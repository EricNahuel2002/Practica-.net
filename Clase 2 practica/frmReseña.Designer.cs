namespace Clase_2_practica
{
    partial class frmReseña
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpFecha = new DateTimePicker();
            cmbPuntuacion = new ComboBox();
            cmbTipoLocal = new ComboBox();
            lblDireccion = new Label();
            tbDireccion = new TextBox();
            btnGuardarReseña = new Button();
            dgvReseñas = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            TipoLocal = new DataGridViewTextBoxColumn();
            Puntuacion = new DataGridViewTextBoxColumn();
            lblPuntacion = new Label();
            lblTipoDeLocal = new Label();
            btnRefrescar = new Button();
            btnAgregarTipoLocal = new Button();
            btnRefrescarTiposDeLocales = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReseñas).BeginInit();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(12, 12);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(310, 27);
            dtpFecha.TabIndex = 0;
            // 
            // cmbPuntuacion
            // 
            cmbPuntuacion.FormattingEnabled = true;
            cmbPuntuacion.Location = new Point(14, 258);
            cmbPuntuacion.Name = "cmbPuntuacion";
            cmbPuntuacion.Size = new Size(310, 28);
            cmbPuntuacion.Sorted = true;
            cmbPuntuacion.TabIndex = 1;
            // 
            // cmbTipoLocal
            // 
            cmbTipoLocal.FormattingEnabled = true;
            cmbTipoLocal.Items.AddRange(new object[] { "Parrila", "Panaderia", "Pizzeria", "Restaurant", "Comida rapida" });
            cmbTipoLocal.Location = new Point(12, 173);
            cmbTipoLocal.Name = "cmbTipoLocal";
            cmbTipoLocal.Size = new Size(312, 28);
            cmbTipoLocal.TabIndex = 2;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(12, 63);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 3;
            lblDireccion.Text = "Direccion";
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(12, 86);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(310, 27);
            tbDireccion.TabIndex = 4;
            // 
            // btnGuardarReseña
            // 
            btnGuardarReseña.Location = new Point(14, 322);
            btnGuardarReseña.Name = "btnGuardarReseña";
            btnGuardarReseña.Size = new Size(151, 56);
            btnGuardarReseña.TabIndex = 5;
            btnGuardarReseña.Text = "Guardar reseña";
            btnGuardarReseña.UseVisualStyleBackColor = true;
            btnGuardarReseña.Click += btnGuardarReseña_Click;
            // 
            // dgvReseñas
            // 
            dgvReseñas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReseñas.Columns.AddRange(new DataGridViewColumn[] { Fecha, Direccion, TipoLocal, Puntuacion });
            dgvReseñas.Location = new Point(12, 396);
            dgvReseñas.Name = "dgvReseñas";
            dgvReseñas.RowHeadersWidth = 51;
            dgvReseñas.Size = new Size(554, 188);
            dgvReseñas.TabIndex = 6;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 125;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            Direccion.Width = 125;
            // 
            // TipoLocal
            // 
            TipoLocal.HeaderText = "TipoLocal";
            TipoLocal.MinimumWidth = 6;
            TipoLocal.Name = "TipoLocal";
            TipoLocal.Width = 125;
            // 
            // Puntuacion
            // 
            Puntuacion.HeaderText = "Puntuacion";
            Puntuacion.MinimumWidth = 6;
            Puntuacion.Name = "Puntuacion";
            Puntuacion.Width = 125;
            // 
            // lblPuntacion
            // 
            lblPuntacion.AutoSize = true;
            lblPuntacion.Location = new Point(12, 235);
            lblPuntacion.Name = "lblPuntacion";
            lblPuntacion.Size = new Size(82, 20);
            lblPuntacion.TabIndex = 7;
            lblPuntacion.Text = "Puntuacion";
            // 
            // lblTipoDeLocal
            // 
            lblTipoDeLocal.AutoSize = true;
            lblTipoDeLocal.Location = new Point(12, 150);
            lblTipoDeLocal.Name = "lblTipoDeLocal";
            lblTipoDeLocal.Size = new Size(96, 20);
            lblTipoDeLocal.TabIndex = 8;
            lblTipoDeLocal.Text = "Tipo de local";
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(171, 322);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(151, 56);
            btnRefrescar.TabIndex = 9;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnAgregarTipoLocal
            // 
            btnAgregarTipoLocal.Location = new Point(330, 173);
            btnAgregarTipoLocal.Name = "btnAgregarTipoLocal";
            btnAgregarTipoLocal.Size = new Size(106, 28);
            btnAgregarTipoLocal.TabIndex = 10;
            btnAgregarTipoLocal.Text = "Agregar";
            btnAgregarTipoLocal.UseVisualStyleBackColor = true;
            btnAgregarTipoLocal.Click += btnAgregarTipoLocal_Click;
            // 
            // btnRefrescarTiposDeLocales
            // 
            btnRefrescarTiposDeLocales.Location = new Point(460, 172);
            btnRefrescarTiposDeLocales.Name = "btnRefrescarTiposDeLocales";
            btnRefrescarTiposDeLocales.Size = new Size(106, 28);
            btnRefrescarTiposDeLocales.TabIndex = 11;
            btnRefrescarTiposDeLocales.Text = "Refrescar";
            btnRefrescarTiposDeLocales.UseVisualStyleBackColor = true;
            btnRefrescarTiposDeLocales.Click += btnRefrescarTiposDeLocales_Click;
            // 
            // frmReseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 626);
            Controls.Add(btnRefrescarTiposDeLocales);
            Controls.Add(btnAgregarTipoLocal);
            Controls.Add(btnRefrescar);
            Controls.Add(lblTipoDeLocal);
            Controls.Add(lblPuntacion);
            Controls.Add(dgvReseñas);
            Controls.Add(btnGuardarReseña);
            Controls.Add(tbDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(cmbTipoLocal);
            Controls.Add(cmbPuntuacion);
            Controls.Add(dtpFecha);
            Name = "frmReseña";
            Text = "Formulario de reseñas";
            ((System.ComponentModel.ISupportInitialize)dgvReseñas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private ComboBox cmbPuntuacion;
        public ComboBox cmbTipoLocal;
        private Label lblDireccion;
        private TextBox tbDireccion;
        private Button btnGuardarReseña;
        private DataGridView dgvReseñas;
        private Label lblPuntacion;
        private Label lblTipoDeLocal;
        private Button btnRefrescar;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn TipoLocal;
        private DataGridViewTextBoxColumn Puntuacion;
        private Button btnAgregarTipoLocal;
        private Button btnRefrescarTiposDeLocales;
    }
}
