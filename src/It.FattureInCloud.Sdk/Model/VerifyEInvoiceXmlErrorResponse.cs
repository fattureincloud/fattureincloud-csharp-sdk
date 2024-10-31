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
    /// VerifyEInvoiceXmlErrorResponse
    /// </summary>
    [DataContract(Name = "VerifyEInvoiceXmlErrorResponse")]
    public partial class VerifyEInvoiceXmlErrorResponse : IEquatable<VerifyEInvoiceXmlErrorResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyEInvoiceXmlErrorResponse" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="extra">extra.</param>
        public VerifyEInvoiceXmlErrorResponse(VerifyEInvoiceXmlErrorResponseError error = default(VerifyEInvoiceXmlErrorResponseError), VerifyEInvoiceXmlErrorResponseExtra extra = default(VerifyEInvoiceXmlErrorResponseExtra))
        {
            this._Error = error;
            if (this.Error != null)
            {
                this._flagError = true;
            }
            this._Extra = extra;
            if (this.Extra != null)
            {
                this._flagExtra = true;
            }
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public VerifyEInvoiceXmlErrorResponseError Error
        {
            get { return _Error; }
            set
            {
                _Error = value;
                _flagError = true;
            }
        }
        private VerifyEInvoiceXmlErrorResponseError _Error;
        private bool _flagError;

        /// <summary>
        /// Returns false as Error should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeError()
        {
            return _flagError;
        }
        /// <summary>
        /// Gets or Sets Extra
        /// </summary>
        [DataMember(Name = "extra", EmitDefaultValue = true)]
        public VerifyEInvoiceXmlErrorResponseExtra Extra
        {
            get { return _Extra; }
            set
            {
                _Extra = value;
                _flagExtra = true;
            }
        }
        private VerifyEInvoiceXmlErrorResponseExtra _Extra;
        private bool _flagExtra;

        /// <summary>
        /// Returns false as Extra should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExtra()
        {
            return _flagExtra;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VerifyEInvoiceXmlErrorResponse {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Extra: ").Append(Extra).Append("\n");
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
            return this.Equals(input as VerifyEInvoiceXmlErrorResponse);
        }

        /// <summary>
        /// Returns true if VerifyEInvoiceXmlErrorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyEInvoiceXmlErrorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyEInvoiceXmlErrorResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) &&
                (
                    this.Extra == input.Extra ||
                    (this.Extra != null &&
                    this.Extra.Equals(input.Extra))
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
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                if (this.Extra != null)
                {
                    hashCode = (hashCode * 59) + this.Extra.GetHashCode();
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
