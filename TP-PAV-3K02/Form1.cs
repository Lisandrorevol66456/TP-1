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
    public partial class NuevoSuscriptor : Form
    {
        SuscriptoresRepositorio _suscriptoresRepositorio;

        public NuevoSuscriptor()
        {
            InitializeComponent();
            _suscriptoresRepositorio = new SuscriptoresRepositorio();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var suscriptor = new Suscriptor();
            suscriptor.nombre = txtnombre.Text;
            suscriptor.apellido = txtApellido.Text;
            suscriptor.calle = txtCalle.Text;
            suscriptor.nroDoc = int.Parse(txtNroDoc.Text);
            suscriptor.numero = int.Parse(txtNumero.Text);
            // suscriptor.numero = convertir a integer el sting (txt.numero)


            if (!suscriptor.NombreValido())
            {
                MessageBox.Show("Nombre Invalido");
                return;
            }

            if (!suscriptor.ApellidoValido())
            {
                MessageBox.Show("Apellido Invalido");
                return;
            }

            if (!suscriptor.CalleValido())
            {
                MessageBox.Show("Calle Invalida");
                return;
            }

            if(!suscriptor.NroDocValido())
            {
                MessageBox.Show("Documento Invalido");
                return;
            }

            if (!suscriptor.NumeroValido())
            {
                MessageBox.Show("Numero Invalido");
                return;
            }

            if (_suscriptoresRepositorio.Guardar(suscriptor))
            {
                MessageBox.Show("Se registro con éxito");
                this.Dispose();
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void suscriptores_Load(object sender, EventArgs e)
        {

        }

        private void cmbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var seleccionadas = grillaSuscriptores.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach(DataGridViewRow fila in seleccionadas)
            {
                var nombre = fila.Cells[2].Value;
                var apellido = fila.Cells[3].Value;
                var id = fila.Cells[0].Value;
                

                //pregunto confirmación
                var confirmacion = MessageBox.Show($"Esta seguro que desea eliminar a {nombre}, {apellido}?",
                    "Confirmar operación",
                    MessageBoxButtons.YesNo);

                if (confirmacion.Equals(DialogResult.No))
                    return;

                if (_suscriptoresRepositorio.Eliminar(id.ToString()))
                {
                    MessageBox.Show("Se eliminó exitosamente");
                    
                }
            }
        }
            //this.Dispose();
        }
    }

