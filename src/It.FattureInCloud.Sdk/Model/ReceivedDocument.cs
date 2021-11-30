/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.5
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
    /// ReceivedDocument
    /// </summary>
    [DataContract(Name = "ReceivedDocument")]
    public partial class ReceivedDocument : IEquatable<ReceivedDocument>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ReceivedDocumentType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivedDocument" /> class.
        /// </summary>
        /// <param name="id">Unique identifier of the document..</param>
        /// <param name="type">type.</param>
        /// <param name="entity">entity.</param>
        /// <param name="date">Date of the document [If not specified, today date is used]..</param>
        /// <param name="category">Document category..</param>
        /// <param name="description">Document description..</param>
        /// <param name="amountNet">Total net amount..</param>
        /// <param name="amountVat">Total vat amount..</param>
        /// <param name="amountWithholdingTax">Withholding tax amount..</param>
        /// <param name="amountOtherWithholdingTax">Other withholding tax amount..</param>
        /// <param name="amortization">Amortization value.</param>
        /// <param name="rcCenter">Revenue center..</param>
        /// <param name="invoiceNumber">Invoice number.</param>
        /// <param name="isMarked">isMarked.</param>
        /// <param name="isDetailed">isDetailed.</param>
        /// <param name="eInvoice">[Read Only] Indicates if this is an e-invoice..</param>
        /// <param name="currency">currency.</param>
        /// <param name="taxDeductibility">Tax deducibility percentage..</param>
        /// <param name="vatDeductibility">Vat deducibility percentage..</param>
        /// <param name="itemsList">itemsList.</param>
        /// <param name="paymentsList">paymentsList.</param>
        /// <param name="attachmentToken">Uploaded attachement token..</param>
        public ReceivedDocument(int id = default(int), ReceivedDocumentType? type = default(ReceivedDocumentType?), ReceivedDocumentEntity entity = default(ReceivedDocumentEntity), DateTimeOffset date = default(DateTimeOffset), string category = default(string), string description = default(string), decimal amountNet = default(decimal), decimal amountVat = default(decimal), decimal amountWithholdingTax = default(decimal), decimal amountOtherWithholdingTax = default(decimal), decimal amortization = default(decimal), string rcCenter = default(string), string invoiceNumber = default(string), bool isMarked = default(bool), bool isDetailed = default(bool), bool eInvoice = default(bool), Currency currency = default(Currency), decimal taxDeductibility = default(decimal), decimal vatDeductibility = default(decimal), List<ReceivedDocumentItemsList> itemsList = default(List<ReceivedDocumentItemsList>), List<ReceivedDocumentPaymentsList> paymentsList = default(List<ReceivedDocumentPaymentsList>), string attachmentToken = default(string))
        {
            this.Id = id;
            this.Type = type;
            this.Entity = entity;
            this.Date = date;
            this.Category = category;
            this.Description = description;
            this.AmountNet = amountNet;
            this.AmountVat = amountVat;
            this.AmountWithholdingTax = amountWithholdingTax;
            this.AmountOtherWithholdingTax = amountOtherWithholdingTax;
            this.Amortization = amortization;
            this.RcCenter = rcCenter;
            this.InvoiceNumber = invoiceNumber;
            this.IsMarked = isMarked;
            this.IsDetailed = isDetailed;
            this.EInvoice = eInvoice;
            this.Currency = currency;
            this.TaxDeductibility = taxDeductibility;
            this.VatDeductibility = vatDeductibility;
            this.ItemsList = itemsList;
            this.PaymentsList = paymentsList;
            this.AttachmentToken = attachmentToken;
        }

        /// <summary>
        /// Unique identifier of the document.
        /// </summary>
        /// <value>Unique identifier of the document.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public ReceivedDocumentEntity Entity { get; set; }

        /// <summary>
        /// Date of the document [If not specified, today date is used].
        /// </summary>
        /// <value>Date of the document [If not specified, today date is used].</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Document category.
        /// </summary>
        /// <value>Document category.</value>
        [DataMember(Name = "category", EmitDefaultValue = true)]
        public string Category { get; set; }

        /// <summary>
        /// Document description.
        /// </summary>
        /// <value>Document description.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Total net amount.
        /// </summary>
        /// <value>Total net amount.</value>
        [DataMember(Name = "amount_net", EmitDefaultValue = false)]
        public decimal AmountNet { get; set; }

        /// <summary>
        /// Total vat amount.
        /// </summary>
        /// <value>Total vat amount.</value>
        [DataMember(Name = "amount_vat", EmitDefaultValue = false)]
        public decimal AmountVat { get; set; }

        /// <summary>
        /// Withholding tax amount.
        /// </summary>
        /// <value>Withholding tax amount.</value>
        [DataMember(Name = "amount_withholding_tax", EmitDefaultValue = false)]
        public decimal AmountWithholdingTax { get; set; }

        /// <summary>
        /// Other withholding tax amount.
        /// </summary>
        /// <value>Other withholding tax amount.</value>
        [DataMember(Name = "amount_other_withholding_tax", EmitDefaultValue = false)]
        public decimal AmountOtherWithholdingTax { get; set; }

        /// <summary>
        /// [Read Only] Total gross amount.
        /// </summary>
        /// <value>[Read Only] Total gross amount.</value>
        [DataMember(Name = "amount_gross", EmitDefaultValue = false)]
        public decimal AmountGross { get; private set; }

        /// <summary>
        /// Returns false as AmountGross should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountGross()
        {
            return false;
        }
        /// <summary>
        /// Amortization value
        /// </summary>
        /// <value>Amortization value</value>
        [DataMember(Name = "amortization", EmitDefaultValue = false)]
        public decimal Amortization { get; set; }

        /// <summary>
        /// Revenue center.
        /// </summary>
        /// <value>Revenue center.</value>
        [DataMember(Name = "rc_center", EmitDefaultValue = false)]
        public string RcCenter { get; set; }

        /// <summary>
        /// Invoice number
        /// </summary>
        /// <value>Invoice number</value>
        [DataMember(Name = "invoice_number", EmitDefaultValue = false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Gets or Sets IsMarked
        /// </summary>
        [DataMember(Name = "is_marked", EmitDefaultValue = true)]
        public bool IsMarked { get; set; }

        /// <summary>
        /// Gets or Sets IsDetailed
        /// </summary>
        [DataMember(Name = "is_detailed", EmitDefaultValue = true)]
        public bool IsDetailed { get; set; }

        /// <summary>
        /// [Read Only] Indicates if this is an e-invoice.
        /// </summary>
        /// <value>[Read Only] Indicates if this is an e-invoice.</value>
        [DataMember(Name = "e_invoice", EmitDefaultValue = true)]
        public bool EInvoice { get; set; }

        /// <summary>
        /// [Read Only] Next due date.
        /// </summary>
        /// <value>[Read Only] Next due date.</value>
        [DataMember(Name = "next_due_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? NextDueDate { get; private set; }

        /// <summary>
        /// Returns false as NextDueDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNextDueDate()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public Currency Currency { get; set; }

        /// <summary>
        /// Tax deducibility percentage.
        /// </summary>
        /// <value>Tax deducibility percentage.</value>
        [DataMember(Name = "tax_deductibility", EmitDefaultValue = false)]
        public decimal TaxDeductibility { get; set; }

        /// <summary>
        /// Vat deducibility percentage.
        /// </summary>
        /// <value>Vat deducibility percentage.</value>
        [DataMember(Name = "vat_deductibility", EmitDefaultValue = false)]
        public decimal VatDeductibility { get; set; }

        /// <summary>
        /// Gets or Sets ItemsList
        /// </summary>
        [DataMember(Name = "items_list", EmitDefaultValue = true)]
        public List<ReceivedDocumentItemsList> ItemsList { get; set; }

        /// <summary>
        /// Gets or Sets PaymentsList
        /// </summary>
        [DataMember(Name = "payments_list", EmitDefaultValue = false)]
        public List<ReceivedDocumentPaymentsList> PaymentsList { get; set; }

        /// <summary>
        /// [Read Only] Attachment url.
        /// </summary>
        /// <value>[Read Only] Attachment url.</value>
        [DataMember(Name = "attachment_url", EmitDefaultValue = false)]
        public string AttachmentUrl { get; private set; }

        /// <summary>
        /// Returns false as AttachmentUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAttachmentUrl()
        {
            return false;
        }
        /// <summary>
        /// [Read Only] Attachment preview url.
        /// </summary>
        /// <value>[Read Only] Attachment preview url.</value>
        [DataMember(Name = "attachment_preview_url", EmitDefaultValue = false)]
        public string AttachmentPreviewUrl { get; private set; }

        /// <summary>
        /// Returns false as AttachmentPreviewUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAttachmentPreviewUrl()
        {
            return false;
        }
        /// <summary>
        /// Uploaded attachement token.
        /// </summary>
        /// <value>Uploaded attachement token.</value>
        [DataMember(Name = "attachment_token", EmitDefaultValue = true)]
        public string AttachmentToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReceivedDocument {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AmountNet: ").Append(AmountNet).Append("\n");
            sb.Append("  AmountVat: ").Append(AmountVat).Append("\n");
            sb.Append("  AmountWithholdingTax: ").Append(AmountWithholdingTax).Append("\n");
            sb.Append("  AmountOtherWithholdingTax: ").Append(AmountOtherWithholdingTax).Append("\n");
            sb.Append("  AmountGross: ").Append(AmountGross).Append("\n");
            sb.Append("  Amortization: ").Append(Amortization).Append("\n");
            sb.Append("  RcCenter: ").Append(RcCenter).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  IsMarked: ").Append(IsMarked).Append("\n");
            sb.Append("  IsDetailed: ").Append(IsDetailed).Append("\n");
            sb.Append("  EInvoice: ").Append(EInvoice).Append("\n");
            sb.Append("  NextDueDate: ").Append(NextDueDate).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  TaxDeductibility: ").Append(TaxDeductibility).Append("\n");
            sb.Append("  VatDeductibility: ").Append(VatDeductibility).Append("\n");
            sb.Append("  ItemsList: ").Append(ItemsList).Append("\n");
            sb.Append("  PaymentsList: ").Append(PaymentsList).Append("\n");
            sb.Append("  AttachmentUrl: ").Append(AttachmentUrl).Append("\n");
            sb.Append("  AttachmentPreviewUrl: ").Append(AttachmentPreviewUrl).Append("\n");
            sb.Append("  AttachmentToken: ").Append(AttachmentToken).Append("\n");
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
            return this.Equals(input as ReceivedDocument);
        }

        /// <summary>
        /// Returns true if ReceivedDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of ReceivedDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceivedDocument input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AmountNet == input.AmountNet ||
                    this.AmountNet.Equals(input.AmountNet)
                ) && 
                (
                    this.AmountVat == input.AmountVat ||
                    this.AmountVat.Equals(input.AmountVat)
                ) && 
                (
                    this.AmountWithholdingTax == input.AmountWithholdingTax ||
                    this.AmountWithholdingTax.Equals(input.AmountWithholdingTax)
                ) && 
                (
                    this.AmountOtherWithholdingTax == input.AmountOtherWithholdingTax ||
                    this.AmountOtherWithholdingTax.Equals(input.AmountOtherWithholdingTax)
                ) && 
                (
                    this.AmountGross == input.AmountGross ||
                    this.AmountGross.Equals(input.AmountGross)
                ) && 
                (
                    this.Amortization == input.Amortization ||
                    this.Amortization.Equals(input.Amortization)
                ) && 
                (
                    this.RcCenter == input.RcCenter ||
                    (this.RcCenter != null &&
                    this.RcCenter.Equals(input.RcCenter))
                ) && 
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) && 
                (
                    this.IsMarked == input.IsMarked ||
                    this.IsMarked.Equals(input.IsMarked)
                ) && 
                (
                    this.IsDetailed == input.IsDetailed ||
                    this.IsDetailed.Equals(input.IsDetailed)
                ) && 
                (
                    this.EInvoice == input.EInvoice ||
                    this.EInvoice.Equals(input.EInvoice)
                ) && 
                (
                    this.NextDueDate == input.NextDueDate ||
                    (this.NextDueDate != null &&
                    this.NextDueDate.Equals(input.NextDueDate))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.TaxDeductibility == input.TaxDeductibility ||
                    this.TaxDeductibility.Equals(input.TaxDeductibility)
                ) && 
                (
                    this.VatDeductibility == input.VatDeductibility ||
                    this.VatDeductibility.Equals(input.VatDeductibility)
                ) && 
                (
                    this.ItemsList == input.ItemsList ||
                    this.ItemsList != null &&
                    input.ItemsList != null &&
                    this.ItemsList.SequenceEqual(input.ItemsList)
                ) && 
                (
                    this.PaymentsList == input.PaymentsList ||
                    this.PaymentsList != null &&
                    input.PaymentsList != null &&
                    this.PaymentsList.SequenceEqual(input.PaymentsList)
                ) && 
                (
                    this.AttachmentUrl == input.AttachmentUrl ||
                    (this.AttachmentUrl != null &&
                    this.AttachmentUrl.Equals(input.AttachmentUrl))
                ) && 
                (
                    this.AttachmentPreviewUrl == input.AttachmentPreviewUrl ||
                    (this.AttachmentPreviewUrl != null &&
                    this.AttachmentPreviewUrl.Equals(input.AttachmentPreviewUrl))
                ) && 
                (
                    this.AttachmentToken == input.AttachmentToken ||
                    (this.AttachmentToken != null &&
                    this.AttachmentToken.Equals(input.AttachmentToken))
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.AmountNet.GetHashCode();
                hashCode = hashCode * 59 + this.AmountVat.GetHashCode();
                hashCode = hashCode * 59 + this.AmountWithholdingTax.GetHashCode();
                hashCode = hashCode * 59 + this.AmountOtherWithholdingTax.GetHashCode();
                hashCode = hashCode * 59 + this.AmountGross.GetHashCode();
                hashCode = hashCode * 59 + this.Amortization.GetHashCode();
                if (this.RcCenter != null)
                    hashCode = hashCode * 59 + this.RcCenter.GetHashCode();
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                hashCode = hashCode * 59 + this.IsMarked.GetHashCode();
                hashCode = hashCode * 59 + this.IsDetailed.GetHashCode();
                hashCode = hashCode * 59 + this.EInvoice.GetHashCode();
                if (this.NextDueDate != null)
                    hashCode = hashCode * 59 + this.NextDueDate.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                hashCode = hashCode * 59 + this.TaxDeductibility.GetHashCode();
                hashCode = hashCode * 59 + this.VatDeductibility.GetHashCode();
                if (this.ItemsList != null)
                    hashCode = hashCode * 59 + this.ItemsList.GetHashCode();
                if (this.PaymentsList != null)
                    hashCode = hashCode * 59 + this.PaymentsList.GetHashCode();
                if (this.AttachmentUrl != null)
                    hashCode = hashCode * 59 + this.AttachmentUrl.GetHashCode();
                if (this.AttachmentPreviewUrl != null)
                    hashCode = hashCode * 59 + this.AttachmentPreviewUrl.GetHashCode();
                if (this.AttachmentToken != null)
                    hashCode = hashCode * 59 + this.AttachmentToken.GetHashCode();
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
            // TaxDeductibility (decimal) maximum
            if(this.TaxDeductibility > (decimal)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxDeductibility, must be a value less than or equal to 100.", new [] { "TaxDeductibility" });
            }

            // TaxDeductibility (decimal) minimum
            if(this.TaxDeductibility < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxDeductibility, must be a value greater than or equal to 0.", new [] { "TaxDeductibility" });
            }

            // VatDeductibility (decimal) maximum
            if(this.VatDeductibility > (decimal)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VatDeductibility, must be a value less than or equal to 100.", new [] { "VatDeductibility" });
            }

            // VatDeductibility (decimal) minimum
            if(this.VatDeductibility < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VatDeductibility, must be a value greater than or equal to 0.", new [] { "VatDeductibility" });
            }

            yield break;
        }
    }

}
