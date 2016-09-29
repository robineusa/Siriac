using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Usuarios
    {
        #region Atributos
        private int _Id_Usuario;
        private double _Cedula;
        private string _Nombre;
        private string _Usuario_RR;
        private string _Usuario_Agendamiento;
        private string _Contrasena;
        private int _Id_Rol;
        private int _Id_Nombre_Linea;
        private int _Acceso_1;
        private int _Acceso_2;
        private int _Acceso_3;
        private int _Acceso_4;
        private int _Acceso_5;
        private int _Acceso_6;
        private int _Acceso_7;
        private int _Acceso_8;
        private int _Acceso_9;
        private int _Acceso_10;
        private int _Acceso_11;
        private int _Acceso_12;
        private int _Acceso_13;
        private int _Acceso_14;
        private int _Acceso_15;
        private int _Acceso_16;
        private int _Acceso_17;
        private int _Acceso_18;
        private int _Acceso_19;
        private int _Acceso_20;
        private int _Acceso_21;
        private int _Acceso_22;
        private int _Acceso_23;
        private int _Acceso_24;
        private int _Acceso_25;
        private int _Acceso_26;
        private int _Acceso_27;
        private int _Acceso_28;
        private int _Acceso_29;
        private int _Acceso_30;
        private string _Aliado;
        private string _Nombre_Linea;
        private string _Cedulas;
        private string _Id_rol;
        #endregion
        #region Constructor
        public E_Usuarios()
        {
            _Id_Usuario = 0;
            _Cedula = 0;
            _Nombre = string.Empty;
            _Usuario_RR = string.Empty;
            _Usuario_Agendamiento = string.Empty;
            _Contrasena = string.Empty;
            _Id_Rol = 0;
            _Id_Nombre_Linea = 0;
            _Acceso_1 = 0;
            _Acceso_2 = 0;
            _Acceso_3 = 0;
            _Acceso_4 = 0;
            _Acceso_5 = 0;
            _Acceso_6 = 0;
            _Acceso_7 = 0;
            _Acceso_8 = 0;
            _Acceso_9 = 0;
            _Acceso_10 = 0;
            _Acceso_11 = 0;
            _Acceso_12 = 0;
            _Acceso_13 = 0;
            _Acceso_14 = 0;
            _Acceso_15 = 0;
            _Acceso_16 = 0;
            _Acceso_17 = 0;
            _Acceso_18 = 0;
            _Acceso_19 = 0;
            _Acceso_20 = 0;
            _Acceso_21 = 0;
            _Acceso_22 = 0;
            _Acceso_23 = 0;
            _Acceso_24 = 0;
            _Acceso_25 = 0;
            _Acceso_26 = 0;
            _Acceso_27 = 0;
            _Acceso_28 = 0;
            _Acceso_29 = 0;
            _Acceso_30 = 0;
            _Aliado = string.Empty;
            _Nombre_Linea = string.Empty;
            Id_rol = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public int Id_Usuario
        {
            get { return _Id_Usuario; }
            set { _Id_Usuario = value; }
        }
        public double Cedula
        {
            get { return _Cedula; }
            set { _Cedula = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
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
        public string Contrasena
        {
            get { return _Contrasena; }
            set { _Contrasena = value; }
        }
        public int Id_Rol
        {
            get { return _Id_Rol; }
            set { _Id_Rol = value; }
        }
        public int Id_Nombre_Linea
        {
            get { return _Id_Nombre_Linea; }
            set { _Id_Nombre_Linea = value; }
        }
        public int Acceso_1
        {
            get { return _Acceso_1; }
            set { _Acceso_1 = value; }
        }
        public int Acceso_2
        {
            get { return _Acceso_2; }
            set { _Acceso_2 = value; }
        }
        public int Acceso_3
        {
            get { return _Acceso_3; }
            set { _Acceso_3 = value; }
        }
        public int Acceso_4
        {
            get { return _Acceso_4; }
            set { _Acceso_4 = value; }
        }
        public int Acceso_5
        {
            get { return _Acceso_5; }
            set { _Acceso_5 = value; }
        }
        public int Acceso_6
        {
            get { return _Acceso_6; }
            set { _Acceso_6 = value; }
        }
        public int Acceso_7
        {
            get { return _Acceso_7; }
            set { _Acceso_7 = value; }
        }
        public int Acceso_8
        {
            get { return _Acceso_8; }
            set { _Acceso_8 = value; }
        }
        public int Acceso_9
        {
            get { return _Acceso_9; }
            set { _Acceso_9 = value; }
        }
        public int Acceso_10
        {
            get { return _Acceso_10; }
            set { _Acceso_10 = value; }
        }
        public int Acceso_11
        {
            get { return _Acceso_11; }
            set { _Acceso_11 = value; }
        }
        public int Acceso_12
        {
            get { return _Acceso_12; }
            set { _Acceso_12 = value; }
        }
        public int Acceso_13
        {
            get { return _Acceso_13; }
            set { _Acceso_13 = value; }
        }
        public int Acceso_14
        {
            get { return _Acceso_14; }
            set { _Acceso_14 = value; }
        }
        public int Acceso_15
        {
            get { return _Acceso_15; }
            set { _Acceso_15 = value; }
        }
        public int Acceso_16
        {
            get { return _Acceso_16; }
            set { _Acceso_16 = value; }
        }
        public int Acceso_17
        {
            get { return _Acceso_17; }
            set { _Acceso_17 = value; }
        }
        public int Acceso_18
        {
            get { return _Acceso_18; }
            set { _Acceso_18 = value; }
        }
        public int Acceso_19
        {
            get { return _Acceso_19; }
            set { _Acceso_19 = value; }
        }
        public int Acceso_20
        {
            get { return _Acceso_20; }
            set { _Acceso_20 = value; }
        }
        public int Acceso_21
        {
            get { return _Acceso_21; }
            set { _Acceso_21 = value; }
        }
        public int Acceso_22
        {
            get { return _Acceso_22; }
            set { _Acceso_22 = value; }
        }
        public int Acceso_23
        {
            get { return _Acceso_23; }
            set { _Acceso_23 = value; }
        }
        public int Acceso_24
        {
            get { return _Acceso_24; }
            set { _Acceso_24 = value; }
        }
        public int Acceso_25
        {
            get { return _Acceso_25; }
            set { _Acceso_25 = value; }
        }
        public int Acceso_26
        {
            get { return _Acceso_26; }
            set { _Acceso_26 = value; }
        }
        public int Acceso_27
        {
            get { return _Acceso_27; }
            set { _Acceso_27 = value; }
        }
        public int Acceso_28
        {
            get { return _Acceso_28; }
            set { _Acceso_28 = value; }
        }
        public int Acceso_29
        {
            get { return _Acceso_29; }
            set { _Acceso_29 = value; }
        }
        public int Acceso_30
        {
            get { return _Acceso_30; }
            set { _Acceso_30 = value; }
        }
        public string Aliado
        {
            get { return _Aliado; }
            set { _Aliado = value; }
        }
        public string Nombre_Linea
        {
            get { return _Nombre_Linea; }
            set { _Nombre_Linea = value; }
        }

        public string Cedulas
        {
            get
            { return _Cedulas; }

            set
            { _Cedulas = value; }
        }

        public string Id_rol
        {
            get
            {
                return _Id_rol;
            }

            set
            {
                _Id_rol = value;
            }
        }
        #endregion
    }
}
