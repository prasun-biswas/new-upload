using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListViewHelperNameSpace;


namespace ListViewAdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string name = nameTextBox.Text;
            double salary = Convert.ToDouble(salaryTextBox.Text);

            ListViewHelper helper = new ListViewHelper();
            helper.AddToListView(employeeListView,id,name,salary);
        }
    }
}
