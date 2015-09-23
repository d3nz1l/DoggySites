// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnquiryForm.cs" company="">
//   
// </copyright>
// <summary>
//   The enquiry form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CliftonAgility.Models.Membership
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The enquiry form.
    /// </summary>
    public class EnquiryForm
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please give us your name. We like to know who we are talking to.")]
        [Display(Name = "Forename:")]
        public string Forename { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please give us your name. We like to know who we are talking to.")]
        [Display(Name = "Surname:")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please give us your email address, as we will need to be able reply.")]
        [EmailAddress(ErrorMessage = "Please check your email address, it appears to wrong.")]
        [Display(Name = "Email Address:")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the telephone number.
        /// </summary>
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number:")]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please give us your address. The Kennel Club require us to hold current addresses for our members.")]
        [Display(Name = "Address:")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the members dogs.
        /// </summary>
        [Required(ErrorMessage = "Please gives us your dogs details.")]
        [Display(Name = "Your dogs details:")]
        public IEnumerable<MembersDog> MembersDogs { get; set; }

        /// <summary>
        /// Gets or sets the experience.
        /// </summary>
        [Required(ErrorMessage = "Please tells us how much experience you have. This will allow us to place you in the correct class.")]
        [Display(Name = "How much experience have you had:")]
        public ExperienceLevel Experience { get; set; }
    }
}