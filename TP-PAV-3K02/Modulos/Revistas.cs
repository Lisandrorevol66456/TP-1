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

            if (!revista.CodValido(txtcodigoInterno.Text.ToString()))
            {
                MessageBox.Show("Codigo Interno Invalido");
                return;
            }

            revista.cod_Interno = int.Parse(txtcodigoInterno.Text);

            if (!revista.fechavalida())
            {
                MessageBox.Show("Fecha de inicio invalida");
                return;
            }

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
    }
}
