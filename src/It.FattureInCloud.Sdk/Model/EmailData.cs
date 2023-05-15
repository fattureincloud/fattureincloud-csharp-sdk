/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.28
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
    /// EmailData
    /// </summary>
    [DataContract(Name = "EmailData")]
    public partial class EmailData : IEquatable<EmailData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailData" /> class.
        /// </summary>
        /// <param name="recipientEmail">Recipient&#39;s email.</param>
        /// <param name="defaultSenderEmail">defaultSenderEmail.</param>
        /// <param name="senderEmailsList">List of all emails from which the document can be sent.</param>
        /// <param name="ccEmail">By default is the logged company email. This is the email address to which a copy will be sent..</param>
        /// <param name="subject">Email subject.</param>
        /// <param name="body">Email body.</param>
        /// <param name="documentExists">If the document is not a delivery note, this flag will be set to true.</param>
        /// <param name="deliveryNoteExists">If the document is a delivery note, this flag will be set to true.</param>
        /// <param name="attachmentExists">If the document has one or more attachments, this flag will be set to true.</param>
        /// <param name="accompanyingInvoiceExists">If an accompanying invoice exists, this flag will be set to true.</param>
        /// <param name="defaultAttachPdf">If a pdf is attached, this flag will be set to true.</param>
        public EmailData(string recipientEmail = default(string), EmailDataDefaultSenderEmail defaultSenderEmail = default(EmailDataDefaultSenderEmail), List<SenderEmail> senderEmailsList = default(List<SenderEmail>), string ccEmail = default(string), string subject = default(string), string body = default(string), bool? documentExists = default(bool?), bool? deliveryNoteExists = default(bool?), bool? attachmentExists = default(bool?), bool? accompanyingInvoiceExists = default(bool?), bool? defaultAttachPdf = default(bool?))
        {
            this._RecipientEmail = recipientEmail;
            if (this.RecipientEmail != null)
            {
                this._flagRecipientEmail = true;
            }
            this._DefaultSenderEmail = defaultSenderEmail;
            if (this.DefaultSenderEmail != null)
            {
                this._flagDefaultSenderEmail = true;
            }
            this._SenderEmailsList = senderEmailsList;
            if (this.SenderEmailsList != null)
            {
                this._flagSenderEmailsList = true;
            }
            this._CcEmail = ccEmail;
            if (this.CcEmail != null)
            {
                this._flagCcEmail = true;
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
            this._DocumentExists = documentExists;
            if (this.DocumentExists != null)
            {
                this._flagDocumentExists = true;
            }
            this._DeliveryNoteExists = deliveryNoteExists;
            if (this.DeliveryNoteExists != null)
            {
                this._flagDeliveryNoteExists = true;
            }
            this._AttachmentExists = attachmentExists;
            if (this.AttachmentExists != null)
            {
                this._flagAttachmentExists = true;
            }
            this._AccompanyingInvoiceExists = accompanyingInvoiceExists;
            if (this.AccompanyingInvoiceExists != null)
            {
                this._flagAccompanyingInvoiceExists = true;
            }
            this._DefaultAttachPdf = defaultAttachPdf;
            if (this.DefaultAttachPdf != null)
            {
                this._flagDefaultAttachPdf = true;
            }
        }

        /// <summary>
        /// Recipient&#39;s email
        /// </summary>
        /// <value>Recipient&#39;s email</value>
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
        /// Gets or Sets DefaultSenderEmail
        /// </summary>
        [DataMember(Name = "default_sender_email", EmitDefaultValue = true)]
        public EmailDataDefaultSenderEmail DefaultSenderEmail
        {
            get { return _DefaultSenderEmail; }
            set
            {
                _DefaultSenderEmail = value;
                _flagDefaultSenderEmail = true;
            }
        }
        private EmailDataDefaultSenderEmail _DefaultSenderEmail;
        private bool _flagDefaultSenderEmail;

        /// <summary>
        /// Returns false as DefaultSenderEmail should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDefaultSenderEmail()
        {
            return _flagDefaultSenderEmail;
        }
        /// <summary>
        /// List of all emails from which the document can be sent
        /// </summary>
        /// <value>List of all emails from which the document can be sent</value>
        [DataMember(Name = "sender_emails_list", EmitDefaultValue = true)]
        public List<SenderEmail> SenderEmailsList
        {
            get { return _SenderEmailsList; }
            set
            {
                _SenderEmailsList = value;
                _flagSenderEmailsList = true;
            }
        }
        private List<SenderEmail> _SenderEmailsList;
        private bool _flagSenderEmailsList;

        /// <summary>
        /// Returns false as SenderEmailsList should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSenderEmailsList()
        {
            return _flagSenderEmailsList;
        }
        /// <summary>
        /// By default is the logged company email. This is the email address to which a copy will be sent.
        /// </summary>
        /// <value>By default is the logged company email. This is the email address to which a copy will be sent.</value>
        [DataMember(Name = "cc_email", EmitDefaultValue = true)]
        public string CcEmail
        {
            get { return _CcEmail; }
            set
            {
                _CcEmail = value;
                _flagCcEmail = true;
            }
        }
        private string _CcEmail;
        private bool _flagCcEmail;

        /// <summary>
        /// Returns false as CcEmail should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCcEmail()
        {
            return _flagCcEmail;
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
        /// Email body
        /// </summary>
        /// <value>Email body</value>
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
        /// If the document is not a delivery note, this flag will be set to true
        /// </summary>
        /// <value>If the document is not a delivery note, this flag will be set to true</value>
        [DataMember(Name = "document_exists", EmitDefaultValue = true)]
        public bool? DocumentExists
        {
            get { return _DocumentExists; }
            set
            {
                _DocumentExists = value;
                _flagDocumentExists = true;
            }
        }
        private bool? _DocumentExists;
        private bool _flagDocumentExists;

        /// <summary>
        /// Returns false as DocumentExists should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDocumentExists()
        {
            return _flagDocumentExists;
        }
        /// <summary>
        /// If the document is a delivery note, this flag will be set to true
        /// </summary>
        /// <value>If the document is a delivery note, this flag will be set to true</value>
        [DataMember(Name = "delivery_note_exists", EmitDefaultValue = true)]
        public bool? DeliveryNoteExists
        {
            get { return _DeliveryNoteExists; }
            set
            {
                _DeliveryNoteExists = value;
                _flagDeliveryNoteExists = true;
            }
        }
        private bool? _DeliveryNoteExists;
        private bool _flagDeliveryNoteExists;

        /// <summary>
        /// Returns false as DeliveryNoteExists should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeliveryNoteExists()
        {
            return _flagDeliveryNoteExists;
        }
        /// <summary>
        /// If the document has one or more attachments, this flag will be set to true
        /// </summary>
        /// <value>If the document has one or more attachments, this flag will be set to true</value>
        [DataMember(Name = "attachment_exists", EmitDefaultValue = true)]
        public bool? AttachmentExists
        {
            get { return _AttachmentExists; }
            set
            {
                _AttachmentExists = value;
                _flagAttachmentExists = true;
            }
        }
        private bool? _AttachmentExists;
        private bool _flagAttachmentExists;

        /// <summary>
        /// Returns false as AttachmentExists should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAttachmentExists()
        {
            return _flagAttachmentExists;
        }
        /// <summary>
        /// If an accompanying invoice exists, this flag will be set to true
        /// </summary>
        /// <value>If an accompanying invoice exists, this flag will be set to true</value>
        [DataMember(Name = "accompanying_invoice_exists", EmitDefaultValue = true)]
        public bool? AccompanyingInvoiceExists
        {
            get { return _AccompanyingInvoiceExists; }
            set
            {
                _AccompanyingInvoiceExists = value;
                _flagAccompanyingInvoiceExists = true;
            }
        }
        private bool? _AccompanyingInvoiceExists;
        private bool _flagAccompanyingInvoiceExists;

        /// <summary>
        /// Returns false as AccompanyingInvoiceExists should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccompanyingInvoiceExists()
        {
            return _flagAccompanyingInvoiceExists;
        }
        /// <summary>
        /// If a pdf is attached, this flag will be set to true
        /// </summary>
        /// <value>If a pdf is attached, this flag will be set to true</value>
        [DataMember(Name = "default_attach_pdf", EmitDefaultValue = true)]
        public bool? DefaultAttachPdf
        {
            get { return _DefaultAttachPdf; }
            set
            {
                _DefaultAttachPdf = value;
                _flagDefaultAttachPdf = true;
            }
        }
        private bool? _DefaultAttachPdf;
        private bool _flagDefaultAttachPdf;

        /// <summary>
        /// Returns false as DefaultAttachPdf should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDefaultAttachPdf()
        {
            return _flagDefaultAttachPdf;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailData {\n");
            sb.Append("  RecipientEmail: ").Append(RecipientEmail).Append("\n");
            sb.Append("  DefaultSenderEmail: ").Append(DefaultSenderEmail).Append("\n");
            sb.Append("  SenderEmailsList: ").Append(SenderEmailsList).Append("\n");
            sb.Append("  CcEmail: ").Append(CcEmail).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  DocumentExists: ").Append(DocumentExists).Append("\n");
            sb.Append("  DeliveryNoteExists: ").Append(DeliveryNoteExists).Append("\n");
            sb.Append("  AttachmentExists: ").Append(AttachmentExists).Append("\n");
            sb.Append("  AccompanyingInvoiceExists: ").Append(AccompanyingInvoiceExists).Append("\n");
            sb.Append("  DefaultAttachPdf: ").Append(DefaultAttachPdf).Append("\n");
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
            return this.Equals(input as EmailData);
        }

        /// <summary>
        /// Returns true if EmailData instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailData input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.RecipientEmail == input.RecipientEmail ||
                    (this.RecipientEmail != null &&
                    this.RecipientEmail.Equals(input.RecipientEmail))
                ) &&
                (
                    this.DefaultSenderEmail == input.DefaultSenderEmail ||
                    (this.DefaultSenderEmail != null &&
                    this.DefaultSenderEmail.Equals(input.DefaultSenderEmail))
                ) &&
                (
                    this.SenderEmailsList == input.SenderEmailsList ||
                    this.SenderEmailsList != null &&
                    input.SenderEmailsList != null &&
                    this.SenderEmailsList.SequenceEqual(input.SenderEmailsList)
                ) &&
                (
                    this.CcEmail == input.CcEmail ||
                    (this.CcEmail != null &&
                    this.CcEmail.Equals(input.CcEmail))
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
                    this.DocumentExists == input.DocumentExists ||
                    (this.DocumentExists != null &&
                    this.DocumentExists.Equals(input.DocumentExists))
                ) &&
                (
                    this.DeliveryNoteExists == input.DeliveryNoteExists ||
                    (this.DeliveryNoteExists != null &&
                    this.DeliveryNoteExists.Equals(input.DeliveryNoteExists))
                ) &&
                (
                    this.AttachmentExists == input.AttachmentExists ||
                    (this.AttachmentExists != null &&
                    this.AttachmentExists.Equals(input.AttachmentExists))
                ) &&
                (
                    this.AccompanyingInvoiceExists == input.AccompanyingInvoiceExists ||
                    (this.AccompanyingInvoiceExists != null &&
                    this.AccompanyingInvoiceExists.Equals(input.AccompanyingInvoiceExists))
                ) &&
                (
                    this.DefaultAttachPdf == input.DefaultAttachPdf ||
                    (this.DefaultAttachPdf != null &&
                    this.DefaultAttachPdf.Equals(input.DefaultAttachPdf))
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
                if (this.RecipientEmail != null)
                {
                    hashCode = (hashCode * 59) + this.RecipientEmail.GetHashCode();
                }
                if (this.DefaultSenderEmail != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultSenderEmail.GetHashCode();
                }
                if (this.SenderEmailsList != null)
                {
                    hashCode = (hashCode * 59) + this.SenderEmailsList.GetHashCode();
                }
                if (this.CcEmail != null)
                {
                    hashCode = (hashCode * 59) + this.CcEmail.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.DocumentExists != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentExists.GetHashCode();
                }
                if (this.DeliveryNoteExists != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryNoteExists.GetHashCode();
                }
                if (this.AttachmentExists != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentExists.GetHashCode();
                }
                if (this.AccompanyingInvoiceExists != null)
                {
                    hashCode = (hashCode * 59) + this.AccompanyingInvoiceExists.GetHashCode();
                }
                if (this.DefaultAttachPdf != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultAttachPdf.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
