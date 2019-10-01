using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3K02.Modelos
{
    class Empresa
    {
        public long cuit { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string domicilio { get; set; }
        public DateTime fechaI { get; set; }
        public int codCal { get; set; }
    }

}