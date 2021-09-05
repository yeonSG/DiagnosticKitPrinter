using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TubeFeeder
{
    public delegate void SetCallback();
    public delegate void SetTextCallback(string Text);
    public delegate void SetBoolCallback(bool boolean);
    public delegate void SetColorCallback(Color Color);

    public delegate void ReciveMsgCallback(MessageProtocol.ReciveMessage message);

    public partial class Form1 : Form
    {
        [DllImport("CoreDll.dll")]
        public static extern void MessageBeep(int code);

        [DllImport("HwaUSB.dll")]
        public static extern int UsbOpen(string selPrinter);        // int or long 시스템 따라서 ..

        ScanLogFileManager m_ScanLogFileManager = new ScanLogFileManager();
        ControlBoard m_ControlBoard = null;

        private string m_inputBuffer = "";
        private string m_insertedItem = "";

        private DateTime m_runTime = DateTime.Now;
        private UInt32 m_scanCount = 0;

        private bool m_debugMode = false;   // 디버그모드

        private bool m_isRecivedFromCom = false;
        private bool m_isOnError = false;
        private bool m_isBarcodeReadMode_On = true; // 바코드 읽기모드 On
        private bool m_isAutoStopMode_On = true; // AutoStopMode On

        private SettingValues m_settingValues;

        private Queue<byte> reciveQueue = new Queue<byte>();

        public Form1()
        {
            InitializeComponent();

            SetTextCallback logCallback = new SetTextCallback(AddLog_d);
            ReciveMsgCallback msgRecivCallback = new ReciveMsgCallback(msgRecive);
            m_ControlBoard = new ControlBoard(serialPort1, logCallback, msgRecivCallback);

            // ModeInit();
            ModeInit();

            //SettingInit();
            SettingInit();


            smartTimer1.Interval = 1000;    // 1000msec
            smartTimer1.Start();
            smartTimer2.Interval = 1000;    // 1000msec
            smartTimer2.Start();
        }

        private void ModeInit()
        {
        }

        private void SettingInit()
        {
            m_settingValues = new SettingValues();
            m_settingValues.value_conveyorSpeed = IniFileManager.GetSetting_ConveyerSpeed();
            m_settingValues.value_XAxisDistance = IniFileManager.GetSetting_XXaisDistance();
            m_settingValues.value_ConvererRollerSpeed = IniFileManager.GetSetting_ConverterRollerSpeed();

            // set for machine
            //SendSettingValues(settingValues);
        }

        private void SendSettingValues(SettingValues valueData)
        {
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_Write(MessageProtocol.CMD_WRITE_BELTSPEED, (short)valueData.value_conveyorSpeed));
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_Write(MessageProtocol.CMD_WRITE_XXAISDISTANCE, (short)valueData.value_XAxisDistance));
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_Write(MessageProtocol.CMD_WRITE_ROLLERSPEED, (short)valueData.value_ConvererRollerSpeed));
        }

        private void AppendInputBuffer(string key)
        {
            m_inputBuffer += key;
        }
        private void ClearInputBuffer()
        {
            m_inputBuffer = "";
        }
        private void InsertBufferStrToLogFile()
        {
            m_insertedItem = m_inputBuffer;

            AddLog(m_insertedItem);   

            if (m_ScanLogFileManager.WriteValue(m_insertedItem) == false)
                ErrorInfo("로그파일 쓰기 error");
            
            ClearInputBuffer();
            
        }

        private void AddLog(string value)
        {
            ;
        }

        private void AddLog_d(string value)
        {
            if (m_debugMode != true)
                return;
                
            {
                AddLog(value);
            }
        }

        private string getBaudrateString(System.IO.Ports.SerialPort serialPort) 
        {
            return Convert.ToString(serialPort.BaudRate);
        }
        private string getDatabitsString(System.IO.Ports.SerialPort serialPort)
        {
            return Convert.ToString(serialPort.DataBits);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                //MessageBox.Show("enter");// Enter key pressed

                if (m_inputBuffer == "")
                    return;


                if (m_inputBuffer.Equals(m_insertedItem) == true)
                {
                    // AddLog("(duplicated) " + m_insertedItem);   
                    ClearInputBuffer();
                    return; //  Do not action, When Duplicated before Input value. (중복시 아무것도 하지 않음
                }
                else
                {
                    m_scanCount++;
                    m_ControlBoard.SendMessage(MessageGenerator.Meesage_Infom(MessageProtocol.CMD_INFORM_SCANNED));
                    InsertBufferStrToLogFile();
                }
            }
            else
            {
                AppendInputBuffer(e.KeyChar.ToString());
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //SmartX.SmartMessageBox.Show(e.ToString());
            //MessageBox.Show(e.KeyChar.ToString());
            //** 엔터를 여기서 받으려면 포커스가 엔터이벤트를 받지 않는 포커스에 있어야 함(추측임)(버튼같은?)
        }

        private void ErrorInfo(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

        // comport로 메시지 수신함
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (m_ControlBoard.isOpen())
            {
                int recSize = serialPort1.BytesToRead;
                string recString;

                if(recSize != 0)
                {
                    m_isRecivedFromCom = true;
                    recString = "[RX] ";
                    byte[] buff = new byte[recSize];

                    serialPort1.Read(buff, 0, recSize);
                    for (int i = 0; i < recSize; i++)
                    {
                        recString += buff[i].ToString("X2") + " ";

                        reciveQueue.Enqueue(buff[i]);
                    }
                    AddLog_d(recString);

                    // 큐의 첫번째것이 HEADER일때까지 버림
                    while (reciveQueue.Count != 0)
                    {
                        if (reciveQueue.Peek() == MessageProtocol.HEADER)
                            break;
                        else
                            reciveQueue.Dequeue();
                    }

                    // 큐의 아이템이 7이상이어야 함
                    while(reciveQueue.Count >= MessageProtocol.PROTOCOL_MESSAGE_SIZE)
                    {
                        List<byte> message = new List<byte>();
                        for (int i = 0; i < MessageProtocol.PROTOCOL_MESSAGE_SIZE; i++)
                        {
                            if (i != 0 && reciveQueue.Peek() == MessageProtocol.HEADER) // 인덱스0이 헤더가 아니면 거기서부터 다시
                            {
                                // Console.Write("broken Message!");
                                break;
                            }
                            if (i==6 && reciveQueue.Peek() != MessageProtocol.TAIL) // 테일에러
                            {
                                // Console.Write("broken Message!");
                                break;
                            }
                            else
                                message.Add(reciveQueue.Dequeue());
                        }

                        if (message.Count == MessageProtocol.PROTOCOL_MESSAGE_SIZE)
                        {
                            if (message[6] != MessageProtocol.TAIL) // 테일에러
                            {
                                Console.Write("broken Message! - tail");
                                continue;
                            }
                            
                            byte[] myArryByte = message.ToArray();
                            m_ControlBoard.ProcessMessage(myArryByte);
                        }
                    }
                }
            }
        }

        private void SendPing()
        {
            m_ControlBoard.SendMessage( MessageGenerator.Meesage_Ping() );
        }

        private void buttonTest1_Click(object sender, EventArgs e)
        {
            AddLog_d("send");
            SendPing();
        }

        private void buttonTest2_Click(object sender, EventArgs e)
        {
            long ret = UsbOpen("HMK-054");
            // Printer.UsbClose();
            long zero = 0;
            long minus3 = -3;

            MessageBox.Show(ret.ToString("X4"));

            /*
            PasswordForm pwFrom = new PasswordForm();
            DialogResult pwResult = pwFrom.ShowDialog();
            if (pwResult == DialogResult.OK)
            {
                OptionSettingRuttin();
                // 저장 메시지 전송함
            }
            else if (pwResult == DialogResult.No)
            {
                MessageBox.Show("password fail");
            }
            else if (pwResult == DialogResult.Cancel)
            {
                ;   // nothing do 
            }
             * */
        }

        private void OptionSettingRuttin()
        {
            DialogForm dialog = new DialogForm(m_ControlBoard ,m_settingValues);
            DialogResult dr = dialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                //MessageBox.Show(settingData.value_conveyorSpeed + " "
                //    + settingData.value_XAxisDistance
                //    + settingData.value_ConvererRollerSpeed);

                // initFile에 저장
                IniFileManager.SetSetting_ConveyerSpeed(m_settingValues.value_conveyorSpeed);
                IniFileManager.SetSetting_XXaisDistance(m_settingValues.value_XAxisDistance);
                IniFileManager.SetSetting_ConverterRollerSpeed(m_settingValues.value_ConvererRollerSpeed);

                // 저장메시지 전송
                // SendSettingValues(settingData);
                
            }
            else if (dr == DialogResult.Cancel)
            {
                ;
            }
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_Infom(MessageProtocol.CMD_INFORM_SETTING_CLOSE));
            
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Application.Exit();
            SendSettingValues(m_settingValues);     // setting값 보냄

            m_ControlBoard.SendMessage(MessageGenerator.Meesage_DeviceStart(m_isBarcodeReadMode_On, m_isAutoStopMode_On));
            setIndicatorColor(Color.Green);
            m_isOnError = false;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_DeviceStop());
            
            m_isOnError = false;
            doStop();
        }
        private void doStop()
        {
            setIndicatorColor(Color.Gray);
        }


        private void setIndicatorColor(Color color)
        {
            if (this.label_indicator.InvokeRequired)
            {
                SetColorCallback dp = new SetColorCallback(setIndicatorColor);
                this.Invoke(dp, new object[] { color });
            }
            else
            {
                label_indicator.BackColor = color;
            }
        }
        
        public void msgRecive(MessageProtocol.ReciveMessage reciveMsg)
        {
            switch (reciveMsg)
            {
                case MessageProtocol.ReciveMessage.unknown:
                    break;
                case MessageProtocol.ReciveMessage.inform_Error:
                    m_isOnError = true;
                    break;
                case MessageProtocol.ReciveMessage.order_Start:
                    break;
                case MessageProtocol.ReciveMessage.order_Stop:
                    btnStop_buttonDown();
                    btnStart_buttonUp();
                    doStop();
                    break;
                default:
                    break;

            }
        }

        public void btnStart_buttonUp()
        {
            if (this.btn_start.InvokeRequired)
            {
                SetCallback dp = new SetCallback(btnStart_buttonUp);
                this.Invoke(dp, new object[] { });
            }
            else
            {
                btn_start.ButtonUp();
            }

        }
        public void btnStop_buttonDown()
        {
            if (this.btn_stop.InvokeRequired)
            {
                SetCallback dp = new SetCallback(btnStop_buttonDown);
                this.Invoke(dp, new object[] { });
            }
            else
            {
                btn_stop.ButtonDown();
            }
        }


        private void setComponentToStartedState(bool isStarted)    // start 도중 건들면 안되는 컴포넌트들 disable 용도
        {

            if (isStarted)  // 시작상태일때
            {
                // start버튼 disable
                // stop버튼 enable
                // 라디오버튼 disable
            }
            else
            {
                // start버튼 enable
                // stop버튼 disable
                // 라디오버튼 enable
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void smartTimer1_Tick(object sender, EventArgs e)
        {
            TimeSpan runTime = DateTime.Now.Subtract(m_runTime);
            string strRunTime = runTime.Days + "일 " + runTime.Hours + "시간 " + runTime.Minutes + "분 " + runTime.Seconds + "초";
            string strCurTime = DateTime.Now.ToLongTimeString();

            if(m_isOnError==true)
            {
                MessageBeep(64);
                if (label_indicator.BackColor == Color.Red) // 1초간격 점멸 
                {
                    setIndicatorColor(Color.Black);
                }
                else
                {
                    setIndicatorColor(Color.Red);

                }
            }
            if (btn_start.ButtonStatus == SmartX.SmartButton.BUTSTATUS.DOWN)
            {
                if (m_isRecivedFromCom == true)
                {
                    setIndicatorColor(Color.Lime);
                    m_isRecivedFromCom = false;
                }
                else
                {
                    setIndicatorColor(Color.Green);
                }
            }
        }

        private void smartTimer2_Tick(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////
            //                                                            //
            // SmartUpdate 관련 설정 사항은 폼디자인 모드에서 SmartUpdate //
            // 의 속성 값을 확인 하시기 바라며 또한 속성값 변경을 속성창  //
            // 에서 직접 하셔도 됩니다. 본 예제에서는 속성 값을 따로 코드 //
            // 로 정의 하지 않고 속성창 에서 설정 하였습니다.             //
            //                                                            //
            ////////////////////////////////////////////////////////////////


            // 현재 응용프로그램이 종료된후 업데이트 모듈이 업데이트를 시작하기까지의 지연 시간을 설정 함
            // 응용프로그램의 용량등(프로그램 복잡도)에 따라서 종료되는 지연시간을 감안 하여 시간을
            // 충분한 값으로 설정 하시기 바랍니다. 단위 ms
            smartUpdate1.SetStartInterval = 3000;  // 3초

            // Update File을 확인 하며 업데이트 할 파일이 있을경우 업데이트 시작
            // 리턴값 : 업데이트 할 파일이 있는경우 True, 업데이트 할 파일이 없는경우 False
            if (smartUpdate1.Start() == true)
            {
                // ※※※[중요] 업데이트 할 파일이 있을경우 반드시 현재 응용프로그램을 종료 해야 합니다.!!! [중요]※※※
                Application.Exit();
            }
        }
        // Ping
        // Value Write
        // Value Read
        // Start
        // Sttop
        
    }
}
