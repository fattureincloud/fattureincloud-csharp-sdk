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
    /// Receipt
    /// </summary>
    [DataContract(Name = "Receipt")]
    public partial class Receipt : IEquatable<Receipt>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ReceiptType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Receipt" /> class.
        /// </summary>
        /// <param name="id">Receipt unique identifier..</param>
        /// <param name="date">Receipt date..</param>
        /// <param name="number">Receipt number..</param>
        /// <param name="numeration">If it&#39;s null or empty string use the default numeration..</param>
        /// <param name="amountNet">Total net amount..</param>
        /// <param name="amountVat">Total vat amount..</param>
        /// <param name="amountGross">Total gross amount..</param>
        /// <param name="useGrossPrices">useGrossPrices (default to false).</param>
        /// <param name="type">type.</param>
        /// <param name="description">Receipt description..</param>
        /// <param name="rcCenter">Revenue center..</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="paymentAccount">paymentAccount.</param>
        /// <param name="itemsList">itemsList.</param>
        public Receipt(int id = default(int), DateTimeOffset date = default(DateTimeOffset), decimal? number = default(decimal?), string numeration = default(string), decimal amountNet = default(decimal), decimal amountVat = default(decimal), decimal amountGross = default(decimal), bool useGrossPrices = false, ReceiptType? type = default(ReceiptType?), string description = default(string), string rcCenter = default(string), string createdAt = default(string), string updatedAt = default(string), PaymentAccount paymentAccount = default(PaymentAccount), List<ReceiptItemsListItem> itemsList = default(List<ReceiptItemsListItem>))
        {
            this.Id = id;
            this.Date = date;
            this.Number = number;
            this.Numeration = numeration;
            this.AmountNet = amountNet;
            this.AmountVat = amountVat;
            this.AmountGross = amountGross;
            this.UseGrossPrices = useGrossPrices;
            this.Type = type;
            this.Description = description;
            this.RcCenter = rcCenter;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.PaymentAccount = paymentAccount;
            this.ItemsList = itemsList;
        }

        /// <summary>
        /// Receipt unique identifier.
        /// </summary>
        /// <value>Receipt unique identifier.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Receipt date.
        /// </summary>
        /// <value>Receipt date.</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Receipt number.
        /// </summary>
        /// <value>Receipt number.</value>
        [DataMember(Name = "number", EmitDefaultValue = true)]
        public decimal? Number { get; set; }

        /// <summary>
        /// If it&#39;s null or empty string use the default numeration.
        /// </summary>
        /// <value>If it&#39;s null or empty string use the default numeration.</value>
        [DataMember(Name = "numeration", EmitDefaultValue = false)]
        public string Numeration { get; set; }

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
        /// Total gross amount.
        /// </summary>
        /// <value>Total gross amount.</value>
        [DataMember(Name = "amount_gross", EmitDefaultValue = false)]
        public decimal AmountGross { get; set; }

        /// <summary>
        /// Gets or Sets UseGrossPrices
        /// </summary>
        [DataMember(Name = "use_gross_prices", EmitDefaultValue = true)]
        public bool UseGrossPrices { get; set; }

        /// <summary>
        /// Receipt description.
        /// </summary>
        /// <value>Receipt description.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Revenue center.
        /// </summary>
        /// <value>Revenue center.</value>
        [DataMember(Name = "rc_center", EmitDefaultValue = false)]
        public string RcCenter { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets PaymentAccount
        /// </summary>
        [DataMember(Name = "payment_account", EmitDefaultValue = true)]
        public PaymentAccount PaymentAccount { get; set; }

        /// <summary>
        /// Gets or Sets ItemsList
        /// </summary>
        [DataMember(Name = "items_list", EmitDefaultValue = true)]
        public List<ReceiptItemsListItem> ItemsList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Receipt {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Numeration: ").Append(Numeration).Append("\n");
            sb.Append("  AmountNet: ").Append(AmountNet).Append("\n");
            sb.Append("  AmountVat: ").Append(AmountVat).Append("\n");
            sb.Append("  AmountGross: ").Append(AmountGross).Append("\n");
            sb.Append("  UseGrossPrices: ").Append(UseGrossPrices).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RcCenter: ").Append(RcCenter).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  PaymentAccount: ").Append(PaymentAccount).Append("\n");
            sb.Append("  ItemsList: ").Append(ItemsList).Append("\n");
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
            return this.Equals(input as Receipt);
        }

        /// <summary>
        /// Returns true if Receipt instances are equal
        /// </summary>
        /// <param name="input">Instance of Receipt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Receipt input)
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
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Numeration == input.Numeration ||
                    (this.Numeration != null &&
                    this.Numeration.Equals(input.Numeration))
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
                    this.AmountGross == input.AmountGross ||
                    this.AmountGross.Equals(input.AmountGross)
                ) && 
                (
                    this.UseGrossPrices == input.UseGrossPrices ||
                    this.UseGrossPrices.Equals(input.UseGrossPrices)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.RcCenter == input.RcCenter ||
                    (this.RcCenter != null &&
                    this.RcCenter.Equals(input.RcCenter))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.PaymentAccount == input.PaymentAccount ||
                    (this.PaymentAccount != null &&
                    this.PaymentAccount.Equals(input.PaymentAccount))
                ) && 
                (
                    this.ItemsList == input.ItemsList ||
                    this.ItemsList != null &&
                    input.ItemsList != null &&
                    this.ItemsList.SequenceEqual(input.ItemsList)
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
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.Numeration != null)
                {
                    hashCode = (hashCode * 59) + this.Numeration.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AmountNet.GetHashCode();
                hashCode = (hashCode * 59) + this.AmountVat.GetHashCode();
                hashCode = (hashCode * 59) + this.AmountGross.GetHashCode();
                hashCode = (hashCode * 59) + this.UseGrossPrices.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.RcCenter != null)
                {
                    hashCode = (hashCode * 59) + this.RcCenter.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.PaymentAccount != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentAccount.GetHashCode();
                }
                if (this.ItemsList != null)
                {
                    hashCode = (hashCode * 59) + this.ItemsList.GetHashCode();
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
