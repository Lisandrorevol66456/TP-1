using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K02.Modelos;
using TP_PAV_3K02.Repositorios;
using TP_PAV_3K02.Utils;

namespace TP_PAV_3K02.Modulos
{
    public partial class EditarDistribucion : Form
    {
        ValidateTextBox v;
        Distribucion dist;
        DistribucionesRepositorio _distribRepos;
        RevistasRepositorio _revistaRepo;
        public EditarDistribucion()
        {
            InitializeComponent();
        }
        public EditarDistribucion( string cuit, string id_dist)
        {
            InitializeComponent();
            _distribRepos = new DistribucionesRepositorio();
            _revistaRepo = new RevistasRepositorio();
            v = new ValidateTextBox();
            dist = _distribRepos.ObtenerPorID(id_dist);

        }

        private void EditarDistribucion_Load(object sender, EventArgs e)
        {
            TXTCUIT.Text = dist.Cuit_dist.ToString();
            CargarRevistas();
            TxtidDistribucion.Text = dist.id.ToString();
            TXTpagados.Text = dist.nro_ejemplares_pagos.ToString();
            TXTtotal.Text = dist.nro_ejemplares.ToString();
           
        }
        private void CargarRevistas()
        {
            var revista = _revistaRepo.ObtenerRevistasDT();
            CMB_revistas.ValueMember = "cod_Interno";
            CMB_revistas.DisplayMember = "nombre";
            CMB_revistas.DataSource = revista;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var distribucion1 = new Distribucion();
            distribucion1.id = int.Parse(TxtidDistribucion.Text);
            distribucion1.nro_ejemplares = long.Parse(TXTtotal.Text);
            distribucion1.nro_ejemplares_pagos = long.Parse(TXTpagados.Text);
            distribucion1.Cod_Interno = int.Parse(CMB_revistas.SelectedValue.ToString());
            distribucion1.Cuit_dist = long.Parse(TXTCUIT.Text);
            distribucion1.fecha_Entrega = DTPfechaEntrega.Value;

            if (!distribucion1.fechavalida())
            {
                MessageBox.Show("La fecha que ingreso no es valido");
                return;
            }
            if (_distribRepos.Editar(distribucion1, dist.id.ToString()))
            {
                MessageBox.Show("Se actualizo con Exito");
                this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void validarNumero(object sender, KeyPressEventArgs e)
        {
            v.ValidateSoloNumeros(sender, e);
        }
    }
}
