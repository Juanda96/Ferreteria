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

namespace Ferreteria.Administration
{
    public partial class TransportAdd : Form
    {
        UserBO ubo = new UserBO();
        TransportBO tbo = new TransportBO();
        LinkedList<User> transportist = new LinkedList<User>();
        public TransportAdd()
        {
            InitializeComponent();
        }

        private void TransportAdd_Load(object sender, EventArgs e)
        {
            foreach (User user in ubo.getLinkedUser())
            {
                if (user.type.Equals("Transportista"))
                {
                    transportist.AddLast(user);
                    cmbTransportist.Items.Add(user.dni + " - " +user.name +" "+user.last);
                }
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

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicense.Text)||cmbTransportist.SelectedIndex < 0)
            {
                MessageBox.Show("Datos incompletos");
            }
            else
            {
                try
                {
                    tbo.createTransport(txtLicense.Text, transportist.ElementAt(cmbTransportist.SelectedIndex).dni);
                    MessageBox.Show("¡Agregado con exito!");
                }
                catch (Exception x)
                {

                    MessageBox.Show(x.Message + Environment.NewLine + x.StackTrace);
                }
                
                
            }
        }
    }
}
