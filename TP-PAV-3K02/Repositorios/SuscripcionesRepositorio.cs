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
            string sqlTxt = "SELECT * FROM Suscripciones";

            var tmp = _BD.consulta(sqlTxt);

            var suscripciones = new List<Suscripcion>();

            foreach (DataRow rowSus in tmp.Rows)
            {

                if (rowSus.HasErrors)
                    continue;

                var suscripcion = new Suscripcion()
                {
                    nro_doc = int.Parse(rowSus.ItemArray[0].ToString()),
                    cod_TipoDoc = int.Parse(rowSus.ItemArray[1].ToString()),
                    cod_int = int.Parse(rowSus.ItemArray[2].ToString()),
                };
                suscripciones.Add(suscripcion);

            }

            return suscripciones;
        }

        
    }
}