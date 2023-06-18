
namespace OsKumbara
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbCoin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBanknote = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMevcutPara = new System.Windows.Forms.Label();
            this.btnShake = new System.Windows.Forms.Button();
            this.cboxKatla = new System.Windows.Forms.CheckBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(300, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(120, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // cmbCoin
            // 
            this.cmbCoin.BackColor = System.Drawing.Color.Honeydew;
            this.cmbCoin.FormattingEnabled = true;
            this.cmbCoin.Location = new System.Drawing.Point(641, 457);
            this.cmbCoin.Name = "cmbCoin";
            this.cmbCoin.Size = new System.Drawing.Size(176, 21);
            this.cmbCoin.TabIndex = 3;
            this.cmbCoin.SelectedIndexChanged += new System.EventHandler(this.cmbCoin_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(156, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Eklenecek Kağıt Parayı Seçiniz";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Khaki;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(443, 414);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 40);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Kumbaraya Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.BackColor = System.Drawing.Color.Khaki;
            this.btnBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBreak.Location = new System.Drawing.Point(521, 537);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(111, 37);
            this.btnBreak.TabIndex = 9;
            this.btnBreak.Text = "Kumbarayı Kır";
            this.btnBreak.UseVisualStyleBackColor = false;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(574, 250);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(300, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(606, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Eklenecek Bozuk Parayı Seçiniz";
            // 
            // cmbBanknote
            // 
            this.cmbBanknote.BackColor = System.Drawing.Color.Honeydew;
            this.cmbBanknote.FormattingEnabled = true;
            this.cmbBanknote.Location = new System.Drawing.Point(181, 457);
            this.cmbBanknote.Name = "cmbBanknote";
            this.cmbBanknote.Size = new System.Drawing.Size(176, 21);
            this.cmbBanknote.TabIndex = 4;
            this.cmbBanknote.SelectedIndexChanged += new System.EventHandler(this.cmbBanknote_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(745, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kumbaradan Çıkan Para";
            // 
            // lblMevcutPara
            // 
            this.lblMevcutPara.AutoSize = true;
            this.lblMevcutPara.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMevcutPara.Location = new System.Drawing.Point(810, 103);
            this.lblMevcutPara.Name = "lblMevcutPara";
            this.lblMevcutPara.Size = new System.Drawing.Size(64, 28);
            this.lblMevcutPara.TabIndex = 11;
            this.lblMevcutPara.Text = "0 TL";
            // 
            // btnShake
            // 
            this.btnShake.BackColor = System.Drawing.Color.Khaki;
            this.btnShake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShake.ForeColor = System.Drawing.Color.Black;
            this.btnShake.Location = new System.Drawing.Point(364, 535);
            this.btnShake.Name = "btnShake";
            this.btnShake.Size = new System.Drawing.Size(111, 40);
            this.btnShake.TabIndex = 12;
            this.btnShake.Text = "Kumbarayı Salla";
            this.btnShake.UseVisualStyleBackColor = false;
            this.btnShake.Click += new System.EventHandler(this.btnShake_Click);
            // 
            // cboxKatla
            // 
            this.cboxKatla.AutoSize = true;
            this.cboxKatla.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxKatla.Location = new System.Drawing.Point(208, 493);
            this.cboxKatla.Name = "cboxKatla";
            this.cboxKatla.Size = new System.Drawing.Size(110, 19);
            this.cboxKatla.TabIndex = 14;
            this.cboxKatla.Text = "Parayı Katla";
            this.cboxKatla.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Khaki;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(443, 472);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(111, 40);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1003, 635);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.cboxKatla);
            this.Controls.Add(this.btnShake);
            this.Controls.Add(this.lblMevcutPara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBanknote);
            this.Controls.Add(this.cmbCoin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbCoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBanknote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMevcutPara;
        private System.Windows.Forms.Button btnShake;
        private System.Windows.Forms.CheckBox cboxKatla;
        private System.Windows.Forms.Button btnTemizle;
    }
}

