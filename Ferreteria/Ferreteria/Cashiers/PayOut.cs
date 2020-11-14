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
    public partial class PayOut : Form
    {
        UserBO ubo = new UserBO();
        SaleBO sbo = new SaleBO();
        public PayOut()
        {
            InitializeComponent();
        }

        private void PayOut_Load(object sender, EventArgs e)
        {

            foreach (var compra in sbo.selectSaleClientLink())
            {
                foreach (var user in ubo.getLinkedClients())
                {
                    if (compra == user.dni)
                    {
                        cmbUserBuy.Items.Add(user.name +" - "+ user.dni);
                    }
                }
            }
        }

        private void cmbUserBuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(int.Parse(cmbUserBuy.Text.Split('-')[1].Trim()));
            dgvPayment.DataSource = sbo.selectSaleEspecificClientBuys(int.Parse(cmbUserBuy.Text.Split('-')[1].Trim()));
            double total = 0;
            foreach (DataGridViewRow row in dgvPayment.Rows)
            {
                int each = int.Parse(row.Cells[2].Value.ToString());
                int price = int.Parse(row.Cells[4].Value.ToString());
                int totalRow = each * price;
                total = double.Parse(lblTotal.Text) + totalRow;
                lblTotal.Text = Convert.ToString(total);
            }
            double imp = total * 0.13;
            lblTotalImp.Text = Convert.ToString(total + imp);
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPayment.Rows)
            {
                sbo.changeStatus(Convert.ToInt32(row.Cells[0].Value.ToString()));
            }
            MessageBox.Show("Pago ejecutado con exito"+ Environment.NewLine+"Cancelado: "+lblTotalImp.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {


        }
    }
}
