//using layoutdesign.DTo;
//using layoutdesign.Helper;
//using layoutdesign.Interfaces;
//using layoutdesign.Models;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Options;
//using System;

//namespace layoutdesign.Repository
//{
//    public class Accountrepo : IAccount
//    {
//        private readonly IConfiguration _configuration;

//        private readonly UpdatePlaceHolders _updateplaceholder = new UpdatePlaceHolders(
//            new IOptions<SMTPConfigModel>(new SMTPConfigModel
//            {
//                Host = "smtp.gmail.com",
//                Port = 587,
//                UserName = "",
//                Password = "",
//                SenderAddress = "",
//                SenderDisplayName = "",
//                EnableSSL = true,
//                UseDefaultCredentials = false,
//                IsBodyHTML = true
//            })
//            );

//        public Accountrepo(IConfiguration configuration,UpdatePlaceHolders updatePlaceHolders)
//        {
//            _configuration = configuration;
//            _updateplaceholder = updatePlaceHolders;
//        }
//        public async Task SendEmailConfirmationAsync(Appuser user, string token)
//        {
//            string appDomain = _configuration.GetSection("Application:AppDomain").Value;
//            string confirmationLink = _configuration.GetSection("Application:EmailConfirmation").Value;

//            UserEmailOptions options = new UserEmailOptions
//            {
//                ToEmails = new List<string> { user.Email },
//                PlaceHolders = new List<KeyValuePair<string, string>>
//                {
//                    new KeyValuePair<string, string>("{{UserName}}", user.FisrtName),
//                    new KeyValuePair<string, string>("{{Link}}",
//                        string.Format(appDomain + confirmationLink, user.Id, token))
//                }
//            };

//            options.Subject = await _updateplaceholder.Hepler("Hello {{UserName}}, Confirm your email id.", options.PlaceHolders);

//            options.Body =await _updateplaceholder.Hepler(await _updateplaceholder.GetEmailBody("EmailConfirm"), options.PlaceHolders);

//            await _updateplaceholder.SendEmail(options);


//        }
//    }
//}
