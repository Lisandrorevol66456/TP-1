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
using TP_PAV_3K02.REPORTES.rep_publicidad;
using TP_PAV_3K02.REPORTES.rep_revista;
using TP_PAV_3K02.REPORTES.rep_suscripcion;
using TP_PAV_3K02.REPORTES.rep_suscriptores;

namespace TP_PAV_3K02
{
    public partial class FormINICIO : Form
    {
        public FormINICIO()
        {
            InitializeComponent();
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

        

        private void distribucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var distri = new INFOdistribucion();
            distri.ShowDialog();
        }

        private void vigentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vigen = new INFO_publicidadVigente();
            vigen.ShowDialog();
        }

        private void empresasConMasPublicidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var empre = new INFO_empresaConMasPublicidad();
            empre.ShowDialog();
        }

        private void listadoDeEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = new INFO_empresas();
            list.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rep_susc = new INFO_suscriptores();
            rep_susc.ShowDialog();
        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var rep_rev = new INFO_revistas();
            rep_rev.ShowDialog();
        }

        private void másVendidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var masvend = new INFO_revistasMasVendidas();
            masvend.ShowDialog();
        }

        private void listadoDeDistribuidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dis = new INFO_distribuidores();
            dis.ShowDialog();
        }

        private void revistaConMásSuscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var revi = new INFO_revistaConMasSuscriptores();
            revi.ShowDialog();
        }

        private void planesMásElegidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var planes = new INFO_planesMasElegidos();
            planes.ShowDialog();
        }

        private void mayoresDistribuidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mayores = new INFO_MayoresDistribuidores();
            mayores.ShowDialog();
        }
    }
}
