using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessObject;
using Entity;

namespace Ferreteria.Administration
{
    public partial class serviceUpdate : Form
    {
        Service servOld;
        LinkedList<Service> dataService;
        int serv;        
        ServiceBO sbo = new ServiceBO();

        public serviceUpdate(LinkedList<Service> dataService, int selection)
        {
            InitializeComponent();
            this.dataService = dataService;
            this.serv = selection;
        }


        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
        
        private void btnuUpdate_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtCate.Text) || string.IsNullOrEmpty(txtDescrip.Text) || string.IsNullOrEmpty(txtPrice.Text))

            {
                MessageBox.Show("Error: información incompleta");
            }
            else
            {
                sbo.updateServ(int.Parse(txtId.Text), txtName.Text, txtCate.Text, txtDescrip.Text, int.Parse(txtPrice.Text),  serv);
                MessageBox.Show("¡Actualizado con exito!");
            }
        }

    }
    }

