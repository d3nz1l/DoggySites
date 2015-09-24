// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlyballServiceLayer.cs" company="">
//   
// </copyright>
// <summary>
//   The flyball service layer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ServiceLayer
{
    using System.Data.Entity;

    using Doggy.Persistence;

    /// <summary>
    /// The flyball service layer.
    /// </summary>
    public class FlyballServiceLayer
    {
        public FlyballServiceLayer()
        {
            Initialise();
        }

        public void GetFastestTeamTimes()
        {
            
        }

        /// <summary>
        /// The initialise.
        /// </summary>
        public static void Initialise()
        {
            Database.SetInitializer(new DoggyDropCreateInitialiser());
        }
    }
}
