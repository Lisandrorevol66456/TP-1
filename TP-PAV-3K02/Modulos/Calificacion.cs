using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K02.BaseDatos;
using TP_PAV_3K02.Modelos;
using TP_PAV_3K02.Repositorios;

namespace TP_PAV_3K02.Modulos
{
    public partial class Calificacion : Form
    {
        CalificacionesRepositorio _calificacionRepositorio;
        EmpresasRepositorio _empresasRepositorio;
        Editorial_BD _BD;
        Empresa empresa;
        public Calificacion()
        {
            InitializeComponent();
            
        }
        public Calificacion(string nrocuit)
        {
            InitializeComponent();
            _empresasRepositorio = new EmpresasRepositorio();
            _calificacionRepositorio = new CalificacionesRepositorio();
            empresa = _empresasRepositorio.ObtenerPorCuit(nrocuit);
            _BD = new Editorial_BD();
        }
        private void CargaCombo()
        {
            var calificacion = _calificacionRepositorio.ObtenerCalificacionesDT();
            cmbCodCal.ValueMember = "cod_Calificaciones";
            cmbCodCal.DisplayMember = "nombre";
            cmbCodCal.DataSource = calificacion;
        }
        private void Calificacion_Load(object sender, EventArgs e)
        {
            CargaCombo();
            TxtCuit.Text = empresa.cuit_Empresa.ToString();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            empresa.cod_calificacion = int.Parse(cmbCodCal.SelectedValue.ToString());

            DateTime fecha = DateTime.MinValue;
            DateTime.TryParse(DTPfechacal.ToString(), out fecha);
            empresa.fecha_cal = fecha; // fecha

            if (_empresasRepositorio.calificar(empresa, TxtCuit.Text.ToString()))
            {
                MessageBox.Show("Se Calificó con éxito");
                this.Dispose();//Libera los recursos

            }




        }
    }
}
