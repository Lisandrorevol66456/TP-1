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
            var suscripcion = new Suscripcion();

            suscripcion.nro_doc = int.Parse(txtDoc.Text);
            suscripcion.cod_TipoDoc = cmbTipoDoc.SelectedIndex;
            suscripcion.cod_int = int.Parse(txtCodInt.Text);
            suscripcion.fecha_inicio = DateTime.Today;
            suscripcion.fecha_fin = DateTime.Today.AddYears(1);
            suscripcion.doc_plan = obtenerDocPlan();
            suscripcion.plan = consegirPlanes();

            repos.guardar(suscripcion);
        }

        public IList<Plan> consegirPlanes()
        {
                var planes = new List<Plan>();

                var filas = dgvSuscripciones.Rows;

                if (cmbPlan.SelectedIndex == 0)
                {
                    foreach (DataGridViewRow fila in filas)
                    {
                        var plan = new Plan(00, 10, DateTime.Today, DateTime.Today.AddYears(1), 200);
                        planes.Add(plan);
                    }
                    
                }
                else
                {
                    if (cmbPlan.SelectedIndex == 1)
                    {
                        foreach (DataGridViewRow fila in filas)
                        {
                            var plan = new Plan(01, 20, DateTime.Today, DateTime.Today.AddYears(1), 400);
                            planes.Add(plan);
                        }
                        
                    }
                    else
                    {
                        if (cmbPlan.SelectedIndex == 2)
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
            if (cmbPlan.SelectedIndex == 0)
                return 00;

            else
            {
                if (cmbPlan.SelectedIndex == 1)
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
         //   if(dgvSuscripciones.Rows != null)
         //       dgvSuscripciones.Rows.Clear();

            
            var filas = new List<DataGridViewRow>();

            foreach ( Suscripcion suscripcion in subs)
            {

                var fila = new string[]
                {
                    suscripcion.nro_doc.ToString(),
                    suscripcion.cod_int.ToString(),
                    suscripcion.fecha_inicio.ToString(),
                    suscripcion.fecha_fin.ToString(),
                    suscripcion.doc_plan.ToString(),
                    suscripcion.plan.ToString(),
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
    }
}