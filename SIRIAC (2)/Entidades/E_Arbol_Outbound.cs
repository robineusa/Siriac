using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Arbol_Outbound
    {
        #region Atributos
        private int _Id_Tipo_Contacto;
        private string _Tipo_Contacto;
        private int _Id_Tipo_Gestion;
        private string _Gestion;
        private int _Id_Cierre;
        private string _Cierre;
        private string _Razon;
        private int _Id_Causa;
        private string _Causa;
        private string _Hipotesis;
        #endregion
        #region Constructor
        public E_Arbol_Outbound()
        {
            _Id_Tipo_Contacto = 0;
            _Tipo_Contacto = string.Empty;
            _Id_Tipo_Gestion = 0;
            _Gestion = string.Empty;
            _Id_Cierre = 0;
            _Cierre = string.Empty;
            _Razon = string.Empty;
            _Id_Causa = 0;
            _Causa = string.Empty;
            _Hipotesis = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public int Id_Tipo_Contacto
        {
            get { return _Id_Tipo_Contacto; }
            set { _Id_Tipo_Contacto = value; }
        }
        public string Tipo_Contacto
        {
            get { return _Tipo_Contacto; }
            set { _Tipo_Contacto = value; }
        }
        public int Id_Tipo_Gestion
        {
            get { return _Id_Tipo_Gestion; }
            set { _Id_Tipo_Gestion = value; }
        }
        public string Gestion
        {
            get { return _Gestion; }
            set { _Gestion = value; }
        }
        public int Id_Cierre
        {
            get { return _Id_Cierre; }
            set { _Id_Cierre = value; }
        }
        public string Cierre
        {
            get { return _Cierre; }
            set { _Cierre = value; }
        }
        public string Razon
        {
            get { return _Razon; }
            set { _Razon = value; }
        }
        public int Id_Causa
        {
            get { return _Id_Causa; }
            set { _Id_Causa = value; }
        }
        public string Causa
        {
            get { return _Causa; }
            set { _Causa = value; }
        }
        public string Hipotesis
        {
            get { return _Hipotesis; }
            set { _Hipotesis = value; }
        }
        #endregion
    }
}
