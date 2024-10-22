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
    /// ListF24ResponseAggregatedData
    /// </summary>
    [DataContract(Name = "ListF24ResponseAggregatedData")]
    public partial class ListF24ResponseAggregatedData : IEquatable<ListF24ResponseAggregatedData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListF24ResponseAggregatedData" /> class.
        /// </summary>
        /// <param name="amount">Total amount..</param>
        public ListF24ResponseAggregatedData(decimal? amount = default(decimal?))
        {
            this._Amount = amount;
            if (this.Amount != null)
            {
                this._flagAmount = true;
            }
        }

        /// <summary>
        /// Total amount.
        /// </summary>
        /// <value>Total amount.</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListF24ResponseAggregatedData {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as ListF24ResponseAggregatedData);
        }

        /// <summary>
        /// Returns true if ListF24ResponseAggregatedData instances are equal
        /// </summary>
        /// <param name="input">Instance of ListF24ResponseAggregatedData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListF24ResponseAggregatedData input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
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
