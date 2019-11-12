namespace TP_PAV_3K02.Modulos
{
    partial class Empresas
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
            this.components = new System.ComponentModel.Container();
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.cuit_Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_cal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TP_PAV_3K02.DataSet1();
            this.empresasTableAdapter = new TP_PAV_3K02.DataSet1TableAdapters.EmpresasTableAdapter();
            this.TxtCuit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPfechainicio = new System.Windows.Forms.DateTimePicker();
            this.TxtDomicilio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblsuscriptores = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnCancelarBusqueda = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TXTbuscarCUIT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BTNactualizar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.gbBuscar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuit_Empresa,
            this.nombre,
            this.apellido,
            this.domicilio,
            this.fechaInicio,
            this.cod_calificacion,
            this.fecha_cal});
            this.dgvEmpresas.Location = new System.Drawing.Point(338, 118);
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.Size = new System.Drawing.Size(745, 267);
            this.dgvEmpresas.TabIndex = 0;
            // 
            // cuit_Empresa
            // 
            this.cuit_Empresa.HeaderText = "Cuit Empresa";
            this.cuit_Empresa.Name = "cuit_Empresa";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // domicilio
            // 
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "Fecha Inicio";
            this.fechaInicio.Name = "fechaInicio";
            // 
            // cod_calificacion
            // 
            this.cod_calificacion.HeaderText = "Cod Calif.";
            this.cod_calificacion.Name = "cod_calificacion";
            // 
            // fecha_cal
            // 
            this.fecha_cal.HeaderText = "Fecha Calif";
            this.fecha_cal.Name = "fecha_cal";
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // TxtCuit
            // 
            this.TxtCuit.Location = new System.Drawing.Point(144, 190);
            this.TxtCuit.MaxLength = 14;
            this.TxtCuit.Name = "TxtCuit";
            this.TxtCuit.Size = new System.Drawing.Size(163, 20);
            this.TxtCuit.TabIndex = 29;
            this.TxtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateSoloNumeros);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "CUIT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fecha de inicio :";
            // 
            // DTPfechainicio
            // 
            this.DTPfechainicio.Location = new System.Drawing.Point(144, 283);
            this.DTPfechainicio.MaxDate = new System.DateTime(2019, 9, 13, 0, 0, 0, 0);
            this.DTPfechainicio.MinDate = new System.DateTime(1919, 12, 29, 0, 0, 0, 0);
            this.DTPfechainicio.Name = "DTPfechainicio";
            this.DTPfechainicio.Size = new System.Drawing.Size(163, 20);
            this.DTPfechainicio.TabIndex = 26;
            this.DTPfechainicio.Value = new System.DateTime(2019, 9, 13, 0, 0, 0, 0);
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.Location = new System.Drawing.Point(143, 237);
            this.TxtDomicilio.MaxLength = 20;
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(164, 20);
            this.TxtDomicilio.TabIndex = 25;
            this.TxtDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarLetrayNumero);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Domicilio :";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(144, 146);
            this.txtApellido.MaxLength = 20;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(163, 20);
            this.txtApellido.TabIndex = 23;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarletra);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(144, 102);
            this.txtnombre.MaxLength = 20;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(163, 20);
            this.txtnombre.TabIndex = 22;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarletra);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(32, 146);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 16);
            this.lblApellido.TabIndex = 21;
            this.lblApellido.Text = "Apellido :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(33, 106);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 16);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblsuscriptores
            // 
            this.lblsuscriptores.AutoSize = true;
            this.lblsuscriptores.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsuscriptores.Location = new System.Drawing.Point(32, 25);
            this.lblsuscriptores.Name = "lblsuscriptores";
            this.lblsuscriptores.Size = new System.Drawing.Size(86, 23);
            this.lblsuscriptores.TabIndex = 30;
            this.lblsuscriptores.Text = "Empresas";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(444, 403);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 35);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(525, 403);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 35);
            this.btnEditar.TabIndex = 32;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(27, 362);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 35);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.btnCancelarBusqueda);
            this.gbBuscar.Controls.Add(this.BtnBuscar);
            this.gbBuscar.Controls.Add(this.TXTbuscarCUIT);
            this.gbBuscar.Controls.Add(this.label4);
            this.gbBuscar.Location = new System.Drawing.Point(336, 12);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(462, 100);
            this.gbBuscar.TabIndex = 36;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar";
            // 
            // btnCancelarBusqueda
            // 
            this.btnCancelarBusqueda.Location = new System.Drawing.Point(271, 59);
            this.btnCancelarBusqueda.Name = "btnCancelarBusqueda";
            this.btnCancelarBusqueda.Size = new System.Drawing.Size(86, 21);
            this.btnCancelarBusqueda.TabIndex = 40;
            this.btnCancelarBusqueda.Text = "cancelar";
            this.btnCancelarBusqueda.UseVisualStyleBackColor = true;
            this.btnCancelarBusqueda.Click += new System.EventHandler(this.btnCancelarBusqueda_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(271, 33);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(86, 20);
            this.BtnBuscar.TabIndex = 36;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TXTbuscarCUIT
            // 
            this.TXTbuscarCUIT.Location = new System.Drawing.Point(123, 47);
            this.TXTbuscarCUIT.MaxLength = 11;
            this.TXTbuscarCUIT.Name = "TXTbuscarCUIT";
            this.TXTbuscarCUIT.Size = new System.Drawing.Size(138, 20);
            this.TXTbuscarCUIT.TabIndex = 30;
            this.TXTbuscarCUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateSoloNumeros);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nro Cuit:";
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(336, 403);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(95, 35);
            this.btnCalificar.TabIndex = 37;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(143, 362);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BTNactualizar
            // 
            this.BTNactualizar.Location = new System.Drawing.Point(1008, 77);
            this.BTNactualizar.Name = "BTNactualizar";
            this.BTNactualizar.Size = new System.Drawing.Size(75, 35);
            this.BTNactualizar.TabIndex = 39;
            this.BTNactualizar.Text = "Actualizar";
            this.BTNactualizar.UseVisualStyleBackColor = true;
            this.BTNactualizar.Click += new System.EventHandler(this.BTNactualizar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            this.informesToolStripMenuItem.Click += new System.EventHandler(this.informesToolStripMenuItem_Click);
            // 
            // Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 450);
            this.Controls.Add(this.BTNactualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCalificar);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblsuscriptores);
            this.Controls.Add(this.TxtCuit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTPfechainicio);
            this.Controls.Add(this.TxtDomicilio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvEmpresas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Empresas";
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.Peliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpresas;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private DataSet1TableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private System.Windows.Forms.TextBox TxtCuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPfechainicio;
        private System.Windows.Forms.TextBox TxtDomicilio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblsuscriptores;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TXTbuscarCUIT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BTNactualizar;
        private System.Windows.Forms.Button btnCancelarBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit_Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_calificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_cal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
    }
}