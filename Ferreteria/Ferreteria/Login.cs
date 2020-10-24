﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            panelButton.Visible = false;
            TimerWelcome.Start();
            lblUsuario.Visible = false;
            lblContraseña.Visible = false;
            lblInfo.Visible = false;
            
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
            lblTimer.Visible = false;
            lblDate.Visible = false;
            lblUsuario.Visible = true;
            lblContraseña.Visible = true;
            lblInfo.Visible = false;
            lblUsuario.Text = "Usuario";
            lblContraseña.Text = "Contraseña";
            txtUser.Visible = true;
            txtPassword.Visible = true;
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

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            lblTimer.Visible = true;
            lblDate.Visible = true;
            lblUsuario.Visible = false;
            lblContraseña.Visible = false;
            lblInfo.Visible = false;
            txtUser.Visible = false;
            txtPassword.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
            
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            lblTimer.Visible = false;
            lblDate.Visible = false;
            lblUsuario.Visible = false;
            lblContraseña.Visible = false;
            lblInfo.Text = "         Proyecto #2" + Environment.NewLine + "    Programación III" + Environment.NewLine + Environment.NewLine + " Tiffany - Juan Daniel";
            lblInfo.Visible = true;
            txtUser.Visible = false;
            txtPassword.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (initSesion(e) == true)
                {
                    MessageBox.Show("Sesion iniciada");
                }
                else
                {
                    MessageBox.Show("Datos incompletos");
                }
            }
        }

        private bool initSesion(KeyEventArgs e) 
        {
            bool init = false;
                if (txtUser.Text.Equals("") || txtPassword.Text.Equals(""))
                {
                    init = false;
                }
                else
                { 
                    init = true;
                }
            return init;
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (initSesion(e) == true)
                {
                    MessageBox.Show("Sesion iniciada");
                }
                else
                {
                    MessageBox.Show("Datos incompletos");
                }
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}