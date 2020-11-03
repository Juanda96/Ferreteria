using BussinessObject;
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

namespace Ferreteria.Administrations
{
    public partial class ProductUpdate : Form
    {
        ProductBO pbo = new ProductBO();
        LinkedList<Product> linkProducts;
        int product;
        public ProductUpdate(LinkedList<Product> dataProduct, int selection)
        {
            InitializeComponent();
            this.product = selection;
            this.linkProducts = dataProduct;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtCategory.Text) || string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Error: información incompleta");
            }
            else
            {
                pbo.updateProduct(txtName.Text, txtCategory.Text, txtDescription.Text, int.Parse(txtPrice.Text),product);
                MessageBox.Show("¡Actualizado con exito!");
            }
        }

        private void ProductUpdate_Load(object sender, EventArgs e)
        {
            foreach  (Product product in linkProducts)
            {
                if (product.id == this.product)
                {
                    txtName.Text = product.name;
                    txtCategory.Text = product.category;
                    txtDescription.Text = product.description;
                    txtPrice.Text = ""+product.price;
                }
            }
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
