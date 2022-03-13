using System.Net;
using System.Net.Mail;
using System;


namespace Session20_Gmail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.gamil.com");



            mail.From = new MailAddress("Bahador567@gmail.com");
            mail.To.Add("Bahador567@gmail.com");
            mail.Subject = "سلام چطوری";
            mail.Body = "من خیلی خفنم";
            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential ("Bahador567@gmail.com","Pasword");
            smtpServer.EnableSsl = true;

            smtpServer.Send(mail);


        }
    }
}
