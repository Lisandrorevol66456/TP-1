using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3K02.Modelos
{
    public class Suscriptor
    {

        public long nroDoc { get; set; }
        public int cod_TipoDoc { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string calle { get; set; }
        public long numero { get; set; }
        public int cod_Localidad { get; set; }
        public int cod_Provincia { get; set; }
        public int cod_Pais { get; set; }


        public bool NroDocValido(string documento)
        {
            if (long.TryParse(documento, out long resultado))
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

        public bool CalleValido()
        {
            if (!string.IsNullOrEmpty(calle) && calle.Length < 20 )
                return true;
            return false;
        }

        public bool NumeroValido(string num)
        {
            if(long.TryParse(num , out long resultado))
                return true;
            return false;
            
        }

    }
}
