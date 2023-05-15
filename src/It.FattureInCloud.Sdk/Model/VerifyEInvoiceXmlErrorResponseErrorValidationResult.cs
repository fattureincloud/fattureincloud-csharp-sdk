/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.28
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
    /// VerifyEInvoiceXmlErrorResponseErrorValidationResult
    /// </summary>
    [DataContract(Name = "VerifyEInvoiceXmlErrorResponse_error_validation_result")]
    public partial class VerifyEInvoiceXmlErrorResponseErrorValidationResult : IEquatable<VerifyEInvoiceXmlErrorResponseErrorValidationResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyEInvoiceXmlErrorResponseErrorValidationResult" /> class.
        /// </summary>
        /// <param name="xmlErrors">xmlErrors.</param>
        public VerifyEInvoiceXmlErrorResponseErrorValidationResult(List<string> xmlErrors = default(List<string>))
        {
            this._XmlErrors = xmlErrors;
            if (this.XmlErrors != null)
            {
                this._flagXmlErrors = true;
            }
        }

        /// <summary>
        /// Gets or Sets XmlErrors
        /// </summary>
        [DataMember(Name = "xml_errors", EmitDefaultValue = true)]
        public List<string> XmlErrors
        {
            get { return _XmlErrors; }
            set
            {
                _XmlErrors = value;
                _flagXmlErrors = true;
            }
        }
        private List<string> _XmlErrors;
        private bool _flagXmlErrors;

        /// <summary>
        /// Returns false as XmlErrors should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeXmlErrors()
        {
            return _flagXmlErrors;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VerifyEInvoiceXmlErrorResponseErrorValidationResult {\n");
            sb.Append("  XmlErrors: ").Append(XmlErrors).Append("\n");
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
            return this.Equals(input as VerifyEInvoiceXmlErrorResponseErrorValidationResult);
        }

        /// <summary>
        /// Returns true if VerifyEInvoiceXmlErrorResponseErrorValidationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyEInvoiceXmlErrorResponseErrorValidationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyEInvoiceXmlErrorResponseErrorValidationResult input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.XmlErrors == input.XmlErrors ||
                    this.XmlErrors != null &&
                    input.XmlErrors != null &&
                    this.XmlErrors.SequenceEqual(input.XmlErrors)
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
                if (this.XmlErrors != null)
                {
                    hashCode = (hashCode * 59) + this.XmlErrors.GetHashCode();
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
