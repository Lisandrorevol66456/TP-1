using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3K02.Modelos
{
    public class Suscriptor
    {

        public int nroDoc { get; set; }
        public int cod_TipoDoc { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string calle { get; set; }
        public int numero { get; set; }
        public int cod_Localidad { get; set; }
        public int cod_Provincia { get; set; }
        public int cod_Pais { get; set; }


        public bool NroDocValido()
        {
            if(nroDoc > 0)
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
            if (!string.IsNullOrEmpty(apellido) && apellido.Length < 51)
                return true;
            return false;
        }

        public bool CalleValido()
        {
            if (!string.IsNullOrEmpty(calle) && apellido.Length < 20)
                return true;
            return false;
        }

        public bool NumeroValido()
        {
            if(numero > 0)
                return true;
            return false;
            
        }



    }
}
