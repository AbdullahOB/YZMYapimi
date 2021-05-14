
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuzetlmeFormu));
            this.urnTipiCmb = new System.Windows.Forms.ComboBox();
            this.redSebebiTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackBtnPic = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.urnMiktariTxt = new System.Windows.Forms.TextBox();
            this.urnFiyatiTxt = new System.Windows.Forms.TextBox();
            this.TalepGonder = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtnPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // urnTipiCmb
            // 
            this.urnTipiCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urnTipiCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urnTipiCmb.FormattingEnabled = true;
            this.urnTipiCmb.Items.AddRange(new object[] {
            "Buğday",
            "Pamuk",
            "Yulaf"});
            this.urnTipiCmb.Location = new System.Drawing.Point(167, 201);
            this.urnTipiCmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.urnTipiCmb.Name = "urnTipiCmb";
            this.urnTipiCmb.Size = new System.Drawing.Size(201, 39);
            this.urnTipiCmb.Sorted = true;
            this.urnTipiCmb.TabIndex = 9;
            // 
            // redSebebiTxt
            // 
            this.redSebebiTxt.AutoSize = true;
            this.redSebebiTxt.BackColor = System.Drawing.Color.Transparent;
            this.redSebebiTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redSebebiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redSebebiTxt.ForeColor = System.Drawing.Color.White;
            this.redSebebiTxt.Location = new System.Drawing.Point(211, 84);
            this.redSebebiTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.redSebebiTxt.Name = "redSebebiTxt";
            this.redSebebiTxt.Size = new System.Drawing.Size(95, 20);
            this.redSebebiTxt.TabIndex = 10;
            this.redSebebiTxt.Text = "Red Sebebi";
            this.redSebebiTxt.Click += new System.EventHandler(this.redSebebiTxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(197, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ürün Seçin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(193, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ürün Miktarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(161, 366);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ürün Birim Fiyati";
            // 
            // BackBtnPic
            // 
            this.BackBtnPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtnPic.Image = ((System.Drawing.Image)(resources.GetObject("BackBtnPic.Image")));
            this.BackBtnPic.Location = new System.Drawing.Point(51, 29);
            this.BackBtnPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackBtnPic.Name = "BackBtnPic";
            this.BackBtnPic.Size = new System.Drawing.Size(52, 44);
            this.BackBtnPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackBtnPic.TabIndex = 45;
            this.BackBtnPic.TabStop = false;
            this.BackBtnPic.Click += new System.EventHandler(this.BackBtnPic_Click);
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(449, 30);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(52, 44);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 46;
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
            this.pictureBox1.Size = new System.Drawing.Size(551, 581);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // urnMiktariTxt
            // 
            this.urnMiktariTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.urnMiktariTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urnMiktariTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urnMiktariTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.urnMiktariTxt.Location = new System.Drawing.Point(167, 313);
            this.urnMiktariTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.urnMiktariTxt.MaximumSize = new System.Drawing.Size(666, 500);
            this.urnMiktariTxt.MinimumSize = new System.Drawing.Size(2, 26);
            this.urnMiktariTxt.Name = "urnMiktariTxt";
            this.urnMiktariTxt.Size = new System.Drawing.Size(202, 30);
            this.urnMiktariTxt.TabIndex = 48;
            this.urnMiktariTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urnMiktariTxt_KeyPress);
            // 
            // urnFiyatiTxt
            // 
            this.urnFiyatiTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.urnFiyatiTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urnFiyatiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urnFiyatiTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.urnFiyatiTxt.Location = new System.Drawing.Point(167, 399);
            this.urnFiyatiTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.urnFiyatiTxt.MaximumSize = new System.Drawing.Size(666, 500);
            this.urnFiyatiTxt.MinimumSize = new System.Drawing.Size(2, 26);
            this.urnFiyatiTxt.Name = "urnFiyatiTxt";
            this.urnFiyatiTxt.Size = new System.Drawing.Size(202, 30);
            this.urnFiyatiTxt.TabIndex = 49;
            this.urnFiyatiTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urnFiyatiTxt_KeyPress_1);
            // 
            // TalepGonder
            // 
            this.TalepGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(216)))), ((int)(((byte)(104)))));
            this.TalepGonder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TalepGonder.FlatAppearance.BorderSize = 2;
            this.TalepGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TalepGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TalepGonder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.TalepGonder.Location = new System.Drawing.Point(52, 463);
            this.TalepGonder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TalepGonder.Name = "TalepGonder";
            this.TalepGonder.Size = new System.Drawing.Size(445, 54);
            this.TalepGonder.TabIndex = 50;
            this.TalepGonder.Text = "Talep Gönder";
            this.TalepGonder.UseVisualStyleBackColor = false;
            this.TalepGonder.Click += new System.EventHandler(this.TalepGonderBtn);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // DuzetlmeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(551, 581);
            this.Controls.Add(this.TalepGonder);
            this.Controls.Add(this.urnFiyatiTxt);
            this.Controls.Add(this.urnMiktariTxt);
            this.Controls.Add(this.BackBtnPic);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redSebebiTxt);
            this.Controls.Add(this.urnTipiCmb);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DuzetlmeFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DuzetlmeFormu";
            this.Load += new System.EventHandler(this.DuzetlmeFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackBtnPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox urnTipiCmb;
        private System.Windows.Forms.Label redSebebiTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox BackBtnPic;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox urnMiktariTxt;
        private System.Windows.Forms.TextBox urnFiyatiTxt;
        private System.Windows.Forms.Button TalepGonder;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}