﻿using System;
using System.Data;

namespace TP_PAV_3K02.Modelos
{
    
    public class Plan
    {
        public Plan(int cod_Plan, int cod_int, DateTime fechaInicial, DateTime fechaFin, int precio)
        {
            this.cod_Plan = cod_Plan;
            this.cod_int = cod_int;
            this.fechaInicial = fechaInicial;
            this.fechaFin = fechaFin;
            Precio = precio;
        }

        public int cod_Plan { get; set; }
        public int cod_int { get; set; }
        public DateTime fechaInicial { get; set; }
        public DateTime fechaFin { get; set; }
        public int Precio { get; set; }

        
    }

    

}