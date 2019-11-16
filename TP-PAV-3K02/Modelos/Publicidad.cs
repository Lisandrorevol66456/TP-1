using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3K02.Modelos
{
    class Publicidad
    {
        public int ID_publicidad { get; set; }
        public long cuit_Empresa { get; set; }
        public int ID_revista { get; set; }
        public DateTime fecha_desde { get; set; }
        public DateTime fecha_hasta { get; set; }
        public int monto { get; set; }

        public bool fechadesdevalida()
        {
            if (fecha_desde != DateTime.MinValue && fecha_desde <= DateTime.Today)
                return true;
            return false;

        }
        public bool fechahastavalida()
        {
            if (fecha_hasta > fecha_desde && fecha_hasta > DateTime.Today)
                return true;
            return false;

        }
    }
}
