using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace TP_PAV_3K02.Modelos
{
    public class Suscripcion
    {
        public long nro_doc { get; set; }
        public int cod_TipoDoc { get; set; }
        public int cod_int { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public int doc_plan { get; set; }
        public IList<Suscriptor> Suscriptors { get; set; }
        public bool fechavalida()
        {
            if (fecha_inicio != DateTime.MinValue && fecha_inicio < DateTime.Today)
                return true;
            return false;

        }
    }
}