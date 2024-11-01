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
    /// CashbookEntry
    /// </summary>
    [DataContract(Name = "CashbookEntry")]
    public partial class CashbookEntry : IEquatable<CashbookEntry>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Kind
        /// </summary>

        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public CashbookEntryKind? Kind
        {
            get { return _Kind; }
            set
            {
                _Kind = value;
                _flagKind = true;
            }
        }
        private CashbookEntryKind? _Kind;
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
        /// Gets or Sets Type
        /// </summary>

        [DataMember(Name = "type", EmitDefaultValue = true)]
        public CashbookEntryType? Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                _flagType = true;
            }
        }
        private CashbookEntryType? _Type;
        private bool _flagType;

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return _flagType;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CashbookEntry" /> class.
        /// </summary>
        /// <param name="id">Cashbook id.</param>
        /// <param name="date">Cashbook date.</param>
        /// <param name="description">Cashbook description.</param>
        /// <param name="kind">kind.</param>
        /// <param name="type">type.</param>
        /// <param name="entityName">Cashbook entity name.</param>
        /// <param name="document">document.</param>
        /// <param name="amountIn">[Only for cashbook entry in] Cashbook total amount in.</param>
        /// <param name="paymentAccountIn">paymentAccountIn.</param>
        /// <param name="amountOut">[Only for cashbook entry out] Cashbook total amount out.</param>
        /// <param name="paymentAccountOut">paymentAccountOut.</param>
        public CashbookEntry(string id = default(string), DateTime? date = default(DateTime?), string description = default(string), CashbookEntryKind? kind = default(CashbookEntryKind?), CashbookEntryType? type = default(CashbookEntryType?), string entityName = default(string), CashbookEntryDocument document = default(CashbookEntryDocument), decimal? amountIn = default(decimal?), PaymentAccount paymentAccountIn = default(PaymentAccount), decimal? amountOut = default(decimal?), PaymentAccount paymentAccountOut = default(PaymentAccount))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._Date = date;
            if (this.Date != null)
            {
                this._flagDate = true;
            }
            this._Description = description;
            if (this.Description != null)
            {
                this._flagDescription = true;
            }
            this._Kind = kind;
            if (this.Kind != null)
            {
                this._flagKind = true;
            }
            this._Type = type;
            if (this.Type != null)
            {
                this._flagType = true;
            }
            this._EntityName = entityName;
            if (this.EntityName != null)
            {
                this._flagEntityName = true;
            }
            this._Document = document;
            if (this.Document != null)
            {
                this._flagDocument = true;
            }
            this._AmountIn = amountIn;
            if (this.AmountIn != null)
            {
                this._flagAmountIn = true;
            }
            this._PaymentAccountIn = paymentAccountIn;
            if (this.PaymentAccountIn != null)
            {
                this._flagPaymentAccountIn = true;
            }
            this._AmountOut = amountOut;
            if (this.AmountOut != null)
            {
                this._flagAmountOut = true;
            }
            this._PaymentAccountOut = paymentAccountOut;
            if (this.PaymentAccountOut != null)
            {
                this._flagPaymentAccountOut = true;
            }
        }

        /// <summary>
        /// Cashbook id
        /// </summary>
        /// <value>Cashbook id</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
                _flagId = true;
            }
        }
        private string _Id;
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
        /// Cashbook date
        /// </summary>
        /// <value>Cashbook date</value>
        [JsonConverter(typeof(OpenAPIDateConverter))]
        [DataMember(Name = "date", EmitDefaultValue = true)]
        public DateTime? Date
        {
            get { return _Date; }
            set
            {
                _Date = value;
                _flagDate = true;
            }
        }
        private DateTime? _Date;
        private bool _flagDate;

        /// <summary>
        /// Returns false as Date should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDate()
        {
            return _flagDate;
        }
        /// <summary>
        /// Cashbook description
        /// </summary>
        /// <value>Cashbook description</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                _flagDescription = true;
            }
        }
        private string _Description;
        private bool _flagDescription;

        /// <summary>
        /// Returns false as Description should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDescription()
        {
            return _flagDescription;
        }
        /// <summary>
        /// Cashbook entity name
        /// </summary>
        /// <value>Cashbook entity name</value>
        [DataMember(Name = "entity_name", EmitDefaultValue = true)]
        public string EntityName
        {
            get { return _EntityName; }
            set
            {
                _EntityName = value;
                _flagEntityName = true;
            }
        }
        private string _EntityName;
        private bool _flagEntityName;

        /// <summary>
        /// Returns false as EntityName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEntityName()
        {
            return _flagEntityName;
        }
        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name = "document", EmitDefaultValue = true)]
        public CashbookEntryDocument Document
        {
            get { return _Document; }
            set
            {
                _Document = value;
                _flagDocument = true;
            }
        }
        private CashbookEntryDocument _Document;
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
        /// [Only for cashbook entry in] Cashbook total amount in
        /// </summary>
        /// <value>[Only for cashbook entry in] Cashbook total amount in</value>
        [DataMember(Name = "amount_in", EmitDefaultValue = true)]
        public decimal? AmountIn
        {
            get { return _AmountIn; }
            set
            {
                _AmountIn = value;
                _flagAmountIn = true;
            }
        }
        private decimal? _AmountIn;
        private bool _flagAmountIn;

        /// <summary>
        /// Returns false as AmountIn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountIn()
        {
            return _flagAmountIn;
        }
        /// <summary>
        /// Gets or Sets PaymentAccountIn
        /// </summary>
        [DataMember(Name = "payment_account_in", EmitDefaultValue = true)]
        public PaymentAccount PaymentAccountIn
        {
            get { return _PaymentAccountIn; }
            set
            {
                _PaymentAccountIn = value;
                _flagPaymentAccountIn = true;
            }
        }
        private PaymentAccount _PaymentAccountIn;
        private bool _flagPaymentAccountIn;

        /// <summary>
        /// Returns false as PaymentAccountIn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentAccountIn()
        {
            return _flagPaymentAccountIn;
        }
        /// <summary>
        /// [Only for cashbook entry out] Cashbook total amount out
        /// </summary>
        /// <value>[Only for cashbook entry out] Cashbook total amount out</value>
        [DataMember(Name = "amount_out", EmitDefaultValue = true)]
        public decimal? AmountOut
        {
            get { return _AmountOut; }
            set
            {
                _AmountOut = value;
                _flagAmountOut = true;
            }
        }
        private decimal? _AmountOut;
        private bool _flagAmountOut;

        /// <summary>
        /// Returns false as AmountOut should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountOut()
        {
            return _flagAmountOut;
        }
        /// <summary>
        /// Gets or Sets PaymentAccountOut
        /// </summary>
        [DataMember(Name = "payment_account_out", EmitDefaultValue = true)]
        public PaymentAccount PaymentAccountOut
        {
            get { return _PaymentAccountOut; }
            set
            {
                _PaymentAccountOut = value;
                _flagPaymentAccountOut = true;
            }
        }
        private PaymentAccount _PaymentAccountOut;
        private bool _flagPaymentAccountOut;

        /// <summary>
        /// Returns false as PaymentAccountOut should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentAccountOut()
        {
            return _flagPaymentAccountOut;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CashbookEntry {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  EntityName: ").Append(EntityName).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  AmountIn: ").Append(AmountIn).Append("\n");
            sb.Append("  PaymentAccountIn: ").Append(PaymentAccountIn).Append("\n");
            sb.Append("  AmountOut: ").Append(AmountOut).Append("\n");
            sb.Append("  PaymentAccountOut: ").Append(PaymentAccountOut).Append("\n");
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
            return this.Equals(input as CashbookEntry);
        }

        /// <summary>
        /// Returns true if CashbookEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of CashbookEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashbookEntry input)
        {
            if (input == null)
            {
                return false;
            }
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
                    this.AmountIn == input.AmountIn ||
                    (this.AmountIn != null &&
                    this.AmountIn.Equals(input.AmountIn))
                ) &&
                (
                    this.PaymentAccountIn == input.PaymentAccountIn ||
                    (this.PaymentAccountIn != null &&
                    this.PaymentAccountIn.Equals(input.PaymentAccountIn))
                ) &&
                (
                    this.AmountOut == input.AmountOut ||
                    (this.AmountOut != null &&
                    this.AmountOut.Equals(input.AmountOut))
                ) &&
                (
                    this.PaymentAccountOut == input.PaymentAccountOut ||
                    (this.PaymentAccountOut != null &&
                    this.PaymentAccountOut.Equals(input.PaymentAccountOut))
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Kind.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.EntityName != null)
                {
                    hashCode = (hashCode * 59) + this.EntityName.GetHashCode();
                }
                if (this.Document != null)
                {
                    hashCode = (hashCode * 59) + this.Document.GetHashCode();
                }
                if (this.AmountIn != null)
                {
                    hashCode = (hashCode * 59) + this.AmountIn.GetHashCode();
                }
                if (this.PaymentAccountIn != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentAccountIn.GetHashCode();
                }
                if (this.AmountOut != null)
                {
                    hashCode = (hashCode * 59) + this.AmountOut.GetHashCode();
                }
                if (this.PaymentAccountOut != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentAccountOut.GetHashCode();
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
