using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K02.Utils;
using TP_PAV_3K02.Modelos;
using TP_PAV_3K02.Repositorios;

namespace TP_PAV_3K02.Modulos
{
    public partial class Suscripciones : Form
    {

        ValidateTextBox v;
        SuscripcionesRepositorios repos;
        PlanesRepositorio pRepos;

        public Suscripciones()
        {
            InitializeComponent();
            repos =new SuscripcionesRepositorios();
            pRepos = new PlanesRepositorio();
            v = new ValidateTextBox();
            cargarCMB();
        }

        

        private void ValidateSoloNumeros(object sender, KeyPressEventArgs e)
        {
            v.ValidateSoloNumeros(sender, e);

        }

        private void Suscripciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Suscripcion' Puede moverla o quitarla según sea necesario.
 //           this.suscripcionTableAdapter.Fill(this.dataSet1.Suscripcion);

        }


        private void actualizarGrilla()
        {
            var suscripciones = repos.obtenerSuscripciones();
            actualizar();
        }

        private void actualizar()
        {
            dgvSuscripciones.Rows.Clear();
            var doc = long.Parse(txtDoc.Text);
            var codPlan = cmbPlanes.SelectedValue.ToString();
            var precPlan = pRepos.obtenerPlanesByValue(codPlan);
            var sustros = repos.obtenerSuscripcionesPorDoc(doc).Rows;
            var filas = new List<DataGridViewRow>();
            var filasP = new List<DataGridViewRow>();

            foreach (DataRow suscrib in sustros)
            {
                if (suscrib.HasErrors)
                    continue;

                var fila = new string[]
                {
                    suscrib.ItemArray[0].ToString(),
                    suscrib.ItemArray[1].ToString(),
                    suscrib.ItemArray[2].ToString(),
                    suscrib.ItemArray[3].ToString(),
                    suscrib.ItemArray[4].ToString()
                    
                };
                var planPart = new string[]
                    {
                    codPlan, precPlan.ToString()
                     };

                planPart.CopyTo(fila, fila.Length);

                dgvSuscripciones.Rows.Add(fila);
                

            }

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            actualizarGrilla();
        }


        public void cargarCMB()
        {
            var planes = pRepos.obtenerPlanes();
            cmbPlanes.DisplayMember = "nombre";
            cmbPlanes.ValueMember = "cod_Plan";
            cmbPlanes.DataSource = planes;
        }
        
        private void tnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var _suscripcion = prepararSus();

                repos.guardar(_suscripcion);

                actualizar();

            }

            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Delete()
        {
            StringBuilder mensaje = new StringBuilder("La operación ");
            if (MessageBox.Show("Desea eliminar?", "Confirmación", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            try
            {
                var seleccionadas = dgvSuscripciones.SelectedRows;
                if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
                {
                    MessageBox.Show("Debe seleccionar una fila");
                    return;
                }
                foreach (DataGridViewRow fila in seleccionadas)
                {
                    var nroDoc = fila.Cells[0].Value;
                    var tipDoc = fila.Cells[1].Value;
                    var codInt = fila.Cells[2].Value;
                    var fechaI = fila.Cells[3].Value;
                    var fechaF = fila.Cells[4].Value;

                    repos.borrar(codInt.ToString());
                    
                    mensaje.Append("eliminar se realizo con exito");

                }
            }
            catch (InvalidOperationException ex)
            {
                mensaje.Append("no se realizó. Hubo un problema en la conexión a la BD");
                
            }
            finally
            {
                MessageBox.Show(mensaje.ToString());
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Delete();
            actualizarGrilla();
            clear();
        }

        public Suscripcion prepararSus()
        {
            var suscripcion = new Suscripcion();

            suscripcion.nro_doc = long.Parse(txtDoc.Text);
            suscripcion.cod_TipoDoc = cmbPlanes.SelectedIndex;
            suscripcion.fecha_inicio = DateTime.Today;
            suscripcion.fecha_fin = DateTime.Today.AddYears(1);
            return suscripcion;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            cmbPlanes.SelectedIndex = -1;
            cmbTipDoc.SelectedIndex = -1;
            txtDoc.Clear();
        }

       
    }
}