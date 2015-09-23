// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MembershipUser.cs" company="">
//   
// </copyright>
// <summary>
//   The membership user.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CliftonAgility.Models.Emails
{
    using System.Collections.Generic;

    using CliftonAgility.Models.Membership;

    /// <summary>
    /// The membership user.
    /// </summary>
    public class MembershipUser : BaseEmail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipUser"/> class.
        /// </summary>
        public MembershipUser()
        {
            this.Subject = "Membership Request Confirmation";
        }

        /// <summary>
        /// Gets or sets the forename.
        /// </summary>
        public string Forename { get; set; }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the members dogs.
        /// </summary>
        public IEnumerable<MembersDog> MembersDogs { get; set; }

        /// <summary>
        /// Gets or sets the experience.
        /// </summary>
        public ExperienceLevel Experience { get; set; }
    }
}