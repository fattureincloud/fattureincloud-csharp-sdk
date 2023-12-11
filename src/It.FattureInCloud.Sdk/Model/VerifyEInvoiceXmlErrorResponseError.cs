/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.31
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
        public VerifyEInvoiceXmlErrorResponseError(string message = default(string), VerifyEInvoiceXmlErrorResponseErrorValidationResult validationResult = default(VerifyEInvoiceXmlErrorResponseErrorValidationResult))
        {
            this._Message = message;
            if (this.Message != null)
            {
                this._flagMessage = true;
            }
            this._ValidationResult = validationResult;
            if (this.ValidationResult != null)
            {
                this._flagValidationResult = true;
            }
        }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message
        {
            get { return _Message; }
            set
            {
                _Message = value;
                _flagMessage = true;
            }
        }
        private string _Message;
        private bool _flagMessage;

        /// <summary>
        /// Returns false as Message should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMessage()
        {
            return _flagMessage;
        }
        /// <summary>
        /// Gets or Sets ValidationResult
        /// </summary>
        [DataMember(Name = "validation_result", EmitDefaultValue = true)]
        public VerifyEInvoiceXmlErrorResponseErrorValidationResult ValidationResult
        {
            get { return _ValidationResult; }
            set
            {
                _ValidationResult = value;
                _flagValidationResult = true;
            }
        }
        private VerifyEInvoiceXmlErrorResponseErrorValidationResult _ValidationResult;
        private bool _flagValidationResult;

        /// <summary>
        /// Returns false as ValidationResult should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValidationResult()
        {
            return _flagValidationResult;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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
            {
                return false;
            }
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
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.ValidationResult != null)
                {
                    hashCode = (hashCode * 59) + this.ValidationResult.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
