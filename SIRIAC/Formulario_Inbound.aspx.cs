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

public partial class Formulario_Inbound : System.Web.UI.Page
{
    public E_Usuarios Obj_Entidad_Usuarios = new E_Usuarios();
    public N_Usuarios Obj_Neg_Usuarios = new N_Usuarios();
    public E_Clientes Obj_Entidad_Clientes = new E_Clientes();
    public N_Clientes Obj_Neg_Clientes = new N_Clientes();
    public E_Ingreso Obj_Entidad_Ingresos = new E_Ingreso();
    public N_Ingresos Obj_Neg_Ingresos = new N_Ingresos();
    public E_Datos_Clientes Obj_Entidad_Datos_Cliente = new E_Datos_Clientes();
    public N_Datos_Cliente Obj_Neg_Datos_Clientes = new N_Datos_Cliente();
    public E_Marcaciones Obj_Entidad_Marcaciones = new E_Marcaciones();
    public N_Marcaciones Obj_Neg_Marcaciones = new N_Marcaciones();
    public E_Estado_Casos Obj_Entidad_Estado_Casos = new E_Estado_Casos();
    public N_Estado_Casos Obj_Neg_Estado_Casos = new N_Estado_Casos();
    public E_Nombre_Linea Obj_Entidad_Nombre_Linea = new E_Nombre_Linea();
    public N_Nombre_Linea Obj_Neg_Nombre_Linea = new N_Nombre_Linea();
    public E_Hobbies Obj_Entidad_Hobbies = new E_Hobbies();
    public N_Hobbies Obj_Neg_Hobbies = new N_Hobbies();
    public E_Servicios Obj_Entidad_Servicios = new E_Servicios();
    public N_Servicios Obj_Neg_Servicios = new N_Servicios();
    public E_Notas_Casos Obj_Entidad_Notas_Casos = new E_Notas_Casos();
    public N_Notas_Casos Obj_Neg_Notas_Casos = new N_Notas_Casos();
    public E_Cuentas_Genericas Obj_Entidad_Cuentas_Genericas = new E_Cuentas_Genericas();
    public N_Cuentas_Genericas Obj_Neg_Cuentas_Genericas = new N_Cuentas_Genericas();
    public E_Log_Transacciones Obj_Entidad_Transacciones = new E_Log_Transacciones();
    public N_Log_Transacciones Obj_Neg_Transacciones = new N_Log_Transacciones();
    public E_Incremento_Tarifa Obj_Entidad_Incremento = new E_Incremento_Tarifa();
    public N_Incremento_Tarifa Obj_Neg_Incremento = new N_Incremento_Tarifa();
    public E_Ofrecimientos_Incremento Obj_Entidad_Of_Incremento = new E_Ofrecimientos_Incremento();
    public N_Ofrecimientos_Incremento Obj_Neg_Of_Incremento = new N_Ofrecimientos_Incremento();
    public E_Regleta Obj_Entidad_Regleta = new E_Regleta();
    public N_Regleta Obj_Neg_Regleta = new N_Regleta();
    public E_Regleta_Adicionales Obj_Entidad_Regleta_Adicional = new E_Regleta_Adicionales();
    public N_Regleta_Adicionales Obj_Neg_Regleta_Adicional = new N_Regleta_Adicionales();
    public E_Convenio_Electronico obj_Entidad_Convenio_Electronico = new E_Convenio_Electronico();
    public N_Convenio_Electronico obj_neg_Convenio_Electronico = new N_Convenio_Electronico();
    public N_Mejor_Oferta obj_Neg_Mejor_Oferta = new N_Mejor_Oferta();
    public E_Mejor_Oferta obj_Entidad_Mejor_Oferta = new E_Mejor_Oferta();
    public E_Arbol_Outbound Obj_Entidad_Arbol_Outbound = new E_Arbol_Outbound();
    public N_Arbol_Outbound Obj_Neg_Arbol_Outbound = new N_Arbol_Outbound();
    public N_Claro_Video Obj_Neg_Claro_Video = new N_Claro_Video();
    public E_Claro_Video Obj_Entidad_Claro_Video = new E_Claro_Video();
    public N_Siembra_HD Obj_Neg_Siembra_HD = new N_Siembra_HD();
    public E_Siembra_HD Obj_Entidad_Siembra_HD = new E_Siembra_HD();
    public int sw1 = 0;
    public int sw2 = 0;
    public int sw3 = 0;
    public int sw4 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Acceso_1"].ToString() == "1") { } else { Response.Redirect("Bienvenida_Asesor.aspx?Acceso= " + Session["ACCESO_1"].ToString() + "--DENEGADO Gestión Inbound"); }
        if (Session["Rol_Usuario"].ToString() == "3") { }
        else { Response.Redirect("Inicio_de_Sesion.aspx?id=" + Session["Rol_Usuario"].ToString() + ""); }
        this.RadioButton1.Attributes.Add("OnClick", "javascript:return Ofrecimiento1SI();");
        this.RadioButton2.Attributes.Add("OnClick", "javascript:return Ofrecimiento1NO();");
        this.RadioButton3.Attributes.Add("OnClick", "javascript:return Ofrecimiento2SI();");
        this.RadioButton4.Attributes.Add("OnClick", "javascript:return Ofrecimiento2NO();");
        //this.RadioButton5.Attributes.Add("OnClick", "javascript:return Ofrecimiento3SI();");
        //this.RadioButton6.Attributes.Add("OnClick", "javascript:return Ofrecimiento3NO();");
        //this.RadioButton7.Attributes.Add("OnClick", "javascript:return Ofrecimiento4SI();");
        //this.RadioButton8.Attributes.Add("OnClick", "javascript:return Ofrecimiento4NO();");
        //this.RadioButton9.Attributes.Add("OnClick", "javascript:return Ofrecimiento5SI();");
        //this.RadioButton10.Attributes.Add("OnClick", "javascript:return Ofrecimiento5NO();");
        //this.RadioButton11.Attributes.Add("OnClick", "javascript:return Ofrecimiento6SI();");
        //this.RadioButton12.Attributes.Add("OnClick", "javascript:return Ofrecimiento6NO();");

        this.AC_Radio_1.Attributes.Add("OnClick", "javascript:return AC_Abrir_Primer_Calculo();");
        this.AC_Radio_2.Attributes.Add("OnClick", "javascript:return AC_Cerrar_Primer_Calculo();");
        this.AC_Radio_3.Attributes.Add("OnClick", "javascript:return AC_Abrir_Segundo_Calculo();");
        this.AC_Radio_4.Attributes.Add("OnClick", "javascript:return AC_Cerrar_Segundo_Calculo();");
        this.AC_Radio_5.Attributes.Add("OnClick", "javascript:return AC_Abrir_Tercer_Calculo();");
        this.AC_Radio_6.Attributes.Add("OnClick", "javascript:return AC_Cerrar_Tercer_Calculo();");



        this.SMO_Radio_1.Attributes.Add("OnClick", "javascript:return Ofrecimiento_SMO_1_SI();");
        this.SMO_Radio_2.Attributes.Add("OnClick", "javascript:return Ofrecimiento_SMO_1_NO();");
        this.SMO_Radio_3.Attributes.Add("OnClick", "javascript:return Ofrecimiento_SMO_2_SI();");
        this.SMO_Radio_4.Attributes.Add("OnClick", "javascript:return Ofrecimiento_SMO_2_NO();");
        this.SMO_Radio_5.Attributes.Add("OnClick", "javascript:return Ofrecimiento_SMO_3_SI();");
        this.SMO_Radio_6.Attributes.Add("OnClick", "javascript:return Ofrecimiento_SMO_3_NO();");




        string script = "otorgar_permisos();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "carga", script, true);
        string script2 = "otorgar_permisos2();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "carga", script2, true);
    }
    protected void Cuenta_Cliente_TextChanged(object sender, EventArgs e)
    {
        SMO_Limpiar_Controles();
        string script10 = "Banner_Alertas_Inicio();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "Banner_Alertas_Inicio()", script10, true);

        DataSet dt = new DataSet();
        Obj_Entidad_Clientes.Cuenta_Cliente = Cuenta_Cliente.Text;
        dt = Obj_Neg_Clientes.Consulta_Cliente(Obj_Entidad_Clientes.Cuenta_Cliente);

        if (dt.Tables[0].Rows.Count > 0)
        {
            Nombre_Cliente.Text = dt.Tables[0].Rows[0]["NOMBRE"].ToString();
            Apellido_Cliente.Text = dt.Tables[0].Rows[0]["APELLIDO"].ToString();
            Cedula_Cliente.Text = dt.Tables[0].Rows[0]["CEDULA"].ToString();
            Telefono_Telmex.Text = dt.Tables[0].Rows[0]["TELEFONO_TELMEX"].ToString();
            Telefono_1.Text = dt.Tables[0].Rows[0]["TELEFONO_1"].ToString();
            Telefono_2.Text = dt.Tables[0].Rows[0]["TELEFONO_2"].ToString();
            Telefono_3.Text = dt.Tables[0].Rows[0]["TELEFONO_3"].ToString();
            Direccion_Instalacion.Text = dt.Tables[0].Rows[0]["DIR_INSTALACION"].ToString();
            Direccion_Correspondencia.Text = dt.Tables[0].Rows[0]["DIR_CORRESPONDENCIA"].ToString();
            Nodo.Text = dt.Tables[0].Rows[0]["NODO"].ToString();
            Red.Text = dt.Tables[0].Rows[0]["RED"].ToString();
            Division.Text = dt.Tables[0].Rows[0]["DIVISION"].ToString();
            Area.Text = dt.Tables[0].Rows[0]["AREA"].ToString();
            Zona.Text = dt.Tables[0].Rows[0]["ZONA"].ToString();
            Distrito.Text = dt.Tables[0].Rows[0]["DISTRITO"].ToString();
            Nombre_Comunidad.Text = dt.Tables[0].Rows[0]["NOMBRE_COMUNIDAD"].ToString();
            Estrato.Text = dt.Tables[0].Rows[0]["ESTRATO"].ToString();
            Tipo_Cliente.Text = dt.Tables[0].Rows[0]["TIPO_CLIENTE"].ToString();
            Descripcion.Text = dt.Tables[0].Rows[0]["DESCRIPCION"].ToString();

            R_Ciudad_Cliente.Items.Clear();
            R_Ciudad_Cliente.Items.Add(dt.Tables[0].Rows[0]["NOMBRE_COMUNIDAD"].ToString());
            R_Estrato_Cliente.Items.Clear();
            R_Estrato_Cliente.Items.Add(dt.Tables[0].Rows[0]["ESTRATO"].ToString());



            DataSet dt2 = new DataSet();
            Obj_Entidad_Incremento.Cuenta_Cliente = Convert.ToInt64(Cuenta_Cliente.Text);
            dt2 = Obj_Neg_Incremento.Consulta_Incremento(Obj_Entidad_Incremento.Cuenta_Cliente);
            if (dt2.Tables[0].Rows.Count > 0)
            {
                Incremento_Cuenta_Cliente.Text = Cuenta_Cliente.Text;
                Incremento_Nombre_Cliente.Text = dt.Tables[0].Rows[0]["NOMBRE"].ToString();
                Incremento_Apellido_Cliente.Text = dt.Tables[0].Rows[0]["APELLIDO"].ToString();
                Incremento_Ciudad_Residencia.Text = dt.Tables[0].Rows[0]["NOMBRE_COMUNIDAD"].ToString();
                Incremento_Estrato.Text = dt.Tables[0].Rows[0]["ESTRATO"].ToString();
                Incremento_Tipo_Cliente.Text = dt.Tables[0].Rows[0]["DESCRIPCION"].ToString();
                Incremento_Tarifa_Anterior.Text = dt2.Tables[0].Rows[0]["TARIFA_ANTERIOR"].ToString();
                Incremento_Tarifa_Nueva.Text = dt2.Tables[0].Rows[0]["TARIFA_NUEVA"].ToString();
                Incremento_Incrmento_Real.Text = dt2.Tables[0].Rows[0]["INCREMENTO_REAL"].ToString();
                Incremento_Renta_Sin_Incrmento.Text = dt2.Tables[0].Rows[0]["RENTA_SIN_INCREMENTO"].ToString();
                Incremento_Nueva_Renta.Text = dt2.Tables[0].Rows[0]["NUEVA_RENTA"].ToString();
                Incremento_Direfencia.Text = dt2.Tables[0].Rows[0]["DIFERENCIA"].ToString();
                Incremento_Paquete_Actual.Text = dt2.Tables[0].Rows[0]["PRODUCTOS"].ToString();
                Incremento_Velocidad_Internet.Text = dt2.Tables[0].Rows[0]["VELOCIDAD_INTERNET"].ToString();
                Incremento_Tipo_Television.Text = dt2.Tables[0].Rows[0]["TIPO_TELEVISION"].ToString();
                Incremento_Servicio_Hd.Text = dt2.Tables[0].Rows[0]["SERVICIO_HD"].ToString();
                Incremento_Elegido_Movil.Text = dt2.Tables[0].Rows[0]["ELEGIDO_FIJO_MOVIL"].ToString();
                Incremento_Claro_Video.Text = dt2.Tables[0].Rows[0]["CLARO_VIDEO"].ToString();
                Incremento_Postpago_Movil.Text = dt2.Tables[0].Rows[0]["POSPAGO_MOVIL"].ToString();
                Incremento_Plan_Ld30.Text = dt2.Tables[0].Rows[0]["LD_30"].ToString();
                Incremento_Apto_Tecnologia.Text = dt2.Tables[0].Rows[0]["TECNOLOGIA"].ToString();
                Incremento_Llamadas_Moviles.Text = dt2.Tables[0].Rows[0]["VALOR_LLAMADAS_COMCEL"].ToString();
                Incremento_Otros_Operadores.Text = dt2.Tables[0].Rows[0]["MINUTOS_LD_OTROS_OPERADORES"].ToString();
                Incremento_Primer_Oprecimiento.Text = dt2.Tables[0].Rows[0]["PRIMER_OFRECIMIENTO"].ToString();
                Incremento_Segundo_Ofrecimiento.Text = dt2.Tables[0].Rows[0]["SEGUNDO_OFRECIMIENTO"].ToString();
                Incremento_Tercer_Ofrecimiento.Text = dt2.Tables[0].Rows[0]["TERCER_OFRECIMIENTO"].ToString();
                Incremento_Cuarto_Ofrecimiento.Text = dt2.Tables[0].Rows[0]["CUARTO_OFRECIMIENTO"].ToString();
                Incremento_Quinto_Ofrecimiento.Text = dt2.Tables[0].Rows[0]["QUINTO_OFRECIMIENTO"].ToString();
                Incremento_Sexto_Ofrecimiento.Text = dt2.Tables[0].Rows[0]["SEXTO_OFRECIMIENTO"].ToString();
                Incremento_Periodo_Ofrecimiento.Text = dt2.Tables[0].Rows[0]["PERIODO_INCREMENTO"].ToString();

            }
            else
            {
                Limpiar_Incremento();
                Guardar_Ofrecimiento.Enabled = false;
            }
            this.Datos_Adicionales_Cliente(sender, e);
            Hobbies();
            this.Carga_Tipo_Regleta(sender, e);
            Nombre_Linea();
            Estado_Casos();
            Lista_Servicios();
            if (Session["Acceso_6"].ToString() == "1")
            {
                this.Carga_Casos_Abiertos(sender, e);
                this.Carga_Casos_Cerrados(sender, e);
            }
            else
            {
                Panel15.Visible = false;
            }
            this.Paquetes_Triples(sender, e);
            this.Paquetes_Dobles(sender, e);
            this.Paquetes_Sencillos(sender, e);
            //ESTA CONSULTA VERIFICA SI EL CLIENTE TIENE ACTIVO O NO EL CONVENIO ELECTRONICO//
            try
            {
                DataSet dt3 = new DataSet();
                obj_Entidad_Convenio_Electronico.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);
                dt3 = obj_neg_Convenio_Electronico.Consulta_Falta_Convenio(Obj_Entidad_Clientes.Cuenta_Cliente);
                if (dt3.Tables[0].Rows.Count > 0)
                {
                    string script1 = "Activar_Conveio();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Activar_Conveio()", script1, true);
                    sw1 = 1;
                }
                else
                {
                    string script1 = "No_Activar_Conveio();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "No_Activar_Conveio()", script1, true);
                    sw1 = 0;
                }
            }
            catch (Exception esc)
            { throw new Exception("Error al Consultar la cuenta del cliente", esc); }

            //ESTA CONSULTA CARGA LA INFORMACION DE SIGUIENTE MEJOR OFERTA//
            try
            {
                SMO_Cuenta_Cliente.Text = Cuenta_Cliente.Text;
                SMO_Nombre_Cliente.Text = Nombre_Cliente.Text;
                SMO_Apellido_Cliente.Text = Apellido_Cliente.Text;
                SMO_Doc_Identidad.Text = Cedula_Cliente.Text;

                DataSet dtSMO = new DataSet();
                obj_Entidad_Mejor_Oferta.Cuenta = Convert.ToDouble(SMO_Cuenta_Cliente.Text);
                dtSMO = obj_Neg_Mejor_Oferta.Consulta_Temporal_Cuentas(obj_Entidad_Mejor_Oferta.Cuenta);
                if (dtSMO.Tables[0].Rows.Count > 0)
                {
                    SMO_Mix_Basico.Text = dtSMO.Tables[0].Rows[0]["MIX_BASICO"].ToString();
                    SMO_Television.Text = dtSMO.Tables[0].Rows[0]["SERVICIO_TV"].ToString();
                    SMO_Internet.Text = dtSMO.Tables[0].Rows[0]["SERVICIO_INTERNET"].ToString();
                    SMO_Telefonia.Text = dtSMO.Tables[0].Rows[0]["SERVICIO_VOZ"].ToString();
                    SMO_HD.Text = dtSMO.Tables[0].Rows[0]["HD"].ToString();
                    SMO_HBO.Text = dtSMO.Tables[0].Rows[0]["HBO"].ToString();
                    SMO_Fox.Text = dtSMO.Tables[0].Rows[0]["FOX"].ToString();
                    SMO_Servicio_Adulto.Text = dtSMO.Tables[0].Rows[0]["ADULTO"].ToString();
                    SMO_Servicio_Claro_Video.Text = dtSMO.Tables[0].Rows[0]["CLAROVIDEO"].ToString();
                    SMO_Num_Decos.Text = dtSMO.Tables[0].Rows[0]["NUM_DECOS"].ToString();
                    SMO_Revista.Text = dtSMO.Tables[0].Rows[0]["REVISTA"].ToString();
                    SMO_Elegido_Fijo_Movil.Text = dtSMO.Tables[0].Rows[0]["ELEGIDO_FIJO_MOVIL"].ToString();
                    SMO_Siembra_HD.Text = dtSMO.Tables[0].Rows[0]["SIEMBRA_HD"].ToString();
                    SMO_Blindaje_Internet.Text = dtSMO.Tables[0].Rows[0]["BLINDAJE_INTERNET"].ToString();
                    SMO_Siembra_Voz.Text = dtSMO.Tables[0].Rows[0]["SIEMBRA_VOZ"].ToString();
                    SMO_Activacion_Claro_Video.Text = dtSMO.Tables[0].Rows[0]["ACTIVACION_CLAROVIDEO"].ToString();
                    SMO_T_Ofrecimiento_1.Text = dtSMO.Tables[0].Rows[0]["OFRECIMIENTO_1"].ToString();
                    SMO_T_Ofrecimiento_2.Text = dtSMO.Tables[0].Rows[0]["OFRECIMIENTO_2"].ToString();
                    SMO_T_Ofrecimiento_3.Text = dtSMO.Tables[0].Rows[0]["OFRECIMIENTO_3"].ToString();
                    SMO_Tipo_Contacto();
                    SMO_Gestion();
                    SMO_Cierre();
                    SMO_Razon();

                    string script1 = "SMO_Activar();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "SMO_Activar()", script1, true);
                    sw2 = 1;
                }
                else
                {
                    string script1 = "SMO_Desactivar();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "SMO_Desactivar()", script1, true);
                    sw2 = 0;
                }
            }
            catch (Exception esc)
            {
                throw new Exception("Error al Consultar la cuenta del cliente Siguiente Mejor Oferta", esc);
            }
            SMO_Tipo_Contacto();
            SMO_Gestion();
            SMO_Cierre();
            SMO_Razon();

            //ESTA CONSULTA CARGA LA INFORMACION DE CLARO VIDEO//
            try
            {
                DataSet CVdt = new DataSet();
                Obj_Entidad_Claro_Video.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);
                CVdt = Obj_Neg_Claro_Video.Consulta_Falta_Activacion_Claro_Video(Obj_Entidad_Claro_Video.Cuenta_Cliente);
                if (CVdt.Tables[0].Rows.Count > 0)
                {
                    string script1 = "CV_Activar();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "CV_Activar()", script1, true);
                }
                else
                {
                    string script1 = "CV_Desactivar();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "CV_Desactivar()", script1, true);
                }
            }
            catch (Exception esc)
            {
                throw new Exception("Error al Consultar la cuenta del cliente beneficios claro video", esc);
            }

            //ESTA CONSULTA CARGA LA INFORMACION DE SIEMBRA HD//
            try
            {
                DataSet SHDdt = new DataSet();
                Obj_Entidad_Siembra_HD.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);
                SHDdt = Obj_Neg_Siembra_HD.Consulta_Falta_Siembra_HD(Obj_Entidad_Siembra_HD.Cuenta_Cliente);
                if (SHDdt.Tables[0].Rows.Count > 0)
                {
                    S_HD_OFRECIMIENTO.Text = SHDdt.Tables[0].Rows[0]["OFRECIMIENTO"].ToString();
                    string script1 = "HD_Activar();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "HD_Activar()", script1, true);
                }
                else
                {
                    string script1 = "HD_Desactivar();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "HD_Desactivar()", script1, true);
                }
            }
            catch (Exception esc)
            {
                throw new Exception("Error al Consultar la cuenta del cliente siembra HD", esc);
            }
        }
        else
        {
            this.Carga_Casos_Abiertos(sender, e);
            this.Carga_Casos_Cerrados(sender, e);
            string script = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script, true);

            Limpiar();
            Limpiar2();
            Colores_Blanco();
            Limpiar_General();
            Limpiar_Incremento();
        }



        if (sw1 == 1 || sw2 == 1)
        {
            string scriptMEC = "Activar_Envia_MEC();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Activar_Envia_MEC()", scriptMEC, true);
        }

    }
    private void Datos_Adicionales_Cliente(object sender, EventArgs e)
    {
        try
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Datos_Cliente.Cuenta_Cliente = Convert.ToInt64(Cuenta_Cliente.Text);
            dt = Obj_Neg_Datos_Clientes.Consulta_Datos_Cliente(Obj_Entidad_Datos_Cliente.Cuenta_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                Correo_Electronico.Text = dt.Tables[0].Rows[0]["CORREO_ELECTRONICO"].ToString();
                Telefono_Personal.Text = dt.Tables[0].Rows[0]["TELEFONO_PERSONAL"].ToString();
                Fecha_Cumpleaños.Text = dt.Tables[0].Rows[0]["FECHA_CUMPLEANOS"].ToString();
                Rango_Edad.Text = dt.Tables[0].Rows[0]["RANGO_DE_EDAD"].ToString();
                Nivel_de_Estudios.Text = dt.Tables[0].Rows[0]["NIVEL_ESTUDIOS"].ToString();
                Hobby.Text = dt.Tables[0].Rows[0]["HOBBIE"].ToString();
                Twitter.Text = dt.Tables[0].Rows[0]["TWITTER"].ToString();
                Facebook.Text = dt.Tables[0].Rows[0]["FACEBOOK"].ToString();
                Instagram.Text = dt.Tables[0].Rows[0]["INSTAGRAM"].ToString();
                Otro.Text = dt.Tables[0].Rows[0]["OTRO"].ToString();
                Numero_de_Hijos.Text = dt.Tables[0].Rows[0]["NUMERO_HIJOS"].ToString();
                Edad_Hijos.Text = dt.Tables[0].Rows[0]["EDAD_HIJOS"].ToString();
                Colores_Verde();
            }
            else
            {
                Colores_Rojo();
                Limpiar2();
                Correo_Electronico.Text = "ACTUALIZARCORREO@YA.COM";
                Telefono_Personal.Text = "0";
                Fecha_Cumpleaños.Text = "1990-01-01";
                Twitter.Text = "NO TIENE";
                Facebook.Text = "NO TIENE";
                Instagram.Text = "NO TIENE";
                Otro.Text = "NO TIENE";
            }
        }
        catch (Exception esp)
        { throw new Exception("Error al Consultar los datos del cliente", esp); }
    }
    private void Colores_Verde()
    {
        Correo_Electronico.BackColor = Color.FromArgb(212, 255, 225);
        Telefono_Personal.BackColor = Color.FromArgb(212, 255, 225);
        Fecha_Cumpleaños.BackColor = Color.FromArgb(212, 255, 225);
        Rango_Edad.BackColor = Color.FromArgb(212, 255, 225);
        Nivel_de_Estudios.BackColor = Color.FromArgb(212, 255, 225);
        Hobby.BackColor = Color.FromArgb(212, 255, 225);
        Twitter.BackColor = Color.FromArgb(212, 255, 225);
        Facebook.BackColor = Color.FromArgb(212, 255, 225);
        Instagram.BackColor = Color.FromArgb(212, 255, 225);
        Otro.BackColor = Color.FromArgb(212, 255, 225);
        Numero_de_Hijos.BackColor = Color.FromArgb(212, 255, 225);
        Edad_Hijos.BackColor = Color.FromArgb(212, 255, 225);

    }
    private void Colores_Rojo()
    {
        Correo_Electronico.BackColor = Color.FromArgb(255, 228, 225);
        Telefono_Personal.BackColor = Color.FromArgb(255, 228, 225);
        Fecha_Cumpleaños.BackColor = Color.FromArgb(255, 228, 225);
        Rango_Edad.BackColor = Color.FromArgb(255, 228, 225);
        Nivel_de_Estudios.BackColor = Color.FromArgb(255, 228, 225);
        Hobby.BackColor = Color.FromArgb(255, 228, 225);
        Twitter.BackColor = Color.FromArgb(255, 228, 225);
        Facebook.BackColor = Color.FromArgb(255, 228, 225);
        Instagram.BackColor = Color.FromArgb(255, 228, 225);
        Otro.BackColor = Color.FromArgb(255, 228, 225);
        Numero_de_Hijos.BackColor = Color.FromArgb(255, 228, 225);
        Edad_Hijos.BackColor = Color.FromArgb(255, 228, 225);

    }
    private void Colores_Blanco()
    {
        Correo_Electronico.BackColor = Color.White;
        Telefono_Personal.BackColor = Color.White;
        Fecha_Cumpleaños.BackColor = Color.White;
        Rango_Edad.BackColor = Color.White;
        Nivel_de_Estudios.BackColor = Color.White;
        Hobby.BackColor = Color.White;
        Twitter.BackColor = Color.White;
        Facebook.BackColor = Color.White;
        Instagram.BackColor = Color.White;
        Otro.BackColor = Color.White;
        Numero_de_Hijos.BackColor = Color.White;
        Edad_Hijos.BackColor = Color.White;

    }
    private void Limpiar()
    {
        Cuenta_Cliente.Text = string.Empty;
        Nombre_Cliente.Text = string.Empty;
        Apellido_Cliente.Text = string.Empty;
        Cedula_Cliente.Text = string.Empty;
        Telefono_Telmex.Text = string.Empty;
        Telefono_1.Text = string.Empty;
        Telefono_2.Text = string.Empty;
        Telefono_3.Text = string.Empty;
        Direccion_Instalacion.Text = string.Empty;
        Direccion_Correspondencia.Text = string.Empty;
        Nodo.Text = string.Empty;
        Red.Text = string.Empty;
        Division.Text = string.Empty;
        Area.Text = string.Empty;
        Zona.Text = string.Empty;
        Distrito.Text = string.Empty;
        Nombre_Comunidad.Text = string.Empty;
        Estrato.Text = string.Empty;
        Tipo_Cliente.Text = string.Empty;
        Descripcion.Text = string.Empty;
        ADT_Nombre_Cliente.Text = string.Empty;
        ADT_Apellido_Cliente.Text = string.Empty;
        ADT_Estrato_Cliente.Text = string.Empty;

    }
    private void Limpiar2()
    {
        Correo_Electronico.Text = string.Empty;
        Telefono_Personal.Text = string.Empty;
        Fecha_Cumpleaños.Text = string.Empty;
        Rango_Edad.ClearSelection();
        Nivel_de_Estudios.ClearSelection();
        Hobby.ClearSelection();
        Twitter.Text = string.Empty;
        Facebook.Text = string.Empty;
        Instagram.Text = string.Empty;
        Otro.Text = string.Empty;
        Numero_de_Hijos.ClearSelection();
        Edad_Hijos.ClearSelection();

        ADT_Nombre_Cliente.Text = string.Empty;
        ADT_Apellido_Cliente.Text = string.Empty;
        ADT_Estrato_Cliente.Text = string.Empty;

    }
    protected void Boton_Calendario_Click(object sender, EventArgs e)
    {
        Calendar1.SelectedDate = DateTime.Now;
        if (Calendar1.Visible == true) { Calendar1.Visible = false; }
        else
        {
            Calendar1.Visible = true;

        }
        Calendar1.VisibleDate = Calendar1.TodaysDate;

        Calendar1.SelectedDates.Clear();

    }
    protected void Lista_Marcaciones_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();


        Obj_Entidad_Marcaciones.Id_Marcacion = Convert.ToInt16(Lista_Marcaciones.SelectedValue);

        dt = Obj_Neg_Marcaciones.Consulta_Marcaciones_Id(Obj_Entidad_Marcaciones.Id_Marcacion);



        if (dt.Tables[0].Rows.Count > 0)
        {
            Macroproceso.DataSource = dt;
            Macroproceso.DataTextField = "MACROPROCESO";
            Macroproceso.DataBind();
            //
            Proceso.DataSource = dt;
            Proceso.DataTextField = "TIPO_DE_NOVEDAD";
            Proceso.DataBind();
            //
            Subproceso.DataSource = dt;
            Subproceso.DataTextField = "TIPO_DE_SOLICITUD";
            Subproceso.DataBind();
            //
            Posible_Causa.Text = dt.Tables[0].Rows[0]["POSIBLE_CAUSA"].ToString();
            Que_Hacer.Text = dt.Tables[0].Rows[0]["QUE_HACER"].ToString();
            Codigos_de_Cierre.Text = dt.Tables[0].Rows[0]["CODIGOS_DE_CIERRE"].ToString();
            Area_Usuario_Escalar.Text = dt.Tables[0].Rows[0]["AREA_USUARIO_ESCALAR"].ToString();
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
            Solucion.DataSource = dt;
            Solucion.DataTextField = "SPC";
            Solucion.DataBind();
        }
    }
    protected void Estado_Caso_TextChanged(object sender, EventArgs e)
    {
        var Id_Estado = Estado_Caso.SelectedValue;

        if (Id_Estado == "1")
        {
            Nombre_Linea();
            Area_Escalar.Enabled = true;
            Label38.Text = Estado_Caso.SelectedValue;
            Label39.Text = Servicios.SelectedValue;
        }
        else
            if (Id_Estado == "2")
        {
            Area_Escalar.Items.Clear();
            Area_Escalar.Enabled = false;
            Label38.Text = Estado_Caso.SelectedValue;
            Label39.Text = Servicios.SelectedValue;
        }
        else
                if (Id_Estado == "3")
        {
            Area_Escalar.Items.Clear();
            Area_Escalar.Enabled = false;
            Label38.Text = Estado_Caso.SelectedValue;
            Label39.Text = Servicios.SelectedValue;
        }
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Fecha_Cumpleaños.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
        Calendar1.Visible = false;
    }
    protected void Caja_consulta_TextChanged(object sender, EventArgs e)
    {

        DataSet dt = new DataSet();

        Obj_Entidad_Marcaciones.Descipcion = Caja_consulta.Text;
        dt = Obj_Neg_Marcaciones.Consulta_Marcaciones(Obj_Entidad_Marcaciones.Descipcion);



        if (dt.Tables[0].Rows.Count > 0)
        {
            Lista_Marcaciones.DataSource = dt;
            Lista_Marcaciones.DataTextField = "DESCRIPCION";
            Lista_Marcaciones.DataValueField = "ID";
            Lista_Marcaciones.DataBind();

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
            Estado_Caso.Items.Insert(0, "--SELECCIONE--");
        }
    }
    /* private void Nombre_Linea()
     {
         DataSet dt = new DataSet();
         Obj_Entidad_Nombre_Linea.Nombre_Linea = Session["Nombre_Linea_Usuario"].ToString();
         dt = Obj_Neg_Nombre_Linea.Consulta_Nombre_Linea(Obj_Entidad_Nombre_Linea.Nombre_Linea);

         if (dt.Tables[0].Rows.Count > 0)
         {

             Area_Escalar.DataSource = dt;
             Area_Escalar.DataTextField = "NOMBRE_LINEA";
             Area_Escalar.DataValueField = "NOMBRE_LINEA";
             Area_Escalar.DataBind();
         }
     }*/
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
            Area_Escalar.Items.Insert(0, "--SELECCIONE--");
        }
    }
    private void Hobbies()
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Hobbies.Selecciona_Hobbies();

        if (dt.Tables[0].Rows.Count > 0)
        {

            Hobby.DataSource = dt;
            Hobby.DataTextField = "HOBBY";
            Hobby.DataValueField = "HOBBY";
            Hobby.DataBind();
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
    private void Controles_a_Objetos()
    {
        //TABLA DE INGRESOS
        var Semaforo_Caso = "";
        var Val_Semaforo = Estado_Caso.SelectedValue;
        if (Val_Semaforo == "1") { Semaforo_Caso = "verde.gif"; }
        else
            if (Val_Semaforo == "2") { Semaforo_Caso = "gris01.png"; }
        else
                if (Val_Semaforo == "3") { Semaforo_Caso = "verde.gif"; }

        var Tiempo_Respuesta_Caso = 1;
        var Llamada_Cliente_Inicial = "SI";
        Obj_Entidad_Ingresos.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);
        Obj_Entidad_Ingresos.Ticket = Convert.ToDouble(Pqr.Text);
        Obj_Entidad_Ingresos.Usuario_Apertura = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Ingresos.Usuario_Ultima_Actualizacion = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Ingresos.Macroproceso = Macroproceso.Text;
        Obj_Entidad_Ingresos.Proceso = Proceso.Text;
        Obj_Entidad_Ingresos.Subproceso = Subproceso.Text;
        Obj_Entidad_Ingresos.Marcacion = Marcacion.Text;
        Obj_Entidad_Ingresos.Id_Estado = Convert.ToInt16(Estado_Caso.SelectedValue);
        Obj_Entidad_Ingresos.Semaforo = Semaforo_Caso;
        Obj_Entidad_Ingresos.Tiempo_Respuesta = Tiempo_Respuesta_Caso;
        Obj_Entidad_Ingresos.Aliado_Apertura = Session["Aliado_Usuario"].ToString();
        Obj_Entidad_Ingresos.Nombre_Linea_Ingreso = Session["Nombre_Linea_Usuario"].ToString();
        Obj_Entidad_Ingresos.Nombre_Linea_Escalado = Area_Escalar.Text;
        Obj_Entidad_Ingresos.Id_Servicio = Convert.ToInt16(Servicios.SelectedValue);
        //TABLA DATOS ADICIONALES DEL CLIENTE
        Obj_Entidad_Datos_Cliente.Cuenta_Cliente = Convert.ToInt64(Cuenta_Cliente.Text);
        Obj_Entidad_Datos_Cliente.Correo_Electronico = Correo_Electronico.Text;
        Obj_Entidad_Datos_Cliente.Telefono_Personal = Convert.ToInt64(Telefono_Personal.Text);
        Obj_Entidad_Datos_Cliente.Fecha_Cumpleanos = Fecha_Cumpleaños.Text;
        Obj_Entidad_Datos_Cliente.Rango_Edad = Rango_Edad.Text;
        Obj_Entidad_Datos_Cliente.Nivel_Estudios = Nivel_de_Estudios.Text;
        Obj_Entidad_Datos_Cliente.Hobbie = Hobby.Text;
        Obj_Entidad_Datos_Cliente.Twitter = Twitter.Text;
        Obj_Entidad_Datos_Cliente.Facebook = Facebook.Text;
        Obj_Entidad_Datos_Cliente.Instagram = Instagram.Text;
        Obj_Entidad_Datos_Cliente.Otro = Otro.Text;
        Obj_Entidad_Datos_Cliente.Numero_Hijos = Numero_de_Hijos.Text;
        Obj_Entidad_Datos_Cliente.Edad_Hijos = Edad_Hijos.Text;
        //TABLA NOTAS DE LOS CASOS
        Obj_Entidad_Notas_Casos.Cuenta_Cliente = Convert.ToInt64(Cuenta_Cliente.Text);
        Obj_Entidad_Notas_Casos.Id_Ingreso = Convert.ToInt64("0");
        Obj_Entidad_Notas_Casos.Ticket = Convert.ToInt64(Pqr.Text);
        Obj_Entidad_Notas_Casos.Usuario = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Notas_Casos.Nombre_Linea_Nota = Session["Nombre_Linea_Usuario"].ToString();
        Obj_Entidad_Notas_Casos.Llamada_Cliente = Llamada_Cliente_Inicial;
        Obj_Entidad_Notas_Casos.Nota = Notas.Text.ToUpper();
        Obj_Entidad_Notas_Casos.Id_Estado = Convert.ToInt16(Estado_Caso.SelectedValue);
        //TABLA DE TRANSACCIONES
        Obj_Entidad_Transacciones.Id_Ingreso = 0;
        Obj_Entidad_Transacciones.Transaccion = "CREACION CASO";
        Obj_Entidad_Transacciones.Usuario = Session["Usuario_Logueado"].ToString();

        if (Convert.ToString(Estado_Caso.SelectedValue) == "1") { Obj_Entidad_Ingresos.Usuario_Cierre = ""; }
        else if (Convert.ToString(Estado_Caso.SelectedValue) == "2") { Obj_Entidad_Ingresos.Usuario_Cierre = Session["Usuario_Logueado"].ToString(); }
        else if (Convert.ToString(Estado_Caso.SelectedValue) == "3") { Obj_Entidad_Ingresos.Usuario_Cierre = ""; }

    }
    private void Maximo_Ingreso()
    {
        try
        {
            DataSet dt = new DataSet();

            Obj_Entidad_Ingresos.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);
            dt = Obj_Neg_Ingresos.Selecciona_Maximo_Ingreso_Cuenta(Obj_Entidad_Ingresos.Cuenta_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                Obj_Entidad_Notas_Casos.Id_Ingreso = Convert.ToInt64(dt.Tables[0].Rows[0]["ID_INGRESO"].ToString());
                Obj_Entidad_Transacciones.Id_Ingreso = Convert.ToInt64(dt.Tables[0].Rows[0]["ID_INGRESO"].ToString());
            }
        }
        catch (Exception exb)
        {
            throw new Exception("Error al Seleccionar Usuario", exb);
        }
    }
    private void Guardar_Cliente_Generico()
    {

        var Guardar_Datos = -1;
        Controles_a_Objetos();
        Guardar_Datos = Obj_Neg_Ingresos.abcIngresos("INSERTAR", Obj_Entidad_Ingresos);
        if (Guardar_Datos != -1)
        {
            Maximo_Ingreso();
            var Guardar_Notas_Casos = -1;
            Guardar_Notas_Casos = Obj_Neg_Notas_Casos.Inserta_Nota_Inicial("INSERTAR", Obj_Entidad_Notas_Casos);
            if (Guardar_Notas_Casos != -1)
            {
                string script1 = "mensaje3();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje3", script1, true);
            }
            else { }

        }
        else
        {
            string script = "mensaje6();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje6", script, true);
        }
    }
    private void Guardar_Cliente_Real()
    {
        Controles_a_Objetos();

        DataSet dt1 = new DataSet();
        dt1 = Obj_Neg_Ingresos.Marcaciones_Escaladas(Obj_Entidad_Ingresos.Cuenta_Cliente, Obj_Entidad_Ingresos.Marcacion);
        if (dt1.Tables[0].Rows.Count > 0)
        {
            string script2 = "mensaje4();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje4", script2, true);

        }
        else
        {

            var Guardar_Datos = -1;
            Guardar_Datos = Obj_Neg_Ingresos.abcIngresos("INSERTAR", Obj_Entidad_Ingresos);
            if (Guardar_Datos != -1)
            {
                Maximo_Ingreso();
                var Guardar_Notas_Casos = -1;
                Guardar_Notas_Casos = Obj_Neg_Notas_Casos.Inserta_Nota_Inicial("INSERTAR", Obj_Entidad_Notas_Casos);
                if (Guardar_Notas_Casos != -1)
                {
                    string script1 = "mensaje3();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje3", script1, true);
                }
                else { }

            }
            else
            {
                string script = "mensaje6();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje6", script, true);
            }

            DataSet dt = new DataSet();
            dt = Obj_Neg_Datos_Clientes.Consulta_Datos_Cliente(Obj_Entidad_Datos_Cliente.Cuenta_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                var Actualizar_Datos_Cliente = -1;
                Actualizar_Datos_Cliente = Obj_Neg_Datos_Clientes.acb_Datos_Adicionales_Clientes("ACTUALIZAR", Obj_Entidad_Datos_Cliente);

            }
            else
            {
                var Guardar_Datos_Ad_Clientes = -1;
                Guardar_Datos_Ad_Clientes = Obj_Neg_Datos_Clientes.acb_Datos_Adicionales_Clientes("INSERTAR", Obj_Entidad_Datos_Cliente);
            }
        }
    }
    private void Limpiar_General()
    {
        Cuenta_Cliente.Text = string.Empty;
        Nombre_Cliente.Text = string.Empty;
        Apellido_Cliente.Text = string.Empty;
        Cedula_Cliente.Text = string.Empty;
        Telefono_Telmex.Text = string.Empty;
        Telefono_1.Text = string.Empty;
        Telefono_2.Text = string.Empty;
        Telefono_3.Text = string.Empty;
        Direccion_Instalacion.Text = string.Empty;
        Direccion_Correspondencia.Text = string.Empty;
        Nodo.Text = string.Empty;
        Red.Text = string.Empty;
        Division.Text = string.Empty;
        Area.Text = string.Empty;
        Zona.Text = string.Empty;
        Distrito.Text = string.Empty;
        Nombre_Comunidad.Text = string.Empty;
        Estrato.Text = string.Empty;
        Tipo_Cliente.Text = string.Empty;
        Descripcion.Text = string.Empty;
        Correo_Electronico.Text = string.Empty;
        Telefono_Personal.Text = string.Empty;
        Fecha_Cumpleaños.Text = string.Empty;
        Rango_Edad.ClearSelection();
        Nivel_de_Estudios.ClearSelection();
        Hobby.ClearSelection();
        Twitter.Text = string.Empty;
        Facebook.Text = string.Empty;
        Instagram.Text = string.Empty;
        Otro.Text = string.Empty;
        Numero_de_Hijos.ClearSelection();
        Edad_Hijos.ClearSelection();
        Caja_consulta.Text = string.Empty;
        Lista_Marcaciones.Items.Clear();
        Servicios.ClearSelection();
        Macroproceso.Items.Clear();
        Proceso.Items.Clear();
        Subproceso.Items.Clear();
        Posible_Causa.Text = string.Empty;
        Que_Hacer.Text = string.Empty;
        Codigos_de_Cierre.Text = string.Empty;
        Area_Usuario_Escalar.Text = string.Empty;
        Marcacion.Items.Clear();
        Producto_Asociado.Items.Clear();
        Tipo_Atencion.Items.Clear();
        Solucion.Items.Clear();
        Estado_Caso.Items.Clear();
        Area_Escalar.Items.Clear();
        Notas.Text = string.Empty;
        Pqr.Text = "0";
        GVINGRESOS.DataBind();
        GVINGRESOS2.DataBind();
        R_Ciudad_Cliente.Items.Clear();
        R_Estrato_Cliente.Items.Clear();
        R_Tipo_Regleta.Items.Clear();
        R_Tipo_Regleta.DataBind();
    }
    private void Limpiar_Incremento()
    {
        Incremento_Cuenta_Cliente.Text = string.Empty;
        Incremento_Nombre_Cliente.Text = string.Empty;
        Incremento_Apellido_Cliente.Text = string.Empty;
        Incremento_Ciudad_Residencia.Text = string.Empty;
        Incremento_Estrato.Text = string.Empty;
        Incremento_Tipo_Cliente.Text = string.Empty;
        Incremento_Tarifa_Anterior.Text = string.Empty;
        Incremento_Tarifa_Nueva.Text = string.Empty;
        Incremento_Incrmento_Real.Text = string.Empty;
        Incremento_Renta_Sin_Incrmento.Text = string.Empty;
        Incremento_Nueva_Renta.Text = string.Empty;
        Incremento_Direfencia.Text = string.Empty;
        Incremento_Paquete_Actual.Text = string.Empty;
        Incremento_Velocidad_Internet.Text = string.Empty;
        Incremento_Tipo_Television.Text = string.Empty;
        Incremento_Servicio_Hd.Text = string.Empty;
        Incremento_Elegido_Movil.Text = string.Empty;
        Incremento_Claro_Video.Text = string.Empty;
        Incremento_Postpago_Movil.Text = string.Empty;
        Incremento_Plan_Ld30.Text = string.Empty;
        Incremento_Apto_Tecnologia.Text = string.Empty;
        Incremento_Llamadas_Moviles.Text = string.Empty;
        Incremento_Otros_Operadores.Text = string.Empty;
        Incremento_Primer_Oprecimiento.Text = string.Empty;
        Incremento_Segundo_Ofrecimiento.Text = string.Empty;
        Incremento_Tercer_Ofrecimiento.Text = string.Empty;
        Incremento_Cuarto_Ofrecimiento.Text = string.Empty;
        Incremento_Quinto_Ofrecimiento.Text = string.Empty;
        Incremento_Sexto_Ofrecimiento.Text = string.Empty;
    }
    protected void Guardar_Caso_Click(object sender, EventArgs e)
    {
        if ((Convert.ToString(Estado_Caso.SelectedItem) == "--SELECCIONE--") || (Convert.ToString(Area_Escalar.SelectedItem) == "--SELECCIONE--"))
        {
            string script10 = "mensaje12();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje12", script10, true);
        }
        else
        {
            if (Convert.ToString(Marcacion.SelectedItem) == "")
            {
                string script9 = "mensaje11();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje11", script9, true);
            }
            else
            {
                var Registrar_Transaccion = -1;
                DataSet dt1 = new DataSet();
                Obj_Entidad_Cuentas_Genericas.Cuenta_Cliente = Convert.ToInt64(Cuenta_Cliente.Text);
                dt1 = Obj_Neg_Cuentas_Genericas.Consultar_Cuenta_Generica(Obj_Entidad_Cuentas_Genericas.Cuenta_Cliente);
                if (dt1.Tables[0].Rows.Count > 0)
                {
                    Guardar_Cliente_Generico();
                    Registrar_Transaccion = Obj_Neg_Transacciones.acb_Log_Transacciones(Obj_Entidad_Transacciones);
                    Limpiar_General();
                    Colores_Blanco();
                    Limpiar_Incremento();
                }
                else
                {
                    Guardar_Cliente_Real();
                    Registrar_Transaccion = Obj_Neg_Transacciones.acb_Log_Transacciones(Obj_Entidad_Transacciones);
                    Limpiar_General();
                    Colores_Blanco();
                    Limpiar_Incremento();
                }
            }
        }
    }
    protected void Guardar_Ofrecimiento_Click(object sender, EventArgs e)
    {
        var ofrecimiento1 = string.Empty;
        var ofrecimiento2 = string.Empty;
        var ofrecimiento3 = string.Empty;
        var ofrecimiento4 = string.Empty;
        var ofrecimiento5 = string.Empty;
        var ofrecimiento6 = string.Empty;

        if (RadioButton1.Checked == true) { ofrecimiento1 = "1"; } else { ofrecimiento1 = "0"; };
        if (RadioButton3.Checked == true) { ofrecimiento2 = "1"; } else { ofrecimiento2 = "0"; };
        if (RadioButton5.Checked == true) { ofrecimiento3 = "1"; } else { ofrecimiento3 = "0"; };
        if (RadioButton7.Checked == true) { ofrecimiento4 = "1"; } else { ofrecimiento4 = "0"; };
        if (RadioButton9.Checked == true) { ofrecimiento5 = "1"; } else { ofrecimiento5 = "0"; };
        if (RadioButton11.Checked == true) { ofrecimiento6 = "1"; } else { ofrecimiento6 = "0"; };

        Obj_Entidad_Of_Incremento.Usuario_Gestion = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Of_Incremento.Cuenta_Cliente = Convert.ToInt64(Incremento_Cuenta_Cliente.Text);
        Obj_Entidad_Of_Incremento.Periodo_Incremento = Convert.ToInt64(Incremento_Periodo_Ofrecimiento.Text);
        Obj_Entidad_Of_Incremento.Ofrecimiento_1 = Convert.ToInt64(ofrecimiento1);
        Obj_Entidad_Of_Incremento.Ofrecimiento_2 = Convert.ToInt64(ofrecimiento2);
        Obj_Entidad_Of_Incremento.Ofrecimiento_3 = Convert.ToInt64(ofrecimiento3);
        Obj_Entidad_Of_Incremento.Ofrecimiento_4 = Convert.ToInt64(ofrecimiento4);
        Obj_Entidad_Of_Incremento.Ofrecimiento_5 = Convert.ToInt64(ofrecimiento5);
        Obj_Entidad_Of_Incremento.Ofrecimiento_6 = Convert.ToInt64(ofrecimiento6);

        var Registrar_Ofrecimiento = -1;
        Registrar_Ofrecimiento = Obj_Neg_Of_Incremento.Registro_de_Ofrecimientos(Obj_Entidad_Of_Incremento);

        if (Registrar_Ofrecimiento != -1)
        {
            string script = "mensaje7();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje7", script, true);
        }
        else { }
    }
    private void Carga_Casos_Abiertos(object sender, EventArgs e)
    {
        DataSet dt3 = new DataSet();
        Obj_Entidad_Ingresos.Cuenta_Cliente = Convert.ToInt64(Cuenta_Cliente.Text);
        dt3 = Obj_Neg_Ingresos.Casos_Abiertos_Tipificador(Convert.ToInt64(Cuenta_Cliente.Text));

        if (dt3.Tables[0].Rows.Count > 0)
        {

            GVINGRESOS.DataSource = dt3.Tables[0];
            GVINGRESOS.DataBind();
        }
        else
        {
            GVINGRESOS.DataSource = null;
            GVINGRESOS.DataBind();
        }

    }
    public void Carga_Casos_Cerrados(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Ingresos.Cuenta_Cliente = Convert.ToInt64(Cuenta_Cliente.Text);
        dt = Obj_Neg_Ingresos.Casos_Cerrados_Tipificador(Convert.ToInt64(Cuenta_Cliente.Text));

        if (dt.Tables[0].Rows.Count > 0)
        {

            GVINGRESOS2.DataSource = dt.Tables[0];
            GVINGRESOS2.DataBind();
        }
        else
        {
            GVINGRESOS2.DataSource = null;
            GVINGRESOS2.DataBind();
        }
    }
    protected void Carga_Tipo_Regleta(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Regleta.Poblacion = R_Ciudad_Cliente.Text;
        Obj_Entidad_Regleta.Estrato = R_Estrato_Cliente.Text;
        dt = Obj_Neg_Regleta.Tipo_Regleta(Obj_Entidad_Regleta.Poblacion, Obj_Entidad_Regleta.Estrato);

        if (dt.Tables[0].Rows.Count > 0)
        {
            R_Tipo_Regleta.DataSource = dt;
            R_Tipo_Regleta.DataTextField = "TIPO_REGLETA";
            R_Tipo_Regleta.DataValueField = "TIPO_REGLETA";
            R_Tipo_Regleta.DataBind();

        }
        else
        {

        }
    }
    protected void R_Limpiar_Click(object sender, EventArgs e)
    {
        R_Ciudad_Cliente.Items.Clear();
        R_Estrato_Cliente.Items.Clear();
        R_Tipo_Regleta.Items.Clear();
        Lista_Paquetes_Triples.Items.Clear();
        Lista_Paquetes_Dobles.Items.Clear();
        Lista_Paquetes_Sencillos.Items.Clear();
        Trae_Ciudades();
        Trae_Estratos();
        R_Tipo_Regleta.DataBind();
        Lista_Paquetes_Triples.DataBind();
        Lista_Paquetes_Dobles.DataBind();
        Lista_Paquetes_Sencillos.DataBind();
        Trae_Estratos();
        this.Carga_Tipo_Regleta(sender, e);
        this.Paquetes_Triples(sender, e);
        this.Paquetes_Dobles(sender, e);
        this.Paquetes_Sencillos(sender, e);
        DETALLE_TARIFA_1.DataSource = null;
        DETALLE_TARIFA_1.DataBind();
        DETALLE_TARIFA_2.DataSource = null;
        DETALLE_TARIFA_2.DataBind();
        DETALLE_REGLETA_AD.DataSource = null;
        DETALLE_REGLETA_AD.DataBind();


    }
    protected void Lista_Paquetes_Triples_SelectedIndexChanged(object sender, EventArgs e)
    {
        Lista_Paquetes_Dobles.ClearSelection();
        Lista_Paquetes_Sencillos.ClearSelection();
        DataSet dt = new DataSet();
        Obj_Entidad_Regleta.Poblacion = R_Ciudad_Cliente.Text;
        Obj_Entidad_Regleta.Estrato = R_Estrato_Cliente.Text;
        Obj_Entidad_Regleta.Tipo_Regleta = R_Tipo_Regleta.Text;
        Obj_Entidad_Regleta.Nombre_Paquete_Final = Lista_Paquetes_Triples.SelectedValue;
        dt = Obj_Neg_Regleta.Valor_Paquetes(Obj_Entidad_Regleta.Poblacion, Obj_Entidad_Regleta.Estrato, Obj_Entidad_Regleta.Tipo_Regleta, Obj_Entidad_Regleta.Nombre_Paquete_Final);

        if (dt.Tables[0].Rows.Count > 0)
        {
            Valor_Paquete.Text = dt.Tables[0].Rows[0]["TOTAL_TARIFA"].ToString();
            this.Detalle_Regleta_1(sender, e);
            this.Detalle_Regleta_2(sender, e);
            this.Regleta_Adicional(sender, e);
        }
        else
        {

        }
    }
    protected void Lista_Paquetes_Dobles_SelectedIndexChanged(object sender, EventArgs e)
    {
        Lista_Paquetes_Triples.ClearSelection();
        Lista_Paquetes_Sencillos.ClearSelection();
        DataSet dt = new DataSet();
        Obj_Entidad_Regleta.Poblacion = R_Ciudad_Cliente.Text;
        Obj_Entidad_Regleta.Estrato = R_Estrato_Cliente.Text;
        Obj_Entidad_Regleta.Tipo_Regleta = R_Tipo_Regleta.Text;
        Obj_Entidad_Regleta.Nombre_Paquete_Final = Lista_Paquetes_Dobles.SelectedValue;
        dt = Obj_Neg_Regleta.Valor_Paquetes(Obj_Entidad_Regleta.Poblacion, Obj_Entidad_Regleta.Estrato, Obj_Entidad_Regleta.Tipo_Regleta, Obj_Entidad_Regleta.Nombre_Paquete_Final);

        if (dt.Tables[0].Rows.Count > 0)
        {
            Valor_Paquete.Text = dt.Tables[0].Rows[0]["TOTAL_TARIFA"].ToString();
            this.Detalle_Regleta_1(sender, e);
            this.Detalle_Regleta_2(sender, e);
            this.Regleta_Adicional(sender, e);
        }
        else
        {

        }
    }
    protected void Lista_Paquetes_Sencillos_SelectedIndexChanged(object sender, EventArgs e)
    {
        Lista_Paquetes_Dobles.ClearSelection();
        Lista_Paquetes_Triples.ClearSelection();
        DataSet dt = new DataSet();
        Obj_Entidad_Regleta.Poblacion = R_Ciudad_Cliente.Text;
        Obj_Entidad_Regleta.Estrato = R_Estrato_Cliente.Text;
        Obj_Entidad_Regleta.Tipo_Regleta = R_Tipo_Regleta.Text;
        Obj_Entidad_Regleta.Nombre_Paquete_Final = Lista_Paquetes_Sencillos.SelectedValue;
        dt = Obj_Neg_Regleta.Valor_Paquetes(Obj_Entidad_Regleta.Poblacion, Obj_Entidad_Regleta.Estrato, Obj_Entidad_Regleta.Tipo_Regleta, Obj_Entidad_Regleta.Nombre_Paquete_Final);

        if (dt.Tables[0].Rows.Count > 0)
        {
            Valor_Paquete.Text = dt.Tables[0].Rows[0]["TOTAL_TARIFA"].ToString();
            this.Detalle_Regleta_1(sender, e);
            this.Detalle_Regleta_2(sender, e);
            this.Regleta_Adicional(sender, e);
        }
        else
        {

        }

    }
    protected void Paquetes_Triples(object sender, EventArgs e)
    {
        Lista_Paquetes_Triples.ClearSelection();
        Lista_Paquetes_Triples.Items.Clear();
        Valor_Paquete.Text = string.Empty;
        DataSet dt = new DataSet();
        Obj_Entidad_Regleta.Poblacion = R_Ciudad_Cliente.Text;
        Obj_Entidad_Regleta.Estrato = R_Estrato_Cliente.Text;
        Obj_Entidad_Regleta.Tipo_Regleta = R_Tipo_Regleta.Text;
        dt = Obj_Neg_Regleta.Paquetes_Triples(Obj_Entidad_Regleta.Poblacion, Obj_Entidad_Regleta.Estrato, Obj_Entidad_Regleta.Tipo_Regleta);

        if (dt.Tables[0].Rows.Count > 0)
        {
            Lista_Paquetes_Triples.DataSource = dt;
            Lista_Paquetes_Triples.DataTextField = "NOMBRE_PAQUETE_FINAL";
            Lista_Paquetes_Triples.DataValueField = "NOMBRE_PAQUETE_FINAL";
            Lista_Paquetes_Triples.DataBind();

        }
        else
        {

        }
    }
    protected void Paquetes_Dobles(object sender, EventArgs e)
    {
        Lista_Paquetes_Dobles.ClearSelection();
        Lista_Paquetes_Dobles.Items.Clear();
        Valor_Paquete.Text = string.Empty;
        DataSet dt = new DataSet();
        Obj_Entidad_Regleta.Poblacion = R_Ciudad_Cliente.Text;
        Obj_Entidad_Regleta.Estrato = R_Estrato_Cliente.Text;
        Obj_Entidad_Regleta.Tipo_Regleta = R_Tipo_Regleta.Text;
        dt = Obj_Neg_Regleta.Paquetes_Dobles(Obj_Entidad_Regleta.Poblacion, Obj_Entidad_Regleta.Estrato, Obj_Entidad_Regleta.Tipo_Regleta);

        if (dt.Tables[0].Rows.Count > 0)
        {
            Lista_Paquetes_Dobles.DataSource = dt;
            Lista_Paquetes_Dobles.DataTextField = "NOMBRE_PAQUETE_FINAL";
            Lista_Paquetes_Dobles.DataValueField = "NOMBRE_PAQUETE_FINAL";
            Lista_Paquetes_Dobles.DataBind();

        }
        else
        {

        }
    }
    protected void Paquetes_Sencillos(object sender, EventArgs e)
    {
        Lista_Paquetes_Sencillos.ClearSelection();
        Lista_Paquetes_Sencillos.Items.Clear();
        Valor_Paquete.Text = string.Empty;
        DataSet dt = new DataSet();
        Obj_Entidad_Regleta.Poblacion = R_Ciudad_Cliente.Text;
        Obj_Entidad_Regleta.Estrato = R_Estrato_Cliente.Text;
        Obj_Entidad_Regleta.Tipo_Regleta = R_Tipo_Regleta.Text;
        dt = Obj_Neg_Regleta.Paquetes_Sencillos(Obj_Entidad_Regleta.Poblacion, Obj_Entidad_Regleta.Estrato, Obj_Entidad_Regleta.Tipo_Regleta);

        if (dt.Tables[0].Rows.Count > 0)
        {
            Lista_Paquetes_Sencillos.DataSource = dt;
            Lista_Paquetes_Sencillos.DataTextField = "NOMBRE_PAQUETE_FINAL";
            Lista_Paquetes_Sencillos.DataValueField = "NOMBRE_PAQUETE_FINAL";
            Lista_Paquetes_Sencillos.DataBind();

        }
        else
        {

        }
    }
    protected void Valor_Paquetes(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Regleta.Poblacion = R_Ciudad_Cliente.Text;
        Obj_Entidad_Regleta.Estrato = R_Estrato_Cliente.Text;
        Obj_Entidad_Regleta.Tipo_Regleta = R_Tipo_Regleta.Text;
        Obj_Entidad_Regleta.Nombre_Paquete_Final = Lista_Paquetes_Triples.SelectedValue;
        dt = Obj_Neg_Regleta.Valor_Paquetes(Obj_Entidad_Regleta.Poblacion, Obj_Entidad_Regleta.Estrato, Obj_Entidad_Regleta.Tipo_Regleta, Obj_Entidad_Regleta.Nombre_Paquete_Final);

        if (dt.Tables[0].Rows.Count > 0)
        {
            Lista_Paquetes_Sencillos.DataSource = dt;
            Lista_Paquetes_Sencillos.DataTextField = "TOTAL_TARIFA";
            Lista_Paquetes_Sencillos.DataValueField = "TOTAL_TARIFA";
            Lista_Paquetes_Sencillos.DataBind();

        }
        else
        {

        }
    }
    protected void Trae_Ciudades()
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Regleta.Total_Poblaciones();

        if (dt.Tables[0].Rows.Count > 0)
        {
            R_Ciudad_Cliente.Items.Clear();
            R_Ciudad_Cliente.DataSource = dt;
            R_Ciudad_Cliente.DataTextField = "POBLACION";
            R_Ciudad_Cliente.DataValueField = "POBLACION";
            R_Ciudad_Cliente.DataBind();

        }
        else
        {

        }
    }
    protected void Trae_Estratos()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Regleta.Poblacion = R_Ciudad_Cliente.Text;
        dt = Obj_Neg_Regleta.Estratos_Regleta(Obj_Entidad_Regleta.Poblacion);

        if (dt.Tables[0].Rows.Count > 0)
        {

            R_Estrato_Cliente.Items.Clear();
            R_Estrato_Cliente.DataSource = dt;
            R_Estrato_Cliente.DataTextField = "ESTRATO";
            R_Estrato_Cliente.DataValueField = "ESTRATO";
            R_Estrato_Cliente.DataBind();

        }
        else
        {

        }
    }
    protected void R_Ciudad_Cliente_SelectedIndexChanged(object sender, EventArgs e)
    {
        Trae_Estratos();
        this.Carga_Tipo_Regleta(sender, e);
        this.Paquetes_Triples(sender, e);
        this.Paquetes_Dobles(sender, e);
        this.Paquetes_Sencillos(sender, e);
    }
    protected void R_Estrato_Cliente_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.Carga_Tipo_Regleta(sender, e);
        this.Paquetes_Triples(sender, e);
        this.Paquetes_Dobles(sender, e);
        this.Paquetes_Sencillos(sender, e);
        this.Regleta_Adicional(sender, e);

    }
    protected void R_Tipo_Regleta_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.Paquetes_Triples(sender, e);
        this.Paquetes_Dobles(sender, e);
        this.Paquetes_Sencillos(sender, e);
    }
    protected void Detalle_Regleta_1(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Regleta.Detalle_Regleta(Obj_Entidad_Regleta.Poblacion, Obj_Entidad_Regleta.Estrato, Obj_Entidad_Regleta.Tipo_Regleta, Obj_Entidad_Regleta.Nombre_Paquete_Final);

        if (dt.Tables[0].Rows.Count > 0)
        {

            DETALLE_TARIFA_1.DataSource = dt.Tables[0];
            DETALLE_TARIFA_1.DataBind();

        }
        else
        {
            DETALLE_TARIFA_1.DataSource = null;
            DETALLE_TARIFA_1.DataBind();
        }
    }
    protected void Detalle_Regleta_2(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Regleta.Detalle_Regleta(Obj_Entidad_Regleta.Poblacion, Obj_Entidad_Regleta.Estrato, Obj_Entidad_Regleta.Tipo_Regleta, Obj_Entidad_Regleta.Nombre_Paquete_Final);

        if (dt.Tables[0].Rows.Count > 0)
        {

            DETALLE_TARIFA_2.DataSource = dt.Tables[0];
            DETALLE_TARIFA_2.DataBind();

        }
        else
        {
            DETALLE_TARIFA_2.DataSource = null;
            DETALLE_TARIFA_2.DataBind();
        }
    }
    protected void Regleta_Adicional(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Regleta_Adicional.Estrato = Convert.ToInt16(R_Estrato_Cliente.Text);
        dt = Obj_Neg_Regleta_Adicional.Regleta_Adicional(Obj_Entidad_Regleta_Adicional.Estrato);

        if (dt.Tables[0].Rows.Count > 0)
        {

            DETALLE_REGLETA_AD.DataSource = dt.Tables[0];
            DETALLE_REGLETA_AD.DataBind();

        }
        else
        {
            DETALLE_REGLETA_AD.DataSource = null;
            DETALLE_REGLETA_AD.DataBind();
        }
    }
    protected void GVINGRESOS_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GVINGRESOS.PageIndex = e.NewPageIndex;
        this.Carga_Casos_Abiertos(sender, e);
    }
    protected void GVINGRESOS2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GVINGRESOS2.PageIndex = e.NewPageIndex;
        this.Carga_Casos_Cerrados(sender, e);
    }
    protected void Cedula_Cliente_TextChanged(object sender, EventArgs e)
    {
        Cuenta_Cliente.Text = "0";
        try
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Clientes.Cedula_Cliente = Cedula_Cliente.Text;
            dt = Obj_Neg_Clientes.Consulta_Cliente_Cedula(Obj_Entidad_Clientes.Cedula_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                Cuenta_Cliente.Text = dt.Tables[0].Rows[0]["CUENTA"].ToString();
                Nombre_Cliente.Text = dt.Tables[0].Rows[0]["NOMBRE"].ToString();
                Apellido_Cliente.Text = dt.Tables[0].Rows[0]["APELLIDO"].ToString();
                Telefono_Telmex.Text = dt.Tables[0].Rows[0]["TELEFONO_TELMEX"].ToString();
                Telefono_1.Text = dt.Tables[0].Rows[0]["TELEFONO_1"].ToString();
                Telefono_2.Text = dt.Tables[0].Rows[0]["TELEFONO_2"].ToString();
                Telefono_3.Text = dt.Tables[0].Rows[0]["TELEFONO_3"].ToString();
                Direccion_Instalacion.Text = dt.Tables[0].Rows[0]["DIR_INSTALACION"].ToString();
                Direccion_Correspondencia.Text = dt.Tables[0].Rows[0]["DIR_CORRESPONDENCIA"].ToString();
                Nodo.Text = dt.Tables[0].Rows[0]["NODO"].ToString();
                Red.Text = dt.Tables[0].Rows[0]["RED"].ToString();
                Division.Text = dt.Tables[0].Rows[0]["DIVISION"].ToString();
                Area.Text = dt.Tables[0].Rows[0]["AREA"].ToString();
                Zona.Text = dt.Tables[0].Rows[0]["ZONA"].ToString();
                Distrito.Text = dt.Tables[0].Rows[0]["DISTRITO"].ToString();
                Nombre_Comunidad.Text = dt.Tables[0].Rows[0]["NOMBRE_COMUNIDAD"].ToString();
                Estrato.Text = dt.Tables[0].Rows[0]["ESTRATO"].ToString();
                Tipo_Cliente.Text = dt.Tables[0].Rows[0]["TIPO_CLIENTE"].ToString();
                Descripcion.Text = dt.Tables[0].Rows[0]["DESCRIPCION"].ToString();

                R_Ciudad_Cliente.Items.Clear();
                R_Ciudad_Cliente.Items.Add(dt.Tables[0].Rows[0]["NOMBRE_COMUNIDAD"].ToString());
                R_Estrato_Cliente.Items.Clear();
                R_Estrato_Cliente.Items.Add(dt.Tables[0].Rows[0]["ESTRATO"].ToString());

                DataSet dt2 = new DataSet();
                Obj_Entidad_Incremento.Cuenta_Cliente = Convert.ToInt64(Cuenta_Cliente.Text);
                dt2 = Obj_Neg_Incremento.Consulta_Incremento(Obj_Entidad_Incremento.Cuenta_Cliente);
                if (dt2.Tables[0].Rows.Count > 0)
                {
                    Incremento_Cuenta_Cliente.Text = Cuenta_Cliente.Text;
                    Incremento_Nombre_Cliente.Text = dt.Tables[0].Rows[0]["NOMBRE"].ToString();
                    Incremento_Apellido_Cliente.Text = dt.Tables[0].Rows[0]["APELLIDO"].ToString();
                    Incremento_Ciudad_Residencia.Text = dt.Tables[0].Rows[0]["NOMBRE_COMUNIDAD"].ToString();
                    Incremento_Estrato.Text = dt.Tables[0].Rows[0]["ESTRATO"].ToString();
                    Incremento_Tipo_Cliente.Text = dt.Tables[0].Rows[0]["DESCRIPCION"].ToString();
                    Incremento_Tarifa_Anterior.Text = dt2.Tables[0].Rows[0]["TARIFA_ANTERIOR"].ToString();
                    Incremento_Tarifa_Nueva.Text = dt2.Tables[0].Rows[0]["TARIFA_NUEVA"].ToString();
                    Incremento_Incrmento_Real.Text = dt2.Tables[0].Rows[0]["INCREMENTO_REAL"].ToString();
                    Incremento_Renta_Sin_Incrmento.Text = dt2.Tables[0].Rows[0]["RENTA_SIN_INCREMENTO"].ToString();
                    Incremento_Nueva_Renta.Text = dt2.Tables[0].Rows[0]["NUEVA_RENTA"].ToString();
                    Incremento_Direfencia.Text = dt2.Tables[0].Rows[0]["DIFERENCIA"].ToString();
                    Incremento_Paquete_Actual.Text = dt2.Tables[0].Rows[0]["PRODUCTOS"].ToString();
                    Incremento_Velocidad_Internet.Text = dt2.Tables[0].Rows[0]["VELOCIDAD_INTERNET"].ToString();
                    Incremento_Tipo_Television.Text = dt2.Tables[0].Rows[0]["TIPO_TELEVISION"].ToString();
                    Incremento_Servicio_Hd.Text = dt2.Tables[0].Rows[0]["SERVICIO_HD"].ToString();
                    Incremento_Elegido_Movil.Text = dt2.Tables[0].Rows[0]["ELEGIDO_FIJO_MOVIL"].ToString();
                    Incremento_Claro_Video.Text = dt2.Tables[0].Rows[0]["CLARO_VIDEO"].ToString();
                    Incremento_Postpago_Movil.Text = dt2.Tables[0].Rows[0]["POSPAGO_MOVIL"].ToString();
                    Incremento_Plan_Ld30.Text = dt2.Tables[0].Rows[0]["LD_30"].ToString();
                    Incremento_Apto_Tecnologia.Text = dt2.Tables[0].Rows[0]["TECNOLOGIA"].ToString();
                    Incremento_Llamadas_Moviles.Text = dt2.Tables[0].Rows[0]["VALOR_LLAMADAS_COMCEL"].ToString();
                    Incremento_Otros_Operadores.Text = dt2.Tables[0].Rows[0]["MINUTOS_LD_OTROS_OPERADORES"].ToString();
                    Incremento_Primer_Oprecimiento.Text = dt2.Tables[0].Rows[0]["PRIMER_OFRECIMIENTO"].ToString();
                    Incremento_Segundo_Ofrecimiento.Text = dt2.Tables[0].Rows[0]["SEGUNDO_OFRECIMIENTO"].ToString();
                    Incremento_Tercer_Ofrecimiento.Text = dt2.Tables[0].Rows[0]["TERCER_OFRECIMIENTO"].ToString();
                    Incremento_Cuarto_Ofrecimiento.Text = dt2.Tables[0].Rows[0]["CUARTO_OFRECIMIENTO"].ToString();
                    Incremento_Quinto_Ofrecimiento.Text = dt2.Tables[0].Rows[0]["QUINTO_OFRECIMIENTO"].ToString();
                    Incremento_Sexto_Ofrecimiento.Text = dt2.Tables[0].Rows[0]["SEXTO_OFRECIMIENTO"].ToString();
                    Incremento_Periodo_Ofrecimiento.Text = dt2.Tables[0].Rows[0]["PERIODO_INCREMENTO"].ToString();

                }
                else
                {
                    Limpiar_Incremento();
                    Guardar_Ofrecimiento.Enabled = false;
                }
                this.Datos_Adicionales_Cliente(sender, e);
                Hobbies();
                this.Carga_Tipo_Regleta(sender, e);
                Nombre_Linea();
                Estado_Casos();
                Lista_Servicios();
                this.Carga_Casos_Abiertos(sender, e);
                this.Carga_Casos_Cerrados(sender, e);
                this.Paquetes_Triples(sender, e);
                this.Paquetes_Dobles(sender, e);
                this.Paquetes_Sencillos(sender, e);
            }
            else
            {
                this.Carga_Casos_Abiertos(sender, e);
                this.Carga_Casos_Cerrados(sender, e);
                string script = "mensaje8();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje8", script, true);

                Limpiar();
                Limpiar2();
                Colores_Blanco();
                Limpiar_General();
                Limpiar_Incremento();
            }

        }
        catch (Exception esc)
        { throw new Exception("Error al Consultar la cuenta del cliente", esc); }
    }
    protected void Cedula_Consulta_TextChanged(object sender, EventArgs e)
    {
        Cuenta_Cliente.Text = "0";
        try
        {
            DataSet dt = new DataSet();
            Obj_Entidad_Clientes.Cedula_Cliente = Cedula_Consulta.Text;
            dt = Obj_Neg_Clientes.Consulta_Cliente_Global(Obj_Entidad_Clientes.Cedula_Cliente);

            if (dt.Tables[0].Rows.Count > 0)
            {
                Resultado_Consulta_Cliente.DataSource = dt.Tables[0];
                Resultado_Consulta_Cliente.DataBind();
            }
            else
            {
                Resultado_Consulta_Cliente.DataSource = null;
                Resultado_Consulta_Cliente.DataBind();
            }

        }
        catch (Exception esc)
        { throw new Exception("Error al Consultar la cuenta del cliente", esc); }
    }
    protected void Resultado_Consulta_Cliente_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cuenta_Cliente.Text = this.Resultado_Consulta_Cliente.Rows[Resultado_Consulta_Cliente.SelectedIndex].Cells[1].Text;
        this.Cuenta_Cliente_TextChanged(sender, e);
        Resultado_Consulta_Cliente.DataSource = null;
        Resultado_Consulta_Cliente.DataBind();
        Cedula_Consulta.Text = string.Empty;
        string script = "mensaje9();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje9", script, true);
    }
    protected void V_SI_T_TextChanged(object sender, EventArgs e)
    {
        var iva = 16;
        var porc = 100;
        Int64 valor = Convert.ToInt64(V_SI_T.Text);
        V_I_T.Text = Convert.ToString((valor * iva) / porc);
        var ValorIva = Convert.ToInt64(V_I_T.Text);
        var ValorMasIva = valor + ValorIva;
        V_CI_T.Text = Convert.ToString(ValorMasIva);
        V_TA_T.Text = Convert.ToString(ValorMasIva);
    }
    protected void V_SI_I_TextChanged(object sender, EventArgs e)
    {


    }
    protected void V_SI_V_TextChanged(object sender, EventArgs e)
    {
        var iva = 16;
        var porc = 100;
        Int64 valor = Convert.ToInt64(V_SI_V.Text);
        V_I_V.Text = Convert.ToString((valor * iva) / porc);
        var ValorIva = Convert.ToInt64(V_I_V.Text);
        var ValorMasIva = valor + ValorIva;
        V_CI_V.Text = Convert.ToString(ValorMasIva);
        V_TA_V.Text = Convert.ToString(ValorMasIva);
    }
    protected void ADT_VT_SI_TextChanged(object sender, EventArgs e)
    {
        var Iva = 16;
        var Porcentaje = 100;
        Int64 Valor = Convert.ToInt64(ADT_VT_SI.Text);
        ADT_VT_I.Text = Convert.ToString((Valor * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(ADT_VT_I.Text);
        var ValorMasIva = Valor + ValorIva;
        ADT_VT_VT.Text = Convert.ToString(ValorMasIva);

        this.ADT_Valor_Total_Facturado_TextChanged(sender, e);
        this.ADT_Valor_Contratado_TextChanged(sender, e);

    }
    protected void ADT_VI_SI_TextChanged(object sender, EventArgs e)
    {
        if ((ADT_Estrato_Cliente.Text == "1") || (ADT_Estrato_Cliente.Text == "2") || (ADT_Estrato_Cliente.Text == "3"))
        {

            ADT_VI_I.Text = Convert.ToString(0);
            ADT_VI_VT.Text = Convert.ToString(ADT_VI_SI.Text);

            this.ADT_Valor_Total_Facturado_TextChanged(sender, e);
            this.ADT_Valor_Contratado_TextChanged(sender, e);

        }
        else
        {
            var Iva = 16;
            var Porcentaje = 100;
            Int64 Valor = Convert.ToInt64(ADT_VI_SI.Text);
            ADT_VI_I.Text = Convert.ToString((Valor * Iva) / Porcentaje);
            var ValorIva = Convert.ToInt64(ADT_VI_I.Text);
            var ValorMasIva = Valor + ValorIva;
            ADT_VI_VT.Text = Convert.ToString(ValorMasIva);

            this.ADT_Valor_Total_Facturado_TextChanged(sender, e);
            this.ADT_Valor_Contratado_TextChanged(sender, e);
        }
    }
    protected void ADT_VV__SI_TextChanged(object sender, EventArgs e)
    {

        if ((ADT_Estrato_Cliente.Text == "1") || (ADT_Estrato_Cliente.Text == "2"))
        {
            var Iva = 16;
            var Iva2 = Convert.ToDecimal(56.8);
            int Porcentaje = 100;
            Int64 Valor_Inicial = Convert.ToInt64(ADT_VV__SI.Text);
            Int64 Valor_Iva = Convert.ToInt64(((Valor_Inicial) * Iva2 / Porcentaje) * Iva / Porcentaje);
            ADT_VV_I.Text = Convert.ToString(Valor_Iva);
            ADT_VV_VT.Text = Convert.ToString(Valor_Inicial + Valor_Iva);

            this.ADT_Valor_Total_Facturado_TextChanged(sender, e);
            this.ADT_Valor_Contratado_TextChanged(sender, e);

        }
        else
        {
            var Iva = 16;
            var Porcentaje = 100;
            Int64 Valor = Convert.ToInt64(ADT_VV__SI.Text);
            ADT_VV_I.Text = Convert.ToString((Valor * Iva) / Porcentaje);
            var ValorIva = Convert.ToInt64(ADT_VV_I.Text);
            var ValorMasIva = Valor + ValorIva;
            ADT_VV_VT.Text = Convert.ToString(ValorMasIva);

            this.ADT_Valor_Total_Facturado_TextChanged(sender, e);
            this.ADT_Valor_Contratado_TextChanged(sender, e);
        }
    }
    protected void ADT_VF_SI_TextChanged(object sender, EventArgs e)
    {
        var Iva = 16;
        var Porcentaje = 100;
        Int64 Valor = Convert.ToInt64(ADT_VF_SI.Text);
        ADT_VF_I.Text = Convert.ToString((Valor * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(ADT_VF_I.Text);
        var ValorMasIva = Valor + ValorIva;
        ADT_VF_VT.Text = Convert.ToString(ValorMasIva);

        this.ADT_Valor_Total_Facturado_TextChanged(sender, e);
        this.ADT_Valor_Contratado_TextChanged(sender, e);

    }
    protected void ADT_VLD_SI_TextChanged(object sender, EventArgs e)
    {
        var Iva = 16;
        var Porcentaje = 100;
        Int64 Valor = Convert.ToInt64(ADT_VLD_SI.Text);
        ADT_VLD_I.Text = Convert.ToString((Valor * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(ADT_VLD_I.Text);
        var ValorMasIva = Valor + ValorIva;
        ADT_VLD_VT.Text = Convert.ToString(ValorMasIva);

        this.ADT_Valor_Total_Facturado_TextChanged(sender, e);
        this.ADT_Valor_Contratado_TextChanged(sender, e);

    }
    protected void ADT_VR_SI_TextChanged(object sender, EventArgs e)
    {
        ADT_VR_I.Text = Convert.ToString(0);
        ADT_VR_VT.Text = Convert.ToString(ADT_VR_SI.Text);
        this.ADT_Valor_Total_Facturado_TextChanged(sender, e);
        this.ADT_Valor_Contratado_TextChanged(sender, e);
    }
    protected void ADT_VHB_SI_TextChanged(object sender, EventArgs e)
    {
        var Iva = 16;
        var Porcentaje = 100;
        Int64 Valor = Convert.ToInt64(ADT_VHB_SI.Text);
        ADT_VHB_I.Text = Convert.ToString((Valor * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(ADT_VHB_I.Text);
        var ValorMasIva = Valor + ValorIva;
        ADT_VHB_VT.Text = Convert.ToString(ValorMasIva);

        this.ADT_Valor_Total_Facturado_TextChanged(sender, e);
        this.ADT_Valor_Contratado_TextChanged(sender, e);
    }
    protected void ADT_VMP_SI_TextChanged(object sender, EventArgs e)
    {
        var Iva = 16;
        var Porcentaje = 100;
        Int64 Valor = Convert.ToInt64(ADT_VMP_SI.Text);
        ADT_VMP_I.Text = Convert.ToString((Valor * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(ADT_VMP_I.Text);
        var ValorMasIva = Valor + ValorIva;
        ADT_VMP_VT.Text = Convert.ToString(ValorMasIva);

        this.ADT_Valor_Total_Facturado_TextChanged(sender, e);
        this.ADT_Valor_Contratado_TextChanged(sender, e);
    }
    protected void ADT_VTHD_SI_TextChanged(object sender, EventArgs e)
    {
        var Iva = 16;
        var Porcentaje = 100;
        Int64 Valor = Convert.ToInt64(ADT_VTHD_SI.Text);
        ADT_VTHD_I.Text = Convert.ToString((Valor * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(ADT_VTHD_I.Text);
        var ValorMasIva = Valor + ValorIva;
        ADT_VTHD_VT.Text = Convert.ToString(ValorMasIva);

        this.ADT_Valor_Total_Facturado_TextChanged(sender, e);
        this.ADT_Valor_Contratado_TextChanged(sender, e);
    }
    protected void ADT_VSP_SI_TextChanged(object sender, EventArgs e)
    {
        var Iva = 16;
        var Porcentaje = 100;
        Int64 Valor = Convert.ToInt64(ADT_VSP_SI.Text);
        ADT_VSP_I.Text = Convert.ToString((Valor * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(ADT_VSP_I.Text);
        var ValorMasIva = Valor + ValorIva;
        ADT_VSP_VT.Text = Convert.ToString(ValorMasIva);

        this.ADT_Valor_Total_Facturado_TextChanged(sender, e);
        this.ADT_Valor_Contratado_TextChanged(sender, e);
    }
    protected void ADT_VVNS_SI_TextChanged(object sender, EventArgs e)
    {
        var Iva = 16;
        var Porcentaje = 100;
        Int64 Valor = Convert.ToInt64(ADT_VVNS_SI.Text);
        ADT_VVNS_I.Text = Convert.ToString((Valor * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(ADT_VVNS_I.Text);
        var ValorMasIva = Valor + ValorIva;
        ADT_VVNS_VT.Text = Convert.ToString(ValorMasIva);

        this.ADT_Valor_Total_Facturado_TextChanged(sender, e);
        this.ADT_Valor_Contratado_TextChanged(sender, e);
    }
    protected void ADT_VPVR_SI_TextChanged(object sender, EventArgs e)
    {
        var Iva = 16;
        var Porcentaje = 100;
        Int64 Valor = Convert.ToInt64(ADT_VPVR_SI.Text);
        ADT_VPVR_I.Text = Convert.ToString((Valor * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(ADT_VPVR_I.Text);
        var ValorMasIva = Valor + ValorIva;
        ADT_VPVR_VT.Text = Convert.ToString(ValorMasIva);

        this.ADT_Valor_Total_Facturado_TextChanged(sender, e);
        this.ADT_Valor_Contratado_TextChanged(sender, e);
    }
    protected void ADT_VWIFI_SI_TextChanged(object sender, EventArgs e)
    {
        if ((ADT_Estrato_Cliente.Text == "1") || (ADT_Estrato_Cliente.Text == "2") || (ADT_Estrato_Cliente.Text == "3"))
        {

            ADT_VWIFI_I.Text = Convert.ToString(0);
            ADT_VWIFI_VT.Text = Convert.ToString(ADT_VWIFI_SI.Text);

            this.ADT_Valor_Total_Facturado_TextChanged(sender, e);
            this.ADT_Valor_Contratado_TextChanged(sender, e);

        }
        else
        {
            var Iva = 16;
            var Porcentaje = 100;
            Int64 Valor = Convert.ToInt64(ADT_VWIFI_SI.Text);
            ADT_VWIFI_I.Text = Convert.ToString((Valor * Iva) / Porcentaje);
            var ValorIva = Convert.ToInt64(ADT_VWIFI_I.Text);
            var ValorMasIva = Valor + ValorIva;
            ADT_VWIFI_VT.Text = Convert.ToString(ValorMasIva);

            this.ADT_Valor_Total_Facturado_TextChanged(sender, e);
            this.ADT_Valor_Contratado_TextChanged(sender, e);
        }
    }
    protected void ADT_CLAROVIDEO_SI_TextChanged(object sender, EventArgs e)
    {
        var Iva = 16;
        var Porcentaje = 100;
        Int64 Valor = Convert.ToInt64(ADT_CLAROVIDEO_SI.Text);
        ADT_CLAROVIDEO_I.Text = Convert.ToString((Valor * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(ADT_CLAROVIDEO_I.Text);
        var ValorMasIva = Valor + ValorIva;
        ADT_CLAROVIDEO_VT.Text = Convert.ToString(ValorMasIva);

        this.ADT_Valor_Total_Facturado_TextChanged(sender, e);
        this.ADT_Valor_Contratado_TextChanged(sender, e);
    }
    protected void ADT_Cargar_Datos_Click(object sender, EventArgs e)
    {
        ADT_Estrato_Cliente.Text = Estrato.Text;
        ADT_Nombre_Cliente.Text = Nombre_Cliente.Text;
        ADT_Apellido_Cliente.Text = Apellido_Cliente.Text;

    }
    protected void ADT_Valor_Total_Facturado_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_1 = Convert.ToInt64(ADT_VT_VT.Text);
        Int64 Valor_2 = Convert.ToInt64(ADT_VI_VT.Text);
        Int64 Valor_3 = Convert.ToInt64(ADT_VV_VT.Text);
        Int64 Valor_4 = Convert.ToInt64(ADT_VF_VT.Text);
        Int64 Valor_5 = Convert.ToInt64(ADT_VLD_VT.Text);
        Int64 Valor_6 = Convert.ToInt64(ADT_VR_VT.Text);
        Int64 Valor_7 = Convert.ToInt64(ADT_VHB_VT.Text);
        Int64 Valor_8 = Convert.ToInt64(ADT_VMP_VT.Text);
        Int64 Valor_9 = Convert.ToInt64(ADT_VTHD_VT.Text);
        Int64 Valor_10 = Convert.ToInt64(ADT_VSP_VT.Text);
        Int64 Valor_11 = Convert.ToInt64(ADT_VVNS_VT.Text);
        Int64 Valor_12 = Convert.ToInt64(ADT_VPVR_VT.Text);
        Int64 Valor_13 = Convert.ToInt64(ADT_VWIFI_VT.Text);
        Int64 Valor_14 = Convert.ToInt64(ADT_CLAROVIDEO_VT.Text);

        Int64 Valor_Total = Convert.ToInt64(Valor_1 + Valor_2 + Valor_3 + Valor_4 + Valor_5 + Valor_6 + Valor_7 + Valor_8 + Valor_9 + Valor_10 + Valor_11 + Valor_12 + Valor_13 + Valor_14);
        ADT_Valor_Total_Facturado.Text = Convert.ToString(Valor_Total);

    }
    protected void ADT_Estrato_Cliente_TextChanged(object sender, EventArgs e)
    {
        this.ADT_VT_SI_TextChanged(sender, e);
        this.ADT_VI_SI_TextChanged(sender, e);
        this.ADT_VV__SI_TextChanged(sender, e);
        this.ADT_VF_SI_TextChanged(sender, e);
        this.ADT_VLD_SI_TextChanged(sender, e);
        this.ADT_VR_SI_TextChanged(sender, e);
        this.ADT_VHB_SI_TextChanged(sender, e);
        this.ADT_VMP_SI_TextChanged(sender, e);
        this.ADT_VTHD_SI_TextChanged(sender, e);
        this.ADT_VSP_SI_TextChanged(sender, e);
        this.ADT_VVNS_SI_TextChanged(sender, e);
        this.ADT_VPVR_SI_TextChanged(sender, e);
        this.ADT_VWIFI_SI_TextChanged(sender, e);
        this.ADT_CLAROVIDEO_SI_TextChanged(sender, e);
    }
    protected void ADT_Valor_Contratado_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Facturado = Convert.ToInt64(ADT_Valor_Total_Facturado.Text);
        Int64 Valor_Contratado = Convert.ToInt64(ADT_Valor_Contratado.Text);
        Int64 Valor_S_Internet = Convert.ToInt64(ADT_Subcidio_Internet.Text);
        Int64 Valor_S_Voz = Convert.ToInt64(ADT_Subcidio_Voz.Text);
        Int64 Valor_Diferencia = Convert.ToInt64(Valor_Facturado - Valor_Contratado - Valor_S_Internet - Valor_S_Voz);

        ADT_Valor_Diferencia.Text = Convert.ToString(Valor_Diferencia);

    }
    protected void ADT_Subcidio_Internet_TextChanged(object sender, EventArgs e)
    {
        this.ADT_Valor_Contratado_TextChanged(sender, e);
    }
    protected void ADT_Subcidio_Voz_TextChanged(object sender, EventArgs e)
    {
        this.ADT_Valor_Contratado_TextChanged(sender, e);
    }
    protected void ADT_Calculo_Fechas_Click(object sender, EventArgs e)
    {
        if ((Convert.ToString(CE_Fecha_Inicial.Text) == "") || (Convert.ToString(CE_Fecha_Final.Text) == ""))
        {

            ADT_Cantidad_de_Dias.Text = "0";
            ADT_Valor_por_fechas.Text = "0";
            ADT_Total_A_Ajustar.Text = "0";
            this.ADT_Ejecuta_Disputa_Final_Click(sender, e);
        }
        else
        {
            Calcular_Valor_Fechas_1();
            this.ADT_Ejecuta_Disputa_Final_Click(sender, e);
        }

    }
    protected void ADT_Periodos_SelectedIndexChanged(object sender, EventArgs e)
    {
        Int64 Valor_Renta = Convert.ToInt64(ADT_Valor_Diferencia.Text);
        Int64 Cantidad_Periodos = Convert.ToInt64(ADT_Periodos.SelectedValue);
        Int64 Valor_Periodo = Convert.ToInt64(Valor_Renta * Cantidad_Periodos);
        ADT_Valor_por_periodos.Text = Valor_Periodo.ToString();

        Int64 Valor_1 = Convert.ToInt64(ADT_Valor_por_fechas.Text);
        Int64 Valor_2 = Convert.ToInt64(ADT_Valor_por_fechas_2.Text);
        Int64 Valor_3 = Convert.ToInt64(ADT_Valor_por_periodos.Text);
        Int64 Valor_General = Convert.ToInt64(Valor_1 + Valor_2 + Valor_3);
        ADT_Total_A_Ajustar.Text = Valor_General.ToString();

        this.ADT_Ejecuta_Disputa_Final_Click(sender, e);
    }
    protected void ADT_Calculo_Fechas_2_Click(object sender, EventArgs e)
    {
        if ((Convert.ToString(ADT_Fecha_Inicial.Text) == "") || (Convert.ToString(ADT_Fecha_Final.Text) == ""))
        {

            ADT_Cantidad_de_Dias_Segundo_Periodo.Text = "0";
            ADT_Valor_por_fechas_2.Text = "0";
            ADT_Total_A_Ajustar.Text = "0";

            this.ADT_Ejecuta_Disputa_Final_Click(sender, e);
        }
        else
        {

            Calcular_Valor_Fecha_2();
            this.ADT_Ejecuta_Disputa_Final_Click(sender, e);
        }

    }
    protected void ADT_Ejecuta_Disputa_Final_Click(object sender, EventArgs e)
    {

        Calculo_Telefonia();
        Calculo_Funcionalidades();
        Calculos_Internet();
        Calculos_Television();
        Calculos_Arriendos();
        Calculos_ClaroVideo();
        Generar_Nota_ADT();
    }
    protected void Calculo_Telefonia()
    {
        //Valor Total Facturado
        Int64 Valor_Total_Facturado = Convert.ToInt64(ADT_Valor_Total_Facturado.Text);

        //Valor Total Ajustar
        Int64 Valor_Total_Ajustar = Convert.ToInt64(ADT_Total_A_Ajustar.Text);

        //Datos Television
        Int64 Television_Sin_Iva = Convert.ToInt64(ADT_VT_SI.Text);
        Int64 Television_Con_Iva = Convert.ToInt64(ADT_VT_VT.Text);

        //Datos Telefonia
        Int64 Telefonia_Sin_Iva = Convert.ToInt64(ADT_VV__SI.Text);
        Int64 Telefonia_Con_Iva = Convert.ToInt64(ADT_VV_VT.Text);

        //Datos Internet
        Int64 Internet_Sin_Iva = Convert.ToInt64(ADT_VI_SI.Text);
        Int64 Internet_Con_Iva = Convert.ToInt64(ADT_VI_VT.Text);

        //Datos LD30
        Int64 LD30_Con_Iva = Convert.ToInt64(ADT_VLD_VT.Text);

        //Datos Revista
        Int64 Revista_Con_Iva = Convert.ToInt64(ADT_VR_VT.Text);

        //Calculo Telefonia
        if ((Convert.ToString(Television_Sin_Iva) == "0") && (Telefonia_Sin_Iva > Internet_Sin_Iva))
        {
            decimal Valor_Iva = 1.16m;
            float Valor_Negativo = -1;
            float Suma_Valores = Telefonia_Con_Iva + LD30_Con_Iva + Revista_Con_Iva;
            float Division_Valores = Suma_Valores / Valor_Total_Facturado;
            Int64 Valor_Disputa_Telefonia = Convert.ToInt64(Division_Valores * Valor_Total_Ajustar);
            float Iva_Servicio_Telefonia1 = Convert.ToInt64((Valor_Disputa_Telefonia / Valor_Iva) - Valor_Disputa_Telefonia);
            Int64 Iva_Servicio_Telefonia = Convert.ToInt64(Iva_Servicio_Telefonia1 * Valor_Negativo);


            if ((Valor_Disputa_Telefonia - Iva_Servicio_Telefonia) <= 0)
            {
                ADT_VDV_F.Text = "SIN DISPUTAS";
            }
            else
            {
                ADT_VDV_F.Text = Convert.ToString(Valor_Disputa_Telefonia - Iva_Servicio_Telefonia);
            }

            ADT_NV_F.Text = Valor_Disputa_Telefonia.ToString();
            ADT_IV_F.Text = Iva_Servicio_Telefonia.ToString();
        }
        else
        {

            decimal Valor_Iva = 1.16m;
            float Valor_Negativo = -1;
            float Suma_Valores = Telefonia_Con_Iva + LD30_Con_Iva;
            float Division_Valores = Suma_Valores / Valor_Total_Facturado;
            Int64 Valor_Disputa_Telefonia = Convert.ToInt64(Division_Valores * Valor_Total_Ajustar);
            float Iva_Servicio_Telefonia1 = Convert.ToInt64((Valor_Disputa_Telefonia / Valor_Iva) - Valor_Disputa_Telefonia);
            Int64 Iva_Servicio_Telefonia = Convert.ToInt64(Iva_Servicio_Telefonia1 * Valor_Negativo);


            if ((Valor_Disputa_Telefonia - Iva_Servicio_Telefonia) <= 0)
            {
                ADT_VDV_F.Text = "SIN DISPUTAS";
            }
            else
            {
                ADT_VDV_F.Text = Convert.ToString(Valor_Disputa_Telefonia - Iva_Servicio_Telefonia);
            }

            ADT_NV_F.Text = Valor_Disputa_Telefonia.ToString();
            ADT_IV_F.Text = Iva_Servicio_Telefonia.ToString();

        }
    }
    protected void Calculo_Funcionalidades()
    {
        //Valor Total Facturado
        Int64 Valor_Total_Facturado = Convert.ToInt64(ADT_Valor_Total_Facturado.Text);

        //Valor Total Ajustar
        Int64 Valor_Total_Ajustar = Convert.ToInt64(ADT_Total_A_Ajustar.Text);

        //Datos Funcionalidades

        float Funcionalidades_Con_Iva = Convert.ToInt64(ADT_VF_VT.Text);

        //Calculo Funcionalidades

        decimal Valor_Iva = 1.16m;
        float Valor_Negativo = -1;
        float Division_Valor_Funcionalidad = Funcionalidades_Con_Iva / Valor_Total_Facturado;
        Int64 Valor_Disputa_Funcionalidad = Convert.ToInt64(Division_Valor_Funcionalidad * Valor_Total_Ajustar);
        float Iva_Servicio_Funcionalidad1 = Convert.ToInt64((Valor_Disputa_Funcionalidad / Valor_Iva) - Valor_Disputa_Funcionalidad);
        Int64 Iva_Servicio_Funcionalidad = Convert.ToInt64(Iva_Servicio_Funcionalidad1 * Valor_Negativo);

        if ((Valor_Disputa_Funcionalidad - Iva_Servicio_Funcionalidad) <= 0)
        {
            ADT_VDF_F.Text = "SIN DISPUTAS";
        }
        else
        {
            ADT_VDF_F.Text = Convert.ToString(Valor_Disputa_Funcionalidad - Iva_Servicio_Funcionalidad);
        }

        ADT_NF_F.Text = Valor_Disputa_Funcionalidad.ToString();
        ADT_IF_F.Text = Iva_Servicio_Funcionalidad.ToString();


    }
    protected void Calculos_Internet()
    {
        //Valor Total Facturado
        Int64 Valor_Total_Facturado = Convert.ToInt64(ADT_Valor_Total_Facturado.Text);

        //Valor Total Ajustar
        Int64 Valor_Total_Ajustar = Convert.ToInt64(ADT_Total_A_Ajustar.Text);

        //Datos Television
        Int64 Television_Sin_Iva = Convert.ToInt64(ADT_VT_SI.Text);
        Int64 Television_Con_Iva = Convert.ToInt64(ADT_VT_VT.Text);

        //Datos Telefonia
        Int64 Telefonia_Sin_Iva = Convert.ToInt64(ADT_VV__SI.Text);
        Int64 Telefonia_Con_Iva = Convert.ToInt64(ADT_VV_VT.Text);

        //Datos Internet
        Int64 Internet_Sin_Iva = Convert.ToInt64(ADT_VI_SI.Text);
        Int64 Internet_Con_Iva = Convert.ToInt64(ADT_VI_VT.Text);

        //Datos LD30
        Int64 LD30_Con_Iva = Convert.ToInt64(ADT_VLD_VT.Text);

        //Datos Revista
        Int64 Revista_Con_Iva = Convert.ToInt64(ADT_VR_VT.Text);

        //Calculo Telefonia
        if ((Convert.ToString(Television_Sin_Iva) == "0") && (Internet_Sin_Iva > Telefonia_Sin_Iva))
        {
            decimal Valor_Iva = 1.16m;
            float Valor_Negativo = -1;
            float Suma_Valores = Internet_Con_Iva + Revista_Con_Iva;
            float Division_Valores = Suma_Valores / Valor_Total_Facturado;
            Int64 Valor_Disputa_Internet = Convert.ToInt64(Division_Valores * Valor_Total_Ajustar);
            float Iva_Servicio_Internet1 = 0;
            Int64 Iva_Servicio_Internet = 0;

            if ((Convert.ToString(ADT_Estrato_Cliente.Text) == "1") || (Convert.ToString(ADT_Estrato_Cliente.Text) == "2") || (Convert.ToString(ADT_Estrato_Cliente.Text) == "3"))
            {

                Iva_Servicio_Internet = 0;
            }
            else
            {
                Iva_Servicio_Internet1 = Convert.ToInt64((Valor_Disputa_Internet / Valor_Iva) - Valor_Disputa_Internet);
                Iva_Servicio_Internet = Convert.ToInt64(Iva_Servicio_Internet1 * Valor_Negativo);
            }


            if ((Valor_Disputa_Internet - Iva_Servicio_Internet) <= 0)
            {
                ADT_VDI_F.Text = "SIN DISPUTAS";
            }
            else
            {
                ADT_VDI_F.Text = Convert.ToString(Valor_Disputa_Internet - Iva_Servicio_Internet);
            }

            ADT_NI_F.Text = Valor_Disputa_Internet.ToString();
            ADT_II_F.Text = Iva_Servicio_Internet.ToString();
        }
        else
        {
            decimal Valor_Iva = 1.16m;
            float Valor_Negativo = -1;
            float Suma_Valores = Internet_Con_Iva;
            float Division_Valores = Suma_Valores / Valor_Total_Facturado;
            Int64 Valor_Disputa_Internet = Convert.ToInt64(Division_Valores * Valor_Total_Ajustar);
            float Iva_Servicio_Internet1 = 0;
            Int64 Iva_Servicio_Internet = 0;

            if ((Convert.ToString(ADT_Estrato_Cliente.Text) == "1") || (Convert.ToString(ADT_Estrato_Cliente.Text) == "2") || (Convert.ToString(ADT_Estrato_Cliente.Text) == "3"))
            {

                Iva_Servicio_Internet = 0;
            }
            else
            {
                Iva_Servicio_Internet1 = Convert.ToInt64((Valor_Disputa_Internet / Valor_Iva) - Valor_Disputa_Internet);
                Iva_Servicio_Internet = Convert.ToInt64(Iva_Servicio_Internet1 * Valor_Negativo);
            }


            if ((Valor_Disputa_Internet - Iva_Servicio_Internet) <= 0)
            {
                ADT_VDI_F.Text = "SIN DISPUTAS";
            }
            else
            {
                ADT_VDI_F.Text = Convert.ToString(Valor_Disputa_Internet - Iva_Servicio_Internet);
            }

            ADT_NI_F.Text = Valor_Disputa_Internet.ToString();
            ADT_II_F.Text = Iva_Servicio_Internet.ToString();

        }
    }
    protected void Calculos_Television()
    {
        //Valor Total Facturado
        Int64 Valor_Total_Facturado = Convert.ToInt64(ADT_Valor_Total_Facturado.Text);

        //Valor Total Ajustar
        Int64 Valor_Total_Ajustar = Convert.ToInt64(ADT_Total_A_Ajustar.Text);

        //Datos Television
        Int64 Television_Sin_Iva = Convert.ToInt64(ADT_VT_SI.Text);
        Int64 Television_Con_Iva = Convert.ToInt64(ADT_VT_VT.Text);

        //Datos Telefonia
        Int64 Telefonia_Sin_Iva = Convert.ToInt64(ADT_VV__SI.Text);
        Int64 Telefonia_Con_Iva = Convert.ToInt64(ADT_VV_VT.Text);

        //Datos Internet
        Int64 Internet_Sin_Iva = Convert.ToInt64(ADT_VI_SI.Text);
        Int64 Internet_Con_Iva = Convert.ToInt64(ADT_VI_VT.Text);

        //Datos LD30
        Int64 LD30_Con_Iva = Convert.ToInt64(ADT_VLD_VT.Text);

        //Datos Revista
        Int64 Revista_Con_Iva = Convert.ToInt64(ADT_VR_VT.Text);

        //Datos HBO
        Int64 HBO_Con_Iva = Convert.ToInt64(ADT_VHB_VT.Text);

        //Datos Movie Pack
        Int64 Movie_Pack_Con_Iva = Convert.ToInt64(ADT_VMP_VT.Text);

        //Datos Television HD
        Int64 Television_HD_Con_Iva = Convert.ToInt64(ADT_VTHD_VT.Text);

        //Datos Spice TV
        Int64 Spice_TV_Con_Iva = Convert.ToInt64(ADT_VSP_VT.Text);

        //Datos Venus
        Int64 Venus_Con_Iva = Convert.ToInt64(ADT_VVNS_VT.Text);

        //Calculo Telefonia
        if (Convert.ToString(Television_Sin_Iva) == "0")
        {
            decimal Valor_Iva = 1.16m;
            float Valor_Negativo = -1;
            float Suma_Valores = Television_Con_Iva + HBO_Con_Iva + Movie_Pack_Con_Iva + Television_HD_Con_Iva + Spice_TV_Con_Iva + Venus_Con_Iva;
            float Division_Valores = Suma_Valores / Valor_Total_Facturado;
            Int64 Valor_Disputa_Television = Convert.ToInt64(Division_Valores * Valor_Total_Ajustar);
            float Iva_Servicio_Television1 = Convert.ToInt64((Valor_Disputa_Television / Valor_Iva) - Valor_Disputa_Television);
            Int64 Iva_Servicio_Television = Convert.ToInt64(Iva_Servicio_Television1 * Valor_Negativo);


            if ((Valor_Disputa_Television - Iva_Servicio_Television) <= 0)
            {
                ADT_VDTV_F.Text = "SIN DISPUTAS";
            }
            else
            {
                ADT_VDTV_F.Text = Convert.ToString(Valor_Disputa_Television - Iva_Servicio_Television);
            }

            ADT_NTV_F.Text = Valor_Disputa_Television.ToString();
            ADT_ITV_F.Text = Iva_Servicio_Television.ToString();
        }
        else
        {
            decimal Valor_Iva = 1.16m;
            float Valor_Negativo = -1;
            float Suma_Valores = Television_Con_Iva + HBO_Con_Iva + Movie_Pack_Con_Iva + Television_HD_Con_Iva + Spice_TV_Con_Iva + Venus_Con_Iva + Revista_Con_Iva;
            float Division_Valores = Suma_Valores / Valor_Total_Facturado;
            Int64 Valor_Disputa_Television = Convert.ToInt64(Division_Valores * Valor_Total_Ajustar);
            float Iva_Servicio_Television1 = Convert.ToInt64((Valor_Disputa_Television / Valor_Iva) - Valor_Disputa_Television);
            Int64 Iva_Servicio_Television = Convert.ToInt64(Iva_Servicio_Television1 * Valor_Negativo);


            if ((Valor_Disputa_Television - Iva_Servicio_Television) <= 0)
            {
                ADT_VDTV_F.Text = "SIN DISPUTAS";
            }
            else
            {
                ADT_VDTV_F.Text = Convert.ToString(Valor_Disputa_Television - Iva_Servicio_Television);
            }

            ADT_NTV_F.Text = Valor_Disputa_Television.ToString();
            ADT_ITV_F.Text = Iva_Servicio_Television.ToString();

        }
    }
    protected void Calculos_Arriendos()
    {
        //Valor Total Facturado
        Int64 Valor_Total_Facturado = Convert.ToInt64(ADT_Valor_Total_Facturado.Text);

        //Valor Total Ajustar
        Int64 Valor_Total_Ajustar = Convert.ToInt64(ADT_Total_A_Ajustar.Text);

        //Datos PVR
        Int64 Valor_PVR_Con_Iva = Convert.ToInt64(ADT_VPVR_VT.Text);

        //Datos Wifi
        Int64 Valor_Wifi = Convert.ToInt64(ADT_VWIFI_VT.Text);

        //Calculo Telefonia

        decimal Valor_Iva = 1.16m;
        float Valor_Negativo = -1;
        float Suma_Valores = Valor_PVR_Con_Iva + Valor_Wifi;
        float Division_Valores = Suma_Valores / Valor_Total_Facturado;
        Int64 Valor_Disputa_Arriendos = Convert.ToInt64(Division_Valores * Valor_Total_Ajustar);
        float Iva_Servicio_Arriendos1 = Convert.ToInt64((Valor_Disputa_Arriendos / Valor_Iva) - Valor_Disputa_Arriendos);
        Int64 Iva_Servicio_Arriendos = Convert.ToInt64(Iva_Servicio_Arriendos1 * Valor_Negativo);


        if ((Valor_Disputa_Arriendos - Iva_Servicio_Arriendos) <= 0)
        {
            ADT_VDA_F.Text = "SIN DISPUTAS";
        }
        else
        {
            ADT_VDA_F.Text = Convert.ToString(Valor_Disputa_Arriendos - Iva_Servicio_Arriendos);
        }

        ADT_NA_F.Text = Valor_Disputa_Arriendos.ToString();
        ADT_IA_F.Text = Iva_Servicio_Arriendos.ToString();

    }
    protected void Calculos_ClaroVideo()
    {
        //Valor Total Facturado
        Int64 Valor_Total_Facturado = Convert.ToInt64(ADT_Valor_Total_Facturado.Text);

        //Valor Total Ajustar
        Int64 Valor_Total_Ajustar = Convert.ToInt64(ADT_Total_A_Ajustar.Text);

        //Datos CLAROVIDEO
        Int64 Valor_CLAROVIDEO_Con_Iva = Convert.ToInt64(ADT_CLAROVIDEO_VT.Text);



        //Calculo CLARO VIDEO

        decimal Valor_Iva = 1.16m;
        float Valor_Negativo = -1;
        float Suma_Valores = Valor_CLAROVIDEO_Con_Iva;
        float Division_Valores = Suma_Valores / Valor_Total_Facturado;
        Int64 Valor_Disputa_CLAROVIDEO = Convert.ToInt64(Division_Valores * Valor_Total_Ajustar);
        float Iva_Servicio_CLAROVIDEO1 = Convert.ToInt64((Valor_Disputa_CLAROVIDEO / Valor_Iva) - Valor_Disputa_CLAROVIDEO);
        Int64 Iva_Servicio_CLAROVIDEO = Convert.ToInt64(Iva_Servicio_CLAROVIDEO1 * Valor_Negativo);


        if ((Valor_Disputa_CLAROVIDEO - Iva_Servicio_CLAROVIDEO) <= 0)
        {
            ADT_VDCLAROVIDEO_F.Text = "SIN DISPUTAS";
        }
        else
        {
            ADT_VDCLAROVIDEO_F.Text = Convert.ToString(Valor_Disputa_CLAROVIDEO - Iva_Servicio_CLAROVIDEO);
        }

        ADT_NCLAROVIDEO_F.Text = Valor_Disputa_CLAROVIDEO.ToString();
        ADT_ICLAROVIDEO_F.Text = Iva_Servicio_CLAROVIDEO.ToString();

    }
    protected void Calcular_Valor_Fecha_2()
    {
        DateTime Fecha_Inicial = Convert.ToDateTime(ADT_Fecha_Inicial.Text);
        DateTime Fecha_Final = Convert.ToDateTime(ADT_Fecha_Final.Text);
        TimeSpan Dia_Inicial = Fecha_Final.Subtract(Fecha_Inicial);
        int Dias_a_Calcular = Convert.ToInt16((Dia_Inicial.Days) + 1);
        ADT_Cantidad_de_Dias_Segundo_Periodo.Text = Dias_a_Calcular.ToString();

        DateTime Fecha_Seleccionada = Convert.ToDateTime(ADT_Fecha_Final.Text);

        int Numero_Mes = Convert.ToDateTime(ADT_Fecha_Inicial.Text).Month;
        int Cantidad_Dias = 0;
        int Numero_ano = Convert.ToDateTime(ADT_Fecha_Inicial.Text).Year;
        int Dias_Febrero = 0;

        if ((Numero_ano == 2016) || (Numero_ano == 2020) || (Numero_ano == 2024) || (Numero_ano == 2028) || (Numero_ano == 2032) || (Numero_ano == 2036) || (Numero_ano == 2040) || (Numero_ano == 2044)) { Dias_Febrero = 29; }
        else { Dias_Febrero = 28; }

        if ((Numero_Mes == 1) || (Numero_Mes == 3) || (Numero_Mes == 5) || (Numero_Mes == 7) || (Numero_Mes == 8) || (Numero_Mes == 10) || (Numero_Mes == 12)) { Cantidad_Dias = 31; }
        else if ((Numero_Mes == 2)) { Cantidad_Dias = Dias_Febrero; }
        else if ((Numero_Mes == 4) || (Numero_Mes == 6) || (Numero_Mes == 9) || (Numero_Mes == 11)) { Cantidad_Dias = 30; };

        Int64 Valor_Diferencia = Convert.ToInt64(ADT_Valor_Diferencia.Text);
        Int64 Dias_A_Ajustar = Convert.ToInt64(ADT_Cantidad_de_Dias_Segundo_Periodo.Text);
        Int64 Valor_Ajustar = Convert.ToInt64((Valor_Diferencia * Dias_A_Ajustar) / Cantidad_Dias);
        ADT_Valor_por_fechas_2.Text = Valor_Ajustar.ToString();

        Int64 Valor_1 = Convert.ToInt64(ADT_Valor_por_fechas.Text);
        Int64 Valor_2 = Convert.ToInt64(ADT_Valor_por_fechas_2.Text);
        Int64 Valor_3 = Convert.ToInt64(ADT_Valor_por_periodos.Text);
        Int64 Valor_General = Convert.ToInt64(Valor_1 + Valor_2 + Valor_3);
        ADT_Total_A_Ajustar.Text = Valor_General.ToString();

    }

    protected void Calcular_Valor_Fechas_1()
    {

        DateTime Fecha_Inicial = Convert.ToDateTime(CE_Fecha_Inicial.Text);
        DateTime Fecha_Final = Convert.ToDateTime(CE_Fecha_Final.Text);
        TimeSpan Dia_Inicial = Fecha_Final.Subtract(Fecha_Inicial);
        int Dias_a_Calcular = Convert.ToInt16((Dia_Inicial.Days) + 1);
        //TimeSpan Dia_Final = FActualizada.Subtract(Fecha_Final);
        ADT_Cantidad_de_Dias.Text = Dias_a_Calcular.ToString(); ;

        //este calculo es para sacar la cantidad de dias del mes en el que se selecciono
        DateTime Fecha_Seleccionada = Convert.ToDateTime(CE_Fecha_Final.Text);

        int Numero_Mes = Convert.ToDateTime(CE_Fecha_Inicial.Text).Month;
        int Cantidad_Dias = 0;
        int Numero_ano = Convert.ToDateTime(CE_Fecha_Inicial.Text).Year;
        int Dias_Febrero = 0;

        if ((Numero_ano == 2016) || (Numero_ano == 2020) || (Numero_ano == 2024) || (Numero_ano == 2028) || (Numero_ano == 2032) || (Numero_ano == 2036) || (Numero_ano == 2040) || (Numero_ano == 2044)) { Dias_Febrero = 29; }
        else { Dias_Febrero = 28; }

        if ((Numero_Mes == 1) || (Numero_Mes == 3) || (Numero_Mes == 5) || (Numero_Mes == 7) || (Numero_Mes == 8) || (Numero_Mes == 10) || (Numero_Mes == 12)) { Cantidad_Dias = 31; }
        else if ((Numero_Mes == 2)) { Cantidad_Dias = Dias_Febrero; }
        else if ((Numero_Mes == 4) || (Numero_Mes == 6) || (Numero_Mes == 9) || (Numero_Mes == 11)) { Cantidad_Dias = 30; };

        Int64 Valor_Diferencia = Convert.ToInt64(ADT_Valor_Diferencia.Text);
        Int64 Dias_A_Ajustar = Convert.ToInt64(ADT_Cantidad_de_Dias.Text);
        Int64 Valor_Ajustar = Convert.ToInt64((Valor_Diferencia * Dias_A_Ajustar) / Cantidad_Dias);
        ADT_Valor_por_fechas.Text = Valor_Ajustar.ToString();

        Int64 Valor_1 = Convert.ToInt64(ADT_Valor_por_fechas.Text);
        Int64 Valor_2 = Convert.ToInt64(ADT_Valor_por_fechas_2.Text);
        Int64 Valor_3 = Convert.ToInt64(ADT_Valor_por_periodos.Text);
        Int64 Valor_General = Convert.ToInt64(Valor_1 + Valor_2 + Valor_3);
        ADT_Total_A_Ajustar.Text = Valor_General.ToString();

    }
    protected void Generar_Nota_ADT()
    {
        if ((Convert.ToString(CE_Fecha_Inicial.Text) != "") && (Convert.ToString(ADT_Fecha_Inicial.Text) != ""))
        {

            var Parte_1 = "Se solicita ajuste por diferencia de tarifas segun renta facturada en RR $";
            var Parte_2 = ADT_Valor_Total_Facturado.Text;
            var Parte_3 = " iva incluido y la tarifa en reclamacion $";
            var Parte_4 = ADT_Valor_Contratado.Text;
            var Parte_5 = " iva incluido, con una diferencia de $";
            var Parte_6 = ADT_Valor_Diferencia.Text;
            var Parte_7 = " iva incluido segun contrato N° ";
            var Parte_8 = ADT_Contrato_Cliente.Text;
            var Parte_9 = ". se debe realizar correcion desde el ";
            var Parte_10 = CE_Fecha_Inicial.Text;
            var Parte_11 = " hasta el ";
            var Parte_12 = CE_Fecha_Final.Text;
            var Parte_13 = ", y entre el ";
            var Parte_14 = ADT_Fecha_Inicial.Text;
            var Parte_15 = " hasta el ";
            var Parte_16 = ADT_Fecha_Final.Text;

            if (Convert.ToString(ADT_Periodos.SelectedItem) != "0")
            {
                var Parte_17 = ", tambien se incluyen en el ajuste ";
                var Parte_18 = Convert.ToString(ADT_Periodos.SelectedItem);
                var Parte_19 = " periodos completos.";
                var Nota_Final = Parte_1 + Parte_2 + Parte_3 + Parte_4 + Parte_5 + Parte_6 + Parte_7 + Parte_8 + Parte_9 + Parte_10 + Parte_11 + Parte_12 + Parte_13 + Parte_14 + Parte_15 + Parte_16 + Parte_17 + Parte_18 + Parte_19;
                ADT_Notas.Text = Nota_Final;

            }
            else
            {

                var Nota_Final = Parte_1 + Parte_2 + Parte_3 + Parte_4 + Parte_5 + Parte_6 + Parte_7 + Parte_8 + Parte_9 + Parte_10 + Parte_11 + Parte_12 + Parte_13 + Parte_14 + Parte_15 + Parte_16;
                ADT_Notas.Text = Nota_Final;

            }


        }
        else
        {
            var Parte_1 = "Se solicita ajuste por diferencia de tarifas segun renta facturada en RR ";
            var Parte_2 = ADT_Valor_Total_Facturado.Text;
            var Parte_3 = " iva incluido y la tarifa en reclamacion ";
            var Parte_4 = ADT_Valor_Contratado.Text;
            var Parte_5 = " iva incluido, con una diferencia de ";
            var Parte_6 = ADT_Valor_Diferencia.Text;
            var Parte_7 = " iva incluido segun contrato N° ";
            var Parte_8 = ADT_Contrato_Cliente.Text;
            var Parte_9 = ". se debe realizar correcion desde el ";
            var Parte_10 = CE_Fecha_Inicial.Text;
            var Parte_11 = " hasta el ";
            var Parte_12 = CE_Fecha_Final.Text;
            if (Convert.ToString(ADT_Periodos.SelectedItem) != "0")
            {
                var Parte_17 = ", tambien se incluyen en el ajuste ";
                var Parte_18 = Convert.ToString(ADT_Periodos.SelectedItem);
                var Parte_19 = " periodos completos.";
                var Nota_Final = Parte_1 + Parte_2 + Parte_3 + Parte_4 + Parte_5 + Parte_6 + Parte_7 + Parte_8 + Parte_9 + Parte_10 + Parte_11 + Parte_12 + Parte_17 + Parte_18 + Parte_19;
                ADT_Notas.Text = Nota_Final;

            }
            else
            {

                var Nota_Final = Parte_1 + Parte_2 + Parte_3 + Parte_4 + Parte_5 + Parte_6 + Parte_7 + Parte_8 + Parte_9 + Parte_10 + Parte_11 + Parte_12;
                ADT_Notas.Text = Nota_Final;

            }
        }


    }
    protected void Limpiar_Controles_ADT()
    {
        var Limpiar = "0";
        ADT_Nombre_Cliente.Text = Limpiar;
        ADT_Apellido_Cliente.Text = Limpiar;
        ADT_VT_SI.Text = Limpiar;
        ADT_VT_I.Text = Limpiar;
        ADT_VT_VT.Text = Limpiar;
        ADT_VI_SI.Text = Limpiar;
        ADT_VI_I.Text = Limpiar;
        ADT_VI_VT.Text = Limpiar;
        ADT_VV__SI.Text = Limpiar;
        ADT_VV_I.Text = Limpiar;
        ADT_VV_VT.Text = Limpiar;
        ADT_VF_SI.Text = Limpiar;
        ADT_VF_I.Text = Limpiar;
        ADT_VF_VT.Text = Limpiar;
        ADT_VLD_SI.Text = Limpiar;
        ADT_VLD_I.Text = Limpiar;
        ADT_VLD_VT.Text = Limpiar;
        ADT_VR_SI.Text = Limpiar;
        ADT_VR_I.Text = Limpiar;
        ADT_VR_VT.Text = Limpiar;
        ADT_VHB_SI.Text = Limpiar;
        ADT_VHB_I.Text = Limpiar;
        ADT_VHB_VT.Text = Limpiar;
        ADT_VMP_SI.Text = Limpiar;
        ADT_VMP_I.Text = Limpiar;
        ADT_VMP_VT.Text = Limpiar;
        ADT_VTHD_SI.Text = Limpiar;
        ADT_VTHD_I.Text = Limpiar;
        ADT_VTHD_VT.Text = Limpiar;
        ADT_VSP_SI.Text = Limpiar;
        ADT_VSP_I.Text = Limpiar;
        ADT_VSP_VT.Text = Limpiar;
        ADT_VVNS_SI.Text = Limpiar;
        ADT_VVNS_I.Text = Limpiar;
        ADT_VVNS_VT.Text = Limpiar;
        ADT_VPVR_SI.Text = Limpiar;
        ADT_VPVR_I.Text = Limpiar;
        ADT_VPVR_VT.Text = Limpiar;
        ADT_VWIFI_SI.Text = Limpiar;
        ADT_VWIFI_I.Text = Limpiar;
        ADT_VWIFI_VT.Text = Limpiar;
        ADT_CLAROVIDEO_SI.Text = Limpiar;
        ADT_CLAROVIDEO_I.Text = Limpiar;
        ADT_CLAROVIDEO_VT.Text = Limpiar;
        ADT_Valor_Total_Facturado.Text = Limpiar;
        ADT_Estrato_Cliente.Text = Limpiar;
        ADT_Valor_Contratado.Text = Limpiar;
        ADT_Subcidio_Internet.Text = Limpiar;
        ADT_Subcidio_Voz.Text = Limpiar;
        ADT_Valor_Diferencia.Text = Limpiar;
        CE_Fecha_Inicial.Text = "";
        CE_Fecha_Final.Text = "";
        ADT_Fecha_Inicial.Text = "";
        ADT_Fecha_Final.Text = "";
        ADT_Periodos.ClearSelection();
        ADT_Cantidad_de_Dias.Text = Limpiar;
        ADT_Cantidad_de_Dias_Segundo_Periodo.Text = Limpiar;
        ADT_Valor_por_fechas.Text = Limpiar;
        ADT_Valor_por_fechas_2.Text = Limpiar;
        ADT_Valor_por_periodos.Text = Limpiar;
        ADT_Total_A_Ajustar.Text = Limpiar;
        ADT_Contrato_Cliente.Text = Limpiar;
        ADT_NV_F.Text = Limpiar;
        ADT_IV_F.Text = Limpiar;
        ADT_VDV_F.Text = Limpiar;
        ADT_NF_F.Text = Limpiar;
        ADT_IF_F.Text = Limpiar;
        ADT_VDF_F.Text = Limpiar;
        ADT_NI_F.Text = Limpiar;
        ADT_II_F.Text = Limpiar;
        ADT_VDI_F.Text = Limpiar;
        ADT_NTV_F.Text = Limpiar;
        ADT_ITV_F.Text = Limpiar;
        ADT_VDTV_F.Text = Limpiar;
        ADT_NA_F.Text = Limpiar;
        ADT_IA_F.Text = Limpiar;
        ADT_VDA_F.Text = Limpiar;
        ADT_NCLAROVIDEO_F.Text = Limpiar;
        ADT_ICLAROVIDEO_F.Text = Limpiar;
        ADT_VDCLAROVIDEO_F.Text = Limpiar;
        ADT_Notas.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Limpiar_Controles_ADT();
    }
    protected void AC_Radio_1_CheckedChanged(object sender, EventArgs e)
    {
        string script = "AC_Abrir_Primer_Calculo();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "script", script, true);
    }
    protected void AC_Radio_2_CheckedChanged(object sender, EventArgs e)
    {
        string script = "AC_Cerrar_Primer_Calculo();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "script", script, true);
    }
    protected void AC_Radio_3_CheckedChanged(object sender, EventArgs e)
    {
        string script = "AC_Abrir_Segundo_Calculo();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "script", script, true);
    }
    protected void AC_Radio_4_CheckedChanged(object sender, EventArgs e)
    {
        string script = "AC_Cerrar_Segundo_Calculo();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "script", script, true);
    }
    protected void AC_Radio_5_CheckedChanged(object sender, EventArgs e)
    {
        string script = "AC_Abrir_Tercer_Calculo();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "script", script, true);
    }
    protected void AC_Radio_6_CheckedChanged(object sender, EventArgs e)
    {
        string script = "AC_Cerrar_Tercer_Calculo();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "script", script, true);
    }
    protected void AC_Limpiar_Controles_Click(object sender, EventArgs e)
    {

        AC_C1_Cantidad_Horas.Text = "";
        AC_C1_Cantidad_Das.Text = "";
        AC_Internet.Checked = false;
        AC_Telefonia.Checked = false;
        AC_Renta_Internet.Text = "0";
        AC_Renta_Telefonia.Text = "0";
        AC_APCI.Text = "0";
        AC_APCV.Text = "0";
        AC_APFI.Text = "0";
        AC_APFV.Text = "0";
        AC_Notas.Text = "";
        string script = "AC_Limpiar_Controles();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "AC_Limpiar_Controles", script, true);
    }
    protected void AC_Ejecutar_Aclculos_Click(object sender, EventArgs e)
    {
        if ((Convert.ToString(AC_C1_Fecha_Inicial.Text) == "") || (Convert.ToString(AC_C1_Fecha_Final.Text) == "")) { }
        else
        {
            DateTime Fecha_Inicial = Convert.ToDateTime(AC_C1_Fecha_Inicial.Text);
            DateTime Fecha_Final = Convert.ToDateTime(AC_C1_Fecha_Final.Text);
            TimeSpan Dia_Inicial = Fecha_Final.Subtract(Fecha_Inicial);
            int Cantidad_Horas = Dia_Inicial.Hours;
            Int64 Cantidad_Dias = Convert.ToInt64(Dia_Inicial.Days.ToString());
            Int64 Total_Horas = Convert.ToInt64((Cantidad_Dias * 24) + Cantidad_Horas);
            string Final_Cantidad_Horas = "0";
            string Final_Minutos = "0";
            int Minutos = Dia_Inicial.Minutes;
            if (Total_Horas < 10) { Final_Cantidad_Horas = "0" + Total_Horas; } else { Final_Cantidad_Horas = Total_Horas.ToString(); }
            if (Minutos < 10) { Final_Minutos = "0" + Minutos; } else { Final_Minutos = Minutos.ToString(); }


            AC_C1_Cantidad_Horas.Text = Convert.ToString(Final_Cantidad_Horas + ":" + Final_Minutos);
            //AC_C1_Cantidad_Horas.Text = Total_Horas.ToString();
            AC_C1_Cantidad_Das.Text = Cantidad_Dias.ToString();




            //Int64 Validador_Horas = Convert.ToInt64(AC_C1_Cantidad_Horas.Text);

            if (AC_Radio_1.Checked == true)
            {
                Int64 _Calculo_Total_Horas = 0;
                if (Minutos > 0) { _Calculo_Total_Horas = Total_Horas + 1; } else { _Calculo_Total_Horas = Total_Horas; }
                if (_Calculo_Total_Horas > 7)
                {
                    string script = "Mostrar_Aviso_Rechazo_2();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Mostrar_Aviso_Rechazo_2()", script, true);

                }
                else
                {

                    string script = "Mostrar_Aviso_Rechazo_1();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Mostrar_Aviso_Rechazo_1()", script, true);
                }

            }
            else if (AC_Radio_3.Checked == true)
            {

                if (Total_Horas >= 48)
                {

                    string script = "Mostrar_Aviso_Rechazo_4();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Mostrar_Aviso_Rechazo_4()", script, true);

                }
                else
                {

                    string script = "Mostrar_Aviso_Rechazo_3();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Mostrar_Aviso_Rechazo_3()", script, true);
                }

            }
            else if (AC_Radio_5.Checked == true)
            {
                if (Total_Horas >= 48)
                {
                    string script = "Mostrar_Aviso_Rechazo_6();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Mostrar_Aviso_Rechazo_6()", script, true);

                }
                else
                {

                    string script = "Mostrar_Aviso_Rechazo_5();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Mostrar_Aviso_Rechazo_5()", script, true);
                }
            }
            else { }
        }
        AC_Calculos_Internet();
        AC_Calculos_Telefonia();
    }
    protected void AC_Internet_CheckedChanged(object sender, EventArgs e)
    {
        if (AC_Internet.Checked == true)
        {
            AC_Renta_Internet.Enabled = true;
            AC_Renta_Internet.Text = "0";
            AC_Calculos_Internet();
            AC_Notas_Para_RR();
        }
        else
        {
            AC_Renta_Internet.Enabled = false;
            AC_Renta_Internet.Text = "0";
            AC_Calculos_Internet();
            AC_Notas_Para_RR();
        }

    }
    protected void AC_Telefonia_CheckedChanged(object sender, EventArgs e)
    {
        if (AC_Telefonia.Checked == true)
        {
            AC_Renta_Telefonia.Enabled = true;
            AC_Renta_Telefonia.Text = "0";
            AC_Calculos_Telefonia();
            AC_Notas_Para_RR();
        }
        else
        {
            AC_Renta_Telefonia.Enabled = false;
            AC_Renta_Telefonia.Text = "0";
            AC_Calculos_Telefonia();
            AC_Notas_Para_RR();
        }

    }
    protected void AC_Calculos_Internet()
    {
        if (Convert.ToString(AC_Renta_Internet.Text) == "0") { }
        else
        {
            DateTime Fecha_Inicial = Convert.ToDateTime(AC_C1_Fecha_Inicial.Text);
            DateTime Fecha_Final = Convert.ToDateTime(AC_C1_Fecha_Final.Text);
            TimeSpan Dia_Inicial = Fecha_Final.Subtract(Fecha_Inicial);
            int Cantidad_Horas = Dia_Inicial.Hours;
            Int64 Cantidad_Dias = Convert.ToInt64(Dia_Inicial.Days.ToString());
            Int64 Total_Horas = Convert.ToInt64((Cantidad_Dias * 24) + Cantidad_Horas);
            int Minutos = Dia_Inicial.Minutes;

            float Cantidad_Horas_Falla = Total_Horas;
            float Valor_Renta = Convert.ToInt64(AC_Renta_Internet.Text);
            float Valor_Calculo_1 = (Valor_Renta / 720);
            float Valor_Calculo_2 = (Valor_Calculo_1 * Cantidad_Horas_Falla);
            float Valor_Calculo_3 = (Valor_Calculo_1 / 60);
            float Valor_Calculo_4 = (Valor_Calculo_3 * Minutos);
            Int64 Valor_Final = Convert.ToInt64(Valor_Calculo_2 + Valor_Calculo_4);

            AC_APCI.Text = Valor_Final.ToString();
            AC_APFI.Text = Valor_Final.ToString();
        }
    }
    protected void AC_Calculos_Telefonia()
    {

        if (Convert.ToString(AC_Renta_Telefonia.Text) == "0") { }
        else
        {
            DateTime Fecha_Inicial = Convert.ToDateTime(AC_C1_Fecha_Inicial.Text);
            DateTime Fecha_Final = Convert.ToDateTime(AC_C1_Fecha_Final.Text);
            TimeSpan Dia_Inicial = Fecha_Final.Subtract(Fecha_Inicial);
            int Cantidad_Horas = Dia_Inicial.Hours;
            Int64 Cantidad_Dias = Convert.ToInt64(Dia_Inicial.Days.ToString());
            Int64 Total_Horas = Convert.ToInt64((Cantidad_Dias * 24) + Cantidad_Horas);
            int Minutos = Dia_Inicial.Minutes;

            float Cantidad_Horas_Falla = Total_Horas;
            float Valor_Renta = Convert.ToInt64(AC_Renta_Telefonia.Text);
            float Valor_Calculo_1 = (Valor_Renta / 720);
            float Valor_Calculo_2 = (Valor_Calculo_1 * Cantidad_Horas_Falla);
            float Valor_Calculo_3 = (Valor_Calculo_1 / 60);
            float Valor_Calculo_4 = (Valor_Calculo_3 * Minutos);
            Int64 Valor_Final = Convert.ToInt64(Valor_Calculo_2 + Valor_Calculo_4);

            AC_APCV.Text = Valor_Final.ToString();
            AC_APFV.Text = Valor_Final.ToString();
        }
    }
    protected void AC_Renta_Internet_TextChanged(object sender, EventArgs e)
    {
        AC_Calculos_Internet();
        AC_Notas_Para_RR();
    }
    protected void AC_Renta_Telefonia_TextChanged(object sender, EventArgs e)
    {
        AC_Calculos_Telefonia();
        AC_Notas_Para_RR();
    }
    protected void AC_Notas_Para_RR()
    {
        DateTime Fecha_Inicial = Convert.ToDateTime(AC_C1_Fecha_Inicial.Text);
        int Hora_Inicio = Fecha_Inicial.Hour;
        string Hora_Inicio_Nota = "";
        if (Hora_Inicio < 10) { Hora_Inicio_Nota = "0" + Hora_Inicio; } else { Hora_Inicio_Nota = Hora_Inicio.ToString(); }
        int Minutos_Inicio = Fecha_Inicial.Minute;
        string Minuto_Inicio_Nota = "";
        if (Minutos_Inicio < 10) { Minuto_Inicio_Nota = "0" + Minutos_Inicio; } else { Minuto_Inicio_Nota = Minutos_Inicio.ToString(); }
        DateTime Fecha_Final = Convert.ToDateTime(AC_C1_Fecha_Final.Text);
        int Hora_Fin = Fecha_Final.Hour;
        string Hora_Fin_Nota = "";
        if (Hora_Fin < 10) { Hora_Fin_Nota = "0" + Hora_Fin; } else { Hora_Fin_Nota = Hora_Fin.ToString(); }
        int Minuto_Fin = Fecha_Final.Minute;
        string Minuto_Final_Nota = "";
        if (Minuto_Fin < 10) { Minuto_Final_Nota = "0" + Minuto_Fin; } else { Minuto_Final_Nota = Minuto_Fin.ToString(); }
        string Hora_Inicial_Falla = Hora_Inicio_Nota + ":" + Minuto_Inicio_Nota;
        string Hora_Final_Falla = Hora_Fin_Nota + ":" + Minuto_Final_Nota;

        var Tipo_Ajuste = "";
        var Servicios = "";
        Int64 Valor_1 = Convert.ToInt64(AC_APCI.Text);
        Int64 Valor_2 = Convert.ToInt64(AC_APFI.Text);
        Int64 Valor_3 = Convert.ToInt64(AC_APCV.Text);
        Int64 Valor_4 = Convert.ToInt64(AC_APFV.Text);

        float Suma_Internet = Valor_1 + Valor_2;
        float Suma_Telefonia = Valor_3 + Valor_4;
        float Sumta_Total = Suma_Internet + Suma_Telefonia;
        float Ajuste_Fallas = Valor_2 + Valor_4;
        float Ajuste_Compensacion = Valor_1 + Valor_3;


        TimeSpan Dia_Inicial = Fecha_Final.Subtract(Fecha_Inicial);
        int Cantidad_Horas = Dia_Inicial.Hours;
        Int64 Cantidad_Dias = Convert.ToInt64(Dia_Inicial.Days.ToString());
        Int64 Total_Horas = Convert.ToInt64((Cantidad_Dias * 24) + Cantidad_Horas);
        string Final_Cantidad_Horas = "0";
        string Final_Minutos = "0";
        int Minutos = Dia_Inicial.Minutes;
        if (Total_Horas < 10) { Final_Cantidad_Horas = "0" + Total_Horas; } else { Final_Cantidad_Horas = Total_Horas.ToString(); }
        if (Minutos < 10) { Final_Minutos = "0" + Minutos; } else { Final_Minutos = Minutos.ToString(); }


        if (AC_Radio_1.Checked == true)
        {
            Tipo_Ajuste = "DESCONEXION INJUSTIFICADA";
        }
        else if (AC_Radio_3.Checked == true)
        {
            Tipo_Ajuste = "FALLAS TECNICAS";

        }
        else if (AC_Radio_5.Checked == true)
        {
            Tipo_Ajuste = "FALLAS EN EL EQUIPO TERMINAL";
        }
        else { }

        if (AC_Internet.Checked == true)
        {
            if (AC_Telefonia.Checked == true)
            {
                Servicios = "INTERNET Y TELEFONIA";

                var Notas_RR = "TIEMPO SIN SERVICIO DE " + Servicios + " POR " + Tipo_Ajuste + " ENTRE EL " + Fecha_Inicial + " Y EL " + Fecha_Final + " CON UNA HORA DE INICIO " + Hora_Inicial_Falla + " Y HORA FIN " + Hora_Final_Falla + ", PARA UN TOTAL DE " + Total_Horas + " HORAS Y " + Final_Minutos + " MINUTOS, LO EQUIVALENTE A UN VALOR DE AJUSTE POR $ " + Ajuste_Fallas + " Y UN VALOR DE CONPENSACION DE $ " + Ajuste_Compensacion + " SIN IVA, SEGUN SOPORTE(S) (LLAMADA DE SERVICIO, OT, LOG, AVISOS FINALES), LO ANTERIOR DISCRIMINADO POR SERVICIO ASI: AJUSTE POR INTERNET DE $ " + Valor_2 + " Y COMPENSACION DE INTERNET POR $" + Valor_1 + ", AJUSTE POR TELEFONIA DE $" + Valor_4 + " Y COMPENSACION POR TELEFONIA DE $" + Valor_3;
                AC_Notas.Text = Notas_RR;
            }
            else
            {
                Servicios = "INTERNET";
                var Notas_RR = "TIEMPO SIN SERVICIO DE " + Servicios + " POR " + Tipo_Ajuste + " ENTRE EL " + Fecha_Inicial + " Y EL " + Fecha_Final + " CON UNA HORA DE INICIO " + Hora_Inicial_Falla + " Y HORA FIN " + Hora_Final_Falla + ", PARA UN TOTAL DE " + Total_Horas + " HORAS Y " + Final_Minutos + " MINUTOS, LO EQUIVALENTE A UN VALOR DE AJUSTE POR $ " + Ajuste_Fallas + " Y UN VALOR DE CONPENSACION DE $ " + Ajuste_Compensacion + " SIN IVA, SEGUN SOPORTE(S) (LLAMADA DE SERVICIO, OT, LOG, AVISOS FINALES), LO ANTERIOR DISCRIMINADO POR SERVICIO ASI: AJUSTE POR INTERNET DE $ " + Valor_2 + " Y COMPENSACION DE INTERNET POR $" + Valor_1;
                AC_Notas.Text = Notas_RR;
            }
        }
        else
        {
            if (AC_Telefonia.Checked == true)
            {

                Servicios = "TELEFONIA";
                var Notas_RR = "TIEMPO SIN SERVICIO DE " + Servicios + " POR " + Tipo_Ajuste + " ENTRE EL " + Fecha_Inicial + " Y EL " + Fecha_Final + " CON UNA HORA DE INICIO " + Hora_Inicial_Falla + " Y HORA FIN " + Hora_Final_Falla + ", PARA UN TOTAL DE " + Total_Horas + " HORAS Y " + Final_Minutos + " MINUTOS, LO EQUIVALENTE A UN VALOR DE AJUSTE POR $ " + Ajuste_Fallas + " Y UN VALOR DE CONPENSACION DE $ " + Ajuste_Compensacion + " SIN IVA, SEGUN SOPORTE(S) (LLAMADA DE SERVICIO, OT, LOG, AVISOS FINALES), LO ANTERIOR DISCRIMINADO POR SERVICIO ASI: AJUSTE POR TELEFONIA DE $ " + Valor_4 + " Y COMPENSACION DE TELEFONIA POR $" + Valor_3;
                AC_Notas.Text = Notas_RR;

            }
            else { Servicios = ""; }
        }


    }
    protected void AP_cargar_Datos_Click(object sender, EventArgs e)
    {
        AP_Estrato_Cliente.Text = Estrato.Text;
        AP_Nombre_Cliente.Text = Nombre_Cliente.Text;
        AP_Apellido_Cliente.Text = Apellido_Cliente.Text;

    }
    protected void AP_TV_RR_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(AP_TV_RR.Text);
        var Estrato_Cliente = AP_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        AP_TV_IVA.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(AP_TV_IVA.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        AP_TV_TOTAL.Text = Convert.ToString(ValorMasIva);
        AP_Generar_Calculos_Valores();

    }
    protected void AP_IN_RR_TextChanged(object sender, EventArgs e)
    {
        var Estrato_Cliente = AP_Estrato_Cliente.Text;

        if ((Convert.ToString(Estrato_Cliente) == "1") || (Convert.ToString(Estrato_Cliente) == "2") || (Convert.ToString(Estrato_Cliente) == "3"))
        {
            Int64 Valor_Servicio = Convert.ToInt64(AP_IN_RR.Text);
            AP_IN_IVA.Text = Convert.ToString(0);
            AP_IN_TOTAL.Text = Convert.ToString(Valor_Servicio);
            AP_Generar_Calculos_Valores();
        }
        else
        {
            Int64 Valor_Servicio = Convert.ToInt64(AP_IN_RR.Text);
            var Iva = 16;
            var Porcentaje = 100;
            AP_IN_IVA.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
            var ValorIva = Convert.ToInt64(AP_IN_IVA.Text);
            var ValorMasIva = Valor_Servicio + ValorIva;
            AP_IN_TOTAL.Text = Convert.ToString(ValorMasIva);
            AP_Generar_Calculos_Valores();
        }

    }
    protected void AP_VOZ_RR_TextChanged(object sender, EventArgs e)
    {
        var Estrato_Cliente = AP_Estrato_Cliente.Text;

        if ((Estrato_Cliente == "1") || (Estrato_Cliente == "2"))
        {
            var Iva = 16;
            var Iva2 = Convert.ToDecimal(56.8);
            int Porcentaje = 100;
            Int64 Valor_Inicial = Convert.ToInt64(AP_VOZ_RR.Text);
            Int64 Valor_Iva = Convert.ToInt64(((Valor_Inicial) * Iva2 / Porcentaje) * Iva / Porcentaje);
            AP_VOZ_IVA.Text = Convert.ToString(Valor_Iva);
            AP_VOZ_TOTAL.Text = Convert.ToString(Valor_Inicial + Valor_Iva);
            AP_Generar_Calculos_Valores();
        }
        else
        {
            var Iva = 16;
            var Porcentaje = 100;
            Int64 Valor = Convert.ToInt64(AP_VOZ_RR.Text);
            AP_VOZ_IVA.Text = Convert.ToString((Valor * Iva) / Porcentaje);
            var ValorIva = Convert.ToInt64(AP_VOZ_IVA.Text);
            var ValorMasIva = Valor + ValorIva;
            AP_VOZ_TOTAL.Text = Convert.ToString(ValorMasIva);
            AP_Generar_Calculos_Valores();
        }
    }
    protected void AP_FUN_RR_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(AP_FUN_RR.Text);
        var Estrato_Cliente = AP_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        AP_FUN_IVA.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(AP_FUN_IVA.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        AP_FUN_TOTAL.Text = Convert.ToString(ValorMasIva);
        AP_Generar_Calculos_Valores();
    }
    protected void AP_LD_RR_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(AP_LD_RR.Text);
        var Estrato_Cliente = AP_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        AP_LD_IVA.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(AP_LD_IVA.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        AP_LD_TOTAL.Text = Convert.ToString(ValorMasIva);
        AP_Generar_Calculos_Valores();
    }
    protected void AP_RV_RR_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(AP_RV_RR.Text);
        var Estrato_Cliente = AP_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        AP_RV_IVA.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(AP_RV_IVA.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        AP_RV_TOTAL.Text = Convert.ToString(ValorMasIva);
        AP_Generar_Calculos_Valores();
    }
    protected void AP_HBO_RR_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(AP_HBO_RR.Text);
        var Estrato_Cliente = AP_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        AP_HBO_IVA.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(AP_HBO_IVA.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        AP_HBO_TOTAL.Text = Convert.ToString(ValorMasIva);
        AP_Generar_Calculos_Valores();
    }
    protected void AP_MPK_RR_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(AP_MPK_RR.Text);
        var Estrato_Cliente = AP_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        AP_MPK_IVA.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(AP_MPK_IVA.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        AP_MPK_TOTAL.Text = Convert.ToString(ValorMasIva);
        AP_Generar_Calculos_Valores();
    }
    protected void AP_TVHD_RR_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(AP_TVHD_RR.Text);
        var Estrato_Cliente = AP_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        AP_TVHD_IVA.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(AP_TVHD_IVA.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        AP_TVHD_TOTAL.Text = Convert.ToString(ValorMasIva);
        AP_Generar_Calculos_Valores();
    }
    protected void AP_SP_RR_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(AP_SP_RR.Text);
        var Estrato_Cliente = AP_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        AP_SP_IVA.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(AP_SP_IVA.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        AP_SP_TOTAL.Text = Convert.ToString(ValorMasIva);
        AP_Generar_Calculos_Valores();
    }
    protected void AP_VENUS_RR_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(AP_VENUS_RR.Text);
        var Estrato_Cliente = AP_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        AP_VENUS_IVA.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(AP_VENUS_IVA.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        AP_VENUS_TOTAL.Text = Convert.ToString(ValorMasIva);
        AP_Generar_Calculos_Valores();
    }
    protected void AP_PVR_RR_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(AP_PVR_RR.Text);
        var Estrato_Cliente = AP_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        AP_PVR_IVA.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(AP_PVR_IVA.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        AP_PVR_TOTAL.Text = Convert.ToString(ValorMasIva);
        AP_Generar_Calculos_Valores();
    }
    protected void AP_WIFI_RR_TextChanged(object sender, EventArgs e)
    {
        var Estrato_Cliente = AP_Estrato_Cliente.Text;

        if ((Convert.ToString(Estrato_Cliente) == "1") || (Convert.ToString(Estrato_Cliente) == "2") || (Convert.ToString(Estrato_Cliente) == "3"))
        {
            Int64 Valor_Servicio = Convert.ToInt64(AP_WIFI_RR.Text);
            AP_WIFI_IVA.Text = Convert.ToString(0);
            AP_WIFI_TOTAL.Text = Convert.ToString(Valor_Servicio);
            AP_Generar_Calculos_Valores();
        }
        else
        {
            Int64 Valor_Servicio = Convert.ToInt64(AP_WIFI_RR.Text);
            var Iva = 16;
            var Porcentaje = 100;
            AP_WIFI_IVA.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
            var ValorIva = Convert.ToInt64(AP_WIFI_IVA.Text);
            var ValorMasIva = Valor_Servicio + ValorIva;
            AP_WIFI_TOTAL.Text = Convert.ToString(ValorMasIva);
            AP_Generar_Calculos_Valores();
        }

    }
    protected void AP_CLAROVIDEO_RR_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(AP_CLAROVIDEO_RR.Text);
        var Estrato_Cliente = AP_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        AP_CLAROVIDEO_IVA.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(AP_CLAROVIDEO_IVA.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        AP_CLAROVIDEO_TOTAL.Text = Convert.ToString(ValorMasIva);
        AP_Generar_Calculos_Valores();
    }
    protected void AP_Calculo_Fechas_Click(object sender, EventArgs e)
    {
        if ((Convert.ToString(AP_Fecha_Inicial.Text) != "") && (Convert.ToString(AP_Fecha_Corte.Text) != "") && (Convert.ToString(AP_Fecha_Final.Text) != ""))
        {

            DateTime Fecha_Inicial = Convert.ToDateTime(AP_Fecha_Inicial.Text);
            DateTime Fecha_Final = Convert.ToDateTime(AP_Fecha_Final.Text);
            DateTime Fecha_Corte = Convert.ToDateTime(AP_Fecha_Corte.Text);
            TimeSpan Dia_Inicial = Fecha_Corte.Subtract(Fecha_Inicial);
            TimeSpan Dia_Inicial_1 = Fecha_Final.Subtract(Fecha_Corte);
            Int64 Total_Dias_1 = Convert.ToInt64(Dia_Inicial.Days.ToString());
            Int64 Total_Dias_2 = Convert.ToInt64(Dia_Inicial_1.Days.ToString());

            AP_Dias_Primer_Periodo.Text = Total_Dias_1.ToString();
            AP_Dias_Segundo_Periodo.Text = Total_Dias_2.ToString();

            this.AP_TV_RR_TextChanged(sender, e);
            this.AP_IN_RR_TextChanged(sender, e);
            this.AP_VOZ_RR_TextChanged(sender, e);
            this.AP_FUN_RR_TextChanged(sender, e);
            this.AP_LD_RR_TextChanged(sender, e);
            this.AP_RV_RR_TextChanged(sender, e);
            this.AP_HBO_RR_TextChanged(sender, e);
            this.AP_MPK_RR_TextChanged(sender, e);
            this.AP_TVHD_RR_TextChanged(sender, e);
            this.AP_SP_RR_TextChanged(sender, e);
            this.AP_VENUS_RR_TextChanged(sender, e);
            this.AP_PVR_RR_TextChanged(sender, e);
            this.AP_WIFI_RR_TextChanged(sender, e);
            this.AP_CLAROVIDEO_RR_TextChanged(sender, e);

            AP_Generar_Calculos_Valores();
        }
        else
        { }
    }
    protected void AP_Generar_Calculos_Valores()
    {

        int Numero_Mes = Convert.ToDateTime(AP_Fecha_Inicial.Text).Month;
        int Numero_Mes_2 = Convert.ToDateTime(AP_Fecha_Final.Text).Month;
        int Cantidad_Dias = 0;
        int Cantidad_Dias_2 = 0;
        int Numero_ano = Convert.ToDateTime(AP_Fecha_Inicial.Text).Year;
        int Numero_ano_2 = Convert.ToDateTime(AP_Fecha_Final.Text).Year;
        int Dias_Febrero = 0;
        int Dias_Febrero_2 = 0;

        if ((Numero_ano == 2016) || (Numero_ano == 2020) || (Numero_ano == 2024) || (Numero_ano == 2028) || (Numero_ano == 2032) || (Numero_ano == 2036) || (Numero_ano == 2040) || (Numero_ano == 2044)) { Dias_Febrero = 29; }
        else { Dias_Febrero = 28; }

        if ((Numero_ano_2 == 2016) || (Numero_ano_2 == 2020) || (Numero_ano_2 == 2024) || (Numero_ano_2 == 2028) || (Numero_ano_2 == 2032) || (Numero_ano_2 == 2036) || (Numero_ano_2 == 2040) || (Numero_ano_2 == 2044)) { Dias_Febrero_2 = 29; }
        else { Dias_Febrero_2 = 28; }

        if ((Numero_Mes == 1) || (Numero_Mes == 3) || (Numero_Mes == 5) || (Numero_Mes == 7) || (Numero_Mes == 8) || (Numero_Mes == 10) || (Numero_Mes == 12)) { Cantidad_Dias = 31; }
        else if ((Numero_Mes == 2)) { Cantidad_Dias = Dias_Febrero; }
        else if ((Numero_Mes == 4) || (Numero_Mes == 6) || (Numero_Mes == 9) || (Numero_Mes == 11)) { Cantidad_Dias = 30; };

        if ((Numero_Mes_2 == 1) || (Numero_Mes_2 == 3) || (Numero_Mes_2 == 5) || (Numero_Mes_2 == 7) || (Numero_Mes_2 == 8) || (Numero_Mes_2 == 10) || (Numero_Mes_2 == 12)) { Cantidad_Dias_2 = 31; }
        else if ((Numero_Mes_2 == 2)) { Cantidad_Dias_2 = Dias_Febrero_2; }
        else if ((Numero_Mes_2 == 4) || (Numero_Mes_2 == 6) || (Numero_Mes_2 == 9) || (Numero_Mes_2 == 11)) { Cantidad_Dias_2 = 30; };

        int Dias_Primer_Periodo = Convert.ToInt16(AP_Dias_Primer_Periodo.Text);
        int Dias_Segundo_Periodo = Convert.ToInt16(AP_Dias_Segundo_Periodo.Text);


        //CALCULOS PARA EL PRIMER PERIODO
        float Valor_Television = Convert.ToInt64(AP_TV_TOTAL.Text);
        float Valor_Disputa_Television = Convert.ToInt64((Valor_Television / Cantidad_Dias) * Dias_Primer_Periodo);
        AP_TV_1P.Text = Valor_Disputa_Television.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_Internet = Convert.ToInt64(AP_IN_TOTAL.Text);
        float Valor_Disputa_Internet = Convert.ToInt64((Valor_Internet / Cantidad_Dias) * Dias_Primer_Periodo);
        AP_IN_1P.Text = Valor_Disputa_Internet.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_Telefonia = Convert.ToInt64(AP_VOZ_TOTAL.Text);
        float Valor_Disputa_Telefonia = Convert.ToInt64((Valor_Telefonia / Cantidad_Dias) * Dias_Primer_Periodo);
        AP_VOZ_1P.Text = Valor_Disputa_Telefonia.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_Funcionalidades = Convert.ToInt64(AP_FUN_TOTAL.Text);
        float Valor_Disputa_Funcionalidades = Convert.ToInt64((Valor_Funcionalidades / Cantidad_Dias) * Dias_Primer_Periodo);
        AP_FUN_1P.Text = Valor_Disputa_Funcionalidades.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_LD_30 = Convert.ToInt64(AP_LD_TOTAL.Text);
        float Valor_Disputa_LD_30 = Convert.ToInt64((Valor_LD_30 / Cantidad_Dias) * Dias_Primer_Periodo);
        AP_LD_1P.Text = Valor_Disputa_LD_30.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_Revista = Convert.ToInt64(AP_RV_TOTAL.Text);
        float Valor_Disputa_Revista = Convert.ToInt64((Valor_Revista / Cantidad_Dias) * Dias_Primer_Periodo);
        AP_RV_1P.Text = Valor_Disputa_Revista.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_HBO = Convert.ToInt64(AP_HBO_TOTAL.Text);
        float Valor_Disputa_HBO = Convert.ToInt64((Valor_HBO / Cantidad_Dias) * Dias_Primer_Periodo);
        AP_HBO_1P.Text = Valor_Disputa_HBO.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_Mpk = Convert.ToInt64(AP_MPK_TOTAL.Text);
        float Valor_Disputa_Mpk = Convert.ToInt64((Valor_Mpk / Cantidad_Dias) * Dias_Primer_Periodo);
        AP_MPK_1P.Text = Valor_Disputa_Mpk.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_Tv_HD = Convert.ToInt64(AP_TVHD_TOTAL.Text);
        float Valor_Disputa_Tv_HD = Convert.ToInt64((Valor_Tv_HD / Cantidad_Dias) * Dias_Primer_Periodo);
        AP_TVHD_1P.Text = Valor_Disputa_Tv_HD.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_SP = Convert.ToInt64(AP_SP_TOTAL.Text);
        float Valor_Disputa_SP = Convert.ToInt64((Valor_SP / Cantidad_Dias) * Dias_Primer_Periodo);
        AP_SP_1P.Text = Valor_Disputa_SP.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_VENUS = Convert.ToInt64(AP_VENUS_TOTAL.Text);
        float Valor_Disputa_VENUS = Convert.ToInt64((Valor_VENUS / Cantidad_Dias) * Dias_Primer_Periodo);
        AP_VENUS_1P.Text = Valor_Disputa_VENUS.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_PVR = Convert.ToInt64(AP_PVR_TOTAL.Text);
        float Valor_Disputa_PVR = Convert.ToInt64((Valor_PVR / Cantidad_Dias) * Dias_Primer_Periodo);
        AP_PVR_1P.Text = Valor_Disputa_PVR.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_WIFI = Convert.ToInt64(AP_WIFI_TOTAL.Text);
        float Valor_Disputa_WIFI = Convert.ToInt64((Valor_WIFI / Cantidad_Dias) * Dias_Primer_Periodo);
        AP_WIFI_1P.Text = Valor_Disputa_WIFI.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_CLAROVIDEO = Convert.ToInt64(AP_CLAROVIDEO_TOTAL.Text);
        float Valor_Disputa_CLAROVIDEO = Convert.ToInt64((Valor_CLAROVIDEO / Cantidad_Dias) * Dias_Primer_Periodo);
        AP_CLAROVIDEO_1P.Text = Valor_Disputa_CLAROVIDEO.ToString();




        //CALCULOS PARA EL SEGUNDO PERIODO
        float Valor_Television_2 = Convert.ToInt64(AP_TV_TOTAL.Text);
        float Valor_Disputa_Television_2 = Convert.ToInt64((Valor_Television_2 / Cantidad_Dias_2) * Dias_Segundo_Periodo);
        AP_TV_2P.Text = Valor_Disputa_Television_2.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_Internet_2 = Convert.ToInt64(AP_IN_TOTAL.Text);
        float Valor_Disputa_Internet_2 = Convert.ToInt64((Valor_Internet_2 / Cantidad_Dias_2) * Dias_Segundo_Periodo);
        AP_IN_2P.Text = Valor_Disputa_Internet_2.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_Telefonia_2 = Convert.ToInt64(AP_VOZ_TOTAL.Text);
        float Valor_Disputa_Telefonia_2 = Convert.ToInt64((Valor_Telefonia_2 / Cantidad_Dias_2) * Dias_Segundo_Periodo);
        AP_VOZ_2P.Text = Valor_Disputa_Telefonia_2.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_Funcionalidades_2 = Convert.ToInt64(AP_FUN_TOTAL.Text);
        float Valor_Disputa_Funcionalidades_2 = Convert.ToInt64((Valor_Funcionalidades_2 / Cantidad_Dias_2) * Dias_Segundo_Periodo);
        AP_FUN_2P.Text = Valor_Disputa_Funcionalidades_2.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_LD_30_2 = Convert.ToInt64(AP_LD_TOTAL.Text);
        float Valor_Disputa_LD_30_2 = Convert.ToInt64((Valor_LD_30_2 / Cantidad_Dias_2) * Dias_Segundo_Periodo);
        AP_LD_2P.Text = Valor_Disputa_LD_30_2.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_Revista_2 = Convert.ToInt64(AP_RV_TOTAL.Text);
        float Valor_Disputa_Revista_2 = Convert.ToInt64((Valor_Revista_2 / Cantidad_Dias_2) * Dias_Segundo_Periodo);
        AP_RV_2P.Text = Valor_Disputa_Revista_2.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_HBO_2 = Convert.ToInt64(AP_HBO_TOTAL.Text);
        float Valor_Disputa_HBO_2 = Convert.ToInt64((Valor_HBO_2 / Cantidad_Dias_2) * Dias_Segundo_Periodo);
        AP_HBO_2P.Text = Valor_Disputa_HBO_2.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_Mpk_2 = Convert.ToInt64(AP_MPK_TOTAL.Text);
        float Valor_Disputa_Mpk_2 = Convert.ToInt64((Valor_Mpk_2 / Cantidad_Dias_2) * Dias_Segundo_Periodo);
        AP_MPK_2P.Text = Valor_Disputa_Mpk_2.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_Tv_HD_2 = Convert.ToInt64(AP_TVHD_TOTAL.Text);
        float Valor_Disputa_Tv_HD_2 = Convert.ToInt64((Valor_Tv_HD_2 / Cantidad_Dias_2) * Dias_Segundo_Periodo);
        AP_TVHD_2P.Text = Valor_Disputa_Tv_HD_2.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_SP_2 = Convert.ToInt64(AP_SP_TOTAL.Text);
        float Valor_Disputa_SP_2 = Convert.ToInt64((Valor_SP_2 / Cantidad_Dias_2) * Dias_Segundo_Periodo);
        AP_SP_2P.Text = Valor_Disputa_SP_2.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_VENUS_2 = Convert.ToInt64(AP_VENUS_TOTAL.Text);
        float Valor_Disputa_VENUS_2 = Convert.ToInt64((Valor_VENUS_2 / Cantidad_Dias_2) * Dias_Segundo_Periodo);
        AP_VENUS_2P.Text = Valor_Disputa_VENUS_2.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_PVR_2 = Convert.ToInt64(AP_PVR_TOTAL.Text);
        float Valor_Disputa_PVR_2 = Convert.ToInt64((Valor_PVR_2 / Cantidad_Dias_2) * Dias_Segundo_Periodo);
        AP_PVR_2P.Text = Valor_Disputa_PVR_2.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_WIFI_2 = Convert.ToInt64(AP_WIFI_TOTAL.Text);
        float Valor_Disputa_WIFI_2 = Convert.ToInt64((Valor_WIFI_2 / Cantidad_Dias_2) * Dias_Segundo_Periodo);
        AP_WIFI_2P.Text = Valor_Disputa_WIFI_2.ToString();

        //----------------SIGUIENTE SERVICIO----------------------------//
        float Valor_CLAROVIDEO_2 = Convert.ToInt64(AP_CLAROVIDEO_TOTAL.Text);
        float Valor_Disputa_CLAROVIDEO_2 = Convert.ToInt64((Valor_CLAROVIDEO_2 / Cantidad_Dias_2) * Dias_Segundo_Periodo);
        AP_CLAROVIDEO_2P.Text = Valor_Disputa_CLAROVIDEO_2.ToString();

        AP_Disputas_Finales();
    }
    protected void AP_Disputas_Finales()
    {
        float Valor_Total_Telefonia = Convert.ToInt64(Convert.ToInt64(AP_VOZ_1P.Text) + Convert.ToInt64(AP_VOZ_2P.Text));
        float Valor_Total_Funcionalidades = Convert.ToInt64(Convert.ToInt64(AP_FUN_1P.Text) + Convert.ToInt64(AP_FUN_2P.Text));
        float Valor_Total_LD_30 = Convert.ToInt64(Convert.ToInt64(AP_LD_1P.Text) + Convert.ToInt64(AP_LD_2P.Text));
        float Valor_Basico_Disputa_Telefonia = Convert.ToInt64(Valor_Total_Telefonia + Valor_Total_LD_30 + Valor_Total_Funcionalidades);
        AP_VOZ_NETO.Text = Valor_Basico_Disputa_Telefonia.ToString();

        //----SIGUIENTE SERVICIO----///
        float Valor_Total_Internet = Convert.ToInt64(Convert.ToInt64(AP_IN_1P.Text) + Convert.ToInt64(AP_IN_2P.Text));
        AP_IN_NETO.Text = Valor_Total_Internet.ToString();

        //----SIGUIENTE SERVICIO----///
        float Valor_Total_Television = Convert.ToInt64(Convert.ToInt64(AP_TV_1P.Text) + Convert.ToInt64(AP_TV_2P.Text));
        AP_TV_NETO.Text = Valor_Total_Television.ToString();

        //----SIGUIENTE SERVICIO----///
        float Valor_Total_Hbo = Convert.ToInt64(Convert.ToInt64(AP_HBO_1P.Text) + Convert.ToInt64(AP_HBO_2P.Text));
        AP_HBO_NETO.Text = Valor_Total_Hbo.ToString();

        //----SIGUIENTE SERVICIO----///
        float Valor_Total_Moviepack = Convert.ToInt64(Convert.ToInt64(AP_MPK_1P.Text) + Convert.ToInt64(AP_MPK_2P.Text));
        AP_MPK_NETO.Text = Valor_Total_Moviepack.ToString();

        //----SIGUIENTE SERVICIO----///
        float Valor_Total_Television_HD = Convert.ToInt64(Convert.ToInt64(AP_TVHD_1P.Text) + Convert.ToInt64(AP_TVHD_2P.Text));
        AP_TVHD_NETO.Text = Valor_Total_Television_HD.ToString();

        //----SIGUIENTE SERVICIO----///
        float Valor_Total_Spice = Convert.ToInt64(Convert.ToInt64(AP_SP_1P.Text) + Convert.ToInt64(AP_SP_2P.Text));
        AP_SP_NETO.Text = Valor_Total_Spice.ToString();

        //----SIGUIENTE SERVICIO----///
        float Valor_Total_Venus = Convert.ToInt64(Convert.ToInt64(AP_VENUS_1P.Text) + Convert.ToInt64(AP_VENUS_2P.Text));
        AP_VENUS_NETO.Text = Valor_Total_Venus.ToString();

        //----SIGUIENTE SERVICIO----///
        float Valor_Total_Pvr = Convert.ToInt64(Convert.ToInt64(AP_PVR_1P.Text) + Convert.ToInt64(AP_PVR_2P.Text));
        AP_PVR_NETO.Text = Valor_Total_Pvr.ToString();

        //----SIGUIENTE SERVICIO----///
        float Valor_Total_Wifi = Convert.ToInt64(Convert.ToInt64(AP_WIFI_1P.Text) + Convert.ToInt64(AP_WIFI_2P.Text));
        AP_WIFI_NETO.Text = Valor_Total_Wifi.ToString();

        //----SIGUIENTE SERVICIO----///
        float Valor_Total_CLAROVIDEO = Convert.ToInt64(Convert.ToInt64(AP_CLAROVIDEO_1P.Text) + Convert.ToInt64(AP_CLAROVIDEO_2P.Text));
        AP_CLAROVIDEO_NETO.Text = Valor_Total_CLAROVIDEO.ToString();

        AP_Iva_Servicios();
    }
    protected void AP_Iva_Servicios()
    {

        decimal Valor_Iva = 1.16m;
        float Valor_Negativo = -1;

        //-------------SIGUIENTE SERVICIO--------------//
        Int64 Valor_Television = Convert.ToInt64(AP_TV_NETO.Text);
        float Iva_Television = Convert.ToInt64((Valor_Television / Valor_Iva) - Valor_Television);
        Int64 Iva_Final_Television = Convert.ToInt64(Iva_Television * Valor_Negativo);
        AP_TV_NETO_IVA.Text = Iva_Final_Television.ToString();

        //-------------SIGUIENTE SERVICIO--------------//
        if ((Convert.ToString(AP_Estrato_Cliente.Text) == "1") || (Convert.ToString(AP_Estrato_Cliente.Text) == "2") || (Convert.ToString(AP_Estrato_Cliente.Text) == "3"))
        {
            AP_IN_NETO_IVA.Text = Convert.ToString(0);
        }
        else
        {
            Int64 Valor_Internet = Convert.ToInt64(AP_IN_NETO.Text);
            float Iva_Internet = Convert.ToInt64((Valor_Internet / Valor_Iva) - Valor_Internet);
            Int64 Iva_Final_Internet = Convert.ToInt64(Iva_Internet * Valor_Negativo);
            AP_IN_NETO_IVA.Text = Iva_Final_Internet.ToString();
        }

        //-------------SIGUIENTE SERVICIO--------------//
        Int64 Valor_Telefonia = Convert.ToInt64(AP_VOZ_NETO.Text);
        float Iva_Telefonia = Convert.ToInt64((Valor_Telefonia / Valor_Iva) - Valor_Telefonia);
        Int64 Iva_Final_Telefonia = Convert.ToInt64(Iva_Telefonia * Valor_Negativo);
        AP_VOZ_NETO_IVA.Text = Iva_Final_Telefonia.ToString();

        //-------------SIGUIENTE SERVICIO--------------//
        Int64 Valor_HBO = Convert.ToInt64(AP_HBO_NETO.Text);
        float Iva_HBO = Convert.ToInt64((Valor_HBO / Valor_Iva) - Valor_HBO);
        Int64 Iva_Final_HBO = Convert.ToInt64(Iva_HBO * Valor_Negativo);
        AP_HBO_NETO_IVA.Text = Iva_Final_HBO.ToString();

        //-------------SIGUIENTE SERVICIO--------------//
        Int64 Valor_MPK = Convert.ToInt64(AP_MPK_NETO.Text);
        float Iva_MPK = Convert.ToInt64((Valor_MPK / Valor_Iva) - Valor_MPK);
        Int64 Iva_Final_MPK = Convert.ToInt64(Iva_MPK * Valor_Negativo);
        AP_MPK_NETO_IVA.Text = Iva_Final_MPK.ToString();

        //-------------SIGUIENTE SERVICIO--------------//
        Int64 Valor_Television_HD = Convert.ToInt64(AP_TVHD_NETO.Text);
        float Iva_Television_HD = Convert.ToInt64((Valor_Television_HD / Valor_Iva) - Valor_Television_HD);
        Int64 Iva_Final_Television_HD = Convert.ToInt64(Iva_Television_HD * Valor_Negativo);
        AP_TVHD_NETO_IVA.Text = Iva_Final_Television_HD.ToString();

        //-------------SIGUIENTE SERVICIO--------------//
        Int64 Valor_SP = Convert.ToInt64(AP_SP_NETO.Text);
        float Iva_SP = Convert.ToInt64((Valor_SP / Valor_Iva) - Valor_SP);
        Int64 Iva_Final_SP = Convert.ToInt64(Iva_SP * Valor_Negativo);
        AP_SP_NETO_IVA.Text = Iva_Final_SP.ToString();

        //-------------SIGUIENTE SERVICIO--------------//
        Int64 Valor_VENUS = Convert.ToInt64(AP_VENUS_NETO.Text);
        float Iva_VENUS = Convert.ToInt64((Valor_VENUS / Valor_Iva) - Valor_VENUS);
        Int64 Iva_Final_VENUS = Convert.ToInt64(Iva_VENUS * Valor_Negativo);
        AP_VENUS_NETO_IVA.Text = Iva_Final_VENUS.ToString();

        //-------------SIGUIENTE SERVICIO--------------//
        Int64 Valor_PVR = Convert.ToInt64(AP_PVR_NETO.Text);
        float Iva_PVR = Convert.ToInt64((Valor_PVR / Valor_Iva) - Valor_PVR);
        Int64 Iva_Final_PVR = Convert.ToInt64(Iva_PVR * Valor_Negativo);
        AP_PVR_NETO_IVA.Text = Iva_Final_PVR.ToString();

        //-------------SIGUIENTE SERVICIO--------------//
        if ((Convert.ToString(AP_Estrato_Cliente.Text) == "1") || (Convert.ToString(AP_Estrato_Cliente.Text) == "2") || (Convert.ToString(AP_Estrato_Cliente.Text) == "3"))
        {
            AP_WIFI_NETO_IVA.Text = Convert.ToString(0);
        }
        else
        {
            Int64 Valor_WIFI = Convert.ToInt64(AP_WIFI_NETO.Text);
            float Iva_WIFI = Convert.ToInt64((Valor_WIFI / Valor_Iva) - Valor_WIFI);
            Int64 Iva_Final_WIFI = Convert.ToInt64(Iva_WIFI * Valor_Negativo);
            AP_WIFI_NETO_IVA.Text = Iva_Final_WIFI.ToString();
        }

        //-------------SIGUIENTE SERVICIO--------------//
        Int64 Valor_CLAROVIDEO = Convert.ToInt64(AP_CLAROVIDEO_NETO.Text);
        float Iva_CLAROVIDEO = Convert.ToInt64((Valor_CLAROVIDEO / Valor_Iva) - Valor_CLAROVIDEO);
        Int64 Iva_Final_CLAROVIDEO = Convert.ToInt64(Iva_CLAROVIDEO * Valor_Negativo);
        AP_CLAROVIDEO_NETO_IVA.Text = Iva_Final_CLAROVIDEO.ToString();

        AP_Disputas_Finales_RR();
    }
    protected void AP_Disputas_Finales_RR()
    {
        var Sin_Disputa = "SIN DISPUTAS";
        float Valor_Negativo = -1;

        //-------OTRO SERVICIO---------//
        Int64 Valor_Neto_Tv = Convert.ToInt64(AP_TV_NETO.Text);
        Int64 Valor_Iva_Tv = Convert.ToInt64(AP_TV_NETO_IVA.Text);
        float Disputa_Tv = Valor_Neto_Tv - Valor_Iva_Tv;
        if (Disputa_Tv > 0)
        {

            Disputa_Tv = Disputa_Tv * Valor_Negativo;
            AP_TV_NETO_DP.Text = Disputa_Tv.ToString();
        }
        else
        {
            AP_TV_NETO_DP.Text = Sin_Disputa;
        }

        //-------OTRO SERVICIO---------//
        Int64 Valor_Neto_Internet = Convert.ToInt64(AP_IN_NETO.Text);
        Int64 Valor_Iva_Internet = Convert.ToInt64(AP_IN_NETO_IVA.Text);
        float Disputa_Internet = Valor_Neto_Internet - Valor_Iva_Internet;
        if (Disputa_Internet > 0)
        {

            Disputa_Internet = Disputa_Internet * Valor_Negativo;
            AP_IN_NETO_DP.Text = Disputa_Internet.ToString();
        }
        else
        {
            AP_IN_NETO_DP.Text = Sin_Disputa;
        }

        //-------OTRO SERVICIO---------//
        Int64 Valor_Neto_Voz = Convert.ToInt64(AP_VOZ_NETO.Text);
        Int64 Valor_Iva_Voz = Convert.ToInt64(AP_VOZ_NETO_IVA.Text);
        float Disputa_Voz = Valor_Neto_Voz - Valor_Iva_Voz;
        if (Disputa_Voz > 0)
        {

            Disputa_Voz = Disputa_Voz * Valor_Negativo;
            AP_VOZ_NETO_DP.Text = Disputa_Voz.ToString();
        }
        else
        {
            AP_VOZ_NETO_DP.Text = Sin_Disputa;
        }

        //-------OTRO SERVICIO---------//
        Int64 Valor_Neto_HBO = Convert.ToInt64(AP_HBO_NETO.Text);
        Int64 Valor_Iva_HBO = Convert.ToInt64(AP_HBO_NETO_IVA.Text);
        float Disputa_HBO = Valor_Neto_HBO - Valor_Iva_HBO;
        if (Disputa_HBO > 0)
        {

            Disputa_HBO = Disputa_HBO * Valor_Negativo;
            AP_HBO_NETO_DP.Text = Disputa_HBO.ToString();
        }
        else
        {
            AP_HBO_NETO_DP.Text = Sin_Disputa;
        }

        //-------OTRO SERVICIO---------//
        Int64 Valor_Neto_MPK = Convert.ToInt64(AP_MPK_NETO.Text);
        Int64 Valor_Iva_MPK = Convert.ToInt64(AP_MPK_NETO_IVA.Text);
        float Disputa_MPK = Valor_Neto_MPK - Valor_Iva_MPK;
        if (Disputa_MPK > 0)
        {

            Disputa_MPK = Disputa_MPK * Valor_Negativo;
            AP_MPK_NETO_DP.Text = Disputa_MPK.ToString();
        }
        else
        {
            AP_MPK_NETO_DP.Text = Sin_Disputa;
        }

        //-------OTRO SERVICIO---------//
        Int64 Valor_Neto_SP = Convert.ToInt64(AP_SP_NETO.Text);
        Int64 Valor_Iva_SP = Convert.ToInt64(AP_SP_NETO_IVA.Text);
        float Disputa_SP = Valor_Neto_SP - Valor_Iva_SP;
        if (Disputa_SP > 0)
        {

            Disputa_SP = Disputa_SP * Valor_Negativo;
            AP_SP_NETO_DP.Text = Disputa_SP.ToString();
        }
        else
        {
            AP_SP_NETO_DP.Text = Sin_Disputa;
        }

        //-------OTRO SERVICIO---------//
        Int64 Valor_Neto_VENUS = Convert.ToInt64(AP_VENUS_NETO.Text);
        Int64 Valor_Iva_VENUS = Convert.ToInt64(AP_VENUS_NETO_IVA.Text);
        float Disputa_VENUS = Valor_Neto_VENUS - Valor_Iva_VENUS;
        if (Disputa_VENUS > 0)
        {

            Disputa_VENUS = Disputa_VENUS * Valor_Negativo;
            AP_VENUS_NETO_DP.Text = Disputa_VENUS.ToString();
        }
        else
        {
            AP_VENUS_NETO_DP.Text = Sin_Disputa;
        }

        //-------OTRO SERVICIO---------//
        Int64 Valor_Neto_PVR = Convert.ToInt64(AP_PVR_NETO.Text);
        Int64 Valor_Iva_PVR = Convert.ToInt64(AP_PVR_NETO_IVA.Text);
        float Disputa_PVR = Valor_Neto_PVR - Valor_Iva_PVR;
        if (Disputa_PVR > 0)
        {

            Disputa_PVR = Disputa_PVR * Valor_Negativo;
            AP_PVR_NETO_DP.Text = Disputa_PVR.ToString();
        }
        else
        {
            AP_PVR_NETO_DP.Text = Sin_Disputa;
        }

        //-------OTRO SERVICIO---------//
        Int64 Valor_Neto_WIFI = Convert.ToInt64(AP_WIFI_NETO.Text);
        Int64 Valor_Iva_WIFI = Convert.ToInt64(AP_WIFI_NETO_IVA.Text);
        float Disputa_WIFI = Valor_Neto_WIFI - Valor_Iva_WIFI;
        if (Disputa_WIFI > 0)
        {

            Disputa_WIFI = Disputa_WIFI * Valor_Negativo;
            AP_WIFI_NETO_DP.Text = Disputa_WIFI.ToString();
        }
        else
        {
            AP_WIFI_NETO_DP.Text = Sin_Disputa;
        }

        //-------OTRO SERVICIO---------//
        Int64 Valor_Neto_TVHD = Convert.ToInt64(AP_TVHD_NETO.Text);
        Int64 Valor_Iva_TVHD = Convert.ToInt64(AP_TVHD_NETO_IVA.Text);
        float Disputa_TVHD = Valor_Neto_TVHD - Valor_Iva_TVHD;
        if (Disputa_TVHD > 0)
        {

            Disputa_TVHD = Disputa_TVHD * Valor_Negativo;
            AP_TVHD_NETO_DP.Text = Disputa_TVHD.ToString();
        }
        else
        {
            AP_TVHD_NETO_DP.Text = Sin_Disputa;
        }

        //-------OTRO SERVICIO---------//
        Int64 Valor_Neto_CLAROVIDEO = Convert.ToInt64(AP_CLAROVIDEO_NETO.Text);
        Int64 Valor_Iva_CLAROVIDEO = Convert.ToInt64(AP_CLAROVIDEO_NETO_IVA.Text);
        float Disputa_CLAROVIDEO = Valor_Neto_CLAROVIDEO - Valor_Iva_CLAROVIDEO;
        if (Disputa_CLAROVIDEO > 0)
        {

            Disputa_CLAROVIDEO = Disputa_CLAROVIDEO * Valor_Negativo;
            AP_CLAROVIDEO_NETO_DP.Text = Disputa_CLAROVIDEO.ToString();
        }
        else
        {
            AP_CLAROVIDEO_NETO_DP.Text = Sin_Disputa;
        }


    }
    protected void AP_Estrato_Cliente_TextChanged(object sender, EventArgs e)
    {

        this.AP_Calculo_Fechas_Click(sender, e);
        AP_Generar_Calculos_Valores();
    }
    protected void AP_Limpiar_Click(object sender, EventArgs e)
    {
        AP_Apellido_Cliente.Text = "";
        AP_Nombre_Cliente.Text = "";
        AP_Estrato_Cliente.Text = "";
        AP_Fecha_Inicial.Text = "";
        AP_Fecha_Corte.Text = "";
        AP_Fecha_Final.Text = "";
        AP_Dias_Primer_Periodo.Text = "";
        AP_Dias_Segundo_Periodo.Text = "";
        AP_TV_RR.Text = "0";
        AP_TV_IVA.Text = "0";
        AP_TV_TOTAL.Text = "0";
        AP_TV_1P.Text = "0";
        AP_TV_2P.Text = "0";
        AP_TV_NETO.Text = "0";
        AP_TV_NETO_IVA.Text = "0";
        AP_TV_NETO_DP.Text = "0";
        AP_IN_RR.Text = "0";
        AP_IN_IVA.Text = "0";
        AP_IN_TOTAL.Text = "0";
        AP_IN_1P.Text = "0";
        AP_IN_2P.Text = "0";
        AP_IN_NETO.Text = "0";
        AP_IN_NETO_IVA.Text = "0";
        AP_IN_NETO_DP.Text = "0";
        AP_VOZ_RR.Text = "0";
        AP_VOZ_IVA.Text = "0";
        AP_VOZ_TOTAL.Text = "0";
        AP_VOZ_1P.Text = "0";
        AP_VOZ_2P.Text = "0";
        AP_VOZ_NETO.Text = "0";
        AP_VOZ_NETO_IVA.Text = "0";
        AP_VOZ_NETO_DP.Text = "0";
        AP_FUN_RR.Text = "0";
        AP_FUN_IVA.Text = "0";
        AP_FUN_TOTAL.Text = "0";
        AP_FUN_1P.Text = "0";
        AP_FUN_2P.Text = "0";
        AP_LD_RR.Text = "0";
        AP_LD_IVA.Text = "0";
        AP_LD_TOTAL.Text = "0";
        AP_LD_1P.Text = "0";
        AP_LD_2P.Text = "0";
        AP_TVHD_RR.Text = "0";
        AP_TVHD_IVA.Text = "0";
        AP_TVHD_TOTAL.Text = "0";
        AP_TVHD_1P.Text = "0";
        AP_TVHD_2P.Text = "0";
        AP_TVHD_NETO.Text = "0";
        AP_TVHD_NETO_IVA.Text = "0";
        AP_TVHD_NETO_DP.Text = "0";
        AP_HBO_RR.Text = "0";
        AP_HBO_IVA.Text = "0";
        AP_HBO_TOTAL.Text = "0";
        AP_HBO_1P.Text = "0";
        AP_HBO_2P.Text = "0";
        AP_HBO_NETO.Text = "0";
        AP_HBO_NETO_IVA.Text = "0";
        AP_HBO_NETO_DP.Text = "0";
        AP_RV_RR.Text = "0";
        AP_RV_IVA.Text = "0";
        AP_RV_TOTAL.Text = "0";
        AP_RV_1P.Text = "0";
        AP_RV_2P.Text = "0";
        AP_MPK_RR.Text = "0";
        AP_MPK_IVA.Text = "0";
        AP_MPK_TOTAL.Text = "0";
        AP_MPK_1P.Text = "0";
        AP_MPK_2P.Text = "0";
        AP_MPK_NETO.Text = "0";
        AP_MPK_NETO_IVA.Text = "0";
        AP_MPK_NETO_DP.Text = "0";
        AP_SP_RR.Text = "0";
        AP_SP_IVA.Text = "0";
        AP_SP_TOTAL.Text = "0";
        AP_SP_1P.Text = "0";
        AP_SP_2P.Text = "0";
        AP_SP_NETO.Text = "0";
        AP_SP_NETO_IVA.Text = "0";
        AP_SP_NETO_DP.Text = "0";
        AP_VENUS_RR.Text = "0";
        AP_VENUS_IVA.Text = "0";
        AP_VENUS_TOTAL.Text = "0";
        AP_VENUS_1P.Text = "0";
        AP_VENUS_2P.Text = "0";
        AP_VENUS_NETO.Text = "0";
        AP_VENUS_NETO_IVA.Text = "0";
        AP_VENUS_NETO_DP.Text = "0";
        AP_WIFI_RR.Text = "0";
        AP_WIFI_IVA.Text = "0";
        AP_WIFI_TOTAL.Text = "0";
        AP_WIFI_1P.Text = "0";
        AP_WIFI_2P.Text = "0";
        AP_WIFI_NETO.Text = "0";
        AP_WIFI_NETO_IVA.Text = "0";
        AP_WIFI_NETO_DP.Text = "0";
        AP_PVR_RR.Text = "0";
        AP_PVR_IVA.Text = "0";
        AP_PVR_TOTAL.Text = "0";
        AP_PVR_1P.Text = "0";
        AP_PVR_2P.Text = "0";
        AP_PVR_NETO.Text = "0";
        AP_PVR_NETO_IVA.Text = "0";
        AP_PVR_NETO_DP.Text = "0";
        AP_CLAROVIDEO_RR.Text = "0";
        AP_CLAROVIDEO_IVA.Text = "0";
        AP_CLAROVIDEO_TOTAL.Text = "0";
        AP_CLAROVIDEO_1P.Text = "0";
        AP_CLAROVIDEO_2P.Text = "0";
        AP_CLAROVIDEO_NETO.Text = "0";
        AP_CLAROVIDEO_NETO_IVA.Text = "0";
        AP_CLAROVIDEO_NETO_DP.Text = "0";

        string script = "AP_Limpiar_Controles();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "AP_Limpiar_Controles()", script, true);
    }
    protected void APC_Cargar_Datos_Click(object sender, EventArgs e)
    {
        APC_Estrato_Cliente.Text = Estrato.Text;
        APC_Nombre_Cliente.Text = Nombre_Cliente.Text;
        APC_Apellido_Cliente.Text = Apellido_Cliente.Text;
    }
    protected void APC_Calculo_Fechas_Click(object sender, EventArgs e)
    {
        if ((Convert.ToString(APC_Fecha_Inicial_T.Text) != "") && (Convert.ToString(APC_Fecha_Final_T.Text) != ""))
        {

            DateTime Fecha_Inicial = Convert.ToDateTime(APC_Fecha_Inicial_T.Text);
            DateTime Fecha_Corte = Convert.ToDateTime(APC_Fecha_Final_T.Text);
            TimeSpan Dia_Inicial = Fecha_Corte.Subtract(Fecha_Inicial);
            Int64 Total_Dias_1 = Convert.ToInt64((Dia_Inicial.Days) + 1);

            APC_Cantidad_de_Dias.Text = Total_Dias_1.ToString();
            this.APC_TV_SI_TextChanged(sender, e);
            this.APC_IN_SI_TextChanged(sender, e);
            this.APC_VOZ_SI_TextChanged(sender, e);
            this.APC_FUN_SI_TextChanged(sender, e);
            this.APC_LD_SI_TextChanged(sender, e);
            this.APC_RV_SI_TextChanged(sender, e);
            this.APC_HBO_SI_TextChanged(sender, e);
            this.APC_MPK_SI_TextChanged(sender, e);
            this.APC_TVHD_SI_TextChanged(sender, e);
            this.APC_SP_SI_TextChanged(sender, e);
            this.APC_VENUS_SI_TextChanged(sender, e);
            this.APC_PVR_SI_TextChanged(sender, e);
            this.APC_WIFI_SI_TextChanged(sender, e);
            this.APC_CLAROVIDEO_SI_TextChanged(sender, e);
            APC_Generar_Calculos_Valores();

        }
        else
        { }

    }
    protected void APC_Periodos_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.APC_TV_SI_TextChanged(sender, e);
        this.APC_IN_SI_TextChanged(sender, e);
        this.APC_VOZ_SI_TextChanged(sender, e);
        this.APC_FUN_SI_TextChanged(sender, e);
        this.APC_LD_SI_TextChanged(sender, e);
        this.APC_RV_SI_TextChanged(sender, e);
        this.APC_HBO_SI_TextChanged(sender, e);
        this.APC_MPK_SI_TextChanged(sender, e);
        this.APC_TVHD_SI_TextChanged(sender, e);
        this.APC_SP_SI_TextChanged(sender, e);
        this.APC_VENUS_SI_TextChanged(sender, e);
        this.APC_PVR_SI_TextChanged(sender, e);
        this.APC_WIFI_SI_TextChanged(sender, e);
        this.APC_CLAROVIDEO_SI_TextChanged(sender, e);
        APC_Generar_Calculos_Valores();
    }
    protected void APC_TV_SI_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(APC_TV_SI.Text);
        var Estrato_Cliente = APC_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        APC_TV_CI.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(APC_TV_CI.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        APC_TV_TOTAL.Text = Convert.ToString(ValorMasIva);
        APC_Generar_Calculos_Valores();
    }
    protected void APC_IN_SI_TextChanged(object sender, EventArgs e)
    {
        var Estrato_Cliente = APC_Estrato_Cliente.Text;

        if ((Convert.ToString(Estrato_Cliente) == "1") || (Convert.ToString(Estrato_Cliente) == "2") || (Convert.ToString(Estrato_Cliente) == "3"))
        {
            Int64 Valor_Servicio = Convert.ToInt64(APC_IN_SI.Text);
            APC_IN_CI.Text = Convert.ToString(0);
            APC_IN_TOTAL.Text = Convert.ToString(Valor_Servicio);
            APC_Generar_Calculos_Valores();
        }
        else
        {
            Int64 Valor_Servicio = Convert.ToInt64(APC_IN_SI.Text);
            var Iva = 16;
            var Porcentaje = 100;
            APC_IN_CI.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
            var ValorIva = Convert.ToInt64(APC_IN_CI.Text);
            var ValorMasIva = Valor_Servicio + ValorIva;
            APC_IN_TOTAL.Text = Convert.ToString(ValorMasIva);
            APC_Generar_Calculos_Valores();
        }
    }
    protected void APC_VOZ_SI_TextChanged(object sender, EventArgs e)
    {
        var Estrato_Cliente = APC_Estrato_Cliente.Text;

        if ((Estrato_Cliente == "1") || (Estrato_Cliente == "2"))
        {
            var Iva = 16;
            var Iva2 = Convert.ToDecimal(56.8);
            int Porcentaje = 100;
            Int64 Valor_Inicial = Convert.ToInt64(APC_VOZ_SI.Text);
            Int64 Valor_Iva = Convert.ToInt64(((Valor_Inicial) * Iva2 / Porcentaje) * Iva / Porcentaje);
            APC_VOZ_CI.Text = Convert.ToString(Valor_Iva);
            APC_VOZ_TOTAL.Text = Convert.ToString(Valor_Inicial + Valor_Iva);
            APC_Generar_Calculos_Valores();
        }
        else
        {
            var Iva = 16;
            var Porcentaje = 100;
            Int64 Valor = Convert.ToInt64(APC_VOZ_SI.Text);
            APC_VOZ_CI.Text = Convert.ToString((Valor * Iva) / Porcentaje);
            var ValorIva = Convert.ToInt64(APC_VOZ_CI.Text);
            var ValorMasIva = Valor + ValorIva;
            APC_VOZ_TOTAL.Text = Convert.ToString(ValorMasIva);
            APC_Generar_Calculos_Valores();
        }
    }
    protected void APC_FUN_SI_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(APC_FUN_SI.Text);
        var Estrato_Cliente = APC_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        APC_FUN_CI.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(APC_FUN_CI.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        APC_FUN_TOTAL.Text = Convert.ToString(ValorMasIva);
        APC_Generar_Calculos_Valores();
    }
    protected void APC_LD_SI_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(APC_LD_SI.Text);
        var Estrato_Cliente = APC_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        APC_LD_CI.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(APC_LD_CI.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        APC_LD_TOTAL.Text = Convert.ToString(ValorMasIva);
        APC_Generar_Calculos_Valores();
    }
    protected void APC_RV_SI_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(APC_RV_SI.Text);
        var Estrato_Cliente = APC_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        APC_RV_CI.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(APC_RV_CI.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        APC_RV_TOTAL.Text = Convert.ToString(ValorMasIva);
        APC_Generar_Calculos_Valores();
    }
    protected void APC_HBO_SI_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(APC_HBO_SI.Text);
        var Estrato_Cliente = APC_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        APC_HBO_CI.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(APC_HBO_CI.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        APC_HBO_TOTAL.Text = Convert.ToString(ValorMasIva);
        APC_Generar_Calculos_Valores();
    }
    protected void APC_MPK_SI_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(APC_MPK_SI.Text);
        var Estrato_Cliente = APC_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        APC_MPK_CI.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(APC_MPK_CI.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        APC_MPK_TOTAL.Text = Convert.ToString(ValorMasIva);
        APC_Generar_Calculos_Valores();
    }
    protected void APC_TVHD_SI_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(APC_TVHD_SI.Text);
        var Estrato_Cliente = APC_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        APC_TVHD_CI.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(APC_TVHD_CI.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        APC_TVHD_TOTAL.Text = Convert.ToString(ValorMasIva);
        APC_Generar_Calculos_Valores();
    }
    protected void APC_SP_SI_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(APC_SP_SI.Text);
        var Estrato_Cliente = APC_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        APC_SP_CI.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(APC_SP_CI.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        APC_SP_TOTAL.Text = Convert.ToString(ValorMasIva);
        APC_Generar_Calculos_Valores();
    }
    protected void APC_VENUS_SI_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(APC_VENUS_SI.Text);
        var Estrato_Cliente = APC_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        APC_VENUS_CI.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(APC_VENUS_CI.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        APC_VENUS_TOTAL.Text = Convert.ToString(ValorMasIva);
        APC_Generar_Calculos_Valores();
    }
    protected void APC_PVR_SI_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(APC_PVR_SI.Text);
        var Estrato_Cliente = APC_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        APC_PVR_CI.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(APC_PVR_CI.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        APC_PVR_TOTAL.Text = Convert.ToString(ValorMasIva);
        APC_Generar_Calculos_Valores();
    }
    protected void APC_WIFI_SI_TextChanged(object sender, EventArgs e)
    {
        var Estrato_Cliente = APC_Estrato_Cliente.Text;

        if ((Convert.ToString(Estrato_Cliente) == "1") || (Convert.ToString(Estrato_Cliente) == "2") || (Convert.ToString(Estrato_Cliente) == "3"))
        {
            Int64 Valor_Servicio = Convert.ToInt64(APC_WIFI_SI.Text);
            APC_WIFI_CI.Text = Convert.ToString(0);
            APC_WIFI_TOTAL.Text = Convert.ToString(Valor_Servicio);
            APC_Generar_Calculos_Valores();
        }
        else
        {
            Int64 Valor_Servicio = Convert.ToInt64(APC_WIFI_SI.Text);
            var Iva = 16;
            var Porcentaje = 100;
            APC_WIFI_CI.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
            var ValorIva = Convert.ToInt64(APC_WIFI_CI.Text);
            var ValorMasIva = Valor_Servicio + ValorIva;
            APC_WIFI_TOTAL.Text = Convert.ToString(ValorMasIva);
            APC_Generar_Calculos_Valores();
        }
    }
    protected void APC_CLAROVIDEO_SI_TextChanged(object sender, EventArgs e)
    {
        Int64 Valor_Servicio = Convert.ToInt64(APC_CLAROVIDEO_SI.Text);
        var Estrato_Cliente = APC_Estrato_Cliente.Text;
        var Iva = 16;
        var Porcentaje = 100;
        APC_CLAROVIDEO_CI.Text = Convert.ToString((Valor_Servicio * Iva) / Porcentaje);
        var ValorIva = Convert.ToInt64(APC_CLAROVIDEO_CI.Text);
        var ValorMasIva = Valor_Servicio + ValorIva;
        APC_CLAROVIDEO_TOTAL.Text = Convert.ToString(ValorMasIva);
        APC_Generar_Calculos_Valores();
    }
    protected void APC_Generar_Calculos_Valores()
    {

        if ((APC_Estrato_Cliente.Text != "") && (APC_Prcentaje_Descuento.Text != "") && (APC_Fecha_Inicial_T.Text != "") && (APC_Fecha_Final_T.Text != ""))
        {

            Int64 Valor_Descuento = Convert.ToInt64(APC_Prcentaje_Descuento.Text);
            var Porcentaje = 100;

            //-----SIGUIENTE SERVICIO-----//
            Int64 Valor_Servicio_TV = Convert.ToInt64(APC_TV_TOTAL.Text);
            APC_TV_DIFERENCIA.Text = Convert.ToString((Valor_Servicio_TV * Valor_Descuento) / Porcentaje);

            //-----SIGUIENTE SERVICIO-----//
            Int64 Valor_Servicio_IN = Convert.ToInt64(APC_IN_TOTAL.Text);
            APC_IN_DIFERENCIA.Text = Convert.ToString((Valor_Servicio_IN * Valor_Descuento) / Porcentaje);

            //-----SIGUIENTE SERVICIO-----//
            Int64 Valor_Servicio_VOZ = Convert.ToInt64(APC_VOZ_TOTAL.Text);
            APC_VOZ_DIFERENCIA.Text = Convert.ToString((Valor_Servicio_VOZ * Valor_Descuento) / Porcentaje);

            //-----SIGUIENTE SERVICIO-----//
            Int64 Valor_Servicio_FUN = Convert.ToInt64(APC_FUN_TOTAL.Text);
            APC_FUN_DIFERENCIA.Text = Convert.ToString((Valor_Servicio_FUN * Valor_Descuento) / Porcentaje);

            //-----SIGUIENTE SERVICIO-----//
            Int64 Valor_Servicio_LD = Convert.ToInt64(APC_LD_TOTAL.Text);
            APC_LD_DIFERENCIA.Text = Convert.ToString((Valor_Servicio_LD * Valor_Descuento) / Porcentaje);

            //-----SIGUIENTE SERVICIO-----//
            Int64 Valor_Servicio_RV = Convert.ToInt64(APC_RV_TOTAL.Text);
            APC_RV_DIFERENCIA.Text = Convert.ToString((Valor_Servicio_RV * Valor_Descuento) / Porcentaje);

            //-----SIGUIENTE SERVICIO-----//
            Int64 Valor_Servicio_HBO = Convert.ToInt64(APC_HBO_TOTAL.Text);
            APC_HBO_DIFERENCIA.Text = Convert.ToString((Valor_Servicio_HBO * Valor_Descuento) / Porcentaje);

            //-----SIGUIENTE SERVICIO-----//
            Int64 Valor_Servicio_MPK = Convert.ToInt64(APC_MPK_TOTAL.Text);
            APC_MPK_DIFERENCIA.Text = Convert.ToString((Valor_Servicio_MPK * Valor_Descuento) / Porcentaje);

            //-----SIGUIENTE SERVICIO-----//
            Int64 Valor_Servicio_TVHD = Convert.ToInt64(APC_TVHD_TOTAL.Text);
            APC_TVHD_DIFERENCIA.Text = Convert.ToString((Valor_Servicio_TVHD * Valor_Descuento) / Porcentaje);

            //-----SIGUIENTE SERVICIO-----//
            Int64 Valor_Servicio_SP = Convert.ToInt64(APC_SP_TOTAL.Text);
            APC_SP_DIFERENCIA.Text = Convert.ToString((Valor_Servicio_SP * Valor_Descuento) / Porcentaje);

            //-----SIGUIENTE SERVICIO-----//
            Int64 Valor_Servicio_VENUS = Convert.ToInt64(APC_VENUS_TOTAL.Text);
            APC_VENUS_DIFERENCIA.Text = Convert.ToString((Valor_Servicio_VENUS * Valor_Descuento) / Porcentaje);

            //-----SIGUIENTE SERVICIO-----//
            Int64 Valor_Servicio_PVR = Convert.ToInt64(APC_PVR_TOTAL.Text);
            APC_PVR_DIFERENCIA.Text = Convert.ToString((Valor_Servicio_PVR * Valor_Descuento) / Porcentaje);

            //-----SIGUIENTE SERVICIO-----//
            Int64 Valor_Servicio_WIFI = Convert.ToInt64(APC_WIFI_TOTAL.Text);
            APC_WIFI_DIFERENCIA.Text = Convert.ToString((Valor_Servicio_WIFI * Valor_Descuento) / Porcentaje);

            //-----SIGUIENTE SERVICIO-----//
            Int64 Valor_Servicio_CLAROVIDEO = Convert.ToInt64(APC_CLAROVIDEO_TOTAL.Text);
            APC_CLAROVIDEO_DIFERENCIA.Text = Convert.ToString((Valor_Servicio_CLAROVIDEO * Valor_Descuento) / Porcentaje);

            APC_Generar_Disputas_Finales();
        }
        else { }
    }
    protected void APC_Estrato_Cliente_TextChanged(object sender, EventArgs e)
    {
        this.APC_TV_SI_TextChanged(sender, e);
        this.APC_IN_SI_TextChanged(sender, e);
        this.APC_VOZ_SI_TextChanged(sender, e);
        this.APC_FUN_SI_TextChanged(sender, e);
        this.APC_LD_SI_TextChanged(sender, e);
        this.APC_RV_SI_TextChanged(sender, e);
        this.APC_HBO_SI_TextChanged(sender, e);
        this.APC_MPK_SI_TextChanged(sender, e);
        this.APC_TVHD_SI_TextChanged(sender, e);
        this.APC_SP_SI_TextChanged(sender, e);
        this.APC_VENUS_SI_TextChanged(sender, e);
        this.APC_PVR_SI_TextChanged(sender, e);
        this.APC_WIFI_SI_TextChanged(sender, e);
        this.APC_CLAROVIDEO_SI_TextChanged(sender, e);
        this.APC_Prcentaje_Descuento_TextChanged(sender, e);


    }
    protected void APC_Prcentaje_Descuento_TextChanged(object sender, EventArgs e)
    {


        String TxtBx = APC_Prcentaje_Descuento.Text;
        if (APC_Prcentaje_Descuento.Text.Length > 0)
        {
            foreach (char car in TxtBx)
            {
                if (car < '0' || car > '9')
                {
                    this.APC_TV_SI_TextChanged(sender, e);
                    this.APC_IN_SI_TextChanged(sender, e);
                    this.APC_VOZ_SI_TextChanged(sender, e);
                    this.APC_FUN_SI_TextChanged(sender, e);
                    this.APC_LD_SI_TextChanged(sender, e);
                    this.APC_RV_SI_TextChanged(sender, e);
                    this.APC_HBO_SI_TextChanged(sender, e);
                    this.APC_MPK_SI_TextChanged(sender, e);
                    this.APC_TVHD_SI_TextChanged(sender, e);
                    this.APC_SP_SI_TextChanged(sender, e);
                    this.APC_VENUS_SI_TextChanged(sender, e);
                    this.APC_PVR_SI_TextChanged(sender, e);
                    this.APC_WIFI_SI_TextChanged(sender, e);
                    this.APC_CLAROVIDEO_SI_TextChanged(sender, e);
                    APC_Generar_Calculos_Valores();

                }
                else { }
            }
        }
        else { }


    }
    protected void APC_Generar_Disputas_Finales()
    {

        if ((Convert.ToString(APC_Fecha_Inicial_T.Text) != "") && (Convert.ToString(APC_Fecha_Final_T.Text) != ""))
        {

            int Numero_Mes = Convert.ToDateTime(APC_Fecha_Inicial_T.Text).Month;
            int Cantidad_Dias = 0;
            int Numero_ano = Convert.ToDateTime(APC_Fecha_Inicial_T.Text).Year;
            int Dias_Febrero = 0;

            if ((Numero_ano == 2016) || (Numero_ano == 2020) || (Numero_ano == 2024) || (Numero_ano == 2028) || (Numero_ano == 2032) || (Numero_ano == 2036) || (Numero_ano == 2040) || (Numero_ano == 2044)) { Dias_Febrero = 29; }
            else { Dias_Febrero = 28; }

            if ((Numero_Mes == 1) || (Numero_Mes == 3) || (Numero_Mes == 5) || (Numero_Mes == 7) || (Numero_Mes == 8) || (Numero_Mes == 10) || (Numero_Mes == 12)) { Cantidad_Dias = 31; }
            else if ((Numero_Mes == 2)) { Cantidad_Dias = Dias_Febrero; }
            else if ((Numero_Mes == 4) || (Numero_Mes == 6) || (Numero_Mes == 9) || (Numero_Mes == 11)) { Cantidad_Dias = 30; };

            //----VARIABLES GLOBALES----//
            int Dias_A_Ajustar = Convert.ToInt16(APC_Cantidad_de_Dias.Text);
            int Cantidad_de_Periodos = Convert.ToInt16(APC_Periodos.Text);
            var Estrato_Cliente = APC_Estrato_Cliente.Text;

            ///------CALCULO PARA VALORES NETOS-----///
            ///
            float Valor_VOZ = Convert.ToInt64(APC_VOZ_DIFERENCIA.Text);
            float Valor_Periodo_VOZ = Valor_VOZ * Cantidad_de_Periodos;
            Int64 Valor_Dias_VOZ = Convert.ToInt64((Valor_VOZ * Dias_A_Ajustar) / Cantidad_Dias);
            Int64 Valor_A_Disputar_VOZ = Convert.ToInt64(Valor_Periodo_VOZ + Valor_Dias_VOZ);
            APC_VOZ_NETO.Text = Valor_A_Disputar_VOZ.ToString();

            //---SIGUIENTE SERVICIO---//
            float Valor_FUN = Convert.ToInt64(APC_FUN_DIFERENCIA.Text);
            float Valor_Periodo_FUN = Valor_FUN * Cantidad_de_Periodos;
            Int64 Valor_Dias_FUN = Convert.ToInt64((Valor_FUN * Dias_A_Ajustar) / Cantidad_Dias);
            Int64 Valor_A_Disputar_FUN = Convert.ToInt64(Valor_Periodo_FUN + Valor_Dias_FUN);
            APC_FUN_NETO.Text = Valor_A_Disputar_FUN.ToString();

            //---SIGUIENTE SERVICIO---//
            float Valor_LD = Convert.ToInt64(APC_LD_DIFERENCIA.Text);
            float Valor_Periodo_LD = Valor_LD * Cantidad_de_Periodos;
            Int64 Valor_Dias_LD = Convert.ToInt64((Valor_LD * Dias_A_Ajustar) / Cantidad_Dias);
            Int64 Valor_A_Disputar_LD = Convert.ToInt64(Valor_Periodo_LD + Valor_Dias_LD);
            APC_LD_NETO.Text = Valor_A_Disputar_LD.ToString();

            //---SIGUIENTE SERVICIO---//
            float Valor_IN = Convert.ToInt64(APC_IN_DIFERENCIA.Text);
            float Valor_Periodo_IN = Valor_IN * Cantidad_de_Periodos;
            Int64 Valor_Dias_IN = Convert.ToInt64((Valor_IN * Dias_A_Ajustar) / Cantidad_Dias);
            Int64 Valor_A_Disputar_IN = Convert.ToInt64(Valor_Periodo_IN + Valor_Dias_IN);
            APC_IN_NETO.Text = Valor_A_Disputar_IN.ToString();

            //---SIGUIENTE SERVICIO---//
            float Valor_TV = Convert.ToInt64(APC_TV_DIFERENCIA.Text);
            float Valor_Periodo_TV = Valor_TV * Cantidad_de_Periodos;
            Int64 Valor_Dias_TV = Convert.ToInt64((Valor_TV * Dias_A_Ajustar) / Cantidad_Dias);
            Int64 Valor_A_Disputar_TV = Convert.ToInt64(Valor_Periodo_TV + Valor_Dias_TV);
            APC_TV_NETO.Text = Valor_A_Disputar_TV.ToString();

            //---SIGUIENTE SERVICIO---//
            float Valor_HBO = Convert.ToInt64(APC_HBO_DIFERENCIA.Text);
            float Valor_Periodo_HBO = Valor_HBO * Cantidad_de_Periodos;
            Int64 Valor_Dias_HBO = Convert.ToInt64((Valor_HBO * Dias_A_Ajustar) / Cantidad_Dias);
            Int64 Valor_A_Disputar_HBO = Convert.ToInt64(Valor_Periodo_HBO + Valor_Dias_HBO);
            APC_HBO_NETO.Text = Valor_A_Disputar_HBO.ToString();

            //---SIGUIENTE SERVICIO---//
            float Valor_MPK = Convert.ToInt64(APC_MPK_DIFERENCIA.Text);
            float Valor_Periodo_MPK = Valor_MPK * Cantidad_de_Periodos;
            Int64 Valor_Dias_MPK = Convert.ToInt64((Valor_MPK * Dias_A_Ajustar) / Cantidad_Dias);
            Int64 Valor_A_Disputar_MPK = Convert.ToInt64(Valor_Periodo_MPK + Valor_Dias_MPK);
            APC_MPK_NETO.Text = Valor_A_Disputar_MPK.ToString();

            //---SIGUIENTE SERVICIO---//
            float Valor_TVHD = Convert.ToInt64(APC_TVHD_DIFERENCIA.Text);
            float Valor_Periodo_TVHD = Valor_TVHD * Cantidad_de_Periodos;
            Int64 Valor_Dias_TVHD = Convert.ToInt64((Valor_TVHD * Dias_A_Ajustar) / Cantidad_Dias);
            Int64 Valor_A_Disputar_TVHD = Convert.ToInt64(Valor_Periodo_TVHD + Valor_Dias_TVHD);
            APC_TVHD_NETO.Text = Valor_A_Disputar_TVHD.ToString();

            //---SIGUIENTE SERVICIO---//
            float Valor_SP = Convert.ToInt64(APC_SP_DIFERENCIA.Text);
            float Valor_Periodo_SP = Valor_SP * Cantidad_de_Periodos;
            Int64 Valor_Dias_SP = Convert.ToInt64((Valor_SP * Dias_A_Ajustar) / Cantidad_Dias);
            Int64 Valor_A_Disputar_SP = Convert.ToInt64(Valor_Periodo_SP + Valor_Dias_SP);
            APC_SP_NETO.Text = Valor_A_Disputar_SP.ToString();

            //---SIGUIENTE SERVICIO---//
            float Valor_VENUS = Convert.ToInt64(APC_VENUS_DIFERENCIA.Text);
            float Valor_Periodo_VENUS = Valor_VENUS * Cantidad_de_Periodos;
            Int64 Valor_Dias_VENUS = Convert.ToInt64((Valor_VENUS * Dias_A_Ajustar) / Cantidad_Dias);
            Int64 Valor_A_Disputar_VENUS = Convert.ToInt64(Valor_Periodo_VENUS + Valor_Dias_VENUS);
            APC_VENUS_NETO.Text = Valor_A_Disputar_VENUS.ToString();

            //---SIGUIENTE SERVICIO---//
            float Valor_PVR = Convert.ToInt64(APC_PVR_DIFERENCIA.Text);
            float Valor_Periodo_PVR = Valor_PVR * Cantidad_de_Periodos;
            Int64 Valor_Dias_PVR = Convert.ToInt64((Valor_PVR * Dias_A_Ajustar) / Cantidad_Dias);
            Int64 Valor_A_Disputar_PVR = Convert.ToInt64(Valor_Periodo_PVR + Valor_Dias_PVR);
            APC_PVR_NETO.Text = Valor_A_Disputar_PVR.ToString();

            //---SIGUIENTE SERVICIO---//
            float Valor_WIFI = Convert.ToInt64(APC_WIFI_DIFERENCIA.Text);
            float Valor_Periodo_WIFI = Valor_WIFI * Cantidad_de_Periodos;
            Int64 Valor_Dias_WIFI = Convert.ToInt64((Valor_WIFI * Dias_A_Ajustar) / Cantidad_Dias);
            Int64 Valor_A_Disputar_WIFI = Convert.ToInt64(Valor_Periodo_WIFI + Valor_Dias_WIFI);
            APC_WIFI_NETO.Text = Valor_A_Disputar_WIFI.ToString();

            //---SIGUIENTE SERVICIO---//
            float Valor_CLAROVIDEO = Convert.ToInt64(APC_CLAROVIDEO_DIFERENCIA.Text);
            float Valor_Periodo_CLAROVIDEO = Valor_CLAROVIDEO * Cantidad_de_Periodos;
            Int64 Valor_Dias_CLAROVIDEO = Convert.ToInt64((Valor_CLAROVIDEO * Dias_A_Ajustar) / Cantidad_Dias);
            Int64 Valor_A_Disputar_CLAROVIDEO = Convert.ToInt64(Valor_Periodo_CLAROVIDEO + Valor_Dias_CLAROVIDEO);
            APC_CLAROVIDEO_NETO.Text = Valor_A_Disputar_CLAROVIDEO.ToString();

            //----CALCULOS DE IVA PARA CADA SERVICIO----//

            decimal Valor_Iva = 1.16m;
            float Valor_Negativo = -1;

            //-------------SIGUIENTE SERVICIO--------------//
            Int64 Valor_NETO_VOZ = Convert.ToInt64(APC_VOZ_NETO.Text);
            float Iva_VOZ = Convert.ToInt64((Valor_NETO_VOZ / Valor_Iva) - Valor_NETO_VOZ);
            Int64 Iva_Final_VOZ = Convert.ToInt64(Iva_VOZ * Valor_Negativo);
            APC_VOZ_NETO_IVA.Text = Iva_Final_VOZ.ToString();

            //-------------SIGUIENTE SERVICIO--------------//
            Int64 Valor_NETO_FUN = Convert.ToInt64(APC_FUN_NETO.Text);
            float Iva_FUN = Convert.ToInt64((Valor_NETO_FUN / Valor_Iva) - Valor_NETO_FUN);
            Int64 Iva_Final_FUN = Convert.ToInt64(Iva_FUN * Valor_Negativo);
            APC_FUN_NETO_IVA.Text = Iva_Final_FUN.ToString();

            //-------------SIGUIENTE SERVICIO--------------//
            Int64 Valor_NETO_LD = Convert.ToInt64(APC_LD_NETO.Text);
            float Iva_LD = Convert.ToInt64((Valor_NETO_LD / Valor_Iva) - Valor_NETO_LD);
            Int64 Iva_Final_LD = Convert.ToInt64(Iva_LD * Valor_Negativo);
            APC_LD_NETO_IVA.Text = Iva_Final_LD.ToString();

            //-------------SIGUIENTE SERVICIO--------------//
            if ((Convert.ToString(APC_Estrato_Cliente.Text) == "1") || (Convert.ToString(APC_Estrato_Cliente.Text) == "2") || (Convert.ToString(APC_Estrato_Cliente.Text) == "3"))
            {
                APC_IN_NETO_IVA.Text = Convert.ToString(0);
            }
            else
            {
                Int64 Valor_NETO_IN = Convert.ToInt64(APC_IN_NETO.Text);
                float Iva_IN = Convert.ToInt64((Valor_NETO_IN / Valor_Iva) - Valor_NETO_IN);
                Int64 Iva_Final_IN = Convert.ToInt64(Iva_IN * Valor_Negativo);
                APC_IN_NETO_IVA.Text = Iva_Final_IN.ToString();
            }

            //-------------SIGUIENTE SERVICIO--------------//
            Int64 Valor_NETO_TV = Convert.ToInt64(APC_TV_NETO.Text);
            float Iva_TV = Convert.ToInt64((Valor_NETO_TV / Valor_Iva) - Valor_NETO_TV);
            Int64 Iva_Final_TV = Convert.ToInt64(Iva_TV * Valor_Negativo);
            APC_TV_NETO_IVA.Text = Iva_Final_TV.ToString();

            //-------------SIGUIENTE SERVICIO--------------//
            Int64 Valor_NETO_HBO = Convert.ToInt64(APC_HBO_NETO.Text);
            float Iva_HBO = Convert.ToInt64((Valor_NETO_HBO / Valor_Iva) - Valor_NETO_HBO);
            Int64 Iva_Final_HBO = Convert.ToInt64(Iva_HBO * Valor_Negativo);
            APC_HBO_NETO_IVA.Text = Iva_Final_HBO.ToString();

            //-------------SIGUIENTE SERVICIO--------------//
            Int64 Valor_NETO_MPK = Convert.ToInt64(APC_MPK_NETO.Text);
            float Iva_MPK = Convert.ToInt64((Valor_NETO_MPK / Valor_Iva) - Valor_NETO_MPK);
            Int64 Iva_Final_MPK = Convert.ToInt64(Iva_MPK * Valor_Negativo);
            APC_MPK_NETO_IVA.Text = Iva_Final_MPK.ToString();

            //-------------SIGUIENTE SERVICIO--------------//
            Int64 Valor_NETO_TVHD = Convert.ToInt64(APC_TVHD_NETO.Text);
            float Iva_TVHD = Convert.ToInt64((Valor_NETO_TVHD / Valor_Iva) - Valor_NETO_TVHD);
            Int64 Iva_Final_TVHD = Convert.ToInt64(Iva_TVHD * Valor_Negativo);
            APC_TVHD_NETO_IVA.Text = Iva_Final_TVHD.ToString();

            //-------------SIGUIENTE SERVICIO--------------//
            Int64 Valor_NETO_SP = Convert.ToInt64(APC_SP_NETO.Text);
            float Iva_SP = Convert.ToInt64((Valor_NETO_SP / Valor_Iva) - Valor_NETO_SP);
            Int64 Iva_Final_SP = Convert.ToInt64(Iva_SP * Valor_Negativo);
            APC_SP_NETO_IVA.Text = Iva_Final_SP.ToString();

            //-------------SIGUIENTE SERVICIO--------------//
            Int64 Valor_NETO_VENUS = Convert.ToInt64(APC_VENUS_NETO.Text);
            float Iva_VENUS = Convert.ToInt64((Valor_NETO_VENUS / Valor_Iva) - Valor_NETO_VENUS);
            Int64 Iva_Final_VENUS = Convert.ToInt64(Iva_VENUS * Valor_Negativo);
            APC_VENUS_NETO_IVA.Text = Iva_Final_VENUS.ToString();

            //-------------SIGUIENTE SERVICIO--------------//
            Int64 Valor_NETO_PVR = Convert.ToInt64(APC_PVR_NETO.Text);
            float Iva_PVR = Convert.ToInt64((Valor_NETO_PVR / Valor_Iva) - Valor_NETO_PVR);
            Int64 Iva_Final_PVR = Convert.ToInt64(Iva_PVR * Valor_Negativo);
            APC_PVR_NETO_IVA.Text = Iva_Final_PVR.ToString();

            //-------------SIGUIENTE SERVICIO--------------//
            if ((Convert.ToString(APC_Estrato_Cliente.Text) == "1") || (Convert.ToString(APC_Estrato_Cliente.Text) == "2") || (Convert.ToString(APC_Estrato_Cliente.Text) == "3"))
            {
                APC_WIFI_NETO_IVA.Text = Convert.ToString(0);
            }
            else
            {
                Int64 Valor_NETO_WIFI = Convert.ToInt64(APC_WIFI_NETO.Text);
                float Iva_WIFI = Convert.ToInt64((Valor_NETO_WIFI / Valor_Iva) - Valor_NETO_WIFI);
                Int64 Iva_Final_WIFI = Convert.ToInt64(Iva_WIFI * Valor_Negativo);
                APC_WIFI_NETO_IVA.Text = Iva_Final_WIFI.ToString();
            }

            //-------------SIGUIENTE SERVICIO--------------//
            Int64 Valor_NETO_CLAROVIDEO = Convert.ToInt64(APC_CLAROVIDEO_NETO.Text);
            float Iva_CLAROVIDEO = Convert.ToInt64((Valor_NETO_CLAROVIDEO / Valor_Iva) - Valor_NETO_CLAROVIDEO);
            Int64 Iva_Final_CLAROVIDEO = Convert.ToInt64(Iva_CLAROVIDEO * Valor_Negativo);
            APC_CLAROVIDEO_NETO_IVA.Text = Iva_Final_CLAROVIDEO.ToString();

            //----CALCULOS PARA DISPUTAS FINALES POR SERVICIO----//

            var Sin_Disputa = "SIN DISPUTAS";

            //-------OTRO SERVICIO---------//
            Int64 Valor_Neto_VOZ = Convert.ToInt64(APC_VOZ_NETO.Text);
            Int64 Valor_Iva_VOZ = Convert.ToInt64(APC_VOZ_NETO_IVA.Text);
            float Disputa_VOZ = Valor_Neto_VOZ - Valor_Iva_VOZ;
            if (Disputa_VOZ > 0)
            {

                //Disputa_VOZ = Disputa_VOZ * Valor_Negativo;
                APC_VOZ_NETO_DISPUTA.Text = Disputa_VOZ.ToString();
            }
            else
            {
                APC_VOZ_NETO_DISPUTA.Text = Sin_Disputa;
            }

            //-------OTRO SERVICIO---------//
            Int64 Valor_Neto_FUN = Convert.ToInt64(APC_FUN_NETO.Text);
            Int64 Valor_Iva_FUN = Convert.ToInt64(APC_FUN_NETO_IVA.Text);
            float Disputa_FUN = Valor_Neto_FUN - Valor_Iva_FUN;
            if (Disputa_FUN > 0)
            {

                //Disputa_FUN = Disputa_FUN * Valor_Negativo;
                APC_FUN_NETO_DISPUTA.Text = Disputa_FUN.ToString();
            }
            else
            {
                APC_FUN_NETO_DISPUTA.Text = Sin_Disputa;
            }

            //-------OTRO SERVICIO---------//
            Int64 Valor_Neto_LD = Convert.ToInt64(APC_LD_NETO.Text);
            Int64 Valor_Iva_LD = Convert.ToInt64(APC_LD_NETO_IVA.Text);
            float Disputa_LD = Valor_Neto_LD - Valor_Iva_LD;
            if (Disputa_LD > 0)
            {

                //Disputa_LD = Disputa_LD * Valor_Negativo;
                APC_LD_NETO_DISPUTA.Text = Disputa_LD.ToString();
            }
            else
            {
                APC_LD_NETO_DISPUTA.Text = Sin_Disputa;
            }

            //-------OTRO SERVICIO---------//
            Int64 Valor_Neto_IN = Convert.ToInt64(APC_IN_NETO.Text);
            Int64 Valor_Iva_IN = Convert.ToInt64(APC_IN_NETO_IVA.Text);
            float Disputa_IN = Valor_Neto_IN - Valor_Iva_IN;
            if (Disputa_IN > 0)
            {

                //Disputa_IN = Disputa_IN * Valor_Negativo;
                APC_IN_NETO_DISPUTA.Text = Disputa_IN.ToString();
            }
            else
            {
                APC_IN_NETO_DISPUTA.Text = Sin_Disputa;
            }

            //-------OTRO SERVICIO---------//
            Int64 Valor_Neto_TV = Convert.ToInt64(APC_TV_NETO.Text);
            Int64 Valor_Iva_TV = Convert.ToInt64(APC_TV_NETO_IVA.Text);
            float Disputa_TV = Valor_Neto_TV - Valor_Iva_TV;
            if (Disputa_TV > 0)
            {

                //Disputa_TV = Disputa_TV * Valor_Negativo;
                APC_TV_NETO_DISPUTA.Text = Disputa_TV.ToString();
            }
            else
            {
                APC_TV_NETO_DISPUTA.Text = Sin_Disputa;
            }

            //-------OTRO SERVICIO---------//
            Int64 Valor_Neto_HBO = Convert.ToInt64(APC_HBO_NETO.Text);
            Int64 Valor_Iva_HBO = Convert.ToInt64(APC_HBO_NETO_IVA.Text);
            float Disputa_HBO = Valor_Neto_HBO - Valor_Iva_HBO;
            if (Disputa_HBO > 0)
            {

                //Disputa_HBO = Disputa_HBO * Valor_Negativo;
                APC_HBO_NETO_DISPUTA.Text = Disputa_HBO.ToString();
            }
            else
            {
                APC_HBO_NETO_DISPUTA.Text = Sin_Disputa;
            }

            //-------OTRO SERVICIO---------//
            Int64 Valor_Neto_MPK = Convert.ToInt64(APC_MPK_NETO.Text);
            Int64 Valor_Iva_MPK = Convert.ToInt64(APC_MPK_NETO_IVA.Text);
            float Disputa_MPK = Valor_Neto_MPK - Valor_Iva_MPK;
            if (Disputa_MPK > 0)
            {

                //Disputa_MPK = Disputa_MPK * Valor_Negativo;
                APC_MPK_NETO_DISPUTA.Text = Disputa_MPK.ToString();
            }
            else
            {
                APC_MPK_NETO_DISPUTA.Text = Sin_Disputa;
            }

            //-------OTRO SERVICIO---------//
            Int64 Valor_Neto_TVHD = Convert.ToInt64(APC_TVHD_NETO.Text);
            Int64 Valor_Iva_TVHD = Convert.ToInt64(APC_TVHD_NETO_IVA.Text);
            float Disputa_TVHD = Valor_Neto_TVHD - Valor_Iva_TVHD;
            if (Disputa_TVHD > 0)
            {

                //Disputa_TVHD = Disputa_TVHD * Valor_Negativo;
                APC_TVHD_NETO_DISPUTA.Text = Disputa_TVHD.ToString();
            }
            else
            {
                APC_TVHD_NETO_DISPUTA.Text = Sin_Disputa;
            }

            //-------OTRO SERVICIO---------//
            Int64 Valor_Neto_SP = Convert.ToInt64(APC_SP_NETO.Text);
            Int64 Valor_Iva_SP = Convert.ToInt64(APC_SP_NETO_IVA.Text);
            float Disputa_SP = Valor_Neto_SP - Valor_Iva_SP;
            if (Disputa_SP > 0)
            {

                //Disputa_SP = Disputa_SP * Valor_Negativo;
                APC_SP_NETO_DISPUTA.Text = Disputa_SP.ToString();
            }
            else
            {
                APC_SP_NETO_DISPUTA.Text = Sin_Disputa;
            }

            //-------OTRO SERVICIO---------//
            Int64 Valor_Neto_VENUS = Convert.ToInt64(APC_VENUS_NETO.Text);
            Int64 Valor_Iva_VENUS = Convert.ToInt64(APC_VENUS_NETO_IVA.Text);
            float Disputa_VENUS = Valor_Neto_VENUS - Valor_Iva_VENUS;
            if (Disputa_VENUS > 0)
            {

                //Disputa_VENUS = Disputa_VENUS * Valor_Negativo;
                APC_VENUS_NETO_DISPUTA.Text = Disputa_VENUS.ToString();
            }
            else
            {
                APC_VENUS_NETO_DISPUTA.Text = Sin_Disputa;
            }

            //-------OTRO SERVICIO---------//
            Int64 Valor_Neto_PVR = Convert.ToInt64(APC_PVR_NETO.Text);
            Int64 Valor_Iva_PVR = Convert.ToInt64(APC_PVR_NETO_IVA.Text);
            float Disputa_PVR = Valor_Neto_PVR - Valor_Iva_PVR;
            if (Disputa_PVR > 0)
            {

                //Disputa_PVR = Disputa_PVR * Valor_Negativo;
                APC_PVR_NETO_DISPUTA.Text = Disputa_PVR.ToString();
            }
            else
            {
                APC_PVR_NETO_DISPUTA.Text = Sin_Disputa;
            }

            //-------OTRO SERVICIO---------//
            Int64 Valor_Neto_WIFI = Convert.ToInt64(APC_WIFI_NETO.Text);
            Int64 Valor_Iva_WIFI = Convert.ToInt64(APC_WIFI_NETO_IVA.Text);
            float Disputa_WIFI = Valor_Neto_WIFI - Valor_Iva_WIFI;
            if (Disputa_WIFI > 0)
            {

                //Disputa_WIFI = Disputa_WIFI * Valor_Negativo;
                APC_WIFI_NETO_DISPUTA.Text = Disputa_WIFI.ToString();
            }
            else
            {
                APC_WIFI_NETO_DISPUTA.Text = Sin_Disputa;
            }

            //-------OTRO SERVICIO---------//
            Int64 Valor_Neto_CLAROVIDEO = Convert.ToInt64(APC_CLAROVIDEO_NETO.Text);
            Int64 Valor_Iva_CLAROVIDEO = Convert.ToInt64(APC_CLAROVIDEO_NETO_IVA.Text);
            float Disputa_CLAROVIDEO = Valor_Neto_CLAROVIDEO - Valor_Iva_CLAROVIDEO;
            if (Disputa_CLAROVIDEO > 0)
            {

                //Disputa_PVR = Disputa_PVR * Valor_Negativo;
                APC_CLAROVIDEO_NETO_DISPUTA.Text = Disputa_CLAROVIDEO.ToString();
            }
            else
            {
                APC_CLAROVIDEO_NETO_DISPUTA.Text = Sin_Disputa;
            }


            ////---------PROCESO PARA LA GENERACION DE LA NOTA PARA EL AJUSTE------------//////
            var Servicios = "";
            if (APC_VOZ_NETO_DISPUTA.Text != "SIN DISPUTAS") { Servicios = "TELEFONIA ,"; } else { }
            if (APC_FUN_NETO_DISPUTA.Text != "SIN DISPUTAS") { Servicios = Servicios + "FUNCIONALIDADES, "; } else { }
            if (APC_LD_NETO_DISPUTA.Text != "SIN DISPUTAS") { Servicios = Servicios + "LD30, "; } else { }
            if (APC_IN_NETO_DISPUTA.Text != "SIN DISPUTAS") { Servicios = Servicios + "INTERNET, "; } else { }
            if (APC_TV_NETO_DISPUTA.Text != "SIN DISPUTAS") { Servicios = Servicios + "TELEVISION, "; } else { }
            if (APC_HBO_NETO_DISPUTA.Text != "SIN DISPUTAS") { Servicios = Servicios + "HBO, "; } else { }
            if (APC_MPK_NETO_DISPUTA.Text != "SIN DISPUTAS") { Servicios = Servicios + "MOVIE PACK, "; } else { }
            if (APC_TVHD_NETO_DISPUTA.Text != "SIN DISPUTAS") { Servicios = Servicios + "TELEVISION HD, "; } else { }
            if (APC_SP_NETO_DISPUTA.Text != "SIN DISPUTAS") { Servicios = Servicios + "SPICE TV, "; } else { }
            if (APC_VENUS_NETO_DISPUTA.Text != "SIN DISPUTAS") { Servicios = Servicios + "VENUS, "; } else { }
            if (APC_PVR_NETO_DISPUTA.Text != "SIN DISPUTAS") { Servicios = Servicios + "PVR - DECOS, "; } else { }
            if (APC_WIFI_NETO_DISPUTA.Text != "SIN DISPUTAS") { Servicios = Servicios + "WIFI, "; } else { }
            if (APC_CLAROVIDEO_NETO_DISPUTA.Text != "SIN DISPUTAS") { Servicios = Servicios + "CLARO VIDEO, "; } else { }


            if (APC_Periodos.Text != "0")
            {

                var Nota_Ajuste = "SE SOLICITA AJUSTE SEGUN OFRECIMIENTO REALIZADO AL CLIENTE CON CAMPAÑA DEL " + APC_Prcentaje_Descuento.Text + "% DE DESCUENTO SOBRE LOS SERVICIOS DE " + Servicios + "POR EL AREA DE " + APC_Area_Ofrecimiento.Text + " EL DIA " + APC_Fecha_Ofrecimiento.Text + ", SE DEBE REALIZAR CORRECCION DESDE EL " + APC_Fecha_Inicial_T.Text + " HASTA EL " + APC_Fecha_Final_T.Text + " Y POR " + APC_Periodos.Text + " MESES YA CAUSADOS";
                APC_NOTAS_RR.Text = Nota_Ajuste;
            }
            else
            {
                var Nota_Ajuste = "SE SOLICITA AJUSTE SEGUN OFRECIMIENTO REALIZADO AL CLIENTE CON CAMPAÑA DEL " + APC_Prcentaje_Descuento.Text + "% DE DESCUENTO SOBRE LOS SERVICIOS DE " + Servicios + "POR EL AREA DE " + APC_Area_Ofrecimiento.Text + " EL DIA " + APC_Fecha_Ofrecimiento.Text + ", SE DEBE REALIZAR CORRECCION DESDE EL " + APC_Fecha_Inicial_T.Text + " HASTA EL " + APC_Fecha_Final_T.Text;
                APC_NOTAS_RR.Text = Nota_Ajuste;
            }



        }
        else
        { }
    }
    protected void APC_Limpiar_Controles()
    {
        APC_Apellido_Cliente.Text = "";
        APC_Nombre_Cliente.Text = "";
        APC_Estrato_Cliente.Text = "";
        APC_Fecha_Inicial_T.Text = "";
        APC_Fecha_Final_T.Text = "";
        APC_Cantidad_de_Dias.Text = "";
        APC_TV_SI.Text = "0";
        APC_TV_CI.Text = "0";
        APC_TV_TOTAL.Text = "0";
        APC_TV_DIFERENCIA.Text = "0";
        APC_TV_NETO.Text = "0";
        APC_TV_NETO_IVA.Text = "0";
        APC_TV_NETO_DISPUTA.Text = "0";
        APC_VOZ_SI.Text = "0";
        APC_VOZ_CI.Text = "0";
        APC_VOZ_TOTAL.Text = "0";
        APC_VOZ_DIFERENCIA.Text = "0";
        APC_VOZ_NETO.Text = "0";
        APC_VOZ_NETO_IVA.Text = "0";
        APC_VOZ_NETO_DISPUTA.Text = "0";
        APC_IN_SI.Text = "0";
        APC_IN_CI.Text = "0";
        APC_IN_TOTAL.Text = "0";
        APC_IN_DIFERENCIA.Text = "0";
        APC_IN_NETO.Text = "0";
        APC_IN_NETO_IVA.Text = "0";
        APC_IN_NETO_DISPUTA.Text = "0";
        APC_FUN_SI.Text = "0";
        APC_FUN_CI.Text = "0";
        APC_FUN_TOTAL.Text = "0";
        APC_FUN_DIFERENCIA.Text = "0";
        APC_FUN_NETO.Text = "0";
        APC_FUN_NETO_IVA.Text = "0";
        APC_FUN_NETO_DISPUTA.Text = "0";
        APC_LD_SI.Text = "0";
        APC_LD_CI.Text = "0";
        APC_LD_TOTAL.Text = "0";
        APC_LD_DIFERENCIA.Text = "0";
        APC_LD_NETO.Text = "0";
        APC_LD_NETO_IVA.Text = "0";
        APC_LD_NETO_DISPUTA.Text = "0";
        APC_HBO_SI.Text = "0";
        APC_HBO_CI.Text = "0";
        APC_HBO_TOTAL.Text = "0";
        APC_HBO_DIFERENCIA.Text = "0";
        APC_HBO_NETO.Text = "0";
        APC_HBO_NETO_IVA.Text = "0";
        APC_HBO_NETO_DISPUTA.Text = "0";
        APC_TVHD_SI.Text = "0";
        APC_TVHD_CI.Text = "0";
        APC_TVHD_TOTAL.Text = "0";
        APC_TVHD_DIFERENCIA.Text = "0";
        APC_TVHD_NETO.Text = "0";
        APC_TVHD_NETO_IVA.Text = "0";
        APC_TVHD_NETO_DISPUTA.Text = "0";
        APC_RV_SI.Text = "0";
        APC_RV_CI.Text = "0";
        APC_RV_TOTAL.Text = "0";
        APC_RV_DIFERENCIA.Text = "0";
        APC_MPK_SI.Text = "0";
        APC_MPK_CI.Text = "0";
        APC_MPK_TOTAL.Text = "0";
        APC_MPK_DIFERENCIA.Text = "0";
        APC_MPK_NETO.Text = "0";
        APC_MPK_NETO_IVA.Text = "0";
        APC_MPK_NETO_DISPUTA.Text = "0";
        APC_SP_SI.Text = "0";
        APC_SP_CI.Text = "0";
        APC_SP_TOTAL.Text = "0";
        APC_SP_DIFERENCIA.Text = "0";
        APC_SP_NETO.Text = "0";
        APC_SP_NETO_IVA.Text = "0";
        APC_SP_NETO_DISPUTA.Text = "0";
        APC_VENUS_SI.Text = "0";
        APC_VENUS_CI.Text = "0";
        APC_VENUS_TOTAL.Text = "0";
        APC_VENUS_DIFERENCIA.Text = "0";
        APC_VENUS_NETO.Text = "0";
        APC_VENUS_NETO_IVA.Text = "0";
        APC_VENUS_NETO_DISPUTA.Text = "0";
        APC_PVR_SI.Text = "0";
        APC_PVR_CI.Text = "0";
        APC_PVR_TOTAL.Text = "0";
        APC_PVR_DIFERENCIA.Text = "0";
        APC_PVR_NETO.Text = "0";
        APC_PVR_NETO_IVA.Text = "0";
        APC_PVR_NETO_DISPUTA.Text = "0";
        APC_WIFI_SI.Text = "0";
        APC_WIFI_CI.Text = "0";
        APC_WIFI_TOTAL.Text = "0";
        APC_WIFI_DIFERENCIA.Text = "0";
        APC_WIFI_NETO.Text = "0";
        APC_WIFI_NETO_IVA.Text = "0";
        APC_WIFI_NETO_DISPUTA.Text = "0";
        APC_CLAROVIDEO_SI.Text = "0";
        APC_CLAROVIDEO_CI.Text = "0";
        APC_CLAROVIDEO_TOTAL.Text = "0";
        APC_CLAROVIDEO_DIFERENCIA.Text = "0";
        APC_CLAROVIDEO_NETO.Text = "0";
        APC_CLAROVIDEO_NETO_IVA.Text = "0";
        APC_CLAROVIDEO_NETO_DISPUTA.Text = "0";
        APC_NOTAS_RR.Text = "";
        APC_Area_Ofrecimiento.ClearSelection();
        APC_Periodos.ClearSelection();
        APC_Prcentaje_Descuento.Text = "";

        string script = "APC_Limpiar_Controles();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "APC_Limpiar_Controles()", script, true);
    }
    protected void APC_Limpiar_Click(object sender, EventArgs e)
    {
        APC_Limpiar_Controles();
        this.APC_Cargar_Datos_Click(sender, e);
    }
    protected void SMO_Controles_A_Objeto()
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

        if (SMO_Radio_1.Checked == true) { Ofrecimiento_1 = 1; } else { Ofrecimiento_1 = 0; }
        if (SMO_Radio_3.Checked == true) { Ofrecimiento_2 = 1; } else { Ofrecimiento_2 = 0; }
        if (SMO_Radio_5.Checked == true) { Ofrecimiento_3 = 1; } else { Ofrecimiento_3 = 0; }

        if (SMO_S_VOZ.Checked == true) { Servicio_1 = 1; } else { Servicio_1 = 0; }
        if (SMO_S_ANALOGA.Checked == true) { Servicio_2 = 1; } else { Servicio_2 = 0; }
        if (SMO_S_AVANZADA.Checked == true) { Servicio_3 = 1; } else { Servicio_3 = 0; }
        if (SMO_S_BASICA.Checked == true) { Servicio_4 = 1; } else { Servicio_4 = 0; }
        if (SMO_S_SATELITAL.Checked == true) { Servicio_5 = 1; } else { Servicio_5 = 0; }
        if (SMO_S_INTERNET_3M.Checked == true) { Servicio_6 = 1; } else { Servicio_6 = 0; }
        if (SMO_S_INTERNET_5M.Checked == true) { Servicio_7 = 1; } else { Servicio_7 = 0; }
        if (SMO_S_INTERNET_10M.Checked == true) { Servicio_8 = 1; } else { Servicio_8 = 0; }
        if (SMO_S_INTERNET_20M.Checked == true) { Servicio_9 = 1; } else { Servicio_9 = 0; }
        if (SMO_S_INTERNET_50M.Checked == true) { Servicio_10 = 1; } else { Servicio_10 = 0; }
        if (SMO_S_INTERNET_100M.Checked == true) { Servicio_11 = 1; } else { Servicio_11 = 0; }
        if (SMO_S_CLARO_VIDEO.Checked == true) { Servicio_12 = 1; } else { Servicio_12 = 0; }
        if (SMO_S_FOX.Checked == true) { Servicio_13 = 1; } else { Servicio_13 = 0; }
        if (SMO_S_GOLDEN_PREMIER_HD.Checked == true) { Servicio_14 = 1; } else { Servicio_14 = 0; }
        if (SMO_S_HBO.Checked == true) { Servicio_15 = 1; } else { Servicio_15 = 0; }
        if (SMO_S_HD.Checked == true) { Servicio_16 = 1; } else { Servicio_16 = 0; }
        if (SMO_S_HOTPACK.Checked == true) { Servicio_17 = 1; } else { Servicio_17 = 0; }
        if (SMO_S_INTERNET_MOVIL_1_5.Checked == true) { Servicio_18 = 1; } else { Servicio_18 = 0; }
        if (SMO_S_INTERNET_MOVIL_750.Checked == true) { Servicio_19 = 1; } else { Servicio_19 = 0; }
        if (SMO_S_IP_FIJA.Checked == true) { Servicio_20 = 1; } else { Servicio_20 = 0; }
        if (SMO_S_LOCAL_EXTENDIDA.Checked == true) { Servicio_21 = 1; } else { Servicio_21 = 0; }
        if (SMO_S_MACAFEE.Checked == true) { Servicio_22 = 1; } else { Servicio_22 = 0; }
        if (SMO_S_MINI_FOX.Checked == true) { Servicio_23 = 1; } else { Servicio_23 = 0; }
        if (SMO_S_MINI_HBO.Checked == true) { Servicio_24 = 1; } else { Servicio_24 = 0; }
        if (SMO_S_MODEM_ADICIONAL.Checked == true) { Servicio_25 = 1; } else { Servicio_25 = 0; }
        if (SMO_S_PVR.Checked == true) { Servicio_26 = 1; } else { Servicio_26 = 0; }
        if (SMO_S_PVR_HD.Checked == true) { Servicio_27 = 1; } else { Servicio_27 = 0; }
        if (SMO_S_REVISTA.Checked == true) { Servicio_28 = 1; } else { Servicio_28 = 0; }
        if (SMO_S_SEGUNDO_MODEM.Checked == true) { Servicio_29 = 1; } else { Servicio_29 = 0; }
        if (SMO_S_UFC.Checked == true) { Servicio_30 = 1; } else { Servicio_30 = 0; }
        if (SMO_S_VOD.Checked == true) { Servicio_31 = 1; } else { Servicio_31 = 0; }

        obj_Entidad_Mejor_Oferta.Usuario_Gestion = Session["Usuario_Logueado"].ToString();
        obj_Entidad_Mejor_Oferta.Aliado_Gestion = Session["Aliado_Usuario"].ToString();
        obj_Entidad_Mejor_Oferta.Cuenta = Convert.ToDouble(SMO_Cuenta_Cliente.Text);
        obj_Entidad_Mejor_Oferta.Ofrecimiento_1_Envio = Ofrecimiento_1;
        obj_Entidad_Mejor_Oferta.Ofrecimiento_2_Envio = Ofrecimiento_2;
        obj_Entidad_Mejor_Oferta.Ofrecimiento_3_Envio = Ofrecimiento_3;
        obj_Entidad_Mejor_Oferta.Servicio_1 = Servicio_1;
        obj_Entidad_Mejor_Oferta.Servicio_2 = Servicio_2;
        obj_Entidad_Mejor_Oferta.Servicio_3 = Servicio_3;
        obj_Entidad_Mejor_Oferta.Servicio_4 = Servicio_4;
        obj_Entidad_Mejor_Oferta.Servicio_5 = Servicio_5;
        obj_Entidad_Mejor_Oferta.Servicio_6 = Servicio_6;
        obj_Entidad_Mejor_Oferta.Servicio_7 = Servicio_7;
        obj_Entidad_Mejor_Oferta.Servicio_8 = Servicio_8;
        obj_Entidad_Mejor_Oferta.Servicio_9 = Servicio_9;
        obj_Entidad_Mejor_Oferta.Servicio_10 = Servicio_10;
        obj_Entidad_Mejor_Oferta.Servicio_11 = Servicio_11;
        obj_Entidad_Mejor_Oferta.Servicio_12 = Servicio_12;
        obj_Entidad_Mejor_Oferta.Servicio_13 = Servicio_13;
        obj_Entidad_Mejor_Oferta.Servicio_14 = Servicio_14;
        obj_Entidad_Mejor_Oferta.Servicio_15 = Servicio_15;
        obj_Entidad_Mejor_Oferta.Servicio_16 = Servicio_16;
        obj_Entidad_Mejor_Oferta.Servicio_17 = Servicio_17;
        obj_Entidad_Mejor_Oferta.Servicio_18 = Servicio_18;
        obj_Entidad_Mejor_Oferta.Servicio_19 = Servicio_19;
        obj_Entidad_Mejor_Oferta.Servicio_20 = Servicio_20;
        obj_Entidad_Mejor_Oferta.Servicio_21 = Servicio_21;
        obj_Entidad_Mejor_Oferta.Servicio_22 = Servicio_22;
        obj_Entidad_Mejor_Oferta.Servicio_23 = Servicio_23;
        obj_Entidad_Mejor_Oferta.Servicio_24 = Servicio_24;
        obj_Entidad_Mejor_Oferta.Servicio_25 = Servicio_25;
        obj_Entidad_Mejor_Oferta.Servicio_26 = Servicio_26;
        obj_Entidad_Mejor_Oferta.Servicio_27 = Servicio_27;
        obj_Entidad_Mejor_Oferta.Servicio_28 = Servicio_28;
        obj_Entidad_Mejor_Oferta.Servicio_29 = Servicio_29;
        obj_Entidad_Mejor_Oferta.Servicio_30 = Servicio_30;
        obj_Entidad_Mejor_Oferta.Servicio_31 = Servicio_31;
        obj_Entidad_Mejor_Oferta.Servicio_32 = Servicio_32;
        obj_Entidad_Mejor_Oferta.Servicio_33 = Servicio_33;
        obj_Entidad_Mejor_Oferta.Tipo_Contacto = Convert.ToString(SMO_TIPO_CONTACTO.SelectedItem);
        obj_Entidad_Mejor_Oferta.Gestion = Convert.ToString(SMO_GESTION.SelectedItem);
        obj_Entidad_Mejor_Oferta.Cierre = Convert.ToString(SMO_CIERRE.SelectedItem);
        obj_Entidad_Mejor_Oferta.Razon = Convert.ToString(SMO_RAZON.SelectedItem);
        obj_Entidad_Mejor_Oferta.Observaciones = SMO_Notas.Text.ToUpper();

    }

    protected void SMO_Guardar_Datos_Click(object sender, EventArgs e)
    {
        if (Convert.ToString(SMO_Cuenta_Cliente.Text) != "")
        {

            SMO_Guardar_Datos.Enabled = false;
            DataSet dt = new DataSet();
            obj_Entidad_Mejor_Oferta.Cuenta = Convert.ToDouble(Cuenta_Cliente.Text);
            dt = obj_Neg_Mejor_Oferta.Consulta_Cliente_Mejor_Oferta_Gestionado(obj_Entidad_Mejor_Oferta.Cuenta);

            if (dt.Tables[0].Rows.Count > 0)
            {
                SMO_Actualizar_Datos();

            }
            else
            {
                SMO_Guardar_Datos_Ofrecimiento();
            }
        }
        else { }
    }
    protected void SMO_Guardar_Datos_Ofrecimiento()
    {


        SMO_Controles_A_Objeto();
        var Guardar_Datos = -1;
        Guardar_Datos = obj_Neg_Mejor_Oferta.abcVentas_Inbound("INSERTAR", obj_Entidad_Mejor_Oferta);
        if (Guardar_Datos != -1)
        {
            SMO_Guardar_Datos_Log();
            SMO_Limpiar_Controles();
            string script1 = "SMO_Guardado();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "SMO_Guardado", script1, true);

        }
        else
        {

            string script = "SMO_No_Guardado();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "SMO_No_Guardado", script, true);
        }

    }
    protected void SMO_Guardar_Datos_Log()
    {
        SMO_Controles_A_Objeto();
        var Guardar_Datos = -1;
        Guardar_Datos = obj_Neg_Mejor_Oferta.abc_LogVentas_Inbound("INSERTAR", obj_Entidad_Mejor_Oferta);
        SMO_Limpiar_Controles();
        SMO_Guardar_Datos.Enabled = true;

    }
    protected void SMO_Actualizar_Datos()
    {

        SMO_Controles_A_Objeto();
        var Guardar_Datos = -1;
        Guardar_Datos = obj_Neg_Mejor_Oferta.abcVentas_Inbound("ACTUALIZAR", obj_Entidad_Mejor_Oferta);
        if (Guardar_Datos != -1)
        {
            SMO_Guardar_Datos_Log();
            SMO_Limpiar_Controles();
            string script1 = "SMO_Actualizado();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "SMO_Actualizado", script1, true);

        }
        else
        {
            string script = "SMO_No_Actualizado();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "SMO_No_Actualizado", script, true);
        }

    }

    protected void SMO_Tipo_Contacto()
    {

        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion = 9;
        dt = Obj_Neg_Arbol_Outbound.Oubound_Tipo_Contacto(Obj_Entidad_Arbol_Outbound.Id_Tipo_Gestion);

        if (dt.Tables[0].Rows.Count > 0)
        {
            SMO_TIPO_CONTACTO.DataSource = dt;
            SMO_TIPO_CONTACTO.DataTextField = "TIPO_CONTACTO";
            SMO_TIPO_CONTACTO.DataValueField = "ID_TIPO_CONTACTO";
            SMO_TIPO_CONTACTO.DataBind();
        }
        else
        {
            SMO_TIPO_CONTACTO.Items.Clear();
        }
    }
    protected void SMO_Gestion()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto = Convert.ToInt16(SMO_TIPO_CONTACTO.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Cierre(Obj_Entidad_Arbol_Outbound.Id_Tipo_Contacto);

        if (dt.Tables[0].Rows.Count > 0)
        {

            SMO_GESTION.DataSource = dt;
            SMO_GESTION.DataTextField = "CIERRE";
            SMO_GESTION.DataValueField = "ID_CIERRE";
            SMO_GESTION.DataBind();
        }
        else
        {
            SMO_GESTION.Items.Clear();
        }
    }
    protected void SMO_Cierre()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Cierre = Convert.ToInt16(SMO_GESTION.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Razon(Obj_Entidad_Arbol_Outbound.Id_Cierre);

        if (dt.Tables[0].Rows.Count > 0)
        {
            SMO_CIERRE.DataSource = dt;
            SMO_CIERRE.DataTextField = "RAZON";
            SMO_CIERRE.DataValueField = "ID_RAZON";
            SMO_CIERRE.DataBind();
        }
        else
        {
            SMO_CIERRE.Items.Clear();
        }
    }
    protected void SMO_Razon()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Arbol_Outbound.Id_Causa = Convert.ToInt16(SMO_CIERRE.SelectedValue);
        dt = Obj_Neg_Arbol_Outbound.Oubound_Causa(Obj_Entidad_Arbol_Outbound.Id_Causa);

        if (dt.Tables[0].Rows.Count > 0)
        {
            SMO_RAZON.DataSource = dt;
            SMO_RAZON.DataTextField = "CAUSA";
            SMO_RAZON.DataValueField = "ID_CAUSA";
            SMO_RAZON.DataBind();
        }
        else
        {
            SMO_RAZON.Items.Clear();
        }
    }

    protected void SMO_TIPO_CONTACTO_SelectedIndexChanged(object sender, EventArgs e)
    {
        SMO_Gestion();
        SMO_Cierre();
        SMO_Razon();
    }

    protected void SMO_GESTION_SelectedIndexChanged(object sender, EventArgs e)
    {
        SMO_Cierre();
        SMO_Razon();
    }

    protected void SMO_CIERRE_SelectedIndexChanged(object sender, EventArgs e)
    {
        SMO_Razon();
    }
    protected void SMO_Limpiar_Controles()
    {
        var LIMPIAR_DATOS = "";
        SMO_Cuenta_Cliente.Text = LIMPIAR_DATOS;
        SMO_Nombre_Cliente.Text = LIMPIAR_DATOS;
        SMO_Apellido_Cliente.Text = LIMPIAR_DATOS;
        SMO_Doc_Identidad.Text = LIMPIAR_DATOS;
        SMO_Mix_Basico.Text = LIMPIAR_DATOS;
        SMO_Television.Text = LIMPIAR_DATOS;
        SMO_Internet.Text = LIMPIAR_DATOS;
        SMO_Telefonia.Text = LIMPIAR_DATOS;
        SMO_HD.Text = LIMPIAR_DATOS;
        SMO_HBO.Text = LIMPIAR_DATOS;
        SMO_Fox.Text = LIMPIAR_DATOS;
        SMO_Servicio_Adulto.Text = LIMPIAR_DATOS;
        SMO_Servicio_Claro_Video.Text = LIMPIAR_DATOS;
        SMO_Num_Decos.Text = LIMPIAR_DATOS;
        SMO_Revista.Text = LIMPIAR_DATOS;
        SMO_Elegido_Fijo_Movil.Text = LIMPIAR_DATOS;
        SMO_Siembra_HD.Text = LIMPIAR_DATOS;
        SMO_Blindaje_Internet.Text = LIMPIAR_DATOS;
        SMO_Siembra_Voz.Text = LIMPIAR_DATOS;
        SMO_Activacion_Claro_Video.Text = LIMPIAR_DATOS;
        SMO_T_Ofrecimiento_1.Text = LIMPIAR_DATOS;
        SMO_T_Ofrecimiento_2.Text = LIMPIAR_DATOS;
        SMO_T_Ofrecimiento_3.Text = LIMPIAR_DATOS;
        SMO_S_VOZ.Checked = false;
        SMO_S_ANALOGA.Checked = false;
        SMO_S_AVANZADA.Checked = false;
        SMO_S_BASICA.Checked = false;
        SMO_S_SATELITAL.Checked = false;
        SMO_S_INTERNET_3M.Checked = false;
        SMO_S_INTERNET_5M.Checked = false;
        SMO_S_INTERNET_10M.Checked = false;
        SMO_S_INTERNET_20M.Checked = false;
        SMO_S_INTERNET_50M.Checked = false;
        SMO_S_INTERNET_100M.Checked = false;
        SMO_S_CLARO_VIDEO.Checked = false;
        SMO_S_FOX.Checked = false;
        SMO_S_GOLDEN_PREMIER_HD.Checked = false;
        SMO_S_HBO.Checked = false;
        SMO_S_HD.Checked = false;
        SMO_S_HOTPACK.Checked = false;
        SMO_S_INTERNET_MOVIL_1_5.Checked = false;
        SMO_S_INTERNET_MOVIL_750.Checked = false;
        SMO_S_IP_FIJA.Checked = false;
        SMO_S_LOCAL_EXTENDIDA.Checked = false;
        SMO_S_MACAFEE.Checked = false;
        SMO_S_MINI_FOX.Checked = false;
        SMO_S_MINI_HBO.Checked = false;
        SMO_S_MODEM_ADICIONAL.Checked = false;
        SMO_S_PVR.Checked = false;
        SMO_S_PVR_HD.Checked = false;
        SMO_S_REVISTA.Checked = false;
        SMO_S_SEGUNDO_MODEM.Checked = false;
        SMO_S_UFC.Checked = false;
        SMO_S_VOD.Checked = false;
        SMO_Radio_1.Checked = false;
        SMO_Radio_2.Checked = false;
        SMO_Radio_3.Checked = false;
        SMO_Radio_4.Checked = false;
        SMO_Radio_5.Checked = false;
        SMO_Radio_6.Checked = false;
        SMO_TIPO_CONTACTO.ClearSelection();
        SMO_TIPO_CONTACTO.Items.Clear();
        SMO_GESTION.ClearSelection();
        SMO_GESTION.Items.Clear();
        SMO_CIERRE.ClearSelection();
        SMO_CIERRE.Items.Clear();
        SMO_RAZON.ClearSelection();
        SMO_RAZON.Items.Clear();
        SMO_Notas.Text = LIMPIAR_DATOS;


    }

    protected void ADT_Contrato_Cliente_TextChanged(object sender, EventArgs e)
    {
        Generar_Nota_ADT();
    }



    protected void CV_Guarda_Click(object sender, EventArgs e)
    {
        CV_Guarda.Enabled = false;
        DataSet dt = new DataSet();
        Obj_Entidad_Claro_Video.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);
        dt = Obj_Neg_Claro_Video.Consulta_Cliente_Activacion_Claro_Video(Obj_Entidad_Claro_Video.Cuenta_Cliente);

        if (dt.Tables[0].Rows.Count > 0)
        {
            CV_Guardar_Datos_Ofrecimiento();
            string script1 = "CV_Actualizado();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "CV_Actualizado", script1, true);
        }
        else
        {
            CV_Guardar_Datos_Ofrecimiento();
            string script1 = "CV_Guardado();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "CV_Guardado", script1, true);
        }
    }
    protected void CV_Guardar_Datos_Ofrecimiento()
    {
        CV_Controles_A_Objeto();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Claro_Video.abc_Activacion_Claro_Video("INSERTAR", Obj_Entidad_Claro_Video);
        if (Guardar_Datos != -1)
        {
            CV_Limpiar_Controles();
        }
        else
        {
            
        }

    }
    protected void CV_Controles_A_Objeto()
    {
        string Aceptacion = string.Empty;
        
        if (RadioButton13.Checked == true) { Aceptacion = "SI"; }
        if (RadioButton14.Checked == true) { Aceptacion = "NO"; } 

        Obj_Entidad_Claro_Video.Fecha_Gestion = "";
        Obj_Entidad_Claro_Video.Usuario_Gestion = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Claro_Video.Nombre_Usuario_Gestion = Session["Nombre_Usuario"].ToString();
        Obj_Entidad_Claro_Video.Aliado_Gestion = Session["Aliado_Usuario"].ToString();
        Obj_Entidad_Claro_Video.Cuenta_Cliente = Convert.ToInt64(Cuenta_Cliente.Text);
        Obj_Entidad_Claro_Video.Aceptacion_Claro_Video = Aceptacion;
    }
    protected void CV_Limpiar_Controles()
    {
        RadioButton13.Checked = false;
        RadioButton14.Checked = false;
        CV_Guarda.Enabled = true;
    }

    protected void SHD_Guardar_Click(object sender, EventArgs e)
    {
        SHD_Guardar.Enabled = false;
        DataSet dt = new DataSet();
        Obj_Entidad_Siembra_HD.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);
        dt = Obj_Neg_Siembra_HD.Consulta_Cliente_Activacion_Siembra_HD(Obj_Entidad_Siembra_HD.Cuenta_Cliente);

        if (dt.Tables[0].Rows.Count > 0)
        {
            SHD_Guardar_Datos_Ofrecimiento();
            string script1 = "SHD_Actualizado();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "SHD_Actualizado", script1, true);
        }
        else
        {
            SHD_Guardar_Datos_Ofrecimiento();
            string script1 = "SHD_Guardado();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "SHD_Guardado", script1, true);
        }
    }
    protected void SHD_Guardar_Datos_Ofrecimiento()
    {
        SHD_Controles_A_Objeto();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Siembra_HD.abc_Activacion_Siembra_HD("INSERTAR", Obj_Entidad_Siembra_HD);
        if (Guardar_Datos != -1)
        {
            SHD_Limpiar_Controles();
        }
        else
        {

        }

    }
    protected void SHD_Controles_A_Objeto()
    {
        string AceptacionSHD = string.Empty;

        if (RadioButton15.Checked == true) { AceptacionSHD = "SI"; }
        if (RadioButton16.Checked == true) { AceptacionSHD = "NO"; }

        Obj_Entidad_Siembra_HD.Fecha_Gestion = "";
        Obj_Entidad_Siembra_HD.Usuario_Gestion = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Siembra_HD.Nombre_Usuario_Gestion = Session["Nombre_Usuario"].ToString();
        Obj_Entidad_Siembra_HD.Aliado_Gestion = Session["Aliado_Usuario"].ToString();
        Obj_Entidad_Siembra_HD.Cuenta_Cliente = Convert.ToInt64(Cuenta_Cliente.Text);
        Obj_Entidad_Siembra_HD.Ofrecimiento = S_HD_OFRECIMIENTO.Text;
        Obj_Entidad_Siembra_HD.Aceptacion_Siembra_HD = AceptacionSHD;
    }
    protected void SHD_Limpiar_Controles()
    {
        RadioButton15.Checked = false;
        RadioButton16.Checked = false;
        S_HD_OFRECIMIENTO.Text = string.Empty;
        SHD_Guardar.Enabled = true;
    }
    protected void BE_Cargar_Datos_Click(object sender, EventArgs e)
    {
        BE_Cuenta.Text = Cuenta_Cliente.Text;
        BE_Nodo.Text = Nodo.Text;
    }

    protected void TCD_Tipo_de_Direccion_SelectedIndexChanged(object sender, EventArgs e)
    {
        string script1 = "Reset_valores();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "Reset_valores", script1, true);
       

    }
    protected void Llenar_Direccion_Final()
    {
        var Seleccion = Convert.ToString(TCD_Tipo_de_Direccion.SelectedItem);

        if (Seleccion == "--SELECCIONE--")
        {

        }
        else if (Seleccion == "Basica")
        {
            Llenar_Direccion_Basica();
        }
        else if (Seleccion == "Barrio Manzana")
        {
            Llenar_Direccion_Barrio_Manzana();
        }
        else if (Seleccion == "Multiorigen")
        {
            Llenar_Direccion_Multiorigen();
        }
        else if (Seleccion == "Intraducible")
        {
            Llenar_Direccion_Intraducible();
        }
    }
    protected void Llenar_Direccion_Basica()
    {
        Limpiar_Direcciones_Traslados();
        var valor1 =Convert.ToString(TCDB_Tipo_de_Via.SelectedItem);
        var valor2 = TCDB_Via_Principal.Text;
        var valor3 = TCDB_Cuadrante.Text;
        var valor4 = TCDB_Placa.Text;
        var valor5 = TCDB_Complemento.Text;
        var Dir_Total = valor1 +" "+ valor2 +" "+ valor3 +" "+ valor4 +" "+ valor5;
        TCDB_Direccion.Text = Dir_Total.ToString();
    }
    protected void Llenar_Direccion_Barrio_Manzana()
    {
        Limpiar_Direcciones_Traslados();
        var valor1 = TCDBM_Barrio.Text;
        var valor2 = TCDBM_Placa.Text;
        var valor3 = TCDBM_Complemento.Text;
        var Dir_Total = valor1 + " " + valor2 + " " + valor3;
        TCDBM_Direccion_Final.Text = Dir_Total.ToString();
    }
    protected void Llenar_Direccion_Multiorigen()
    {
        Limpiar_Direcciones_Traslados();
        var valor1 = Convert.ToString(TCDM_Tipo_de_via.SelectedItem);
        var valor2 = TCDM_Via_Principal.Text;
        var valor3 = TCDM_Cuadrante.Text;
        var valor4 = TCDM_Barrio.Text;
        var valor5 = TCDM_Placa.Text;
        var valor6 = TCDM_Complemento.Text;
        var Dir_Total = valor1 + " " + valor2 + " " + valor3 + " " + valor4 + " " + valor5 +" "+ valor6;
        TCDM_Direccion_Final.Text = Dir_Total.ToString();

    }
    protected void Llenar_Direccion_Intraducible()
    {
        Limpiar_Direcciones_Traslados();
        var valor1 = TCDI_Via_Vereda.Text;
        var valor2 = TCDI_Nombre_Via.Text;
        var valor3 = TCDI_Kilometro.Text;
        var valor4 = TCDI_Sector.Text;
        var valor5 = TCDI_Nombre_Sector.Text;
        var valor6 = TCDI_Urb_O_Finca.Text;
        var valor7 = TCDI_Placa.Text;
        var valor8 = TCDI_Complemento.Text;
        var Dir_Total = valor1 + " " + valor2 + " " + valor3 + " " + valor4 + " " + valor5 + " " + valor6+" "+valor7+" "+valor8;
        TCDI_Direccion_Final.Text = Dir_Total.ToString();
    }
    protected void Limpiar_Direcciones_Traslados()
    {
        var limpiar = "";
        TCDI_Direccion_Final.Text = limpiar;
        TCDM_Direccion_Final.Text = limpiar;
        TCDBM_Direccion_Final.Text = limpiar;
        TCDB_Direccion.Text = limpiar;
    }

    protected void TCDB_Via_Principal_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDB_Cuadrante_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDB_Placa_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDB_Complemento_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDM_Via_Principal_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDM_Cuadrante_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDM_Barrio_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDM_Placa_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDM_Complemento_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDBM_Barrio_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDBM_Placa_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDBM_Complemento_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDI_Via_Vereda_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDI_Nombre_Via_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDI_Kilometro_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDI_Sector_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDI_Nombre_Sector_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDI_Urb_O_Finca_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDI_Placa_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }

    protected void TCDI_Complemento_TextChanged(object sender, EventArgs e)
    {
        Llenar_Direccion_Final();
    }
}

