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

namespace Ferreteria
{
    public partial class LobbyAdministrador : Form
    {
        User admin;
        public LobbyAdministrador(User admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void LobbyAdministrador_Load(object sender, EventArgs e)
        {
            timerWelcome.Start();
            lblAdmin.Text = "Bienvenido: " + admin.name;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnWelcome_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            lblDate.Visible = true;
            lblTimer.Visible = true;
            lblAdmin.Visible = true;
        }

        private void btnWelcome_MouseMove(object sender, MouseEventArgs e)
        {
            panelButton.Height = btnWelcome.Height;
            panelButton.Top = btnWelcome.Top;
            panelButton.Visible = true;
        }

        private void btnUser_MouseMove(object sender, MouseEventArgs e)
        {
            panelButton.Height = btnUser.Height;
            panelButton.Top = btnUser.Top;
            panelButton.Visible = true;
        }

        private void btnProduct_MouseMove(object sender, MouseEventArgs e)
        {
            panelButton.Height = btnProduct.Height;
            panelButton.Top = btnProduct.Top;
            panelButton.Visible = true;
        }

        private void btnService_MouseMove(object sender, MouseEventArgs e)
        {
            panelButton.Height = btnService.Height;
            panelButton.Top = btnService.Top;
            panelButton.Visible = true;
        }

        private void btnTransport_MouseMove(object sender, MouseEventArgs e)
        {
            panelButton.Height = btnTransport.Height;
            panelButton.Top = btnTransport.Top;
            panelButton.Visible = true;
        }

        private void btnClose_MouseMove(object sender, MouseEventArgs e)
        {
            panelButton.Height = btnClose.Height;
            panelButton.Top = btnClose.Top;
            panelButton.Visible = true;
        }

        private void panelButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerWelcome_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            lblDate.Visible = false;
            lblTimer.Visible = false;
            lblAdmin.Visible = false;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            lblAdmin.Visible = false;
            lblDate.Visible = false;
            lblTimer.Visible = false;
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            lblAdmin.Visible = false;
            lblDate.Visible = false;
            lblTimer.Visible = false;
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            lblAdmin.Visible = false;
            lblDate.Visible = false;
            lblTimer.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            lblAdmin.Visible = false;
            lblDate.Visible = false;
            lblTimer.Visible = false;
        }
    }
}
