using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PregDays
{
    public partial class FormConfig : Form
    {
        private DateTime _pregDate;
        /// <summary>
        /// 怀孕开始日期
        /// </summary>
        public DateTime PregDate
        {
            get { return _pregDate; }
            set { _pregDate = value; }
        }


        public FormConfig(DateTime tmPregDate)
        {
            PregDate = tmPregDate;

            InitializeComponent();

            dateTimePicker1.Value = PregDate;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PregDate = dateTimePicker1.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PregDate = dateTimePicker1.Value;

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            chkAutoRun.Checked = IsAutoStart();
        }

        public bool IsAutoStart()
        {
            RegistryKey HKLM = Registry.LocalMachine;            
            RegistryKey Run = HKLM.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run"); 
            if (Run.GetValue("PregDays") != null)
            {
                return true;
            }else
            {

                return false;
            }

        }

        /// <summary> 
        /// 开机启动项 
        /// </summary> 
        /// <param name="Started">是否启动</param> 
        /// <param name="name">启动值的名称</param> 
        /// <param name="path">启动程序的路径</param> 
        public static void RunWhenStart(bool Started, string name, string path) 
        { 
            RegistryKey HKLM = Registry.LocalMachine; 
            RegistryKey Run = HKLM.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run"); 
            if (Started == true) 
            { 
                try 
                { 
                    Run.SetValue(name, path); 
                    HKLM.Close(); 
                } 
                catch (Exception Err) 
                { 
                    MessageBox.Show(Err.Message.ToString(), "PregDays", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                } 
            }
            else
            {
                try
                {
                    Run.DeleteValue(name);
                    HKLM.Close();
                }
                catch (Exception)
                {
                    // 
                }
            }
        }

        private void chkAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            RunWhenStart(chkAutoRun.Checked, "PregDays", Application.ExecutablePath);
        } 
    }
}