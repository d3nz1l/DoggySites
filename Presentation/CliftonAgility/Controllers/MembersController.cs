// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MembersController.cs" company="">
//   
// </copyright>
// <summary>
//   The members controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CliftonAgility.Controllers
{
    using System.Web.Mvc;

    using CliftonAgility.Models;

    /// <summary>
    /// The members controller.
    /// </summary>
    public class MembersController : Controller
    {
        /// <summary>
        /// The club clothing.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult ClubClothing()
        {
            return this.View(new ClothingItems());
        }

        /// <summary>
        /// The help advice.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult HelpAdvice()
        {
            return this.View(new AdviceItems());
        }

        /// <summary>
        /// The downloads.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Downloads()
        {
            return this.View(new AdviceItems());
        }
    }
}