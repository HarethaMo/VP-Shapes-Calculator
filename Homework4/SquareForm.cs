using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework4
{
    public partial class SquareForm : Form
    {
        public SquareForm()
        {
            InitializeComponent();
        }

        private void SquareForm_Load(object sender, EventArgs e)
        {

        }

        private void lblCirc_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblAreaRule.Text = "Area = x^2";
            lblCircRule.Text = "Circumference = 4x";
            lblDiagRule.Text = "Diagonal = x√2";
            txbLength.Text = "";
            lblArea.Text = "";
            lblCirc.Text = "";
            lblDiag.Text = "";
            squareBox.CreateGraphics().Clear(squareBox.BackColor);
            txbLength.Focus();
        }
        private void btnSquare_Click(object sender, EventArgs e)
        {
            try
            {
                lblAreaRule.Text = "Area = x^2";
                lblCircRule.Text = "Circumference = 4x";
                lblDiagRule.Text = "Diagonal = x√2";
                float length = float.Parse(txbLength.Text);
                if(length < 10 || length> 200)
                {
                    MessageBox.Show("Please enter a number between 10 and 200.\nThe unit of measuerment is pixels");
                    txbLength.Text = "";
                    txbLength.Focus();
                    return;
                }
                squareBox.CreateGraphics().Clear(squareBox.BackColor);
                drawSquare(length);
                float diag = (float)Math.Sqrt(2 * length * length);
                lblArea.Text = (length * length).ToString();
                lblCirc.Text = (4 * length).ToString();
                lblDiag.Text = diag.ToString("0.00");
                lblAreaRule.Text += String.Format(" = {0} * {0}", length);
                lblCircRule.Text += String.Format(" = 4 * {0}", length);
                lblDiagRule.Text += String.Format(" = {0} * √2", length);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
        void drawSquare(float x)
        {
            Graphics g = squareBox.CreateGraphics();
            Pen p = new Pen(Color.Black, 3);
            g.DrawRectangle(p, 10, 10, x, x);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAreaRule_Click(object sender, EventArgs e)
        {

        }

        private void lblDiagRule_Click(object sender, EventArgs e)
        {

        }

        private void lblCircRule_Click(object sender, EventArgs e)
        {

        }

        private void lblArea_Click(object sender, EventArgs e)
        {

        }

        private void lblDiag_Click(object sender, EventArgs e)
        {

        }
    }
}
