using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3K02.Modelos
{
    public class Revista
    {
        public int cod_Interno { get; set; }
        public string nombre { get; set; }
        public int  cod_frecPublic { get; set; }
        public int cod_rubro { get; set; }
        public DateTime fechaInicio { get; set; }


        public bool NombreValido()
        {
            if (!string.IsNullOrEmpty(nombre) && nombre.Length < 51)
                return true;
            return false;
        }

        public bool CodValido(string codigo)
        {
            if(int.TryParse(codigo, out int result))
                   return true;
            return false;
        }

        public bool fechavalida()
        {
            if (fechaInicio != DateTime.MinValue && fechaInicio < DateTime.Today)
                return true;
            return false;



        }



    }
}
