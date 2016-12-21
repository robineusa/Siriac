using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Back_Elite
    {
        #region Atributos
        private int _Cuenta;
        private int _LLSOT;
        private string _Tipo;
        private string _Detalle;
        private string _Fecha_Inicio;
        private string _Hora_Inicio;
        private string _Usuario;
        private string _Notas;
        private string _Nodo;
        private string _Aliado_Tec;
        private string _Divisional;
        private string _Red;
        private int _Cedula;
        private string _Nombre;
        private string _Cargo;
        private string _Estado;
        private string _Aliado_Call;
        private string _Operacion;
        private string _Mal_Escalado;
        private string _Error_Marcacion;
        private string _Notas_Incompletas;
        private string _Gestion;
        private string _Observacion;
        private string _Estado_Ticket;
        private int _Tiempo_Horas;
        private string _Fecha_Final;
        private string _Hora_Final;
        private string _ModMejoram;
        private string _Notas_Seg;
        private string _Usuario_Ult_Gest;
        private string _Fecha_Ult_Gest;
        private string _Hora_Ult_Gest;
        private string _Tipo_Trabajo;
        private string _Fecha_Agenda;
        
        #endregion
        #region Constructor
        public E_Back_Elite() {
            _Cuenta = 0;
            _LLSOT = 0;
            _Tipo = string.Empty;
            _Detalle = string.Empty;
            _Fecha_Inicio = string.Empty;
            _Hora_Inicio = string.Empty;
            _Usuario = string.Empty;
            _Notas = string.Empty;
            _Nodo = string.Empty;
            _Aliado_Tec = string.Empty;
            _Divisional = string.Empty;
            _Red = string.Empty;
            _Cedula = 0;
            _Nombre = string.Empty;
            _Cargo = string.Empty;
            _Estado = string.Empty;
            _Aliado_Call = string.Empty;
            _Operacion = string.Empty;
            _Mal_Escalado = string.Empty;
            _Error_Marcacion = string.Empty;
            _Notas_Incompletas = string.Empty;
            _Gestion = string.Empty;
            _Observacion = string.Empty;
            _Estado_Ticket = string.Empty;
            _Tiempo_Horas = 0; 
            _Fecha_Final = string.Empty;
            _Hora_Final = string.Empty;
            _ModMejoram = string.Empty;
            _Notas_Seg = string.Empty;
            _Usuario_Ult_Gest = string.Empty;
            _Fecha_Ult_Gest = string.Empty;
            _Hora_Ult_Gest = string.Empty;
            _Tipo_Trabajo = string.Empty;
            _Fecha_Agenda = string.Empty;
        }
        #endregion
        #region Encapsulamiento
        public int Cuenta
        {
            get
            {
                return _Cuenta;
            }

            set
            {
                _Cuenta = value;
            }
        }

        public int LLSOT
        {
            get
            {
                return _LLSOT;
            }

            set
            {
                _LLSOT = value;
            }
        }

        public string Tipo
        {
            get
            {
                return _Tipo;
            }

            set
            {
                _Tipo = value;
            }
        }

        public string Detalle
        {
            get
            {
                return _Detalle;
            }

            set
            {
                _Detalle = value;
            }
        }

        public string Fecha_Inicio
        {
            get
            {
                return _Fecha_Inicio;
            }

            set
            {
                _Fecha_Inicio = value;
            }
        }

        public string Hora_Inicio
        {
            get
            {
                return _Hora_Inicio;
            }

            set
            {
                _Hora_Inicio = value;
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

        public string Notas
        {
            get
            {
                return _Notas;
            }

            set
            {
                _Notas = value;
            }
        }

        public string Nodo
        {
            get
            {
                return _Nodo;
            }

            set
            {
                _Nodo = value;
            }
        }

        public string Aliado_Tec
        {
            get
            {
                return _Aliado_Tec;
            }

            set
            {
                _Aliado_Tec = value;
            }
        }

        public string Divisional
        {
            get
            {
                return _Divisional;
            }

            set
            {
                _Divisional = value;
            }
        }

        public string Red
        {
            get
            {
                return _Red;
            }

            set
            {
                _Red = value;
            }
        }

        public int Cedula
        {
            get
            {
                return _Cedula;
            }

            set
            {
                _Cedula = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public string Cargo
        {
            get
            {
                return _Cargo;
            }

            set
            {
                _Cargo = value;
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

        public string Aliado_Call
        {
            get
            {
                return _Aliado_Call;
            }

            set
            {
                _Aliado_Call = value;
            }
        }

        public string Operacion
        {
            get
            {
                return _Operacion;
            }

            set
            {
                _Operacion = value;
            }
        }

        public string Mal_Escalado
        {
            get
            {
                return _Mal_Escalado;
            }

            set
            {
                _Mal_Escalado = value;
            }
        }

        public string Error_Marcacion
        {
            get
            {
                return _Error_Marcacion;
            }

            set
            {
                _Error_Marcacion = value;
            }
        }

        public string Notas_Incompletas
        {
            get
            {
                return _Notas_Incompletas;
            }

            set
            {
                _Notas_Incompletas = value;
            }
        }

        public string Gestion
        {
            get
            {
                return _Gestion;
            }

            set
            {
                _Gestion = value;
            }
        }

        public string Observacion
        {
            get
            {
                return _Observacion;
            }

            set
            {
                _Observacion = value;
            }
        }

        public string Estado_Ticket
        {
            get
            {
                return _Estado_Ticket;
            }

            set
            {
                _Estado_Ticket = value;
            }
        }

        public int Tiempo_Horas
        {
            get
            {
                return _Tiempo_Horas;
            }

            set
            {
                _Tiempo_Horas = value;
            }
        }

        public string Fecha_Final
        {
            get
            {
                return _Fecha_Final;
            }

            set
            {
                _Fecha_Final = value;
            }
        }

        public string Hora_Final
        {
            get
            {
                return _Hora_Final;
            }

            set
            {
                _Hora_Final = value;
            }
        }

        public string ModMejoram
        {
            get
            {
                return _ModMejoram;
            }

            set
            {
                _ModMejoram = value;
            }
        }

        public string Notas_Seg
        {
            get
            {
                return _Notas_Seg;
            }

            set
            {
                _Notas_Seg = value;
            }
        }

        public string Usuario_Ult_Gest
        {
            get
            {
                return _Usuario_Ult_Gest;
            }

            set
            {
                _Usuario_Ult_Gest = value;
            }
        }

        public string Fecha_Ult_Gest
        {
            get
            {
                return _Fecha_Ult_Gest;
            }

            set
            {
                _Fecha_Ult_Gest = value;
            }
        }

        public string Hora_Ult_Gest
        {
            get
            {
                return _Hora_Ult_Gest;
            }

            set
            {
                _Hora_Ult_Gest = value;
            }
        }

        public string Tipo_Trabajo
        {
            get
            {
                return _Tipo_Trabajo;
            }

            set
            {
                _Tipo_Trabajo = value;
            }
        }

        public string Fecha_Agenda
        {
            get
            {
                return _Fecha_Agenda;
            }

            set
            {
                _Fecha_Agenda = value;
            }
        }

        #endregion
    }
}
