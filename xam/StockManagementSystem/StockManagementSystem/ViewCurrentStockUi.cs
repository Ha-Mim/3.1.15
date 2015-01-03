using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class ViewCurrentStockUi : Form
    {
       
        private Stock aStock;

        public ViewCurrentStockUi(Stock aStock)
        {
            this.aStock = aStock;
           ;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void ViewCurrentStockUi_Load(object sender, EventArgs e)
        {

            foreach (Item aItem in aStock.GetItems())
            {

                ListViewItem myView = new ListViewItem(aItem.ItemId);
                myView.SubItems.Add(aItem.Quantity.ToString());

                viewCurrentStockListView.Items.Add(myView);
            }
        }
    }
}
