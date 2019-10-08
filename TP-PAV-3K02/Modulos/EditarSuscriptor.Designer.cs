namespace TP_PAV_3K02
{
    partial class EditarSuscriptor
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
            this.comboProvincias = new System.Windows.Forms.ComboBox();
            this.ComboLocalidades = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.TXTcalle = new System.Windows.Forms.TextBox();
            this.TXTnumero = new System.Windows.Forms.TextBox();
            this.TXTnroDoc = new System.Windows.Forms.TextBox();
            this.comboTipodoc = new System.Windows.Forms.ComboBox();
            this.TXTapellido = new System.Windows.Forms.TextBox();
            this.TXTnombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboProvincias
            // 
            this.comboProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProvincias.FormattingEnabled = true;
            this.comboProvincias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboProvincias.Location = new System.Drawing.Point(139, 225);
            this.comboProvincias.Name = "comboProvincias";
            this.comboProvincias.Size = new System.Drawing.Size(138, 21);
            this.comboProvincias.TabIndex = 49;
            this.comboProvincias.SelectedIndexChanged += new System.EventHandler(this.comboProvincias_SelectedIndexChanged);
            // 
            // ComboLocalidades
            // 
            this.ComboLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboLocalidades.FormattingEnabled = true;
            this.ComboLocalidades.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboLocalidades.Location = new System.Drawing.Point(139, 272);
            this.ComboLocalidades.Name = "ComboLocalidades";
            this.ComboLocalidades.Size = new System.Drawing.Size(138, 21);
            this.ComboLocalidades.TabIndex = 48;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(50, 226);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(70, 16);
            this.lblProvincia.TabIndex = 47;
            this.lblProvincia.Text = "Provincia :";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(44, 273);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(74, 16);
            this.lblLocalidad.TabIndex = 46;
            this.lblLocalidad.Text = "Localidad :";
            // 
            // TXTcalle
            // 
            this.TXTcalle.Location = new System.Drawing.Point(139, 154);
            this.TXTcalle.MaxLength = 30;
            this.TXTcalle.Name = "TXTcalle";
            this.TXTcalle.Size = new System.Drawing.Size(138, 20);
            this.TXTcalle.TabIndex = 45;
            this.TXTcalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarLetras);
            // 
            // TXTnumero
            // 
            this.TXTnumero.Location = new System.Drawing.Point(139, 184);
            this.TXTnumero.MaxLength = 5;
            this.TXTnumero.Name = "TXTnumero";
            this.TXTnumero.Size = new System.Drawing.Size(138, 20);
            this.TXTnumero.TabIndex = 44;
            this.TXTnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeros);
            // 
            // TXTnroDoc
            // 
            this.TXTnroDoc.Enabled = false;
            this.TXTnroDoc.Location = new System.Drawing.Point(139, 123);
            this.TXTnroDoc.MaxLength = 11;
            this.TXTnroDoc.Name = "TXTnroDoc";
            this.TXTnroDoc.Size = new System.Drawing.Size(138, 20);
            this.TXTnroDoc.TabIndex = 43;
            this.TXTnroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeros);
            // 
            // comboTipodoc
            // 
            this.comboTipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipodoc.FormattingEnabled = true;
            this.comboTipodoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboTipodoc.Location = new System.Drawing.Point(139, 93);
            this.comboTipodoc.Name = "comboTipodoc";
            this.comboTipodoc.Size = new System.Drawing.Size(138, 21);
            this.comboTipodoc.TabIndex = 42;
            // 
            // TXTapellido
            // 
            this.TXTapellido.Location = new System.Drawing.Point(139, 56);
            this.TXTapellido.MaxLength = 20;
            this.TXTapellido.Name = "TXTapellido";
            this.TXTapellido.Size = new System.Drawing.Size(138, 20);
            this.TXTapellido.TabIndex = 41;
            this.TXTapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarLetras);
            // 
            // TXTnombre
            // 
            this.TXTnombre.Location = new System.Drawing.Point(139, 26);
            this.TXTnombre.MaxLength = 20;
            this.TXTnombre.Name = "TXTnombre";
            this.TXTnombre.Size = new System.Drawing.Size(138, 20);
            this.TXTnombre.TabIndex = 40;
            this.TXTnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarLetras);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(57, 60);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 16);
            this.lblApellido.TabIndex = 39;
            this.lblApellido.Text = "Apellido :";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(48, 94);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(70, 16);
            this.lblTipoDoc.TabIndex = 38;
            this.lblTipoDoc.Text = "Tipo Doc :";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDoc.Location = new System.Drawing.Point(57, 124);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(61, 16);
            this.lblNroDoc.TabIndex = 37;
            this.lblNroDoc.Text = "Nro Doc:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(56, 185);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 16);
            this.lblNumero.TabIndex = 36;
            this.lblNumero.Text = "Numero :";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(73, 155);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(45, 16);
            this.lblCalle.TabIndex = 35;
            this.lblCalle.Text = "Calle :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(57, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 16);
            this.lblNombre.TabIndex = 34;
            this.lblNombre.Text = "Nombre :";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(166, 353);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(61, 353);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 35);
            this.btnAceptar.TabIndex = 50;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // EditarSuscriptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 400);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.TXTnroDoc);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.comboTipodoc);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.TXTnumero);
            this.Controls.Add(this.comboProvincias);
            this.Controls.Add(this.TXTapellido);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.TXTcalle);
            this.Controls.Add(this.ComboLocalidades);
            this.Controls.Add(this.TXTnombre);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblApellido);
            this.Name = "EditarSuscriptor";
            this.Text = "EditarSuscriptor";
            this.Load += new System.EventHandler(this.EditarSuscriptor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboProvincias;
        private System.Windows.Forms.ComboBox ComboLocalidades;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox TXTcalle;
        private System.Windows.Forms.TextBox TXTnumero;
        private System.Windows.Forms.TextBox TXTnroDoc;
        private System.Windows.Forms.ComboBox comboTipodoc;
        private System.Windows.Forms.TextBox TXTapellido;
        private System.Windows.Forms.TextBox TXTnombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}