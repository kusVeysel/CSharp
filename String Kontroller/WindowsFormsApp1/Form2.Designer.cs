namespace WindowsFormsApp1
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.BtnContains = new System.Windows.Forms.Button();
            this.BtnToUpper = new System.Windows.Forms.Button();
            this.BtnToLower = new System.Windows.Forms.Button();
            this.BtnLenght = new System.Windows.Forms.Button();
            this.BtnTrim = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.BtnSplit = new System.Windows.Forms.Button();
            this.BtnSubstring = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(65, 27);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(313, 20);
            this.txtData.TabIndex = 0;
            // 
            // BtnContains
            // 
            this.BtnContains.Location = new System.Drawing.Point(107, 652);
            this.BtnContains.Name = "BtnContains";
            this.BtnContains.Size = new System.Drawing.Size(218, 70);
            this.BtnContains.TabIndex = 1;
            this.BtnContains.Text = "ContainsControl";
            this.BtnContains.UseVisualStyleBackColor = true;
            this.BtnContains.Click += new System.EventHandler(this.BtnContains_Click);
            // 
            // BtnToUpper
            // 
            this.BtnToUpper.Location = new System.Drawing.Point(107, 573);
            this.BtnToUpper.Name = "BtnToUpper";
            this.BtnToUpper.Size = new System.Drawing.Size(218, 73);
            this.BtnToUpper.TabIndex = 2;
            this.BtnToUpper.Text = "ToUpper Control";
            this.BtnToUpper.UseVisualStyleBackColor = true;
            this.BtnToUpper.Click += new System.EventHandler(this.toUpper_Click);
            // 
            // BtnToLower
            // 
            this.BtnToLower.Location = new System.Drawing.Point(107, 486);
            this.BtnToLower.Name = "BtnToLower";
            this.BtnToLower.Size = new System.Drawing.Size(218, 81);
            this.BtnToLower.TabIndex = 3;
            this.BtnToLower.Text = "ToLower Control";
            this.BtnToLower.UseVisualStyleBackColor = true;
            this.BtnToLower.Click += new System.EventHandler(this.BtnToLower_Click);
            // 
            // BtnLenght
            // 
            this.BtnLenght.Location = new System.Drawing.Point(107, 408);
            this.BtnLenght.Name = "BtnLenght";
            this.BtnLenght.Size = new System.Drawing.Size(218, 72);
            this.BtnLenght.TabIndex = 4;
            this.BtnLenght.Text = "Length Control";
            this.BtnLenght.UseVisualStyleBackColor = true;
            this.BtnLenght.Click += new System.EventHandler(this.BtnLenght_Click);
            // 
            // BtnTrim
            // 
            this.BtnTrim.Location = new System.Drawing.Point(107, 330);
            this.BtnTrim.Name = "BtnTrim";
            this.BtnTrim.Size = new System.Drawing.Size(218, 72);
            this.BtnTrim.TabIndex = 5;
            this.BtnTrim.Text = "Trim Control";
            this.BtnTrim.UseVisualStyleBackColor = true;
            this.BtnTrim.Click += new System.EventHandler(this.BtnTrim_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(107, 252);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(218, 72);
            this.btnReplace.TabIndex = 6;
            this.btnReplace.Text = "Replace Control";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // BtnSplit
            // 
            this.BtnSplit.Location = new System.Drawing.Point(107, 174);
            this.BtnSplit.Name = "BtnSplit";
            this.BtnSplit.Size = new System.Drawing.Size(218, 72);
            this.BtnSplit.TabIndex = 7;
            this.BtnSplit.Text = "Split Control";
            this.BtnSplit.UseVisualStyleBackColor = true;
            this.BtnSplit.Click += new System.EventHandler(this.BtnSplit_Click);
            // 
            // BtnSubstring
            // 
            this.BtnSubstring.Location = new System.Drawing.Point(107, 96);
            this.BtnSubstring.Name = "BtnSubstring";
            this.BtnSubstring.Size = new System.Drawing.Size(218, 72);
            this.BtnSubstring.TabIndex = 8;
            this.BtnSubstring.Text = "Substring Control";
            this.BtnSubstring.UseVisualStyleBackColor = true;
            this.BtnSubstring.Click += new System.EventHandler(this.BtnSubstring_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 735);
            this.Controls.Add(this.BtnSubstring);
            this.Controls.Add(this.BtnSplit);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.BtnTrim);
            this.Controls.Add(this.BtnLenght);
            this.Controls.Add(this.BtnToLower);
            this.Controls.Add(this.BtnToUpper);
            this.Controls.Add(this.BtnContains);
            this.Controls.Add(this.txtData);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button BtnContains;
        private System.Windows.Forms.Button BtnToUpper;
        private System.Windows.Forms.Button BtnToLower;
        private System.Windows.Forms.Button BtnLenght;
        private System.Windows.Forms.Button BtnTrim;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button BtnSplit;
        private System.Windows.Forms.Button BtnSubstring;
    }
}