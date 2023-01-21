namespace Homework4
{
    partial class CircleForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.lblDiag = new System.Windows.Forms.Label();
            this.lblDiagRule = new System.Windows.Forms.Label();
            this.lblCirc = new System.Windows.Forms.Label();
            this.lblCircRule = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblAreaRule = new System.Windows.Forms.Label();
            this.txbRadius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CircleBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CircleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(670, 220);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 38);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(584, 220);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 38);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCircle.Location = new System.Drawing.Point(391, 220);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(4);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(128, 38);
            this.btnCircle.TabIndex = 27;
            this.btnCircle.Text = "Calculate";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // lblDiag
            // 
            this.lblDiag.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDiag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiag.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDiag.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiag.Location = new System.Drawing.Point(66, 482);
            this.lblDiag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiag.Name = "lblDiag";
            this.lblDiag.Size = new System.Drawing.Size(143, 26);
            this.lblDiag.TabIndex = 26;
            this.lblDiag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiagRule
            // 
            this.lblDiagRule.AutoSize = true;
            this.lblDiagRule.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagRule.Location = new System.Drawing.Point(62, 451);
            this.lblDiagRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiagRule.Name = "lblDiagRule";
            this.lblDiagRule.Size = new System.Drawing.Size(97, 16);
            this.lblDiagRule.TabIndex = 25;
            this.lblDiagRule.Text = "Diameter = 2R";
            // 
            // lblCirc
            // 
            this.lblCirc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCirc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCirc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCirc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCirc.Location = new System.Drawing.Point(66, 395);
            this.lblCirc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCirc.Name = "lblCirc";
            this.lblCirc.Size = new System.Drawing.Size(143, 25);
            this.lblCirc.TabIndex = 24;
            this.lblCirc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCircRule
            // 
            this.lblCircRule.AutoSize = true;
            this.lblCircRule.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircRule.Location = new System.Drawing.Point(62, 364);
            this.lblCircRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCircRule.Name = "lblCircRule";
            this.lblCircRule.Size = new System.Drawing.Size(142, 16);
            this.lblCircRule.TabIndex = 23;
            this.lblCircRule.Text = "Circumference = \t2πR";
            // 
            // lblArea
            // 
            this.lblArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArea.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblArea.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(66, 310);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(143, 27);
            this.lblArea.TabIndex = 22;
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAreaRule
            // 
            this.lblAreaRule.AutoSize = true;
            this.lblAreaRule.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaRule.Location = new System.Drawing.Point(63, 279);
            this.lblAreaRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAreaRule.Name = "lblAreaRule";
            this.lblAreaRule.Size = new System.Drawing.Size(87, 16);
            this.lblAreaRule.TabIndex = 21;
            this.lblAreaRule.Text = "Area = \tπR^2";
            // 
            // txbRadius
            // 
            this.txbRadius.Location = new System.Drawing.Point(185, 228);
            this.txbRadius.Margin = new System.Windows.Forms.Padding(4);
            this.txbRadius.Name = "txbRadius";
            this.txbRadius.Size = new System.Drawing.Size(153, 22);
            this.txbRadius.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "Enter Circle Radius R:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 94);
            this.label1.TabIndex = 17;
            this.label1.Text = "A Circle is a simple shape that is made of a closed curve, with all points on its" +
    " circumference being an equal distance away form its the center, that distance i" +
    "s the Circles Radius.\r\n";
            // 
            // CircleBox
            // 
            this.CircleBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CircleBox.Location = new System.Drawing.Point(305, 266);
            this.CircleBox.Margin = new System.Windows.Forms.Padding(4);
            this.CircleBox.Name = "CircleBox";
            this.CircleBox.Size = new System.Drawing.Size(301, 271);
            this.CircleBox.TabIndex = 30;
            this.CircleBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Homework4.Properties.Resources.circle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // CircleForm
            // 
            this.AcceptButton = this.btnCircle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 554);
            this.Controls.Add(this.CircleBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.lblDiag);
            this.Controls.Add(this.lblDiagRule);
            this.Controls.Add(this.lblCirc);
            this.Controls.Add(this.lblCircRule);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblAreaRule);
            this.Controls.Add(this.txbRadius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CircleForm";
            this.Text = "Circle Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.CircleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CircleBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Label lblDiag;
        private System.Windows.Forms.Label lblDiagRule;
        private System.Windows.Forms.Label lblCirc;
        private System.Windows.Forms.Label lblCircRule;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblAreaRule;
        private System.Windows.Forms.TextBox txbRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}