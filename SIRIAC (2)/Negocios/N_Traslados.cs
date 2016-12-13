﻿using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class N_Traslados
    {
        D_Traslados objTraslados = new D_Traslados();
        public int abcIngresos(string pAccion, E_Traslados objE_Traslados)
        {
            return objTraslados.abcTraslados(pAccion, objE_Traslados);
        }
        public DataSet Selecciona_Maximo_Ingreso_Traslados(double p_Cuenta)
        {
            return objTraslados.Selecciona_Maximo_Ingreso_Traslados(p_Cuenta);
        }
        public DataSet Consulta_Cuenta_Traslados(double p_Cuenta)
        {
            return objTraslados.Consulta_Cuenta_Traslados(p_Cuenta);
        }
    }
}
