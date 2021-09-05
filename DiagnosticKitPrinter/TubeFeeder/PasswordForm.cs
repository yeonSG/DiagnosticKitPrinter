using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TubeFeeder
{
    public partial class PasswordForm : Form
    {

        const string PASSWORD = "0507";
        string m_insertedPassword = "";
        int m_inputIndex = 0;

        public PasswordForm()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (PASSWORD.Equals(m_insertedPassword))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }

        private void UpdateLabel()
        {
            string password = "";
            for (int i = 0; i < m_insertedPassword.Length -1; i++) // 1
            {
                password += "*";
            }

            if (m_insertedPassword.Length!=0)
                password += m_insertedPassword[m_insertedPassword.Length-1];

            for (int i = password.Length; i < 4; i++)
            {
                password += "-";
            }

            //label_password.Text = password;
            SetLabel_password(password);
        }

        public void SetLabel_password(string password)
        {
            if (this.label_password.InvokeRequired)
            {
                SetTextCallback dp = new SetTextCallback(SetLabel_password);
                this.Invoke(dp, new object[] { password });
            }
            else
            {
                string settingText = "";
                for (int i = 0; i < password.Length; i++)
                {
                    settingText += password[i];
                    settingText += " ";
                }
                this.label_password.Text = settingText;
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (m_insertedPassword.Length > 3)
                return;

            m_insertedPassword += "1";
            UpdateLabel();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (m_insertedPassword.Length > 3)
                return;

            m_insertedPassword += "2";
            UpdateLabel();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (m_insertedPassword.Length > 3)
                return;

            m_insertedPassword += "3";
            UpdateLabel();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (m_insertedPassword.Length > 3)
                return;

            m_insertedPassword += "4";
            UpdateLabel();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (m_insertedPassword.Length > 3)
                return;

            m_insertedPassword += "5";
            UpdateLabel();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (m_insertedPassword.Length > 3)
                return;

            m_insertedPassword += "6";
            UpdateLabel();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (m_insertedPassword.Length > 3)
                return;

            m_insertedPassword += "7";
            UpdateLabel();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (m_insertedPassword.Length > 3)
                return;

            m_insertedPassword += "8";
            UpdateLabel();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (m_insertedPassword.Length > 3)
                return;

            m_insertedPassword += "9";
            UpdateLabel();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (m_insertedPassword.Length > 3)
                return;

            m_insertedPassword += "0";
            UpdateLabel();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}