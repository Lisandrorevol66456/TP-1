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
using TP_PAV_3K02.Utils;
using TP_PAV_3K02.Repositorios;
using TP_PAV_3K02.Modelos;
using TP_PAV_3K02.REPORTES.rep_revista;

namespace TP_PAV_3K02.Modulos
{
    public partial class Revistas : Form
    {
        FrecuenciaPublicacionRepositorio _frecuenciaPublicacionRepositorio;
        RubrosRepositorio _rubrosRepositorio;
        RevistasRepositorio _revistasRepositorio;
        ValidateTextBox v;
        Editorial_BD _BD;


        public Revistas()
        {
            InitializeComponent();
            _BD = new Editorial_BD();
            v = new ValidateTextBox();
            _rubrosRepositorio = new RubrosRepositorio();
            _revistasRepositorio = new RevistasRepositorio();
            _frecuenciaPublicacionRepositorio = new FrecuenciaPublicacionRepositorio();

        }

        private void ActualizarFrecuenciaPublicacion()
        {
            var frecuencia_Publi = _frecuenciaPublicacionRepositorio.ObtenerFrecuenciaPublicacionDT();
            cmbFrecuencia.ValueMember = "cod_Frecuencia";
            cmbFrecuencia.DisplayMember = "nombre";
            cmbFrecuencia.DataSource = frecuencia_Publi;

        }

        private void ActualizarRubros()
        {
            var rubros = _rubrosRepositorio.ObtenerRubrosDT();
            cmbRubro.ValueMember = "cod_Rubro";
            cmbRubro.DisplayMember = "nombre";
            cmbRubro.DataSource = rubros;
        }

        private void ActualizarRevista()
        {
            dgvRevistas.Rows.Clear();
            var revistas = _revistasRepositorio.ObtenerRevistasDT().Rows;
            var filas = new List<DataGridView>();

            foreach( DataRow revista in revistas)
            {
                if (revista.HasErrors)
                    continue;
                var fila = new string[]
                {
                    revista.ItemArray[0].ToString(),
                    revista.ItemArray[1].ToString(),
                    revista.ItemArray[2].ToString(),
                    revista.ItemArray[3].ToString(),
                    revista.ItemArray[4].ToString(),
                    //revista.ItemArray[5].ToString(),
                };

                dgvRevistas.Rows.Add(fila);
            }
        }

        private void Revista_Load(object sender, EventArgs e)
        {
            ActualizarRevista();
            ActualizarFrecuenciaPublicacion();
            ActualizarRubros();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            var revista = new Revista();

            revista.nombre = txtnombre.Text;
            revista.cod_frecPublic = int.Parse(cmbFrecuencia.SelectedValue.ToString());
            revista.cod_rubro = int.Parse(cmbRubro.SelectedValue.ToString());
            revista.fechaInicio = dtpFechaInicio.Value.Date;


            if (!revista.NombreValido())
            {
                MessageBox.Show("Nombre Invalido");
                return;
            }

            /*if (!revista.CodValido(txtcodigoInterno.Text.ToString()))
            {
                MessageBox.Show("Codigo Interno Invalido");
                return;
            }

            revista.cod_Interno = int.Parse(txtcodigoInterno.Text);*/

            if (!revista.fechavalida())
            {
                MessageBox.Show("Fecha de inicio invalida");
                return;
            }

            //if (!_revistasRepositorio.ValidarCod(txtcodigoInterno.Text.ToString()))
            
            if (_revistasRepositorio.Guardar(revista))
                {
                    MessageBox.Show("Se Registro con Exito !!");
                    ActualizarRevista();
                    LimpiarCampos();
                }
            
            

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            
            LimpiarCampos();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            var seleccionadas = dgvRevistas.SelectedRows;

            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }

            foreach(DataGridViewRow fila in seleccionadas)
            {
                var cod = fila.Cells[0].Value;
                var nombre = fila.Cells[1].Value;
                var rubro = fila.Cells[3].Value;


                if(cod != null)
                {
                    var confirmacion = MessageBox.Show($"Esta seguro que desea eliminar a {cod},{nombre} ,{rubro}?",
                        "Confirmar Operacion",
                        MessageBoxButtons.YesNo);

                    if (confirmacion.Equals(DialogResult.No))
                        return;

                    if (_revistasRepositorio.Eliminar(cod.ToString()))
                    {
                        MessageBox.Show("Se eliminó exitosamente");
                        ActualizarRevista();

                    }
                }
                if (cod == null)
                    MessageBox.Show("Debe Seleccionar una fila que no este Vacia.....");


            }

        }

        public void LimpiarCampos()
        {
            txtnombre.Clear();
            txtcodigoInterno.Clear();
        }

        private void ValidarLetras(object sender, KeyPressEventArgs e)
        {
            v.validateSoloLetras(sender,e);
        }

        private void validarNum(object sender, KeyPressEventArgs e)
        {
            v.ValidateSoloNumeros(sender, e);
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var infor = new INFO_revistas();
            infor.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var rev = new Revista();
            if (rev.CodValido(txtCodigoBuscar.Text.ToString()))
            {
                dgvRevistas.Rows.Clear();
                var  codInt = int.Parse(txtCodigoBuscar.Text);
                var revistas = _revistasRepositorio.ObtenerPorCodigo(codInt).Rows;
                var filas = new List<DataGridViewRow>();

                foreach (DataRow revista in revistas)
                {
                    if (revista.HasErrors)
                        continue;//no corto el ciclo


                    var fila = new string[]
                    {
                            revista.ItemArray[0].ToString(),
                            revista.ItemArray[1].ToString(),
                            revista.ItemArray[2].ToString(),
                            revista.ItemArray[3].ToString(),
                            revista.ItemArray[4].ToString(),
                           


                    };

                    dgvRevistas.Rows.Add(fila);


                }

            }
        }

        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            txtCodigoBuscar.Clear();
            ActualizarRevista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var seleccionadas = dgvRevistas.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccionadas)
            {
                var nombre  = fila.Cells[1].Value;
                var cod = fila.Cells[0].Value;
                var frec =  fila.Cells[2].Value;
                var rub = fila.Cells[3].Value;
                var fecha = fila.Cells[4].Value;

                if (cod != null)
                {
                    //pregunto confirmación
                    var confirmacion = MessageBox.Show($"Desea editar a la Revista {nombre}, con cogido = {cod}?",
                    "Confirmar operación",
                    MessageBoxButtons.YesNo);

                    if (confirmacion.Equals(DialogResult.No))
                        return;
                    else
                    {

                        var editar = new EditarRevista(cod.ToString(), frec.ToString(), rub.ToString(),fecha.ToString());
                        editar.ShowDialog();
                        ActualizarRevista();
                    }
                }
                else
                    MessageBox.Show("Debe seleccionar una fila no vacia para poder editar");


            }
        }
    }
}
