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
    public partial class DialogForm : Form
    {
        ControlBoard m_ControlBoard;
        SettingValues m_values;

        public DialogForm(ControlBoard controlBoard, SettingValues values)
        {
            m_ControlBoard = controlBoard;
            m_values = values;
            InitializeComponent();

            SettingValuesToUI();
        }

        private void SettingValuesToUI()
        {
            if (comboBox_conveyorSpeed.Items.Count > m_values.value_conveyorSpeed - 1)      
                comboBox_conveyorSpeed.SelectedIndex = m_values.value_conveyorSpeed - 1;    
            else
                comboBox_conveyorSpeed.SelectedIndex = 0;

            if (comboBox_xXaisDistance.Items.Count > m_values.value_XAxisDistance - 1)
                comboBox_xXaisDistance.SelectedIndex = m_values.value_XAxisDistance - 1;
            else
                comboBox_conveyorSpeed.SelectedIndex = 0;

            if (comboBox_converterRollerSpeed.Items.Count > m_values.value_ConvererRollerSpeed - 1)   
                comboBox_converterRollerSpeed.SelectedIndex = m_values.value_ConvererRollerSpeed - 1;
            else
                comboBox_converterRollerSpeed.SelectedIndex = 0;

            //if (trackBar_conveyorSpeed.Minimum <= m_values.value_ConvererRollerSpeed 
            //    && trackBar_conveyorSpeed.Maximum>=m_values.value_ConvererRollerSpeed)
            //    trackBar_conveyorSpeed.Value = m_values.value_ConvererRollerSpeed;

            //if (trackBar_xXaisDistance.Minimum <= m_values.value_XAxisDistance
            //    && trackBar_xXaisDistance.Maximum >= m_values.value_XAxisDistance)
            //    trackBar_xXaisDistance.Value = m_values.value_XAxisDistance;

            //if (trackBar_converterRollerSpeed.Minimum <= m_values.value_ConvererRollerSpeed
            //    && trackBar_converterRollerSpeed.Maximum >= m_values.value_ConvererRollerSpeed)
            //    trackBar_converterRollerSpeed.Value = m_values.value_ConvererRollerSpeed;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            // OK 눌럿을 때만 m_value 값을 실재로 변경함.
            m_values.value_conveyorSpeed = comboBox_conveyorSpeed.SelectedIndex + 1;
            m_values.value_XAxisDistance = comboBox_xXaisDistance.SelectedIndex + 1;
            m_values.value_ConvererRollerSpeed = comboBox_converterRollerSpeed.SelectedIndex + 1;
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBox_conveyorSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            // m_values.value_conveyorSpeed = comboBox_conveyorSpeed.SelectedIndex + 1;
            int selectValue = comboBox_conveyorSpeed.SelectedIndex + 1;
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_Write(MessageProtocol.CMD_WRITE_BELTSPEED, (short)selectValue));
        }

        private void comboBox_xXaisDistance_SelectedIndexChanged(object sender, EventArgs e)
        {
            // m_values.value_XAxisDistance = comboBox_xXaisDistance.SelectedIndex + 1;
            int selectValue = comboBox_xXaisDistance.SelectedIndex + 1;
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_Write(MessageProtocol.CMD_WRITE_XXAISDISTANCE, (short)selectValue));
        }

        private void comboBox_converterRollerSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            // m_values.value_ConvererRollerSpeed = comboBox_converterRollerSpeed.SelectedIndex + 1;
            int selectValue = comboBox_converterRollerSpeed.SelectedIndex + 1;
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_Write(MessageProtocol.CMD_WRITE_ROLLERSPEED, (short)selectValue));
        }
    }
}