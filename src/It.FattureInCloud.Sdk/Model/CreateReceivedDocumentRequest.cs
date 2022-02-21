/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.12
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
    /// CreateReceivedDocumentRequest
    /// </summary>
    [DataContract(Name = "CreateReceivedDocumentRequest")]
    public partial class CreateReceivedDocumentRequest : IEquatable<CreateReceivedDocumentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReceivedDocumentRequest" /> class.
        /// </summary>
        /// <param name="pendingId">Pending received document id of the document from which the new document is created..</param>
        /// <param name="data">data.</param>
        public CreateReceivedDocumentRequest(int? pendingId = default(int?), ReceivedDocument data = default(ReceivedDocument))
        {
            this._PendingId = pendingId;
            this._Data = data;
        }

        /// <summary>
        /// Pending received document id of the document from which the new document is created.
        /// </summary>
        /// <value>Pending received document id of the document from which the new document is created.</value>
        [DataMember(Name = "pending_id", EmitDefaultValue = true)]
        public int? PendingId
        {
            get{ return _PendingId;}
            set
            {
                _PendingId = value;
                _flagPendingId = true;
            }
        }
        private int? _PendingId;
        private bool _flagPendingId;

        /// <summary>
        /// Returns false as PendingId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePendingId()
        {
            return _flagPendingId;
        }
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public ReceivedDocument Data
        {
            get{ return _Data;}
            set
            {
                _Data = value;
                _flagData = true;
            }
        }
        private ReceivedDocument _Data;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateReceivedDocumentRequest {\n");
            sb.Append("  PendingId: ").Append(PendingId).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as CreateReceivedDocumentRequest);
        }

        /// <summary>
        /// Returns true if CreateReceivedDocumentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateReceivedDocumentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateReceivedDocumentRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PendingId == input.PendingId ||
                    (this.PendingId != null &&
                    this.PendingId.Equals(input.PendingId))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.PendingId != null)
                {
                    hashCode = (hashCode * 59) + this.PendingId.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
