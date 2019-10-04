using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K02.BaseDatos;

namespace TP_PAV_3K02.Repositorios
{
    public class RevistasRepositorio
    {
        private Editorial_BD _BD;

        public RevistasRepositorio()
        {
            _BD = new Editorial_BD();

        }
        
        public DataTable ObtenerRevistasDT()
        {
            string sqltext = "SELECT * FROM Revistas ";

            return _BD.consulta(sqltext);



        }
      
    }
}
