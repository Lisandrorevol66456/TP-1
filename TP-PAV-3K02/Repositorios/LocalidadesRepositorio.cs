using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K02.BaseDatos;

namespace TP_PAV_3K02.Repositorios
{
    class LocalidadesRepositorio
    {
        private Editorial_BD _BD;

        public LocalidadesRepositorio()
        {
            _BD = new Editorial_BD();
        }

        public DataTable ObtenerLocalidadesDT(string prov)
        {

            string sqltext = $"SELECT * FROM [dbo].[Localidades] WHERE cod_provincia ='{prov}'";
            var LocalidadesDTRows = _BD.consulta(sqltext);
            return LocalidadesDTRows;

        }


    }
}
