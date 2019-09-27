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
   public class DistribuidoresRepositorio
    {

        private Editorial_BD _BD;

        public DistribuidoresRepositorio()
        {
            _BD = new Editorial_BD();
        }

        public DataTable ObtenerDistribuidoresDT()
        {
            string sqltext = "SELECT * FROM Distribuidores";
            return _BD.consulta(sqltext);

        }
        public DataTable ObtenerPorcuit(long cuit)
        {
            string sqltxt = "SELECT * FROM Distribuidores Where nroDoc=" + cuit;

            return _BD.consulta(sqltxt);
        }
        public bool Guardar(Distribuidor distribuidor)
        {
            string sqltxt = $"INSERT [dbo].[Distribuidores] ([cuit_dist],[nombre],[apellido],[domicilio],[fecha_inicio]) " +
                $"VALUES ('{distribuidor.cuit_dist}','{distribuidor.nombre}', " +
                $"'{distribuidor.apellido}', '{distribuidor.domicilio}', '{distribuidor.fecha_inicio.ToString("yyyy-MM-dd")}')";

            return _BD.EjecutarSQL(sqltxt);
        }
        public bool Eliminar(string distribuidornrocuit)
        {
            string sqltxt = $"DELETE FROM [dbo].[Distribuidores] WHERE cuit_dist = {distribuidornrocuit}";

            return _BD.EjecutarSQL(sqltxt);
        }

        /*public Distribuidor ObtenerDistribuidor(string cuit_dist)
        {
            string sqltxt = $"SELECT * FROM [dbo].[Distribuidores] where id={cuit_dist}";
            var tablaTemporal = _BD.consulta(sqltxt);
            if (tablaTemporal.Rows.Count == 0)
                return null;
            var distribuidor = new Distribuidor();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo


            }
            return distribuidor;
        }*/
    }
}
