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
    ///     DocumentTemplate
    /// </summary>
    [DataContract(Name = "DocumentTemplate")]
    public class DocumentTemplate : IEquatable<DocumentTemplate>, IValidatableObject
    {
        private bool _flagId;
        private bool _flagName;
        private bool _flagType;
        private int? _Id;
        private string _Name;
        private string _Type;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DocumentTemplate" /> class.
        /// </summary>
        /// <param name="id">Unique identifier..</param>
        /// <param name="name">Template name..</param>
        /// <param name="type">Template type..</param>
        public DocumentTemplate(int? id = default(int?), string name = default(string), string type = default(string))
        {
            _Id = id;
            if (Id != null) _flagId = true;
            _Name = name;
            if (Name != null) _flagName = true;
            _Type = type;
            if (Type != null) _flagType = true;
        }

        /// <summary>
        ///     Unique identifier.
        /// </summary>
        /// <value>Unique identifier.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id
        {
            get => _Id;
            set
            {
                _Id = value;
                _flagId = true;
            }
        }

        /// <summary>
        ///     Template name.
        /// </summary>
        /// <value>Template name.</value>
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
        ///     Template type.
        /// </summary>
        /// <value>Template type.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type
        {
            get => _Type;
            set
            {
                _Type = value;
                _flagType = true;
            }
        }

        /// <summary>
        ///     Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return _flagId;
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
        ///     Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return _flagType;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentTemplate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return Equals(input as DocumentTemplate);
        }

        /// <summary>
        ///     Returns true if DocumentTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentTemplate input)
        {
            if (input == null) return false;
            return
                (
                    Id == input.Id ||
                    (Id != null &&
                     Id.Equals(input.Id))
                ) &&
                (
                    Name == input.Name ||
                    (Name != null &&
                     Name.Equals(input.Name))
                ) &&
                (
                    Type == input.Type ||
                    (Type != null &&
                     Type.Equals(input.Type))
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
                if (Id != null) hashCode = hashCode * 59 + Id.GetHashCode();
                if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
                if (Type != null) hashCode = hashCode * 59 + Type.GetHashCode();
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