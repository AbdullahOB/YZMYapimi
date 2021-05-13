
using YZMYapimiProjesi.Admin.Assets;

namespace YZMYapimiProjesi.Satici
{
    partial class UrunEkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEkForm));
            this.gonderBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.urnSecCmBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackBtnPic = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.urnMiktarTxtBox = new System.Windows.Forms.TextBox();
            this.urnFiyatTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtnPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // gonderBtn
            // 
            this.gonderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(216)))), ((int)(((byte)(104)))));
            this.gonderBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gonderBtn.FlatAppearance.BorderSize = 2;
            this.gonderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gonderBtn.Font = new System.Drawing.Font("D-DIN", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gonderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.gonderBtn.Location = new System.Drawing.Point(40, 387);
            this.gonderBtn.Name = "gonderBtn";
            this.gonderBtn.Size = new System.Drawing.Size(334, 44);
            this.gonderBtn.TabIndex = 3;
            this.gonderBtn.Text = "Talep Gönder";
            this.gonderBtn.UseVisualStyleBackColor = false;
            this.gonderBtn.Click += new System.EventHandler(this.talepGonderBtnFun);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("D-DIN", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(121, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ürün Birim Fiyati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("D-DIN", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(145, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ürün Miktarı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("D-DIN", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(148, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ürün Seçin";
            // 
            // urnSecCmBox
            // 
            this.urnSecCmBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.urnSecCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urnSecCmBox.Font = new System.Drawing.Font("D-DIN", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urnSecCmBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.urnSecCmBox.FormattingEnabled = true;
            this.urnSecCmBox.Items.AddRange(new object[] {
            "Buğday",
            "Pamuk",
            "Yulaf"});
            this.urnSecCmBox.Location = new System.Drawing.Point(125, 112);
            this.urnSecCmBox.Name = "urnSecCmBox";
            this.urnSecCmBox.Size = new System.Drawing.Size(152, 31);
            this.urnSecCmBox.Sorted = true;
            this.urnSecCmBox.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 511);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // BackBtnPic
            // 
            this.BackBtnPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtnPic.Image = ((System.Drawing.Image)(resources.GetObject("BackBtnPic.Image")));
            this.BackBtnPic.Location = new System.Drawing.Point(21, 26);
            this.BackBtnPic.Name = "BackBtnPic";
            this.BackBtnPic.Size = new System.Drawing.Size(39, 36);
            this.BackBtnPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackBtnPic.TabIndex = 43;
            this.BackBtnPic.TabStop = false;
            this.BackBtnPic.Click += new System.EventHandler(this.BackBtnPic_Click_1);
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(365, 26);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(39, 36);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 44;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // urnMiktarTxtBox
            // 
            this.urnMiktarTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.urnMiktarTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urnMiktarTxtBox.Font = new System.Drawing.Font("D-DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urnMiktarTxtBox.ForeColor = System.Drawing.SystemColors.Window;
            this.urnMiktarTxtBox.Location = new System.Drawing.Point(125, 208);
            this.urnMiktarTxtBox.MaximumSize = new System.Drawing.Size(500, 500);
            this.urnMiktarTxtBox.MinimumSize = new System.Drawing.Size(2, 26);
            this.urnMiktarTxtBox.Name = "urnMiktarTxtBox";
            this.urnMiktarTxtBox.Size = new System.Drawing.Size(152, 25);
            this.urnMiktarTxtBox.TabIndex = 45;
            this.urnMiktarTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urnMiktarTxtBox_KeyPress_1);
            // 
            // urnFiyatTxtBox
            // 
            this.urnFiyatTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.urnFiyatTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urnFiyatTxtBox.Font = new System.Drawing.Font("D-DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urnFiyatTxtBox.ForeColor = System.Drawing.SystemColors.Window;
            this.urnFiyatTxtBox.Location = new System.Drawing.Point(125, 322);
            this.urnFiyatTxtBox.MaximumSize = new System.Drawing.Size(500, 500);
            this.urnFiyatTxtBox.MinimumSize = new System.Drawing.Size(2, 26);
            this.urnFiyatTxtBox.Name = "urnFiyatTxtBox";
            this.urnFiyatTxtBox.Size = new System.Drawing.Size(152, 25);
            this.urnFiyatTxtBox.TabIndex = 46;
            this.urnFiyatTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urnFiyatTxtBox_KeyPress);
            // 
            // UrunEkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(429, 511);
            this.Controls.Add(this.urnFiyatTxtBox);
            this.Controls.Add(this.urnMiktarTxtBox);
            this.Controls.Add(this.BackBtnPic);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urnSecCmBox);
            this.Controls.Add(this.gonderBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrunEkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunEkForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtnPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button gonderBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox urnSecCmBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BackBtnPic;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.TextBox urnMiktarTxtBox;
        private System.Windows.Forms.TextBox urnFiyatTxtBox;
    }
}