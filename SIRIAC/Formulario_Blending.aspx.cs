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

public partial class Formulario_Blendign : System.Web.UI.Page
{
    public E_Clientes Obj_Entidad_Clientes = new E_Clientes();
    public N_Clientes Obj_Neg_Clientes = new N_Clientes();
    public E_Arbol_Outbound Obj_Entidad_Arbol_Outbound = new E_Arbol_Outbound();
    public N_Arbol_Outbound Obj_Neg_Arbol_Outbound = new N_Arbol_Outbound();
    public E_Convenio_Electronico Obj_Entidad_Convenio_Electronico = new E_Convenio_Electronico();
    public N_Convenio_Electronico Obj_Neg_Convenio_Electronico = new N_Convenio_Electronico();
    public E_Logistica_Inversa Obj_Entidad_Logistica = new E_Logistica_Inversa();
    public E_Reincidencias Obj_Entidad_Reincidencias = new E_Reincidencias();
    public N_Reincidencias Obj_Neg_Reincidencias = new N_Reincidencias();
    public N_Logistica_Inversa Obj_Neg_Logistica = new N_Logistica_Inversa();
    public E_Ciudades Obj_Entidad_Ciudades = new E_Ciudades();
    public N_Ciudades Obj_Neg_Ciudades = new N_Ciudades();
    public E_Fraude Obj_Entidad_Fraude = new E_Fraude();
    public N_Fraude Obj_Neg_Fraude = new N_Fraude();
    public E_Ventas Obj_Entidad_Ventas = new E_Ventas();
    public N_Ventas Obj_Neg_Ventas = new N_Ventas();
    public E_Claro_Video Obj_Entidad_Claro_Video = new E_Claro_Video();
    public N_Claro_Video Obj_Neg_Claro_Video = new N_Claro_Video();
    public E_Docsis_Overlap obj_Entidad_Docsis_Overlap = new E_Docsis_Overlap();
    public N_Docsis_Overlap Obj_Neg_Docsis_Overlap = new N_Docsis_Overlap();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Acceso_9"].ToString() == "1") { } else { Response.Redirect("Bienvenida_Asesor.aspx?Acceso= " + Session["ACCESO_9"].ToString() + " --DENEGADO Gestion Blending"); }
        if (Session["Acceso_10"].ToString() == "1") { } else { Activacion_div.Style.Add("Display", " none"); }

        if (Session["Acceso_11"].ToString() == "1") { } else { Convenio_div.Style.Add("Display", " none"); }
        if (Session["Acceso_12"].ToString() == "1") { } else { Detractores_div.Style.Add("Display", " none"); }
        if (Session["Acceso_13"].ToString() == "1") { } else { Reincidencia_div.Style.Add("Display", " none"); }
        if (Session["Acceso_14"].ToString() == "1") { } else { Ventas_div.Style.Add("Display", " none"); }
        if (Session["Acceso_15"].ToString() == "1") { } else { Logistica_div.Style.Add("Display", " none"); }
        if (Session["Acceso_16"].ToString() == "1") { } else { Fraudes_div.Style.Add("Display", " none"); }
        if (Session["Acceso_17"].ToString() == "1") { } else { Claro_Video_div.Style.Add("Display", " none"); }
        if (Session["Acceso_18"].ToString() == "1") { } else { Docsis_Overlap_div.Style.Add("Display", " none"); }
    }
    protected void CE_Guardar_Click(object sender, EventArgs e)
    {

        if (CE_Cuenta_Cliente.Text == "")
        {
            string script6 = "mensaje6();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje6", script6, true);
        }
        else
        {
            CE_Guardar.Enabled = false;

            DataSet dt = new DataSet();
            Obj_Entidad_Convenio_Electronico.Cuenta_Cliente = Convert.ToDouble(CE_Cuenta_Cliente.Text);
            dt = Obj_Neg_Convenio_Electronico.Consulta_Registro(Obj_Entidad_Convenio_Electronico.Cuenta_Cliente);
            if (dt.Tables[0].Rows.Count > 0)
            {
                Actualizar_Registro();
            }
            else
            {
                Guardar_Registro();
            }
        }
    }
    protected void CE_Cuenta_Cliente_TextChanged(object sender, EventArgs e)
    {
        try
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Clientes.Cuenta_Cliente = CE_Cuenta_Cliente.Text;
            dt = Obj_Neg_Clientes.Consulta_Cliente(Obj_Entidad_Clientes.Cuenta_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                CE_Nombre_Cliente.Text = dt.Tables[0].Rows[0]["NOMBRE"].ToString();
                CE_Apellido_Cliente.Text = dt.Tables[0].Rows[0]["APELLIDO"].ToString();

                if (dt.Tables[0].Rows[0]["TELEFONO_TELMEX"].ToString() == "") { CE_Telefono_Telmex.Text = "0"; } else { CE_Telefono_Telmex.Text = dt.Tables[0].Rows[0]["TELEFONO_TELMEX"].ToString(); }
                if (dt.Tables[0].Rows[0]["TELEFONO_1"].ToString() == "") { CE_Telefono_1.Text = "0"; } else { CE_Telefono_1.Text = dt.Tables[0].Rows[0]["TELEFONO_1"].ToString(); }
                if (dt.Tables[0].Rows[0]["TELEFONO_2"].ToString() == "") { CE_Telefono_2.Text = "0"; } else { CE_Telefono_2.Text = dt.Tables[0].Rows[0]["TELEFONO_2"].ToString(); }
                if (dt.Tables[0].Rows[0]["TELEFONO_3"].ToString() == "") { CE_Telefono_3.Text = "0"; } else { CE_Telefono_3.Text = dt.Tables[0].Rows[0]["TELEFONO_3"].ToString(); }
                CE_Direccion_Instalacion.Text = dt.Tables[0].Rows[0]["DIR_INSTALACION"].ToString();
                CD_Direccion_Correspondencia.Text = dt.Tables[0].Rows[0]["DIR_CORRESPONDENCIA"].ToString();
                CE_Movil_Nuevo.Text = "0";
                if (dt.Tables[0].Rows[0]["TELEFONO_CONV"].ToString() == "") { CE_Móvil_Actual.Text = "0"; } else { CE_Móvil_Actual.Text = dt.Tables[0].Rows[0]["TELEFONO_CONV"].ToString(); }
                CE_Correo_Electronico_Actual.Text = dt.Tables[0].Rows[0]["CORREO"].ToString();
                Tipo_Contacto();
                Cierre();
                Razon();

            }
            else
            {
                string script5 = "mensaje5();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje5", script5, true);
                CE_Limpiar();

            }
        }
        catch (Exception esc)
        { throw new Exception("Error al Consultar la cuenta del cliente", esc); }

    }
    protected void Tipo_Contacto()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion = 2;
        dt = Obj_Neg_Arbol_Outbound.Oubound_Tipo_Contacto(Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion);

        if (dt.Tables[0].Rows.Count > 0)
        {
            CE_Tipo_de_Contacto.DataSource = dt;
            CE_Tipo_de_Contacto.DataTextField = "TIPO_CONTACTO";
            CE_Tipo_de_Contacto.DataValueField = "ID_TIPO_CONTACTO";
            CE_Tipo_de_Contacto.DataBind();
        }
        else
        {
            CE_Tipo_de_Contacto.Items.Clear();
        }
    }
    protected void Cierre()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto = Convert.ToInt16(CE_Tipo_de_Contacto.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Cierre(Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto);

        if (dt.Tables[0].Rows.Count > 0)
        {
            CE_Cierre.DataSource = dt;
            CE_Cierre.DataTextField = "CIERRE";
            CE_Cierre.DataValueField = "ID_CIERRE";
            CE_Cierre.DataBind();
        }
        else
        {
            CE_Cierre.Items.Clear();
        }
    }
    protected void Razon()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Cierre = Convert.ToInt16(CE_Cierre.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Razon(Obj_Entidad_Arbol_Outbound.Id_Cierre);

        if (dt.Tables[0].Rows.Count > 0)
        {
            CE_Razon.DataSource = dt;
            CE_Razon.DataTextField = "RAZON";
            CE_Razon.DataValueField = "ID_RAZON";
            CE_Razon.DataBind();
        }
        else
        {
            CE_Razon.Items.Clear();
        }
    }
    protected void CE_Cierre_SelectedIndexChanged(object sender, EventArgs e)
    {
        Razon();
    }
    protected void CE_Tipo_de_Contacto_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cierre();
        Razon();
    }
    protected void CE_Limpiar()
    {
        var Limpiar = "";
        CE_Nombre_Cliente.Text = Limpiar;
        CE_Apellido_Cliente.Text = Limpiar;
        CE_Direccion_Instalacion.Text = Limpiar;
        CE_Correo_Electronico_Actual.Text = Limpiar;
        CE_Telefono_Telmex.Text = Limpiar;
        CE_Telefono_1.Text = Limpiar;
        CE_Telefono_2.Text = Limpiar;
        CE_Telefono_3.Text = Limpiar;
        CE_Móvil_Actual.Text = Limpiar;
        CE_Correo_Electronico_Actual.Text = Limpiar;
        CE_Tipo_de_Contacto.Items.Clear();
        CE_Tipo_de_Contacto.ClearSelection();
        CE_Cierre.Items.Clear();
        CE_Cierre.ClearSelection();
        CE_Razon.Items.Clear();
        CE_Razon.ClearSelection();
        CE_Correo_Nuevo.Text = Limpiar;
        CE_Movil_Nuevo.Text = Limpiar;
        CE_Correspondencia_Nueva.Text = Limpiar;
        CD_Direccion_Correspondencia.Text = Limpiar;
        CE_Cuenta_Cliente.Text = Limpiar;
        CE_Guardar.Enabled = true;
    }
    protected void Controles_A_Objeto()
    {
        Obj_Entidad_Convenio_Electronico.Usuario_Gestion = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Convenio_Electronico.Aliado_Gestion = Session["Aliado_Usuario"].ToString();
        Obj_Entidad_Convenio_Electronico.Linea_Gestion = Session["Nombre_Linea_Usuario"].ToString();
        Obj_Entidad_Convenio_Electronico.Cuenta_Cliente = Convert.ToDouble(CE_Cuenta_Cliente.Text);
        Obj_Entidad_Convenio_Electronico.Nombre_Cliente = CE_Nombre_Cliente.Text;
        Obj_Entidad_Convenio_Electronico.Apellido_Cliente = CE_Apellido_Cliente.Text;
        Obj_Entidad_Convenio_Electronico.Direccion_Instalacion = CE_Direccion_Instalacion.Text;
        Obj_Entidad_Convenio_Electronico.Direccion_Correspondencia = CD_Direccion_Correspondencia.Text;
        Obj_Entidad_Convenio_Electronico.Telefono_Telmex = Convert.ToDouble(CE_Telefono_Telmex.Text);
        Obj_Entidad_Convenio_Electronico.Telefono_1 = Convert.ToDouble(CE_Telefono_1.Text);
        Obj_Entidad_Convenio_Electronico.Telefono_2 = Convert.ToDouble(CE_Telefono_2.Text);
        Obj_Entidad_Convenio_Electronico.Telefono_3 = Convert.ToDouble(CE_Telefono_3.Text);
        Obj_Entidad_Convenio_Electronico.Movil_Actual = Convert.ToDouble(CE_Móvil_Actual.Text);
        Obj_Entidad_Convenio_Electronico.Correo_Actual = CE_Correo_Electronico_Actual.Text;
        Obj_Entidad_Convenio_Electronico.Tipo_Contacto = Convert.ToString(CE_Tipo_de_Contacto.SelectedItem);
        Obj_Entidad_Convenio_Electronico.Cierre = Convert.ToString(CE_Cierre.SelectedItem);
        Obj_Entidad_Convenio_Electronico.Razon = Convert.ToString(CE_Razon.SelectedItem);
        Obj_Entidad_Convenio_Electronico.Movil_Nuevo = Convert.ToDouble(CE_Movil_Nuevo.Text);
        Obj_Entidad_Convenio_Electronico.Nuevo_Correo = CE_Correo_Nuevo.Text;
        Obj_Entidad_Convenio_Electronico.Direccion_de_Correspondencia_Nueva = CE_Correspondencia_Nueva.Text;
    }
    protected void Guardar_Registro()
    {
        Controles_A_Objeto();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Convenio_Electronico.abc_Convenioo_Electronico("INSERTAR", Obj_Entidad_Convenio_Electronico);
        if (Guardar_Datos != -1)
        {
            Registrar_Transaccion();
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj1", script1, true);
            CE_Limpiar();
        }
        else
        {

            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj2", script2, true);

        }
    }
    protected void Actualizar_Registro()
    {
        Controles_A_Objeto();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Convenio_Electronico.abc_Convenioo_Electronico("ACTUALIZAR", Obj_Entidad_Convenio_Electronico);
        if (Guardar_Datos != -1)
        {
            Registrar_Transaccion();
            string script3 = "mensaje3();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje3", script3, true);
            CE_Limpiar();
        }
        else
        {

            string script4 = "mensaje4();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje4", script4, true);
        }
    }
    protected void Registrar_Transaccion()
    {
        Controles_A_Objeto();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Convenio_Electronico.abc_Convenioo_Electronico_Log("INSERTAR", Obj_Entidad_Convenio_Electronico);
    }
    protected void LI_Cuenta_Cliente_TextChanged(object sender, EventArgs e)
    {
        try
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Clientes.Cuenta_Cliente = LI_Cuenta_Cliente.Text;
            dt = Obj_Neg_Clientes.Consulta_Cliente(Obj_Entidad_Clientes.Cuenta_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                LI_Nombre_Cliente.Text = dt.Tables[0].Rows[0]["NOMBRE"].ToString();
                LI_Apellido_Cliente.Text = dt.Tables[0].Rows[0]["APELLIDO"].ToString();

                if (dt.Tables[0].Rows[0]["TELEFONO_TELMEX"].ToString() == "") { LI_Telefono_Telmex.Text = "0"; } else { LI_Telefono_Telmex.Text = dt.Tables[0].Rows[0]["TELEFONO_TELMEX"].ToString(); }
                if (dt.Tables[0].Rows[0]["TELEFONO_1"].ToString() == "") { LI_Telefono_1.Text = "0"; } else { LI_Telefono_1.Text = dt.Tables[0].Rows[0]["TELEFONO_1"].ToString(); }
                if (dt.Tables[0].Rows[0]["TELEFONO_2"].ToString() == "") { LI_Telefono_2.Text = "0"; } else { LI_Telefono_2.Text = dt.Tables[0].Rows[0]["TELEFONO_2"].ToString(); }
                if (dt.Tables[0].Rows[0]["TELEFONO_3"].ToString() == "") { LI_Telefono_3.Text = "0"; } else { LI_Telefono_3.Text = dt.Tables[0].Rows[0]["TELEFONO_3"].ToString(); }
                LI_Dir_Instalacion.Text = dt.Tables[0].Rows[0]["DIR_INSTALACION"].ToString();
                LI_Dir_Correspondencia.Text = dt.Tables[0].Rows[0]["DIR_CORRESPONDENCIA"].ToString();
                if (dt.Tables[0].Rows[0]["TELEFONO_CONV"].ToString() == "") { LI_Movil_Postpago.Text = "0"; } else { LI_Movil_Postpago.Text = dt.Tables[0].Rows[0]["TELEFONO_CONV"].ToString(); }
                LI_Telefono_Contacto.Text = "0";
                Tipo_Contacto_Logistica_Inversa();
                Cierre_Logistica_Inversa();
                Razon_Logistica_Inversa();
                LI_Departamentos();


            }
            else
            {
                string script5 = "mensaje5();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje5", script5, true);
                LI_Limpiar();

            }
        }
        catch (Exception esc)
        { throw new Exception("Error al Consultar la cuenta del cliente", esc); }
    }
    protected void Tipo_Contacto_Logistica_Inversa()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion = 6;
        dt = Obj_Neg_Arbol_Outbound.Oubound_Tipo_Contacto(Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion);

        if (dt.Tables[0].Rows.Count > 0)
        {
            LI_Tipo_Contacto.DataSource = dt;
            LI_Tipo_Contacto.DataTextField = "TIPO_CONTACTO";
            LI_Tipo_Contacto.DataValueField = "ID_TIPO_CONTACTO";
            LI_Tipo_Contacto.DataBind();
        }
        else
        {
            LI_Tipo_Contacto.Items.Clear();
        }
    }
    protected void Razon_Logistica_Inversa()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Cierre = Convert.ToInt16(LI_Cierre.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Razon(Obj_Entidad_Arbol_Outbound.Id_Cierre);

        if (dt.Tables[0].Rows.Count > 0)
        {
            LI_Razon.DataSource = dt;
            LI_Razon.DataTextField = "RAZON";
            LI_Razon.DataValueField = "ID_RAZON";
            LI_Razon.DataBind();
        }
        else
        {
            LI_Razon.Items.Clear();
        }
    }
    protected void Cierre_Logistica_Inversa()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto = Convert.ToInt16(LI_Tipo_Contacto.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Cierre(Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto);

        if (dt.Tables[0].Rows.Count > 0)
        {
            LI_Cierre.DataSource = dt;
            LI_Cierre.DataTextField = "CIERRE";
            LI_Cierre.DataValueField = "ID_CIERRE";
            LI_Cierre.DataBind();
        }
        else
        {
            LI_Cierre.Items.Clear();
        }
    }
    protected void LI_Tipo_Contacto_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cierre_Logistica_Inversa();
        Razon_Logistica_Inversa();
    }
    protected void LI_Cierre_SelectedIndexChanged(object sender, EventArgs e)
    {
        Razon_Logistica_Inversa();

    }
    protected void LI_Controles_a_Objeto()
    {
        Obj_Entidad_Logistica.Usuario_Gestion = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Logistica.Aliado_Gestion = Session["Aliado_Usuario"].ToString();
        Obj_Entidad_Logistica.Cuenta_Cliente = Convert.ToDouble(LI_Cuenta_Cliente.Text);
        Obj_Entidad_Logistica.Nombre_Cliente = LI_Nombre_Cliente.Text;
        Obj_Entidad_Logistica.Apellido_Cliente = LI_Apellido_Cliente.Text;
        Obj_Entidad_Logistica.Direccion_Instalacion = LI_Dir_Instalacion.Text;
        Obj_Entidad_Logistica.Direccion_Correspondencia = LI_Dir_Correspondencia.Text;
        Obj_Entidad_Logistica.Telefono_Telmex = Convert.ToDouble(LI_Telefono_Telmex.Text);
        Obj_Entidad_Logistica.Telefono_1 = Convert.ToDouble(LI_Telefono_1.Text);
        Obj_Entidad_Logistica.Telefono_2 = Convert.ToDouble(LI_Telefono_2.Text);
        Obj_Entidad_Logistica.Telefono_3 = Convert.ToDouble(LI_Telefono_3.Text);
        Obj_Entidad_Logistica.Movil_Portpago = Convert.ToDouble(LI_Movil_Postpago.Text);
        Obj_Entidad_Logistica.Tipo_Contacto = Convert.ToString(LI_Tipo_Contacto.SelectedItem);
        Obj_Entidad_Logistica.Cierre = Convert.ToString(LI_Cierre.SelectedItem);
        Obj_Entidad_Logistica.Razon = Convert.ToString(LI_Razon.SelectedItem);
        if (LI_Fecha_Agenda.Text == "") { LI_Fecha_Agenda.Text = "1990-01-01 00:00"; Obj_Entidad_Logistica.Fecha_Agenda = Convert.ToDateTime(LI_Fecha_Agenda.Text); } else { Obj_Entidad_Logistica.Fecha_Agenda = Convert.ToDateTime(LI_Fecha_Agenda.Text); }
        Obj_Entidad_Logistica.Persona_Contacto = LI_Persona_Contacto.Text.ToUpper();
        Obj_Entidad_Logistica.Telefono_Contacto = Convert.ToDouble(LI_Telefono_Contacto.Text);
        Obj_Entidad_Logistica.Direccion_Alterna = LI_Direccion_Alterna.Text.ToUpper();
        Obj_Entidad_Logistica.Observaciones = LI_Observaciones.Text.ToUpper();
        Obj_Entidad_Logistica.Departamento = Convert.ToString(LI_Departamento.SelectedItem);
        Obj_Entidad_Logistica.Ciudad = Convert.ToString(LI_Ciudad_de_Entrega.SelectedItem);
    }
    protected void LI_Guardar_Click(object sender, EventArgs e)
    {
        if (Convert.ToString(LI_Razon.SelectedItem) == "RECOGER LOS EQUIPOS")
        {

        }
        else { LI_Fecha_Agenda.Text = "1990-01-01 00:00"; }

        if (LI_Fecha_Agenda.Text == "")
        {
            string script7 = "mensaje7();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje7", script7, true);

        }
        else
        {

            if (LI_Cuenta_Cliente.Text == "")
            {
                string script6 = "mensaje6();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje6", script6, true);
            }
            else
            {
                LI_Guardar.Enabled = false;

                DataSet dt = new DataSet();
                Obj_Entidad_Logistica.Cuenta_Cliente = Convert.ToDouble(LI_Cuenta_Cliente.Text);
                dt = Obj_Neg_Logistica.Consultar_Registro(Obj_Entidad_Logistica.Cuenta_Cliente);
                if (dt.Tables[0].Rows.Count > 0)
                {
                    Actualizar_Registro_Logistica_Inversa();
                }
                else
                {
                    LI_Guardar_Registro();
                }
            }
        }

    }
    protected void LI_Guardar_Registro()
    {
        LI_Controles_a_Objeto();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Logistica.abc_Logistica_Inversa("INSERTAR", Obj_Entidad_Logistica);
        if (Guardar_Datos != -1)
        {
            Registrar_Transaccion_Logistica();
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj1", script1, true);
            LI_Limpiar();
        }
        else
        {
            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj2", script2, true);

        }
    }
    protected void Registrar_Transaccion_Logistica()
    {
        LI_Controles_a_Objeto();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Logistica.abc_Log_Logistica_Inversa("INSERTAR", Obj_Entidad_Logistica);
        LI_Limpiar();

    }
    protected void Actualizar_Registro_Logistica_Inversa()
    {
        LI_Controles_a_Objeto();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Logistica.abc_Logistica_Inversa("ACTUALIZAR", Obj_Entidad_Logistica);
        if (Guardar_Datos != -1)
        {
            Registrar_Transaccion_Logistica();
            string script3 = "mensaje3();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje3", script3, true);
            LI_Limpiar();
        }
        else
        {

            string script4 = "mensaje4();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje4", script4, true);
        }
    }
    protected void LI_Limpiar()
    {
        var Limpiar = "";
        LI_Nombre_Cliente.Text = Limpiar;
        LI_Apellido_Cliente.Text = Limpiar;
        LI_Dir_Instalacion.Text = Limpiar;
        LI_Telefono_Telmex.Text = Limpiar;
        LI_Telefono_1.Text = Limpiar;
        LI_Telefono_2.Text = Limpiar;
        LI_Telefono_3.Text = Limpiar;
        LI_Movil_Postpago.Text = Limpiar;
        LI_Tipo_Contacto.Items.Clear();
        LI_Tipo_Contacto.ClearSelection();
        LI_Cierre.Items.Clear();
        LI_Cierre.ClearSelection();
        LI_Razon.Items.Clear();
        LI_Razon.ClearSelection();
        LI_Dir_Correspondencia.Text = Limpiar;
        LI_Cuenta_Cliente.Text = Limpiar;
        LI_Persona_Contacto.Text = Limpiar;
        LI_Telefono_Contacto.Text = "0";
        LI_Direccion_Alterna.Text = Limpiar;
        LI_Fecha_Agenda.Text = Limpiar;
        LI_Observaciones.Text = Limpiar;
        LI_Guardar.Enabled = true;
        LI_Departamento.Items.Clear();
        LI_Departamento.ClearSelection();
        LI_Ciudad_de_Entrega.Items.Clear();
        LI_Ciudad_de_Entrega.ClearSelection();
    }
    protected void LI_Departamentos()
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Ciudades.Consulta_Departamentos();

        if (dt.Tables[0].Rows.Count > 0)
        {

            LI_Departamento.DataSource = dt;
            LI_Departamento.DataTextField = "DEPARTAMENTO";
            LI_Departamento.DataValueField = "ID_DEPARTAMENTO";
            LI_Departamento.DataBind();
            LI_Departamento.Items.Insert(0, "--SELECCIONE--");
        }
        else
        {
            LI_Departamento.Items.Clear();
        }

    }
    protected void LI_Municipios()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Ciudades.Id_Departamento = Convert.ToInt16(LI_Departamento.SelectedValue);
        dt = Obj_Neg_Ciudades.Consulta_Municipios(Obj_Entidad_Ciudades.Id_Departamento);

        if (dt.Tables[0].Rows.Count > 0)
        {

            LI_Ciudad_de_Entrega.DataSource = dt;
            LI_Ciudad_de_Entrega.DataTextField = "MUNICIPIO";
            LI_Ciudad_de_Entrega.DataValueField = "MUNICIPIO";
            LI_Ciudad_de_Entrega.DataBind();
            LI_Ciudad_de_Entrega.Items.Insert(0, "--SELECCIONE--");
        }
        else
        {
            LI_Ciudad_de_Entrega.Items.Clear();
        }
    }
    protected void LI_Departamento_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Convert.ToString(LI_Departamento.SelectedItem) == "--SELECCIONE--") { LI_Ciudad_de_Entrega.Items.Clear(); LI_Ciudad_de_Entrega.ClearSelection(); } else { LI_Municipios(); }

    }
    protected void F_Cuenta_Cliente_TextChanged(object sender, EventArgs e)
    {
        try
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Fraude.Cuenta_cliente = Convert.ToDouble(F_Cuenta_Cliente.Text);
            dt = Obj_Neg_Fraude.Consulta_Cuenta_Fraude(Obj_Entidad_Fraude.Cuenta_cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                F_Servicios.Text = dt.Tables[0].Rows[0]["SERVICIOS"].ToString();
                F_Fecha_Digitacion.Text = dt.Tables[0].Rows[0]["FECHA_DIGITACION"].ToString();
                F_Fijos_Buro.Text = dt.Tables[0].Rows[0]["TELEFONO_FIJO_BURO"].ToString();
                F_Moviles_Buro.Text = dt.Tables[0].Rows[0]["TELEFONO_MOVIL_BURO"].ToString();
                F_Consutar_Cliente_General();
            }
            else
            {
                string script5 = "mensaje5();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje5", script5, true);
                F_Limpiar();

            }
        }
        catch (Exception esc)
        { throw new Exception("Error al Consultar la cuenta del cliente", esc); }
    }
    protected void F_Consutar_Cliente_General()
    {
        try
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Clientes.Cuenta_Cliente = F_Cuenta_Cliente.Text;
            dt = Obj_Neg_Clientes.Consulta_Cliente(Obj_Entidad_Clientes.Cuenta_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                F_Home_Pass.Text = dt.Tables[0].Rows[0]["HOME_PASS"].ToString();
                F_Estado_Cliente.Text = dt.Tables[0].Rows[0]["ESTADO"].ToString();
                F_Nombre_Cliente.Text = dt.Tables[0].Rows[0]["NOMBRE"].ToString();
                F_Apellido_Cliente.Text = dt.Tables[0].Rows[0]["APELLIDO"].ToString();
                F_Direccion_Instalacion.Text = dt.Tables[0].Rows[0]["DIR_INSTALACION"].ToString();
                F_Direccion_Correspondencia.Text = dt.Tables[0].Rows[0]["DIR_CORRESPONDENCIA"].ToString();
                if (dt.Tables[0].Rows[0]["TELEFONO_TELMEX"].ToString() == "") { F_Telefono_Telmex.Text = "0"; } else { F_Telefono_Telmex.Text = dt.Tables[0].Rows[0]["TELEFONO_TELMEX"].ToString(); }
                if (dt.Tables[0].Rows[0]["TELEFONO_1"].ToString() == "") { F_Telefono_1.Text = "0"; } else { F_Telefono_1.Text = dt.Tables[0].Rows[0]["TELEFONO_1"].ToString(); }
                if (dt.Tables[0].Rows[0]["TELEFONO_2"].ToString() == "") { F_Telefono_2.Text = "0"; } else { F_Telefono_2.Text = dt.Tables[0].Rows[0]["TELEFONO_2"].ToString(); }
                if (dt.Tables[0].Rows[0]["TELEFONO_3"].ToString() == "") { F_Telefono_3.Text = "0"; } else { F_Telefono_3.Text = dt.Tables[0].Rows[0]["TELEFONO_3"].ToString(); }
                if (dt.Tables[0].Rows[0]["TELEFONO_CONV"].ToString() == "") { F_Movil_Postpago.Text = "0"; } else { F_Movil_Postpago.Text = dt.Tables[0].Rows[0]["TELEFONO_CONV"].ToString(); }
                F_Correo.Text = dt.Tables[0].Rows[0]["CORREO"].ToString();
                F_Nodo.Text = dt.Tables[0].Rows[0]["NODO"].ToString();
                F_Red.Text = dt.Tables[0].Rows[0]["RED"].ToString();
                F_Division.Text = dt.Tables[0].Rows[0]["DIVISION"].ToString();
                F_Area.Text = dt.Tables[0].Rows[0]["AREA"].ToString();
                F_Zona.Text = dt.Tables[0].Rows[0]["ZONA"].ToString();
                F_Distrito.Text = dt.Tables[0].Rows[0]["DISTRITO"].ToString();
                F_Nombre_Comunidad.Text = dt.Tables[0].Rows[0]["NOMBRE_COMUNIDAD"].ToString();
                F_Departamento.Text = dt.Tables[0].Rows[0]["DEPARTAMENTO"].ToString();
                F_Estrato.Text = dt.Tables[0].Rows[0]["ESTRATO"].ToString();
                F_Tipo_Cliente.Text = dt.Tables[0].Rows[0]["TIPO_CLIENTE"].ToString();
                Tipo_Contacto_Fraude();
                Cierre_Fraude();
                Razon_Fraude();

            }
            else
            {
                string script5 = "mensaje5();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje5", script5, true);
                LI_Limpiar();

            }
        }
        catch (Exception esc)
        { throw new Exception("Error al Consultar la cuenta del cliente", esc); }
    }
    protected void F_Limpiar()
    {
        var limpiar = "";
        F_Home_Pass.Text = limpiar;
        F_Estado_Cliente.Text = limpiar;
        F_Nombre_Cliente.Text = limpiar;
        F_Apellido_Cliente.Text = limpiar;
        F_Direccion_Instalacion.Text = limpiar;
        F_Direccion_Correspondencia.Text = limpiar;
        F_Telefono_Telmex.Text = limpiar;
        F_Telefono_1.Text = limpiar;
        F_Telefono_2.Text = limpiar;
        F_Telefono_3.Text = limpiar;
        F_Movil_Postpago.Text = limpiar;
        F_Correo.Text = limpiar;
        F_Nodo.Text = limpiar;
        F_Red.Text = limpiar;
        F_Division.Text = limpiar;
        F_Area.Text = limpiar;
        F_Zona.Text = limpiar;
        F_Distrito.Text = limpiar;
        F_Nombre_Comunidad.Text = limpiar;
        F_Departamento.Text = limpiar;
        F_Estrato.Text = limpiar;
        F_Tipo_Cliente.Text = limpiar;
        F_Cuenta_Cliente.Text = limpiar;
        F_Servicios.Text = limpiar;
        F_Fecha_Digitacion.Text = limpiar;
        F_Fijos_Buro.Text = limpiar;
        F_Moviles_Buro.Text = limpiar;
        F_Tipo_Contacto.Items.Clear();
        F_Tipo_Contacto.ClearSelection();
        F_Cierre.Items.Clear();
        F_Cierre.ClearSelection();
        F_Razon.Items.Clear();
        F_Razon.ClearSelection();
        F_Observaciones.Text = limpiar;
    }
    protected void Tipo_Contacto_Fraude()
    {

        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion = 7;
        dt = Obj_Neg_Arbol_Outbound.Oubound_Tipo_Contacto(Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion);

        if (dt.Tables[0].Rows.Count > 0)
        {
            F_Tipo_Contacto.DataSource = dt;
            F_Tipo_Contacto.DataTextField = "TIPO_CONTACTO";
            F_Tipo_Contacto.DataValueField = "ID_TIPO_CONTACTO";
            F_Tipo_Contacto.DataBind();
        }
        else
        {
            F_Tipo_Contacto.Items.Clear();
        }
    }
    protected void Cierre_Fraude()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto = Convert.ToInt16(F_Tipo_Contacto.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Cierre(Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto);

        if (dt.Tables[0].Rows.Count > 0)
        {

            F_Cierre.DataSource = dt;
            F_Cierre.DataTextField = "CIERRE";
            F_Cierre.DataValueField = "ID_CIERRE";
            F_Cierre.DataBind();
        }
        else
        {
            F_Cierre.Items.Clear();
        }
    }
    protected void Razon_Fraude()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Cierre = Convert.ToInt16(F_Cierre.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Razon(Obj_Entidad_Arbol_Outbound.Id_Cierre);

        if (dt.Tables[0].Rows.Count > 0)
        {
            F_Razon.DataSource = dt;
            F_Razon.DataTextField = "RAZON";
            F_Razon.DataValueField = "ID_RAZON";
            F_Razon.DataBind();
        }
        else
        {
            F_Razon.Items.Clear();
        }
    }
    protected void F_Tipo_Contacto_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cierre_Fraude();
        Razon_Fraude();
    }
    protected void F_Cierre_SelectedIndexChanged(object sender, EventArgs e)
    {
        Razon_Fraude();
    }
    protected void Controles_a_Objeto_Fraudes()
    {
        Obj_Entidad_Fraude.Usuario_gestion = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Fraude.Aliado_gestion = Session["Aliado_Usuario"].ToString();
        Obj_Entidad_Fraude.Cuenta_cliente = Convert.ToDouble(F_Cuenta_Cliente.Text);
        Obj_Entidad_Fraude.Home_pass = F_Home_Pass.Text;
        Obj_Entidad_Fraude.Nombre_cliente = F_Nombre_Cliente.Text;
        Obj_Entidad_Fraude.Apellido_cliente = F_Apellido_Cliente.Text;
        Obj_Entidad_Fraude.Direccion_instalacion = F_Direccion_Instalacion.Text;
        Obj_Entidad_Fraude.Direccion_correspondencia = F_Direccion_Correspondencia.Text;
        Obj_Entidad_Fraude.Telefono_telmex = Convert.ToDouble(F_Telefono_Telmex.Text);
        Obj_Entidad_Fraude.Telefono_1 = Convert.ToDouble(F_Telefono_1.Text);
        Obj_Entidad_Fraude.Telefono_2 = Convert.ToDouble(F_Telefono_2.Text);
        Obj_Entidad_Fraude.Telefono_3 = Convert.ToDouble(F_Telefono_3.Text);
        Obj_Entidad_Fraude.Movil_postpago = Convert.ToDouble(F_Movil_Postpago.Text);
        Obj_Entidad_Fraude.Correo = F_Correo.Text;
        Obj_Entidad_Fraude.Nodo = F_Nodo.Text;
        Obj_Entidad_Fraude.Red = F_Red.Text;
        Obj_Entidad_Fraude.Division = F_Division.Text;
        Obj_Entidad_Fraude.Area = F_Area.Text;
        Obj_Entidad_Fraude.Zona = F_Zona.Text;
        Obj_Entidad_Fraude.Distrito = F_Distrito.Text;
        Obj_Entidad_Fraude.Nombre_comunidad = F_Nombre_Comunidad.Text;
        Obj_Entidad_Fraude.Departamento = F_Departamento.Text;
        Obj_Entidad_Fraude.Estrato = F_Estrato.Text;
        Obj_Entidad_Fraude.Tipo_cliente = F_Tipo_Cliente.Text;
        Obj_Entidad_Fraude.Servicios = F_Servicios.Text;
        Obj_Entidad_Fraude.Telefonos_fijos_buro = F_Fijos_Buro.Text;
        Obj_Entidad_Fraude.Telefonos_moviles_buro = F_Moviles_Buro.Text;
        Obj_Entidad_Fraude.Fecha_digitacion = Convert.ToDouble(F_Fecha_Digitacion.Text);
        Obj_Entidad_Fraude.Tipo_contacto = Convert.ToString(F_Tipo_Contacto.SelectedItem);
        Obj_Entidad_Fraude.Cierre = Convert.ToString(F_Cierre.SelectedItem);
        Obj_Entidad_Fraude.Razon = Convert.ToString(F_Razon.SelectedItem);
        Obj_Entidad_Fraude.Observaciones = F_Observaciones.Text.ToUpper();

    }
    protected void Inserta_Registro_Fraude()
    {
        Controles_a_Objeto_Fraudes();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Fraude.abcFraudes("INSERTAR", Obj_Entidad_Fraude);
        if (Guardar_Datos != -1)
        {
            Registrar_Transaccion_Fraude();
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj1", script1, true);
            F_Limpiar();
        }
        else
        {

            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj2", script2, true);

        }
    }
    protected void Actualizar_Registro_Fraude()
    {
        Controles_a_Objeto_Fraudes();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Fraude.abcFraudes("ACTUALIZAR", Obj_Entidad_Fraude);
        if (Guardar_Datos != -1)
        {
            Registrar_Transaccion_Fraude();
            string script1 = "mensaje3();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj1", script1, true);
            F_Limpiar();
        }
        else
        {

            string script2 = "mensaje4();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj2", script2, true);

        }

    }
    protected void Registrar_Transaccion_Fraude()
    {
        Controles_a_Objeto_Fraudes();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Fraude.abcLog_Fraudes("INSERTAR", Obj_Entidad_Fraude);
        if (Guardar_Datos != -1)
        {

            F_Limpiar();
        }
        else
        {


        }

    }
    protected void F_Guardar_Click(object sender, EventArgs e)
    {
        try
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Fraude.Cuenta_cliente = Convert.ToDouble(F_Cuenta_Cliente.Text);
            dt = Obj_Neg_Fraude.Consulta_Cuenta_Gestionada_Fraude(Obj_Entidad_Fraude.Cuenta_cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {

                Actualizar_Registro_Fraude();
            }
            else
            {
                Inserta_Registro_Fraude();

            }
        }
        catch (Exception esc)
        { throw new Exception("Error al guardar registro", esc); }
    }
    protected void V_Cuenta_Cliente_TextChanged(object sender, EventArgs e)
    {
        try
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Ventas.Cuenta_Cliente = Convert.ToDouble(V_Cuenta_Cliente.Text);
            dt = Obj_Neg_Ventas.Consulta_Temporal_Cuentas(Obj_Entidad_Ventas.Cuenta_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                V_Telefono_1.Text = dt.Tables[0].Rows[0]["TELEFONO_1"].ToString();
                V_Telefono_2.Text = dt.Tables[0].Rows[0]["TELEFONO_2"].ToString();
                V_Telefono_3.Text = dt.Tables[0].Rows[0]["TELEFONO_3"].ToString();
                V_Movil_1.Text = dt.Tables[0].Rows[0]["MOVIL_1"].ToString();
                V_Movil_2.Text = dt.Tables[0].Rows[0]["MOVIL_2"].ToString();
                V_Paquete_Actual.Text = dt.Tables[0].Rows[0]["PAQUETE_ACTUAL"].ToString();
                V_Consultar_Datos_Cliente();
            }
            else
            {
                string script5 = "mensaje5();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje5", script5, true);
                Limpiar_Ventas();

            }
        }
        catch (Exception esc)
        { throw new Exception("Error al Consultar la cuenta del cliente", esc); }
    }
    protected void V_Tipo_de_Contacto_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cierre_Ventas();
        Razon_Ventas();
    }
    protected void V_Cierre_SelectedIndexChanged(object sender, EventArgs e)
    {
        Razon_Ventas();
    }
    protected void V_Consultar_Datos_Cliente()
    {
        try
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Clientes.Cuenta_Cliente = V_Cuenta_Cliente.Text;
            dt = Obj_Neg_Clientes.Consulta_Cliente(Obj_Entidad_Clientes.Cuenta_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                V_Nombre_Cliente.Text = dt.Tables[0].Rows[0]["NOMBRE"].ToString();
                V_Apellido_Cliente.Text = dt.Tables[0].Rows[0]["APELLIDO"].ToString();
                V_Direccion_de_Instalacion.Text = dt.Tables[0].Rows[0]["DIR_INSTALACION"].ToString();
                V_Direccion_de_Correspondencia.Text = dt.Tables[0].Rows[0]["DIR_CORRESPONDENCIA"].ToString();
                V_Correo_Electronico.Text = dt.Tables[0].Rows[0]["CORREO"].ToString();
                V_Nombre_Comunidad.Text = dt.Tables[0].Rows[0]["NOMBRE_COMUNIDAD"].ToString();
                V_Estrato.Text = dt.Tables[0].Rows[0]["ESTRATO"].ToString();
                V_Tipo_Cliente.Text = dt.Tables[0].Rows[0]["DESCRIPCION"].ToString();
                V_Movil_Portpago.Text = dt.Tables[0].Rows[0]["TELEFONO_CONV"].ToString();
                Tipo_Contacto_Cierre();
                Cierre_Ventas();
                Razon_Ventas();

                //Tipo_Contacto_Fraude();
                //Cierre_Fraude();
                //Razon_Fraude();

            }
            else
            {
                string script5 = "mensaje5();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje5", script5, true);
                Limpiar_Ventas();

            }
        }
        catch (Exception esc)
        { throw new Exception("Error al Consultar la cuenta del cliente", esc); }

    }
    protected void Tipo_Contacto_Cierre()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion = 5;
        dt = Obj_Neg_Arbol_Outbound.Oubound_Tipo_Contacto(Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion);

        if (dt.Tables[0].Rows.Count > 0)
        {

            V_Tipo_de_Contacto.DataSource = dt;
            V_Tipo_de_Contacto.DataTextField = "TIPO_CONTACTO";
            V_Tipo_de_Contacto.DataValueField = "ID_TIPO_CONTACTO";
            V_Tipo_de_Contacto.DataBind();
        }
        else
        {
            F_Tipo_Contacto.Items.Clear();
        }
    }
    protected void Cierre_Ventas()
    {

        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto = Convert.ToInt16(V_Tipo_de_Contacto.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Cierre(Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto);

        if (dt.Tables[0].Rows.Count > 0)
        {

            V_Cierre.DataSource = dt;
            V_Cierre.DataTextField = "CIERRE";
            V_Cierre.DataValueField = "ID_CIERRE";
            V_Cierre.DataBind();
        }
        else
        {
            F_Cierre.Items.Clear();
        }
    }
    protected void Razon_Ventas()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Cierre = Convert.ToInt16(V_Cierre.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Razon(Obj_Entidad_Arbol_Outbound.Id_Cierre);

        if (dt.Tables[0].Rows.Count > 0)
        {

            V_Razon.DataSource = dt;
            V_Razon.DataTextField = "RAZON";
            V_Razon.DataValueField = "ID_RAZON";
            V_Razon.DataBind();
        }
        else
        {
            F_Razon.Items.Clear();
        }
    }
    protected void Controles_A_Objeto_Ventas()
    {
        Obj_Entidad_Ventas.Usuario_Gestion = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Ventas.Aliado_Gestion = Session["Aliado_Usuario"].ToString();
        Obj_Entidad_Ventas.Cuenta_Cliente = Convert.ToDouble(V_Cuenta_Cliente.Text);
        Obj_Entidad_Ventas.Nombre_Cliente = V_Nombre_Cliente.Text;
        Obj_Entidad_Ventas.Apellido_Cliente = V_Apellido_Cliente.Text;
        Obj_Entidad_Ventas.Direccion_Instalacion = V_Direccion_de_Instalacion.Text;
        Obj_Entidad_Ventas.Direccion_Correspondencia = V_Direccion_de_Correspondencia.Text;
        Obj_Entidad_Ventas.Correo_Electronico = V_Correo_Electronico.Text;
        Obj_Entidad_Ventas.Telefono_1 = Convert.ToDouble(V_Telefono_1.Text);
        Obj_Entidad_Ventas.Telefono_2 = Convert.ToDouble(V_Telefono_2.Text);
        Obj_Entidad_Ventas.Telefono_3 = Convert.ToDouble(V_Telefono_3.Text);
        Obj_Entidad_Ventas.Movil_1 = Convert.ToDouble(V_Movil_1.Text);
        Obj_Entidad_Ventas.Movil_2 = Convert.ToDouble(V_Movil_2.Text);
        Obj_Entidad_Ventas.Paquete_Actual = V_Paquete_Actual.Text;
        Obj_Entidad_Ventas.Tipo_Contacto = Convert.ToString(V_Tipo_de_Contacto.SelectedItem);
        Obj_Entidad_Ventas.Cierre = Convert.ToString(V_Cierre.SelectedItem);
        Obj_Entidad_Ventas.Razon = Convert.ToString(V_Razon.SelectedItem);
        if (CheckBox1.Checked == true) { Obj_Entidad_Ventas.Atributo_1 = 1; } else { Obj_Entidad_Ventas.Atributo_1 = 0; }
        if (CheckBox2.Checked == true) { Obj_Entidad_Ventas.Atributo_2 = 1; } else { Obj_Entidad_Ventas.Atributo_2 = 0; }
        if (CheckBox3.Checked == true) { Obj_Entidad_Ventas.Atributo_3 = 1; } else { Obj_Entidad_Ventas.Atributo_3 = 0; }
        Obj_Entidad_Ventas.Atributo_4 = 0;
        Obj_Entidad_Ventas.Atributo_5 = 0;
        Obj_Entidad_Ventas.Atributo_6 = 0;
        Obj_Entidad_Ventas.Atributo_7 = 0;
        Obj_Entidad_Ventas.Atributo_8 = 0;
        Obj_Entidad_Ventas.Atributo_9 = 0;
        Obj_Entidad_Ventas.Atributo_10 = 0;
        Obj_Entidad_Ventas.Observaciones = V_Observaciones.Text.ToUpper();
    }
    protected void Guardar_Cliente_Ventas()
    {
        Controles_A_Objeto_Ventas();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Ventas.abcVentas("INSERTAR", Obj_Entidad_Ventas);
        if (Guardar_Datos != -1)
        {
            Registrar_Transaccion_Ventas();
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj1", script1, true);

        }
        else
        {
            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj2", script2, true);

        }

    }
    protected void Actualizar_Cliente_Ventas()
    {
        Controles_A_Objeto_Ventas();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Ventas.abcVentas("ACTUALIZAR", Obj_Entidad_Ventas);
        if (Guardar_Datos != -1)
        {
            Registrar_Transaccion_Ventas();
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj1", script1, true);

        }
        else
        {
            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj2", script2, true);

        }

    }
    protected void V_Guardar_Click(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true || CheckBox2.Checked == true || CheckBox3.Checked == true)
        {
            V_Guardar.Enabled = false;
            DataSet dt = new DataSet();
            Obj_Entidad_Ventas.Cuenta_Cliente = Convert.ToDouble(V_Cuenta_Cliente.Text);
            dt = Obj_Neg_Ventas.Consulta_Cliente_Venta_Gestionado(Obj_Entidad_Ventas.Cuenta_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                Actualizar_Cliente_Ventas();
            }
            else
            {
                Guardar_Cliente_Ventas();
            }
        }
        else
        {
            string script9 = "mensaje9();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj9", script9, true);
        }
    }
    protected void Registrar_Transaccion_Ventas()
    {
        Controles_A_Objeto_Ventas();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Ventas.abcLog_Ventas("INSERTAR", Obj_Entidad_Ventas);
        if (Guardar_Datos != -1)
        {
            Limpiar_Ventas();
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj1", script1, true);
        }
        else
        {
            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj2", script2, true);

        }
    }
    protected void Limpiar_Ventas()
    {
        var LIMPIAR = "";
        V_Cuenta_Cliente.Text = LIMPIAR;
        V_Nombre_Cliente.Text = LIMPIAR;
        V_Apellido_Cliente.Text = LIMPIAR;
        V_Direccion_de_Instalacion.Text = LIMPIAR;
        V_Direccion_de_Correspondencia.Text = LIMPIAR;
        V_Telefono_1.Text = LIMPIAR;
        V_Telefono_2.Text = LIMPIAR;
        V_Telefono_3.Text = LIMPIAR;
        V_Movil_1.Text = LIMPIAR;
        V_Movil_2.Text = LIMPIAR;
        V_Nombre_Comunidad.Text = LIMPIAR;
        V_Correo_Electronico.Text = LIMPIAR;
        V_Estrato.Text = LIMPIAR;
        V_Paquete_Actual.Text = LIMPIAR;
        V_Tipo_de_Contacto.Items.Clear();
        V_Tipo_de_Contacto.ClearSelection();
        V_Movil_Portpago.Text = LIMPIAR;
        V_Cierre.Items.Clear();
        V_Cierre.ClearSelection();
        V_Razon.Items.Clear();
        V_Razon.ClearSelection();
        CheckBox1.Checked = false;
        CheckBox2.Checked = false;
        CheckBox3.Checked = false;
        V_Observaciones.Text = LIMPIAR;
        V_Guardar.Enabled = true;
    }
    protected void CV_Cuenta_Cliente_TextChanged(object sender, EventArgs e)
    {
        try
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Claro_Video.Cuenta_Cliente = Convert.ToDouble(CV_Cuenta_Cliente.Text);
            dt = Obj_Neg_Claro_Video.Consulta_Temporal_Cuentas(Obj_Entidad_Claro_Video.Cuenta_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                if (dt.Tables[0].Rows[0]["TELEFONO_1"].ToString() == "") { CV_Telefono_1.Text = "0"; } else { CV_Telefono_1.Text = dt.Tables[0].Rows[0]["TELEFONO_1"].ToString(); }
                if (dt.Tables[0].Rows[0]["TELEFONO_2"].ToString() == "") { CV_Telefono_2.Text = "0"; } else { CV_Telefono_2.Text = dt.Tables[0].Rows[0]["TELEFONO_2"].ToString(); }
                if (dt.Tables[0].Rows[0]["TELEFONO_3"].ToString() == "") { CV_Telefono_3.Text = "0"; } else { CV_Telefono_3.Text = dt.Tables[0].Rows[0]["TELEFONO_3"].ToString(); }
                if (dt.Tables[0].Rows[0]["MOVIL_1"].ToString() == "") { CV_Movil_1.Text = "0"; } else { CV_Movil_1.Text = dt.Tables[0].Rows[0]["MOVIL_1"].ToString(); }
                if (dt.Tables[0].Rows[0]["MOVIL_2"].ToString() == "") { CV_Movil_2.Text = "0"; } else { CV_Movil_2.Text = dt.Tables[0].Rows[0]["MOVIL_2"].ToString(); }
                CV_Paquete_Actual.Text = dt.Tables[0].Rows[0]["PAQUETE_ACTUAL"].ToString();
                CV_Operacion.Text = dt.Tables[0].Rows[0]["OPERACION"].ToString();
                CV_Consultar_Datos_Cliente();
            }
            else
            {
                string script5 = "mensaje5();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje5", script5, true);
                Limpiar_Claro_Video();

            }
        }
        catch (Exception esc)
        { throw new Exception("Error al Consultar la cuenta del cliente", esc); }
    }
    protected void CV_Consultar_Datos_Cliente()
    {
        try
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Clientes.Cuenta_Cliente = CV_Cuenta_Cliente.Text;
            dt = Obj_Neg_Clientes.Consulta_Cliente(Obj_Entidad_Clientes.Cuenta_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                CV_Nombre_Cliente.Text = dt.Tables[0].Rows[0]["NOMBRE"].ToString();
                CV_Apellido_Cliente.Text = dt.Tables[0].Rows[0]["APELLIDO"].ToString();
                CV_Direccion_de_Instalacion.Text = dt.Tables[0].Rows[0]["DIR_INSTALACION"].ToString();
                CV_Direccion_de_Correspondencia.Text = dt.Tables[0].Rows[0]["DIR_CORRESPONDENCIA"].ToString();
                CV_Correo_Electronico.Text = dt.Tables[0].Rows[0]["CORREO"].ToString();
                CV_Nombre_Comunidad.Text = dt.Tables[0].Rows[0]["NOMBRE_COMUNIDAD"].ToString();
                CV_Estrato.Text = dt.Tables[0].Rows[0]["ESTRATO"].ToString();
                CV_Tipo_Cliente.Text = dt.Tables[0].Rows[0]["DESCRIPCION"].ToString();
                CV_Movil_Portpago.Text = dt.Tables[0].Rows[0]["TELEFONO_CONV"].ToString();
                Tipo_Contacto_Claro_Video();
                Gestion_Claro_Video();
                Cierre_Claro_Video();
                Razon_Claro_Video();

            }
            else
            {
                string script5 = "mensaje5();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje5", script5, true);
                Limpiar_Claro_Video();

            }
        }
        catch (Exception esc)
        { throw new Exception("Error al Consultar la cuenta del cliente", esc); }

    }
    protected void Tipo_Contacto_Claro_Video()
    {

        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion = 8;
        dt = Obj_Neg_Arbol_Outbound.Oubound_Tipo_Contacto(Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion);

        if (dt.Tables[0].Rows.Count > 0)
        {
            CV_Tipo_Contacto.DataSource = dt;
            CV_Tipo_Contacto.DataTextField = "TIPO_CONTACTO";
            CV_Tipo_Contacto.DataValueField = "ID_TIPO_CONTACTO";
            CV_Tipo_Contacto.DataBind();
        }
        else
        {
            CV_Tipo_Contacto.Items.Clear();
        }
    }
    protected void Gestion_Claro_Video()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto = Convert.ToInt16(CV_Tipo_Contacto.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Cierre(Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto);

        if (dt.Tables[0].Rows.Count > 0)
        {

            CV_Tipo_Gestion.DataSource = dt;
            CV_Tipo_Gestion.DataTextField = "CIERRE";
            CV_Tipo_Gestion.DataValueField = "ID_CIERRE";
            CV_Tipo_Gestion.DataBind();
        }
        else
        {
            CV_Tipo_Gestion.Items.Clear();
        }
    }
    protected void Cierre_Claro_Video()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Cierre = Convert.ToInt16(CV_Tipo_Gestion.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Razon(Obj_Entidad_Arbol_Outbound.Id_Cierre);

        if (dt.Tables[0].Rows.Count > 0)
        {
            CV_Tipo_Cierre.DataSource = dt;
            CV_Tipo_Cierre.DataTextField = "RAZON";
            CV_Tipo_Cierre.DataValueField = "ID_RAZON";
            CV_Tipo_Cierre.DataBind();
        }
        else
        {
            CV_Tipo_Cierre.Items.Clear();
        }
    }
    protected void Razon_Claro_Video()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Causa = Convert.ToInt16(CV_Tipo_Cierre.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Causa(Obj_Entidad_Arbol_Outbound.Id_Causa);

        if (dt.Tables[0].Rows.Count > 0)
        {
            CV_Tipo_Razon.DataSource = dt;
            CV_Tipo_Razon.DataTextField = "CAUSA";
            CV_Tipo_Razon.DataValueField = "ID_CAUSA";
            CV_Tipo_Razon.DataBind();
        }
        else
        {
            CV_Tipo_Razon.Items.Clear();
        }
    }
    protected void CV_Tipo_Contacto_SelectedIndexChanged(object sender, EventArgs e)
    {
        Gestion_Claro_Video();
        Cierre_Claro_Video();
        Razon_Claro_Video();

    }
    protected void CV_Tipo_Gestion_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cierre_Claro_Video();
        Razon_Claro_Video();

    }
    protected void CV_Tipo_Cierre_SelectedIndexChanged(object sender, EventArgs e)
    {
        Razon_Claro_Video();

    }
    protected void CV_Guardar_Click(object sender, EventArgs e)
    {
        if (CheckBox4.Checked == true || CheckBox5.Checked == true)
        {
            CV_Guardar.Enabled = false;
            DataSet dt = new DataSet();
            Obj_Entidad_Claro_Video.Cuenta_Cliente = Convert.ToDouble(CV_Cuenta_Cliente.Text);
            dt = Obj_Neg_Claro_Video.Consulta_Cliente_Claro_Video_Gestionado(Obj_Entidad_Claro_Video.Cuenta_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                Actualizar_Cliente_Claro_Video();
            }
            else
            {
                Guardar_Cliente_Claro_Video();
            }
        }
        else
        {
            string script9 = "mensaje9();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj9", script9, true);
        }
    }
    protected void Guardar_Cliente_Claro_Video()
    {
        Controles_A_Objeto_Claro_Video();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Claro_Video.abcClaro_Video("INSERTAR", Obj_Entidad_Claro_Video);
        if (Guardar_Datos != -1)
        {
            Registrar_Transaccion_Claro_Video();
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj1", script1, true);

        }
        else
        {
            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj2", script2, true);

        }

    }
    protected void Actualizar_Cliente_Claro_Video()
    {
        Controles_A_Objeto_Claro_Video();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Claro_Video.abcClaro_Video("ACTUALIZAR", Obj_Entidad_Claro_Video);
        if (Guardar_Datos != -1)
        {
            Registrar_Transaccion_Claro_Video();
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj1", script1, true);

        }
        else
        {
            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj2", script2, true);

        }

    }
    protected void Controles_A_Objeto_Claro_Video()
    {
        Obj_Entidad_Claro_Video.Usuario_Gestion = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Claro_Video.Aliado_Gestion = Session["Aliado_Usuario"].ToString();
        Obj_Entidad_Claro_Video.Nombre_Usuario_Gestion = Session["Nombre_Usuario"].ToString();
        Obj_Entidad_Claro_Video.Cuenta_Cliente = Convert.ToDouble(CV_Cuenta_Cliente.Text);
        Obj_Entidad_Claro_Video.Operacion_Gestion = CV_Operacion.Text;
        Obj_Entidad_Claro_Video.Nombre_Cliente = CV_Nombre_Cliente.Text;
        Obj_Entidad_Claro_Video.Apellido_Cliente = CV_Apellido_Cliente.Text;
        Obj_Entidad_Claro_Video.Direccion_Instalacion = CV_Direccion_de_Instalacion.Text;
        Obj_Entidad_Claro_Video.Direccion_Correspondencia = CV_Direccion_de_Correspondencia.Text;
        Obj_Entidad_Claro_Video.Correo_Electronico = CV_Correo_Electronico.Text;
        Obj_Entidad_Claro_Video.Telefono_1 = Convert.ToDouble(CV_Telefono_1.Text);
        Obj_Entidad_Claro_Video.Telefono_2 = Convert.ToDouble(CV_Telefono_2.Text);
        Obj_Entidad_Claro_Video.Telefono_3 = Convert.ToDouble(CV_Telefono_3.Text);
        Obj_Entidad_Claro_Video.Movil_1 = Convert.ToDouble(CV_Movil_1.Text);
        Obj_Entidad_Claro_Video.Movil_2 = Convert.ToDouble(CV_Movil_2.Text);
        Obj_Entidad_Claro_Video.Paquete_Actual = CV_Paquete_Actual.Text;
        Obj_Entidad_Claro_Video.Tipo_Contacto = Convert.ToString(CV_Tipo_Contacto.SelectedItem);
        Obj_Entidad_Claro_Video.Tipo_Gestion = Convert.ToString(CV_Tipo_Gestion.SelectedItem);
        Obj_Entidad_Claro_Video.Cierre = Convert.ToString(CV_Tipo_Cierre.SelectedItem);
        Obj_Entidad_Claro_Video.Razon = Convert.ToString(CV_Tipo_Razon.SelectedItem);
        if (CheckBox4.Checked == true) { Obj_Entidad_Claro_Video.Atributo_1 = 1; } else { Obj_Entidad_Claro_Video.Atributo_1 = 0; }
        if (CheckBox5.Checked == true) { Obj_Entidad_Claro_Video.Atributo_2 = 1; } else { Obj_Entidad_Claro_Video.Atributo_2 = 0; }
        Obj_Entidad_Claro_Video.Atributo_4 = 0;
        Obj_Entidad_Claro_Video.Atributo_5 = 0;
        Obj_Entidad_Claro_Video.Atributo_6 = 0;
        Obj_Entidad_Claro_Video.Atributo_7 = 0;
        Obj_Entidad_Claro_Video.Atributo_8 = 0;
        Obj_Entidad_Claro_Video.Atributo_9 = 0;
        Obj_Entidad_Claro_Video.Atributo_10 = 0;
        Obj_Entidad_Claro_Video.Observaciones = CV_Observaciones.Text.ToUpper();

    }
    protected void Registrar_Transaccion_Claro_Video()
    {
        Controles_A_Objeto_Claro_Video();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Claro_Video.abcLogClaro_Video("INSERTAR", Obj_Entidad_Claro_Video);
        if (Guardar_Datos != -1)
        {
            Limpiar_Claro_Video();
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj1", script1, true);
        }
        else
        {
            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj2", script2, true);

        }
    }
    protected void Limpiar_Claro_Video()
    {
        var LIMPIAR = "";
        CV_Cuenta_Cliente.Text = LIMPIAR;
        CV_Nombre_Cliente.Text = LIMPIAR;
        CV_Apellido_Cliente.Text = LIMPIAR;
        CV_Direccion_de_Instalacion.Text = LIMPIAR;
        CV_Direccion_de_Correspondencia.Text = LIMPIAR;
        CV_Telefono_1.Text = LIMPIAR;
        CV_Telefono_2.Text = LIMPIAR;
        CV_Telefono_3.Text = LIMPIAR;
        CV_Movil_1.Text = LIMPIAR;
        CV_Movil_2.Text = LIMPIAR;
        CV_Nombre_Comunidad.Text = LIMPIAR;
        CV_Correo_Electronico.Text = LIMPIAR;
        CV_Estrato.Text = LIMPIAR;
        CV_Tipo_Cliente.Text = LIMPIAR;
        CV_Paquete_Actual.Text = LIMPIAR;
        CV_Tipo_Contacto.Items.Clear();
        CV_Tipo_Contacto.ClearSelection();
        CV_Tipo_Gestion.Items.Clear();
        CV_Tipo_Gestion.ClearSelection();
        CV_Movil_Portpago.Text = LIMPIAR;
        CV_Tipo_Cierre.Items.Clear();
        CV_Tipo_Cierre.ClearSelection();
        CV_Tipo_Razon.Items.Clear();
        CV_Tipo_Razon.ClearSelection();
        CheckBox4.Checked = false;
        CheckBox5.Checked = false;
        CV_Observaciones.Text = LIMPIAR;
        CV_Guardar.Enabled = true;
    }
    protected void Controles_A_Objeto_Reincidencias()
    {
        Obj_Entidad_Reincidencias.Usuario_Gestion = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Reincidencias.Nombre_Usuario_Gestion = Session["Nombre_Usuario"].ToString();
        Obj_Entidad_Reincidencias.Aliado_Gestion = Session["Aliado_Usuario"].ToString();
        Obj_Entidad_Reincidencias.Linea_Gestion = Session["Nombre_Linea_Usuario"].ToString();
        Obj_Entidad_Reincidencias.Cuenta_Cliente = Convert.ToDouble(R_Cuenta_Cliente.Text);
        Obj_Entidad_Reincidencias.Nombre_Cliente = R_Nombre_Cliente.Text;
        Obj_Entidad_Reincidencias.Apellido_Cliente = R_Apellido.Text;
        Obj_Entidad_Reincidencias.Direccion_Instalacion = R_Direccion_Instalacion.Text;
        Obj_Entidad_Reincidencias.Direccion_Correspondencia = R_Direccion_Corres.Text;
        Obj_Entidad_Reincidencias.Correo_Actual = R_Correo.Text;
        Obj_Entidad_Reincidencias.Telefono_1 = Convert.ToDouble(R_Telefono_1.Text);
        Obj_Entidad_Reincidencias.Telefono_2 = Convert.ToDouble(R_Telefono_2.Text);
        Obj_Entidad_Reincidencias.Telefono_3 = Convert.ToDouble(R_Telefono_3.Text);
        Obj_Entidad_Reincidencias.Movil_1 = Convert.ToDouble(R_celular_1.Text);
        Obj_Entidad_Reincidencias.Movil_2 = Convert.ToDouble(R_celular_2.Text);
        Obj_Entidad_Reincidencias.Paquete_Actual = R_Paquete_Actual.Text;
        Obj_Entidad_Reincidencias.Tipo_Contacto = Convert.ToString(R_Tipo_Contacto.SelectedItem);
        Obj_Entidad_Reincidencias.Gestion = Convert.ToString(R_Tipo_Gestion.SelectedItem);
        Obj_Entidad_Reincidencias.Cierre = Convert.ToString(R_Cierre.SelectedItem);
        Obj_Entidad_Reincidencias.Razon = Convert.ToString(R_Razon.SelectedItem);
        Obj_Entidad_Reincidencias.Motivo_Reincidencia = R_Motivo_Reincidencia.Text;
        Obj_Entidad_Reincidencias.Ofrecimiento_1 = R_T_Ofrecimiento_1.Text;
        Obj_Entidad_Reincidencias.Ofrecimiento_2 = R_T_Ofrecimiento_2.Text;
        Obj_Entidad_Reincidencias.Ofrecimiento_3 = R_T_Ofrecimiento_3.Text;
        if (CheckBox6.Checked == true) { Obj_Entidad_Reincidencias.Atributo_1 = 1; } else if(CheckBox9.Checked == true) { Obj_Entidad_Reincidencias.Atributo_1 = 0; }
        Obj_Entidad_Reincidencias.Observaciones = R_Observaciones.Text;
    }

    protected void R_Cuenta_Cliente_TextChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Reincidencias.Cuenta_Cliente = Convert.ToDouble( R_Cuenta_Cliente.Text);
        dt = Obj_Neg_Reincidencias.Consulta_Temporal_Cuentas(Obj_Entidad_Reincidencias.Cuenta_Cliente);
        if (dt.Tables[0].Rows.Count > 0)
        {
            R_Motivo_Reincidencia.Text = dt.Tables[0].Rows[0]["MOTIVO_REINCIDENCIA"].ToString();
            R_T_Ofrecimiento_1.Text = dt.Tables[0].Rows[0]["OFRECIMIENTO_1"].ToString();
            R_T_Ofrecimiento_2.Text = dt.Tables[0].Rows[0]["OFRECIMIENTO_2"].ToString();
            R_T_Ofrecimiento_3.Text = dt.Tables[0].Rows[0]["OFRECIMIENTO_3"].ToString();
            R_Consultar_Datos_Clientes();
        }
        else
        {
            string script5 = "mensaje5();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje5", script5, true);
            Limpiar_Reincidencias();
        }
    }

    protected void R_Consultar_Datos_Clientes()
    {

        DataSet dt = new DataSet();
        Obj_Entidad_Clientes.Cuenta_Cliente = R_Cuenta_Cliente.Text;
        dt = Obj_Neg_Clientes.Consulta_Cliente(Obj_Entidad_Clientes.Cuenta_Cliente);

        if (dt.Tables[0].Rows.Count > 0)
        {
            R_Nombre_Cliente.Text = dt.Tables[0].Rows[0]["NOMBRE"].ToString();
            R_Apellido.Text = dt.Tables[0].Rows[0]["APELLIDO"].ToString();

            if (dt.Tables[0].Rows[0]["TELEFONO_TELMEX"].ToString() == "") { R_Telefono_Telmex.Text = "0"; } else { R_Telefono_Telmex.Text = dt.Tables[0].Rows[0]["TELEFONO_TELMEX"].ToString(); }
            if (dt.Tables[0].Rows[0]["TELEFONO_1"].ToString() == "") { R_Telefono_1.Text = "0"; } else { R_Telefono_1.Text = dt.Tables[0].Rows[0]["TELEFONO_1"].ToString(); }
            if (dt.Tables[0].Rows[0]["TELEFONO_2"].ToString() == "") { R_Telefono_2.Text = "0"; } else { R_Telefono_2.Text = dt.Tables[0].Rows[0]["TELEFONO_2"].ToString(); }
            if (dt.Tables[0].Rows[0]["TELEFONO_3"].ToString() == "") { R_Telefono_3.Text = "0"; } else { R_Telefono_3.Text = dt.Tables[0].Rows[0]["TELEFONO_3"].ToString(); }
            R_Direccion_Instalacion.Text = dt.Tables[0].Rows[0]["DIR_INSTALACION"].ToString();
            R_Direccion_Corres.Text = dt.Tables[0].Rows[0]["DIR_CORRESPONDENCIA"].ToString();
            if (dt.Tables[0].Rows[0]["CELULAR_1"].ToString() == "") { R_celular_1.Text = "0"; } else { R_celular_1.Text = dt.Tables[0].Rows[0]["CELULAR_1"].ToString(); }
            if (dt.Tables[0].Rows[0]["CELULAR_2"].ToString() == "") { R_celular_2.Text = "0"; } else { R_celular_2.Text = dt.Tables[0].Rows[0]["CELULAR_2"].ToString(); }
            R_Ciudad.Text = dt.Tables[0].Rows[0]["NOMBRE_COMUNIDAD"].ToString();
            R_Correo.Text = dt.Tables[0].Rows[0]["CORREO"].ToString();
            R_Estrato.Text = dt.Tables[0].Rows[0]["ESTRATO"].ToString();
            R_Tipo_Cliente.Text = dt.Tables[0].Rows[0]["TIPO_CLIENTE"].ToString();
            R_Paquete_Actual.Text = dt.Tables[0].Rows[0]["PRODUCTOS"].ToString();
            if (dt.Tables[0].Rows[0]["TELEFONO_CONV"].ToString() == "") { R_Movil_Postpago.Text = "0"; } else { R_Movil_Postpago.Text = dt.Tables[0].Rows[0]["TELEFONO_CONV"].ToString(); }
            Tipo_Contacto_Reincidencia();
            Gestion_Reincidencia();
            Cierre_Reincidencia();
            Razon_Reincidencia();
        }
        else
        {
            string script5 = "mensaje5();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje5", script5, true);
            Limpiar_Reincidencias();

        }


    }
    protected void Tipo_Contacto_Reincidencia()
    {

        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion = 4;
        dt = Obj_Neg_Arbol_Outbound.Oubound_Tipo_Contacto(Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion);

        if (dt.Tables[0].Rows.Count > 0)
        {
            R_Tipo_Contacto.DataSource = dt;
            R_Tipo_Contacto.DataTextField = "TIPO_CONTACTO";
            R_Tipo_Contacto.DataValueField = "ID_TIPO_CONTACTO";
            R_Tipo_Contacto.DataBind();
        }
        else
        {
            R_Tipo_Contacto.Items.Clear();
        }
    }
    protected void Gestion_Reincidencia()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto = Convert.ToInt16(R_Tipo_Contacto.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Cierre(Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto);

        if (dt.Tables[0].Rows.Count > 0)
        {

            R_Tipo_Gestion.DataSource = dt;
            R_Tipo_Gestion.DataTextField = "CIERRE";
            R_Tipo_Gestion.DataValueField = "ID_CIERRE";
            R_Tipo_Gestion.DataBind();
        }
        else
        {
            R_Tipo_Gestion.Items.Clear();
        }
    }
    protected void Cierre_Reincidencia()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Cierre = Convert.ToInt16(R_Tipo_Gestion.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Razon(Obj_Entidad_Arbol_Outbound.Id_Cierre);

        if (dt.Tables[0].Rows.Count > 0)
        {
            R_Cierre.DataSource = dt;
            R_Cierre.DataTextField = "RAZON";
            R_Cierre.DataValueField = "ID_RAZON";
            R_Cierre.DataBind();
        }
        else
        {
            R_Cierre.Items.Clear();
        }
    }
    protected void Razon_Reincidencia()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Causa = Convert.ToInt16(R_Cierre.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Causa(Obj_Entidad_Arbol_Outbound.Id_Causa);

        if (dt.Tables[0].Rows.Count > 0)
        {
            R_Razon.DataSource = dt;
            R_Razon.DataTextField = "CAUSA";
            R_Razon.DataValueField = "ID_CAUSA";
            R_Razon.DataBind();
        }
        else
        {
            R_Razon.Items.Clear();
        }
    }
    protected void R_Tipo_Contacto_SelectedIndexChanged(object sender, EventArgs e)
    {
        Gestion_Reincidencia();
        Cierre_Reincidencia();
        Razon_Reincidencia();

    }
    protected void R_Tipo_Gestion_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cierre_Reincidencia();
        Razon_Reincidencia();

    }
    protected void R_Tipo_Cierre_SelectedIndexChanged(object sender, EventArgs e)
    {
        Razon_Reincidencia();

    }
    protected void Limpiar_Reincidencias()
    {
        var LIMPIAR = "";
        R_Cuenta_Cliente.Text = LIMPIAR;
        R_Nombre_Cliente.Text = LIMPIAR;
        R_Apellido.Text = LIMPIAR;
        R_Direccion_Instalacion.Text = LIMPIAR;
        R_Direccion_Corres.Text = LIMPIAR;
        R_Telefono_1.Text = LIMPIAR;
        R_Telefono_2.Text = LIMPIAR;
        R_Telefono_3.Text = LIMPIAR;
        R_Telefono_Telmex.Text = LIMPIAR;
        R_celular_1.Text = LIMPIAR;
        R_celular_2.Text = LIMPIAR;
        R_Ciudad.Text = LIMPIAR;
        R_Correo.Text = LIMPIAR;
        R_Estrato.Text = LIMPIAR;
        R_Tipo_Cliente.Text = LIMPIAR;
        R_Paquete_Actual.Text = LIMPIAR;
        R_Movil_Postpago.Text = LIMPIAR;
        R_Motivo_Reincidencia.Text = LIMPIAR;
        R_T_Ofrecimiento_1.Text = LIMPIAR;
        R_T_Ofrecimiento_2.Text = LIMPIAR;
        R_T_Ofrecimiento_3.Text = LIMPIAR;
        R_Tipo_Contacto.Items.Clear();
        R_Tipo_Contacto.ClearSelection();
        R_Tipo_Gestion.Items.Clear();
        R_Tipo_Gestion.ClearSelection();
        R_Cierre.Items.Clear();
        R_Cierre.ClearSelection();
        R_Razon.Items.Clear();
        R_Razon.ClearSelection();
        CheckBox6.Checked = false;
        CheckBox9.Checked = false;
        R_Observaciones.Text = LIMPIAR;
        R_Guardar.Enabled = true;
    }
    protected void R_Guardar_Click(object sender, EventArgs e)
    {
        if (R_Cuenta_Cliente.Text != "")
        {
            if ((CheckBox6.Checked == true && CheckBox9.Checked == true) || (CheckBox6.Checked == false && CheckBox9.Checked == false))
            {
                string script10 = "mensaje10();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje10", script10, true);
            }
            else
            {
                R_Guardar.Enabled = false;
                DataSet dt = new DataSet();
                Obj_Entidad_Reincidencias.Cuenta_Cliente = Convert.ToDouble(R_Cuenta_Cliente.Text);
                dt = Obj_Neg_Reincidencias.Consulta_Cliente_Reincidencias_Gestionado(Obj_Entidad_Reincidencias.Cuenta_Cliente);

                if (dt.Tables[0].Rows.Count > 0)
                {
                    Actualizar_Cliente_Reincidencias();
                }
                else
                {
                    Guardar_Cliente_Reincidencias();
                }
            }
        }
        else {
            string script9 = "mensaje6();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje6", script9, true);
        }
    }

    protected void Guardar_Cliente_Reincidencias()
    {
        Controles_A_Objeto_Reincidencias();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Reincidencias.abc_Reincidencias("INSERTAR", Obj_Entidad_Reincidencias);
        if (Guardar_Datos != -1)
        {
            Registrar_Transaccion_Reincidencias();
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj1", script1, true);

        }
        else
        {
            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj2", script2, true);

        }

    }
    protected void Actualizar_Cliente_Reincidencias()
    {
        Controles_A_Objeto_Reincidencias();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Reincidencias.abc_Reincidencias("ACTUALIZAR", Obj_Entidad_Reincidencias);
        if (Guardar_Datos != -1)
        {
            Registrar_Transaccion_Reincidencias();
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj1", script1, true);

        }
        else
        {
            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj2", script2, true);

        }

    }
    protected void Registrar_Transaccion_Reincidencias()
    {
        Controles_A_Objeto_Reincidencias();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Reincidencias.abcLog_Reincidencias("INSERTAR", Obj_Entidad_Reincidencias);
        if (Guardar_Datos != -1)
        {
            Limpiar_Reincidencias();
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj1", script1, true);
        }
        else
        {
            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj2", script2, true);

        }
    }


    protected void D_Cuenta_Cliente_TextChanged(object sender, EventArgs e)
    {
        try
        {
            DataSet dt = new DataSet();
            obj_Entidad_Docsis_Overlap.Cuenta_Cliente = Convert.ToDouble(D_Cuenta_Cliente.Text);
            dt = Obj_Neg_Docsis_Overlap.Consulta_Temporal_Cuentas(obj_Entidad_Docsis_Overlap.Cuenta_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                if (dt.Tables[0].Rows[0]["TELEFONO_1"].ToString() == "") { D_Telefono_1.Text = "0"; } else { D_Telefono_1.Text = dt.Tables[0].Rows[0]["TELEFONO_1"].ToString(); }
                if (dt.Tables[0].Rows[0]["TELEFONO_2"].ToString() == "") { D_Telefono_2.Text = "0"; } else { D_Telefono_2.Text = dt.Tables[0].Rows[0]["TELEFONO_2"].ToString(); }
                if (dt.Tables[0].Rows[0]["TELEFONO_3"].ToString() == "") { D_Telefono_Telmex.Text = "0"; } else { D_Telefono_Telmex.Text = dt.Tables[0].Rows[0]["TELEFONO_3"].ToString(); }
                if (dt.Tables[0].Rows[0]["MOVIL_1"].ToString() == "") { D_Celular_1.Text = "0"; } else { D_Celular_1.Text = dt.Tables[0].Rows[0]["MOVIL_1"].ToString(); }
                if (dt.Tables[0].Rows[0]["MOVIL_2"].ToString() == "") { D_Celular_2.Text = "0"; } else { D_Celular_2.Text = dt.Tables[0].Rows[0]["MOVIL_2"].ToString(); }
                D_Paquete_Actual.Text = dt.Tables[0].Rows[0]["PAQUETE_ACTUAL"].ToString();
                D_Operacion.Text = dt.Tables[0].Rows[0]["OPERACION"].ToString();
                D_Base.Text = dt.Tables[0].Rows[0]["BASE"].ToString();
                D_Aliado.Text = dt.Tables[0].Rows[0]["ALIADO"].ToString();
                D_Consultar_Datos_Cliente();
                D_ConsultarSeguimientos();
            }
            else
            {
                string script5 = "mensaje5();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje5", script5, true);
                Limpiar_Docsis_Overlap();

            }
        }
        catch (Exception esc)
        { throw new Exception("Error al Consultar la cuenta del cliente de Docsis", esc); }
    }

    private void D_ConsultarSeguimientos()
    {
        DataSet dt = new DataSet();
        obj_Entidad_Docsis_Overlap.Cuenta_Cliente = Convert.ToDouble(D_Cuenta_Cliente.Text);
        dt = Obj_Neg_Docsis_Overlap.Consulta_Cuenta_seguimiento(obj_Entidad_Docsis_Overlap.Cuenta_Cliente);
        if (dt.Tables[0].Rows.Count > 0)
        {
            GV_Seguimientos.DataSource = dt.Tables[0];
            GV_Seguimientos.DataBind();
            string script1 = "Casos_Seguimiento();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Casos_Seguimiento", script1, true);
        }
        else
        {
            string script1 = "No_Casos_Seguimiento();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Casos_Seguimiento", script1, true);

        }
    }

    protected void D_Consultar_Datos_Cliente()
    {
        try
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Clientes.Cuenta_Cliente = D_Cuenta_Cliente.Text;
            dt = Obj_Neg_Clientes.Consulta_Cliente(Obj_Entidad_Clientes.Cuenta_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                D_Nombre_Cliente.Text = dt.Tables[0].Rows[0]["NOMBRE"].ToString();
                D_Apellido_Cliente.Text = dt.Tables[0].Rows[0]["APELLIDO"].ToString();
                D_Direccion.Text = dt.Tables[0].Rows[0]["DIR_INSTALACION"].ToString();
                D_Direccion_Corres.Text = dt.Tables[0].Rows[0]["DIR_CORRESPONDENCIA"].ToString();
                D_Correo_Actual.Text = dt.Tables[0].Rows[0]["CORREO"].ToString();
                D_Ciudad.Text = dt.Tables[0].Rows[0]["NOMBRE_COMUNIDAD"].ToString();
                D_Estrato.Text = dt.Tables[0].Rows[0]["ESTRATO"].ToString();
                D_Tipo_Cliente.Text = dt.Tables[0].Rows[0]["DESCRIPCION"].ToString();
                D_Movil_Pospago.Text = dt.Tables[0].Rows[0]["TELEFONO_CONV"].ToString();
                

                Tipo_Contacto_Docsis_Overlap();
                //Gestion_Docsis_Overlap();
                //Cierre_Docsis_Overlap();
                //Razon_Docsis_Overlap();

            }
            else
            {
                string script5 = "mensaje5();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje5", script5, true);
                Limpiar_Docsis_Overlap();

            }
        }
        catch (Exception esc)
        { throw new Exception("Error al Consultar la cuenta del cliente en base cuentas", esc); }

    }
    protected void Tipo_Contacto_Docsis_Overlap()
    {

        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion = 11;
        dt = Obj_Neg_Arbol_Outbound.Oubound_Tipo_Contacto(Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion);

        if (dt.Tables[0].Rows.Count > 0)
        {
            D_Tipo_Contacto.DataSource = dt;
            D_Tipo_Contacto.DataTextField = "TIPO_CONTACTO";
            D_Tipo_Contacto.DataValueField = "ID_TIPO_CONTACTO";
            D_Tipo_Contacto.DataBind();
            D_Tipo_Contacto.Items.Insert(0, "");
        }
        else
        {
            D_Tipo_Contacto.Items.Clear();
        }
    }
    protected void Gestion_Docsis_Overlap()
    {
        if (D_Tipo_Contacto.SelectedValue != "")
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto = Convert.ToInt16(D_Tipo_Contacto.SelectedValue);
            dt = Obj_Neg_Arbol_Outbound.Oubound_Cierre(Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto);
            if (dt.Tables[0].Rows.Count > 0)
            {

                D_Gestion.DataSource = dt;
                D_Gestion.DataTextField = "CIERRE";
                D_Gestion.DataValueField = "ID_CIERRE";
                D_Gestion.DataBind();
                //D_Gestion.Items.Insert(0, "");
            }
            else
            {
                D_Gestion.Items.Clear();
            }
        }
        else
        {
            D_Gestion.Items.Clear();
        }
        
    }
    protected void Cierre_Docsis_Overlap()
    {
        if (D_Gestion.SelectedValue != "")
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Arbol_Outbound.Id_Cierre = Convert.ToInt16(D_Gestion.SelectedValue);
            dt = Obj_Neg_Arbol_Outbound.Oubound_Razon(Obj_Entidad_Arbol_Outbound.Id_Cierre);

            if (dt.Tables[0].Rows.Count > 0)
            {
                D_Cierre.DataSource = dt;
                D_Cierre.DataTextField = "RAZON";
                D_Cierre.DataValueField = "ID_RAZON";
                D_Cierre.DataBind();
                //D_Cierre.Items.Insert(0, "");
            }
            else
            {
                D_Cierre.Items.Clear();
            }
        }
        else
        {
            D_Cierre.Items.Clear();
        }
    }
    protected void Razon_Docsis_Overlap()
    {
        if (D_Cierre.SelectedValue != "")
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Arbol_Outbound.Id_Causa = Convert.ToInt16(D_Cierre.SelectedValue);
            dt = Obj_Neg_Arbol_Outbound.Oubound_Causa(Obj_Entidad_Arbol_Outbound.Id_Causa);

            if (dt.Tables[0].Rows.Count > 0)
            {
                D_Razon.DataSource = dt;
                D_Razon.DataTextField = "CAUSA";
                D_Razon.DataValueField = "ID_CAUSA";
                D_Razon.DataBind();
                //D_Razon.Items.Insert(0, "");
            }
            else
            {
                D_Razon.Items.Clear();
            }
        }
        else
        {
            D_Razon.Items.Clear();
        }
    }

    protected void D_Tipo_Contacto_SelectedIndexChanged(object sender, EventArgs e)
    {
        string script2 = "No_Mostra_Div();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "No_Mostra_Div", script2, true);

        Gestion_Docsis_Overlap();
        Cierre_Docsis_Overlap();
        Razon_Docsis_Overlap();
        D_ConsultarSeguimientos();
    }
    protected void D_Gestion_SelectedIndexChanged(object sender, EventArgs e)
    {
        string script2 = "No_Mostra_Div();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "No_Mostra_Div", script2, true);

        Cierre_Docsis_Overlap();
        Razon_Docsis_Overlap();
    }
    protected void D_Cierre_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Convert.ToString(D_Cierre.SelectedItem) == "SEGUIMIENTO")
        {
            string script1 = "Mostra_Div();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Mostra_Div", script1, true);

        }
        else
        {
            string script2 = "No_Mostra_Div();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "No_Mostra_Div", script2, true);
        }
        Razon_Docsis_Overlap();
        D_ConsultarSeguimientos();
    }
    protected void Limpiar_Docsis_Overlap()
    {
        var LIMPIAR = "";
        D_Cuenta_Cliente.Text = LIMPIAR;
        D_Nombre_Cliente.Text = LIMPIAR;
        D_Apellido_Cliente.Text = LIMPIAR;
        D_Direccion.Text = LIMPIAR;
        D_Direccion_Corres.Text = LIMPIAR;
        D_Telefono_1.Text = LIMPIAR;
        D_Telefono_2.Text = LIMPIAR;
        D_Telefono_Telmex.Text = LIMPIAR;
        D_Celular_1.Text = LIMPIAR;
        D_Celular_2.Text = LIMPIAR;
        D_Ciudad.Text = LIMPIAR;
        D_Correo_Actual.Text = LIMPIAR;
        D_Estrato.Text = LIMPIAR;
        D_Tipo_Cliente.Text = LIMPIAR;
        D_Paquete_Actual.Text = LIMPIAR;
        D_Movil_Pospago.Text = LIMPIAR;
        D_Tipo_Contacto.Items.Clear();
        D_Tipo_Contacto.ClearSelection();
        D_Gestion.Items.Clear();
        D_Gestion.ClearSelection();
        D_Cierre.Items.Clear();
        D_Cierre.ClearSelection();
        D_Razon.Items.Clear();
        D_Razon.ClearSelection();
        D_Observaciones.Text = LIMPIAR;
        D_Guardar.Enabled = true;
        D_Fecha_Seguimiento.Text = LIMPIAR;
        D_Operacion.Text = LIMPIAR;
        D_Base.Text = LIMPIAR;
        D_Aliado.Text = LIMPIAR;
        string script1 = "Borrar_fecha();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "Borrar_fecha", script1, true);
        string script2 = " No_Mostra_Div();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "No_Mostra_Div", script2, true);
        string script3 = " No_Casos_Seguimiento();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "No_Casos_Seguimiento", script3, true);
    }

    protected void D_Guardar_Click(object sender, EventArgs e)
    {
        if (D_Cierre.SelectedValue != "" && D_Tipo_Contacto.SelectedValue != "" && D_Gestion.SelectedValue != "" && D_Razon.SelectedValue != "")
        {
            D_Guardar.Enabled = false;
            DataSet dt = new DataSet();
            obj_Entidad_Docsis_Overlap.Cuenta_Cliente = Convert.ToDouble(D_Cuenta_Cliente.Text);
            dt = Obj_Neg_Docsis_Overlap.Consulta_Cliente_Docsis_Gestionado(obj_Entidad_Docsis_Overlap.Cuenta_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                Actualizar_Cliente_Docsis();
            }
            else
            {
                Guardar_Cliente_Docsis();
            }
        }
        else
        {
            string script1 = "mensaje11();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje11", script1, true);
        }
    }
    protected void Actualizar_Cliente_Docsis()
    {
        Controles_A_Objeto_Docsis();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Docsis_Overlap.abcDocsis_Overlap("ACTUALIZAR", obj_Entidad_Docsis_Overlap);
        if (Guardar_Datos != -1)
        {
            Registrar_Transaccion_Docsis_Overlap();
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj1", script1, true);

        }
        else
        {
            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj2", script2, true);

        }

    }
    protected void Guardar_Cliente_Docsis()
    {
        Controles_A_Objeto_Docsis();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Docsis_Overlap.abcDocsis_Overlap("INSERTAR", obj_Entidad_Docsis_Overlap);
        if (Guardar_Datos != -1)
        {
            Registrar_Transaccion_Docsis_Overlap();
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj1", script1, true);

        }
        else
        {
            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj2", script2, true);

        }
    }
    protected void Controles_A_Objeto_Docsis()
    {
        obj_Entidad_Docsis_Overlap.Usuario_Gestion = Session["Usuario_Logueado"].ToString();
        obj_Entidad_Docsis_Overlap.Aliado_Gestion = Session["Aliado_Usuario"].ToString();
        obj_Entidad_Docsis_Overlap.Nombre_Usuario_Gestion = Session["Nombre_Usuario"].ToString();
        obj_Entidad_Docsis_Overlap.Operacion_Gestion = D_Operacion.Text;
        obj_Entidad_Docsis_Overlap.Nombre_Base = D_Base.Text;
        obj_Entidad_Docsis_Overlap.Cuenta_Cliente = Convert.ToDouble(D_Cuenta_Cliente.Text);
        obj_Entidad_Docsis_Overlap.Nombre_Cliente = D_Nombre_Cliente.Text;
        obj_Entidad_Docsis_Overlap.Apellido_Cliente = D_Apellido_Cliente.Text;
        obj_Entidad_Docsis_Overlap.Direccion_Instalacion = D_Direccion.Text;
        obj_Entidad_Docsis_Overlap.Direccion_Correspondencia = D_Direccion_Corres.Text;
        obj_Entidad_Docsis_Overlap.Correo_Electronico = D_Correo_Actual.Text;
        obj_Entidad_Docsis_Overlap.Telefono_1 = Convert.ToDouble(D_Telefono_1.Text);
        obj_Entidad_Docsis_Overlap.Telefono_2 = Convert.ToDouble(D_Telefono_2.Text);
        obj_Entidad_Docsis_Overlap.Telefono_3 = Convert.ToDouble(D_Telefono_Telmex.Text);
        obj_Entidad_Docsis_Overlap.Movil_1 = Convert.ToDouble(D_Celular_1.Text);
        obj_Entidad_Docsis_Overlap.Movil_2 = Convert.ToDouble(D_Celular_2.Text);
        obj_Entidad_Docsis_Overlap.Paquete_Actual = D_Paquete_Actual.Text;
        obj_Entidad_Docsis_Overlap.Tipo_Contacto = Convert.ToString(D_Tipo_Contacto.SelectedItem);
        obj_Entidad_Docsis_Overlap.Gestion = Convert.ToString(D_Gestion.SelectedItem);
        obj_Entidad_Docsis_Overlap.Cierre = Convert.ToString(D_Cierre.SelectedItem);
        obj_Entidad_Docsis_Overlap.Razon = Convert.ToString(D_Razon.SelectedItem);
        obj_Entidad_Docsis_Overlap.Observaciones = D_Observaciones.Text.ToUpper();
        obj_Entidad_Docsis_Overlap.Fecha_Seguimiento = D_Fecha_Seguimiento.Text;
        obj_Entidad_Docsis_Overlap.Aliado = D_Aliado.Text;

    }
    protected void Registrar_Transaccion_Docsis_Overlap()
    {
        Controles_A_Objeto_Docsis();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Docsis_Overlap.abcLogClaro_Video("INSERTAR", obj_Entidad_Docsis_Overlap);
        if (Guardar_Datos != -1)
        {
            Limpiar_Docsis_Overlap();
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj1", script1, true);
        }
        else
        {
            string script2 = "mensaje2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj2", script2, true);

        }
    }

    
}



