namespace TP_PAV_3K02.Modulos
{
    partial class PresTipoDoc
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.dgvTipoDoc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new TP_PAV_3K02.DataSet1();
            this.tipoDocumentoTableAdapter1 = new TP_PAV_3K02.DataSet1TableAdapters.TipoDocumentoTableAdapter();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKSuscriptoresTipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suscriptoresTableAdapter = new TP_PAV_3K02.DataSet1TableAdapters.SuscriptoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSuscriptoresTipoDocumentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(43, 354);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 36);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(43, 293);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCan
            // 
            this.btnCan.Location = new System.Drawing.Point(202, 354);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(90, 36);
            this.btnCan.TabIndex = 3;
            this.btnCan.Text = "Cancelar";
            this.btnCan.UseVisualStyleBackColor = true;
            // 
            // dgvTipoDoc
            // 
            this.dgvTipoDoc.AutoGenerateColumns = false;
            this.dgvTipoDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvTipoDoc.DataSource = this.bindingSource2;
            this.dgvTipoDoc.Location = new System.Drawing.Point(43, 212);
            this.dgvTipoDoc.Name = "dgvTipoDoc";
            this.dgvTipoDoc.Size = new System.Drawing.Size(249, 50);
            this.dgvTipoDoc.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_TipoDoc";
            this.dataGridViewTextBoxColumn1.HeaderText = "cod_TipoDoc";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "TipoDocumento";
            this.bindingSource1.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoDocumentoTableAdapter1
            // 
            this.tipoDocumentoTableAdapter1.ClearBeforeFill = true;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(46, 84);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(249, 20);
            this.txtNom.TabIndex = 5;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(46, 153);
            this.txtNum.Mask = "99";
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(249, 20);
            this.txtNum.TabIndex = 6;
            this.txtNum.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nro de tipo de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo de Documento";
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "TipoDocumento";
            this.bindingSource2.DataSource = this.dataSet11;
            // 
            // fKSuscriptoresTipoDocumentoBindingSource
            // 
            this.fKSuscriptoresTipoDocumentoBindingSource.DataMember = "FK_Suscriptores_TipoDocumento";
            this.fKSuscriptoresTipoDocumentoBindingSource.DataSource = this.bindingSource1;
            // 
            // suscriptoresTableAdapter
            // 
            this.suscriptoresTableAdapter.ClearBeforeFill = true;
            // 
            // PresTipoDoc
            // 
            this.ClientSize = new System.Drawing.Size(349, 406);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dgvTipoDoc);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Name = "PresTipoDoc";
            this.Load += new System.EventHandler(this.PresTipoDoc_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSuscriptoresTipoDocumentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFormRepartidores;
        private System.Windows.Forms.DataGridView DvgSuscriptores;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblsuscriptores;
        private EmpleadosDataSet empleadosDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private EmpleadosDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private DataSet1TableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTipoDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.DataGridView dgvTipoDoc;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSet1TableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.MaskedTextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource fKSuscriptoresTipoDocumentoBindingSource;
        private DataSet1TableAdapters.SuscriptoresTableAdapter suscriptoresTableAdapter;
    }
}