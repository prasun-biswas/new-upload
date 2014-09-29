using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_from
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List <string> mylist = new List<string>();
        private int index=0;
        private int count;
        
        private void addButton_Click(object sender, EventArgs e)
        {
            mylist.Add(inputTextBox.Text);
            index += 1;
            inputTextBox.Text = " ";
            addcountLabel.Text = Convert.ToString(index);
            if (index == count)
            {
                addButton.Enabled = false;
                numberlistBox.Items.Clear();
                index = 0;
                foreach (string name in mylist)
                {
                    numberlistBox.Items.Add(name);
                }
                
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            numberlistBox.Items.Clear();
            inputTextBox.Text = " ";
            index = 0;
            datacountTextBox.Text = " ";
            mylist.Clear();
            addcountLabel.Text = "0";
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            foreach (string name in mylist)
            {
                numberlistBox.Items.Add(name);
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            count =Convert.ToInt32(datacountTextBox.Text);
        }
    }
}
