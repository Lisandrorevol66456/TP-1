using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K02.Repositorios;

namespace TP_PAV_3K02.Modulos
{
    public partial class EditarSuscripcion : Form
    {
        SuscripcionesRepositorios repos;

        public EditarSuscripcion()
        {
            InitializeComponent();
            repos = new SuscripcionesRepositorios();
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
