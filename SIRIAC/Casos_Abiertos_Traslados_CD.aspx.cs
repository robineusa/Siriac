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
        Obj_Entidad_Traslados.Nombre_Linea_Escalado = "CELULA CREACION DIRECCION";
        dt = Obj_Neg_Traslados.Consulta_Casos_Abiertos_Traslados(Obj_Entidad_Traslados.Nombre_Linea_Escalado);

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
        DataSet dt = new DataSet();
        //Obj_Entidad_Ingresos.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);
        //dt = Obj_Neg_Ingresos.Consulta_Casos_Abiertos_Cuenta(Obj_Entidad_Ingresos.Cuenta_Cliente);
        Obj_Entidad_Traslados.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);


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
    protected void Id_Ingreso_TextChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        //Obj_Entidad_Ingresos.Id_Ingreso = Convert.ToDouble(Id_Ingreso.Text);
        //dt = Obj_Neg_Ingresos.Consulta_Casos_Abiertos_Id(Obj_Entidad_Ingresos.Id_Ingreso);

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
}