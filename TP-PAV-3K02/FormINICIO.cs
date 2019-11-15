using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K02.Modulos;
using TP_PAV_3K02.REPORTES.rep_distri;
using TP_PAV_3K02.REPORTES.rep_distribuidores;
using TP_PAV_3K02.REPORTES.rep_empresas;
using TP_PAV_3K02.REPORTES.rep_revista;
using TP_PAV_3K02.REPORTES.rep_suscriptores;

namespace TP_PAV_3K02
{
    public partial class FormINICIO : Form
    {
        public FormINICIO()
        {
            InitializeComponent();
        }

        private void FormINICIO_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            var frm = new Empresas();

            frm.ShowDialog();
        }

        private void btnSuscriptores_Click(object sender, EventArgs e)
        {
            var frm = new NuevoSuscriptor();

            frm.ShowDialog();
        }

        private void btnDist_Click(object sender, EventArgs e)
        {
            var di = new FormDistribuidores();
            di.ShowDialog();
        }

        private void btnRevista_Click(object sender, EventArgs e)
        {
            var rev = new Revistas();
            rev.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show($"¿Está seguro que desea salir?",
                   "Usted está por salir",
                   MessageBoxButtons.YesNo);

            if (confirmacion.Equals(DialogResult.No))
                return;

            this.Close();
        }

        private void suscriptoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rep_susc = new INFO_suscriptores();
            rep_susc.ShowDialog();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rep_emp = new INFO_empresas();
            rep_emp.ShowDialog();
        }

        private void revistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rep_rev = new INFO_revistas();
            rep_rev.ShowDialog();
        }

        private void distribuidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dis = new INFO_distribuidores();
            dis.ShowDialog();
        }

        private void distribucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var distri = new INFOdistribucion();
            distri.ShowDialog();
        }
    }
}
