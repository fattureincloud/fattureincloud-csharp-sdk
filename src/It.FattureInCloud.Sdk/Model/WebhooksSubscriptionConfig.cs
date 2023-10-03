/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.30
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
    /// WebhooksSubscriptionConfig
    /// </summary>
    [DataContract(Name = "WebhooksSubscriptionConfig")]
    public partial class WebhooksSubscriptionConfig : IEquatable<WebhooksSubscriptionConfig>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Mapping
        /// </summary>

        [DataMember(Name = "mapping", EmitDefaultValue = false)]
        public WebhooksSubscriptionMapping? Mapping
        {
            get { return _Mapping; }
            set
            {
                _Mapping = value;
                _flagMapping = true;
            }
        }
        private WebhooksSubscriptionMapping? _Mapping;
        private bool _flagMapping;

        /// <summary>
        /// Returns false as Mapping should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMapping()
        {
            return _flagMapping;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSubscriptionConfig" /> class.
        /// </summary>
        /// <param name="mapping">mapping.</param>
        public WebhooksSubscriptionConfig(WebhooksSubscriptionMapping? mapping = default(WebhooksSubscriptionMapping?))
        {
            this._Mapping = mapping;
            if (this.Mapping != null)
            {
                this._flagMapping = true;
            }
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhooksSubscriptionConfig {\n");
            sb.Append("  Mapping: ").Append(Mapping).Append("\n");
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
            return this.Equals(input as WebhooksSubscriptionConfig);
        }

        /// <summary>
        /// Returns true if WebhooksSubscriptionConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhooksSubscriptionConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhooksSubscriptionConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Mapping == input.Mapping ||
                    this.Mapping.Equals(input.Mapping)
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
                hashCode = (hashCode * 59) + this.Mapping.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
