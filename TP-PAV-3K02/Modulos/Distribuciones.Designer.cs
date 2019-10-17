namespace TP_PAV_3K02.Modulos
{
    partial class Distribuciones
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPfechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.DGV_Distribuciones = new System.Windows.Forms.DataGridView();
            this.TXTCod_Int = new System.Windows.Forms.TextBox();
            this.TXTCUIT = new System.Windows.Forms.TextBox();
            this.TXTtotal = new System.Windows.Forms.TextBox();
            this.GRBejemplares = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTpagados = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblIdDist = new System.Windows.Forms.Label();
            this.IDDistribucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Interno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_ejemplares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_ejemplares_pagos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtidDistribucion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Distribuciones)).BeginInit();
            this.GRBejemplares.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha de entrega";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Codigo interno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nº CUIT :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Distribuciones";
            // 
            // DTPfechaEntrega
            // 
            this.DTPfechaEntrega.Location = new System.Drawing.Point(121, 111);
            this.DTPfechaEntrega.Name = "DTPfechaEntrega";
            this.DTPfechaEntrega.Size = new System.Drawing.Size(163, 20);
            this.DTPfechaEntrega.TabIndex = 16;
            // 
            // DGV_Distribuciones
            // 
            this.DGV_Distribuciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Distribuciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDistribucion,
            this.Cuit,
            this.Cod_Interno,
            this.nro_ejemplares,
            this.nro_ejemplares_pagos,
            this.fecha_Entrega});
            this.DGV_Distribuciones.Location = new System.Drawing.Point(338, 85);
            this.DGV_Distribuciones.Name = "DGV_Distribuciones";
            this.DGV_Distribuciones.Size = new System.Drawing.Size(528, 268);
            this.DGV_Distribuciones.TabIndex = 15;
            // 
            // TXTCod_Int
            // 
            this.TXTCod_Int.Location = new System.Drawing.Point(121, 23);
            this.TXTCod_Int.MaxLength = 18;
            this.TXTCod_Int.Name = "TXTCod_Int";
            this.TXTCod_Int.Size = new System.Drawing.Size(89, 20);
            this.TXTCod_Int.TabIndex = 13;
            this.TXTCod_Int.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarnumeros);
            // 
            // TXTCUIT
            // 
            this.TXTCUIT.Location = new System.Drawing.Point(115, 85);
            this.TXTCUIT.MaxLength = 18;
            this.TXTCUIT.Name = "TXTCUIT";
            this.TXTCUIT.ReadOnly = true;
            this.TXTCUIT.Size = new System.Drawing.Size(163, 20);
            this.TXTCUIT.TabIndex = 12;
            this.TXTCUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarnumeros);
            // 
            // TXTtotal
            // 
            this.TXTtotal.Location = new System.Drawing.Point(121, 49);
            this.TXTtotal.MaxLength = 18;
            this.TXTtotal.Name = "TXTtotal";
            this.TXTtotal.Size = new System.Drawing.Size(89, 20);
            this.TXTtotal.TabIndex = 24;
            this.TXTtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarnumeros);
            // 
            // GRBejemplares
            // 
            this.GRBejemplares.Controls.Add(this.label7);
            this.GRBejemplares.Controls.Add(this.TXTpagados);
            this.GRBejemplares.Controls.Add(this.label3);
            this.GRBejemplares.Controls.Add(this.label5);
            this.GRBejemplares.Controls.Add(this.label4);
            this.GRBejemplares.Controls.Add(this.TXTtotal);
            this.GRBejemplares.Controls.Add(this.DTPfechaEntrega);
            this.GRBejemplares.Controls.Add(this.TXTCod_Int);
            this.GRBejemplares.Location = new System.Drawing.Point(28, 131);
            this.GRBejemplares.Name = "GRBejemplares";
            this.GRBejemplares.Size = new System.Drawing.Size(304, 148);
            this.GRBejemplares.TabIndex = 25;
            this.GRBejemplares.TabStop = false;
            this.GRBejemplares.Text = "Ejemplares";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Pagados";
            // 
            // TXTpagados
            // 
            this.TXTpagados.Location = new System.Drawing.Point(121, 75);
            this.TXTpagados.MaxLength = 18;
            this.TXTpagados.Name = "TXTpagados";
            this.TXTpagados.Size = new System.Drawing.Size(89, 20);
            this.TXTpagados.TabIndex = 26;
            this.TXTpagados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarnumeros);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(149, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(513, 366);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 35);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(382, 366);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 35);
            this.btnEditar.TabIndex = 38;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(23, 307);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 35);
            this.btnAceptar.TabIndex = 37;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblIdDist
            // 
            this.lblIdDist.AutoSize = true;
            this.lblIdDist.Location = new System.Drawing.Point(39, 62);
            this.lblIdDist.Name = "lblIdDist";
            this.lblIdDist.Size = new System.Drawing.Size(104, 13);
            this.lblIdDist.TabIndex = 41;
            this.lblIdDist.Text = "ID DISTRIBUCION :";
            // 
            // IDDistribucion
            // 
            this.IDDistribucion.Frozen = true;
            this.IDDistribucion.HeaderText = "ID Dist.";
            this.IDDistribucion.Name = "IDDistribucion";
            // 
            // Cuit
            // 
            this.Cuit.Frozen = true;
            this.Cuit.HeaderText = "CUIT";
            this.Cuit.Name = "Cuit";
            this.Cuit.ReadOnly = true;
            // 
            // Cod_Interno
            // 
            this.Cod_Interno.Frozen = true;
            this.Cod_Interno.HeaderText = "CODIGO INTERNO";
            this.Cod_Interno.Name = "Cod_Interno";
            this.Cod_Interno.ReadOnly = true;
            // 
            // nro_ejemplares
            // 
            this.nro_ejemplares.Frozen = true;
            this.nro_ejemplares.HeaderText = "EJEMPLARES";
            this.nro_ejemplares.Name = "nro_ejemplares";
            this.nro_ejemplares.ReadOnly = true;
            // 
            // nro_ejemplares_pagos
            // 
            this.nro_ejemplares_pagos.Frozen = true;
            this.nro_ejemplares_pagos.HeaderText = "EJEMPLARES PAGOS";
            this.nro_ejemplares_pagos.Name = "nro_ejemplares_pagos";
            this.nro_ejemplares_pagos.ReadOnly = true;
            // 
            // fecha_Entrega
            // 
            this.fecha_Entrega.Frozen = true;
            this.fecha_Entrega.HeaderText = "FECHA DE ENTREGA";
            this.fecha_Entrega.Name = "fecha_Entrega";
            this.fecha_Entrega.ReadOnly = true;
            // 
            // TxtidDistribucion
            // 
            this.TxtidDistribucion.Location = new System.Drawing.Point(149, 55);
            this.TxtidDistribucion.MaxLength = 18;
            this.TxtidDistribucion.Name = "TxtidDistribucion";
            this.TxtidDistribucion.Size = new System.Drawing.Size(129, 20);
            this.TxtidDistribucion.TabIndex = 42;
            // 
            // Distribuciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 413);
            this.Controls.Add(this.TxtidDistribucion);
            this.Controls.Add(this.lblIdDist);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.GRBejemplares);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Distribuciones);
            this.Controls.Add(this.TXTCUIT);
            this.Name = "Distribuciones";
            this.Text = "Distribucion";
            this.Load += new System.EventHandler(this.Distribuciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Distribuciones)).EndInit();
            this.GRBejemplares.ResumeLayout(false);
            this.GRBejemplares.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPfechaEntrega;
        private System.Windows.Forms.DataGridView DGV_Distribuciones;
        private System.Windows.Forms.TextBox TXTCod_Int;
        private System.Windows.Forms.TextBox TXTCUIT;
        private System.Windows.Forms.TextBox TXTtotal;
        private System.Windows.Forms.GroupBox GRBejemplares;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTpagados;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblIdDist;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDistribucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Interno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_ejemplares;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_ejemplares_pagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_Entrega;
        private System.Windows.Forms.TextBox TxtidDistribucion;
    }
}