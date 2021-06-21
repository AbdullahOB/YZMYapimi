
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
            this.PbClose.Location = new System.Drawing.Point(302, 11);
            this.PbClose.Margin = new System.Windows.Forms.Padding(2);
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
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para Yükleme";
            // 
            // TbPara
            // 
            this.TbPara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TbPara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbPara.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPara.ForeColor = System.Drawing.Color.Black;
            this.TbPara.Location = new System.Drawing.Point(44, 133);
            this.TbPara.Margin = new System.Windows.Forms.Padding(2);
            this.TbPara.Name = "TbPara";
            this.TbPara.Size = new System.Drawing.Size(140, 27);
            this.TbPara.TabIndex = 2;
            this.TbPara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPara_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(44, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 3);
            this.panel1.TabIndex = 3;
            // 
            // CbOnaylaPara
            // 
            this.CbOnaylaPara.AutoSize = true;
            this.CbOnaylaPara.Location = new System.Drawing.Point(44, 166);
            this.CbOnaylaPara.Margin = new System.Windows.Forms.Padding(2);
            this.CbOnaylaPara.Name = "CbOnaylaPara";
            this.CbOnaylaPara.Size = new System.Drawing.Size(83, 17);
            this.CbOnaylaPara.TabIndex = 5;
            this.CbOnaylaPara.Text = "Onaylıyorum";
            this.CbOnaylaPara.UseVisualStyleBackColor = true;
            // 
            // btnYukle
            // 
            this.btnYukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYukle.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYukle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnYukle.Location = new System.Drawing.Point(44, 201);
            this.btnYukle.Margin = new System.Windows.Forms.Padding(2);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(242, 38);
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
            this.label3.Location = new System.Drawing.Point(40, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Günlük Hacim: 1000 ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(122, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "*";
            // 
            // CB_Doviz
            // 
            this.CB_Doviz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Doviz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Doviz.FormattingEnabled = true;
            this.CB_Doviz.Items.AddRange(new object[] {
            "TL",
            "USD",
            "EUR",
            "GBP"});
            this.CB_Doviz.Location = new System.Drawing.Point(188, 133);
            this.CB_Doviz.Margin = new System.Windows.Forms.Padding(2);
            this.CB_Doviz.Name = "CB_Doviz";
            this.CB_Doviz.Size = new System.Drawing.Size(96, 28);
            this.CB_Doviz.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(171, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "(TL, USD vb...)";
            // 
            // ParaEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(337, 266);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label2;
    }
}