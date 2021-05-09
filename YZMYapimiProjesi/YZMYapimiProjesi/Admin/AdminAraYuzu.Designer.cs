
namespace YZMYapimiProjesi.Admin
{
    partial class AdminAraYuzu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAraYuzu));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aliciParaEklemeLst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KullaniciLstBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.onayBekleyenUrnLst = new System.Windows.Forms.ListBox();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("D-DIN", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(404, 232);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(7);
            this.label3.Size = new System.Drawing.Size(294, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Alıcı Para Ekleme Talepleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("D-DIN", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(90, 232);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(7);
            this.label2.Size = new System.Drawing.Size(301, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Onay Bekleyen Ürün Listesi";
            // 
            // aliciParaEklemeLst
            // 
            this.aliciParaEklemeLst.AllowDrop = true;
            this.aliciParaEklemeLst.BackColor = System.Drawing.SystemColors.HighlightText;
            this.aliciParaEklemeLst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aliciParaEklemeLst.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aliciParaEklemeLst.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aliciParaEklemeLst.FormattingEnabled = true;
            this.aliciParaEklemeLst.ItemHeight = 16;
            this.aliciParaEklemeLst.Items.AddRange(new object[] {
            "Abdullah 300TL Ekleme İstedi",
            "Mahmoud 200TL Ekleme İstedi",
            "Abdulselam 200TL Ekleme İstedi"});
            this.aliciParaEklemeLst.Location = new System.Drawing.Point(419, 275);
            this.aliciParaEklemeLst.Name = "aliciParaEklemeLst";
            this.aliciParaEklemeLst.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aliciParaEklemeLst.Size = new System.Drawing.Size(279, 258);
            this.aliciParaEklemeLst.TabIndex = 5;
            this.aliciParaEklemeLst.SelectedIndexChanged += new System.EventHandler(this.aliciParaEklemeLst_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("D-DIN Condensed", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(519, 12);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7);
            this.label1.Size = new System.Drawing.Size(218, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Merhaba, Admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // KullaniciLstBtn
            // 
            this.KullaniciLstBtn.BackColor = System.Drawing.Color.IndianRed;
            this.KullaniciLstBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.KullaniciLstBtn.FlatAppearance.BorderSize = 0;
            this.KullaniciLstBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.KullaniciLstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KullaniciLstBtn.Font = new System.Drawing.Font("D-DIN", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KullaniciLstBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.KullaniciLstBtn.Location = new System.Drawing.Point(952, 152);
            this.KullaniciLstBtn.Name = "KullaniciLstBtn";
            this.KullaniciLstBtn.Size = new System.Drawing.Size(263, 43);
            this.KullaniciLstBtn.TabIndex = 12;
            this.KullaniciLstBtn.Text = "Kullanıcılar Listesi";
            this.KullaniciLstBtn.UseVisualStyleBackColor = false;
            this.KullaniciLstBtn.Click += new System.EventHandler(this.kullanicilarListesiKaydet);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("D-DIN", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(952, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Alım Satım Raporu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.alimSatimRaporuKaydet);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(728, 275);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(7);
            this.label4.Size = new System.Drawing.Size(387, 47);
            this.label4.TabIndex = 1;
            this.label4.Text = "*Listeki elemanını onaylamak için";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(855, 322);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(7);
            this.label5.Size = new System.Drawing.Size(120, 47);
            this.label5.TabIndex = 1;
            this.label5.Text = " çift tıkla";
            // 
            // onayBekleyenUrnLst
            // 
            this.onayBekleyenUrnLst.AllowDrop = true;
            this.onayBekleyenUrnLst.BackColor = System.Drawing.SystemColors.HighlightText;
            this.onayBekleyenUrnLst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.onayBekleyenUrnLst.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onayBekleyenUrnLst.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.onayBekleyenUrnLst.FormattingEnabled = true;
            this.onayBekleyenUrnLst.ItemHeight = 16;
            this.onayBekleyenUrnLst.Items.AddRange(new object[] {
            "Ahmet 300KG Buğday Eklemek İstedi",
            "Halit 200KG Pamuk Eklemek İstedi",
            "Muhammet 100KG Yulaf Eklemek İstedi"});
            this.onayBekleyenUrnLst.Location = new System.Drawing.Point(95, 275);
            this.onayBekleyenUrnLst.Name = "onayBekleyenUrnLst";
            this.onayBekleyenUrnLst.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.onayBekleyenUrnLst.Size = new System.Drawing.Size(279, 258);
            this.onayBekleyenUrnLst.TabIndex = 5;
            this.onayBekleyenUrnLst.SelectedIndexChanged += new System.EventHandler(this.onayBekleyenUrnLst_SelectedIndexChanged);
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.ExitBtn.Location = new System.Drawing.Point(1189, 9);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(42, 45);
            this.ExitBtn.TabIndex = 13;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtnFun);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.geriDonButonu);
            // 
            // AdminAraYuzu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1243, 628);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KullaniciLstBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.onayBekleyenUrnLst);
            this.Controls.Add(this.aliciParaEklemeLst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAraYuzu";
            this.Text = "AdminAraYuzu";
            this.Load += new System.EventHandler(this.AdminAraYuzu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox aliciParaEklemeLst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button KullaniciLstBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox onayBekleyenUrnLst;
        private System.Windows.Forms.Label ExitBtn;
    }
}