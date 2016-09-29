using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Drawing;
using System.IO;
using Entidades;
using Negocios;
using System.Web.Services;

public partial class Reporte_Chiquito : System.Web.UI.Page
{
    public E_Clientes Obj_Entidad_Clientes = new E_Clientes();
    public N_Clientes Obj_Neg_Clientes = new N_Clientes();
    public E_Arbol_Outbound Obj_Entidad_Arbol_Outbound = new E_Arbol_Outbound();
    public N_Arbol_Outbound Obj_Neg_Arbol_Outbound = new N_Arbol_Outbound();
    public E_Convenio_Electronico Obj_Entidad_Convenio_Electronico = new E_Convenio_Electronico();
    public N_Convenio_Electronico Obj_Neg_Convenio_Electronico = new N_Convenio_Electronico();
    public E_Logistica_Inversa Obj_Entidad_Logistica = new E_Logistica_Inversa();
    public N_Logistica_Inversa Obj_Neg_Logistica = new N_Logistica_Inversa();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod()]
    public void prueba(){
    DataSet dt = new DataSet();
    dt = Obj_Neg_Logistica.Reporte_Cierre();

}
}
        
