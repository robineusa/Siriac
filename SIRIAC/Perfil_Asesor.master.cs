using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Perfil_Asesor : System.Web.UI.MasterPage
{

    public E_Buen_Servicio Obj_Entidad_Buen_Servicio = new E_Buen_Servicio();
    public N_Buen_Servicio Obj_Neg_Buen_Servicio = new N_Buen_Servicio();
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.AddHeader("cache-control", "private");
        Response.AddHeader("pragma", "no-cache");
        Response.AddHeader("Cache-Control", "must-revalidate");
        Response.AddHeader("Cache-Control", "no-cache");
        
        //if (Session["Acceso_20"].ToString() == "1") { Dir_Creadas.Attributes.CssStyle.Add("Display", "block"); } else { Dir_Creadas.Attributes.CssStyle.Add("Display", "none"); }
        if (Session["Rol_Usuario"].ToString() == "3") { } else { Response.Redirect("Inicio_de_Sesion.aspx?id=" + Session["Rol_Usuario"].ToString() + ""); };
        Nombre_Usuario.Text = Session["Nombre_Usuario"].ToString();
    }
    
    protected void salir(object sender, EventArgs e)
    {

        Session["Usuario_Logueado"] = "";
        Session["Nombre_Usuario"] = "";
        Session["Rol_Usuario"] = "";
        Session["Aliado_Usuario"] = "";
        Session["Nombre_Linea_Usuario"] = "";
        Response.Redirect("Inicio_de_Sesion.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ContentPlaceHolder1.Visible = false;
        CleanControl(this.Controls);
        Session["Usuario_Logueado"] = "";
        Session["Nombre_Usuario"] = "";
        Session["Rol_Usuario"] = "";
        Session["Aliado_Usuario"] = "";
        Session["Nombre_Linea_Usuario"] = "";
        Response.Redirect("Inicio_de_Sesion.aspx");
        ContentPlaceHolder1.Visible = false;

    }
    public void CleanControl(ControlCollection controles)
    {
        foreach (Control control in controles)
        {
            if (control is TextBox)
            {
                ((TextBox)control).Text = "";
                ((TextBox)control).Attributes["Required"] = "false";
            }
            else if (control is RadioButtonList)
            {
                ((RadioButtonList)control).ClearSelection();
                ((RadioButtonList)control).Items.Clear();

            }
            else if (control is CheckBoxList)
                ((CheckBoxList)control).ClearSelection();
            else if (control is Calendar)
                ((Calendar)control).SelectedDates.Clear();
            else if (control is RadioButton)
                ((RadioButton)control).Checked = false;
            else if (control is CheckBox)
                ((CheckBox)control).Checked = false;
            else if (control is DropDownList)
                ((DropDownList)control).ClearSelection();
            else if (control.HasControls())
                //Esta linea detécta un Control que contenga otros Controles
                //Así ningún control se quedará sin ser limpiado.
                CleanControl(control.Controls);

        }
    }
    protected void Visto_Click(object sender, EventArgs e)
    {
        Controles_A_Objeto();

        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Buen_Servicio.Inserta_Notificacion(Obj_Entidad_Buen_Servicio);
        if (Guardar_Datos != -1)
        {
            Nombre_de_Imagen.Text = "";
            Ruta_de_Imagen.Text = "";
            Descripcion_de_Imagen.Text = "";
            Id_de_Notificado.Text = "";
        }
        else
        {


        }


    }
    protected void Controles_A_Objeto() {

        Obj_Entidad_Buen_Servicio.Usuario = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Buen_Servicio.Id_Notificacion = Convert.ToInt64(Id_de_Notificado.Text.Trim());
        Obj_Entidad_Buen_Servicio.Imagen_Vista = "XXX BYTES";
        Obj_Entidad_Buen_Servicio.Nombre_Imagen_Vista = Nombre_de_Imagen.Text;
        Obj_Entidad_Buen_Servicio.Link_Direccionamiento = Ruta_de_Imagen.Text;
        Obj_Entidad_Buen_Servicio.Descripcion_Imagen_Vista = Descripcion_de_Imagen.Text;
        Obj_Entidad_Buen_Servicio.Aliado_Usuario = Session["Aliado_Usuario"].ToString();
        Obj_Entidad_Buen_Servicio.Perfil_Usuario = Session["Rol_Usuario"].ToString();
        Obj_Entidad_Buen_Servicio.Operacion_Usuario = Session["Nombre_Linea_Usuario"].ToString();
    }
}
