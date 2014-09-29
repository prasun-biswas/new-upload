using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_app
{
    public partial class Account1 : Form
    {
        public Account1()
        {
            InitializeComponent();
        }
        Account aAccount;
        private void createButton_Click(object sender, EventArgs e)
        {
            if (customerTextBox.Text != "" && acnoTextBox.Text!="")
            { 
                aAccount = new Account();
                aAccount.Name = customerTextBox.Text;
               
                aAccount.Number=acnoTextBox.Text;
                MessageBox.Show(@"Your Account has been Cteated.");
                customerTextBox.Text = "";
                acnoTextBox.Text = "";
            }
            else
            {
                MessageBox.Show(@"Please Enter a Value First."); 
            }
           
        }

        private void depositeButton_Click(object sender, EventArgs e)
        {
            if (aAccount != null)
            {

                double total = Convert.ToDouble(balanceTextBox.Text);
                aAccount.Deposit(total);
                balanceTextBox.Text = "";
                MessageBox.Show(@"Amount has been Deposited.");
            }
            else
            {
                MessageBox.Show(@"Please Enter a Value First.");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (aAccount != null)
            {
                double total = Convert.ToDouble(balanceTextBox.Text);
                aAccount.Withdraw(total);
                balanceTextBox.Text = "";
                MessageBox.Show(@"Amount has been Withdrawn.");
            }
            else
            {
                MessageBox.Show(@"Please Enter a Value First.");
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (aAccount != null)
            {
                MessageBox.Show(aAccount.Name + " Your Ac no is " + aAccount.Number + " your balance is " + aAccount.Balance);
            }
            else
            {
                MessageBox.Show(@"Please Enter a Value First.");
            }
        }

        
    }
}
