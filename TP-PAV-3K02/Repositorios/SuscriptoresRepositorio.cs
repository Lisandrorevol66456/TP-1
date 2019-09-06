using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K02.BaseDatos;
using TP_PAV_3K02.Modelos;

namespace TP_PAV_3K02.Repositorios
{
    public class SuscriptoresRepositorio
    {

        private Editorial_BD _BD;

        public SuscriptoresRepositorio()
        {
            _BD = new Editorial_BD();
        }

        public bool Guardar(Suscriptor suscriptor)
        {
            string sqltxt = $"INSERT [dbo].[Suscriptores] ([nroDoc],[nombre], [apellido], [calle],[numero]) " +
                $"VALUES ('{suscriptor.nombre}', " + $"'{suscriptor.apellido}', '{suscriptor.calle}', {suscriptor.nroDoc},{suscriptor.numero}";

            return _BD.EjecutarSQL(sqltxt);
        }




    }
}
