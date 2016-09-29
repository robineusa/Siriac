using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Monitoreo : System.Web.UI.Page
{
    public E_Clientes Obj_Entidad_Clientes = new E_Clientes();
    public N_Clientes Obj_Neg_Clientes = new N_Clientes();
    public E_Convenio_Electronico obj_Entidad_Convenio_Electronico = new E_Convenio_Electronico();
    public N_Convenio_Electronico obj_neg_Convenio_Electronico = new N_Convenio_Electronico();
    public N_Mejor_Oferta obj_Neg_Mejor_Oferta = new N_Mejor_Oferta();
    public E_Mejor_Oferta obj_Entidad_Mejor_Oferta = new E_Mejor_Oferta();
    public E_Usuarios Obj_Entidad_Usuarios = new E_Usuarios();
    public N_Usuarios Obj_Neg_Usuarios = new N_Usuarios();
    public E_Base_Personal Obj_Entidad_Base_Personal = new E_Base_Personal();
    public N_Base_Personal Obj_Neg_Base_Personal = new N_Base_Personal();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Cuenta_Cliente_TextChanged(object sender, EventArgs e)
    {
        string script10 = "Banner_Alertas_Inicio();";
        ScriptManager.RegisterStartupScript(this, typeof(Page), "Banner_Alertas_Inicio()", script10, true);
        
        DataSet dt1 = new DataSet();
        Obj_Entidad_Usuarios.Cedulas = C_Cedula.Text;
        dt1 = Obj_Neg_Usuarios.Consulta_Usuarios_Cedula(Obj_Entidad_Usuarios.Cedulas);

        if (dt1.Tables[0].Rows.Count > 0)
        {
            Trae_Informacion_Holos_C();
        }
        else
        {
            Limpiar_Controles();
        }
        try
        {
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
                Correo_Electronico.Text = dt.Tables[0].Rows[0]["CORREO"].ToString();
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
                Panel2.Visible = true;
                //ESTA CONSULTA VERIFICA SI EL CLIENTE TIENE ACTIVO O NO EL CONVENIO ELECTRONICO//
                try
                {
                    DataSet dt3 = new DataSet();
                    obj_Entidad_Convenio_Electronico.Cuenta_Cliente = Convert.ToDouble(Cuenta_Cliente.Text);
                    dt3 = obj_neg_Convenio_Electronico.Consulta_Falta_Convenio(Obj_Entidad_Clientes.Cuenta_Cliente);
                    if (dt3.Tables[0].Rows.Count > 0)
                    {
                        string script1 = "Activar_Convenio();";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "Activar_Convenio()", script1, true);
                    }
                    else
                    {
                        string script1 = "No_Activar_Convenio();";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "No_Activar_Convenio()", script1, true);
                    }
                }
                catch (Exception esc)
                { throw new Exception("Error al Consultar la cuenta del cliente convenio electronico", esc); }

                //ESTA CONSULTA CARGA LA INFORMACION DE SIGUIENTE MEJOR OFERTA//
                try
                {
                    DataSet dtSMO = new DataSet();
                    obj_Entidad_Mejor_Oferta.Cuenta = Convert.ToDouble(Cuenta_Cliente.Text);
                    dtSMO = obj_Neg_Mejor_Oferta.Consulta_Temporal_Cuentas(obj_Entidad_Mejor_Oferta.Cuenta);
                    if (dtSMO.Tables[0].Rows.Count > 0)
                    {
                        SMO_Mix_Basico.Text = dtSMO.Tables[0].Rows[0]["MIX_BASICO"].ToString();
                        SMO_Television.Text = dtSMO.Tables[0].Rows[0]["SERVICIO_TV"].ToString();
                        SMO_Internet.Text = dtSMO.Tables[0].Rows[0]["SERVICIO_INTERNET"].ToString();
                        SMO_Telefonia.Text = dtSMO.Tables[0].Rows[0]["SERVICIO_VOZ"].ToString();
                        SMO_HD.Text = dtSMO.Tables[0].Rows[0]["HD"].ToString();
                        SMO_HBO.Text = dtSMO.Tables[0].Rows[0]["HBO"].ToString();
                        SMO_FOX.Text = dtSMO.Tables[0].Rows[0]["FOX"].ToString();
                        SMO_Adulto.Text = dtSMO.Tables[0].Rows[0]["ADULTO"].ToString();
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
                        string script1 = "SMO_Activar();";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "SMO_Activar()", script1, true);
                    }
                    else
                    {
                        string script1 = "SMO_Desactivar();";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "SMO_Desactivar()", script1, true);
                    }
                }
                catch (Exception esc)
                {
                    throw new Exception("Error al Consultar la cuenta del cliente Siguiente Mejor Oferta", esc);
                }
            }
            else
            {
                string script1 = "mensaje1();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensaje1()", script1, true);
                Limpiar_Controles();
            }
            
        }
        catch (Exception es)
        {
            throw new Exception("Error al Consultar la cuenta del cliente en BASE CUENTAS", es);
        }


    }
    private void Limpiar_Controles()
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
        Correo_Electronico.Text = string.Empty;
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
        C_Cedula.Text = string.Empty;
        C_Nombre_Usuario.Text = string.Empty;
        C_Aliado.Text = string.Empty;
        C_Nombre_Linea.Text = string.Empty;
        C_Operacion.Text = string.Empty;
        C_Grupo.Text = string.Empty;
        C_Cargo.Text = string.Empty;
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
            C_Operacion.Text = dt.Tables[0].Rows[0]["OPERACION"].ToString();
            C_Grupo.Text = dt.Tables[0].Rows[0]["GRUPO"].ToString();
            C_Cargo.Text = dt.Tables[0].Rows[0]["CARGO"].ToString();
            
        }
        else
        {
            
        }
    }

}