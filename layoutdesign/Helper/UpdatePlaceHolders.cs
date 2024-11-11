using layoutdesign.DTo;
using Microsoft.AspNetCore.Routing.Template;
using System.Net.Mail;
using System.Net;
using System.Text;
using Microsoft.Extensions.Options;

namespace layoutdesign.Helper
{
    public class UpdatePlaceHolders
    {
        private const string templatePath = @"EmailTemplate/{0}.html";
        private readonly SMTPConfigModel _smtpConfig;

        public UpdatePlaceHolders(IOptions<SMTPConfigModel> smtpConfig)
        {
            _smtpConfig = smtpConfig.Value;
        }
        public async Task<string> Hepler(string text, List<KeyValuePair<string, string>> keyValuePairs)
        {
            if (!string.IsNullOrEmpty(text) && keyValuePairs != null)
            {
                foreach (var placeholder in keyValuePairs)
                {
                    if (text.Contains(placeholder.Key))
                    {
                        text = text.Replace(placeholder.Key, placeholder.Value);
                    }
                }
            }

            return text;
        }

        public async Task SendEmail(UserEmailOptions userEmailOptions)
        {

            MailMessage mail = new MailMessage
            {
                Subject = userEmailOptions.Subject,
                Body = userEmailOptions.Body,
                From = new MailAddress(_smtpConfig.SenderAddress, _smtpConfig.SenderDisplayName),
                IsBodyHtml = _smtpConfig.IsBodyHTML
            };

            foreach (var toEmail in userEmailOptions.ToEmails)
            {
                mail.To.Add(toEmail);
            }

            NetworkCredential networkCredential = new NetworkCredential(_smtpConfig.UserName, _smtpConfig.Password);

            SmtpClient smtpClient = new SmtpClient
            {
                Host = _smtpConfig.Host,
                Port = _smtpConfig.Port,
                EnableSsl = _smtpConfig.EnableSSL,
                UseDefaultCredentials = _smtpConfig.UseDefaultCredentials,
                Credentials = networkCredential
            };

            mail.BodyEncoding = Encoding.Default;

            await smtpClient.SendMailAsync(mail);
        }

        public async Task<string> GetEmailBody(string templateName)
        {
            var body = await Task.Run(() => File.ReadAllText(string.Format(templatePath, templateName)));
            return body;
        }
    }
}
