using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using TP_PAV_3K02.BaseDatos;
using TP_PAV_3K02.Modelos;
using TP_PAV_3K02.Repositorios;
using TP_PAV_3K02.Utils;

namespace TP_PAV_3K02.Modulos
{
    public partial class Empresas : Form
    {
        EmpresasRepositorio _empresaRepositorio;
        CalificacionesRepositorio _calificacionRepositorio;
        //Empresa _empresa;
        Editorial_BD _BD;
        ValidateTextBox v;

        public Empresas()
        {
            InitializeComponent();
            _empresaRepositorio = new EmpresasRepositorio();
            _calificacionRepositorio = new CalificacionesRepositorio();

            _BD = new Editorial_BD();
        }

        private void Peliculas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Empresas' Puede moverla o quitarla según sea necesario.
          //  this.empresasTableAdapter.Fill(this.dataSet1.Empresas);
            ActualizarEmpresas();
        }
        private void ActualizarEmpresas()
        {

            dgvEmpresas.Rows.Clear();

            var empresas = _empresaRepositorio.ObtenerEmpresa().Rows;
            var filas = new List<DataGridViewRow>();

            foreach (DataRow empresa in empresas)
            {
                if (empresa.HasErrors)
                    continue;//no corto el ciclo
                var fila = new string[]
                {
                    empresa.ItemArray[0].ToString(),
                    empresa.ItemArray[1].ToString(),
                    empresa.ItemArray[2].ToString(),
                    empresa.ItemArray[3].ToString(),
                    empresa.ItemArray[4].ToString(),
                    empresa.ItemArray[5].ToString(),
                    empresa.ItemArray[6].ToString(),
                    


                };

                dgvEmpresas.Rows.Add(fila);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var empresa = new Empresa();
            empresa.nombre = txtnombre.Text;
            empresa.apellido = txtApellido.Text;
            empresa.cuit_Empresa = long.Parse(TxtCuit.Text);
            empresa.domicilio = TxtDomicilio.Text;
            empresa.fecha_Inicio = DTPfechainicio.Value.Date;
            //empresa.codCal = int.Parse(cmbCodCal.SelectedIndex.ToString());

            if (!empresa.NombreValido())
            {
                MessageBox.Show("Nombre Invalido");
                return;
            }

            if (!empresa.ApellidoValido())
            {
                MessageBox.Show("Apellido Invalido");
                return;
            }

            if (!empresa.DomicilioValido())
            {
                MessageBox.Show("Calle Invalida");
                return;
            }


            if (!empresa.NroCuitValido(TxtCuit.Text.ToString()))
            {

                MessageBox.Show("Documento Invalido");
                return;

            }

            empresa.cuit_Empresa = long.Parse(TxtCuit.Text);

            
            if (_empresaRepositorio.guardar(empresa))
            {
                MessageBox.Show("Se registro con éxito");


            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var seleccionadas = dgvEmpresas.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccionadas)
            {
                var cuit = fila.Cells[0].Value;
                var nombre = fila.Cells[1].Value;
                var apellido = fila.Cells[0].Value;
                var domicilio = fila.Cells[0].Value;
                var fechaI = fila.Cells[0].Value;
                var codCal = fila.Cells[0].Value;


                if (cuit != null)
                {
                    //pregunto confirmación
                    var confirmacion = MessageBox.Show($"Esta seguro que desea eliminar a {nombre}, {apellido}, {cuit}?",
                    "Confirmar operación",
                    MessageBoxButtons.YesNo);

                    if (confirmacion.Equals(DialogResult.No))
                        return;


                    if (_empresaRepositorio.eliminar(cuit.ToString()))
                    {
                        MessageBox.Show("Se eliminó exitosamente");

                    }
                }
                if (cuit == null)
                    MessageBox.Show("Debe Seleccionar una fila que no este Vacia.....");

            }
                        
        }

        private void button1_Click(object sender, EventArgs e) // boton calificar
        {
            var seleccionadas = dgvEmpresas.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccionadas)
            {
                var cuit = fila.Cells[0].Value;
                var nombre = fila.Cells[1].Value;
                var apellido = fila.Cells[0].Value;
                var domicilio = fila.Cells[0].Value;
                var fechaI = fila.Cells[0].Value;
                var codCal = fila.Cells[0].Value;


                if (cuit != null)
                {
                    //pregunto confirmación
                    var confirmacion = MessageBox.Show($"Calificar a {nombre}, {apellido}, {cuit}?",
                    "Confirmar operación",
                    MessageBoxButtons.YesNo);

                    if (confirmacion.Equals(DialogResult.No))
                        return;

                    var formCalificacion = new Calificacion(cuit.ToString()); // abre el form de calificaciones
                    formCalificacion.ShowDialog();

                }
                if (cuit == null)
                    MessageBox.Show("Debe Seleccionar una fila que no este Vacia.....");

            }
            

        }
        private void LimpiarCampos()
        {
            txtApellido.Clear();
            TxtCuit.Clear();
            TxtDomicilio.Clear();
            txtnombre.Clear();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BTNactualizar_Click(object sender, EventArgs e)
        {
            ActualizarEmpresas(); // refresh a grid
        }

        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            TXTbuscarCUIT.Clear();
            ActualizarEmpresas();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
        var emp = new Empresa();
            
            dgvEmpresas.Rows.Clear();
            var numcuit = long.Parse(TXTbuscarCUIT.Text);
            var empres = _empresaRepositorio.ObtenerPornroCUIT(numcuit).Rows;
            var filas = new List<DataGridViewRow>();

            foreach (DataRow empresa in empres)
            {
                if (empresa.HasErrors)
                    continue;//no corto el ciclo


                var fila = new string[]
                    {
                            empresa.ItemArray[0].ToString(),
                            empresa.ItemArray[1].ToString(),
                            empresa.ItemArray[2].ToString(),
                            empresa.ItemArray[3].ToString(),
                            empresa.ItemArray[4].ToString(),
                            empresa.ItemArray[5].ToString(),
                            empresa.ItemArray[6].ToString(),
                                

                    };

                dgvEmpresas.Rows.Add(fila);


            }
            
        }

        private void ValidateSoloNumeros(object sender, KeyPressEventArgs e)
        {
            v.ValidateSoloNumeros(sender, e);
        }

        private void validarletra(object sender, KeyPressEventArgs e)
        {
            v.validateSoloLetras(sender, e);
        }

        private void validarLetrayNumero(object sender, KeyPressEventArgs e)
        {
            v.validateLetrasNumeros(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var seleccionadas = dgvEmpresas.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccionadas)
            {
                var nombre = fila.Cells[1].Value;
                var apellido = fila.Cells[2].Value;
                var cuit = fila.Cells[0].Value;
                var domicilio = fila.Cells[3].Value;
                var fecha_inicio = fila.Cells[4].Value;
                var fecha_cal = fila.Cells[5].Value;
                var cod_cal = fila.Cells[6].Value;




                if (cuit != null)
                {
                    //pregunto confirmación
                    var confirmacion = MessageBox.Show($"Desea editar a {nombre}, {apellido}, {cuit}?",
                    "Confirmar operación",
                    MessageBoxButtons.YesNo);

                    if (confirmacion.Equals(DialogResult.No))
                        return;
                    else
                    {

                        var editar = new EditarEmpresa(cuit.ToString());
                        editar.ShowDialog();
                        ActualizarEmpresas();
                    }
                }
                else
                    MessageBox.Show("Debe seleccionar una fila no vacia para poder editar");


            }
        }
    }
}
