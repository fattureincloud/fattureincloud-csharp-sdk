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
    ///     VerifyEInvoiceXmlResponseData
    /// </summary>
    [DataContract(Name = "VerifyEInvoiceXmlResponse_data")]
    public class VerifyEInvoiceXmlResponseData : IEquatable<VerifyEInvoiceXmlResponseData>, IValidatableObject
    {
        private bool _flagSuccess;
        private bool? _Success;

        /// <summary>
        ///     Initializes a new instance of the <see cref="VerifyEInvoiceXmlResponseData" /> class.
        /// </summary>
        /// <param name="success">Determine if the invoice XML is valid..</param>
        public VerifyEInvoiceXmlResponseData(bool? success = default(bool?))
        {
            _Success = success;
            if (Success != null) _flagSuccess = true;
        }

        /// <summary>
        ///     Determine if the invoice XML is valid.
        /// </summary>
        /// <value>Determine if the invoice XML is valid.</value>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool? Success
        {
            get => _Success;
            set
            {
                _Success = value;
                _flagSuccess = true;
            }
        }

        /// <summary>
        ///     Returns false as Success should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSuccess()
        {
            return _flagSuccess;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VerifyEInvoiceXmlResponseData {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
            return Equals(input as VerifyEInvoiceXmlResponseData);
        }

        /// <summary>
        ///     Returns true if VerifyEInvoiceXmlResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyEInvoiceXmlResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyEInvoiceXmlResponseData input)
        {
            if (input == null) return false;
            return
                Success == input.Success ||
                (Success != null &&
                 Success.Equals(input.Success));
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
                if (Success != null) hashCode = hashCode * 59 + Success.GetHashCode();
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