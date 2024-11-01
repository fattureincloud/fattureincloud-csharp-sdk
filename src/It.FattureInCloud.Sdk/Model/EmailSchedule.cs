/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.1.3
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
    /// EmailSchedule
    /// </summary>
    [DataContract(Name = "EmailSchedule")]
    public partial class EmailSchedule : IEquatable<EmailSchedule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailSchedule" /> class.
        /// </summary>
        /// <param name="senderId">Email sender id [required if **sender_email** is not specified].</param>
        /// <param name="senderEmail">Email sender address [required if **sender_id** is not specified].</param>
        /// <param name="recipientEmail">Email recipient emails [comma separated].</param>
        /// <param name="subject">Email subject.</param>
        /// <param name="body">Email body [HTML Escaped] [max size 50KiB].</param>
        /// <param name="include">include.</param>
        /// <param name="attachPdf">Attach the pdf of the document.</param>
        /// <param name="sendCopy">Send a copy of the email to the **cc_email** specified by **Get email data**.</param>
        public EmailSchedule(int? senderId = default(int?), string senderEmail = default(string), string recipientEmail = default(string), string subject = default(string), string body = default(string), EmailScheduleInclude include = default(EmailScheduleInclude), bool? attachPdf = default(bool?), bool? sendCopy = default(bool?))
        {
            this._SenderId = senderId;
            if (this.SenderId != null)
            {
                this._flagSenderId = true;
            }
            this._SenderEmail = senderEmail;
            if (this.SenderEmail != null)
            {
                this._flagSenderEmail = true;
            }
            this._RecipientEmail = recipientEmail;
            if (this.RecipientEmail != null)
            {
                this._flagRecipientEmail = true;
            }
            this._Subject = subject;
            if (this.Subject != null)
            {
                this._flagSubject = true;
            }
            this._Body = body;
            if (this.Body != null)
            {
                this._flagBody = true;
            }
            this._Include = include;
            if (this.Include != null)
            {
                this._flagInclude = true;
            }
            this._AttachPdf = attachPdf;
            if (this.AttachPdf != null)
            {
                this._flagAttachPdf = true;
            }
            this._SendCopy = sendCopy;
            if (this.SendCopy != null)
            {
                this._flagSendCopy = true;
            }
        }

        /// <summary>
        /// Email sender id [required if **sender_email** is not specified]
        /// </summary>
        /// <value>Email sender id [required if **sender_email** is not specified]</value>
        [DataMember(Name = "sender_id", EmitDefaultValue = true)]
        public int? SenderId
        {
            get { return _SenderId; }
            set
            {
                _SenderId = value;
                _flagSenderId = true;
            }
        }
        private int? _SenderId;
        private bool _flagSenderId;

        /// <summary>
        /// Returns false as SenderId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSenderId()
        {
            return _flagSenderId;
        }
        /// <summary>
        /// Email sender address [required if **sender_id** is not specified]
        /// </summary>
        /// <value>Email sender address [required if **sender_id** is not specified]</value>
        [DataMember(Name = "sender_email", EmitDefaultValue = true)]
        public string SenderEmail
        {
            get { return _SenderEmail; }
            set
            {
                _SenderEmail = value;
                _flagSenderEmail = true;
            }
        }
        private string _SenderEmail;
        private bool _flagSenderEmail;

        /// <summary>
        /// Returns false as SenderEmail should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSenderEmail()
        {
            return _flagSenderEmail;
        }
        /// <summary>
        /// Email recipient emails [comma separated]
        /// </summary>
        /// <value>Email recipient emails [comma separated]</value>
        [DataMember(Name = "recipient_email", EmitDefaultValue = true)]
        public string RecipientEmail
        {
            get { return _RecipientEmail; }
            set
            {
                _RecipientEmail = value;
                _flagRecipientEmail = true;
            }
        }
        private string _RecipientEmail;
        private bool _flagRecipientEmail;

        /// <summary>
        /// Returns false as RecipientEmail should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRecipientEmail()
        {
            return _flagRecipientEmail;
        }
        /// <summary>
        /// Email subject
        /// </summary>
        /// <value>Email subject</value>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
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
        /// Email body [HTML Escaped] [max size 50KiB]
        /// </summary>
        /// <value>Email body [HTML Escaped] [max size 50KiB]</value>
        [DataMember(Name = "body", EmitDefaultValue = true)]
        public string Body
        {
            get { return _Body; }
            set
            {
                _Body = value;
                _flagBody = true;
            }
        }
        private string _Body;
        private bool _flagBody;

        /// <summary>
        /// Returns false as Body should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBody()
        {
            return _flagBody;
        }
        /// <summary>
        /// Gets or Sets Include
        /// </summary>
        [DataMember(Name = "include", EmitDefaultValue = true)]
        public EmailScheduleInclude Include
        {
            get { return _Include; }
            set
            {
                _Include = value;
                _flagInclude = true;
            }
        }
        private EmailScheduleInclude _Include;
        private bool _flagInclude;

        /// <summary>
        /// Returns false as Include should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInclude()
        {
            return _flagInclude;
        }
        /// <summary>
        /// Attach the pdf of the document
        /// </summary>
        /// <value>Attach the pdf of the document</value>
        [DataMember(Name = "attach_pdf", EmitDefaultValue = true)]
        public bool? AttachPdf
        {
            get { return _AttachPdf; }
            set
            {
                _AttachPdf = value;
                _flagAttachPdf = true;
            }
        }
        private bool? _AttachPdf;
        private bool _flagAttachPdf;

        /// <summary>
        /// Returns false as AttachPdf should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAttachPdf()
        {
            return _flagAttachPdf;
        }
        /// <summary>
        /// Send a copy of the email to the **cc_email** specified by **Get email data**
        /// </summary>
        /// <value>Send a copy of the email to the **cc_email** specified by **Get email data**</value>
        [DataMember(Name = "send_copy", EmitDefaultValue = true)]
        public bool? SendCopy
        {
            get { return _SendCopy; }
            set
            {
                _SendCopy = value;
                _flagSendCopy = true;
            }
        }
        private bool? _SendCopy;
        private bool _flagSendCopy;

        /// <summary>
        /// Returns false as SendCopy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSendCopy()
        {
            return _flagSendCopy;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailSchedule {\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("  SenderEmail: ").Append(SenderEmail).Append("\n");
            sb.Append("  RecipientEmail: ").Append(RecipientEmail).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Include: ").Append(Include).Append("\n");
            sb.Append("  AttachPdf: ").Append(AttachPdf).Append("\n");
            sb.Append("  SendCopy: ").Append(SendCopy).Append("\n");
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
            return this.Equals(input as EmailSchedule);
        }

        /// <summary>
        /// Returns true if EmailSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailSchedule input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.SenderId == input.SenderId ||
                    (this.SenderId != null &&
                    this.SenderId.Equals(input.SenderId))
                ) &&
                (
                    this.SenderEmail == input.SenderEmail ||
                    (this.SenderEmail != null &&
                    this.SenderEmail.Equals(input.SenderEmail))
                ) &&
                (
                    this.RecipientEmail == input.RecipientEmail ||
                    (this.RecipientEmail != null &&
                    this.RecipientEmail.Equals(input.RecipientEmail))
                ) &&
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) &&
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) &&
                (
                    this.Include == input.Include ||
                    (this.Include != null &&
                    this.Include.Equals(input.Include))
                ) &&
                (
                    this.AttachPdf == input.AttachPdf ||
                    (this.AttachPdf != null &&
                    this.AttachPdf.Equals(input.AttachPdf))
                ) &&
                (
                    this.SendCopy == input.SendCopy ||
                    (this.SendCopy != null &&
                    this.SendCopy.Equals(input.SendCopy))
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
                if (this.SenderId != null)
                {
                    hashCode = (hashCode * 59) + this.SenderId.GetHashCode();
                }
                if (this.SenderEmail != null)
                {
                    hashCode = (hashCode * 59) + this.SenderEmail.GetHashCode();
                }
                if (this.RecipientEmail != null)
                {
                    hashCode = (hashCode * 59) + this.RecipientEmail.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.Include != null)
                {
                    hashCode = (hashCode * 59) + this.Include.GetHashCode();
                }
                if (this.AttachPdf != null)
                {
                    hashCode = (hashCode * 59) + this.AttachPdf.GetHashCode();
                }
                if (this.SendCopy != null)
                {
                    hashCode = (hashCode * 59) + this.SendCopy.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
