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

public partial class Actualizar_Casos : System.Web.UI.Page
{


    public E_Notas_Casos Obj_Entidad_Notas_Casos = new E_Notas_Casos();
    public N_Notas_Casos Obj_Neg_Notas_Casos = new N_Notas_Casos();
    public E_Ingreso Obj_Entidad_Ingresos = new E_Ingreso();
    public N_Ingresos Obj_Neg_Ingresos = new N_Ingresos();
    public E_Estado_Casos Obj_Entidad_Estado_Casos = new E_Estado_Casos();
    public N_Estado_Casos Obj_Neg_Estado_Casos = new N_Estado_Casos();
    public E_Nombre_Linea Obj_Entidad_Nombre_Linea = new E_Nombre_Linea();
    public N_Nombre_Linea Obj_Neg_Nombre_Linea = new N_Nombre_Linea();
    public E_Servicios Obj_Entidad_Servicios = new E_Servicios();
    public N_Servicios Obj_Neg_Servicios = new N_Servicios();
    public E_Marcaciones Obj_Entidad_Marcaciones = new E_Marcaciones();
    public N_Marcaciones Obj_Neg_Marcaciones = new N_Marcaciones();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Rol_Usuario"].ToString() == "3") { }
        else { Response.Redirect("Inicio_de_Sesion.aspx?id=" + Session["Rol_Usuario"].ToString() + ""); }
        string fullname1 = Request.QueryString["id"];
        Id_Ingreso.Text = fullname1;
        Carga_Interacciones_Caso();
    }
    public void Carga_Interacciones_Caso()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Notas_Casos.Id_Ingreso = Convert.ToInt64(Id_Ingreso.Text);
        dt = Obj_Neg_Notas_Casos.Consultar_Notas_Id(Obj_Entidad_Notas_Casos.Id_Ingreso);
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
        Lista_Servicios();
        Estado_Casos();
        Nombre_Linea();
        Consultar_Caso();
        this.Caja_Consulta_TextChanged(sender, e);
        Lista_Marcaciones.SelectedIndex = 0;
        this.Lista_Marcaciones_SelectedIndexChanged(sender, e);
    }
    private void Consultar_Caso()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Notas_Casos.Id_Ingreso = Convert.ToInt64(Id_Ingreso.Text);
        dt = Obj_Neg_Notas_Casos.Consultar_Notas_Id(Obj_Entidad_Notas_Casos.Id_Ingreso);

        DataSet dt2 = new DataSet();
        Obj_Entidad_Ingresos.Id_Ingreso = Convert.ToDouble(Id_Ingreso.Text);
        dt2 = Obj_Neg_Ingresos.Consulta_Ingreso(Obj_Entidad_Ingresos.Id_Ingreso);

        DataSet dt3 = new DataSet();
        Obj_Entidad_Ingresos.Id_Ingreso = Convert.ToDouble(Id_Ingreso.Text);
        dt3 = Obj_Neg_Ingresos.Consulta_Ingreso_General(Obj_Entidad_Ingresos.Id_Ingreso);

        if (dt3.Tables[0].Rows.Count > 0)
        {
            var C_SEMAFORO = dt3.Tables[0].Rows[0]["SEMAFORO"].ToString();
            var C_TIEMPO_RESPUESTA = dt3.Tables[0].Rows[0]["TIEMPO_RESPUESTA"].ToString();
            var C_USUARIO_BACK = dt3.Tables[0].Rows[0]["USUARIO_BACKOFFICE"].ToString();
            var C_NOMBRE_LINEA_ESCALADO = dt3.Tables[0].Rows[0]["NOMBRE_LINEA_ESCALADO"].ToString();
            var C_ID_ESTADO = dt3.Tables[0].Rows[0]["ID_ESTADO"].ToString();


        }
        else { }

        if (dt.Tables[0].Rows.Count > 0)
        {

            Cuenta_Cliente.Text = dt.Tables[0].Rows[0]["CUENTA_CLIENTE"].ToString();
            Ticket.Text = dt.Tables[0].Rows[0]["TICKET"].ToString();
            Caja_Consulta.Text = dt2.Tables[0].Rows[0]["DESCRIPCION"].ToString();
            Servicios.Text = dt2.Tables[0].Rows[0]["ID_SERVICIO"].ToString();
            Estado_del_Caso.Text = dt2.Tables[0].Rows[0]["ID_ESTADO"].ToString();
            Nombre_de_Linea.Text = dt2.Tables[0].Rows[0]["NOMBRE_LINEA_ESCALADO"].ToString();


        }
        else
        {

        }
        if (dt2.Tables[0].Rows[0]["ID_ESTADO"].ToString() == "1")
        {
            Estado_del_Caso.Enabled = true;
            Nombre_de_Linea.Enabled = true;
            Caja_Consulta.Enabled = true;
            Gestionar.Enabled = false;
            Id_Ingreso.Enabled = false;
            Cuenta_Cliente.Enabled = false;
            
        }
        else if (dt2.Tables[0].Rows[0]["ID_ESTADO"].ToString() == "2")
        {
            Estado_del_Caso.Enabled = false;
            Nombre_de_Linea.Enabled = false;
            Caja_Consulta.Enabled = false;
            Guardar_Interaccion.Enabled = false;
            Gestionar.Enabled = false;
            Id_Ingreso.Enabled = false;
            Cuenta_Cliente.Enabled = false;
           
            Notas.Enabled = false;
            Llamada_Cliente.Enabled = false;
            Servicios.Enabled = false;
            string script4 = "mensaje4();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje4", script4, true);
           
        }
        else if (dt2.Tables[0].Rows[0]["ID_ESTADO"].ToString() == "3")
        {
            if (dt3.Tables[0].Rows[0]["USUARIO_BACKOFFICE"].ToString() == "")
            {
                Estado_del_Caso.Enabled = true;
                Nombre_de_Linea.Enabled = true;
                Caja_Consulta.Enabled = true;
                Gestionar.Enabled = false;
                Id_Ingreso.Enabled = false;
                Cuenta_Cliente.Enabled = false;
                
               }
            else
            {
                Estado_del_Caso.Enabled = false;
                Nombre_de_Linea.Enabled = false;
                Caja_Consulta.Enabled = false;
                Gestionar.Enabled = false;
                Id_Ingreso.Enabled = false;
                Cuenta_Cliente.Enabled = false;
                
            }
        }
    }
    private void Nombre_Linea()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Nombre_Linea.Nombre_Linea = Session["Nombre_Linea_Usuario"].ToString();
        dt = Obj_Neg_Nombre_Linea.Consulta_Nombre_Linea(Obj_Entidad_Nombre_Linea.Nombre_Linea);

        if (dt.Tables[0].Rows.Count > 0)
        {

            Nombre_de_Linea.DataSource = dt;
            Nombre_de_Linea.DataTextField = "NOMBRE_LINEA";
            Nombre_de_Linea.DataValueField = "NOMBRE_LINEA";
            Nombre_de_Linea.DataBind();
        }
    }
    private void Estado_Casos()
    {
        DataSet dt = new DataSet();

        dt = Obj_Neg_Estado_Casos.Estado_Casos();



        if (dt.Tables[0].Rows.Count > 0)
        {

            Estado_del_Caso.DataSource = dt;
            Estado_del_Caso.DataTextField = "DESCRIPCION";
            Estado_del_Caso.DataValueField = "ID_ESTADO";
            Estado_del_Caso.DataBind();
        }
    }
    private void Lista_Servicios()
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Servicios.Selecciona_Servicios();

        if (dt.Tables[0].Rows.Count > 0)
        {

            Servicios.DataSource = dt;
            Servicios.DataTextField = "DESCRIPCION";
            Servicios.DataValueField = "ID_SERVICIO";
            Servicios.DataBind();
        }
    }
    protected void Lista_Marcaciones_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();

        Obj_Entidad_Marcaciones.Id_Marcacion = Convert.ToInt16(Lista_Marcaciones.SelectedValue);

        dt = Obj_Neg_Marcaciones.Consulta_Marcaciones_Id(Obj_Entidad_Marcaciones.Id_Marcacion);



        if (dt.Tables[0].Rows.Count > 0)
        {
            Macroproceso_C.DataSource = dt;
            Macroproceso_C.DataTextField = "MACROPROCESO";
            Macroproceso_C.DataBind();
            //
            Proceso_C.DataSource = dt;
            Proceso_C.DataTextField = "TIPO_DE_NOVEDAD";
            Proceso_C.DataBind();
            //
            Subproceso_C.DataSource = dt;
            Subproceso_C.DataTextField = "TIPO_DE_SOLICITUD";
            Subproceso_C.DataBind();
            //
            Posible_Causa.Text = dt.Tables[0].Rows[0]["POSIBLE_CAUSA"].ToString();
            Que_Hacer.Text = dt.Tables[0].Rows[0]["QUE_HACER"].ToString();
            Codigos_de_Cierre.Text = dt.Tables[0].Rows[0]["CODIGOS_DE_CIERRE"].ToString();
            Usuario_a_Escalar.Text = dt.Tables[0].Rows[0]["AREA_USUARIO_ESCALAR"].ToString();
            //
            Marcacion.DataSource = dt;
            Marcacion.DataTextField = "MARCACION";
            Marcacion.DataBind();
            //
            Tipo_Atencion.DataSource = dt;
            Tipo_Atencion.DataTextField = "TIPO_ATENCION";
            Tipo_Atencion.DataBind();
            //
            Producto_Asociado.DataSource = dt;
            Producto_Asociado.DataTextField = "TIPOLOGIAS_SUJETAS_A_CUN";
            Producto_Asociado.DataBind();
            //
            Spc.DataSource = dt;
            Spc.DataTextField = "SPC";
            Spc.DataBind();
        }
    }
    protected void Caja_Consulta_TextChanged(object sender, EventArgs e)
    {

        DataSet dt = new DataSet();

        Obj_Entidad_Marcaciones.Descipcion = Caja_Consulta.Text;
        dt = Obj_Neg_Marcaciones.Consulta_Marcaciones(Obj_Entidad_Marcaciones.Descipcion);



        if (dt.Tables[0].Rows.Count > 0)
        {
            Lista_Marcaciones.DataSource = dt;
            Lista_Marcaciones.DataTextField = "DESCRIPCION";
            Lista_Marcaciones.DataValueField = "ID";
            Lista_Marcaciones.DataBind();

        }
    }

    protected void Guardar_Interaccion_Click(object sender, EventArgs e)
    {
        Controles_a_Objetos();
        var Marcacion_actual = Marcacion.Text;

        if (Marcacion_actual == "")
        {
            string script3 = "mensaje3();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje3", script3, true);
        }
        else
        {
            if (Convert.ToString(Estado_del_Caso.SelectedValue) == "1") { Obj_Entidad_Ingresos.Usuario_Cierre = ""; }
            else if (Convert.ToString(Estado_del_Caso.SelectedValue) == "2") { Obj_Entidad_Ingresos.Usuario_Cierre = Session["Usuario_Logueado"].ToString(); }
            else if (Convert.ToString(Estado_del_Caso.SelectedValue) == "3") { Obj_Entidad_Ingresos.Usuario_Cierre = ""; }

            var Actualizar_Caso_Ingreso = -1;
            Obj_Entidad_Ingresos.Id_Ingreso = Convert.ToDouble(Id_Ingreso.Text);
            Actualizar_Caso_Ingreso = Obj_Neg_Ingresos.Actualiza_Ingreso_Front(Obj_Entidad_Ingresos.Id_Ingreso, Obj_Entidad_Ingresos);
            if (Actualizar_Caso_Ingreso != -1)
            {
                var Guardar_Notas_Casos = -1;
                Guardar_Notas_Casos = Obj_Neg_Notas_Casos.Inserta_Nota_Inicial("INSERTAR", Obj_Entidad_Notas_Casos);
                if (Guardar_Notas_Casos != -1)
                {
                    string script1 = "mensaje1();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script1, true);
                    Limpiar_Controles();

                }
                else
                {
                    string script2 = "mensaje2();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje2", script2, true);

                }


            }
            else
            {

            }
        }



    }
    protected void Estado_del_Caso_SelectedIndexChanged(object sender, EventArgs e)
    {
        var ESTADO_NUM_CASO = Estado_del_Caso.SelectedValue;
        if (ESTADO_NUM_CASO == "1")
        {
            Nombre_Linea();
            Nombre_de_Linea.DataBind();
            Nombre_de_Linea.Enabled = true;
        }
        else if (ESTADO_NUM_CASO == "2")
        {
            Nombre_de_Linea.Items.Clear();
            Nombre_de_Linea.DataBind();
            Nombre_de_Linea.Enabled = false;
        }
        else if (ESTADO_NUM_CASO == "3")
        {
            Nombre_de_Linea.Items.Clear();
            Nombre_de_Linea.DataBind();
            Nombre_de_Linea.Enabled = false;
        }
    }
    protected void Controles_a_Objetos()
    {
        Obj_Entidad_Notas_Casos.Id_Ingreso = Convert.ToInt64(Id_Ingreso.Text);
        Obj_Entidad_Notas_Casos.Cuenta_Cliente = Convert.ToInt64(Cuenta_Cliente.Text);
        Obj_Entidad_Notas_Casos.Ticket = Convert.ToInt64(Ticket.Text);
        Obj_Entidad_Notas_Casos.Usuario = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Notas_Casos.Nombre_Linea_Nota = Session["Nombre_Linea_Usuario"].ToString();
        Obj_Entidad_Notas_Casos.Llamada_Cliente = Llamada_Cliente.Text;
        Obj_Entidad_Notas_Casos.Nota = Notas.Text.ToUpper();
        Obj_Entidad_Notas_Casos.Id_Estado = Convert.ToInt16(Estado_del_Caso.SelectedValue);

        DataSet dt = new DataSet();
        Obj_Entidad_Ingresos.Id_Ingreso = Convert.ToDouble(Id_Ingreso.Text);
        dt = Obj_Neg_Ingresos.Consulta_Ingreso_General(Obj_Entidad_Ingresos.Id_Ingreso);

        var C_SEMAFORO = string.Empty;
        var C_TIEMPO_RESPUESTA = string.Empty;
        var C_USUARIO_BACK = string.Empty;

        C_SEMAFORO = dt.Tables[0].Rows[0]["SEMAFORO"].ToString();
        C_TIEMPO_RESPUESTA = dt.Tables[0].Rows[0]["TIEMPO_RESPUESTA"].ToString();
        C_USUARIO_BACK = dt.Tables[0].Rows[0]["USUARIO_BACKOFFICE"].ToString();


        Obj_Entidad_Ingresos.Ticket = Convert.ToDouble(Ticket.Text);
        Obj_Entidad_Ingresos.Semaforo = C_SEMAFORO;
        Obj_Entidad_Ingresos.Tiempo_Respuesta = Convert.ToDouble(C_TIEMPO_RESPUESTA);
        Obj_Entidad_Ingresos.Usuario_Backoffice = C_USUARIO_BACK;
        Obj_Entidad_Ingresos.Nombre_Linea_Escalado = Nombre_de_Linea.SelectedValue;
        Obj_Entidad_Ingresos.Id_Estado = Convert.ToInt16(Estado_del_Caso.SelectedValue);
        Obj_Entidad_Ingresos.Macroproceso = Macroproceso_C.Text;
        Obj_Entidad_Ingresos.Proceso = Proceso_C.Text;
        Obj_Entidad_Ingresos.Subproceso = Subproceso_C.Text;
        Obj_Entidad_Ingresos.Marcacion = Marcacion.Text;
        Obj_Entidad_Ingresos.Usuario_Ultima_Actualizacion = Session["Usuario_Logueado"].ToString();
    }
    protected void Limpiar_Controles()
    {
        Id_Ingreso.Text = string.Empty;
        Cuenta_Cliente.Text = string.Empty;
        Ticket.Text = string.Empty;
        Caja_Consulta.Text = string.Empty;
        Lista_Marcaciones.Items.Clear();
        Servicios.Items.Clear();
        Macroproceso_C.Items.Clear();
        Proceso_C.Items.Clear();
        Subproceso_C.Items.Clear();
        Posible_Causa.Text = string.Empty;
        Que_Hacer.Text = string.Empty;
        Codigos_de_Cierre.Text = string.Empty;
        Usuario_a_Escalar.Text = string.Empty;
        Marcacion.Items.Clear();
        Tipo_Atencion.Items.Clear();
        Producto_Asociado.Items.Clear();
        Spc.Items.Clear();
        Notas.Text = string.Empty;
        Estado_del_Caso.Items.Clear();
        Nombre_de_Linea.Items.Clear();
        Llamada_Cliente.ClearSelection();
    }

}