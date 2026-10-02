namespace WindowsFormsApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstDetayliBilgi = new System.Windows.Forms.ListBox();
            this.btnYeniGeleniEkle = new System.Windows.Forms.Button();
            this.btnEskiGeleniEkle = new System.Windows.Forms.Button();
            this.nmrc10lt = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nmrc5lt = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nmrc3lt = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstUrunBilgiler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc10lt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc5lt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc3lt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(508, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Geçmiş İşlemler";
            // 
            // lstDetayliBilgi
            // 
            this.lstDetayliBilgi.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstDetayliBilgi.FormattingEnabled = true;
            this.lstDetayliBilgi.ItemHeight = 15;
            this.lstDetayliBilgi.Location = new System.Drawing.Point(511, 56);
            this.lstDetayliBilgi.Name = "lstDetayliBilgi";
            this.lstDetayliBilgi.Size = new System.Drawing.Size(204, 349);
            this.lstDetayliBilgi.TabIndex = 25;
            // 
            // btnYeniGeleniEkle
            // 
            this.btnYeniGeleniEkle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniGeleniEkle.Location = new System.Drawing.Point(310, 270);
            this.btnYeniGeleniEkle.Name = "btnYeniGeleniEkle";
            this.btnYeniGeleniEkle.Size = new System.Drawing.Size(139, 51);
            this.btnYeniGeleniEkle.TabIndex = 24;
            this.btnYeniGeleniEkle.Text = "Ürünleri Ekle";
            this.btnYeniGeleniEkle.UseVisualStyleBackColor = true;
            this.btnYeniGeleniEkle.Click += new System.EventHandler(this.btnYeniGeleniEkle_Click);
            // 
            // btnEskiGeleniEkle
            // 
            this.btnEskiGeleniEkle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEskiGeleniEkle.Location = new System.Drawing.Point(72, 377);
            this.btnEskiGeleniEkle.Name = "btnEskiGeleniEkle";
            this.btnEskiGeleniEkle.Size = new System.Drawing.Size(158, 60);
            this.btnEskiGeleniEkle.TabIndex = 23;
            this.btnEskiGeleniEkle.Text = "En Son Gelen Ürünleri Ekle";
            this.btnEskiGeleniEkle.UseVisualStyleBackColor = true;
            this.btnEskiGeleniEkle.Click += new System.EventHandler(this.btnEskiGeleniEkle_Click);
            // 
            // nmrc10lt
            // 
            this.nmrc10lt.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrc10lt.Location = new System.Drawing.Point(338, 231);
            this.nmrc10lt.Name = "nmrc10lt";
            this.nmrc10lt.Size = new System.Drawing.Size(72, 23);
            this.nmrc10lt.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(335, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Gelen 10LT Bidon Adeti";
            // 
            // nmrc5lt
            // 
            this.nmrc5lt.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrc5lt.Location = new System.Drawing.Point(338, 177);
            this.nmrc5lt.Name = "nmrc5lt";
            this.nmrc5lt.Size = new System.Drawing.Size(72, 23);
            this.nmrc5lt.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(335, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Gelen 5LT Bidon Adeti";
            // 
            // nmrc3lt
            // 
            this.nmrc3lt.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrc3lt.Location = new System.Drawing.Point(338, 120);
            this.nmrc3lt.Name = "nmrc3lt";
            this.nmrc3lt.Size = new System.Drawing.Size(72, 23);
            this.nmrc3lt.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(335, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Gelen 3LT Bidon Adeti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Güncel Ürün Bilgileri";
            // 
            // lstUrunBilgiler
            // 
            this.lstUrunBilgiler.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstUrunBilgiler.FormattingEnabled = true;
            this.lstUrunBilgiler.ItemHeight = 15;
            this.lstUrunBilgiler.Location = new System.Drawing.Point(35, 56);
            this.lstUrunBilgiler.Name = "lstUrunBilgiler";
            this.lstUrunBilgiler.Size = new System.Drawing.Size(233, 304);
            this.lstUrunBilgiler.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDetayliBilgi);
            this.Controls.Add(this.btnYeniGeleniEkle);
            this.Controls.Add(this.btnEskiGeleniEkle);
            this.Controls.Add(this.nmrc10lt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nmrc5lt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmrc3lt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstUrunBilgiler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrc10lt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc5lt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc3lt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDetayliBilgi;
        private System.Windows.Forms.Button btnYeniGeleniEkle;
        private System.Windows.Forms.Button btnEskiGeleniEkle;
        private System.Windows.Forms.NumericUpDown nmrc10lt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmrc5lt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmrc3lt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstUrunBilgiler;
    }
}

