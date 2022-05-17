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
    ///     GetUserInfoResponse
    /// </summary>
    [DataContract(Name = "GetUserInfoResponse")]
    public class GetUserInfoResponse : IEquatable<GetUserInfoResponse>, IValidatableObject
    {
        private User _Data;
        private GetUserInfoResponseEmailConfirmationState _EmailConfirmationState;
        private bool _flagData;
        private bool _flagEmailConfirmationState;
        private bool _flagInfo;
        private GetUserInfoResponseInfo _Info;

        /// <summary>
        ///     Initializes a new instance of the <see cref="GetUserInfoResponse" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="info">info.</param>
        /// <param name="emailConfirmationState">emailConfirmationState.</param>
        public GetUserInfoResponse(User data = default, GetUserInfoResponseInfo info = default,
            GetUserInfoResponseEmailConfirmationState emailConfirmationState = default)
        {
            _Data = data;
            if (Data != null) _flagData = true;
            _Info = info;
            if (Info != null) _flagInfo = true;
            _EmailConfirmationState = emailConfirmationState;
            if (EmailConfirmationState != null) _flagEmailConfirmationState = true;
        }

        /// <summary>
        ///     Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public User Data
        {
            get => _Data;
            set
            {
                _Data = value;
                _flagData = true;
            }
        }

        /// <summary>
        ///     Gets or Sets Info
        /// </summary>
        [DataMember(Name = "info", EmitDefaultValue = true)]
        public GetUserInfoResponseInfo Info
        {
            get => _Info;
            set
            {
                _Info = value;
                _flagInfo = true;
            }
        }

        /// <summary>
        ///     Gets or Sets EmailConfirmationState
        /// </summary>
        [DataMember(Name = "email_confirmation_state", EmitDefaultValue = true)]
        public GetUserInfoResponseEmailConfirmationState EmailConfirmationState
        {
            get => _EmailConfirmationState;
            set
            {
                _EmailConfirmationState = value;
                _flagEmailConfirmationState = true;
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
        ///     Returns false as Info should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInfo()
        {
            return _flagInfo;
        }

        /// <summary>
        ///     Returns false as EmailConfirmationState should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmailConfirmationState()
        {
            return _flagEmailConfirmationState;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetUserInfoResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  EmailConfirmationState: ").Append(EmailConfirmationState).Append("\n");
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
            return Equals(input as GetUserInfoResponse);
        }

        /// <summary>
        ///     Returns true if GetUserInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUserInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUserInfoResponse input)
        {
            if (input == null) return false;
            return
                (
                    Data == input.Data ||
                    (Data != null &&
                     Data.Equals(input.Data))
                ) &&
                (
                    Info == input.Info ||
                    (Info != null &&
                     Info.Equals(input.Info))
                ) &&
                (
                    EmailConfirmationState == input.EmailConfirmationState ||
                    (EmailConfirmationState != null &&
                     EmailConfirmationState.Equals(input.EmailConfirmationState))
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
                if (Info != null) hashCode = hashCode * 59 + Info.GetHashCode();
                if (EmailConfirmationState != null) hashCode = hashCode * 59 + EmailConfirmationState.GetHashCode();
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