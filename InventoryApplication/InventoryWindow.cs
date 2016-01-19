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
    public partial class InventoryWindow : Form
    {
        public InventoryWindow()
        {
            InitializeComponent();
            this.CenterToScreen();
            cbFilter.SelectedIndex = 0;
        }

        private void btnMainWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventoryWindow_Load(object sender, EventArgs e)
        {
            ViewAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            string searchTerm = txtSearchTerm.Text;

            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    products = BusinessController.Instance.FindBy<Product>(p => p.IsDeleted == false && p.Code.Contains(searchTerm)).ToList();
                    break;
                case 1:
                    products = BusinessController.Instance.FindBy<Product>(p => p.IsDeleted == false && p.Description.Contains(searchTerm)).ToList();
                    break;
                default:
                    break;
            }

            UpdateGrid(products);
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ViewAll();
        }

        private void ViewAll()
        {
            List<Product> products = BusinessController.Instance.FindBy<Product>(p => p.IsDeleted == false).ToList();
            UpdateGrid(products);
        }

        private void UpdateGrid(List<Product> products)
        {
            dgInventory.DataSource = products.Select(i =>
                new InventoryViewModel()
                {
                    Code = i.Code,
                    Description = i.Description,
                    Quantity = i.Quantity
                }
            ).ToList();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Utils.ExportToExcelFile(dgInventory, "Inventario");
        }
    }

    class InventoryViewModel
    {
        [DisplayName("Código de producto")]
        public string Code { get; set; }

        [DisplayName("Descripción")]
        public string Description { get; set; }

        [DisplayName("Cantidad disponible")]
        public int Quantity { get; set; }
    }
}
