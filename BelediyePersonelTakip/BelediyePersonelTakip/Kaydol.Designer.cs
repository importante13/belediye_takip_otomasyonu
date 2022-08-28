namespace BelediyePersonelTakip
{
    partial class Kaydol
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
            this.btnPersonelKayıt = new System.Windows.Forms.Button();
            this.txtKulaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPersonelKayıt
            // 
            this.btnPersonelKayıt.Location = new System.Drawing.Point(336, 259);
            this.btnPersonelKayıt.Name = "btnPersonelKayıt";
            this.btnPersonelKayıt.Size = new System.Drawing.Size(75, 23);
            this.btnPersonelKayıt.TabIndex = 4;
            this.btnPersonelKayıt.Text = "Kaydol";
            this.btnPersonelKayıt.UseVisualStyleBackColor = true;
            // 
            // txtKulaniciAdi
            // 
            this.txtKulaniciAdi.Location = new System.Drawing.Point(199, 74);
            this.txtKulaniciAdi.Name = "txtKulaniciAdi";
            this.txtKulaniciAdi.Size = new System.Drawing.Size(212, 23);
            this.txtKulaniciAdi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şifre :";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(199, 120);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(212, 23);
            this.txtsifre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kulanıcı Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Şifre Tekrar :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(212, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Şifre Kurtarma kodu belirle:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(212, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label5.Location = new System.Drawing.Point(126, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Personel Kayıt Ekranına Hoşgeldiniz";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Kaydol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtKulaniciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPersonelKayıt);
            this.Name = "Kaydol";
            this.Text = "Kaydol";
            this.Load += new System.EventHandler(this.Kaydol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPersonelKayıt;
        private TextBox txtKulaniciAdi;
        private Label label3;
        private TextBox txtsifre;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
    }
}