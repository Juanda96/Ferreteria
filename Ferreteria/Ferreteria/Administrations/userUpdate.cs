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
    public partial class userUpdate : Form
    {
        User userOld;
        LinkedList<User> dataUsers;
        int user;
        UserBO ubo = new UserBO();
        public userUpdate(LinkedList<User> dataUsers, int selection)
        {
            InitializeComponent();
            this.dataUsers = dataUsers;
            this.user = selection;
        }

        private void userUpdate_Load(object sender, EventArgs e)
        {
            foreach (User u in dataUsers)
            {
                if (u.dni == user)
                {
                    txtDNI.Text = "" + (u.dni);
                    txtName.Text = u.name;
                    txtLast.Text = u.last;
                    //Cajero Administrador Transportista Vendedor Constructor
                    if (u.type.Equals("Cajero"))
                    {
                        cmbType.SelectedIndex = 0;
                    }
                    else if (u.type.Equals("Administrador"))
                    {
                        cmbType.SelectedIndex = 1;
                    }
                    else if (u.type.Equals("Transportista"))
                    {
                        cmbType.SelectedIndex = 2;
                    }
                    else if (u.type.Equals("Vendedor"))
                    {
                        cmbType.SelectedIndex = 3;
                    }
                    else 
                    {
                        cmbType.SelectedIndex = 3;
                    }
                    lblCodigo.Text = u.code;
                    txtPass.Text = u.password;
                }
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
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
                ubo.updateUser(int.Parse(txtDNI.Text), txtName.Text, txtLast.Text, cmbType.Text, lblCodigo.Text, txtPass.Text,user);
                MessageBox.Show("¡Actualizado con exito!");
            }
        }
    }
}
