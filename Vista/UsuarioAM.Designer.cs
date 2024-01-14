namespace Vista
{
    partial class UsuarioAM
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
            txtEmail = new TextBox();
            chkHabilitado = new CheckBox();
            lblNombre = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            txtClave = new TextBox();
            cmbDisponibles = new ComboBox();
            group = new GroupBox();
            btnLimpiar = new Button();
            lbAsignados = new ListBox();
            btnAgregar = new Button();
            lblAgregarModificar = new Label();
            group.SuspendLayout();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(12, 206);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(79, 27);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(54, 43);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(353, 25);
            txtEmail.TabIndex = 2;
            // 
            // chkHabilitado
            // 
            chkHabilitado.AutoSize = true;
            chkHabilitado.CheckAlign = ContentAlignment.MiddleRight;
            chkHabilitado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chkHabilitado.Location = new Point(320, 110);
            chkHabilitado.Name = "chkHabilitado";
            chkHabilitado.Size = new Size(87, 21);
            chkHabilitado.TabIndex = 4;
            chkHabilitado.Text = "Habilitado";
            chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(6, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(42, 17);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 111);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 7;
            label1.Text = "Clave:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(328, 206);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 27);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(54, 103);
            txtClave.MaxLength = 50;
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(199, 25);
            txtClave.TabIndex = 9;
            // 
            // cmbDisponibles
            // 
            cmbDisponibles.FormattingEnabled = true;
            cmbDisponibles.Location = new Point(6, 36);
            cmbDisponibles.Name = "cmbDisponibles";
            cmbDisponibles.Size = new Size(198, 28);
            cmbDisponibles.TabIndex = 10;
            // 
            // group
            // 
            group.Controls.Add(btnLimpiar);
            group.Controls.Add(lbAsignados);
            group.Controls.Add(btnAgregar);
            group.Controls.Add(cmbDisponibles);
            group.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            group.Location = new Point(430, 12);
            group.Name = "group";
            group.Size = new Size(339, 221);
            group.TabIndex = 11;
            group.TabStop = false;
            group.Text = "Setear grupos del usuario";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(223, 115);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(79, 27);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lbAsignados
            // 
            lbAsignados.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbAsignados.FormattingEnabled = true;
            lbAsignados.ItemHeight = 15;
            lbAsignados.Location = new Point(6, 115);
            lbAsignados.Name = "lbAsignados";
            lbAsignados.Size = new Size(198, 94);
            lbAsignados.TabIndex = 12;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(223, 36);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(79, 27);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblAgregarModificar
            // 
            lblAgregarModificar.AutoSize = true;
            lblAgregarModificar.Location = new Point(248, 15);
            lblAgregarModificar.Name = "lblAgregarModificar";
            lblAgregarModificar.Size = new Size(113, 15);
            lblAgregarModificar.TabIndex = 12;
            lblAgregarModificar.Text = "Agregar o Modificar";
            // 
            // UsuarioAM
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 227);
            ControlBox = false;
            Controls.Add(lblAgregarModificar);
            Controls.Add(group);
            Controls.Add(txtClave);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            Controls.Add(txtEmail);
            Controls.Add(btnAceptar);
            Controls.Add(chkHabilitado);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "UsuarioAM";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormUsuario_Load;
            group.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtEmail;
        private CheckBox chkHabilitado;
        private Label lblNombre;
        private Label label1;
        private Button btnCancelar;
        private TextBox txtClave;
        private ComboBox cmbDisponibles;
        private GroupBox group;
        private ListBox lbAsignados;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Label lblAgregarModificar;
    }
}