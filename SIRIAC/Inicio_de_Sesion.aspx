<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Inicio_de_Sesion.aspx.cs" Inherits="Inicio_de_Sesion" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio de Sesion</title>
    <link href="Estilos/Inicio_de_Sesion.css?1.0.0" rel="stylesheet" />
     
</head>
<body class="body">
    <form id="form1" runat="server">
   <div class="etiquetass" id="loginn">
        <div class="central" id="central">
        <br/>
        &nbsp;&nbsp;&nbsp;<asp:Label  ID="Label1" runat="server" Text="Usuario:" ></asp:Label>&nbsp;&nbsp;
        <asp:TextBox CssClass="textbox1"  ID="Usuario" runat="server" Required="true"></asp:TextBox>
        <br/>
        <br/>
        &nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox CssClass="textbox1"  runat="server" TextMode="Password" ID="Clave" Required="true"></asp:TextBox>
        <br/>
        <br/>
        &nbsp;&nbsp;&nbsp;<asp:Button CssClass="boton1" runat="server" Text="Iniciar Sesión" ID="Aceptar" OnClick="Aceptar_Click" />
        

        </div>
    </div>
        <div class="etiquetass" id="loginnn">
        <div class="etiquetas">
            <h1 class="texto4">Claro</h1>
        </div>

        <div class="etiquetas">
            
        <h1 class="texto1" style="display:none">Sistema Integrado de Radicaciones, Información y Atención al Cliente (SIRIAC)</h1>
        <h2 class="texto2" style="display:none">Jefatura de Planeación y Estrategia - Gerencia de Cuidado al Cliente</h2>
        <h3 class="texto3" style="display:none">Claro Soluciones Fijas</h3>
            </div>
        </div>
    </form>
</body>
</html>
