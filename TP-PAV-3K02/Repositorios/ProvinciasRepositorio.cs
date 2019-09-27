using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K02.BaseDatos;
using TP_PAV_3K02.Modelos;

namespace TP_PAV_3K02.Repositorios
{
    class ProvinciasRepositorio
    {
        private Editorial_BD _BD;
        public ProvinciasRepositorio()
        {
            _BD = new Editorial_BD();
        }
        /*public List<Provincia> ObtenerProvincia()
        {
            var provinciasDTRows = ObtenerProvinciasDT().Rows;//contiene las provincias

            var provincia = new List<Provincia>();
            foreach (DataRow fila in provinciasDTRows)
            {
                if (fila.HasErrors)
                    continue;// detecta si hay un error en alguna fila
                var provincias = new Provincia()
                {
                    cod_provincia = Convert.ToInt32(fila[0]),
                    nombre = fila[1].ToString()
                };
                provincia.Add(provincias);
            }

            return provincia;
        }*/

        public DataTable ObtenerProvinciasDT()
        {
            string sqltext = "SELECT * FROM Provincias";
            var provinciasDTRows = _BD.consulta(sqltext);
            return provinciasDTRows;

        }
    }
}
