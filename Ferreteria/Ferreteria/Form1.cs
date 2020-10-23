using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelButton.Visible = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
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

        private void btnWelcome_MouseMove(object sender, MouseEventArgs e)
        {
            panelButton.Height = btnWelcome.Height;
            panelButton.Top = btnWelcome.Top - 55;
            panelButton.Visible = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_MouseMove(object sender, MouseEventArgs e)
        {
            panelButton.Height = btnLogin.Height;
            panelButton.Top = btnLogin.Top - 55;
            panelButton.Visible = true;
        }

        private void btnInfo_MouseMove(object sender, MouseEventArgs e)
        {
            panelButton.Height = btnInfo.Height;
            panelButton.Top = btnInfo.Top - 55;
            panelButton.Visible = true;
        }
    }
}
