
namespace YZMYapimiProjesi.Satici
{
    partial class SaticiForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.isimlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UrunEkbtn = new System.Windows.Forms.Button();
            this.UrunSilbtn = new System.Windows.Forms.Button();
            this.onayBekleyenUrnLst = new System.Windows.Forms.ListView();
            this.ReqId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urnAdiCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urnMiktari = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urnFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stoktaLst = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stoktaUrnSilBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPara = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PbRefresh = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(644, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Merhaba";
            // 
            // isimlabel
            // 
            this.isimlabel.AutoSize = true;
            this.isimlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isimlabel.Location = new System.Drawing.Point(730, 9);
            this.isimlabel.Name = "isimlabel";
            this.isimlabel.Size = new System.Drawing.Size(58, 22);
            this.isimlabel.TabIndex = 2;
            this.isimlabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stokta Ürünlar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Onay Bekleyen Ürün Listesi";
            // 
            // UrunEkbtn
            // 
            this.UrunEkbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunEkbtn.Location = new System.Drawing.Point(470, 117);
            this.UrunEkbtn.Name = "UrunEkbtn";
            this.UrunEkbtn.Size = new System.Drawing.Size(102, 42);
            this.UrunEkbtn.TabIndex = 7;
            this.UrunEkbtn.Text = "Ürün Ekle";
            this.UrunEkbtn.UseVisualStyleBackColor = true;
            this.UrunEkbtn.Click += new System.EventHandler(this.UrunEkbtn_Click);
            // 
            // UrunSilbtn
            // 
            this.UrunSilbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunSilbtn.Location = new System.Drawing.Point(24, 435);
            this.UrunSilbtn.Name = "UrunSilbtn";
            this.UrunSilbtn.Size = new System.Drawing.Size(102, 42);
            this.UrunSilbtn.TabIndex = 7;
            this.UrunSilbtn.Text = "Ürün Sil";
            this.UrunSilbtn.UseVisualStyleBackColor = true;
            this.UrunSilbtn.Click += new System.EventHandler(this.UrunSilbtn_Click);
            // 
            // onayBekleyenUrnLst
            // 
            this.onayBekleyenUrnLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ReqId,
            this.urnAdiCol,
            this.urnMiktari,
            this.urnFiyat});
            this.onayBekleyenUrnLst.Font = new System.Drawing.Font("D-DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onayBekleyenUrnLst.ForeColor = System.Drawing.SystemColors.GrayText;
            this.onayBekleyenUrnLst.FullRowSelect = true;
            this.onayBekleyenUrnLst.HideSelection = false;
            this.onayBekleyenUrnLst.Location = new System.Drawing.Point(24, 98);
            this.onayBekleyenUrnLst.Name = "onayBekleyenUrnLst";
            this.onayBekleyenUrnLst.Size = new System.Drawing.Size(440, 331);
            this.onayBekleyenUrnLst.TabIndex = 16;
            this.onayBekleyenUrnLst.UseCompatibleStateImageBehavior = false;
            this.onayBekleyenUrnLst.View = System.Windows.Forms.View.Details;
            this.onayBekleyenUrnLst.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.onayBekleyenUrnLst_MouseDoubleClick);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YZMYapimiProjesi.Properties.Resources.iconfinder_arrow_left_circle_1303871;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // stoktaLst
            // 
            this.stoktaLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.stoktaLst.Font = new System.Drawing.Font("D-DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoktaLst.ForeColor = System.Drawing.SystemColors.GrayText;
            this.stoktaLst.FullRowSelect = true;
            this.stoktaLst.HideSelection = false;
            this.stoktaLst.Location = new System.Drawing.Point(589, 98);
            this.stoktaLst.Name = "stoktaLst";
            this.stoktaLst.Size = new System.Drawing.Size(440, 331);
            this.stoktaLst.TabIndex = 17;
            this.stoktaLst.UseCompatibleStateImageBehavior = false;
            this.stoktaLst.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stok Id";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Urun Adi";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Urun Miktari";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Urun Fiyat";
            this.columnHeader4.Width = 94;
            // 
            // stoktaUrnSilBtn
            // 
            this.stoktaUrnSilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoktaUrnSilBtn.Location = new System.Drawing.Point(589, 435);
            this.stoktaUrnSilBtn.Name = "stoktaUrnSilBtn";
            this.stoktaUrnSilBtn.Size = new System.Drawing.Size(102, 42);
            this.stoktaUrnSilBtn.TabIndex = 7;
            this.stoktaUrnSilBtn.Text = "Ürün Sil";
            this.stoktaUrnSilBtn.UseVisualStyleBackColor = true;
            this.stoktaUrnSilBtn.Click += new System.EventHandler(this.StoktaUrunSilbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(140, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 2);
            this.panel2.TabIndex = 27;
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPara.Location = new System.Drawing.Point(137, 89);
            this.lblPara.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(58, 29);
            this.lblPara.TabIndex = 26;
            this.lblPara.Text = "00000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mevcut Para:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(20, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 39);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cüzdanım";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblPara);
            this.panel1.Controls.Add(this.PbRefresh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(358, 540);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 153);
            this.panel1.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Location = new System.Drawing.Point(26, 47);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 3);
            this.panel3.TabIndex = 31;
            // 
            // PbRefresh
            // 
            this.PbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbRefresh.Image = global::YZMYapimiProjesi.Properties.Resources.icons8_refresh_641;
            this.PbRefresh.Location = new System.Drawing.Point(238, 3);
            this.PbRefresh.Name = "PbRefresh";
            this.PbRefresh.Size = new System.Drawing.Size(30, 28);
            this.PbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbRefresh.TabIndex = 29;
            this.PbRefresh.TabStop = false;
            this.PbRefresh.Click += new System.EventHandler(this.PbRefresh_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = global::YZMYapimiProjesi.Properties.Resources.icons8_downward_arrow_641;
            this.pictureBox2.Location = new System.Drawing.Point(591, 514);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 10.8F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(355, 507);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 27);
            this.label8.TabIndex = 32;
            this.label8.Text = "Güncel Paranızı Görüntülemek İçin";
            // 
            // SaticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 819);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stoktaLst);
            this.Controls.Add(this.onayBekleyenUrnLst);
            this.Controls.Add(this.stoktaUrnSilBtn);
            this.Controls.Add(this.UrunSilbtn);
            this.Controls.Add(this.UrunEkbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isimlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SaticiForm";
            this.Text = "SaticiForm";
            this.Load += new System.EventHandler(this.SaticiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label isimlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UrunEkbtn;
        private System.Windows.Forms.Button UrunSilbtn;
        public System.Windows.Forms.ListView onayBekleyenUrnLst;
        private System.Windows.Forms.ColumnHeader urnAdiCol;
        private System.Windows.Forms.ColumnHeader urnMiktari;
        private System.Windows.Forms.ColumnHeader urnFiyat;
        private System.Windows.Forms.ColumnHeader ReqId;
        public System.Windows.Forms.ListView stoktaLst;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button stoktaUrnSilBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox PbRefresh;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
    }
}