namespace TP_PAV_3K02.Modulos
{
    partial class Publicidades
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
            this.CMB_empresa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CMB_Revista = new System.Windows.Forms.ComboBox();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.Desde = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CMB_monto = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.DGV_publicidades = new System.Windows.Forms.DataGridView();
            this.TXT_buscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BTN_filtrar = new System.Windows.Forms.Button();
            this.ID_publi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Revista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_publicidades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Publicidad";
            // 
            // CMB_empresa
            // 
            this.CMB_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_empresa.FormattingEnabled = true;
            this.CMB_empresa.Location = new System.Drawing.Point(31, 79);
            this.CMB_empresa.Name = "CMB_empresa";
            this.CMB_empresa.Size = new System.Drawing.Size(193, 21);
            this.CMB_empresa.TabIndex = 9;
            this.CMB_empresa.SelectedIndexChanged += new System.EventHandler(this.CMB_empresa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Revista";
            // 
            // CMB_Revista
            // 
            this.CMB_Revista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Revista.FormattingEnabled = true;
            this.CMB_Revista.Location = new System.Drawing.Point(33, 134);
            this.CMB_Revista.Name = "CMB_Revista";
            this.CMB_Revista.Size = new System.Drawing.Size(191, 21);
            this.CMB_Revista.TabIndex = 11;
            // 
            // dtp_desde
            // 
            this.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_desde.Location = new System.Drawing.Point(33, 49);
            this.dtp_desde.MaxDate = new System.DateTime(2019, 11, 15, 0, 0, 0, 0);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(111, 26);
            this.dtp_desde.TabIndex = 13;
            this.dtp_desde.Value = new System.DateTime(2019, 11, 15, 0, 0, 0, 0);
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desde.Location = new System.Drawing.Point(30, 20);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(49, 20);
            this.Desde.TabIndex = 14;
            this.Desde.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hasta";
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_hasta.Location = new System.Drawing.Point(33, 112);
            this.dtp_hasta.MaxDate = new System.DateTime(2019, 11, 15, 0, 0, 0, 0);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(111, 26);
            this.dtp_hasta.TabIndex = 15;
            this.dtp_hasta.Value = new System.DateTime(2019, 11, 15, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_desde);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Desde);
            this.groupBox1.Controls.Add(this.dtp_hasta);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(275, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 147);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vigencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Monto";
            // 
            // CMB_monto
            // 
            this.CMB_monto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_monto.FormattingEnabled = true;
            this.CMB_monto.Location = new System.Drawing.Point(33, 197);
            this.CMB_monto.Name = "CMB_monto";
            this.CMB_monto.Size = new System.Drawing.Size(191, 21);
            this.CMB_monto.TabIndex = 18;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(478, 156);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(159, 32);
            this.btnAceptar.TabIndex = 20;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.Location = new System.Drawing.Point(478, 199);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(159, 32);
            this.BTN_Cancelar.TabIndex = 21;
            this.BTN_Cancelar.Text = "&Cancelar";
            this.BTN_Cancelar.UseVisualStyleBackColor = true;
            // 
            // DGV_publicidades
            // 
            this.DGV_publicidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_publicidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_publi,
            this.Cuit_empresa,
            this.id_Revista,
            this.Fecha_desde,
            this.Fecha_hasta,
            this.Monto});
            this.DGV_publicidades.Location = new System.Drawing.Point(33, 342);
            this.DGV_publicidades.Name = "DGV_publicidades";
            this.DGV_publicidades.Size = new System.Drawing.Size(643, 231);
            this.DGV_publicidades.TabIndex = 22;
            // 
            // TXT_buscar
            // 
            this.TXT_buscar.Location = new System.Drawing.Point(478, 316);
            this.TXT_buscar.Name = "TXT_buscar";
            this.TXT_buscar.Size = new System.Drawing.Size(105, 20);
            this.TXT_buscar.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(675, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "__________________________________________________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(199, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(315, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Publicidades pactadas por la empresa";
            // 
            // BTN_filtrar
            // 
            this.BTN_filtrar.Location = new System.Drawing.Point(584, 316);
            this.BTN_filtrar.Name = "BTN_filtrar";
            this.BTN_filtrar.Size = new System.Drawing.Size(92, 20);
            this.BTN_filtrar.TabIndex = 27;
            this.BTN_filtrar.Text = "&Filtrar";
            this.BTN_filtrar.UseVisualStyleBackColor = true;
            // 
            // ID_publi
            // 
            this.ID_publi.Frozen = true;
            this.ID_publi.HeaderText = "ID publicidad";
            this.ID_publi.Name = "ID_publi";
            this.ID_publi.ReadOnly = true;
            // 
            // Cuit_empresa
            // 
            this.Cuit_empresa.Frozen = true;
            this.Cuit_empresa.HeaderText = "CUIT Empresa";
            this.Cuit_empresa.Name = "Cuit_empresa";
            this.Cuit_empresa.ReadOnly = true;
            // 
            // id_Revista
            // 
            this.id_Revista.Frozen = true;
            this.id_Revista.HeaderText = "Revista";
            this.id_Revista.Name = "id_Revista";
            this.id_Revista.ReadOnly = true;
            // 
            // Fecha_desde
            // 
            this.Fecha_desde.Frozen = true;
            this.Fecha_desde.HeaderText = "Desde";
            this.Fecha_desde.Name = "Fecha_desde";
            this.Fecha_desde.ReadOnly = true;
            // 
            // Fecha_hasta
            // 
            this.Fecha_hasta.Frozen = true;
            this.Fecha_hasta.HeaderText = "Hasta";
            this.Fecha_hasta.Name = "Fecha_hasta";
            this.Fecha_hasta.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.Frozen = true;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Publicidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(715, 600);
            this.Controls.Add(this.BTN_filtrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXT_buscar);
            this.Controls.Add(this.DGV_publicidades);
            this.Controls.Add(this.BTN_Cancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CMB_monto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CMB_Revista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMB_empresa);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Publicidad";
            this.Text = "Publicidad";
            this.Load += new System.EventHandler(this.Publicidad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_publicidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMB_empresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CMB_Revista;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CMB_monto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.DataGridView DGV_publicidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_publi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Revista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.TextBox TXT_buscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTN_filtrar;
    }
}