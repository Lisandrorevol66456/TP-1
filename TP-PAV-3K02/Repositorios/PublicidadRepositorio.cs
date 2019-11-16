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
    class PublicidadRepositorio
    {
        private Editorial_BD _BD;

        public PublicidadRepositorio()
        {
            _BD = new Editorial_BD();

        }
        public DataTable ObtenerPublicidadporcuitDT(string cuit)
        {
            string sqlTxt = $"SELECT  p.ID_publicidad, p.cuit_Empresa AS CUIT, r.nombre AS Revista," +
                $" p.fecha_desde AS DESDE, p.fecha_hasta AS HASTA, p.monto FROM Detalle_Publicidad AS p" +
                $" INNER JOIN Revistas AS r ON p.ID_revista = r.cod_Interno Where p.cuit_Empresa ='{cuit}'";
            var PublicidadDTRows = _BD.consulta(sqlTxt);
            return PublicidadDTRows;
        }
        public DataTable ObtenerPublicidadporcuityfechaDT(string cuit, string fechadesde, string fechahasta)
        {
            string sqlTxt = $"SELECT p.ID_publicidad, p.cuit_Empresa AS CUIT, r.nombre AS Revista," +
                $" p.fecha_desde AS DESDE, p.fecha_hasta AS HASTA, p.monto FROM Detalle_Publicidad AS p" +
                $" INNER JOIN Revistas AS r ON p.ID_revista = r.cod_Interno Where p.cuit_Empresa ='{cuit}'" +
                $" AND p.fecha_desde >= '{fechadesde}' AND p.fecha_hasta <='{fechahasta}'";


            var PublicidadDTRows = _BD.consulta(sqlTxt);
            return PublicidadDTRows;
        }

            public bool Guardar (Publicidad publi)
        {
            string sqlTxt = $"INSERT [dbo].[Detalle_Publicidad] ([cuit_Empresa], [ID_revista] ,[fecha_desde],[fecha_hasta],[monto])" +
                $"VALUES('{publi.cuit_Empresa}','{publi.ID_revista}','{publi.fecha_desde.ToString("yyyy-MM-dd")}','{publi.fecha_hasta.ToString("yyyy-MM-dd")}','{publi.monto}')";
            
            return _BD.EjecutarSQL(sqlTxt);

            
        }
    }
}
