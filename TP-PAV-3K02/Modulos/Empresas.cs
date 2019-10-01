using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K02.Modelos;
using TP_PAV_3K02.Repositorios;

namespace TP_PAV_3K02.Modulos
{
    public partial class Empresas : Form
    {
        EmpresasRepositorio _ORepoEmp;
        Empresa _empresa;

        public Empresas()
        {
            InitializeComponent();
            _ORepoEmp = new EmpresasRepositorio();
        }

        private void Peliculas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Empresas' Puede moverla o quitarla según sea necesario.
            this.empresasTableAdapter.Fill(this.dataSet1.Empresas);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var empresa = new Empresa();
            empresa.nombre = txtnombre.Text;
            empresa.apellido = txtApellido.Text;
            empresa.cuit = long.Parse(TxtCuit.Text);
            empresa.domicilio = TxtDomicilio.Text;
            empresa.fechaI = DTPfechainicio.Value.Date;
            empresa.codCal = int.Parse(cmbCodCal.SelectedIndex.ToString());

            _ORepoEmp.guardar(empresa);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var seleccionada = dgvEmpresas.SelectedRows;

            foreach (DataGridViewRow fila in seleccionada)
            {
                var cuit = fila.Cells[0].Value;
                var nombre = fila.Cells[1].Value;
                var apellido = fila.Cells[0].Value;
                var domicilio = fila.Cells[0].Value;
                var fechaI = fila.Cells[0].Value;
                var codCal = fila.Cells[0].Value;
            }
            
        }
    }
}
