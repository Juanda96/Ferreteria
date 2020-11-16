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

namespace Ferreteria.Transportist
{
    public partial class LobbyTransportist : Form
    {
        public LobbyTransportist(User admin)
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWelcome_MouseMove(object sender, MouseEventArgs e)
        {
            panelButton.Height = btnWelcome.Height;
            panelButton.Top = btnWelcome.Top;
            panelButton.Visible = true;
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            panelButton.Height = btnClose.Height;
            panelButton.Top = btnClose.Top;
            panelButton.Visible = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            PayOutProducts pop = new PayOutProducts();
            pop.Show();
        }

        private void LobbyTransportist_Load(object sender, EventArgs e)
        {

        }

        private void btnService_Click(object sender, EventArgs e)
        {
            Status st = new Status();
            st.Show();
        }
    }
}
