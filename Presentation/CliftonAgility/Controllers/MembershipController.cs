// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MembershipController.cs" company="">
//   
// </copyright>
// <summary>
//   The membership controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CliftonAgility.Controllers
{
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using CliftonAgility.Helpers;
    using CliftonAgility.Models.Emails;
    using CliftonAgility.Models.Membership;

    /// <summary>
    /// The membership controller.
    /// </summary>
    public class MembershipController : Controller
    {
        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Index()
        {
            var model = new EnquiryForm();
            return this.View(model);
        }

        /// <summary>
        /// The members dog.
        /// </summary>
        /// <param name="model">
        /// The model.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        [HttpPost]
        public async Task<ActionResult> Index(EnquiryForm model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var userMessage = new MembershipUser
                                  {
                                      Forename = model.Forename,
                                      Surname = model.Surname,
                                      EmailAddress = model.EmailAddress,
                                      PhoneNumber = model.TelephoneNumber,
                                      Address = model.Address,
                                      MembersDogs = model.MembersDogs,
                                      To = model.EmailAddress,
                                      Experience = model.Experience,
                                      ReplyTo = EmailAddresses.Membership,
                                      From = EmailAddresses.Club
                                  };

            var requestMessage = new MembershipRequest
                                {
                                    Forename = model.Forename,
                                    Surname = model.Surname,
                                    EmailAddress = model.EmailAddress,
                                    PhoneNumber = model.TelephoneNumber,
                                    Address = model.Address,
                                    Experience = model.Experience,
                                    MembersDogs = model.MembersDogs,
                                    To = EmailAddresses.Membership,
                                    ReplyTo = model.EmailAddress,
                                    From = model.EmailAddress
                                };

            await userMessage.SendAsync();
            await requestMessage.SendAsync();

            return this.Thankyou(model);
        }

        /// <summary>
        /// The members dog.
        /// </summary>
        /// <param name="enquiryForm">
        /// The enquiry Form.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Thankyou(EnquiryForm enquiryForm)
        {
            return this.View("Thankyou", enquiryForm);
        }

        /// <summary>
        /// The members dog.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult MembersDog()
        {
            return this.PartialView("EditorTemplates/MembersDog", new MembersDog());
        }
    }
}