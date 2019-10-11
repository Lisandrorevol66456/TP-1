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

        public bool Guardar(Revista revista)
        {
            
                string sqltext = $"INSERT [dbo].[Revistas] ([cod_Interno],[nombre],[cod_frecPublic],[cod_rubro],[fechaInicio])" +
                $"VALUES('{revista.cod_Interno}','{revista.nombre}','{revista.cod_frecPublic}','{revista.cod_rubro}'," +
                $"'{revista.fechaInicio.ToString("yyyy-MM-dd")}') ";

                return _BD.EjecutarSQL(sqltext);
            
            
           
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




    }
}
