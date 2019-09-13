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
    public partial class FormDistribuidores : Form
    {
        DistribuidoresRepositorio _distribuidoresRepositorio;
        public FormDistribuidores()
        {
            InitializeComponent();
            _distribuidoresRepositorio = new DistribuidoresRepositorio();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var distribuidor = new Distribuidor();
            distribuidor.cuit_dist = int.Parse(TxtCuit.Text);
            distribuidor.nombre = txtnombre.Text;
            distribuidor.apellido = txtApellido.Text;
            distribuidor.domicilio = TxtDomicilio.Text;
            distribuidor.fecha_inicio = DTPfechainicio.Value.Date;

            if (!distribuidor.NombreValido())
            {
                MessageBox.Show("Nombre Invalido");
                txtnombre.Focus();
                return;
            }

            if (!distribuidor.ApellidoValido())
            {
                MessageBox.Show("Apellido Invalido");
                txtApellido.Focus();
                return;
            }

            if (!distribuidor.domicilioValido())
            {
                MessageBox.Show("Domicilio Invalido");
                TxtDomicilio.Focus();
                return;
            }
            if (!distribuidor.fechavalida())
            {
                MessageBox.Show("Fecha de inicio invalida");
                DTPfechainicio.Focus();
                return;
            }
            if (_distribuidoresRepositorio.Guardar(distribuidor))
            {
                MessageBox.Show("Se registro con éxito");
                this.Dispose();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var seleccionadas = grillaDistribuidores.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccionadas)
            {
                var nombre = fila.Cells[2].Value;
                var apellido = fila.Cells[3].Value;
                var cuit_dist = fila.Cells[0].Value;


                //pregunto confirmación
                var confirmacion = MessageBox.Show($"Esta seguro que desea eliminar a {nombre}, {apellido}, {cuit_dist}?",
                    "Confirmar operación",
                    MessageBoxButtons.YesNo);

                if (confirmacion.Equals(DialogResult.No))
                    return;

                if (_distribuidoresRepositorio.Eliminar(cuit_dist.ToString()))
                {
                    MessageBox.Show("Se eliminó exitosamente");

                }
            }
        }
    }
}
