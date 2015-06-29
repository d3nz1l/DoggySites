// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmailTemplate.cs" company="">
//   
// </copyright>
// <summary>
//   The email template.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Email
{
    using System;
    using System.Collections.Generic;

    using Email.Templates;

    /// <summary>
    /// The email template.
    /// </summary>
    public abstract class EmailTemplate : IEmailTemplate
    {
        /// <summary>
        /// The email data.
        /// </summary>
        protected object emailData;

        /// <summary>
        /// The body template.
        /// </summary>
        protected string bodyTemplate;

        /// <summary>
        /// The subject template.
        /// </summary>
        protected string subjectTemplate;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplate"/> class.
        /// </summary>
        /// <param name="emailData">
        /// The email data.
        /// </param>
        public EmailTemplate(object emailData)
        {
            this.emailData = emailData;
        }

        /// <summary>
        /// Gets or sets the senders address.
        /// </summary>
        public string SendersAddress { get; protected set; }

        /// <summary>
        /// Gets or sets the reply to address.
        /// </summary>
        public string ReplyToAddress { get; protected set; }

        /// <summary>
        /// Gets or sets the recipient address.
        /// </summary>
        public IEnumerable<string> RecipientAddresses { get; protected set; }

        /// <summary>
        /// Gets the subject.
        /// </summary>
        public string Subject
        {
            get
            {
                return this.MergeTemplate(this.subjectTemplate);
            }
        }

        /// <summary>
        /// Gets the body.
        /// </summary>
        public string Body
        {
            get
            {
                return this.MergeTemplate(this.bodyTemplate);
            }
        }

        /// <summary>
        /// The ???.
        /// </summary>
        /// <param name="template">
        /// The template.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        protected string MergeTemplate(string template)
        {
            var dataType = this.emailData.GetType();
            var dataProperties = dataType.GetProperties();

            var bodyText = template;

            foreach (var dataProperty in dataProperties)
            {
                var mergeTagAttribute = Attribute.GetCustomAttribute(dataProperty, dataType) as MergeTagAttribute;

                if (mergeTagAttribute != null)
                {
                    var mergeTag = mergeTagAttribute.TagName;
                    var value = dataProperty.GetValue(this.emailData).ToString();
                    bodyText = bodyText.Replace(mergeTag, value);
                }
            }

            return bodyText;
        }
    }
}
