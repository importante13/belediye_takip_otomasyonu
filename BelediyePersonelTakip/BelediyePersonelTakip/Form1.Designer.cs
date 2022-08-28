namespace BelediyePersonelTakip
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.labelSifreyiUnuttum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKulaniciAdi = new System.Windows.Forms.TextBox();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(189, 156);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kulanıcı Adı :";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(133, 113);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(212, 23);
            this.txtsifre.TabIndex = 1;
            // 
            // labelSifreyiUnuttum
            // 
            this.labelSifreyiUnuttum.AutoSize = true;
            this.labelSifreyiUnuttum.Location = new System.Drawing.Point(250, 207);
            this.labelSifreyiUnuttum.Name = "labelSifreyiUnuttum";
            this.labelSifreyiUnuttum.Size = new System.Drawing.Size(95, 15);
            this.labelSifreyiUnuttum.TabIndex = 4;
            this.labelSifreyiUnuttum.Text = "Şifremi Unuttum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre :";
            // 
            // txtKulaniciAdi
            // 
            this.txtKulaniciAdi.Location = new System.Drawing.Point(133, 67);
            this.txtKulaniciAdi.Name = "txtKulaniciAdi";
            this.txtKulaniciAdi.Size = new System.Drawing.Size(212, 23);
            this.txtKulaniciAdi.TabIndex = 0;
            // 
            // btnKaydol
            // 
            this.btnKaydol.Location = new System.Drawing.Point(270, 156);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(75, 23);
            this.btnKaydol.TabIndex = 3;
            this.btnKaydol.Text = "Kaydol";
            this.btnKaydol.UseVisualStyleBackColor = true;
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 321);
            this.Controls.Add(this.btnKaydol);
            this.Controls.Add(this.txtKulaniciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSifreyiUnuttum);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiris);
            this.MaximumSize = new System.Drawing.Size(472, 360);
            this.MinimumSize = new System.Drawing.Size(472, 360);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGiris;
        private Label label1;
        private TextBox txtsifre;
        private Label labelSifreyiUnuttum;
        private Label label3;
        private TextBox txtKulaniciAdi;
        private Button btnKaydol;
    }
}