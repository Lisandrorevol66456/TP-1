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
    public class EmpresasRepositorio
    {
        private Editorial_BD _BD;

        public EmpresasRepositorio()
        {
           _BD = new Editorial_BD();
        }

        public DataTable ObtenerEmpresa()
        {
            string sqlTxt = $"SELECT * FROM Empresas ";
            var EmpresasDTRows = _BD.consulta(sqlTxt);
            return EmpresasDTRows;
        }

        public Empresa ObtenerPorCuit(string cuit)
        {
            string sqlTxt = $"SELECT * FROM [dbo].[Empresas] WHERE cuit_Empresa ={cuit}";
            var tablaTemporal = _BD.consulta(sqlTxt);


            if (tablaTemporal.Rows.Count == 0)
                return null;

            var empresa = new Empresa();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                empresa.cuit = long.Parse(fila.ItemArray[0].ToString()); // numero documento
                
                empresa.nombre = fila.ItemArray[1].ToString(); // Nombre
                empresa.apellido = fila.ItemArray[2].ToString(); // apellido
                empresa.domicilio = fila.ItemArray[3].ToString(); // calle
                empresa.codCal = int.Parse(fila.ItemArray[5].ToString());

                // tratamiento de fechas
                DateTime fecha = DateTime.MinValue;

                // Si lo que esta en la BD de datos se puede parsear a date se lo parsea y almacena en la variable
                DateTime.TryParse(fila.ItemArray[4]?.ToString(), out fecha);
                empresa.fechaI = fecha; // fecha
            }

            return empresa;
        }

        public bool guardar(Empresa empresa)
        {
            string sqlTxt = $"INSERT [dbo].[Empresas] ([cuit_Empresa], [nombre], [apellido], " +
                $"[domicilio], [fecha_Inicio], [cod_calificacion])" +
                $"VALUES ('{empresa.cuit}', '{empresa.nombre}', '{empresa.apellido}', '{empresa.domicilio}'," +
                $"'{empresa.fechaI.ToString("yyyy-MM-dd")}','{empresa.codCal}')";

            return _BD.EjecutarSQL(sqlTxt);
        }

        public bool eliminar(string cuit)
        {
            string sqlTxt = $"DELETE FROM [dbo].[Empresas] WHERE cuit_Empresas ='{cuit}'";

            return _BD.EjecutarSQL(sqlTxt);
        }

        public bool actualizar(Empresa empresa)
        {
            string sqlTxt = "UPDATE [dbo].[Empresas] SET ([cuit_Empresa], [nombre], [apellido],"+
                $"[domicilio], [fecha_Inicio], [cod_calificacion])"+
                 $"VALUES ('{empresa.cuit}', '{empresa.nombre}', '{empresa.apellido}', '{empresa.domicilio}'," +
                $"'{empresa.codCal}')";

            return _BD.EjecutarSQL(sqlTxt);
        } 
    }
}