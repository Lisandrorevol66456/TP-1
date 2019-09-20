using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3K02.Modelos
{
    public class Distribuidor
    {

        public int cuit_dist { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string domicilio { get; set; }
        public int numero { get; set; }
        public DateTime fecha_inicio { get; set; }
 


        public bool CuitValido()
        {
            if (cuit_dist > 0)
                return true;
            return false;
        }

        public bool NombreValido()
        {
            if (!string.IsNullOrEmpty(nombre) && nombre.Length < 51)
                return true;
            return false;

        }

        public bool ApellidoValido()
        {
            if (!string.IsNullOrEmpty(apellido) && apellido.Length < 30)
                return true;
            return false;
        }

        public bool domicilioValido()
        {
            if (!string.IsNullOrEmpty(domicilio) && domicilio.Length < 51)
                return true;
            return false;
        }
        public bool fechavalida()
        {
            if (fecha_inicio != DateTime.MinValue && fecha_inicio < DateTime.Today)
                return true;
            return false;



        }

    }
}
