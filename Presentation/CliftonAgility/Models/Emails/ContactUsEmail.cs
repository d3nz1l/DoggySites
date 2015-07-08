// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContactUsEmail.cs" company="">
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
    public class ContactUsEmail : BaseEmail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactUsEmail"/> class.
        /// </summary>
        /// <param name="fromAddress">
        /// The from Address.
        /// </param>
        /// <param name="toAddress">
        /// The to Address.
        /// </param>
        public ContactUsEmail(string fromAddress, string toAddress)
        {
            this.From = EmailAddresses.Club;
            this.Subject = "A message from CliftonAgility.co.uk";
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