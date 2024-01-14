using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recuperar = new RecuperarClave();
            recuperar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var openPrincipal = new Menu();
            openPrincipal.ShowDialog();
            this.Hide(); 
        }
    }
}
