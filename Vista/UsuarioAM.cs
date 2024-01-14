using Controlador;
using Controlador.Controlador;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class UsuarioAM : Form
    {
        private Usuario usuario;
        private bool modificar = false;

        public UsuarioAM()
        {
            InitializeComponent();
        }

        public UsuarioAM(Usuario usuarioModificar)
        {
            InitializeComponent();
            usuario = usuarioModificar;
            modificar = true;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(this.txtEmail.Text))
            {
                MessageBox.Show("Debe ingresar el email.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string email = txtEmail.Text;
            if (!EmailValido(email))
            {
                MessageBox.Show("Debe ingresar un email válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(this.txtClave.Text))
            {
                MessageBox.Show("Debe ingresar una clave.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool EmailValido(string email)
        {
            string patron = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)*(\.[a-zA-Z]{2,7})$";

            return Regex.IsMatch(email, patron);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (modificar)
                {

                    usuario.Email = txtEmail.Text;
                    usuario.Grupos = ControladoraUsuarios.Instancia.ObtenerGruposPorNombre(
                                            lbAsignados.Items.Cast<Grupo>().ToList());

                    var mensaje = ControladoraUsuarios.Instancia.Modificar(usuario);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var nuevoUsuario = new Usuario()
                    {
                        Email = txtEmail.Text,
                        Grupos = ControladoraUsuarios.Instancia.ObtenerGruposPorNombre(
                                                lbAsignados.Items.Cast<Grupo>().ToList())
                    };

                    var mensaje = ControladoraUsuarios.Instancia.Agregar(nuevoUsuario);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            LlenarCombo();
            if (modificar)
            {
                lblAgregarModificar.Text = "Modificar Usuario";
                txtEmail.Enabled = false;
                txtEmail.Text = usuario.Email;
                lbAsignados.Items.AddRange(usuario.Grupos.ToArray());
            }
            else
            {
                lblAgregarModificar.Text = "Agregar Usuario";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbDisponibles.SelectedItem != null)
            {
                var grupoSeleccionado = (Grupo)cmbDisponibles.SelectedItem;
                if (grupoSeleccionado.EstaHabilitado)
                {
                    lbAsignados.Items.Add(grupoSeleccionado);
                }
                else
                {
                    MessageBox.Show("La categoría seleccionada no está habilitada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbAsignados.Items.Clear();
        }

        private void LlenarCombo()
        {
            cmbDisponibles.DataSource = null;
            cmbDisponibles.DataSource = ControladoraUsuarios.Instancia.ListarGrupos();
        }

    }
}