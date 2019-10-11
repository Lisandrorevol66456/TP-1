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
            string sqltxt = "SELECT * FROM Distribuidores Where cuit_dist =" +cuit;

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
            string sqltxt = $"DELETE FROM [dbo].[Distribuidores] WHERE cuit_dist= {distribuidornrocuit}";

            return _BD.EjecutarSQL(sqltxt);
        }

        public Distribuidor ObtenerDistribuidor(string cuit)
        {
            string sqltxt = $"SELECT * FROM [dbo].[Distribuidores] Where cuit_dist ='{cuit}'";
            var tablaTemporal = _BD.consulta(sqltxt);
            if (tablaTemporal.Rows.Count == 0)
                return null;

            var distribuidor = new Distribuidor();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                distribuidor.cuit_dist = long.Parse(fila.ItemArray[0].ToString());
                distribuidor.nombre = fila.ItemArray[1].ToString();
                distribuidor.apellido = fila.ItemArray[2].ToString();
                distribuidor.domicilio = fila.ItemArray[3].ToString();
              


            }
            return distribuidor;
        }

        public bool Actualizar(Distribuidor dist, string cuit)
        {
            string sqltext = $"UPDATE [dbo].[Distribuidores] SET cuit_dist = '{dist.cuit_dist}' , "+
                $" nombre =  '{dist.nombre}' , " +
                $" apellido = '{dist.apellido}', " +
                $" domicilio = '{dist.domicilio}' ," +
                $" fecha_inicio = '{dist.fecha_inicio.ToString("yyyy-MM-dd")}' where cuit_dist = {cuit} ";

            return _BD.EjecutarSQL(sqltext);


        }

        public bool Validar(string cuit)
        {
            string sqltext = $"SELECT * From Distribuidores where cuit_dist = {cuit}";

            var tabla = _BD.consulta(sqltext);

            var filas = tabla.Rows;

            if (filas.Count > 0)
                return true;
            return false;
        }

    }
}
