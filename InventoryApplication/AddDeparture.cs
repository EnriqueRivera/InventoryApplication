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
    public partial class AddDeparture : Form
    {
        public AddDeparture()
        {
            InitializeComponent();
            this.CenterToParent();
            Utils.LoadProducts(cbProducts);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddDeparture_Click(object sender, EventArgs e)
        {
            int quantity = 0;
            string petitioner = txtPetitioner.Text.Trim();
            string folio = txtFolio.Text.Trim();
            string area = txtArea.Text.Trim();

            if (cbProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto");
            }
            else if (int.TryParse(txtQuantity.Text, out quantity) == false || quantity < 1)
            {
                MessageBox.Show("Ingrese una cantidad válida");
            }
            else if (string.IsNullOrEmpty(petitioner))
            {
                MessageBox.Show("Ingrese el nombre del solicitante");
            }
            else if (string.IsNullOrEmpty(folio))
            {
                MessageBox.Show("Ingrese el folio");
            }
            else
            {
                Product product = (cbProducts.SelectedItem as ComboBoxItem).Value as Product;

                if (quantity > product.Quantity)
                {
                    MessageBox.Show("No se puede entregar esa cantidad porque sobrepasa la cantidad existente del producto seleccionado");
                }
                else
                {
                    DateTime selectedDate = dtpArriveDate.Value;

                    product.Quantity -= quantity;

                    if (BusinessController.Instance.Update<Product>(product))
                    {
                        Departure departure = new Departure()
                        {
                            ProductId = product.Id,
                            Quantity = quantity,
                            Date = selectedDate,
                            Petitioner = petitioner,
                            Folio = folio,
                            Area = area
                        };

                        if (BusinessController.Instance.Add<Departure>(departure))
                        {
                            MessageBox.Show("Cantidad disminuida y registro agregado");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Se disminuyó la cantidad al inventario pero no se pudo agregar el registro");
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se pudo disminuir la cantidad al inventario y por consiguiente no se agregó el registro");
                    }
                }
            }
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProducts.SelectedIndex != -1)
            {
                Product product = (cbProducts.SelectedItem as ComboBoxItem).Value as Product;
                lblQuantityLeft.Text = "Quedan: " + product.Quantity;
            }
        }
    }
}
