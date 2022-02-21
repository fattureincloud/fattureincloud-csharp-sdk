/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.12
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
        public ReceivedDocumentPaymentsListItem(int? id = default(int?), decimal? amount = default(decimal?), DateTime? dueDate = default(DateTime?), DateTime? paidDate = default(DateTime?), ReceivedDocumentPaymentsListItemPaymentTerms paymentTerms = default(ReceivedDocumentPaymentsListItemPaymentTerms), string status = default(string), PaymentAccount paymentAccount = default(PaymentAccount))
        {
            this._Id = id;
            this._Amount = amount;
            this._DueDate = dueDate;
            this._PaidDate = paidDate;
            this._PaymentTerms = paymentTerms;
            this._Status = status;
            this._PaymentAccount = paymentAccount;
        }

        /// <summary>
        /// Unique identifier.
        /// </summary>
        /// <value>Unique identifier.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id
        {
            get{ return _Id;}
            set
            {
                _Id = value;
                _flagId = true;
            }
        }
        private int? _Id;
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
        /// Amount of items.
        /// </summary>
        /// <value>Amount of items.</value>
        [DataMember(Name = "amount", EmitDefaultValue = true)]
        public decimal? Amount
        {
            get{ return _Amount;}
            set
            {
                _Amount = value;
                _flagAmount = true;
            }
        }
        private decimal? _Amount;
        private bool _flagAmount;

        /// <summary>
        /// Returns false as Amount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmount()
        {
            return _flagAmount;
        }
        /// <summary>
        /// Due date
        /// </summary>
        /// <value>Due date</value>
        [JsonConverter(typeof(OpenAPIDateConverter))]
        [DataMember(Name = "due_date", EmitDefaultValue = true)]
        public DateTime? DueDate
        {
            get{ return _DueDate;}
            set
            {
                _DueDate = value;
                _flagDueDate = true;
            }
        }
        private DateTime? _DueDate;
        private bool _flagDueDate;

        /// <summary>
        /// Returns false as DueDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDueDate()
        {
            return _flagDueDate;
        }
        /// <summary>
        /// Paid date
        /// </summary>
        /// <value>Paid date</value>
        [JsonConverter(typeof(OpenAPIDateConverter))]
        [DataMember(Name = "paid_date", EmitDefaultValue = true)]
        public DateTime? PaidDate
        {
            get{ return _PaidDate;}
            set
            {
                _PaidDate = value;
                _flagPaidDate = true;
            }
        }
        private DateTime? _PaidDate;
        private bool _flagPaidDate;

        /// <summary>
        /// Returns false as PaidDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaidDate()
        {
            return _flagPaidDate;
        }
        /// <summary>
        /// Gets or Sets PaymentTerms
        /// </summary>
        [DataMember(Name = "payment_terms", EmitDefaultValue = true)]
        public ReceivedDocumentPaymentsListItemPaymentTerms PaymentTerms
        {
            get{ return _PaymentTerms;}
            set
            {
                _PaymentTerms = value;
                _flagPaymentTerms = true;
            }
        }
        private ReceivedDocumentPaymentsListItemPaymentTerms _PaymentTerms;
        private bool _flagPaymentTerms;

        /// <summary>
        /// Returns false as PaymentTerms should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentTerms()
        {
            return _flagPaymentTerms;
        }
        /// <summary>
        /// Payment status.
        /// </summary>
        /// <value>Payment status.</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status
        {
            get{ return _Status;}
            set
            {
                _Status = value;
                _flagStatus = true;
            }
        }
        private string _Status;
        private bool _flagStatus;

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
        {
            return _flagStatus;
        }
        /// <summary>
        /// Gets or Sets PaymentAccount
        /// </summary>
        [DataMember(Name = "payment_account", EmitDefaultValue = true)]
        public PaymentAccount PaymentAccount
        {
            get{ return _PaymentAccount;}
            set
            {
                _PaymentAccount = value;
                _flagPaymentAccount = true;
            }
        }
        private PaymentAccount _PaymentAccount;
        private bool _flagPaymentAccount;

        /// <summary>
        /// Returns false as PaymentAccount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentAccount()
        {
            return _flagPaymentAccount;
        }
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
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
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
