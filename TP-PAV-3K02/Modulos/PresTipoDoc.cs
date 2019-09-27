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
using TP_PAV_3K02.BaseDatos;
using TP_PAV_3K02.Modelos;

namespace TP_PAV_3K02.Modulos
{
    public partial class PresTipoDoc : Form
    {
        TipoDocumentoRepositorio _tipodocumentoRepositorio;
        // LocalidadesRepositorio _localidadesRepositorio;
        Editorial_BD _BD;

        public PresTipoDoc()
        {
            InitializeComponent();
        }

        private void PresTipoDoc_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.TipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dataSet1.TipoDocumento);
            // TODO: esta línea de código carga datos en la tabla 'empleadosDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.empleadosDataSet.Empleados);

        }

        public void NuevoTipoDoc()
        {
            InitializeComponent();
            _tipodocumentoRepositorio = new TipoDocumentoRepositorio();
            //_localidadesRepositorio = new LocalidadesRepositorio();
            _BD = new Editorial_BD();
        }

        private void ActualizarTipos()
        {

            dgvTipoDoc.Rows.Clear();

            var tiposDoc = _tipodocumentoRepositorio.ObetenerTiposDocumentosDT().Rows;
            var filas = new List<DataGridViewRow>();

            foreach (DataRow tipoDoc in tiposDoc)
            {
                if (tipoDoc.HasErrors)
                    continue;//no corto el ciclo
                var fila = new string[]
                {
                    tipoDoc.ItemArray[0].ToString(),
                    tipoDoc.ItemArray[1].ToString()
                };

                dgvTipoDoc.Rows.Add(fila);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var tipoDoc = new TipoDocumento();
            tipoDoc.cod_TipoDoc = int.Parse(txtNum.Text);
            tipoDoc.nombre = txtNom.Text;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ActualizarTipos();
        }

        private void PresTipoDoc_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.Suscriptores' Puede moverla o quitarla según sea necesario.
            this.suscriptoresTableAdapter.Fill(this.dataSet11.Suscriptores);

        }
    }
}
