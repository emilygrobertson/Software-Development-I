namespace Lab_2
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
            this.MealPrice = new System.Windows.Forms.Label();
            this.Num1txt = new System.Windows.Forms.TextBox();
            this.Tipratelow = new System.Windows.Forms.Label();
            this.Tipratemedium = new System.Windows.Forms.Label();
            this.Tipratehigh = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TipCalculator = new System.Windows.Forms.Button();
            this.Output15 = new System.Windows.Forms.Label();
            this.Output18 = new System.Windows.Forms.Label();
            this.Output20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MealPrice
            // 
            this.MealPrice.AutoSize = true;
            this.MealPrice.Location = new System.Drawing.Point(113, 44);
            this.MealPrice.Name = "MealPrice";
            this.MealPrice.Size = new System.Drawing.Size(98, 13);
            this.MealPrice.TabIndex = 0;
            this.MealPrice.Text = "Enter price of meal:";
            // 
            // Num1txt
            // 
            this.Num1txt.Location = new System.Drawing.Point(217, 41);
            this.Num1txt.Name = "Num1txt";
            this.Num1txt.Size = new System.Drawing.Size(100, 20);
            this.Num1txt.TabIndex = 1;
            this.Num1txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Tipratelow
            // 
            this.Tipratelow.AutoSize = true;
            this.Tipratelow.Location = new System.Drawing.Point(147, 73);
            this.Tipratelow.Name = "Tipratelow";
            this.Tipratelow.Size = new System.Drawing.Size(27, 13);
            this.Tipratelow.TabIndex = 2;
            this.Tipratelow.Text = "15%";
            // 
            // Tipratemedium
            // 
            this.Tipratemedium.AutoSize = true;
            this.Tipratemedium.Location = new System.Drawing.Point(147, 111);
            this.Tipratemedium.Name = "Tipratemedium";
            this.Tipratemedium.Size = new System.Drawing.Size(27, 13);
            this.Tipratemedium.TabIndex = 3;
            this.Tipratemedium.Text = "18%";
            // 
            // Tipratehigh
            // 
            this.Tipratehigh.AutoSize = true;
            this.Tipratehigh.Location = new System.Drawing.Point(147, 149);
            this.Tipratehigh.Name = "Tipratehigh";
            this.Tipratehigh.Size = new System.Drawing.Size(27, 13);
            this.Tipratehigh.TabIndex = 4;
            this.Tipratehigh.Text = "20%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 5;
            // 
            // TipCalculator
            // 
            this.TipCalculator.Location = new System.Drawing.Point(150, 195);
            this.TipCalculator.Name = "TipCalculator";
            this.TipCalculator.Size = new System.Drawing.Size(112, 22);
            this.TipCalculator.TabIndex = 9;
            this.TipCalculator.Text = "Calculate Tip";
            this.TipCalculator.UseVisualStyleBackColor = true;
            this.TipCalculator.Click += new System.EventHandler(this.button1_Click);
            // 
            // Output15
            // 
            this.Output15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output15.Location = new System.Drawing.Point(217, 73);
            this.Output15.Name = "Output15";
            this.Output15.Size = new System.Drawing.Size(100, 23);
            this.Output15.TabIndex = 10;
            // 
            // Output18
            // 
            this.Output18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output18.Location = new System.Drawing.Point(214, 111);
            this.Output18.Name = "Output18";
            this.Output18.Size = new System.Drawing.Size(100, 23);
            this.Output18.TabIndex = 11;
            // 
            // Output20
            // 
            this.Output20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output20.Location = new System.Drawing.Point(214, 149);
            this.Output20.Name = "Output20";
            this.Output20.Size = new System.Drawing.Size(100, 23);
            this.Output20.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Output20);
            this.Controls.Add(this.Output18);
            this.Controls.Add(this.Output15);
            this.Controls.Add(this.TipCalculator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tipratehigh);
            this.Controls.Add(this.Tipratemedium);
            this.Controls.Add(this.Tipratelow);
            this.Controls.Add(this.Num1txt);
            this.Controls.Add(this.MealPrice);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MealPrice;
        private System.Windows.Forms.TextBox Num1txt;
        private System.Windows.Forms.Label Tipratelow;
        private System.Windows.Forms.Label Tipratemedium;
        private System.Windows.Forms.Label Tipratehigh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TipCalculator;
        private System.Windows.Forms.Label Output15;
        private System.Windows.Forms.Label Output18;
        private System.Windows.Forms.Label Output20;
    }
}

