using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileOperationApp
{
    public partial class FileUI : Form
    {
        private string fileLocation = @"studentname.doc";
        public FileUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(fileLocation, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFileStream );
            aStreamWriter.Write(nameTextBox.Text + "\n");
            aStreamWriter.WriteLine();
            aStreamWriter.Close();

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(fileLocation, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);
            namesListBox.Items.Clear();
            while (!aStreamReader.EndOfStream)
            {
                string aLine = aStreamReader.ReadLine();
                namesListBox.Items.Add(aLine);
            }
            aStreamReader.Close();

        }
    }
}
