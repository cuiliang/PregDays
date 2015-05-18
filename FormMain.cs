using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PregDays
{
    public partial class FormMain : Form
    {
        private DateTime _pregDate = DateTime.Now.Date;

       

        /// <summary>
        /// ���п�ʼ����
        /// </summary>
        public DateTime PregDate
        {
            get { return _pregDate; }
            set { _pregDate = value; }
        }


        public FormMain()
        {
            InitializeComponent();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            toolTip1.Hide(btnConfig);

            FormConfig frmConfig = new FormConfig(PregDate);
            if (frmConfig.ShowDialog() == DialogResult.OK)
            {
                PregDate = frmConfig.PregDate;

                UpdateDays();
            }
        }

        /// <summary>
        /// ����ʱ����ʾ
        /// </summary>
        private void UpdateDays()
        {
            TimeSpan span = DateTime.Now.Date - PregDate.Date;
            if (span.TotalDays < 15 || span.TotalDays>300)
            {
                lblPregDays.Text = "���趨���п�ʼʱ�䣡";
                lblDaysLeft.Text = "";
            }
            else
            {
                int nTotalDays = Convert.ToInt32(Math.Ceiling(span.TotalDays));
                int nWeek = nTotalDays / 7 + 1;
                int nDays = nTotalDays % 7 + 1;

                StringBuilder sb = new StringBuilder();

                lblPregDays.Text = "���е�" + (nTotalDays + 1).ToString() + "�죬��" + nWeek.ToString() + "�ܵ�" + nDays.ToString() + "��(" + (nWeek - 1).ToString() + "w+" + (nDays).ToString() + "d)";
               

                int nTotalLeftDays = 280 - nTotalDays - 1;
                int nLeftWeek = nTotalLeftDays / 7;
                int nLeftDays = nTotalLeftDays % 7;

                DateTime birthDay = PregDate + (new TimeSpan(280, 0, 0, 0));
                lblDaysLeft.Text = "Ԥ����Ϊ" + birthDay.ToString("yyyy��M��d��") +"������" + nTotalLeftDays.ToString() + "�죨" + nLeftWeek.ToString() + "��" + nLeftDays.ToString() + "�죩";

                try
                {
                    progressBar1.Value = nTotalDays;
                }
                catch {
                    progressBar1.Value = 0;
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadConfig();

            UpdateDays();

            this.Activate();

            if (String.IsNullOrEmpty(lblDaysLeft.Text)) //�Ƿ��Ŀ�ʼʱ��
            {
                toolTip1.Show("���趨���п�ʼʱ�䣡", btnConfig, 5000);
            }
        }

        /// <summary>
        /// ��������
        /// </summary>
        private void SaveConfig()
        {
            try
            {
                string cfgFile = Path.Combine(Application.StartupPath, "PregDays.ini");
                File.WriteAllText(cfgFile,PregDate.ToShortDateString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("�޷��������ã�����" + ex.Message);
            }
        }

        /// <summary>
        /// ��ȡ����
        /// </summary>
        private void LoadConfig()
        {
            string cfgFile = Path.Combine(Application.StartupPath, "PregDays.ini");
            if (!File.Exists(cfgFile))
            {
                return;
            }
            else
            {
                try
                {
                    string dateString = File.ReadAllText(cfgFile);
                    PregDate = Convert.ToDateTime(dateString);
                }
                catch
                {
                }
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveConfig();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.littletools.cn");

            }
            catch
            {
                MessageBox.Show("�޷�����http://www.LittleTools.cn");
            }
        }
    }
}