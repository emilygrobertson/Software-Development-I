namespace lab4
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
            this.GPALbl = new System.Windows.Forms.Label();
            this.GPAText = new System.Windows.Forms.TextBox();
            this.testScoreText = new System.Windows.Forms.TextBox();
            this.testScoreLbl = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.runningTotalLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GPALbl
            // 
            this.GPALbl.AutoSize = true;
            this.GPALbl.Location = new System.Drawing.Point(64, 46);
            this.GPALbl.Name = "GPALbl";
            this.GPALbl.Size = new System.Drawing.Size(32, 13);
            this.GPALbl.TabIndex = 0;
            this.GPALbl.Text = "GPA:";
            // 
            // GPAText
            // 
            this.GPAText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GPAText.Location = new System.Drawing.Point(115, 39);
            this.GPAText.Name = "GPAText";
            this.GPAText.Size = new System.Drawing.Size(100, 20);
            this.GPAText.TabIndex = 1;
            // 
            // testScoreText
            // 
            this.testScoreText.Location = new System.Drawing.Point(115, 78);
            this.testScoreText.Name = "testScoreText";
            this.testScoreText.Size = new System.Drawing.Size(100, 20);
            this.testScoreText.TabIndex = 2;
            this.testScoreText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // testScoreLbl
            // 
            this.testScoreLbl.AutoSize = true;
            this.testScoreLbl.Location = new System.Drawing.Point(47, 85);
            this.testScoreLbl.Name = "testScoreLbl";
            this.testScoreLbl.Size = new System.Drawing.Size(62, 13);
            this.testScoreLbl.TabIndex = 3;
            this.testScoreLbl.Text = "Test Score:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(256, 56);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate!";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // runningTotalLbl
            // 
            this.runningTotalLbl.AutoSize = true;
            this.runningTotalLbl.Location = new System.Drawing.Point(32, 139);
            this.runningTotalLbl.Name = "runningTotalLbl";
            this.runningTotalLbl.Size = new System.Drawing.Size(77, 13);
            this.runningTotalLbl.TabIndex = 5;
            this.runningTotalLbl.Text = "Running Total:";
            // 
            // totalLbl
            // 
            this.totalLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLbl.Location = new System.Drawing.Point(115, 129);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(100, 29);
            this.totalLbl.TabIndex = 6;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.runningTotalLbl);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.testScoreLbl);
            this.Controls.Add(this.testScoreText);
            this.Controls.Add(this.GPAText);
            this.Controls.Add(this.GPALbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GPALbl;
        private System.Windows.Forms.TextBox GPAText;
        private System.Windows.Forms.TextBox testScoreText;
        private System.Windows.Forms.Label testScoreLbl;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label runningTotalLbl;
        private System.Windows.Forms.Label totalLbl;
    }
}

