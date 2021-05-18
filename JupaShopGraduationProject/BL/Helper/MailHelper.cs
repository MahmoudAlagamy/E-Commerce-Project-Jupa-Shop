using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace JupaShopGraduationProject.BL.Helper
{
    public static class MailHelper
    {
        public static string SendMail(string Title, string Message)
        {
            try
            {
                SmtpClient smtp = new("smtp.gmail.com", 587)
                {
                    //SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 465);

                    EnableSsl = true,


                    Credentials = new NetworkCredential("alagamymahmoud2@gmail.com", "alagamymahmoud11219951")
                };
                smtp.Send("alagamymahmoud2@gmail.com", "mahmoudalagamy846@yahoo.com", Title, Message);

                return "Mail Sent Succesfully";

            }
            catch (Exception)
            {

                return "Send Mail Faild";

            }
        }
    }
}
