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

                empresa.cuit_Empresa = long.Parse(fila.ItemArray[0].ToString()); // numero documento
                empresa.nombre = fila.ItemArray[1].ToString(); // Nombre
                empresa.apellido = fila.ItemArray[2].ToString(); // apellido
                empresa.domicilio = fila.ItemArray[3].ToString(); // calle
                empresa.cod_calificacion = int.Parse(fila.ItemArray[6].ToString());

            
            }

            return empresa;
        }
        public DataTable ObtenerPornroCUIT(long cuit)
        {
            string sqltxt = "SELECT * FROM Empresas Where cuit_Empresa=" + cuit;

            return _BD.consulta(sqltxt);
        }


        public bool guardar(Empresa empresa)
        {
            string sqlTxt = $"INSERT [dbo].[Empresas] ([cuit_Empresa], [nombre], [apellido], " +
                $"[domicilio], [fecha_Inicio],[fecha_cal],[cod_calificacion])" +
                $"VALUES ('{empresa.cuit_Empresa}', '{empresa.nombre}', '{empresa.apellido}', '{empresa.domicilio}'," +
                $"'{empresa.fecha_Inicio.ToString("yyyy-MM-dd")}','{empresa.fecha_cal.ToString("yyyy-MM-dd")}','{empresa.cod_calificacion}')";

            return _BD.EjecutarSQL(sqlTxt);
        }
        public bool calificar(Empresa empresa, string cuit_empre)
        {
            string sqltxt = $"UPDATE [dbo].[Empresas] SET fecha_cal ='{empresa.fecha_cal.ToString("yyyy-MM-dd")}', " +
                $" cod_calificacion = '{empresa.cod_calificacion}' WHERE cuit_Empresa = {cuit_empre}";

            return _BD.EjecutarSQL(sqltxt);
        }

        public bool eliminar(string cuit)
        {
            string sqlTxt = $"DELETE FROM [dbo].[Empresas] WHERE cuit_Empresa ={cuit}";

            return _BD.EjecutarSQL(sqlTxt);
        }

        public bool actualizar(Empresa empresa, string empresaCuit)
        {
            string sqlTxt = "UPDATE [dbo].[Empresas] SET cuit_Empresa= '{empresa.cuit_Empresa}'," +
                $" nombre='{empresa.nombre}'," +
                $" apellido = '{empresa.apellido}'," +
                $" domicilio ='{empresa.domicilio}'," +
                $" fecha_Inicio = '{empresa.fecha_Inicio.ToString("yyyy-MM-dd")}'," +
                $" cod_calificacion = '{empresa.cod_calificacion}' WHERE cuit_Empresa ={empresaCuit}";

            return _BD.EjecutarSQL(sqlTxt);
        }

        public bool Validar(string cuit)
        {
            string sqltext = $"SELECT * From Empresas where cuit_Empresa = {cuit}";

            var tabla = _BD.consulta(sqltext);

            var filas = tabla.Rows;

            if (filas.Count > 0)
                return true;
            return false;
        }
    }
}