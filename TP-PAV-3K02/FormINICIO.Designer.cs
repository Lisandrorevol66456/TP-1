﻿namespace TP_PAV_3K02
{
    partial class FormINICIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormINICIO));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnRevista = new System.Windows.Forms.Button();
            this.btnDist = new System.Windows.Forms.Button();
            this.btnSuscriptores = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suscriptoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 369);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(687, 324);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(149, 40);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "Salir";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnRevista
            // 
            this.btnRevista.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRevista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevista.Location = new System.Drawing.Point(687, 236);
            this.btnRevista.Name = "btnRevista";
            this.btnRevista.Size = new System.Drawing.Size(149, 52);
            this.btnRevista.TabIndex = 8;
            this.btnRevista.Text = "Revistas";
            this.btnRevista.UseVisualStyleBackColor = false;
            this.btnRevista.Click += new System.EventHandler(this.btnRevista_Click);
            // 
            // btnDist
            // 
            this.btnDist.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDist.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDist.Location = new System.Drawing.Point(687, 162);
            this.btnDist.Name = "btnDist";
            this.btnDist.Size = new System.Drawing.Size(149, 52);
            this.btnDist.TabIndex = 7;
            this.btnDist.Text = "Distribuidores";
            this.btnDist.UseVisualStyleBackColor = false;
            this.btnDist.Click += new System.EventHandler(this.btnDist_Click);
            // 
            // btnSuscriptores
            // 
            this.btnSuscriptores.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSuscriptores.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuscriptores.Location = new System.Drawing.Point(687, 94);
            this.btnSuscriptores.Name = "btnSuscriptores";
            this.btnSuscriptores.Size = new System.Drawing.Size(149, 52);
            this.btnSuscriptores.TabIndex = 6;
            this.btnSuscriptores.Text = "Suscriptores";
            this.btnSuscriptores.UseVisualStyleBackColor = false;
            this.btnSuscriptores.Click += new System.EventHandler(this.btnSuscriptores_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmpresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.Location = new System.Drawing.Point(687, 27);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(149, 52);
            this.btnEmpresa.TabIndex = 5;
            this.btnEmpresa.Text = "Empresas";
            this.btnEmpresa.UseVisualStyleBackColor = false;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suscriptoresToolStripMenuItem,
            this.empresasToolStripMenuItem,
            this.revistasToolStripMenuItem,
            this.distribuidoresToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "&Reportes";
            // 
            // suscriptoresToolStripMenuItem
            // 
            this.suscriptoresToolStripMenuItem.Name = "suscriptoresToolStripMenuItem";
            this.suscriptoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.suscriptoresToolStripMenuItem.Text = "&Suscriptores";
            this.suscriptoresToolStripMenuItem.Click += new System.EventHandler(this.suscriptoresToolStripMenuItem_Click);
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empresasToolStripMenuItem.Text = "&Empresas";
            this.empresasToolStripMenuItem.Click += new System.EventHandler(this.empresasToolStripMenuItem_Click);
            // 
            // revistasToolStripMenuItem
            // 
            this.revistasToolStripMenuItem.Name = "revistasToolStripMenuItem";
            this.revistasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revistasToolStripMenuItem.Text = "&Revistas";
            this.revistasToolStripMenuItem.Click += new System.EventHandler(this.revistasToolStripMenuItem_Click);
            // 
            // distribuidoresToolStripMenuItem
            // 
            this.distribuidoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distribucionesToolStripMenuItem});
            this.distribuidoresToolStripMenuItem.Name = "distribuidoresToolStripMenuItem";
            this.distribuidoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.distribuidoresToolStripMenuItem.Text = "&Distribuidores";
            this.distribuidoresToolStripMenuItem.Click += new System.EventHandler(this.distribuidoresToolStripMenuItem_Click);
            // 
            // distribucionesToolStripMenuItem
            // 
            this.distribucionesToolStripMenuItem.Name = "distribucionesToolStripMenuItem";
            this.distribucionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.distribucionesToolStripMenuItem.Text = "&Distribuciones";
            this.distribucionesToolStripMenuItem.Click += new System.EventHandler(this.distribucionesToolStripMenuItem_Click);
            // 
            // FormINICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(856, 395);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnRevista);
            this.Controls.Add(this.btnDist);
            this.Controls.Add(this.btnSuscriptores);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormINICIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido a Editorial El Pórfido";
            this.Load += new System.EventHandler(this.FormINICIO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnRevista;
        private System.Windows.Forms.Button btnDist;
        private System.Windows.Forms.Button btnSuscriptores;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suscriptoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribuidoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribucionesToolStripMenuItem;
    }
}