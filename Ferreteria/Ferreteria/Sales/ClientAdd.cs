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
    public partial class ClientAdd : Form
    {
        UserBO ubo = new UserBO();
        public ClientAdd()
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
            if (string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtLast.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Error: información incompleta");
            }
            else
            {
                ubo.createUser(int.Parse(txtDNI.Text), txtName.Text, txtLast.Text, "Cliente", lblCodigo.Text, txtPass.Text);
                MessageBox.Show("¡Agregado con exito!");
            }
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(txtDNI.Text.Equals("")))
                {
                    string codeDNI = txtDNI.Text;
                    string codeType = "Cliente";
                    lblCodigo.Text = codeType.Substring(0, 3).ToUpper() + codeDNI.Substring(codeDNI.Length - 3);
                }
                else
                {
                    MessageBox.Show("Numero de cedula invalido");
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtDNI_RegionChanged(object sender, EventArgs e)
        {
            
        }



        private void ClientAdd_Load(object sender, EventArgs e)
        {

        }

        private void txtDNI_CursorChanged(object sender, EventArgs e)
        {
            
        }
    }
}
