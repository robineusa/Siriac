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

public partial class Formulario_Outbound : System.Web.UI.Page
{
    public E_Midas Obj_Entidad_Midas = new E_Midas();
    public N_Midas Obj_Neg_Midas = new N_Midas();
    public E_Servicios Obj_Entidad_Servicios = new E_Servicios();
    public N_Servicios Obj_Neg_Servicios = new N_Servicios();
    public E_Atributos Obj_Entidad_Atributos = new E_Atributos();
    public N_Atributos Obj_Neg_Atributos = new N_Atributos();
    public E_Arbol_Outbound Obj_Entidad_Arbol_Outbound = new E_Arbol_Outbound();
    public N_Arbol_Outbound Obj_Neg_Arbol_Outbound = new N_Arbol_Outbound();
    public E_Estado_Casos Obj_Entidad_Estado_Casos = new E_Estado_Casos();
    public N_Estado_Casos Obj_Neg_Estado_Casos = new N_Estado_Casos();
    public E_Seguimientos_Midas Obj_Entidad_Seguimientos_Midas = new E_Seguimientos_Midas();
    public N_Seguimientos_Midas Obj_Neg_Seguimientos_Midas = new N_Seguimientos_Midas();
    public N_Cierre_Ciclo Obj_Neg_Cierre_Ciclo = new N_Cierre_Ciclo();
    public E_Cierre_Ciclo Obj_Entidad_Cierre_Ciclo = new E_Cierre_Ciclo();
    public N_Clientes Obj_Neg_Clientes = new N_Clientes();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Acceso_2"].ToString() == "1") { } else { Response.Redirect("Bienvenida_Asesor.aspx?Acceso= " + Session["ACCESO_2"].ToString() + "--DENEGADO Gestion Outbound"); }
        //Label27.Text = Session["Nombre_Linea_Usuario"].ToString();
        //this.RadioButton1.Attributes.Add("OnClick", "javascript:return Ofrecimiento1SI();");
        //this.RadioButton2.Attributes.Add("OnClick", "javascript:return Ofrecimiento1NO();");
        //this.RadioButton3.Attributes.Add("OnClick", "javascript:return Ofrecimiento2SI();");
        //this.RadioButton4.Attributes.Add("OnClick", "javascript:return Ofrecimiento2NO();");
        //this.RadioButton5.Attributes.Add("OnClick", "javascript:return Ofrecimiento3SI();");
        //this.RadioButton6.Attributes.Add("OnClick", "javascript:return Ofrecimiento3NO();");
        //this.RadioButton7.Attributes.Add("OnClick", "javascript:return Ofrecimiento4SI();");
        //this.RadioButton8.Attributes.Add("OnClick", "javascript:return Ofrecimiento4NO();");
        //this.RadioButton9.Attributes.Add("OnClick", "javascript:return Ofrecimiento5SI();");
        //this.RadioButton10.Attributes.Add("OnClick", "javascript:return Ofrecimiento5NO();");
        //this.RadioButton11.Attributes.Add("OnClick", "javascript:return Ofrecimiento6SI();");
        //this.RadioButton12.Attributes.Add("OnClick", "javascript:return Ofrecimiento6NO();");
        //this.RadioButton13.Attributes.Add("OnClick", "javascript:return Ofrecimiento7SI();");
        //this.RadioButton14.Attributes.Add("OnClick", "javascript:return Ofrecimiento7NO();");
        //this.RadioButton15.Attributes.Add("OnClick", "javascript:return Ofrecimiento8SI();");
        //this.RadioButton16.Attributes.Add("OnClick", "javascript:return Ofrecimiento8NO();");
        //this.RadioButton17.Attributes.Add("OnClick", "javascript:return Ofrecimiento9SI();");
        //this.RadioButton18.Attributes.Add("OnClick", "javascript:return Ofrecimiento9NO();");
        //this.RadioButton19.Attributes.Add("OnClick", "javascript:return Ofrecimiento10SI();");
        //this.RadioButton20.Attributes.Add("OnClick", "javascript:return Ofrecimiento10NO();");
        //this.Label27.Attributes.Add("OnClick", "javascript:return permisos();");

        this.RadioButton21.Attributes.Add("OnClick", "javascript:return Ofrecimiento_CC_1_SI();");
        this.RadioButton22.Attributes.Add("OnClick", "javascript:return Ofrecimiento_CC_1_NO();");
        this.RadioButton23.Attributes.Add("OnClick", "javascript:return Ofrecimiento_CC_2_SI();");
        this.RadioButton24.Attributes.Add("OnClick", "javascript:return Ofrecimiento_CC_2_NO();");
        this.RadioButton25.Attributes.Add("OnClick", "javascript:return Ofrecimiento_CC_3_SI();");
        this.RadioButton26.Attributes.Add("OnClick", "javascript:return Ofrecimiento_CC_3_NO();");
    }

    private void Cargar_Registro(object sender, EventArgs e)
    {

        try
        {
            DataSet dt = new DataSet();
            //Obj_Entidad_Midas.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);
            dt = Obj_Neg_Midas.Consulta_Temporal_Midas(Obj_Entidad_Midas.Cuenta_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                //Nombre_Cliente.Text = dt.Tables[0].Rows[0]["NOMBRE_CLIENTE"].ToString();
                //Apellido_Cliente_1.Text = dt.Tables[0].Rows[0]["APELLIDO_1"].ToString();
                //Apellido_Cliente_2.Text = dt.Tables[0].Rows[0]["APELLIDO_2"].ToString();
                //Ciudad.Text = dt.Tables[0].Rows[0]["CIUDAD"].ToString();
                //Nodo.Text = dt.Tables[0].Rows[0]["NODO"].ToString(); ;
                //Mix_Basico.Text = dt.Tables[0].Rows[0]["MIX_BASICO"].ToString();
                //Tipo_de_Servicio.Text = dt.Tables[0].Rows[0]["TIPO_SERVICIO"].ToString();
                //Ciclo_de_Facturacion.Text = dt.Tables[0].Rows[0]["CICLO_FACTURACION"].ToString();
                //Renta.Text = dt.Tables[0].Rows[0]["RENTA"].ToString();
                //Tipo_de_Television.Text = dt.Tables[0].Rows[0]["TIPO_TV"].ToString();
                //Velocidad_Del_Internet.Text = dt.Tables[0].Rows[0]["VELOCIDAD_INTERNET"].ToString();
                //Estado_Cuenta.Text = dt.Tables[0].Rows[0]["ESTADO_CUENTA"].ToString();
                //Motivo_Desconexion.Text = dt.Tables[0].Rows[0]["MOTIVO_DESCONEXION"].ToString();
                //Contrato.Text = dt.Tables[0].Rows[0]["CONTRATO"].ToString();
                //Telefono_1.Text = dt.Tables[0].Rows[0]["TELEFONO_1"].ToString();
                //Telefono_2.Text = dt.Tables[0].Rows[0]["TELEFONO_2"].ToString();
                //Telefono_3.Text = dt.Tables[0].Rows[0]["TELEFONO_3"].ToString();
                //Estrato.Text = dt.Tables[0].Rows[0]["ESTRATO"].ToString();
                //Tipo_Hipotesis.Text = dt.Tables[0].Rows[0]["TIPO_HIPOTESIS"].ToString();
                //Telefono_Movil_1.Text = dt.Tables[0].Rows[0]["MOVIL_1"].ToString();
                //Telefono_Movil_2.Text = dt.Tables[0].Rows[0]["MOVIL_2"].ToString();
                //Telefono_Movil_3.Text = dt.Tables[0].Rows[0]["MOVIL_3"].ToString();
                //Campana_Actual.Text = dt.Tables[0].Rows[0]["CAMPANA"].ToString();
                //Estado_Campana.Text = dt.Tables[0].Rows[0]["ESTADO_CAMPANA"].ToString();
                //Historico.Text = dt.Tables[0].Rows[0]["HISTORICO"].ToString();
                //Ofrecimiento_1.Text = dt.Tables[0].Rows[0]["OFRECIMIENTO_1"].ToString();
                //Ofrecimiento_2.Text = dt.Tables[0].Rows[0]["OFRECIMIENTO_2"].ToString();
                //Ofrecimiento_3.Text = dt.Tables[0].Rows[0]["OFRECIMIENTO_3"].ToString();
                //Ofrecimiento_4.Text = dt.Tables[0].Rows[0]["OFRECIMIENTO_4"].ToString();
                //Ofrecimiento_5.Text = dt.Tables[0].Rows[0]["OFRECIMIENTO_5"].ToString();
                //Ofrecimiento_6.Text = dt.Tables[0].Rows[0]["OFRECIMIENTO_6"].ToString();
                //Ofrecimiento_7.Text = dt.Tables[0].Rows[0]["OFRECIMIENTO_7"].ToString();
                //Ofrecimiento_8.Text = dt.Tables[0].Rows[0]["OFRECIMIENTO_8"].ToString();
                //Ofrecimiento_9.Text = dt.Tables[0].Rows[0]["OFRECIMIENTO_9"].ToString();
                //Ofrecimiento_10.Text = dt.Tables[0].Rows[0]["OFRECIMIENTO_10"].ToString();
            }
            else
            {
                string script3 = "mensaje3();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje3", script3, true);
                Limpiar(Controls);
            }
        }
        catch (Exception esp)
        { throw new Exception("Error al Consultar los datos del cliente", esp); }
    }
    private void Controles_a_Objeto()
    {
        //var Atributo_1 = 0;
        //var Atributo_2 = 0;
        //var Atributo_3 = 0;
        //var Atributo_4 = 0;
        //var Atributo_5 = 0;
        //var Atributo_6 = 0;
        //var Atributo_7 = 0;
        //var Atributo_8 = 0;
        //var Atributo_9 = 0;
        //var Atributo_10 = 0;
        //var Ofrecimiento_1 = 0;
        //var Ofrecimiento_2 = 0;
        //var Ofrecimiento_3 = 0;
        //var Ofrecimiento_4 = 0;
        //var Ofrecimiento_5 = 0;
        //var Ofrecimiento_6 = 0;
        //var Ofrecimiento_7 = 0;
        //var Ofrecimiento_8 = 0;
        //var Ofrecimiento_9 = 0;
        //var Ofrecimiento_10 = 0;

        //if (CheckBox1.Checked == true) { Atributo_1 = 1; } else { Atributo_1 = 0; };
        //if (CheckBox2.Checked == true) { Atributo_2 = 1; } else { Atributo_2 = 0; };
        //if (CheckBox3.Checked == true) { Atributo_3 = 1; } else { Atributo_3 = 0; };
        //if (CheckBox4.Checked == true) { Atributo_4 = 1; } else { Atributo_4 = 0; };
        //if (CheckBox5.Checked == true) { Atributo_5 = 1; } else { Atributo_5 = 0; };
        //if (CheckBox6.Checked == true) { Atributo_6 = 1; } else { Atributo_6 = 0; };
        //if (CheckBox7.Checked == true) { Atributo_7 = 1; } else { Atributo_7 = 0; };

        //if (RadioButton1.Checked == true) { Ofrecimiento_1 = 1; } else { Ofrecimiento_1 = 0; }
        //if (RadioButton3.Checked == true) { Ofrecimiento_2 = 1; } else { Ofrecimiento_2 = 0; }
        //if (RadioButton5.Checked == true) { Ofrecimiento_3 = 1; } else { Ofrecimiento_3 = 0; }
        //if (RadioButton7.Checked == true) { Ofrecimiento_4 = 1; } else { Ofrecimiento_4 = 0; }
        //if (RadioButton9.Checked == true) { Ofrecimiento_5 = 1; } else { Ofrecimiento_5 = 0; }
        //if (RadioButton11.Checked == true) { Ofrecimiento_6 = 1; } else { Ofrecimiento_6 = 0; }
        //if (RadioButton13.Checked == true) { Ofrecimiento_7 = 1; } else { Ofrecimiento_7 = 0; }
        //if (RadioButton15.Checked == true) { Ofrecimiento_8 = 1; } else { Ofrecimiento_8 = 0; }
        //if (RadioButton17.Checked == true) { Ofrecimiento_9 = 1; } else { Ofrecimiento_9 = 0; }
        //if (RadioButton19.Checked == true) { Ofrecimiento_10 = 1; } else { Ofrecimiento_10 = 0; }

        //Obj_Entidad_Midas.Usuario_de_Gestion = Session["Usuario_Logueado"].ToString();
        //Obj_Entidad_Midas.Aliado_Gestion = Session["Aliado_Usuario"].ToString();
        //Obj_Entidad_Midas.Ciudad = Ciudad.Text;
        //Obj_Entidad_Midas.Nodo = Nodo.Text;
        //Obj_Entidad_Midas.Mix_Basico = Mix_Basico.Text;
        //Obj_Entidad_Midas.Tipo_Servicio = Tipo_de_Servicio.Text;
        //Obj_Entidad_Midas.Ciclo_Facturacion = Convert.ToDouble(Ciclo_de_Facturacion.Text);
        //Obj_Entidad_Midas.Renta = Convert.ToDouble(Renta.Text);
        //Obj_Entidad_Midas.Tipo_Tv = Tipo_de_Television.Text;
        //Obj_Entidad_Midas.Velovidad_Internet = Convert.ToDouble(Velocidad_Del_Internet.Text);
        //Obj_Entidad_Midas.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);
        //Obj_Entidad_Midas.Estado_Cuenta = Estado_Cuenta.Text;
        //Obj_Entidad_Midas.Motivo_Desconexion = Motivo_Desconexion.Text;
        //Obj_Entidad_Midas.Nombre_Cliente = Nombre_Cliente.Text;
        //Obj_Entidad_Midas.Apellido_1 = Apellido_Cliente_1.Text;
        //Obj_Entidad_Midas.Apellido_2 = Apellido_Cliente_2.Text;
        //Obj_Entidad_Midas.Contrato = Contrato.Text;
        //Obj_Entidad_Midas.Telefono_1 = Convert.ToDouble(Telefono_1.Text);
        //Obj_Entidad_Midas.Telefono_2 = Convert.ToDouble(Telefono_2.Text);
        //Obj_Entidad_Midas.Telefono_3 = Convert.ToDouble(Telefono_3.Text);
        //Obj_Entidad_Midas.Movil_1 = Convert.ToDouble(Telefono_Movil_1.Text);
        //Obj_Entidad_Midas.Movil_2 = Convert.ToDouble(Telefono_Movil_2.Text);
        //Obj_Entidad_Midas.Movil_3 = Convert.ToDouble(Telefono_Movil_3.Text);
        //Obj_Entidad_Midas.Estrato = Estrato.Text;
        //Obj_Entidad_Midas.Historico = Historico.Text;
        //Obj_Entidad_Midas.Tipo_Hipotesis = Tipo_Hipotesis.Text;
        //Obj_Entidad_Midas.Tipo_Contacto = Convert.ToString(Tipo_de_Contacto.SelectedItem);
        //Obj_Entidad_Midas.Gestion = Convert.ToString(Gestion_Cliente.SelectedItem);
        //Obj_Entidad_Midas.Cierre = Convert.ToString(Cierre_Cliente.SelectedItem);
        //Obj_Entidad_Midas.Razon = Razon_Cliente.Text;
        //Obj_Entidad_Midas.Causa = Causa_Hipotesis.Text;
        //Obj_Entidad_Midas.Nps = Convert.ToDouble(Nps.Text);
        //Obj_Entidad_Midas.Campana = Campana_Actual.Text;
        //Obj_Entidad_Midas.Estado_Campana = Estado_Campana.Text;
        //Obj_Entidad_Midas.Satisfaccion = Satisfaccion.Text;
        //Obj_Entidad_Midas.Atributo_1 = Atributo_1;
        //Obj_Entidad_Midas.Atributo_2 = Atributo_2;
        //Obj_Entidad_Midas.Atributo_3 = Atributo_3;
        //Obj_Entidad_Midas.Atributo_4 = Atributo_4;
        //Obj_Entidad_Midas.Atributo_5 = Atributo_5;
        //Obj_Entidad_Midas.Atributo_6 = Atributo_6;
        //Obj_Entidad_Midas.Atributo_7 = Atributo_7;
        //Obj_Entidad_Midas.Atributo_8 = Atributo_8;
        //Obj_Entidad_Midas.Atributo_9 = Atributo_9;
        //Obj_Entidad_Midas.Atributo_10 = Atributo_10;
        //Obj_Entidad_Midas.Ofrecimiento_1 = Ofrecimiento_1;
        //Obj_Entidad_Midas.Ofrecimiento_2 = Ofrecimiento_2;
        //Obj_Entidad_Midas.Ofrecimiento_3 = Ofrecimiento_3;
        //Obj_Entidad_Midas.Ofrecimiento_4 = Ofrecimiento_4;
        //Obj_Entidad_Midas.Ofrecimiento_5 = Ofrecimiento_5;
        //Obj_Entidad_Midas.Ofrecimiento_6 = Ofrecimiento_6;
        //Obj_Entidad_Midas.Ofrecimiento_7 = Ofrecimiento_7;
        //Obj_Entidad_Midas.Ofrecimiento_8 = Ofrecimiento_8;
        //Obj_Entidad_Midas.Ofrecimiento_9 = Ofrecimiento_9;
        //Obj_Entidad_Midas.Ofrecimiento_10 = Ofrecimiento_10;
        //Obj_Entidad_Midas.Id_Estado = Convert.ToInt16(Estado_Caso.SelectedValue);

        //Obj_Entidad_Seguimientos_Midas.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);
        //Obj_Entidad_Seguimientos_Midas.Usuario_Creacion = Session["Usuario_Logueado"].ToString();
        //Obj_Entidad_Seguimientos_Midas.Motivo_Seguimiento = Motivo_Seguimiento.SelectedValue;
        //if (datetimepicker1.Text == "")
        //{
        //    datetimepicker1.Text = "2016-01-01 00:00";
        //}
        //else
        //{
        //    Obj_Entidad_Seguimientos_Midas.Fecha_Hora_Seguimiento = Convert.ToDateTime(datetimepicker1.Text);
        //}
        //Obj_Entidad_Seguimientos_Midas.Tipo_Hipotesis = Tipo_Hipotesis.Text;
    }
    private void Limpiar(ControlCollection controles)
    {
        foreach (Control control in controles)
        {
            if (control is TextBox)
                ((TextBox)control).Text = string.Empty;
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
            {
                ((DropDownList)control).ClearSelection();
                ((DropDownList)control).DataBind();
            }
            else if (control.HasControls())
                //Esta linea detécta un Control que contenga otros Controles
                //Así ningún control se quedará sin ser limpiado.
                Limpiar(control.Controls);
            //datetimepicker1.Text = "2016-01-01 00:00";
        }
        //datetimepicker1.Text = "2016-01-01 00:00";
    }
    protected void Cuenta_Cliente_TextChanged(object sender, EventArgs e)
    {
        this.Cargar_Registro(sender, e);
        Lista_Servicios();
        Carga_Atributos();
        Tipo_Contacto();
        Arbol_Gestion();
        Arbol_Cierre();
        Arbol_Razon();
        Causa();
        Estado_Casos();
    }
    private void Lista_Servicios()
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Atributos.Consulta_Servicios();

        if (dt.Tables[0].Rows.Count > 0)
        {
            //Servicios.DataSource = dt;
            //Servicios.DataTextField = "SERVICIO";
            //Servicios.DataValueField = "SERVICIO";
            //Servicios.DataBind();
        }
    }
    private void Carga_Atributos()
    {
        DataSet dt = new DataSet();
        //Obj_Entidad_Atributos.Servicio = Servicios.Text;
        dt = Obj_Neg_Atributos.Consulta_Atributos(Obj_Entidad_Atributos.Servicio);

        if (dt.Tables[0].Rows.Count > 0)
        {
            //Atributos_Servicio.Text = dt.Tables[0].Rows[0]["ATRIBUTO"].ToString();
        }
        else { }
    }
    protected void Servicios_SelectedIndexChanged(object sender, EventArgs e)
    {
        Carga_Atributos();
    }
    protected void Tipo_Contacto()
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Arbol_Outbound.Tipo_Contacto();

        if (dt.Tables[0].Rows.Count > 0)
        {

            //Tipo_de_Contacto.DataSource = dt;
            //Tipo_de_Contacto.DataTextField = "TIPO_CONTACTO";
            //Tipo_de_Contacto.DataValueField = "ID_TIPO_CONTACTO";
            //Tipo_de_Contacto.DataBind();
        }
    }
    protected void Arbol_Gestion()
    {
        DataSet dt = new DataSet();
        //Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto = Convert.ToInt16(Tipo_de_Contacto.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Selecciona_Gestion(Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto);

        if (dt.Tables[0].Rows.Count > 0)
        {

            //Gestion_Cliente.DataSource = dt;
            //Gestion_Cliente.DataTextField = "GESTION";
            //Gestion_Cliente.DataValueField = "ID_TIPO_GESTION";
            //Gestion_Cliente.DataBind();
        }
    }
    protected void Arbol_Cierre()
    {
        DataSet dt = new DataSet();
        //Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion = Convert.ToInt16(Gestion_Cliente.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Selecciona_Cierre(Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion);

        if (dt.Tables[0].Rows.Count > 0)
        {

            //Cierre_Cliente.DataSource = dt;
            //Cierre_Cliente.DataTextField = "CIERRE";
            //Cierre_Cliente.DataValueField = "ID_CIERRE";
            //Cierre_Cliente.DataBind();
        }
    }
    protected void Arbol_Razon()
    {
        DataSet dt = new DataSet();
        //Obj_Entidad_Arbol_Outbound.Id_Cierre = Convert.ToInt16(Cierre_Cliente.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Selecciona_Razon(Obj_Entidad_Arbol_Outbound.Id_Cierre);

        if (dt.Tables[0].Rows.Count > 0)
        {

            //Razon_Cliente.DataSource = dt;
            //Razon_Cliente.DataTextField = "RAZON";
            //Razon_Cliente.DataValueField = "RAZON";
            //Razon_Cliente.DataBind();
        }
    }
    protected void Causa()
    {
        DataSet dt = new DataSet();
        //Obj_Entidad_Arbol_Outbound.Hipotesis = Tipo_Hipotesis.Text;
        dt = Obj_Neg_Arbol_Outbound.Selecciona_Causa(Obj_Entidad_Arbol_Outbound.Hipotesis);

        if (dt.Tables[0].Rows.Count > 0)
        {

            //Causa_Hipotesis.DataSource = dt;
            //Causa_Hipotesis.DataTextField = "CAUSA";
            //Causa_Hipotesis.DataValueField = "ID_CAUSA";
            //Causa_Hipotesis.DataBind();
        }
    }
    protected void Tipo_de_Contacto_SelectedIndexChanged(object sender, EventArgs e)
    {
        Arbol_Gestion();
        Arbol_Cierre();
        Arbol_Razon();
    }
    protected void Gestion_Cliente_SelectedIndexChanged(object sender, EventArgs e)
    {
        Arbol_Cierre();
        Arbol_Razon();
    }
    protected void Cierre_Cliente_SelectedIndexChanged(object sender, EventArgs e)
    {
        Arbol_Razon();
    }
    protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
    {
        //if (CheckBox5.Checked == true) { Panel5.Visible = true; }
        //else { Panel5.Visible = false; }
    }
    private void Estado_Casos()
    {
        DataSet dt = new DataSet();

        dt = Obj_Neg_Estado_Casos.Estado_Casos_Outbound();



        if (dt.Tables[0].Rows.Count > 0)
        {
            //Estado_Caso.DataSource = dt;
            //Estado_Caso.DataTextField = "DESCRIPCION";
            //Estado_Caso.DataValueField = "ID_ESTADO";
            //Estado_Caso.DataBind();
        }
    }
    protected void Estado_Caso_SelectedIndexChanged(object sender, EventArgs e)
    {
        //var ESTADO_CASO = Estado_Caso.SelectedValue;
        //if (ESTADO_CASO == "2") { Panel10.Visible = false; }
        //else if (ESTADO_CASO == "3") { Panel10.Visible = true; }
    }
    protected void Insertar_Registro(object sender, EventArgs e)
    {
        Controles_a_Objeto();

        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Midas.abcMidas("INSERTAR", Obj_Entidad_Midas);
        if (Guardar_Datos != -1)
        {
            this.Log_Transaccion(sender, e);

        }
        else
        {
            string script6 = "mensaje6();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje6", script6, true);
        }

    }
    protected void Actualizar_Registro(object sender, EventArgs e)
    {
        Controles_a_Objeto();

        var Guardar_Datos = -1;
        //Obj_Entidad_Midas.Cuenta_Cliente = Convert.ToInt64(Cuenta_Cliente.Text);
        Guardar_Datos = Obj_Neg_Midas.abcMidas("ACTUALIZAR", Obj_Entidad_Midas);
        if (Guardar_Datos != -1)
        {
            this.Log_Transaccion(sender, e);
        }
        else
        {
            string script6 = "mensaje6();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj6", script6, true);
        }
    }
    protected void Log_Transaccion(object sender, EventArgs e)
    {
        Controles_a_Objeto();

        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Midas.abcMidas_Log("INSERTAR", Obj_Entidad_Midas);
        if (Guardar_Datos != -1)
        {
            //var FECHA = datetimepicker1.Text;
            //if (FECHA == "") { }
            //else
            //{
            //    Seguimeintos_Midas();
            //}

            string script4 = "mensaje4();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj4", script4, true);
            Limpiar(Controls);
            this.Page_Load(sender, e);
            string script5 = "Traer_Fecha();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaj5", script5, true);
        }
        else
        {
            string script6 = "mensaje6();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje5", script6, true);
        }
    }
    protected void Registrar_Seguimiento()
    {
        Controles_a_Objeto();

        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Seguimientos_Midas.abcSeguimientos_Midas("INSERTAR", Obj_Entidad_Seguimientos_Midas);
        if (Guardar_Datos != -1)
        {


        }
        else
        {

        }
    }
    protected void Actualizar_Seguimiento()
    {
        Controles_a_Objeto();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Seguimientos_Midas.abcSeguimientos_Midas("ACTUALIZAR", Obj_Entidad_Seguimientos_Midas);
        if (Guardar_Datos != -1)
        {


        }
        else
        {

        }
    }
    protected void Seguimeintos_Midas()
    {
        DataSet dt = new DataSet();
        //Obj_Entidad_Seguimientos_Midas.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);
        dt = Obj_Neg_Seguimientos_Midas.Consulta_Seguimientos_Midas(Obj_Entidad_Seguimientos_Midas.Cuenta_Cliente);

        if (dt.Tables[0].Rows.Count > 0)
        {
            Actualizar_Seguimiento();
        }
        else
        {
            Registrar_Seguimiento();
        }
    }
    protected void Guardar_Click(object sender, EventArgs e)
    {

        DataSet dt = new DataSet();
        //Obj_Entidad_Midas.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);
        dt = Obj_Neg_Midas.Consulta_Registro(Obj_Entidad_Midas.Cuenta_Cliente);



        if (dt.Tables[0].Rows.Count > 0)
        {
            this.Actualizar_Registro(sender, e);
        }
        else
        {
            this.Insertar_Registro(sender, e);
        }
    }
    protected void Cuenta_Cliente_Unload(object sender, EventArgs e)
    {
        //Cuenta_Cliente.Attributes.Remove("Required");
        //Cuenta_Cliente.Attributes.Clear();
    }
    protected void CC_Tipo_Contacto()
    {

        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion = 10;
        dt = Obj_Neg_Arbol_Outbound.Oubound_Tipo_Contacto(Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion);

        if (dt.Tables[0].Rows.Count > 0)
        {
            CC_TIPO_CONTACTO.DataSource = dt;
            CC_TIPO_CONTACTO.DataTextField = "TIPO_CONTACTO";
            CC_TIPO_CONTACTO.DataValueField = "ID_TIPO_CONTACTO";
            CC_TIPO_CONTACTO.DataBind();
        }
        else
        {
            CC_TIPO_CONTACTO.Items.Clear();
        }
    }
    protected void CC_Gestion()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto = Convert.ToInt16(CC_TIPO_CONTACTO.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Cierre(Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto);

        if (dt.Tables[0].Rows.Count > 0)
        {

            CC_GESTION.DataSource = dt;
            CC_GESTION.DataTextField = "CIERRE";
            CC_GESTION.DataValueField = "ID_CIERRE";
            CC_GESTION.DataBind();
        }
        else
        {
            CC_GESTION.Items.Clear();
        }
    }
    protected void CC_Cierre()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Cierre = Convert.ToInt16(CC_GESTION.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Razon(Obj_Entidad_Arbol_Outbound.Id_Cierre);

        if (dt.Tables[0].Rows.Count > 0)
        {
            CC_CIERRE.DataSource = dt;
            CC_CIERRE.DataTextField = "RAZON";
            CC_CIERRE.DataValueField = "ID_RAZON";
            CC_CIERRE.DataBind();
        }
        else
        {
            CC_CIERRE.Items.Clear();
        }
    }
    protected void CC_Razon()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Causa = Convert.ToInt16(CC_CIERRE.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Causa(Obj_Entidad_Arbol_Outbound.Id_Causa);

        if (dt.Tables[0].Rows.Count > 0)
        {
            CC_RAZON.DataSource = dt;
            CC_RAZON.DataTextField = "CAUSA";
            CC_RAZON.DataValueField = "ID_CAUSA";
            CC_RAZON.DataBind();
        }
        else
        {
            CC_RAZON.Items.Clear();
        }
    }
    protected void CC_Motivo()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Motivo = Convert.ToInt16(CC_RAZON.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Motivo(Obj_Entidad_Arbol_Outbound.Id_Motivo);

        if (dt.Tables[0].Rows.Count > 0)
        {
            CC_MOTIVO.DataSource = dt;
            CC_MOTIVO.DataTextField = "MOTIVO";
            CC_MOTIVO.DataValueField = "ID_MOTIVO";
            CC_MOTIVO.DataBind();
        }
        else
        {
            CC_RAZON.Items.Clear();
        }
    }

    protected void CC_TIPO_CONTACTO_SelectedIndexChanged(object sender, EventArgs e)
    {
        CC_Gestion();
        CC_Cierre();
        CC_Razon();
        CC_Motivo();
    }

    protected void CC_GESTION_SelectedIndexChanged(object sender, EventArgs e)
    {
        CC_Cierre();
        CC_Razon();
        CC_Motivo();
    }

    protected void CC_CIERRE_SelectedIndexChanged(object sender, EventArgs e)
    {
        CC_Razon();
        CC_Motivo();
    }
    protected void CC_RAZON_SelectedIndexChanged(object sender, EventArgs e)
    {
        CC_Motivo();
    }
    protected void CC_Cuenta_Cliente_TextChanged(object sender, EventArgs e)
    {
        //Limpiar_CC();
        DataSet dt = new DataSet();
        Obj_Entidad_Cierre_Ciclo.Cuenta = CC_Cuenta_Cliente.Text;
        dt = Obj_Neg_Cierre_Ciclo.Consulta_Temporal_Cuentas(Obj_Entidad_Cierre_Ciclo.Cuenta);
        if (dt.Tables[0].Rows.Count > 0)
        {
            CC_Mix_Basico.Text = dt.Tables[0].Rows[0]["MIX_BASICO"].ToString();
            CC_Television.Text = dt.Tables[0].Rows[0]["SERVICIO_TV"].ToString();
            CC_Internet.Text = dt.Tables[0].Rows[0]["SERVICIO_INTERNET"].ToString();
            CC_Telefonia.Text = dt.Tables[0].Rows[0]["SERVICIO_VOZ"].ToString();
            CC_HD.Text = dt.Tables[0].Rows[0]["HD"].ToString();
            CC_HBO.Text = dt.Tables[0].Rows[0]["HBO"].ToString();
            CC_FOX.Text = dt.Tables[0].Rows[0]["FOX"].ToString();
            CC_Adulto.Text = dt.Tables[0].Rows[0]["ADULTO"].ToString();
            CC_Claro_Video.Text = dt.Tables[0].Rows[0]["CLAROVIDEO"].ToString();
            CC_Num_Decos.Text = dt.Tables[0].Rows[0]["NUM_DECOS"].ToString();
            CC_Revista.Text = dt.Tables[0].Rows[0]["REVISTA"].ToString();
            CC_Elegido_Fijo_Movil.Text = dt.Tables[0].Rows[0]["ELEGIDO_FIJO_MOVIL"].ToString();
            CC_Siembra_HD.Text = dt.Tables[0].Rows[0]["SIEMBRA_HD"].ToString();
            CC_Blindaje_Internet.Text = dt.Tables[0].Rows[0]["BLINDAJE_INTERNET"].ToString();
            CC_Siembra_Voz.Text = dt.Tables[0].Rows[0]["SIEMBRA_VOZ"].ToString();
            CC_Activacion_Claro_Video.Text = dt.Tables[0].Rows[0]["ACTIVACION_CLAROVIDEO"].ToString();
            CC_Primer_Ofrecimiento.Text = dt.Tables[0].Rows[0]["OFRECIMIENTO_1"].ToString();
            CC_Segundo_Ofrecimiento.Text = dt.Tables[0].Rows[0]["OFRECIMIENTO_2"].ToString();
            CC_Tercer_Ofrecimiento.Text = dt.Tables[0].Rows[0]["OFRECIMIENTO_3"].ToString();
            CC_Fecha_Marcacion.Text = dt.Tables[0].Rows[0]["FECHA_MARCACION"].ToString();
            CC_Notas_Marcacion.Text = dt.Tables[0].Rows[0]["NOTAS_MARCACION"].ToString();
            CC_Marcacion.Text = dt.Tables[0].Rows[0]["MARCACION"].ToString();
            CC_Convenio_Electronico.Text = dt.Tables[0].Rows[0]["CONVENIO_ELECTRONICO"].ToString();
            Base.Text = dt.Tables[0].Rows[0]["BASE"].ToString();
            Operacion.Text = dt.Tables[0].Rows[0]["OPERACION_GESTION"].ToString();
            CC_Consultar_Datos_Clientes();
        }
        else
        {
            string script3 = "mensaje3();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje3", script3, true);
            Limpiar_CC();
        }

    }

    protected void CC_Guardar_Datos_Click(object sender, EventArgs e)
    {
        if ((CC_Cuenta_Cliente.Text != ""))
        {
            if ((Convert.ToString(CC_GESTION.SelectedItem) != "") || (Convert.ToString(CC_CIERRE.SelectedItem) != "") || (Convert.ToString(CC_RAZON.SelectedItem) != ""))
            {
                CC_Guardar_Datos.Enabled = false;
                DataSet dt = new DataSet();
                Obj_Entidad_Cierre_Ciclo.Cuenta = CC_Cuenta_Cliente.Text;
                dt = Obj_Neg_Cierre_Ciclo.Consulta_Cliente_Cierre_Ciclo_Gestionado(Obj_Entidad_Cierre_Ciclo.Cuenta);

                if (dt.Tables[0].Rows.Count > 0)
                {
                    CC_Actualizar_Datos();

                }
                else
                {
                    CC_Guardar_Datos_1();
                }
            }
            else
            {
                string script9 = "mensaje9();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje9", script9, true);
            }
        }
        else {
            string script8 = "mensaje8();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje8", script8, true);
        }
        string CC = "Cargar_Datos_CC();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "Cargar_Datos_CC", CC, true);
        
    }
    protected void CC_Guardar_Datos_1()
    {
        CC_Controles_A_Objeto();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Cierre_Ciclo.abcCierre_Ciclo("INSERTAR", Obj_Entidad_Cierre_Ciclo);
        if (Guardar_Datos != -1)
        {
            CC_Guardar_Datos_Log();
            Limpiar_CC();
            string script2 = "mensaje4();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje4", script2, true);

        }
        else
        {
            string script = "mensaje7();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje7", script, true);
        }

    }
    protected void CC_Guardar_Datos_Log()
    {
        CC_Controles_A_Objeto();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Cierre_Ciclo.abc_LogCierre_Ciclo("INSERTAR", Obj_Entidad_Cierre_Ciclo);
        Limpiar_CC();
    }
    protected void CC_Actualizar_Datos()
    {
        CC_Controles_A_Objeto();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Cierre_Ciclo.abcCierre_Ciclo("ACTUALIZAR", Obj_Entidad_Cierre_Ciclo);
        if (Guardar_Datos != -1)
        {
            CC_Guardar_Datos_Log();
            Limpiar_CC();
            string script2 = "mensaje4();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje4", script2, true);

        }
        else
        {
            string script = "mensaje7();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje7", script, true);
        }

    }
    protected void CC_Consultar_Datos_Clientes()
    {

        DataSet dt = new DataSet();
        Obj_Entidad_Cierre_Ciclo.Cuenta = CC_Cuenta_Cliente.Text;
        dt = Obj_Neg_Clientes.Consulta_Cliente(Obj_Entidad_Cierre_Ciclo.Cuenta);

        if (dt.Tables[0].Rows.Count > 0)
        {
            CC_Nombre_Cliente.Text = dt.Tables[0].Rows[0]["NOMBRE"].ToString();
            CC_Apellido_Cliente.Text = dt.Tables[0].Rows[0]["APELLIDO"].ToString();
            CC_Direccion_de_Instalacion.Text = dt.Tables[0].Rows[0]["DIR_INSTALACION"].ToString();
            CC_Direccion_de_Correspondencia.Text = dt.Tables[0].Rows[0]["DIR_CORRESPONDENCIA"].ToString();
            CC_Nombre_Comunidad.Text = dt.Tables[0].Rows[0]["NOMBRE_COMUNIDAD"].ToString();
            CC_Correo_Electronico.Text = dt.Tables[0].Rows[0]["CORREO"].ToString();
            CC_Estrato.Text = dt.Tables[0].Rows[0]["ESTRATO"].ToString();
            CC_Tipo_Cliente.Text = dt.Tables[0].Rows[0]["TIPO_CLIENTE"].ToString();
            CC_Paquete_Actual.Text = dt.Tables[0].Rows[0]["PRODUCTOS"].ToString();
            if (dt.Tables[0].Rows[0]["TELEFONO_1"].ToString() == "") { CC_Telefono_1.Text = "0"; } else { CC_Telefono_1.Text = dt.Tables[0].Rows[0]["TELEFONO_1"].ToString(); }
            if (dt.Tables[0].Rows[0]["TELEFONO_2"].ToString() == "") { CC_Telefono_2.Text = "0"; } else { CC_Telefono_2.Text = dt.Tables[0].Rows[0]["TELEFONO_2"].ToString(); }
            if (dt.Tables[0].Rows[0]["TELEFONO_3"].ToString() == "") { CC_Telefono_3.Text = "0"; } else { CC_Telefono_3.Text = dt.Tables[0].Rows[0]["TELEFONO_3"].ToString(); }
            if (dt.Tables[0].Rows[0]["CELULAR_1"].ToString() == "") { CC_Movil_1.Text = "0"; } else { CC_Movil_1.Text = dt.Tables[0].Rows[0]["CELULAR_1"].ToString(); }
            if (dt.Tables[0].Rows[0]["CELULAR_2"].ToString() == "") { CC_Movil_2.Text = "0"; } else { CC_Movil_2.Text = dt.Tables[0].Rows[0]["CELULAR_2"].ToString(); }
            if (dt.Tables[0].Rows[0]["TELEFONO_CONV"].ToString() == "") { CC_Movil_Portpago.Text = "0"; } else { CC_Movil_Portpago.Text = dt.Tables[0].Rows[0]["TELEFONO_CONV"].ToString(); }
            CC_Tipo_Contacto();
            CC_GESTION.ClearSelection();
            CC_GESTION.Items.Clear();
            CC_CIERRE.ClearSelection();
            CC_CIERRE.Items.Clear();
            CC_RAZON.ClearSelection();
            CC_RAZON.Items.Clear();

            //CC_Gestion();
            //CC_Cierre();
            //CC_Razon();
        }
        else
        {
            string script3 = "mensaje3();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje3", script3, true);

        }
    }
    private void Limpiar_CC()
    {
        var LIMPIAR_DATOS = "";
        CC_Cuenta_Cliente.Text = LIMPIAR_DATOS;
        CC_Nombre_Cliente.Text = LIMPIAR_DATOS;
        CC_Apellido_Cliente.Text = LIMPIAR_DATOS;
        CC_Direccion_de_Instalacion.Text = LIMPIAR_DATOS;
        CC_Direccion_de_Correspondencia.Text = LIMPIAR_DATOS;
        CC_Telefono_1.Text = LIMPIAR_DATOS;
        CC_Telefono_2.Text = LIMPIAR_DATOS;
        CC_Telefono_3.Text = LIMPIAR_DATOS;
        CC_Movil_1.Text = LIMPIAR_DATOS;
        CC_Movil_2.Text = LIMPIAR_DATOS;
        CC_Nombre_Comunidad.Text = LIMPIAR_DATOS;
        CC_Correo_Electronico.Text = LIMPIAR_DATOS;
        CC_Estrato.Text = LIMPIAR_DATOS;
        CC_Tipo_Cliente.Text = LIMPIAR_DATOS;
        CC_Paquete_Actual.Text = LIMPIAR_DATOS;
        CC_Movil_Portpago.Text = LIMPIAR_DATOS;
        CC_Mix_Basico.Text = LIMPIAR_DATOS;
        CC_Television.Text = LIMPIAR_DATOS;
        CC_Internet.Text = LIMPIAR_DATOS;
        CC_Telefonia.Text = LIMPIAR_DATOS;
        CC_HD.Text = LIMPIAR_DATOS;
        CC_HBO.Text = LIMPIAR_DATOS;
        CC_FOX.Text = LIMPIAR_DATOS;
        CC_Adulto.Text = LIMPIAR_DATOS;
        CC_Claro_Video.Text = LIMPIAR_DATOS;
        CC_Num_Decos.Text = LIMPIAR_DATOS;
        CC_Revista.Text = LIMPIAR_DATOS;
        CC_Elegido_Fijo_Movil.Text = LIMPIAR_DATOS;
        CC_Siembra_HD.Text = LIMPIAR_DATOS;
        CC_Blindaje_Internet.Text = LIMPIAR_DATOS;
        CC_Siembra_Voz.Text = LIMPIAR_DATOS;
        CC_Activacion_Claro_Video.Text = LIMPIAR_DATOS;
        CC_Primer_Ofrecimiento.Text = LIMPIAR_DATOS;
        CC_Segundo_Ofrecimiento.Text = LIMPIAR_DATOS;
        CC_Tercer_Ofrecimiento.Text = LIMPIAR_DATOS;
        RadioButton21.Checked = false;
        RadioButton22.Checked = false;
        RadioButton23.Checked = false;
        RadioButton24.Checked = false;
        RadioButton25.Checked = false;
        RadioButton26.Checked = false;
        CC_S_VOZ.Checked = false;
        CC_ANALOGA.Checked = false;
        CC_AVANZADA.Checked = false;
        CC_BASICA.Checked = false;
        CC_SATELITAL.Checked = false;
        CC_UPGRADE_TV.Checked = false;
        CC_UPGRADE_INTERNET.Checked = false;
        CC_INTERNET_3M.Checked = false;
        CC_INTERNET_5M.Checked = false;
        CC_INTERNET_10M.Checked = false;
        CC_INTERNET_20M.Checked = false;
        CC_INTERNET_50M.Checked = false;
        CC_INTERNET_100M.Checked = false;
        CC_CHECK_CLARO_VIDEO.Checked = false;
        CC_CHECK_FOX.Checked = false;
        CC_GOLDEN_PREMIER_HD.Checked = false;
        CC_CHECK_HBO.Checked = false;
        CC_CHECK_HD.Checked = false;
        CC_HOTPACK.Checked = false;
        CC_INTERNET_MOVIL_1_5.Checked = false;
        CC_INTERNET_MOVIL_750.Checked = false;
        CC_IP_FIJA.Checked = false;
        CC_LOCAL_EXTENDIDA.Checked = false;
        CC_MACAFEE.Checked = false;
        CC_MINI_FOX.Checked = false;
        CC_MINI_HBO.Checked = false;
        CC_MODEM_ADICIONAL.Checked = false;
        CC_PVR.Checked = false;
        CC_PVR_HD.Checked = false;
        CC_CHECK_REVISTA.Checked = false;
        CC_SEGUNDO_MODEM.Checked = false;
        CC_UFC.Checked = false;
        CC_VOD.Checked = false;
        CC_2CHECK_ELEGIDO_FIJO_MOVIL.Checked = false;
        CC_2CHECK_CLARO_VIDEO.Checked = false;
        CC_CONVENIO.Checked = false;
        CC_TIPO_CONTACTO.ClearSelection();
        CC_TIPO_CONTACTO.Items.Clear();
        CC_GESTION.ClearSelection();
        CC_GESTION.Items.Clear();
        CC_CIERRE.ClearSelection();
        CC_CIERRE.Items.Clear();
        CC_RAZON.ClearSelection();
        CC_RAZON.Items.Clear();
        CC_Observaciones.Text = LIMPIAR_DATOS;
        CC_Fecha_Marcacion.Text = LIMPIAR_DATOS;
        CC_Marcacion.Text = LIMPIAR_DATOS;
        CC_Notas_Marcacion.Text = LIMPIAR_DATOS;
        CC_Convenio_Electronico.Text = LIMPIAR_DATOS;
        Base.Text = LIMPIAR_DATOS;
        Operacion.Text = LIMPIAR_DATOS;
        CC_Guardar_Datos.Enabled = true;
    }
    protected void CC_Controles_A_Objeto()
    {
        int Ofrecimiento_1 = 0;
        int Ofrecimiento_2 = 0;
        int Ofrecimiento_3 = 0;
        int Servicio_1 = 0;
        int Servicio_2 = 0;
        int Servicio_3 = 0;
        int Servicio_4 = 0;
        int Servicio_5 = 0;
        int Servicio_6 = 0;
        int Servicio_7 = 0;
        int Servicio_8 = 0;
        int Servicio_9 = 0;
        int Servicio_10 = 0;
        int Servicio_11 = 0;
        int Servicio_12 = 0;
        int Servicio_13 = 0;
        int Servicio_14 = 0;
        int Servicio_15 = 0;
        int Servicio_16 = 0;
        int Servicio_17 = 0;
        int Servicio_18 = 0;
        int Servicio_19 = 0;
        int Servicio_20 = 0;
        int Servicio_21 = 0;
        int Servicio_22 = 0;
        int Servicio_23 = 0;
        int Servicio_24 = 0;
        int Servicio_25 = 0;
        int Servicio_26 = 0;
        int Servicio_27 = 0;
        int Servicio_28 = 0;
        int Servicio_29 = 0;
        int Servicio_30 = 0;
        int Servicio_31 = 0;
        int Servicio_32 = 0;
        int Servicio_33 = 0;
        int Servicio_34 = 0;
        int Servicio_35 = 0;
        int Servicio_36 = 0;

        if (RadioButton21.Checked == true) { Ofrecimiento_1 = 1; } else { Ofrecimiento_1 = 0; }
        if (RadioButton23.Checked == true) { Ofrecimiento_2 = 1; } else { Ofrecimiento_2 = 0; }
        if (RadioButton25.Checked == true) { Ofrecimiento_3 = 1; } else { Ofrecimiento_3 = 0; }

        if (CC_S_VOZ.Checked == true) { Servicio_1 = 1; } else { Servicio_1 = 0; }
        if (CC_ANALOGA.Checked == true) { Servicio_2 = 1; } else { Servicio_2 = 0; }
        if (CC_AVANZADA.Checked == true) { Servicio_3 = 1; } else { Servicio_3 = 0; }
        if (CC_BASICA.Checked == true) { Servicio_4 = 1; } else { Servicio_4 = 0; }
        if (CC_SATELITAL.Checked == true) { Servicio_5 = 1; } else { Servicio_5 = 0; }
        if (CC_UPGRADE_TV.Checked == true) { Servicio_6 = 1; } else { Servicio_6 = 0; }
        if (CC_UPGRADE_INTERNET.Checked == true) { Servicio_7 = 1; } else { Servicio_7 = 0; }
        if (CC_INTERNET_3M.Checked == true) { Servicio_8 = 1; } else { Servicio_8 = 0; }
        if (CC_INTERNET_5M.Checked == true) { Servicio_9 = 1; } else { Servicio_9 = 0; }
        if (CC_INTERNET_10M.Checked == true) { Servicio_10 = 1; } else { Servicio_10 = 0; }
        if (CC_INTERNET_20M.Checked == true) { Servicio_11 = 1; } else { Servicio_11 = 0; }
        if (CC_INTERNET_50M.Checked == true) { Servicio_12 = 1; } else { Servicio_12 = 0; }
        if (CC_INTERNET_100M.Checked == true) { Servicio_13 = 1; } else { Servicio_13 = 0; }
        if (CC_CHECK_CLARO_VIDEO.Checked == true) { Servicio_14 = 1; } else { Servicio_14 = 0; }
        if (CC_CHECK_FOX.Checked == true) { Servicio_15 = 1; } else { Servicio_15 = 0; }
        if (CC_GOLDEN_PREMIER_HD.Checked == true) { Servicio_16 = 1; } else { Servicio_16 = 0; }
        if (CC_CHECK_HBO.Checked == true) { Servicio_17 = 1; } else { Servicio_17 = 0; }
        if (CC_CHECK_HD.Checked == true) { Servicio_18 = 1; } else { Servicio_18 = 0; }
        if (CC_HOTPACK.Checked == true) { Servicio_19 = 1; } else { Servicio_19 = 0; }
        if (CC_INTERNET_MOVIL_1_5.Checked == true) { Servicio_20 = 1; } else { Servicio_20 = 0; }
        if (CC_INTERNET_MOVIL_750.Checked == true) { Servicio_21 = 1; } else { Servicio_21 = 0; }
        if (CC_IP_FIJA.Checked == true) { Servicio_22 = 1; } else { Servicio_22 = 0; }
        if (CC_LOCAL_EXTENDIDA.Checked == true) { Servicio_23 = 1; } else { Servicio_23 = 0; }
        if (CC_MACAFEE.Checked == true) { Servicio_24 = 1; } else { Servicio_24 = 0; }
        if (CC_MINI_FOX.Checked == true) { Servicio_25 = 1; } else { Servicio_25 = 0; }
        if (CC_MINI_HBO.Checked == true) { Servicio_26 = 1; } else { Servicio_26 = 0; }
        if (CC_MODEM_ADICIONAL.Checked == true) { Servicio_27 = 1; } else { Servicio_27 = 0; }
        if (CC_PVR.Checked == true) { Servicio_28 = 1; } else { Servicio_28 = 0; }
        if (CC_PVR_HD.Checked == true) { Servicio_29 = 1; } else { Servicio_29 = 0; }
        if (CC_CHECK_REVISTA.Checked == true) { Servicio_30 = 1; } else { Servicio_30 = 0; }
        if (CC_SEGUNDO_MODEM.Checked == true) { Servicio_31 = 1; } else { Servicio_31 = 0; }
        if (CC_UFC.Checked == true) { Servicio_32 = 1; } else { Servicio_32 = 0; }
        if (CC_VOD.Checked == true) { Servicio_33 = 1; } else { Servicio_33 = 0; }
        if (CC_2CHECK_ELEGIDO_FIJO_MOVIL.Checked == true) { Servicio_34 = 1; } else { Servicio_34 = 0; }
        if (CC_2CHECK_CLARO_VIDEO.Checked == true) { Servicio_35 = 1; } else { Servicio_35 = 0; }
        if (CC_CONVENIO.Checked == true) { Servicio_36 = 1; } else { Servicio_36 = 0; }

        Obj_Entidad_Cierre_Ciclo.Usuario_Gestion = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Cierre_Ciclo.Aliado_Gestion = Session["Aliado_Usuario"].ToString();
        Obj_Entidad_Cierre_Ciclo.Cuenta = CC_Cuenta_Cliente.Text;
        Obj_Entidad_Cierre_Ciclo.Ofrecimiento_1_Envio = Ofrecimiento_1;
        Obj_Entidad_Cierre_Ciclo.Ofrecimiento_2_Envio = Ofrecimiento_2;
        Obj_Entidad_Cierre_Ciclo.Ofrecimiento_3_Envio = Ofrecimiento_3;
        Obj_Entidad_Cierre_Ciclo.Servicio_1 = Servicio_1;
        Obj_Entidad_Cierre_Ciclo.Servicio_2 = Servicio_2;
        Obj_Entidad_Cierre_Ciclo.Servicio_3 = Servicio_3;
        Obj_Entidad_Cierre_Ciclo.Servicio_4 = Servicio_4;
        Obj_Entidad_Cierre_Ciclo.Servicio_5 = Servicio_5;
        Obj_Entidad_Cierre_Ciclo.Servicio_6 = Servicio_6;
        Obj_Entidad_Cierre_Ciclo.Servicio_7 = Servicio_7;
        Obj_Entidad_Cierre_Ciclo.Servicio_8 = Servicio_8;
        Obj_Entidad_Cierre_Ciclo.Servicio_9 = Servicio_9;
        Obj_Entidad_Cierre_Ciclo.Servicio_10 = Servicio_10;
        Obj_Entidad_Cierre_Ciclo.Servicio_11 = Servicio_11;
        Obj_Entidad_Cierre_Ciclo.Servicio_12 = Servicio_12;
        Obj_Entidad_Cierre_Ciclo.Servicio_13 = Servicio_13;
        Obj_Entidad_Cierre_Ciclo.Servicio_14 = Servicio_14;
        Obj_Entidad_Cierre_Ciclo.Servicio_15 = Servicio_15;
        Obj_Entidad_Cierre_Ciclo.Servicio_16 = Servicio_16;
        Obj_Entidad_Cierre_Ciclo.Servicio_17 = Servicio_17;
        Obj_Entidad_Cierre_Ciclo.Servicio_18 = Servicio_18;
        Obj_Entidad_Cierre_Ciclo.Servicio_19 = Servicio_19;
        Obj_Entidad_Cierre_Ciclo.Servicio_20 = Servicio_20;
        Obj_Entidad_Cierre_Ciclo.Servicio_21 = Servicio_21;
        Obj_Entidad_Cierre_Ciclo.Servicio_22 = Servicio_22;
        Obj_Entidad_Cierre_Ciclo.Servicio_23 = Servicio_23;
        Obj_Entidad_Cierre_Ciclo.Servicio_24 = Servicio_24;
        Obj_Entidad_Cierre_Ciclo.Servicio_25 = Servicio_25;
        Obj_Entidad_Cierre_Ciclo.Servicio_26 = Servicio_26;
        Obj_Entidad_Cierre_Ciclo.Servicio_27 = Servicio_27;
        Obj_Entidad_Cierre_Ciclo.Servicio_28 = Servicio_28;
        Obj_Entidad_Cierre_Ciclo.Servicio_29 = Servicio_29;
        Obj_Entidad_Cierre_Ciclo.Servicio_30 = Servicio_30;
        Obj_Entidad_Cierre_Ciclo.Servicio_31 = Servicio_31;
        Obj_Entidad_Cierre_Ciclo.Servicio_32 = Servicio_32;
        Obj_Entidad_Cierre_Ciclo.Servicio_33 = Servicio_33;
        Obj_Entidad_Cierre_Ciclo.Servicio_34 = Servicio_34;
        Obj_Entidad_Cierre_Ciclo.Servicio_35 = Servicio_35;
        Obj_Entidad_Cierre_Ciclo.Servicio_36 = Servicio_36;
        Obj_Entidad_Cierre_Ciclo.Tipo_Contacto = Convert.ToString(CC_TIPO_CONTACTO.SelectedItem);
        Obj_Entidad_Cierre_Ciclo.Gestion = Convert.ToString(CC_GESTION.SelectedItem);
        Obj_Entidad_Cierre_Ciclo.Cierre = Convert.ToString(CC_CIERRE.SelectedItem);
        Obj_Entidad_Cierre_Ciclo.Razon = Convert.ToString(CC_RAZON.SelectedItem);
        Obj_Entidad_Cierre_Ciclo.Observaciones = CC_Observaciones.Text.ToUpper();
        Obj_Entidad_Cierre_Ciclo.Base = Base.Text;
        Obj_Entidad_Cierre_Ciclo.Operacion_Gestion = Operacion.Text;
    }


    
}