using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administracion_de_Casos_Traslados : System.Web.UI.Page
{
    E_Traslados Obj_Entidad_Traslados = new E_Traslados();
    N_Traslados Obj_Neg_Traslados = new N_Traslados();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void A_Cuenta_Cliente_TextChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Traslados.Cuenta_Cliente = Convert.ToDouble(A_Cuenta_Cliente.Text);
        dt = Obj_Neg_Traslados.Consulta_Admin_Casos_Traslados_Cuenta(Obj_Entidad_Traslados.Cuenta_Cliente);
        if (dt.Tables[0].Rows.Count > 0)
        {
            A_CONSULTA_CASOS.DataSource = dt.Tables[0];
            A_CONSULTA_CASOS.DataBind();
        }
        else
        {
            string script = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script, true);
            Limpiar();
        }
        A_Usuario_Creacion.Text = "";
        A_Id_Ingreso.Text = "";
    }
    protected void A_Id_Ingreso_TextChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Traslados.Id_Traslado= Convert.ToDouble(A_Id_Ingreso.Text);
        dt = Obj_Neg_Traslados.Consulta_Admin_Casos_Traslados_Id(Obj_Entidad_Traslados.Id_Traslado);
        if (dt.Tables[0].Rows.Count > 0)
        {

            A_CONSULTA_CASOS.DataSource = dt.Tables[0];
            A_CONSULTA_CASOS.DataBind();
        }
        else
        {
            string script = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script, true);
            Limpiar();
        }
        A_Cuenta_Cliente.Text = "";
        A_Usuario_Creacion.Text = "";
    }
    protected void A_Usuario_Creacion_TextChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Traslados.Usuario_Apertura = A_Usuario_Creacion.Text;
        dt = Obj_Neg_Traslados.Consulta_Admin_Casos_Traslados_Usuario(Obj_Entidad_Traslados.Usuario_Apertura);
        if (dt.Tables[0].Rows.Count > 0)
        {

            A_CONSULTA_CASOS.DataSource = dt.Tables[0];
            A_CONSULTA_CASOS.DataBind();
        }
        else
        {
            string script = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script, true);
            Limpiar();
        }
        A_Cuenta_Cliente.Text = "";
        A_Id_Ingreso.Text = "";
    }
    protected void Limpiar()
    {
        A_Cuenta_Cliente.Text = string.Empty;
        A_Id_Ingreso.Text = string.Empty;
        A_Usuario_Creacion.Text = string.Empty;
        A_CONSULTA_CASOS.DataSource = null;
        A_CONSULTA_CASOS.DataBind();
    }
}