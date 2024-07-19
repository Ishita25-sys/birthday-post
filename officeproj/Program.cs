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
            msg.Body = "<html><body background='https://img.freepik.com/free-vector/flat-golden-circle-balloons-birthday-background_52683-34659.jpg?t=st=1721368644~exp=1721372244~hmac=6c9d09b06ba6db26f868b7e8ee646796bd28da7743d262b6af7f398c4aedff33&w=996'>Happy Birthday<br><img src='https://as1.ftcdn.net/v2/jpg/03/25/69/56/1000_F_325695691_662cr0MVqqJ6NA1dzgmtlMtHCoT6aguX.jpg'></body></html>";
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
