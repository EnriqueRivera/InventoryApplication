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
    public partial class AddProductWindow : Form
    {
        public AddProductWindow()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Debe ingresar un código");
            }
            else if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Debe ingresar una descripción");
            }
            else
            {
                Product product = BusinessController.Instance.FindBy<Product>(p => p.IsDeleted == false && p.Code == code).FirstOrDefault();

                if (product == null)
                {
                    Product productToAdd = new Product()
                    {
                        Code = code,
                        Description = description,
                        Quantity = 0,
                        IsDeleted = false
                    };

                    if (BusinessController.Instance.Add<Product>(productToAdd))
                    {
                        MessageBox.Show("Producto agregado");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el producto");
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un producto con ese código:\nCódigo: " + product.Code + "\nDescripción: " + product.Description);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
