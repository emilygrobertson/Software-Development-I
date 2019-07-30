namespace Lab6
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
            this.wordsTypedTxt = new System.Windows.Forms.TextBox();
            this.wordsLbl = new System.Windows.Forms.Label();
            this.gradeButton = new System.Windows.Forms.Button();
            this.outputLbl = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wordsTypedTxt
            // 
            this.wordsTypedTxt.Location = new System.Drawing.Point(312, 63);
            this.wordsTypedTxt.Name = "wordsTypedTxt";
            this.wordsTypedTxt.Size = new System.Drawing.Size(100, 20);
            this.wordsTypedTxt.TabIndex = 0;
            // 
            // wordsLbl
            // 
            this.wordsLbl.AutoSize = true;
            this.wordsLbl.Location = new System.Drawing.Point(113, 66);
            this.wordsLbl.Name = "wordsLbl";
            this.wordsLbl.Size = new System.Drawing.Size(163, 13);
            this.wordsLbl.TabIndex = 1;
            this.wordsLbl.Text = "Enter the number of words typed:";
            // 
            // gradeButton
            // 
            this.gradeButton.Location = new System.Drawing.Point(204, 127);
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.Size = new System.Drawing.Size(198, 25);
            this.gradeButton.TabIndex = 2;
            this.gradeButton.Text = "Click Here to Calculate your Grade!";
            this.gradeButton.UseVisualStyleBackColor = true;
            this.gradeButton.Click += new System.EventHandler(this.gradeButton_Click);
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Location = new System.Drawing.Point(284, 187);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(0, 13);
            this.outputLbl.TabIndex = 3;
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(252, 177);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(100, 23);
            this.outputLabel.TabIndex = 4;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(174, 178);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(72, 13);
            this.gradeLabel.TabIndex = 5;
            this.gradeLabel.Text = "Your grade is:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.gradeButton);
            this.Controls.Add(this.wordsLbl);
            this.Controls.Add(this.wordsTypedTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wordsTypedTxt;
        private System.Windows.Forms.Label wordsLbl;
        private System.Windows.Forms.Button gradeButton;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label gradeLabel;
    }
}

