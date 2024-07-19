using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace officeproj
{
    class Program
    {
        static void Main(string[] args)
        {
            string fromMail = "ishu.252502@gmail.com";
            string fromPassword = "ibkg cjbs dpzr sfjz";

            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(fromMail);
            msg.Subject = "Birthday Wishes...";
            msg.To.Add(new MailAddress("ishita25.visitorz@gmail.com"));
            msg.Body = "<html><body background='https://raw.githubusercontent.com/Ishita25-sys/birthday-post/main/birthdaypost.jpg'></body></html>";
            msg.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };
            smtpClient.Send(msg);
        }
    }
}
