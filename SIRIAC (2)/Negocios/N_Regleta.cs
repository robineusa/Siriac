using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;
using Entidades;

namespace Negocios
{
    public class N_Regleta
    {
        D_Regleta Obj_Consultas_Regleta_Principal = new D_Regleta();
        public DataSet Tipo_Regleta(string pPoblacion, string pEstrato)
        {
            return Obj_Consultas_Regleta_Principal.Tipo_Regleta(pPoblacion, pEstrato);
        }
        public DataSet Paquetes_Triples(string pPoblacion, string pEstrato, string pTipo_Regleta) {
            return Obj_Consultas_Regleta_Principal.Paquetes_Triples(pPoblacion, pEstrato, pTipo_Regleta);
        }
        public DataSet Paquetes_Dobles(string pPoblacion, string pEstrato, string pTipo_Regleta)
        {
            return Obj_Consultas_Regleta_Principal.Paquetes_Dobles(pPoblacion, pEstrato, pTipo_Regleta);
        }
        public DataSet Paquetes_Sencillos(string pPoblacion, string pEstrato, string pTipo_Regleta)
        {
            return Obj_Consultas_Regleta_Principal.Paquetes_Sencillos(pPoblacion, pEstrato, pTipo_Regleta);
        }
        public DataSet Valor_Paquetes(string pPoblacion, string pEstrato, string pTipo_Regleta, string pLista_Paquetes)
        {
            return Obj_Consultas_Regleta_Principal.Valor_Paquetes(pPoblacion, pEstrato, pTipo_Regleta, pLista_Paquetes);
        }
        public DataSet Total_Poblaciones() {
            return Obj_Consultas_Regleta_Principal.Total_Poblaciones();
        }
        public DataSet Estratos_Regleta(string pPoblacion)
        {
            return Obj_Consultas_Regleta_Principal.Estratos_Regleta(pPoblacion);
        }
        public DataSet Detalle_Regleta(string pPoblacion, string pEstrato, string pTipo_Regleta, string pLista_Paquetes)
        {
            return Obj_Consultas_Regleta_Principal.Detalle_Regleta(pPoblacion, pEstrato, pTipo_Regleta, pLista_Paquetes);
        }
    }
}
