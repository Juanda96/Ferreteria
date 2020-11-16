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

namespace Ferreteria.Transportist
{
    
    public partial class PayOutProducts : Form
    {
        SaleBO sbo = new SaleBO();
        UserBO ubo = new UserBO();
        TransportBO tbo = new TransportBO();
        public PayOutProducts()
        {
            InitializeComponent();
        }
        private void PayOutProducts_Load(object sender, EventArgs e)
        {
            foreach (var compra in sbo.clientReadyTransportLink())
            {
                foreach (var user in ubo.getLinkedClients())
                {
                    if (compra == user.dni)
                    {
                        cmbUserBuy.Items.Add(user.name + " - " + user.dni);
                    }
                }
            }

            foreach (var item in tbo.selectTransportStatusLink())
            {
                cmbCamión.Items.Add(item);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbUserBuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvReadyToTransport.DataSource = sbo.productReadyTransport(int.Parse(cmbUserBuy.Text.Split('-')[1].Trim()));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvReadyToTransport.Rows)
            {
                sbo.changeDelivery(Convert.ToInt32(row.Cells[0].Value.ToString()));
                tbo.updateStatus(1, cmbCamión.Text);
            }
            MessageBox.Show("Entrega iniciada");
        }

        private void cmbCamión_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
