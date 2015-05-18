namespace PregDays
{
    partial class FormAbout
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
            this.lnkAddComment = new System.Windows.Forms.LinkLabel();
            this.lnkProductHome = new System.Windows.Forms.LinkLabel();
            this.lnkSiteHome = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblThanks = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkAddComment
            // 
            this.lnkAddComment.AutoSize = true;
            this.lnkAddComment.Location = new System.Drawing.Point(151, 128);
            this.lnkAddComment.Name = "lnkAddComment";
            this.lnkAddComment.Size = new System.Drawing.Size(79, 13);
            this.lnkAddComment.TabIndex = 18;
            this.lnkAddComment.TabStop = true;
            this.lnkAddComment.Text = "提交反馈信息";
            this.lnkAddComment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddComment_LinkClicked);
            // 
            // lnkProductHome
            // 
            this.lnkProductHome.AutoSize = true;
            this.lnkProductHome.Location = new System.Drawing.Point(151, 103);
            this.lnkProductHome.Name = "lnkProductHome";
            this.lnkProductHome.Size = new System.Drawing.Size(103, 13);
            this.lnkProductHome.TabIndex = 17;
            this.lnkProductHome.TabStop = true;
            this.lnkProductHome.Text = "访问本软件的首页";
            this.lnkProductHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkProductHome_LinkClicked);
            // 
            // lnkSiteHome
            // 
            this.lnkSiteHome.AutoSize = true;
            this.lnkSiteHome.Location = new System.Drawing.Point(151, 78);
            this.lnkSiteHome.Name = "lnkSiteHome";
            this.lnkSiteHome.Size = new System.Drawing.Size(202, 13);
            this.lnkSiteHome.TabIndex = 16;
            this.lnkSiteHome.TabStop = true;
            this.lnkSiteHome.Text = "访问LittleTools.cn查看本网站其他作品";
            this.lnkSiteHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSiteHome_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::PregDays.Properties.Resources.site_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Location = new System.Drawing.Point(151, 50);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(178, 13);
            this.lblThanks.TabIndex = 14;
            this.lblThanks.Text = "感谢您使用LittleTools.cn的作品。";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(146, 12);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(54, 13);
            this.lblVersion.TabIndex = 19;
            this.lblVersion.Text = "Version：";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(277, 177);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 214);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lnkAddComment);
            this.Controls.Add(this.lnkProductHome);
            this.Controls.Add(this.lnkSiteHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblThanks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "软件信息";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkAddComment;
        private System.Windows.Forms.LinkLabel lnkProductHome;
        private System.Windows.Forms.LinkLabel lnkSiteHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnClose;
    }
}