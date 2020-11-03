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
    public partial class ProductAdd : Form
    {
        ProductBO pbo = new ProductBO();
        public ProductAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtCategory.Text) || string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Error: información incompleta");
            }
            else
            {
                pbo.createProduct(txtName.Text, txtCategory.Text, txtDescription.Text, int.Parse(txtPrice.Text));
                MessageBox.Show("¡Agregado con exito!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
