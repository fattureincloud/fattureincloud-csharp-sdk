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
    /// Default values for the document items.
    /// </summary>
    [DataContract(Name = "IssuedDocumentPreCreateInfo_items_default_values")]
    public partial class IssuedDocumentPreCreateInfoItemsDefaultValues : IEquatable<IssuedDocumentPreCreateInfoItemsDefaultValues>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedDocumentPreCreateInfoItemsDefaultValues" /> class.
        /// </summary>
        /// <param name="vat">vat.</param>
        public IssuedDocumentPreCreateInfoItemsDefaultValues(VatType vat = default(VatType))
        {
            this._Vat = vat;
            if (this.Vat != null) this._flagVat = true;
        }

        /// <summary>
        /// Gets or Sets Vat
        /// </summary>
        [DataMember(Name = "vat", EmitDefaultValue = true)]
        public VatType Vat
        {
            get{ return _Vat;}
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
            sb.Append("class IssuedDocumentPreCreateInfoItemsDefaultValues {\n");
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
            return this.Equals(input as IssuedDocumentPreCreateInfoItemsDefaultValues);
        }

        /// <summary>
        /// Returns true if IssuedDocumentPreCreateInfoItemsDefaultValues instances are equal
        /// </summary>
        /// <param name="input">Instance of IssuedDocumentPreCreateInfoItemsDefaultValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuedDocumentPreCreateInfoItemsDefaultValues input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
