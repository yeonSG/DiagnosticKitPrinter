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
            this.btn_start = new SmartX.SmartButton();
            this.btn_stop = new SmartX.SmartButton();
            this.label_indicator = new SmartX.SmartLabel();
            this.smartTimer1 = new SmartX.SmartTimer(this.components);
            this.btn_Exit = new SmartX.SmartButton();
            this.btn_logo_BIONIT = new SmartX.SmartButton();
            this.smartUpdate1 = new SmartX.SmartUpdate(this.components);
            this.smartTimer2 = new SmartX.SmartTimer(this.components);
            this.smartLabel_VERSION = new SmartX.SmartLabel();
            this.smartButton3 = new SmartX.SmartCheckBox();
            this.smartLabel1 = new SmartX.SmartLabel();
            this.smartCheckBox1 = new SmartX.SmartCheckBox();
            this.smartCheckBox2 = new SmartX.SmartCheckBox();
            this.smartListBox_log = new SmartX.SmartListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // btn_start
            // 
            this.btn_start.BackPictureBox = null;
            this.btn_start.BackPictureBox1 = null;
            this.btn_start.BackPictureBox2 = null;
            this.btn_start.ButtonColor = System.Drawing.Color.Maroon;
            this.btn_start.ButtonImageAutoSize = false;
            this.btn_start.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_start.DisableImage = null;
            this.btn_start.DownImage = ((System.Drawing.Image)(resources.GetObject("btn_start.DownImage")));
            this.btn_start.Font = new System.Drawing.Font("Tahoma", 23F, System.Drawing.FontStyle.Bold);
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.GroupID = 1;
            this.btn_start.InitVisible = true;
            this.btn_start.Location = new System.Drawing.Point(328, 10);
            this.btn_start.Mode = SmartX.SmartButton.BUTTONMODE.RADIO;
            this.btn_start.Name = "btn_start";
            this.btn_start.NestedClickEventPrevent = false;
            this.btn_start.OutlinePixel = 1;
            this.btn_start.RepeatInterval = 200;
            this.btn_start.RepeatIntervalAccelerate = null;
            this.btn_start.SafeInterval = 200;
            this.btn_start.Size = new System.Drawing.Size(140, 46);
            this.btn_start.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_start.TabIndex = 59;
            this.btn_start.Text = "시작";
            this.btn_start.TextColor = System.Drawing.Color.White;
            this.btn_start.TextDownColor = System.Drawing.Color.Black;
            this.btn_start.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_start.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_start.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_start.UpImage = null;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackPictureBox = null;
            this.btn_stop.BackPictureBox1 = null;
            this.btn_stop.BackPictureBox2 = null;
            this.btn_stop.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_stop.ButtonImageAutoSize = true;
            this.btn_stop.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_stop.DisableImage = null;
            this.btn_stop.DownImage = ((System.Drawing.Image)(resources.GetObject("btn_stop.DownImage")));
            this.btn_stop.Font = new System.Drawing.Font("Tahoma", 23F, System.Drawing.FontStyle.Bold);
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.GroupID = 1;
            this.btn_stop.InitVisible = true;
            this.btn_stop.Location = new System.Drawing.Point(328, 61);
            this.btn_stop.Mode = SmartX.SmartButton.BUTTONMODE.RADIO;
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.NestedClickEventPrevent = false;
            this.btn_stop.OutlinePixel = 1;
            this.btn_stop.RepeatInterval = 200;
            this.btn_stop.RepeatIntervalAccelerate = null;
            this.btn_stop.SafeInterval = 200;
            this.btn_stop.Size = new System.Drawing.Size(140, 46);
            this.btn_stop.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_stop.TabIndex = 60;
            this.btn_stop.Text = "중지";
            this.btn_stop.TextColor = System.Drawing.Color.White;
            this.btn_stop.TextDownColor = System.Drawing.Color.Black;
            this.btn_stop.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_stop.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_stop.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_stop.UpImage = null;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
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
            this.label_indicator.Location = new System.Drawing.Point(328, 121);
            this.label_indicator.Name = "label_indicator";
            this.label_indicator.Size = new System.Drawing.Size(140, 133);
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
            this.btn_Exit.Location = new System.Drawing.Point(206, 196);
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
            this.btn_logo_BIONIT.Location = new System.Drawing.Point(215, 234);
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
            this.smartUpdate1.TitleText = "[[[ AutoFeeder Update ]]]";
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
            this.smartLabel_VERSION.Location = new System.Drawing.Point(7, 251);
            this.smartLabel_VERSION.Name = "smartLabel_VERSION";
            this.smartLabel_VERSION.Size = new System.Drawing.Size(56, 18);
            this.smartLabel_VERSION.TabIndex = 90;
            this.smartLabel_VERSION.Text = "ver 1.0";
            this.smartLabel_VERSION.TextHAlign = SmartX.SmartLabel.TextHorAlign.Left;
            this.smartLabel_VERSION.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.smartLabel_VERSION.Wordwrap = false;
            // 
            // smartButton3
            // 
            this.smartButton3.BackColor = System.Drawing.Color.Gray;
            this.smartButton3.BackPictureBox = null;
            this.smartButton3.BackPictureBox1 = null;
            this.smartButton3.BackPictureBox2 = null;
            this.smartButton3.CheckBoxBackColor = System.Drawing.Color.White;
            this.smartButton3.CheckBoxCheckColor = System.Drawing.Color.Green;
            this.smartButton3.CheckBoxForeColor = System.Drawing.Color.Black;
            this.smartButton3.CheckBoxSymbolSize = 14;
            this.smartButton3.Checked = false;
            this.smartButton3.CheckLineWidth = 3;
            this.smartButton3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.smartButton3.ImageCheckBox = ((System.Drawing.Image)(resources.GetObject("smartButton3.ImageCheckBox")));
            this.smartButton3.ImageUnCheckBox = ((System.Drawing.Image)(resources.GetObject("smartButton3.ImageUnCheckBox")));
            this.smartButton3.InitVisible = true;
            this.smartButton3.Location = new System.Drawing.Point(341, 146);
            this.smartButton3.Name = "smartButton3";
            this.smartButton3.Size = new System.Drawing.Size(103, 34);
            this.smartButton3.TabIndex = 97;
            this.smartButton3.Text = "서랍1";
            this.smartButton3.TextVAlign = SmartX.SmartCheckBox.TextVerAlign.Middle;
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
            this.smartLabel1.Location = new System.Drawing.Point(359, 124);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(84, 29);
            this.smartLabel1.TabIndex = 99;
            this.smartLabel1.Text = "서랍 상태";
            this.smartLabel1.TextHAlign = SmartX.SmartLabel.TextHorAlign.Left;
            this.smartLabel1.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.smartLabel1.Wordwrap = false;
            // 
            // smartCheckBox1
            // 
            this.smartCheckBox1.BackColor = System.Drawing.Color.Gray;
            this.smartCheckBox1.BackPictureBox = null;
            this.smartCheckBox1.BackPictureBox1 = null;
            this.smartCheckBox1.BackPictureBox2 = null;
            this.smartCheckBox1.CheckBoxBackColor = System.Drawing.Color.White;
            this.smartCheckBox1.CheckBoxCheckColor = System.Drawing.Color.Green;
            this.smartCheckBox1.CheckBoxForeColor = System.Drawing.Color.Black;
            this.smartCheckBox1.CheckBoxSymbolSize = 14;
            this.smartCheckBox1.Checked = false;
            this.smartCheckBox1.CheckLineWidth = 3;
            this.smartCheckBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.smartCheckBox1.ImageCheckBox = ((System.Drawing.Image)(resources.GetObject("smartCheckBox1.ImageCheckBox")));
            this.smartCheckBox1.ImageUnCheckBox = ((System.Drawing.Image)(resources.GetObject("smartCheckBox1.ImageUnCheckBox")));
            this.smartCheckBox1.InitVisible = true;
            this.smartCheckBox1.Location = new System.Drawing.Point(341, 177);
            this.smartCheckBox1.Name = "smartCheckBox1";
            this.smartCheckBox1.Size = new System.Drawing.Size(103, 34);
            this.smartCheckBox1.TabIndex = 97;
            this.smartCheckBox1.Text = "서랍2";
            this.smartCheckBox1.TextVAlign = SmartX.SmartCheckBox.TextVerAlign.Middle;
            // 
            // smartCheckBox2
            // 
            this.smartCheckBox2.BackColor = System.Drawing.Color.Gray;
            this.smartCheckBox2.BackPictureBox = null;
            this.smartCheckBox2.BackPictureBox1 = null;
            this.smartCheckBox2.BackPictureBox2 = null;
            this.smartCheckBox2.CheckBoxBackColor = System.Drawing.Color.White;
            this.smartCheckBox2.CheckBoxCheckColor = System.Drawing.Color.Green;
            this.smartCheckBox2.CheckBoxForeColor = System.Drawing.Color.Black;
            this.smartCheckBox2.CheckBoxSymbolSize = 14;
            this.smartCheckBox2.Checked = false;
            this.smartCheckBox2.CheckLineWidth = 3;
            this.smartCheckBox2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.smartCheckBox2.ImageCheckBox = ((System.Drawing.Image)(resources.GetObject("smartCheckBox2.ImageCheckBox")));
            this.smartCheckBox2.ImageUnCheckBox = ((System.Drawing.Image)(resources.GetObject("smartCheckBox2.ImageUnCheckBox")));
            this.smartCheckBox2.InitVisible = true;
            this.smartCheckBox2.Location = new System.Drawing.Point(341, 208);
            this.smartCheckBox2.Name = "smartCheckBox2";
            this.smartCheckBox2.Size = new System.Drawing.Size(103, 34);
            this.smartCheckBox2.TabIndex = 97;
            this.smartCheckBox2.Text = "서랍3";
            this.smartCheckBox2.TextVAlign = SmartX.SmartCheckBox.TextVerAlign.Middle;
            // 
            // smartListBox_log
            // 
            this.smartListBox_log.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.smartListBox_log.BackPictureBox = null;
            this.smartListBox_log.BackPictureBox1 = null;
            this.smartListBox_log.BackPictureBox2 = null;
            this.smartListBox_log.ColumnAlign = SmartX.SmartListBox.COLUMNALIGNS.CENTER;
            this.smartListBox_log.ColumnDelimiter = '\0';
            this.smartListBox_log.ColumnOffsets = null;
            this.smartListBox_log.FontColor = System.Drawing.Color.Black;
            this.smartListBox_log.InitVisible = true;
            this.smartListBox_log.ItemAddOrder = SmartX.SmartListBox.ITEMADDORDERS.BOTTOMADD;
            this.smartListBox_log.ItemOffsetGap = 0;
            this.smartListBox_log.ItemOffsetX = 0;
            this.smartListBox_log.ItemOffsetY = 0;
            this.smartListBox_log.Location = new System.Drawing.Point(7, 40);
            this.smartListBox_log.MouseMoveEventSpace = 3;
            this.smartListBox_log.MouseMoveSpace = 10;
            this.smartListBox_log.Name = "smartListBox_log";
            this.smartListBox_log.OutLineColor = System.Drawing.SystemColors.ControlText;
            this.smartListBox_log.SelectColor = System.Drawing.Color.Blue;
            this.smartListBox_log.SelectFilled = true;
            this.smartListBox_log.SelectFontColor = System.Drawing.Color.DarkBlue;
            this.smartListBox_log.SelectItemIndex = -1;
            this.smartListBox_log.SeparationlineColor1 = System.Drawing.Color.Gray;
            this.smartListBox_log.SeparationlineColor2 = System.Drawing.Color.LightGray;
            this.smartListBox_log.SeparationLineStyle = SmartX.SmartListBox.SEPARATIONLINETYPES.FixedSingle;
            this.smartListBox_log.SeparationlineVisibleBottom = true;
            this.smartListBox_log.SeparationlineVisibleTop = true;
            this.smartListBox_log.Size = new System.Drawing.Size(305, 191);
            this.smartListBox_log.TabIndex = 101;
            this.smartListBox_log.Text = "LogListBox";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 272);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.smartListBox_log);
            this.Controls.Add(this.smartLabel1);
            this.Controls.Add(this.smartCheckBox2);
            this.Controls.Add(this.smartCheckBox1);
            this.Controls.Add(this.smartButton3);
            this.Controls.Add(this.smartLabel_VERSION);
            this.Controls.Add(this.btn_logo_BIONIT);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label_indicator);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.smartForm1);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "ver0.1_20201208";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.smartForm1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private SmartX.SmartForm smartForm1;
        private SmartX.SmartButton btn_start;
        private SmartX.SmartButton btn_stop;
        private SmartX.SmartLabel label_indicator;
        private SmartX.SmartTimer smartTimer1;
        private SmartX.SmartButton btn_Exit;
        private SmartX.SmartButton btn_logo_BIONIT;
        private SmartX.SmartUpdate smartUpdate1;
        private SmartX.SmartTimer smartTimer2;
        private SmartX.SmartLabel smartLabel_VERSION;
        private SmartX.SmartCheckBox smartButton3;
        private SmartX.SmartLabel smartLabel1;
        private SmartX.SmartCheckBox smartCheckBox1;
        private SmartX.SmartCheckBox smartCheckBox2;
        private SmartX.SmartListBox smartListBox_log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

