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
    /// JoinIssuedDocumentsResponse
    /// </summary>
    [DataContract(Name = "JoinIssuedDocumentsResponse")]
    public partial class JoinIssuedDocumentsResponse : IEquatable<JoinIssuedDocumentsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JoinIssuedDocumentsResponse" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="options">options.</param>
        public JoinIssuedDocumentsResponse(IssuedDocument data = default(IssuedDocument), IssuedDocumentOptions options = default(IssuedDocumentOptions))
        {
            this._Data = data;
            if (this.Data != null)
            {
                this._flagData = true;
            }
            this._Options = options;
            if (this.Options != null)
            {
                this._flagOptions = true;
            }
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public IssuedDocument Data
        {
            get { return _Data; }
            set
            {
                _Data = value;
                _flagData = true;
            }
        }
        private IssuedDocument _Data;
        private bool _flagData;

        /// <summary>
        /// Returns false as Data should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeData()
        {
            return _flagData;
        }
        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public IssuedDocumentOptions Options
        {
            get { return _Options; }
            set
            {
                _Options = value;
                _flagOptions = true;
            }
        }
        private IssuedDocumentOptions _Options;
        private bool _flagOptions;

        /// <summary>
        /// Returns false as Options should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOptions()
        {
            return _flagOptions;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JoinIssuedDocumentsResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as JoinIssuedDocumentsResponse);
        }

        /// <summary>
        /// Returns true if JoinIssuedDocumentsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of JoinIssuedDocumentsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JoinIssuedDocumentsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) &&
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
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
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
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
