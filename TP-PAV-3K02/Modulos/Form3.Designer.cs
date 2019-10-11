namespace TP_PAV_3K02.Modulos
{
    partial class Suscripciones
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
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.txtCodInt = new System.Windows.Forms.TextBox();
            this.dgvSuscripciones = new System.Windows.Forms.DataGridView();
            this.nrodocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTipoDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suscripcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TP_PAV_3K02.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.suscripcionTableAdapter = new TP_PAV_3K02.DataSet1TableAdapters.SuscripcionTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuscripciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suscripcionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(144, 78);
            this.txtDoc.MaxLength = 18;
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(163, 20);
            this.txtDoc.TabIndex = 0;
            this.txtDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateSoloNumeros);
            // 
            // txtCodInt
            // 
            this.txtCodInt.Location = new System.Drawing.Point(144, 247);
            this.txtCodInt.MaxLength = 18;
            this.txtCodInt.Name = "txtCodInt";
            this.txtCodInt.Size = new System.Drawing.Size(163, 20);
            this.txtCodInt.TabIndex = 1;
            this.txtCodInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateSoloNumeros);
            // 
            // dgvSuscripciones
            // 
            this.dgvSuscripciones.AutoGenerateColumns = false;
            this.dgvSuscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrodocDataGridViewTextBoxColumn,
            this.codTipoDocDataGridViewTextBoxColumn,
            this.codintDataGridViewTextBoxColumn,
            this.fechainicioDataGridViewTextBoxColumn,
            this.fechafinDataGridViewTextBoxColumn,
            this.docplanDataGridViewTextBoxColumn});
            this.dgvSuscripciones.DataSource = this.suscripcionBindingSource;
            this.dgvSuscripciones.Location = new System.Drawing.Point(379, 78);
            this.dgvSuscripciones.Name = "dgvSuscripciones";
            this.dgvSuscripciones.Size = new System.Drawing.Size(704, 268);
            this.dgvSuscripciones.TabIndex = 3;
            // 
            // nrodocDataGridViewTextBoxColumn
            // 
            this.nrodocDataGridViewTextBoxColumn.DataPropertyName = "nro_doc";
            this.nrodocDataGridViewTextBoxColumn.HeaderText = "nro_doc";
            this.nrodocDataGridViewTextBoxColumn.Name = "nrodocDataGridViewTextBoxColumn";
            // 
            // codTipoDocDataGridViewTextBoxColumn
            // 
            this.codTipoDocDataGridViewTextBoxColumn.DataPropertyName = "cod_TipoDoc";
            this.codTipoDocDataGridViewTextBoxColumn.HeaderText = "cod_TipoDoc";
            this.codTipoDocDataGridViewTextBoxColumn.Name = "codTipoDocDataGridViewTextBoxColumn";
            // 
            // codintDataGridViewTextBoxColumn
            // 
            this.codintDataGridViewTextBoxColumn.DataPropertyName = "cod_int";
            this.codintDataGridViewTextBoxColumn.HeaderText = "cod_int";
            this.codintDataGridViewTextBoxColumn.Name = "codintDataGridViewTextBoxColumn";
            // 
            // fechainicioDataGridViewTextBoxColumn
            // 
            this.fechainicioDataGridViewTextBoxColumn.DataPropertyName = "fecha_inicio";
            this.fechainicioDataGridViewTextBoxColumn.HeaderText = "fecha_inicio";
            this.fechainicioDataGridViewTextBoxColumn.Name = "fechainicioDataGridViewTextBoxColumn";
            // 
            // fechafinDataGridViewTextBoxColumn
            // 
            this.fechafinDataGridViewTextBoxColumn.DataPropertyName = "fecha_fin";
            this.fechafinDataGridViewTextBoxColumn.HeaderText = "fecha_fin";
            this.fechafinDataGridViewTextBoxColumn.Name = "fechafinDataGridViewTextBoxColumn";
            // 
            // docplanDataGridViewTextBoxColumn
            // 
            this.docplanDataGridViewTextBoxColumn.DataPropertyName = "doc_plan";
            this.docplanDataGridViewTextBoxColumn.HeaderText = "doc_plan";
            this.docplanDataGridViewTextBoxColumn.Name = "docplanDataGridViewTextBoxColumn";
            // 
            // suscripcionBindingSource
            // 
            this.suscripcionBindingSource.DataMember = "Suscripcion";
            this.suscripcionBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Suscripciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nº Documento :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo de Documento :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Codigo Int :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 398);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(690, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(796, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(983, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbTipoDoc.Items.AddRange(new object[] {
            "D.N.I.",
            "L.E."});
            this.cmbTipoDoc.Location = new System.Drawing.Point(144, 161);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(163, 21);
            this.cmbTipoDoc.TabIndex = 18;
            // 
            // suscripcionTableAdapter
            // 
            this.suscripcionTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "Plan Low",
            "Plan Medium",
            "Plan High"});
            this.comboBox1.Location = new System.Drawing.Point(144, 325);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tipo de Documento :";
            // 
            // Suscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSuscripciones);
            this.Controls.Add(this.txtCodInt);
            this.Controls.Add(this.txtDoc);
            this.Name = "Suscripciones";
            this.Text = "Suscripciones";
            this.Load += new System.EventHandler(this.Suscripciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuscripciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suscripcionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.TextBox txtCodInt;
        private System.Windows.Forms.DataGridView dgvSuscripciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource suscripcionBindingSource;
        private DataSet1TableAdapters.SuscripcionTableAdapter suscripcionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrodocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTipoDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}