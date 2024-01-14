namespace Vista
{
    partial class Login
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
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            btnAceptar = new Button();
            txtClave = new TextBox();
            label1 = new Label();
            linkRecuperar = new LinkLabel();
            lblNombre = new Label();
            txtEmail = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnAceptar);
            groupBox1.Controls.Add(txtClave);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(linkRecuperar);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 246);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(365, 206);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(79, 27);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(6, 206);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(79, 27);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(54, 113);
            txtClave.MaxLength = 50;
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(199, 25);
            txtClave.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 121);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 9;
            label1.Text = "Clave:";
            // 
            // linkRecuperar
            // 
            linkRecuperar.AutoSize = true;
            linkRecuperar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkRecuperar.Location = new Point(91, 156);
            linkRecuperar.Name = "linkRecuperar";
            linkRecuperar.Size = new Size(110, 15);
            linkRecuperar.TabIndex = 1;
            linkRecuperar.TabStop = true;
            linkRecuperar.Text = "¿Olvidaste tu clave?";
            linkRecuperar.LinkClicked += linkRecuperar_LinkClicked;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(6, 63);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(42, 17);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(54, 55);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(370, 25);
            txtEmail.TabIndex = 7;
            // 
            // FormLogin
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 262);
            ControlBox = false;
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormLogin";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblNombre;
        private TextBox txtEmail;
        private LinkLabel linkRecuperar;
        private Button btnSalir;
        private Button btnAceptar;
        private TextBox txtClave;
        private Label label1;
    }
}