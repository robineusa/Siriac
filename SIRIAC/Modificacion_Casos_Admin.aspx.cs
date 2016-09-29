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


public partial class Modificacion_Casos_Admin : System.Web.UI.Page
{
    public E_Ingreso Obj_Entidad_Ingresos = new E_Ingreso();
    public N_Ingresos Obj_Neg_Ingresos = new N_Ingresos();
    public E_Usuarios Obj_Entidad_Usuarios = new E_Usuarios();
    public N_Usuarios Obj_Neg_Usuarios = new N_Usuarios();
    public E_Nombre_Linea Obj_Entidad_Nombre_Linea = new E_Nombre_Linea();
    public N_Nombre_Linea Obj_Neg_Nombre_Linea = new N_Nombre_Linea();
    public E_Estado_Casos Obj_Entidad_Estado_Casos = new E_Estado_Casos();
    public N_Estado_Casos Obj_Neg_Estado_Casos = new N_Estado_Casos();
    public E_Notas_Casos Obj_Entidad_Notas_Casos = new E_Notas_Casos();
    public N_Notas_Casos Obj_Neg_Notas_Casos = new N_Notas_Casos();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        string fullname1 = Request.QueryString["id"];
        Id_Ingreso.Text = fullname1;
       
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox2.Checked = false;
        CheckBox3.Checked = false;

        Celulas.Enabled = true;
        Usuarios_Back.Enabled = false;
        Estado_Caso.Enabled = false;

        
        Carga_Usuarios_Celula();
        Carga_Nombre__Linea_Celula();
        Estado_Casos();
        Cargar_Informacion_Caso();
        
    }
    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox1.Checked = false;
        CheckBox3.Checked = false;

        Celulas.Enabled = false;
        Usuarios_Back.Enabled = true;
        Estado_Caso.Enabled = false;

      
        Carga_Usuarios_Celula();
        Carga_Nombre__Linea_Celula();
        Estado_Casos();
        Cargar_Informacion_Caso();
       
    }
    protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox1.Checked = false;
        CheckBox2.Checked = false;

        Celulas.Enabled = false;
        Usuarios_Back.Enabled = false;
        Estado_Caso.Enabled = true;

       
        Carga_Usuarios_Celula();
        Carga_Nombre__Linea_Celula();
        Estado_Casos();
        Cargar_Informacion_Caso();
       
    }
    protected void Actualizar_Click(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true) { Actualizar_Caso_Celula(); Registrar_Nota(); }
        else if (CheckBox2.Checked == true) { Actualizar_Caso_Back(); Registrar_Nota(); }
        else if (CheckBox3.Checked == true) { Actualizar_Caso_Estado(); Registrar_Nota(); }
        else {
            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje2", script2, true);
        }
    }
    protected void Cargar_Informacion_Caso()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Ingresos.Id_Ingreso = Convert.ToDouble(Id_Ingreso.Text);
        dt = Obj_Neg_Ingresos.Consulta_Admin_Casos_Id(Obj_Entidad_Ingresos.Id_Ingreso);
        if (dt.Tables[0].Rows.Count > 0)
        {

            Cuenta_Cliente.Text = dt.Tables[0].Rows[0]["CUENTA_CLIENTE"].ToString();
            Ticket.Text = dt.Tables[0].Rows[0]["TICKET"].ToString();
            Marcacion.Text = dt.Tables[0].Rows[0]["MARCACION"].ToString();
            Fecha_Apertura.Text = dt.Tables[0].Rows[0]["FECHA_APERTURA"].ToString();
            Aliado_Apertura.Text = dt.Tables[0].Rows[0]["ALIADO_APERTURA"].ToString();
            Linea_de_Ingreso.Text = dt.Tables[0].Rows[0]["NOMBRE_LINEA_INGRESO"].ToString();
            
        }
        else
        {


        }
    }
    protected void Carga_Usuarios_Celula() { 
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
    protected void Carga_Nombre__Linea_Celula()
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Nombre_Linea.Selecciona_Nombre_Linea_Celula();

        if (dt.Tables[0].Rows.Count > 0)
        {
            Celulas.Items.Clear();
            Celulas.DataSource = dt;
            Celulas.DataTextField = "NOMBRE_LINEA";
            Celulas.DataValueField = "NOMBRE_LINEA";
            Celulas.DataBind();

        }
    }
    private void Estado_Casos()
    {
        DataSet dt = new DataSet();

        dt = Obj_Neg_Estado_Casos.Estado_Casos();



        if (dt.Tables[0].Rows.Count > 0)
        {
            Estado_Caso.Items.Clear();
            Estado_Caso.DataSource = dt;
            Estado_Caso.DataTextField = "DESCRIPCION";
            Estado_Caso.DataValueField = "ID_ESTADO";
            Estado_Caso.DataBind();
        }
    }
    protected void Actualizar_Caso_Celula() {
    
            var Guardar_Datos = -1;
            Obj_Entidad_Ingresos.Id_Ingreso = Convert.ToDouble(Id_Ingreso.Text);
            Obj_Entidad_Ingresos.Nombre_Linea_Escalado = Celulas.SelectedValue;
            Obj_Entidad_Ingresos.Usuario_Ultima_Actualizacion = Session["Usuario_Logueado"].ToString();
        Guardar_Datos = Obj_Neg_Ingresos.Actualiza_Ingreso_Celula(Obj_Entidad_Ingresos.Id_Ingreso, Obj_Entidad_Ingresos);
            if (Guardar_Datos != -1)
            {
                
            }
            else { }
    }
    protected void Actualizar_Caso_Back() {
        var Guardar_Datos = -1;
        Obj_Entidad_Ingresos.Usuario_Backoffice = Usuarios_Back.SelectedValue;
        Obj_Entidad_Ingresos.Usuario_Backoffice = Usuarios_Back.SelectedValue;
        Obj_Entidad_Ingresos.Usuario_Ultima_Actualizacion = Session["Usuario_Logueado"].ToString();
        Guardar_Datos = Obj_Neg_Ingresos.Actualiza_Ingreso_Back(Obj_Entidad_Ingresos.Id_Ingreso, Obj_Entidad_Ingresos);
        if (Guardar_Datos != -1)
        {
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script1, true);
        }
        else { }
    }
    protected void Actualizar_Caso_Estado() {
        var Guardar_Datos = -1;
        Obj_Entidad_Ingresos.Id_Ingreso = Convert.ToInt64(Id_Ingreso.Text);
        Obj_Entidad_Ingresos.Id_Estado = Convert.ToInt16(Estado_Caso.Text);
        if (Convert.ToString(Estado_Caso.SelectedValue) == "1") { Obj_Entidad_Ingresos.Usuario_Cierre = ""; }
        else if (Convert.ToString(Estado_Caso.SelectedValue) == "2") { Obj_Entidad_Ingresos.Usuario_Cierre = Session["Usuario_Logueado"].ToString(); }
        else if (Convert.ToString(Estado_Caso.SelectedValue) == "3") { Obj_Entidad_Ingresos.Usuario_Cierre = ""; }
            

        Obj_Entidad_Ingresos.Usuario_Ultima_Actualizacion = Session["Usuario_Logueado"].ToString();
        Guardar_Datos = Obj_Neg_Ingresos.Actualiza_Ingreso_Estado(Obj_Entidad_Ingresos.Id_Ingreso, Obj_Entidad_Ingresos);
        if (Guardar_Datos != -1)
        {
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script1, true);
        }
        else { }
    }
    protected void Registrar_Nota() {

        //TABLA NOTAS DE LOS CASOS
        var Llamada_Cliente_Inicial = "NO";
        Obj_Entidad_Notas_Casos.Cuenta_Cliente = Convert.ToInt64(Cuenta_Cliente.Text);
        Obj_Entidad_Notas_Casos.Id_Ingreso = Convert.ToInt64(Id_Ingreso.Text);
        Obj_Entidad_Notas_Casos.Ticket = Convert.ToInt64(Ticket.Text);
        Obj_Entidad_Notas_Casos.Usuario = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Notas_Casos.Nombre_Linea_Nota = Session["Nombre_Linea_Usuario"].ToString();
        Obj_Entidad_Notas_Casos.Llamada_Cliente = Llamada_Cliente_Inicial;
        Obj_Entidad_Notas_Casos.Nota = Notas.Text.ToUpper();
        Obj_Entidad_Notas_Casos.Id_Estado = Convert.ToInt16(Estado_Caso.SelectedValue);
        
        var Guardar_Notas_Casos = -1;
        Guardar_Notas_Casos = Obj_Neg_Notas_Casos.Inserta_Nota_Inicial("INSERTAR", Obj_Entidad_Notas_Casos);
        if (Guardar_Notas_Casos != -1)
        {
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script1, true);
        }
        else { }
    }
}