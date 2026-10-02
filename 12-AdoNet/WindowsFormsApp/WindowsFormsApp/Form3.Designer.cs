namespace WindowsFormsApp
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
            this.btnform4ac = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dgvUrunListe = new System.Windows.Forms.DataGridView();
            this.txtKarakter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnform4ac
            // 
            this.btnform4ac.Location = new System.Drawing.Point(600, 18);
            this.btnform4ac.Name = "btnform4ac";
            this.btnform4ac.Size = new System.Drawing.Size(75, 23);
            this.btnform4ac.TabIndex = 19;
            this.btnform4ac.Text = "Form4 Aç";
            this.btnform4ac.UseVisualStyleBackColor = true;
            this.btnform4ac.Click += new System.EventHandler(this.btnform4ac_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Adet";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(264, 61);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 17;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(415, 40);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(173, 58);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Ürün Stok Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dgvUrunListe
            // 
            this.dgvUrunListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunListe.Location = new System.Drawing.Point(17, 116);
            this.dgvUrunListe.Name = "dgvUrunListe";
            this.dgvUrunListe.Size = new System.Drawing.Size(646, 331);
            this.dgvUrunListe.TabIndex = 15;
            // 
            // txtKarakter
            // 
            this.txtKarakter.Location = new System.Drawing.Point(16, 60);
            this.txtKarakter.Name = "txtKarakter";
            this.txtKarakter.Size = new System.Drawing.Size(212, 20);
            this.txtKarakter.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Aranan";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 464);
            this.Controls.Add(this.btnform4ac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgvUrunListe);
            this.Controls.Add(this.txtKarakter);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnform4ac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.DataGridView dgvUrunListe;
        private System.Windows.Forms.TextBox txtKarakter;
        private System.Windows.Forms.Label label1;
    }
}