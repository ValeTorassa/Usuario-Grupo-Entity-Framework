namespace Vista
{
    partial class GrupoAM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceptar = new Button();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            cbHabilitado = new CheckBox();
            lblNombre = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            lblAgregarModificar = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(12, 191);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(79, 27);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(91, 86);
            txtDescripcion.MaxLength = 200;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(310, 69);
            txtDescripcion.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(72, 45);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(144, 25);
            txtNombre.TabIndex = 2;
            // 
            // cbHabilitado
            // 
            cbHabilitado.AutoSize = true;
            cbHabilitado.CheckAlign = ContentAlignment.MiddleRight;
            cbHabilitado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbHabilitado.Location = new Point(311, 47);
            cbHabilitado.Name = "cbHabilitado";
            cbHabilitado.Size = new Size(87, 21);
            cbHabilitado.TabIndex = 4;
            cbHabilitado.Text = "Habilitado";
            cbHabilitado.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(6, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(60, 17);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 87);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 7;
            label1.Text = "Descripcion:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(328, 191);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 27);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblAgregarModificar
            // 
            lblAgregarModificar.AutoSize = true;
            lblAgregarModificar.Location = new Point(167, 9);
            lblAgregarModificar.Name = "lblAgregarModificar";
            lblAgregarModificar.Size = new Size(113, 15);
            lblAgregarModificar.TabIndex = 9;
            lblAgregarModificar.Text = "Agregar o Modificar";
            // 
            // GrupoAM
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 228);
            ControlBox = false;
            Controls.Add(lblAgregarModificar);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(btnAceptar);
            Controls.Add(cbHabilitado);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "GrupoAM";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += GrupoAM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private CheckBox cbHabilitado;
        private Label lblNombre;
        private Label label1;
        private Button btnCancelar;
        private Label lblAgregarModificar;
    }
}