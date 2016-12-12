using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Notas_Traslados
    {
        #region Atributos
        private Int64 _Id_Nota;
        private Int64 _Id_Traslado;
        private Int64 _Cuenta_Cliente;
        private string _Usuario;
        private string _Nombre_Linea_Nota;
        private string _Fecha_Nota;
        private string _Hora_Nota;
        private string _Nota;
        private string _Razon;
        private string _Subrazon;
        private string _Estado;
        #endregion
        #region Constructor
        public E_Notas_Traslados()
        {
            _Id_Nota = 0;
            _Id_Traslado = 0;
            _Cuenta_Cliente = 0;            
            _Usuario = string.Empty;
            _Nombre_Linea_Nota = string.Empty;
            _Fecha_Nota = string.Empty;
            _Hora_Nota = string.Empty;
            _Nota = string.Empty;
            _Razon = string.Empty;
            _Subrazon = string.Empty;
            _Estado = string.Empty;
        }
        #endregion
        #region Encapsulamiento
        public long Id_Nota
        {
            get
            {
                return _Id_Nota;
            }

            set
            {
                _Id_Nota = value;
            }
        }

        public long Id_Traslado
        {
            get
            {
                return _Id_Traslado;
            }

            set
            {
                _Id_Traslado = value;
            }
        }

        public long Cuenta_Cliente
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

        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public string Nombre_Linea_Nota
        {
            get
            {
                return _Nombre_Linea_Nota;
            }

            set
            {
                _Nombre_Linea_Nota = value;
            }
        }

        public string Fecha_Nota
        {
            get
            {
                return _Fecha_Nota;
            }

            set
            {
                _Fecha_Nota = value;
            }
        }

        public string Hora_Nota
        {
            get
            {
                return _Hora_Nota;
            }

            set
            {
                _Hora_Nota = value;
            }
        }

        public string Nota
        {
            get
            {
                return _Nota;
            }

            set
            {
                _Nota = value;
            }
        }

        public string Razon
        {
            get
            {
                return _Razon;
            }

            set
            {
                _Razon = value;
            }
        }

        public string Subrazon
        {
            get
            {
                return _Subrazon;
            }

            set
            {
                _Subrazon = value;
            }
        }

        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

        

        #endregion
    }
}
