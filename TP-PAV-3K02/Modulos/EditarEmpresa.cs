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
using TP_PAV_3K02.Utils;

namespace TP_PAV_3K02.Modulos
{
    public partial class EditarEmpresa : Form
    {
        Editorial_BD _BD;
        ValidateTextBox v;
        EmpresasRepositorio _empresaRepositorio;
        Empresa empresa;

        public EditarEmpresa()
        {
            InitializeComponent();
            
        }
        public EditarEmpresa(string nroCuit)
        {
            InitializeComponent();
            _BD = new Editorial_BD();
            _empresaRepositorio = new EmpresasRepositorio();
            empresa = _empresaRepositorio.ObtenerPorCuit(nroCuit);

        }


        private void EditarEmpresa_Load(object sender, EventArgs e)
        {
            TXTnombre.Text = empresa.nombre;
            TXTapellido.Text = empresa.apellido;
            txtCuit.Text = empresa.cuit_Empresa.ToString();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            empresa.nombre = TXTnombre.Text;
            empresa.apellido = TXTapellido.Text;
            empresa.cuit_Empresa = long.Parse(txtCuit.Text.ToString());
            empresa.fecha_Inicio = DateTime.Parse(DTPfechainicio.ToString());

            if (_empresaRepositorio.actualizar(empresa, txtCuit.Text.ToString()))
            {
                MessageBox.Show("Se actualizó con éxito");
                this.Dispose();//Libera los recursos

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void validarLetra(object sender, KeyPressEventArgs e)
        {
            v.validateSoloLetras(sender, e);
        }

        private void validarNumero(object sender, KeyPressEventArgs e)
        {
            v.ValidateSoloNumeros(sender, e);
        }

        private void validarLetrayNumero(object sender, KeyPressEventArgs e)
        {
            v.validateLetrasNumeros(sender, e);
        }
    }
}
