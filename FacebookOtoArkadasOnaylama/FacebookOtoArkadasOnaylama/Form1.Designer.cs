
namespace FacebookOtoArkadasOnaylama
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnArkadasOnaylama = new System.Windows.Forms.Button();
            this.txtKacSaniyeAraIleOnaylansin = new System.Windows.Forms.TextBox();
            this.txtOnaylanacakIstekSayisi = new System.Windows.Forms.TextBox();
            this.btnScrollKaydir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnArkadasCikarmaScrol = new System.Windows.Forms.Button();
            this.btnArkadasCikarma = new System.Windows.Forms.Button();
            this.kacSaniyeAraIleCikarilsin = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKacKisiCikarilsin = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(145, 114);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(207, 43);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnArkadasOnaylama
            // 
            this.btnArkadasOnaylama.BackColor = System.Drawing.Color.DarkCyan;
            this.btnArkadasOnaylama.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnArkadasOnaylama.ForeColor = System.Drawing.Color.White;
            this.btnArkadasOnaylama.Location = new System.Drawing.Point(260, 178);
            this.btnArkadasOnaylama.Name = "btnArkadasOnaylama";
            this.btnArkadasOnaylama.Size = new System.Drawing.Size(168, 45);
            this.btnArkadasOnaylama.TabIndex = 1;
            this.btnArkadasOnaylama.Text = "Başlat";
            this.btnArkadasOnaylama.UseVisualStyleBackColor = false;
            this.btnArkadasOnaylama.Click += new System.EventHandler(this.btnİstekleriOnayla_Click);
            // 
            // txtKacSaniyeAraIleOnaylansin
            // 
            this.txtKacSaniyeAraIleOnaylansin.Location = new System.Drawing.Point(260, 141);
            this.txtKacSaniyeAraIleOnaylansin.Name = "txtKacSaniyeAraIleOnaylansin";
            this.txtKacSaniyeAraIleOnaylansin.Size = new System.Drawing.Size(168, 31);
            this.txtKacSaniyeAraIleOnaylansin.TabIndex = 2;
            // 
            // txtOnaylanacakIstekSayisi
            // 
            this.txtOnaylanacakIstekSayisi.Location = new System.Drawing.Point(260, 90);
            this.txtOnaylanacakIstekSayisi.Name = "txtOnaylanacakIstekSayisi";
            this.txtOnaylanacakIstekSayisi.Size = new System.Drawing.Size(168, 31);
            this.txtOnaylanacakIstekSayisi.TabIndex = 3;
            // 
            // btnScrollKaydir
            // 
            this.btnScrollKaydir.Location = new System.Drawing.Point(260, 30);
            this.btnScrollKaydir.Name = "btnScrollKaydir";
            this.btnScrollKaydir.Size = new System.Drawing.Size(168, 40);
            this.btnScrollKaydir.TabIndex = 5;
            this.btnScrollKaydir.Text = "Scrol Kaydır";
            this.btnScrollKaydir.UseVisualStyleBackColor = true;
            this.btnScrollKaydir.Click += new System.EventHandler(this.btnScrollKaydir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kaç Kişi Onaylansın";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kaç Saniye Ara İle Onaylansın";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnArkadasOnaylama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKacSaniyeAraIleOnaylansin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOnaylanacakIstekSayisi);
            this.groupBox1.Controls.Add(this.btnScrollKaydir);
            this.groupBox1.Location = new System.Drawing.Point(12, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 250);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arkadaşlık İsteklerini Onaylama";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(434, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 25);
            this.label15.TabIndex = 19;
            this.label15.Text = "7";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(434, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 25);
            this.label13.TabIndex = 17;
            this.label13.Text = "6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnGiris);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(319, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 172);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giriş";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 31);
            this.textBox2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Şifre : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 31);
            this.textBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kullanıcı Adı : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnArkadasCikarmaScrol);
            this.groupBox3.Controls.Add(this.btnArkadasCikarma);
            this.groupBox3.Controls.Add(this.kacSaniyeAraIleCikarilsin);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtKacKisiCikarilsin);
            this.groupBox3.Location = new System.Drawing.Point(515, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 250);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arkadaş Çıkarma";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(423, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 25);
            this.label16.TabIndex = 20;
            this.label16.Text = "7";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(424, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 25);
            this.label14.TabIndex = 18;
            this.label14.Text = "6";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(424, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "4";
            // 
            // btnArkadasCikarmaScrol
            // 
            this.btnArkadasCikarmaScrol.Location = new System.Drawing.Point(247, 16);
            this.btnArkadasCikarmaScrol.Name = "btnArkadasCikarmaScrol";
            this.btnArkadasCikarmaScrol.Size = new System.Drawing.Size(168, 34);
            this.btnArkadasCikarmaScrol.TabIndex = 13;
            this.btnArkadasCikarmaScrol.Text = "Scrol Kaydır";
            this.btnArkadasCikarmaScrol.UseVisualStyleBackColor = true;
            this.btnArkadasCikarmaScrol.Click += new System.EventHandler(this.btnArkadasCikarmaScrol_Click);
            // 
            // btnArkadasCikarma
            // 
            this.btnArkadasCikarma.BackColor = System.Drawing.Color.DarkCyan;
            this.btnArkadasCikarma.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnArkadasCikarma.ForeColor = System.Drawing.Color.White;
            this.btnArkadasCikarma.Location = new System.Drawing.Point(250, 162);
            this.btnArkadasCikarma.Name = "btnArkadasCikarma";
            this.btnArkadasCikarma.Size = new System.Drawing.Size(168, 45);
            this.btnArkadasCikarma.TabIndex = 8;
            this.btnArkadasCikarma.Text = "Başlat";
            this.btnArkadasCikarma.UseVisualStyleBackColor = false;
            this.btnArkadasCikarma.Click += new System.EventHandler(this.btnArkadasCikarma_Click);
            // 
            // kacSaniyeAraIleCikarilsin
            // 
            this.kacSaniyeAraIleCikarilsin.AutoSize = true;
            this.kacSaniyeAraIleCikarilsin.Location = new System.Drawing.Point(13, 110);
            this.kacSaniyeAraIleCikarilsin.Name = "kacSaniyeAraIleCikarilsin";
            this.kacSaniyeAraIleCikarilsin.Size = new System.Drawing.Size(224, 25);
            this.kacSaniyeAraIleCikarilsin.TabIndex = 12;
            this.kacSaniyeAraIleCikarilsin.Text = "Kaç Saniye Ara İle Çıkarılsın";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(249, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 31);
            this.textBox3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kaç Kişi Çıkarılsın";
            // 
            // txtKacKisiCikarilsin
            // 
            this.txtKacKisiCikarilsin.Location = new System.Drawing.Point(248, 56);
            this.txtKacKisiCikarilsin.Name = "txtKacKisiCikarilsin";
            this.txtKacKisiCikarilsin.Size = new System.Drawing.Size(168, 31);
            this.txtKacKisiCikarilsin.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FacebookOtoArkadasOnaylama.Properties.Resources.i__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FB-Mood";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnArkadasOnaylama;
        private System.Windows.Forms.TextBox txtKacSaniyeAraIleOnaylansin;
        private System.Windows.Forms.TextBox txtOnaylanacakIstekSayisi;
        private System.Windows.Forms.Button btnScrollKaydir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnArkadasCikarma;
        private System.Windows.Forms.Label kacSaniyeAraIleCikarilsin;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKacKisiCikarilsin;
        private System.Windows.Forms.Button btnArkadasCikarmaScrol;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
    }
}

