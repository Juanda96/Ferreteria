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

namespace Ferreteria.Cashiers
{
    public partial class Payment : Form
    {
        SaleBO sbo = new SaleBO();
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            dgvPayment.EnableHeadersVisualStyles = false;
            dgvPayment.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvPayment.DataSource = sbo.selectSalePayment();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            PayOut po = new PayOut();
            po.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
