using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_app
{
    class Account
    {
        private string number;
        private string name;
        private double balance;


        public string  Name
        {
           
            set
            {
                if (value.Length >= 0)
                {
                    name = value;
                }
            }
            get { return name; }
        }
        public string Number
        {

            set
            {
                if (value.Length >= 0)
                {
                    number = value;
                }
            }
            get { return number; }
        }
        public double Balance
        {
            get { return balance; }
        }

    
        
        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }


    }

}
