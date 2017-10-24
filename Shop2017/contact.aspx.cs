using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop2017
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendBtn_Click1(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {

            }
            try
            {

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("dingdongbells18", "Chestersci123");
                using (MailMessage message = new MailMessage(ToTxt.Text, "dingdongbells18"))
                {
                    message.Subject = SubjectTxt.Text;
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(NameTxt.Text + Environment.NewLine);
                    sb.AppendLine(MessageTxt.Text + Environment.NewLine);
                    sb.AppendLine(ToTxt.Text + Environment.NewLine);
                    message.Body = sb.ToString();
                    message.IsBodyHtml = false;
                    smtpClient.Send(message);
                }
                SendLit.Text = "Email was sent successfully.";
            }
            catch (Exception)
            {
                SendLit.Text = "Email did not send.";
            }
        }
    }
}