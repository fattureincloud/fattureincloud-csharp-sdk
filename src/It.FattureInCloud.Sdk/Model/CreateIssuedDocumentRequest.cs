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
    ///     CreateIssuedDocumentRequest
    /// </summary>
    [DataContract(Name = "CreateIssuedDocumentRequest")]
    public class CreateIssuedDocumentRequest : IEquatable<CreateIssuedDocumentRequest>, IValidatableObject
    {
        private IssuedDocument _Data;
        private bool _flagData;
        private bool _flagOptions;
        private IssuedDocumentOptions _Options;

        /// <summary>
        ///     Initializes a new instance of the <see cref="CreateIssuedDocumentRequest" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="options">options.</param>
        public CreateIssuedDocumentRequest(IssuedDocument data = default, IssuedDocumentOptions options = default)
        {
            _Data = data;
            if (Data != null) _flagData = true;
            _Options = options;
            if (Options != null) _flagOptions = true;
        }

        /// <summary>
        ///     Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public IssuedDocument Data
        {
            get => _Data;
            set
            {
                _Data = value;
                _flagData = true;
            }
        }

        /// <summary>
        ///     Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public IssuedDocumentOptions Options
        {
            get => _Options;
            set
            {
                _Options = value;
                _flagOptions = true;
            }
        }

        /// <summary>
        ///     Returns false as Data should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeData()
        {
            return _flagData;
        }

        /// <summary>
        ///     Returns false as Options should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOptions()
        {
            return _flagOptions;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateIssuedDocumentRequest {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return Equals(input as CreateIssuedDocumentRequest);
        }

        /// <summary>
        ///     Returns true if CreateIssuedDocumentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateIssuedDocumentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateIssuedDocumentRequest input)
        {
            if (input == null) return false;
            return
                (
                    Data == input.Data ||
                    (Data != null &&
                     Data.Equals(input.Data))
                ) &&
                (
                    Options == input.Options ||
                    (Options != null &&
                     Options.Equals(input.Options))
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
                if (Data != null) hashCode = hashCode * 59 + Data.GetHashCode();
                if (Options != null) hashCode = hashCode * 59 + Options.GetHashCode();
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