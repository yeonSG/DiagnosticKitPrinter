namespace TubeFeeder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.smartForm1 = new SmartX.SmartForm();
            this.label_indicator = new SmartX.SmartLabel();
            this.smartTimer1 = new SmartX.SmartTimer(this.components);
            this.btn_Exit = new SmartX.SmartButton();
            this.btn_logo_BIONIT = new SmartX.SmartButton();
            this.smartUpdate1 = new SmartX.SmartUpdate(this.components);
            this.smartTimer2 = new SmartX.SmartTimer(this.components);
            this.smartLabel_VERSION = new SmartX.SmartLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_tray1 = new SmartX.SmartCheckBox();
            this.smartLabel1 = new SmartX.SmartLabel();
            this.btn_tray2 = new SmartX.SmartCheckBox();
            this.btn_tray3 = new SmartX.SmartCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.btn_stop = new SmartX.SmartButton();
            this.btn_start = new SmartX.SmartButton();
            this.btn_Test1 = new SmartX.SmartButton();
            this.btn_Test2 = new SmartX.SmartButton();
            this.btn_Test3 = new SmartX.SmartButton();
            ((System.ComponentModel.ISupportInitialize)(this.smartForm1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // smartForm1
            // 
            this.smartForm1.CenterLocation = false;
            this.smartForm1.LCDDirection = SmartX.SmartForm.LCDDIRECTIONS.HORIZONTAL;
            this.smartForm1.LCDSize = SmartX.SmartForm.LCDRESOLUTION.LCD480X272;
            this.smartForm1.Location = new System.Drawing.Point(0, 0);
            this.smartForm1.MainForm = null;
            this.smartForm1.Mode = SmartX.SmartForm.RUNMODE.RUNTIME;
            this.smartForm1.MouseCursor = SmartX.SmartForm.OnOff.OFF;
            this.smartForm1.Name = "smartForm1";
            this.smartForm1.Size = new System.Drawing.Size(480, 272);
            this.smartForm1.SpecialFunctionClickPointSize = 100;
            this.smartForm1.SuspendLayoutInterval = 1;
            // 
            // label_indicator
            // 
            this.label_indicator.BackColor = System.Drawing.Color.Gray;
            this.label_indicator.BackPictureBox = null;
            this.label_indicator.BackPictureBox1 = null;
            this.label_indicator.BackPictureBox2 = null;
            this.label_indicator.BorderColor = System.Drawing.Color.Black;
            this.label_indicator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_indicator.InitVisible = true;
            this.label_indicator.LineSpacing = 0F;
            this.label_indicator.Location = new System.Drawing.Point(346, 42);
            this.label_indicator.Name = "label_indicator";
            this.label_indicator.Size = new System.Drawing.Size(25, 31);
            this.label_indicator.TabIndex = 61;
            this.label_indicator.TextHAlign = SmartX.SmartLabel.TextHorAlign.Left;
            this.label_indicator.TextVAlign = SmartX.SmartLabel.TextVerAlign.Top;
            this.label_indicator.Wordwrap = false;
            // 
            // smartTimer1
            // 
            this.smartTimer1.EndTime = ((long)(100000000000));
            this.smartTimer1.Interval = 100;
            this.smartTimer1.IntervalSeries = null;
            this.smartTimer1.NowMillisecond = ((long)(0));
            this.smartTimer1.StartTime = ((long)(0));
            this.smartTimer1.Tick += new System.EventHandler(this.smartTimer1_Tick);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackPictureBox = null;
            this.btn_Exit.BackPictureBox1 = null;
            this.btn_Exit.BackPictureBox2 = null;
            this.btn_Exit.ButtonColor = System.Drawing.Color.Gray;
            this.btn_Exit.ButtonImageAutoSize = true;
            this.btn_Exit.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_Exit.DisableImage = null;
            this.btn_Exit.DownImage = null;
            this.btn_Exit.GroupID = 0;
            this.btn_Exit.InitVisible = true;
            this.btn_Exit.Location = new System.Drawing.Point(395, 201);
            this.btn_Exit.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.NestedClickEventPrevent = false;
            this.btn_Exit.OutlinePixel = 1;
            this.btn_Exit.RepeatInterval = 200;
            this.btn_Exit.RepeatIntervalAccelerate = null;
            this.btn_Exit.SafeInterval = 200;
            this.btn_Exit.Size = new System.Drawing.Size(85, 29);
            this.btn_Exit.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_Exit.TabIndex = 73;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.TextColor = System.Drawing.Color.Black;
            this.btn_Exit.TextDownColor = System.Drawing.Color.White;
            this.btn_Exit.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_Exit.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_Exit.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_Exit.UpImage = null;
            this.btn_Exit.Visible = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_logo_BIONIT
            // 
            this.btn_logo_BIONIT.BackPictureBox = null;
            this.btn_logo_BIONIT.BackPictureBox1 = null;
            this.btn_logo_BIONIT.BackPictureBox2 = null;
            this.btn_logo_BIONIT.ButtonColor = System.Drawing.Color.Gray;
            this.btn_logo_BIONIT.ButtonImageAutoSize = true;
            this.btn_logo_BIONIT.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_logo_BIONIT.DisableImage = ((System.Drawing.Image)(resources.GetObject("btn_logo_BIONIT.DisableImage")));
            this.btn_logo_BIONIT.DownImage = null;
            this.btn_logo_BIONIT.Enabled = false;
            this.btn_logo_BIONIT.GroupID = 0;
            this.btn_logo_BIONIT.InitVisible = true;
            this.btn_logo_BIONIT.Location = new System.Drawing.Point(382, 236);
            this.btn_logo_BIONIT.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.btn_logo_BIONIT.Name = "btn_logo_BIONIT";
            this.btn_logo_BIONIT.NestedClickEventPrevent = false;
            this.btn_logo_BIONIT.OutlinePixel = 1;
            this.btn_logo_BIONIT.RepeatInterval = 200;
            this.btn_logo_BIONIT.RepeatIntervalAccelerate = null;
            this.btn_logo_BIONIT.SafeInterval = 200;
            this.btn_logo_BIONIT.Size = new System.Drawing.Size(95, 32);
            this.btn_logo_BIONIT.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_logo_BIONIT.TabIndex = 89;
            this.btn_logo_BIONIT.TextColor = System.Drawing.Color.Black;
            this.btn_logo_BIONIT.TextDownColor = System.Drawing.Color.White;
            this.btn_logo_BIONIT.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_logo_BIONIT.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_logo_BIONIT.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_logo_BIONIT.UpImage = ((System.Drawing.Image)(resources.GetObject("btn_logo_BIONIT.UpImage")));
            // 
            // smartUpdate1
            // 
            this.smartUpdate1.BackImageFilePathName = null;
            this.smartUpdate1.CompanyText = "BIONIT Co.";
            this.smartUpdate1.CompanyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.smartUpdate1.FromFilePath = "하드 디스크\\UpdateFiles";
            this.smartUpdate1.MessageText = "응용프로그램을 업데이트 하고 있습니다. 잠시만 기다려 주시기 바랍니다....!!!";
            this.smartUpdate1.MessageTextColor = System.Drawing.Color.Blue;
            this.smartUpdate1.Restart = SmartX.SmartUpdate.RESTARTFLAG.REBOOTING;
            this.smartUpdate1.SetStartInterval = ((uint)(3000u));
            this.smartUpdate1.TitleText = "[[[ DiagnosticKitPrinter Update ]]]";
            this.smartUpdate1.TitleTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.smartUpdate1.ToFilePath = "Flash Disk\\Run";
            // 
            // smartTimer2
            // 
            this.smartTimer2.EndTime = ((long)(100000000000));
            this.smartTimer2.Interval = 100;
            this.smartTimer2.IntervalSeries = null;
            this.smartTimer2.NowMillisecond = ((long)(0));
            this.smartTimer2.StartTime = ((long)(0));
            this.smartTimer2.Tick += new System.EventHandler(this.smartTimer2_Tick);
            // 
            // smartLabel_VERSION
            // 
            this.smartLabel_VERSION.BackColor = System.Drawing.Color.Silver;
            this.smartLabel_VERSION.BackPictureBox = null;
            this.smartLabel_VERSION.BackPictureBox1 = null;
            this.smartLabel_VERSION.BackPictureBox2 = null;
            this.smartLabel_VERSION.BorderColor = System.Drawing.Color.Transparent;
            this.smartLabel_VERSION.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smartLabel_VERSION.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.smartLabel_VERSION.InitVisible = true;
            this.smartLabel_VERSION.LineSpacing = 0F;
            this.smartLabel_VERSION.Location = new System.Drawing.Point(319, 250);
            this.smartLabel_VERSION.Name = "smartLabel_VERSION";
            this.smartLabel_VERSION.Size = new System.Drawing.Size(56, 18);
            this.smartLabel_VERSION.TabIndex = 90;
            this.smartLabel_VERSION.Text = "ver 1.3";
            this.smartLabel_VERSION.TextHAlign = SmartX.SmartLabel.TextHorAlign.Left;
            this.smartLabel_VERSION.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.smartLabel_VERSION.Wordwrap = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(322, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 134);
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_tray1
            // 
            this.btn_tray1.BackColor = System.Drawing.Color.Gray;
            this.btn_tray1.BackPictureBox = null;
            this.btn_tray1.BackPictureBox1 = null;
            this.btn_tray1.BackPictureBox2 = null;
            this.btn_tray1.CheckBoxBackColor = System.Drawing.Color.White;
            this.btn_tray1.CheckBoxCheckColor = System.Drawing.Color.Green;
            this.btn_tray1.CheckBoxForeColor = System.Drawing.Color.Black;
            this.btn_tray1.CheckBoxSymbolSize = 14;
            this.btn_tray1.Checked = false;
            this.btn_tray1.CheckLineWidth = 3;
            this.btn_tray1.Enabled = false;
            this.btn_tray1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btn_tray1.ImageCheckBox = ((System.Drawing.Image)(resources.GetObject("btn_tray1.ImageCheckBox")));
            this.btn_tray1.ImageUnCheckBox = ((System.Drawing.Image)(resources.GetObject("btn_tray1.ImageUnCheckBox")));
            this.btn_tray1.InitVisible = true;
            this.btn_tray1.Location = new System.Drawing.Point(340, 41);
            this.btn_tray1.Name = "btn_tray1";
            this.btn_tray1.Size = new System.Drawing.Size(103, 34);
            this.btn_tray1.TabIndex = 97;
            this.btn_tray1.Text = "서랍1";
            this.btn_tray1.TextVAlign = SmartX.SmartCheckBox.TextVerAlign.Middle;
            // 
            // smartLabel1
            // 
            this.smartLabel1.BackColor = System.Drawing.Color.Gray;
            this.smartLabel1.BackPictureBox = null;
            this.smartLabel1.BackPictureBox1 = null;
            this.smartLabel1.BackPictureBox2 = null;
            this.smartLabel1.BorderColor = System.Drawing.Color.Transparent;
            this.smartLabel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smartLabel1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.InitVisible = true;
            this.smartLabel1.LineSpacing = 0F;
            this.smartLabel1.Location = new System.Drawing.Point(358, 15);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(84, 29);
            this.smartLabel1.TabIndex = 99;
            this.smartLabel1.Text = "서랍 상태";
            this.smartLabel1.TextHAlign = SmartX.SmartLabel.TextHorAlign.Left;
            this.smartLabel1.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.smartLabel1.Wordwrap = false;
            // 
            // btn_tray2
            // 
            this.btn_tray2.BackColor = System.Drawing.Color.Gray;
            this.btn_tray2.BackPictureBox = null;
            this.btn_tray2.BackPictureBox1 = null;
            this.btn_tray2.BackPictureBox2 = null;
            this.btn_tray2.CheckBoxBackColor = System.Drawing.Color.White;
            this.btn_tray2.CheckBoxCheckColor = System.Drawing.Color.Green;
            this.btn_tray2.CheckBoxForeColor = System.Drawing.Color.Black;
            this.btn_tray2.CheckBoxSymbolSize = 14;
            this.btn_tray2.Checked = false;
            this.btn_tray2.CheckLineWidth = 3;
            this.btn_tray2.Enabled = false;
            this.btn_tray2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btn_tray2.ImageCheckBox = ((System.Drawing.Image)(resources.GetObject("btn_tray2.ImageCheckBox")));
            this.btn_tray2.ImageUnCheckBox = ((System.Drawing.Image)(resources.GetObject("btn_tray2.ImageUnCheckBox")));
            this.btn_tray2.InitVisible = true;
            this.btn_tray2.Location = new System.Drawing.Point(340, 72);
            this.btn_tray2.Name = "btn_tray2";
            this.btn_tray2.Size = new System.Drawing.Size(103, 34);
            this.btn_tray2.TabIndex = 97;
            this.btn_tray2.Text = "서랍2";
            this.btn_tray2.TextVAlign = SmartX.SmartCheckBox.TextVerAlign.Middle;
            // 
            // btn_tray3
            // 
            this.btn_tray3.BackColor = System.Drawing.Color.Gray;
            this.btn_tray3.BackPictureBox = null;
            this.btn_tray3.BackPictureBox1 = null;
            this.btn_tray3.BackPictureBox2 = null;
            this.btn_tray3.CheckBoxBackColor = System.Drawing.Color.White;
            this.btn_tray3.CheckBoxCheckColor = System.Drawing.Color.Green;
            this.btn_tray3.CheckBoxForeColor = System.Drawing.Color.Black;
            this.btn_tray3.CheckBoxSymbolSize = 14;
            this.btn_tray3.Checked = false;
            this.btn_tray3.CheckLineWidth = 3;
            this.btn_tray3.Enabled = false;
            this.btn_tray3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.btn_tray3.ImageCheckBox = ((System.Drawing.Image)(resources.GetObject("btn_tray3.ImageCheckBox")));
            this.btn_tray3.ImageUnCheckBox = ((System.Drawing.Image)(resources.GetObject("btn_tray3.ImageUnCheckBox")));
            this.btn_tray3.InitVisible = true;
            this.btn_tray3.Location = new System.Drawing.Point(340, 103);
            this.btn_tray3.Name = "btn_tray3";
            this.btn_tray3.Size = new System.Drawing.Size(103, 34);
            this.btn_tray3.TabIndex = 97;
            this.btn_tray3.Text = "서랍3";
            this.btn_tray3.TextVAlign = SmartX.SmartCheckBox.TextVerAlign.Middle;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(107, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.Text = "Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.Text = "DateTime";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // btn_stop
            // 
            this.btn_stop.BackPictureBox = null;
            this.btn_stop.BackPictureBox1 = null;
            this.btn_stop.BackPictureBox2 = null;
            this.btn_stop.ButtonColor = System.Drawing.Color.DimGray;
            this.btn_stop.ButtonImageAutoSize = true;
            this.btn_stop.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_stop.DisableImage = null;
            this.btn_stop.DownImage = null;
            this.btn_stop.Font = new System.Drawing.Font("Tahoma", 40F, System.Drawing.FontStyle.Bold);
            this.btn_stop.GroupID = 1;
            this.btn_stop.InitVisible = true;
            this.btn_stop.Location = new System.Drawing.Point(0, 136);
            this.btn_stop.Mode = SmartX.SmartButton.BUTTONMODE.RADIO;
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.NestedClickEventPrevent = false;
            this.btn_stop.OutlinePixel = 1;
            this.btn_stop.RepeatInterval = 200;
            this.btn_stop.RepeatIntervalAccelerate = null;
            this.btn_stop.SafeInterval = 200;
            this.btn_stop.Size = new System.Drawing.Size(313, 136);
            this.btn_stop.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_stop.TabIndex = 104;
            this.btn_stop.Text = "STOP";
            this.btn_stop.TextColor = System.Drawing.Color.Black;
            this.btn_stop.TextDownColor = System.Drawing.Color.White;
            this.btn_stop.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_stop.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_stop.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_stop.UpImage = null;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackPictureBox = null;
            this.btn_start.BackPictureBox1 = null;
            this.btn_start.BackPictureBox2 = null;
            this.btn_start.ButtonColor = System.Drawing.Color.DimGray;
            this.btn_start.ButtonImageAutoSize = false;
            this.btn_start.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_start.DisableImage = null;
            this.btn_start.DownImage = null;
            this.btn_start.Font = new System.Drawing.Font("Tahoma", 40F, System.Drawing.FontStyle.Bold);
            this.btn_start.GroupID = 1;
            this.btn_start.InitVisible = true;
            this.btn_start.Location = new System.Drawing.Point(0, 0);
            this.btn_start.Mode = SmartX.SmartButton.BUTTONMODE.RADIO;
            this.btn_start.Name = "btn_start";
            this.btn_start.NestedClickEventPrevent = false;
            this.btn_start.OutlinePixel = 1;
            this.btn_start.RepeatInterval = 200;
            this.btn_start.RepeatIntervalAccelerate = null;
            this.btn_start.SafeInterval = 200;
            this.btn_start.Size = new System.Drawing.Size(313, 136);
            this.btn_start.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_start.TabIndex = 103;
            this.btn_start.Text = "START";
            this.btn_start.TextColor = System.Drawing.Color.Black;
            this.btn_start.TextDownColor = System.Drawing.Color.White;
            this.btn_start.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_start.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_start.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_start.UpImage = null;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_Test1
            // 
            this.btn_Test1.BackPictureBox = null;
            this.btn_Test1.BackPictureBox1 = null;
            this.btn_Test1.BackPictureBox2 = null;
            this.btn_Test1.ButtonColor = System.Drawing.Color.Gray;
            this.btn_Test1.ButtonImageAutoSize = true;
            this.btn_Test1.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_Test1.DisableImage = null;
            this.btn_Test1.DownImage = null;
            this.btn_Test1.GroupID = 0;
            this.btn_Test1.InitVisible = true;
            this.btn_Test1.Location = new System.Drawing.Point(319, 153);
            this.btn_Test1.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.btn_Test1.Name = "btn_Test1";
            this.btn_Test1.NestedClickEventPrevent = false;
            this.btn_Test1.OutlinePixel = 1;
            this.btn_Test1.RepeatInterval = 200;
            this.btn_Test1.RepeatIntervalAccelerate = null;
            this.btn_Test1.SafeInterval = 200;
            this.btn_Test1.Size = new System.Drawing.Size(85, 29);
            this.btn_Test1.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_Test1.TabIndex = 105;
            this.btn_Test1.Text = "test1";
            this.btn_Test1.TextColor = System.Drawing.Color.Black;
            this.btn_Test1.TextDownColor = System.Drawing.Color.White;
            this.btn_Test1.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_Test1.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_Test1.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_Test1.UpImage = null;
            this.btn_Test1.Visible = false;
            this.btn_Test1.Click += new System.EventHandler(this.btn_Test1_Click);
            // 
            // btn_Test2
            // 
            this.btn_Test2.BackPictureBox = null;
            this.btn_Test2.BackPictureBox1 = null;
            this.btn_Test2.BackPictureBox2 = null;
            this.btn_Test2.ButtonColor = System.Drawing.Color.Gray;
            this.btn_Test2.ButtonImageAutoSize = true;
            this.btn_Test2.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_Test2.DisableImage = null;
            this.btn_Test2.DownImage = null;
            this.btn_Test2.GroupID = 0;
            this.btn_Test2.InitVisible = true;
            this.btn_Test2.Location = new System.Drawing.Point(319, 185);
            this.btn_Test2.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.btn_Test2.Name = "btn_Test2";
            this.btn_Test2.NestedClickEventPrevent = false;
            this.btn_Test2.OutlinePixel = 1;
            this.btn_Test2.RepeatInterval = 200;
            this.btn_Test2.RepeatIntervalAccelerate = null;
            this.btn_Test2.SafeInterval = 200;
            this.btn_Test2.Size = new System.Drawing.Size(85, 29);
            this.btn_Test2.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_Test2.TabIndex = 106;
            this.btn_Test2.Text = "test2";
            this.btn_Test2.TextColor = System.Drawing.Color.Black;
            this.btn_Test2.TextDownColor = System.Drawing.Color.White;
            this.btn_Test2.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_Test2.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_Test2.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_Test2.UpImage = null;
            this.btn_Test2.Visible = false;
            // 
            // btn_Test3
            // 
            this.btn_Test3.BackPictureBox = null;
            this.btn_Test3.BackPictureBox1 = null;
            this.btn_Test3.BackPictureBox2 = null;
            this.btn_Test3.ButtonColor = System.Drawing.Color.Gray;
            this.btn_Test3.ButtonImageAutoSize = true;
            this.btn_Test3.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_Test3.DisableImage = null;
            this.btn_Test3.DownImage = null;
            this.btn_Test3.GroupID = 0;
            this.btn_Test3.InitVisible = true;
            this.btn_Test3.Location = new System.Drawing.Point(319, 215);
            this.btn_Test3.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.btn_Test3.Name = "btn_Test3";
            this.btn_Test3.NestedClickEventPrevent = false;
            this.btn_Test3.OutlinePixel = 1;
            this.btn_Test3.RepeatInterval = 200;
            this.btn_Test3.RepeatIntervalAccelerate = null;
            this.btn_Test3.SafeInterval = 200;
            this.btn_Test3.Size = new System.Drawing.Size(85, 29);
            this.btn_Test3.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_Test3.TabIndex = 107;
            this.btn_Test3.Text = "test3";
            this.btn_Test3.TextColor = System.Drawing.Color.Black;
            this.btn_Test3.TextDownColor = System.Drawing.Color.White;
            this.btn_Test3.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_Test3.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_Test3.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_Test3.UpImage = null;
            this.btn_Test3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 272);
            this.Controls.Add(this.btn_Test3);
            this.Controls.Add(this.btn_Test2);
            this.Controls.Add(this.btn_Test1);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.smartLabel1);
            this.Controls.Add(this.btn_tray3);
            this.Controls.Add(this.btn_tray2);
            this.Controls.Add(this.btn_tray1);
            this.Controls.Add(this.smartLabel_VERSION);
            this.Controls.Add(this.btn_logo_BIONIT);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label_indicator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.smartForm1);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "ver1.3_20211028";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.smartForm1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private SmartX.SmartForm smartForm1;
        private SmartX.SmartLabel label_indicator;
        private SmartX.SmartTimer smartTimer1;
        private SmartX.SmartButton btn_Exit;
        private SmartX.SmartButton btn_logo_BIONIT;
        private SmartX.SmartUpdate smartUpdate1;
        private SmartX.SmartTimer smartTimer2;
        private SmartX.SmartLabel smartLabel_VERSION;
        private System.Windows.Forms.Label label3;
        private SmartX.SmartCheckBox btn_tray1;
        private SmartX.SmartLabel smartLabel1;
        private SmartX.SmartCheckBox btn_tray2;
        private SmartX.SmartCheckBox btn_tray3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort2;
        private SmartX.SmartButton btn_stop;
        private SmartX.SmartButton btn_start;
        private SmartX.SmartButton btn_Test1;
        private SmartX.SmartButton btn_Test2;
        private SmartX.SmartButton btn_Test3;
    }
}

