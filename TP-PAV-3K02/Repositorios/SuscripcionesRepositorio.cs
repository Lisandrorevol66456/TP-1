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
            string sqlTxt = "SELECT * FROM Suscripciones";

           
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
                    string sqlTxt = $"INSERT [dbo].[Suscripciones] ([nro_doc], [cod_TipoDoc], [cod_int], [fecha_inicio], [fecha_fin], [doc_plan]) " +
                        $"VALUES ('{s.nro_doc}', '{s.cod_TipoDoc}', '{s.cod_int}', '{s.fecha_inicio}', '{s.fecha_fin}', '{s.doc_plan}')";
                    

                    foreach (var p in s.plan )
                    {
                        string sqlText = $"INSERT [dbo].[Planes] ([cod_Plan], [cod_int], [fechaInicial]" +
                            $", [fechaFin], [Precio])" +
                            $"VALUES ('{p.cod_Plan}', '{p.cod_int}', '{p.fechaInicial}', '{p.fechaFin}', " +
                            $"'{p.Precio}')";

                        _BD.EjecutarSQL(sqlText);
                    }


                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo guardar la suscripcion.");
                }

                finally
                {
                    _BD.cerrar();
                }
                
            }
        }
    }
}