using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BussinessObject;

namespace Ferreteria.Clients
{
    public partial class SaleProduct : Form
    {
        ProductBO pbo = new ProductBO();
        UserBO ubo = new UserBO();
        SaleBO sbo = new SaleBO();
        LinkedList<User> clients = new LinkedList<User>();
        
        public SaleProduct()
        {
            InitializeComponent();

        }

        private void SaleProduct_Load(object sender, EventArgs e)
        {
           
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvProduct.DataSource = pbo.getProductDataTableSales();
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
            if (dgvProduct.SelectedRows.Count > -1 && !(string.IsNullOrEmpty(txtCant.Text)))
            {
                foreach (DataGridViewRow row in dgvProduct.Rows)
                {
                    if (row.Selected)
                    {
                        if (Convert.ToInt32(row.Cells[3].Value) > Convert.ToInt32(txtCant.Text))
                        {
                            int newRow = dgvBuy.Rows.Add();
                            dgvBuy.Rows[newRow].Cells[0].Value = row.Cells[0].Value.ToString();
                            dgvBuy.Rows[newRow].Cells[1].Value = row.Cells[1].Value.ToString();
                            dgvBuy.Rows[newRow].Cells[2].Value = row.Cells[2].Value.ToString();
                            dgvBuy.Rows[newRow].Cells[3].Value = txtCant.Text;
                            int total = int.Parse(lblTotal.Text);
                            int quantity = int.Parse(txtCant.Text);
                            int priceProduct = int.Parse(row.Cells[2].Value.ToString());
                            lblTotal.Text = (total + (quantity * priceProduct)).ToString();
                            dgvProduct.Rows.RemoveAt(this.dgvProduct.SelectedRows[0].Index);
                        }
                        else
                        {
                            MessageBox.Show("La cantidad solicitada es mayor al inventario");
                        }
                    }
                }
            }
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if (dgvBuy.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvBuy.Rows)
                {
                    sbo.createSale(lblFactura.Text, Convert.ToInt32(cmbClients.SelectedItem.ToString().Split('-')[0].Trim()), Convert.ToInt32(row.Cells[0].Value), Convert.ToInt32(row.Cells[3].Value), "Product", 0, 0);
                    MessageBox.Show("¡Agregado con exito!");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }

}

