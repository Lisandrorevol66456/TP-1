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

        public DataTable ObtenerSuscriptoresDT()
        {
            string sqltxt = "SELECT * FROM Suscriptores ";
            
            return _BD.consulta(sqltxt);

        }
        public DataTable ObtenerPorDNI(long dni)
        {
            string sqltxt = "SELECT * FROM Suscriptores Where nroDoc="+ dni;

            return _BD.consulta(sqltxt);
        }

        public bool Guardar(Suscriptor suscriptor)
        {
            string sqltxt = $"INSERT [dbo].[Suscriptores] ([nroDoc],[cod_TipoDoc],[nombre], [apellido], [calle],[numero],[cod_Provincia]) " +
                $"VALUES ('{suscriptor.nroDoc}', " + 
                $"'{suscriptor.cod_TipoDoc}','{suscriptor.nombre}','{suscriptor.apellido}','{suscriptor.calle}','{suscriptor.numero}','{suscriptor.cod_Provincia}')";

            return _BD.EjecutarSQL(sqltxt);
        }
        public bool Eliminar(string suscriptornroDoc)
        {
            string sqltxt = $"DELETE FROM [dbo].[Suscriptores] WHERE nroDoc ='{suscriptornroDoc}'";

            return _BD.EjecutarSQL(sqltxt);
        }
        /*public Suscriptor ObtenerSuscriptor(string nroDoc)
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

        }*/
    }
}
