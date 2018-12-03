using System;
using System.Net;
using System.Net.Mail;
using System.Threading;

namespace NetCoreMailSend
{
    class Program
    {
        static void Main(string[] args)
        {
            var body = "message";
            string s = string.Format("{0} \nServer time:\t{1}\nUTC time:\t{2}", body, DateTime.Now, DateTime.UtcNow);
            while(DateTime.Now.Second != 0)
            {
                Thread.Sleep(1);
            }
            s = string.Format("{0} \nServer time:\t{1}\nUTC time:\t{2}", body, DateTime.Now, DateTime.UtcNow);
            Console.WriteLine(s);
            //var fromAddress = new MailAddress("ai.mailsend@gmail.com", "From Name22");
            //var toAddress = new MailAddress("mrz.ivanov@gmail.com", "To Name22");
            //const string fromPassword = "LX38SbNReRi7bHy";
            //const string subject = "Subject1";
            //const string body = "Body1";

            //var smtp = new SmtpClient
            //{
            //    Host = "smtp.gmail.com",
            //    Port = 587,
            //    EnableSsl = true,
            //    DeliveryMethod = SmtpDeliveryMethod.Network,
            //    UseDefaultCredentials = false,
            //    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            //};
            //var userType = typeof(User);
            //userType.GetProperty("");
            //using (var message = new MailMessage(fromAddress, toAddress)
            //{
            //    Subject = subject,
            //    Body = body
            //})
            //{
            //    smtp.Send(message);
            //}
        }
    }
    class User
    {
        public int Id { get; set; }
        public string Name{ get; set; }
    }
}
