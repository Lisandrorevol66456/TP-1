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
                var s = new Suscripcion()
                {
                    nro_doc = int.Parse(fila.ItemArray[0].ToString()),
                    cod_int = int.Parse(fila.ItemArray[1].ToString()),
                    fecha_inicio = fechaI,
                    fecha_fin = fechaF,
                    doc_plan = int.Parse(fila.ItemArray[4].ToString()),
                    
                };
                subs.Add(s);
            }
            return subs;
        }
        
        public void guardar(Suscripcion s)
        {
            using (var tx = _BD.IniciarTransaccion())
            {
                try
                {
                    string sqlTxt = $"INSERT [dbo].[Suscripcion] ([nro_doc],[cod_TipoDoc], [cod_int],[fecha_inicio], [fecha_fin], [doc_plan]) " +
                        $"VALUES ('{s.nro_doc}', '{s.cod_TipoDoc}', '{s.cod_int}','{s.fecha_inicio.ToString("yyyy-MM-dd")}', '{s.fecha_fin.ToString("yyyy-MM-dd")}', '{s.doc_plan}')";
                    

                   foreach (var p in s.plan )
                    {
                        string sqlText = $"INSERT [dbo].[Planes] ([cod_Plan], [cod_int], [fecha_inicio]" +
                            $", [fecha_fin], [Precio])" +
                            $"VALUES ('{p.cod_Plan}', '{p.cod_int}', '{p.fechaInicial}', '{p.fechaFin}', " +
                            $"'{p.Precio}')";

                        _BD.EjecutarTransaccion(sqlTxt);
                    }
    
                    
                    tx.Commit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);

                    try
                    {
                        tx.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }

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

        public DataTable obtenerSuscripcionesPorCod(string codInt)
        {
            int code = int.Parse(codInt);

            string sqlTxt = "SELECT * FROM Suscripcion WHERE cod_int ="+code;

            return _BD.consulta(sqlTxt);
        }

        
    }
 
}