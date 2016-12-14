using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
//using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Drawing;
using System.IO;
using Entidades;
using Negocios;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.OleDb;

public partial class Administracion_de_Usuarios : System.Web.UI.Page
{
    public E_Nombre_Linea Obj_Entidad_Nombre_Linea = new E_Nombre_Linea();
    public N_Nombre_Linea Obj_Neg_Nombre_Linea = new N_Nombre_Linea();
    public E_Perfiles Obj_Entidad_Perfiles = new E_Perfiles();
    public N_Perfiles Obj_Neg_Perfiles = new N_Perfiles();
    public E_Base_Personal Obj_Entidad_Base_Personal = new E_Base_Personal();
    public N_Base_Personal Obj_Neg_Base_Personal = new N_Base_Personal();
    public E_Usuarios Obj_Entidad_Usuarios = new E_Usuarios();
    public N_Usuarios Obj_Neg_Usuarios = new N_Usuarios();

    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Cedula_TextChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Usuarios.Cedulas = Cedula.Text;
        dt = Obj_Neg_Usuarios.Consulta_Usuarios_Cedula(Obj_Entidad_Usuarios.Cedulas);

        if (dt.Tables[0].Rows.Count > 0)
        {
            string script1 = "mensaje1();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1", script1, true);
            Limpiar();
        }
        else
        {
            Carga_Perfil_Usuarios();
            this.Perfil_SelectedIndexChanged(sender, e);
            Trae_Informacion_Holos();


        }

    }
    protected void Crear_Usuario_Click(object sender, EventArgs e)
    {
        Registra_Usuario();
    }
    protected void Actualizar_Usuario_Click(object sender, EventArgs e)
    {
        var V_Usuario_RR = A_Usuario_RR.Text;
        if (V_Usuario_RR == "")
        {
            string script6 = "mensaje6();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje6", script6, true);
            Limpiar();
        }
        else
        {

            var Guardar_Datos = -1;
            Controles_a_Objeto_A();
            Guardar_Datos = Obj_Neg_Usuarios.abcUsuarios("ACTUALIZAR", Obj_Entidad_Usuarios);
            if (Guardar_Datos != -1)
            {
                string script7 = "mensaje7();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje7", script7, true);
                Limpiar();
            }
            else
            {

            }
        }
    }
    protected void C_Cedula_TextChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Usuarios.Cedulas = C_Cedula.Text;
        dt = Obj_Neg_Usuarios.Consulta_Usuarios_Cedula(Obj_Entidad_Usuarios.Cedulas);

        if (dt.Tables[0].Rows.Count > 0)
        {

            Trae_Informacion_Holos_C();

        }
        else
        {

            string script5 = "mensaje5();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje5", script5, true);
            Limpiar();

        }
    }
    protected void A_Cedula_TextChanged(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Usuarios.Cedulas = A_Cedula.Text;
        dt = Obj_Neg_Usuarios.Consulta_Usuarios_Cedula(Obj_Entidad_Usuarios.Cedulas);

        if (dt.Tables[0].Rows.Count > 0)
        {

            this.Trae_Informacion_Holos_A(sender, e);
            //this.A_Perfil_Siriac_SelectedIndexChanged(sender, e);

        }
        else
        {

            string script5 = "mensaje5();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje5", script5, true);
            Limpiar();

        }
    }
    protected void Carga_Nombre__Linea_Celula()
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Nombre_Linea.Selecciona_Nombre_Linea_Celula();

        if (dt.Tables[0].Rows.Count > 0)
        {

            Nombre_Linea.DataSource = dt;
            Nombre_Linea.DataTextField = "NOMBRE_LINEA";
            Nombre_Linea.DataValueField = "ID_NOMBRE_LINEA";
            Nombre_Linea.DataBind();

            A_Nombre_Linea_Siriac.DataSource = dt;
            A_Nombre_Linea_Siriac.DataTextField = "NOMBRE_LINEA";
            A_Nombre_Linea_Siriac.DataValueField = "ID_NOMBRE_LINEA";
            A_Nombre_Linea_Siriac.DataBind();

            Masivo_Nombre_Linea.DataSource = dt;
            Masivo_Nombre_Linea.DataTextField = "NOMBRE_LINEA";
            Masivo_Nombre_Linea.DataValueField = "ID_NOMBRE_LINEA";
            Masivo_Nombre_Linea.DataBind();
        }
    }
    protected void Carga_Nombre__Linea_Asesor()
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Nombre_Linea.Selecciona_Nombre_Linea_Asesor();

        if (dt.Tables[0].Rows.Count > 0)
        {

            Nombre_Linea.DataSource = dt;
            Nombre_Linea.DataTextField = "NOMBRE_LINEA";
            Nombre_Linea.DataValueField = "ID_NOMBRE_LINEA";
            Nombre_Linea.DataBind();

            A_Nombre_Linea_Siriac.DataSource = dt;
            A_Nombre_Linea_Siriac.DataTextField = "NOMBRE_LINEA";
            A_Nombre_Linea_Siriac.DataValueField = "ID_NOMBRE_LINEA";
            A_Nombre_Linea_Siriac.DataBind();

            Masivo_Nombre_Linea.DataSource = dt;
            Masivo_Nombre_Linea.DataTextField = "NOMBRE_LINEA";
            Masivo_Nombre_Linea.DataValueField = "ID_NOMBRE_LINEA";
            Masivo_Nombre_Linea.DataBind();
        }
    }
    protected void Perfil_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel8.Visible = false;
        Panel7.Visible = false;
        Panel6.Visible = false;
        var PERFIL = Perfil.SelectedValue;

        if (PERFIL == "1")
        {
            Carga_Nombre__Linea_Asesor();
            Panel8.Visible = true;
        }
        else if (PERFIL == "2")
        {
            Carga_Nombre__Linea_Celula();
            Panel7.Visible = true;
        }
        else if (PERFIL == "3")
        {
            Carga_Nombre__Linea_Asesor();
            Panel6.Visible = true;
        }
    }
    protected void A_Perfil_Siriac_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel14.Visible = false;
        Panel15.Visible = false;
        Panel16.Visible = false;
        var PERFIL = A_Perfil_Siriac.SelectedValue;

        if (PERFIL == "1")
        {
            DataSet dt = new DataSet();
            dt = Obj_Neg_Nombre_Linea.Selecciona_Nombre_Linea_Asesor();

            if (dt.Tables[0].Rows.Count > 0)
            {
                A_Nombre_Linea_Siriac.DataSource = dt;
                A_Nombre_Linea_Siriac.DataTextField = "NOMBRE_LINEA";
                A_Nombre_Linea_Siriac.DataValueField = "ID_NOMBRE_LINEA";
                A_Nombre_Linea_Siriac.DataBind();
            }
            Panel16.Visible = true;
        }
        else if (PERFIL == "2")
        {
            DataSet dt = new DataSet();
            dt = Obj_Neg_Nombre_Linea.Selecciona_Nombre_Linea_Celula();

            if (dt.Tables[0].Rows.Count > 0)
            {
                A_Nombre_Linea_Siriac.DataSource = dt;
                A_Nombre_Linea_Siriac.DataTextField = "NOMBRE_LINEA";
                A_Nombre_Linea_Siriac.DataValueField = "ID_NOMBRE_LINEA";
                A_Nombre_Linea_Siriac.DataBind();
            }
            else
            { }
            Panel15.Visible = true;
        }
        else if (PERFIL == "3")
        {

            DataSet dt = new DataSet();
            dt = Obj_Neg_Nombre_Linea.Selecciona_Nombre_Linea_Asesor();

            if (dt.Tables[0].Rows.Count > 0)
            {
                A_Nombre_Linea_Siriac.DataSource = dt;
                A_Nombre_Linea_Siriac.DataTextField = "NOMBRE_LINEA";
                A_Nombre_Linea_Siriac.DataValueField = "ID_NOMBRE_LINEA";
                A_Nombre_Linea_Siriac.DataBind();
            }
            Panel14.Visible = true;
        }
    }
    protected void Carga_Perfil_Usuarios()
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Perfiles.Perfil_Usuario();

        if (dt.Tables[0].Rows.Count > 0)
        {

            Perfil.DataSource = dt;
            Perfil.DataTextField = "DESCRIPCION";
            Perfil.DataValueField = "ID_ROL";
            Perfil.DataBind();

            A_Perfil_Siriac.DataSource = dt;
            A_Perfil_Siriac.DataTextField = "DESCRIPCION";
            A_Perfil_Siriac.DataValueField = "ID_ROL";
            A_Perfil_Siriac.DataBind();
        }
    }
    protected void Trae_Informacion_Holos()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Base_Personal.Cedula = Cedula.Text;
        dt = Obj_Neg_Base_Personal.Consulta_Informacion_Usuario(Obj_Entidad_Base_Personal.Cedula);

        if (dt.Tables[0].Rows.Count > 0)
        {

            Nombre_Usuario.Text = dt.Tables[0].Rows[0]["NOMBRE"].ToString();
            Aliado.Text = dt.Tables[0].Rows[0]["ALIADO"].ToString();
            Nombre_de_Linea.Text = dt.Tables[0].Rows[0]["NOMBRE_LINEA"].ToString();
            Usuario_RR.Text = dt.Tables[0].Rows[0]["USUARIO_RR"].ToString();
            Usuario_Agendamiento.Text = dt.Tables[0].Rows[0]["USUARIO_AGENDAMIENTO"].ToString();
            Usuario_Gerencia.Text = dt.Tables[0].Rows[0]["USUARIO_GERENCIA"].ToString();
            Estado.Text = dt.Tables[0].Rows[0]["ESTADO"].ToString();
            Canal.Text = dt.Tables[0].Rows[0]["CANAL"].ToString();
            Operacion.Text = dt.Tables[0].Rows[0]["OPERACION"].ToString();
            Grupo.Text = dt.Tables[0].Rows[0]["GRUPO"].ToString();
            Cargo.Text = dt.Tables[0].Rows[0]["CARGO"].ToString();
            Segmento.Text = dt.Tables[0].Rows[0]["SEGMENTO"].ToString();

            Nombre_Usuario.Enabled = false;
            Aliado.Enabled = false;
            Nombre_de_Linea.Enabled = false;
            Usuario_RR.Enabled = false;
            Usuario_Agendamiento.Enabled = false;
            Usuario_Gerencia.Enabled = false;
            Estado.Enabled = false;
            Canal.Enabled = false;
            Operacion.Enabled = false;
            Grupo.Enabled = false;
            Cargo.Enabled = false;
            Segmento.Enabled = false;

        }
        else
        {
            Limpiar();
        }
    }
    protected void Limpiar()
    {
        Panel8.Visible = false;
        Panel7.Visible = false;
        Panel6.Visible = false;
        Panel11.Visible = false;
        Panel12.Visible = false;

        Panel16.Visible = false;
        Panel15.Visible = false;
        Panel14.Visible = false;


        Nombre_Usuario.Enabled = true;
        Aliado.Enabled = true;
        Nombre_de_Linea.Enabled = true;
        Usuario_RR.Enabled = true;
        Usuario_Agendamiento.Enabled = true;
        Usuario_Gerencia.Enabled = true;
        Estado.Enabled = true;
        Canal.Enabled = true;
        Operacion.Enabled = true;
        Grupo.Enabled = true;
        Cargo.Enabled = true;
        Segmento.Enabled = true;

        Nombre_Usuario.Text = string.Empty;
        Aliado.Text = string.Empty;
        Nombre_de_Linea.Text = string.Empty;
        Usuario_RR.Text = string.Empty;
        Usuario_Agendamiento.Text = string.Empty;
        Usuario_Gerencia.Text = string.Empty;
        Estado.Text = string.Empty;
        Canal.Text = string.Empty;
        Operacion.Text = string.Empty;
        Grupo.Text = string.Empty;
        Cargo.Text = string.Empty;
        Segmento.Text = string.Empty;
        CleanControl(this.Controls);
    }
    public void CleanControl(ControlCollection controles)
    {
        foreach (Control control in controles)
        {
            if (control is TextBox)
                ((TextBox)control).Text = "";
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
                ((DropDownList)control).Items.Clear();
            }
            else if (control.HasControls())
                //Esta linea detécta un Control que contenga otros Controles
                //Así ningún control se quedará sin ser limpiado.
                CleanControl(control.Controls);
        }
    }
    protected void Controles_a_Objeto()
    {
        var ACCESO_1 = 0;
        var ACCESO_2 = 0;
        var ACCESO_3 = 0;
        var ACCESO_4 = 0;
        var ACCESO_5 = 0;
        var ACCESO_6 = 0;
        var ACCESO_7 = 0;
        var ACCESO_8 = 0;
        var ACCESO_9 = 0;
        var ACCESO_10 = 0;
        var ACCESO_11 = 0;
        var ACCESO_12 = 0;
        var ACCESO_13 = 0;
        var ACCESO_14 = 0;
        var ACCESO_15 = 0;
        var ACCESO_16 = 0;
        var ACCESO_17 = 0;
        var ACCESO_18 = 0;
        var ACCESO_19 = 0;
        var ACCESO_20 = 0;
        var ACCESO_21 = 0;
        var ACCESO_22 = 0;
        var ACCESO_23 = 0;
        var ACCESO_24 = 0;
        var ACCESO_25 = 0;
        var ACCESO_26 = 0;
        var ACCESO_27 = 0;
        var ACCESO_28 = 0;
        var ACCESO_29 = 0;
        var ACCESO_30 = 0;

        string PERFIL = Perfil.SelectedValue;
        if (PERFIL == "1")
        {

            if (CheckBox13.Checked == true) { ACCESO_1 = 1; } else { ACCESO_1 = 0; };
            if (CheckBox14.Checked == true) { ACCESO_2 = 1; } else { ACCESO_2 = 0; };
            if (CheckBox15.Checked == true) { ACCESO_3 = 1; } else { ACCESO_3 = 0; };
            if (CheckBox16.Checked == true) { ACCESO_4 = 1; } else { ACCESO_4 = 0; };
            if (CheckBox17.Checked == true) { ACCESO_5 = 1; } else { ACCESO_5 = 0; };
            if (CheckBox18.Checked == true) { ACCESO_6 = 1; } else { ACCESO_6 = 0; };
            if (CheckBox19.Checked == true) { ACCESO_7 = 1; } else { ACCESO_7 = 0; };
            if (CheckBox20.Checked == true) { ACCESO_8 = 1; } else { ACCESO_8 = 0; };
            if (CheckBox21.Checked == true) { ACCESO_9 = 1; } else { ACCESO_9 = 0; };
            if (CheckBox22.Checked == true) { ACCESO_10 = 1; } else { ACCESO_10 = 0; };
            if (CheckBox23.Checked == true) { ACCESO_11 = 1; } else { ACCESO_11 = 0; };
            if (CheckBox24.Checked == true) { ACCESO_12 = 1; } else { ACCESO_12 = 0; };
            if (CheckBox25.Checked == true) { ACCESO_13 = 1; } else { ACCESO_13 = 0; };
            if (CheckBox26.Checked == true) { ACCESO_14 = 1; } else { ACCESO_14 = 0; };
            if (CheckBox27.Checked == true) { ACCESO_15 = 1; } else { ACCESO_15 = 0; };
            if (CheckBox106.Checked == true) { ACCESO_16 = 1; } else { ACCESO_16 = 0; };
            if (CheckBox107.Checked == true) { ACCESO_17 = 1; } else { ACCESO_17 = 0; };
            if (CheckBox188.Checked == true) { ACCESO_18 = 1; } else { ACCESO_18 = 0; };
            if (CheckBox189.Checked == true) { ACCESO_19 = 1; } else { ACCESO_19= 0; };
            if (CheckBox211.Checked == true) { ACCESO_20 = 1; } else { ACCESO_20 = 0; };
            if (CheckBox212.Checked == true) { ACCESO_21 = 1; } else { ACCESO_21 = 0; };

        }
        else if (PERFIL == "2")
        {
            if (CheckBox9.Checked == true) { ACCESO_1 = 1; } else { ACCESO_1 = 0; };
            if (CheckBox10.Checked == true) { ACCESO_2 = 1; } else { ACCESO_2 = 0; };
            if (CheckBox11.Checked == true) { ACCESO_3 = 1; } else { ACCESO_3 = 0; };
            if (CheckBox12.Checked == true) { ACCESO_4 = 1; } else { ACCESO_4 = 0; };
            if (CheckBox209.Checked == true) { ACCESO_5 = 1; } else { ACCESO_5 = 0; };
            if (CheckBox210.Checked == true) { ACCESO_6 = 1; } else { ACCESO_6 = 0; };

        }
        else if (PERFIL == "3")
        {

            if (CheckBox1.Checked == true) { ACCESO_1 = 1; } else { ACCESO_1 = 0; };
            if (CheckBox2.Checked == true) { ACCESO_2 = 1; } else { ACCESO_2 = 0; };
            if (CheckBox3.Checked == true) { ACCESO_3 = 1; } else { ACCESO_3 = 0; };
            if (CheckBox4.Checked == true) { ACCESO_4 = 1; } else { ACCESO_4 = 0; };
            if (CheckBox5.Checked == true) { ACCESO_5 = 1; } else { ACCESO_5 = 0; };
            if (CheckBox6.Checked == true) { ACCESO_6 = 1; } else { ACCESO_6 = 0; };
            if (CheckBox7.Checked == true) { ACCESO_7 = 1; } else { ACCESO_7 = 0; };
            if (CheckBox8.Checked == true) { ACCESO_8 = 1; } else { ACCESO_8 = 0; };
            if (CheckBox82.Checked == true) { ACCESO_9 = 1; } else { ACCESO_9 = 0; };
            if (CheckBox83.Checked == true) { ACCESO_10 = 1; } else { ACCESO_10 = 0; };
            if (CheckBox84.Checked == true) { ACCESO_11 = 1; } else { ACCESO_11 = 0; };
            if (CheckBox85.Checked == true) { ACCESO_12 = 1; } else { ACCESO_12 = 0; };
            if (CheckBox86.Checked == true) { ACCESO_13 = 1; } else { ACCESO_13 = 0; };
            if (CheckBox87.Checked == true) { ACCESO_14 = 1; } else { ACCESO_14 = 0; };
            if (CheckBox88.Checked == true) { ACCESO_15 = 1; } else { ACCESO_15 = 0; };
            if (CheckBox89.Checked == true) { ACCESO_16 = 1; } else { ACCESO_16 = 0; };
            if (CheckBox187.Checked == true) { ACCESO_17 = 1; } else { ACCESO_17 = 0; };
            if (CheckBox202.Checked == true) { ACCESO_18 = 1; } else { ACCESO_18 = 0; };
            if (CheckBox207.Checked == true) { ACCESO_19 = 1; } else { ACCESO_19 = 0; };
            if (CheckBox208.Checked == true) { ACCESO_20 = 1; } else { ACCESO_20 = 0; };

        };

        Obj_Entidad_Usuarios.Cedula = Convert.ToDouble(Cedula.Text);
        Obj_Entidad_Usuarios.Nombre = Nombre_Usuario.Text;
        Obj_Entidad_Usuarios.Usuario_RR = Usuario_RR.Text;
        Obj_Entidad_Usuarios.Usuario_Agendamiento = Usuario_Agendamiento.Text;
        Obj_Entidad_Usuarios.Contrasena = Contrasena.Text;
        Obj_Entidad_Usuarios.Id_Rol = Convert.ToInt16(Perfil.SelectedValue);
        Obj_Entidad_Usuarios.Id_Nombre_Linea = Convert.ToInt16(Nombre_Linea.SelectedValue);
        Obj_Entidad_Usuarios.Acceso_1 = ACCESO_1;
        Obj_Entidad_Usuarios.Acceso_2 = ACCESO_2;
        Obj_Entidad_Usuarios.Acceso_3 = ACCESO_3;
        Obj_Entidad_Usuarios.Acceso_4 = ACCESO_4;
        Obj_Entidad_Usuarios.Acceso_5 = ACCESO_5;
        Obj_Entidad_Usuarios.Acceso_6 = ACCESO_6;
        Obj_Entidad_Usuarios.Acceso_7 = ACCESO_7;
        Obj_Entidad_Usuarios.Acceso_8 = ACCESO_8;
        Obj_Entidad_Usuarios.Acceso_9 = ACCESO_9;
        Obj_Entidad_Usuarios.Acceso_10 = ACCESO_10;
        Obj_Entidad_Usuarios.Acceso_11 = ACCESO_11;
        Obj_Entidad_Usuarios.Acceso_12 = ACCESO_12;
        Obj_Entidad_Usuarios.Acceso_13 = ACCESO_13;
        Obj_Entidad_Usuarios.Acceso_14 = ACCESO_14;
        Obj_Entidad_Usuarios.Acceso_15 = ACCESO_15;
        Obj_Entidad_Usuarios.Acceso_16 = ACCESO_16;
        Obj_Entidad_Usuarios.Acceso_17 = ACCESO_17;
        Obj_Entidad_Usuarios.Acceso_18 = ACCESO_18;
        Obj_Entidad_Usuarios.Acceso_19 = ACCESO_19;
        Obj_Entidad_Usuarios.Acceso_20 = ACCESO_20;
        Obj_Entidad_Usuarios.Acceso_21 = ACCESO_21;
        Obj_Entidad_Usuarios.Acceso_22 = ACCESO_22;
        Obj_Entidad_Usuarios.Acceso_23 = ACCESO_23;
        Obj_Entidad_Usuarios.Acceso_24 = ACCESO_24;
        Obj_Entidad_Usuarios.Acceso_25 = ACCESO_25;
        Obj_Entidad_Usuarios.Acceso_26 = ACCESO_26;
        Obj_Entidad_Usuarios.Acceso_27 = ACCESO_27;
        Obj_Entidad_Usuarios.Acceso_28 = ACCESO_28;
        Obj_Entidad_Usuarios.Acceso_29 = ACCESO_29;
        Obj_Entidad_Usuarios.Acceso_30 = ACCESO_30;

    }
    protected void Controles_a_Objeto_A()
    {
        var ACCESO_1 = 0;
        var ACCESO_2 = 0;
        var ACCESO_3 = 0;
        var ACCESO_4 = 0;
        var ACCESO_5 = 0;
        var ACCESO_6 = 0;
        var ACCESO_7 = 0;
        var ACCESO_8 = 0;
        var ACCESO_9 = 0;
        var ACCESO_10 = 0;
        var ACCESO_11 = 0;
        var ACCESO_12 = 0;
        var ACCESO_13 = 0;
        var ACCESO_14 = 0;
        var ACCESO_15 = 0;
        var ACCESO_16 = 0;
        var ACCESO_17 = 0;
        var ACCESO_18 = 0;
        var ACCESO_19 = 0;
        var ACCESO_20 = 0;
        var ACCESO_21 = 0;
        var ACCESO_22 = 0;
        var ACCESO_23 = 0;
        var ACCESO_24 = 0;
        var ACCESO_25 = 0;
        var ACCESO_26 = 0;
        var ACCESO_27 = 0;
        var ACCESO_28 = 0;
        var ACCESO_29 = 0;
        var ACCESO_30 = 0;

        string PERFIL = A_Perfil_Siriac.SelectedValue;
        if (PERFIL == "1")
        {

            if (CheckBox67.Checked == true) { ACCESO_1 = 1; } else { ACCESO_1 = 0; };
            if (CheckBox68.Checked == true) { ACCESO_2 = 1; } else { ACCESO_2 = 0; };
            if (CheckBox69.Checked == true) { ACCESO_3 = 1; } else { ACCESO_3 = 0; };
            if (CheckBox70.Checked == true) { ACCESO_4 = 1; } else { ACCESO_4 = 0; };
            if (CheckBox71.Checked == true) { ACCESO_5 = 1; } else { ACCESO_5 = 0; };
            if (CheckBox72.Checked == true) { ACCESO_6 = 1; } else { ACCESO_6 = 0; };
            if (CheckBox73.Checked == true) { ACCESO_7 = 1; } else { ACCESO_7 = 0; };
            if (CheckBox74.Checked == true) { ACCESO_8 = 1; } else { ACCESO_8 = 0; };
            if (CheckBox75.Checked == true) { ACCESO_9 = 1; } else { ACCESO_9 = 0; };
            if (CheckBox76.Checked == true) { ACCESO_10 = 1; } else { ACCESO_10 = 0; };
            if (CheckBox77.Checked == true) { ACCESO_11 = 1; } else { ACCESO_11 = 0; };
            if (CheckBox78.Checked == true) { ACCESO_12 = 1; } else { ACCESO_12 = 0; };
            if (CheckBox79.Checked == true) { ACCESO_13 = 1; } else { ACCESO_13 = 0; };
            if (CheckBox80.Checked == true) { ACCESO_14 = 1; } else { ACCESO_14 = 0; };
            if (CheckBox81.Checked == true) { ACCESO_15 = 1; } else { ACCESO_15 = 0; };
            if (CheckBox110.Checked == true) { ACCESO_16 = 1; } else { ACCESO_16 = 0; };
            if (CheckBox111.Checked == true) { ACCESO_17 = 1; } else { ACCESO_17 = 0; };
            if (CheckBox194.Checked == true) { ACCESO_18 = 1; } else { ACCESO_18 = 0; };
            if (CheckBox195.Checked == true) { ACCESO_19 = 1; } else { ACCESO_19 = 0; };
            if (CheckBox223.Checked == true) { ACCESO_20 = 1; } else { ACCESO_20 = 0; };
            if (CheckBox224.Checked == true) { ACCESO_21 = 1; } else { ACCESO_21 = 0; };

        }
        else if (PERFIL == "2")
        {

            if (CheckBox63.Checked == true) { ACCESO_1 = 1; } else { ACCESO_1 = 0; };
            if (CheckBox64.Checked == true) { ACCESO_2 = 1; } else { ACCESO_2 = 0; };
            if (CheckBox65.Checked == true) { ACCESO_3 = 1; } else { ACCESO_3 = 0; };
            if (CheckBox66.Checked == true) { ACCESO_4 = 1; } else { ACCESO_4 = 0; };
            if (CheckBox221.Checked == true) { ACCESO_5 = 1; } else { ACCESO_5 = 0; };
            if (CheckBox222.Checked == true) { ACCESO_6 = 1; } else { ACCESO_6 = 0; };

        }
        else if (PERFIL == "3")
        {

            if (CheckBox55.Checked == true) { ACCESO_1 = 1; } else { ACCESO_1 = 0; };
            if (CheckBox56.Checked == true) { ACCESO_2 = 1; } else { ACCESO_2 = 0; };
            if (CheckBox57.Checked == true) { ACCESO_3 = 1; } else { ACCESO_3 = 0; };
            if (CheckBox58.Checked == true) { ACCESO_4 = 1; } else { ACCESO_4 = 0; };
            if (CheckBox59.Checked == true) { ACCESO_5 = 1; } else { ACCESO_5 = 0; };
            if (CheckBox60.Checked == true) { ACCESO_6 = 1; } else { ACCESO_6 = 0; };
            if (CheckBox61.Checked == true) { ACCESO_7 = 1; } else { ACCESO_7 = 0; };
            if (CheckBox62.Checked == true) { ACCESO_8 = 1; } else { ACCESO_8 = 0; };
            if (CheckBox98.Checked == true) { ACCESO_9 = 1; } else { ACCESO_9 = 0; };
            if (CheckBox99.Checked == true) { ACCESO_10 = 1; } else { ACCESO_10 = 0; };
            if (CheckBox100.Checked == true) { ACCESO_11 = 1; } else { ACCESO_11 = 0; };
            if (CheckBox101.Checked == true) { ACCESO_12 = 1; } else { ACCESO_12 = 0; };
            if (CheckBox102.Checked == true) { ACCESO_13 = 1; } else { ACCESO_13 = 0; };
            if (CheckBox103.Checked == true) { ACCESO_14 = 1; } else { ACCESO_14 = 0; };
            if (CheckBox104.Checked == true) { ACCESO_15 = 1; } else { ACCESO_15 = 0; };
            if (CheckBox105.Checked == true) { ACCESO_16 = 1; } else { ACCESO_16 = 0; };
            if (CheckBox193.Checked == true) { ACCESO_17 = 1; } else { ACCESO_17 = 0; };
            if (CheckBox204.Checked == true) { ACCESO_18 = 1; } else { ACCESO_18 = 0; };
            if (CheckBox219.Checked == true) { ACCESO_19 = 1; } else { ACCESO_19 = 0; };
            if (CheckBox220.Checked == true) { ACCESO_20 = 1; } else { ACCESO_20 = 0; };
        };

        Obj_Entidad_Usuarios.Cedula = Convert.ToDouble(A_Cedula.Text);
        Obj_Entidad_Usuarios.Nombre = A_Nombre_Usuario.Text;
        Obj_Entidad_Usuarios.Usuario_RR = A_Usuario_RR.Text;
        Obj_Entidad_Usuarios.Usuario_Agendamiento = A_Usuario_Agendamiento.Text;
        Obj_Entidad_Usuarios.Contrasena = A_Contrasena.Text;
        Obj_Entidad_Usuarios.Id_Rol = Convert.ToInt16(A_Perfil_Siriac.SelectedValue);
        Obj_Entidad_Usuarios.Id_Nombre_Linea = Convert.ToInt16(A_Nombre_Linea_Siriac.SelectedValue);
        Obj_Entidad_Usuarios.Acceso_1 = ACCESO_1;
        Obj_Entidad_Usuarios.Acceso_2 = ACCESO_2;
        Obj_Entidad_Usuarios.Acceso_3 = ACCESO_3;
        Obj_Entidad_Usuarios.Acceso_4 = ACCESO_4;
        Obj_Entidad_Usuarios.Acceso_5 = ACCESO_5;
        Obj_Entidad_Usuarios.Acceso_6 = ACCESO_6;
        Obj_Entidad_Usuarios.Acceso_7 = ACCESO_7;
        Obj_Entidad_Usuarios.Acceso_8 = ACCESO_8;
        Obj_Entidad_Usuarios.Acceso_9 = ACCESO_9;
        Obj_Entidad_Usuarios.Acceso_10 = ACCESO_10;
        Obj_Entidad_Usuarios.Acceso_11 = ACCESO_11;
        Obj_Entidad_Usuarios.Acceso_12 = ACCESO_12;
        Obj_Entidad_Usuarios.Acceso_13 = ACCESO_13;
        Obj_Entidad_Usuarios.Acceso_14 = ACCESO_14;
        Obj_Entidad_Usuarios.Acceso_15 = ACCESO_15;
        Obj_Entidad_Usuarios.Acceso_16 = ACCESO_16;
        Obj_Entidad_Usuarios.Acceso_17 = ACCESO_17;
        Obj_Entidad_Usuarios.Acceso_18 = ACCESO_18;
        Obj_Entidad_Usuarios.Acceso_19 = ACCESO_19;
        Obj_Entidad_Usuarios.Acceso_20 = ACCESO_20;
        Obj_Entidad_Usuarios.Acceso_21 = ACCESO_21;
        Obj_Entidad_Usuarios.Acceso_22 = ACCESO_22;
        Obj_Entidad_Usuarios.Acceso_23 = ACCESO_23;
        Obj_Entidad_Usuarios.Acceso_24 = ACCESO_24;
        Obj_Entidad_Usuarios.Acceso_25 = ACCESO_25;
        Obj_Entidad_Usuarios.Acceso_26 = ACCESO_26;
        Obj_Entidad_Usuarios.Acceso_27 = ACCESO_27;
        Obj_Entidad_Usuarios.Acceso_28 = ACCESO_28;
        Obj_Entidad_Usuarios.Acceso_29 = ACCESO_29;
        Obj_Entidad_Usuarios.Acceso_30 = ACCESO_30;
    }
    protected void Registra_Usuario()
    {

        var V_Usuario_RR = Usuario_RR.Text;
        if (V_Usuario_RR == "")
        {
            string script4 = "mensaje4();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje4", script4, true);
            Limpiar();
        }
        else
        {

            var Guardar_Datos = -1;
            Controles_a_Objeto();
            Guardar_Datos = Obj_Neg_Usuarios.abcUsuarios("INSERTAR", Obj_Entidad_Usuarios);
            if (Guardar_Datos != -1)
            {
                string script3 = "mensaje3();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje3", script3, true);
                Limpiar();
            }
            else
            {

            }
        }
    }
    protected void Trae_Informacion_Holos_C()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Base_Personal.Cedula = C_Cedula.Text;
        dt = Obj_Neg_Base_Personal.Consulta_Informacion_Usuario(Obj_Entidad_Base_Personal.Cedula);

        if (dt.Tables[0].Rows.Count > 0)
        {

            C_Nombre_Usuario.Text = dt.Tables[0].Rows[0]["NOMBRE"].ToString();
            C_Aliado.Text = dt.Tables[0].Rows[0]["ALIADO"].ToString();
            C_Nombre_Linea.Text = dt.Tables[0].Rows[0]["NOMBRE_LINEA"].ToString();
            C_Usuario_RR.Text = dt.Tables[0].Rows[0]["USUARIO_RR"].ToString();
            C_Usuario_Agendamiento.Text = dt.Tables[0].Rows[0]["USUARIO_AGENDAMIENTO"].ToString();
            C_Usuario_Gerencia.Text = dt.Tables[0].Rows[0]["USUARIO_GERENCIA"].ToString();
            C_Estado.Text = dt.Tables[0].Rows[0]["ESTADO"].ToString();
            C_Canal.Text = dt.Tables[0].Rows[0]["CANAL"].ToString();
            C_Operacion.Text = dt.Tables[0].Rows[0]["OPERACION"].ToString();
            C_Grupo.Text = dt.Tables[0].Rows[0]["GRUPO"].ToString();
            C_Cargo.Text = dt.Tables[0].Rows[0]["CARGO"].ToString();
            C_Segmento.Text = dt.Tables[0].Rows[0]["SEGMENTO"].ToString();

            C_Nombre_Usuario.Enabled = false;
            C_Aliado.Enabled = false;
            C_Nombre_Linea.Enabled = false;
            C_Usuario_RR.Enabled = false;
            C_Usuario_Agendamiento.Enabled = false;
            C_Usuario_Gerencia.Enabled = false;
            C_Estado.Enabled = false;
            C_Canal.Enabled = false;
            C_Operacion.Enabled = false;
            C_Grupo.Enabled = false;
            C_Cargo.Enabled = false;
            C_Segmento.Enabled = false;

            Trae_Informacion_Siriac();

        }
        else
        {
            CleanControl(this.Controls);
        }
    }
    protected void Trae_Informacion_Holos_A(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Base_Personal.Cedula = A_Cedula.Text;
        dt = Obj_Neg_Base_Personal.Consulta_Informacion_Usuario(Obj_Entidad_Base_Personal.Cedula);

        if (dt.Tables[0].Rows.Count > 0)
        {

            A_Nombre_Usuario.Text = dt.Tables[0].Rows[0]["NOMBRE"].ToString();
            A_Aliado.Text = dt.Tables[0].Rows[0]["ALIADO"].ToString();
            A_Nombre_Linea.Text = dt.Tables[0].Rows[0]["NOMBRE_LINEA"].ToString();
            A_Usuario_RR.Text = dt.Tables[0].Rows[0]["USUARIO_RR"].ToString();
            A_Usuario_Agendamiento.Text = dt.Tables[0].Rows[0]["USUARIO_AGENDAMIENTO"].ToString();
            A_Usuario_Gerencia.Text = dt.Tables[0].Rows[0]["USUARIO_GERENCIA"].ToString();
            A_Estado.Text = dt.Tables[0].Rows[0]["ESTADO"].ToString();
            A_Canal.Text = dt.Tables[0].Rows[0]["CANAL"].ToString();
            A_Operacion.Text = dt.Tables[0].Rows[0]["OPERACION"].ToString();
            A_Grupo.Text = dt.Tables[0].Rows[0]["GRUPO"].ToString();
            A_Cargo.Text = dt.Tables[0].Rows[0]["CARGO"].ToString();
            A_Segmento.Text = dt.Tables[0].Rows[0]["SEGMENTO"].ToString();


            A_Nombre_Usuario.Enabled = false;
            A_Aliado.Enabled = false;
            A_Nombre_Linea.Enabled = false;
            A_Usuario_RR.Enabled = false;
            A_Usuario_Agendamiento.Enabled = false;
            A_Usuario_Gerencia.Enabled = false;
            A_Estado.Enabled = false;
            A_Canal.Enabled = false;
            A_Operacion.Enabled = false;
            A_Grupo.Enabled = false;
            A_Cargo.Enabled = false;
            A_Segmento.Enabled = false;

            Carga_Perfil_Usuarios();
            this.Trae_Informacion_Siriac_A(sender, e);

        }
        else
        {
            CleanControl(this.Controls);
        }
    }
    protected void Trae_Informacion_Siriac()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Usuarios.Cedula = Convert.ToDouble(C_Cedula.Text);
        dt = Obj_Neg_Usuarios.Consulta_Informacion_Usuario(Obj_Entidad_Usuarios.Cedula);

        if (dt.Tables[0].Rows.Count > 0)
        {

            C_Perfil_Siriac.Text = dt.Tables[0].Rows[0]["ROL_USUARIO"].ToString();
            C_Nombre_Linea_Siriac.Text = dt.Tables[0].Rows[0]["NOMBRE_LINEA"].ToString();
            Label86.Text = dt.Tables[0].Rows[0]["ACCESO_1"].ToString();
            Label87.Text = dt.Tables[0].Rows[0]["ACCESO_2"].ToString();
            Label88.Text = dt.Tables[0].Rows[0]["ACCESO_3"].ToString();
            Label89.Text = dt.Tables[0].Rows[0]["ACCESO_4"].ToString();
            Label90.Text = dt.Tables[0].Rows[0]["ACCESO_5"].ToString();
            Label91.Text = dt.Tables[0].Rows[0]["ACCESO_6"].ToString();
            Label92.Text = dt.Tables[0].Rows[0]["ACCESO_7"].ToString();
            Label93.Text = dt.Tables[0].Rows[0]["ACCESO_8"].ToString();
            Label94.Text = dt.Tables[0].Rows[0]["ACCESO_9"].ToString();
            Label95.Text = dt.Tables[0].Rows[0]["ACCESO_10"].ToString();
            Label96.Text = dt.Tables[0].Rows[0]["ACCESO_11"].ToString();
            Label97.Text = dt.Tables[0].Rows[0]["ACCESO_12"].ToString();
            Label98.Text = dt.Tables[0].Rows[0]["ACCESO_13"].ToString();
            Label99.Text = dt.Tables[0].Rows[0]["ACCESO_14"].ToString();
            Label100.Text = dt.Tables[0].Rows[0]["ACCESO_15"].ToString();
            Label101.Text = dt.Tables[0].Rows[0]["ACCESO_16"].ToString();
            Label102.Text = dt.Tables[0].Rows[0]["ACCESO_17"].ToString();
            Label103.Text = dt.Tables[0].Rows[0]["ACCESO_18"].ToString();
            Label104.Text = dt.Tables[0].Rows[0]["ACCESO_19"].ToString();
            Label105.Text = dt.Tables[0].Rows[0]["ACCESO_20"].ToString();
            Label106.Text = dt.Tables[0].Rows[0]["ACCESO_21"].ToString();
            Label107.Text = dt.Tables[0].Rows[0]["ACCESO_22"].ToString();
            Label108.Text = dt.Tables[0].Rows[0]["ACCESO_23"].ToString();
            Label109.Text = dt.Tables[0].Rows[0]["ACCESO_24"].ToString();
            Label110.Text = dt.Tables[0].Rows[0]["ACCESO_25"].ToString();
            Label111.Text = dt.Tables[0].Rows[0]["ACCESO_26"].ToString();
            Label112.Text = dt.Tables[0].Rows[0]["ACCESO_27"].ToString();
            Label113.Text = dt.Tables[0].Rows[0]["ACCESO_28"].ToString();
            Label114.Text = dt.Tables[0].Rows[0]["ACCESO_29"].ToString();
            Label115.Text = dt.Tables[0].Rows[0]["ACCESO_30"].ToString();

            Panel10.Visible = false;
            Panel11.Visible = false;
            Panel12.Visible = false;

            if (C_Perfil_Siriac.Text == "ADMINISTRADOR")
            {
                Panel12.Visible = true;
                if (Label86.Text == "1") { CheckBox40.Checked = true; } else { CheckBox40.Checked = false; };
                if (Label87.Text == "1") { CheckBox41.Checked = true; } else { CheckBox41.Checked = false; };
                if (Label88.Text == "1") { CheckBox42.Checked = true; } else { CheckBox42.Checked = false; };
                if (Label89.Text == "1") { CheckBox43.Checked = true; } else { CheckBox43.Checked = false; };
                if (Label90.Text == "1") { CheckBox44.Checked = true; } else { CheckBox44.Checked = false; };
                if (Label91.Text == "1") { CheckBox45.Checked = true; } else { CheckBox45.Checked = false; };
                if (Label92.Text == "1") { CheckBox46.Checked = true; } else { CheckBox46.Checked = false; };
                if (Label93.Text == "1") { CheckBox47.Checked = true; } else { CheckBox47.Checked = false; };
                if (Label94.Text == "1") { CheckBox48.Checked = true; } else { CheckBox48.Checked = false; };
                if (Label95.Text == "1") { CheckBox49.Checked = true; } else { CheckBox49.Checked = false; };
                if (Label96.Text == "1") { CheckBox50.Checked = true; } else { CheckBox50.Checked = false; };
                if (Label97.Text == "1") { CheckBox51.Checked = true; } else { CheckBox51.Checked = false; };
                if (Label98.Text == "1") { CheckBox52.Checked = true; } else { CheckBox52.Checked = false; };
                if (Label99.Text == "1") { CheckBox53.Checked = true; } else { CheckBox53.Checked = false; };
                if (Label100.Text == "1") { CheckBox54.Checked = true; } else { CheckBox54.Checked = false; };
                if (Label101.Text == "1") { CheckBox108.Checked = true; } else { CheckBox108.Checked = false; };
                if (Label102.Text == "1") { CheckBox109.Checked = true; } else { CheckBox109.Checked = false; };
                if (Label103.Text == "1") { CheckBox191.Checked = true; } else { CheckBox191.Checked = false; };
                if (Label104.Text == "1") { CheckBox192.Checked = true; } else { CheckBox192.Checked = false; };
                if (Label105.Text == "1") { CheckBox217.Checked = true; } else { CheckBox217.Checked = false; };
                if (Label106.Text == "1") { CheckBox218.Checked = true; } else { CheckBox218.Checked = false; };

            }
            else
                if (C_Perfil_Siriac.Text == "BACKOFFICE")
            {
                Panel11.Visible = true;
                if (Label86.Text == "1") { CheckBox36.Checked = true; } else { CheckBox36.Checked = false; };
                if (Label87.Text == "1") { CheckBox37.Checked = true; } else { CheckBox37.Checked = false; };
                if (Label88.Text == "1") { CheckBox38.Checked = true; } else { CheckBox38.Checked = false; };
                if (Label89.Text == "1") { CheckBox39.Checked = true; } else { CheckBox39.Checked = false; };
                if (Label90.Text == "1") { CheckBox215.Checked = true; } else { CheckBox215.Checked = false; };
                if (Label91.Text == "1") { CheckBox216.Checked = true; } else { CheckBox216.Checked = false; };

            }
            else
                    if (C_Perfil_Siriac.Text == "ASESOR")
            {
                Panel10.Visible = true;
                if (Label86.Text == "1") { CheckBox28.Checked = true; } else { CheckBox28.Checked = false; };
                if (Label87.Text == "1") { CheckBox29.Checked = true; } else { CheckBox29.Checked = false; };
                if (Label88.Text == "1") { CheckBox30.Checked = true; } else { CheckBox30.Checked = false; };
                if (Label89.Text == "1") { CheckBox31.Checked = true; } else { CheckBox31.Checked = false; };
                if (Label90.Text == "1") { CheckBox32.Checked = true; } else { CheckBox32.Checked = false; };
                if (Label91.Text == "1") { CheckBox33.Checked = true; } else { CheckBox33.Checked = false; };
                if (Label92.Text == "1") { CheckBox34.Checked = true; } else { CheckBox34.Checked = false; };
                if (Label93.Text == "1") { CheckBox35.Checked = true; } else { CheckBox35.Checked = false; };
                if (Label94.Text == "1") { CheckBox90.Checked = true; } else { CheckBox90.Checked = false; };
                if (Label95.Text == "1") { CheckBox91.Checked = true; } else { CheckBox91.Checked = false; };
                if (Label96.Text == "1") { CheckBox92.Checked = true; } else { CheckBox92.Checked = false; };
                if (Label97.Text == "1") { CheckBox93.Checked = true; } else { CheckBox93.Checked = false; };
                if (Label98.Text == "1") { CheckBox94.Checked = true; } else { CheckBox94.Checked = false; };
                if (Label99.Text == "1") { CheckBox95.Checked = true; } else { CheckBox95.Checked = false; };
                if (Label100.Text == "1") { CheckBox96.Checked = true; } else { CheckBox96.Checked = false; };
                if (Label101.Text == "1") { CheckBox97.Checked = true; } else { CheckBox97.Checked = false; };
                if (Label101.Text == "1") { CheckBox97.Checked = true; } else { CheckBox97.Checked = false; };
                if (Label102.Text == "1") { CheckBox190.Checked = true; } else { CheckBox190.Checked = false; };
                if (Label103.Text == "1") { CheckBox203.Checked = true; } else { CheckBox203.Checked = false; };
                if (Label104.Text == "1") { CheckBox213.Checked = true; } else { CheckBox213.Checked = false; };
                if (Label105.Text == "1") { CheckBox214.Checked = true; } else { CheckBox214.Checked = false; };
            };
        }
        else
        {

        }
    }
    protected void Trae_Informacion_Siriac_A(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Usuarios.Cedula = Convert.ToDouble(A_Cedula.Text);
        dt = Obj_Neg_Usuarios.Consulta_Informacion_Usuario(Obj_Entidad_Usuarios.Cedula);

        if (dt.Tables[0].Rows.Count > 0)
        {
            A_Perfil_Siriac.Text = dt.Tables[0].Rows[0]["ID_ROL"].ToString();
            A_Nombre_Linea_Siriac.Items.Clear();
            A_Nombre_Linea_Siriac.DataSource = dt;
            A_Nombre_Linea_Siriac.DataTextField = "NOMBRE_LINEA";
            A_Nombre_Linea_Siriac.DataValueField = "ID_NOMBRE_LINEA";
            A_Nombre_Linea_Siriac.DataBind();
            A_Contrasena.Text = dt.Tables[0].Rows[0]["CONTRASENA"].ToString();
            Label86.Text = dt.Tables[0].Rows[0]["ACCESO_1"].ToString();
            Label87.Text = dt.Tables[0].Rows[0]["ACCESO_2"].ToString();
            Label88.Text = dt.Tables[0].Rows[0]["ACCESO_3"].ToString();
            Label89.Text = dt.Tables[0].Rows[0]["ACCESO_4"].ToString();
            Label90.Text = dt.Tables[0].Rows[0]["ACCESO_5"].ToString();
            Label91.Text = dt.Tables[0].Rows[0]["ACCESO_6"].ToString();
            Label92.Text = dt.Tables[0].Rows[0]["ACCESO_7"].ToString();
            Label93.Text = dt.Tables[0].Rows[0]["ACCESO_8"].ToString();
            Label94.Text = dt.Tables[0].Rows[0]["ACCESO_9"].ToString();
            Label95.Text = dt.Tables[0].Rows[0]["ACCESO_10"].ToString();
            Label96.Text = dt.Tables[0].Rows[0]["ACCESO_11"].ToString();
            Label97.Text = dt.Tables[0].Rows[0]["ACCESO_12"].ToString();
            Label98.Text = dt.Tables[0].Rows[0]["ACCESO_13"].ToString();
            Label99.Text = dt.Tables[0].Rows[0]["ACCESO_14"].ToString();
            Label100.Text = dt.Tables[0].Rows[0]["ACCESO_15"].ToString();
            Label101.Text = dt.Tables[0].Rows[0]["ACCESO_16"].ToString();
            Label102.Text = dt.Tables[0].Rows[0]["ACCESO_17"].ToString();
            Label103.Text = dt.Tables[0].Rows[0]["ACCESO_18"].ToString();
            Label104.Text = dt.Tables[0].Rows[0]["ACCESO_19"].ToString();
            Label105.Text = dt.Tables[0].Rows[0]["ACCESO_20"].ToString();
            Label106.Text = dt.Tables[0].Rows[0]["ACCESO_21"].ToString();
            Label107.Text = dt.Tables[0].Rows[0]["ACCESO_22"].ToString();
            Label108.Text = dt.Tables[0].Rows[0]["ACCESO_23"].ToString();
            Label109.Text = dt.Tables[0].Rows[0]["ACCESO_24"].ToString();
            Label110.Text = dt.Tables[0].Rows[0]["ACCESO_25"].ToString();
            Label111.Text = dt.Tables[0].Rows[0]["ACCESO_26"].ToString();
            Label112.Text = dt.Tables[0].Rows[0]["ACCESO_27"].ToString();
            Label113.Text = dt.Tables[0].Rows[0]["ACCESO_28"].ToString();
            Label114.Text = dt.Tables[0].Rows[0]["ACCESO_29"].ToString();
            Label115.Text = dt.Tables[0].Rows[0]["ACCESO_30"].ToString();

            Panel14.Visible = false;
            Panel15.Visible = false;
            Panel16.Visible = false;

            if (A_Perfil_Siriac.SelectedValue == "1")
            {
                Panel16.Visible = true;
                if (Label86.Text == "1") { CheckBox67.Checked = true; } else { CheckBox40.Checked = false; };
                if (Label87.Text == "1") { CheckBox68.Checked = true; } else { CheckBox41.Checked = false; };
                if (Label88.Text == "1") { CheckBox69.Checked = true; } else { CheckBox42.Checked = false; };
                if (Label89.Text == "1") { CheckBox70.Checked = true; } else { CheckBox43.Checked = false; };
                if (Label90.Text == "1") { CheckBox71.Checked = true; } else { CheckBox44.Checked = false; };
                if (Label91.Text == "1") { CheckBox72.Checked = true; } else { CheckBox45.Checked = false; };
                if (Label92.Text == "1") { CheckBox73.Checked = true; } else { CheckBox46.Checked = false; };
                if (Label93.Text == "1") { CheckBox74.Checked = true; } else { CheckBox47.Checked = false; };
                if (Label94.Text == "1") { CheckBox75.Checked = true; } else { CheckBox48.Checked = false; };
                if (Label95.Text == "1") { CheckBox76.Checked = true; } else { CheckBox49.Checked = false; };
                if (Label96.Text == "1") { CheckBox77.Checked = true; } else { CheckBox50.Checked = false; };
                if (Label97.Text == "1") { CheckBox78.Checked = true; } else { CheckBox51.Checked = false; };
                if (Label98.Text == "1") { CheckBox79.Checked = true; } else { CheckBox52.Checked = false; };
                if (Label99.Text == "1") { CheckBox80.Checked = true; } else { CheckBox53.Checked = false; };
                if (Label100.Text == "1") { CheckBox81.Checked = true; } else { CheckBox54.Checked = false; };
                if (Label101.Text == "1") { CheckBox110.Checked = true; } else { CheckBox110.Checked = false; };
                if (Label102.Text == "1") { CheckBox111.Checked = true; } else { CheckBox111.Checked = false; };
                if (Label103.Text == "1") { CheckBox194.Checked = true; } else { CheckBox194.Checked = false; };
                if (Label104.Text == "1") { CheckBox195.Checked = true; } else { CheckBox195.Checked = false; };
                if (Label105.Text == "1") { CheckBox223.Checked = true; } else { CheckBox223.Checked = false; };
                if (Label106.Text == "1") { CheckBox224.Checked = true; } else { CheckBox224.Checked = false; };

            }
            else
                if (A_Perfil_Siriac.SelectedValue == "2")
            {
                Panel15.Visible = true;
                if (Label86.Text == "1") { CheckBox63.Checked = true; } else { CheckBox63.Checked = false; };
                if (Label87.Text == "1") { CheckBox64.Checked = true; } else { CheckBox64.Checked = false; };
                if (Label88.Text == "1") { CheckBox65.Checked = true; } else { CheckBox65.Checked = false; };
                if (Label89.Text == "1") { CheckBox66.Checked = true; } else { CheckBox66.Checked = false; };
                if (Label90.Text == "1") { CheckBox221.Checked = true; } else { CheckBox221.Checked = false; };
                if (Label91.Text == "1") { CheckBox222.Checked = true; } else { CheckBox222.Checked = false; };

            }
            else
                    if (A_Perfil_Siriac.SelectedValue == "3")
            {
                Panel14.Visible = true;
                if (Label86.Text == "1") { CheckBox55.Checked = true; } else { CheckBox55.Checked = false; };
                if (Label87.Text == "1") { CheckBox56.Checked = true; } else { CheckBox56.Checked = false; };
                if (Label88.Text == "1") { CheckBox57.Checked = true; } else { CheckBox57.Checked = false; };
                if (Label89.Text == "1") { CheckBox58.Checked = true; } else { CheckBox58.Checked = false; };
                if (Label90.Text == "1") { CheckBox59.Checked = true; } else { CheckBox59.Checked = false; };
                if (Label91.Text == "1") { CheckBox60.Checked = true; } else { CheckBox60.Checked = false; };
                if (Label92.Text == "1") { CheckBox61.Checked = true; } else { CheckBox61.Checked = false; };
                if (Label93.Text == "1") { CheckBox62.Checked = true; } else { CheckBox62.Checked = false; };
                if (Label94.Text == "1") { CheckBox98.Checked = true; } else { CheckBox98.Checked = false; };
                if (Label95.Text == "1") { CheckBox99.Checked = true; } else { CheckBox99.Checked = false; };
                if (Label96.Text == "1") { CheckBox100.Checked = true; } else { CheckBox100.Checked = false; };
                if (Label97.Text == "1") { CheckBox101.Checked = true; } else { CheckBox101.Checked = false; };
                if (Label98.Text == "1") { CheckBox102.Checked = true; } else { CheckBox102.Checked = false; };
                if (Label99.Text == "1") { CheckBox103.Checked = true; } else { CheckBox103.Checked = false; };
                if (Label100.Text == "1") { CheckBox104.Checked = true; } else { CheckBox104.Checked = false; };
                if (Label101.Text == "1") { CheckBox105.Checked = true; } else { CheckBox105.Checked = false; };
                if (Label102.Text == "1") { CheckBox193.Checked = true; } else { CheckBox193.Checked = false; };
                if (Label103.Text == "1") { CheckBox204.Checked = true; } else { CheckBox204.Checked = false; };
                if (Label104.Text == "1") { CheckBox219.Checked = true; } else { CheckBox219.Checked = false; };
                if (Label105.Text == "1") { CheckBox220.Checked = true; } else { CheckBox220.Checked = false; };
            };
        }
        else
        {

        }

    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (Cargar_Excel.HasFile)
        {
            btnUpload.Enabled = false;
            string FileName = Path.GetFileName(Cargar_Excel.PostedFile.FileName);
            string Extension = Path.GetExtension(Cargar_Excel.PostedFile.FileName);
            //string FolderPath = ConfigurationManager.AppSettings["/Files/"];

            string FilePath = Server.MapPath(".") + "/Archivos/" + Cargar_Excel.FileName;
            Cargar_Excel.SaveAs(FilePath);
            

            DataSet d;
            string conStr = "";
            switch (Extension)
            {
                case ".xls": //Excel 97-03
                    conStr = ConfigurationManager.ConnectionStrings["Excel03ConString"].ConnectionString;
                    break;
                case ".xlsx": //Excel 07
                    conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
                    break;
            }
            conStr = String.Format(conStr, FilePath);
            //Label500.Text = conStr;
            OleDbConnection connExcel = new OleDbConnection(conStr);
            OleDbCommand cmdExcel = new OleDbCommand();
            OleDbDataAdapter oda = new OleDbDataAdapter();
            d = new DataSet();
            cmdExcel.Connection = connExcel;


            //Get the name of First Sheet
            connExcel.Open();
            DataTable dtExcelSchema;
            dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string SheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
            connExcel.Close();

            //Read Data from First Sheet
            connExcel.Open();
            cmdExcel.CommandText = "SELECT * From [" + SheetName + "]";
            oda.SelectCommand = cmdExcel;
            oda.Fill(d);
            connExcel.Close();

            //Bind Data to GridView
            //GridView1.Caption = Path.GetFileName(FilePath);
            GridView1.DataSource = d.Tables[0];
            GridView1.DataBind();
            Panel17.Visible = true;
            Panel18.Visible = true;
            File.Delete(FilePath);

            foreach (GridViewRow rows in GridView1.Rows)
            {
                DataSet dusu = new DataSet();
                string cedulas = rows.Cells[0].Text;
                if (cedulas != "&nbsp;")
                {
                    Obj_Entidad_Usuarios.Cedulas = cedulas.ToString();
                    dusu = Obj_Neg_Usuarios.Consulta_Usuarios_Cedula(Obj_Entidad_Usuarios.Cedulas);

                    if (dusu.Tables[0].Rows.Count > 0)
                    {
                        rows.Cells[1].Text = dusu.Tables[0].Rows[0]["NOMBRE"].ToString();
                        rows.Cells[2].Text = "------";
                        rows.Cells[3].Text = "------";
                        rows.Cells[4].Text = "------";
                        rows.Cells[5].Text = "------";
                        rows.Cells[6].Text = "------";
                        rows.Cells[7].Text = "------";
                        rows.Cells[8].Text = "------";
                        rows.Cells[9].Text = "------";
                        rows.Cells[10].Text = "------";
                        rows.Cells[11].Text = "------";
                        rows.Cells[12].Text = "------";
                        rows.Cells[13].Text = "YA ESTA REGISTRADO EN SIRIAC";
                    }
                    else
                    {
                        Carga_Perfil_Usuarios_masivo();
                        this.Perfil_Masivo_SelectedIndexChanged(sender, e);
                        DataSet dU = new DataSet();
                        Obj_Entidad_Base_Personal.Cedula = cedulas;
                        dU = Obj_Neg_Base_Personal.Consulta_Informacion_Usuario(Obj_Entidad_Base_Personal.Cedula);

                        if (dU.Tables[0].Rows.Count > 0)
                        {

                            rows.Cells[1].Text = dU.Tables[0].Rows[0]["NOMBRE"].ToString();
                            rows.Cells[2].Text = dU.Tables[0].Rows[0]["ALIADO"].ToString();
                            rows.Cells[3].Text = dU.Tables[0].Rows[0]["NOMBRE_LINEA"].ToString();
                            rows.Cells[4].Text = dU.Tables[0].Rows[0]["USUARIO_RR"].ToString();
                            rows.Cells[5].Text = dU.Tables[0].Rows[0]["USUARIO_AGENDAMIENTO"].ToString();
                            rows.Cells[6].Text = dU.Tables[0].Rows[0]["USUARIO_GERENCIA"].ToString();
                            rows.Cells[7].Text = dU.Tables[0].Rows[0]["ESTADO"].ToString();
                            rows.Cells[8].Text = dU.Tables[0].Rows[0]["CANAL"].ToString();
                            rows.Cells[9].Text = dU.Tables[0].Rows[0]["OPERACION"].ToString();
                            rows.Cells[10].Text = dU.Tables[0].Rows[0]["GRUPO"].ToString();
                            rows.Cells[11].Text = dU.Tables[0].Rows[0]["CARGO"].ToString();
                            rows.Cells[12].Text = dU.Tables[0].Rows[0]["SEGMENTO"].ToString();
                            rows.Cells[13].Text = "SIN REGISTRAR EN SIRIAC";

                        }
                        else
                        {
                            rows.Cells[1].Text = "------";
                            rows.Cells[2].Text = "------";
                            rows.Cells[3].Text = "------";
                            rows.Cells[4].Text = "------";
                            rows.Cells[5].Text = "------";
                            rows.Cells[6].Text = "------";
                            rows.Cells[7].Text = "------";
                            rows.Cells[8].Text = "------";
                            rows.Cells[9].Text = "------";
                            rows.Cells[10].Text = "------";
                            rows.Cells[11].Text = "------";
                            rows.Cells[12].Text = "------";
                            rows.Cells[13].Text = "USUARIO NO EXISTE EN HOLOS";
                        }
                    }
                }

            }
        }
        btnUpload.Enabled = true;
    }
    protected void Carga_Perfil_Usuarios_masivo()
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Perfiles.Perfil_Usuario();

        if (dt.Tables[0].Rows.Count > 0)
        {

            Perfil_Masivo.DataSource = dt;
            Perfil_Masivo.DataTextField = "DESCRIPCION";
            Perfil_Masivo.DataValueField = "ID_ROL";
            Perfil_Masivo.DataBind();

        }
    }
    protected void Perfil_Masivo_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel19.Visible = false;
        Panel20.Visible = false;
        Panel21.Visible = false;
        var PERFIL = Perfil_Masivo.SelectedValue;

        if (PERFIL == "1")
        {
            Carga_Nombre__Linea_Asesor();
            Panel21.Visible = true;
        }
        else if (PERFIL == "2")
        {
            Carga_Nombre__Linea_Celula();
            Panel20.Visible = true;
        }
        else if (PERFIL == "3")
        {
            Carga_Nombre__Linea_Asesor();
            Panel19.Visible = true;
        }
    }
    protected void Crear_Usuario_Masivo_Click(object sender, EventArgs e)
    {
        if (Panel17.Visible == false)
        {
            string script5 = "mensaje9();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje9", script5, true);
        }
        else
        {
            Registra_Usuarios_Masivo();
            string script3 = "mensaje8();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje8", script3, true);
            GridView1.DataBind();
            //Perfil_Masivo.Text = "";
            //Perfil_Masivo.SelectedValue = "";
            //Masivo_Nombre_Linea.Text = "";
            //Masivo_Nombre_Linea.SelectedValue = "";
            //Limpiar();
            Contrasena_M.Text = "";
            Panel17.Visible = false;
            Panel18.Visible = false;
            Panel19.Visible = false;
            Panel20.Visible = false;
            Panel21.Visible = false;

        }
    }
    protected void Registra_Usuarios_Masivo()
    {
        foreach (GridViewRow rows in GridView1.Rows)
        {
            string cedulas = rows.Cells[0].Text;
            if (cedulas != "&nbsp;")
            {
                if (rows.Cells[13].Text == "USUARIO NO EXISTE EN HOLOS" || rows.Cells[13].Text == "YA ESTA REGISTRADO EN SIRIAC")
                {

                }
                else
                {
                    var Guardar_Datos = -1;
                    var ACCESO_1 = 0;
                    var ACCESO_2 = 0;
                    var ACCESO_3 = 0;
                    var ACCESO_4 = 0;
                    var ACCESO_5 = 0;
                    var ACCESO_6 = 0;
                    var ACCESO_7 = 0;
                    var ACCESO_8 = 0;
                    var ACCESO_9 = 0;
                    var ACCESO_10 = 0;
                    var ACCESO_11 = 0;
                    var ACCESO_12 = 0;
                    var ACCESO_13 = 0;
                    var ACCESO_14 = 0;
                    var ACCESO_15 = 0;
                    var ACCESO_16 = 0;
                    var ACCESO_17 = 0;
                    var ACCESO_18 = 0;
                    var ACCESO_19 = 0;
                    var ACCESO_20 = 0;
                    var ACCESO_21 = 0;
                    var ACCESO_22 = 0;
                    var ACCESO_23 = 0;
                    var ACCESO_24 = 0;
                    var ACCESO_25 = 0;
                    var ACCESO_26 = 0;
                    var ACCESO_27 = 0;
                    var ACCESO_28 = 0;
                    var ACCESO_29 = 0;
                    var ACCESO_30 = 0;

                    string PERFIL_M = Perfil_Masivo.SelectedValue;
                    if (PERFIL_M == "1")
                    {

                        if (CheckBox132.Checked == true) { ACCESO_1 = 1; } else { ACCESO_1 = 0; };
                        if (CheckBox133.Checked == true) { ACCESO_2 = 1; } else { ACCESO_2 = 0; };
                        if (CheckBox134.Checked == true) { ACCESO_3 = 1; } else { ACCESO_3 = 0; };
                        if (CheckBox135.Checked == true) { ACCESO_4 = 1; } else { ACCESO_4 = 0; };
                        if (CheckBox136.Checked == true) { ACCESO_5 = 1; } else { ACCESO_5 = 0; };
                        if (CheckBox137.Checked == true) { ACCESO_6 = 1; } else { ACCESO_6 = 0; };
                        if (CheckBox138.Checked == true) { ACCESO_7 = 1; } else { ACCESO_7 = 0; };
                        if (CheckBox139.Checked == true) { ACCESO_8 = 1; } else { ACCESO_8 = 0; };
                        if (CheckBox140.Checked == true) { ACCESO_9 = 1; } else { ACCESO_9 = 0; };
                        if (CheckBox141.Checked == true) { ACCESO_10 = 1; } else { ACCESO_10 = 0; };
                        if (CheckBox142.Checked == true) { ACCESO_11 = 1; } else { ACCESO_11 = 0; };
                        if (CheckBox143.Checked == true) { ACCESO_12 = 1; } else { ACCESO_12 = 0; };
                        if (CheckBox144.Checked == true) { ACCESO_13 = 1; } else { ACCESO_13 = 0; };
                        if (CheckBox145.Checked == true) { ACCESO_14 = 1; } else { ACCESO_14 = 0; };
                        if (CheckBox146.Checked == true) { ACCESO_15 = 1; } else { ACCESO_15 = 0; };
                        if (CheckBox147.Checked == true) { ACCESO_16 = 1; } else { ACCESO_16 = 0; };
                        if (CheckBox148.Checked == true) { ACCESO_17 = 1; } else { ACCESO_17 = 0; };
                        if (CheckBox200.Checked == true) { ACCESO_18 = 1; } else { ACCESO_18 = 0; };
                        if (CheckBox201.Checked == true) { ACCESO_19 = 1; } else { ACCESO_19 = 0; };
                        if (CheckBox235.Checked == true) { ACCESO_20 = 1; } else { ACCESO_20 = 0; };
                        if (CheckBox236.Checked == true) { ACCESO_21 = 1; } else { ACCESO_21 = 0; };
                    }
                    else if (PERFIL_M == "2")
                    {
                        if (CheckBox128.Checked == true) { ACCESO_1 = 1; } else { ACCESO_1 = 0; };
                        if (CheckBox129.Checked == true) { ACCESO_2 = 1; } else { ACCESO_2 = 0; };
                        if (CheckBox130.Checked == true) { ACCESO_3 = 1; } else { ACCESO_3 = 0; };
                        if (CheckBox131.Checked == true) { ACCESO_4 = 1; } else { ACCESO_4 = 0; };
                        if (CheckBox233.Checked == true) { ACCESO_5 = 1; } else { ACCESO_5 = 0; };
                        if (CheckBox234.Checked == true) { ACCESO_6 = 1; } else { ACCESO_6 = 0; };

                    }
                    else if (PERFIL_M == "3")
                    {

                        if (CheckBox112.Checked == true) { ACCESO_1 = 1; } else { ACCESO_1 = 0; };
                        if (CheckBox113.Checked == true) { ACCESO_2 = 1; } else { ACCESO_2 = 0; };
                        if (CheckBox114.Checked == true) { ACCESO_3 = 1; } else { ACCESO_3 = 0; };
                        if (CheckBox115.Checked == true) { ACCESO_4 = 1; } else { ACCESO_4 = 0; };
                        if (CheckBox116.Checked == true) { ACCESO_5 = 1; } else { ACCESO_5 = 0; };
                        if (CheckBox117.Checked == true) { ACCESO_6 = 1; } else { ACCESO_6 = 0; };
                        if (CheckBox118.Checked == true) { ACCESO_7 = 1; } else { ACCESO_7 = 0; };
                        if (CheckBox119.Checked == true) { ACCESO_8 = 1; } else { ACCESO_8 = 0; };
                        if (CheckBox120.Checked == true) { ACCESO_9 = 1; } else { ACCESO_9 = 0; };
                        if (CheckBox121.Checked == true) { ACCESO_10 = 1; } else { ACCESO_10 = 0; };
                        if (CheckBox122.Checked == true) { ACCESO_11 = 1; } else { ACCESO_11 = 0; };
                        if (CheckBox123.Checked == true) { ACCESO_12 = 1; } else { ACCESO_12 = 0; };
                        if (CheckBox124.Checked == true) { ACCESO_13 = 1; } else { ACCESO_13 = 0; };
                        if (CheckBox125.Checked == true) { ACCESO_14 = 1; } else { ACCESO_14 = 0; };
                        if (CheckBox126.Checked == true) { ACCESO_15 = 1; } else { ACCESO_15 = 0; };
                        if (CheckBox127.Checked == true) { ACCESO_16 = 1; } else { ACCESO_16 = 0; };
                        if (CheckBox199.Checked == true) { ACCESO_17 = 1; } else { ACCESO_17 = 0; };
                        if (CheckBox231.Checked == true) { ACCESO_19 = 1; } else { ACCESO_19 = 0; };
                        if (CheckBox232.Checked == true) { ACCESO_20 = 1; } else { ACCESO_20 = 0; };
                    };

                    Obj_Entidad_Usuarios.Cedula = Convert.ToDouble(rows.Cells[0].Text);
                    Obj_Entidad_Usuarios.Nombre = rows.Cells[1].Text;
                    Obj_Entidad_Usuarios.Usuario_RR = rows.Cells[4].Text;
                    Obj_Entidad_Usuarios.Usuario_Agendamiento = rows.Cells[5].Text;
                    Obj_Entidad_Usuarios.Contrasena = Contrasena_M.Text;
                    Obj_Entidad_Usuarios.Id_Rol = Convert.ToInt16(Perfil_Masivo.SelectedValue);
                    Obj_Entidad_Usuarios.Id_Nombre_Linea = Convert.ToInt16(Masivo_Nombre_Linea.SelectedValue);
                    Obj_Entidad_Usuarios.Acceso_1 = ACCESO_1;
                    Obj_Entidad_Usuarios.Acceso_2 = ACCESO_2;
                    Obj_Entidad_Usuarios.Acceso_3 = ACCESO_3;
                    Obj_Entidad_Usuarios.Acceso_4 = ACCESO_4;
                    Obj_Entidad_Usuarios.Acceso_5 = ACCESO_5;
                    Obj_Entidad_Usuarios.Acceso_6 = ACCESO_6;
                    Obj_Entidad_Usuarios.Acceso_7 = ACCESO_7;
                    Obj_Entidad_Usuarios.Acceso_8 = ACCESO_8;
                    Obj_Entidad_Usuarios.Acceso_9 = ACCESO_9;
                    Obj_Entidad_Usuarios.Acceso_10 = ACCESO_10;
                    Obj_Entidad_Usuarios.Acceso_11 = ACCESO_11;
                    Obj_Entidad_Usuarios.Acceso_12 = ACCESO_12;
                    Obj_Entidad_Usuarios.Acceso_13 = ACCESO_13;
                    Obj_Entidad_Usuarios.Acceso_14 = ACCESO_14;
                    Obj_Entidad_Usuarios.Acceso_15 = ACCESO_15;
                    Obj_Entidad_Usuarios.Acceso_16 = ACCESO_16;
                    Obj_Entidad_Usuarios.Acceso_17 = ACCESO_17;
                    Obj_Entidad_Usuarios.Acceso_18 = ACCESO_18;
                    Obj_Entidad_Usuarios.Acceso_19 = ACCESO_19;
                    Obj_Entidad_Usuarios.Acceso_20 = ACCESO_20;
                    Obj_Entidad_Usuarios.Acceso_21 = ACCESO_21;
                    Obj_Entidad_Usuarios.Acceso_22 = ACCESO_22;
                    Obj_Entidad_Usuarios.Acceso_23 = ACCESO_23;
                    Obj_Entidad_Usuarios.Acceso_24 = ACCESO_24;
                    Obj_Entidad_Usuarios.Acceso_25 = ACCESO_25;
                    Obj_Entidad_Usuarios.Acceso_26 = ACCESO_26;
                    Obj_Entidad_Usuarios.Acceso_27 = ACCESO_27;
                    Obj_Entidad_Usuarios.Acceso_28 = ACCESO_28;
                    Obj_Entidad_Usuarios.Acceso_29 = ACCESO_29;
                    Obj_Entidad_Usuarios.Acceso_30 = ACCESO_30;

                    Guardar_Datos = Obj_Neg_Usuarios.abcUsuarios("INSERTAR", Obj_Entidad_Usuarios);
                    if (Guardar_Datos != -1)
                    {
                    }
                    else
                    {

                    }
                }
            }
        }

    }
    protected void Carga_Aliado()
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Perfiles.Aliado_Usuario();

        if (dt.Tables[0].Rows.Count > 0)
        {

            Aliado_D.DataSource = dt;
            Aliado_D.DataTextField = "ALIADO";
            Aliado_D.DataValueField = "ALIADO";
            Aliado_D.DataBind();
        }
    }
    protected void Perfil_Usuario_Masivo_Accesos()
    {
        DataSet dt = new DataSet();
        dt = Obj_Neg_Perfiles.Perfil_Usuario();

        if (dt.Tables[0].Rows.Count > 0)
        {

            Perfil_A_Masivo.DataSource = dt;
            Perfil_A_Masivo.DataTextField = "DESCRIPCION";
            Perfil_A_Masivo.DataValueField = "ID_ROL";
            Perfil_A_Masivo.DataBind();

            Perfil_A_Cambiar.DataSource = dt;
            Perfil_A_Cambiar.DataTextField = "DESCRIPCION";
            Perfil_A_Cambiar.DataValueField = "ID_ROL";
            Perfil_A_Cambiar.DataBind();

        }
    }
    protected void Buscar_Usuarios_Click(object sender, EventArgs e)
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Usuarios.Aliado = Aliado_D.SelectedValue;
        Obj_Entidad_Usuarios.Id_rol = Perfil_A_Masivo.SelectedValue;

        dt = Obj_Neg_Usuarios.Selecciona_Usuarios_Masivo(Obj_Entidad_Usuarios.Aliado, Obj_Entidad_Usuarios.Id_rol);
        if (dt.Tables[0].Rows.Count > 0)
        {
            Panel22.Visible = true;
            Panel23.Visible = true;
            GV_Usuarios_Masivos.DataSource = dt.Tables[0];
            GV_Usuarios_Masivos.DataBind();
            Accesos_Masivo_SelectedIndexChanged(sender, e);
        }
        else
        {
            GV_Usuarios_Masivos.DataSource = null;
            GV_Usuarios_Masivos.DataBind();
            string script1 = "mensaje10();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje10", script1, true);
        }

    }
    protected void Activa_Click(object sender, EventArgs e)
    {
        Carga_Aliado();
        Perfil_Usuario_Masivo_Accesos();

    }
    protected void Accesos_Masivo_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel24.Visible = false;
        Panel25.Visible = false;
        Panel26.Visible = false;
        var PERFIL = Perfil_A_Cambiar.SelectedValue;

        if (PERFIL == "1")
        {
            Panel26.Visible = true;
        }
        else if (PERFIL == "2")
        {
            Panel25.Visible = true;
        }
        else if (PERFIL == "3")
        {
            Panel24.Visible = true;
        }
    }
    protected void Actualizar_Usuarios_Click(object sender, EventArgs e)
    {
        if (Panel22.Visible == false)
        {
            string script12 = "mensaje12();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje12", script12, true);
        }
        else
        {
            foreach (GridViewRow rows in GV_Usuarios_Masivos.Rows)
            {
                bool Seleccionado = false;
                Seleccionado = ((CheckBox)rows.FindControl("CheckBox186")).Checked;
                if (Seleccionado == true)
                {
                    var Guardar_Datos = -1;
                    var ACCESO_1 = 0;
                    var ACCESO_2 = 0;
                    var ACCESO_3 = 0;
                    var ACCESO_4 = 0;
                    var ACCESO_5 = 0;
                    var ACCESO_6 = 0;
                    var ACCESO_7 = 0;
                    var ACCESO_8 = 0;
                    var ACCESO_9 = 0;
                    var ACCESO_10 = 0;
                    var ACCESO_11 = 0;
                    var ACCESO_12 = 0;
                    var ACCESO_13 = 0;
                    var ACCESO_14 = 0;
                    var ACCESO_15 = 0;
                    var ACCESO_16 = 0;
                    var ACCESO_17 = 0;
                    var ACCESO_18 = 0;
                    var ACCESO_19 = 0;
                    var ACCESO_20 = 0;
                    var ACCESO_21 = 0;
                    var ACCESO_22 = 0;
                    var ACCESO_23 = 0;
                    var ACCESO_24 = 0;
                    var ACCESO_25 = 0;
                    var ACCESO_26 = 0;
                    var ACCESO_27 = 0;
                    var ACCESO_28 = 0;
                    var ACCESO_29 = 0;
                    var ACCESO_30 = 0;

                    string PERFIL_M = Perfil_A_Cambiar.SelectedValue;
                    if (PERFIL_M == "1")
                    {

                        if (CheckBox169.Checked == true) { ACCESO_1 = 1; } else { ACCESO_1 = 0; };
                        if (CheckBox170.Checked == true) { ACCESO_2 = 1; } else { ACCESO_2 = 0; };
                        if (CheckBox171.Checked == true) { ACCESO_3 = 1; } else { ACCESO_3 = 0; };
                        if (CheckBox172.Checked == true) { ACCESO_4 = 1; } else { ACCESO_4 = 0; };
                        if (CheckBox173.Checked == true) { ACCESO_5 = 1; } else { ACCESO_5 = 0; };
                        if (CheckBox174.Checked == true) { ACCESO_6 = 1; } else { ACCESO_6 = 0; };
                        if (CheckBox175.Checked == true) { ACCESO_7 = 1; } else { ACCESO_7 = 0; };
                        if (CheckBox176.Checked == true) { ACCESO_8 = 1; } else { ACCESO_8 = 0; };
                        if (CheckBox177.Checked == true) { ACCESO_9 = 1; } else { ACCESO_9 = 0; };
                        if (CheckBox178.Checked == true) { ACCESO_10 = 1; } else { ACCESO_10 = 0; };
                        if (CheckBox179.Checked == true) { ACCESO_11 = 1; } else { ACCESO_11 = 0; };
                        if (CheckBox180.Checked == true) { ACCESO_12 = 1; } else { ACCESO_12 = 0; };
                        if (CheckBox181.Checked == true) { ACCESO_13 = 1; } else { ACCESO_13 = 0; };
                        if (CheckBox182.Checked == true) { ACCESO_14 = 1; } else { ACCESO_14 = 0; };
                        if (CheckBox183.Checked == true) { ACCESO_15 = 1; } else { ACCESO_15 = 0; };
                        if (CheckBox184.Checked == true) { ACCESO_16 = 1; } else { ACCESO_16 = 0; };
                        if (CheckBox185.Checked == true) { ACCESO_17 = 1; } else { ACCESO_17 = 0; };
                        if (CheckBox197.Checked == true) { ACCESO_18 = 1; } else { ACCESO_18 = 0; };
                        if (CheckBox198.Checked == true) { ACCESO_19 = 1; } else { ACCESO_19 = 0; };
                        if (CheckBox229.Checked == true) { ACCESO_20 = 1; } else { ACCESO_20 = 0; };
                        if (CheckBox230.Checked == true) { ACCESO_21 = 1; } else { ACCESO_21 = 0; };

                    }
                    else if (PERFIL_M == "2")
                    {
                        if (CheckBox165.Checked == true) { ACCESO_1 = 1; } else { ACCESO_1 = 0; };
                        if (CheckBox166.Checked == true) { ACCESO_2 = 1; } else { ACCESO_2 = 0; };
                        if (CheckBox167.Checked == true) { ACCESO_3 = 1; } else { ACCESO_3 = 0; };
                        if (CheckBox168.Checked == true) { ACCESO_4 = 1; } else { ACCESO_4 = 0; };
                        if (CheckBox227.Checked == true) { ACCESO_5 = 1; } else { ACCESO_5 = 0; };
                        if (CheckBox228.Checked == true) { ACCESO_6 = 1; } else { ACCESO_6 = 0; };
                    }
                    else if (PERFIL_M == "3")
                    {

                        if (CheckBox149.Checked == true) { ACCESO_1 = 1; } else { ACCESO_1 = 0; };
                        if (CheckBox150.Checked == true) { ACCESO_2 = 1; } else { ACCESO_2 = 0; };
                        if (CheckBox151.Checked == true) { ACCESO_3 = 1; } else { ACCESO_3 = 0; };
                        if (CheckBox152.Checked == true) { ACCESO_4 = 1; } else { ACCESO_4 = 0; };
                        if (CheckBox153.Checked == true) { ACCESO_5 = 1; } else { ACCESO_5 = 0; };
                        if (CheckBox154.Checked == true) { ACCESO_6 = 1; } else { ACCESO_6 = 0; };
                        if (CheckBox155.Checked == true) { ACCESO_7 = 1; } else { ACCESO_7 = 0; };
                        if (CheckBox156.Checked == true) { ACCESO_8 = 1; } else { ACCESO_8 = 0; };
                        if (CheckBox157.Checked == true) { ACCESO_9 = 1; } else { ACCESO_9 = 0; };
                        if (CheckBox158.Checked == true) { ACCESO_10 = 1; } else { ACCESO_10 = 0; };
                        if (CheckBox159.Checked == true) { ACCESO_11 = 1; } else { ACCESO_11 = 0; };
                        if (CheckBox160.Checked == true) { ACCESO_12 = 1; } else { ACCESO_12 = 0; };
                        if (CheckBox161.Checked == true) { ACCESO_13 = 1; } else { ACCESO_13 = 0; };
                        if (CheckBox162.Checked == true) { ACCESO_14 = 1; } else { ACCESO_14 = 0; };
                        if (CheckBox163.Checked == true) { ACCESO_15 = 1; } else { ACCESO_15 = 0; };
                        if (CheckBox164.Checked == true) { ACCESO_16 = 1; } else { ACCESO_16 = 0; };
                        if (CheckBox196.Checked == true) { ACCESO_17 = 1; } else { ACCESO_17 = 0; };
                        if (CheckBox206.Checked == true) { ACCESO_18 = 1; } else { ACCESO_18 = 0; };
                        if (CheckBox225.Checked == true) { ACCESO_19 = 1; } else { ACCESO_19 = 0; };
                        if (CheckBox226.Checked == true) { ACCESO_20 = 1; } else { ACCESO_20 = 0; };

                    };

                    Obj_Entidad_Usuarios.Cedula = Convert.ToDouble(rows.Cells[0].Text);
                    Obj_Entidad_Usuarios.Nombre = rows.Cells[1].Text;
                    Obj_Entidad_Usuarios.Usuario_RR = rows.Cells[4].Text;
                    Obj_Entidad_Usuarios.Usuario_Agendamiento = rows.Cells[5].Text;
                    Obj_Entidad_Usuarios.Contrasena = rows.Cells[13].Text;
                    Obj_Entidad_Usuarios.Id_Rol = Convert.ToInt16(Perfil_A_Cambiar.SelectedValue);
                    Obj_Entidad_Usuarios.Id_Nombre_Linea = Convert.ToInt16(rows.Cells[14].Text);
                    Obj_Entidad_Usuarios.Acceso_1 = ACCESO_1;
                    Obj_Entidad_Usuarios.Acceso_2 = ACCESO_2;
                    Obj_Entidad_Usuarios.Acceso_3 = ACCESO_3;
                    Obj_Entidad_Usuarios.Acceso_4 = ACCESO_4;
                    Obj_Entidad_Usuarios.Acceso_5 = ACCESO_5;
                    Obj_Entidad_Usuarios.Acceso_6 = ACCESO_6;
                    Obj_Entidad_Usuarios.Acceso_7 = ACCESO_7;
                    Obj_Entidad_Usuarios.Acceso_8 = ACCESO_8;
                    Obj_Entidad_Usuarios.Acceso_9 = ACCESO_9;
                    Obj_Entidad_Usuarios.Acceso_10 = ACCESO_10;
                    Obj_Entidad_Usuarios.Acceso_11 = ACCESO_11;
                    Obj_Entidad_Usuarios.Acceso_12 = ACCESO_12;
                    Obj_Entidad_Usuarios.Acceso_13 = ACCESO_13;
                    Obj_Entidad_Usuarios.Acceso_14 = ACCESO_14;
                    Obj_Entidad_Usuarios.Acceso_15 = ACCESO_15;
                    Obj_Entidad_Usuarios.Acceso_16 = ACCESO_16;
                    Obj_Entidad_Usuarios.Acceso_17 = ACCESO_17;
                    Obj_Entidad_Usuarios.Acceso_18 = ACCESO_18;
                    Obj_Entidad_Usuarios.Acceso_19 = ACCESO_19;
                    Obj_Entidad_Usuarios.Acceso_20 = ACCESO_20;
                    Obj_Entidad_Usuarios.Acceso_21 = ACCESO_21;
                    Obj_Entidad_Usuarios.Acceso_22 = ACCESO_22;
                    Obj_Entidad_Usuarios.Acceso_23 = ACCESO_23;
                    Obj_Entidad_Usuarios.Acceso_24 = ACCESO_24;
                    Obj_Entidad_Usuarios.Acceso_25 = ACCESO_25;
                    Obj_Entidad_Usuarios.Acceso_26 = ACCESO_26;
                    Obj_Entidad_Usuarios.Acceso_27 = ACCESO_27;
                    Obj_Entidad_Usuarios.Acceso_28 = ACCESO_28;
                    Obj_Entidad_Usuarios.Acceso_29 = ACCESO_29;
                    Obj_Entidad_Usuarios.Acceso_30 = ACCESO_30;

                    Guardar_Datos = Obj_Neg_Usuarios.abcUsuarios("ACTUALIZAR", Obj_Entidad_Usuarios);
                    if (Guardar_Datos != -1)
                    {

                    }
                }
                else
                {
                    string script12 = "mensaje11();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje11", script12, true);
                }
            }
        }
        string script7 = "mensaje11();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje11", script7, true);
        Panel22.Visible = false;
        Panel23.Visible = false;
        Panel24.Visible = false;
        Panel25.Visible = false;
        Panel26.Visible = false;
        Limpiar();
        Activa_Click(sender, e);
    }
    protected void Select_CheckedChanged(object sender, EventArgs e)
    {
        string script7 = "mensaje7();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje7", script7, true);
        //CheckBox check = new CheckBox();
        //foreach (GridViewRow rows in GV_Usuarios_Masivos.Rows)
        //{
        //    check = rows.FindControl("ChkSelecAnalisis") as CheckBox;
        //    check.Checked = true;
        //}
    }

}