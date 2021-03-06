﻿namespace TP_PAV_3K02
{
    partial class FormDistribuidores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDistribuidores));
            this.lblsuscriptores = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.TxtDomicilio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPfechainicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCuit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.DvgDistribuidores = new System.Windows.Forms.DataGridView();
            this.cuit_dist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnCancelarBusqueda = new System.Windows.Forms.Button();
            this.BtnBuscarCuit = new System.Windows.Forms.Button();
            this.TXTbuscarCUIT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BTNAgregarDistribucion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DvgDistribuidores)).BeginInit();
            this.gbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsuscriptores
            // 
            this.lblsuscriptores.AutoSize = true;
            this.lblsuscriptores.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsuscriptores.Location = new System.Drawing.Point(21, 19);
            this.lblsuscriptores.Name = "lblsuscriptores";
            this.lblsuscriptores.Size = new System.Drawing.Size(117, 23);
            this.lblsuscriptores.TabIndex = 1;
            this.lblsuscriptores.Text = "Distribuidores";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(134, 108);
            this.txtApellido.MaxLength = 20;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(171, 20);
            this.txtApellido.TabIndex = 13;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateSoloLetras);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(134, 71);
            this.txtnombre.MaxLength = 20;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(171, 20);
            this.txtnombre.TabIndex = 12;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateSoloLetras);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(22, 108);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 16);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(23, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 16);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre :";
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.Location = new System.Drawing.Point(134, 175);
            this.TxtDomicilio.MaxLength = 50;
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(171, 20);
            this.TxtDomicilio.TabIndex = 15;
            this.TxtDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateSoloLetrasNumeros);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Domicilio :";
            // 
            // DTPfechainicio
            // 
            this.DTPfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPfechainicio.Location = new System.Drawing.Point(134, 217);
            this.DTPfechainicio.MaxDate = new System.DateTime(2019, 10, 10, 0, 0, 0, 0);
            this.DTPfechainicio.MinDate = new System.DateTime(1919, 12, 29, 0, 0, 0, 0);
            this.DTPfechainicio.Name = "DTPfechainicio";
            this.DTPfechainicio.Size = new System.Drawing.Size(171, 20);
            this.DTPfechainicio.TabIndex = 16;
            this.DTPfechainicio.Value = new System.DateTime(2019, 9, 13, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha de inicio :";
            // 
            // TxtCuit
            // 
            this.TxtCuit.Location = new System.Drawing.Point(134, 143);
            this.TxtCuit.MaxLength = 11;
            this.TxtCuit.Name = "TxtCuit";
            this.TxtCuit.Size = new System.Drawing.Size(171, 20);
            this.TxtCuit.TabIndex = 19;
            this.TxtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateSoloNumeros);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "CUIT :";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(449, 418);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 35);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(352, 418);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 35);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(42, 304);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(263, 35);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // DvgDistribuidores
            // 
            this.DvgDistribuidores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DvgDistribuidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgDistribuidores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuit_dist,
            this.nombre,
            this.apellido,
            this.domicilio,
            this.fecha_inicio});
            this.DvgDistribuidores.Location = new System.Drawing.Point(341, 129);
            this.DvgDistribuidores.Name = "DvgDistribuidores";
            this.DvgDistribuidores.Size = new System.Drawing.Size(546, 283);
            this.DvgDistribuidores.TabIndex = 28;
            this.DvgDistribuidores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgDistribuidores_CellContentClick);
            // 
            // cuit_dist
            // 
            this.cuit_dist.HeaderText = "Cuit";
            this.cuit_dist.Name = "cuit_dist";
            this.cuit_dist.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // domicilio
            // 
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.HeaderText = "Fecha Inicio";
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.ReadOnly = true;
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.btnCancelarBusqueda);
            this.gbBuscar.Controls.Add(this.BtnBuscarCuit);
            this.gbBuscar.Controls.Add(this.TXTbuscarCUIT);
            this.gbBuscar.Controls.Add(this.label4);
            this.gbBuscar.Location = new System.Drawing.Point(341, 19);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(366, 100);
            this.gbBuscar.TabIndex = 35;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar";
            // 
            // btnCancelarBusqueda
            // 
            this.btnCancelarBusqueda.Location = new System.Drawing.Point(224, 67);
            this.btnCancelarBusqueda.Name = "btnCancelarBusqueda";
            this.btnCancelarBusqueda.Size = new System.Drawing.Size(95, 21);
            this.btnCancelarBusqueda.TabIndex = 35;
            this.btnCancelarBusqueda.Text = "cancelar";
            this.btnCancelarBusqueda.UseVisualStyleBackColor = true;
            this.btnCancelarBusqueda.Click += new System.EventHandler(this.btnCancelarBusqueda_Click);
            // 
            // BtnBuscarCuit
            // 
            this.BtnBuscarCuit.Location = new System.Drawing.Point(224, 35);
            this.BtnBuscarCuit.Name = "BtnBuscarCuit";
            this.BtnBuscarCuit.Size = new System.Drawing.Size(95, 20);
            this.BtnBuscarCuit.TabIndex = 36;
            this.BtnBuscarCuit.Text = "buscar";
            this.BtnBuscarCuit.UseVisualStyleBackColor = true;
            this.BtnBuscarCuit.Click += new System.EventHandler(this.BtnBuscarCuit_Click);
            // 
            // TXTbuscarCUIT
            // 
            this.TXTbuscarCUIT.Location = new System.Drawing.Point(78, 61);
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
            this.label4.Location = new System.Drawing.Point(75, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nro CUIT:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(42, 368);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(263, 35);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BTNAgregarDistribucion
            // 
            this.BTNAgregarDistribucion.Location = new System.Drawing.Point(550, 418);
            this.BTNAgregarDistribucion.Name = "BTNAgregarDistribucion";
            this.BTNAgregarDistribucion.Size = new System.Drawing.Size(139, 35);
            this.BTNAgregarDistribucion.TabIndex = 37;
            this.BTNAgregarDistribucion.Text = "Ver distribuciones";
            this.BTNAgregarDistribucion.UseVisualStyleBackColor = true;
            this.BTNAgregarDistribucion.Click += new System.EventHandler(this.BTNAgregarDistribucion_Click);
            // 
            // FormDistribuidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 476);
            this.Controls.Add(this.BTNAgregarDistribucion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.DvgDistribuidores);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
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
            this.Controls.Add(this.lblsuscriptores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDistribuidores";
            this.Text = "Distribuidores";
            this.Load += new System.EventHandler(this.FormDistribuidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgDistribuidores)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsuscriptores;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox TxtDomicilio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPfechainicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView DvgDistribuidores;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Button btnCancelarBusqueda;
        private System.Windows.Forms.Button BtnBuscarCuit;
        private System.Windows.Forms.TextBox TXTbuscarCUIT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BTNAgregarDistribucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit_dist;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_inicio;
    }
}