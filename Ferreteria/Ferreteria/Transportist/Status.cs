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
           
            foreach (DataGridViewRow row in dgvStatus0.Rows)
            {                
                t.updateStatus(Convert.ToInt32(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString());
                t.updateStatus(1, cmbCamion.Text);
                dgvStatus0.Rows.Add(t);

            }
            MessageBox.Show("Vehículo Ocupado");
        }

        private void Status_Load(object sender, EventArgs e)
        {

            foreach (var item in t.selectTransportStatusLink())
            {
                cmbCamion.Items.Add(item);
            }

            //    foreach (var compra in t.selectTransportStatusLink())
            //    {
            //        foreach (var user in ub.getLinkedClients())
            //        {
            //            if (compra == user.dni)
            //            {
            //                cmbCamion.Items.Add(user.name + " - " + user.dni);
            //            }
            //        }
            //    }

        }

        private void cmbCamion_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}

