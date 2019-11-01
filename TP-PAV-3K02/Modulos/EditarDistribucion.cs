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
        public EditarDistribucion()
        {
            InitializeComponent();
        }
        public EditarDistribucion( string cuit, string id_dist)
        {
            InitializeComponent();
            _distribRepos = new DistribucionesRepositorio();
            v = new ValidateTextBox();
            dist = _distribRepos.ObtenerPorID(id_dist);

        }

        private void EditarDistribucion_Load(object sender, EventArgs e)
        {
            TXTCUIT.Text = dist.Cuit_dist.ToString();
            TXTCod_Int.Text = dist.Cod_Interno.ToString();
            TxtidDistribucion.Text = dist.id.ToString();
            TXTpagados.Text = dist.nro_ejemplares_pagos.ToString();
            TXTtotal.Text = dist.nro_ejemplares.ToString();
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var distribucion = new Distribucion();
            distribucion.id = int.Parse(TxtidDistribucion.ToString());
            distribucion.nro_ejemplares = long.Parse(TXTtotal.ToString());
            distribucion.nro_ejemplares_pagos = long.Parse(TXTpagados.ToString());
            distribucion.Cod_Interno = int.Parse(TXTCod_Int.ToString());
            distribucion.Cuit_dist = long.Parse(TXTCUIT.ToString());
            distribucion.fecha_Entrega = DTPfechaEntrega.Value;

            if (!distribucion.fechavalida())
            {
                MessageBox.Show("La fecha que ingreso no es valido");
                return;
            }
            if (_distribRepos.Editar(distribucion, TxtidDistribucion.ToString()))
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
