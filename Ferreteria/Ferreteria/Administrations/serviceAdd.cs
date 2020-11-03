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

namespace Ferreteria.Administrations
{
    public partial class serviceAdd : Form
    {
        ServiceBO sbo = new ServiceBO();

        public serviceAdd()
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

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtCateg.Text) || string.IsNullOrEmpty(txtDescrip.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Error: información incompleta");
            }
            else
            {
                sbo.createServ( txtName.Text, txtCateg.Text, txtDescrip.Text, int.Parse(txtPrice.Text));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

