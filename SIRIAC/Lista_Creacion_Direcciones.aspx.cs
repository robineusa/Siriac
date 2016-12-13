using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Lista_Creaciojn_Direcciones : System.Web.UI.Page
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
       
        dt = Obj_Neg_Traslados.Consulta_Casos_Escalados_Traslados();

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