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
    /// MonthlyTotal
    /// </summary>
    [DataContract(Name = "MonthlyTotal")]
    public partial class MonthlyTotal : IEquatable<MonthlyTotal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyTotal" /> class.
        /// </summary>
        /// <param name="net">Monthly total net amount..</param>
        /// <param name="gross">Monthly total gross amount..</param>
        /// <param name="count">Monthly total receipt number..</param>
        public MonthlyTotal(decimal? net = default(decimal?), decimal? gross = default(decimal?), decimal? count = default(decimal?))
        {
            this._Net = net;
            this._Gross = gross;
            this._Count = count;
        }

        /// <summary>
        /// Monthly total net amount.
        /// </summary>
        /// <value>Monthly total net amount.</value>
        [DataMember(Name = "net", EmitDefaultValue = true)]
        public decimal? Net
        {
            get{ return _Net;}
            set
            {
                _Net = value;
                _flagNet = true;
            }
        }
        private decimal? _Net;
        private bool _flagNet;

        /// <summary>
        /// Returns false as Net should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNet()
        {
            return _flagNet;
        }
        /// <summary>
        /// Monthly total gross amount.
        /// </summary>
        /// <value>Monthly total gross amount.</value>
        [DataMember(Name = "gross", EmitDefaultValue = true)]
        public decimal? Gross
        {
            get{ return _Gross;}
            set
            {
                _Gross = value;
                _flagGross = true;
            }
        }
        private decimal? _Gross;
        private bool _flagGross;

        /// <summary>
        /// Returns false as Gross should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGross()
        {
            return _flagGross;
        }
        /// <summary>
        /// Monthly total receipt number.
        /// </summary>
        /// <value>Monthly total receipt number.</value>
        [DataMember(Name = "count", EmitDefaultValue = true)]
        public decimal? Count
        {
            get{ return _Count;}
            set
            {
                _Count = value;
                _flagCount = true;
            }
        }
        private decimal? _Count;
        private bool _flagCount;

        /// <summary>
        /// Returns false as Count should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCount()
        {
            return _flagCount;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MonthlyTotal {\n");
            sb.Append("  Net: ").Append(Net).Append("\n");
            sb.Append("  Gross: ").Append(Gross).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as MonthlyTotal);
        }

        /// <summary>
        /// Returns true if MonthlyTotal instances are equal
        /// </summary>
        /// <param name="input">Instance of MonthlyTotal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonthlyTotal input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Net == input.Net ||
                    (this.Net != null &&
                    this.Net.Equals(input.Net))
                ) && 
                (
                    this.Gross == input.Gross ||
                    (this.Gross != null &&
                    this.Gross.Equals(input.Gross))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.Net != null)
                {
                    hashCode = (hashCode * 59) + this.Net.GetHashCode();
                }
                if (this.Gross != null)
                {
                    hashCode = (hashCode * 59) + this.Gross.GetHashCode();
                }
                if (this.Count != null)
                {
                    hashCode = (hashCode * 59) + this.Count.GetHashCode();
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
