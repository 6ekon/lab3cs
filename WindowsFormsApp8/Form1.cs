using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComplexNumbers R = new ComplexNumbers();
            ComplexNumbers a = new ComplexNumbers();
            ComplexNumbers b = new ComplexNumbers();
            ComplexNumbers c = new ComplexNumbers();
            ComplexNumbers d = new ComplexNumbers();
            R = b + a - (b / c * d.Pow(5));
            OutA.Text += a.Output();
            OutA.Text += b.Output();
            OutA.Text += c.Output();
            OutA.Text += d.Output();
            OutA.Text += R.Output();
        }
    }
}
