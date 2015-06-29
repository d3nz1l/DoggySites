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
    using System.Security.Policy;
    using System.Threading.Tasks;
    using System.Web.Mvc;

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
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        [HttpPost]
        public Task<ActionResult> Contact(MessageForm model)
        {
            if (!ModelState.IsValid)
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

            var messageTask = message.SendAsync();
            var confirmationTask = confirmation.SendAsync();

            Task.WaitAll(messageTask, confirmationTask);

            return this.View("ThankYou");
        }

        private string GetEmailAddressFromType(MessageType messageType)
        {
            string emailAddress;

            switch (messageType)
            {
                case MessageType.Membership:

                    emailAddress = EmailAddresses.Membership;

                    break;

                default:

                    emailAddress = EmailAddresses.Info;

                    break;
            }

            return emailAddress;
        }
    }
}