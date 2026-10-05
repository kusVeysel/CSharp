namespace SuTakip.UIForm
{
    partial class AnaMenu
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
            this.btnAyarForm = new System.Windows.Forms.Button();
            this.btnUrunForm = new System.Windows.Forms.Button();
            this.btnMusteriFrom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAyarForm
            // 
            this.btnAyarForm.BackgroundImage = global::SuTakip.UIForm.Properties.Resources.cogs;
            this.btnAyarForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAyarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarForm.Location = new System.Drawing.Point(485, 34);
            this.btnAyarForm.Name = "btnAyarForm";
            this.btnAyarForm.Size = new System.Drawing.Size(170, 216);
            this.btnAyarForm.TabIndex = 2;
            this.btnAyarForm.Text = "Program Ayarları";
            this.btnAyarForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAyarForm.UseVisualStyleBackColor = true;
            // 
            // btnUrunForm
            // 
            this.btnUrunForm.BackgroundImage = global::SuTakip.UIForm.Properties.Resources.products;
            this.btnUrunForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrunForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunForm.Location = new System.Drawing.Point(254, 34);
            this.btnUrunForm.Name = "btnUrunForm";
            this.btnUrunForm.Size = new System.Drawing.Size(170, 216);
            this.btnUrunForm.TabIndex = 1;
            this.btnUrunForm.Text = "Ürün İşlemleri";
            this.btnUrunForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUrunForm.UseVisualStyleBackColor = true;
            // 
            // btnMusteriFrom
            // 
            this.btnMusteriFrom.BackgroundImage = global::SuTakip.UIForm.Properties.Resources.customer;
            this.btnMusteriFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMusteriFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriFrom.Location = new System.Drawing.Point(39, 34);
            this.btnMusteriFrom.Name = "btnMusteriFrom";
            this.btnMusteriFrom.Size = new System.Drawing.Size(170, 216);
            this.btnMusteriFrom.TabIndex = 0;
            this.btnMusteriFrom.Text = "Müşteri İşlemleri";
            this.btnMusteriFrom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriFrom.UseVisualStyleBackColor = true;
            this.btnMusteriFrom.Click += new System.EventHandler(this.btnMusteriFrom_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 283);
            this.Controls.Add(this.btnAyarForm);
            this.Controls.Add(this.btnUrunForm);
            this.Controls.Add(this.btnMusteriFrom);
            this.Name = "AnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriFrom;
        private System.Windows.Forms.Button btnUrunForm;
        private System.Windows.Forms.Button btnAyarForm;
    }
}