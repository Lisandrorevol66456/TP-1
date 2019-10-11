namespace TP_PAV_3K02.Modulos
{
    partial class Calificacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCodCal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPfechacal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCuit = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Calificacion :";
            // 
            // cmbCodCal
            // 
            this.cmbCodCal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodCal.FormattingEnabled = true;
            this.cmbCodCal.Location = new System.Drawing.Point(101, 55);
            this.cmbCodCal.Name = "cmbCodCal";
            this.cmbCodCal.Size = new System.Drawing.Size(97, 21);
            this.cmbCodCal.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Fecha de calificacion:";
            // 
            // DTPfechacal
            // 
            this.DTPfechacal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPfechacal.Location = new System.Drawing.Point(156, 98);
            this.DTPfechacal.MaxDate = new System.DateTime(2019, 10, 4, 19, 0, 53, 0);
            this.DTPfechacal.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.DTPfechacal.Name = "DTPfechacal";
            this.DTPfechacal.Size = new System.Drawing.Size(200, 20);
            this.DTPfechacal.TabIndex = 42;
            this.DTPfechacal.Value = new System.DateTime(2019, 10, 3, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Cuit:";
            // 
            // TxtCuit
            // 
            this.TxtCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCuit.Location = new System.Drawing.Point(60, 18);
            this.TxtCuit.MaxLength = 14;
            this.TxtCuit.Name = "TxtCuit";
            this.TxtCuit.ReadOnly = true;
            this.TxtCuit.Size = new System.Drawing.Size(200, 20);
            this.TxtCuit.TabIndex = 44;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(143, 151);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 35);
            this.btnAceptar.TabIndex = 45;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(261, 151);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(95, 35);
            this.BtnCancelar.TabIndex = 46;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Calificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 234);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.TxtCuit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTPfechacal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCodCal);
            this.Name = "Calificacion";
            this.Text = "Calificacion";
            this.Load += new System.EventHandler(this.Calificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCodCal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPfechacal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCuit;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}