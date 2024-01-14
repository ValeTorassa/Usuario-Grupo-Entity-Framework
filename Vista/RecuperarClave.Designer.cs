namespace Vista
{
    partial class RecuperarClave
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtCodigo = new TextBox();
            label1 = new Label();
            lblNombre = new Label();
            txtEmail = new TextBox();
            btnEnviarCodigo = new Button();
            label2 = new Label();
            txtClave1 = new TextBox();
            txtClave2 = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtClave2);
            groupBox1.Controls.Add(txtClave1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnEnviarCodigo);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnAceptar);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 294);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recuperar clave";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(411, 255);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 27);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(6, 255);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(79, 27);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(66, 118);
            txtCodigo.MaxLength = 50;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(102, 25);
            txtCodigo.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 121);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 9;
            label1.Text = "Codigo:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(6, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(190, 17);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Colocar email de recuperacion:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(6, 70);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(370, 25);
            txtEmail.TabIndex = 7;
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviarCodigo.Location = new Point(382, 68);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new Size(98, 27);
            btnEnviarCodigo.TabIndex = 11;
            btnEnviarCodigo.Text = "Enviar codigo";
            btnEnviarCodigo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 169);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 12;
            label2.Text = "Clave:";
            // 
            // txtClave1
            // 
            txtClave1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave1.Location = new Point(54, 166);
            txtClave1.MaxLength = 50;
            txtClave1.Name = "txtClave1";
            txtClave1.Size = new Size(248, 25);
            txtClave1.TabIndex = 13;
            // 
            // txtClave2
            // 
            txtClave2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave2.Location = new Point(114, 209);
            txtClave2.MaxLength = 50;
            txtClave2.Name = "txtClave2";
            txtClave2.Size = new Size(248, 25);
            txtClave2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 212);
            label3.Name = "label3";
            label3.Size = new Size(102, 17);
            label3.TabIndex = 15;
            label3.Text = "Confirmar clave:";
            // 
            // FormRecuperarCLave
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 310);
            ControlBox = false;
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormRecuperarCLave";
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
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtCodigo;
        private Label label1;
        private Button btnEnviarCodigo;
        private Label label3;
        private TextBox txtClave2;
        private TextBox txtClave1;
        private Label label2;
    }
}