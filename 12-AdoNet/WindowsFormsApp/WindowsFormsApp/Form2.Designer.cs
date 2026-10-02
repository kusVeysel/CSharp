namespace WindowsFormsApp
{
    partial class Form2
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
            this.Form3Ac = new System.Windows.Forms.Button();
            this.btnUrunDataGetir = new System.Windows.Forms.Button();
            this.btnKategoriDataGetir = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // Form3Ac
            // 
            this.Form3Ac.Location = new System.Drawing.Point(709, 17);
            this.Form3Ac.Name = "Form3Ac";
            this.Form3Ac.Size = new System.Drawing.Size(75, 23);
            this.Form3Ac.TabIndex = 11;
            this.Form3Ac.Text = "btnForm3Ac";
            this.Form3Ac.UseVisualStyleBackColor = true;
            this.Form3Ac.Click += new System.EventHandler(this.Form3Ac_Click);
            // 
            // btnUrunDataGetir
            // 
            this.btnUrunDataGetir.Location = new System.Drawing.Point(182, 18);
            this.btnUrunDataGetir.Name = "btnUrunDataGetir";
            this.btnUrunDataGetir.Size = new System.Drawing.Size(128, 39);
            this.btnUrunDataGetir.TabIndex = 10;
            this.btnUrunDataGetir.Text = "Ürün Data Getir";
            this.btnUrunDataGetir.UseVisualStyleBackColor = true;
            this.btnUrunDataGetir.Click += new System.EventHandler(this.btnUrunDataGetir_Click);
            // 
            // btnKategoriDataGetir
            // 
            this.btnKategoriDataGetir.Location = new System.Drawing.Point(26, 18);
            this.btnKategoriDataGetir.Name = "btnKategoriDataGetir";
            this.btnKategoriDataGetir.Size = new System.Drawing.Size(128, 39);
            this.btnKategoriDataGetir.TabIndex = 9;
            this.btnKategoriDataGetir.Text = "Kategori Data Getir";
            this.btnKategoriDataGetir.UseVisualStyleBackColor = true;
            this.btnKategoriDataGetir.Click += new System.EventHandler(this.btnKategoriDataGetir_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(25, 198);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(759, 328);
            this.dgvData.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 543);
            this.Controls.Add(this.Form3Ac);
            this.Controls.Add(this.btnUrunDataGetir);
            this.Controls.Add(this.btnKategoriDataGetir);
            this.Controls.Add(this.dgvData);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Form3Ac;
        private System.Windows.Forms.Button btnUrunDataGetir;
        private System.Windows.Forms.Button btnKategoriDataGetir;
        private System.Windows.Forms.DataGridView dgvData;
    }
}