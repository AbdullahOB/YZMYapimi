
namespace YZMYapimiProjesi.Satici
{
    partial class DuzetlmeFormu
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
            this.urnTipiCmb = new System.Windows.Forms.ComboBox();
            this.TalepGonder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.redSebebiTxt = new System.Windows.Forms.Label();
            this.urnFiyatiTxt = new YZMYapimiProjesi.Admin.Assets.PHTextBox();
            this.urnMiktariTxt = new YZMYapimiProjesi.Admin.Assets.PHTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // urnTipiCmb
            // 
            this.urnTipiCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urnTipiCmb.Font = new System.Drawing.Font("D-DIN", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urnTipiCmb.FormattingEnabled = true;
            this.urnTipiCmb.Items.AddRange(new object[] {
            "Buğday",
            "Pamuk",
            "Yulaf"});
            this.urnTipiCmb.Location = new System.Drawing.Point(106, 121);
            this.urnTipiCmb.Name = "urnTipiCmb";
            this.urnTipiCmb.Size = new System.Drawing.Size(152, 31);
            this.urnTipiCmb.Sorted = true;
            this.urnTipiCmb.TabIndex = 9;
            // 
            // TalepGonder
            // 
            this.TalepGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TalepGonder.Location = new System.Drawing.Point(115, 333);
            this.TalepGonder.Name = "TalepGonder";
            this.TalepGonder.Size = new System.Drawing.Size(132, 50);
            this.TalepGonder.TabIndex = 8;
            this.TalepGonder.Text = "Talep Gönder";
            this.TalepGonder.UseVisualStyleBackColor = true;
            this.TalepGonder.Click += new System.EventHandler(this.TalepGonderBtn);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YZMYapimiProjesi.Properties.Resources.iconfinder_arrow_left_circle_1303871;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // redSebebiTxt
            // 
            this.redSebebiTxt.AutoSize = true;
            this.redSebebiTxt.Font = new System.Drawing.Font("D-DIN Exp", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redSebebiTxt.Location = new System.Drawing.Point(114, 24);
            this.redSebebiTxt.Name = "redSebebiTxt";
            this.redSebebiTxt.Size = new System.Drawing.Size(144, 28);
            this.redSebebiTxt.TabIndex = 10;
            this.redSebebiTxt.Text = "Red Sebebi";
            // 
            // urnFiyatiTxt
            // 
            this.urnFiyatiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urnFiyatiTxt.ForeColor = System.Drawing.Color.Gray;
            this.urnFiyatiTxt.Location = new System.Drawing.Point(106, 282);
            this.urnFiyatiTxt.Name = "urnFiyatiTxt";
            this.urnFiyatiTxt.PlaceHolderText = "";
            this.urnFiyatiTxt.Size = new System.Drawing.Size(152, 26);
            this.urnFiyatiTxt.TabIndex = 6;
            this.urnFiyatiTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urnFiyatiTxt_KeyPress);
            // 
            // urnMiktariTxt
            // 
            this.urnMiktariTxt.Location = new System.Drawing.Point(106, 202);
            this.urnMiktariTxt.MaximumSize = new System.Drawing.Size(1000, 200);
            this.urnMiktariTxt.MinimumSize = new System.Drawing.Size(0, 30);
            this.urnMiktariTxt.Name = "urnMiktariTxt";
            this.urnMiktariTxt.PlaceHolderText = "dvsdv";
            this.urnMiktariTxt.Size = new System.Drawing.Size(152, 30);
            this.urnMiktariTxt.TabIndex = 11;
            this.urnMiktariTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urnMiktariTxt_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("D-DIN", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ürün Seçin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("D-DIN", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ürün Miktarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("D-DIN", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ürün Birim Fiyati";
            // 
            // DuzetlmeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 425);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urnMiktariTxt);
            this.Controls.Add(this.redSebebiTxt);
            this.Controls.Add(this.urnTipiCmb);
            this.Controls.Add(this.TalepGonder);
            this.Controls.Add(this.urnFiyatiTxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DuzetlmeFormu";
            this.Text = "DuzetlmeFormu";
            this.Load += new System.EventHandler(this.DuzetlmeFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox urnTipiCmb;
        private System.Windows.Forms.Button TalepGonder;
        private Admin.Assets.PHTextBox urnFiyatiTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label redSebebiTxt;
        private Admin.Assets.PHTextBox urnMiktariTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}