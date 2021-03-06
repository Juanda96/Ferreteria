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
    public partial class ProductRead : Form
    {
        ProductBO pbo = new ProductBO();
        public ProductRead()
        {
            InitializeComponent();
        }

        private void productRead_Load(object sender, EventArgs e)
        {
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvProduct.DataSource = pbo.getProductDataTable();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductAdd pa = new ProductAdd();
            pa.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow.Index > -1)
            {
                ProductUpdate pu = new ProductUpdate(pbo.getLinkedProduct(), Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value));
                pu.Show();
            }
            
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count < 0 && dgvProduct.CurrentCell.RowIndex != 1)
            {
                MessageBox.Show("Seleccione una producto");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Desea eliminar '" + dgvProduct.CurrentRow.Cells[1].Value+"'", "Eliminar Producto", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    pbo.deleteProduct(Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value));
                }
            }
        }
    }
}
