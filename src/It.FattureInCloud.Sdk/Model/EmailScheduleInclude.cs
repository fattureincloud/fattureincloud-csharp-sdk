/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.6
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
    /// EmailScheduleInclude
    /// </summary>
    [DataContract(Name = "EmailSchedule_include")]
    public partial class EmailScheduleInclude : IEquatable<EmailScheduleInclude>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailScheduleInclude" /> class.
        /// </summary>
        /// <param name="document">If set to true, the email will have a button to view the document.</param>
        /// <param name="deliveryNote">If set to true, the email will have a button to view the delivery note.</param>
        /// <param name="attachment">If set to true, the email will have a button to view the attachment.</param>
        /// <param name="accompanyingInvoice">If set to true, the email will have a button to view the accompanying invoice.</param>
        public EmailScheduleInclude(bool document = default(bool), bool deliveryNote = default(bool), bool attachment = default(bool), bool accompanyingInvoice = default(bool))
        {
            this.Document = document;
            this.DeliveryNote = deliveryNote;
            this.Attachment = attachment;
            this.AccompanyingInvoice = accompanyingInvoice;
        }

        /// <summary>
        /// If set to true, the email will have a button to view the document
        /// </summary>
        /// <value>If set to true, the email will have a button to view the document</value>
        [DataMember(Name = "document", EmitDefaultValue = true)]
        public bool Document { get; set; }

        /// <summary>
        /// If set to true, the email will have a button to view the delivery note
        /// </summary>
        /// <value>If set to true, the email will have a button to view the delivery note</value>
        [DataMember(Name = "delivery_note", EmitDefaultValue = true)]
        public bool DeliveryNote { get; set; }

        /// <summary>
        /// If set to true, the email will have a button to view the attachment
        /// </summary>
        /// <value>If set to true, the email will have a button to view the attachment</value>
        [DataMember(Name = "attachment", EmitDefaultValue = true)]
        public bool Attachment { get; set; }

        /// <summary>
        /// If set to true, the email will have a button to view the accompanying invoice
        /// </summary>
        /// <value>If set to true, the email will have a button to view the accompanying invoice</value>
        [DataMember(Name = "accompanying_invoice", EmitDefaultValue = true)]
        public bool AccompanyingInvoice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailScheduleInclude {\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  DeliveryNote: ").Append(DeliveryNote).Append("\n");
            sb.Append("  Attachment: ").Append(Attachment).Append("\n");
            sb.Append("  AccompanyingInvoice: ").Append(AccompanyingInvoice).Append("\n");
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
            return this.Equals(input as EmailScheduleInclude);
        }

        /// <summary>
        /// Returns true if EmailScheduleInclude instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailScheduleInclude to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailScheduleInclude input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Document == input.Document ||
                    this.Document.Equals(input.Document)
                ) && 
                (
                    this.DeliveryNote == input.DeliveryNote ||
                    this.DeliveryNote.Equals(input.DeliveryNote)
                ) && 
                (
                    this.Attachment == input.Attachment ||
                    this.Attachment.Equals(input.Attachment)
                ) && 
                (
                    this.AccompanyingInvoice == input.AccompanyingInvoice ||
                    this.AccompanyingInvoice.Equals(input.AccompanyingInvoice)
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
                hashCode = hashCode * 59 + this.Document.GetHashCode();
                hashCode = hashCode * 59 + this.DeliveryNote.GetHashCode();
                hashCode = hashCode * 59 + this.Attachment.GetHashCode();
                hashCode = hashCode * 59 + this.AccompanyingInvoice.GetHashCode();
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
