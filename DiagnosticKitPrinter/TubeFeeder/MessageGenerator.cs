using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TubeFeeder
{
    class MessageGenerator
    {

        // 제어장치에게 Ping 보냄
        public static byte[] Meesage_Ping()
        {
            byte[] Message = new byte[7];

            Message[MessageProtocol.PROTOCOL_HEADER] = MessageProtocol.HEADER;
            Message[MessageProtocol.PROTOCOL_CMD] = MessageProtocol.CMD_PING;
            Message[MessageProtocol.PROTOCOL_CMD_SUB] = 0x00;
            Message[MessageProtocol.PROTOCOL_DATA1] = 0x00;
            Message[MessageProtocol.PROTOCOL_DATA2] = 0x00;
            Message[MessageProtocol.PROTOCOL_CHECKSUM] = 0;
            for (int i = 0; i < MessageProtocol.PROTOCOL_CHECKSUM; i++)
                Message[MessageProtocol.PROTOCOL_CHECKSUM] ^= Message[i];       // XOR
            Message[MessageProtocol.PROTOCOL_TAIL] = MessageProtocol.TAIL;

            return Message;
        }

        // 제어장치에게 시작 명령
        public static byte[] Meesage_DeviceStart()
        {
            byte[] Message = new byte[7];

            Message[MessageProtocol.PROTOCOL_HEADER] = MessageProtocol.HEADER;
            Message[MessageProtocol.PROTOCOL_CMD] = MessageProtocol.CMD_ORDER;
            Message[MessageProtocol.PROTOCOL_CMD_SUB] = MessageProtocol.CMD_ORDER_START;
            Message[MessageProtocol.PROTOCOL_DATA1] = 0x00;
            Message[MessageProtocol.PROTOCOL_DATA2] = 0x00;
            // if(isBarcodeOnMode)                
            //     Message[MessageProtocol.PROTOCOL_DATA1] = MessageProtocol.CMD_ORDER_START_BARCODE_ON;
            // else
            //     Message[MessageProtocol.PROTOCOL_DATA1] = MessageProtocol.CMD_ORDER_START_BARCODE_OFF;
                
            // if(isAutoStopMode)                
            //     Message[MessageProtocol.PROTOCOL_DATA2] = MessageProtocol.CMD_ORDER_START_AUTOSTOP_ON;
            // else
            //     Message[MessageProtocol.PROTOCOL_DATA2] = MessageProtocol.CMD_ORDER_START_AUTOSTOP_OFF;

            Message[MessageProtocol.PROTOCOL_CHECKSUM] = 0;
            for (int i = 0; i < MessageProtocol.PROTOCOL_CHECKSUM; i++)
                Message[MessageProtocol.PROTOCOL_CHECKSUM] ^= Message[i];       // XOR
            Message[MessageProtocol.PROTOCOL_TAIL] = MessageProtocol.TAIL;

            return Message;
        }
        
        public static byte[] Meesage_DeviceStop()
        {
            byte[] Message = new byte[7];

            Message[MessageProtocol.PROTOCOL_HEADER] = MessageProtocol.HEADER;
            Message[MessageProtocol.PROTOCOL_CMD] = MessageProtocol.CMD_ORDER;
            Message[MessageProtocol.PROTOCOL_CMD_SUB] = MessageProtocol.CMD_ORDER_STOP;
            Message[MessageProtocol.PROTOCOL_DATA1] = 0x00;
            Message[MessageProtocol.PROTOCOL_DATA2] = 0x00;
            Message[MessageProtocol.PROTOCOL_CHECKSUM] = 0;
            for (int i = 0; i < MessageProtocol.PROTOCOL_CHECKSUM; i++)
                Message[MessageProtocol.PROTOCOL_CHECKSUM] ^= Message[i];       // XOR
            Message[MessageProtocol.PROTOCOL_TAIL] = MessageProtocol.TAIL;

            return Message;
        }

        // 제어장치에게 알림
        public static byte[] Meesage_Infom(byte inform)
        {
            byte[] Message = new byte[7];

            Message[MessageProtocol.PROTOCOL_HEADER] = MessageProtocol.HEADER;
            Message[MessageProtocol.PROTOCOL_CMD] = MessageProtocol.CMD_INFORM;
            Message[MessageProtocol.PROTOCOL_CMD_SUB] = inform;
            Message[MessageProtocol.PROTOCOL_DATA1] = 0x00;
            Message[MessageProtocol.PROTOCOL_DATA2] = 0x00;
            Message[MessageProtocol.PROTOCOL_CHECKSUM] = 0;
            for (int i = 0; i < MessageProtocol.PROTOCOL_CHECKSUM; i++)
                Message[MessageProtocol.PROTOCOL_CHECKSUM] ^= Message[i];       // XOR
            Message[MessageProtocol.PROTOCOL_TAIL] = MessageProtocol.TAIL;

            return Message;
        }

        // 제어장치에게 특정 값 쓰기 요청
        public static byte[] Meesage_Write(byte Reg, short data)
        {
            byte[] Message = new byte[7];

            Message[MessageProtocol.PROTOCOL_HEADER] = MessageProtocol.HEADER;
            Message[MessageProtocol.PROTOCOL_CMD] = MessageProtocol.CMD_WRITE;
            Message[MessageProtocol.PROTOCOL_CMD_SUB] = Reg;
            Message[MessageProtocol.PROTOCOL_DATA1] = (byte)(data>>8);
            Message[MessageProtocol.PROTOCOL_DATA2] = (byte)data;
            Message[MessageProtocol.PROTOCOL_CHECKSUM] = 0;
            for (int i = 0; i < MessageProtocol.PROTOCOL_CHECKSUM; i++)
                Message[MessageProtocol.PROTOCOL_CHECKSUM] ^= Message[i];       // XOR
            Message[MessageProtocol.PROTOCOL_TAIL] = MessageProtocol.TAIL;

            return Message;
        }

        // 제어장치에게 특정 값 읽기 요청
        public static byte[] Meesage_Read(byte Reg)
        {
            byte[] Message = new byte[7];

            Message[MessageProtocol.PROTOCOL_HEADER] = MessageProtocol.HEADER;
            Message[MessageProtocol.PROTOCOL_CMD] = MessageProtocol.CMD_READ;
            Message[MessageProtocol.PROTOCOL_CMD_SUB] = Reg;
            Message[MessageProtocol.PROTOCOL_DATA1] = 0x00;
            Message[MessageProtocol.PROTOCOL_DATA2] = 0x00;
            Message[MessageProtocol.PROTOCOL_CHECKSUM] = 0;
            for (int i = 0; i < MessageProtocol.PROTOCOL_CHECKSUM; i++)
                Message[MessageProtocol.PROTOCOL_CHECKSUM] ^= Message[i];       // XOR
            Message[MessageProtocol.PROTOCOL_TAIL] = MessageProtocol.TAIL;

            return Message;
        }


    }
}
