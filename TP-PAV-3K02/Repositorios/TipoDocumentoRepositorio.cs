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
    class TipoDocumentoRepositorio
    {
        private Editorial_BD _BD;

        public TipoDocumentoRepositorio()
        {
            _BD = new Editorial_BD();
        }

        public List<TipoDocumento> ObtenertDocumentos()
        {
            var documentosDTRows = ObetenerTiposDocumentosDT().Rows;//contiene lso tipos de docuemtos por filas

            var documentos = new List<TipoDocumento>();
            foreach(DataRow fila in documentosDTRows)
            {
                if (fila.HasErrors)
                    continue;// detecta si hay un error en alguna fila
                var tipoDocumento = new TipoDocumento()
                {
                    cod_TipoDoc = Convert.ToInt32(fila[0]),
                    nombre = fila[1].ToString()
                };
                documentos.Add(tipoDocumento);
            }

            return documentos;

        }
        public DataTable ObetenerTiposDocumentosDT()
        {
            string sqltext = "SELECT * FROM TipoDocumento";
            var documentosDTRows = _BD.consulta(sqltext);
            return documentosDTRows;

        }
        




    }
}
