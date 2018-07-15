<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExportarParaImpressaoEPDF.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <%--<script type="text/javascript" src="js/imprimir.js" ></script>--%>
    <%--<script src="js/jquery-3.1.1.js"></script>
    <script src="https://cdn.rawgit.com/MrRio/jsPDF/master/dist/jspdf.min.js" ></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/html2canvas/0.5.0-beta4/html2canvas.min.js" ></script>--%>
</head>
<body>
    <form id="form1" runat="server">
        <div id="conteudo">
            <br />
            <span style="color:red;">11111111</span>
            <br />
            <span style="color:blue; margin-left:200px;">22222222</span>
            <br />
            <button onclick="printElem('conteudo')">Imprimir</button>
            <asp:Button ID="exportar" runat="server" OnClick="exportarPDF" />
            <button id="exportar2" >exportar 2</button>
        </div>
    </form>
</body>
<%--    <script>
        $('#exportar2').on('click', function () {
            html2canvas($('#conteudo'), {
                onrendered: function (canvas) {
                    var imgData = canvas.toDataURL('image/png');
                    var pdf = new jsPDF('p', 'mm');
                    pdf.addImage(imgData, 'PNG', 10, 10);
                    pdf.save('test.pdf');
                }
            });
        });
    </script>--%>
</html>
