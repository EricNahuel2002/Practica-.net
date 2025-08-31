namespace Clase_2_practica
{
    partial class frmAgregarTipoLocal
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
            tbNuevoTipoLocal = new TextBox();
            btnGuardarNuevoTipo = new Button();
            btnVolverAlMenu = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbNuevoTipoLocal
            // 
            tbNuevoTipoLocal.Location = new Point(262, 173);
            tbNuevoTipoLocal.Name = "tbNuevoTipoLocal";
            tbNuevoTipoLocal.Size = new Size(262, 27);
            tbNuevoTipoLocal.TabIndex = 0;
            // 
            // btnGuardarNuevoTipo
            // 
            btnGuardarNuevoTipo.Location = new Point(262, 223);
            btnGuardarNuevoTipo.Name = "btnGuardarNuevoTipo";
            btnGuardarNuevoTipo.Size = new Size(113, 55);
            btnGuardarNuevoTipo.TabIndex = 1;
            btnGuardarNuevoTipo.Text = "Guardar nuevo tipo";
            btnGuardarNuevoTipo.UseVisualStyleBackColor = true;
            btnGuardarNuevoTipo.Click += btnGuardarNuevoTipo_Click;
            // 
            // btnVolverAlMenu
            // 
            btnVolverAlMenu.Location = new Point(413, 223);
            btnVolverAlMenu.Name = "btnVolverAlMenu";
            btnVolverAlMenu.Size = new Size(111, 55);
            btnVolverAlMenu.TabIndex = 2;
            btnVolverAlMenu.Text = "Volver al menu";
            btnVolverAlMenu.UseVisualStyleBackColor = true;
            btnVolverAlMenu.Click += btnVolverAlMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 140);
            label1.Name = "label1";
            label1.Size = new Size(205, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingresa el nuevo tipo de local";
            // 
            // frmAgregarTipoLocal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnVolverAlMenu);
            Controls.Add(btnGuardarNuevoTipo);
            Controls.Add(tbNuevoTipoLocal);
            Name = "frmAgregarTipoLocal";
            Text = "Formulario de tipos de locales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNuevoTipoLocal;
        private Button btnGuardarNuevoTipo;
        private Button btnVolverAlMenu;
        private Label label1;
    }
}