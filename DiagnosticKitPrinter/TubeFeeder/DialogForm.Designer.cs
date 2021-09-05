namespace TubeFeeder
{
    partial class DialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btn_OK = new SmartX.SmartButton();
            this.btn_cancel = new SmartX.SmartButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_conveyorSpeed = new System.Windows.Forms.ComboBox();
            this.comboBox_xXaisDistance = new System.Windows.Forms.ComboBox();
            this.comboBox_converterRollerSpeed = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.BackPictureBox = null;
            this.btn_OK.BackPictureBox1 = null;
            this.btn_OK.BackPictureBox2 = null;
            this.btn_OK.ButtonColor = System.Drawing.Color.Gray;
            this.btn_OK.ButtonImageAutoSize = true;
            this.btn_OK.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_OK.DisableImage = null;
            this.btn_OK.DownImage = null;
            this.btn_OK.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btn_OK.GroupID = 0;
            this.btn_OK.InitVisible = true;
            this.btn_OK.Location = new System.Drawing.Point(145, 179);
            this.btn_OK.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.NestedClickEventPrevent = false;
            this.btn_OK.OutlinePixel = 1;
            this.btn_OK.RepeatInterval = 200;
            this.btn_OK.RepeatIntervalAccelerate = null;
            this.btn_OK.SafeInterval = 200;
            this.btn_OK.Size = new System.Drawing.Size(108, 43);
            this.btn_OK.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "SAVE";
            this.btn_OK.TextColor = System.Drawing.Color.Black;
            this.btn_OK.TextDownColor = System.Drawing.Color.White;
            this.btn_OK.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_OK.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_OK.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_OK.UpImage = null;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackPictureBox = null;
            this.btn_cancel.BackPictureBox1 = null;
            this.btn_cancel.BackPictureBox2 = null;
            this.btn_cancel.ButtonColor = System.Drawing.Color.Gray;
            this.btn_cancel.ButtonImageAutoSize = true;
            this.btn_cancel.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_cancel.DisableImage = null;
            this.btn_cancel.DownImage = null;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.GroupID = 0;
            this.btn_cancel.InitVisible = true;
            this.btn_cancel.Location = new System.Drawing.Point(270, 179);
            this.btn_cancel.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NestedClickEventPrevent = false;
            this.btn_cancel.OutlinePixel = 1;
            this.btn_cancel.RepeatInterval = 200;
            this.btn_cancel.RepeatIntervalAccelerate = null;
            this.btn_cancel.SafeInterval = 200;
            this.btn_cancel.Size = new System.Drawing.Size(108, 43);
            this.btn_cancel.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextColor = System.Drawing.Color.Black;
            this.btn_cancel.TextDownColor = System.Drawing.Color.White;
            this.btn_cancel.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_cancel.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_cancel.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_cancel.UpImage = null;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.Text = "Conveyor belt speed";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(30, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.Text = "X axis distance";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(28, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.Text = "Converter roller speed";
            // 
            // comboBox_conveyorSpeed
            // 
            this.comboBox_conveyorSpeed.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular);
            this.comboBox_conveyorSpeed.Items.Add("1");
            this.comboBox_conveyorSpeed.Items.Add("2");
            this.comboBox_conveyorSpeed.Items.Add("3");
            this.comboBox_conveyorSpeed.Location = new System.Drawing.Point(246, 28);
            this.comboBox_conveyorSpeed.Name = "comboBox_conveyorSpeed";
            this.comboBox_conveyorSpeed.Size = new System.Drawing.Size(132, 31);
            this.comboBox_conveyorSpeed.TabIndex = 8;
            this.comboBox_conveyorSpeed.SelectedIndexChanged += new System.EventHandler(this.comboBox_conveyorSpeed_SelectedIndexChanged);
            // 
            // comboBox_xXaisDistance
            // 
            this.comboBox_xXaisDistance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular);
            this.comboBox_xXaisDistance.Items.Add("1");
            this.comboBox_xXaisDistance.Items.Add("2");
            this.comboBox_xXaisDistance.Items.Add("3");
            this.comboBox_xXaisDistance.Items.Add("4");
            this.comboBox_xXaisDistance.Items.Add("5");
            this.comboBox_xXaisDistance.Items.Add("6");
            this.comboBox_xXaisDistance.Items.Add("7");
            this.comboBox_xXaisDistance.Items.Add("8");
            this.comboBox_xXaisDistance.Items.Add("9");
            this.comboBox_xXaisDistance.Items.Add("MAX");
            this.comboBox_xXaisDistance.Location = new System.Drawing.Point(246, 75);
            this.comboBox_xXaisDistance.Name = "comboBox_xXaisDistance";
            this.comboBox_xXaisDistance.Size = new System.Drawing.Size(132, 31);
            this.comboBox_xXaisDistance.TabIndex = 9;
            this.comboBox_xXaisDistance.SelectedIndexChanged += new System.EventHandler(this.comboBox_xXaisDistance_SelectedIndexChanged);
            // 
            // comboBox_converterRollerSpeed
            // 
            this.comboBox_converterRollerSpeed.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular);
            this.comboBox_converterRollerSpeed.Items.Add("1");
            this.comboBox_converterRollerSpeed.Items.Add("2");
            this.comboBox_converterRollerSpeed.Location = new System.Drawing.Point(246, 121);
            this.comboBox_converterRollerSpeed.Name = "comboBox_converterRollerSpeed";
            this.comboBox_converterRollerSpeed.Size = new System.Drawing.Size(132, 31);
            this.comboBox_converterRollerSpeed.TabIndex = 10;
            this.comboBox_converterRollerSpeed.SelectedIndexChanged += new System.EventHandler(this.comboBox_converterRollerSpeed_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(228, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(228, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(228, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.Text = ":";
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.comboBox_converterRollerSpeed);
            this.Controls.Add(this.comboBox_xXaisDistance);
            this.Controls.Add(this.comboBox_conveyorSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "DialogForm";
            this.Text = "dialogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private SmartX.SmartButton btn_OK;
        private SmartX.SmartButton btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_conveyorSpeed;
        private System.Windows.Forms.ComboBox comboBox_xXaisDistance;
        private System.Windows.Forms.ComboBox comboBox_converterRollerSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}