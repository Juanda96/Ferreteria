using BussinessObject;
using Ferreteria.Administrations;
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
    public partial class serviceRead : Form
    {
        ServiceBO sbo = new ServiceBO();

        public serviceRead()
        {
            InitializeComponent();
        }

        private void readService_Load(object sender, EventArgs e)
        {
            dgvService.EnableHeadersVisualStyles = false;
            dgvService.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvService.DataSource = sbo.getServDataTable();
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
            serviceAdd sd = new serviceAdd();
            sd.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvService.SelectedRows.Count < 0 && dgvService.CurrentCell.RowIndex != 1)
            {
                MessageBox.Show("Seleccione un id");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Desea eliminar  '" + dgvService.CurrentRow.Cells[1].Value, "Eliminar servicio", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sbo.deleteServ(Convert.ToInt32(dgvService.CurrentRow.Cells[0].Value));
                }
            }
        }
    }
}

