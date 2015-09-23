using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CliftonAgility.Controllers
{
    using CliftonAgility.Models;

    public class MapController : Controller
    {
        // GET: Map
        public ActionResult Index(string locationId)
        {
            var factory = new LocationFactory();
            var location = factory.GetLocation(locationId);

            if (location == null)
            {
                return this.HttpNotFound();
            }

            return View(location);
        }
    }
}