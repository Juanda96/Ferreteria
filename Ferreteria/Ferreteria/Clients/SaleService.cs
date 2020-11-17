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

namespace Ferreteria.Clients
{
    public partial class SaleService : Form
    {
        ProductBO pbo = new ProductBO();
        UserBO ubo = new UserBO();
        SaleBO sbo = new SaleBO();
        LinkedList<User> clients = new LinkedList<User>();
        public SaleService()
        {
            InitializeComponent();
        }

        private void SaleService_Load(object sender, EventArgs e)
        {
            dgvService.EnableHeadersVisualStyles = false;
            dgvService.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvService.DataSource = pbo.getProductDataTableSales();
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

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            if (dgvService.SelectedRows.Count > -1 && !(string.IsNullOrEmpty(txtQuantity.Text)))
            {
                foreach (DataGridViewRow row in dgvService.Rows)
                {
                    if (row.Selected)
                    {
                        if (Convert.ToInt32(row.Cells[3].Value) > Convert.ToInt32(txtQuantity.Text))
                        {
                            int newRow = dgvBuyData.Rows.Add();
                            dgvBuyData.Rows[newRow].Cells[0].Value = row.Cells[0].Value.ToString();
                            dgvBuyData.Rows[newRow].Cells[1].Value = row.Cells[1].Value.ToString();
                            dgvBuyData.Rows[newRow].Cells[2].Value = row.Cells[2].Value.ToString();
                            dgvBuyData.Rows[newRow].Cells[3].Value = txtQuantity.Text;
                            int total = int.Parse(lblTotal.Text);
                            int quantity = int.Parse(txtQuantity.Text);
                            int priceProduct = int.Parse(row.Cells[2].Value.ToString());
                            lblTotal.Text = (total + (quantity * priceProduct)).ToString();
                            dgvService.Rows.RemoveAt(this.dgvService.SelectedRows[0].Index);
                        }
                        else
                        {
                            MessageBox.Show("La cantidad solicitada es mayor al inventario");
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvBuyData.Rows.RemoveAt(this.dgvBuyData.SelectedRows[0].Index);
            dgvService.DataSource = pbo.getProductDataTableSales();
            foreach (DataGridViewRow product in dgvService.Rows)
            {
                foreach (DataGridViewRow buy in dgvBuyData.Rows)
                {
                    if (product.Cells[0].Value.ToString().Equals(buy.Cells[0].Value.ToString()))
                    {
                        dgvService.Rows.RemoveAt(product.Index);
                    }
                }
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
