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

namespace TP_PAV_3K02.Modulos
{
    public partial class Empresas : Form
    {
        EmpresasRepositorio _empresaRepositorio;
        CalificacionesRepositorio _calificacionRepositorio;
        //Empresa _empresa;
        Editorial_BD _BD;

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
            this.empresasTableAdapter.Fill(this.dataSet1.Empresas);
        }
        
        
    private void btnAgregar_Click(object sender, EventArgs e)
        {
            var empresa = new Empresa();
            empresa.nombre = txtnombre.Text;
            empresa.apellido = txtApellido.Text;
            empresa.cuit = long.Parse(TxtCuit.Text);
            empresa.domicilio = TxtDomicilio.Text;
            empresa.fechaI = DTPfechainicio.Value.Date;
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

            empresa.cuit = long.Parse(TxtCuit.Text);

            
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

        private void button1_Click(object sender, EventArgs e)
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
    }
}
