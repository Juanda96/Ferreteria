using BussinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ferreteria.Administration
{
    public partial class Reports : Form
    {
        SaleBO sbo = new SaleBO();
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            int service = 0;
            int product = 0;
            foreach (var sale in sbo.selectSalesReport())
            {
                if (sale.type.Equals("Service"))
                {
                    service++;
                } else if(sale.type.Equals("Product"))
                {
                    product++;
                }
            }
            ventas.Titles.Add("Ventas de productos y servicios");
            Series serie1 = ventas.Series.Add("Productos");
            serie1.Label = product.ToString();
            serie1.Points.Add(product);
            Series serie2 = ventas.Series.Add("Servicios");
            serie2.Label = service.ToString();
            serie2.Points.Add(service);

            foreach (var item in sbo.selectSalesReportCatProduct().GroupBy(x=>x))
            {
                catProdcut.Titles.Add("Ventas de productos por categoria");
                Series serie3 = catProdcut.Series.Add(item.Key);
                serie3.Label = item.Key;
                serie3.Points.Add(item.Count());
            }

            foreach (var item in sbo.selectSalesReportCatService().GroupBy(x => x))
            {
                CatService.Titles.Add("Ventas de Servicios por categoria");
                Series serie3 = CatService.Series.Add(item.Key);
                serie3.Label = item.Key;
                serie3.Points.Add(item.Count());
            }
        }

        private void ventas_Click(object sender, EventArgs e)
        {

        }

        private void CatService_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
