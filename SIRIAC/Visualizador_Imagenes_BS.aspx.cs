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


public partial class Visualizador_Imagenes_BS : System.Web.UI.Page
{

    public E_Buen_Servicio Obj_Entidad_Buen_Servicio = new E_Buen_Servicio();
    public N_Buen_Servicio Obj_Neg_Buen_Servicio = new N_Buen_Servicio();

    protected void Page_Load(object sender, EventArgs e)
    {
        string fullname1 = Request.QueryString["id"];
        Consultar_Imagenes_Publicadas();
        Nombre_Usuario_T.Text = Session["Nombre_Usuario"].ToString();
    }
    protected void Consultar_Imagenes_Publicadas() {
        
        string Id_Imagen = Request.QueryString["id"];

        DataSet dt = new DataSet();
        Obj_Entidad_Buen_Servicio.Id_Notificacion = Convert.ToInt16(Id_Imagen); 
        dt = Obj_Neg_Buen_Servicio.Consulta_Imagen_Buen_Servicio(Convert.ToInt16(Obj_Entidad_Buen_Servicio.Id_Notificacion));

        if (dt.Tables[0].Rows.Count > 0)
        {
           var Ruta=dt.Tables[0].Rows[0]["LINK_DIRECCIONAMIENTO"].ToString();
           Imagen_Seleccionada.ImageUrl = "~/Imagenes/Imagenes_BS/" + dt.Tables[0].Rows[0]["NOMBRE_IMAGEN"].ToString();
           URL.NavigateUrl=Ruta;
            Ruta_Imagen.Text = Ruta;
            Nombre_Imagen.Text = "Imagenes/Imagenes_BS/" + dt.Tables[0].Rows[0]["NOMBRE_IMAGEN"].ToString();
            Id_Notificado.Text = dt.Tables[0].Rows[0]["ID_NOTIFICADO"].ToString();
            Descripcion_Imagen.Text = dt.Tables[0].Rows[0]["DESCRIPCION"].ToString();
        }
        else
        {
            Imagen_Seleccionada.ImageUrl = "~/Imagenes/Imagenes_BS/Sin_Foto.png";
        }
    }
}