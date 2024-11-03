using System;
using System.Windows.Forms;

namespace FactorialCalculator
{
    public partial class btnClear : Form
    {
        public btnClear()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtNumber.Text, out number) && number >= 0)
            {
                long factorial = CalculateFactorial(number);
                lblResult.Text = $"Factorial of {number} is {factorial}";
            }
            else
            {
                lblResult.Text = "Please enter a non-negative integer.";
            }
        }

        private long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * CalculateFactorial(n - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
