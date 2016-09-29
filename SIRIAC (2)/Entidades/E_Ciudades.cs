using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class E_Ciudades
    {
        #region Atributos
        private int _Id_Departamento;
        private string _Departamento;
        private int _Id_Municipio;
        private string _Municipio;
        #endregion
        #region Constructor
        public E_Ciudades() {
            _Id_Departamento = 0;
            _Id_Municipio = 0;
            _Departamento = string.Empty;
            _Municipio = string.Empty;
        }
        #endregion
        #region Encapsulamientos
        public int Id_Departamento
        {
            get { return _Id_Departamento; }
            set { _Id_Departamento = value; }
        }
        public string Departamento
        {
            get { return _Departamento; }
            set { _Departamento = value; }
        }
        public int Id_Municipio
        {
            get { return _Id_Municipio; }
            set { _Id_Municipio = value; }
        }
        public string Municipio
        {
            get { return _Municipio; }
            set { _Municipio = value; }
        }
        #endregion
    }
}
