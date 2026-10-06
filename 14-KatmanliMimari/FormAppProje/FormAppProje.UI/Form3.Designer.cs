namespace FormAppProje.UI
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbSiparisIdList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.lblSiparisTarihi = new System.Windows.Forms.Label();
            this.lblKargoTarihi = new System.Windows.Forms.Label();
            this.lblSiparisToplam = new System.Windows.Forms.Label();
            this.lblSiparisIdListe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(572, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbSiparisIdList
            // 
            this.cmbSiparisIdList.FormattingEnabled = true;
            this.cmbSiparisIdList.Location = new System.Drawing.Point(351, 23);
            this.cmbSiparisIdList.Name = "cmbSiparisIdList";
            this.cmbSiparisIdList.Size = new System.Drawing.Size(233, 21);
            this.cmbSiparisIdList.TabIndex = 1;
            this.cmbSiparisIdList.SelectedIndexChanged += new System.EventHandler(this.cmbSiparisIdList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müşteri Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sipariş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kargo Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sipariş Toplam";
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Location = new System.Drawing.Point(153, 23);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(0, 13);
            this.lblMusteriAdi.TabIndex = 6;
            // 
            // lblSiparisTarihi
            // 
            this.lblSiparisTarihi.AutoSize = true;
            this.lblSiparisTarihi.Location = new System.Drawing.Point(153, 62);
            this.lblSiparisTarihi.Name = "lblSiparisTarihi";
            this.lblSiparisTarihi.Size = new System.Drawing.Size(0, 13);
            this.lblSiparisTarihi.TabIndex = 7;
            // 
            // lblKargoTarihi
            // 
            this.lblKargoTarihi.AutoSize = true;
            this.lblKargoTarihi.Location = new System.Drawing.Point(153, 103);
            this.lblKargoTarihi.Name = "lblKargoTarihi";
            this.lblKargoTarihi.Size = new System.Drawing.Size(0, 13);
            this.lblKargoTarihi.TabIndex = 8;
            // 
            // lblSiparisToplam
            // 
            this.lblSiparisToplam.AutoSize = true;
            this.lblSiparisToplam.Location = new System.Drawing.Point(153, 143);
            this.lblSiparisToplam.Name = "lblSiparisToplam";
            this.lblSiparisToplam.Size = new System.Drawing.Size(0, 13);
            this.lblSiparisToplam.TabIndex = 9;
            // 
            // lblSiparisIdListe
            // 
            this.lblSiparisIdListe.AutoSize = true;
            this.lblSiparisIdListe.Location = new System.Drawing.Point(348, 7);
            this.lblSiparisIdListe.Name = "lblSiparisIdListe";
            this.lblSiparisIdListe.Size = new System.Drawing.Size(84, 13);
            this.lblSiparisIdListe.TabIndex = 10;
            this.lblSiparisIdListe.Text = "Sipariş ID Listesi";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.lblSiparisIdListe);
            this.Controls.Add(this.lblSiparisToplam);
            this.Controls.Add(this.lblKargoTarihi);
            this.Controls.Add(this.lblSiparisTarihi);
            this.Controls.Add(this.lblMusteriAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSiparisIdList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbSiparisIdList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.Label lblSiparisTarihi;
        private System.Windows.Forms.Label lblKargoTarihi;
        private System.Windows.Forms.Label lblSiparisToplam;
        private System.Windows.Forms.Label lblSiparisIdListe;
    }
}