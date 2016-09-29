using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using Entidades;
using Negocios;

public partial class Inicio_de_Sesion : System.Web.UI.Page
{
    public E_Usuarios Obj_Entidad_Usuarios = new E_Usuarios();
    public N_Usuarios Obj_Neg_Usuarios = new N_Usuarios();

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    private void Ubicaciones()
    {
        Obj_Entidad_Usuarios.Usuario_RR = Usuario.Text;
        Obj_Entidad_Usuarios.Contrasena = Clave.Text;
    }

    protected void Aceptar_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        Obj_Entidad_Usuarios.Usuario_RR = Usuario.Text;
        Obj_Entidad_Usuarios.Contrasena = Clave.Text;
        ds = Obj_Neg_Usuarios.Identifica_Usuario(Obj_Entidad_Usuarios.Usuario_RR, Obj_Entidad_Usuarios.Contrasena);

        if (ds.Tables[0].Rows.Count > 0)
        {
            Session["Cedula"] = ds.Tables[0].Rows[0]["CEDULA"].ToString();
            Session["Usuario_Logueado"] = ds.Tables[0].Rows[0]["Usuario_RR"].ToString();
            Session["Rol_Usuario"] = ds.Tables[0].Rows[0]["Id_Rol"].ToString();
            Session["Aliado_Usuario"] = ds.Tables[0].Rows[0]["Aliado"].ToString();
            Session["Nombre_Linea_Usuario"] = ds.Tables[0].Rows[0]["Nombre_Linea"].ToString();
            Session["Nombre_Usuario"] = ds.Tables[0].Rows[0]["Nombre"].ToString();
            Session["Acceso_1"] = ds.Tables[0].Rows[0]["Acceso_1"].ToString();
            Session["Acceso_2"] = ds.Tables[0].Rows[0]["Acceso_2"].ToString();
            Session["Acceso_3"] = ds.Tables[0].Rows[0]["Acceso_3"].ToString();
            Session["Acceso_4"] = ds.Tables[0].Rows[0]["Acceso_4"].ToString();
            Session["Acceso_5"] = ds.Tables[0].Rows[0]["Acceso_5"].ToString();
            Session["Acceso_6"] = ds.Tables[0].Rows[0]["Acceso_6"].ToString();
            Session["Acceso_7"] = ds.Tables[0].Rows[0]["Acceso_7"].ToString();
            Session["Acceso_8"] = ds.Tables[0].Rows[0]["Acceso_8"].ToString();
            Session["Acceso_9"] = ds.Tables[0].Rows[0]["Acceso_9"].ToString();
            Session["Acceso_10"] = ds.Tables[0].Rows[0]["Acceso_10"].ToString();
            Session["Acceso_11"] = ds.Tables[0].Rows[0]["Acceso_11"].ToString();
            Session["Acceso_12"] = ds.Tables[0].Rows[0]["Acceso_12"].ToString();
            Session["Acceso_13"] = ds.Tables[0].Rows[0]["Acceso_13"].ToString();
            Session["Acceso_14"] = ds.Tables[0].Rows[0]["Acceso_14"].ToString();
            Session["Acceso_15"] = ds.Tables[0].Rows[0]["Acceso_15"].ToString();
            Session["Acceso_16"] = ds.Tables[0].Rows[0]["Acceso_16"].ToString();
            Session["Acceso_17"] = ds.Tables[0].Rows[0]["Acceso_17"].ToString();
            Session["Acceso_18"] = ds.Tables[0].Rows[0]["Acceso_18"].ToString();
            Session["Acceso_19"] = ds.Tables[0].Rows[0]["Acceso_19"].ToString();
            Session["Acceso_20"] = ds.Tables[0].Rows[0]["Acceso_20"].ToString();
            Session["Acceso_21"] = ds.Tables[0].Rows[0]["Acceso_21"].ToString();
            Session["Acceso_22"] = ds.Tables[0].Rows[0]["Acceso_22"].ToString();
            Session["Acceso_23"] = ds.Tables[0].Rows[0]["Acceso_23"].ToString();
            Session["Acceso_24"] = ds.Tables[0].Rows[0]["Acceso_24"].ToString();
            Session["Acceso_25"] = ds.Tables[0].Rows[0]["Acceso_25"].ToString();
            Session["Acceso_26"] = ds.Tables[0].Rows[0]["Acceso_26"].ToString();
            Session["Acceso_27"] = ds.Tables[0].Rows[0]["Acceso_27"].ToString();
            Session["Acceso_28"] = ds.Tables[0].Rows[0]["Acceso_28"].ToString();
            Session["Acceso_29"] = ds.Tables[0].Rows[0]["Acceso_29"].ToString();
            Session["Acceso_30"] = ds.Tables[0].Rows[0]["Acceso_30"].ToString();

            if (Session["Rol_Usuario"].ToString() == "1") { Response.Redirect("Bienvenida_Administrador.aspx"); }
            else
                if (Session["Rol_Usuario"].ToString() == "2") { Response.Redirect("Bienvenida_Celula.aspx"); }
                else
                    if (Session["Rol_Usuario"].ToString() == "3") { Response.Redirect("Bienvenida_Asesor.aspx"); }
                    else
                        if (Session["Rol_Usuario"].ToString() == "6") { Response.Redirect("Bienvenida_Lider.aspx"); }
                        else
                            if (Session["Rol_Usuario"].ToString() == "5") { Response.Redirect("Bienvenida_Jefe.aspx"); }
                            else
                                if (Session["Rol_Usuario"].ToString() == "4") { Response.Redirect("Bienvenida_MEC.aspx"); }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script> alert('Usuario o contraseña incorrecto');</script>");
        }

    }
    private void Limpiar()
    {
        Usuario.Text = string.Empty;
        Clave.Text = string.Empty;
    }
}