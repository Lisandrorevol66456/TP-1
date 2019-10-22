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

        public Suscripciones()
        {
            InitializeComponent();
            repos =new SuscripcionesRepositorios();
            v = new ValidateTextBox();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            Planes frm = new Planes();

            frm.Show();
        }

        private void ValidateSoloNumeros(object sender, KeyPressEventArgs e)
        {
            v.ValidateSoloNumeros(sender, e);

        }

        private void Suscripciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Suscripcion' Puede moverla o quitarla según sea necesario.
            this.suscripcionTableAdapter.Fill(this.dataSet1.Suscripcion);

        }

        private void cmbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void label4_Click(object sender, EventArgs e)
        {}

        private void label3_Click(object sender, EventArgs e)
        {}

        private void txtCodInt_TextChanged(object sender, EventArgs e)
        {}

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        public IList<Plan> consegirPlanes()
        {
                var planes = new List<Plan>();

                var filas = dgvSuscripciones.Rows;

                if (cmbPlanes.SelectedIndex == 0)
                {
                    foreach (DataGridViewRow fila in filas)
                    {
                        var plan = new Plan(00, 10, DateTime.Today, DateTime.Today.AddYears(1), 200);
                        planes.Add(plan);
                    }
                    
                }
                else
                {
                    if (cmbPlanes.SelectedIndex == 1)
                    {
                        foreach (DataGridViewRow fila in filas)
                        {
                            var plan = new Plan(01, 20, DateTime.Today, DateTime.Today.AddYears(1), 400);
                            planes.Add(plan);
                        }
                        
                    }
                    else
                    {
                        if (cmbPlanes.SelectedIndex == 2)
                        {
                            foreach (DataGridViewRow fila in filas)
                            {
                                var plan = new Plan(02, 30, DateTime.Today, DateTime.Today.AddYears(1), 600);
                                planes.Add(plan);
                            }
                            
                        }
                    }
                }
                return planes;
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
            actualizar(suscripciones);
        }

        private void actualizar(IList<Suscripcion> subs)
        {
            dgvSuscripciones.Rows.Clear();
            var sus = new Suscripcion();
            var codeInt = sus.cod_int;
            var sustros = repos.obtenerSuscripcionesPorCod(codeInt.ToString()).Rows;
            var filas = new List<DataGridViewRow>();

            foreach (DataRow distribucion in sustros)
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
                    distribucion.ItemArray[5].ToString(),

                };

                dgvSuscripciones.Rows.Add(fila);

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void tnAdd_Click(object sender, EventArgs e)
        {
            var suscripcion = new Suscripcion();

            suscripcion.nro_doc = int.Parse(txtDoc.Text);
            suscripcion.fecha_inicio = DateTime.Today;
            suscripcion.fecha_fin = DateTime.Today.AddYears(1);
            suscripcion.doc_plan = obtenerDocPlan();
            suscripcion.plan = consegirPlanes();

            repos.guardar(suscripcion);
            actualizarGrilla();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
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


                //pregunto confirmación
                if (nroDoc != null)
                {
                    var confirmacion = MessageBox.Show($"Esta seguro que desea eliminar la distribucion {nroDoc}?",
                   "Confirmar operación",
                   MessageBoxButtons.YesNo);

                    if (confirmacion.Equals(DialogResult.No))
                        return;

                    if (repos.borrar(codInt.ToString()))
                    {
                        MessageBox.Show("Se eliminó exitosamente");
                        actualizarGrilla();

                    }
                }
            }
        }
    }
}