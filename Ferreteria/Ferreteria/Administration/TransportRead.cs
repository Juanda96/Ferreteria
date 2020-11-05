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

namespace Ferreteria.Administration
{
    public partial class TransportRead : Form
    {
        TransportBO tbo = new TransportBO();
        public TransportRead()
        {
            InitializeComponent();
        }

        private void TransportRead_Load(object sender, EventArgs e)
        {
            dgvTransport.EnableHeadersVisualStyles = false;
            dgvTransport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvTransport.DataSource = tbo.getTransportDataTable();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            TransportAdd ta = new TransportAdd();
            ta.Show();
        }
    }
}
