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
            this.lblRevista = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblCodigoInterno = new System.Windows.Forms.Label();
            this.txtcodigoInterno = new System.Windows.Forms.TextBox();
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
            this.Cod_Interno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_frecPublic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevistas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRevista
            // 
            this.lblRevista.AutoSize = true;
            this.lblRevista.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevista.Location = new System.Drawing.Point(23, 31);
            this.lblRevista.Name = "lblRevista";
            this.lblRevista.Size = new System.Drawing.Size(75, 23);
            this.lblRevista.TabIndex = 1;
            this.lblRevista.Text = "Revistas";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(24, 93);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(50, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre :";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(130, 90);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(172, 20);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarLetras);
            // 
            // lblCodigoInterno
            // 
            this.lblCodigoInterno.AutoSize = true;
            this.lblCodigoInterno.Location = new System.Drawing.Point(24, 136);
            this.lblCodigoInterno.Name = "lblCodigoInterno";
            this.lblCodigoInterno.Size = new System.Drawing.Size(85, 13);
            this.lblCodigoInterno.TabIndex = 4;
            this.lblCodigoInterno.Text = "Codigo Interno : ";
            // 
            // txtcodigoInterno
            // 
            this.txtcodigoInterno.Location = new System.Drawing.Point(130, 129);
            this.txtcodigoInterno.Name = "txtcodigoInterno";
            this.txtcodigoInterno.Size = new System.Drawing.Size(172, 20);
            this.txtcodigoInterno.TabIndex = 5;
            this.txtcodigoInterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNum);
            // 
            // lblfrecuenciaPublicacion
            // 
            this.lblfrecuenciaPublicacion.AutoSize = true;
            this.lblfrecuenciaPublicacion.Location = new System.Drawing.Point(24, 186);
            this.lblfrecuenciaPublicacion.Name = "lblfrecuenciaPublicacion";
            this.lblfrecuenciaPublicacion.Size = new System.Drawing.Size(139, 13);
            this.lblfrecuenciaPublicacion.TabIndex = 6;
            this.lblfrecuenciaPublicacion.Text = "Frecuencia de Publicacion :";
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(24, 239);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(42, 13);
            this.lblRubro.TabIndex = 8;
            this.lblRubro.Text = "Rubro :";
            // 
            // lblFechaIncio
            // 
            this.lblFechaIncio.AutoSize = true;
            this.lblFechaIncio.Location = new System.Drawing.Point(24, 283);
            this.lblFechaIncio.Name = "lblFechaIncio";
            this.lblFechaIncio.Size = new System.Drawing.Size(71, 13);
            this.lblFechaIncio.TabIndex = 9;
            this.lblFechaIncio.Text = "Fecha Inicio :";
            // 
            // cmbFrecuencia
            // 
            this.cmbFrecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrecuencia.FormattingEnabled = true;
            this.cmbFrecuencia.Location = new System.Drawing.Point(181, 178);
            this.cmbFrecuencia.Name = "cmbFrecuencia";
            this.cmbFrecuencia.Size = new System.Drawing.Size(121, 21);
            this.cmbFrecuencia.TabIndex = 10;
            // 
            // cmbRubro
            // 
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(130, 231);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(172, 21);
            this.cmbRubro.TabIndex = 11;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(114, 276);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(123, 20);
            this.dtpFechaInicio.TabIndex = 12;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(27, 357);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(82, 40);
            this.btnagregar.TabIndex = 15;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(155, 357);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 40);
            this.btncancelar.TabIndex = 16;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(279, 357);
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
            this.cod_frecPublic,
            this.cod_Rubro,
            this.FechaInicio});
            this.dgvRevistas.Location = new System.Drawing.Point(367, 31);
            this.dgvRevistas.Name = "dgvRevistas";
            this.dgvRevistas.Size = new System.Drawing.Size(421, 349);
            this.dgvRevistas.TabIndex = 18;
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
            // cod_frecPublic
            // 
            this.cod_frecPublic.HeaderText = "Frec. Public";
            this.cod_frecPublic.Name = "cod_frecPublic";
            // 
            // cod_Rubro
            // 
            this.cod_Rubro.HeaderText = "Rubro";
            this.cod_Rubro.Name = "cod_Rubro";
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            this.informesToolStripMenuItem.Click += new System.EventHandler(this.informesToolStripMenuItem_Click);
            // 
            // Revistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Revistas";
            this.Text = "Revista";
            this.Load += new System.EventHandler(this.Revista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevistas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRevista;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblCodigoInterno;
        private System.Windows.Forms.TextBox txtcodigoInterno;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Interno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_frecPublic;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
    }
}