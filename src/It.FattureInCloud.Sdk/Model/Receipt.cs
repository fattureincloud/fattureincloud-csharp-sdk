/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.1.0
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
        public ReceiptType? Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                _flagType = true;
            }
        }
        private ReceiptType? _Type;
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
        /// Initializes a new instance of the <see cref="Receipt" /> class.
        /// </summary>
        /// <param name="id">Receipt id.</param>
        /// <param name="date">Receipt date.</param>
        /// <param name="number">Receipt number.</param>
        /// <param name="numeration">Receipt numeration.</param>
        /// <param name="amountNet">Receipt total net amount.</param>
        /// <param name="amountVat">Receipt total vat amount.</param>
        /// <param name="amountGross">Receipt total gross amount.</param>
        /// <param name="useGrossPrices">Receipt uses gross prices.</param>
        /// <param name="type">type.</param>
        /// <param name="description">Receipt description.</param>
        /// <param name="rcCenter">Receipt revenue center.</param>
        /// <param name="createdAt">Receipt creation date.</param>
        /// <param name="updatedAt">Receipt last update date.</param>
        /// <param name="paymentAccount">paymentAccount.</param>
        /// <param name="itemsList">itemsList.</param>
        public Receipt(int? id = default(int?), DateTime? date = default(DateTime?), decimal? number = default(decimal?), string numeration = default(string), decimal? amountNet = default(decimal?), decimal? amountVat = default(decimal?), decimal? amountGross = default(decimal?), bool? useGrossPrices = default(bool?), ReceiptType? type = default(ReceiptType?), string description = default(string), string rcCenter = default(string), string createdAt = default(string), string updatedAt = default(string), PaymentAccount paymentAccount = default(PaymentAccount), List<ReceiptItemsListItem> itemsList = default(List<ReceiptItemsListItem>))
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
            this._Number = number;
            if (this.Number != null)
            {
                this._flagNumber = true;
            }
            this._Numeration = numeration;
            if (this.Numeration != null)
            {
                this._flagNumeration = true;
            }
            this._AmountNet = amountNet;
            if (this.AmountNet != null)
            {
                this._flagAmountNet = true;
            }
            this._AmountVat = amountVat;
            if (this.AmountVat != null)
            {
                this._flagAmountVat = true;
            }
            this._AmountGross = amountGross;
            if (this.AmountGross != null)
            {
                this._flagAmountGross = true;
            }
            this._UseGrossPrices = useGrossPrices;
            if (this.UseGrossPrices != null)
            {
                this._flagUseGrossPrices = true;
            }
            this._Type = type;
            if (this.Type != null)
            {
                this._flagType = true;
            }
            this._Description = description;
            if (this.Description != null)
            {
                this._flagDescription = true;
            }
            this._RcCenter = rcCenter;
            if (this.RcCenter != null)
            {
                this._flagRcCenter = true;
            }
            this._CreatedAt = createdAt;
            if (this.CreatedAt != null)
            {
                this._flagCreatedAt = true;
            }
            this._UpdatedAt = updatedAt;
            if (this.UpdatedAt != null)
            {
                this._flagUpdatedAt = true;
            }
            this._PaymentAccount = paymentAccount;
            if (this.PaymentAccount != null)
            {
                this._flagPaymentAccount = true;
            }
            this._ItemsList = itemsList;
            if (this.ItemsList != null)
            {
                this._flagItemsList = true;
            }
        }

        /// <summary>
        /// Receipt id
        /// </summary>
        /// <value>Receipt id</value>
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
        /// Receipt date
        /// </summary>
        /// <value>Receipt date</value>
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
        /// Receipt number
        /// </summary>
        /// <value>Receipt number</value>
        [DataMember(Name = "number", EmitDefaultValue = true)]
        public decimal? Number
        {
            get { return _Number; }
            set
            {
                _Number = value;
                _flagNumber = true;
            }
        }
        private decimal? _Number;
        private bool _flagNumber;

        /// <summary>
        /// Returns false as Number should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNumber()
        {
            return _flagNumber;
        }
        /// <summary>
        /// Receipt numeration
        /// </summary>
        /// <value>Receipt numeration</value>
        [DataMember(Name = "numeration", EmitDefaultValue = true)]
        public string Numeration
        {
            get { return _Numeration; }
            set
            {
                _Numeration = value;
                _flagNumeration = true;
            }
        }
        private string _Numeration;
        private bool _flagNumeration;

        /// <summary>
        /// Returns false as Numeration should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNumeration()
        {
            return _flagNumeration;
        }
        /// <summary>
        /// Receipt total net amount
        /// </summary>
        /// <value>Receipt total net amount</value>
        [DataMember(Name = "amount_net", EmitDefaultValue = true)]
        public decimal? AmountNet
        {
            get { return _AmountNet; }
            set
            {
                _AmountNet = value;
                _flagAmountNet = true;
            }
        }
        private decimal? _AmountNet;
        private bool _flagAmountNet;

        /// <summary>
        /// Returns false as AmountNet should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountNet()
        {
            return _flagAmountNet;
        }
        /// <summary>
        /// Receipt total vat amount
        /// </summary>
        /// <value>Receipt total vat amount</value>
        [DataMember(Name = "amount_vat", EmitDefaultValue = true)]
        public decimal? AmountVat
        {
            get { return _AmountVat; }
            set
            {
                _AmountVat = value;
                _flagAmountVat = true;
            }
        }
        private decimal? _AmountVat;
        private bool _flagAmountVat;

        /// <summary>
        /// Returns false as AmountVat should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountVat()
        {
            return _flagAmountVat;
        }
        /// <summary>
        /// Receipt total gross amount
        /// </summary>
        /// <value>Receipt total gross amount</value>
        [DataMember(Name = "amount_gross", EmitDefaultValue = true)]
        public decimal? AmountGross
        {
            get { return _AmountGross; }
            set
            {
                _AmountGross = value;
                _flagAmountGross = true;
            }
        }
        private decimal? _AmountGross;
        private bool _flagAmountGross;

        /// <summary>
        /// Returns false as AmountGross should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountGross()
        {
            return _flagAmountGross;
        }
        /// <summary>
        /// Receipt uses gross prices
        /// </summary>
        /// <value>Receipt uses gross prices</value>
        [DataMember(Name = "use_gross_prices", EmitDefaultValue = true)]
        public bool? UseGrossPrices
        {
            get { return _UseGrossPrices; }
            set
            {
                _UseGrossPrices = value;
                _flagUseGrossPrices = true;
            }
        }
        private bool? _UseGrossPrices;
        private bool _flagUseGrossPrices;

        /// <summary>
        /// Returns false as UseGrossPrices should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUseGrossPrices()
        {
            return _flagUseGrossPrices;
        }
        /// <summary>
        /// Receipt description
        /// </summary>
        /// <value>Receipt description</value>
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
        /// Receipt revenue center
        /// </summary>
        /// <value>Receipt revenue center</value>
        [DataMember(Name = "rc_center", EmitDefaultValue = true)]
        public string RcCenter
        {
            get { return _RcCenter; }
            set
            {
                _RcCenter = value;
                _flagRcCenter = true;
            }
        }
        private string _RcCenter;
        private bool _flagRcCenter;

        /// <summary>
        /// Returns false as RcCenter should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRcCenter()
        {
            return _flagRcCenter;
        }
        /// <summary>
        /// Receipt creation date
        /// </summary>
        /// <value>Receipt creation date</value>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public string CreatedAt
        {
            get { return _CreatedAt; }
            set
            {
                _CreatedAt = value;
                _flagCreatedAt = true;
            }
        }
        private string _CreatedAt;
        private bool _flagCreatedAt;

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return _flagCreatedAt;
        }
        /// <summary>
        /// Receipt last update date
        /// </summary>
        /// <value>Receipt last update date</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public string UpdatedAt
        {
            get { return _UpdatedAt; }
            set
            {
                _UpdatedAt = value;
                _flagUpdatedAt = true;
            }
        }
        private string _UpdatedAt;
        private bool _flagUpdatedAt;

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return _flagUpdatedAt;
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
        /// Gets or Sets ItemsList
        /// </summary>
        [DataMember(Name = "items_list", EmitDefaultValue = true)]
        public List<ReceiptItemsListItem> ItemsList
        {
            get { return _ItemsList; }
            set
            {
                _ItemsList = value;
                _flagItemsList = true;
            }
        }
        private List<ReceiptItemsListItem> _ItemsList;
        private bool _flagItemsList;

        /// <summary>
        /// Returns false as ItemsList should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeItemsList()
        {
            return _flagItemsList;
        }
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
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    (this.AmountNet != null &&
                    this.AmountNet.Equals(input.AmountNet))
                ) &&
                (
                    this.AmountVat == input.AmountVat ||
                    (this.AmountVat != null &&
                    this.AmountVat.Equals(input.AmountVat))
                ) &&
                (
                    this.AmountGross == input.AmountGross ||
                    (this.AmountGross != null &&
                    this.AmountGross.Equals(input.AmountGross))
                ) &&
                (
                    this.UseGrossPrices == input.UseGrossPrices ||
                    (this.UseGrossPrices != null &&
                    this.UseGrossPrices.Equals(input.UseGrossPrices))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
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
                if (this.AmountNet != null)
                {
                    hashCode = (hashCode * 59) + this.AmountNet.GetHashCode();
                }
                if (this.AmountVat != null)
                {
                    hashCode = (hashCode * 59) + this.AmountVat.GetHashCode();
                }
                if (this.AmountGross != null)
                {
                    hashCode = (hashCode * 59) + this.AmountGross.GetHashCode();
                }
                if (this.UseGrossPrices != null)
                {
                    hashCode = (hashCode * 59) + this.UseGrossPrices.GetHashCode();
                }
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
