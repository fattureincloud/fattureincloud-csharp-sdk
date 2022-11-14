/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.22
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = It.FattureInCloud.Sdk.Client.OpenAPIDateConverter;

namespace It.FattureInCloud.Sdk.Model
{
    /// <summary>
    /// Email
    /// </summary>
    [DataContract(Name = "Email")]
    public partial class Email : IEquatable<Email>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>

        [DataMember(Name = "status", EmitDefaultValue = false)]
        public EmailStatus? Status
        {
            get { return _Status; }
            set
            {
                _Status = value;
                _flagStatus = true;
            }
        }
        private EmailStatus? _Status;
        private bool _flagStatus;

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
        {
            return _flagStatus;
        }

        /// <summary>
        /// Gets or Sets RecipientStatus
        /// </summary>

        [DataMember(Name = "recipient_status", EmitDefaultValue = false)]
        public EmailRecipientStatus? RecipientStatus
        {
            get { return _RecipientStatus; }
            set
            {
                _RecipientStatus = value;
                _flagRecipientStatus = true;
            }
        }
        private EmailRecipientStatus? _RecipientStatus;
        private bool _flagRecipientStatus;

        /// <summary>
        /// Returns false as RecipientStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRecipientStatus()
        {
            return _flagRecipientStatus;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        /// <param name="id">Email unique identifier..</param>
        /// <param name="status">status.</param>
        /// <param name="sentDate">Email sent date..</param>
        /// <param name="errorsCount">Errors count..</param>
        /// <param name="errorLog">Error log..</param>
        /// <param name="fromEmail">Sender email..</param>
        /// <param name="fromName">Sender name..</param>
        /// <param name="toEmail">Recipient email..</param>
        /// <param name="toName">Receipient email..</param>
        /// <param name="subject">Email subject..</param>
        /// <param name="content">Email content..</param>
        /// <param name="copyTo">copyTo.</param>
        /// <param name="recipientStatus">recipientStatus.</param>
        /// <param name="recipientDate">recipientDate.</param>
        /// <param name="kind">Email kind..</param>
        /// <param name="attachments">Email attachments..</param>
        public Email(int id = default(int), EmailStatus? status = default(EmailStatus?), DateTimeOffset sentDate = default(DateTimeOffset), int errorsCount = default(int), string errorLog = default(string), string fromEmail = default(string), string fromName = default(string), string toEmail = default(string), string toName = default(string), string subject = default(string), string content = default(string), string copyTo = default(string), EmailRecipientStatus? recipientStatus = default(EmailRecipientStatus?), DateTimeOffset recipientDate = default(DateTimeOffset), string kind = default(string), List<EmailAttachment> attachments = default(List<EmailAttachment>))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._Status = status;
            if (this.Status != null)
            {
                this._flagStatus = true;
            }
            this._SentDate = sentDate;
            if (this.SentDate != null)
            {
                this._flagSentDate = true;
            }
            this._ErrorsCount = errorsCount;
            if (this.ErrorsCount != null)
            {
                this._flagErrorsCount = true;
            }
            this._ErrorLog = errorLog;
            if (this.ErrorLog != null)
            {
                this._flagErrorLog = true;
            }
            this._FromEmail = fromEmail;
            if (this.FromEmail != null)
            {
                this._flagFromEmail = true;
            }
            this._FromName = fromName;
            if (this.FromName != null)
            {
                this._flagFromName = true;
            }
            this._ToEmail = toEmail;
            if (this.ToEmail != null)
            {
                this._flagToEmail = true;
            }
            this._ToName = toName;
            if (this.ToName != null)
            {
                this._flagToName = true;
            }
            this._Subject = subject;
            if (this.Subject != null)
            {
                this._flagSubject = true;
            }
            this._Content = content;
            if (this.Content != null)
            {
                this._flagContent = true;
            }
            this._CopyTo = copyTo;
            if (this.CopyTo != null)
            {
                this._flagCopyTo = true;
            }
            this._RecipientStatus = recipientStatus;
            if (this.RecipientStatus != null)
            {
                this._flagRecipientStatus = true;
            }
            this._RecipientDate = recipientDate;
            if (this.RecipientDate != null)
            {
                this._flagRecipientDate = true;
            }
            this._Kind = kind;
            if (this.Kind != null)
            {
                this._flagKind = true;
            }
            this._Attachments = attachments;
            if (this.Attachments != null)
            {
                this._flagAttachments = true;
            }
        }

        /// <summary>
        /// Email unique identifier.
        /// </summary>
        /// <value>Email unique identifier.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
                _flagId = true;
            }
        }
        private int _Id;
        private bool _flagId;

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return _flagId;
        }
        /// <summary>
        /// Email sent date.
        /// </summary>
        /// <value>Email sent date.</value>
        [DataMember(Name = "sent_date", EmitDefaultValue = false)]
        public DateTimeOffset SentDate
        {
            get { return _SentDate; }
            set
            {
                _SentDate = value;
                _flagSentDate = true;
            }
        }
        private DateTimeOffset _SentDate;
        private bool _flagSentDate;

        /// <summary>
        /// Returns false as SentDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSentDate()
        {
            return _flagSentDate;
        }
        /// <summary>
        /// Errors count.
        /// </summary>
        /// <value>Errors count.</value>
        [DataMember(Name = "errors_count", EmitDefaultValue = false)]
        public int ErrorsCount
        {
            get { return _ErrorsCount; }
            set
            {
                _ErrorsCount = value;
                _flagErrorsCount = true;
            }
        }
        private int _ErrorsCount;
        private bool _flagErrorsCount;

        /// <summary>
        /// Returns false as ErrorsCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeErrorsCount()
        {
            return _flagErrorsCount;
        }
        /// <summary>
        /// Error log.
        /// </summary>
        /// <value>Error log.</value>
        [DataMember(Name = "error_log", EmitDefaultValue = false)]
        public string ErrorLog
        {
            get { return _ErrorLog; }
            set
            {
                _ErrorLog = value;
                _flagErrorLog = true;
            }
        }
        private string _ErrorLog;
        private bool _flagErrorLog;

        /// <summary>
        /// Returns false as ErrorLog should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeErrorLog()
        {
            return _flagErrorLog;
        }
        /// <summary>
        /// Sender email.
        /// </summary>
        /// <value>Sender email.</value>
        [DataMember(Name = "from_email", EmitDefaultValue = false)]
        public string FromEmail
        {
            get { return _FromEmail; }
            set
            {
                _FromEmail = value;
                _flagFromEmail = true;
            }
        }
        private string _FromEmail;
        private bool _flagFromEmail;

        /// <summary>
        /// Returns false as FromEmail should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFromEmail()
        {
            return _flagFromEmail;
        }
        /// <summary>
        /// Sender name.
        /// </summary>
        /// <value>Sender name.</value>
        [DataMember(Name = "from_name", EmitDefaultValue = false)]
        public string FromName
        {
            get { return _FromName; }
            set
            {
                _FromName = value;
                _flagFromName = true;
            }
        }
        private string _FromName;
        private bool _flagFromName;

        /// <summary>
        /// Returns false as FromName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFromName()
        {
            return _flagFromName;
        }
        /// <summary>
        /// Recipient email.
        /// </summary>
        /// <value>Recipient email.</value>
        [DataMember(Name = "to_email", EmitDefaultValue = false)]
        public string ToEmail
        {
            get { return _ToEmail; }
            set
            {
                _ToEmail = value;
                _flagToEmail = true;
            }
        }
        private string _ToEmail;
        private bool _flagToEmail;

        /// <summary>
        /// Returns false as ToEmail should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeToEmail()
        {
            return _flagToEmail;
        }
        /// <summary>
        /// Receipient email.
        /// </summary>
        /// <value>Receipient email.</value>
        [DataMember(Name = "to_name", EmitDefaultValue = false)]
        public string ToName
        {
            get { return _ToName; }
            set
            {
                _ToName = value;
                _flagToName = true;
            }
        }
        private string _ToName;
        private bool _flagToName;

        /// <summary>
        /// Returns false as ToName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeToName()
        {
            return _flagToName;
        }
        /// <summary>
        /// Email subject.
        /// </summary>
        /// <value>Email subject.</value>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject
        {
            get { return _Subject; }
            set
            {
                _Subject = value;
                _flagSubject = true;
            }
        }
        private string _Subject;
        private bool _flagSubject;

        /// <summary>
        /// Returns false as Subject should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSubject()
        {
            return _flagSubject;
        }
        /// <summary>
        /// Email content.
        /// </summary>
        /// <value>Email content.</value>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content
        {
            get { return _Content; }
            set
            {
                _Content = value;
                _flagContent = true;
            }
        }
        private string _Content;
        private bool _flagContent;

        /// <summary>
        /// Returns false as Content should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContent()
        {
            return _flagContent;
        }
        /// <summary>
        /// Gets or Sets CopyTo
        /// </summary>
        [DataMember(Name = "copy_to", EmitDefaultValue = false)]
        public string CopyTo
        {
            get { return _CopyTo; }
            set
            {
                _CopyTo = value;
                _flagCopyTo = true;
            }
        }
        private string _CopyTo;
        private bool _flagCopyTo;

        /// <summary>
        /// Returns false as CopyTo should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCopyTo()
        {
            return _flagCopyTo;
        }
        /// <summary>
        /// Gets or Sets RecipientDate
        /// </summary>
        [DataMember(Name = "recipient_date", EmitDefaultValue = false)]
        public DateTimeOffset RecipientDate
        {
            get { return _RecipientDate; }
            set
            {
                _RecipientDate = value;
                _flagRecipientDate = true;
            }
        }
        private DateTimeOffset _RecipientDate;
        private bool _flagRecipientDate;

        /// <summary>
        /// Returns false as RecipientDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRecipientDate()
        {
            return _flagRecipientDate;
        }
        /// <summary>
        /// Email kind.
        /// </summary>
        /// <value>Email kind.</value>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public string Kind
        {
            get { return _Kind; }
            set
            {
                _Kind = value;
                _flagKind = true;
            }
        }
        private string _Kind;
        private bool _flagKind;

        /// <summary>
        /// Returns false as Kind should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeKind()
        {
            return _flagKind;
        }
        /// <summary>
        /// Email attachments.
        /// </summary>
        /// <value>Email attachments.</value>
        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        public List<EmailAttachment> Attachments
        {
            get { return _Attachments; }
            set
            {
                _Attachments = value;
                _flagAttachments = true;
            }
        }
        private List<EmailAttachment> _Attachments;
        private bool _flagAttachments;

        /// <summary>
        /// Returns false as Attachments should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAttachments()
        {
            return _flagAttachments;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Email {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SentDate: ").Append(SentDate).Append("\n");
            sb.Append("  ErrorsCount: ").Append(ErrorsCount).Append("\n");
            sb.Append("  ErrorLog: ").Append(ErrorLog).Append("\n");
            sb.Append("  FromEmail: ").Append(FromEmail).Append("\n");
            sb.Append("  FromName: ").Append(FromName).Append("\n");
            sb.Append("  ToEmail: ").Append(ToEmail).Append("\n");
            sb.Append("  ToName: ").Append(ToName).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  CopyTo: ").Append(CopyTo).Append("\n");
            sb.Append("  RecipientStatus: ").Append(RecipientStatus).Append("\n");
            sb.Append("  RecipientDate: ").Append(RecipientDate).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Email);
        }

        /// <summary>
        /// Returns true if Email instances are equal
        /// </summary>
        /// <param name="input">Instance of Email to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Email input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) &&
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) &&
                (
                    this.SentDate == input.SentDate ||
                    (this.SentDate != null &&
                    this.SentDate.Equals(input.SentDate))
                ) &&
                (
                    this.ErrorsCount == input.ErrorsCount ||
                    this.ErrorsCount.Equals(input.ErrorsCount)
                ) &&
                (
                    this.ErrorLog == input.ErrorLog ||
                    (this.ErrorLog != null &&
                    this.ErrorLog.Equals(input.ErrorLog))
                ) &&
                (
                    this.FromEmail == input.FromEmail ||
                    (this.FromEmail != null &&
                    this.FromEmail.Equals(input.FromEmail))
                ) &&
                (
                    this.FromName == input.FromName ||
                    (this.FromName != null &&
                    this.FromName.Equals(input.FromName))
                ) &&
                (
                    this.ToEmail == input.ToEmail ||
                    (this.ToEmail != null &&
                    this.ToEmail.Equals(input.ToEmail))
                ) &&
                (
                    this.ToName == input.ToName ||
                    (this.ToName != null &&
                    this.ToName.Equals(input.ToName))
                ) &&
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) &&
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) &&
                (
                    this.CopyTo == input.CopyTo ||
                    (this.CopyTo != null &&
                    this.CopyTo.Equals(input.CopyTo))
                ) &&
                (
                    this.RecipientStatus == input.RecipientStatus ||
                    this.RecipientStatus.Equals(input.RecipientStatus)
                ) &&
                (
                    this.RecipientDate == input.RecipientDate ||
                    (this.RecipientDate != null &&
                    this.RecipientDate.Equals(input.RecipientDate))
                ) &&
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
                ) &&
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.SentDate != null)
                {
                    hashCode = (hashCode * 59) + this.SentDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ErrorsCount.GetHashCode();
                if (this.ErrorLog != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorLog.GetHashCode();
                }
                if (this.FromEmail != null)
                {
                    hashCode = (hashCode * 59) + this.FromEmail.GetHashCode();
                }
                if (this.FromName != null)
                {
                    hashCode = (hashCode * 59) + this.FromName.GetHashCode();
                }
                if (this.ToEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ToEmail.GetHashCode();
                }
                if (this.ToName != null)
                {
                    hashCode = (hashCode * 59) + this.ToName.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.CopyTo != null)
                {
                    hashCode = (hashCode * 59) + this.CopyTo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RecipientStatus.GetHashCode();
                if (this.RecipientDate != null)
                {
                    hashCode = (hashCode * 59) + this.RecipientDate.GetHashCode();
                }
                if (this.Kind != null)
                {
                    hashCode = (hashCode * 59) + this.Kind.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
