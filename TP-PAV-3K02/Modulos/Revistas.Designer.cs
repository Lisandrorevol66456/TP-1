namespace TP_PAV_3K02.Modulos
{
    partial class Revistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Revistas));
            this.lblRevista = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblfrecuenciaPublicacion = new System.Windows.Forms.Label();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblFechaIncio = new System.Windows.Forms.Label();
            this.cmbFrecuencia = new System.Windows.Forms.ComboBox();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dgvRevistas = new System.Windows.Forms.DataGridView();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.btnCancelarBusqueda = new System.Windows.Forms.Button();
            this.txtCodigoBuscar = new System.Windows.Forms.TextBox();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblCodigoInterno = new System.Windows.Forms.Label();
            this.txtcodigoInterno = new System.Windows.Forms.TextBox();
            this.Cod_Interno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_frecPublic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevistas)).BeginInit();
            this.gbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRevista
            // 
            this.lblRevista.AutoSize = true;
            this.lblRevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevista.Location = new System.Drawing.Point(23, 31);
            this.lblRevista.Name = "lblRevista";
            this.lblRevista.Size = new System.Drawing.Size(87, 24);
            this.lblRevista.TabIndex = 1;
            this.lblRevista.Text = "Revistas";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(24, 104);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(50, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre :";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(130, 97);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(146, 20);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarLetras);
            // 
            // lblfrecuenciaPublicacion
            // 
            this.lblfrecuenciaPublicacion.AutoSize = true;
            this.lblfrecuenciaPublicacion.Location = new System.Drawing.Point(24, 159);
            this.lblfrecuenciaPublicacion.Name = "lblfrecuenciaPublicacion";
            this.lblfrecuenciaPublicacion.Size = new System.Drawing.Size(139, 13);
            this.lblfrecuenciaPublicacion.TabIndex = 6;
            this.lblfrecuenciaPublicacion.Text = "Frecuencia de Publicacion :";
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(24, 209);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(42, 13);
            this.lblRubro.TabIndex = 8;
            this.lblRubro.Text = "Rubro :";
            // 
            // lblFechaIncio
            // 
            this.lblFechaIncio.AutoSize = true;
            this.lblFechaIncio.Location = new System.Drawing.Point(24, 255);
            this.lblFechaIncio.Name = "lblFechaIncio";
            this.lblFechaIncio.Size = new System.Drawing.Size(71, 13);
            this.lblFechaIncio.TabIndex = 9;
            this.lblFechaIncio.Text = "Fecha Inicio :";
            // 
            // cmbFrecuencia
            // 
            this.cmbFrecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrecuencia.FormattingEnabled = true;
            this.cmbFrecuencia.Location = new System.Drawing.Point(181, 151);
            this.cmbFrecuencia.Name = "cmbFrecuencia";
            this.cmbFrecuencia.Size = new System.Drawing.Size(95, 21);
            this.cmbFrecuencia.TabIndex = 10;
            // 
            // cmbRubro
            // 
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(130, 201);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(146, 21);
            this.cmbRubro.TabIndex = 11;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(163, 255);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaInicio.TabIndex = 12;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(13, 340);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(82, 40);
            this.btnagregar.TabIndex = 15;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(114, 340);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 40);
            this.btncancelar.TabIndex = 16;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(220, 340);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 40);
            this.btneliminar.TabIndex = 17;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dgvRevistas
            // 
            this.dgvRevistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Interno,
            this.nom,
            this.cod_Rubro,
            this.cod_frecPublic,
            this.FechaInicio});
            this.dgvRevistas.Location = new System.Drawing.Point(320, 104);
            this.dgvRevistas.Name = "dgvRevistas";
            this.dgvRevistas.Size = new System.Drawing.Size(524, 283);
            this.dgvRevistas.TabIndex = 18;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(62, 30);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(46, 13);
            this.lblcodigo.TabIndex = 20;
            this.lblcodigo.Text = "Codigo :";
            // 
            // btnCancelarBusqueda
            // 
            this.btnCancelarBusqueda.Location = new System.Drawing.Point(278, 50);
            this.btnCancelarBusqueda.Name = "btnCancelarBusqueda";
            this.btnCancelarBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarBusqueda.TabIndex = 21;
            this.btnCancelarBusqueda.Text = "Cancelar";
            this.btnCancelarBusqueda.UseVisualStyleBackColor = true;
            this.btnCancelarBusqueda.Click += new System.EventHandler(this.btnCancelarBusqueda_Click);
            // 
            // txtCodigoBuscar
            // 
            this.txtCodigoBuscar.Location = new System.Drawing.Point(123, 27);
            this.txtCodigoBuscar.Name = "txtCodigoBuscar";
            this.txtCodigoBuscar.Size = new System.Drawing.Size(134, 20);
            this.txtCodigoBuscar.TabIndex = 22;
            this.txtCodigoBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNum);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Controls.Add(this.txtCodigoBuscar);
            this.gbBuscar.Controls.Add(this.lblcodigo);
            this.gbBuscar.Controls.Add(this.btnCancelarBusqueda);
            this.gbBuscar.Location = new System.Drawing.Point(320, 19);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(412, 79);
            this.gbBuscar.TabIndex = 23;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(278, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(751, 31);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 54);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblCodigoInterno
            // 
            this.lblCodigoInterno.AutoSize = true;
            this.lblCodigoInterno.Location = new System.Drawing.Point(24, 123);
            this.lblCodigoInterno.Name = "lblCodigoInterno";
            this.lblCodigoInterno.Size = new System.Drawing.Size(85, 13);
            this.lblCodigoInterno.TabIndex = 4;
            this.lblCodigoInterno.Text = "Codigo Interno : ";
            this.lblCodigoInterno.Visible = false;
            // 
            // txtcodigoInterno
            // 
            this.txtcodigoInterno.Location = new System.Drawing.Point(130, 116);
            this.txtcodigoInterno.Name = "txtcodigoInterno";
            this.txtcodigoInterno.Size = new System.Drawing.Size(146, 20);
            this.txtcodigoInterno.TabIndex = 5;
            this.txtcodigoInterno.Visible = false;
            this.txtcodigoInterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNum);
            // 
            // Cod_Interno
            // 
            this.Cod_Interno.HeaderText = "Codigo Interno";
            this.Cod_Interno.Name = "Cod_Interno";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nombre";
            this.nom.Name = "nom";
            // 
            // cod_Rubro
            // 
            this.cod_Rubro.HeaderText = "Rubro";
            this.cod_Rubro.Name = "cod_Rubro";
            // 
            // cod_frecPublic
            // 
            this.cod_frecPublic.HeaderText = "Frec. Public";
            this.cod_frecPublic.Name = "cod_frecPublic";
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            // 
            // Revistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.dgvRevistas);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cmbRubro);
            this.Controls.Add(this.cmbFrecuencia);
            this.Controls.Add(this.lblFechaIncio);
            this.Controls.Add(this.lblRubro);
            this.Controls.Add(this.lblfrecuenciaPublicacion);
            this.Controls.Add(this.txtcodigoInterno);
            this.Controls.Add(this.lblCodigoInterno);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblRevista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Revistas";
            this.Text = "Revista";
            this.Load += new System.EventHandler(this.Revista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevistas)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRevista;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblfrecuenciaPublicacion;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Label lblFechaIncio;
        private System.Windows.Forms.ComboBox cmbFrecuencia;
        private System.Windows.Forms.ComboBox cmbRubro;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView dgvRevistas;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Button btnCancelarBusqueda;
        private System.Windows.Forms.TextBox txtCodigoBuscar;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblCodigoInterno;
        private System.Windows.Forms.TextBox txtcodigoInterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Interno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_frecPublic;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
    }
}