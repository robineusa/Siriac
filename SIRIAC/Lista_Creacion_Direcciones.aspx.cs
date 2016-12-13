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
    protected void Cuenta_Cliente_TextChanged(object sender, EventArgs e)
    {
        if (Cuenta_Cliente.Text != "")
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Traslados.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);
            dt = Obj_Neg_Traslados.Consulta_Casos_Abiertos_Cuenta(Obj_Entidad_Traslados.Cuenta_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {

                CONSULTA_CASOS.DataSource = dt.Tables[0];
                CONSULTA_CASOS.DataBind();
            }
            else
            {
                CONSULTA_CASOS.DataSource = null;
                CONSULTA_CASOS.DataBind();
            }
        }
        else { }
    }
    protected void Id_Ingreso_TextChanged(object sender, EventArgs e)
    {
        if (Id_Traslado.Text != "")
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Traslados.Id_Traslado = Convert.ToDouble(Id_Traslado.Text);
            dt = Obj_Neg_Traslados.Consulta_Casos_Abiertos_Id(Obj_Entidad_Traslados.Id_Traslado);

            if (dt.Tables[0].Rows.Count > 0)
            {

                CONSULTA_CASOS.DataSource = dt.Tables[0];
                CONSULTA_CASOS.DataBind();
            }
            else
            {
                CONSULTA_CASOS.DataSource = null;
                CONSULTA_CASOS.DataBind();
            }
        }
        else { }
    }
}