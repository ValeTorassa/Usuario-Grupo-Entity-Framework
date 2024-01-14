namespace Vista
{
    partial class Menu
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
            menuNavegacion = new MenuStrip();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            gruposToolStripMenuItem = new ToolStripMenuItem();
            menuNavegacion.SuspendLayout();
            SuspendLayout();
            // 
            // menuNavegacion
            // 
            menuNavegacion.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, gruposToolStripMenuItem });
            menuNavegacion.Location = new Point(0, 0);
            menuNavegacion.Name = "menuNavegacion";
            menuNavegacion.Size = new Size(1037, 24);
            menuNavegacion.TabIndex = 3;
            menuNavegacion.Text = "Menu";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(64, 20);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click_1;
            // 
            // gruposToolStripMenuItem
            // 
            gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            gruposToolStripMenuItem.Size = new Size(57, 20);
            gruposToolStripMenuItem.Text = "Grupos";
            gruposToolStripMenuItem.Click += gruposToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 554);
            Controls.Add(menuNavegacion);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            FormClosed += FormPrincipal_FormClosed;
            menuNavegacion.ResumeLayout(false);
            menuNavegacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuNavegacion;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem gruposToolStripMenuItem;
    }
}