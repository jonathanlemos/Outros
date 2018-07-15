using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ExportarParaImpressaoEPDF
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void exportarPDF(object sender, EventArgs e)
        {
            //gerarPDF(txtTextoPDF.Text, txtNomeArquivoPDF.Text);
        }

        private void gerarPDF(string texto, string arquivo)
        {
            DateTime hoje = DateTime.Now;

            if(arquivo.Contains(".pdf")) {
                arquivo = arquivo.Replace(".pdf", "");
            }

            var arquivoPDF = arquivo + hoje.Millisecond + ".pdf";

            Document doc  = new Document();
            PdfWriter.GetInstance(doc, new FileStream(Request.PhysicalApplicationPath + "\\" + arquivoPDF, FileMode.Create));
            doc.Open();
            doc.Add(new Paragraph(texto));
            doc.Close();
            Response.Redirect("~/" + arquivoPDF);
        }
    }
}