using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3K02.Modelos
{
    class Distribucion
    {
        public int id { get; set; }
        public long Cuit_dist { get; set; }
        public int Cod_Interno { get; set; }
        public long nro_ejemplares { get; set; }
        public long nro_ejemplares_pagos { get; set; }
        public DateTime fecha_Entrega { get; set; }

        public bool CuitValido(string cuit)
        {
            if (long.TryParse(cuit, out long resultado))
                return true;
            return false;
        }

        public bool idValido(string id)
        {
            if (int.TryParse(id, out int resultado))
                return true;
            return false;
        }

        public bool fechavalida()
        {
            if (fecha_Entrega != DateTime.MinValue && fecha_Entrega < DateTime.Today)
                return true;
            return false;

        }
        public bool NumeroValido(string num)
        {
            if (long.TryParse(num, out long resultado))
                return true;
            return false;

        }

    }
}
