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
    public partial class StockInUI : Form
    {
        
        private Stock aStock;

        public StockInUI( Stock aStock )
        {
            this.aStock = aStock;
            
            InitializeComponent();
        }

        private void inButton_Click(object sender, EventArgs e)
        {
           Item aItem = new Item();
            aItem.ItemId = itemIdTextBox.Text;
            aItem.Quantity = Convert.ToInt32(quantityTextBox.Text);
            
            string msg = aStock.Additem(aItem);
            MessageBox.Show(msg);
        }
    }
}
