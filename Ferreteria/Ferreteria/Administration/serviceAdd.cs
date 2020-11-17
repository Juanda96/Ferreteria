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
        public serviceAdd(int id, string name, string cate, string descri, int precio)
        {
            InitializeComponent();
            txtId.Text = id.ToString();
            txtName.Text = name.ToString();
            txtCateg.Text = cate.ToString();
            txtDescrip.Text = descri.ToString();
            txtPrice.Text = precio.ToString();
           
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
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtCateg.Text) || string.IsNullOrEmpty(txtDescrip.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Error: información incompleta");
            }
            else
            {
                sbo.createServ(int.Parse(txtId.Text), txtName.Text, txtCateg.Text, txtDescrip.Text, int.Parse(txtPrice.Text));
                MessageBox.Show("¡Agregado con exito!");
            }
        }
    

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void serviceAdd_Load(object sender, EventArgs e)
        {

        }
    }
}

