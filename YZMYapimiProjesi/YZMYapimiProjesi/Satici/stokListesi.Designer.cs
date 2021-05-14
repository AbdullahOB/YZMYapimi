
namespace YZMYapimiProjesi.Satici
{
    partial class stokListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stokListesi));
            this.stoktaLst = new System.Windows.Forms.ListView();
            this.ReqId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urnAdiCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urnMiktari = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urnFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.urnSilBtn = new System.Windows.Forms.Button();
            this.BackBtnPic = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtnPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stoktaLst
            // 
            this.stoktaLst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.stoktaLst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stoktaLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ReqId,
            this.urnAdiCol,
            this.urnMiktari,
            this.urnFiyat});
            this.stoktaLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoktaLst.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.stoktaLst.FullRowSelect = true;
            this.stoktaLst.HideSelection = false;
            this.stoktaLst.Location = new System.Drawing.Point(48, 143);
            this.stoktaLst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stoktaLst.Name = "stoktaLst";
            this.stoktaLst.Size = new System.Drawing.Size(532, 418);
            this.stoktaLst.TabIndex = 17;
            this.stoktaLst.UseCompatibleStateImageBehavior = false;
            this.stoktaLst.View = System.Windows.Forms.View.Details;
            // 
            // ReqId
            // 
            this.ReqId.Text = "Request Id";
            this.ReqId.Width = 124;
            // 
            // urnAdiCol
            // 
            this.urnAdiCol.Text = "Urun Adi";
            this.urnAdiCol.Width = 142;
            // 
            // urnMiktari
            // 
            this.urnMiktari.Text = "Urun Miktari";
            this.urnMiktari.Width = 149;
            // 
            // urnFiyat
            // 
            this.urnFiyat.Text = "Urun Fiyat";
            this.urnFiyat.Width = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(188, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Stokta Ürünler";
            // 
            // urnSilBtn
            // 
            this.urnSilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(216)))), ((int)(((byte)(104)))));
            this.urnSilBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urnSilBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(166)))), ((int)(((byte)(82)))));
            this.urnSilBtn.FlatAppearance.BorderSize = 2;
            this.urnSilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urnSilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urnSilBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.urnSilBtn.Location = new System.Drawing.Point(87, 569);
            this.urnSilBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.urnSilBtn.Name = "urnSilBtn";
            this.urnSilBtn.Size = new System.Drawing.Size(445, 42);
            this.urnSilBtn.TabIndex = 39;
            this.urnSilBtn.Text = "Ürün Sil";
            this.urnSilBtn.UseVisualStyleBackColor = false;
            this.urnSilBtn.Click += new System.EventHandler(this.urnSilBtn_Click);
            // 
            // BackBtnPic
            // 
            this.BackBtnPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtnPic.Image = ((System.Drawing.Image)(resources.GetObject("BackBtnPic.Image")));
            this.BackBtnPic.Location = new System.Drawing.Point(48, 30);
            this.BackBtnPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackBtnPic.Name = "BackBtnPic";
            this.BackBtnPic.Size = new System.Drawing.Size(52, 44);
            this.BackBtnPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackBtnPic.TabIndex = 36;
            this.BackBtnPic.TabStop = false;
            this.BackBtnPic.Click += new System.EventHandler(this.BackBtnPic_Click);
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(528, 30);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(52, 44);
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 677);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // stokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(627, 677);
            this.Controls.Add(this.urnSilBtn);
            this.Controls.Add(this.BackBtnPic);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stoktaLst);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "stokListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.stokListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackBtnPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView stoktaLst;
        private System.Windows.Forms.ColumnHeader ReqId;
        private System.Windows.Forms.ColumnHeader urnAdiCol;
        private System.Windows.Forms.ColumnHeader urnMiktari;
        private System.Windows.Forms.ColumnHeader urnFiyat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BackBtnPic;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Button urnSilBtn;
    }
}