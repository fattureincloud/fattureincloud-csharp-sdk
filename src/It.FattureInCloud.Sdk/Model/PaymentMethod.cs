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
    /// PaymentMethod
    /// </summary>
    [DataContract(Name = "PaymentMethod")]
    public partial class PaymentMethod : IEquatable<PaymentMethod>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>

        [DataMember(Name = "type", EmitDefaultValue = false)]
        public PaymentMethodType? Type
        {
            get{ return _Type;}
            set
            {
                _Type = value;
                _flagType = true;
            }
        }
        private PaymentMethodType? _Type;
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
        /// Initializes a new instance of the <see cref="PaymentMethod" /> class.
        /// </summary>
        /// <param name="id">Unique identifier.</param>
        /// <param name="name">Name of the payment method.</param>
        /// <param name="type">type.</param>
        /// <param name="isDefault">Determines if this is the default payment method..</param>
        /// <param name="defaultPaymentAccount">defaultPaymentAccount.</param>
        /// <param name="details">Method details rows.</param>
        /// <param name="bankIban">Bank iban.</param>
        /// <param name="bankName">Bank name.</param>
        /// <param name="bankBeneficiary">Bank beneficiary.</param>
        /// <param name="eiPaymentMethod">EInvoice payment method.</param>
        public PaymentMethod(int? id = default(int?), string name = default(string), PaymentMethodType? type = default(PaymentMethodType?), bool? isDefault = default(bool?), PaymentAccount defaultPaymentAccount = default(PaymentAccount), List<PaymentMethodDetails> details = default(List<PaymentMethodDetails>), string bankIban = default(string), string bankName = default(string), string bankBeneficiary = default(string), string eiPaymentMethod = default(string))
        {
            this._Id = id;
            this._Name = name;
            this._Type = type;
            this._IsDefault = isDefault;
            this._DefaultPaymentAccount = defaultPaymentAccount;
            this._Details = details;
            this._BankIban = bankIban;
            this._BankName = bankName;
            this._BankBeneficiary = bankBeneficiary;
            this._EiPaymentMethod = eiPaymentMethod;
        }

        /// <summary>
        /// Unique identifier
        /// </summary>
        /// <value>Unique identifier</value>
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
        /// Name of the payment method
        /// </summary>
        /// <value>Name of the payment method</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name
        {
            get{ return _Name;}
            set
            {
                _Name = value;
                _flagName = true;
            }
        }
        private string _Name;
        private bool _flagName;

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return _flagName;
        }
        /// <summary>
        /// Determines if this is the default payment method.
        /// </summary>
        /// <value>Determines if this is the default payment method.</value>
        [DataMember(Name = "is_default", EmitDefaultValue = true)]
        public bool? IsDefault
        {
            get{ return _IsDefault;}
            set
            {
                _IsDefault = value;
                _flagIsDefault = true;
            }
        }
        private bool? _IsDefault;
        private bool _flagIsDefault;

        /// <summary>
        /// Returns false as IsDefault should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsDefault()
        {
            return _flagIsDefault;
        }
        /// <summary>
        /// Gets or Sets DefaultPaymentAccount
        /// </summary>
        [DataMember(Name = "default_payment_account", EmitDefaultValue = true)]
        public PaymentAccount DefaultPaymentAccount
        {
            get{ return _DefaultPaymentAccount;}
            set
            {
                _DefaultPaymentAccount = value;
                _flagDefaultPaymentAccount = true;
            }
        }
        private PaymentAccount _DefaultPaymentAccount;
        private bool _flagDefaultPaymentAccount;

        /// <summary>
        /// Returns false as DefaultPaymentAccount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDefaultPaymentAccount()
        {
            return _flagDefaultPaymentAccount;
        }
        /// <summary>
        /// Method details rows
        /// </summary>
        /// <value>Method details rows</value>
        [DataMember(Name = "details", EmitDefaultValue = true)]
        public List<PaymentMethodDetails> Details
        {
            get{ return _Details;}
            set
            {
                _Details = value;
                _flagDetails = true;
            }
        }
        private List<PaymentMethodDetails> _Details;
        private bool _flagDetails;

        /// <summary>
        /// Returns false as Details should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDetails()
        {
            return _flagDetails;
        }
        /// <summary>
        /// Bank iban
        /// </summary>
        /// <value>Bank iban</value>
        [DataMember(Name = "bank_iban", EmitDefaultValue = true)]
        public string BankIban
        {
            get{ return _BankIban;}
            set
            {
                _BankIban = value;
                _flagBankIban = true;
            }
        }
        private string _BankIban;
        private bool _flagBankIban;

        /// <summary>
        /// Returns false as BankIban should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBankIban()
        {
            return _flagBankIban;
        }
        /// <summary>
        /// Bank name
        /// </summary>
        /// <value>Bank name</value>
        [DataMember(Name = "bank_name", EmitDefaultValue = true)]
        public string BankName
        {
            get{ return _BankName;}
            set
            {
                _BankName = value;
                _flagBankName = true;
            }
        }
        private string _BankName;
        private bool _flagBankName;

        /// <summary>
        /// Returns false as BankName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBankName()
        {
            return _flagBankName;
        }
        /// <summary>
        /// Bank beneficiary
        /// </summary>
        /// <value>Bank beneficiary</value>
        [DataMember(Name = "bank_beneficiary", EmitDefaultValue = true)]
        public string BankBeneficiary
        {
            get{ return _BankBeneficiary;}
            set
            {
                _BankBeneficiary = value;
                _flagBankBeneficiary = true;
            }
        }
        private string _BankBeneficiary;
        private bool _flagBankBeneficiary;

        /// <summary>
        /// Returns false as BankBeneficiary should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBankBeneficiary()
        {
            return _flagBankBeneficiary;
        }
        /// <summary>
        /// EInvoice payment method
        /// </summary>
        /// <value>EInvoice payment method</value>
        [DataMember(Name = "ei_payment_method", EmitDefaultValue = true)]
        public string EiPaymentMethod
        {
            get{ return _EiPaymentMethod;}
            set
            {
                _EiPaymentMethod = value;
                _flagEiPaymentMethod = true;
            }
        }
        private string _EiPaymentMethod;
        private bool _flagEiPaymentMethod;

        /// <summary>
        /// Returns false as EiPaymentMethod should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEiPaymentMethod()
        {
            return _flagEiPaymentMethod;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethod {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  DefaultPaymentAccount: ").Append(DefaultPaymentAccount).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  BankIban: ").Append(BankIban).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  BankBeneficiary: ").Append(BankBeneficiary).Append("\n");
            sb.Append("  EiPaymentMethod: ").Append(EiPaymentMethod).Append("\n");
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
            return this.Equals(input as PaymentMethod);
        }

        /// <summary>
        /// Returns true if PaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethod input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    (this.IsDefault != null &&
                    this.IsDefault.Equals(input.IsDefault))
                ) && 
                (
                    this.DefaultPaymentAccount == input.DefaultPaymentAccount ||
                    (this.DefaultPaymentAccount != null &&
                    this.DefaultPaymentAccount.Equals(input.DefaultPaymentAccount))
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.BankIban == input.BankIban ||
                    (this.BankIban != null &&
                    this.BankIban.Equals(input.BankIban))
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.BankBeneficiary == input.BankBeneficiary ||
                    (this.BankBeneficiary != null &&
                    this.BankBeneficiary.Equals(input.BankBeneficiary))
                ) && 
                (
                    this.EiPaymentMethod == input.EiPaymentMethod ||
                    (this.EiPaymentMethod != null &&
                    this.EiPaymentMethod.Equals(input.EiPaymentMethod))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.IsDefault != null)
                {
                    hashCode = (hashCode * 59) + this.IsDefault.GetHashCode();
                }
                if (this.DefaultPaymentAccount != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultPaymentAccount.GetHashCode();
                }
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
                }
                if (this.BankIban != null)
                {
                    hashCode = (hashCode * 59) + this.BankIban.GetHashCode();
                }
                if (this.BankName != null)
                {
                    hashCode = (hashCode * 59) + this.BankName.GetHashCode();
                }
                if (this.BankBeneficiary != null)
                {
                    hashCode = (hashCode * 59) + this.BankBeneficiary.GetHashCode();
                }
                if (this.EiPaymentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.EiPaymentMethod.GetHashCode();
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
