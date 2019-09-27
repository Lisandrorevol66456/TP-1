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

namespace TP_PAV_3K02
{
    public partial class FormDistribuidores : Form
    {
        DistribuidoresRepositorio _distribuidoresRepositorio;
        public FormDistribuidores()
        {
            InitializeComponent();
            _distribuidoresRepositorio = new DistribuidoresRepositorio();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var distribuidor = new Distribuidor();
            distribuidor.nombre = txtnombre.Text;
            distribuidor.apellido = txtApellido.Text;
            distribuidor.cuit_dist = long.Parse(TxtCuit.Text); // Se debe modificar la base de datos, ya que cuit esta creado como INT,
                                                               //cuando debe ser numerico.
            distribuidor.domicilio = TxtDomicilio.Text;
            distribuidor.fecha_inicio = DTPfechainicio.Value.Date;

            if (!distribuidor.NombreValido())
            {
                MessageBox.Show("Nombre Invalido");
                txtnombre.Focus();
                return;
            }

            if (!distribuidor.ApellidoValido())
            {
                MessageBox.Show("Apellido Invalido");
                txtApellido.Focus();
                return;
            }

            if (!distribuidor.CuitValido())
            {
                MessageBox.Show("Cuit Invalido");
                TxtCuit.Focus();
                return;
            }
            if (!distribuidor.domicilioValido())
            {
                MessageBox.Show("Domicilio Invalido");
                TxtDomicilio.Focus();
                return;
            }
            if (!distribuidor.fechavalida())
            {
                MessageBox.Show("Fecha de inicio invalida");
                DTPfechainicio.Focus();
                return;
            }
            if (_distribuidoresRepositorio.Guardar(distribuidor))
            {
                MessageBox.Show("Se registro con éxito");
                this.Dispose();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var seleccionadas = DvgDistribuidores.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccionadas)
            {
                var nombre = fila.Cells[2].Value;
                var apellido = fila.Cells[3].Value;
                var cuit_dist = fila.Cells[0].Value;


                //pregunto confirmación
                if (cuit_dist != null)
                {
                    var confirmacion = MessageBox.Show($"Esta seguro que desea eliminar a {nombre}, {apellido}, {cuit_dist}?",
                   "Confirmar operación",
                   MessageBoxButtons.YesNo);

                    if (confirmacion.Equals(DialogResult.No))
                        return;

                    if (_distribuidoresRepositorio.Eliminar(cuit_dist.ToString()))
                    {
                        MessageBox.Show("Se eliminó exitosamente");
                        ActualizarDistribuidores();

                    }

                }

                if(cuit_dist == null)
                    MessageBox.Show("Debe Seleccionar una fila no Vacia......");
                
            }
        }

        private void ActualizarDistribuidores()
        {
            DvgDistribuidores.Rows.Clear();

            var distribuidores = _distribuidoresRepositorio.ObtenerDistribuidoresDT().Rows;
            var filas = new List<DataGridViewRow>();

            foreach (DataRow distribuidor in distribuidores)
            {
                if (distribuidor.HasErrors)
                    continue;

                var fila = new string[]
                {
                    distribuidor.ItemArray[0].ToString(),
                    distribuidor.ItemArray[1].ToString(),
                    distribuidor.ItemArray[2].ToString(),
                    distribuidor.ItemArray[3].ToString(),
                    distribuidor.ItemArray[4].ToString(),
                  
                };

                DvgDistribuidores.Rows.Add(fila);

            }


        }

        private void FormDistribuidores_Load(object sender, EventArgs e)
        {
            ActualizarDistribuidores();

        }

        private void DvgDistribuidores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DvgDistribuidores.Rows.Clear();
            var numcuit = long.Parse(TXTbuscarCUIT.Text);
            var distribuidores = _distribuidoresRepositorio.ObtenerPorcuit(numcuit).Rows;
            var filas = new List<DataGridViewRow>();

            foreach (DataRow distribuidor in distribuidores)
            {
                if (distribuidor.HasErrors)
                    continue;//no corto el ciclo
                var fila = new string[]
                {
                    distribuidor.ItemArray[0].ToString(),
                    distribuidor.ItemArray[1].ToString(),
                    distribuidor.ItemArray[2].ToString(),
                    distribuidor.ItemArray[3].ToString(),
                    distribuidor.ItemArray[4].ToString(),
                    distribuidor.ItemArray[5].ToString(),
                    distribuidor.ItemArray[6].ToString(),
                    distribuidor.ItemArray[7].ToString(),
                    distribuidor.ItemArray[8].ToString(),
                };

                DvgDistribuidores.Rows.Add(fila);

            }
        }
    }
    }

