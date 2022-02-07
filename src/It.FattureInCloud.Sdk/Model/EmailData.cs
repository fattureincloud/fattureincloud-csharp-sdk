/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.11
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
        public EmailData(string recipientEmail = default(string), EmailDataDefaultSenderEmail defaultSenderEmail = default(EmailDataDefaultSenderEmail), List<SenderEmail> senderEmailsList = default(List<SenderEmail>), string ccEmail = default(string), string subject = default(string), string body = default(string), bool documentExists = default(bool), bool deliveryNoteExists = default(bool), bool attachmentExists = default(bool), bool accompanyingInvoiceExists = default(bool), bool defaultAttachPdf = default(bool))
        {
            this.RecipientEmail = recipientEmail;
            this.DefaultSenderEmail = defaultSenderEmail;
            this.SenderEmailsList = senderEmailsList;
            this.CcEmail = ccEmail;
            this.Subject = subject;
            this.Body = body;
            this.DocumentExists = documentExists;
            this.DeliveryNoteExists = deliveryNoteExists;
            this.AttachmentExists = attachmentExists;
            this.AccompanyingInvoiceExists = accompanyingInvoiceExists;
            this.DefaultAttachPdf = defaultAttachPdf;
        }

        /// <summary>
        /// Recipient&#39;s email
        /// </summary>
        /// <value>Recipient&#39;s email</value>
        [DataMember(Name = "recipient_email", EmitDefaultValue = true)]
        public string RecipientEmail { get; set; }

        /// <summary>
        /// Gets or Sets DefaultSenderEmail
        /// </summary>
        [DataMember(Name = "default_sender_email", EmitDefaultValue = false)]
        public EmailDataDefaultSenderEmail DefaultSenderEmail { get; set; }

        /// <summary>
        /// List of all emails from which the document can be sent
        /// </summary>
        /// <value>List of all emails from which the document can be sent</value>
        [DataMember(Name = "sender_emails_list", EmitDefaultValue = false)]
        public List<SenderEmail> SenderEmailsList { get; set; }

        /// <summary>
        /// By default is the logged company email. This is the email address to which a copy will be sent.
        /// </summary>
        /// <value>By default is the logged company email. This is the email address to which a copy will be sent.</value>
        [DataMember(Name = "cc_email", EmitDefaultValue = false)]
        public string CcEmail { get; set; }

        /// <summary>
        /// Email subject
        /// </summary>
        /// <value>Email subject</value>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Email body
        /// </summary>
        /// <value>Email body</value>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// If the document is not a delivery note, this flag will be set to true
        /// </summary>
        /// <value>If the document is not a delivery note, this flag will be set to true</value>
        [DataMember(Name = "document_exists", EmitDefaultValue = true)]
        public bool DocumentExists { get; set; }

        /// <summary>
        /// If the document is a delivery note, this flag will be set to true
        /// </summary>
        /// <value>If the document is a delivery note, this flag will be set to true</value>
        [DataMember(Name = "delivery_note_exists", EmitDefaultValue = true)]
        public bool DeliveryNoteExists { get; set; }

        /// <summary>
        /// If the document has one or more attachments, this flag will be set to true
        /// </summary>
        /// <value>If the document has one or more attachments, this flag will be set to true</value>
        [DataMember(Name = "attachment_exists", EmitDefaultValue = true)]
        public bool AttachmentExists { get; set; }

        /// <summary>
        /// If an accompanying invoice exists, this flag will be set to true
        /// </summary>
        /// <value>If an accompanying invoice exists, this flag will be set to true</value>
        [DataMember(Name = "accompanying_invoice_exists", EmitDefaultValue = true)]
        public bool AccompanyingInvoiceExists { get; set; }

        /// <summary>
        /// If a pdf is attached, this flag will be set to true
        /// </summary>
        /// <value>If a pdf is attached, this flag will be set to true</value>
        [DataMember(Name = "default_attach_pdf", EmitDefaultValue = true)]
        public bool DefaultAttachPdf { get; set; }

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
                    this.DocumentExists.Equals(input.DocumentExists)
                ) && 
                (
                    this.DeliveryNoteExists == input.DeliveryNoteExists ||
                    this.DeliveryNoteExists.Equals(input.DeliveryNoteExists)
                ) && 
                (
                    this.AttachmentExists == input.AttachmentExists ||
                    this.AttachmentExists.Equals(input.AttachmentExists)
                ) && 
                (
                    this.AccompanyingInvoiceExists == input.AccompanyingInvoiceExists ||
                    this.AccompanyingInvoiceExists.Equals(input.AccompanyingInvoiceExists)
                ) && 
                (
                    this.DefaultAttachPdf == input.DefaultAttachPdf ||
                    this.DefaultAttachPdf.Equals(input.DefaultAttachPdf)
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
                hashCode = (hashCode * 59) + this.DocumentExists.GetHashCode();
                hashCode = (hashCode * 59) + this.DeliveryNoteExists.GetHashCode();
                hashCode = (hashCode * 59) + this.AttachmentExists.GetHashCode();
                hashCode = (hashCode * 59) + this.AccompanyingInvoiceExists.GetHashCode();
                hashCode = (hashCode * 59) + this.DefaultAttachPdf.GetHashCode();
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
