/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.3
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
    /// GetUserInfoResponse
    /// </summary>
    [DataContract(Name = "GetUserInfoResponse")]
    public partial class GetUserInfoResponse : IEquatable<GetUserInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserInfoResponse" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="info">info.</param>
        /// <param name="emailConfirmationState">emailConfirmationState.</param>
        public GetUserInfoResponse(User data = default(User), GetUserInfoResponseInfo info = default(GetUserInfoResponseInfo), GetUserInfoResponseEmailConfirmationState emailConfirmationState = default(GetUserInfoResponseEmailConfirmationState))
        {
            this.Data = data;
            this.Info = info;
            this.EmailConfirmationState = emailConfirmationState;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public User Data { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name = "info", EmitDefaultValue = false)]
        public GetUserInfoResponseInfo Info { get; set; }

        /// <summary>
        /// Gets or Sets EmailConfirmationState
        /// </summary>
        [DataMember(Name = "email_confirmation_state", EmitDefaultValue = false)]
        public GetUserInfoResponseEmailConfirmationState EmailConfirmationState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUserInfoResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  EmailConfirmationState: ").Append(EmailConfirmationState).Append("\n");
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
            return this.Equals(input as GetUserInfoResponse);
        }

        /// <summary>
        /// Returns true if GetUserInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUserInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUserInfoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
                ) && 
                (
                    this.EmailConfirmationState == input.EmailConfirmationState ||
                    (this.EmailConfirmationState != null &&
                    this.EmailConfirmationState.Equals(input.EmailConfirmationState))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Info != null)
                    hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.EmailConfirmationState != null)
                    hashCode = hashCode * 59 + this.EmailConfirmationState.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}