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
    /// EmailScheduleInclude
    /// </summary>
    [DataContract(Name = "EmailSchedule_include")]
    public partial class EmailScheduleInclude : IEquatable<EmailScheduleInclude>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailScheduleInclude" /> class.
        /// </summary>
        /// <param name="document">Include a button to view the document.</param>
        /// <param name="deliveryNote">Include a button to view the delivery note.</param>
        /// <param name="attachment">Include a button to view the attachment.</param>
        /// <param name="accompanyingInvoice">Include a button to view the accompanying invoice.</param>
        public EmailScheduleInclude(bool? document = default(bool?), bool? deliveryNote = default(bool?), bool? attachment = default(bool?), bool? accompanyingInvoice = default(bool?))
        {
            this._Document = document;
            if (this.Document != null)
            {
                this._flagDocument = true;
            }
            this._DeliveryNote = deliveryNote;
            if (this.DeliveryNote != null)
            {
                this._flagDeliveryNote = true;
            }
            this._Attachment = attachment;
            if (this.Attachment != null)
            {
                this._flagAttachment = true;
            }
            this._AccompanyingInvoice = accompanyingInvoice;
            if (this.AccompanyingInvoice != null)
            {
                this._flagAccompanyingInvoice = true;
            }
        }

        /// <summary>
        /// Include a button to view the document
        /// </summary>
        /// <value>Include a button to view the document</value>
        [DataMember(Name = "document", EmitDefaultValue = true)]
        public bool? Document
        {
            get { return _Document; }
            set
            {
                _Document = value;
                _flagDocument = true;
            }
        }
        private bool? _Document;
        private bool _flagDocument;

        /// <summary>
        /// Returns false as Document should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDocument()
        {
            return _flagDocument;
        }
        /// <summary>
        /// Include a button to view the delivery note
        /// </summary>
        /// <value>Include a button to view the delivery note</value>
        [DataMember(Name = "delivery_note", EmitDefaultValue = true)]
        public bool? DeliveryNote
        {
            get { return _DeliveryNote; }
            set
            {
                _DeliveryNote = value;
                _flagDeliveryNote = true;
            }
        }
        private bool? _DeliveryNote;
        private bool _flagDeliveryNote;

        /// <summary>
        /// Returns false as DeliveryNote should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeliveryNote()
        {
            return _flagDeliveryNote;
        }
        /// <summary>
        /// Include a button to view the attachment
        /// </summary>
        /// <value>Include a button to view the attachment</value>
        [DataMember(Name = "attachment", EmitDefaultValue = true)]
        public bool? Attachment
        {
            get { return _Attachment; }
            set
            {
                _Attachment = value;
                _flagAttachment = true;
            }
        }
        private bool? _Attachment;
        private bool _flagAttachment;

        /// <summary>
        /// Returns false as Attachment should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAttachment()
        {
            return _flagAttachment;
        }
        /// <summary>
        /// Include a button to view the accompanying invoice
        /// </summary>
        /// <value>Include a button to view the accompanying invoice</value>
        [DataMember(Name = "accompanying_invoice", EmitDefaultValue = true)]
        public bool? AccompanyingInvoice
        {
            get { return _AccompanyingInvoice; }
            set
            {
                _AccompanyingInvoice = value;
                _flagAccompanyingInvoice = true;
            }
        }
        private bool? _AccompanyingInvoice;
        private bool _flagAccompanyingInvoice;

        /// <summary>
        /// Returns false as AccompanyingInvoice should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccompanyingInvoice()
        {
            return _flagAccompanyingInvoice;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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
            {
                return false;
            }
            return
                (
                    this.Document == input.Document ||
                    (this.Document != null &&
                    this.Document.Equals(input.Document))
                ) &&
                (
                    this.DeliveryNote == input.DeliveryNote ||
                    (this.DeliveryNote != null &&
                    this.DeliveryNote.Equals(input.DeliveryNote))
                ) &&
                (
                    this.Attachment == input.Attachment ||
                    (this.Attachment != null &&
                    this.Attachment.Equals(input.Attachment))
                ) &&
                (
                    this.AccompanyingInvoice == input.AccompanyingInvoice ||
                    (this.AccompanyingInvoice != null &&
                    this.AccompanyingInvoice.Equals(input.AccompanyingInvoice))
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
                if (this.Document != null)
                {
                    hashCode = (hashCode * 59) + this.Document.GetHashCode();
                }
                if (this.DeliveryNote != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryNote.GetHashCode();
                }
                if (this.Attachment != null)
                {
                    hashCode = (hashCode * 59) + this.Attachment.GetHashCode();
                }
                if (this.AccompanyingInvoice != null)
                {
                    hashCode = (hashCode * 59) + this.AccompanyingInvoice.GetHashCode();
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
