using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K02.BaseDatos;
using TP_PAV_3K02.Modelos;
using TP_PAV_3K02.Repositorios;
using TP_PAV_3K02.Utils;

namespace TP_PAV_3K02.Modulos
{
    public partial class Distribuciones : Form
    {
        DistribuidoresRepositorio _distribuidoresRepositorio;
        DistribucionesRepositorio _distribucionesRepositorio;
        Editorial_BD _BD;
        Distribuidor distribuidor;
        Distribucion distribucion;
        ValidateTextBox v;

        public Distribuciones()
        {
            InitializeComponent();
        }
        public Distribuciones(string distribuidorCuit)
        {
            InitializeComponent();
            _distribuidoresRepositorio = new DistribuidoresRepositorio();
            _distribucionesRepositorio = new DistribucionesRepositorio();
            v = new ValidateTextBox();
            _BD = new Editorial_BD();
            distribuidor = _distribuidoresRepositorio.ObtenerDistribuidor(distribuidorCuit);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var distribucion = new Distribucion();
            distribucion.Cod_Interno = int.Parse(TXTCod_Int.Text);
            distribucion.nro_ejemplares = long.Parse(TXTtotal.Text);
            distribucion.nro_ejemplares_pagos = long.Parse(TXTpagados.Text);
            distribucion.fecha_Entrega = DTPfechaEntrega.Value;


            if (!distribucion.CuitValido(TXTCUIT.Text.ToString()))
            {
                MessageBox.Show("El CUIT que ingreso no es valido");
                return;
            }
            distribucion.Cuit_dist = long.Parse(TXTCUIT.Text);
            if (!distribucion.fechavalida())
            {
                MessageBox.Show("La fecha ingresada no es valida");
                return;
            }

            // valida que el codigo interno exista en la tabla revistas
            if (!_distribucionesRepositorio.ValidarCod(TXTCod_Int.Text.ToString()))
            { // y que no este repetido sino daria error por primary key
                if (!_distribucionesRepositorio.ValidarCod_duplicado(TXTCod_Int.Text.ToString(), TXTCUIT.Text.ToString()))
                {
                    if (_distribucionesRepositorio.Guardar(distribucion))
                    {
                        MessageBox.Show("Se registró distribución con Exito");
                        ActualizarDistribuciones(distribucion.Cuit_dist);
                        LimpiarCampos();
                    }
                }
                else
                    MessageBox.Show($"Ya existe una distribucion con el Codigo = {TXTCod_Int.Text}");
            }
            else
                MessageBox.Show($"El Codigo = {TXTCod_Int.Text} no existe");

        }

        private void Distribuciones_Load(object sender, EventArgs e)
        {
            TXTCUIT.Text = distribuidor.cuit_dist.ToString(); //carga el form con el cuit del distribuidor al que se le asigna una distribucion
            ActualizarDistribuciones(distribuidor.cuit_dist); //actualiza el grid con las distribuciones de ese distribuidor
            LimpiarCampos();
        }
        private void ActualizarDistribuciones(long TXTCUIT)
        {
            DGV_Distribuciones.Rows.Clear();
            var cuit = distribuidor.cuit_dist;
            var distros = _distribucionesRepositorio.ObtenerPorcuit(cuit).Rows;
            var filas = new List<DataGridViewRow>();

            foreach (DataRow distribucion in distros)
            {
                if (distribucion.HasErrors)
                    continue;

                var fila = new string[]
                {
                    distribucion.ItemArray[0].ToString(),
                    distribucion.ItemArray[1].ToString(),
                    distribucion.ItemArray[2].ToString(),
                    distribucion.ItemArray[3].ToString(),
                    distribucion.ItemArray[4].ToString(),

                };

                DGV_Distribuciones.Rows.Add(fila);

            }
            
        }
        private void LimpiarCampos()
        {
            TXTCod_Int.Clear();
            TXTpagados.Clear();
            TXTtotal.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActualizarDistribuciones(distribucion.Cuit_dist);
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var seleccionadas = DGV_Distribuciones.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccionadas)
            {
                var cod_int = fila.Cells[1].Value;
                var cuit_dist = fila.Cells[0].Value;


                //pregunto confirmación
                if (cuit_dist != null)
                {
                    var confirmacion = MessageBox.Show($"Esta seguro que desea eliminar la distribucion {cod_int}, {cuit_dist}?",
                   "Confirmar operación",
                   MessageBoxButtons.YesNo);

                    if (confirmacion.Equals(DialogResult.No))
                        return;

                    if (_distribucionesRepositorio.Eliminar(cuit_dist.ToString()))
                    {
                        MessageBox.Show("Se eliminó exitosamente");
                        ActualizarDistribuciones(distribucion.Cuit_dist);

                    }

                }

                if (cuit_dist == null)
                    MessageBox.Show("Debe Seleccionar una fila no Vacia......");

            }
        }
    }
}
