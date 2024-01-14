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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /*
                private void volverToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    this.Hide();
                    var openLogin = new Login();
                    openLogin.ShowDialog();
                }*/


        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var openUsuarios = new Usuarios();
            openUsuarios.MdiParent = this;
            openUsuarios.Show();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openGrupos = new Grupos();
            openGrupos.MdiParent = this;
            openGrupos.Show();
        }
    }
}
