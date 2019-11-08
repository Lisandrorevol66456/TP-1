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

        public bool Actualizar(Suscripcion sus,string doc)
        {
            string sqltext = $"UPDATE [dbo].[Suscripcion] SET doc_plan = {sus.doc_plan}  where nro_doc = {doc} ";

            return _BD.EjecutarSQL(sqltext);


        }

        public void guardar(Suscripcion s)
        {
           
            
            using (var tx = _BD.IniciarTransaccion())
            {
                StringBuilder mensaje = new StringBuilder("La operación se realizo con exito ");
                try
                {
                        string sqlTxt = $"INSERT [dbo].[Suscripcion] ([nro_doc], [cod_TipoDoc], [fecha_inicio], [fecha_fin]) " +
                        $"VALUES ('{s.nro_doc}', '{s.cod_TipoDoc}', '{s.fecha_inicio.ToString("yyyy-MM-dd")}', '{s.fecha_fin.ToString("yyyy-MM-dd")}')";

                    s.cod_int = _BD.EjecutarTransaccion(sqlTxt);
                    if(s.cod_int == 0)
                        throw new ApplicationException();
                    
                    tx.Commit();
                }
                catch (InvalidOperationException ex)
                {
                    mensaje.Append("no se realizó. Hubo un problema en la conexión a la BD");
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

        public DataTable obtenerSuscripcionesPorDoc(long doc)
        {
            
            string sqlTxt = "SELECT * FROM Suscripcion WHERE nro_doc = "+ doc;

            return _BD.consulta(sqlTxt);
        }

        public void BeginTransation()
        {

            _BD.IniciarTransaccion();

        }
        
    }
 
}