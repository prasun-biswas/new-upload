using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewHelperNameSpace
{
    public class ListViewHelper
    {
        public void AddToListView(ListView myListView, int id, string name, double salary)
        {
            ListViewItem item = new ListViewItem();
            item.Text = id.ToString();
            item.SubItems.Add(name);
            item.SubItems.Add(salary.ToString());

            myListView.Items.Add(item);
        }
    }
}
