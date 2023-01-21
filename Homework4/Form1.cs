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
    public partial class Form1 : Form
    {
        
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            SquareForm squareForm = new SquareForm();
            squareForm.Show();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            CircleForm circleForm = new CircleForm();
            circleForm.Show();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            RectangleForm rectangleForm = new RectangleForm();
            rectangleForm.Show();
        }
    }
}
