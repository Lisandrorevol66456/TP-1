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
    public class SuscripcionesRepositorios
    {
        Editorial_BD _BD;

        public SuscripcionesRepositorios()
        {
            _BD = new Editorial_BD();
        } 

        public IList<Suscripcion> obtenerSuscripciones()
        {
            string sqlTxt = "SELECT * FROM Suscripcion";
            
            var tmp = _BD.consulta(sqlTxt);
            var subs = new List<Suscripcion>();

            foreach (DataRow fila in tmp.Rows)
            {
                if (fila.HasErrors)
                    continue;

                DateTime fechaI = DateTime.Today;
                DateTime fechaF = DateTime.Today.AddYears(1);
                DateTime.TryParse(fila.ItemArray[3]?.ToString(), out fechaI);
                DateTime.TryParse(fila.ItemArray[4]?.ToString(), out fechaF);
                var s = new Suscripcion();
                var p = new Plan();

                

                s.nro_doc = long.Parse(fila.ItemArray[0].ToString());
                s.cod_int = int.Parse(fila.ItemArray[1].ToString());
                s.fecha_inicio = fechaI;
                s.fecha_fin = fechaF;
                s.doc_plan = int.Parse(fila.ItemArray[5].ToString());
                
                subs.Add(s);
            }
            return subs;
        }

        public bool Actualizar(Suscripcion sus,string cod)
        {
            string sqltext = $"UPDATE [dbo].[Suscripcion] SET cod_plan = '{sus.doc_plan}', " +
                $" fecha_inicio = '{sus.fecha_inicio.ToString("yyyy-MM-dd")}' , " +
                $" fecha_fin = '{sus.fecha_fin.ToString("yyyy-MM-dd")}' where cod_int = '{cod}' ";

            return _BD.EjecutarSQL(sqltext);

        }

        public void guardar(Suscripcion s)
        {
           
            
            using (var tx = _BD.IniciarTransaccion())
            {
                StringBuilder mensaje = new StringBuilder("La operación ");
                try
                {
                        string sqlTxt = $"INSERT [dbo].[Suscripcion] ([cod_TipoDoc], [nro_doc], [fecha_inicio], [fecha_fin], [cod_Plan]) " +
                        $"VALUES ('{s.cod_TipoDoc}', '{s.nro_doc}', '{s.fecha_inicio.ToString("yyyy-MM-dd")}', '{s.fecha_fin.ToString("yyyy-MM-dd")}', '{s.doc_plan}')";

                    s.cod_int = _BD.EjecutarTransaccion(sqlTxt);
                    if(s.cod_int == 0)
                        throw new ApplicationException();
                    
                    tx.Commit();
                    mensaje.Append("se realizó con éxito");
                }
                catch (InvalidOperationException ex)
                {
                     
                    mensaje.Append("no se realizó. Error inesperado");
                    tx.Rollback();
                }
                finally
                {
                    _BD.cerrar();
                }
            }
        }

        public bool borrar(string cod)
        {
            int codigo = int.Parse(cod);

            string sqltxt = $"DELETE [dbo].[Suscripcion] where cod_int = {codigo}";

            return _BD.EjecutarSQL(sqltxt);
        }
        public DataTable ObtenerPorDNI(long dni)
        {
            string sqltxt = "SELECT s.cod_int, s.cod_TipoDoc, s.nro_doc, s.fecha_inicio, s.fecha_fin, s.cod_Plan," +
                " p.precio, p.nombre FROM Suscripcion AS s INNER JOIN Planes AS p ON s.cod_Plan = p.cod_Plan" +
                " Where nro_doc =" + dni;

            return _BD.consulta(sqltxt);

        }
        public DataTable obtenerSuscripcionesPorDoc(long doc)
        {
            
            string sqlTxt = "SELECT S.* , P.precio FROM Suscripcion S " +
                "JOIN Planes P ON S.cod_Plan = P.cod_Plan " +
                "WHERE nro_doc = "+ doc;

            return _BD.consulta(sqlTxt);
        }

        public void BeginTransation()
        {

            _BD.IniciarTransaccion();

        }
        
        public Suscripcion Obtenerporcodint(string codint)
        {
            string sqltxt = $"SELECT * FROM [dbo].[Suscripcion] WHERE cod_int = {codint}";
            var tablaTemporal = _BD.consulta(sqltxt);


            if (tablaTemporal.Rows.Count == 0)
                return null;

            var suscri = new Suscripcion();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                suscri.cod_int = int.Parse(fila.ItemArray[0].ToString()); // numero documento
                suscri.cod_TipoDoc = int.Parse(fila.ItemArray[1].ToString()); // codigo tipo documento
                suscri.nro_doc = long.Parse(fila.ItemArray[2].ToString()); // Nombre
                suscri.fecha_inicio = DateTime.Parse(fila.ItemArray[3].ToString()); // apellido
                suscri.fecha_fin = DateTime.Parse(fila.ItemArray[4].ToString()); // calle
                suscri.doc_plan = int.Parse(fila.ItemArray[5].ToString());


            }

            return suscri;
        }
    }
 
}