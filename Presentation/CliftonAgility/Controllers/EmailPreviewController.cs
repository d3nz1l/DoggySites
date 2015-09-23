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
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    using CliftonAgility.Models.Emails;
    using CliftonAgility.Models.Membership;

    using DoggySites.Presentation.Common.Enumerations;

    using Postal;

    /// <summary>
    /// The email preview controller.
    /// </summary>
    public class EmailPreviewController : Controller
    {
        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Index()
        {
            var publicMethods = this.GetType().GetMethods();
            var actions = publicMethods.Where(m => m.ReturnType == typeof(EmailViewResult));
            var emailActions = actions.Select(a => a.Name);

            return this.View(emailActions);
        }

        /// <summary>
        /// The contact us.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public EmailViewResult ContactUs()
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

        /// <summary>
        /// The contact us.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public EmailViewResult ContactUsConfirmation()
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

        /// <summary>
        /// The membership user.
        /// </summary>
        /// <returns>
        /// The <see cref="EmailViewResult"/>.
        /// </returns>
        public EmailViewResult MembershipUser()
        {
            var model = new MembershipUser
                            {
                                To = "to@example.com", 
                                From = "from@example.com", 
                                ReplyTo = "replyto@example.com", 
                                Forename = "Mark", 
                                Surname = "Test", 
                                EmailAddress = "test@example.com", 
                                PhoneNumber = "07987654321", 
                                Address = "123 Some Rd, Somewhere, Over Here",
                                Experience = ExperienceLevel.Novice
                            };

            model.MembersDogs = new List<MembersDog>
                           {
                               new MembersDog
                                   {
                                       PetName = "Loki", 
                                       KennelClubName = "Comhlan Dream Walker", 
                                       Breed = DogBreeds.BorderCollieWsd, 
                                       DateOfBirth = new DateTime(2009, 8, 4), 
                                       Gender = DogGender.Dog, 
                                       KennelClubNumber = "KC123456"
                                   }, 
                                new MembersDog
                                   {
                                       PetName = "Freya", 
                                       KennelClubName = "Devongem Bright Star", 
                                       Breed = DogBreeds.BorderCollieWsd, 
                                       DateOfBirth = new DateTime(2013, 4, 3), 
                                       Gender = DogGender.Bitch, 
                                       KennelClubNumber = "KC9999999"
                                   }
                           };

            return new EmailViewResult(model);
        }

        /// <summary>
        /// The membership request.
        /// </summary>
        /// <returns>
        /// The <see cref="EmailViewResult"/>.
        /// </returns>
        public EmailViewResult MembershipRequest()
        {
            var model = new MembershipRequest
            {
                To = "to@example.com", 
                From = "from@example.com", 
                ReplyTo = "replyto@example.com", 
                Forename = "Mark", 
                Surname = "Test", 
                EmailAddress = "test@example.com", 
                PhoneNumber = "07987654321",
                Address = "123 Some Rd, Somewhere, Over Here",
                Experience = ExperienceLevel.Senior
            };

            model.MembersDogs = new List<MembersDog>
                           {
                               new MembersDog
                                   {
                                       PetName = "Loki", 
                                       KennelClubName = "Comhlan Dream Walker", 
                                       Breed = DogBreeds.BorderCollieWsd, 
                                       DateOfBirth = new DateTime(2009, 8, 4), 
                                       Gender = DogGender.Dog, 
                                       KennelClubNumber = "KC123456"
                                   }, 
                                new MembersDog
                                   {
                                       PetName = "Freya", 
                                       KennelClubName = "Devongem Bright Star", 
                                       Breed = DogBreeds.BorderCollieWsd, 
                                       DateOfBirth = new DateTime(2013, 4, 3), 
                                       Gender = DogGender.Bitch, 
                                       KennelClubNumber = "KC9999999"
                                   }
                           };

            return new EmailViewResult(model);
        }
    }
}