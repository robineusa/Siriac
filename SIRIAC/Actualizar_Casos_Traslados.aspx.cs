using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Actualizar_Casos_Traslados : System.Web.UI.Page
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
        dt = Obj_Neg_Traslados.Consulta_Usuario_Outbound(Obj_Entidad_Traslados.Id_Traslado);
        if (dt.Tables[0].Rows.Count > 0)
        {
            var USUARIORR = dt.Tables[0].Rows[0]["USUARIO_GESTION_OUTBOUND"].ToString();
            var USUARIO_LOGUEADO = Session["Usuario_Logueado"].ToString();
            if (USUARIORR == "")
            {
                Actualizar_Gestion_Inbound_Inicio();
            }
            else if (USUARIORR == USUARIO_LOGUEADO)
            {
                Actualizar_Gestion_Inbound_Gestion();
            }
            else
            {
                string script = "Aviso1();";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Aviso1", script, true);
                Response.Redirect("Lista_Creacion_Direcciones.aspx");
            }
        }
        else
        {

        }
    }
    protected void Actualizar_Gestion_Inbound_Inicio()
    {
        var Guardar_Datos = -1;
        Obj_Entidad_Traslados.Id_Traslado = Convert.ToDouble(Id_Traslado.Text);
        Obj_Entidad_Traslados.Usuario_Gestion_Outbound = Session["Usuario_Logueado"].ToString();
        Guardar_Datos = Obj_Neg_Traslados.Actualiza_Usuario_Outbound_Inicio(Obj_Entidad_Traslados.Id_Traslado, Obj_Entidad_Traslados);
        if (Guardar_Datos != -1)
        {
            Cargar_Informacion_del_Caso();
        }
        else
        {

        }

    }
    protected void Actualizar_Gestion_Inbound_Gestion()
    {
        var Guardar_Datos = -1;
        Obj_Entidad_Traslados.Id_Traslado = Convert.ToDouble(Id_Traslado.Text);
        Obj_Entidad_Traslados.Usuario_Gestion_Outbound = Session["Usuario_Logueado"].ToString();
        Guardar_Datos = Obj_Neg_Traslados.Actualiza_Usuario_Outbound_Gestion(Obj_Entidad_Traslados.Id_Traslado, Obj_Entidad_Traslados);
        if (Guardar_Datos != -1)
        {
            Cargar_Informacion_del_Caso();
        }
        else
        {

        }

    }

    protected void Cargar_Informacion_del_Caso()
    {
        DataSet dt = new DataSet();
        Obj_Entidad_Traslados.Id_Traslado = Convert.ToDouble(Id_Traslado.Text);
        dt = Obj_Neg_Traslados.Consulta_Traslados_PorID(Obj_Entidad_Traslados.Id_Traslado);
        if (dt.Tables[0].Rows.Count > 0)
        {
            Fecha_Creacion.Text = dt.Tables[0].Rows[0]["FECHA_APERTURA"].ToString();
            Hora_Creacion.Text = dt.Tables[0].Rows[0]["HORA_APERTURA"].ToString();
            Usuario_Creacion.Text = dt.Tables[0].Rows[0]["USUARIO_APERTURA"].ToString();
            Aliado_Creacion.Text = dt.Tables[0].Rows[0]["ALIADO_APERTURA"].ToString();
            Nombre_Linea_Ingreso.Text = dt.Tables[0].Rows[0]["NOMBRE_LINEA_INGRESO"].ToString();
            Cuenta_Cliente.Text = dt.Tables[0].Rows[0]["CUENTA_CLIENTE"].ToString();
            Telefono_Celular.Text = dt.Tables[0].Rows[0]["TELEFONO_CELULAR"].ToString();
            Telefono_Fijo.Text = dt.Tables[0].Rows[0]["TELEFONO_FIJO"].ToString();
            Fecha_Actualizacion.Text = dt.Tables[0].Rows[0]["FECHA_ULTIMA_ACTUALIZACION"].ToString();
            Usuario_Actualizacion.Text = dt.Tables[0].Rows[0]["USUARIO_ULTIMA_ACTUALIZACION"].ToString();
            Hora_Actualizacion.Text = dt.Tables[0].Rows[0]["HORA_ULTIMA_ACTUALIZACION"].ToString();
            Estado_Actual_del_Caso.Text = dt.Tables[0].Rows[0]["ESTADO_CASO"].ToString();
            Direccion.Text = dt.Tables[0].Rows[0]["DIRECCION"].ToString();
            Estrato.Text = dt.Tables[0].Rows[0]["ESTRATO"].ToString();
            Nodo.Text = dt.Tables[0].Rows[0]["NODO"].ToString();
            Nombre_Nodo.Text = dt.Tables[0].Rows[0]["NOMBRE_NODO"].ToString();
            DIV.Text = dt.Tables[0].Rows[0]["DIV"].ToString();
            COM.Text = dt.Tables[0].Rows[0]["COM"].ToString();
            Divisional.Text = dt.Tables[0].Rows[0]["DIVISIONAL"].ToString();
            Area.Text = dt.Tables[0].Rows[0]["AREA"].ToString();
            Distrito.Text = dt.Tables[0].Rows[0]["DISTRITO"].ToString();
            Unidad_Gestion.Text = dt.Tables[0].Rows[0]["UGESTION"].ToString();
            Estado_Nodo.Text = dt.Tables[0].Rows[0]["ESTADO_NODO"].ToString();
            Red.Text = dt.Tables[0].Rows[0]["RED"].ToString();
            
        }
        else
        {
            string script = "Aviso2();";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Aviso2", script, true);

        }
    }


    protected void Controles_A_Objeto()
    {
        Obj_Entidad_Notas_Traslados.Id_Traslado = Convert.ToInt64(Id_Traslado.Text);
        Obj_Entidad_Notas_Traslados.Cuenta_Cliente = Convert.ToInt64(Cuenta_Cliente.Text);
        Obj_Entidad_Notas_Traslados.Usuario = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Notas_Traslados.Nombre_Linea_Nota = Session["Nombre_Linea_Usuario"].ToString();
        Obj_Entidad_Notas_Traslados.Nota = Observaciones.Text.ToUpper();
        Obj_Entidad_Notas_Traslados.Razon = "GESTION OUTBOUND";
        Obj_Entidad_Notas_Traslados.Subrazon = Convert.ToString(Gestion_Realizada.SelectedItem);
        Obj_Entidad_Notas_Traslados.Estado = Convert.ToString(Estado_del_Caso.SelectedItem);
    }
    protected void Guardar_Interaccion_Click(object sender, EventArgs e)
    {
        Guardar_Interaccion.Enabled = false;
        if (Convert.ToString(Gestion_Realizada.SelectedItem) != "--SELECCIONE--")
        {
            if (Convert.ToString(Estado_del_Caso.SelectedItem) != "--SELECCIONE--")
            {
                if (Estado_Actual_del_Caso.Text == "FINALIZADO")
                {
                    Guardar_Interaccion.Enabled = true;
                    Alerta.Text = "Este caso ya esta finalizado, no puedes realizarle mas transacciones";
                    Alerta.Attributes.Add("Style", "display:block;color :red; font-size:16px;font-family:'Century Gothic';");
                }
                else
                {
                    Generar_Transaccion();
                }

            }
            else
            {
                Guardar_Interaccion.Enabled = true;
                Alerta.Text = "Debes seleccionar un estado para el caso";
                Alerta.Attributes.Add("Style", "display:block;color :red; font-size:16px;font-family:'Century Gothic';");
            }
        }
        else
        {
            Guardar_Interaccion.Enabled = true;
            Alerta.Text = "Debes seleccionar una gestión realizada en el caso";
            Alerta.Attributes.Add("Style", "display:block;color :red; font-size:16px;font-family:'Century Gothic';");

        }

    }
    protected void Guardar_Nota_Caso()
    {
        Controles_A_Objeto();
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Notas_Traslados.Inserta_Nota_Traslados("INSERTAR", Obj_Entidad_Notas_Traslados);
        if (Guardar_Datos != -1)
        {
            Response.Redirect("Lista_Creacion_Direcciones.aspx");
        }
        else
        {
            Guardar_Interaccion.Enabled = true;
            Alerta.Text = "No se pudo insertar la transaccion, por favor intentelo nuevamente";
            Alerta.Attributes.Add("Style", "display:block;color :red; font-size:16px;font-family:'Century Gothic';");
        }
    }
    protected void Actualizar_Caso_Cierre()
    {
        Controles_A_Objeto_Actualizar_Caso();
        Obj_Entidad_Traslados.Id_Traslado = Convert.ToInt64(Id_Traslado.Text);
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Traslados.Actualizar_Traslado_Cierre("ACTUALIZAR", Obj_Entidad_Traslados);
        if (Guardar_Datos != -1)
        {
            Guardar_Nota_Caso();
        }
        else
        {
            Guardar_Interaccion.Enabled = true;
            Alerta.Text = "No se pudo insertar la transaccion, por favor intentelo nuevamente";
            Alerta.Attributes.Add("Style", "display:block;color :red; font-size:16px;font-family:'Century Gothic';");
        }
    }
    protected void Actualizar_Caso_Gestion()
    {

        Controles_A_Objeto_Actualizar_Caso();
        Obj_Entidad_Traslados.Id_Traslado = Convert.ToInt64(Id_Traslado.Text);
        var Guardar_Datos = -1;
        Guardar_Datos = Obj_Neg_Traslados.Actualizar_Traslado_Gestion("ACTUALIZAR", Obj_Entidad_Traslados);
        if (Guardar_Datos != -1)
        {
            Guardar_Nota_Caso();
        }
        else
        {
            Guardar_Interaccion.Enabled = true;
            Alerta.Text = "No se pudo insertar la transaccion, por favor intentelo nuevamente";
            Alerta.Attributes.Add("Style", "display:block;color :red; font-size:16px;font-family:'Century Gothic';");
        }
    }
    protected void Generar_Transaccion()
    {
        if (Convert.ToString(Estado_del_Caso.SelectedItem) == "PENDIENTE CONTACTO")
        {
            Actualizar_Caso_Gestion();


        }
        else
            if (Convert.ToString(Estado_del_Caso.SelectedItem) == "FINALIZADO")
        {
            Actualizar_Caso_Cierre();

        }
        else
         {}
    }
    protected void Controles_A_Objeto_Actualizar_Caso()
    {
        Obj_Entidad_Traslados.Id_Traslado = Convert.ToInt64(Id_Traslado.Text);
        Obj_Entidad_Traslados.Usuario_Cierre = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Traslados.Usuario_Ultima_Actualizacion = Session["Usuario_Logueado"].ToString();
        Obj_Entidad_Traslados.Razon = "GESTION OUTBOUND";
        Obj_Entidad_Traslados.Subrazon = Convert.ToString(Gestion_Realizada.SelectedItem);
        Obj_Entidad_Traslados.Estado = Convert.ToString(Estado_del_Caso.SelectedItem);

    }
}