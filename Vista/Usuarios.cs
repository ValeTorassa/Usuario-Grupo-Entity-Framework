using Controlador.Controlador;
using Entidades;
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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void ActualizarGrilla()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.DataSource = ControladoraUsuarios.Instancia.ListarUsuarios();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            UsuarioAM formUsuarios = new UsuarioAM();
            formUsuarios.ShowDialog();
            ActualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                var usuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                var mensaje = ControladoraUsuarios.Instancia.Eliminar(usuario);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrilla();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                var usuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                UsuarioAM formUsuarios = new UsuarioAM(usuario);
                formUsuarios.ShowDialog();
                ActualizarGrilla();
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            CargarGruposDeUsuario();
        }

        private void CargarGruposDeUsuario()
        {
            if (dgvUsuarios.Rows.Count > 0 && dgvUsuarios.SelectedRows.Count > 0)
            {
                dgvGrupos.DataSource = null;
                dgvGrupos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var usuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                dgvGrupos.DataSource = usuario.Grupos;
            }
        }

        private void Usuarios_Load_1(object sender, EventArgs e)
        {
            ActualizarGrilla();
            if (dgvUsuarios.Rows.Count > 0)
            {
                dgvGrupos.DataSource = null;
                dgvGrupos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var usuario = dgvUsuarios.Rows[0].DataBoundItem as Usuario;
                dgvGrupos.DataSource = usuario.Grupos;
            }

        }
    }
}
