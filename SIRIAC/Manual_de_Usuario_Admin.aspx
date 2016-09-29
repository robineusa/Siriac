<%@ Page Title="" Language="C#" MasterPageFile="~/Perfil_Administrador.master" AutoEventWireup="true" CodeFile="Manual_de_Usuario_Admin.aspx.cs" Inherits="Manual_de_Usuario_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="container"><div style="text-align: left; border: none;">    
<object type="application/pdf" data="Doc/Manual_Administrador.pdf" width="100%" height="600" id="pdf"> 
<param name="src" value="Doc/Manual_Administrador.pdf" /> 
<p style="text-align:center; width: 60%;">Adobe Reader no se encuentra o la versi&oacute;n no es compatible, utiliza el icono para ir a la p&aacute;gina de descarga <br /> 
<a href="http://get.adobe.com/es/reader/" onclick="this.target='_blank'">
<img src="reader_icon_special.jpg" alt="Descargar Adobe Reader" width="32" height="32" style="border: none;" /></a> 
</p> 
</object> 
</div> 
     </div>
</asp:Content>

