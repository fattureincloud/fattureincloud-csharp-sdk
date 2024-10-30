/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.1.3
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
    /// WebhooksSubscription
    /// </summary>
    [DataContract(Name = "WebhooksSubscription")]
    public partial class WebhooksSubscription : IEquatable<WebhooksSubscription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSubscription" /> class.
        /// </summary>
        /// <param name="id">Webhooks subscription id.</param>
        /// <param name="sink">Webhooks callback uri..</param>
        /// <param name="verified">[Read Only] True if the webhooks subscription has been verified..</param>
        /// <param name="types">Webhooks events types..</param>
        /// <param name="config">config.</param>
        public WebhooksSubscription(string id = default(string), string sink = default(string), bool? verified = default(bool?), List<EventType> types = default(List<EventType>), WebhooksSubscriptionConfig config = default(WebhooksSubscriptionConfig))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._Sink = sink;
            if (this.Sink != null)
            {
                this._flagSink = true;
            }
            this._Verified = verified;
            if (this.Verified != null)
            {
                this._flagVerified = true;
            }
            this._Types = types;
            if (this.Types != null)
            {
                this._flagTypes = true;
            }
            this._Config = config;
            if (this.Config != null)
            {
                this._flagConfig = true;
            }
        }

        /// <summary>
        /// Webhooks subscription id
        /// </summary>
        /// <value>Webhooks subscription id</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
                _flagId = true;
            }
        }
        private string _Id;
        private bool _flagId;

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return _flagId;
        }
        /// <summary>
        /// Webhooks callback uri.
        /// </summary>
        /// <value>Webhooks callback uri.</value>
        [DataMember(Name = "sink", EmitDefaultValue = true)]
        public string Sink
        {
            get { return _Sink; }
            set
            {
                _Sink = value;
                _flagSink = true;
            }
        }
        private string _Sink;
        private bool _flagSink;

        /// <summary>
        /// Returns false as Sink should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSink()
        {
            return _flagSink;
        }
        /// <summary>
        /// [Read Only] True if the webhooks subscription has been verified.
        /// </summary>
        /// <value>[Read Only] True if the webhooks subscription has been verified.</value>
        [DataMember(Name = "verified", EmitDefaultValue = true)]
        public bool? Verified
        {
            get { return _Verified; }
            set
            {
                _Verified = value;
                _flagVerified = true;
            }
        }
        private bool? _Verified;
        private bool _flagVerified;

        /// <summary>
        /// Returns false as Verified should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVerified()
        {
            return _flagVerified;
        }
        /// <summary>
        /// Webhooks events types.
        /// </summary>
        /// <value>Webhooks events types.</value>
        [DataMember(Name = "types", EmitDefaultValue = true)]
        public List<EventType> Types
        {
            get { return _Types; }
            set
            {
                _Types = value;
                _flagTypes = true;
            }
        }
        private List<EventType> _Types;
        private bool _flagTypes;

        /// <summary>
        /// Returns false as Types should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTypes()
        {
            return _flagTypes;
        }
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "config", EmitDefaultValue = false)]
        public WebhooksSubscriptionConfig Config
        {
            get { return _Config; }
            set
            {
                _Config = value;
                _flagConfig = true;
            }
        }
        private WebhooksSubscriptionConfig _Config;
        private bool _flagConfig;

        /// <summary>
        /// Returns false as Config should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConfig()
        {
            return _flagConfig;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhooksSubscription {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Sink: ").Append(Sink).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
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
            return this.Equals(input as WebhooksSubscription);
        }

        /// <summary>
        /// Returns true if WebhooksSubscription instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhooksSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhooksSubscription input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) &&
                (
                    this.Sink == input.Sink ||
                    (this.Sink != null &&
                    this.Sink.Equals(input.Sink))
                ) &&
                (
                    this.Verified == input.Verified ||
                    (this.Verified != null &&
                    this.Verified.Equals(input.Verified))
                ) &&
                (
                    this.Types == input.Types ||
                    this.Types != null &&
                    input.Types != null &&
                    this.Types.SequenceEqual(input.Types)
                ) &&
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Sink != null)
                {
                    hashCode = (hashCode * 59) + this.Sink.GetHashCode();
                }
                if (this.Verified != null)
                {
                    hashCode = (hashCode * 59) + this.Verified.GetHashCode();
                }
                if (this.Types != null)
                {
                    hashCode = (hashCode * 59) + this.Types.GetHashCode();
                }
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
