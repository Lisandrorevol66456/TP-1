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

        public DataTable obtenerSuscripciones()
        {
            string sqlTxt = "SELECT * FROM Suscripcion";

           
            return _BD.consulta(sqlTxt);
        }


        public void obtenerSuscripcionesByCod()
        {

        }

        public void guardar(Suscripcion s)
        {
            using (var tx = _BD.IniciarTransaccion())
            {
                try
                {
                    string sqlTxt = $"INSERT [dbo].[Suscripcion] ([nro_doc], [cod_TipoDoc], [cod_int], [fecha_inicio], [fecha_fin], [doc_plan]) " +
                        $"VALUES ('{s.nro_doc}', '{s.cod_TipoDoc}', '{s.cod_int}', '{s.fecha_inicio}', '{s.fecha_fin}', '{s.doc_plan}')";
                    

                    foreach (var p in s.plan )
                    {
                        string sqlText = $"INSERT [dbo].[Planes] ([cod_Plan], [cod_int], [fechaInicial]" +
                            $", [fechaFin], [Precio])" +
                            $"VALUES ('{p.cod_Plan}', '{p.cod_int}', '{p.fechaInicial}', '{p.fechaFin}', " +
                            $"'{p.Precio}')";

                        _BD.EjecutarTransaccion(sqlText);
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

        public bool borrar(int s)
        {

            string sqltxt = $"DELETE [dbo].[Suscripcion] where cod_int = {s}";

            return _BD.EjecutarSQL(sqltxt);
        }

    }
 
}