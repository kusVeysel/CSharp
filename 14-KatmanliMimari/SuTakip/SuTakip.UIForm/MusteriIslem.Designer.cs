namespace SuTakip.UIForm
{
    partial class MusteriIslemleri
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
            this.dgvMusteriListe = new System.Windows.Forms.DataGridView();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMusteriListe
            // 
            this.dgvMusteriListe.AllowUserToAddRows = false;
            this.dgvMusteriListe.AllowUserToDeleteRows = false;
            this.dgvMusteriListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriListe.Location = new System.Drawing.Point(12, 288);
            this.dgvMusteriListe.MultiSelect = false;
            this.dgvMusteriListe.Name = "dgvMusteriListe";
            this.dgvMusteriListe.ReadOnly = true;
            this.dgvMusteriListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriListe.Size = new System.Drawing.Size(930, 247);
            this.dgvMusteriListe.TabIndex = 0;
            this.dgvMusteriListe.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMusteriListe_MouseDoubleClick);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackgroundImage = global::SuTakip.UIForm.Properties.Resources.add;
            this.btnMusteriEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMusteriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMusteriEkle.Location = new System.Drawing.Point(851, 186);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(91, 96);
            this.btnMusteriEkle.TabIndex = 1;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            // 
            // MusteriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 547);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.dgvMusteriListe);
            this.Name = "MusteriIslemleri";
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.MusteriIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusteriListe;
        private System.Windows.Forms.Button btnMusteriEkle;
    }
}