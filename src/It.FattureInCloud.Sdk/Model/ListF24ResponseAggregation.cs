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
    /// ListF24ResponseAggregation
    /// </summary>
    [DataContract(Name = "ListF24ResponseAggregation")]
    public partial class ListF24ResponseAggregation : IEquatable<ListF24ResponseAggregation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListF24ResponseAggregation" /> class.
        /// </summary>
        /// <param name="aggregatedData">aggregatedData.</param>
        public ListF24ResponseAggregation(ListF24ResponseAggregatedData aggregatedData = default(ListF24ResponseAggregatedData))
        {
            this._AggregatedData = aggregatedData;
            if (this.AggregatedData != null)
            {
                this._flagAggregatedData = true;
            }
        }

        /// <summary>
        /// Gets or Sets AggregatedData
        /// </summary>
        [DataMember(Name = "aggregated_data", EmitDefaultValue = false)]
        public ListF24ResponseAggregatedData AggregatedData
        {
            get { return _AggregatedData; }
            set
            {
                _AggregatedData = value;
                _flagAggregatedData = true;
            }
        }
        private ListF24ResponseAggregatedData _AggregatedData;
        private bool _flagAggregatedData;

        /// <summary>
        /// Returns false as AggregatedData should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAggregatedData()
        {
            return _flagAggregatedData;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListF24ResponseAggregation {\n");
            sb.Append("  AggregatedData: ").Append(AggregatedData).Append("\n");
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
            return this.Equals(input as ListF24ResponseAggregation);
        }

        /// <summary>
        /// Returns true if ListF24ResponseAggregation instances are equal
        /// </summary>
        /// <param name="input">Instance of ListF24ResponseAggregation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListF24ResponseAggregation input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AggregatedData == input.AggregatedData ||
                    (this.AggregatedData != null &&
                    this.AggregatedData.Equals(input.AggregatedData))
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
                if (this.AggregatedData != null)
                {
                    hashCode = (hashCode * 59) + this.AggregatedData.GetHashCode();
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
