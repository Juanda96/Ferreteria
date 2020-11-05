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

namespace Ferreteria.Sales
{
    public partial class ClientRead : Form
    {
        UserBO ubo = new UserBO();
        public ClientRead()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ClientRead_Load(object sender, EventArgs e)
        {
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvUsers.DataSource = ubo.getClientsDataTable();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            ClientAdd ca = new ClientAdd();
            ca.Show();
        }
    }
}
