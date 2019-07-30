namespace Lab_7
{
    partial class Lab7
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
            this.futureValueLbl = new System.Windows.Forms.Label();
            this.interestRateLbl = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.presentValueLbl = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.futureValueTxt = new System.Windows.Forms.TextBox();
            this.interestRateTxt = new System.Windows.Forms.TextBox();
            this.numOfYearsTxt = new System.Windows.Forms.TextBox();
            this.outputVLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // futureValueLbl
            // 
            this.futureValueLbl.AutoSize = true;
            this.futureValueLbl.Location = new System.Drawing.Point(28, 32);
            this.futureValueLbl.Name = "futureValueLbl";
            this.futureValueLbl.Size = new System.Drawing.Size(70, 13);
            this.futureValueLbl.TabIndex = 0;
            this.futureValueLbl.Text = "Future Value:";
            // 
            // interestRateLbl
            // 
            this.interestRateLbl.AutoSize = true;
            this.interestRateLbl.Location = new System.Drawing.Point(12, 80);
            this.interestRateLbl.Name = "interestRateLbl";
            this.interestRateLbl.Size = new System.Drawing.Size(107, 13);
            this.interestRateLbl.TabIndex = 1;
            this.interestRateLbl.Text = "Annual Interest Rate:";
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Location = new System.Drawing.Point(28, 134);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(82, 13);
            this.yearLbl.TabIndex = 2;
            this.yearLbl.Text = "No. of the Year:";
            // 
            // presentValueLbl
            // 
            this.presentValueLbl.AutoSize = true;
            this.presentValueLbl.Location = new System.Drawing.Point(28, 192);
            this.presentValueLbl.Name = "presentValueLbl";
            this.presentValueLbl.Size = new System.Drawing.Size(76, 13);
            this.presentValueLbl.TabIndex = 3;
            this.presentValueLbl.Text = "Present Value:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(146, 237);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate!";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // futureValueTxt
            // 
            this.futureValueTxt.Location = new System.Drawing.Point(136, 29);
            this.futureValueTxt.Name = "futureValueTxt";
            this.futureValueTxt.Size = new System.Drawing.Size(100, 20);
            this.futureValueTxt.TabIndex = 5;
            // 
            // interestRateTxt
            // 
            this.interestRateTxt.Location = new System.Drawing.Point(136, 72);
            this.interestRateTxt.Name = "interestRateTxt";
            this.interestRateTxt.Size = new System.Drawing.Size(100, 20);
            this.interestRateTxt.TabIndex = 6;
            // 
            // numOfYearsTxt
            // 
            this.numOfYearsTxt.Location = new System.Drawing.Point(136, 126);
            this.numOfYearsTxt.Name = "numOfYearsTxt";
            this.numOfYearsTxt.Size = new System.Drawing.Size(100, 20);
            this.numOfYearsTxt.TabIndex = 7;
            // 
            // outputVLbl
            // 
            this.outputVLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputVLbl.Location = new System.Drawing.Point(136, 182);
            this.outputVLbl.Name = "outputVLbl";
            this.outputVLbl.Size = new System.Drawing.Size(100, 23);
            this.outputVLbl.TabIndex = 8;
            // 
            // Lab7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 286);
            this.Controls.Add(this.outputVLbl);
            this.Controls.Add(this.numOfYearsTxt);
            this.Controls.Add(this.interestRateTxt);
            this.Controls.Add(this.futureValueTxt);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.presentValueLbl);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.interestRateLbl);
            this.Controls.Add(this.futureValueLbl);
            this.Name = "Lab7";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label futureValueLbl;
        private System.Windows.Forms.Label interestRateLbl;
        public System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label presentValueLbl;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox futureValueTxt;
        private System.Windows.Forms.TextBox interestRateTxt;
        private System.Windows.Forms.TextBox numOfYearsTxt;
        private System.Windows.Forms.Label outputVLbl;
    }
}

