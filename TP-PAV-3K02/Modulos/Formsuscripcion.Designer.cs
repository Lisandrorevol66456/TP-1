﻿namespace TP_PAV_3K02.Modulos
{
    partial class Formsuscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formsuscripcion));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.cmbPlanes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSuscripciones = new System.Windows.Forms.DataGridView();
            this.DTPfechainicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CMB_Revista = new System.Windows.Forms.ComboBox();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREPLAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(754, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 40);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(754, 399);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 25);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tnAdd
            // 
            this.tnAdd.Location = new System.Drawing.Point(754, 178);
            this.tnAdd.Name = "tnAdd";
            this.tnAdd.Size = new System.Drawing.Size(78, 40);
            this.tnAdd.TabIndex = 23;
            this.tnAdd.Text = "Agregar";
            this.tnAdd.UseVisualStyleBackColor = true;
            this.tnAdd.Click += new System.EventHandler(this.tnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(754, 234);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 40);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(162, 77);
            this.txtDoc.MaxLength = 8;
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.ReadOnly = true;
            this.txtDoc.Size = new System.Drawing.Size(131, 20);
            this.txtDoc.TabIndex = 21;
            // 
            // cmbPlanes
            // 
            this.cmbPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanes.FormattingEnabled = true;
            this.cmbPlanes.Items.AddRange(new object[] {
            "Plan Simple",
            "Plan Medio",
            "Plan Premium"});
            this.cmbPlanes.Location = new System.Drawing.Point(343, 109);
            this.cmbPlanes.Name = "cmbPlanes";
            this.cmbPlanes.Size = new System.Drawing.Size(131, 21);
            this.cmbPlanes.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(39, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Número de Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(309, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Plan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Suscripciones";
            // 
            // dgvSuscripciones
            // 
            this.dgvSuscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column2,
            this.Column1,
            this.Revista,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.NOMBREPLAN});
            this.dgvSuscripciones.Location = new System.Drawing.Point(12, 178);
            this.dgvSuscripciones.Name = "dgvSuscripciones";
            this.dgvSuscripciones.Size = new System.Drawing.Size(727, 219);
            this.dgvSuscripciones.TabIndex = 14;
            // 
            // DTPfechainicio
            // 
            this.DTPfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPfechainicio.Location = new System.Drawing.Point(162, 135);
            this.DTPfechainicio.Name = "DTPfechainicio";
            this.DTPfechainicio.Size = new System.Drawing.Size(131, 20);
            this.DTPfechainicio.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(93, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Feca desde";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(664, 399);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Revista";
            // 
            // CMB_Revista
            // 
            this.CMB_Revista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Revista.FormattingEnabled = true;
            this.CMB_Revista.Location = new System.Drawing.Point(162, 109);
            this.CMB_Revista.Name = "CMB_Revista";
            this.CMB_Revista.Size = new System.Drawing.Size(131, 21);
            this.CMB_Revista.TabIndex = 42;
            // 
            // Column8
            // 
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "Codigo Interno";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TiPO documento";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero de Documento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Revista
            // 
            this.Revista.HeaderText = "Revista";
            this.Revista.Name = "Revista";
            this.Revista.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha de Inicio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha de Finalizacion";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Codigo de Plan";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Precio";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // NOMBREPLAN
            // 
            this.NOMBREPLAN.HeaderText = "NOMBRE PLAN";
            this.NOMBREPLAN.Name = "NOMBREPLAN";
            this.NOMBREPLAN.ReadOnly = true;
            // 
            // Formsuscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(844, 436);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CMB_Revista);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTPfechainicio);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.cmbPlanes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSuscripciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Formsuscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suscripciones";
            this.Load += new System.EventHandler(this.Formsuscripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuscripciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button tnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.ComboBox cmbPlanes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSuscripciones;
        private System.Windows.Forms.DateTimePicker DTPfechainicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CMB_Revista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREPLAN;
    }
}