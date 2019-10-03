using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobidiagGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPrimeSummation_Click(object sender, EventArgs e)
        {
            lblPrimeSummation.Visible = true;
            lblPrimeSummation.Text = "Sum is " + PrimeSummation.PrimeSummation.SumAllPrimesBelow(2000000).ToString();
        }

        private void BtnCollatz_Click(object sender, EventArgs e)
        {
            lblCollatz.Visible = true;
            lblCollatz.Text = "The longest sequence is " + Collatz.CollatzSequence.SolveLongestSequenceStartingUnder(1000000).ToString();
        }

        private void BtnFibonacci_Click(object sender, EventArgs e)
        {
            lblFibonacci.Visible = true;
            lblFibonacci.Text = "Sum is " + Fibonacci.Fibonacci.SumEvenNumbersUpTo(4000000).ToString();
        }
    }
}
