/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.32
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
    /// EmailAttachment
    /// </summary>
    [DataContract(Name = "EmailAttachment")]
    public partial class EmailAttachment : IEquatable<EmailAttachment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAttachment" /> class.
        /// </summary>
        /// <param name="filename">Email attachment filename.</param>
        /// <param name="url">Email attachment url.</param>
        public EmailAttachment(string filename = default(string), string url = default(string))
        {
            this._Filename = filename;
            if (this.Filename != null)
            {
                this._flagFilename = true;
            }
            this._Url = url;
            if (this.Url != null)
            {
                this._flagUrl = true;
            }
        }

        /// <summary>
        /// Email attachment filename
        /// </summary>
        /// <value>Email attachment filename</value>
        [DataMember(Name = "filename", EmitDefaultValue = false)]
        public string Filename
        {
            get { return _Filename; }
            set
            {
                _Filename = value;
                _flagFilename = true;
            }
        }
        private string _Filename;
        private bool _flagFilename;

        /// <summary>
        /// Returns false as Filename should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFilename()
        {
            return _flagFilename;
        }
        /// <summary>
        /// Email attachment url
        /// </summary>
        /// <value>Email attachment url</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url
        {
            get { return _Url; }
            set
            {
                _Url = value;
                _flagUrl = true;
            }
        }
        private string _Url;
        private bool _flagUrl;

        /// <summary>
        /// Returns false as Url should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUrl()
        {
            return _flagUrl;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailAttachment {\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as EmailAttachment);
        }

        /// <summary>
        /// Returns true if EmailAttachment instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailAttachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailAttachment input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) &&
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Filename != null)
                {
                    hashCode = (hashCode * 59) + this.Filename.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
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
