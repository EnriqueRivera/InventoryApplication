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
    public partial class ArrivesWindow : Form
    {
        public ArrivesWindow()
        {
            InitializeComponent();
            this.CenterToScreen();
            LoadProducts();
        }

        private void LoadProducts()
        {
            cbProducts.Items.Add(new ComboBoxItem() { Text = "Todos", Value = string.Empty });
            Utils.LoadProducts(cbProducts);

            cbProducts.SelectedIndex = 0;
        }

        private void btnMainWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ArrivesWindow_Load(object sender, EventArgs e)
        {
            FilterSearch();
        }

        private void btnAddArrive_Click(object sender, EventArgs e)
        {
            new AddArrive().ShowDialog();
            FilterSearch();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Utils.ExportToExcelFile(dgArrives, "Entradas");
        }

        private void UpdateGrid(List<Arrive> arrives)
        {
            dgArrives.DataSource = arrives.Select(i =>
                new ArriveViewModel()
                {
                    Code = i.Product.Code,
                    Description = i.Product.Description,
                    Quantity = i.Quantity,
                    Date = i.Date
                }
            ).ToList();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterSearch();
        }

        private void FilterSearch()
        {
            object selectedItem = (cbProducts.SelectedItem as ComboBoxItem).Value;
            DateTime startTime = dtpStartDate.Value.Date;
            DateTime endTime = dtpEndDate.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);            

            List<Arrive> arrives = BusinessController.Instance.FindBy<Arrive>(p => p.Date >= startTime && p.Date <= endTime)
                                            .OrderByDescending(p => p.Date)
                                            .ToList();

            if (selectedItem is Product)
            {
                Product selectedProduct = selectedItem as Product;
                arrives = arrives.Where(p => p.Id == selectedProduct.Id).ToList();
            }

            UpdateGrid(arrives);
        }
    }

    class ArriveViewModel
    {
        [DisplayName("Código de producto")]
        public string Code { get; set; }

        [DisplayName("Descripción")]
        public string Description { get; set; }

        [DisplayName("Cantidad")]
        public int Quantity { get; set; }

        [DisplayName("Fecha")]
        public DateTime Date { get; set; }
    }
}
