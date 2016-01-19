using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApplication
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InventoryWindow().ShowDialog();
            this.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductsWindow().ShowDialog();
            this.Show();
        }

        private void btnArrives_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ArrivesWindow().ShowDialog();
            this.Show();
        }

        private void btnDepartures_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeparturesWindow().ShowDialog();
            this.Show();
        }
    }
}
