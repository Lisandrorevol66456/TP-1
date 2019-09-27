namespace TP_PAV_3K02.Modelos
{
    partial class PresProvincia
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.MaskedTextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.dgvProvincia = new System.Windows.Forms.DataGridView();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataSet1 = new TP_PAV_3K02.DataSet1();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinciasTableAdapter = new TP_PAV_3K02.DataSet1TableAdapters.ProvinciasTableAdapter();
            this.codprovinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Provincia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(46, 153);
            this.txtNum.Mask = "99";
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(249, 20);
            this.txtNum.TabIndex = 15;
            this.txtNum.ValidatingType = typeof(int);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(46, 84);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(249, 20);
            this.txtNom.TabIndex = 14;
            // 
            // dgvProvincia
            // 
            this.dgvProvincia.AutoGenerateColumns = false;
            this.dgvProvincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvincia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codprovinciaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.codPaisDataGridViewTextBoxColumn});
            this.dgvProvincia.DataSource = this.provinciasBindingSource;
            this.dgvProvincia.Location = new System.Drawing.Point(43, 213);
            this.dgvProvincia.Name = "dgvProvincia";
            this.dgvProvincia.Size = new System.Drawing.Size(249, 65);
            this.dgvProvincia.TabIndex = 13;
            // 
            // btnCan
            // 
            this.btnCan.Location = new System.Drawing.Point(202, 354);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(90, 36);
            this.btnCan.TabIndex = 12;
            this.btnCan.Text = "Cancelar";
            this.btnCan.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(43, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 36);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(43, 354);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 36);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "Provincias";
            this.provinciasBindingSource.DataSource = this.dataSet1;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // codprovinciaDataGridViewTextBoxColumn
            // 
            this.codprovinciaDataGridViewTextBoxColumn.DataPropertyName = "cod_provincia";
            this.codprovinciaDataGridViewTextBoxColumn.HeaderText = "cod_provincia";
            this.codprovinciaDataGridViewTextBoxColumn.Name = "codprovinciaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // codPaisDataGridViewTextBoxColumn
            // 
            this.codPaisDataGridViewTextBoxColumn.DataPropertyName = "cod_Pais";
            this.codPaisDataGridViewTextBoxColumn.HeaderText = "cod_Pais";
            this.codPaisDataGridViewTextBoxColumn.Name = "codPaisDataGridViewTextBoxColumn";
            // 
            // PresProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dgvProvincia);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Name = "PresProvincia";
            this.Text = "PresProvincia";
            this.Load += new System.EventHandler(this.PresProvincia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtNum;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DataGridView dgvProvincia;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private DataSet1TableAdapters.ProvinciasTableAdapter provinciasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprovinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPaisDataGridViewTextBoxColumn;
    }
}