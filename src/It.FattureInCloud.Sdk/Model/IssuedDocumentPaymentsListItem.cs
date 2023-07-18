/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.29
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
    /// IssuedDocumentPaymentsListItem
    /// </summary>
    [DataContract(Name = "IssuedDocumentPaymentsListItem")]
    public partial class IssuedDocumentPaymentsListItem : IEquatable<IssuedDocumentPaymentsListItem>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>

        [DataMember(Name = "status", EmitDefaultValue = false)]
        public IssuedDocumentStatus? Status
        {
            get { return _Status; }
            set
            {
                _Status = value;
                _flagStatus = true;
            }
        }
        private IssuedDocumentStatus? _Status;
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
        /// Initializes a new instance of the <see cref="IssuedDocumentPaymentsListItem" /> class.
        /// </summary>
        /// <param name="id">Issued document payment item id.</param>
        /// <param name="dueDate">Issued document payment due date.</param>
        /// <param name="amount">Issued document payment amount.</param>
        /// <param name="status">status.</param>
        /// <param name="paymentAccount">paymentAccount.</param>
        /// <param name="paidDate">Issued document payment date [Only if status is paid].</param>
        /// <param name="eiRaw">Issued document payment advanced raw attributes for e-invoices.</param>
        /// <param name="paymentTerms">paymentTerms.</param>
        public IssuedDocumentPaymentsListItem(int? id = default(int?), DateTime? dueDate = default(DateTime?), decimal? amount = default(decimal?), IssuedDocumentStatus? status = default(IssuedDocumentStatus?), PaymentAccount paymentAccount = default(PaymentAccount), DateTime? paidDate = default(DateTime?), Object eiRaw = default(Object), IssuedDocumentPaymentsListItemPaymentTerms paymentTerms = default(IssuedDocumentPaymentsListItemPaymentTerms))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._DueDate = dueDate;
            if (this.DueDate != null)
            {
                this._flagDueDate = true;
            }
            this._Amount = amount;
            if (this.Amount != null)
            {
                this._flagAmount = true;
            }
            this._Status = status;
            if (this.Status != null)
            {
                this._flagStatus = true;
            }
            this._PaymentAccount = paymentAccount;
            if (this.PaymentAccount != null)
            {
                this._flagPaymentAccount = true;
            }
            this._PaidDate = paidDate;
            if (this.PaidDate != null)
            {
                this._flagPaidDate = true;
            }
            this._EiRaw = eiRaw;
            if (this.EiRaw != null)
            {
                this._flagEiRaw = true;
            }
            this._PaymentTerms = paymentTerms;
            if (this.PaymentTerms != null)
            {
                this._flagPaymentTerms = true;
            }
        }

        /// <summary>
        /// Issued document payment item id
        /// </summary>
        /// <value>Issued document payment item id</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id
        {
            get { return _Id; }
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
        /// Issued document payment due date
        /// </summary>
        /// <value>Issued document payment due date</value>
        /// <example>&quot;Tue Apr 03 00:00:00 UTC 2018&quot;</example>
        [JsonConverter(typeof(OpenAPIDateConverter))]
        [DataMember(Name = "due_date", EmitDefaultValue = true)]
        public DateTime? DueDate
        {
            get { return _DueDate; }
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
        /// Issued document payment amount
        /// </summary>
        /// <value>Issued document payment amount</value>
        /// <example>1.45</example>
        [DataMember(Name = "amount", EmitDefaultValue = true)]
        public decimal? Amount
        {
            get { return _Amount; }
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
        /// Gets or Sets PaymentAccount
        /// </summary>
        [DataMember(Name = "payment_account", EmitDefaultValue = true)]
        public PaymentAccount PaymentAccount
        {
            get { return _PaymentAccount; }
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
        /// Issued document payment date [Only if status is paid]
        /// </summary>
        /// <value>Issued document payment date [Only if status is paid]</value>
        /// <example>&quot;Tue Apr 03 00:00:00 UTC 2018&quot;</example>
        [JsonConverter(typeof(OpenAPIDateConverter))]
        [DataMember(Name = "paid_date", EmitDefaultValue = true)]
        public DateTime? PaidDate
        {
            get { return _PaidDate; }
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
        /// Issued document payment advanced raw attributes for e-invoices
        /// </summary>
        /// <value>Issued document payment advanced raw attributes for e-invoices</value>
        [DataMember(Name = "ei_raw", EmitDefaultValue = true)]
        public Object EiRaw
        {
            get { return _EiRaw; }
            set
            {
                _EiRaw = value;
                _flagEiRaw = true;
            }
        }
        private Object _EiRaw;
        private bool _flagEiRaw;

        /// <summary>
        /// Returns false as EiRaw should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEiRaw()
        {
            return _flagEiRaw;
        }
        /// <summary>
        /// Gets or Sets PaymentTerms
        /// </summary>
        [DataMember(Name = "payment_terms", EmitDefaultValue = false)]
        public IssuedDocumentPaymentsListItemPaymentTerms PaymentTerms
        {
            get { return _PaymentTerms; }
            set
            {
                _PaymentTerms = value;
                _flagPaymentTerms = true;
            }
        }
        private IssuedDocumentPaymentsListItemPaymentTerms _PaymentTerms;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssuedDocumentPaymentsListItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PaymentAccount: ").Append(PaymentAccount).Append("\n");
            sb.Append("  PaidDate: ").Append(PaidDate).Append("\n");
            sb.Append("  EiRaw: ").Append(EiRaw).Append("\n");
            sb.Append("  PaymentTerms: ").Append(PaymentTerms).Append("\n");
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
            return this.Equals(input as IssuedDocumentPaymentsListItem);
        }

        /// <summary>
        /// Returns true if IssuedDocumentPaymentsListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of IssuedDocumentPaymentsListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuedDocumentPaymentsListItem input)
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
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) &&
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) &&
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) &&
                (
                    this.PaymentAccount == input.PaymentAccount ||
                    (this.PaymentAccount != null &&
                    this.PaymentAccount.Equals(input.PaymentAccount))
                ) &&
                (
                    this.PaidDate == input.PaidDate ||
                    (this.PaidDate != null &&
                    this.PaidDate.Equals(input.PaidDate))
                ) &&
                (
                    this.EiRaw == input.EiRaw ||
                    (this.EiRaw != null &&
                    this.EiRaw.Equals(input.EiRaw))
                ) &&
                (
                    this.PaymentTerms == input.PaymentTerms ||
                    (this.PaymentTerms != null &&
                    this.PaymentTerms.Equals(input.PaymentTerms))
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
                if (this.DueDate != null)
                {
                    hashCode = (hashCode * 59) + this.DueDate.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.PaymentAccount != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentAccount.GetHashCode();
                }
                if (this.PaidDate != null)
                {
                    hashCode = (hashCode * 59) + this.PaidDate.GetHashCode();
                }
                if (this.EiRaw != null)
                {
                    hashCode = (hashCode * 59) + this.EiRaw.GetHashCode();
                }
                if (this.PaymentTerms != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentTerms.GetHashCode();
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
