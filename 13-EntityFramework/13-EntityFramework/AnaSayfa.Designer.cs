namespace _13_EntityFramework
{
    partial class AnaSayfa
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStokForm = new System.Windows.Forms.Button();
            this.btnKisiBilgiEkleme = new System.Windows.Forms.Button();
            this.btnSetupFrom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(554, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kişi Bilgi Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(332, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ayarlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Stok Ekranı";
            // 
            // btnStokForm
            // 
            this.btnStokForm.BackgroundImage = global::_13_EntityFramework.Properties.Resources._2795451;
            this.btnStokForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStokForm.Location = new System.Drawing.Point(27, 17);
            this.btnStokForm.Name = "btnStokForm";
            this.btnStokForm.Size = new System.Drawing.Size(200, 200);
            this.btnStokForm.TabIndex = 6;
            this.btnStokForm.UseVisualStyleBackColor = true;
            // 
            // btnKisiBilgiEkleme
            // 
            this.btnKisiBilgiEkleme.BackgroundImage = global::_13_EntityFramework.Properties.Resources.profile_11121549;
            this.btnKisiBilgiEkleme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKisiBilgiEkleme.Location = new System.Drawing.Point(502, 17);
            this.btnKisiBilgiEkleme.Name = "btnKisiBilgiEkleme";
            this.btnKisiBilgiEkleme.Size = new System.Drawing.Size(200, 200);
            this.btnKisiBilgiEkleme.TabIndex = 10;
            this.btnKisiBilgiEkleme.UseVisualStyleBackColor = true;
            this.btnKisiBilgiEkleme.Click += new System.EventHandler(this.btnKisiBilgiEkleme_Click_1);
            // 
            // btnSetupFrom
            // 
            this.btnSetupFrom.BackgroundImage = global::_13_EntityFramework.Properties.Resources.cogs_8429974;
            this.btnSetupFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSetupFrom.Location = new System.Drawing.Point(262, 17);
            this.btnSetupFrom.Name = "btnSetupFrom";
            this.btnSetupFrom.Size = new System.Drawing.Size(200, 200);
            this.btnSetupFrom.TabIndex = 7;
            this.btnSetupFrom.UseVisualStyleBackColor = true;
            this.btnSetupFrom.Click += new System.EventHandler(this.btnSetupFrom_Click_1);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 266);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKisiBilgiEkleme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetupFrom);
            this.Controls.Add(this.btnStokForm);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKisiBilgiEkleme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetupFrom;
        private System.Windows.Forms.Button btnStokForm;
    }
}