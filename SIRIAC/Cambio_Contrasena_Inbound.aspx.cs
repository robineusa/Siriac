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
public partial class Cambio_Contrasena_Inbound : System.Web.UI.Page
{
    public E_Usuarios Obj_Entidad_Usuarios = new E_Usuarios();
    public N_Usuarios Obj_Neg_Usuarios = new N_Usuarios();

    protected void Page_Load(object sender, EventArgs e)
    {
        Cargar_Registro();
    }
    protected void Controles_a_Objetos()
    {
        Obj_Entidad_Usuarios.Contrasena = Contrasena_1.Text;
        Obj_Entidad_Usuarios.Usuario_RR=Session["Usuario_Logueado"].ToString();
    }
    protected void Actualizar_Usuario() { 
    
        var Guardar_Datos = -1;
        Controles_a_Objetos();
        Guardar_Datos = Obj_Neg_Usuarios.abcUsuarios("ACTUALIZAR", Obj_Entidad_Usuarios);
        if (Guardar_Datos != -1)
        {
            Cargar_Registro();
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script1, true);
            
            Contrasena_1.Text = "";
            Contrasena_2.Text = "";
        }
        else { }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        var Guardar_Datos = -1;
        Controles_a_Objetos();
        Guardar_Datos = Obj_Neg_Usuarios.Actualizar_Contrasena("ACTUALIZAR", Obj_Entidad_Usuarios);
        if (Guardar_Datos != -1)
        {
            Cargar_Registro();
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script1, true);
            Contrasena_1.Text = "";
            Contrasena_2.Text = "";
        }
        else { }
    }
    protected void Cargar_Registro() {
        
        DataSet dt3 = new DataSet();
        Obj_Entidad_Usuarios.Usuario_RR=Session["Usuario_Logueado"].ToString();
        dt3 = Obj_Neg_Usuarios.Consulta_Datos_Usuario(Obj_Entidad_Usuarios.Usuario_RR);

        if (dt3.Tables[0].Rows.Count > 0)
        {

            Cedula.Text = dt3.Tables[0].Rows[0]["CEDULA"].ToString();
            Nombre_Usuario.Text = dt3.Tables[0].Rows[0]["NOMBRE"].ToString();
            Usuario_RR.Text = dt3.Tables[0].Rows[0]["USUARIO_RR"].ToString();
            Contrasena_Actual.Text = dt3.Tables[0].Rows[0]["CONTRASENA"].ToString();
            Rol_Usuario.Text = dt3.Tables[0].Rows[0]["ID_ROL"].ToString();
            Usuario_Agendamiento.Text = dt3.Tables[0].Rows[0]["USUARIO_AGENDAMIENTO"].ToString();
           
            //Contrasena_2.Text = "";
        }
        else
        {
            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje2", script2, true);
        }
        //Contrasena_1.Text = "";
    }
}