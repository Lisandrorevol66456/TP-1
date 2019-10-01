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
    public class SuscriptoresRepositorio
    {

        private Editorial_BD _BD;

        public SuscriptoresRepositorio()
        {
            _BD = new Editorial_BD();
        }

        public DataTable ObtenerSuscriptoresDT()
        {
            string sqltxt = "SELECT * FROM Suscriptores ";
            
            return _BD.consulta(sqltxt);

        }
        public DataTable ObtenerPorDNI(long dni)
        {
            string sqltxt = "SELECT * FROM Suscriptores Where nroDoc="+ dni;
            
            return _BD.consulta(sqltxt);
        }

        public bool Guardar(Suscriptor suscriptor)
        {
            string sqltxt = $"INSERT [dbo].[Suscriptores] ([nroDoc],[cod_TipoDoc],[nombre], [apellido], [calle],[numero],[cod_Provincia],[cod_Localidad]) " +
                $"VALUES ('{suscriptor.nroDoc}', " + 
                $"'{suscriptor.cod_TipoDoc}','{suscriptor.nombre}','{suscriptor.apellido}','{suscriptor.calle}','{suscriptor.numero}','{suscriptor.cod_Provincia}','{suscriptor.cod_Localidad}')";

            return _BD.EjecutarSQL(sqltxt);
        }
        public bool Eliminar(string suscriptornroDoc)
        {
            string sqltxt = $"DELETE FROM [dbo].[Suscriptores] WHERE nroDoc ='{suscriptornroDoc}'";

            return _BD.EjecutarSQL(sqltxt);
        }
        
        public Suscriptor ObtenerSuscriptor(string suscriptorDOC)
        {
            string sqltxt = $"SELECT * FROM [dbo].[Suscriptores] WHERE nroDoc = {suscriptorDOC}";
            var tablaTemporal = _BD.consulta(sqltxt);
            

            if (tablaTemporal.Rows.Count == 0)
                return null;

            var suscri = new Suscriptor();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue; // no corto el ciclo

                suscri.nroDoc = long.Parse(fila.ItemArray[0].ToString()); // numero documento
                suscri.cod_TipoDoc = int.Parse(fila.ItemArray[1].ToString()); // codigo tipo documento
                suscri.nombre = fila.ItemArray[2].ToString(); // Nombre
                suscri.apellido = fila.ItemArray[3].ToString(); // apellido
                suscri.calle = fila.ItemArray[4].ToString(); // calle
                suscri.numero = long.Parse(fila.ItemArray[5].ToString()); // numero de calle
                suscri.cod_Localidad =int.Parse(fila.ItemArray[6].ToString()); // codigo de la localidad
                suscri.cod_Provincia = int.Parse(fila.ItemArray[7].ToString()); // codigo de la provincia
                 
            }

            return suscri;
        }
        public bool Actualizar(Suscriptor suscriptor, string suscriptordni)
        {
            string sqltxt = $"UPDATE [dbo].[Suscriptores] SET nombre='{suscriptor.nombre}' , " +
                $" apellido ='{suscriptor.apellido}'," +
                $" calle ='{suscriptor.calle}'," + 
                $" nroDoc='{suscriptor.nroDoc}', " +
                $" cod_TipoDoc = '{suscriptor.cod_TipoDoc}'," +
                $" numero ='{suscriptor.numero}'," +
                $" cod_Provincia='{suscriptor.cod_Provincia}'," +
                $" cod_Localidad= '{suscriptor.cod_Localidad}' where nroDoc = {suscriptordni}";


            return _BD.EjecutarSQL(sqltxt);
        }
    }
}
