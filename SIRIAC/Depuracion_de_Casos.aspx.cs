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

public partial class Depuracion_de_Casos : System.Web.UI.Page
{
    public E_Notas_Casos Obj_Entidad_Notas = new E_Notas_Casos();
    public N_Notas_Casos Obj_Neg_Notas = new N_Notas_Casos();
    public E_Ingreso Obj_Entidad_Ingresos = new E_Ingreso();
    public N_Ingresos Obj_Neg_Ingresos = new N_Ingresos();
    public E_Clientes Obj_Entidad_Clientes = new E_Clientes();
    public N_Clientes Obj_Neg_Clientes = new N_Clientes();
    public E_Datos_Clientes Obj_Entidad_Datos_Cliente = new E_Datos_Clientes();
    public N_Datos_Cliente Obj_Neg_Datos_Clientes = new N_Datos_Cliente();
    public E_Estado_Casos Obj_Entidad_Estado_Casos = new E_Estado_Casos();
    public N_Estado_Casos Obj_Neg_Estado_Casos = new N_Estado_Casos();
    public E_Nombre_Linea Obj_Entidad_Nombre_Linea = new E_Nombre_Linea();
    public N_Nombre_Linea Obj_Neg_Nombre_Linea = new N_Nombre_Linea();
    public E_Notas_Casos Obj_Entidad_Notas_Casos = new E_Notas_Casos();
    public N_Notas_Casos Obj_Neg_Notas_Casos = new N_Notas_Casos();
    public E_Log_Transacciones Obj_Entidad_Transacciones = new E_Log_Transacciones();
    public N_Log_Transacciones Obj_Neg_Transacciones = new N_Log_Transacciones();
    public E_Rechazos Obj_Entidad_Rechazos = new E_Rechazos();
    public N_Rechazos Obj_Neg_Rechazos = new N_Rechazos();

    protected void Page_Load(object sender, EventArgs e)
    {
        string fullname1 = Request.QueryString["id"];
        Id_Ingreso.Text = fullname1;
        Carga_Notas_Caso();

    }
    protected void Carga_Notas_Caso()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Notas.Id_Ingreso = Convert.ToInt64(Id_Ingreso.Text);
        dt = Obj_Neg_Notas.Consultar_Notas_Id(Obj_Entidad_Notas.Id_Ingreso);

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
        Obj_Entidad_Ingresos.Id_Ingreso = Convert.ToDouble(Id_Ingreso.Text);
        dt = Obj_Neg_Ingresos.Consulta_Usuario_Back(Obj_Entidad_Ingresos.Id_Ingreso);
        if (dt.Tables[0].Rows.Count > 0)
        {
            var USUARIORR = dt.Tables[0].Rows[0]["USUARIO_BACKOFFICE"].ToString();
            var USUARIO_LOGUEADO = Session["Usuario_Logueado"].ToString();
            if (USUARIORR == "" || USUARIORR == USUARIO_LOGUEADO)
            {
                Estado_Casos();
                Nombre_Linea();
                Actualiza_Usuario_Back();
                Carga_Informacion_Ingreso();
                Carga_Informacion_Cliente();
                Carga_Datos_Adicionales_Cliente();
                Carga_Datos_Marcacion();
                Gestionar.Enabled = false;
                Button3.Enabled = true;
            }
            else {
                Response.Redirect("Gestion_Casos_Celula.aspx");
            }
        }
        else
        {
           
        }
    }
    protected void Carga_Informacion_Ingreso()
    {

        DataSet dt = new DataSet();
        Obj_Entidad_Ingresos.Id_Ingreso = Convert.ToDouble(Id_Ingreso.Text);
        dt = Obj_Neg_Ingresos.Consulta_Ingreso_Back(Obj_Entidad_Ingresos.Id_Ingreso);
        if (dt.Tables[0].Rows.Count > 0)
        {
            Cuenta_Cliente.Text = dt.Tables[0].Rows[0]["CUENTA_CLIENTE"].ToString();
            Ticket.Text = dt.Tables[0].Rows[0]["TICKET"].ToString();
            Fecha_Apertura.Text = dt.Tables[0].Rows[0]["FECHA_APERTURA"].ToString();
            Hora_Apertura.Text = dt.Tables[0].Rows[0]["HORA_APERTURA"].ToString();
            Usuario_Apertura.Text = dt.Tables[0].Rows[0]["USUARIO_APERTURA"].ToString();
            Aliado_Apertura.Text = dt.Tables[0].Rows[0]["ALIADO_APERTURA"].ToString();
            Fecha_Ult_Actualizacion.Text = dt.Tables[0].Rows[0]["FECHA_ULTIMA_ACTUALIZACION"].ToString();
            Usuario_Ult_Actualizacion.Text = dt.Tables[0].Rows[0]["USUARIO_ULTIMA_ACTUALIZACION"].ToString();
            Hora_Actualizacion.Text = dt.Tables[0].Rows[0]["HORA_ULTIMA_ACTUALIZACION"].ToString();
            Macroproceso.Text = dt.Tables[0].Rows[0]["MACROPROCESO"].ToString();
            Proceso.Text = dt.Tables[0].Rows[0]["PROCESO"].ToString();
            Subproceso.Text = dt.Tables[0].Rows[0]["SUBPROCESO"].ToString();
            Marcacion.Text = dt.Tables[0].Rows[0]["MARCACION"].ToString();
            Servicios.Text = dt.Tables[0].Rows[0]["SERVICIOS"].ToString();
            Estado_Caso.Text = dt.Tables[0].Rows[0]["ID_ESTADO"].ToString();
            // Area_Escalar.Items.Clear();
            //Area_Escalar.Items.Add(dt.Tables[0].Rows[0]["NOMBRE_LINEA_ESCALADO"].ToString());
            Area_Escalar.SelectedValue = dt.Tables[0].Rows[0]["NOMBRE_LINEA_ESCALADO"].ToString();
            Label3.Text = dt.Tables[0].Rows[0]["NOMBRE_LINEA_ESCALADO"].ToString();
        }
        else { }
    }
    protected void Actualiza_Usuario_Back()
    {
        var Guardar_Datos = -1;
        Obj_Entidad_Ingresos.Id_Ingreso = Convert.ToDouble(Id_Ingreso.Text);
        Obj_Entidad_Ingresos.Usuario_Backoffice = Session["Usuario_Logueado"].ToString();
        Guardar_Datos = Obj_Neg_Ingresos.Actualiza_Usuario_Back(Obj_Entidad_Ingresos.Id_Ingreso, Obj_Entidad_Ingresos);
        if (Guardar_Datos != -1)
        {

        }
        else
        {

        }
    }
    protected void Carga_Informacion_Cliente()
    {
        DataSet dt2 = new DataSet();
        Obj_Entidad_Clientes.Cuenta_Cliente = Cuenta_Cliente.Text;
        dt2 = Obj_Neg_Clientes.Consulta_Cliente(Obj_Entidad_Clientes.Cuenta_Cliente);

        if (dt2.Tables[0].Rows.Count > 0)
        {
            Nombre_Cliente.Text = dt2.Tables[0].Rows[0]["NOMBRE"].ToString();
            Apellido_Cliente.Text = dt2.Tables[0].Rows[0]["APELLIDO"].ToString();
            Doc_Identidad.Text = dt2.Tables[0].Rows[0]["CEDULA"].ToString();
            Telefono_Telmex.Text = dt2.Tables[0].Rows[0]["TELEFONO_TELMEX"].ToString();
            Telefono_1.Text = dt2.Tables[0].Rows[0]["TELEFONO_1"].ToString();
            Telefono_2.Text = dt2.Tables[0].Rows[0]["TELEFONO_2"].ToString();
            Telefono_3.Text = dt2.Tables[0].Rows[0]["TELEFONO_3"].ToString();
            Dir_Instalacion.Text = dt2.Tables[0].Rows[0]["DIR_INSTALACION"].ToString();
            Dir_Correspondencia.Text = dt2.Tables[0].Rows[0]["DIR_CORRESPONDENCIA"].ToString();
            Red.Text = dt2.Tables[0].Rows[0]["RED"].ToString();
            Division.Text = dt2.Tables[0].Rows[0]["DIVISION"].ToString();
            Area.Text = dt2.Tables[0].Rows[0]["AREA"].ToString();
            Zona.Text = dt2.Tables[0].Rows[0]["ZONA"].ToString();
            Distrito.Text = dt2.Tables[0].Rows[0]["DISTRITO"].ToString();
            Nombre_Comunidad.Text = dt2.Tables[0].Rows[0]["NOMBRE_COMUNIDAD"].ToString();
            Estrato.Text = dt2.Tables[0].Rows[0]["ESTRATO"].ToString();
            Tipo_Cliente.Text = dt2.Tables[0].Rows[0]["TIPO_CLIENTE"].ToString();
            Descripcion.Text = dt2.Tables[0].Rows[0]["DESCRIPCION"].ToString();
        }
        else
        {

        }
    }
    protected void Carga_Datos_Adicionales_Cliente()
    {
        DataSet dt = new DataSet();

        Obj_Entidad_Datos_Cliente.Cuenta_Cliente = Convert.ToInt64(Cuenta_Cliente.Text);
        dt = Obj_Neg_Datos_Clientes.Consulta_Cliente_Back(Obj_Entidad_Datos_Cliente.Cuenta_Cliente);
        if (dt.Tables[0].Rows.Count > 0)
        {
            Telefono_Personal.Text = dt.Tables[0].Rows[0]["TELEFONO_PERSONAL"].ToString();
            Correo_Electronico.Text = dt.Tables[0].Rows[0]["CORREO_ELECTRONICO"].ToString();
        }
        else
        { }
    }
    protected void Carga_Datos_Marcacion()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Ingresos.Id_Ingreso = Convert.ToDouble(Id_Ingreso.Text);
        dt = Obj_Neg_Ingresos.Consulta_Marcacion_Back(Obj_Entidad_Ingresos.Id_Ingreso);
        if (dt.Tables[0].Rows.Count > 0)
        {
            Que_Hacer.Text = dt.Tables[0].Rows[0]["Que_Hacer"].ToString();
            Posible_Causa.Text = dt.Tables[0].Rows[0]["Posible_Causa"].ToString();
            Codigos_Cierre.Text = dt.Tables[0].Rows[0]["Codigos_De_Cierre"].ToString();
        }
        else
        {

        }
    }
    private void Estado_Casos()
    {
        DataSet dt = new DataSet();

        dt = Obj_Neg_Estado_Casos.Estado_Casos();



        if (dt.Tables[0].Rows.Count > 0)
        {
            Estado_Caso.DataSource = dt;
            Estado_Caso.DataTextField = "DESCRIPCION";
            Estado_Caso.DataValueField = "ID_ESTADO";
            Estado_Caso.DataBind();
        }
    }
    private void Nombre_Linea()
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Nombre_Linea.Nombre_Linea_Celulas();

        if (dt.Tables[0].Rows.Count > 0)
        {

            Area_Escalar.DataSource = dt;
            Area_Escalar.DataTextField = "NOMBRE_LINEA";
            Area_Escalar.DataValueField = "NOMBRE_LINEA";
            Area_Escalar.DataBind();
        }
    }
    protected void Estado_Caso_SelectedIndexChanged(object sender, EventArgs e)
    {
        var ESTADO_CASO = Estado_Caso.SelectedValue;


        if (ESTADO_CASO == "1")
        {
            Area_Escalar.Enabled = true;
            Area_Escalar.Items.Clear();
            Nombre_Linea();
        }
        else if (ESTADO_CASO == "2")
        {
            Area_Escalar.Items.Clear();
            Area_Escalar.Items.Add(Session["Nombre_Linea_Usuario"].ToString());
            Area_Escalar.Enabled = false;
        }
        else if (ESTADO_CASO == "3")
        {
            Area_Escalar.Enabled = true;
            Area_Escalar.Items.Clear();
            Area_Escalar.Items.Add(Session["Nombre_Linea_Usuario"].ToString());
        }


    }
    protected void Rechazo_SelectedIndexChanged(object sender, EventArgs e)
    {
        var RECHAZO = Rechazo.SelectedValue;

        if (RECHAZO == "SI") { Motivo_Rechazo.Enabled = true; }
        else
        {
            Motivo_Rechazo.Text = "";
            Motivo_Rechazo.Enabled = false;

            Rechazo.Focus();
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        var Estado_Select_Caso = Estado_Caso.SelectedValue;
        var Nombre_Linea_Back = Session["Nombre_Linea_Usuario"].ToString();
        var Area_Escalado = Area_Escalar.SelectedValue;
        if (Estado_Select_Caso == "1" && Area_Escalado == Nombre_Linea_Back) {
            string script = "mensaje4();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje4", script, true);
        }
        else { Actualiza_Ingreso(); }

        
    }
    protected void Controles_a_Objeto()
    {

        var Llamada_Cliente_Inicial = "NO";

        //TABLA INGRESOS
        Obj_Entidad_Ingresos.Id_Ingreso = Convert.ToInt64(Id_Ingreso.Text);
        
        Obj_Entidad_Ingresos.Usuario_Ultima_Actualizacion = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Ingresos.Id_Estado = Convert.ToInt16(Estado_Caso.SelectedValue);
        Obj_Entidad_Ingresos.Nombre_Linea_Escalado = Area_Escalar.Text;

        var Estado = Estado_Caso.SelectedValue;
        if (Estado == "1") 
        {
            Obj_Entidad_Ingresos.Usuario_Backoffice ="";
            Obj_Entidad_Ingresos.Usuario_Cierre = "";
        }
        else if (Estado == "2") {
            Obj_Entidad_Ingresos.Usuario_Backoffice = Session["Usuario_Logueado"].ToString();
            Obj_Entidad_Ingresos.Usuario_Cierre = Session["Usuario_Logueado"].ToString();
        }
        else if (Estado == "3") {
            Obj_Entidad_Ingresos.Usuario_Backoffice = Session["Usuario_Logueado"].ToString();
            Obj_Entidad_Ingresos.Usuario_Cierre = Session["Usuario_Logueado"].ToString();
        }
        

        //TABLA NOTAS DE LOS CASOS
        Obj_Entidad_Notas_Casos.Cuenta_Cliente = Convert.ToInt64(Cuenta_Cliente.Text);
        Obj_Entidad_Notas_Casos.Id_Ingreso = Convert.ToInt64(Id_Ingreso.Text);
        Obj_Entidad_Notas_Casos.Ticket = Convert.ToInt64(Ticket.Text);
        Obj_Entidad_Notas_Casos.Usuario = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Notas_Casos.Nombre_Linea_Nota = Session["Nombre_Linea_Usuario"].ToString();
        Obj_Entidad_Notas_Casos.Llamada_Cliente = Llamada_Cliente_Inicial;
        Obj_Entidad_Notas_Casos.Nota = Notas.Text.ToUpper();
        Obj_Entidad_Notas_Casos.Id_Estado = Convert.ToInt16(Estado_Caso.SelectedValue);
        //TABLA DE TRANSACCIONES
        Obj_Entidad_Transacciones.Id_Ingreso = Convert.ToInt64(Id_Ingreso.Text);
        Obj_Entidad_Transacciones.Transaccion = "DEPURACION BACK";
        Obj_Entidad_Transacciones.Usuario = Session["Usuario_Logueado"].ToString();
        //TABLA DE RECHAZOS
        Obj_Entidad_Rechazos.Id_Ingreso = Convert.ToInt64(Id_Ingreso.Text);
        Obj_Entidad_Rechazos.Fecha_Creacion = Fecha_Apertura.Text;
        Obj_Entidad_Rechazos.Hora_de_Creacion = Hora_Apertura.Text;
        Obj_Entidad_Rechazos.Usuario_Creacion = Usuario_Apertura.Text;
        Obj_Entidad_Rechazos.Notas_del_Rechazo=Motivo_Rechazo.Text;
        Obj_Entidad_Rechazos.Usuario_Rechaza = Session["Usuario_Logueado"].ToString();
    }
    protected void Actualiza_Ingreso()
    {
        Controles_a_Objeto();
        var Guardar_Notas_Casos = -1;
        Guardar_Notas_Casos = Obj_Neg_Ingresos.Actualiza_Casos_Back(Obj_Entidad_Ingresos.Id_Ingreso, Obj_Entidad_Ingresos);
        if (Guardar_Notas_Casos != -1)
        {
            Inserta_Notas();
            Button3.Enabled = false;
        }
        else
        { }
    }
    protected void Inserta_Notas()
    {
       
        var Guardar_Notas_Casos = -1;
        Guardar_Notas_Casos = Obj_Neg_Notas_Casos.Inserta_Nota_Inicial("INSERTAR", Obj_Entidad_Notas_Casos);
        if (Guardar_Notas_Casos != -1)
        {
            Registrar_Transaccion();
            Registra_Rechazo();
            Response.Redirect("Gestion_Casos_Celula.aspx");
        }
        else
        {

        }
    }
    protected void Registrar_Transaccion()
    {
        
        var Registrar_Transaccion = -1;
        Registrar_Transaccion = Obj_Neg_Transacciones.acb_Log_Transacciones(Obj_Entidad_Transacciones);
    }
    protected void Registra_Rechazo()
    {
        var APLICA = Rechazo.SelectedValue;
        if (APLICA == "SI")
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Rechazos.Id_Ingreso = Convert.ToInt64(Id_Ingreso.Text);
            dt = Obj_Neg_Rechazos.Consulta_Duplicado_Rechazo(Obj_Entidad_Rechazos.Id_Ingreso);

            if (dt.Tables[0].Rows.Count > 0)
            {

            }
            else
            {
                
                var Registrar_Transaccion = -1;
                Registrar_Transaccion = Obj_Neg_Rechazos.Inserta_Rechazo(Obj_Entidad_Rechazos.Id_Ingreso, Obj_Entidad_Rechazos);
            }
        }
        else
        {
        
        }
    }
    protected void Semaforo() {
        var Semaforo = -1;
        Semaforo = Obj_Neg_Ingresos.Semaforo();
    }
}