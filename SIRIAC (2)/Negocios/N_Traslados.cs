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
        public DataSet Consulta_Casos_Abiertos_Traslados(string pNombre_Linea)
        {
            return objTraslados.Consulta_Casos_Abiertos_Traslados(pNombre_Linea);
        }
        public DataSet Selecciona_Maximo_Ingreso_Traslados(double p_Cuenta)
        {
            return objTraslados.Selecciona_Maximo_Ingreso_Traslados(p_Cuenta);
        }
        public DataSet Consulta_Cuenta_Traslados(double p_Cuenta)
        {
            return objTraslados.Consulta_Cuenta_Traslados(p_Cuenta);
        }
        public DataSet Consulta_Casos_Escalados_Traslados()
        {
            return objTraslados.Consulta_Casos_Escalados_Traslados();
        }
        public DataSet Consulta_Casos_Abiertos_Id(double pId_Ingreso)
        {
            return objTraslados.Consulta_Casos_Abiertos_Id(pId_Ingreso);
        }
        public DataSet Consulta_Casos_Abiertos_Cuenta(double pCuenta)
        {
            return objTraslados.Consulta_Casos_Abiertos_Cuenta(pCuenta);
        }

        public DataSet Consulta_Usuario_Back(double pId_Traslado)
        {
            return objTraslados.Consulta_Usuario_Back(pId_Traslado);
        }
        public int Actualiza_Usuario_Back(double Id_Ingreso, E_Traslados objE_Traslados)
        {
            return objTraslados.Actualiza_Usuario_Back(Id_Ingreso, objE_Traslados);
        }
        public DataSet Consulta_Admin_Solicitudes_Crear_Direccion(string pFecha_Inicial, string pFecha_Final)
        {
            return objTraslados.Consulta_Admin_Solicitudes_Crear_Direccion(pFecha_Inicial, pFecha_Final);
        }
        public DataSet Consulta_Admin_Gestion_Crear_Direccion(string pFecha_Inicial, string pFecha_Final)
        {
            return objTraslados.Consulta_Admin_Gestion_Crear_Direccion(pFecha_Inicial, pFecha_Final);
        }
        public DataSet Consulta_Traslados_PorID(double pId_Traslado)
        {
            return objTraslados.Consulta_Traslados_PorID(pId_Traslado);
        }
        public int Actualizar_Traslado_Cierre(string pAccion, E_Traslados objE_Traslados)
        {
            return objTraslados.Actualizar_Traslado_Cierre(pAccion, objE_Traslados);
        }
        public int Actualizar_Traslado_Gestion(string pAccion, E_Traslados objE_Traslados)
        {
            return objTraslados.Actualizar_Traslado_Gestion(pAccion, objE_Traslados);
        }
        public DataSet Consultar_Nodo_Existente(string pNodo)
        {
            return objTraslados.Consultar_Nodo_Existente(pNodo);
        }
        public int Actualiza_Usuario_Back_Gestion(double Id_Ingreso, E_Traslados objE_Traslados)
        {
            return objTraslados.Actualiza_Usuario_Back_Gestion(Id_Ingreso, objE_Traslados);
        }
        public DataSet Consulta_Casos_Escalados_Traslados_Por_Estado(string pEstado)
        {
            return objTraslados.Consulta_Casos_Escalados_Traslados_Por_Estado(pEstado);
        }
        public int Actualiza_Usuario_Outbound_Inicio(double Id_Ingreso, E_Traslados objE_Traslados)
        {
            return objTraslados.Actualiza_Usuario_Outbound_Inicio(Id_Ingreso, objE_Traslados);
        }
        public int Actualiza_Usuario_Outbound_Gestion(double Id_Ingreso, E_Traslados objE_Traslados)
        {
            return objTraslados.Actualiza_Usuario_Outbound_Gestion(Id_Ingreso, objE_Traslados);
        }
        public DataSet Consulta_Usuario_Outbound(double pId_Traslado)
        {
            return objTraslados.Consulta_Usuario_Outbound(pId_Traslado);
        }
        public int Actualizar_Traslado_Gestion_Outbound(string pAccion, E_Traslados objE_Traslados)
        {
            return objTraslados.Actualizar_Traslado_Gestion_Outbound(pAccion, objE_Traslados);
        }
        public DataSet Consulta_Casos_Escalados_Traslados_Por_Estado_Celula(string pBack)
        {
            return objTraslados.Consulta_Casos_Escalados_Traslados_Por_Estado_Celula(pBack);
        }
        public DataSet Consulta_Admin_Casos_Traslados_Cuenta(double pCuenta)
        {
            return objTraslados.Consulta_Admin_Casos_Traslados_Cuenta(pCuenta);
        }
        public DataSet Consulta_Admin_Casos_Traslados_Usuario(string pUsuario)
        {
            return objTraslados.Consulta_Admin_Casos_Traslados_Usuario(pUsuario);
        }
        public DataSet Consulta_Admin_Casos_Traslados_Id(double pId_Traslado)
        {
            return objTraslados.Consulta_Admin_Casos_Traslados_Id(pId_Traslado);
        }
        public int Actualiza_Ingreso_Back_Traslados(double Id_Traslado, E_Traslados objE_Traslados)
        {
            return objTraslados.Actualiza_Ingreso_Back_Traslados(Id_Traslado, objE_Traslados);
        }
    }
}
