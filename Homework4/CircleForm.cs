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
    public partial class CircleForm : Form
    {
        public CircleForm()
        {
            InitializeComponent();
        }
        void drawCircle(float radius)
        {
            Graphics g = CircleBox.CreateGraphics();
            Pen p = new Pen(Color.Black, 3);
            g.DrawEllipse(p, 10, 10, radius, radius);
            
        }
        private void btnSquare_Click(object sender, EventArgs e)
        {
            try
            {
                lblAreaRule.Text = "Area = πR^2";
                lblCircRule.Text = "Circumference = 2πR";
                lblDiagRule.Text = "Diameter = 2R";
                float radius = float.Parse(txbRadius.Text);
                if (radius < 10 || radius > 200)
                {
                    MessageBox.Show("Please enter a number between 10 and 200.\nThe unit of measuerment is pixels");
                    txbRadius.Text = "";
                    txbRadius.Focus();
                    return;
                }
                CircleBox.CreateGraphics().Clear(CircleBox.BackColor);
                drawCircle(radius);
                lblArea.Text = (Math.PI * radius * radius).ToString("0.00");
                lblCirc.Text = (2 * Math.PI * radius).ToString("0.00");
                lblDiag.Text = (2 * radius).ToString("0.00");
                lblAreaRule.Text += String.Format(" =  π * {0}^2", radius);
                lblCircRule.Text += String.Format(" =  2π * {0}", radius);
                lblDiagRule.Text += String.Format(" = 2 * {0}", radius);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblAreaRule.Text = "Area = x^2";
            lblCircRule.Text = "Circumference = 4x";
            lblDiagRule.Text = "Diagonal = x√2";
            txbRadius.Text = "";
            lblArea.Text = "";
            lblCirc.Text = "";
            lblDiag.Text = "";
            CircleBox.CreateGraphics().Clear(CircleBox.BackColor);
            txbRadius.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
