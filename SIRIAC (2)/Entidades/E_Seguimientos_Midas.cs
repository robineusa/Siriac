using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Seguimientos_Midas
    {
        #region Atributos
        private double _Id_Seguimiento;
        private string _Usuario_Creacion;
        private string _Fecha_Creacion;
        private string _Motivo_Seguimiento;
        private double _Cuenta_Cliente;
        private DateTime _Fecha_Hora_Seguimiento;
        private string _Tipo_Hipotesis;
        #endregion
        #region Constructor
        public E_Seguimientos_Midas()
        {
            _Id_Seguimiento = 0;
            _Usuario_Creacion = string.Empty;
            _Fecha_Creacion = string.Empty;
            _Motivo_Seguimiento = string.Empty;
            _Cuenta_Cliente = 0;
            _Fecha_Hora_Seguimiento =DateTime.Now ;
            _Tipo_Hipotesis = string.Empty;
        }
        #endregion
        #region Encapsulamientos

        public double Id_Seguimiento
        {
            get { return _Id_Seguimiento; }
            set { _Id_Seguimiento = value; }
        }
        public string Usuario_Creacion
        {
            get { return _Usuario_Creacion; }
            set { _Usuario_Creacion = value; }
        }
        public string Fecha_Creacion
        {
            get { return _Fecha_Creacion; }
            set { _Fecha_Creacion = value; }
        }
        public string Motivo_Seguimiento
        {
            get { return _Motivo_Seguimiento; }
            set { _Motivo_Seguimiento = value; }
        }
        public double Cuenta_Cliente
        {
            get { return _Cuenta_Cliente; }
            set { _Cuenta_Cliente = value; }
        }
        public DateTime Fecha_Hora_Seguimiento
        {
            get { return _Fecha_Hora_Seguimiento; }
            set { _Fecha_Hora_Seguimiento = value; }
        }
        public string Tipo_Hipotesis
        {
            get { return _Tipo_Hipotesis; }
            set { _Tipo_Hipotesis = value; }
        }
        #endregion
    }
}
