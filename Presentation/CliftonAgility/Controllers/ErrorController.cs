// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ErrorController.cs" company="">
//   
// </copyright>
// <summary>
//   The error controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CliftonAgility.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    /// The error controller.
    /// </summary>
    public class ErrorController : Controller
    {
        /// <summary>
        /// The error 404.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Error404()
        {
            return this.View();
        }

        /// <summary>
        /// The error 500.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Error500()
        {
            return this.View();
        }
    }
}