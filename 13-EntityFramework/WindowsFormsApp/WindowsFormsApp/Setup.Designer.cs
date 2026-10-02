namespace WindowsFormsApp
{
    partial class Setup
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTedarikciListele = new System.Windows.Forms.Button();
            this.cmbUrunAktifMi = new System.Windows.Forms.ComboBox();
            this.btnUrunListele = new System.Windows.Forms.Button();
            this.txtAdminUserName = new System.Windows.Forms.TextBox();
            this.btnAdminListele = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.dgvListele = new System.Windows.Forms.DataGridView();
            this.btnTedarikciGuncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdminGuncelle = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtTedarikciEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdminTelefon = new System.Windows.Forms.TextBox();
            this.txtTedarikciAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(62, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 534);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnTedarikciListele);
            this.tabPage1.Controls.Add(this.cmbUrunAktifMi);
            this.tabPage1.Controls.Add(this.btnUrunListele);
            this.tabPage1.Controls.Add(this.txtAdminUserName);
            this.tabPage1.Controls.Add(this.btnAdminListele);
            this.tabPage1.Controls.Add(this.btnUrunGuncelle);
            this.tabPage1.Controls.Add(this.dgvListele);
            this.tabPage1.Controls.Add(this.btnTedarikciGuncelle);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnAdminGuncelle);
            this.tabPage1.Controls.Add(this.txtUrunAdi);
            this.tabPage1.Controls.Add(this.txtTedarikciEmail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtAdminTelefon);
            this.tabPage1.Controls.Add(this.txtTedarikciAdi);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(726, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bilgi Güncelle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin Kullanıcı Adı";
            // 
            // btnTedarikciListele
            // 
            this.btnTedarikciListele.Location = new System.Drawing.Point(600, 282);
            this.btnTedarikciListele.Name = "btnTedarikciListele";
            this.btnTedarikciListele.Size = new System.Drawing.Size(120, 40);
            this.btnTedarikciListele.TabIndex = 3;
            this.btnTedarikciListele.Text = "Tedarikçi Listele";
            this.btnTedarikciListele.UseVisualStyleBackColor = true;
            this.btnTedarikciListele.Click += new System.EventHandler(this.btnTedarikciListele_Click);
            // 
            // cmbUrunAktifMi
            // 
            this.cmbUrunAktifMi.FormattingEnabled = true;
            this.cmbUrunAktifMi.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cmbUrunAktifMi.Location = new System.Drawing.Point(295, 206);
            this.cmbUrunAktifMi.Name = "cmbUrunAktifMi";
            this.cmbUrunAktifMi.Size = new System.Drawing.Size(201, 21);
            this.cmbUrunAktifMi.TabIndex = 19;
            // 
            // btnUrunListele
            // 
            this.btnUrunListele.Location = new System.Drawing.Point(295, 282);
            this.btnUrunListele.Name = "btnUrunListele";
            this.btnUrunListele.Size = new System.Drawing.Size(120, 40);
            this.btnUrunListele.TabIndex = 2;
            this.btnUrunListele.Text = "Ürün Listele";
            this.btnUrunListele.UseVisualStyleBackColor = true;
            this.btnUrunListele.Click += new System.EventHandler(this.btnUrunListele_Click);
            // 
            // txtAdminUserName
            // 
            this.txtAdminUserName.Location = new System.Drawing.Point(20, 58);
            this.txtAdminUserName.Name = "txtAdminUserName";
            this.txtAdminUserName.Size = new System.Drawing.Size(201, 20);
            this.txtAdminUserName.TabIndex = 5;
            // 
            // btnAdminListele
            // 
            this.btnAdminListele.Location = new System.Drawing.Point(11, 282);
            this.btnAdminListele.Name = "btnAdminListele";
            this.btnAdminListele.Size = new System.Drawing.Size(120, 40);
            this.btnAdminListele.TabIndex = 1;
            this.btnAdminListele.Text = "Admin Listele";
            this.btnAdminListele.UseVisualStyleBackColor = true;
            this.btnAdminListele.Click += new System.EventHandler(this.btnAdminListele_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(552, 190);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(150, 37);
            this.btnUrunGuncelle.TabIndex = 13;
            this.btnUrunGuncelle.Text = "Ürün Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // dgvListele
            // 
            this.dgvListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListele.Location = new System.Drawing.Point(11, 328);
            this.dgvListele.Name = "dgvListele";
            this.dgvListele.Size = new System.Drawing.Size(706, 174);
            this.dgvListele.TabIndex = 0;
            this.dgvListele.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvListele_MouseDoubleClick);
            // 
            // btnTedarikciGuncelle
            // 
            this.btnTedarikciGuncelle.Location = new System.Drawing.Point(552, 115);
            this.btnTedarikciGuncelle.Name = "btnTedarikciGuncelle";
            this.btnTedarikciGuncelle.Size = new System.Drawing.Size(150, 37);
            this.btnTedarikciGuncelle.TabIndex = 18;
            this.btnTedarikciGuncelle.Text = "Tedarikçi Güncelle";
            this.btnTedarikciGuncelle.UseVisualStyleBackColor = true;
            this.btnTedarikciGuncelle.Click += new System.EventHandler(this.btnTedarikciGuncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ürün Aktif Mi";
            // 
            // btnAdminGuncelle
            // 
            this.btnAdminGuncelle.Location = new System.Drawing.Point(552, 42);
            this.btnAdminGuncelle.Name = "btnAdminGuncelle";
            this.btnAdminGuncelle.Size = new System.Drawing.Size(150, 37);
            this.btnAdminGuncelle.TabIndex = 8;
            this.btnAdminGuncelle.Text = "Admin Güncelle";
            this.btnAdminGuncelle.UseVisualStyleBackColor = true;
            this.btnAdminGuncelle.Click += new System.EventHandler(this.btnAdminGuncelle_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(18, 206);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(201, 20);
            this.txtUrunAdi.TabIndex = 10;
            // 
            // txtTedarikciEmail
            // 
            this.txtTedarikciEmail.Location = new System.Drawing.Point(295, 132);
            this.txtTedarikciEmail.Name = "txtTedarikciEmail";
            this.txtTedarikciEmail.Size = new System.Drawing.Size(201, 20);
            this.txtTedarikciEmail.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Admin Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tedarikçi Email";
            // 
            // txtAdminTelefon
            // 
            this.txtAdminTelefon.Location = new System.Drawing.Point(295, 58);
            this.txtAdminTelefon.Name = "txtAdminTelefon";
            this.txtAdminTelefon.Size = new System.Drawing.Size(201, 20);
            this.txtAdminTelefon.TabIndex = 7;
            // 
            // txtTedarikciAdi
            // 
            this.txtTedarikciAdi.Location = new System.Drawing.Point(18, 132);
            this.txtTedarikciAdi.Name = "txtTedarikciAdi";
            this.txtTedarikciAdi.Size = new System.Drawing.Size(201, 20);
            this.txtTedarikciAdi.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tedarikçi Adı";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(726, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log Listesi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 600);
            this.Controls.Add(this.tabControl1);
            this.Name = "Setup";
            this.Text = "Setup";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTedarikciListele;
        private System.Windows.Forms.ComboBox cmbUrunAktifMi;
        private System.Windows.Forms.Button btnUrunListele;
        private System.Windows.Forms.TextBox txtAdminUserName;
        private System.Windows.Forms.Button btnAdminListele;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.DataGridView dgvListele;
        private System.Windows.Forms.Button btnTedarikciGuncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdminGuncelle;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtTedarikciEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdminTelefon;
        private System.Windows.Forms.TextBox txtTedarikciAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
    }
}