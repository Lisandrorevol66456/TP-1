namespace TP_PAV_3K02
{
    partial class Menu
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
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnSuscriptores = new System.Windows.Forms.Button();
            this.btnDist = new System.Windows.Forms.Button();
            this.btnRevista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(13, 49);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(433, 52);
            this.btnEmpresa.TabIndex = 0;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnSuscriptores
            // 
            this.btnSuscriptores.Location = new System.Drawing.Point(13, 148);
            this.btnSuscriptores.Name = "btnSuscriptores";
            this.btnSuscriptores.Size = new System.Drawing.Size(433, 52);
            this.btnSuscriptores.TabIndex = 1;
            this.btnSuscriptores.Text = "Suscriptores";
            this.btnSuscriptores.UseVisualStyleBackColor = true;
            this.btnSuscriptores.Click += new System.EventHandler(this.btnSuscriptores_Click);
            // 
            // btnDist
            // 
            this.btnDist.Location = new System.Drawing.Point(13, 246);
            this.btnDist.Name = "btnDist";
            this.btnDist.Size = new System.Drawing.Size(433, 52);
            this.btnDist.TabIndex = 2;
            this.btnDist.Text = "Distribuidores";
            this.btnDist.UseVisualStyleBackColor = true;
            this.btnDist.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRevista
            // 
            this.btnRevista.Location = new System.Drawing.Point(13, 341);
            this.btnRevista.Name = "btnRevista";
            this.btnRevista.Size = new System.Drawing.Size(433, 52);
            this.btnRevista.TabIndex = 3;
            this.btnRevista.Text = "Revistas";
            this.btnRevista.UseVisualStyleBackColor = true;
            this.btnRevista.Click += new System.EventHandler(this.btnRevista_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.btnRevista);
            this.Controls.Add(this.btnDist);
            this.Controls.Add(this.btnSuscriptores);
            this.Controls.Add(this.btnEmpresa);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnSuscriptores;
        private System.Windows.Forms.Button btnDist;
        private System.Windows.Forms.Button btnRevista;
    }
}