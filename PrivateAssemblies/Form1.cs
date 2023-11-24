using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace PrivateAssemblies
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            cbOperations.Items.Add("+");
            cbOperations.Items.Add("-");
            cbOperations.Items.Add("*");
            cbOperations.Items.Add("/");
        }
        float a, b;
        private void button1_Click(object sender, EventArgs e)
        {
            a = float.Parse(tbNum1.Text);
            b = float.Parse(tbNum2.Text);

            if (cbOperations.Text == "+")
            {
                lblTotal.Text = BasicComputation.Addition(a, b).ToString();
            }
            else if(cbOperations.Text == "-")
            {
                lblTotal.Text = BasicComputation.Subtraction(a, b).ToString(); 
            }
            else if (cbOperations.Text == "*")
            {
                lblTotal.Text = BasicComputation.Multiplication(a, b).ToString();
            }
            else if ( cbOperations.Text == "/")
            {
                lblTotal.Text = BasicComputation.Division(a, b).ToString();
            }
        }
    }
}
