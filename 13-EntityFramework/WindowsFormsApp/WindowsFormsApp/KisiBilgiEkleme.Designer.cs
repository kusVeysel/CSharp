namespace WindowsFormsApp
{
    partial class KisiBilgiEkleme
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
            this.grpAdmin = new System.Windows.Forms.GroupBox();
            this.cmbAdminAktifMi = new System.Windows.Forms.ComboBox();
            this.btnAdminEkle = new System.Windows.Forms.Button();
            this.txtAdminTelefon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAdminEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdminKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpTedarikci = new System.Windows.Forms.GroupBox();
            this.btnTedarikciEkle = new System.Windows.Forms.Button();
            this.txtTedarikciAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTedarikciTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTedarikciEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTedarikciVergiDairesi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTedarikciVergiNumarası = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTedarikciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTedarikciAktifMi = new System.Windows.Forms.ComboBox();
            this.grpMusteri = new System.Windows.Forms.GroupBox();
            this.txtMusteriEmaill = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMusteriAdres = new System.Windows.Forms.Label();
            this.txtMusteriEmail = new System.Windows.Forms.Label();
            this.txtMusteriTelefon = new System.Windows.Forms.Label();
            this.txtMusteriYetkili = new System.Windows.Forms.Label();
            this.nudiskonto = new System.Windows.Forms.NumericUpDown();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.txtMusteriYetkiliAdSoyad = new System.Windows.Forms.TextBox();
            this.txtMusteriTel = new System.Windows.Forms.TextBox();
            this.txtMusteriAdress = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtMusteriFirma = new System.Windows.Forms.TextBox();
            this.txtMusteri = new System.Windows.Forms.Label();
            this.rdAdminEkle = new System.Windows.Forms.RadioButton();
            this.rdTedarikciEkle = new System.Windows.Forms.RadioButton();
            this.rdMusteriEkle = new System.Windows.Forms.RadioButton();
            this.grpAdmin.SuspendLayout();
            this.grpTedarikci.SuspendLayout();
            this.grpMusteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudiskonto)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAdmin
            // 
            this.grpAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.grpAdmin.Controls.Add(this.cmbAdminAktifMi);
            this.grpAdmin.Controls.Add(this.btnAdminEkle);
            this.grpAdmin.Controls.Add(this.txtAdminTelefon);
            this.grpAdmin.Controls.Add(this.label13);
            this.grpAdmin.Controls.Add(this.txtAdminEmail);
            this.grpAdmin.Controls.Add(this.label12);
            this.grpAdmin.Controls.Add(this.txtAdminSifre);
            this.grpAdmin.Controls.Add(this.label11);
            this.grpAdmin.Controls.Add(this.label10);
            this.grpAdmin.Controls.Add(this.txtAdminKullaniciAdi);
            this.grpAdmin.Controls.Add(this.label9);
            this.grpAdmin.Location = new System.Drawing.Point(75, 48);
            this.grpAdmin.Name = "grpAdmin";
            this.grpAdmin.Size = new System.Drawing.Size(750, 450);
            this.grpAdmin.TabIndex = 23;
            this.grpAdmin.TabStop = false;
            this.grpAdmin.Text = "Admin Ekleme";
            this.grpAdmin.Visible = false;
            // 
            // cmbAdminAktifMi
            // 
            this.cmbAdminAktifMi.FormattingEnabled = true;
            this.cmbAdminAktifMi.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cmbAdminAktifMi.Location = new System.Drawing.Point(114, 233);
            this.cmbAdminAktifMi.Name = "cmbAdminAktifMi";
            this.cmbAdminAktifMi.Size = new System.Drawing.Size(230, 21);
            this.cmbAdminAktifMi.TabIndex = 11;
            // 
            // btnAdminEkle
            // 
            this.btnAdminEkle.Location = new System.Drawing.Point(435, 226);
            this.btnAdminEkle.Name = "btnAdminEkle";
            this.btnAdminEkle.Size = new System.Drawing.Size(207, 40);
            this.btnAdminEkle.TabIndex = 10;
            this.btnAdminEkle.Text = "Admin Ekle";
            this.btnAdminEkle.UseVisualStyleBackColor = true;
            this.btnAdminEkle.Click += new System.EventHandler(this.btnAdminEkle_Click);
            // 
            // txtAdminTelefon
            // 
            this.txtAdminTelefon.Location = new System.Drawing.Point(114, 167);
            this.txtAdminTelefon.Name = "txtAdminTelefon";
            this.txtAdminTelefon.Size = new System.Drawing.Size(233, 20);
            this.txtAdminTelefon.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(111, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Telefon";
            // 
            // txtAdminEmail
            // 
            this.txtAdminEmail.Location = new System.Drawing.Point(404, 170);
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.Size = new System.Drawing.Size(243, 20);
            this.txtAdminEmail.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(407, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Email";
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.Location = new System.Drawing.Point(405, 103);
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.Size = new System.Drawing.Size(244, 20);
            this.txtAdminSifre.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(407, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Şifre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Aktif Mi?";
            // 
            // txtAdminKullaniciAdi
            // 
            this.txtAdminKullaniciAdi.Location = new System.Drawing.Point(114, 103);
            this.txtAdminKullaniciAdi.Name = "txtAdminKullaniciAdi";
            this.txtAdminKullaniciAdi.Size = new System.Drawing.Size(233, 20);
            this.txtAdminKullaniciAdi.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kullanıcı Adı";
            // 
            // grpTedarikci
            // 
            this.grpTedarikci.Controls.Add(this.btnTedarikciEkle);
            this.grpTedarikci.Controls.Add(this.txtTedarikciAdres);
            this.grpTedarikci.Controls.Add(this.label8);
            this.grpTedarikci.Controls.Add(this.txtTedarikciTelefon);
            this.grpTedarikci.Controls.Add(this.label7);
            this.grpTedarikci.Controls.Add(this.txtTedarikciEmail);
            this.grpTedarikci.Controls.Add(this.label5);
            this.grpTedarikci.Controls.Add(this.label4);
            this.grpTedarikci.Controls.Add(this.txtTedarikciVergiDairesi);
            this.grpTedarikci.Controls.Add(this.label3);
            this.grpTedarikci.Controls.Add(this.txtTedarikciVergiNumarası);
            this.grpTedarikci.Controls.Add(this.label2);
            this.grpTedarikci.Controls.Add(this.txtTedarikciAdi);
            this.grpTedarikci.Controls.Add(this.label1);
            this.grpTedarikci.Controls.Add(this.cmbTedarikciAktifMi);
            this.grpTedarikci.Location = new System.Drawing.Point(75, 54);
            this.grpTedarikci.Name = "grpTedarikci";
            this.grpTedarikci.Size = new System.Drawing.Size(750, 450);
            this.grpTedarikci.TabIndex = 28;
            this.grpTedarikci.TabStop = false;
            this.grpTedarikci.Text = "Tedarikçi Ekleme";
            this.grpTedarikci.Visible = false;
            // 
            // btnTedarikciEkle
            // 
            this.btnTedarikciEkle.Location = new System.Drawing.Point(591, 388);
            this.btnTedarikciEkle.Name = "btnTedarikciEkle";
            this.btnTedarikciEkle.Size = new System.Drawing.Size(126, 45);
            this.btnTedarikciEkle.TabIndex = 16;
            this.btnTedarikciEkle.Text = "Tedarikçi Ekle";
            this.btnTedarikciEkle.UseVisualStyleBackColor = true;
            this.btnTedarikciEkle.Click += new System.EventHandler(this.btnTedarikciEkle_Click);
            // 
            // txtTedarikciAdres
            // 
            this.txtTedarikciAdres.Location = new System.Drawing.Point(129, 249);
            this.txtTedarikciAdres.Multiline = true;
            this.txtTedarikciAdres.Name = "txtTedarikciAdres";
            this.txtTedarikciAdres.Size = new System.Drawing.Size(519, 105);
            this.txtTedarikciAdres.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Adres";
            // 
            // txtTedarikciTelefon
            // 
            this.txtTedarikciTelefon.Location = new System.Drawing.Point(75, 123);
            this.txtTedarikciTelefon.Name = "txtTedarikciTelefon";
            this.txtTedarikciTelefon.Size = new System.Drawing.Size(268, 20);
            this.txtTedarikciTelefon.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Telefon";
            // 
            // txtTedarikciEmail
            // 
            this.txtTedarikciEmail.Location = new System.Drawing.Point(402, 123);
            this.txtTedarikciEmail.Name = "txtTedarikciEmail";
            this.txtTedarikciEmail.Size = new System.Drawing.Size(268, 20);
            this.txtTedarikciEmail.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Aktif Mi?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vergi Numarası";
            // 
            // txtTedarikciVergiDairesi
            // 
            this.txtTedarikciVergiDairesi.Location = new System.Drawing.Point(75, 185);
            this.txtTedarikciVergiDairesi.Name = "txtTedarikciVergiDairesi";
            this.txtTedarikciVergiDairesi.Size = new System.Drawing.Size(268, 20);
            this.txtTedarikciVergiDairesi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // txtTedarikciVergiNumarası
            // 
            this.txtTedarikciVergiNumarası.Location = new System.Drawing.Point(402, 185);
            this.txtTedarikciVergiNumarası.Name = "txtTedarikciVergiNumarası";
            this.txtTedarikciVergiNumarası.Size = new System.Drawing.Size(268, 20);
            this.txtTedarikciVergiNumarası.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vergi Dairesi";
            // 
            // txtTedarikciAdi
            // 
            this.txtTedarikciAdi.Location = new System.Drawing.Point(75, 56);
            this.txtTedarikciAdi.Name = "txtTedarikciAdi";
            this.txtTedarikciAdi.Size = new System.Drawing.Size(268, 20);
            this.txtTedarikciAdi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tedarikçi Adı";
            // 
            // cmbTedarikciAktifMi
            // 
            this.cmbTedarikciAktifMi.FormattingEnabled = true;
            this.cmbTedarikciAktifMi.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cmbTedarikciAktifMi.Location = new System.Drawing.Point(402, 56);
            this.cmbTedarikciAktifMi.Name = "cmbTedarikciAktifMi";
            this.cmbTedarikciAktifMi.Size = new System.Drawing.Size(268, 21);
            this.cmbTedarikciAktifMi.TabIndex = 1;
            // 
            // grpMusteri
            // 
            this.grpMusteri.Controls.Add(this.txtMusteriEmaill);
            this.grpMusteri.Controls.Add(this.label6);
            this.grpMusteri.Controls.Add(this.txtMusteriAdres);
            this.grpMusteri.Controls.Add(this.txtMusteriEmail);
            this.grpMusteri.Controls.Add(this.txtMusteriTelefon);
            this.grpMusteri.Controls.Add(this.txtMusteriYetkili);
            this.grpMusteri.Controls.Add(this.nudiskonto);
            this.grpMusteri.Controls.Add(this.btnMusteriEkle);
            this.grpMusteri.Controls.Add(this.txtMusteriYetkiliAdSoyad);
            this.grpMusteri.Controls.Add(this.txtMusteriTel);
            this.grpMusteri.Controls.Add(this.txtMusteriAdress);
            this.grpMusteri.Controls.Add(this.checkBox2);
            this.grpMusteri.Controls.Add(this.checkBox1);
            this.grpMusteri.Controls.Add(this.txtMusteriFirma);
            this.grpMusteri.Controls.Add(this.txtMusteri);
            this.grpMusteri.Location = new System.Drawing.Point(75, 54);
            this.grpMusteri.Name = "grpMusteri";
            this.grpMusteri.Size = new System.Drawing.Size(750, 450);
            this.grpMusteri.TabIndex = 27;
            this.grpMusteri.TabStop = false;
            this.grpMusteri.Text = "Müşteri Ekleme";
            this.grpMusteri.Visible = false;
            // 
            // txtMusteriEmaill
            // 
            this.txtMusteriEmaill.Location = new System.Drawing.Point(405, 146);
            this.txtMusteriEmaill.Name = "txtMusteriEmaill";
            this.txtMusteriEmaill.Size = new System.Drawing.Size(295, 20);
            this.txtMusteriEmaill.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "İskonto";
            // 
            // txtMusteriAdres
            // 
            this.txtMusteriAdres.AutoSize = true;
            this.txtMusteriAdres.Location = new System.Drawing.Point(27, 195);
            this.txtMusteriAdres.Name = "txtMusteriAdres";
            this.txtMusteriAdres.Size = new System.Drawing.Size(34, 13);
            this.txtMusteriAdres.TabIndex = 14;
            this.txtMusteriAdres.Text = "Adres";
            // 
            // txtMusteriEmail
            // 
            this.txtMusteriEmail.AutoSize = true;
            this.txtMusteriEmail.Location = new System.Drawing.Point(402, 130);
            this.txtMusteriEmail.Name = "txtMusteriEmail";
            this.txtMusteriEmail.Size = new System.Drawing.Size(32, 13);
            this.txtMusteriEmail.TabIndex = 13;
            this.txtMusteriEmail.Text = "Email";
            // 
            // txtMusteriTelefon
            // 
            this.txtMusteriTelefon.AutoSize = true;
            this.txtMusteriTelefon.Location = new System.Drawing.Point(17, 130);
            this.txtMusteriTelefon.Name = "txtMusteriTelefon";
            this.txtMusteriTelefon.Size = new System.Drawing.Size(43, 13);
            this.txtMusteriTelefon.TabIndex = 12;
            this.txtMusteriTelefon.Text = "Telefon";
            // 
            // txtMusteriYetkili
            // 
            this.txtMusteriYetkili.AutoSize = true;
            this.txtMusteriYetkili.Location = new System.Drawing.Point(402, 40);
            this.txtMusteriYetkili.Name = "txtMusteriYetkili";
            this.txtMusteriYetkili.Size = new System.Drawing.Size(88, 13);
            this.txtMusteriYetkili.TabIndex = 11;
            this.txtMusteriYetkili.Text = "Yetkili Adı Soyadı";
            // 
            // nudiskonto
            // 
            this.nudiskonto.Location = new System.Drawing.Point(340, 402);
            this.nudiskonto.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudiskonto.Name = "nudiskonto";
            this.nudiskonto.Size = new System.Drawing.Size(77, 20);
            this.nudiskonto.TabIndex = 10;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(521, 386);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(167, 47);
            this.btnMusteriEkle.TabIndex = 9;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // txtMusteriYetkiliAdSoyad
            // 
            this.txtMusteriYetkiliAdSoyad.Location = new System.Drawing.Point(405, 56);
            this.txtMusteriYetkiliAdSoyad.Name = "txtMusteriYetkiliAdSoyad";
            this.txtMusteriYetkiliAdSoyad.Size = new System.Drawing.Size(295, 20);
            this.txtMusteriYetkiliAdSoyad.TabIndex = 8;
            // 
            // txtMusteriTel
            // 
            this.txtMusteriTel.Location = new System.Drawing.Point(20, 146);
            this.txtMusteriTel.Name = "txtMusteriTel";
            this.txtMusteriTel.Size = new System.Drawing.Size(295, 20);
            this.txtMusteriTel.TabIndex = 7;
            // 
            // txtMusteriAdress
            // 
            this.txtMusteriAdress.Location = new System.Drawing.Point(30, 211);
            this.txtMusteriAdress.Multiline = true;
            this.txtMusteriAdress.Name = "txtMusteriAdress";
            this.txtMusteriAdress.Size = new System.Drawing.Size(658, 111);
            this.txtMusteriAdress.TabIndex = 4;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(166, 402);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Aktif";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(46, 402);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Toptancı";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtMusteriFirma
            // 
            this.txtMusteriFirma.Location = new System.Drawing.Point(20, 56);
            this.txtMusteriFirma.Name = "txtMusteriFirma";
            this.txtMusteriFirma.Size = new System.Drawing.Size(295, 20);
            this.txtMusteriFirma.TabIndex = 1;
            // 
            // txtMusteri
            // 
            this.txtMusteri.AutoSize = true;
            this.txtMusteri.Location = new System.Drawing.Point(17, 39);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(69, 13);
            this.txtMusteri.TabIndex = 0;
            this.txtMusteri.Text = "Müşteri Firma";
            // 
            // rdAdminEkle
            // 
            this.rdAdminEkle.AutoSize = true;
            this.rdAdminEkle.Location = new System.Drawing.Point(529, 587);
            this.rdAdminEkle.Name = "rdAdminEkle";
            this.rdAdminEkle.Size = new System.Drawing.Size(78, 17);
            this.rdAdminEkle.TabIndex = 26;
            this.rdAdminEkle.TabStop = true;
            this.rdAdminEkle.Text = "Admin Ekle";
            this.rdAdminEkle.UseVisualStyleBackColor = true;
            this.rdAdminEkle.CheckedChanged += new System.EventHandler(this.rdAdminEkle_CheckedChanged);
            // 
            // rdTedarikciEkle
            // 
            this.rdTedarikciEkle.AutoSize = true;
            this.rdTedarikciEkle.Location = new System.Drawing.Point(418, 587);
            this.rdTedarikciEkle.Name = "rdTedarikciEkle";
            this.rdTedarikciEkle.Size = new System.Drawing.Size(93, 17);
            this.rdTedarikciEkle.TabIndex = 25;
            this.rdTedarikciEkle.TabStop = true;
            this.rdTedarikciEkle.Text = "Tedarikçi Ekle";
            this.rdTedarikciEkle.UseVisualStyleBackColor = true;
            this.rdTedarikciEkle.CheckedChanged += new System.EventHandler(this.rdTedarikciEkle_CheckedChanged);
            // 
            // rdMusteriEkle
            // 
            this.rdMusteriEkle.AutoSize = true;
            this.rdMusteriEkle.Location = new System.Drawing.Point(310, 587);
            this.rdMusteriEkle.Name = "rdMusteriEkle";
            this.rdMusteriEkle.Size = new System.Drawing.Size(83, 17);
            this.rdMusteriEkle.TabIndex = 24;
            this.rdMusteriEkle.TabStop = true;
            this.rdMusteriEkle.Text = "Müşteri Ekle";
            this.rdMusteriEkle.UseVisualStyleBackColor = true;
            this.rdMusteriEkle.CheckedChanged += new System.EventHandler(this.rdMusteriEkle_CheckedChanged);
            // 
            // KisiBilgiEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 638);
            this.Controls.Add(this.grpAdmin);
            this.Controls.Add(this.grpTedarikci);
            this.Controls.Add(this.grpMusteri);
            this.Controls.Add(this.rdAdminEkle);
            this.Controls.Add(this.rdTedarikciEkle);
            this.Controls.Add(this.rdMusteriEkle);
            this.Name = "KisiBilgiEkleme";
            this.Text = "KisiBilgiEkleem";
            this.Load += new System.EventHandler(this.KisiBilgiEkleme_Load);
            this.grpAdmin.ResumeLayout(false);
            this.grpAdmin.PerformLayout();
            this.grpTedarikci.ResumeLayout(false);
            this.grpTedarikci.PerformLayout();
            this.grpMusteri.ResumeLayout(false);
            this.grpMusteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudiskonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdmin;
        private System.Windows.Forms.ComboBox cmbAdminAktifMi;
        private System.Windows.Forms.Button btnAdminEkle;
        private System.Windows.Forms.TextBox txtAdminTelefon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAdminEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAdminSifre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAdminKullaniciAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpTedarikci;
        private System.Windows.Forms.Button btnTedarikciEkle;
        private System.Windows.Forms.TextBox txtTedarikciAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTedarikciTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTedarikciEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTedarikciVergiDairesi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTedarikciVergiNumarası;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTedarikciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTedarikciAktifMi;
        private System.Windows.Forms.GroupBox grpMusteri;
        private System.Windows.Forms.TextBox txtMusteriEmaill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtMusteriAdres;
        private System.Windows.Forms.Label txtMusteriEmail;
        private System.Windows.Forms.Label txtMusteriTelefon;
        private System.Windows.Forms.Label txtMusteriYetkili;
        private System.Windows.Forms.NumericUpDown nudiskonto;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.TextBox txtMusteriYetkiliAdSoyad;
        private System.Windows.Forms.TextBox txtMusteriTel;
        private System.Windows.Forms.TextBox txtMusteriAdress;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtMusteriFirma;
        private System.Windows.Forms.Label txtMusteri;
        private System.Windows.Forms.RadioButton rdAdminEkle;
        private System.Windows.Forms.RadioButton rdTedarikciEkle;
        private System.Windows.Forms.RadioButton rdMusteriEkle;
    }
}