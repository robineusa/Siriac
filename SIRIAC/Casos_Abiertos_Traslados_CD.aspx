<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Celula.master" AutoEventWireup="true" CodeFile="Casos_Abiertos_Traslados_CD.aspx.cs" Inherits="Casos_Abiertos_Traslados_CD" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <script type="text/javascript">
        $(document).ready(function () {
            if ('<%=Session["Acceso_1"]%>' == "1") {

            } else {
                $("#Primer_div").hide();
                $("#html").hide();
            }
            if ('<%=Session["Acceso_3"]%>' == "1") {
                if ('<%=Session["Acceso_1"]%>' == "1") {

                } else {
                    $("#css").addClass("active");
                    $("#css-tab").addClass("tab-content active");
                }
            } else {
                $("#Segundo_div").hide();
                $("#css").hide();
            }
        });

        function otorgar_permisos() {

            var activeTabIndex = -1;
            var tabNames = ["html", "javascript", "css"];
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

    <asp:Panel CssClass="panel" ID="Panel1" runat="server">
        <div id="tab-container">
            <ul class="tab-menu">
                <li id="html" class="active" onclick="otorgar_permisos()">CASOS ABIERTOS</li>
                <li id="css" onclick="otorgar_permisos()">CONSULTA DE CASOS</li>
            </ul>
            <div class="clear"></div>
            <div class="tab-top-border"></div>
            <div id="Primer_div">
                <div id="html-tab" class="tab-content active">
                    <h3 class="Titulos">BOLSA DE CASOS ABIERTOS ESCALADOS A LA CÉLULA PARA LA CREACIÓN DE DIRECCIONES</h3>
                  
                </div>
            </div>

            <div id="Segundo_div">
                <div id="css-tab" class="tab-content">
                    <h3 class="Titulos">FORMULARIO PARA LA CONSULTA DE CASOS ESCALADOS</h3>
                
                </div>
            </div>
        </div>

    </asp:Panel>
</asp:Content>

