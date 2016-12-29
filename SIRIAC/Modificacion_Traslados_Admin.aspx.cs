using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Modificacion_Traslados_Admin : System.Web.UI.Page
{
    public N_Usuarios Obj_Neg_Usuarios = new N_Usuarios();
    public E_Traslados Obj_Entidad_Traslados = new E_Traslados();
    public N_Traslados Obj_Neg_Traslados = new N_Traslados();
    public E_Notas_Traslados Obj_Entidad_Notas_Traslados = new E_Notas_Traslados();
    public N_Notas_Traslados Obj_Neg_Notas_Traslados = new N_Notas_Traslados();

    protected void Page_Load(object sender, EventArgs e)
    {
        string fullname1 = Request.QueryString["id"];
        Id_Ingreso.Text = fullname1;
        Cargar_Informacion_Caso();
    }
    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
    //    //CheckBox3.Checked = false;
    //    Usuarios_Back.Enabled = true;
    //    Estado_Caso.Enabled = false;


        Carga_Usuarios_Celula_Traslados();
    //    //Estado_Casos();
    //    Cargar_Informacion_Caso();

    }
    //protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
    //{
    //    CheckBox2.Checked = false;

    //    Usuarios_Back.Enabled = false;
    //    Estado_Caso.Enabled = true;

    //    Carga_Usuarios_Celula_Traslados();
    //    //Estado_Casos();
    //    Cargar_Informacion_Caso();

    //}
    protected void Actualizar_Click(object sender, EventArgs e)
    {
        Actualizar_Caso_Back();
        Registrar_Nota();
        
    }
    protected void Cargar_Informacion_Caso()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Traslados.Id_Traslado = Convert.ToDouble(Id_Ingreso.Text);
        dt = Obj_Neg_Traslados.Consulta_Admin_Casos_Traslados_Id(Obj_Entidad_Traslados.Id_Traslado);
        if (dt.Tables[0].Rows.Count > 0)
        {
            Cuenta_Cliente.Text = dt.Tables[0].Rows[0]["CUENTA_CLIENTE"].ToString();
            Ticket.Text = dt.Tables[0].Rows[0]["ESTADO_CASO"].ToString();
            Marcacion.Text = dt.Tables[0].Rows[0]["FECHA_APERTURA"].ToString();
            Fecha_Apertura.Text = dt.Tables[0].Rows[0]["HORA_APERTURA"].ToString();
            Aliado_Apertura.Text = dt.Tables[0].Rows[0]["ALIADO_APERTURA"].ToString();
            Linea_de_Ingreso.Text = dt.Tables[0].Rows[0]["NOMBRE_LINEA_INGRESO"].ToString();
            Razon.Text= dt.Tables[0].Rows[0]["RAZON"].ToString();
            Subrazon.Text= dt.Tables[0].Rows[0]["SUBRAZON"].ToString();
        }
        else
        {
            
        }
    }
    protected void Carga_Usuarios_Celula_Traslados()
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Usuarios.Consulta_Nombres_Usuarios_Celula();
        if (dt.Tables[0].Rows.Count > 0)
        {
            Usuarios_Back.DataSource = dt;
            Usuarios_Back.DataTextField = "NOMBRE";
            Usuarios_Back.DataValueField = "USUARIO_RR";
            Usuarios_Back.DataBind();
        }
    }
    //private void Estado_Casos()
    //{
    //    DataSet dt = new DataSet();

    //    //dt = Obj_Neg_Estado_Casos.Estado_Casos();
    //    //Pendiente
    //    if (dt.Tables[0].Rows.Count > 0)
    //    {
    //        Estado_Caso.Items.Clear();
    //        Estado_Caso.DataSource = dt;
    //        Estado_Caso.DataTextField = "DESCRIPCION";
    //        Estado_Caso.DataValueField = "ID_ESTADO";
    //        Estado_Caso.DataBind();
    //    }
    //}
    //protected void Actualizar_Caso_Celula()
    //{

    //    var Guardar_Datos = -1;
    //    //Obj_Entidad_Ingresos.Id_Ingreso = Convert.ToDouble(Id_Ingreso.Text);
    //    //Obj_Entidad_Ingresos.Nombre_Linea_Escalado = Celulas.SelectedValue;
    //    //Obj_Entidad_Ingresos.Usuario_Ultima_Actualizacion = Session["Usuario_Logueado"].ToString();
    //    //Guardar_Datos = Obj_Neg_Ingresos.Actualiza_Ingreso_Celula(Obj_Entidad_Ingresos.Id_Ingreso, Obj_Entidad_Ingresos);
    //    if (Guardar_Datos != -1)
    //    {

    //    }
    //    else { }
    //}
    protected void Actualizar_Caso_Back()
    {
        var Guardar_Datos = -1;
        Obj_Entidad_Traslados.Id_Traslado = Convert.ToDouble(Id_Ingreso.Text);
        Obj_Entidad_Traslados.Usuario_Backoffice = Usuarios_Back.SelectedValue;
        Obj_Entidad_Traslados.Usuario_Ultima_Actualizacion = Session["Usuario_Logueado"].ToString();
        Guardar_Datos = Obj_Neg_Traslados.Actualiza_Ingreso_Back_Traslados(Obj_Entidad_Traslados.Id_Traslado, Obj_Entidad_Traslados);
        if (Guardar_Datos != -1)
        {
            //string script1 = "mensaje1();";
            //ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script1, true);
        }
        else { }
    }
    //protected void Actualizar_Caso_Estado()
    //{
    //    var Guardar_Datos = -1;
    //    Obj_Entidad_Traslados.Id_Traslado = Convert.ToDouble(Id_Ingreso.Text);
    //    //Obj_Entidad_Traslados.Estado = Estado_Caso.Text;
    //    //if (Convert.ToString(Estado_Caso.SelectedValue) == "1") { Obj_Entidad_Ingresos.Usuario_Cierre = ""; }
    //    //else if (Convert.ToString(Estado_Caso.SelectedValue) == "2") { Obj_Entidad_Ingresos.Usuario_Cierre = Session["Usuario_Logueado"].ToString(); }
    //    //else if (Convert.ToString(Estado_Caso.SelectedValue) == "3") { Obj_Entidad_Ingresos.Usuario_Cierre = ""; }


    //    //Obj_Entidad_Ingresos.Usuario_Ultima_Actualizacion = Session["Usuario_Logueado"].ToString();
    //    //Guardar_Datos = Obj_Neg_Ingresos.Actualiza_Ingreso_Estado(Obj_Entidad_Ingresos.Id_Ingreso, Obj_Entidad_Ingresos);
    //    if (Guardar_Datos != -1)
    //    {
    //        string script1 = "mensaje1();";
    //        ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script1, true);
    //    }
    //    else { }
    //}
    protected void Registrar_Nota()
    {
        Obj_Entidad_Notas_Traslados.Cuenta_Cliente = Convert.ToInt64(Cuenta_Cliente.Text);
        Obj_Entidad_Notas_Traslados.Id_Traslado = Convert.ToInt64(Id_Ingreso.Text);
        Obj_Entidad_Notas_Traslados.Usuario = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Notas_Traslados.Nombre_Linea_Nota = Session["Nombre_Linea_Usuario"].ToString();
        Obj_Entidad_Notas_Traslados.Nota = Notas.Text.ToUpper();
        Obj_Entidad_Notas_Traslados.Razon = Razon.Text;
        Obj_Entidad_Notas_Traslados.Subrazon = Subrazon.Text;
        Obj_Entidad_Notas_Traslados.Estado = Ticket.Text;

        var Guardar_Notas_Casos = -1;
        Guardar_Notas_Casos = Obj_Neg_Notas_Traslados.Inserta_Nota_Traslados("INSERTAR", Obj_Entidad_Notas_Traslados);
        if (Guardar_Notas_Casos != -1)
        {
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script1, true);
            Limpiar_Controles();
            Response.Redirect("Administracion_de_Casos_Traslados.aspx");
        }
        else { }
    }

    protected void Limpiar_Controles()
    {
        Cuenta_Cliente.Text = string.Empty;
        Ticket.Text = string.Empty;
        Marcacion.Text = string.Empty;
        Fecha_Apertura.Text = string.Empty;
        Aliado_Apertura.Text = string.Empty;
        Linea_de_Ingreso.Text = string.Empty;
        Razon.Text = string.Empty;
        Subrazon.Text = string.Empty;
    }


}