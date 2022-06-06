/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.18
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
    /// PaymentAccount
    /// </summary>
    [DataContract(Name = "PaymentAccount")]
    public partial class PaymentAccount : IEquatable<PaymentAccount>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>

        [DataMember(Name = "type", EmitDefaultValue = false)]
        public PaymentAccountType? Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                _flagType = true;
            }
        }
        private PaymentAccountType? _Type;
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
        /// Initializes a new instance of the <see cref="PaymentAccount" /> class.
        /// </summary>
        /// <param name="id">Unique identifier.</param>
        /// <param name="name">Payment account name..</param>
        /// <param name="type">type.</param>
        /// <param name="iban">Payment account iban..</param>
        /// <param name="sia">Payment account sia..</param>
        /// <param name="cuc">Payment account cuc..</param>
        /// <param name="_virtual">Determine if the payment method is virtual..</param>
        public PaymentAccount(int? id = default(int?), string name = default(string), PaymentAccountType? type = default(PaymentAccountType?), string iban = default(string), string sia = default(string), string cuc = default(string), bool? _virtual = default(bool?))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._Name = name;
            if (this.Name != null)
            {
                this._flagName = true;
            }
            this._Type = type;
            if (this.Type != null)
            {
                this._flagType = true;
            }
            this._Iban = iban;
            if (this.Iban != null)
            {
                this._flagIban = true;
            }
            this._Sia = sia;
            if (this.Sia != null)
            {
                this._flagSia = true;
            }
            this._Cuc = cuc;
            if (this.Cuc != null)
            {
                this._flagCuc = true;
            }
            this._Virtual = _virtual;
            if (this.Virtual != null)
            {
                this._flagVirtual = true;
            }
        }

        /// <summary>
        /// Unique identifier
        /// </summary>
        /// <value>Unique identifier</value>
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
        /// Payment account name.
        /// </summary>
        /// <value>Payment account name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name
        {
            get { return _Name; }
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
        /// Payment account iban.
        /// </summary>
        /// <value>Payment account iban.</value>
        [DataMember(Name = "iban", EmitDefaultValue = true)]
        public string Iban
        {
            get { return _Iban; }
            set
            {
                _Iban = value;
                _flagIban = true;
            }
        }
        private string _Iban;
        private bool _flagIban;

        /// <summary>
        /// Returns false as Iban should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIban()
        {
            return _flagIban;
        }
        /// <summary>
        /// Payment account sia.
        /// </summary>
        /// <value>Payment account sia.</value>
        [DataMember(Name = "sia", EmitDefaultValue = true)]
        public string Sia
        {
            get { return _Sia; }
            set
            {
                _Sia = value;
                _flagSia = true;
            }
        }
        private string _Sia;
        private bool _flagSia;

        /// <summary>
        /// Returns false as Sia should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSia()
        {
            return _flagSia;
        }
        /// <summary>
        /// Payment account cuc.
        /// </summary>
        /// <value>Payment account cuc.</value>
        [DataMember(Name = "cuc", EmitDefaultValue = true)]
        public string Cuc
        {
            get { return _Cuc; }
            set
            {
                _Cuc = value;
                _flagCuc = true;
            }
        }
        private string _Cuc;
        private bool _flagCuc;

        /// <summary>
        /// Returns false as Cuc should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCuc()
        {
            return _flagCuc;
        }
        /// <summary>
        /// Determine if the payment method is virtual.
        /// </summary>
        /// <value>Determine if the payment method is virtual.</value>
        [DataMember(Name = "virtual", EmitDefaultValue = true)]
        public bool? Virtual
        {
            get { return _Virtual; }
            set
            {
                _Virtual = value;
                _flagVirtual = true;
            }
        }
        private bool? _Virtual;
        private bool _flagVirtual;

        /// <summary>
        /// Returns false as Virtual should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVirtual()
        {
            return _flagVirtual;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentAccount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Sia: ").Append(Sia).Append("\n");
            sb.Append("  Cuc: ").Append(Cuc).Append("\n");
            sb.Append("  Virtual: ").Append(Virtual).Append("\n");
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
            return this.Equals(input as PaymentAccount);
        }

        /// <summary>
        /// Returns true if PaymentAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAccount input)
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
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
                ) &&
                (
                    this.Sia == input.Sia ||
                    (this.Sia != null &&
                    this.Sia.Equals(input.Sia))
                ) &&
                (
                    this.Cuc == input.Cuc ||
                    (this.Cuc != null &&
                    this.Cuc.Equals(input.Cuc))
                ) &&
                (
                    this.Virtual == input.Virtual ||
                    (this.Virtual != null &&
                    this.Virtual.Equals(input.Virtual))
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
                if (this.Iban != null)
                {
                    hashCode = (hashCode * 59) + this.Iban.GetHashCode();
                }
                if (this.Sia != null)
                {
                    hashCode = (hashCode * 59) + this.Sia.GetHashCode();
                }
                if (this.Cuc != null)
                {
                    hashCode = (hashCode * 59) + this.Cuc.GetHashCode();
                }
                if (this.Virtual != null)
                {
                    hashCode = (hashCode * 59) + this.Virtual.GetHashCode();
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
