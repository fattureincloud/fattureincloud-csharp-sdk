/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.10
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
    /// ReceivedDocumentPaymentsListItem
    /// </summary>
    [DataContract(Name = "ReceivedDocumentPaymentsListItem")]
    public partial class ReceivedDocumentPaymentsListItem : IEquatable<ReceivedDocumentPaymentsListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivedDocumentPaymentsListItem" /> class.
        /// </summary>
        /// <param name="id">Unique identifier..</param>
        /// <param name="amount">Amount of items..</param>
        /// <param name="dueDate">Due date.</param>
        /// <param name="paidDate">Paid date.</param>
        /// <param name="paymentTerms">paymentTerms.</param>
        /// <param name="status">Payment status..</param>
        /// <param name="paymentAccount">paymentAccount.</param>
        public ReceivedDocumentPaymentsListItem(int id = default(int), decimal amount = default(decimal), DateTimeOffset dueDate = default(DateTimeOffset), DateTimeOffset paidDate = default(DateTimeOffset), ReceivedDocumentPaymentsListItemPaymentTerms paymentTerms = default(ReceivedDocumentPaymentsListItemPaymentTerms), string status = default(string), PaymentAccount paymentAccount = default(PaymentAccount))
        {
            this.Id = id;
            this.Amount = amount;
            this.DueDate = dueDate;
            this.PaidDate = paidDate;
            this.PaymentTerms = paymentTerms;
            this.Status = status;
            this.PaymentAccount = paymentAccount;
        }

        /// <summary>
        /// Unique identifier.
        /// </summary>
        /// <value>Unique identifier.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Amount of items.
        /// </summary>
        /// <value>Amount of items.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Due date
        /// </summary>
        /// <value>Due date</value>
        [DataMember(Name = "due_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTimeOffset DueDate { get; set; }

        /// <summary>
        /// Paid date
        /// </summary>
        /// <value>Paid date</value>
        [DataMember(Name = "paid_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTimeOffset PaidDate { get; set; }

        /// <summary>
        /// Gets or Sets PaymentTerms
        /// </summary>
        [DataMember(Name = "payment_terms", EmitDefaultValue = false)]
        public ReceivedDocumentPaymentsListItemPaymentTerms PaymentTerms { get; set; }

        /// <summary>
        /// Payment status.
        /// </summary>
        /// <value>Payment status.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets PaymentAccount
        /// </summary>
        [DataMember(Name = "payment_account", EmitDefaultValue = true)]
        public PaymentAccount PaymentAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReceivedDocumentPaymentsListItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  PaidDate: ").Append(PaidDate).Append("\n");
            sb.Append("  PaymentTerms: ").Append(PaymentTerms).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PaymentAccount: ").Append(PaymentAccount).Append("\n");
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
            return this.Equals(input as ReceivedDocumentPaymentsListItem);
        }

        /// <summary>
        /// Returns true if ReceivedDocumentPaymentsListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ReceivedDocumentPaymentsListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceivedDocumentPaymentsListItem input)
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
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.PaidDate == input.PaidDate ||
                    (this.PaidDate != null &&
                    this.PaidDate.Equals(input.PaidDate))
                ) && 
                (
                    this.PaymentTerms == input.PaymentTerms ||
                    (this.PaymentTerms != null &&
                    this.PaymentTerms.Equals(input.PaymentTerms))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.PaymentAccount == input.PaymentAccount ||
                    (this.PaymentAccount != null &&
                    this.PaymentAccount.Equals(input.PaymentAccount))
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.DueDate != null)
                {
                    hashCode = (hashCode * 59) + this.DueDate.GetHashCode();
                }
                if (this.PaidDate != null)
                {
                    hashCode = (hashCode * 59) + this.PaidDate.GetHashCode();
                }
                if (this.PaymentTerms != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentTerms.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.PaymentAccount != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentAccount.GetHashCode();
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
