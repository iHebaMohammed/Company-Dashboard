using Demo.DAL.Entities;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Demo.PL.Helpers
{
	public static class EmailSettings
	{
		public static async Task SendEmail(Email email) 
		{
			var client = new SmtpClient("smtp.gmail.com", 587);
			client.EnableSsl = true; // Encrypted
			client.Credentials = new NetworkCredential("ihebaadil@gmail.com" , "123456");
			client.Send("ihebaadil@gmail.com", email.To , email.Subject , email.Body);
		}
	}
}
