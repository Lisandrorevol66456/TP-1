using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3K02.Modelos
{
    public class Empresa
    {
        public long cuit { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string domicilio { get; set; }
        public DateTime fechaI { get; set; }
        public int codCal { get; set; }

        public bool NroCuitValido(string cuit)
        {
            if (long.TryParse(cuit, out long resultado))
                return true;
            return false;

        }

        public bool NombreValido()
        {
            if (!string.IsNullOrEmpty(nombre) && nombre.Length < 51)
                return true;
            return false;

        }
        public bool busquedaValida(string busqueda)
        {
            if (!string.IsNullOrEmpty(busqueda) || !string.IsNullOrWhiteSpace(busqueda))
                return true;
            return false;
        }

        public bool ApellidoValido()
        {
            if (!string.IsNullOrEmpty(apellido) && apellido.Length < 30)
                return true;
            return false;
        }

        public bool DomicilioValido()
        {
            if (!string.IsNullOrEmpty(domicilio))
                return true;
            return false;
        }

        public bool codCalValido(string codCal)
        {
            if (int.TryParse(codCal, out int resultado))
                return true;
            return false;

        }
    }

}