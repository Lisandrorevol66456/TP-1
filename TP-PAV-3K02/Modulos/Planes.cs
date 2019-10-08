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
            var plan = new Plan();

            plan.cod_Plan = 10;
            plan.cod_int = 00;
            plan.fechaInicial = DateTime.Today;
            plan.fechaFin = DateTime.Today.AddYears(1);
            plan.Precio = 200;

            DialogResult result = MessageBox.Show("¿Estas seguro/a de elejir este plan?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                _planesRepos.guardar(plan);
            else
                this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var plan = new Plan();

            plan.cod_Plan = 20;
            plan.cod_int = 01;
            plan.fechaInicial = DateTime.Today;
            plan.fechaFin = DateTime.Today.AddYears(1);
            plan.Precio = 400;

            DialogResult result = MessageBox.Show("¿Estas seguro/a de elejir este plan?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                _planesRepos.guardar(plan);
            else
                this.Dispose();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var plan = new Plan();

            plan.cod_Plan = 30;
            plan.cod_int = 02;
            plan.fechaInicial = DateTime.Today;
            plan.fechaFin = DateTime.Today.AddYears(1);
            plan.Precio = 500;

            DialogResult result = MessageBox.Show("¿Estas seguro/a de elejir este plan?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                _planesRepos.guardar(plan);
            else
                this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
