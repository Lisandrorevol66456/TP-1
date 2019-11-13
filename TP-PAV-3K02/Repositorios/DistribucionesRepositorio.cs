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
        public Distribucion ObtenerPorID(string ID)
        {
            string sqltxt = $"SELECT * FROM Distribuciones Where Id = '{ID}'";
            var tablaTemporal = _BD.consulta(sqltxt);
            if (tablaTemporal.Rows.Count == 0)
                return null;

            var distribuc = new Distribucion();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                distribuc.id = int.Parse(fila.ItemArray[0].ToString());
                distribuc.Cuit_dist = long.Parse(fila.ItemArray[1].ToString());
                distribuc.Cod_Interno = int.Parse(fila.ItemArray[2].ToString());
                distribuc.nro_ejemplares = long.Parse(fila.ItemArray[3].ToString());
                distribuc.nro_ejemplares_pagos = long.Parse(fila.ItemArray[4].ToString());
                //distribuc.fecha_Entrega =DateTime.Parse(fila.ItemArray[5].ToString());


            }
            return distribuc;

        }
        public Distribucion ObtenerdistPorcuit(string cuit)
        {
            string sqltxt = $"SELECT * FROM Distribuciones Where Cuit_dist = '{cuit}'";
            var tablaTemporal = _BD.consulta(sqltxt);
            if (tablaTemporal.Rows.Count == 0)
                return null;

            var distribuc = new Distribucion();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                distribuc.id = int.Parse(fila.ItemArray[0].ToString());
                distribuc.Cuit_dist = long.Parse(fila.ItemArray[1].ToString());
                distribuc.Cod_Interno = int.Parse(fila.ItemArray[2].ToString());
                distribuc.nro_ejemplares = long.Parse(fila.ItemArray[3].ToString());
                distribuc.nro_ejemplares_pagos = long.Parse(fila.ItemArray[4].ToString());
                //distribuc.fecha_Entrega =DateTime.Parse(fila.ItemArray[5].ToString());


            }
            return distribuc;

        }

        public bool Editar(Distribucion d, string Id)
        {
            string sqltxt = $"UPDATE [dbo].[Distribuciones] SET Cuit_dist='{d.Cuit_dist}'," +
                
                $" Cod_Interno='{d.Cod_Interno}'," +
                $" nro_ejemplares='{d.nro_ejemplares}'," +
                $" nro_ejemplares_pagos='{d.nro_ejemplares_pagos}'," +
                $"fecha_Entrega='{d.fecha_Entrega.ToString("yyyy-MM-dd")}' Where Id ={Id}";

            return _BD.EjecutarSQL(sqltxt);
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
