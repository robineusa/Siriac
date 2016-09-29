using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Mejor_Oferta
    {
        #region Atributos
        private double _Cuenta;
        private string _Servicio_TV;
        private int _Servicio_Internet;
        private string _Servicio_Voz;
        private string _HD;
        private string _HBO;
        private string _Fox;
        private string _Adulto;
        private string _ClaroVideo;
        private double _Num_Decos;
        private string _Revista;
        private string _Mix_Basico;
        private string _Elegido_Fijo_Movil;
        private string _SiembraHD;
        private string _Blindaje_Internet;
        private string _Siembra_Voz;
        private string _Activacion_ClaroVideo;
        private string _Ofrecimiento_1;
        private string _Ofrecimiento_2;
        private string _Ofrecimiento_3;
        //estos con los campos para guargar_informacion//
        private string _Fecha_Gestion;
        private string _Usuario_Gestion;
        private string _Aliado_Gestion;
        private int _Ofrecimiento_1_Envio;
        private int _Ofrecimiento_2_Envio;
        private int _Ofrecimiento_3_Envio;
        private int _Servicio_1;
        private int _Servicio_2;
        private int _Servicio_3;
        private int _Servicio_4;
        private int _Servicio_5;
        private int _Servicio_6;
        private int _Servicio_7;
        private int _Servicio_8;
        private int _Servicio_9;
        private int _Servicio_10;
        private int _Servicio_11;
        private int _Servicio_12;
        private int _Servicio_13;
        private int _Servicio_14;
        private int _Servicio_15;
        private int _Servicio_16;
        private int _Servicio_17;
        private int _Servicio_18;
        private int _Servicio_19;
        private int _Servicio_20;
        private int _Servicio_21;
        private int _Servicio_22;
        private int _Servicio_23;
        private int _Servicio_24;
        private int _Servicio_25;
        private int _Servicio_26;
        private int _Servicio_27;
        private int _Servicio_28;
        private int _Servicio_29;
        private int _Servicio_30;
        private int _Servicio_31;
        private int _Servicio_32;
        private int _Servicio_33;
        private string _Tipo_Contacto;
        private string _Gestion;
        private string _Cierre;
        private string _Razon;
        private string _Observaciones;
        #endregion
        #region Constructor
        public E_Mejor_Oferta()
        {
            _Cuenta = 0;
            _Servicio_TV = string.Empty;
            _Servicio_Internet = 0;
            _Servicio_Voz = string.Empty;
            _HD = string.Empty;
            _HBO = string.Empty;
            _Fox = string.Empty;
            _Adulto = string.Empty;
            _ClaroVideo = string.Empty;
            _Num_Decos = 0;
            _Revista = string.Empty;
            _Mix_Basico = string.Empty;
            _Elegido_Fijo_Movil = string.Empty;
            _SiembraHD = string.Empty;
            _Blindaje_Internet = string.Empty;
            _Siembra_Voz = string.Empty;
            _Activacion_ClaroVideo = string.Empty;
            _Ofrecimiento_1 = string.Empty;
            _Ofrecimiento_2 = string.Empty;
            _Ofrecimiento_3 = string.Empty;
            ///campos para guardar la informacio///
            _Fecha_Gestion = string.Empty;
            _Usuario_Gestion = string.Empty;
            _Aliado_Gestion = string.Empty;
            _Ofrecimiento_1_Envio = 0;
            _Ofrecimiento_2_Envio = 0;
            _Ofrecimiento_3_Envio = 0;
            _Servicio_1 = 0;
            _Servicio_2 = 0;
            _Servicio_3 = 0;
            _Servicio_4 = 0;
            _Servicio_5 = 0;
            _Servicio_6 = 0;
            _Servicio_7 = 0;
            _Servicio_8 = 0;
            _Servicio_9 = 0;
            _Servicio_10 = 0;
            _Servicio_11 = 0;
            _Servicio_12 = 0;
            _Servicio_13 = 0;
            _Servicio_14 = 0;
            _Servicio_15 = 0;
            _Servicio_16 = 0;
            _Servicio_17 = 0;
            _Servicio_18 = 0;
            _Servicio_19 = 0;
            _Servicio_20 = 0;
            _Servicio_21 = 0;
            _Servicio_22 = 0;
            _Servicio_23 = 0;
            _Servicio_24 = 0;
            _Servicio_25 = 0;
            _Servicio_26 = 0;
            _Servicio_27 = 0;
            _Servicio_28 = 0;
            _Servicio_29 = 0;
            _Servicio_30 = 0;
            _Servicio_31 = 0;
            _Servicio_32 = 0;
            _Servicio_33 = 0;
            _Tipo_Contacto = string.Empty;
            _Gestion = string.Empty;
            _Cierre = string.Empty;
            _Razon = string.Empty;
            _Observaciones = string.Empty;

        }
        #endregion
        #region Encapsulamientos
        public double Cuenta
        {
            get { return _Cuenta; }
            set { _Cuenta = value; }
        }
        public string Servicio_TV
        {
            get { return _Servicio_TV; }
            set { _Servicio_TV = value; }
        }
        public int Servicio_Internet
        {
            get { return _Servicio_Internet; }
            set { _Servicio_Internet = value; }
        }
        public string Servicio_Voz
        {
            get { return _Servicio_Voz; }
            set { _Servicio_Voz = value; }
        }
        public string HD
        {
            get { return _HD; }
            set { _HD = value; }
        }
        public string HBO
        {
            get { return _HBO; }
            set { _HBO = value; }
        }
        public string Fox
        {
            get { return _Fox; }
            set { _Fox = value; }
        }
        public string Adulto
        {
            get { return _Adulto; }
            set { _Adulto = value; }
        }
        public string ClaroVideo
        {
            get { return _ClaroVideo; }
            set { _ClaroVideo = value; }
        }
        public double Num_Decos
        {
            get { return _Num_Decos; }
            set { _Num_Decos = value; }
        }
        public string Revista
        {
            get { return _Revista; }
            set { _Revista = value; }
        }
        public string Mix_Basico
        {
            get { return _Mix_Basico; }
            set { _Mix_Basico = value; }
        }
        public string Elegido_Fijo_Movil
        {
            get { return _Elegido_Fijo_Movil; }
            set { _Elegido_Fijo_Movil = value; }
        }
        public string SiembraHD
        {
            get { return _SiembraHD; }
            set { _SiembraHD = value; }
        }
        public string Blindaje_Internet
        {
            get { return _Blindaje_Internet; }
            set { _Blindaje_Internet = value; }
        }
        public string Siembra_Voz
        {
            get { return _Siembra_Voz; }
            set { _Siembra_Voz = value; }
        }
        public string Activacion_ClaroVideo
        {
            get { return _Activacion_ClaroVideo; }
            set { _Activacion_ClaroVideo = value; }
        }
        public string Ofrecimiento_1
        {
            get { return _Ofrecimiento_1; }
            set { _Ofrecimiento_1 = value; }
        }
        public string Ofrecimiento_2
        {
            get { return _Ofrecimiento_2; }
            set { _Ofrecimiento_2 = value; }
        }
        public string Ofrecimiento_3
        {
            get { return _Ofrecimiento_3; }
            set { _Ofrecimiento_3 = value; }
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

        public int Ofrecimiento_1_Envio
        {
            get
            {
                return _Ofrecimiento_1_Envio;
            }

            set
            {
                _Ofrecimiento_1_Envio = value;
            }
        }

        public int Ofrecimiento_2_Envio
        {
            get
            {
                return _Ofrecimiento_2_Envio;
            }

            set
            {
                _Ofrecimiento_2_Envio = value;
            }
        }

        public int Ofrecimiento_3_Envio
        {
            get
            {
                return _Ofrecimiento_3_Envio;
            }

            set
            {
                _Ofrecimiento_3_Envio = value;
            }
        }

        public int Servicio_1
        {
            get
            {
                return _Servicio_1;
            }

            set
            {
                _Servicio_1 = value;
            }
        }

        public int Servicio_2
        {
            get
            {
                return _Servicio_2;
            }

            set
            {
                _Servicio_2 = value;
            }
        }

        public int Servicio_3
        {
            get
            {
                return _Servicio_3;
            }

            set
            {
                _Servicio_3 = value;
            }
        }

        public int Servicio_4
        {
            get
            {
                return _Servicio_4;
            }

            set
            {
                _Servicio_4 = value;
            }
        }

        public int Servicio_5
        {
            get
            {
                return _Servicio_5;
            }

            set
            {
                _Servicio_5 = value;
            }
        }

        public int Servicio_6
        {
            get
            {
                return _Servicio_6;
            }

            set
            {
                _Servicio_6 = value;
            }
        }

        public int Servicio_7
        {
            get
            {
                return _Servicio_7;
            }

            set
            {
                _Servicio_7 = value;
            }
        }

        public int Servicio_8
        {
            get
            {
                return _Servicio_8;
            }

            set
            {
                _Servicio_8 = value;
            }
        }

        public int Servicio_9
        {
            get
            {
                return _Servicio_9;
            }

            set
            {
                _Servicio_9 = value;
            }
        }

        public int Servicio_10
        {
            get
            {
                return _Servicio_10;
            }

            set
            {
                _Servicio_10 = value;
            }
        }

        public int Servicio_11
        {
            get
            {
                return _Servicio_11;
            }

            set
            {
                _Servicio_11 = value;
            }
        }

        public int Servicio_12
        {
            get
            {
                return _Servicio_12;
            }

            set
            {
                _Servicio_12 = value;
            }
        }

        public int Servicio_13
        {
            get
            {
                return _Servicio_13;
            }

            set
            {
                _Servicio_13 = value;
            }
        }

        public int Servicio_14
        {
            get
            {
                return _Servicio_14;
            }

            set
            {
                _Servicio_14 = value;
            }
        }

        public int Servicio_15
        {
            get
            {
                return _Servicio_15;
            }

            set
            {
                _Servicio_15 = value;
            }
        }

        public int Servicio_16
        {
            get
            {
                return _Servicio_16;
            }

            set
            {
                _Servicio_16 = value;
            }
        }

        public int Servicio_17
        {
            get
            {
                return _Servicio_17;
            }

            set
            {
                _Servicio_17 = value;
            }
        }

        public int Servicio_18
        {
            get
            {
                return _Servicio_18;
            }

            set
            {
                _Servicio_18 = value;
            }
        }

        public int Servicio_19
        {
            get
            {
                return _Servicio_19;
            }

            set
            {
                _Servicio_19 = value;
            }
        }

        public int Servicio_20
        {
            get
            {
                return _Servicio_20;
            }

            set
            {
                _Servicio_20 = value;
            }
        }

        public int Servicio_21
        {
            get
            {
                return _Servicio_21;
            }

            set
            {
                _Servicio_21 = value;
            }
        }

        public int Servicio_22
        {
            get
            {
                return _Servicio_22;
            }

            set
            {
                _Servicio_22 = value;
            }
        }

        public int Servicio_23
        {
            get
            {
                return _Servicio_23;
            }

            set
            {
                _Servicio_23 = value;
            }
        }

        public int Servicio_24
        {
            get
            {
                return _Servicio_24;
            }

            set
            {
                _Servicio_24 = value;
            }
        }

        public int Servicio_25
        {
            get
            {
                return _Servicio_25;
            }

            set
            {
                _Servicio_25 = value;
            }
        }

        public int Servicio_26
        {
            get
            {
                return _Servicio_26;
            }

            set
            {
                _Servicio_26 = value;
            }
        }

        public int Servicio_27
        {
            get
            {
                return _Servicio_27;
            }

            set
            {
                _Servicio_27 = value;
            }
        }

        public int Servicio_28
        {
            get
            {
                return _Servicio_28;
            }

            set
            {
                _Servicio_28 = value;
            }
        }

        public int Servicio_29
        {
            get
            {
                return _Servicio_29;
            }

            set
            {
                _Servicio_29 = value;
            }
        }

        public int Servicio_30
        {
            get
            {
                return _Servicio_30;
            }

            set
            {
                _Servicio_30 = value;
            }
        }

        public int Servicio_31
        {
            get
            {
                return _Servicio_31;
            }

            set
            {
                _Servicio_31 = value;
            }
        }

        public int Servicio_32
        {
            get
            {
                return _Servicio_32;
            }

            set
            {
                _Servicio_32 = value;
            }
        }

        public int Servicio_33
        {
            get
            {
                return _Servicio_33;
            }

            set
            {
                _Servicio_33 = value;
            }
        }

        public string Tipo_Contacto
        {
            get
            {
                return _Tipo_Contacto;
            }

            set
            {
                _Tipo_Contacto = value;
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

        public string Cierre
        {
            get
            {
                return _Cierre;
            }

            set
            {
                _Cierre = value;
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

        public string Observaciones
        {
            get
            {
                return _Observaciones;
            }

            set
            {
                _Observaciones = value;
            }
        }

        #endregion
    }

}
