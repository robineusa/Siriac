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
    public class N_Usuarios
    {
        public D_Usuarios Obj_abcUsuarios = new D_Usuarios();

        public int abcUsuarios(string pAccion, E_Usuarios objUsuarios) {
            return Obj_abcUsuarios.abcUsuarios(pAccion, objUsuarios);
        }
        public DataSet Identifica_Usuario(string pUsuario_RR, string pContrasena)
        {
           return Obj_abcUsuarios.Identifica_Usuario(pUsuario_RR, pContrasena);
        }
        public DataSet Consulta_Datos_Usuario(string pUsuario_RR)
        {
            return Obj_abcUsuarios.Consulta_Datos_Usuario(pUsuario_RR);
        }
        public int Actualizar_Contrasena(string pAccion, E_Usuarios objE_Usuarios)
        {
            return Obj_abcUsuarios.Actualizar_Contrasena(pAccion, objE_Usuarios);
        }
        public DataSet Consulta_Usuarios_Cedula(string pCedula)
        {
            return Obj_abcUsuarios.Consulta_Usuarios_Cedula(pCedula);
        }
        public DataSet Consulta_Informacion_Usuario(double pCedula)
        {
            return Obj_abcUsuarios.Consulta_Informacion_Usuario(pCedula);
        }
        public DataSet Consulta_Nombres_Usuarios_Celula()
        {
            return Obj_abcUsuarios.Consulta_Nombres_Usuarios_Celula();
        }
        public DataSet Selecciona_Usuarios_Masivo(string pAliado, string pId_Rol)
        {
            return Obj_abcUsuarios.Selecciona_Usuarios_Masivo(pAliado, pId_Rol);
        }
    }
}
