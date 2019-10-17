using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K02.BaseDatos;
using TP_PAV_3K02.Modelos;

namespace TP_PAV_3K02.Repositorios
{
    class DistribucionesRepositorio
    {
        private int _codigo ;
        private Editorial_BD _BD;
        public DistribucionesRepositorio()
        {
            _BD = new Editorial_BD();
        }
        public bool Guardar(Distribucion distribucion)
        {
            string sqltxt = $"INSERT [dbo].[Distribuciones] ([Id],[Cuit_dist],[Cod_Interno],[nro_ejemplares],[nro_ejemplares_pagos],[fecha_Entrega]) " +
                $"VALUES ('{distribucion.id}','{distribucion.Cuit_dist}','{distribucion.Cod_Interno}', " +
                $"'{distribucion.nro_ejemplares}', '{distribucion.nro_ejemplares_pagos}', '{distribucion.fecha_Entrega.ToString("yyyy-MM-dd")}')";

            return _BD.EjecutarSQL(sqltxt);
        }
        public DataTable ObtenerDistribucionesDT()
        {
            string sqltext = "SELECT * FROM Distribuciones";
            return _BD.consulta(sqltext);

        }
        public DataTable ObtenerPorcuit(long cuit)
        {
            string sqltxt = "SELECT * FROM Distribuciones Where Cuit_dist =" + cuit;

            return _BD.consulta(sqltxt);
        }
        public bool Eliminar(string cod_int, string cuit, string ejemplares)
        {
            string sqltxt = $"DELETE FROM [dbo].[Distribuciones] WHERE Cod_Interno= {cod_int} and Cuit_dist ={cuit} and nro_ejemplares={ejemplares}";

            return _BD.EjecutarSQL(sqltxt);
        }
        public bool ValidarCod(string cod)
        {
            string sqltxt = $"SELECT * FROM Revistas where Cod_Interno ={cod}";

            var tablaResultante = _BD.consulta(sqltxt);

            var filas = tablaResultante.Rows;

            if (filas.Count == 0)
                return true;
            return false;

        }
        public bool ValidarCod_duplicado(string cod, string cuit)
        {
            string sqltxt = $"SELECT * FROM Distribuciones where Cod_Interno ={cod} and Cuit_dist = {cuit}";

            var tablaResultante = _BD.consulta(sqltxt);

            var filas = tablaResultante.Rows;

            if (filas.Count > 0)
                return true;
            return false;

        }
        public bool ValidarIDduplicadp(string id)
        {
            string sqltxt = $"SELECT * FROM Distribuciones where Id ={id}";

            var tablaResultante = _BD.consulta(sqltxt);

            var filas = tablaResultante.Rows;

            if (filas.Count > 0)
                return true;
            return false;

        }
    }
}
