using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;

namespace RMaD.Classes{
    public static class Utils
    {       
        public static void sendEmail(string body, string from, string to, string trackingNum)         
        {
            try
            {
                const string fromPassword = "nehoseiyelgvvzid";
                MailMessage message = new MailMessage();
                message.From = new MailAddress(from, "RMad Shipping");
                message.To.Add(to);
                message.Subject = "Shipping Info for Tracking Number: " + trackingNum;
                message.IsBodyHtml = true;
                message.Body = body;

                SmtpClient smtpClient = new SmtpClient();         
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Credentials = new NetworkCredential(message.From.Address, fromPassword);
                smtpClient.Timeout = 20000;
                smtpClient.Send(message);               
            }
            catch (Exception e) 
            {
                MessageBox.Show("Email failed!");
            }            
        }

        public static void emailShipment(string trackingID, string shipDt, string arrDt, string carrier) {
            string Body = System.IO.File.ReadAllText("./EmailTemplate/email.html");
            Body = Body.Replace("%status%", "Shipped");
            Body = Body.Replace("%date%time%", DateTime.Parse(arrDt).ToString());            
            Body = Body.Replace("%tracking number%", trackingID);
            Body = Body.Replace("%carrier%", carrier);
            Body = Body.Replace("%shippingdate%", DateTime.Parse(shipDt).ToString());
            
            string toEmail = new User(LoginInfo.loggedInUser).Email();

            sendEmail(Body, "rmadshipping@gmail.com", toEmail, trackingID);
        }
    }
}
