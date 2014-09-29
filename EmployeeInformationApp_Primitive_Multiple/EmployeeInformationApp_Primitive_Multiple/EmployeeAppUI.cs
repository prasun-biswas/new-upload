using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationApp_Primitive_Multiple
{
    public partial class EmployeeAppUI : Form
    {
        public EmployeeAppUI()
        {
            InitializeComponent();
        }

        List<int> idList = new List<int>();
        List<string> nameList = new List<string>();
        List<double> salaryList = new List<double>();
        List<string> addressList = new List<string>(); 
        private void saveButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string name = nameTextBox.Text;
            double salary = Convert.ToDouble(salaryTextBox.Text);
            string address = addressTextBox.Text;
            SaveEmployee(id, name, salary, address);
            InsertIntoListView(id, name, salary);
        }

        private void InsertIntoListView(int id, string name, double salary)
        {
            ListViewItem item = new ListViewItem(id.ToString());
            item.SubItems.Add(name);
            item.SubItems.Add(salary.ToString());

            employeeListView.Items.Add(item);
        }

        private void SaveEmployee(int id, string name, double salary, string address)
        {
            idList.Add(id);
            nameList.Add(name);
            salaryList.Add(salary);
            addressList.Add(address);
        }

        private void employeeListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = employeeListView.SelectedIndices[0];
            idTextBox.Text = idList[selectedIndex].ToString();
            nameTextBox.Text = nameList[selectedIndex];
            salaryTextBox.Text = salaryList[selectedIndex].ToString();
            addressTextBox.Text = addressList[selectedIndex];
        }

       

       
    }
}
