// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmailAccount.cs" company="">
//   
// </copyright>
// <summary>
//   The email account.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Email
{
    using System.Configuration;

    /// <summary>
    /// The email account.
    /// </summary>
    internal abstract class EmailAccount : IEmailAccount
    {
        /// <summary>
        /// The smtp server.
        /// </summary>
        protected string smtpServer;

        /// <summary>
        /// The user name.
        /// </summary>
        protected string userName;

        /// <summary>
        /// The password.
        /// </summary>
        protected string password;

        /// <summary>
        /// Gets the smtp address.
        /// </summary>
        public string SmtpAddress
        {
            get
            {
                return this.smtpServer;
            }
        }

        /// <summary>
        /// Gets the username.
        /// </summary>
        public string Username
        {
            get
            {
                return this.userName;
            }
        }

        /// <summary>
        /// Gets the password.
        /// </summary>
        public string Password
        {
            get
            {
                return this.password;
            }
        }
    }
}
