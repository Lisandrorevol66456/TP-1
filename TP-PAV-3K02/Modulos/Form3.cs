using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K02.Utils;
using TP_PAV_3K02.Modelos;
using TP_PAV_3K02.Repositorios;


namespace TP_PAV_3K02.Modulos
{
    public partial class Suscripciones : Form
    {

        ValidateTextBox v;
        SuscripcionesRepositorios repos;


        public Suscripciones()
        {
            InitializeComponent();
            v = new ValidateTextBox();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            

            Planes frm = new Planes();

            frm.Show();
        }

        private void ValidateSoloNumeros(object sender, KeyPressEventArgs e)
        {
            v.ValidateSoloNumeros(sender, e);

        }

        private void Suscripciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Suscripcion' Puede moverla o quitarla según sea necesario.
            this.suscripcionTableAdapter.Fill(this.dataSet1.Suscripcion);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            

            var s = new Suscripcion();

            

            DateTime fechaI = DateTime.Today;
            DateTime fechaF = DateTime.Today.AddYears(1);

            s.nro_doc = int.Parse(txtDoc.Text);
            s.cod_TipoDoc = cmbTipoDoc.SelectedIndex;
            s.cod_int = int.Parse(txtCodInt.Text);
            s.fecha_inicio = fechaI;
            s.fecha_fin = fechaF;
            

            repos.guardar(s);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public Plan guardarPlan()
        {
            var combo = cmbTipoDoc.
        }
    }
}
