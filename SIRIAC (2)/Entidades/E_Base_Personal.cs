using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Base_Personal
    {
        #region Atributos
        private string _Cedula;
        private string _Nombre;
        private string _Aliado;
        private string _Canal;
        private string _Operacion;
        private string _Grupo;
        private string _Usuario_RR;
        private string _Usuario_Agendamiento;
        private string _Usuario_Gerencia;
        private string _Estado;
        private string _Segmento;
        private string _Nombre_Linea;
        #endregion
        #region Constructor
        public E_Base_Personal() {
            _Cedula = string.Empty;
            _Nombre= string.Empty;
            _Aliado = string.Empty;
            _Canal = string.Empty;
            _Operacion = string.Empty;
            _Grupo = string.Empty;
            _Usuario_RR = string.Empty;
            _Usuario_Agendamiento = string.Empty;
            _Usuario_Gerencia = string.Empty;
            _Estado = string.Empty;
            _Segmento = string.Empty;
            _Nombre_Linea = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public string Cedula
        {
            get { return _Cedula; }
            set { _Cedula = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Aliado
        {
            get { return _Aliado; }
            set { _Aliado = value; }
        }
        public string Canal
        {
            get { return _Canal; }
            set { _Canal = value; }
        }
        public string Operacion
        {
            get { return _Operacion; }
            set { _Operacion = value; }
        }
        public string Grupo
        {
            get { return _Grupo; }
            set { _Grupo = value; }
        }
        public string Usuario_RR
        {
            get { return _Usuario_RR; }
            set { _Usuario_RR = value; }
        }
        public string Usuario_Agendamiento
        {
            get { return _Usuario_Agendamiento; }
            set { _Usuario_Agendamiento = value; }
        }
        public string Usuario_Gerencia
        {
            get { return _Usuario_Gerencia; }
            set { _Usuario_Gerencia = value; }
        }
        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public string Segmento
        {
            get { return _Segmento; }
            set { _Segmento = value; }
        }
        public string Nombre_Linea
        {
            get { return _Nombre_Linea; }
            set { _Nombre_Linea = value; }
        }
        #endregion
    }
}
