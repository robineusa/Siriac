using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Ofrecimientos_Incremento
    {
        #region Atributos
        private string _Fecha_Gestion;
        private string _Usuario_Gestion;
        private Int64 _Cuenta_Cliente;
        private Int64 _Periodo_Incremento;
        private Int64 _Ofrecimiento_1;
        private Int64 _Ofrecimiento_2;
        private Int64 _Ofrecimiento_3;
        private Int64 _Ofrecimiento_4;
        private Int64 _Ofrecimiento_5;
        private Int64 _Ofrecimiento_6;
        #endregion
        #region Constructor
        public E_Ofrecimientos_Incremento()
        {
            _Fecha_Gestion = string.Empty;
            _Usuario_Gestion = string.Empty;
            _Cuenta_Cliente = 0;
            _Periodo_Incremento = 0;
            _Ofrecimiento_1 = 0;
            _Ofrecimiento_2 = 0;
            _Ofrecimiento_3 = 0;
            _Ofrecimiento_4 = 0;
            _Ofrecimiento_5 = 0;
            _Ofrecimiento_6 = 0;
        }
        #endregion
        #region Encapsulamientos
        public string Fecha_Gestion
        {
            get { return _Fecha_Gestion; }
            set { _Fecha_Gestion = value; }
        }
        public string Usuario_Gestion
        {
            get { return _Usuario_Gestion; }
            set { _Usuario_Gestion = value; }
        }
        public Int64 Cuenta_Cliente
        {
            get { return _Cuenta_Cliente; }
            set { _Cuenta_Cliente = value; }
        }
        public Int64 Periodo_Incremento
        {
            get { return _Periodo_Incremento; }
            set { _Periodo_Incremento = value; }
        }
        public Int64 Ofrecimiento_1
        {
            get { return _Ofrecimiento_1; }
            set { _Ofrecimiento_1 = value; }
        }
        public Int64 Ofrecimiento_2
        {
            get { return _Ofrecimiento_2; }
            set { _Ofrecimiento_2 = value; }
        }
        public Int64 Ofrecimiento_3
        {
            get { return _Ofrecimiento_3; }
            set { _Ofrecimiento_3 = value; }
        }
        public Int64 Ofrecimiento_4
        {
            get { return _Ofrecimiento_4; }
            set { _Ofrecimiento_4 = value; }
        }
        public Int64 Ofrecimiento_5
        {
            get { return _Ofrecimiento_5; }
            set { _Ofrecimiento_5 = value; }
        }
        public Int64 Ofrecimiento_6
        {
            get { return _Ofrecimiento_6; }
            set { _Ofrecimiento_6 = value; }
        }
        #endregion

    }
}
