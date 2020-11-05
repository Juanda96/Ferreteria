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
    public partial class TransportUpdate : Form
    {
        UserBO ubo = new UserBO();
        TransportBO tbo = new TransportBO();
        LinkedList<User> transportist = new LinkedList<User>();
        string license;
        int user;
        int choice = -1;
        int idTransport;
        public TransportUpdate(string licensePlate, int idUserTransportist,int idTransport)
        {
            InitializeComponent();
            license = licensePlate;
            user = idUserTransportist;
            this.idTransport = idTransport;
        }

        private void TransportUpdate_Load(object sender, EventArgs e)
        {
            foreach (User user in ubo.getLinkedUser())
            {
                if (user.type.Equals("Transportista"))
                {
                    transportist.AddLast(user);
                    cmbTransportist.Items.Add(user.dni + " - " + user.name + " " + user.last);
                }
            }

            foreach (var item in transportist)
            {
                choice++;
                if (item.dni == user)
                {
                    cmbTransportist.SelectedIndex = choice;
                }
            }
            txtLicense.Text = license;
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
            try
            {
                tbo.updateTransport(txtLicense.Text, transportist.ElementAt(cmbTransportist.SelectedIndex).dni,idTransport);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message + Environment.NewLine + x.StackTrace);
            }
            
        }
    }
}
