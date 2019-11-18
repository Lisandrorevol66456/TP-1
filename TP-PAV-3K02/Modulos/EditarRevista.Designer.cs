namespace TP_PAV_3K02.Modulos
{
    partial class EditarRevista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarRevista));
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblCodigoInterno = new System.Windows.Forms.Label();
            this.lblfrecuenciaPublicacion = new System.Windows.Forms.Label();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblFechaIncio = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcodigoInterno = new System.Windows.Forms.TextBox();
            this.cmbFrecuencia = new System.Windows.Forms.ComboBox();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblRevista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(30, 63);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(50, 13);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Nombre :";
            // 
            // lblCodigoInterno
            // 
            this.lblCodigoInterno.AutoSize = true;
            this.lblCodigoInterno.Location = new System.Drawing.Point(30, 98);
            this.lblCodigoInterno.Name = "lblCodigoInterno";
            this.lblCodigoInterno.Size = new System.Drawing.Size(85, 13);
            this.lblCodigoInterno.TabIndex = 5;
            this.lblCodigoInterno.Text = "Codigo Interno : ";
            // 
            // lblfrecuenciaPublicacion
            // 
            this.lblfrecuenciaPublicacion.AutoSize = true;
            this.lblfrecuenciaPublicacion.Location = new System.Drawing.Point(30, 140);
            this.lblfrecuenciaPublicacion.Name = "lblfrecuenciaPublicacion";
            this.lblfrecuenciaPublicacion.Size = new System.Drawing.Size(139, 13);
            this.lblfrecuenciaPublicacion.TabIndex = 7;
            this.lblfrecuenciaPublicacion.Text = "Frecuencia de Publicacion :";
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(30, 181);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(42, 13);
            this.lblRubro.TabIndex = 9;
            this.lblRubro.Text = "Rubro :";
            // 
            // lblFechaIncio
            // 
            this.lblFechaIncio.AutoSize = true;
            this.lblFechaIncio.Location = new System.Drawing.Point(30, 227);
            this.lblFechaIncio.Name = "lblFechaIncio";
            this.lblFechaIncio.Size = new System.Drawing.Size(71, 13);
            this.lblFechaIncio.TabIndex = 10;
            this.lblFechaIncio.Text = "Fecha Inicio :";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(24, 281);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(91, 35);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(149, 281);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 35);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(121, 56);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(172, 20);
            this.txtnombre.TabIndex = 13;
            // 
            // txtcodigoInterno
            // 
            this.txtcodigoInterno.Location = new System.Drawing.Point(121, 91);
            this.txtcodigoInterno.Name = "txtcodigoInterno";
            this.txtcodigoInterno.ReadOnly = true;
            this.txtcodigoInterno.Size = new System.Drawing.Size(172, 20);
            this.txtcodigoInterno.TabIndex = 14;
            // 
            // cmbFrecuencia
            // 
            this.cmbFrecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrecuencia.FormattingEnabled = true;
            this.cmbFrecuencia.Location = new System.Drawing.Point(172, 140);
            this.cmbFrecuencia.Name = "cmbFrecuencia";
            this.cmbFrecuencia.Size = new System.Drawing.Size(121, 21);
            this.cmbFrecuencia.TabIndex = 15;
            // 
            // cmbRubro
            // 
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(121, 181);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(172, 21);
            this.cmbRubro.TabIndex = 16;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(132, 227);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(144, 20);
            this.dtpFechaInicio.TabIndex = 17;
            // 
            // lblRevista
            // 
            this.lblRevista.AutoSize = true;
            this.lblRevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevista.Location = new System.Drawing.Point(29, 18);
            this.lblRevista.Name = "lblRevista";
            this.lblRevista.Size = new System.Drawing.Size(137, 24);
            this.lblRevista.TabIndex = 18;
            this.lblRevista.Text = "Editar Revista";
            // 
            // EditarRevista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 366);
            this.Controls.Add(this.lblRevista);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cmbRubro);
            this.Controls.Add(this.cmbFrecuencia);
            this.Controls.Add(this.txtcodigoInterno);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblFechaIncio);
            this.Controls.Add(this.lblRubro);
            this.Controls.Add(this.lblfrecuenciaPublicacion);
            this.Controls.Add(this.lblCodigoInterno);
            this.Controls.Add(this.lblnombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarRevista";
            this.Text = "EditarRevista";
            this.Load += new System.EventHandler(this.EditarRevista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblCodigoInterno;
        private System.Windows.Forms.Label lblfrecuenciaPublicacion;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Label lblFechaIncio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcodigoInterno;
        private System.Windows.Forms.ComboBox cmbFrecuencia;
        private System.Windows.Forms.ComboBox cmbRubro;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblRevista;
    }
}