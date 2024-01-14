using Controlador;
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
    public partial class GrupoAM : Form
    {
        private bool modifica = false;
        private Grupo grupo;

        public GrupoAM()
        {
            InitializeComponent();
        }

        public GrupoAM(Grupo grupoModificar)
        {
            InitializeComponent();
            grupo = grupoModificar;
            modifica = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (modifica)
                {
                    grupo.Nombre = txtNombre.Text;
                    grupo.Descripcion = txtDescripcion.Text;
                    grupo.EstaHabilitado = cbHabilitado.Checked;

                    var mensaje = ControladoraGrupos.Instancia.Modificar(grupo);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (ControladoraGrupos.Instancia.NombreExiste(txtNombre.Text))
                {
                    var nuevoGrupo = new Grupo()
                    {
                        Nombre = txtNombre.Text,
                        Descripcion = txtDescripcion.Text,
                        EstaHabilitado = cbHabilitado.Checked
                    };

                    var mensaje = ControladoraGrupos.Instancia.Agregar(nuevoGrupo);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El nombre de grupo ingresado ya existe");
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void GrupoAM_Load(object sender, EventArgs e)
        {
            if (modifica)
            {
                lblAgregarModificar.Text = "Modificar Grupo";
                txtNombre.Enabled = false;
                txtNombre.Text = grupo.Nombre;
                txtDescripcion.Text = grupo.Descripcion;
                cbHabilitado.Checked = grupo.EstaHabilitado;
            }
            else
            {
                lblAgregarModificar.Text = "Agregar Grupo";
            }
        }
    }
}