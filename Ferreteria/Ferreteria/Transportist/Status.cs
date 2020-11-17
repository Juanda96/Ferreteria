using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessObject;
using Entity;

namespace Ferreteria.Transportist
{
    public partial class Status : Form
    {
        TransportBO t = new TransportBO();

        UserBO ub = new UserBO();
        SaleBO sbo = new SaleBO();
        public Status()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.updateStatus(0, "ABC345");
            dgvStatus.DataSource = t.selectTransportStatus();
          
            MessageBox.Show("Vehículo Disponible");

        }


        private void Status_Load(object sender, EventArgs e)
        {
            dgvStatus.EnableHeadersVisualStyles = false;
            dgvStatus.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvStatus.DataSource = t.selectTransportStatus();
            foreach (var item in t.selectTransportStatusLink1())
            {
                cmbCamion.Items.Add(item);
            }


        }

        private void cmbCamion_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}

