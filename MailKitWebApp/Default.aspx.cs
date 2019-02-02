using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MimeKit;
using MailKit;
using MailKit.Security;
using MailKit.Net.Smtp;


namespace MailKitWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendButton_Click(object sender, EventArgs e)
        {
            MimeMessage message = new MimeMessage();
            try
            {
                // Feel free to add in ProtocolLogger here if you would like to get an smtp logger to output to a file. I removed it for this sample (and brevity).
                // Example: 
                // using (var client = new SmtpClient(new ProtocolLogger("D:\\home\LogFiles\\smtp.log")))
                using (var client = new SmtpClient())
                {
                    message.From.Add(new MailboxAddress("Name", "FromEmail"));
                    message.To.Add(new MailboxAddress("Name", "ToEmail"));
                    message.Subject = "Google Test Message from web app";

                    client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);

                    // Go to Google Profile to generate an app password rather than using your real password here
                    client.Authenticate("FromEmail", "GoogleAppID");

                    client.Send(message);
                    client.Disconnect(true);

                    TextBox1.Text = "Message Sent!";
                }
            }
            catch (Exception ex)
            {
                TextBox1.Text = "Something went wrong: " + ex.Message;
                
            }

        }
    }
}