using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework4
{
    public partial class RectangleForm : Form
    {
        public RectangleForm()
        {
            InitializeComponent();
        }
        void drawRectangle(float x, float y)
        {
            Graphics g = rectangleBox.CreateGraphics();
            Pen p = new Pen(Color.Black, 3);
            g.DrawRectangle(p, 10, 10, x, y);
        }
        private void btnSquare_Click(object sender, EventArgs e)
        {
            try
            {
                
                lblAreaRule.Text = "Area = x * y";
                lblCircRule.Text = "Circumference = 2x + 2y";
                lblDiagRule.Text = "Diagonal = √(x^2 + y^2)";
                float x = float.Parse(txbWidth.Text);
                float y = float.Parse(txbHight.Text);
                if (x< 10 || x > 350)
                {
                    MessageBox.Show("Please enter a width between 10 and 350.\nThe unit of measuerment is pixels");
                    txbWidth.Text = "";
                    txbHight.Text = "";
                    txbWidth.Focus();
                    return;
                }
                if (y < 10 || x > 200)
                {
                    MessageBox.Show("Please enter a hight between 10 and 200.\nThe unit of measuerment is pixels");
                    txbWidth.Text = "";
                    txbHight.Text = "";
                    txbWidth.Focus();
                    return;
                }
                rectangleBox.CreateGraphics().Clear(rectangleBox.BackColor);
                drawRectangle(x, y);
                float diag = (float)Math.Sqrt(x*x + y*y);
                lblArea.Text = (x * y).ToString("0.00");
                lblCirc.Text = ((2 * x) + (2*y)).ToString("0.00");
                lblDiag.Text = diag.ToString("0.00");
                lblAreaRule.Text += String.Format(" = {0} * {1}", x,y);
                lblCircRule.Text += String.Format(" = 2 * {0} + 2 * {1}", x,y);
                lblDiagRule.Text += String.Format(" = √({0}^2 + {1}^2)", x,y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbHight.Text = "";
            txbWidth.Text = "";
            lblArea.Text = "";
            lblCirc.Text = "";
            lblDiag.Text = "";
            lblAreaRule.Text = "Area = x * y";
            lblCircRule.Text = "Circumference = 2x + 2y";
            lblDiagRule.Text = "Diagonal = √(x^2 + y^2)";
            rectangleBox.CreateGraphics().Clear(rectangleBox.BackColor);
            txbWidth.Focus();
        }
    }
}
