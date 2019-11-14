namespace TP_PAV_3K02.Modulos
{
    partial class Form_Editarsuscripcion
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
            this.label4 = new System.Windows.Forms.Label();
            this.DTPfechainicio = new System.Windows.Forms.DateTimePicker();
            this.cmbPlanes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTcodint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(27, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Feca desde";
            // 
            // DTPfechainicio
            // 
            this.DTPfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPfechainicio.Location = new System.Drawing.Point(96, 137);
            this.DTPfechainicio.Name = "DTPfechainicio";
            this.DTPfechainicio.Size = new System.Drawing.Size(101, 20);
            this.DTPfechainicio.TabIndex = 31;
            this.DTPfechainicio.Value = new System.DateTime(2019, 11, 13, 23, 51, 57, 0);
            // 
            // cmbPlanes
            // 
            this.cmbPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanes.FormattingEnabled = true;
            this.cmbPlanes.Items.AddRange(new object[] {
            "Plan Simple",
            "Plan Medio",
            "Plan Premium"});
            this.cmbPlanes.Location = new System.Drawing.Point(96, 109);
            this.cmbPlanes.Name = "cmbPlanes";
            this.cmbPlanes.Size = new System.Drawing.Size(101, 21);
            this.cmbPlanes.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(51, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Planes";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(179, 227);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 40);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tnAdd
            // 
            this.tnAdd.Location = new System.Drawing.Point(75, 227);
            this.tnAdd.Name = "tnAdd";
            this.tnAdd.Size = new System.Drawing.Size(78, 40);
            this.tnAdd.TabIndex = 42;
            this.tnAdd.Text = "Aceptar";
            this.tnAdd.UseVisualStyleBackColor = true;
            this.tnAdd.Click += new System.EventHandler(this.tnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(15, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Codigo interno";
            // 
            // TXTcodint
            // 
            this.TXTcodint.Location = new System.Drawing.Point(96, 81);
            this.TXTcodint.Name = "TXTcodint";
            this.TXTcodint.ReadOnly = true;
            this.TXTcodint.Size = new System.Drawing.Size(101, 20);
            this.TXTcodint.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Editar Suscripcion";
            // 
            // Form_Editarsuscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 284);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTcodint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTPfechainicio);
            this.Controls.Add(this.cmbPlanes);
            this.Controls.Add(this.label2);
            this.Name = "Form_Editarsuscripcion";
            this.Text = "Form_Editarsuscripcion";
            this.Load += new System.EventHandler(this.Form_Editarsuscripcion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTPfechainicio;
        private System.Windows.Forms.ComboBox cmbPlanes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button tnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTcodint;
        private System.Windows.Forms.Label label3;
    }
}