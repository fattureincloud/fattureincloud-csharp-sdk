/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.16
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


namespace It.FattureInCloud.Sdk.Model
{
    /// <summary>
    ///     VerifyEInvoiceXmlErrorResponse
    /// </summary>
    [DataContract(Name = "VerifyEInvoiceXmlErrorResponse")]
    public class VerifyEInvoiceXmlErrorResponse : IEquatable<VerifyEInvoiceXmlErrorResponse>, IValidatableObject
    {
        private VerifyEInvoiceXmlErrorResponseError _Error;
        private VerifyEInvoiceXmlErrorResponseExtra _Extra;
        private bool _flagError;
        private bool _flagExtra;

        /// <summary>
        ///     Initializes a new instance of the <see cref="VerifyEInvoiceXmlErrorResponse" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="extra">extra.</param>
        public VerifyEInvoiceXmlErrorResponse(VerifyEInvoiceXmlErrorResponseError error = default,
            VerifyEInvoiceXmlErrorResponseExtra extra = default)
        {
            _Error = error;
            if (Error != null) _flagError = true;
            _Extra = extra;
            if (Extra != null) _flagExtra = true;
        }

        /// <summary>
        ///     Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public VerifyEInvoiceXmlErrorResponseError Error
        {
            get => _Error;
            set
            {
                _Error = value;
                _flagError = true;
            }
        }

        /// <summary>
        ///     Gets or Sets Extra
        /// </summary>
        [DataMember(Name = "extra", EmitDefaultValue = true)]
        public VerifyEInvoiceXmlErrorResponseExtra Extra
        {
            get => _Extra;
            set
            {
                _Extra = value;
                _flagExtra = true;
            }
        }

        /// <summary>
        ///     Returns false as Error should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeError()
        {
            return _flagError;
        }

        /// <summary>
        ///     Returns false as Extra should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExtra()
        {
            return _flagExtra;
        }

        /// <summary>
        ///     Returns the string presentation of the object
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
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as VerifyEInvoiceXmlErrorResponse);
        }

        /// <summary>
        ///     Returns true if VerifyEInvoiceXmlErrorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyEInvoiceXmlErrorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyEInvoiceXmlErrorResponse input)
        {
            if (input == null) return false;
            return
                (
                    Error == input.Error ||
                    (Error != null &&
                     Error.Equals(input.Error))
                ) &&
                (
                    Extra == input.Extra ||
                    (Extra != null &&
                     Extra.Equals(input.Extra))
                );
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Error != null) hashCode = hashCode * 59 + Error.GetHashCode();
                if (Extra != null) hashCode = hashCode * 59 + Extra.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}