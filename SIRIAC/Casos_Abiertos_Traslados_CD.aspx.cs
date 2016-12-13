using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Casos_Abiertos_Traslados_CD : System.Web.UI.Page
{
    public E_Traslados Obj_Entidad_Traslados = new E_Traslados();
    public N_Traslados Obj_Neg_Traslados = new N_Traslados();
    protected void Page_Load(object sender, EventArgs e)
    {
        Cargar_Casos_Traslados();
    }
    protected void Cargar_Casos_Traslados()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Traslados.Aliado_Apertura = Session["Aliado_Usuario"].ToString();
        Obj_Entidad_Traslados.Nombre_Linea_Escalado = "CELULA CREACION DIRECCION";
        dt = Obj_Neg_Traslados.Consulta_Casos_Abiertos_Traslados(Obj_Entidad_Traslados.Aliado_Apertura, Obj_Entidad_Traslados.Nombre_Linea_Escalado);

        if (dt.Tables[0].Rows.Count > 0)
        {

            CASOS_ESCALADOS_TRASLADOS.DataSource = dt.Tables[0];
            CASOS_ESCALADOS_TRASLADOS.DataBind();
        }
        else
        {
            CASOS_ESCALADOS_TRASLADOS.DataSource = null;
            CASOS_ESCALADOS_TRASLADOS.DataBind();
        }
    }
}