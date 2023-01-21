namespace Homework4
{
    partial class SquareForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txbLength = new System.Windows.Forms.TextBox();
            this.lblAreaRule = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCirc = new System.Windows.Forms.Label();
            this.lblCircRule = new System.Windows.Forms.Label();
            this.lblDiag = new System.Windows.Forms.Label();
            this.lblDiagRule = new System.Windows.Forms.Label();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.squareBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.squareBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "A Square is a shape with 4 sides, all have the same length, and all sides are con" +
    "nected by 90 degree angles.\r\n";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Side Length x:";
            // 
            // txbLength
            // 
            this.txbLength.Location = new System.Drawing.Point(207, 230);
            this.txbLength.Margin = new System.Windows.Forms.Padding(4);
            this.txbLength.Name = "txbLength";
            this.txbLength.Size = new System.Drawing.Size(153, 22);
            this.txbLength.TabIndex = 6;
            this.txbLength.TextChanged += new System.EventHandler(this.txbLength_TextChanged);
            // 
            // lblAreaRule
            // 
            this.lblAreaRule.AutoSize = true;
            this.lblAreaRule.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaRule.Location = new System.Drawing.Point(73, 286);
            this.lblAreaRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAreaRule.Name = "lblAreaRule";
            this.lblAreaRule.Size = new System.Drawing.Size(76, 16);
            this.lblAreaRule.TabIndex = 7;
            this.lblAreaRule.Text = "Area = x^2";
            this.lblAreaRule.Click += new System.EventHandler(this.lblAreaRule_Click);
            // 
            // lblArea
            // 
            this.lblArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArea.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblArea.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(76, 317);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(143, 27);
            this.lblArea.TabIndex = 8;
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblArea.Click += new System.EventHandler(this.lblArea_Click);
            // 
            // lblCirc
            // 
            this.lblCirc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCirc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCirc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCirc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCirc.Location = new System.Drawing.Point(76, 402);
            this.lblCirc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCirc.Name = "lblCirc";
            this.lblCirc.Size = new System.Drawing.Size(143, 25);
            this.lblCirc.TabIndex = 10;
            this.lblCirc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCirc.Click += new System.EventHandler(this.lblCirc_Click);
            // 
            // lblCircRule
            // 
            this.lblCircRule.AutoSize = true;
            this.lblCircRule.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircRule.Location = new System.Drawing.Point(72, 371);
            this.lblCircRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCircRule.Name = "lblCircRule";
            this.lblCircRule.Size = new System.Drawing.Size(131, 16);
            this.lblCircRule.TabIndex = 9;
            this.lblCircRule.Text = "Circumference = 4x";
            this.lblCircRule.Click += new System.EventHandler(this.lblCircRule_Click);
            // 
            // lblDiag
            // 
            this.lblDiag.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDiag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiag.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDiag.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiag.Location = new System.Drawing.Point(76, 489);
            this.lblDiag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiag.Name = "lblDiag";
            this.lblDiag.Size = new System.Drawing.Size(143, 26);
            this.lblDiag.TabIndex = 12;
            this.lblDiag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDiag.Click += new System.EventHandler(this.lblDiag_Click);
            // 
            // lblDiagRule
            // 
            this.lblDiagRule.AutoSize = true;
            this.lblDiagRule.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagRule.Location = new System.Drawing.Point(72, 458);
            this.lblDiagRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiagRule.Name = "lblDiagRule";
            this.lblDiagRule.Size = new System.Drawing.Size(103, 16);
            this.lblDiagRule.TabIndex = 11;
            this.lblDiagRule.Text = "Diagonal = x√2";
            this.lblDiagRule.Click += new System.EventHandler(this.lblDiagRule_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.Location = new System.Drawing.Point(394, 222);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(4);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(128, 38);
            this.btnSquare.TabIndex = 13;
            this.btnSquare.Text = "Calculate";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(587, 222);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 38);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(673, 222);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 38);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // squareBox
            // 
            this.squareBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.squareBox.Location = new System.Drawing.Point(328, 268);
            this.squareBox.Margin = new System.Windows.Forms.Padding(4);
            this.squareBox.Name = "squareBox";
            this.squareBox.Size = new System.Drawing.Size(301, 271);
            this.squareBox.TabIndex = 16;
            this.squareBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Homework4.Properties.Resources.square;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SquareForm
            // 
            this.AcceptButton = this.btnSquare;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(779, 554);
            this.Controls.Add(this.squareBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.lblDiag);
            this.Controls.Add(this.lblDiagRule);
            this.Controls.Add(this.lblCirc);
            this.Controls.Add(this.lblCircRule);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblAreaRule);
            this.Controls.Add(this.txbLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SquareForm";
            this.Text = "Square Calculator";
            this.Load += new System.EventHandler(this.SquareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.squareBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbLength;
        private System.Windows.Forms.Label lblAreaRule;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCirc;
        private System.Windows.Forms.Label lblCircRule;
        private System.Windows.Forms.Label lblDiag;
        private System.Windows.Forms.Label lblDiagRule;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox squareBox;
    }
}