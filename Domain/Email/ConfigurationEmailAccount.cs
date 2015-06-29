// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConfigurationEmailAccount.cs" company="">
//   
// </copyright>
// <summary>
//   The configuration email account.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Email
{
    using System.Configuration;

    /// <summary>
    /// The configuration email account.
    /// </summary>
    internal class ConfigurationEmailAccount : EmailAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationEmailAccount"/> class. 
        /// </summary>
        public ConfigurationEmailAccount()
        {
            this.smtpServer = ConfigurationManager.AppSettings.Get("Email_SmtpServer");
            this.userName = ConfigurationManager.AppSettings.Get("Email_Username");
            this.password = ConfigurationManager.AppSettings.Get("Email_Password");
        }
    }
}
