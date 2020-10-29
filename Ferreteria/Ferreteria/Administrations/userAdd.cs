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
    public partial class userAdd : Form
    {
        UserBO ubo = new UserBO();
        public userAdd()
        {
            InitializeComponent();
        }

        private void userAdd_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(txtDNI.Text.Equals("")))
            {
                string codeDNI = txtDNI.Text;
                string codeType = cmbType.Text;
                lblCodigo.Text = codeType.Substring(0, 3).ToUpper() + codeDNI.Substring(codeDNI.Length - 3);
            }
            else 
            {
                MessageBox.Show("Numero de cedula invalido");
            }
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtLast.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Error: información incompleta");
            }
            else
            {
                ubo.createUser(int.Parse(txtDNI.Text),txtName.Text,txtLast.Text,cmbType.Text,lblCodigo.Text,txtPass.Text);
            }
        }
    }
}
