using System;
using System.Data;

namespace TP_PAV_3K02.Modelos
{
    
    public class Plan
    {
        
        public int cod_Plan { get; set; }
        public int cod_int { get; set; }
        public DateTime fechaInicial { get; set; }
        public DateTime fechaFin { get; set; }
        public int Precio { get; set; }
    }
}