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

        public IList<Plan> obtenerPlanesByDoc()
        {
            string sqlTxt = $"SELECT * FROM Planes ";

            var tmp = _BD.consulta(sqlTxt);
            var pla = new List<Plan>();

            foreach (DataRow fila in tmp.Rows)
            {
                if (fila.HasErrors)
                    continue;

                DateTime fechaI = DateTime.Today;
                DateTime fechaF = DateTime.Today.AddYears(1);
                DateTime.TryParse(fila.ItemArray[3]?.ToString(), out fechaI);
                DateTime.TryParse(fila.ItemArray[4]?.ToString(), out fechaF);

                var p = new Plan();
                
                p.fechaInicial = fechaI;
                p.fechaFin = fechaF;
                p.Precio = int.Parse(fila.ItemArray[4].ToString());

                pla.Add(p);
            }
            return pla;
        }

        public DataTable obtenerPlanesByDoc(string prec)
        {
            string sqlText = $"SELECT * FROM Planes WHERE precio = {prec}";

            return _BD.consulta(sqlText);
        }
         public DataTable obtenerPlanes()
        {
            string sqlText = $"SELECT * FROM Planes";

            return _BD.consulta(sqlText);
        }

        public DataTable obtenerPlanesByValue(string value)
        {
            string sqlText = $"SELECT precio FROM Planes WHERE cod_Plan = {value}";

            return _BD.consulta(sqlText);
        }

        public bool guardar(Plan plan)
        {
            string sqlText = $"INSERT [dbo].[Planes] ([fecha_inicio], [fecha_fin], [precio])" +
                $"VALUES('{plan.fechaInicial}', '{plan.fechaFin}', '{plan.Precio}')";
            return _BD.EjecutarSQL(sqlText);
        }

    }
}