using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameReverse
{
    public partial class NameReverse : Form
    {
        public NameReverse()
        {
            InitializeComponent();
        }
        person aPerson = new person();
        private void button1_Click(object sender, EventArgs e)
        {
            aPerson.firstname = textBoxFirstName.Text;
            aPerson.middlename = textBoxMiddleName.Text;
            aPerson.lastname = textBoxLastName.Text;

            textBoxFullName.Text=aPerson.GetFullname();
            textBoxReverseName.Text = aPerson.GetReverseName();
        }
    }
}
