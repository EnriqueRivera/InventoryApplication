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
    public partial class DeparturesWindow : Form
    {
        public DeparturesWindow()
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

        private void btnAddArrive_Click(object sender, EventArgs e)
        {
            new AddDeparture().ShowDialog();
            FilterSearch();
        }

        private void DeparturesWindow_Load(object sender, EventArgs e)
        {
            FilterSearch();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Utils.ExportToExcelFile(dgDepartures, "Entregas");
        }

        private void UpdateGrid(List<Departure> departures)
        {
            dgDepartures.DataSource = departures.Select(i =>
                new DepartureViewModel()
                {
                    Code = i.Product.Code,
                    Description = i.Product.Description,
                    Quantity = i.Quantity,
                    Date = i.Date,
                    Petitioner = i.Petitioner,
                    Folio = i.Folio,
                    Area = i.Area
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

            List<Departure> departures = BusinessController.Instance.FindBy<Departure>(p => p.Date >= startTime && p.Date <= endTime)
                                            .OrderByDescending(p => p.Date)
                                            .ToList();

            if (selectedItem is Product)
            {
                Product selectedProduct = selectedItem as Product;
                departures = departures.Where(p => p.Id == selectedProduct.Id).ToList();
            }

            UpdateGrid(departures);
        }
    }

    class DepartureViewModel
    {
        [DisplayName("Código de producto")]
        public string Code { get; set; }

        [DisplayName("Descripción")]
        public string Description { get; set; }

        [DisplayName("Cantidad")]
        public int Quantity { get; set; }

        [DisplayName("Fecha")]
        public DateTime Date { get; set; }

        [DisplayName("Solicitante")]
        public string Petitioner { get; set; }

        [DisplayName("Folio vale")]
        public string Folio { get; set; }

        [DisplayName("Área que solicitó")]
        public string Area { get; set; }
    }
}
