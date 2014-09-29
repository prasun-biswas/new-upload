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

namespace CustomerQueueManageUDT
{
    public partial class CusQueManForm : Form
    {
        Queue<Customer> aCustomerQueue =new Queue<Customer>();
        Customer aCustomer = new Customer();
        ListViewItem itemSelect;
        public int count;
        public int presentSlNo;
        private int dQserialNo;


        
        public CusQueManForm()
        {
            InitializeComponent();
        }

        private void buttonEnqueue_Click(object sender, EventArgs e)
        {
            //Customer aCustomer = new Customer();
            count++;
            aCustomer.name = textBoxName.Text;
            aCustomer.complain = textBoxComplain.Text;
            //aCustomer.serialNo = aCustomerQueue.Count+1;
            aCustomer.serialNo = Convert.ToInt32(count);
            aCustomerQueue.Enqueue(aCustomer);
            //int dQserialNo = Convert.ToInt32(textBoxSerialNo.Text);


            ListViewItem selectItem = new ListViewItem(aCustomer.serialNo.ToString());
            selectItem.SubItems.Add(aCustomer.name);
            selectItem.SubItems.Add(aCustomer.complain);
            listViewQueue.Items.Add(selectItem);

            //foreach (Customer see in aCustomerQueue)
            //{
            //    int i = count++;
            //    listViewQueue.Items.Add(aCustomer.serialNo.ToString());
            //    listViewQueue.Items[i].SubItems.Add(aCustomer.name);
            //    listViewQueue.Items[i].SubItems.Add(aCustomer.complain);
            //    yield break;
            //}
          

            textBoxName.Clear();
            textBoxComplain.Clear();
        }

      
        private void buttonDequeue_Click(object sender, EventArgs e)
        {
            
            int dQserialNo = Convert.ToInt32(textBoxSerialNo.Text);
            int presentSlNo = Convert.ToInt32(listViewQueue.Items[0].SubItems[0].Text);
            
            if (listViewQueue.Items.Count==0) return;


            textBoxNameShow.Text = listViewQueue.Items[0].SubItems[1].Text;
            textBoxComplainShow.Text = listViewQueue.Items[0].SubItems[2].Text;


            if (dQserialNo == presentSlNo)
            {

                aCustomerQueue.Dequeue();
                listViewQueue.Items.RemoveAt(0);
            }
            else if (dQserialNo < presentSlNo)
            {
                textBoxNameShow.Text = "The Customer";
                textBoxComplainShow.Text = "has been served";
            }
            else
            {
                textBoxNameShow.Text = "wrong guy";
                textBoxComplainShow.Text = "can't be processed now";
            }




            //listViewQueue.Items.Clear();
            //listViewQueue.Items.Add(itemSelect);
            //ShowInList(aCustomer,out itemSelect);

        }

       }
}
