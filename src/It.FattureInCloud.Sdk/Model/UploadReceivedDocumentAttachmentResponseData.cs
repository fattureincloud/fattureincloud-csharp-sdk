/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.5
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
    /// UploadReceivedDocumentAttachmentResponseData
    /// </summary>
    [DataContract(Name = "UploadReceivedDocumentAttachmentResponse_data")]
    public partial class UploadReceivedDocumentAttachmentResponseData : IEquatable<UploadReceivedDocumentAttachmentResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadReceivedDocumentAttachmentResponseData" /> class.
        /// </summary>
        /// <param name="attachmentToken">Uploaded attachment token..</param>
        public UploadReceivedDocumentAttachmentResponseData(string attachmentToken = default(string))
        {
            this.AttachmentToken = attachmentToken;
        }

        /// <summary>
        /// Uploaded attachment token.
        /// </summary>
        /// <value>Uploaded attachment token.</value>
        [DataMember(Name = "attachment_token", EmitDefaultValue = false)]
        public string AttachmentToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadReceivedDocumentAttachmentResponseData {\n");
            sb.Append("  AttachmentToken: ").Append(AttachmentToken).Append("\n");
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
            return this.Equals(input as UploadReceivedDocumentAttachmentResponseData);
        }

        /// <summary>
        /// Returns true if UploadReceivedDocumentAttachmentResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadReceivedDocumentAttachmentResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadReceivedDocumentAttachmentResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttachmentToken == input.AttachmentToken ||
                    (this.AttachmentToken != null &&
                    this.AttachmentToken.Equals(input.AttachmentToken))
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
                if (this.AttachmentToken != null)
                    hashCode = hashCode * 59 + this.AttachmentToken.GetHashCode();
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
