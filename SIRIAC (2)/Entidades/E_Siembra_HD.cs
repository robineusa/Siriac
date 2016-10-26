using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Siembra_HD
    {
        #region Atributos
        private double _Cuenta_Cliente;
        private string _Ofrecimiento;
        private string _Fecha_Gestion;
        private string _Usuario_Gestion;
        private string _Nombre_Usuario_Gestion;
        private string _Aliado_Gestion;
        private string _Aceptacion_Siembra_HD;
        #endregion
        #region Constructor
        public E_Siembra_HD()
        {
            _Cuenta_Cliente = 0;
            _Ofrecimiento = string.Empty;
            _Fecha_Gestion = string.Empty;
            _Usuario_Gestion = string.Empty;
            _Nombre_Usuario_Gestion = string.Empty;
            _Aliado_Gestion = string.Empty;
            _Aceptacion_Siembra_HD = string.Empty;
        }


        #endregion
        #region Encapsulamientos
        public double Cuenta_Cliente
        {
            get
            {
                return _Cuenta_Cliente;
            }

            set
            {
                _Cuenta_Cliente = value;
            }
        }

        public string Ofrecimiento
        {
            get
            {
                return _Ofrecimiento;
            }

            set
            {
                _Ofrecimiento = value;
            }
        }

        public string Fecha_Gestion
        {
            get
            {
                return _Fecha_Gestion;
            }

            set
            {
                _Fecha_Gestion = value;
            }
        }

        public string Usuario_Gestion
        {
            get
            {
                return _Usuario_Gestion;
            }

            set
            {
                _Usuario_Gestion = value;
            }
        }

        public string Nombre_Usuario_Gestion
        {
            get
            {
                return _Nombre_Usuario_Gestion;
            }

            set
            {
                _Nombre_Usuario_Gestion = value;
            }
        }

        public string Aliado_Gestion
        {
            get
            {
                return _Aliado_Gestion;
            }

            set
            {
                _Aliado_Gestion = value;
            }
        }

        public string Aceptacion_Siembra_HD
        {
            get
            {
                return _Aceptacion_Siembra_HD;
            }

            set
            {
                _Aceptacion_Siembra_HD = value;
            }
        }
        #endregion
    }
}
