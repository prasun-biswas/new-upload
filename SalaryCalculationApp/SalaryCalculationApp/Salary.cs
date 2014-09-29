using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculationApp
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        private void totalSalaryButton_Click(object sender, EventArgs e)
        {
            CalSalary aSalary =new CalSalary();
            aSalary.name = textBoxName.Text;
            aSalary.basic = Convert.ToDouble(textBoxBasic.Text);
            aSalary.house = Convert.ToDouble(textBoxHousePer.Text);
            aSalary.medical = Convert.ToDouble(textBoxMedicalPer.Text);
            double total = aSalary.GetTotal();

            MessageBox.Show(aSalary.name + "your salary is"+ total);
        }

       
    }
}
