using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.IO;

namespace ExportarParaImpressaoEPDF
{
    public partial class EnviarEmail : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void enviarEmail_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add("jonathanlemos@outlook.com"); //quem recebe (para)
                mail.From = new MailAddress("jonathanlemosrj@gmail.com"); //quem envia (de)
                mail.Subject = "teste"; //titulo mensagem(assunto)
                mail.IsBodyHtml = true;
                //Para evitar problemas com caracteres "estranhos", configuramos o Charset para "ISO-8859-1"
                mail.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
                mail.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");
                mail.Priority = MailPriority.Normal;

                //enviar conteudo aspx
                //StringBuilder stringBuilder = new StringBuilder();
                //StringWriter writer = new StringWriter(stringBuilder);
                //HtmlTextWriter htmlWriter = new HtmlTextWriter(writer);
                //form1.RenderControl(htmlWriter);
                //conteudo = stringBuilder.ToString();

                // enviar anexo
                string arquivo = Server.MapPath("img/MK-logo.png");
                Attachment anexo = new Attachment(arquivo, System.Net.Mime.MediaTypeNames.Application.Octet);
                mail.Attachments.Add(anexo);

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new NetworkCredential("jonathanlemosrj@gmail.com", "sj6853600");
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Port = 465; //25, 465/ssl ou 587/tls
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Send(mail);
            }
            catch (Exception er)
            {
                throw new Exception(er.Source + er.InnerException + er.Message);
            }

        }

        //protected void enviarEmail_Click(object sender, EventArgs e)
        //{
        //    SmtpClient client = new SmtpClient();
        //    client.Host = "smtp.gmail.com";
        //    client.EnableSsl = true;
        //    client.Credentials = new NetworkCredential("jonathanlemosrj@gmail.com", "sj6853600");
        //    MailMessage mail = new MailMessage();
        //    mail.Sender = new MailAddress("jonathanlemosrj@gmail.com", "ENVIADOR");
        //    mail.From = new MailAddress("jonathanlemosrj@gmail.com", "ENVIADOR");
        //    mail.To.Add(new MailAddress("jonathanlemos@outlook.com", "RECEBEDOR"));
        //    mail.Subject = "Contato";
        //    mail.Body = "abcd";
        //    mail.IsBodyHtml = true;
        //    mail.Priority = MailPriority.High;
        //    try
        //    {
        //        client.Send(mail);
        //    }
        //    catch (Exception err)
        //    {
        //        throw new Exception("Erro ao enviar email: " + err.Message);
        //    }
        //    finally
        //    {
        //        mail = null;
        //    }
        //}

    }
}