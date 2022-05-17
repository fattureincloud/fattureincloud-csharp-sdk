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
    ///     ModifyClientResponse
    /// </summary>
    [DataContract(Name = "ModifyClientResponse")]
    public class ModifyClientResponse : IEquatable<ModifyClientResponse>, IValidatableObject
    {
        private ModelClient _Data;
        private bool _flagData;

        /// <summary>
        ///     Initializes a new instance of the <see cref="ModifyClientResponse" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        public ModifyClientResponse(ModelClient data = default)
        {
            _Data = data;
            if (Data != null) _flagData = true;
        }

        /// <summary>
        ///     Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public ModelClient Data
        {
            get => _Data;
            set
            {
                _Data = value;
                _flagData = true;
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
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModifyClientResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return Equals(input as ModifyClientResponse);
        }

        /// <summary>
        ///     Returns true if ModifyClientResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifyClientResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyClientResponse input)
        {
            if (input == null) return false;
            return
                Data == input.Data ||
                (Data != null &&
                 Data.Equals(input.Data));
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