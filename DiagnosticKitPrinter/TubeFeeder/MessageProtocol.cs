using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TubeFeeder
{
    public class MessageProtocol
    {
        // | byte[0]      | byte[1]   | byte[2]   | byte[3]   | byte[4]   | byte[5]   | byte[6]
        // | HEADER(0xFA) | CMD       | CMD_SUB   | DATA1     | DATA2     | CheckSum  | TAIL(0xFE)

        public const byte PROTOCOL_MESSAGE_SIZE = 7;
        public const byte PROTOCOL_HEADER    = 0;
        public const byte PROTOCOL_CMD       = 1;
        public const byte PROTOCOL_CMD_SUB   = 2;
        public const byte PROTOCOL_DATA1     = 3;
        public const byte PROTOCOL_DATA2     = 4;
        public const byte PROTOCOL_CHECKSUM  = 5;
        public const byte PROTOCOL_TAIL      = 6;

        // HEADER
        public const byte HEADER = 0xFA;

        // TAIL
        public const byte TAIL = 0xFE;

        // CMD
        public const byte CMD_PING   = (byte)'P';    // 제어장치에게 Ping~     
        public const byte CMD_ORDER  = (byte)'O';    // 제어장치에게 명령함
        public const byte CMD_WRITE  = (byte)'W';    // 제어장치에게 특정 값 저장 요청
        public const byte CMD_READ   = (byte)'R';    // 제어장치에게 특정 값 읽기 요청
        public const byte CMD_INFORM = (byte)'I';    // 제어장치에게 알림

        // CMD_SUB
        public const byte CMD_ORDER_START = (byte)'S';
        public const byte CMD_ORDER_STOP = (byte)'T';

        public const byte CMD_ORDER_START_BARCODE_ON  = 0xF0;
        public const byte CMD_ORDER_START_BARCODE_OFF = 0x0F;
        
        public const byte CMD_ORDER_START_AUTOSTOP_ON  = 0xF0;
        public const byte CMD_ORDER_START_AUTOSTOP_OFF = 0x0F;

        public const byte CMD_WRITE_BELTSPEED = (byte)'B';
        public const byte CMD_READ_BELTSPEED = (byte)'B';    
        
        public const byte CMD_WRITE_XXAISDISTANCE = (byte)'X';
        public const byte CMD_READ_XXAISDISTANCE = (byte)'X';    
        
        public const byte CMD_WRITE_ROLLERSPEED = (byte)'R';
        public const byte CMD_READ_ROLLERSPEED = (byte)'R';    
        
        public const byte CMD_INFORM_SCANNED = (byte)'S';
        public const byte CMD_INFORM_PRINTED = (byte)'P';
        public const byte CMD_INFORM_ACK = (byte)'A';
        public const byte CMD_INFORM_ERROR = (byte)'E';        
        public const byte CMD_INFORM_SETTING_CLOSE = (byte)'C';
        public const byte CMD_INFORM_TRAY = (byte)'T';
        public const byte CMD_INFORM_COLORSENSOR_RESULT = (byte)'R';
        public const byte CMD_INFORM_COLORSENSOR_SUBRESULT = (byte)'C';
        public const byte CMD_INFORM_COLORSENSOR_RAWDATA = (byte)'r';
        public const byte CMD_INFORM_END = (byte)'D';

        // 에러코드
        public const Byte ERRORCODE_SOMETHING_WRONG = 0x01;
        public const Byte ERRORCODE_ANOTHER_WRONG = 0x02;

        public enum ReciveMessage
        {
            noHead,
            noTail,
            ping,
            order,
            order_Start,
            order_Stop,
            inform_Ack,
            inform_BarcodeNoHave,
            inform_Error,
            inform_Tray,
            inform_ColorSensorResult,
            inform_ColorSensorRawData,
            inform_ColorSensorSubResult,
            inform_End,
            write,
            read,
            unknown

        }
    }
}

