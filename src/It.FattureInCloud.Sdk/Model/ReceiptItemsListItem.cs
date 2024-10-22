/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.1.2
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
    /// ReceiptItemsListItem
    /// </summary>
    [DataContract(Name = "ReceiptItemsListItem")]
    public partial class ReceiptItemsListItem : IEquatable<ReceiptItemsListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptItemsListItem" /> class.
        /// </summary>
        /// <param name="id">Receipt item id.</param>
        /// <param name="amountNet">Receipt item total net amount.</param>
        /// <param name="amountGross">Receipt item total gross amount.</param>
        /// <param name="category">Receipt item category.</param>
        /// <param name="vat">vat.</param>
        public ReceiptItemsListItem(int? id = default(int?), decimal? amountNet = default(decimal?), decimal? amountGross = default(decimal?), string category = default(string), VatType vat = default(VatType))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._AmountNet = amountNet;
            if (this.AmountNet != null)
            {
                this._flagAmountNet = true;
            }
            this._AmountGross = amountGross;
            if (this.AmountGross != null)
            {
                this._flagAmountGross = true;
            }
            this._Category = category;
            if (this.Category != null)
            {
                this._flagCategory = true;
            }
            this._Vat = vat;
            if (this.Vat != null)
            {
                this._flagVat = true;
            }
        }

        /// <summary>
        /// Receipt item id
        /// </summary>
        /// <value>Receipt item id</value>
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
        /// Receipt item total net amount
        /// </summary>
        /// <value>Receipt item total net amount</value>
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
        /// Receipt item total gross amount
        /// </summary>
        /// <value>Receipt item total gross amount</value>
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
        /// Receipt item category
        /// </summary>
        /// <value>Receipt item category</value>
        [DataMember(Name = "category", EmitDefaultValue = true)]
        public string Category
        {
            get { return _Category; }
            set
            {
                _Category = value;
                _flagCategory = true;
            }
        }
        private string _Category;
        private bool _flagCategory;

        /// <summary>
        /// Returns false as Category should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCategory()
        {
            return _flagCategory;
        }
        /// <summary>
        /// Gets or Sets Vat
        /// </summary>
        [DataMember(Name = "vat", EmitDefaultValue = true)]
        public VatType Vat
        {
            get { return _Vat; }
            set
            {
                _Vat = value;
                _flagVat = true;
            }
        }
        private VatType _Vat;
        private bool _flagVat;

        /// <summary>
        /// Returns false as Vat should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVat()
        {
            return _flagVat;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReceiptItemsListItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AmountNet: ").Append(AmountNet).Append("\n");
            sb.Append("  AmountGross: ").Append(AmountGross).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
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
            return this.Equals(input as ReceiptItemsListItem);
        }

        /// <summary>
        /// Returns true if ReceiptItemsListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ReceiptItemsListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceiptItemsListItem input)
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
                    this.AmountNet == input.AmountNet ||
                    (this.AmountNet != null &&
                    this.AmountNet.Equals(input.AmountNet))
                ) &&
                (
                    this.AmountGross == input.AmountGross ||
                    (this.AmountGross != null &&
                    this.AmountGross.Equals(input.AmountGross))
                ) &&
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) &&
                (
                    this.Vat == input.Vat ||
                    (this.Vat != null &&
                    this.Vat.Equals(input.Vat))
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
                if (this.AmountNet != null)
                {
                    hashCode = (hashCode * 59) + this.AmountNet.GetHashCode();
                }
                if (this.AmountGross != null)
                {
                    hashCode = (hashCode * 59) + this.AmountGross.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.Vat != null)
                {
                    hashCode = (hashCode * 59) + this.Vat.GetHashCode();
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
