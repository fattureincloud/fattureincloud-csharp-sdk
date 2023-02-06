/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.25
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
    /// GetUserInfoResponseInfo
    /// </summary>
    [DataContract(Name = "GetUserInfoResponse_info")]
    public partial class GetUserInfoResponseInfo : IEquatable<GetUserInfoResponseInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserInfoResponseInfo" /> class.
        /// </summary>
        /// <param name="needMarketingConsentsConfirmation">needMarketingConsentsConfirmation.</param>
        /// <param name="needPasswordChange">needPasswordChange.</param>
        /// <param name="needTermsOfServiceConfirmation">needTermsOfServiceConfirmation.</param>
        public GetUserInfoResponseInfo(bool? needMarketingConsentsConfirmation = default(bool?), bool? needPasswordChange = default(bool?), bool? needTermsOfServiceConfirmation = default(bool?))
        {
            this._NeedMarketingConsentsConfirmation = needMarketingConsentsConfirmation;
            if (this.NeedMarketingConsentsConfirmation != null)
            {
                this._flagNeedMarketingConsentsConfirmation = true;
            }
            this._NeedPasswordChange = needPasswordChange;
            if (this.NeedPasswordChange != null)
            {
                this._flagNeedPasswordChange = true;
            }
            this._NeedTermsOfServiceConfirmation = needTermsOfServiceConfirmation;
            if (this.NeedTermsOfServiceConfirmation != null)
            {
                this._flagNeedTermsOfServiceConfirmation = true;
            }
        }

        /// <summary>
        /// Gets or Sets NeedMarketingConsentsConfirmation
        /// </summary>
        [DataMember(Name = "need_marketing_consents_confirmation", EmitDefaultValue = true)]
        public bool? NeedMarketingConsentsConfirmation
        {
            get { return _NeedMarketingConsentsConfirmation; }
            set
            {
                _NeedMarketingConsentsConfirmation = value;
                _flagNeedMarketingConsentsConfirmation = true;
            }
        }
        private bool? _NeedMarketingConsentsConfirmation;
        private bool _flagNeedMarketingConsentsConfirmation;

        /// <summary>
        /// Returns false as NeedMarketingConsentsConfirmation should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNeedMarketingConsentsConfirmation()
        {
            return _flagNeedMarketingConsentsConfirmation;
        }
        /// <summary>
        /// Gets or Sets NeedPasswordChange
        /// </summary>
        [DataMember(Name = "need_password_change", EmitDefaultValue = true)]
        public bool? NeedPasswordChange
        {
            get { return _NeedPasswordChange; }
            set
            {
                _NeedPasswordChange = value;
                _flagNeedPasswordChange = true;
            }
        }
        private bool? _NeedPasswordChange;
        private bool _flagNeedPasswordChange;

        /// <summary>
        /// Returns false as NeedPasswordChange should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNeedPasswordChange()
        {
            return _flagNeedPasswordChange;
        }
        /// <summary>
        /// Gets or Sets NeedTermsOfServiceConfirmation
        /// </summary>
        [DataMember(Name = "need_terms_of_service_confirmation", EmitDefaultValue = true)]
        public bool? NeedTermsOfServiceConfirmation
        {
            get { return _NeedTermsOfServiceConfirmation; }
            set
            {
                _NeedTermsOfServiceConfirmation = value;
                _flagNeedTermsOfServiceConfirmation = true;
            }
        }
        private bool? _NeedTermsOfServiceConfirmation;
        private bool _flagNeedTermsOfServiceConfirmation;

        /// <summary>
        /// Returns false as NeedTermsOfServiceConfirmation should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNeedTermsOfServiceConfirmation()
        {
            return _flagNeedTermsOfServiceConfirmation;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetUserInfoResponseInfo {\n");
            sb.Append("  NeedMarketingConsentsConfirmation: ").Append(NeedMarketingConsentsConfirmation).Append("\n");
            sb.Append("  NeedPasswordChange: ").Append(NeedPasswordChange).Append("\n");
            sb.Append("  NeedTermsOfServiceConfirmation: ").Append(NeedTermsOfServiceConfirmation).Append("\n");
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
            return this.Equals(input as GetUserInfoResponseInfo);
        }

        /// <summary>
        /// Returns true if GetUserInfoResponseInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUserInfoResponseInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUserInfoResponseInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.NeedMarketingConsentsConfirmation == input.NeedMarketingConsentsConfirmation ||
                    (this.NeedMarketingConsentsConfirmation != null &&
                    this.NeedMarketingConsentsConfirmation.Equals(input.NeedMarketingConsentsConfirmation))
                ) &&
                (
                    this.NeedPasswordChange == input.NeedPasswordChange ||
                    (this.NeedPasswordChange != null &&
                    this.NeedPasswordChange.Equals(input.NeedPasswordChange))
                ) &&
                (
                    this.NeedTermsOfServiceConfirmation == input.NeedTermsOfServiceConfirmation ||
                    (this.NeedTermsOfServiceConfirmation != null &&
                    this.NeedTermsOfServiceConfirmation.Equals(input.NeedTermsOfServiceConfirmation))
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
                if (this.NeedMarketingConsentsConfirmation != null)
                {
                    hashCode = (hashCode * 59) + this.NeedMarketingConsentsConfirmation.GetHashCode();
                }
                if (this.NeedPasswordChange != null)
                {
                    hashCode = (hashCode * 59) + this.NeedPasswordChange.GetHashCode();
                }
                if (this.NeedTermsOfServiceConfirmation != null)
                {
                    hashCode = (hashCode * 59) + this.NeedTermsOfServiceConfirmation.GetHashCode();
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
