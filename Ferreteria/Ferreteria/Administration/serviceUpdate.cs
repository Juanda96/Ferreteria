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

        private void serviceUpdate_Load(object sender, EventArgs e)
        {
            foreach (Service s in dataService)
            {
                if (s.id == serv)
                {
                    txtId.Text = "" + (s.id);
                    txtName.Text = s.name;
                    txtCate.Text = s.cate;
                    txtDescrip.Text = s.descri;
                    txtPrice.Text = "" + (s.price);
                }

            }
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


            if ( string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtCate.Text) ||
                string.IsNullOrEmpty(txtDescrip.Text) || string.IsNullOrEmpty(txtPrice.Text))

            {
                MessageBox.Show("Error: información incompleta");
            }
            else
            {
                sbo.updateServ( txtName.Text, txtCate.Text, txtDescrip.Text, int.Parse(txtPrice.Text), serv);
                MessageBox.Show("¡Actualizado con exito!");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescrip_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

