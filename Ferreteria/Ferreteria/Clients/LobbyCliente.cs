using Entity;
using Ferreteria.Clients;
using Ferreteria.Administrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.Clients
{
    public partial class LobbyCliente : Form
    {
        User cliente;
        public LobbyCliente(User cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }


        private void LobbyCliente_Load(object sender, EventArgs e)
        {
            timerWelcome.Start();
            lblCliente.Text = "Bienvenido: " + cliente.name;
        }

        private void timerWelcome_Tick(object sender, EventArgs e)
        { 
            lblTimer.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            lblDate.Visible = true;
            lblTimer.Visible = true;
            lblCliente.Visible = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            lblCliente.Visible = true;
            SaleProduct sa = new SaleProduct();
            sa.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            lblCliente.Visible = false;
            lblDate.Visible = false;
            lblTimer.Visible = false;
        }

        private void btnWelcome_MouseMove(object sender, MouseEventArgs e)
        {
            panelButton.Height = btnWelcome.Height;
            panelButton.Top = btnWelcome.Top;
            panelButton.Visible = true;
        }

        private void btnProduct_MouseMove(object sender, MouseEventArgs e)
        {
            panelButton.Height = btnWelcome.Height;
            panelButton.Top = btnWelcome.Top;
            panelButton.Visible = true;
        }

        private void btnService_MouseMove(object sender, MouseEventArgs e)
        {
            panelButton.Height = btnWelcome.Height;
            panelButton.Top = btnWelcome.Top;
            panelButton.Visible = true;
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            SaleService ad = new SaleService();
            ad.Show();
        }
    }
}
