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

namespace Ferreteria.Cashiers
{
    public partial class LobbyCashier : Form
    {
        User cashier;
        public LobbyCashier(User cashier)
        {
            InitializeComponent();
            this.cashier = cashier;
        }

        private void LobbyCashier_Load(object sender, EventArgs e)
        {
            lblAdmin.Text = "Bienvenido: " + cashier.name + " " + cashier.last;
        }
    }
}
