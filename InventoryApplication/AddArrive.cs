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
    public partial class AddArrive : Form
    {
        public AddArrive()
        {
            InitializeComponent();
            this.CenterToParent();
            Utils.LoadProducts(cbProducts);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int quantity = 0;

            if (cbProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto");
            }
            else if (int.TryParse(txtQuantity.Text, out quantity) == false || quantity < 1)
            {
                MessageBox.Show("Ingrese una cantidad válida");
            }
            else
            {
                Product product = (cbProducts.SelectedItem as ComboBoxItem).Value as Product;
                DateTime selectedDate = dtpArriveDate.Value;

                product.Quantity += quantity;

                if (BusinessController.Instance.Update<Product>(product))
                {
                    Arrive arrive = new Arrive() 
                    {
                        ProductId = product.Id,
                        Quantity = quantity,
                        Date = selectedDate
                    };

                    if (BusinessController.Instance.Add<Arrive>(arrive))
                    {
                        MessageBox.Show("Cantidad y registro agregados");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Se agregó la cantidad al inventario pero no se pudo agregar el registro");
                    }

                }
                else
                {
                    MessageBox.Show("No se pudo agregar la cantidad al inventario y por consiguiente no se agregó el registro");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
