// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContactUsConfirmationEmail.cs" company="">
//   
// </copyright>
// <summary>
//   The contact us email.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CliftonAgility.Models.Emails
{
    using System.Globalization;

    using CliftonAgility.Helpers;

    /// <summary>
    /// The contact us email.
    /// </summary>
    public class ContactUsConfirmationEmail : BaseEmail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactUsConfirmationEmail"/> class. 
        /// </summary>
        /// <param name="fromAddress">
        /// The from Address.
        /// </param>
        /// <param name="toAddress">
        /// The to Address.
        /// </param>
        public ContactUsConfirmationEmail(string fromAddress, string toAddress)
        {
            this.From = EmailAddresses.Club;
            this.Subject = "Thank you - Clifton Agility Club";
            this.ReplyTo = fromAddress;
            this.To = toAddress;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }
    }
}