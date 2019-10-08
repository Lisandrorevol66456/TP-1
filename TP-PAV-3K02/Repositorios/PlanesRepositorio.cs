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
    public class PlanesRepositorio
    {
        Editorial_BD _BD;

        public PlanesRepositorio()
        {
            _BD = new Editorial_BD();
        }

        public DataTable obtenerPlanes()
        {
            string sqlText = $"SELECT * FROM Planes";

            return _BD.consulta(sqlText);
        }

        public DataTable obtenerPlanesByCod(int cod)
        {
            string sqlText = $"SELECT * FROM Planes WHERE cod_plan =" + cod;

            return _BD.consulta(sqlText); 
        }

        public bool guardar(Plan plan)
        {
            string sqlText = $"INSERT [dbo].[Planes] ([cod_Plan], [cod_Int], [fecha_inicio], [fecha_fin], [precio])" +
                $"VALUES('{plan.cod_Plan}', '{plan.cod_int}', '{plan.fechaInicial}', '{plan.fechaFin}', '{plan.Precio}')";
            return _BD.EjecutarSQL(sqlText);
        }

    }
}