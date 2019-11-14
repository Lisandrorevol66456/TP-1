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
    public partial class Formsuscripcion : Form
    {

        SuscripcionesRepositorios _suscripcionesrepo;
        SuscriptoresRepositorio _suscriptoresrepo;
        PlanesRepositorio _planesrepo;
        Suscriptor suscriptor;
        Suscripcion suscripcion;


        public Formsuscripcion()
        {
            InitializeComponent();
        }
        public Formsuscripcion(string dni)
        {
            InitializeComponent();
            _suscripcionesrepo = new SuscripcionesRepositorios();
            _suscriptoresrepo = new SuscriptoresRepositorio();
            _planesrepo = new PlanesRepositorio();
            suscripcion = new Suscripcion();
            suscriptor = _suscriptoresrepo.ObtenerSuscriptor(dni);

        }
        private void Formsuscripcion_Load(object sender, EventArgs e)
        {
            txtDoc.Text = suscriptor.nroDoc.ToString(); // carga el form con el dni del suscriptor al qe se le va a ver las suscripciones
            ActualizarSuscripciones(suscriptor.nroDoc);
            CargarCombo();
        }
        private void ActualizarSuscripciones(long dni)
        {
            dgvSuscripciones.Rows.Clear();

            var suscrip = _suscripcionesrepo.ObtenerPorDNI(dni).Rows;
            var filas = new List<DataGridViewRow>();

            foreach (DataRow suscripcion in suscrip)
            {
                if (suscripcion.HasErrors)
                    continue;
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
        private void CargarCombo()
        {
            var plan = _planesrepo.obtenerPlanes();
            cmbPlanes.ValueMember = "cod_Plan";
            cmbPlanes.DisplayMember = "nombre";
            cmbPlanes.DataSource = plan;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActualizarSuscripciones(suscriptor.nroDoc);
        }

        private void tnAdd_Click(object sender, EventArgs e)
        {

            var suscripcion = new Suscripcion();

            suscripcion.nro_doc = long.Parse(txtDoc.Text);
            suscripcion.cod_TipoDoc = cmbPlanes.SelectedIndex;
            suscripcion.fecha_inicio = DTPfechainicio.Value;
            suscripcion.fecha_fin = DTPfechainicio.Value.AddYears(1);
            suscripcion.doc_plan = int.Parse(cmbPlanes.SelectedValue.ToString());

            if (!suscripcion.fechavalida())
            {
                MessageBox.Show("La fecha ingresada no es valida");
                return;
            }

            _suscripcionesrepo.guardar(suscripcion);
            Mensaje();

            ActualizarSuscripciones(suscriptor.nroDoc);


        }
        private void Mensaje()
        {
            MessageBox.Show("Operacion exitosa");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show($"Desea salir?",
                    "Confirmar operación",
                    MessageBoxButtons.YesNo);

            if (confirmacion.Equals(DialogResult.No))
                return;
            else
            {
                this.Dispose();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var seleccionadas = dgvSuscripciones.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccionadas)
            {
                var codint = fila.Cells[0].Value;
                var documento = fila.Cells[2].Value;

                if (documento != null)
                {
                    //pregunto confirmación
                    var confirmacion = MessageBox.Show($"Esta seguro que desea eliminar a {documento}?",
                    "Confirmar operación",
                    MessageBoxButtons.YesNo);

                    if (confirmacion.Equals(DialogResult.No))
                        return;
                    if (_suscripcionesrepo.borrar(codint.ToString()))
                    {
                        Mensaje();
                        ActualizarSuscripciones(suscriptor.nroDoc);
                    }



                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var seleccionadas = dgvSuscripciones.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccionadas)
            {
                var codint = fila.Cells[0].Value;
                var documento = fila.Cells[2].Value;

                if (documento != null)
                {
                    //pregunto confirmación
                    var confirmacion = MessageBox.Show($"Esta seguro que desea editar a {documento}?",
                    "Confirmar operación",
                    MessageBoxButtons.YesNo);

                    if (confirmacion.Equals(DialogResult.No))
                        return;
                    var edi = new Form_Editarsuscripcion(codint.ToString());
                    edi.ShowDialog();
                    ActualizarSuscripciones(suscriptor.nroDoc);
                }
            }
        }
    }
}
    
