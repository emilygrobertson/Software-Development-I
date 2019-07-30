namespace Program2
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
            this.yearLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.freshmanButton = new System.Windows.Forms.RadioButton();
            this.sophomoreButton = new System.Windows.Forms.RadioButton();
            this.juniorButton = new System.Windows.Forms.RadioButton();
            this.seniorButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Location = new System.Drawing.Point(49, 45);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(79, 13);
            this.yearLbl.TabIndex = 1;
            this.yearLbl.Text = "Click your year:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(359, 45);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(194, 13);
            this.lastNameLbl.TabIndex = 2;
            this.lastNameLbl.Text = "Enter the First Letter of your Last Name:";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(559, 42);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(100, 20);
            this.lastNameTxt.TabIndex = 3;
            this.lastNameTxt.TextChanged += new System.EventHandler(this.lastNameTxt_TextChanged);
            // 
            // freshmanButton
            // 
            this.freshmanButton.AutoSize = true;
            this.freshmanButton.Location = new System.Drawing.Point(67, 61);
            this.freshmanButton.Name = "freshmanButton";
            this.freshmanButton.Size = new System.Drawing.Size(71, 17);
            this.freshmanButton.TabIndex = 4;
            this.freshmanButton.TabStop = true;
            this.freshmanButton.Text = "Freshman";
            this.freshmanButton.UseVisualStyleBackColor = true;
            // 
            // sophomoreButton
            // 
            this.sophomoreButton.AutoSize = true;
            this.sophomoreButton.Location = new System.Drawing.Point(67, 85);
            this.sophomoreButton.Name = "sophomoreButton";
            this.sophomoreButton.Size = new System.Drawing.Size(79, 17);
            this.sophomoreButton.TabIndex = 5;
            this.sophomoreButton.TabStop = true;
            this.sophomoreButton.Text = "Sophomore";
            this.sophomoreButton.UseVisualStyleBackColor = true;
            // 
            // juniorButton
            // 
            this.juniorButton.AutoSize = true;
            this.juniorButton.Location = new System.Drawing.Point(67, 109);
            this.juniorButton.Name = "juniorButton";
            this.juniorButton.Size = new System.Drawing.Size(53, 17);
            this.juniorButton.TabIndex = 6;
            this.juniorButton.TabStop = true;
            this.juniorButton.Text = "Junior";
            this.juniorButton.UseVisualStyleBackColor = true;
            // 
            // seniorButton
            // 
            this.seniorButton.AutoSize = true;
            this.seniorButton.Location = new System.Drawing.Point(67, 133);
            this.seniorButton.Name = "seniorButton";
            this.seniorButton.Size = new System.Drawing.Size(55, 17);
            this.seniorButton.TabIndex = 7;
            this.seniorButton.TabStop = true;
            this.seniorButton.Text = "Senior";
            this.seniorButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Click me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seniorButton);
            this.Controls.Add(this.juniorButton);
            this.Controls.Add(this.sophomoreButton);
            this.Controls.Add(this.freshmanButton);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.yearLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.RadioButton freshmanButton;
        private System.Windows.Forms.RadioButton sophomoreButton;
        private System.Windows.Forms.RadioButton juniorButton;
        private System.Windows.Forms.RadioButton seniorButton;
        private System.Windows.Forms.Button button1;
    }
}

