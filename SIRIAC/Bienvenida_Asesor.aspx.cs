using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bienvenida_Asesor : System.Web.UI.Page
{
    public static E_Buen_Servicio Obj_Entidad_Buen_Servicio = new E_Buen_Servicio();
    public static N_Buen_Servicio Obj_Neg_Buen_Servicio = new N_Buen_Servicio();

    public static string sesion;
    public static string ID_NOTIFICACION;
    public static string IMAGEN_VISTA;
    public static string NOMBRE_IMAGEN_VISTA;
    public static string LINK;
    public static string DESCRIPCION;
    public static string ALIADO;
    public static string PERFIL;
    public static string NOMBRE_LINEA;


    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    
    
}