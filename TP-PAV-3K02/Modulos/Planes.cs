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
using TP_PAV_3K02.Modelos;

namespace TP_PAV_3K02.Modulos
{
    public partial class Planes : Form
    {

        PlanesRepositorio _planesRepos;

        public Planes()
        {
            InitializeComponent();
            _planesRepos = new PlanesRepositorio();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Plan p = new Plan(10,  00, DateTime.Today, DateTime.Today.AddYears(1), 200);

            DialogResult result = MessageBox.Show("¿Estas seguro/a de elejir este plan?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _planesRepos.guardar(p);
                this.Dispose();
            }
            else
                this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Plan p = new Plan(20, 01, DateTime.Today, DateTime.Today.AddYears(1), 400);
            
            DialogResult result = MessageBox.Show("¿Estas seguro/a de elejir este plan?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _planesRepos.guardar(p);
                this.Dispose();
            }
            else
                this.Dispose();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Plan p = new Plan(30, 02, DateTime.Today, DateTime.Today.AddYears(1), 500);

            DialogResult result = MessageBox.Show("¿Estas seguro/a de elejir este plan?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                _planesRepos.guardar(p);
            else
                this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
