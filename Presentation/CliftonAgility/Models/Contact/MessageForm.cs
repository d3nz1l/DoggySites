// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MessageForm.cs" company="">
//   
// </copyright>
// <summary>
//   The message form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CliftonAgility.Models.Contact
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The message form.
    /// </summary>
    public class MessageForm
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please give us your name. We like to know who we are talking to.")]
        [Display(Name = "Name:")]
        public string Name { get; set; }

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
        /// Gets or sets the message.
        /// </summary>
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please include a message, without it we won't know what you want.")]
        [Display(Name = "Message:")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the message type.
        /// </summary>
        [Required(ErrorMessage = "Please select your question so we can forward the message on to the right person.")]
        [Display(Name = "Question:")]
        public MessageType MessageType { get; set; }
    }
}