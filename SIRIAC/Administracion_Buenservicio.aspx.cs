using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using Entidades;
using Negocios;
using System.IO;

public partial class Administracion_Buenservicio : System.Web.UI.Page
{
    public E_Buen_Servicio Obj_Entidad_Buen_Servicio = new E_Buen_Servicio();
    public N_Buen_Servicio Obj_Neg_Buen_Servicio = new N_Buen_Servicio();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Acceso_19"].ToString() == "1") { } else { Response.Redirect("Bienvenida_Administrador.aspx?Acceso= " + Session["ACCESO_19"].ToString() + " --DENEGADO Pieza Buen Servicio"); }
        Consultar_Imagenes_Guardadas();
    }
    protected void Cargar_Click(object sender, EventArgs e)
    {
        Boolean Correcto = false;
        if (Cargar_Archivo.HasFile) {
            String Extencion_Archivo = System.IO.Path.GetExtension(Cargar_Archivo.FileName).ToLower();
            String[] Extenciones_Permitidas = { ".png", ".jpg", ".jpeg" };
            for (int i = 0; i < Extenciones_Permitidas.Length; i++) 
            {
                if (Extencion_Archivo == Extenciones_Permitidas[i]) 
                {
                    Correcto = true;
                
                }
            }
            if (Correcto == true) 
            {
                ViewState["foto"] = System.IO.Path.GetFileName(Cargar_Archivo.FileName);
                Cargar_Archivo.SaveAs(MapPath("Imagenes/Imagenes_BS/") + ViewState["foto"]);
                Imagen_Cargada.ImageUrl = "Imagenes/Imagenes_BS/" + ViewState["foto"];
                Imagen_Cargada.DataBind();
            }
        }
        else { }
    }
    protected Byte[] Convertir_Imagen_A_Byte(System.Drawing.Image Foto) 
    {
        if (!(Foto == null)) 
       {
           MemoryStream Codigo = new MemoryStream();
           Foto.Save(Codigo, System.Drawing.Imaging.ImageFormat.Jpeg);
           return Codigo.GetBuffer();
        }
        else {
            return null;
        }
    }
    protected System.Drawing.Image Convertir_Byte_A_Imagen(Byte [] Foto) {
        if (!(Foto == null))
        {
            MemoryStream Codigo = new MemoryStream();
            System.Drawing.Image Resultado = System.Drawing.Image.FromStream(Codigo);
            return Resultado;
        }
        else {
            return null;
        }
    }
    protected void Controles_A_Objeto() 
    {
        System.Drawing.Image Foto = System.Drawing.Image.FromFile(Server.MapPath("~/Imagenes/Imagenes_BS/") + ViewState["foto"]);
        Obj_Entidad_Buen_Servicio.Usuario_Publicacion = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Buen_Servicio.Descripcion = Descripcion.Text;
        Obj_Entidad_Buen_Servicio.Nombre_Imagen= ViewState["foto"].ToString();
        Obj_Entidad_Buen_Servicio.Aliado_Destino = Aliado_Destino.Text;
        Obj_Entidad_Buen_Servicio.Link_Direccionamiento =  Link.Text.Trim();
        Obj_Entidad_Buen_Servicio.Perfil_Destino = Perfil_Destino.Text;
        Obj_Entidad_Buen_Servicio.Operacion_Destino = Operacion_Destino.Text;
        Obj_Entidad_Buen_Servicio.Estado_Publicacion = Estado_Notificacion.Text;
        Obj_Entidad_Buen_Servicio.Imagen_Notificacion = Convertir_Imagen_A_Byte(Foto);
    }
    protected void Guardar_Click(object sender, EventArgs e)
    {
        Guardar.Enabled = false;
        Controles_A_Objeto();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Buen_Servicio.abcBuenServicio("INSERTAR", Obj_Entidad_Buen_Servicio);
        if (Guardar_Datos != -1)
        {
           
                
                Guardar.Enabled = true;
                Limpiar_Controles();
                string script1 = "mensaje1();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script1, true);
           
        }
        else
        {
            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje2", script2, true);
            Guardar.Enabled = true;
        }
       
    }
    protected void Consultar_Imagenes_Guardadas() 
    {

        DataSet dt = new DataSet();
        dt = Obj_Neg_Buen_Servicio.Consulta_Imagen_General_Buen_Servicio();

        if (dt.Tables[0].Rows.Count > 0)
        {
            PUBLICACIONES.Visible = true;
            PUBLICACIONES.DataSource = dt.Tables[0];
            PUBLICACIONES.DataBind();
        }
        else
        {
            PUBLICACIONES.Visible = false;
            PUBLICACIONES.DataSource = null;
            PUBLICACIONES.DataBind();
        }
    }
    protected void Limpiar_Controles() 
    {
        Imagen_Cargada.Attributes.Clear();
        Cargar_Archivo.Attributes.Clear();
        Imagen_Cargada.ImageUrl = "~/Imagenes/Imagenes_BS/Sin_Foto.png";
        Descripcion.Text = "";
       

       
    }
    protected void PUBLICACIONES_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        PUBLICACIONES.PageIndex = e.NewPageIndex;
        Consultar_Imagenes_Guardadas();
    }
    protected void Refrescar_Click(object sender, EventArgs e)
    {

        Consultar_Imagenes_Guardadas();
    }
}