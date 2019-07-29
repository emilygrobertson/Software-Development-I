namespace Lab3
{
    partial class Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab3));
            this.Radiuslbl = new System.Windows.Forms.Label();
            this.RadiusAmount = new System.Windows.Forms.TextBox();
            this.Diameterlbl = new System.Windows.Forms.Label();
            this.SurfaceArealbl = new System.Windows.Forms.Label();
            this.Volumelbl = new System.Windows.Forms.Label();
            this.outputLbl1 = new System.Windows.Forms.Label();
            this.outputLbl2 = new System.Windows.Forms.Label();
            this.outputLbl3 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.Picture1 = new System.Windows.Forms.PictureBox();
            this.Picture2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).BeginInit();
            this.SuspendLayout();
            // 
            // Radiuslbl
            // 
            this.Radiuslbl.AutoSize = true;
            this.Radiuslbl.Location = new System.Drawing.Point(155, 37);
            this.Radiuslbl.Name = "Radiuslbl";
            this.Radiuslbl.Size = new System.Drawing.Size(98, 13);
            this.Radiuslbl.TabIndex = 0;
            this.Radiuslbl.Text = "Radius of a Sphere";
            // 
            // RadiusAmount
            // 
            this.RadiusAmount.Location = new System.Drawing.Point(272, 34);
            this.RadiusAmount.Name = "RadiusAmount";
            this.RadiusAmount.Size = new System.Drawing.Size(100, 20);
            this.RadiusAmount.TabIndex = 1;
            // 
            // Diameterlbl
            // 
            this.Diameterlbl.AutoSize = true;
            this.Diameterlbl.Location = new System.Drawing.Point(13, 200);
            this.Diameterlbl.Name = "Diameterlbl";
            this.Diameterlbl.Size = new System.Drawing.Size(49, 13);
            this.Diameterlbl.TabIndex = 2;
            this.Diameterlbl.Text = "Diameter";
            // 
            // SurfaceArealbl
            // 
            this.SurfaceArealbl.AutoSize = true;
            this.SurfaceArealbl.Location = new System.Drawing.Point(13, 229);
            this.SurfaceArealbl.Name = "SurfaceArealbl";
            this.SurfaceArealbl.Size = new System.Drawing.Size(69, 13);
            this.SurfaceArealbl.TabIndex = 3;
            this.SurfaceArealbl.Text = "Surface Area";
            // 
            // Volumelbl
            // 
            this.Volumelbl.AutoSize = true;
            this.Volumelbl.Location = new System.Drawing.Point(13, 263);
            this.Volumelbl.Name = "Volumelbl";
            this.Volumelbl.Size = new System.Drawing.Size(42, 13);
            this.Volumelbl.TabIndex = 4;
            this.Volumelbl.Text = "Volume";
            // 
            // outputLbl1
            // 
            this.outputLbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl1.Location = new System.Drawing.Point(101, 190);
            this.outputLbl1.Name = "outputLbl1";
            this.outputLbl1.Size = new System.Drawing.Size(100, 23);
            this.outputLbl1.TabIndex = 5;
            // 
            // outputLbl2
            // 
            this.outputLbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl2.Location = new System.Drawing.Point(101, 229);
            this.outputLbl2.Name = "outputLbl2";
            this.outputLbl2.Size = new System.Drawing.Size(100, 23);
            this.outputLbl2.TabIndex = 6;
            // 
            // outputLbl3
            // 
            this.outputLbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl3.Location = new System.Drawing.Point(101, 263);
            this.outputLbl3.Name = "outputLbl3";
            this.outputLbl3.Size = new System.Drawing.Size(100, 23);
            this.outputLbl3.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(282, 76);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Picture1
            // 
            this.Picture1.Image = ((System.Drawing.Image)(resources.GetObject("Picture1.Image")));
            this.Picture1.Location = new System.Drawing.Point(-1, 1);
            this.Picture1.Name = "Picture1";
            this.Picture1.Size = new System.Drawing.Size(150, 150);
            this.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture1.TabIndex = 9;
            this.Picture1.TabStop = false;
            this.Picture1.Click += new System.EventHandler(this.Picture1_Click);
            // 
            // Picture2
            // 
            this.Picture2.Image = ((System.Drawing.Image)(resources.GetObject("Picture2.Image")));
            this.Picture2.InitialImage = ((System.Drawing.Image)(resources.GetObject("Picture2.InitialImage")));
            this.Picture2.Location = new System.Drawing.Point(222, 169);
            this.Picture2.Name = "Picture2";
            this.Picture2.Size = new System.Drawing.Size(150, 150);
            this.Picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture2.TabIndex = 10;
            this.Picture2.TabStop = false;
            this.Picture2.Click += new System.EventHandler(this.Picture2_Click);
            // 
            // Lab3
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.Picture2);
            this.Controls.Add(this.Picture1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputLbl3);
            this.Controls.Add(this.outputLbl2);
            this.Controls.Add(this.outputLbl1);
            this.Controls.Add(this.Volumelbl);
            this.Controls.Add(this.SurfaceArealbl);
            this.Controls.Add(this.Diameterlbl);
            this.Controls.Add(this.RadiusAmount);
            this.Controls.Add(this.Radiuslbl);
            this.Name = "Lab3";
            this.Text = "Lab3";
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Radiuslbl;
        private System.Windows.Forms.TextBox RadiusAmount;
        private System.Windows.Forms.Label Diameterlbl;
        private System.Windows.Forms.Label SurfaceArealbl;
        private System.Windows.Forms.Label Volumelbl;
        private System.Windows.Forms.Label outputLbl1;
        private System.Windows.Forms.Label outputLbl2;
        private System.Windows.Forms.Label outputLbl3;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.PictureBox Picture1;
        private System.Windows.Forms.PictureBox Picture2;
    }
}

