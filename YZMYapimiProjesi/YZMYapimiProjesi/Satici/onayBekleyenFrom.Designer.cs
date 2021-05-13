
namespace YZMYapimiProjesi.Satici
{
    partial class onayBekleyenFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(onayBekleyenFrom));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.onayBekleyenLst = new System.Windows.Forms.ListView();
            this.ReqId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urnAdiCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urnMiktari = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urnFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtnPic = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.urnSilBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtnPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 526);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // onayBekleyenLst
            // 
            this.onayBekleyenLst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.onayBekleyenLst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.onayBekleyenLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ReqId,
            this.urnAdiCol,
            this.urnMiktari,
            this.urnFiyat});
            this.onayBekleyenLst.Font = new System.Drawing.Font("D-DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onayBekleyenLst.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.onayBekleyenLst.FullRowSelect = true;
            this.onayBekleyenLst.HideSelection = false;
            this.onayBekleyenLst.Location = new System.Drawing.Point(29, 125);
            this.onayBekleyenLst.Name = "onayBekleyenLst";
            this.onayBekleyenLst.Size = new System.Drawing.Size(396, 299);
            this.onayBekleyenLst.TabIndex = 18;
            this.onayBekleyenLst.UseCompatibleStateImageBehavior = false;
            this.onayBekleyenLst.View = System.Windows.Forms.View.Details;
            this.onayBekleyenLst.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.onayBekleyenLst_MouseDoubleClick);
            // 
            // ReqId
            // 
            this.ReqId.Text = "Request Id";
            this.ReqId.Width = 94;
            // 
            // urnAdiCol
            // 
            this.urnAdiCol.Text = "Urun Adi";
            this.urnAdiCol.Width = 79;
            // 
            // urnMiktari
            // 
            this.urnMiktari.Text = "Urun Miktari";
            this.urnMiktari.Width = 100;
            // 
            // urnFiyat
            // 
            this.urnFiyat.Text = "Urun Fiyat";
            this.urnFiyat.Width = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("D-DIN", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(76, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Onay Bekleyen Ürün Listesi";
            // 
            // BackBtnPic
            // 
            this.BackBtnPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtnPic.Image = ((System.Drawing.Image)(resources.GetObject("BackBtnPic.Image")));
            this.BackBtnPic.Location = new System.Drawing.Point(29, 26);
            this.BackBtnPic.Name = "BackBtnPic";
            this.BackBtnPic.Size = new System.Drawing.Size(39, 36);
            this.BackBtnPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackBtnPic.TabIndex = 38;
            this.BackBtnPic.TabStop = false;
            this.BackBtnPic.Click += new System.EventHandler(this.BackBtnPic_Click);
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(386, 26);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(39, 36);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 39;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // urnSilBtn
            // 
            this.urnSilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(216)))), ((int)(((byte)(104)))));
            this.urnSilBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urnSilBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(166)))), ((int)(((byte)(82)))));
            this.urnSilBtn.FlatAppearance.BorderSize = 2;
            this.urnSilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urnSilBtn.Font = new System.Drawing.Font("D-DIN", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urnSilBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.urnSilBtn.Location = new System.Drawing.Point(59, 442);
            this.urnSilBtn.Name = "urnSilBtn";
            this.urnSilBtn.Size = new System.Drawing.Size(334, 34);
            this.urnSilBtn.TabIndex = 40;
            this.urnSilBtn.Text = "Ürün Sil";
            this.urnSilBtn.UseVisualStyleBackColor = false;
            this.urnSilBtn.Click += new System.EventHandler(this.urnSilBtn_Click);
            // 
            // onayBekleyenFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(454, 526);
            this.Controls.Add(this.urnSilBtn);
            this.Controls.Add(this.BackBtnPic);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onayBekleyenLst);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "onayBekleyenFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "onayBekleyenFrom";
            this.Load += new System.EventHandler(this.onayBekleyenFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtnPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ListView onayBekleyenLst;
        private System.Windows.Forms.ColumnHeader ReqId;
        private System.Windows.Forms.ColumnHeader urnAdiCol;
        private System.Windows.Forms.ColumnHeader urnMiktari;
        private System.Windows.Forms.ColumnHeader urnFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BackBtnPic;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Button urnSilBtn;
    }
}