﻿using System;
using System.IO.Ports;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TubeFeeder
{
    /* 써멀 프린터에 대한 구현
     * - Comport 연결관련 구현
     * - Message 프로토콜과 처리 관련된 구현
     */
    
    public enum PrinterState
    {
        UNKNOWN,        // 프로그램 시작 시 디폴트 상태
        READY,          // Comport 연결이 확인되고 아무것도 안하고 있는 상태
        WORKING,        // Feeding 동작을 하고 있는 상태
        WAIT_FOR_BARCODE_TO_READ,   // Feeding 동작 중 바코드 읽기를 기다리고 있는 상태
        ERROR_JAM       // 재밍 에러가 난 상태
    }
    
    public class ThermalPrinter
    {
        /* 컴포트 설정 */
        public String CONTROLBOARD_COMPORT = IniFileManager.GetComport_Printer_COM();
        public int COM_BAUDRATE = IniFileManager.GetComport_Printer_BaudRate();
        public const int COM_DATABITS = 8;
        public const Parity COM_PARITY = Parity.None;
        public const StopBits COM_STOPBITS = StopBits.One;

        private SetTextCallback logFunctionCallback = null;
        private ReciveMsgCallback reciveMsgCallback = null;

        private SerialPort m_serialPort = null;
        private MessageReciver m_messageReciver = null;

        public static PrinterState m_state = PrinterState.UNKNOWN;

        public void sendTestMessage()
        {
            SendMessage(ThermalPrinterCommand.CMD_FONT_X2);
            byte[] testByte = ThermalPrinterCommand.stringToByteArray("한글");
            SendMessage(testByte);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CUT_PART);

            // for log
            byte[] msg = { 0x00, 0x00 };
            msg = ThermalPrinterCommand.concatArray(msg, ThermalPrinterCommand.CMD_FONT_X2);
            msg = ThermalPrinterCommand.concatArray(msg, testByte);
            msg = ThermalPrinterCommand.concatArray(msg, ThermalPrinterCommand.CMD_CRLF);
            msg = ThermalPrinterCommand.concatArray(msg, ThermalPrinterCommand.CMD_CRLF);
            msg = ThermalPrinterCommand.concatArray(msg, ThermalPrinterCommand.CMD_CUT_PART);
            string sendString = "[TX] ";
            for (int i = 0; i < msg.Length; i++)
            {
                sendString += msg[i].ToString("X2") + " ";
            }
            logFunctionCallback(sendString);

            // SmartX.SmartFile m_smartFile = m_smartFile = new SmartX.SmartFile();

            // m_smartFile.FilePathName = "\\Flash Disk\\ErrorLog.txt";
            // if (m_smartFile.Open() == true)
            // {
            //     m_smartFile.WriteString(sendString);
            //     m_smartFile.Close();
            // }
            System.Windows.Forms.MessageBox.Show(sendString);
        }

        public ThermalPrinter(SerialPort serialPort, SetTextCallback logFunction, ReciveMsgCallback reciveFunction)
        {
            this.m_serialPort = serialPort;
            this.logFunctionCallback = logFunction;
            this.reciveMsgCallback = reciveFunction;
            this.m_messageReciver = new MessageReciver(logFunction);

            Init();
            
        }

        private void Init()
        {
            m_serialPort.PortName = CONTROLBOARD_COMPORT;
            m_serialPort.BaudRate = COM_BAUDRATE;
            m_serialPort.DataBits = COM_DATABITS;
            m_serialPort.Parity = COM_PARITY;
            m_serialPort.StopBits = COM_STOPBITS;

            Open();
        }

        public bool Open()
        {
            try
            {
                m_serialPort.Open();
                logFunctionCallback("Port "+ m_serialPort.PortName +" is Opend.");
            }
            catch
            {
                logFunctionCallback("Port is already using.");
                return false;
            }
            return true;
        }

        public bool isOpen()
        {
            return m_serialPort.IsOpen;
        }

        public bool SendMessage(byte[] msg)
        {
            if (isOpen() == false)
                return false;

            try
            {
                //m_serialPort.Write(msg, 0, msg.Length);
                
                //if(doDelay==true)
                //    Thread.Sleep(100);

                int sendSize = msg.Length;

                //serialPort1.Write(data, 0, sendSize);
                for (int i = 0; i < sendSize; i++ )
                {
                    Wait.Start(10);      // MicroSec Sleep
                    m_serialPort.Write(msg, i, 1);      // 1개씩 보냄
                }
                 
                string sendString = "[TX] ";
                for (int i = 0; i < sendSize; i++)
                {
                    sendString += msg[i].ToString("X2") + " ";
                }
                logFunctionCallback(sendString);

            }
            catch
            {
                logFunctionCallback("Error at SendMessage()");
                return false;
            }
            return true;
        }
    }
}