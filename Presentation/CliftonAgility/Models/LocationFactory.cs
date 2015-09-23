// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocationFactory.cs" company="">
//   
// </copyright>
// <summary>
//   The location factory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CliftonAgility.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The location factory.
    /// </summary>
    public class LocationFactory
    {
        /// <summary>
        /// The locations.
        /// </summary>
        private IList<Location> locations;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationFactory"/> class.
        /// </summary>
        public LocationFactory()
        {
            this.locations = new List<Location>
                                 {
                                     new Location
                                         {
                                             Id = "Chelvey", 
                                             Name = "Chelvey Court Farm", 
                                             Longitude = -2.76832604408264M, 
                                             Latitude = 51.4115062667691M,
                                             Address = new PostalAddress
                                                           {
                                                               HouseNameNumber = "Chelvey Court Farm",
                                                               StreetName = "Chelvey Road",
                                                               AddressLine2 = "Backwell",
                                                               AddressLine3 = "Bristol",
                                                               Postcode = "BS48 4AA"
                                                           }
                                         }
                                 };
        }

        /// <summary>
        /// The get location.
        /// </summary>
        /// <param name="locationId">
        /// The location id.
        /// </param>
        /// <returns>
        /// The <see cref="Location"/>.
        /// </returns>
        public Location GetLocation(string locationId)
        {
            return this.locations.FirstOrDefault(l => l.Id.Equals(locationId, StringComparison.OrdinalIgnoreCase));
        }
    }
}