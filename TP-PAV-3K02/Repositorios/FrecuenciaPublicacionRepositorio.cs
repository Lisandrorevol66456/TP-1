using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K02.BaseDatos;

namespace TP_PAV_3K02.Repositorios
{
    public class FrecuenciaPublicacionRepositorio
    {
        private Editorial_BD _BD;

        public FrecuenciaPublicacionRepositorio()
        {
            _BD = new Editorial_BD();
        }
        
        public DataTable ObtenerFrecuenciaPublicacionDT()
        {
            string sqltext = "SELECT * FROM FrecuenciaPublicacion ";

            return _BD.consulta(sqltext);
        }
    }
}
