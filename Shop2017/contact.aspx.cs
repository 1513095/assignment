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
            protected void sendbtn_Click(object sender, EventArgs e)
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
                    smtpClient.Credentials = new System.Net.NetworkCredential("VirtualVolumes@gmail.com", "DontReadThis123");
                    using (MailMessage message = new MailMessage(totxt.Text, "VirtualVolumes@gmail.com"))
                    {
                        message.Subject = subtxt.Text;
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(nametxt.Text + Environment.NewLine);
                        sb.AppendLine(messagetxt.Text + Environment.NewLine);
                        sb.AppendLine(totxt.Text + Environment.NewLine);
                        message.Body = sb.ToString();
                        message.IsBodyHtml = false;
                        smtpClient.Send(message);
                    }
                    sendlbl.Text = "Email was sent successfully.";
                }
                catch (Exception)
                {
                    sendlbl.Text = "Email did not send.";
                }
            }
        }
    }
}