using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K02.BaseDatos;

namespace TP_PAV_3K02.Repositorios
{
    class CalificacionesRepositorio
    {
        private Editorial_BD _BD;

        public CalificacionesRepositorio()
        {
            _BD = new Editorial_BD();
        }
        public DataTable ObtenerCalificacionesDT()
        {
            string sqltext = "SELECT * FROM Calificaciones";
            var calificacionesDTRows = _BD.consulta(sqltext);
            return calificacionesDTRows;

        }
    }
}
