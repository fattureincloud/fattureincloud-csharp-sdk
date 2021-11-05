/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.3
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
    /// CashbookEntryInOut
    /// </summary>
    [DataContract(Name = "CashbookEntryInOut")]
    public partial class CashbookEntryInOut : IEquatable<CashbookEntryInOut>, IValidatableObject
    {
        /// <summary>
        /// Cashbook kind.
        /// </summary>
        /// <value>Cashbook kind.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KindEnum
        {
            /// <summary>
            /// Enum Cashbook for value: cashbook
            /// </summary>
            [EnumMember(Value = "cashbook")]
            Cashbook = 1,

            /// <summary>
            /// Enum IssuedDocument for value: issued_document
            /// </summary>
            [EnumMember(Value = "issued_document")]
            IssuedDocument = 2,

            /// <summary>
            /// Enum ReceivedDocument for value: received_document
            /// </summary>
            [EnumMember(Value = "received_document")]
            ReceivedDocument = 3,

            /// <summary>
            /// Enum Tax for value: tax
            /// </summary>
            [EnumMember(Value = "tax")]
            Tax = 4,

            /// <summary>
            /// Enum Receipt for value: receipt
            /// </summary>
            [EnumMember(Value = "receipt")]
            Receipt = 5

        }


        /// <summary>
        /// Cashbook kind.
        /// </summary>
        /// <value>Cashbook kind.</value>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public KindEnum? Kind { get; set; }
        /// <summary>
        /// Cashbook type.
        /// </summary>
        /// <value>Cashbook type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum In for value: in
            /// </summary>
            [EnumMember(Value = "in")]
            In = 1,

            /// <summary>
            /// Enum Out for value: out
            /// </summary>
            [EnumMember(Value = "out")]
            Out = 2

        }


        /// <summary>
        /// Cashbook type.
        /// </summary>
        /// <value>Cashbook type.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CashbookEntryInOut" /> class.
        /// </summary>
        /// <param name="id">Cashbook unique identifier..</param>
        /// <param name="date">Cashbook date..</param>
        /// <param name="description">Cashbook description..</param>
        /// <param name="kind">Cashbook kind..</param>
        /// <param name="type">Cashbook type..</param>
        /// <param name="entityName">Entity name..</param>
        /// <param name="document">document.</param>
        /// <param name="amountOut">Total amount out..</param>
        /// <param name="paymentAccountOut">paymentAccountOut.</param>
        /// <param name="amountIn">Total amount in..</param>
        /// <param name="paymentAccountIn">paymentAccountIn.</param>
        public CashbookEntryInOut(string id = default(string), DateTimeOffset date = default(DateTimeOffset), string description = default(string), KindEnum? kind = default(KindEnum?), TypeEnum? type = default(TypeEnum?), string entityName = default(string), CashbookEntryDataDocument document = default(CashbookEntryDataDocument), decimal amountOut = default(decimal), PaymentAccount paymentAccountOut = default(PaymentAccount), decimal amountIn = default(decimal), PaymentAccount paymentAccountIn = default(PaymentAccount))
        {
            this.Id = id;
            this.Date = date;
            this.Description = description;
            this.Kind = kind;
            this.Type = type;
            this.EntityName = entityName;
            this.Document = document;
            this.AmountOut = amountOut;
            this.PaymentAccountOut = paymentAccountOut;
            this.AmountIn = amountIn;
            this.PaymentAccountIn = paymentAccountIn;
        }

        /// <summary>
        /// Cashbook unique identifier.
        /// </summary>
        /// <value>Cashbook unique identifier.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Cashbook date.
        /// </summary>
        /// <value>Cashbook date.</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Cashbook description.
        /// </summary>
        /// <value>Cashbook description.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Entity name.
        /// </summary>
        /// <value>Entity name.</value>
        [DataMember(Name = "entity_name", EmitDefaultValue = true)]
        public string EntityName { get; set; }

        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name = "document", EmitDefaultValue = false)]
        public CashbookEntryDataDocument Document { get; set; }

        /// <summary>
        /// Total amount out.
        /// </summary>
        /// <value>Total amount out.</value>
        [DataMember(Name = "amount_out", EmitDefaultValue = false)]
        public decimal AmountOut { get; set; }

        /// <summary>
        /// Gets or Sets PaymentAccountOut
        /// </summary>
        [DataMember(Name = "payment_account_out", EmitDefaultValue = true)]
        public PaymentAccount PaymentAccountOut { get; set; }

        /// <summary>
        /// Total amount in.
        /// </summary>
        /// <value>Total amount in.</value>
        [DataMember(Name = "amount_in", EmitDefaultValue = false)]
        public decimal AmountIn { get; set; }

        /// <summary>
        /// Gets or Sets PaymentAccountIn
        /// </summary>
        [DataMember(Name = "payment_account_in", EmitDefaultValue = true)]
        public PaymentAccount PaymentAccountIn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CashbookEntryInOut {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  EntityName: ").Append(EntityName).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  AmountOut: ").Append(AmountOut).Append("\n");
            sb.Append("  PaymentAccountOut: ").Append(PaymentAccountOut).Append("\n");
            sb.Append("  AmountIn: ").Append(AmountIn).Append("\n");
            sb.Append("  PaymentAccountIn: ").Append(PaymentAccountIn).Append("\n");
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
            return this.Equals(input as CashbookEntryInOut);
        }

        /// <summary>
        /// Returns true if CashbookEntryInOut instances are equal
        /// </summary>
        /// <param name="input">Instance of CashbookEntryInOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashbookEntryInOut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Kind == input.Kind ||
                    this.Kind.Equals(input.Kind)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.EntityName == input.EntityName ||
                    (this.EntityName != null &&
                    this.EntityName.Equals(input.EntityName))
                ) && 
                (
                    this.Document == input.Document ||
                    (this.Document != null &&
                    this.Document.Equals(input.Document))
                ) && 
                (
                    this.AmountOut == input.AmountOut ||
                    this.AmountOut.Equals(input.AmountOut)
                ) && 
                (
                    this.PaymentAccountOut == input.PaymentAccountOut ||
                    (this.PaymentAccountOut != null &&
                    this.PaymentAccountOut.Equals(input.PaymentAccountOut))
                ) && 
                (
                    this.AmountIn == input.AmountIn ||
                    this.AmountIn.Equals(input.AmountIn)
                ) && 
                (
                    this.PaymentAccountIn == input.PaymentAccountIn ||
                    (this.PaymentAccountIn != null &&
                    this.PaymentAccountIn.Equals(input.PaymentAccountIn))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Kind.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.EntityName != null)
                    hashCode = hashCode * 59 + this.EntityName.GetHashCode();
                if (this.Document != null)
                    hashCode = hashCode * 59 + this.Document.GetHashCode();
                hashCode = hashCode * 59 + this.AmountOut.GetHashCode();
                if (this.PaymentAccountOut != null)
                    hashCode = hashCode * 59 + this.PaymentAccountOut.GetHashCode();
                hashCode = hashCode * 59 + this.AmountIn.GetHashCode();
                if (this.PaymentAccountIn != null)
                    hashCode = hashCode * 59 + this.PaymentAccountIn.GetHashCode();
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