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
    public partial class ProductsWindow : Form
    {
        public ProductsWindow()
        {
            InitializeComponent();
            this.CenterToScreen();
            cbFilter.SelectedIndex = 0;
        }

        private void ProductsWindow_Load(object sender, EventArgs e)
        {
            ViewAll();
        }

        private void btnMainWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            new AddProductWindow().ShowDialog();
            ViewAll();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgProducts.CurrentCell.RowIndex;

            if (selectedRowIndex == -1)
            {
                MessageBox.Show("Seleccione un producto");
            }
            else if (MessageBox.Show("Está seguro que desea eliminar el producto seleccionado", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int productId = (dgProducts.Rows[selectedRowIndex].DataBoundItem as ProductViewModel).Id;

                Product productToDelete = BusinessController.Instance.FindById<Product>(productId);

                if (productToDelete == null)
                {
                    MessageBox.Show("No se pudo eliminar el producto");   
                }
                else
                {
                    productToDelete.IsDeleted = true;

                    if (BusinessController.Instance.Update<Product>(productToDelete))
                    {
                        MessageBox.Show("Producto eliminado");
                        ViewAll();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el producto");
                    }
                }
            }
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
            dgProducts.DataSource = products.Select(i =>
                new ProductViewModel()
                {
                    Id = i.Id,
                    Code = i.Code,
                    Description = i.Description
                }
            ).ToList();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Utils.ExportToExcelFile(dgProducts, "Productos");
        }
    }

    class ProductViewModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("Código de producto")]
        public string Code { get; set; }

        [DisplayName("Descripción")]
        public string Description { get; set; }
    }
}
