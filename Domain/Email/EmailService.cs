// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmailService.cs" company="">
//   
// </copyright>
// <summary>
//   The email service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DoggySites.Email
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Mail;
    using System.Threading.Tasks;

    using global::Email;

    using Microsoft.Practices.ObjectBuilder2;

    /// <summary>
    /// The email service.
    /// </summary>
    public class EmailService
    {
        /// <summary>
        /// The email account.
        /// </summary>
        private IEmailAccount emailAccount;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailService"/> class.
        /// </summary>
        /// <param name="emailAccount">
        /// The email account.
        /// </param>
        public EmailService(IEmailAccount emailAccount)
        {
            this.emailAccount = emailAccount;
        }

        /// <summary>
        /// The send message.
        /// </summary>
        /// <param name="emailTemplate">
        /// The email Template.
        /// </param>
        /// <exception cref="SmtpException">
        /// </exception>
        public void SendMessage(IEmailTemplate emailTemplate)
        {
            Task.Factory.StartNew(
                () => this.SendMessageAsync(emailTemplate)).ConfigureAwait(false);
        }

        /// <summary>
        /// The send message async.
        /// </summary>
        /// <param name="emailTemplate">
        /// The email Template.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task SendMessageAsync(IEmailTemplate emailTemplate)
        {
            var mailMessage = this.GetMessage(emailTemplate.SendersAddress, emailTemplate.ReplyToAddress, emailTemplate.RecipientAddresses, emailTemplate.Subject, emailTemplate.Body);

            var emailClient = this.GetClient();

            try
            {
                await emailClient.SendMailAsync(mailMessage);
            }
            catch (Exception ex)
            {
                const string errorTemplate = @"Error sending message.
From: {0}
To: {1}
Subject: {2}
Error: {3}";

                var error = new SmtpException(string.Format(errorTemplate, emailTemplate.SendersAddress, emailTemplate.RecipientAddresses, emailTemplate.Subject, ex.Message), ex);

                throw error;
            }
        }

        /// <summary>
        /// The get client.
        /// </summary>
        /// <returns>
        /// The <see cref="SmtpClient"/>.
        /// </returns>
        private SmtpClient GetClient()
        {
            var credentials = new NetworkCredential(this.emailAccount.Username, this.emailAccount.Password);

            var client = new SmtpClient(this.emailAccount.SmtpAddress);
            client.Credentials = credentials;

            return client;
        }

        /// <summary>
        /// The get message.
        /// </summary>
        /// <param name="sendersAddress">
        /// The senders Address.
        /// </param>
        /// <param name="replyToAddress">
        /// The reply To Address.
        /// </param>
        /// <param name="recipients">
        /// The recipients.
        /// </param>
        /// <param name="subject">
        /// The subject.
        /// </param>
        /// <param name="body">
        /// The body.
        /// </param>
        /// <returns>
        /// The <see cref="MailMessage"/>.
        /// </returns>
        private MailMessage GetMessage(string sendersAddress, string replyToAddress, IEnumerable<string> recipients, string subject, string body)
        {
            var message = new MailMessage();
            message.From = new MailAddress(sendersAddress);
            recipients.ForEach(a => message.To.Add(a));
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;
            message.ReplyToList.Add(new MailAddress(replyToAddress));

            return message;
        }
    }
}
