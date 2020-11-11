using BussinessObject;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.Sales
{
    public partial class SalesService : Form
    {
        ServiceBO pbo = new ServiceBO();
        UserBO ubo = new UserBO();
        SaleBO sbo = new SaleBO();
        LinkedList<User> clients = new LinkedList<User>();
        public SalesService()
        {
            InitializeComponent();
        }

        private void SalesService_Load(object sender, EventArgs e)
        {
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvProduct.DataSource = pbo.getServDataTableSale();
            foreach (User user in ubo.getLinkedUser())
            {
                if (user.type.Equals("Cliente"))
                {
                    clients.AddLast(user);
                    cmbClients.Items.Add(user.dni + " - " + user.name);
                }
            }
            lblFactura.Text = sbo.generateCode();
        }
        private void addService()
        {
            if (dgvProduct.SelectedRows.Count > -1)
            {
                foreach (DataGridViewRow row in dgvProduct.Rows)
                {
                    if (row.Selected)
                    {
                        int newRow = dgvBuyData.Rows.Add();
                        dgvBuyData.Rows[newRow].Cells[0].Value = row.Cells[0].Value.ToString();
                        dgvBuyData.Rows[newRow].Cells[1].Value = row.Cells[1].Value.ToString();
                        dgvBuyData.Rows[newRow].Cells[2].Value = row.Cells[3].Value.ToString();
                        dgvBuyData.Rows[newRow].Cells[3].Value = 1;
                        int total = int.Parse(lblTotal.Text);
                        int quantity = 1;
                        int priceProduct = int.Parse(row.Cells[3].Value.ToString());
                        lblTotal.Text = (total + (quantity * priceProduct)).ToString();
                        dgvProduct.Rows.RemoveAt(this.dgvProduct.SelectedRows[0].Index);
                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado un servicio");
                    }
                }

            }
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            addService();
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if (dgvBuyData.Rows.Count > 0 && (cmbClients.SelectedItem != null))
            {
                foreach (DataGridViewRow row in dgvBuyData.Rows)
                {
                    sbo.createSale(lblFactura.Text, Convert.ToInt32(cmbClients.SelectedItem.ToString().Split('-')[0].Trim()), Convert.ToInt32(row.Cells[0].Value), Convert.ToInt32(row.Cells[3].Value), "Service", 0, 0);
                    MessageBox.Show("¡Agregado con exito!");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado el cliente");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvBuyData.Rows.RemoveAt(this.dgvBuyData.SelectedRows[0].Index);
            dgvProduct.DataSource = pbo.getServDataTableSale();
            foreach (DataGridViewRow product in dgvProduct.Rows)
            {
                foreach (DataGridViewRow buy in dgvBuyData.Rows)
                {
                    if (product.Cells[0].Value.ToString().Equals(buy.Cells[0].Value.ToString()))
                    {
                        dgvProduct.Rows.RemoveAt(product.Index);
                    }
                }
            }
        }
    }
}
