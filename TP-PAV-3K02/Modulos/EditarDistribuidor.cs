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

namespace TP_PAV_3K02.Modulos
{
    public partial class EditarDistribuidor : Form
    {

        DistribuidoresRepositorio _ORepoDist;
        Editorial_BD _BD;
        Distribuidor _distribuidor;

        public EditarDistribuidor()
        {
            InitializeComponent();
            _ORepoDist = new DistribuidoresRepositorio();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var distribuidor = new Distribuidor();

            distribuidor.apellido = txtApellido.Text;
            distribuidor.nombre = txtnombre.Text;
            distribuidor.cuit_dist = int.Parse(TxtCuit.Text);
            distribuidor.domicilio = TxtDomicilio.Text;
            distribuidor.fecha_inicio = DTPfechainicio.Value;

            if (!distribuidor.ApellidoValido())
            {
                MessageBox.Show("El apellido que ingreso no es valido ");
                return;
            }

            if (!distribuidor.NombreValido())
            {
                MessageBox.Show("El nombre que ingreso no es valido");
                return;
            }

            if (!distribuidor.CuitValido())
            {
                MessageBox.Show("El CUIT que ingreso no es valido");
                return;
            }

            if (!distribuidor.domicilioValido())
            {
                MessageBox.Show("El domicilio ingresado no es valido");
                return;
            }

            if (!distribuidor.fechavalida())
            {
                MessageBox.Show("La fecha ingresada no es valida");
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarDistribuidor_Load(object sender, EventArgs e)
        {

        }
    }
}
