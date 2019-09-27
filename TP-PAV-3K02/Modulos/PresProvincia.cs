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

namespace TP_PAV_3K02.Modelos
{
    public partial class PresProvincia : Form
    {
        ProvinciasRepositorio _provincia;

        public PresProvincia()
        {
            InitializeComponent();
            _provincia = new ProvinciasRepositorio();
        }

        private void PresProvincia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter.Fill(this.dataSet1.Provincias);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var prov = new Provincia();
            prov.cod_provincia = int.Parse(txtNum.Text);
            prov.nombre = txtNom.Text;
            
        }

        public void Actualizar()
        {
            dgvProvincia.Rows.Clear();
            var seleccionadas = _provincia.ObtenerProvinciasDT().Rows;
            var filas = new List<DataGridViewRow>();

            foreach (DataRow seleccionada in seleccionadas)
            {
                if (seleccionada.HasErrors)
                    continue;
                var fila = new string[]
                {
                seleccionada.ItemArray[0].ToString(),
                seleccionada.ItemArray[1].ToString()
                };
                dgvProvincia.Rows.Add(fila);
            }

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
