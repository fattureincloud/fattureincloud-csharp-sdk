/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.3
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
    /// CreateReceiptRequest
    /// </summary>
    [DataContract(Name = "CreateReceiptRequest")]
    public partial class CreateReceiptRequest : IEquatable<CreateReceiptRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReceiptRequest" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="autocompleteNumber">If true, the number is autocompleted progressively..</param>
        public CreateReceiptRequest(Receipt data = default(Receipt), bool autocompleteNumber = default(bool))
        {
            this.Data = data;
            this.AutocompleteNumber = autocompleteNumber;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Receipt Data { get; set; }

        /// <summary>
        /// If true, the number is autocompleted progressively.
        /// </summary>
        /// <value>If true, the number is autocompleted progressively.</value>
        [DataMember(Name = "autocomplete_number", EmitDefaultValue = true)]
        public bool AutocompleteNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateReceiptRequest {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  AutocompleteNumber: ").Append(AutocompleteNumber).Append("\n");
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
            return this.Equals(input as CreateReceiptRequest);
        }

        /// <summary>
        /// Returns true if CreateReceiptRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateReceiptRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateReceiptRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.AutocompleteNumber == input.AutocompleteNumber ||
                    this.AutocompleteNumber.Equals(input.AutocompleteNumber)
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                hashCode = hashCode * 59 + this.AutocompleteNumber.GetHashCode();
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
