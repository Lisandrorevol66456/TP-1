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
        TipoDocumentoRepositorio _tipodocumentoRepositorio;

        public NuevoSuscriptor()
        {
            InitializeComponent();
            _suscriptoresRepositorio = new SuscriptoresRepositorio();
            _tipodocumentoRepositorio = new TipoDocumentoRepositorio();
        }
        //METODO PARA CARGAR LA GRILLA DE SUSCRIPTORES EXISTENTES
        private void ActualizarSuscriptores() {

            DvgSuscriptores.Rows.Clear();

            var suscriptores = _suscriptoresRepositorio.ObtenerSuscriptoresDT().Rows;
            var filas = new List<DataGridViewRow>();

            foreach (DataRow suscriptor in suscriptores)
            {
                if (suscriptor.HasErrors)
                    continue;//no corto el ciclo
                var fila = new string[]
                {
                    suscriptor.ItemArray[0].ToString(),
                    suscriptor.ItemArray[1].ToString(),
                    suscriptor.ItemArray[2].ToString(),
                    suscriptor.ItemArray[3].ToString(),
                    suscriptor.ItemArray[4].ToString(),
                    suscriptor.ItemArray[5].ToString(),
                    suscriptor.ItemArray[6].ToString(),
                    suscriptor.ItemArray[7].ToString(),
                    suscriptor.ItemArray[8].ToString(),
                };

                DvgSuscriptores.Rows.Add(fila);

            }

        }
        //cargar combos Tipo Documento
        private void ActualizarCombo()
        {
            var tip_documentos = _tipodocumentoRepositorio.ObetenerTiposDocumentosDT();
            cmbTipoDoc.ValueMember = "cod_TipoDoc";
            cmbTipoDoc.DisplayMember = "nombre";
            cmbTipoDoc.DataSource = tip_documentos;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var suscriptor = new Suscriptor();
            suscriptor.nombre = txtnombre.Text;
            suscriptor.apellido = txtApellido.Text;
            suscriptor.calle = txtCalle.Text;
            suscriptor.nroDoc = long.Parse(txtNroDoc.Text);
            suscriptor.numero = long.Parse(txtNumero.Text);
            suscriptor.cod_TipoDoc = int.Parse(cmbTipoDoc.SelectedValue.ToString());


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

            if (!suscriptor.NroDocValido())
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
            ActualizarSuscriptores();
            ActualizarCombo();
            //Se selecciona automaticamente el DNI
            cmbTipoDoc.SelectedIndex = 0;
         
        }

        private void cmbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var seleccionadas = DvgSuscriptores.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccionadas)
            {
                var nombre = fila.Cells[2].Value;
                var apellido = fila.Cells[3].Value;
                var documento = fila.Cells[0].Value;



                if (documento != null)
                {
                    //pregunto confirmación
                    var confirmacion = MessageBox.Show($"Esta seguro que desea eliminar a {nombre}, {apellido}, {documento}?",
                    "Confirmar operación",
                    MessageBoxButtons.YesNo);

                    if (confirmacion.Equals(DialogResult.No))
                        return;

                 
                    if (_suscriptoresRepositorio.Eliminar(documento.ToString()))
                    {
                        MessageBox.Show("Se eliminó exitosamente");
                        ActualizarSuscriptores();

                    }
                }
                if(documento == null)
                    MessageBox.Show("Debe Seleccionar una fila que no este Vacia.....");

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnFormRepartidores_Click(object sender, EventArgs e)
        {
            var formrepar = new FormDistribuidores();
            formrepar.ShowDialog();

        }

        private void DvgSuscriptores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCalle_TextChanged(object sender, EventArgs e)
        {

        }
    }   
}

