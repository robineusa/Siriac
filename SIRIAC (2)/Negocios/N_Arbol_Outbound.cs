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
    public class N_Arbol_Outbound
    {
        public D_Arbol_Outbound Consultas_Arbol_Outbound = new D_Arbol_Outbound();
        public DataSet Tipo_Contacto()
        {
            return Consultas_Arbol_Outbound.Tipo_Contacto();
        }
        public DataSet Selecciona_Gestion(int p_Id_Tipo_Contacto)
        {
            return Consultas_Arbol_Outbound.Selecciona_Gestion(p_Id_Tipo_Contacto);
        }
        public DataSet Selecciona_Cierre(int p_Id_Tipo_Gestion)
        {
            return Consultas_Arbol_Outbound.Selecciona_Cierre(p_Id_Tipo_Gestion);
        }
        public DataSet Selecciona_Razon(int p_Id_Cierre)
        {
            return Consultas_Arbol_Outbound.Selecciona_Razon(p_Id_Cierre);
        }
        public DataSet Selecciona_Causa(string pHipotesis)
        {
            return Consultas_Arbol_Outbound.Selecciona_Causa(pHipotesis);
        }
        public DataSet Oubound_Tipo_Contacto(int p_Id_Tipo_Gestion)
        {
            return Consultas_Arbol_Outbound.Oubound_Tipo_Contacto(p_Id_Tipo_Gestion);
        }
        public DataSet Oubound_Cierre(int p_Id_Tipo_Contacto)
        {
            return Consultas_Arbol_Outbound.Oubound_Cierre(p_Id_Tipo_Contacto);
        }
        public DataSet Oubound_Razon(int p_Id_Cierre)
        {
            return Consultas_Arbol_Outbound.Oubound_Razon(p_Id_Cierre);
        }
        public DataSet Oubound_Causa(int p_Id_Razon)
        {
            return Consultas_Arbol_Outbound.Oubound_Causa(p_Id_Razon);
        }
        public DataSet Oubound_Motivo(int p_Id_Causa)
        {
            return Consultas_Arbol_Outbound.Oubound_Motivo(p_Id_Causa);
        }
    }
}
