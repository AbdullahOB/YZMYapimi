
namespace YZMYapimiProjesi.Alici
{
    partial class ParaEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaEkleForm));
            this.PbClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbPara = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbOnaylaPara = new System.Windows.Forms.CheckBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.errProvParaEkle = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Doviz = new System.Windows.Forms.ComboBox();
            this.imageListBayraklar = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvParaEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // PbClose
            // 
            this.PbClose.BackColor = System.Drawing.Color.Transparent;
            this.PbClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PbClose.ErrorImage")));
            this.PbClose.Image = global::YZMYapimiProjesi.Properties.Resources.close_window_32px;
            this.PbClose.Location = new System.Drawing.Point(402, 13);
            this.PbClose.Name = "PbClose";
            this.PbClose.Size = new System.Drawing.Size(32, 32);
            this.PbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbClose.TabIndex = 0;
            this.PbClose.TabStop = false;
            this.PbClose.Click += new System.EventHandler(this.PbClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para Yükleme";
            // 
            // TbPara
            // 
            this.TbPara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TbPara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbPara.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPara.ForeColor = System.Drawing.Color.Black;
            this.TbPara.Location = new System.Drawing.Point(58, 164);
            this.TbPara.Name = "TbPara";
            this.TbPara.Size = new System.Drawing.Size(187, 34);
            this.TbPara.TabIndex = 2;
            this.TbPara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPara_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(58, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 4);
            this.panel1.TabIndex = 3;
            // 
            // CbOnaylaPara
            // 
            this.CbOnaylaPara.AutoSize = true;
            this.CbOnaylaPara.Location = new System.Drawing.Point(58, 204);
            this.CbOnaylaPara.Name = "CbOnaylaPara";
            this.CbOnaylaPara.Size = new System.Drawing.Size(109, 21);
            this.CbOnaylaPara.TabIndex = 5;
            this.CbOnaylaPara.Text = "Onaylıyorum";
            this.CbOnaylaPara.UseVisualStyleBackColor = true;
            // 
            // btnYukle
            // 
            this.btnYukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYukle.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYukle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnYukle.Location = new System.Drawing.Point(58, 247);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(323, 47);
            this.btnYukle.TabIndex = 24;
            this.btnYukle.Text = "Talep Gönder";
            this.btnYukle.UseVisualStyleBackColor = false;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // errProvParaEkle
            // 
            this.errProvParaEkle.ContainerControl = this;
            this.errProvParaEkle.Icon = ((System.Drawing.Icon)(resources.GetObject("errProvParaEkle.Icon")));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(53, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 30);
            this.label3.TabIndex = 25;
            this.label3.Text = "Günlük Hacim: 1000 ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(163, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 30);
            this.label4.TabIndex = 26;
            this.label4.Text = "*";
            // 
            // CB_Doviz
            // 
            this.CB_Doviz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Doviz.FormattingEnabled = true;
            this.CB_Doviz.Items.AddRange(new object[] {
            "TL",
            "USD",
            "EUR",
            "GBP"});
            this.CB_Doviz.Location = new System.Drawing.Point(251, 164);
            this.CB_Doviz.Name = "CB_Doviz";
            this.CB_Doviz.Size = new System.Drawing.Size(127, 33);
            this.CB_Doviz.TabIndex = 27;
            this.CB_Doviz.Text = "Para Birimi";
            // 
            // imageListBayraklar
            // 
            this.imageListBayraklar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBayraklar.ImageStream")));
            this.imageListBayraklar.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBayraklar.Images.SetKeyName(0, "dolar.png");
            this.imageListBayraklar.Images.SetKeyName(1, "euro.png");
            this.imageListBayraklar.Images.SetKeyName(2, "sterlin.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(228, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "(TL, USD vb...)";
            // 
            // ParaEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(449, 327);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Doviz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.CbOnaylaPara);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TbPara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParaEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvParaEkle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbPara;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CbOnaylaPara;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.ErrorProvider errProvParaEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_Doviz;
        private System.Windows.Forms.ImageList imageListBayraklar;
        private System.Windows.Forms.Label label2;
    }
}