namespace TP_PAV_3K02.Modulos
{
    partial class EditarDistribucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarDistribucion));
            this.GRBejemplares = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTpagados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTtotal = new System.Windows.Forms.TextBox();
            this.DTPfechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.TxtidDistribucion = new System.Windows.Forms.TextBox();
            this.lblIdDist = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTCUIT = new System.Windows.Forms.TextBox();
            this.CMB_revistas = new System.Windows.Forms.ComboBox();
            this.GRBejemplares.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRBejemplares
            // 
            this.GRBejemplares.Controls.Add(this.CMB_revistas);
            this.GRBejemplares.Controls.Add(this.label7);
            this.GRBejemplares.Controls.Add(this.TXTpagados);
            this.GRBejemplares.Controls.Add(this.label3);
            this.GRBejemplares.Controls.Add(this.label5);
            this.GRBejemplares.Controls.Add(this.label4);
            this.GRBejemplares.Controls.Add(this.TXTtotal);
            this.GRBejemplares.Controls.Add(this.DTPfechaEntrega);
            this.GRBejemplares.Location = new System.Drawing.Point(28, 153);
            this.GRBejemplares.Name = "GRBejemplares";
            this.GRBejemplares.Size = new System.Drawing.Size(304, 158);
            this.GRBejemplares.TabIndex = 26;
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
            this.TXTpagados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNumero);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Revista";
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
            // TXTtotal
            // 
            this.TXTtotal.Location = new System.Drawing.Point(121, 49);
            this.TXTtotal.MaxLength = 18;
            this.TXTtotal.Name = "TXTtotal";
            this.TXTtotal.Size = new System.Drawing.Size(89, 20);
            this.TXTtotal.TabIndex = 24;
            this.TXTtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNumero);
            // 
            // DTPfechaEntrega
            // 
            this.DTPfechaEntrega.Location = new System.Drawing.Point(121, 111);
            this.DTPfechaEntrega.Name = "DTPfechaEntrega";
            this.DTPfechaEntrega.Size = new System.Drawing.Size(163, 20);
            this.DTPfechaEntrega.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(173, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(47, 329);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 35);
            this.btnAceptar.TabIndex = 41;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // TxtidDistribucion
            // 
            this.TxtidDistribucion.Location = new System.Drawing.Point(135, 68);
            this.TxtidDistribucion.MaxLength = 18;
            this.TxtidDistribucion.Name = "TxtidDistribucion";
            this.TxtidDistribucion.ReadOnly = true;
            this.TxtidDistribucion.Size = new System.Drawing.Size(129, 20);
            this.TxtidDistribucion.TabIndex = 47;
            // 
            // lblIdDist
            // 
            this.lblIdDist.AutoSize = true;
            this.lblIdDist.Location = new System.Drawing.Point(25, 75);
            this.lblIdDist.Name = "lblIdDist";
            this.lblIdDist.Size = new System.Drawing.Size(104, 13);
            this.lblIdDist.TabIndex = 46;
            this.lblIdDist.Text = "ID DISTRIBUCION :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nº CUIT :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(65, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Editar distribucion";
            // 
            // TXTCUIT
            // 
            this.TXTCUIT.Location = new System.Drawing.Point(101, 98);
            this.TXTCUIT.MaxLength = 18;
            this.TXTCUIT.Name = "TXTCUIT";
            this.TXTCUIT.ReadOnly = true;
            this.TXTCUIT.Size = new System.Drawing.Size(163, 20);
            this.TXTCUIT.TabIndex = 43;
            // 
            // CMB_revistas
            // 
            this.CMB_revistas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_revistas.FormattingEnabled = true;
            this.CMB_revistas.Location = new System.Drawing.Point(121, 18);
            this.CMB_revistas.Name = "CMB_revistas";
            this.CMB_revistas.Size = new System.Drawing.Size(111, 21);
            this.CMB_revistas.TabIndex = 28;
            // 
            // EditarDistribucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 382);
            this.Controls.Add(this.TxtidDistribucion);
            this.Controls.Add(this.lblIdDist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTCUIT);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.GRBejemplares);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarDistribucion";
            this.Text = "EditarDistribucion";
            this.Load += new System.EventHandler(this.EditarDistribucion_Load);
            this.GRBejemplares.ResumeLayout(false);
            this.GRBejemplares.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GRBejemplares;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTpagados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTtotal;
        private System.Windows.Forms.DateTimePicker DTPfechaEntrega;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox TxtidDistribucion;
        private System.Windows.Forms.Label lblIdDist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTCUIT;
        private System.Windows.Forms.ComboBox CMB_revistas;
    }
}