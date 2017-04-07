<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Administracion_de_Usuarios.aspx.cs" Inherits="Administracion_de_Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="jquery/jquery-1.11.1.js?1.0.0"></script>
    <script src="jquery/jquery.dropdownPlain.js?1.0.0"></script>
    <%--<script src="javascript/Funciones.js?1.0.0"></script>--%>
    <link href="Estilos/Style_Perfil_Asesor.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Style_Ingreso_Casos.css?1.0.0" rel="stylesheet" />
    <link href="Estilos/Menu.css?1.0.0" rel="stylesheet" />
    <script lang="ja">
        
        <%--function seleccionar_todo(id) {
            alert('123'+id);
            var gridViewControl = document.getElementById('<%=GV_Usuarios_Masivos.ClientID %>');
            alert('123' + id);
            for (i = 0; i < gridViewControl.elements.length; i++) {
                alert('123' + id);
                if (gridViewControl.elements[i].type == "checkbox") {
                    gridViewControl.elements[i].checked = document.getElementById(id).checked;
                }
            }
        }--%>


        $(document).ready(function () {

            if ('<%=Session["Acceso_1"]%>' == "1") {

            } else {
                $("#Primer_div").hide();
                $("#html").hide();
            }

            if ('<%=Session["Acceso_2"]%>' == "1") {
                if ('<%=Session["Acceso_1"]%>' == "1") {

                } else {
                    $("#css").addClass("active");
                    $("#css-tab").addClass("tab-content active");
                }
            } else {
                $("#Segundo_div").hide();
                $("#css").hide();
            }
            if ('<%=Session["Acceso_3"]%>' == "1") {
                if ('<%=Session["Acceso_1"]%>' == "1" || '<%=Session["Acceso_2"]%>' == "1") {

                } else {
                    $("#javascript").addClass("active");
                    $("#javascript-tab").addClass("tab-content active");
                }
            } else {
                $("#Tercer_div").hide();
                $("#javascript").hide();
            }
            if ('<%=Session["Acceso_18"]%>' == "1") {
                if ('<%=Session["Acceso_1"]%>' == "1" || '<%=Session["Acceso_2"]%>' == "1" || '<%=Session["Acceso_3"]%>' == "1") {

                } else {
                    $("#Cuarto").addClass("active");
                    $("#Cuarto-tab").addClass("tab-content active");
                }
            } else {
                $("#Cuarto_div").hide();
                $("#Cuarto").hide();
            }
        });
        function otorgar_permisos() {
            var Activa_Aliado = '<%=Activa_C.ClientID%>';
            var x = document.getElementById(Activa_Aliado);
            x.click();
            var activeTabIndex = -1;
            var tabNames = ["html", "javascript", "css", "Cuarto"];
            $(".tab-menu > li").click(function (e) {
                for (var i = 0; i < tabNames.length; i++) {
                    if (e.target.id == tabNames[i]) {
                        activeTabIndex = i;
                    } else {
                        $("#" + tabNames[i]).removeClass("active");
                        $("#" + tabNames[i] + "-tab").css("display", "none");
                    }
                }
                $("#" + tabNames[activeTabIndex] + "-tab").fadeIn();
                $("#" + tabNames[activeTabIndex]).addClass("active");
                return false;
            });

        }
    </script>

    <script type="text/javascript">
        function mensaje1() {

            alert('El usuario ya se encuentra registrado en Siriac');
        }
    </script>
    <script type="text/javascript">
        function mensaje2() {

            alert('El usuario no se encuentra activo en Holos System');
        }
    </script>
    <script type="text/javascript">
        function mensaje3() {

            alert('Usuario Registrado');
        }
    </script>
    <script type="text/javascript">
        function mensaje4() {

            alert('No se puede almacenar un registro sin usuario de RR');
        }
    </script>

    <script type="text/javascript">
        function mensaje5() {

            alert('El usuario no se encuentra registrado en Siriac');
        }
    </script>
    <script type="text/javascript">
        function mensaje6() {

            alert('No se puede actualizar un registro sin información');
        }
    </script>
    <script type="text/javascript">
        function mensaje7() {

            alert('Usuario Actualizado');
        }
    </script>
    <script type="text/javascript">
        function mensaje8() {

            alert('Usuarios Registrados');
        }
    </script>
    <script type="text/javascript">
        function mensaje9() {

            alert('Debe cargar un Archivo de Excel para guardar nuevos Usarios');
        }
    </script>
    <script type="text/javascript">
        function mensaje10() {

            alert('No se Encuentra Resgitrado Ningun Usario en ese Aliado');
        }
    </script>
    <script type="text/javascript">
        function mensaje11() {

            alert('Usuarios Actualizados');
        }
    </script>
    <script type="text/javascript">
        function mensaje12() {

            alert('Debe Primero Buscar los Usuarios a Modificar');
        }
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:ScriptManager runat="server"></asp:ScriptManager>

    <asp:Panel CssClass="panel" ID="Panel1" runat="server" Style="width: 1100px">
        <div id="tab-container" style="width: 1080px">
            <ul class="tab-menu">
                <li id="html" class="active" onclick="otorgar_permisos()">CREACIÓN DE USUARIOS</li>
                <li id="css" onclick="otorgar_permisos()">CONSULTA DE USUARIOS</li>
                <li id="javascript" onclick="otorgar_permisos()">ACCESOS Y ROLES</li>
                <li id="Cuarto" onclick="otorgar_permisos()">ACCESOS Y ROLES MASIVO</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>

            <div id="Primer_div">
                <div id="html-tab" class="tab-content active">
                    <h3 class="Titulos">FORMULARIO PARA LA CREACIÓN DE USUARIOS</h3>
                    <asp:UpdatePanel runat="server" ID="update0">
                        <ContentTemplate>
                            <asp:Panel CssClass="panel_informativo" ID="Panel3" runat="server" GroupingText="Datos del Usuario en Holos">
                                <table class="tabla">
                                    <tr>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label1" runat="server" Text="Documento de Identidad:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Cedula" runat="server" OnTextChanged="Cedula_TextChanged" AutoPostBack="true" Placeholder="Ingrese la Cédula"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label2" runat="server" Text="Nombre del Usuario:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Nombre_Usuario" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label3" runat="server" Text="Aliado:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Aliado" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label4" runat="server" Text="Nombre de Linea:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Nombre_de_Linea" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label5" runat="server" Text="Usuario RR:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Usuario_RR" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label6" runat="server" Text="Usuario Agendamiento:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Usuario_Agendamiento" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label7" runat="server" Text="Usuario Gerencia:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Usuario_Gerencia" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label8" runat="server" Text="Estado:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Estado" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>

                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label9" runat="server" Text="Canal:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Canal" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label10" runat="server" Text="Operación:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Operacion" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label11" runat="server" Text="Grupo:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Grupo" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label12" runat="server" Text="Cargo:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Cargo" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label13" runat="server" Text="Segmento:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Segmento" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>

                            <asp:Panel CssClass="panel_informativo" ID="Panel5" runat="server" GroupingText="Perfíl y Nombre de Línea a Otorgar">

                                <table class="tabla">
                                    <tr>

                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label14" runat="server" Text="Perfil:"></asp:Label><br />
                                            <asp:DropDownList CssClass="dropdown1" ID="Perfil" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Perfil_SelectedIndexChanged"></asp:DropDownList>

                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label15" runat="server" Text="Nombre de Línea:"></asp:Label><br />
                                            <asp:DropDownList CssClass="dropdown2" ID="Nombre_Linea" runat="server"></asp:DropDownList>

                                        </td>


                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label16" runat="server" Text="Contraseña:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="Contrasena" runat="server"></asp:TextBox>
                                        </td>

                                        <div style="float: right; margin-right: 10px;" id="Carga_Masiva_div" class="referencia" runat="server"><a href="#Carga_Masiva">Carga Masiva</a></div>
                                    </tr>
                                </table>
                            </asp:Panel>

                            <asp:Panel CssClass="panel_informativo" ID="Panel6" runat="server" GroupingText="Accesos y Privilegios a Otorgar" Visible="false">
                                <table class="tabla2">
                                    <tr>
                                        <td>

                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox1" runat="server" />
                                                <asp:Label ID="Label17" AssociatedControlID="CheckBox1" runat="server"
                                                    Text="Gestión Inbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox2" runat="server" />
                                                <asp:Label ID="Label18" AssociatedControlID="CheckBox2" runat="server"
                                                    Text="Gestión Outbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox3" runat="server" />
                                                <asp:Label ID="Label19" AssociatedControlID="CheckBox3" runat="server"
                                                    Text="Midas Activación" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox4" runat="server" />
                                                <asp:Label ID="Label20" AssociatedControlID="CheckBox4" runat="server"
                                                    Text="Incremento de Tarifa" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox5" runat="server" />
                                                <asp:Label ID="Label21" AssociatedControlID="CheckBox5" runat="server"
                                                    Text="Ayuda Ventas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox6" runat="server" />
                                                <asp:Label ID="Label22" AssociatedControlID="CheckBox6" runat="server"
                                                    Text="Historico de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>

                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox7" runat="server" />
                                                <asp:Label ID="Label23" AssociatedControlID="CheckBox7" runat="server"
                                                    Text="Pqr y Marcaciones RR" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox8" runat="server" />
                                                <asp:Label ID="Label24" AssociatedControlID="CheckBox8" runat="server"
                                                    Text="Ordenes Abiertas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox82" runat="server" />
                                                <asp:Label ID="Label159" AssociatedControlID="CheckBox82" runat="server"
                                                    Text="Gestión Blending" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox83" runat="server" />
                                                <asp:Label ID="Label160" AssociatedControlID="CheckBox83" runat="server"
                                                    Text="Activación" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox84" runat="server" />
                                                <asp:Label ID="Label161" AssociatedControlID="CheckBox84" runat="server"
                                                    Text="Convenio Electrónico" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox85" runat="server" />
                                                <asp:Label ID="Label162" AssociatedControlID="CheckBox85" runat="server"
                                                    Text="Detractores" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox86" runat="server" />
                                                <asp:Label ID="Label163" AssociatedControlID="CheckBox86" runat="server"
                                                    Text="Reincidencia" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox87" runat="server" />
                                                <asp:Label ID="Label164" AssociatedControlID="CheckBox87" runat="server"
                                                    Text="Ventas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox88" runat="server" />
                                                <asp:Label ID="Label165" AssociatedControlID="CheckBox88" runat="server"
                                                    Text="Logistica Inversa" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox89" runat="server" />
                                                <asp:Label ID="Label166" AssociatedControlID="CheckBox89" runat="server"
                                                    Text="Fraudes" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox187" runat="server" />
                                                <asp:Label ID="Label229" AssociatedControlID="CheckBox187" runat="server"
                                                    Text="Claro Video" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox202" runat="server" />
                                                <asp:Label ID="Label284" AssociatedControlID="CheckBox202" runat="server"
                                                    Text="Docsis y Overlap" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox207" runat="server" />
                                                <asp:Label ID="Label289" AssociatedControlID="CheckBox207" runat="server"
                                                    Text="Traslados - Crear Direccion" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox208" runat="server" />
                                                <asp:Label ID="Label290" AssociatedControlID="CheckBox208" runat="server"
                                                    Text="Direcciones Creadas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Panel CssClass="panel_informativo" ID="Panel7" runat="server" GroupingText="Accesos y Privilegios a Otorgar" Visible="false">
                                <table class="tabla2">
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox9" runat="server" />
                                                <asp:Label ID="Label25" AssociatedControlID="CheckBox9" runat="server"
                                                    Text="Casos Abiertos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox10" runat="server" />
                                                <asp:Label ID="Label26" AssociatedControlID="CheckBox10" runat="server"
                                                    Text="Seguimiento de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox11" runat="server" />
                                                <asp:Label ID="Label27" AssociatedControlID="CheckBox11" runat="server"
                                                    Text="Consulta de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox12" runat="server" />
                                                <asp:Label ID="Label28" AssociatedControlID="CheckBox12" runat="server"
                                                    Text="Gestión Inbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox209" runat="server" />
                                                <asp:Label ID="Label291" AssociatedControlID="CheckBox209" runat="server"
                                                    Text="Crear Direcciones" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox210" runat="server" />
                                                <asp:Label ID="Label292" AssociatedControlID="CheckBox210" runat="server"
                                                    Text="Seguimientos Traslados" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Panel CssClass="panel_informativo" ID="Panel8" runat="server" GroupingText="Accesos y Privilegios a Otorgar" Visible="false">
                                <table class="tabla2">
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox13" runat="server" />
                                                <asp:Label ID="Label29" AssociatedControlID="CheckBox13" runat="server"
                                                    Text="Creación de Usuarios" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox14" runat="server" />
                                                <asp:Label ID="Label30" AssociatedControlID="CheckBox14" runat="server"
                                                    Text="Consulta de Usuarios" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox15" runat="server" />
                                                <asp:Label ID="Label31" AssociatedControlID="CheckBox15" runat="server"
                                                    Text="Actualización de Usuarios" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox16" runat="server" />
                                                <asp:Label ID="Label32" AssociatedControlID="CheckBox16" runat="server"
                                                    Text="Consulta de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox17" runat="server" />
                                                <asp:Label ID="Label33" AssociatedControlID="CheckBox17" runat="server"
                                                    Text="Consulta de Paloteo" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox18" runat="server" />
                                                <asp:Label ID="Label34" AssociatedControlID="CheckBox18" runat="server"
                                                    Text="Consulta de Gestión" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox19" runat="server" />
                                                <asp:Label ID="Label35" AssociatedControlID="CheckBox19" runat="server"
                                                    Text="Consulta Outbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox20" runat="server" />
                                                <asp:Label ID="Label36" AssociatedControlID="CheckBox20" runat="server"
                                                    Text="Consulta Rechazos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox21" runat="server" />
                                                <asp:Label ID="Label37" AssociatedControlID="CheckBox21" runat="server"
                                                    Text="Actualización de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox22" runat="server" />
                                                <asp:Label ID="Label38" AssociatedControlID="CheckBox22" runat="server"
                                                    Text="Actualizar Marcaciones" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox23" runat="server" />
                                                <asp:Label ID="Label39" AssociatedControlID="CheckBox23" runat="server"
                                                    Text="Creación de Marcaciones" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox24" runat="server" />
                                                <asp:Label ID="Label40" AssociatedControlID="CheckBox24" runat="server"
                                                    Text="Reporte de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox25" runat="server" />
                                                <asp:Label ID="Label41" AssociatedControlID="CheckBox25" runat="server"
                                                    Text="Reporte de Paloteo" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox26" runat="server" />
                                                <asp:Label ID="Label42" AssociatedControlID="CheckBox26" runat="server"
                                                    Text="Reporte Outbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox27" runat="server" />
                                                <asp:Label ID="Label43" AssociatedControlID="CheckBox27" runat="server"
                                                    Text="Reporte Midas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox106" runat="server" />
                                                <asp:Label ID="Label183" AssociatedControlID="CheckBox106" runat="server"
                                                    Text="Consulta Blending" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox107" runat="server" />
                                                <asp:Label ID="Label184" AssociatedControlID="CheckBox107" runat="server"
                                                    Text="Reporte Ventas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox188" runat="server" />
                                                <asp:Label ID="Label230" AssociatedControlID="CheckBox188" runat="server"
                                                    Text="Actualizacion Usuarios Masivo" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox189" runat="server" />
                                                <asp:Label ID="Label231" AssociatedControlID="CheckBox189" runat="server"
                                                    Text="Pieza Buen Servicio" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox211" runat="server" />
                                                <asp:Label ID="Label293" AssociatedControlID="CheckBox211" runat="server"
                                                    Text="Consulta Solicitudes Direccion" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox212" runat="server" />
                                                <asp:Label ID="Label294" AssociatedControlID="CheckBox212" runat="server"
                                                    Text="Consulta Interacciones Direccion" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Button CssClass="button" ID="Crear_Usuario" runat="server" Text="Crear Usuario" OnClick="Crear_Usuario_Click" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>


            <div id="Segundo_div">
                <div id="css-tab" class="tab-content">
                    <h3 class="Titulos">FORMULARIO PARA CONSULTA DE USUARIOS</h3>
                    <asp:UpdatePanel runat="server" ID="update2">
                        <ContentTemplate>
                            <asp:Panel CssClass="panel_informativo" ID="Panel2" runat="server" GroupingText="Datos del Usuario en Holos System">
                                <table class="tabla">
                                    <tr>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label44" runat="server" Text="Documento de Identidad:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="C_Cedula" runat="server" OnTextChanged="C_Cedula_TextChanged" AutoPostBack="true"></asp:TextBox>

                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label45" runat="server" Text="Nombre del Usuario:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="C_Nombre_Usuario" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label46" runat="server" Text="Aliado:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="C_Aliado" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label47" runat="server" Text="Nombre de Linea:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="C_Nombre_Linea" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label48" runat="server" Text="Usuario RR:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="C_Usuario_RR" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label49" runat="server" Text="Usuario Agendamiento:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="C_Usuario_Agendamiento" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label50" runat="server" Text="Usuario Gerencia:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="C_Usuario_Gerencia" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label51" runat="server" Text="Estado:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="C_Estado" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label52" runat="server" Text="Canal:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="C_Canal" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label53" runat="server" Text="Operación:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="C_Operacion" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label54" runat="server" Text="Grupo:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="C_Grupo" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label55" runat="server" Text="Cargo:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="C_Cargo" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label56" runat="server" Text="Segmento:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="C_Segmento" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>


                            </asp:Panel>

                            <asp:Panel CssClass="panel_informativo" ID="Panel9" runat="server" GroupingText="Información del Usuario en Siriac">
                                <table class="tabla">
                                    <tr>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label57" runat="server" Text="Perfil:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="C_Perfil_Siriac" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label58" runat="server" Text="Nombre de Linea:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="C_Nombre_Linea_Siriac" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>

                                </table>
                            </asp:Panel>
                            <asp:Panel CssClass="panel_informativo" ID="Panel10" runat="server" GroupingText="Accesos y Privilegios del Usuario" Visible="false">
                                <table class="tabla2">
                                    <tr>
                                        <td>

                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox28" runat="server" />
                                                <asp:Label ID="Label59" AssociatedControlID="CheckBox28" runat="server" Text="Gestión Inbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox29" runat="server" />
                                                <asp:Label ID="Label60" AssociatedControlID="CheckBox29" runat="server"
                                                    Text="Gestión Outbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox30" runat="server" />
                                                <asp:Label ID="Label61" AssociatedControlID="CheckBox30" runat="server"
                                                    Text="Midas Activación" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox31" runat="server" />
                                                <asp:Label ID="Label62" AssociatedControlID="CheckBox31" runat="server"
                                                    Text="Incremento de Tarifa" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox32" runat="server" />
                                                <asp:Label ID="Label63" AssociatedControlID="CheckBox32" runat="server"
                                                    Text="Ayuda Ventas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox33" runat="server" />
                                                <asp:Label ID="Label64" AssociatedControlID="CheckBox33" runat="server"
                                                    Text="Historico de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>

                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox34" runat="server" />
                                                <asp:Label ID="Label65" AssociatedControlID="CheckBox34" runat="server"
                                                    Text="Pqr y Marcaciones RR" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox35" runat="server" />
                                                <asp:Label ID="Label66" AssociatedControlID="CheckBox35" runat="server"
                                                    Text="Ordenes Abiertas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox90" runat="server" />
                                                <asp:Label ID="Label167" AssociatedControlID="CheckBox90" runat="server"
                                                    Text="Gestión Blending" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox91" runat="server" />
                                                <asp:Label ID="Label168" AssociatedControlID="CheckBox91" runat="server"
                                                    Text="Activación" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox92" runat="server" />
                                                <asp:Label ID="Label169" AssociatedControlID="CheckBox92" runat="server"
                                                    Text="Convenio Electrónico" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox93" runat="server" />
                                                <asp:Label ID="Label170" AssociatedControlID="CheckBox93" runat="server"
                                                    Text="Detractores" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox94" runat="server" />
                                                <asp:Label ID="Label171" AssociatedControlID="CheckBox94" runat="server"
                                                    Text="Reincidencia" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox95" runat="server" />
                                                <asp:Label ID="Label172" AssociatedControlID="CheckBox95" runat="server"
                                                    Text="Ventas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox96" runat="server" />
                                                <asp:Label ID="Label173" AssociatedControlID="CheckBox96" runat="server"
                                                    Text="Logistica Inversa" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox97" runat="server" />
                                                <asp:Label ID="Label174" AssociatedControlID="CheckBox97" runat="server"
                                                    Text="Fraudes" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox190" runat="server" />
                                                <asp:Label ID="Label232" AssociatedControlID="CheckBox190" runat="server"
                                                    Text="Claro Video" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox203" runat="server" />
                                                <asp:Label ID="Label285" AssociatedControlID="CheckBox203" runat="server"
                                                    Text="Docsis y Overlap" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox213" runat="server" />
                                                <asp:Label ID="Label295" AssociatedControlID="CheckBox213" runat="server"
                                                    Text="Traslados - Crear Direccion" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox214" runat="server" />
                                                <asp:Label ID="Label296" AssociatedControlID="CheckBox214" runat="server"
                                                    Text="Direcciones Creadas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Panel CssClass="panel_informativo" ID="Panel11" runat="server" GroupingText="Accesos y Privilegios a Otorgar" Visible="false">
                                <table class="tabla2">
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox36" runat="server" />
                                                <asp:Label ID="Label67" AssociatedControlID="CheckBox36" runat="server"
                                                    Text="Casos Abiertos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox37" runat="server" />
                                                <asp:Label ID="Label68" AssociatedControlID="CheckBox37" runat="server"
                                                    Text="Seguimiento de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox38" runat="server" />
                                                <asp:Label ID="Label69" AssociatedControlID="CheckBox38" runat="server"
                                                    Text="Consulta de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox39" runat="server" />
                                                <asp:Label ID="Label70" AssociatedControlID="CheckBox39" runat="server"
                                                    Text="Gestión Inbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox215" runat="server" />
                                                <asp:Label ID="Label297" AssociatedControlID="CheckBox215" runat="server"
                                                    Text="Crear Direcciones" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox216" runat="server" />
                                                <asp:Label ID="Label298" AssociatedControlID="CheckBox216" runat="server"
                                                    Text="Seguimientos Traslados" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Panel CssClass="panel_informativo" ID="Panel12" runat="server" GroupingText="Accesos y Privilegios a Otorgar" Visible="false">
                                <table class="tabla2">
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox40" runat="server" />
                                                <asp:Label ID="Label71" AssociatedControlID="CheckBox40" runat="server"
                                                    Text="Creación de Usuarios" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox41" runat="server" />
                                                <asp:Label ID="Label72" AssociatedControlID="CheckBox41" runat="server"
                                                    Text="Consulta de Usuarios" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox42" runat="server" />
                                                <asp:Label ID="Label73" AssociatedControlID="CheckBox42" runat="server"
                                                    Text="Actualización de Usuarios" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox43" runat="server" />
                                                <asp:Label ID="Label74" AssociatedControlID="CheckBox43" runat="server"
                                                    Text="Consulta de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox44" runat="server" />
                                                <asp:Label ID="Label75" AssociatedControlID="CheckBox44" runat="server"
                                                    Text="Consulta de Paloteo" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox45" runat="server" />
                                                <asp:Label ID="Label76" AssociatedControlID="CheckBox45" runat="server"
                                                    Text="Consulta de Gestión" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox46" runat="server" />
                                                <asp:Label ID="Label77" AssociatedControlID="CheckBox46" runat="server"
                                                    Text="Consulta Outbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox47" runat="server" />
                                                <asp:Label ID="Label78" AssociatedControlID="CheckBox47" runat="server"
                                                    Text="Consulta Rechazos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox48" runat="server" />
                                                <asp:Label ID="Label79" AssociatedControlID="CheckBox48" runat="server"
                                                    Text="Actualización de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox49" runat="server" />
                                                <asp:Label ID="Label80" AssociatedControlID="CheckBox49" runat="server"
                                                    Text="Actualizar Marcaciones" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox50" runat="server" />
                                                <asp:Label ID="Label81" AssociatedControlID="CheckBox50" runat="server"
                                                    Text="Creación de Marcaciones" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox51" runat="server" />
                                                <asp:Label ID="Label82" AssociatedControlID="CheckBox51" runat="server"
                                                    Text="Reporte de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox52" runat="server" />
                                                <asp:Label ID="Label83" AssociatedControlID="CheckBox52" runat="server"
                                                    Text="Reporte de Paloteo" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox53" runat="server" />
                                                <asp:Label ID="Label84" AssociatedControlID="CheckBox53" runat="server"
                                                    Text="Reporte Outbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox54" runat="server" />
                                                <asp:Label ID="Label85" AssociatedControlID="CheckBox54" runat="server"
                                                    Text="Reporte Midas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox108" runat="server" />
                                                <asp:Label ID="Label185" AssociatedControlID="CheckBox108" runat="server"
                                                    Text="Consulta Blending" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox109" runat="server" />
                                                <asp:Label ID="Label186" AssociatedControlID="CheckBox109" runat="server"
                                                    Text="Reporte Ventas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox191" runat="server" />
                                                <asp:Label ID="Label233" AssociatedControlID="CheckBox191" runat="server"
                                                    Text="Actualizacion Usuarios Masivo" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox192" runat="server" />
                                                <asp:Label ID="Label234" AssociatedControlID="CheckBox192" runat="server"
                                                    Text="Pieza Buen Servicio" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox217" runat="server" />
                                                <asp:Label ID="Label299" AssociatedControlID="CheckBox217" runat="server"
                                                    Text="Consulta Solicitudes Direccion" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox218" runat="server" />
                                                <asp:Label ID="Label300" AssociatedControlID="CheckBox218" runat="server"
                                                    Text="Consulta Interacciones Direccion" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                                <asp:Label ID="Label86" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label87" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label88" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label89" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label90" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label91" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label92" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label93" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label94" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label95" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label96" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label97" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label98" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label99" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label100" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label101" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label102" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label103" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label104" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label105" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label106" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label107" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label108" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label109" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label110" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label111" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label112" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label113" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label114" runat="server" Text="" Style="display: none"></asp:Label>
                                <asp:Label ID="Label115" runat="server" Text="" Style="display: none"></asp:Label>

                            </asp:Panel>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>


            <div id="Tercer_div">
                <div id="javascript-tab" class="tab-content">
                    <h3 class="Titulos">FORMULARIO PARA OTORGAR ACCESOS A LOS USUARIOS</h3>
                    <asp:UpdatePanel runat="server" ID="update3">
                        <ContentTemplate>
                            <asp:Panel CssClass="panel_informativo" ID="Panel4" runat="server" GroupingText="Datos del Usuario en Holos">
                                <table class="tabla">
                                    <tr>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label116" runat="server" Text="Documento de Identidad:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="A_Cedula" runat="server" OnTextChanged="A_Cedula_TextChanged" AutoPostBack="true"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label117" runat="server" Text="Nombre del Usuario:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="A_Nombre_Usuario" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label118" runat="server" Text="Aliado:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="A_Aliado" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label119" runat="server" Text="Nombre de Linea:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="A_Nombre_Linea" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label120" runat="server" Text="Usuario RR:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="A_Usuario_RR" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label121" runat="server" Text="Usuario Agendamiento:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="A_Usuario_Agendamiento" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label122" runat="server" Text="Usuario Gerencia:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="A_Usuario_Gerencia" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label123" runat="server" Text="Estado:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="A_Estado" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label124" runat="server" Text="Canal:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="A_Canal" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label125" runat="server" Text="Operación:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="A_Operacion" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label126" runat="server" Text="Grupo:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="A_Grupo" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label127" runat="server" Text="Cargo:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="A_Cargo" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label128" runat="server" Text="Segmento:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="A_Segmento" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>

                            <asp:Panel CssClass="panel_informativo" ID="Panel13" runat="server" GroupingText="Perfíl y Nombre de Línea a Otorgar">

                                <table class="tabla">
                                    <tr>

                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label129" runat="server" Text="Perfil:"></asp:Label><br />
                                            <asp:DropDownList CssClass="dropdown1" ID="A_Perfil_Siriac" runat="server" AutoPostBack="true" OnSelectedIndexChanged="A_Perfil_Siriac_SelectedIndexChanged"></asp:DropDownList>

                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label130" runat="server" Text="Nombre de Línea:"></asp:Label><br />
                                            <asp:DropDownList CssClass="dropdown2" ID="A_Nombre_Linea_Siriac" runat="server"></asp:DropDownList>

                                        </td>


                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label131" runat="server" Text="Contraseña:"></asp:Label><br />
                                            <asp:TextBox CssClass="caja_de_texto" ID="A_Contrasena" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>


                            </asp:Panel>


                            <asp:Panel CssClass="panel_informativo" ID="Panel14" runat="server" GroupingText="Accesos y Privilegios a Otorgar" Visible="false">
                                <table class="tabla2">
                                    <tr>
                                        <td>

                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox55" runat="server" />
                                                <asp:Label ID="Label132" AssociatedControlID="CheckBox55" runat="server" Text="Gestión Inbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox56" runat="server" />
                                                <asp:Label ID="Label133" AssociatedControlID="CheckBox56" runat="server"
                                                    Text="Gestión Outbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox57" runat="server" />
                                                <asp:Label ID="Label134" AssociatedControlID="CheckBox57" runat="server"
                                                    Text="Midas Activación" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox58" runat="server" />
                                                <asp:Label ID="Label135" AssociatedControlID="CheckBox58" runat="server"
                                                    Text="Incremento de Tarifa" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox59" runat="server" />
                                                <asp:Label ID="Label136" AssociatedControlID="CheckBox59" runat="server"
                                                    Text="Ayuda Ventas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox60" runat="server" />
                                                <asp:Label ID="Label137" AssociatedControlID="CheckBox60" runat="server"
                                                    Text="Historico de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>

                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox61" runat="server" />
                                                <asp:Label ID="Label138" AssociatedControlID="CheckBox61" runat="server"
                                                    Text="Pqr y Marcaciones RR" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox62" runat="server" />
                                                <asp:Label ID="Label139" AssociatedControlID="CheckBox62" runat="server"
                                                    Text="Ordenes Abiertas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox98" runat="server" />
                                                <asp:Label ID="Label175" AssociatedControlID="CheckBox98" runat="server"
                                                    Text="Gestión Blending" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox99" runat="server" />
                                                <asp:Label ID="Label176" AssociatedControlID="CheckBox99" runat="server"
                                                    Text="Activación" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox100" runat="server" />
                                                <asp:Label ID="Label177" AssociatedControlID="CheckBox100" runat="server"
                                                    Text="Convenio Electrónico" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox101" runat="server" />
                                                <asp:Label ID="Label178" AssociatedControlID="CheckBox101" runat="server"
                                                    Text="Detractores" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox102" runat="server" />
                                                <asp:Label ID="Label179" AssociatedControlID="CheckBox102" runat="server"
                                                    Text="Reincidencia" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox103" runat="server" />
                                                <asp:Label ID="Label180" AssociatedControlID="CheckBox103" runat="server"
                                                    Text="Ventas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox104" runat="server" />
                                                <asp:Label ID="Label181" AssociatedControlID="CheckBox104" runat="server"
                                                    Text="Logistica Inversa" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox105" runat="server" />
                                                <asp:Label ID="Label182" AssociatedControlID="CheckBox105" runat="server"
                                                    Text="Fraudes" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox193" runat="server" />
                                                <asp:Label ID="Label235" AssociatedControlID="CheckBox193" runat="server"
                                                    Text="Claro Video" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox204" runat="server" />
                                                <asp:Label ID="Label286" AssociatedControlID="CheckBox204" runat="server"
                                                    Text="Docsis y Overlap" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox219" runat="server" />
                                                <asp:Label ID="Label301" AssociatedControlID="CheckBox219" runat="server"
                                                    Text="Traslados - Crear Direccion" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox220" runat="server" />
                                                <asp:Label ID="Label302" AssociatedControlID="CheckBox220" runat="server"
                                                    Text="Direcciones Creadas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Panel CssClass="panel_informativo" ID="Panel15" runat="server" GroupingText="Accesos y Privilegios a Otorgar" Visible="false">
                                <table class="tabla2">
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox63" runat="server" />
                                                <asp:Label ID="Label140" AssociatedControlID="CheckBox63" runat="server"
                                                    Text="Casos Abiertos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox64" runat="server" />
                                                <asp:Label ID="Label141" AssociatedControlID="CheckBox64" runat="server"
                                                    Text="Seguimiento de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox65" runat="server" />
                                                <asp:Label ID="Label142" AssociatedControlID="CheckBox65" runat="server"
                                                    Text="Consulta de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox66" runat="server" />
                                                <asp:Label ID="Label143" AssociatedControlID="CheckBox66" runat="server"
                                                    Text="Gestión Inbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox221" runat="server" />
                                                <asp:Label ID="Label303" AssociatedControlID="CheckBox221" runat="server"
                                                    Text="Crear Direcciones" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox222" runat="server" />
                                                <asp:Label ID="Label304" AssociatedControlID="CheckBox222" runat="server"
                                                    Text="Seguimientos Traslados" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Panel CssClass="panel_informativo" ID="Panel16" runat="server" GroupingText="Accesos y Privilegios a Otorgar" Visible="false">
                                <table class="tabla2">
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox67" runat="server" />
                                                <asp:Label ID="Label144" AssociatedControlID="CheckBox67" runat="server"
                                                    Text="Creación de Usuarios" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox68" runat="server" />
                                                <asp:Label ID="Label145" AssociatedControlID="CheckBox68" runat="server"
                                                    Text="Consulta de Usuarios" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox69" runat="server" />
                                                <asp:Label ID="Label146" AssociatedControlID="CheckBox69" runat="server"
                                                    Text="Actualización de Usuarios" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox70" runat="server" />
                                                <asp:Label ID="Label147" AssociatedControlID="CheckBox70" runat="server"
                                                    Text="Consulta de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox71" runat="server" />
                                                <asp:Label ID="Label148" AssociatedControlID="CheckBox71" runat="server"
                                                    Text="Consulta de Paloteo" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox72" runat="server" />
                                                <asp:Label ID="Label149" AssociatedControlID="CheckBox72" runat="server"
                                                    Text="Consulta de Gestión" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox73" runat="server" />
                                                <asp:Label ID="Label150" AssociatedControlID="CheckBox73" runat="server"
                                                    Text="Consulta Outbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox74" runat="server" />
                                                <asp:Label ID="Label151" AssociatedControlID="CheckBox74" runat="server"
                                                    Text="Consulta Rechazos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox75" runat="server" />
                                                <asp:Label ID="Label152" AssociatedControlID="CheckBox75" runat="server"
                                                    Text="Actualización de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox76" runat="server" />
                                                <asp:Label ID="Label153" AssociatedControlID="CheckBox76" runat="server"
                                                    Text="Actualizar Marcaciones" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox77" runat="server" />
                                                <asp:Label ID="Label154" AssociatedControlID="CheckBox77" runat="server"
                                                    Text="Creación de Marcaciones" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox78" runat="server" />
                                                <asp:Label ID="Label155" AssociatedControlID="CheckBox78" runat="server"
                                                    Text="Reporte de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox79" runat="server" />
                                                <asp:Label ID="Label156" AssociatedControlID="CheckBox79" runat="server"
                                                    Text="Reporte de Paloteo" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox80" runat="server" />
                                                <asp:Label ID="Label157" AssociatedControlID="CheckBox80" runat="server"
                                                    Text="Reporte Outbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox81" runat="server" />
                                                <asp:Label ID="Label158" AssociatedControlID="CheckBox81" runat="server"
                                                    Text="Reporte Midas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox110" runat="server" />
                                                <asp:Label ID="Label187" AssociatedControlID="CheckBox110" runat="server"
                                                    Text="Consulta Blending" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox111" runat="server" />
                                                <asp:Label ID="Label188" AssociatedControlID="CheckBox111" runat="server"
                                                    Text="Reporte Ventas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox194" runat="server" />
                                                <asp:Label ID="Label236" AssociatedControlID="CheckBox194" runat="server"
                                                    Text="Actualizacion Usuarios Masivo" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox195" runat="server" />
                                                <asp:Label ID="Label237" AssociatedControlID="CheckBox195" runat="server"
                                                    Text="Pieza Buen Servicio" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox223" runat="server" />
                                                <asp:Label ID="Label305" AssociatedControlID="CheckBox223" runat="server"
                                                    Text="Consulta Solicitudes Direccion" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox224" runat="server" />
                                                <asp:Label ID="Label306" AssociatedControlID="CheckBox224" runat="server"
                                                    Text="Consulta Interacciones Direccion" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Button CssClass="button" ID="Actualizar_Usuario" runat="server" Text="Actualizar Usuario" OnClick="Actualizar_Usuario_Click" />

                        </ContentTemplate>
                    </asp:UpdatePanel>

                </div>
            </div>
            <div id="Cuarto_div">
                <div id="Cuarto-tab" class="tab-content">
                    <h3 class="Titulos">FORMULARIO PARA OTORGAR ACCESOS A LOS USUARIOS DE FORMA MASIVA</h3>
                    <asp:UpdatePanel runat="server" ID="UpdatePanel2">
                        <ContentTemplate>
                            <asp:Panel CssClass="panel_informativo" ID="Panel27" runat="server" GroupingText="Grupo de usuarios">
                                <table class="tabla">
                                    <tr>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label282" runat="server" Text="Aliado:"></asp:Label><br />
                                            <asp:DropDownList CssClass="dropdown2" ID="Aliado_D" runat="server"></asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label283" runat="server" Text="Perfil:"></asp:Label><br />
                                            <asp:DropDownList CssClass="dropdown1" ID="Perfil_A_Masivo" runat="server"></asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:Button CssClass="button" ID="Activa_C" runat="server" Text="Buscar Aliado" OnClick="Activa_Click" Style="display: none;" />
                                            <asp:Button CssClass="button" ID="Button3" runat="server" Text="Buscar Usuarios" OnClick="Buscar_Usuarios_Click" Style="left: 20px;" />
                                        </td>
                                    </tr>
                                    <tr>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Panel CssClass="panel_informativo" ID="Panel22" runat="server" GroupingText="Datos de los Usuarios en Holos" Visible="false">
                                <br />
                                <asp:GridView CssClass="mGrid" ID="GV_Usuarios_Masivos" runat="server" AutoGenerateColumns="False" Style="max-width: 96%; margin-left: 5px; margin-top: 5px;">
                                    <Columns>
                                        <asp:BoundField DataField="CEDULA" HeaderText="CEDULA" />
                                        <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE" />
                                        <asp:BoundField DataField="ALIADO" HeaderText="ALIADO" />
                                        <asp:BoundField DataField="NOMBRE_LINEA" HeaderText="NOMBRE DE LINEA" />
                                        <asp:BoundField DataField="USUARIO_RR" HeaderText="USUARIO RR" />
                                        <asp:BoundField DataField="USUARIO_AGENDAMIENTO" HeaderText="USUARIO DE AGENDAMIENTO" />
                                        <asp:BoundField DataField="USUARIO_GERENCIA" HeaderText="USUARIO DE GERENCIA" />
                                        <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" />
                                        <asp:BoundField DataField="CANAL" HeaderText="CANAL" />
                                        <asp:BoundField DataField="OPERACION" HeaderText="OPERACION" />
                                        <asp:BoundField DataField="GRUPO" HeaderText="GRUPO" />
                                        <asp:BoundField DataField="CARGO" HeaderText="CARGO" />
                                        <asp:BoundField DataField="SEGMENTO" HeaderText="SEGMENTO" />
                                        <asp:BoundField DataField="CONTRASENA" HeaderText="CONTRASEÑA" />
                                        <asp:BoundField DataField="ID_NOMBRE_LINEA" HeaderText="ID NOMBRE LINEA" />
                                        <asp:TemplateField HeaderImageUrl="~/Estilos/Imagenes/Check.png">
                                            <%--<HeaderTemplate>
                                                <asp:CheckBox ID="chkHeader" runat="server" onclick="seleccionar_todo(id);" />
                                            </HeaderTemplate>--%>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="CheckBox186" runat="server" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>

                            </asp:Panel>

                            <asp:Panel CssClass="panel_informativo" ID="Panel23" runat="server" GroupingText="Perfíl a Otorgar" Visible="false">
                                <table class="tabla">
                                    <tr>
                                        <td>
                                            <asp:Label CssClass="texto_informativo" ID="Label242" runat="server" Text="Perfil:"></asp:Label><br />
                                            <asp:DropDownList CssClass="dropdown1" ID="Perfil_A_Cambiar" runat="server" OnSelectedIndexChanged="Accesos_Masivo_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>

                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Panel CssClass="panel_informativo" ID="Panel24" runat="server" GroupingText="Accesos y Privilegios a Otorgar" Visible="false">
                                <table class="tabla2">
                                    <tr>
                                        <td>

                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox149" runat="server" />
                                                <asp:Label ID="Label245" AssociatedControlID="CheckBox149" runat="server" Text="Gestión Inbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox150" runat="server" />
                                                <asp:Label ID="Label246" AssociatedControlID="CheckBox150" runat="server"
                                                    Text="Gestión Outbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox151" runat="server" />
                                                <asp:Label ID="Label247" AssociatedControlID="CheckBox151" runat="server"
                                                    Text="Midas Activación" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox152" runat="server" />
                                                <asp:Label ID="Label248" AssociatedControlID="CheckBox152" runat="server"
                                                    Text="Incremento de Tarifa" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox153" runat="server" />
                                                <asp:Label ID="Label249" AssociatedControlID="CheckBox153" runat="server"
                                                    Text="Ayuda Ventas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox154" runat="server" />
                                                <asp:Label ID="Label250" AssociatedControlID="CheckBox154" runat="server"
                                                    Text="Historico de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>

                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox155" runat="server" />
                                                <asp:Label ID="Label251" AssociatedControlID="CheckBox155" runat="server"
                                                    Text="Pqr y Marcaciones RR" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox156" runat="server" />
                                                <asp:Label ID="Label252" AssociatedControlID="CheckBox156" runat="server"
                                                    Text="Ordenes Abiertas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox157" runat="server" />
                                                <asp:Label ID="Label253" AssociatedControlID="CheckBox157" runat="server"
                                                    Text="Gestión Blending" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox158" runat="server" />
                                                <asp:Label ID="Label254" AssociatedControlID="CheckBox158" runat="server"
                                                    Text="Activación" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox159" runat="server" />
                                                <asp:Label ID="Label255" AssociatedControlID="CheckBox159" runat="server"
                                                    Text="Convenio Electrónico" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox160" runat="server" />
                                                <asp:Label ID="Label256" AssociatedControlID="CheckBox160" runat="server"
                                                    Text="Detractores" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox161" runat="server" />
                                                <asp:Label ID="Label257" AssociatedControlID="CheckBox161" runat="server"
                                                    Text="Reincidencia" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox162" runat="server" />
                                                <asp:Label ID="Label258" AssociatedControlID="CheckBox162" runat="server"
                                                    Text="Ventas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox163" runat="server" />
                                                <asp:Label ID="Label259" AssociatedControlID="CheckBox163" runat="server"
                                                    Text="Logistica Inversa" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox164" runat="server" />
                                                <asp:Label ID="Label260" AssociatedControlID="CheckBox164" runat="server"
                                                    Text="Fraudes" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox196" runat="server" />
                                                <asp:Label ID="Label238" AssociatedControlID="CheckBox196" runat="server"
                                                    Text="Claro Video" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox206" runat="server" />
                                                <asp:Label ID="Label288" AssociatedControlID="CheckBox206" runat="server"
                                                    Text="Docsis y Overlap" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox225" runat="server" />
                                                <asp:Label ID="Label307" AssociatedControlID="CheckBox225" runat="server"
                                                    Text="Traslados - Crear Direccion" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox226" runat="server" />
                                                <asp:Label ID="Label308" AssociatedControlID="CheckBox226" runat="server"
                                                    Text="Direcciones Creadas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>

                                </table>
                            </asp:Panel>
                            <asp:Panel CssClass="panel_informativo" ID="Panel25" runat="server" GroupingText="Accesos y Privilegios a Otorgar" Visible="false">
                                <table class="tabla2">
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox165" runat="server" />
                                                <asp:Label ID="Label261" AssociatedControlID="CheckBox165" runat="server"
                                                    Text="Casos Abiertos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox166" runat="server" />
                                                <asp:Label ID="Label262" AssociatedControlID="CheckBox166" runat="server"
                                                    Text="Seguimiento de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox167" runat="server" />
                                                <asp:Label ID="Label263" AssociatedControlID="CheckBox167" runat="server"
                                                    Text="Consulta de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox168" runat="server" />
                                                <asp:Label ID="Label264" AssociatedControlID="CheckBox168" runat="server"
                                                    Text="Gestión Inbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox227" runat="server" />
                                                <asp:Label ID="Label309" AssociatedControlID="CheckBox227" runat="server"
                                                    Text="Crear Direcciones" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox228" runat="server" />
                                                <asp:Label ID="Label310" AssociatedControlID="CheckBox228" runat="server"
                                                    Text="Seguimientos Traslados" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Panel CssClass="panel_informativo" ID="Panel26" runat="server" GroupingText="Accesos y Privilegios a Otorgar" Visible="false">
                                <table class="tabla2">
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox169" runat="server" />
                                                <asp:Label ID="Label265" AssociatedControlID="CheckBox169" runat="server"
                                                    Text="Creación de Usuarios" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox170" runat="server" />
                                                <asp:Label ID="Label266" AssociatedControlID="CheckBox170" runat="server"
                                                    Text="Consulta de Usuarios" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox171" runat="server" />
                                                <asp:Label ID="Label267" AssociatedControlID="CheckBox171" runat="server"
                                                    Text="Actualización de Usuarios" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox172" runat="server" />
                                                <asp:Label ID="Label268" AssociatedControlID="CheckBox172" runat="server"
                                                    Text="Consulta de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox173" runat="server" />
                                                <asp:Label ID="Label269" AssociatedControlID="CheckBox173" runat="server"
                                                    Text="Consulta de Paloteo" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox174" runat="server" />
                                                <asp:Label ID="Label270" AssociatedControlID="CheckBox174" runat="server"
                                                    Text="Consulta de Gestión" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox175" runat="server" />
                                                <asp:Label ID="Label271" AssociatedControlID="CheckBox175" runat="server"
                                                    Text="Consulta Outbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox176" runat="server" />
                                                <asp:Label ID="Label272" AssociatedControlID="CheckBox176" runat="server"
                                                    Text="Consulta Rechazos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox177" runat="server" />
                                                <asp:Label ID="Label273" AssociatedControlID="CheckBox177" runat="server"
                                                    Text="Actualización de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox178" runat="server" />
                                                <asp:Label ID="Label274" AssociatedControlID="CheckBox178" runat="server"
                                                    Text="Actualizar Marcaciones" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox179" runat="server" />
                                                <asp:Label ID="Label275" AssociatedControlID="CheckBox179" runat="server"
                                                    Text="Creación de Marcaciones" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox180" runat="server" />
                                                <asp:Label ID="Label276" AssociatedControlID="CheckBox180" runat="server"
                                                    Text="Reporte de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox181" runat="server" />
                                                <asp:Label ID="Label277" AssociatedControlID="CheckBox181" runat="server"
                                                    Text="Reporte de Paloteo" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox182" runat="server" />
                                                <asp:Label ID="Label278" AssociatedControlID="CheckBox182" runat="server"
                                                    Text="Reporte Outbound" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox183" runat="server" />
                                                <asp:Label ID="Label279" AssociatedControlID="CheckBox183" runat="server"
                                                    Text="Reporte Midas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox184" runat="server" />
                                                <asp:Label ID="Label280" AssociatedControlID="CheckBox184" runat="server"
                                                    Text="Consulta Blending" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox185" runat="server" />
                                                <asp:Label ID="Label281" AssociatedControlID="CheckBox185" runat="server"
                                                    Text="Reporte Ventas" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox197" runat="server" />
                                                <asp:Label ID="Label239" AssociatedControlID="CheckBox197" runat="server"
                                                    Text="Actualizacion Usuarios Masivo" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox198" runat="server" />
                                                <asp:Label ID="Label240" AssociatedControlID="CheckBox198" runat="server"
                                                    Text="Pieza Buen Servicio" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox229" runat="server" />
                                                <asp:Label ID="Label311" AssociatedControlID="CheckBox229" runat="server"
                                                    Text="Consulta Solicitudes Direccion" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="SingleCheckbox">
                                                <asp:CheckBox ID="CheckBox230" runat="server" />
                                                <asp:Label ID="Label312" AssociatedControlID="CheckBox230" runat="server"
                                                    Text="Consulta Interacciones Direccion" CssClass="CheckBoxLabel"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Button CssClass="button" ID="Button2" runat="server" Text="Actualizar Usuarios" OnClick="Actualizar_Usuarios_Click" />

                        </ContentTemplate>
                    </asp:UpdatePanel>

                </div>
            </div>
        </div>

    </asp:Panel>

    <!-- NUEVO SCRIP DE DISEÑO-->
    <div class="modal-wrapper" id="Carga_Masiva">
        <div class="Carga_Masiva-contenedor">
            <a class="Carga_Masiva-cerrar" href="#">X</a>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <h2>CARGA MASIVA DE USUARIOS</h2>
                    <hr />
                    <div class="numeros">1</div>
                    <hr />
                    <div class="Texto_Informativo">Inicialmente debe descargar el Excel adjunto y llenar UNICAMENTE la columna "Cedula":</div>
                    <asp:HyperLink CssClass="hiperlink_masivo" ID="HyperLink1" runat="server" NavigateUrl="Archivo_Descargable/Formato_Carga_Masiva_Siriac.xls">
                    <div class="descarga_Arcvhivo" id="hiperlink_masivo"> 
                    </div>
                    </asp:HyperLink>
                    <hr />
                    <div class="numeros">2</div>
                    <hr />
                    <div class="Texto_Informativo">Agregue el Excel en formato "97-2003 .XLS" ya diligenciado de la manera correcta y carguelo: </div>
                    <asp:FileUpload ID="Cargar_Excel" runat="server" />
                    <asp:Button ID="btnUpload" CssClass="button" runat="server" Text="Cargar" OnClick="btnUpload_Click" PostBackUrl="Administracion_de_Usuarios.aspx#Carga_Masiva" />
                    <hr />
                    <div class="numeros">3</div>
                    <hr />
                    <div class="Texto_Informativo">Visualize la informacion cargada desde Excel y que fue cotejada en Holos: </div>
                    <asp:Panel CssClass="panel_informativo" ID="Panel17" runat="server" GroupingText="" Visible="false">
                        <asp:GridView CssClass="mGrid" ID="GridView1" runat="server" AutoGenerateColumns="False" Style="max-width: 950px;">
                            <Columns>
                                <asp:BoundField DataField="CEDULA" HeaderText="CEDULA" />
                                <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE" />
                                <asp:BoundField DataField="ALIADO" HeaderText="ALIADO" />
                                <asp:BoundField DataField="Nombre_Linea" HeaderText="NOMBRE DE LINEA" />
                                <asp:BoundField DataField="Usuario_RR" HeaderText="USUARIO RR" />
                                <asp:BoundField DataField="Usuario_Agendamiento" HeaderText="USUARIO DE AGENDAMIENTO" />
                                <asp:BoundField DataField="Usuario_Gerencia" HeaderText="USUARIO DE GERENCIA" />
                                <asp:BoundField DataField="Estado" HeaderText="ESTADO" />
                                <asp:BoundField DataField="Canal" HeaderText="CANAL" />
                                <asp:BoundField DataField="Operacion" HeaderText="OPERACION" />
                                <asp:BoundField DataField="Grupo" HeaderText="GRUPO" />
                                <asp:BoundField DataField="Cargo" HeaderText="CARGO" />
                                <asp:BoundField DataField="Segmento" HeaderText="SEGMENTO" />
                                <asp:BoundField DataField="Registrado" HeaderText="REGISTRADO" />
                            </Columns>
                        </asp:GridView>
                    </asp:Panel>
                    <hr />
                    <%--<asp:Label ID="Label500" runat="server" Text="Label"></asp:Label>--%>
                    <div class="numeros">4</div>
                    <hr />
                    <div class="Texto_Informativo">Seleccione un Perfil, el Nombre de Linea a la que pertenecen y establezca una Contraseña. (Tenga en cuenta que esto se aplicara para todos los usuarios de la misma forma en que se seleccione): </div>
                    <asp:Panel CssClass="panel_informativo" ID="Panel18" runat="server" GroupingText="" Visible="false">
                        <table class="tabla">
                            <tr>
                                <td>
                                    <asp:Label CssClass="texto_informativo" ID="Label189" runat="server" Text="Perfil:"></asp:Label><br />
                                    <asp:DropDownList CssClass="dropdown1" ID="Perfil_Masivo" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Perfil_Masivo_SelectedIndexChanged"></asp:DropDownList>

                                </td>
                                <td>
                                    <asp:Label CssClass="texto_informativo" ID="Label190" runat="server" Text="Nombre de Línea:"></asp:Label><br />
                                    <asp:DropDownList CssClass="dropdown2" ID="Masivo_Nombre_Linea" runat="server"></asp:DropDownList>

                                </td>


                                <td>
                                    <asp:Label CssClass="texto_informativo" ID="Label191" runat="server" Text="Contraseña:"></asp:Label><br />
                                    <asp:TextBox CssClass="caja_de_texto" ID="Contrasena_M" runat="server"></asp:TextBox>
                                </td>


                            </tr>
                        </table>
                    </asp:Panel>
                    <hr />
                    <div class="numeros">5</div>
                    <hr />
                    <div class="Texto_Informativo">Seleccione cuales son los Accesos que se otorgaran en la plataforma a los Usuarios : </div>
                    <asp:Panel CssClass="panel_informativo" ID="Panel19" runat="server" GroupingText="" Visible="false">
                        <table class="tabla2">
                            <tr>
                                <td>

                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox112" runat="server" />
                                        <asp:Label ID="Label192" AssociatedControlID="CheckBox112" runat="server"
                                            Text="Gestión Inbound" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox113" runat="server" />
                                        <asp:Label ID="Label193" AssociatedControlID="CheckBox113" runat="server"
                                            Text="Gestión Outbound" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox114" runat="server" />
                                        <asp:Label ID="Label194" AssociatedControlID="CheckBox114" runat="server"
                                            Text="Midas Activación" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox115" runat="server" />
                                        <asp:Label ID="Label195" AssociatedControlID="CheckBox115" runat="server"
                                            Text="Incremento de Tarifa" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox116" runat="server" />
                                        <asp:Label ID="Label196" AssociatedControlID="CheckBox116" runat="server"
                                            Text="Ayuda Ventas" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox117" runat="server" />
                                        <asp:Label ID="Label197" AssociatedControlID="CheckBox117" runat="server"
                                            Text="Historico de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>

                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox118" runat="server" />
                                        <asp:Label ID="Label198" AssociatedControlID="CheckBox118" runat="server"
                                            Text="Pqr y Marcaciones RR" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox119" runat="server" />
                                        <asp:Label ID="Label199" AssociatedControlID="CheckBox119" runat="server"
                                            Text="Ordenes Abiertas" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox120" runat="server" />
                                        <asp:Label ID="Label200" AssociatedControlID="CheckBox120" runat="server"
                                            Text="Gestión Blending" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox121" runat="server" />
                                        <asp:Label ID="Label201" AssociatedControlID="CheckBox121" runat="server"
                                            Text="Activación" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox122" runat="server" />
                                        <asp:Label ID="Label202" AssociatedControlID="CheckBox122" runat="server"
                                            Text="Convenio Electrónico" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox123" runat="server" />
                                        <asp:Label ID="Label203" AssociatedControlID="CheckBox123" runat="server"
                                            Text="Detractores" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox124" runat="server" />
                                        <asp:Label ID="Label204" AssociatedControlID="CheckBox124" runat="server"
                                            Text="Reincidencia" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox125" runat="server" />
                                        <asp:Label ID="Label205" AssociatedControlID="CheckBox125" runat="server"
                                            Text="Ventas" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox126" runat="server" />
                                        <asp:Label ID="Label206" AssociatedControlID="CheckBox126" runat="server"
                                            Text="Logistica Inversa" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox127" runat="server" />
                                        <asp:Label ID="Label207" AssociatedControlID="CheckBox127" runat="server"
                                            Text="Fraudes" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox199" runat="server" />
                                        <asp:Label ID="Label241" AssociatedControlID="CheckBox199" runat="server"
                                            Text="Claro Video" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox205" runat="server" />
                                        <asp:Label ID="Label287" AssociatedControlID="CheckBox205" runat="server"
                                            Text="Docsis y Overlap" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox231" runat="server" />
                                        <asp:Label ID="Label313" AssociatedControlID="CheckBox231" runat="server"
                                            Text="Traslados - Crear Direccion" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox232" runat="server" />
                                        <asp:Label ID="Label314" AssociatedControlID="CheckBox232" runat="server"
                                            Text="Direcciones Creadas" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel CssClass="panel_informativo" ID="Panel20" runat="server" GroupingText="" Visible="false">
                        <table class="tabla2">
                            <tr>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox128" runat="server" />
                                        <asp:Label ID="Label208" AssociatedControlID="CheckBox128" runat="server"
                                            Text="Casos Abiertos" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox129" runat="server" />
                                        <asp:Label ID="Label209" AssociatedControlID="CheckBox129" runat="server"
                                            Text="Seguimiento de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox130" runat="server" />
                                        <asp:Label ID="Label210" AssociatedControlID="CheckBox130" runat="server"
                                            Text="Consulta de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox131" runat="server" />
                                        <asp:Label ID="Label211" AssociatedControlID="CheckBox131" runat="server"
                                            Text="Gestión Inbound" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox233" runat="server" />
                                        <asp:Label ID="Label315" AssociatedControlID="CheckBox233" runat="server"
                                            Text="Crear Direcciones" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox234" runat="server" />
                                        <asp:Label ID="Label316" AssociatedControlID="CheckBox234" runat="server"
                                            Text="Seguimientos Traslados" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel CssClass="panel_informativo" ID="Panel21" runat="server" GroupingText="" Visible="false">
                        <table class="tabla2">
                            <tr>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox132" runat="server" />
                                        <asp:Label ID="Label212" AssociatedControlID="CheckBox132" runat="server"
                                            Text="Creación de Usuarios" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox133" runat="server" />
                                        <asp:Label ID="Label213" AssociatedControlID="CheckBox133" runat="server"
                                            Text="Consulta de Usuarios" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox134" runat="server" />
                                        <asp:Label ID="Label214" AssociatedControlID="CheckBox134" runat="server"
                                            Text="Actualización de Usuarios" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox135" runat="server" />
                                        <asp:Label ID="Label215" AssociatedControlID="CheckBox135" runat="server"
                                            Text="Consulta de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox136" runat="server" />
                                        <asp:Label ID="Label216" AssociatedControlID="CheckBox136" runat="server"
                                            Text="Consulta de Paloteo" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox137" runat="server" />
                                        <asp:Label ID="Label217" AssociatedControlID="CheckBox137" runat="server"
                                            Text="Consulta de Gestión" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>

                            </tr>
                            <tr>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox138" runat="server" />
                                        <asp:Label ID="Label218" AssociatedControlID="CheckBox138" runat="server"
                                            Text="Consulta Outbound" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox139" runat="server" />
                                        <asp:Label ID="Label219" AssociatedControlID="CheckBox139" runat="server"
                                            Text="Consulta Rechazos" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox140" runat="server" />
                                        <asp:Label ID="Label220" AssociatedControlID="CheckBox140" runat="server"
                                            Text="Actualización de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox141" runat="server" />
                                        <asp:Label ID="Label221" AssociatedControlID="CheckBox141" runat="server"
                                            Text="Actualizar Marcaciones" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox142" runat="server" />
                                        <asp:Label ID="Label222" AssociatedControlID="CheckBox142" runat="server"
                                            Text="Creación de Marcaciones" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox143" runat="server" />
                                        <asp:Label ID="Label223" AssociatedControlID="CheckBox143" runat="server"
                                            Text="Reporte de Casos" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>

                            </tr>
                            <tr>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox144" runat="server" />
                                        <asp:Label ID="Label224" AssociatedControlID="CheckBox144" runat="server"
                                            Text="Reporte de Paloteo" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox145" runat="server" />
                                        <asp:Label ID="Label225" AssociatedControlID="CheckBox145" runat="server"
                                            Text="Reporte Outbound" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox146" runat="server" />
                                        <asp:Label ID="Label226" AssociatedControlID="CheckBox146" runat="server"
                                            Text="Reporte Midas" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox147" runat="server" />
                                        <asp:Label ID="Label227" AssociatedControlID="CheckBox147" runat="server"
                                            Text="Consulta Blending" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox148" runat="server" />
                                        <asp:Label ID="Label228" AssociatedControlID="CheckBox148" runat="server"
                                            Text="Reporte Ventas" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox200" runat="server" />
                                        <asp:Label ID="Label243" AssociatedControlID="CheckBox200" runat="server"
                                            Text="Actualizacion Usuarios Masivo" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox201" runat="server" />
                                        <asp:Label ID="Label244" AssociatedControlID="CheckBox201" runat="server"
                                            Text="Pieza Buen Servicio" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox235" runat="server" />
                                        <asp:Label ID="Label317" AssociatedControlID="CheckBox235" runat="server"
                                            Text="Consulta Solicitudes Direccion" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="SingleCheckbox">
                                        <asp:CheckBox ID="CheckBox236" runat="server" />
                                        <asp:Label ID="Label318" AssociatedControlID="CheckBox236" runat="server"
                                            Text="Consulta Interacciones Direccion" CssClass="CheckBoxLabel"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Button CssClass="button" ID="Button1" runat="server" Text="Crear Usuario" OnClick="Crear_Usuario_Masivo_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    </div>

</asp:Content>

