using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Depuracion_Traslados : System.Web.UI.Page
{
    public E_Notas_Traslados Obj_Entidad_Notas_Traslados = new E_Notas_Traslados();
    public N_Notas_Traslados Obj_Neg_Notas_Traslados = new N_Notas_Traslados();
    public E_Traslados Obj_Entidad_Traslados = new E_Traslados();
    public N_Traslados Obj_Neg_Traslados = new N_Traslados();
    protected void Page_Load(object sender, EventArgs e)
    {
        string fullname1 = Request.QueryString["id"];
        Id_Traslado.Text = fullname1;
        Carga_Notas_Caso();
    }
    protected void Carga_Notas_Caso()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Notas_Traslados.Id_Traslado = Convert.ToInt64(Id_Traslado.Text);
        dt = Obj_Neg_Notas_Traslados.Consultar_Traslados_Id(Obj_Entidad_Notas_Traslados.Id_Traslado);

        if (dt.Tables[0].Rows.Count > 0)
        {
            GVNOTAS.DataSource = dt.Tables[0];
            GVNOTAS.DataBind();
        }
        else
        {
            GVNOTAS.DataSource = null;
            GVNOTAS.DataBind();
        }
    }
    protected void Gestionar_Click(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Traslados.Id_Traslado = Convert.ToDouble(Id_Traslado.Text);
        dt = Obj_Neg_Traslados.Consulta_Usuario_Back(Obj_Entidad_Traslados.Id_Traslado);
        if (dt.Tables[0].Rows.Count > 0)
        {
            var USUARIORR = dt.Tables[0].Rows[0]["USUARIO_BACKOFFICE"].ToString();
            var USUARIO_LOGUEADO = Session["Usuario_Logueado"].ToString();
            if (USUARIORR == "" || USUARIORR == USUARIO_LOGUEADO)
            {
                //Estado_Casos(); ---
                //Nombre_Linea(); **
                Actualiza_Usuario_Back(); 
                //Carga_Informacion_Ingreso();
                //Carga_Informacion_Cliente();
                //Carga_Datos_Adicionales_Cliente();
                //Carga_Datos_Marcacion();
                //Gestionar.Enabled = false;
                //Button3.Enabled = true;
            }
            else
            {
                Response.Redirect("Gestion_Casos_Celula.aspx");
            }
        }
        else
        {

        }
    }
    protected void Actualiza_Usuario_Back()
    {
        var Guardar_Datos = -1;
        Obj_Entidad_Traslados.Id_Traslado = Convert.ToDouble(Id_Traslado.Text);
        Obj_Entidad_Traslados.Usuario_Backoffice = Session["Usuario_Logueado"].ToString();
        Guardar_Datos = Obj_Neg_Traslados.Actualiza_Usuario_Back(Obj_Entidad_Traslados.Id_Traslado, Obj_Entidad_Traslados);
        if (Guardar_Datos != -1)
        {

        }
        else
        {

        }
    }

}