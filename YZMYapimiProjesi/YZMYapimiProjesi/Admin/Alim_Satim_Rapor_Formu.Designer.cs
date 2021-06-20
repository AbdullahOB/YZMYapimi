
namespace YZMYapimiProjesi.Admin
{
    partial class Alim_Satim_Rapor_Formu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alim_Satim_Rapor_Formu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.alimSatimRaporBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.urnTipiCmb = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP_BaslangicTarih = new System.Windows.Forms.DateTimePicker();
            this.DTP_BitisTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ozlListle_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 526);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(399, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(33, 30);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 40;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 12);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7);
            this.label1.Size = new System.Drawing.Size(289, 47);
            this.label1.TabIndex = 38;
            this.label1.Text = "Alım / Satım Raporu";
            // 
            // alimSatimRaporBtn
            // 
            this.alimSatimRaporBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(216)))), ((int)(((byte)(104)))));
            this.alimSatimRaporBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alimSatimRaporBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(166)))), ((int)(((byte)(82)))));
            this.alimSatimRaporBtn.FlatAppearance.BorderSize = 2;
            this.alimSatimRaporBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alimSatimRaporBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alimSatimRaporBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.alimSatimRaporBtn.Location = new System.Drawing.Point(56, 453);
            this.alimSatimRaporBtn.Name = "alimSatimRaporBtn";
            this.alimSatimRaporBtn.Size = new System.Drawing.Size(334, 46);
            this.alimSatimRaporBtn.TabIndex = 41;
            this.alimSatimRaporBtn.Text = "Tüm Alım Satımları Listele";
            this.alimSatimRaporBtn.UseVisualStyleBackColor = false;
            this.alimSatimRaporBtn.Click += new System.EventHandler(this.alimSatimRaporBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(41, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 3);
            this.panel1.TabIndex = 42;
            // 
            // urnTipiCmb
            // 
            this.urnTipiCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urnTipiCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urnTipiCmb.FormattingEnabled = true;
            this.urnTipiCmb.Items.AddRange(new object[] {
            "Alım",
            "Satım"});
            this.urnTipiCmb.Location = new System.Drawing.Point(56, 121);
            this.urnTipiCmb.Name = "urnTipiCmb";
            this.urnTipiCmb.Size = new System.Drawing.Size(334, 28);
            this.urnTipiCmb.Sorted = true;
            this.urnTipiCmb.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(41, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 3);
            this.panel2.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 91);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(7);
            this.label2.Size = new System.Drawing.Size(133, 27);
            this.label2.TabIndex = 44;
            this.label2.Text = "İşlem Tipi ( Alım /Satım )";
            // 
            // DTP_BaslangicTarih
            // 
            this.DTP_BaslangicTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_BaslangicTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_BaslangicTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_BaslangicTarih.Location = new System.Drawing.Point(56, 182);
            this.DTP_BaslangicTarih.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.DTP_BaslangicTarih.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTP_BaslangicTarih.Name = "DTP_BaslangicTarih";
            this.DTP_BaslangicTarih.Size = new System.Drawing.Size(334, 29);
            this.DTP_BaslangicTarih.TabIndex = 45;
            this.DTP_BaslangicTarih.Value = new System.DateTime(2020, 6, 20, 0, 0, 0, 0);
            // 
            // DTP_BitisTarih
            // 
            this.DTP_BitisTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_BitisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_BitisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_BitisTarih.Location = new System.Drawing.Point(56, 244);
            this.DTP_BitisTarih.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.DTP_BitisTarih.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DTP_BitisTarih.Name = "DTP_BitisTarih";
            this.DTP_BitisTarih.Size = new System.Drawing.Size(334, 29);
            this.DTP_BitisTarih.TabIndex = 45;
            this.DTP_BitisTarih.Value = new System.DateTime(2021, 6, 20, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 152);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(7);
            this.label3.Size = new System.Drawing.Size(135, 27);
            this.label3.TabIndex = 44;
            this.label3.Text = "İşlem Tarihi ( Başlangıç )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 214);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(7);
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 44;
            this.label4.Text = "İşlem Tarihi ( Bitiş )";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alım",
            "Satım"});
            this.comboBox1.Location = new System.Drawing.Point(56, 306);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(334, 28);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 276);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(7);
            this.label5.Size = new System.Drawing.Size(64, 27);
            this.label5.TabIndex = 44;
            this.label5.Text = "Ürün Tipi";
            // 
            // ozlListle_btn
            // 
            this.ozlListle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(216)))), ((int)(((byte)(104)))));
            this.ozlListle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ozlListle_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(166)))), ((int)(((byte)(82)))));
            this.ozlListle_btn.FlatAppearance.BorderSize = 2;
            this.ozlListle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ozlListle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ozlListle_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.ozlListle_btn.Location = new System.Drawing.Point(175, 363);
            this.ozlListle_btn.Name = "ozlListle_btn";
            this.ozlListle_btn.Size = new System.Drawing.Size(98, 46);
            this.ozlListle_btn.TabIndex = 41;
            this.ozlListle_btn.Text = "Listele";
            this.ozlListle_btn.UseVisualStyleBackColor = false;
            this.ozlListle_btn.Click += new System.EventHandler(this.ozlListle_btn_Click);
            // 
            // Alim_Satim_Rapor_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 526);
            this.Controls.Add(this.DTP_BitisTarih);
            this.Controls.Add(this.DTP_BaslangicTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.urnTipiCmb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ozlListle_btn);
            this.Controls.Add(this.alimSatimRaporBtn);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alim_Satim_Rapor_Formu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alim_Satim_Rapor_Formu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button alimSatimRaporBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox urnTipiCmb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTP_BaslangicTarih;
        private System.Windows.Forms.DateTimePicker DTP_BitisTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ozlListle_btn;
    }
}