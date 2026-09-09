namespace _08_StringMetotlar
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
            this.BtnSubstring = new System.Windows.Forms.Button();
            this.BtnSplit = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.BtnTrim = new System.Windows.Forms.Button();
            this.BtnLenght = new System.Windows.Forms.Button();
            this.BtnToLower = new System.Windows.Forms.Button();
            this.BtnToUpper = new System.Windows.Forms.Button();
            this.BtnContains = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSubstring
            // 
            this.BtnSubstring.Location = new System.Drawing.Point(108, 112);
            this.BtnSubstring.Name = "BtnSubstring";
            this.BtnSubstring.Size = new System.Drawing.Size(218, 72);
            this.BtnSubstring.TabIndex = 17;
            this.BtnSubstring.Text = "Substring Control";
            this.BtnSubstring.UseVisualStyleBackColor = true;
            this.BtnSubstring.Click += new System.EventHandler(this.BtnSubstring_Click);
            // 
            // BtnSplit
            // 
            this.BtnSplit.Location = new System.Drawing.Point(108, 190);
            this.BtnSplit.Name = "BtnSplit";
            this.BtnSplit.Size = new System.Drawing.Size(218, 72);
            this.BtnSplit.TabIndex = 16;
            this.BtnSplit.Text = "Split Control";
            this.BtnSplit.UseVisualStyleBackColor = true;
            this.BtnSplit.Click += new System.EventHandler(this.BtnSplit_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(108, 268);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(218, 72);
            this.btnReplace.TabIndex = 15;
            this.btnReplace.Text = "Replace Control";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // BtnTrim
            // 
            this.BtnTrim.Location = new System.Drawing.Point(108, 346);
            this.BtnTrim.Name = "BtnTrim";
            this.BtnTrim.Size = new System.Drawing.Size(218, 72);
            this.BtnTrim.TabIndex = 14;
            this.BtnTrim.Text = "Trim Control";
            this.BtnTrim.UseVisualStyleBackColor = true;
            this.BtnTrim.Click += new System.EventHandler(this.BtnTrim_Click);
            // 
            // BtnLenght
            // 
            this.BtnLenght.Location = new System.Drawing.Point(108, 424);
            this.BtnLenght.Name = "BtnLenght";
            this.BtnLenght.Size = new System.Drawing.Size(218, 72);
            this.BtnLenght.TabIndex = 13;
            this.BtnLenght.Text = "Length Control";
            this.BtnLenght.UseVisualStyleBackColor = true;
            this.BtnLenght.Click += new System.EventHandler(this.BtnLenght_Click);
            // 
            // BtnToLower
            // 
            this.BtnToLower.Location = new System.Drawing.Point(108, 502);
            this.BtnToLower.Name = "BtnToLower";
            this.BtnToLower.Size = new System.Drawing.Size(218, 81);
            this.BtnToLower.TabIndex = 12;
            this.BtnToLower.Text = "ToLower Control";
            this.BtnToLower.UseVisualStyleBackColor = true;
            this.BtnToLower.Click += new System.EventHandler(this.BtnToLower_Click);
            // 
            // BtnToUpper
            // 
            this.BtnToUpper.Location = new System.Drawing.Point(108, 589);
            this.BtnToUpper.Name = "BtnToUpper";
            this.BtnToUpper.Size = new System.Drawing.Size(218, 73);
            this.BtnToUpper.TabIndex = 11;
            this.BtnToUpper.Text = "ToUpper Control";
            this.BtnToUpper.UseVisualStyleBackColor = true;
            this.BtnToUpper.Click += new System.EventHandler(this.BtnToUpper_Click);
            // 
            // BtnContains
            // 
            this.BtnContains.Location = new System.Drawing.Point(108, 668);
            this.BtnContains.Name = "BtnContains";
            this.BtnContains.Size = new System.Drawing.Size(218, 70);
            this.BtnContains.TabIndex = 10;
            this.BtnContains.Text = "ContainsControl";
            this.BtnContains.UseVisualStyleBackColor = true;
            this.BtnContains.Click += new System.EventHandler(this.BtnContains_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(66, 43);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(313, 20);
            this.txtData.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 787);
            this.Controls.Add(this.BtnSubstring);
            this.Controls.Add(this.BtnSplit);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.BtnTrim);
            this.Controls.Add(this.BtnLenght);
            this.Controls.Add(this.BtnToLower);
            this.Controls.Add(this.BtnToUpper);
            this.Controls.Add(this.BtnContains);
            this.Controls.Add(this.txtData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSubstring;
        private System.Windows.Forms.Button BtnSplit;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button BtnTrim;
        private System.Windows.Forms.Button BtnLenght;
        private System.Windows.Forms.Button BtnToLower;
        private System.Windows.Forms.Button BtnToUpper;
        private System.Windows.Forms.Button BtnContains;
        private System.Windows.Forms.TextBox txtData;
    }
}

