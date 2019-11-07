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

      

        public Plan consegirPlanes()
        {
                Plan planes = new Plan();

                var filas = dgvSuscripciones.Rows;

                if (cmbPlanes.SelectedIndex == 0)
                {
                Plan plan = new Plan();
                    plan.cod_Plan = 00;
                    plan.fechaInicial = DateTime.Today;
                    plan.fechaFin = DateTime.Today.AddYears(1);
                    plan.Precio = 200;
                return plan;  
                   
                }
                else
                {
                    if (cmbPlanes.SelectedIndex == 1)
                    {
                            Plan plan = new Plan();
                            plan.cod_Plan = 01;
                            plan.fechaInicial = DateTime.Today;
                            plan.fechaFin = DateTime.Today.AddYears(1);
                            plan.Precio = 400;
                    return plan;

                }
                    else
                    {
                        if (cmbPlanes.SelectedIndex == 2)
                        {
                                Plan plan = new Plan();
                                plan.cod_Plan = 02;
                                plan.cod_int = 30;
                                plan.fechaInicial = DateTime.Today;
                                plan.fechaFin = DateTime.Today.AddYears(1);
                                plan.Precio = 600;
                        return plan;
                    }
                    }
                }

            return planes;
        }


        public void cambiarDoc()
        {
            if (cmbTipDoc.SelectedIndex == 0)
            {
                txtDoc.MaxLength = 8;
            }
        }

        public int obtenerDocPlan()
        {
            if (cmbPlanes.SelectedIndex == 0)
                return 00;

            else
            {
                if (cmbPlanes.SelectedIndex == 1)
                return 01;

                else
                {
                    return 02;
                }
            }
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
            var idPlan = cmbPlanes.SelectedIndex.ToString();
            var sustros = repos.obtenerSuscripcionesPorDoc(doc).Rows;
            var plans = pRepos.obtenerPlanesByDoc(idPlan).Rows;
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
                    suscrib.ItemArray[4].ToString(),
                    suscrib.ItemArray[5].ToString()
                };
                dgvSuscripciones.Rows.Add(fila);

                foreach (DataRow plan in plans)
                {
                    if (suscrib.HasErrors)
                        continue;

                    var filaP = new string[]
                    {
                    plan.ItemArray[0].ToString(),
                    plan.ItemArray[1].ToString(),
                    plan.ItemArray[2].ToString(),
                    plan.ItemArray[3].ToString(),
                    plan.ItemArray[4].ToString(),
                    };
                    dgvSuscripciones.Rows.Add(filaP);
                }
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

       

        private void tnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var _suscripcion = prepararSus();

                repos.guardar(_suscripcion);

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
            suscripcion.fecha_inicio = DateTime.Today;
            suscripcion.fecha_fin = DateTime.Today.AddYears(1);
            suscripcion.doc_plan = obtenerDocPlan();
            suscripcion.plan.Add(consegirPlanes());
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