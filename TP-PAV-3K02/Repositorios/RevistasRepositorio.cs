using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K02.BaseDatos;
using TP_PAV_3K02.Modelos;
using TP_PAV_3K02.Modulos;

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
            string sqltext = "SELECT  r.cod_Interno, r.nombre, ru.nombre AS Rubro, fp.nombre AS FRECUENCIA, r.fechaInicio AS FECHA" +
                " FROM Revistas AS r INNER JOIN Rubro AS ru ON r.cod_rubro = ru.cod_Rubro" +
                " INNER JOIN FrecuenciaPublicacion AS fp ON r.cod_frecPublic = fp.cod_Frecuencia ";

            return _BD.consulta(sqltext);

        }

        public DataTable ObtenerMontosDT()
        {
            string sqltext = "SELECT * FROM Precios";

            return _BD.consulta(sqltext);
        }
        public bool Guardar(Revista revista)
        {
            
                string sqltext = $"INSERT [dbo].[Revistas] ([nombre],[cod_frecPublic],[cod_rubro],[fechaInicio])" +
                $"VALUES('{revista.nombre}','{revista.cod_frecPublic}','{revista.cod_rubro}'," +
                $"'{revista.fechaInicio.ToString("yyyy-MM-dd")}') ";

                return _BD.EjecutarSQL(sqltext);
            
            
         
        }

        public DataTable ObtenerPorCodigo(int cod)
        {
            string sqltext = $"SELECT * FROM Revistas where cod_Interno = {cod}";

            return _BD.consulta(sqltext);
        }

        public  Revista ObtenerRevistas(string codRevista)
        {
            string sqltxt = $"SELECT * FROM [dbo].[Revistas] WHERE cod_Interno = {codRevista}";
            var tablaTemporal = _BD.consulta(sqltxt);


            if (tablaTemporal.Rows.Count == 0)
                return null;

            var rev = new Revista();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                rev.cod_Interno = int.Parse(fila.ItemArray[0].ToString());
                rev.nombre = fila.ItemArray[1].ToString();
                rev.cod_frecPublic = int.Parse(fila.ItemArray[2].ToString());
                rev.cod_rubro = int.Parse(fila.ItemArray[3].ToString());
               


            }

            return rev;

        }

        public bool ValidarCod(string cod)
        {
            string sqltxt = $"SELECT * FROM Revistas where cod_Interno ={cod}";

            var tablaResultante = _BD.consulta(sqltxt);

            var filas = tablaResultante.Rows;

            if (filas.Count > 0)
                return true;
            return false;


        }



        public bool Eliminar(string cod)
        {
            string sqltxt = $"DELETE [dbo].[Revistas] where cod_Interno = {cod}";

            return _BD.EjecutarSQL(sqltxt);

        }

        public bool Actualizar(Revista revista, string cod)
        {
            string sqltext = $"UPDATE [dbo].[Revistas] SET  nombre = '{revista.nombre}' , " +
                $" cod_frecPublic = '{revista.cod_frecPublic}', " +
                $" cod_rubro = '{revista.cod_rubro}' ," +
                $" fechaInicio = '{revista.fechaInicio.ToString("yyyy-MM-dd")}' where cod_Interno = {cod}";

            return _BD.EjecutarSQL(sqltext);


        }



    }
}
