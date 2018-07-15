<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnviarEmail.aspx.cs" Inherits="ExportarParaImpressaoEPDF.EnviarEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <div id="conteudo" style="border:black solid 1px; font: bold 14px verdana;">
            Teste para enviar email
            <br />
            <asp:TextBox ID="aa" runat="server" Text="aa" ></asp:TextBox>
            <br />
            <asp:TextBox ID="bb" runat="server" Text="bb" ></asp:TextBox>
        </div>

        <asp:Button ID="enviarEmail" Text="enviar" runat="server" OnClick="enviarEmail_Click" />
    </div>
    </form>
</body>
</html>
