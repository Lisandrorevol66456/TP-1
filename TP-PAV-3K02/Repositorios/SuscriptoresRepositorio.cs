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
        public bool Eliminar(string suscriptornroDoc)
        {
            string sqltxt = $"DELETE FROM [dbo].[Suscriptores] WHERE id = {suscriptornroDoc}";

            return _BD.EjecutarSQL(sqltxt);
        }
        public Suscriptor ObtenerSuscriptor(string nroDoc)
        {
            string sqltxt = $"SELECT * FROM [dbo].[Suscriptores] where id={nroDoc}";
            var tablaTemporal = _BD.consulta(sqltxt);
            if (tablaTemporal.Rows.Count == 0)
                return null;
            var suscriptor = new Suscriptor();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo


            }
            return suscriptor;

        }
    }
}
