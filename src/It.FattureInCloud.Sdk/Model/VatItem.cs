/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.14
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
    /// VatItem
    /// </summary>
    [DataContract(Name = "VatItem")]
    public partial class VatItem : IEquatable<VatItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VatItem" /> class.
        /// </summary>
        /// <param name="amountNet">amountNet.</param>
        /// <param name="amountVat">amountVat.</param>
        public VatItem(decimal? amountNet = default(decimal?), decimal? amountVat = default(decimal?))
        {
            this._AmountNet = amountNet;
            if (this.AmountNet != null) this._flagAmountNet = true;
            this._AmountVat = amountVat;
            if (this.AmountVat != null) this._flagAmountVat = true;
        }

        /// <summary>
        /// Gets or Sets AmountNet
        /// </summary>
        [DataMember(Name = "amount_net", EmitDefaultValue = true)]
        public decimal? AmountNet
        {
            get{ return _AmountNet;}
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
        /// Gets or Sets AmountVat
        /// </summary>
        [DataMember(Name = "amount_vat", EmitDefaultValue = true)]
        public decimal? AmountVat
        {
            get{ return _AmountVat;}
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VatItem {\n");
            sb.Append("  AmountNet: ").Append(AmountNet).Append("\n");
            sb.Append("  AmountVat: ").Append(AmountVat).Append("\n");
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
            return this.Equals(input as VatItem);
        }

        /// <summary>
        /// Returns true if VatItem instances are equal
        /// </summary>
        /// <param name="input">Instance of VatItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VatItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AmountNet == input.AmountNet ||
                    (this.AmountNet != null &&
                    this.AmountNet.Equals(input.AmountNet))
                ) && 
                (
                    this.AmountVat == input.AmountVat ||
                    (this.AmountVat != null &&
                    this.AmountVat.Equals(input.AmountVat))
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
                if (this.AmountNet != null)
                {
                    hashCode = (hashCode * 59) + this.AmountNet.GetHashCode();
                }
                if (this.AmountVat != null)
                {
                    hashCode = (hashCode * 59) + this.AmountVat.GetHashCode();
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
