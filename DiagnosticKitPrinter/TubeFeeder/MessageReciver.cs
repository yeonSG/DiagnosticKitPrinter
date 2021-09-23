using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TubeFeeder
{
    class MessageReciver
    {
        private SetTextCallback LogFunction = null;

        private byte[] message = null;

        public MessageReciver(SetTextCallback LogFunction)
        {
            this.LogFunction = LogFunction;
        }

        public void setMesage(byte[] message)
        {
            this.message = message;
        }

        public MessageProtocol.ReciveMessage messageProcessing(byte[] message)
        {
            setMesage(message);
            return messageProcessing();
        }

        // message를 해석함
        public MessageProtocol.ReciveMessage messageProcessing()
        {
            if (message[MessageProtocol.PROTOCOL_HEADER] != MessageProtocol.HEADER)
            {
                LogFunction("Recived : Header Invaild!");
                return MessageProtocol.ReciveMessage.noHead;
            }
            if (message[MessageProtocol.PROTOCOL_TAIL] != MessageProtocol.TAIL)
            {
                LogFunction("Recived : Tail Invaild!");
                return MessageProtocol.ReciveMessage.noTail;
            }

            switch (message[MessageProtocol.PROTOCOL_CMD])
            {
                case MessageProtocol.CMD_PING:
                    ControlBoard.m_controlBoardConnected = true;        // 또는 콜백함수
                    LogFunction("Recived : Ping");
                    return MessageProtocol.ReciveMessage.ping;

                case MessageProtocol.CMD_ORDER:
                    LogFunction("Recived : Order");
                    {
                        switch (message[MessageProtocol.PROTOCOL_CMD_SUB])
                        {
                            case MessageProtocol.CMD_ORDER_START:
                                LogFunction("Recived : Order_Start");
                                return MessageProtocol.ReciveMessage.order_Start;
                            case MessageProtocol.CMD_ORDER_STOP:
                                LogFunction("Recived : Order_Stop");
                                return MessageProtocol.ReciveMessage.order_Stop;
                        }

                    }
                    return MessageProtocol.ReciveMessage.order;

                case MessageProtocol.CMD_INFORM:
                    {
                        switch (message[MessageProtocol.PROTOCOL_CMD_SUB])
                        {
                            case MessageProtocol.CMD_INFORM_ACK:
                                LogFunction("Recived : Inform_Ack");
                                return MessageProtocol.ReciveMessage.inform_Ack;
                            case MessageProtocol.CMD_INFORM_SCANNED:
                                LogFunction("Recived : Inform_scaned");
                                return MessageProtocol.ReciveMessage.inform_Scanned;
                            case MessageProtocol.CMD_INFORM_ERROR:
                                // 에러코드 별로 처리 필요
                                LogFunction("Recived : Inform_Error");
                                return MessageProtocol.ReciveMessage.inform_Error;
                            case MessageProtocol.CMD_INFORM_TRAY:
                                return MessageProtocol.ReciveMessage.inform_Tray;
                            case MessageProtocol.CMD_INFORM_COLORSENSOR_RESULT:
                                return MessageProtocol.ReciveMessage.inform_ColorSensorResult;
                            case MessageProtocol.CMD_INFORM_COLORSENSOR_RAWDATA:
                                return MessageProtocol.ReciveMessage.inform_ColorSensorRawData;
                            case MessageProtocol.CMD_INFORM_END:
                                return MessageProtocol.ReciveMessage.inform_End;
                        }
                    }
                    break;

                case MessageProtocol.CMD_WRITE:
                    LogFunction("Recived : Write");
                    return MessageProtocol.ReciveMessage.write;

                case MessageProtocol.CMD_READ:
                    LogFunction("Recived : Read");
                    return MessageProtocol.ReciveMessage.read;
            }

            return MessageProtocol.ReciveMessage.unknown;

        }

    }
}
