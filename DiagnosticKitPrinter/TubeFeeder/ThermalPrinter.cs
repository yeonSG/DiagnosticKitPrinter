using System;
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
    public class ResultItem { 
    	public string Barcode { get; set; }
        public string Result { get; set; }
        public string SubResult { get; set; }

        public ResultItem(string barcode, string result, string subResult) {
		    Barcode = barcode;
            Result = result;
            SubResult = subResult;
	    }
    }

    public class ResultManager {
        public const string RESULT_POSITIVE = "(P)ositive";
        public const string RESULT_NEGATIVE = "(N)egative";
        public const string RESULT_NG = "N.G.";
        public const string BARCODE_NONE = "NONE";

        public List<ResultItem> resultItems = new List<ResultItem>();
        public string currentBarcode;
        public string currentResult;
        public string currentSubResult;

        public bool setCurrentResult(string result) {
            currentResult = result;
            return addListIfVailid();
        }
        public bool setCurrentSubResult(string subResult) {
            currentSubResult = subResult;
            return addListIfVailid();
        }
        public bool setCurrentBarcode(string barcode) {
            currentBarcode = barcode;
            return addListIfVailid();
        }
        
        public string getLastBarcode() {
            if (resultItems.Count > 0)
                return resultItems[resultItems.Count - 1].Barcode;
            else
                return "";
        }
        public string getLastResult() {
            if (resultItems.Count > 0)
                return resultItems[resultItems.Count-1].Result;
            else
                return "";
        }
        public string getLastSubResult() {
            if (resultItems.Count > 0)
                return resultItems[resultItems.Count-1].SubResult;
            else
                return "";
        }

        public void clear() {
            resultItems.Clear(); 
            currentBarcode = "";
            currentResult = "";
            currentSubResult = "";
        }

        // 유효한지 채크함
        private bool addListIfVailid() {
            if (String.IsNullOrEmpty(currentBarcode) || String.IsNullOrEmpty(currentResult) || String.IsNullOrEmpty(currentSubResult))
                return false;
            
            // ex) list의 마지막 값과 barcode가 갖지않으면 추가함. 
            if (true) {
                resultItems.Add(new ResultItem(currentBarcode, currentResult, currentSubResult));
                currentBarcode = currentResult = currentSubResult = "";
            }
            return true;
        }
    }
    
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
        public String PRINTER_COMPORT = IniFileManager.GetComport_Printer_COM();
        public int COM_BAUDRATE = IniFileManager.GetComport_Printer_BaudRate();
        public const int COM_DATABITS = 8;
        public const Parity COM_PARITY = Parity.None;
        public const StopBits COM_STOPBITS = StopBits.One;

        private SetTextCallback logFunctionCallback = null;

        private SerialPort m_serialPort = null;
        private MessageReciver m_messageReciver = null;

        public static PrinterState m_state = PrinterState.UNKNOWN;


        public void sendTestMessage_resultType()
        {
            byte[] testByte;
            SendMessage(ThermalPrinterCommand.CMD_FONT_X1);
            testByte = ThermalPrinterCommand.stringToByteArray("**********************************");
            SendMessage(testByte);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            testByte = ThermalPrinterCommand.stringToByteArray("Date\t\t : " + DateTime.Now.ToString("yyyy/MM/dd"));
            SendMessage(testByte);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            testByte = ThermalPrinterCommand.stringToByteArray("Time\t\t : " + String.Format("{0,2:N0}:{1,2:N0}:{2,2:N0}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second));
            SendMessage(testByte);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            testByte = ThermalPrinterCommand.stringToByteArray("Barcode\t\t : 123456789");
            SendMessage(testByte);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            testByte = ThermalPrinterCommand.stringToByteArray("Result\t\t : (P)ositive");
            SendMessage(testByte);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CUT_PART);
            
        }

        public void sendTestMessage()
        {
            byte[] testByte;
            testByte = ThermalPrinterCommand.stringToByteArray("***** *****");
            SendMessage(testByte);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_FONT_X2);
            testByte = ThermalPrinterCommand.stringToByteArray("한글Test..");
            SendMessage(testByte);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
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
            msg = ThermalPrinterCommand.concatArray(msg, ThermalPrinterCommand.CMD_CRLF);
            msg = ThermalPrinterCommand.concatArray(msg, ThermalPrinterCommand.CMD_CRLF);
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

        public ThermalPrinter(SerialPort serialPort, SetTextCallback logFunction)
        {
            this.m_serialPort = serialPort;
            this.logFunctionCallback = logFunction;
            this.m_messageReciver = new MessageReciver(logFunction);

            Init();
            
        }

        private void Init()
        {
            m_serialPort.PortName = PRINTER_COMPORT;
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

        public void PrintResult(List<ResultItem> resultArr) {
            
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_FONT_X2);
            for (int i=0; i<resultArr.Count; i++) {
                byte[] value = ThermalPrinterCommand.stringToByteArray(resultArr[i].Barcode);
                value = ThermalPrinterCommand.concatArray(value, ThermalPrinterCommand.stringToByteArray(" ... "));
                value = ThermalPrinterCommand.concatArray(value, ThermalPrinterCommand.stringToByteArray(resultArr[i].Result));
                SendMessage(value);
                SendMessage(ThermalPrinterCommand.CMD_CRLF);
            }
            SendMessage(ThermalPrinterCommand.CMD_CRLF);    // 이부분 조절바람
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CUT_PART);
        }

        public void PrintResult(string barcode, string result, string subResult)
        {
            byte[] testByte;
            SendMessage(ThermalPrinterCommand.CMD_FONT_X1);
            testByte = ThermalPrinterCommand.stringToByteArray("**********************************");
            SendMessage(testByte);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            testByte = ThermalPrinterCommand.stringToByteArray("Date\t\t : " + DateTime.Now.ToString("yyyy/MM/dd"));
            SendMessage(testByte);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            testByte = ThermalPrinterCommand.stringToByteArray("Time\t\t : " + String.Format("{0,2:N0}:{1,2:N0}:{2,2:N0}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second));
            SendMessage(testByte);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            testByte = ThermalPrinterCommand.stringToByteArray("Barcode\t\t : " + barcode);
            SendMessage(testByte);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            testByte = ThermalPrinterCommand.stringToByteArray("T\t\t : " + result); // (P)ositive | (N)egative | N.G | RawData
            SendMessage(testByte);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            testByte = ThermalPrinterCommand.stringToByteArray("C\t\t : " + subResult); 
            SendMessage(testByte);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            testByte = ThermalPrinterCommand.stringToByteArray("**********************************");
            SendMessage(testByte);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);   
            cutPaper();
        }

        public void cutPaper() {
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CRLF);
            SendMessage(ThermalPrinterCommand.CMD_CUT_PART);
        }
    }
}
