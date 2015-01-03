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
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }
        
        Stock aStock = new Stock();
        private void stockInButton_Click(object sender, EventArgs e)
        {
            StockInUI aStockInUi = new StockInUI(aStock);
            aStockInUi.Show();
        }

        private void stockOutButton_Click(object sender, EventArgs e)
        {
            StockOutUI aStockOutUi = new StockOutUI(aStock);
            aStockOutUi.Show();
        }

        private void viewCurrentStockButton_Click(object sender, EventArgs e)
        {
            ViewCurrentStockUi aViewCurrentStockUi = new ViewCurrentStockUi(aStock);
            aViewCurrentStockUi.Show();
        }
    }
}
