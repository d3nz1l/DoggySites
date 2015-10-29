// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="">
//   
// </copyright>
// <summary>
//   The home controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CliftonAgility.Controllers
{
    using System;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using Aliencube.ReCaptcha;
    using Aliencube.ReCaptcha.Wrapper;
    using Aliencube.ReCaptcha.Wrapper.Interfaces;

    using CliftonAgility.Helpers;
    using CliftonAgility.Models.Contact;
    using CliftonAgility.Models.Emails;

    /// <summary>
    /// The home controller.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// The Recaptcha module.
        /// </summary>
        private readonly IReCaptchaV2 recaptcha;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="recaptcha">The recaptcha.</param>
        public HomeController(IReCaptchaV2 recaptcha)
        {
            this.recaptcha = recaptcha;
        }

        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Index()
        {
            return this.View();
        }

        /// <summary>
        /// The our venue.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult OurVenue()
        {
            return this.View();
        }

        /// <summary>
        /// The about.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult About()
        {
            this.ViewBag.Message = "Your application description page.";

            return this.View();
        }

        /// <summary>
        /// The contact.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult ThankYou()
        {
            return this.View();
        }

        /// <summary>
        /// The contact.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Contact()
        {
            return this.View();
        }

        /// <summary>
        /// The contact.
        /// </summary>
        /// <param name="model">
        /// The model.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        [HttpPost]
        public async Task<ActionResult> Contact(MessageForm model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            if (!await this.IsRecaptchaValidAsync())
            {
                this.ModelState.AddModelError("Recaptcha", "Please comfirm you are a person.");
                return this.View(model);
            }

            if (model.MessageType == MessageType.SellUsSomthing)
            {
                return this.RedirectToAction("NoThanks");
            }

            var siteEmailAddress = this.GetEmailAddressFromType(model.MessageType);

            var message = new ContactUsEmail(model.EmailAddress, siteEmailAddress)
                            {
                                Name = model.Name, 
                                EmailAddress = model.EmailAddress, 
                                PhoneNumber = model.TelephoneNumber, 
                                Message = model.Message
                            };
            var confirmation = new ContactUsConfirmationEmail(siteEmailAddress, model.EmailAddress)
                            {
                                Name = model.Name, 
                                EmailAddress = model.EmailAddress, 
                                PhoneNumber = model.TelephoneNumber, 
                                Message = model.Message
                            };

            var messageTask = message.SendAsync();
            var confirmationTask = confirmation.SendAsync();

            await Task.WhenAll(messageTask, confirmationTask);

            return this.View("ThankYou");
        }
        
        /// <summary>
        /// The contact.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult NoThanks()
        {
            return this.View();
        }

        /// <summary>
        /// The get email address from type.
        /// </summary>
        /// <param name="messageType">
        /// The message type.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private string GetEmailAddressFromType(MessageType messageType)
        {
            string emailAddress;

            switch (messageType)
            {
                case MessageType.Membership:

                    emailAddress = EmailAddresses.Membership;

                    break;

                default:

                    emailAddress = EmailAddresses.Information;

                    break;
            }

            return emailAddress;
        }

        /// <summary>
        /// Determines whether recaptcha is valid.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the captcha is valid.
        /// </returns>
        public async Task<bool> IsRecaptchaValidAsync()
        {
            try
            {
                var result = await this.recaptcha.SiteVerifyAsync(
                        this.Request.Form,
                        this.Request.ServerVariables);

                return result.Success;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}