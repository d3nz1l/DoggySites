// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmailPreviewController.cs" company="">
//   
// </copyright>
// <summary>
//   The email preview controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CliftonAgility.Controllers
{
    using System.Web.Mvc;

    using CliftonAgility.Models.Emails;

    using Postal;

    /// <summary>
    /// The email preview controller.
    /// </summary>
    public class EmailPreviewController : Controller
    {
        /// <summary>
        /// The contact us.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult ContactUs()
        {
            var message = new ContactUsEmail("from@site.com", "to@site.com")
            {
                Name = "Testy McTest", 
                EmailAddress = "test@example.com", 
                PhoneNumber = "07987654321", 
                Message = @"Hello,

This is an example message
This is an example message
This is an example message
This is an example message
This is an example message
This is an example message
This is an example message
This is an example message"
            };

            return new EmailViewResult(message);
        }
    }
}