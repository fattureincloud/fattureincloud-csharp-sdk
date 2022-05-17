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
    ///     Language
    /// </summary>
    [DataContract(Name = "Language")]
    public class Language : IEquatable<Language>, IValidatableObject
    {
        private string _Code;
        private bool _flagCode;
        private bool _flagName;
        private string _Name;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Language" /> class.
        /// </summary>
        /// <param name="code">Language code..</param>
        /// <param name="name">Language extended name..</param>
        public Language(string code = default(string), string name = default(string))
        {
            _Code = code;
            if (Code != null) _flagCode = true;
            _Name = name;
            if (Name != null) _flagName = true;
        }

        /// <summary>
        ///     Language code.
        /// </summary>
        /// <value>Language code.</value>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code
        {
            get => _Code;
            set
            {
                _Code = value;
                _flagCode = true;
            }
        }

        /// <summary>
        ///     Language extended name.
        /// </summary>
        /// <value>Language extended name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                _flagName = true;
            }
        }

        /// <summary>
        ///     Returns false as Code should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCode()
        {
            return _flagCode;
        }

        /// <summary>
        ///     Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return _flagName;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Language {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return Equals(input as Language);
        }

        /// <summary>
        ///     Returns true if Language instances are equal
        /// </summary>
        /// <param name="input">Instance of Language to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Language input)
        {
            if (input == null) return false;
            return
                (
                    Code == input.Code ||
                    (Code != null &&
                     Code.Equals(input.Code))
                ) &&
                (
                    Name == input.Name ||
                    (Name != null &&
                     Name.Equals(input.Name))
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
                if (Code != null) hashCode = hashCode * 59 + Code.GetHashCode();
                if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
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