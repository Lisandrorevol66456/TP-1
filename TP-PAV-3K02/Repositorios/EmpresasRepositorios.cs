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
    class EmpresasRepositorio
    {
        private Editorial_BD _BD;
        private 

        public EmpresasRepositorio()
        {
            var _BD = new Editorial_BD();
        }

        public DataTable ObtenerEmpresa()
        {
            string sqlTxt = $"SELECT * FROM Empresas ";
            var EmpresasDTRows = _BD.consulta(sqlTxt);
            return EmpresasDTRows;
        }

        public DataTable ObtenerPorCuit(long cuit)
        {
            string sqlTxt = $"SELECT * FROM Empresas WHERE cuit_Empresa =" + cuit;
            return _BD.consulta(sqlTxt);
        }

        public bool guardar(Empresa empresa)
        {
            string sqlTxt = $"INSERT [dbo].[Empresas] ([cuit_Empresa], [nombre], [apellido], " +
                $"[domicilio], [fecha_Inicio], [cod_calificacion])" +
                $"VALUES ('{empresa.cuit}', '{empresa.nombre}', '{empresa.apellido}', '{empresa.domicilio}'," +
                $"'{empresa.codCal}')";

            return _BD.EjecutarSQL(sqlTxt);
        }

        public bool eliminar(Empresa empresa)
        {
            string sqlTxt = $"DELETE FROM [dbo].[Empresas] WHERE cuit_Empresas ='{empresa.cuit}'";

            return _BD.EjecutarSQL(sqlTxt);
        }

        public bool actualizar(Empresa empresa)
        {
            string sqlTxt = "UPDATE [dbo].[Empresas] SET ([cuit_Empresa], [nombre], [apellido],"+
                $"[domicilio], [fecha_Inicio], [cod_calificacion])"+
                 $"VALUES ('{empresa.cuit}', '{empresa.nombre}', '{empresa.apellido}', '{empresa.domicilio}'," +
                $"'{empresa.codCal}')";

            return _BD.EjecutarSQL(sqlTxt)
        } 
    }
}