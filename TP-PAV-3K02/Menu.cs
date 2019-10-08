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

namespace TP_PAV_3K02
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDistribuidores frm = new FormDistribuidores();

            frm.Show();
        }

        private void btnSuscriptores_Click(object sender, EventArgs e)
        {
            NuevoSuscriptor frm = new NuevoSuscriptor();

            frm.Show();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            Empresas frm = new Empresas();

            frm.Show();
        }

        private void btnRevista_Click(object sender, EventArgs e)
        {
            Revistas frm = new Revistas();

            frm.Show();
        }
    }
}
