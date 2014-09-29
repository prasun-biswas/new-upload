using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Calculate doCalculate = new Calculate();
        private double firstNo;
        private double secondNo;
        private double result;

        public Calculator()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            GetFirstAndSecondNo();

            result = doCalculate.Add( firstNo,secondNo);
            textBoxResult.Text = result.ToString();

        }

        private void GetFirstAndSecondNo()
        {
            firstNo = Convert.ToDouble(textBoxFirstNumber.Text);
            secondNo = Convert.ToDouble(textBoxSecondNumber.Text);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            GetFirstAndSecondNo();

            result = doCalculate.Subtract(firstNo, secondNo);
            textBoxResult.Text = result.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            GetFirstAndSecondNo();

            result = doCalculate.Multiply(firstNo, secondNo);
            textBoxResult.Text = result.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            GetFirstAndSecondNo();

            result = doCalculate.Divide(firstNo, secondNo);
            textBoxResult.Text = result.ToString();
        }
    }
}
