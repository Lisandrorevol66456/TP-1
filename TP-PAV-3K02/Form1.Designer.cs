﻿namespace TP_PAV_3K02
{
    partial class NuevoSuscriptor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblsuscriptores = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.DvgSuscriptores = new System.Windows.Forms.DataGridView();
            this.NroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFormRepartidores = new System.Windows.Forms.Button();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTbuscarDNI = new System.Windows.Forms.TextBox();
            this.cmbBuscarDNI = new System.Windows.Forms.ComboBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DvgSuscriptores)).BeginInit();
            this.gbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsuscriptores
            // 
            this.lblsuscriptores.AutoSize = true;
            this.lblsuscriptores.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsuscriptores.Location = new System.Drawing.Point(10, 19);
            this.lblsuscriptores.Name = "lblsuscriptores";
            this.lblsuscriptores.Size = new System.Drawing.Size(107, 23);
            this.lblsuscriptores.TabIndex = 0;
            this.lblsuscriptores.Text = "Suscriptores";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(56, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(72, 183);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(45, 16);
            this.lblCalle.TabIndex = 3;
            this.lblCalle.Text = "Calle :";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(55, 213);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 16);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Numero :";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDoc.Location = new System.Drawing.Point(56, 152);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(61, 16);
            this.lblNroDoc.TabIndex = 5;
            this.lblNroDoc.Text = "Nro Doc:";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(47, 122);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(70, 16);
            this.lblTipoDoc.TabIndex = 6;
            this.lblTipoDoc.Text = "Tipo Doc :";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(56, 88);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 16);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido :";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(138, 54);
            this.txtnombre.MaxLength = 20;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(138, 20);
            this.txtnombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(138, 84);
            this.txtApellido.MaxLength = 20;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(138, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbTipoDoc.Location = new System.Drawing.Point(138, 121);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(138, 21);
            this.cmbTipoDoc.TabIndex = 10;
            this.cmbTipoDoc.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDoc_SelectedIndexChanged);
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(138, 151);
            this.txtNroDoc.MaxLength = 11;
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(138, 20);
            this.txtNroDoc.TabIndex = 11;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(138, 212);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(138, 20);
            this.txtNumero.TabIndex = 12;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(138, 182);
            this.txtCalle.MaxLength = 30;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(138, 20);
            this.txtCalle.TabIndex = 13;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(43, 301);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(74, 16);
            this.lblLocalidad.TabIndex = 17;
            this.lblLocalidad.Text = "Localidad :";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(49, 254);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(70, 16);
            this.lblProvincia.TabIndex = 18;
            this.lblProvincia.Text = "Provincia :";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(59, 378);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 35);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(283, 378);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(174, 378);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 35);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // DvgSuscriptores
            // 
            this.DvgSuscriptores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DvgSuscriptores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgSuscriptores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroDoc,
            this.TipoDoc,
            this.Nombre,
            this.Apellido,
            this.Calle,
            this.Numero,
            this.codLocalidad,
            this.codProvincia});
            this.DvgSuscriptores.Location = new System.Drawing.Point(364, 130);
            this.DvgSuscriptores.Name = "DvgSuscriptores";
            this.DvgSuscriptores.Size = new System.Drawing.Size(424, 279);
            this.DvgSuscriptores.TabIndex = 24;
            // 
            // NroDoc
            // 
            this.NroDoc.HeaderText = "Nro Doc";
            this.NroDoc.Name = "NroDoc";
            // 
            // TipoDoc
            // 
            this.TipoDoc.HeaderText = "TipoDoc";
            this.TipoDoc.Name = "TipoDoc";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Calle
            // 
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // codLocalidad
            // 
            this.codLocalidad.HeaderText = "codLocalidad";
            this.codLocalidad.Name = "codLocalidad";
            // 
            // codProvincia
            // 
            this.codProvincia.HeaderText = "codProvincia";
            this.codProvincia.Name = "codProvincia";
            // 
            // btnFormRepartidores
            // 
            this.btnFormRepartidores.Location = new System.Drawing.Point(664, 415);
            this.btnFormRepartidores.Name = "btnFormRepartidores";
            this.btnFormRepartidores.Size = new System.Drawing.Size(124, 23);
            this.btnFormRepartidores.TabIndex = 31;
            this.btnFormRepartidores.Text = "FormRepartidores";
            this.btnFormRepartidores.UseVisualStyleBackColor = true;
            this.btnFormRepartidores.Click += new System.EventHandler(this.btnFormRepartidores_Click);
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbLocalidad.Location = new System.Drawing.Point(138, 300);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(138, 21);
            this.cmbLocalidad.TabIndex = 32;
            this.cmbLocalidad.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidad_SelectedIndexChanged);
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbProvincias.Location = new System.Drawing.Point(138, 253);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(138, 21);
            this.cmbProvincias.TabIndex = 33;
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.BtnBuscar);
            this.gbBuscar.Controls.Add(this.cmbBuscarDNI);
            this.gbBuscar.Controls.Add(this.TXTbuscarDNI);
            this.gbBuscar.Controls.Add(this.label2);
            this.gbBuscar.Controls.Add(this.label1);
            this.gbBuscar.Location = new System.Drawing.Point(364, 19);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(414, 100);
            this.gbBuscar.TabIndex = 34;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tipo Doc :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nro Doc:";
            // 
            // TXTbuscarDNI
            // 
            this.TXTbuscarDNI.Location = new System.Drawing.Point(103, 65);
            this.TXTbuscarDNI.MaxLength = 11;
            this.TXTbuscarDNI.Name = "TXTbuscarDNI";
            this.TXTbuscarDNI.Size = new System.Drawing.Size(138, 20);
            this.TXTbuscarDNI.TabIndex = 30;
            // 
            // cmbBuscarDNI
            // 
            this.cmbBuscarDNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarDNI.FormattingEnabled = true;
            this.cmbBuscarDNI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbBuscarDNI.Location = new System.Drawing.Point(103, 35);
            this.cmbBuscarDNI.Name = "cmbBuscarDNI";
            this.cmbBuscarDNI.Size = new System.Drawing.Size(138, 21);
            this.cmbBuscarDNI.TabIndex = 35;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(288, 40);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 35);
            this.BtnBuscar.TabIndex = 36;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // NuevoSuscriptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.cmbProvincias);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.btnFormRepartidores);
            this.Controls.Add(this.DvgSuscriptores);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNroDoc);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblsuscriptores);
            this.Name = "NuevoSuscriptor";
            this.Text = "Suscriptores";
            this.Load += new System.EventHandler(this.suscriptores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgSuscriptores)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsuscriptores;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView DvgSuscriptores;
        private System.Windows.Forms.Button btnFormRepartidores;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbProvincias;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProvincia;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.ComboBox cmbBuscarDNI;
        private System.Windows.Forms.TextBox TXTbuscarDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
    }
}

