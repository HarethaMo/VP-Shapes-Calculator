namespace Homework4
{
    partial class RectangleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectangleForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.lblDiag = new System.Windows.Forms.Label();
            this.lblDiagRule = new System.Windows.Forms.Label();
            this.lblCirc = new System.Windows.Forms.Label();
            this.lblCircRule = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblAreaRule = new System.Windows.Forms.Label();
            this.txbWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rectangleBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbHight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rectangleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(869, 220);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 38);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(783, 220);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 38);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.Location = new System.Drawing.Point(633, 220);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(4);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(128, 38);
            this.btnSquare.TabIndex = 27;
            this.btnSquare.Text = "Calculate";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // lblDiag
            // 
            this.lblDiag.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDiag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiag.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDiag.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiag.Location = new System.Drawing.Point(13, 484);
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
            this.lblDiagRule.Location = new System.Drawing.Point(9, 453);
            this.lblDiagRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiagRule.Name = "lblDiagRule";
            this.lblDiagRule.Size = new System.Drawing.Size(157, 16);
            this.lblDiagRule.TabIndex = 25;
            this.lblDiagRule.Text = "Diagonal = √(x^2 + y^2)";
            // 
            // lblCirc
            // 
            this.lblCirc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCirc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCirc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCirc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCirc.Location = new System.Drawing.Point(13, 397);
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
            this.lblCircRule.Location = new System.Drawing.Point(9, 366);
            this.lblCircRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCircRule.Name = "lblCircRule";
            this.lblCircRule.Size = new System.Drawing.Size(161, 16);
            this.lblCircRule.TabIndex = 23;
            this.lblCircRule.Text = "Circumference = 2x + 2y";
            // 
            // lblArea
            // 
            this.lblArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArea.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblArea.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(13, 312);
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
            this.lblAreaRule.Location = new System.Drawing.Point(10, 281);
            this.lblAreaRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAreaRule.Name = "lblAreaRule";
            this.lblAreaRule.Size = new System.Drawing.Size(81, 16);
            this.lblAreaRule.TabIndex = 21;
            this.lblAreaRule.Text = "Area = x * y";
            // 
            // txbWidth
            // 
            this.txbWidth.Location = new System.Drawing.Point(153, 228);
            this.txbWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txbWidth.Name = "txbWidth";
            this.txbWidth.Size = new System.Drawing.Size(153, 22);
            this.txbWidth.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Enter Width x:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 106);
            this.label1.TabIndex = 17;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // rectangleBox
            // 
            this.rectangleBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rectangleBox.Location = new System.Drawing.Point(408, 266);
            this.rectangleBox.Margin = new System.Windows.Forms.Padding(4);
            this.rectangleBox.Name = "rectangleBox";
            this.rectangleBox.Size = new System.Drawing.Size(507, 271);
            this.rectangleBox.TabIndex = 30;
            this.rectangleBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Homework4.Properties.Resources.rectangle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txbHight
            // 
            this.txbHight.Location = new System.Drawing.Point(451, 228);
            this.txbHight.Margin = new System.Windows.Forms.Padding(4);
            this.txbHight.Name = "txbHight";
            this.txbHight.Size = new System.Drawing.Size(153, 22);
            this.txbHight.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Enter Hight y:";
            // 
            // RectangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(972, 558);
            this.Controls.Add(this.txbHight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rectangleBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.lblDiag);
            this.Controls.Add(this.lblDiagRule);
            this.Controls.Add(this.lblCirc);
            this.Controls.Add(this.lblCircRule);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblAreaRule);
            this.Controls.Add(this.txbWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "RectangleForm";
            this.Text = "RectangleForm";
            ((System.ComponentModel.ISupportInitialize)(this.rectangleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rectangleBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Label lblDiag;
        private System.Windows.Forms.Label lblDiagRule;
        private System.Windows.Forms.Label lblCirc;
        private System.Windows.Forms.Label lblCircRule;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblAreaRule;
        private System.Windows.Forms.TextBox txbWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbHight;
        private System.Windows.Forms.Label label3;
    }
}