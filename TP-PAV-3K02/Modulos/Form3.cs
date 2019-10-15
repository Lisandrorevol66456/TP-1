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

            try
            {
                var suscripcion = new Suscripcion()
                {
                    nro_doc = int.Parse(txtDoc.Text),
                    cod_TipoDoc = cmbTipoDoc.SelectedIndex,
                    fecha_inicio = DateTime.Today,
                    fecha_fin = DateTime.Today.AddYears(1),
                    doc_plan = obtenerDocPlan(),
                    plan = consegirPlanes()
                };

            }

            catch { }
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

        private void actualizar()
        {
            dgvSuscripciones.DataSource = null;

            var subs = repos.obtenerSuscripciones().Rows;
            var filas = new List<DataGridViewRow>();

            foreach ( DataRow suscripcion in subs)
            {
                var fila = new string[]
                {
                    suscripcion.ItemArray[0].ToString(),
                    suscripcion.ItemArray[1].ToString(),
                    suscripcion.ItemArray[2].ToString(),
                    suscripcion.ItemArray[3].ToString(),
                    suscripcion.ItemArray[4].ToString(),
                    suscripcion.ItemArray[5].ToString(),
                };
            
                dgvSuscripciones.Rows.Add(fila);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}