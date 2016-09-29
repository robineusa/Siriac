using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Marcaciones
    {
        #region Atributos
        private int _Id_Marcacion;
        private string _Tipo_Atencion;
        private string _Razon;
        private string _Subrazon;
        private string _Descipcion;
        private string _Posible_Causa;
        private string _Spc;
        private string _Canal_Habilidato;
        private string _Que_Hcer;
        private string _Codigo_de_Cierre;
        private string _Asociada_Ajuste;
        private string _Area_Usuario_Escalar;
        private string _Quien_Finaliza;
        private string _Tipologia_Sujeta_Cun;
        private string _Servicio_Que_Crea;
        private string _Responsable;
        private string _Area_Responsable;
        private string _Macroproceso;
        private string _Tipo_de_Novedad;
        private string _Tipo_de_Solicitud;
        private string _Servicio_Afectado;
        private string _Marcacion;
        #endregion
        #region Constructor
        public E_Marcaciones() {
            _Id_Marcacion = 0;
            _Tipo_Atencion = string.Empty;
            _Razon = string.Empty;
            _Subrazon = string.Empty;
            _Descipcion = string.Empty;
            _Posible_Causa = string.Empty;
            _Spc = string.Empty;
            _Canal_Habilidato = string.Empty;
            _Que_Hcer = string.Empty;
            _Codigo_de_Cierre = string.Empty;
            _Asociada_Ajuste = string.Empty;
            _Area_Usuario_Escalar = string.Empty;
            _Quien_Finaliza = string.Empty;
            _Tipologia_Sujeta_Cun = string.Empty;
            _Servicio_Que_Crea = string.Empty;
            _Responsable = string.Empty;
            _Area_Responsable = string.Empty;
            _Macroproceso = string.Empty;
            _Tipo_de_Novedad = string.Empty;
            _Tipo_de_Solicitud = string.Empty;
            _Servicio_Afectado = string.Empty;
            _Marcacion = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public int Id_Marcacion
        {
            get { return _Id_Marcacion; }
            set { _Id_Marcacion = value; }
        }
        public string Tipo_Atencion
        {
            get { return _Tipo_Atencion; }
            set { _Tipo_Atencion = value; }
        }
        public string Razon
        {
            get { return _Razon; }
            set { _Razon = value; }
        }
        public string Subrazon
        {
            get { return _Subrazon; }
            set { _Subrazon = value; }
        }
        public string Descipcion
        {
            get { return _Descipcion; }
            set { _Descipcion = value; }
        }
        public string Posible_Causa
        {
            get { return _Posible_Causa; }
            set { _Posible_Causa = value; }
        }
        public string Spc
        {
            get { return _Spc; }
            set { _Spc = value; }
        }
        public string Canal_Habilidato
        {
            get { return _Canal_Habilidato; }
            set { _Canal_Habilidato = value; }
        }
        public string Que_Hcer
        {
            get { return _Que_Hcer; }
            set { _Que_Hcer = value; }
        }
        public string Codigo_de_Cierre
        {
            get { return _Codigo_de_Cierre; }
            set { _Codigo_de_Cierre = value; }
        }
        public string Asociada_Ajuste
        {
            get { return _Asociada_Ajuste; }
            set { _Asociada_Ajuste = value; }
        }
        public string Area_Usuario_Escalar
        {
            get { return _Area_Usuario_Escalar; }
            set { _Area_Usuario_Escalar = value; }
        }
        public string Quien_Finaliza
        {
            get { return _Quien_Finaliza; }
            set { _Quien_Finaliza = value; }
        }
        public string Tipologia_Sujeta_Cun
        {
            get { return _Tipologia_Sujeta_Cun; }
            set { _Tipologia_Sujeta_Cun = value; }
        }
        public string Servicio_Que_Crea
        {
            get { return _Servicio_Que_Crea; }
            set { _Servicio_Que_Crea = value; }
        }
        public string Responsable
        {
            get { return _Responsable; }
            set { _Responsable = value; }
        }
        public string Area_Responsable
        {
            get { return _Area_Responsable; }
            set { _Area_Responsable = value; }
        }
        public string Macroproceso
        {
            get { return _Macroproceso; }
            set { _Macroproceso = value; }
        }
        public string Tipo_de_Novedad
        {
            get { return _Tipo_de_Novedad; }
            set { _Tipo_de_Novedad = value; }
        }
        public string Tipo_de_Solicitud
        {
            get { return _Tipo_de_Solicitud; }
            set { _Tipo_de_Solicitud = value; }
        }
        public string Servicio_Afectado
        {
            get { return _Servicio_Afectado; }
            set { _Servicio_Afectado = value; }
        }
        public string Marcacion
        {
            get { return _Marcacion; }
            set { _Marcacion = value; }
        }
        #endregion
    }
}
