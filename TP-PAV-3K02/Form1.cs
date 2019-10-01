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
using TP_PAV_3K02.BaseDatos;

namespace TP_PAV_3K02
{
    public partial class NuevoSuscriptor : Form
    {
        SuscriptoresRepositorio _suscriptoresRepositorio;
        TipoDocumentoRepositorio _tipodocumentoRepositorio;
        ProvinciasRepositorio _provinciasRepositorio;
        LocalidadesRepositorio _localidadesRepositorio;
        Editorial_BD _BD;

        public NuevoSuscriptor()
        {
            InitializeComponent();
            _suscriptoresRepositorio = new SuscriptoresRepositorio();
            _tipodocumentoRepositorio = new TipoDocumentoRepositorio();
            _provinciasRepositorio = new ProvinciasRepositorio();
            _localidadesRepositorio = new LocalidadesRepositorio();

            _BD = new Editorial_BD();
        }

        //METODO PARA CARGAR LA GRILLA DE SUSCRIPTORES EXISTENTES
        private void ActualizarSuscriptores() {

            DvgSuscriptores.Rows.Clear();
            LimpiarCampos();


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


                };

                DvgSuscriptores.Rows.Add(fila);
                TipoDoc.Visible = false; // la columna tipo doc se hace invisible al usuario, ya que no es un dato
                                         // relevante para él.


            }

        }

        //cargar combos Tipo Documento
        private void ActualizarCombo()
        {
            //combo Tipo DNI
            var tip_documentos = _tipodocumentoRepositorio.ObetenerTiposDocumentosDT();
            cmbTipoDoc.ValueMember = "cod_TipoDoc";
            cmbTipoDoc.DisplayMember = "nombre";
            cmbTipoDoc.DataSource = tip_documentos;

        }

        //cargar combos de provincia
        private void ActualizarProvi()
        {
            var provi = _provinciasRepositorio.ObtenerProvinciasDT();
            cmbProvincias.ValueMember = "cod_provincia";
            cmbProvincias.DisplayMember = "nombre";
            cmbProvincias.DataSource = provi;


        }

        //cargar combos de localidades (recibe un codigo de provincia)
        private void ActualizarLocalidad(string provincia)
        {

            var localidad = _localidadesRepositorio.ObtenerLocalidadesDT(provincia);
            cmbLocalidad.ValueMember = "cod_Localidad";
            cmbLocalidad.DisplayMember = "nombre";
            cmbLocalidad.DataSource = localidad;



        }

        private void LimpiarCampos()
        {
            //resetea los txt para poder agregar otro suscriptor sin tener que borrar manualmente
            txtApellido.Clear();
            txtnombre.Clear();
            txtCalle.Clear();
            txtNumero.Clear();
            txtNroDoc.Clear();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var suscriptor = new Suscriptor();

            suscriptor.nombre = txtnombre.Text;

            suscriptor.apellido = txtApellido.Text;

            suscriptor.calle = txtCalle.Text;

            suscriptor.cod_TipoDoc = int.Parse(cmbTipoDoc.SelectedValue.ToString());

            suscriptor.cod_Provincia = int.Parse(cmbProvincias.SelectedValue.ToString());
            suscriptor.cod_Localidad = int.Parse(cmbLocalidad.SelectedValue.ToString());



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


            if (!suscriptor.NroDocValido(txtNroDoc.Text.ToString()))
            {

                MessageBox.Show("Documento Invalido");
                return;

            }

            suscriptor.nroDoc = long.Parse(txtNroDoc.Text);

            if (!suscriptor.NumeroValido(txtNumero.Text.ToString()))
            {
                MessageBox.Show("Numero Invalido");
                return;
            }

            suscriptor.numero = long.Parse(txtNumero.Text);



            if (_suscriptoresRepositorio.Guardar(suscriptor))
            {
                MessageBox.Show("Se registro con éxito");
                

            }

        }

        private void suscriptores_Load(object sender, EventArgs e)
        {
            ActualizarSuscriptores();
            ActualizarCombo();
            //Se selecciona automaticamente el DNI
            cmbTipoDoc.SelectedIndex = 0;
            ActualizarProvi();

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

                    }
                }
                if (documento == null)
                    MessageBox.Show("Debe Seleccionar una fila que no este Vacia.....");

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // cancela la carga del suscriptor y limpialos textbox
            LimpiarCampos();
        }
       
      

        // boton buscar por documento, filtra la grilla segun el valor ingresado
        private void BtnBuscar_Click(object sender, EventArgs e)

        {
            var sus = new Suscriptor();
            if (sus.busquedaValida(TXTbuscarDNI.Text.ToString())) // valido que no sea espacio en blanco o campo vacio
            {
                if (sus.NumeroValido(TXTbuscarDNI.Text)) // valido qeu sea numero
                {
                    DvgSuscriptores.Rows.Clear();
                    var numdoc = long.Parse(TXTbuscarDNI.Text);
                    var suscriptores = _suscriptoresRepositorio.ObtenerPorDNI(numdoc).Rows;
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

                            };  

                            DvgSuscriptores.Rows.Add(fila);    


                    }
                }
                else
                {
                    MessageBox.Show("No se puede buscar lo ingresado, ingrese nuevamente.");
                    TXTbuscarDNI.Focus(); // me devuelve el prompt al txt buscar para que el usuario reingrese datos
                }
            }
        }

        //segun el valor seleccionado del cmbprovincias actualiza el cmblocalidades
        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvincias.Items.Count != 0)
            {
                ActualizarLocalidad(cmbProvincias.SelectedValue.ToString());


            }
            else
            {
                cmbLocalidad.DataSource = null; // si no hay nada seleccionado en provincias localidades es null
                DvgSuscriptores.DataSource = null;
            }
        }

        private void validateTextBox(object sender, KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
             
            }

        }

        //editar un suscriptor
        private void BTNeditar_Click(object sender, EventArgs e)
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
                var prov = fila.Cells[7].Value;
                var loc = fila.Cells[6].Value;
               
               


                if (documento != null)
                {
                    //pregunto confirmación
                    var confirmacion = MessageBox.Show($"Desea editar a {nombre}, {apellido}, {documento}?",
                    "Confirmar operación",
                    MessageBoxButtons.YesNo);

                    if (confirmacion.Equals(DialogResult.No))
                        return;
                    else
                    {
                       
                        var editar = new EditarSuscriptor(documento.ToString(),prov.ToString(),loc.ToString());
                        editar.ShowDialog();
                        ActualizarSuscriptores();
                    }
                }
                else
                    MessageBox.Show("Debe seleccionar una fila no vacia para poder editar");


            }
        }

        private void BTNactualizar_Click(object sender, EventArgs e)
        {
            //DvgSuscriptores.Rows.Clear();
            ActualizarSuscriptores(); // refresh a grid
        }

        // abre el form de distribuidores
        private void btnFormDistribuidores_Click(object sender, EventArgs e)
        {
            var formrepar = new FormDistribuidores();
            formrepar.ShowDialog();
        }

        // boton cancelar, cancela la busqueda y actualiza la grilla a como estaba
        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            ActualizarSuscriptores();
            TXTbuscarDNI.Clear(); // limpio contenido de txt buscar

        }
    }

} 

