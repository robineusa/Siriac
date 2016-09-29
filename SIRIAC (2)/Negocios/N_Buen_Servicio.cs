using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using System.Data;

namespace Negocios
{
    public class N_Buen_Servicio
    {
        public D_Buen_Servicio Consultas_Buen_Servicio = new D_Buen_Servicio();

        public int abcBuenServicio(string pAccion, E_Buen_Servicio objE_Buen_Servicio)
        {
            return Consultas_Buen_Servicio.abcBuenServicio(pAccion,objE_Buen_Servicio);
        }
        public DataSet Consulta_Imagen_Buen_Servicio(int Id_Imagen)
        {
            return Consultas_Buen_Servicio.Consulta_Imagen_Buen_Servicio(Id_Imagen);
        }
        public DataSet Consulta_Imagen_General_Buen_Servicio()
        {
            return Consultas_Buen_Servicio.Consulta_Imagen_General_Buen_Servicio();
        }
        public DataSet Consulta_Notificaciones(string p_Usuario)
        {
            return Consultas_Buen_Servicio.Consulta_Notificaciones(p_Usuario);
        }
        public int Inserta_Notificacion(E_Buen_Servicio objE_Buen_Servicio)
        {
            return Consultas_Buen_Servicio.Inserta_Notificacion(objE_Buen_Servicio);
        }
    }
}
