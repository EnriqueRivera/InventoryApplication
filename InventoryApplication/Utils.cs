using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApplication
{
    public class Utils
    {
        public static void LoadProducts(ComboBox cbProducts)
        {
            List<Product> allProducts = BusinessController.Instance.FindBy<Product>(p => p.IsDeleted == false)
                                        .OrderBy(p => p.Code)
                                        .ToList();

            foreach (Product product in allProducts)
            {
                cbProducts.Items.Add(new ComboBoxItem() { Text = product.Code + " - " + product.Description, Value = product });
            }
        }

        public static void ExportToExcelFile(DataGridView dg, string tabName)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            sfd.FileName = tabName + ".xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportToExcelFile(dg, sfd.FileName, tabName);
                    MessageBox.Show("Reporte creado");
                }
                catch (Exception)
                {
                    MessageBox.Show("No pudo ser creado el reporte");
                }
            }
        }

        private static void ExportToExcelFile(DataGridView dGV, string filename, string tabName)
        {
            //Creating DataTable
            DataTable dt = new DataTable();

            //Adding the Columns
            foreach (DataGridViewColumn column in dGV.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows
            foreach (DataGridViewRow row in dGV.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, tabName);
                wb.SaveAs(filename);
            }
        }  
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
