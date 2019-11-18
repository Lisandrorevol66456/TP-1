using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3K02.REPORTES.rep_publicidad
{
    public partial class INFO_publicidadVigente : Form
    {
        public INFO_publicidadVigente()
        {
            InitializeComponent();
        }

        private void INFO_publicidad_Load(object sender, EventArgs e)
        {

            this.RV_publicidades.RefreshReport();
        }
    }
}
