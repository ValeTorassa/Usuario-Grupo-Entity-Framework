

using Controlador;
using Entidades;

namespace Vista
{
    public partial class Grupos : Form
    {
        public Grupos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GrupoAM formGruposAM = new GrupoAM();
            formGruposAM.ShowDialog();
            ActualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.Rows.Count > 0)
            {
                var grupo = (Grupo)dgvGrupos.CurrentRow.DataBoundItem;
                GrupoAM formGruposAM = new GrupoAM(grupo);
                formGruposAM.ShowDialog();
                ActualizarGrilla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.Rows.Count > 0)
            {
                var grupo = (Grupo)dgvGrupos.CurrentRow.DataBoundItem;

                var mensaje = ControladoraGrupos.Instancia.Eliminar(grupo);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrilla();
            }
        }

        private void ActualizarGrilla()
        {
            dgvGrupos.DataSource = null;
            dgvGrupos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrupos.DataSource = ControladoraGrupos.Instancia.Listar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grupos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}