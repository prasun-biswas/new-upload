using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace Daily_Expense_Application
{
    public partial class DailyExpenseForm : Form
    {
        public DailyExpenseForm()
        {
            totalExpense = 0;
            maximumExpense = 0;
            InitializeComponent();
        }

        private string fileLocation = @"C:\Users\PC21\Documents\Lab Exam\Daily Expense Application\Daily Expense Application\file\dailyExpenseData.csv";
        private double totalExpense;
        private double tempVal;
        private double maximumExpense;

        private void saveButton_Click(object sender, EventArgs e)
        {

            //empty total
            totalTextBox.Text = "";
            showListView.Items.Clear();
            //===========



            if (amountTextBox.Text == "" 
                || particularTextBox.Text =="" 
                || categoryComboBox.Text =="")
            {
                MessageBox.Show("Values cannot be empty!!");
                return;                
            }
            
            FileStream aStream = new FileStream(fileLocation ,FileMode.Append);
            CsvFileWriter aWriter= new CsvFileWriter(aStream);

            List<string> aDailyExpense = new List<string>();


             
            tempVal = Convert.ToDouble(amountTextBox.Text);
            totalExpense += tempVal;

            //find max
            if (maximumExpense < tempVal)
            {
                maximumExpense = tempVal;
            }

            aDailyExpense.Add(amountTextBox.Text);
            aDailyExpense.Add(categoryComboBox.Text);
            aDailyExpense.Add(particularTextBox.Text);

            aWriter.WriteRow(aDailyExpense);
            aStream.Close();

            MessageBox.Show("Success!!");



            amountTextBox.Text = "";
            particularTextBox.Text = "";
        }




        private void viewSummaryShowButton_Click(object sender, EventArgs e)
        {
            
            
            totalExpenseTextBox.Text = totalExpense.ToString();
            maximumExpenseTextBox.Text = maximumExpense.ToString();

            //double total = 0;
            double maxVal = 0;
            double totalVal = 0;
            showListView.Items.Clear();



            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aDailyExpense = new List<string>();

            
            
            if (new FileInfo(fileLocation).Length != 0)
            {
                while (aReader.ReadRow(aDailyExpense))
                {

                    tempVal = Convert.ToDouble(aDailyExpense[0]);


                    //tempVal = Convert.ToDouble(aDailyExpense[0]);
                    if (maxVal < tempVal)
                    {
                        maxVal = tempVal;
                    }

                    totalVal += tempVal;
                }
            }

            
            
            totalExpenseTextBox.Text = totalVal.ToString();
            maximumExpenseTextBox.Text = maxVal.ToString();
            aStream.Close();

        }

        private void DailyExpenseForm_Load(object sender, EventArgs e)
        {
            amountTextBox.Focus();
            
            totalExpense = 0;
            maximumExpense = 0;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            
            double total = 0;
            showListView.Items.Clear();

            string haveToMatch = categoryComboBox2.Text;
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);

            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aDailyExpense = new List<string>();

            ListViewItem listViewItem;

            if (new FileInfo(fileLocation).Length != 0)
            {
                while (aReader.ReadRow(aDailyExpense))
                {
                    if (aDailyExpense[1] == haveToMatch)
                    {

                        listViewItem = new ListViewItem(
                        new string []
                        {
                            
                            aDailyExpense[0],
                            aDailyExpense[1],
                            aDailyExpense[2]
                        }
                    );
                        
                        showListView.Items.Add(listViewItem);

                        total += Convert.ToDouble(aDailyExpense[0]);
                    }
                }
            }
            aStream.Close();


            totalTextBox.Text = total.ToString();
        }
    }
}
