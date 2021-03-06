﻿using BussinessObject;
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
    public partial class userRead : Form
    {
        UserBO ubo = new UserBO();
        public userRead()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40,40,40);
            dgvUsers.DataSource = ubo.getUsersDataTable();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            userAdd ud = new userAdd();
            ud.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count < 0 && dgvUsers.CurrentCell.RowIndex != 1)
            {
                MessageBox.Show("Seleccione una cedula");
            }
            else
            {
                userUpdate uu = new userUpdate(ubo.getLinkedUser(), Convert.ToInt32(dgvUsers.CurrentRow.Cells[1].Value));
                uu.Show();
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count < 0 && dgvUsers.CurrentCell.RowIndex != 1)
            {
                MessageBox.Show("Seleccione una cedula");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Desea eliminar a '"+ dgvUsers.CurrentRow.Cells[2].Value , "Eliminar usuario", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ubo.deleteUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells[1].Value));
                }
            }
        }
    }
}
