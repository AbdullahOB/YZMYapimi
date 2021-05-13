
namespace YZMYapimiProjesi.Alici
{
    partial class AliciForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AliciForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CbUrun = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CbOnayla = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProviderMiktar = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refreshBtnNew = new System.Windows.Forms.PictureBox();
            this.Paralbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAl = new System.Windows.Forms.Button();
            this.BackBtnPic = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TbMiktar = new System.Windows.Forms.TextBox();
            this.paraYukleBtnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtnPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("D-DIN", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(95, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Merhabalar,";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("D-DIN", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(210, 27);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 21);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "{Kullanici}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("D-DIN", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(89, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Almak İstediğiniz Ürün Seçiniz";
            // 
            // CbUrun
            // 
            this.CbUrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.CbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbUrun.Font = new System.Drawing.Font("D-DIN", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbUrun.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.CbUrun.FormattingEnabled = true;
            this.CbUrun.Items.AddRange(new object[] {
            "Pamuk",
            "Yulaf",
            "Buğday"});
            this.CbUrun.Location = new System.Drawing.Point(66, 273);
            this.CbUrun.Margin = new System.Windows.Forms.Padding(2);
            this.CbUrun.Name = "CbUrun";
            this.CbUrun.Size = new System.Drawing.Size(271, 29);
            this.CbUrun.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("D-DIN", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(163, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Miktar (Kg)";
            // 
            // CbOnayla
            // 
            this.CbOnayla.AutoSize = true;
            this.CbOnayla.Font = new System.Drawing.Font("D-DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbOnayla.ForeColor = System.Drawing.Color.White;
            this.CbOnayla.Location = new System.Drawing.Point(66, 401);
            this.CbOnayla.Margin = new System.Windows.Forms.Padding(2);
            this.CbOnayla.Name = "CbOnayla";
            this.CbOnayla.Size = new System.Drawing.Size(256, 21);
            this.CbOnayla.TabIndex = 26;
            this.CbOnayla.Text = "Girdiğim ürün ve miktardan eminim";
            this.CbOnayla.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(322, 399);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "*";
            // 
            // errorProviderMiktar
            // 
            this.errorProviderMiktar.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("D-DIN", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(179, 515);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tüm İşlemlerim Geçmeşi";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(381, 508);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refreshBtnNew);
            this.groupBox1.Controls.Add(this.Paralbl);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.paraYukleBtnNew);
            this.groupBox1.Font = new System.Drawing.Font("D-DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(42, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 158);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cüzdanım";
            // 
            // refreshBtnNew
            // 
            this.refreshBtnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtnNew.Image")));
            this.refreshBtnNew.Location = new System.Drawing.Point(285, 14);
            this.refreshBtnNew.Name = "refreshBtnNew";
            this.refreshBtnNew.Size = new System.Drawing.Size(43, 36);
            this.refreshBtnNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshBtnNew.TabIndex = 1;
            this.refreshBtnNew.TabStop = false;
            this.refreshBtnNew.Click += new System.EventHandler(this.refreshBtnNew_Click);
            // 
            // Paralbl
            // 
            this.Paralbl.AutoSize = true;
            this.Paralbl.Font = new System.Drawing.Font("D-DIN", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paralbl.Location = new System.Drawing.Point(167, 63);
            this.Paralbl.Name = "Paralbl";
            this.Paralbl.Size = new System.Drawing.Size(48, 26);
            this.Paralbl.TabIndex = 0;
            this.Paralbl.Text = "000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("D-DIN", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(248, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "TL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("D-DIN", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mevcut Para: ";
            // 
            // btnAl
            // 
            this.btnAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(216)))), ((int)(((byte)(104)))));
            this.btnAl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(166)))), ((int)(((byte)(82)))));
            this.btnAl.FlatAppearance.BorderSize = 2;
            this.btnAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAl.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnAl.Location = new System.Drawing.Point(54, 446);
            this.btnAl.Margin = new System.Windows.Forms.Padding(2);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(302, 32);
            this.btnAl.TabIndex = 28;
            this.btnAl.Text = "Ürün Al";
            this.btnAl.UseVisualStyleBackColor = false;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // BackBtnPic
            // 
            this.BackBtnPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtnPic.Image = ((System.Drawing.Image)(resources.GetObject("BackBtnPic.Image")));
            this.BackBtnPic.Location = new System.Drawing.Point(12, 12);
            this.BackBtnPic.Name = "BackBtnPic";
            this.BackBtnPic.Size = new System.Drawing.Size(39, 36);
            this.BackBtnPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackBtnPic.TabIndex = 36;
            this.BackBtnPic.TabStop = false;
            this.BackBtnPic.Click += new System.EventHandler(this.BackBtnPic_Click);
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(376, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(39, 36);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 37;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 554);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // TbMiktar
            // 
            this.TbMiktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.TbMiktar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMiktar.Font = new System.Drawing.Font("D-DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMiktar.ForeColor = System.Drawing.SystemColors.Window;
            this.TbMiktar.Location = new System.Drawing.Point(66, 360);
            this.TbMiktar.MaximumSize = new System.Drawing.Size(500, 500);
            this.TbMiktar.MinimumSize = new System.Drawing.Size(2, 26);
            this.TbMiktar.Name = "TbMiktar";
            this.TbMiktar.Size = new System.Drawing.Size(271, 25);
            this.TbMiktar.TabIndex = 50;
            this.TbMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbMiktar_KeyPress_1);
            // 
            // paraYukleBtnNew
            // 
            this.paraYukleBtnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(216)))), ((int)(((byte)(104)))));
            this.paraYukleBtnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(166)))), ((int)(((byte)(82)))));
            this.paraYukleBtnNew.FlatAppearance.BorderSize = 2;
            this.paraYukleBtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paraYukleBtnNew.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paraYukleBtnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.paraYukleBtnNew.Location = new System.Drawing.Point(101, 111);
            this.paraYukleBtnNew.Margin = new System.Windows.Forms.Padding(2);
            this.paraYukleBtnNew.Name = "paraYukleBtnNew";
            this.paraYukleBtnNew.Size = new System.Drawing.Size(127, 32);
            this.paraYukleBtnNew.TabIndex = 28;
            this.paraYukleBtnNew.Text = "Para Yükle";
            this.paraYukleBtnNew.UseVisualStyleBackColor = false;
            this.paraYukleBtnNew.Click += new System.EventHandler(this.paraYukleBtnNew_Click);
            // 
            // AliciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(427, 554);
            this.Controls.Add(this.TbMiktar);
            this.Controls.Add(this.BackBtnPic);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbOnayla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbUrun);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AliciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALICI";
            this.Load += new System.EventHandler(this.AliciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtnPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbUrun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CbOnayla;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProviderMiktar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox refreshBtnNew;
        private System.Windows.Forms.Label Paralbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.PictureBox BackBtnPic;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TbMiktar;
        private System.Windows.Forms.Button paraYukleBtnNew;
    }
}