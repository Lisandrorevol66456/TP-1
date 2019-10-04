using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K02.BaseDatos;

namespace TP_PAV_3K02.Repositorios
{
    public class RubrosRepositorio
    {

        private Editorial_BD _BD;

        public RubrosRepositorio()
        {
            _BD = new Editorial_BD();
        }

        public DataTable ObtenerRubrosDT()
        {
            string sqltext = "SELECT * FROM Rubro ";

            return _BD.consulta(sqltext);
        }


    }
}
