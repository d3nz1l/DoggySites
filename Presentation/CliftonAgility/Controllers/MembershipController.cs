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
    using System.Collections.ObjectModel;
    using System.Web.Mvc;

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
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult MembersDog()
        {
            return this.PartialView("EditorTemplates/MembersDog", new MembersDog());
        }
    }
}