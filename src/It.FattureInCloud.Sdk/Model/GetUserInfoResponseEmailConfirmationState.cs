/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.24
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
    /// GetUserInfoResponseEmailConfirmationState
    /// </summary>
    [DataContract(Name = "GetUserInfoResponse_email_confirmation_state")]
    public partial class GetUserInfoResponseEmailConfirmationState : IEquatable<GetUserInfoResponseEmailConfirmationState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserInfoResponseEmailConfirmationState" /> class.
        /// </summary>
        /// <param name="needConfirmation">needConfirmation.</param>
        public GetUserInfoResponseEmailConfirmationState(bool? needConfirmation = default(bool?))
        {
            this._NeedConfirmation = needConfirmation;
            if (this.NeedConfirmation != null)
            {
                this._flagNeedConfirmation = true;
            }
        }

        /// <summary>
        /// Gets or Sets NeedConfirmation
        /// </summary>
        [DataMember(Name = "need_confirmation", EmitDefaultValue = true)]
        public bool? NeedConfirmation
        {
            get { return _NeedConfirmation; }
            set
            {
                _NeedConfirmation = value;
                _flagNeedConfirmation = true;
            }
        }
        private bool? _NeedConfirmation;
        private bool _flagNeedConfirmation;

        /// <summary>
        /// Returns false as NeedConfirmation should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNeedConfirmation()
        {
            return _flagNeedConfirmation;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetUserInfoResponseEmailConfirmationState {\n");
            sb.Append("  NeedConfirmation: ").Append(NeedConfirmation).Append("\n");
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
            return this.Equals(input as GetUserInfoResponseEmailConfirmationState);
        }

        /// <summary>
        /// Returns true if GetUserInfoResponseEmailConfirmationState instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUserInfoResponseEmailConfirmationState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUserInfoResponseEmailConfirmationState input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.NeedConfirmation == input.NeedConfirmation ||
                    (this.NeedConfirmation != null &&
                    this.NeedConfirmation.Equals(input.NeedConfirmation))
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
                if (this.NeedConfirmation != null)
                {
                    hashCode = (hashCode * 59) + this.NeedConfirmation.GetHashCode();
                }
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
