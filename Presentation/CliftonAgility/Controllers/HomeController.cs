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
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using CliftonAgility.Helpers;
    using CliftonAgility.Models.Contact;
    using CliftonAgility.Models.Emails;

    /// <summary>
    /// The home controller.
    /// </summary>
    public class HomeController : Controller
    {
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
            
            await message.SendAsync();
            await confirmation.SendAsync();

            return this.View("ThankYou");
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
    }
}