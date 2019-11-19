using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3K02.REPORTES.rep_suscripciones
{
    public partial class INFO_suscripciones : Form
    {
        public INFO_suscripciones()
        {
            InitializeComponent();
        }

        private void INFO_suscripciones_Load(object sender, EventArgs e)
        {

            this.RV_suscripciones.RefreshReport();
        }
    }
}
