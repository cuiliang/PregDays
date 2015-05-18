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
        /// 怀孕开始日期
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
        /// 更新时间显示
        /// </summary>
        private void UpdateDays()
        {
            TimeSpan span = DateTime.Now.Date - PregDate.Date;
            if (span.TotalDays < 15 || span.TotalDays>300)
            {
                lblPregDays.Text = "请设定怀孕开始时间！";
                lblDaysLeft.Text = "";
            }
            else
            {
                int nTotalDays = Convert.ToInt32(Math.Ceiling(span.TotalDays));
                int nWeek = nTotalDays / 7 + 1;
                int nDays = nTotalDays % 7 + 1;

                StringBuilder sb = new StringBuilder();

                lblPregDays.Text = "怀孕第" + (nTotalDays + 1).ToString() + "天，第" + nWeek.ToString() + "周第" + nDays.ToString() + "天(" + (nWeek - 1).ToString() + "w+" + (nDays).ToString() + "d)";
               

                int nTotalLeftDays = 280 - nTotalDays - 1;
                int nLeftWeek = nTotalLeftDays / 7;
                int nLeftDays = nTotalLeftDays % 7;

                DateTime birthDay = PregDate + (new TimeSpan(280, 0, 0, 0));
                lblDaysLeft.Text = "预产期为" + birthDay.ToString("yyyy年M月d日") +"，还有" + nTotalLeftDays.ToString() + "天（" + nLeftWeek.ToString() + "周" + nLeftDays.ToString() + "天）";

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

            if (String.IsNullOrEmpty(lblDaysLeft.Text)) //非法的开始时间
            {
                toolTip1.Show("请设定怀孕开始时间！", btnConfig, 5000);
            }
        }

        /// <summary>
        /// 保存配置
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
                MessageBox.Show("无法保存配置！错误：" + ex.Message);
            }
        }

        /// <summary>
        /// 读取配置
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
                MessageBox.Show("无法访问http://www.LittleTools.cn");
            }
        }
    }
}