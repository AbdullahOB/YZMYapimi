
namespace YZMYapimiProjesi.Admin
{
    partial class onayBekleyenLstFormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(onayBekleyenLstFormAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.onayBekleyenUrnLst = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BackBtnPic = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtnPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(214, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 39);
            this.label1.TabIndex = 21;
            this.label1.Text = "Onay Bekleyen Ürün Listesi";
            // 
            // onayBekleyenUrnLst
            // 
            this.onayBekleyenUrnLst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.onayBekleyenUrnLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.onayBekleyenUrnLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onayBekleyenUrnLst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.onayBekleyenUrnLst.FullRowSelect = true;
            this.onayBekleyenUrnLst.HideSelection = false;
            this.onayBekleyenUrnLst.Location = new System.Drawing.Point(49, 99);
            this.onayBekleyenUrnLst.Margin = new System.Windows.Forms.Padding(4);
            this.onayBekleyenUrnLst.Name = "onayBekleyenUrnLst";
            this.onayBekleyenUrnLst.Size = new System.Drawing.Size(773, 464);
            this.onayBekleyenUrnLst.TabIndex = 43;
            this.onayBekleyenUrnLst.UseCompatibleStateImageBehavior = false;
            this.onayBekleyenUrnLst.View = System.Windows.Forms.View.Details;
            this.onayBekleyenUrnLst.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.onayBekleyenUrnLst_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Request Id";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kullanici Id";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mesaj";
            this.columnHeader3.Width = 174;
            // 
            // BackBtnPic
            // 
            this.BackBtnPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtnPic.Image = ((System.Drawing.Image)(resources.GetObject("BackBtnPic.Image")));
            this.BackBtnPic.Location = new System.Drawing.Point(49, 32);
            this.BackBtnPic.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtnPic.Name = "BackBtnPic";
            this.BackBtnPic.Size = new System.Drawing.Size(52, 44);
            this.BackBtnPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackBtnPic.TabIndex = 40;
            this.BackBtnPic.TabStop = false;
            this.BackBtnPic.Click += new System.EventHandler(this.BackBtnPic_Click);
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(770, 32);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(52, 44);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 41;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(872, 599);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // onayBekleyenLstFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(872, 599);
            this.Controls.Add(this.onayBekleyenUrnLst);
            this.Controls.Add(this.BackBtnPic);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "onayBekleyenLstFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "onayBekleyenLstFormAdmin";
            this.Load += new System.EventHandler(this.onayBekleyenLstFormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackBtnPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BackBtnPic;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ListView onayBekleyenUrnLst;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}