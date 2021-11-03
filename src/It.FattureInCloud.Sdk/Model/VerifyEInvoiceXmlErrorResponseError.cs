/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol. For more information, please visit https://www.fattureincloud.it.
 *
 * The version of the OpenAPI document: 2.0.2
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
    /// VerifyEInvoiceXmlErrorResponseError
    /// </summary>
    [DataContract(Name = "VerifyEInvoiceXmlErrorResponse_error")]
    public partial class VerifyEInvoiceXmlErrorResponseError : IEquatable<VerifyEInvoiceXmlErrorResponseError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyEInvoiceXmlErrorResponseError" /> class.
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="validationResult">validationResult.</param>
        public VerifyEInvoiceXmlErrorResponseError(string message = default(string), Object validationResult = default(Object))
        {
            this.Message = message;
            this.ValidationResult = validationResult;
        }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets ValidationResult
        /// </summary>
        [DataMember(Name = "validation_result", EmitDefaultValue = false)]
        public Object ValidationResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyEInvoiceXmlErrorResponseError {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ValidationResult: ").Append(ValidationResult).Append("\n");
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
            return this.Equals(input as VerifyEInvoiceXmlErrorResponseError);
        }

        /// <summary>
        /// Returns true if VerifyEInvoiceXmlErrorResponseError instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyEInvoiceXmlErrorResponseError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyEInvoiceXmlErrorResponseError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.ValidationResult == input.ValidationResult ||
                    (this.ValidationResult != null &&
                    this.ValidationResult.Equals(input.ValidationResult))
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.ValidationResult != null)
                    hashCode = hashCode * 59 + this.ValidationResult.GetHashCode();
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
