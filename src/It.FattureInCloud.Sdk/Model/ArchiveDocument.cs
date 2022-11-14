/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.21
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
    /// ArchiveDocument
    /// </summary>
    [DataContract(Name = "ArchiveDocument")]
    public partial class ArchiveDocument : IEquatable<ArchiveDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveDocument" /> class.
        /// </summary>
        /// <param name="id">Archive document unique identifier..</param>
        /// <param name="date">Archive document date..</param>
        /// <param name="description">Archive Document description..</param>
        /// <param name="category">Archive document category..</param>
        /// <param name="attachmentToken">[Write Only]  [Required] Attachment token returned by POST /archive/attachment. Used to attach the file already uploaded..</param>
        public ArchiveDocument(int? id = default(int?), DateTime? date = default(DateTime?), string description = default(string), string category = default(string), string attachmentToken = default(string))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._Date = date;
            if (this.Date != null)
            {
                this._flagDate = true;
            }
            this._Description = description;
            if (this.Description != null)
            {
                this._flagDescription = true;
            }
            this._Category = category;
            if (this.Category != null)
            {
                this._flagCategory = true;
            }
            this._AttachmentToken = attachmentToken;
            if (this.AttachmentToken != null)
            {
                this._flagAttachmentToken = true;
            }
        }

        /// <summary>
        /// Archive document unique identifier.
        /// </summary>
        /// <value>Archive document unique identifier.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
                _flagId = true;
            }
        }
        private int? _Id;
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
        /// Archive document date.
        /// </summary>
        /// <value>Archive document date.</value>
        [JsonConverter(typeof(OpenAPIDateConverter))]
        [DataMember(Name = "date", EmitDefaultValue = true)]
        public DateTime? Date
        {
            get { return _Date; }
            set
            {
                _Date = value;
                _flagDate = true;
            }
        }
        private DateTime? _Date;
        private bool _flagDate;

        /// <summary>
        /// Returns false as Date should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDate()
        {
            return _flagDate;
        }
        /// <summary>
        /// Archive Document description.
        /// </summary>
        /// <value>Archive Document description.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                _flagDescription = true;
            }
        }
        private string _Description;
        private bool _flagDescription;

        /// <summary>
        /// Returns false as Description should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDescription()
        {
            return _flagDescription;
        }
        /// <summary>
        /// [Read Only] Absolute url of the attached file. Authomatically set if a valid attachment token is passed via POST /archive or PUT /archive/{documentId}.
        /// </summary>
        /// <value>[Read Only] Absolute url of the attached file. Authomatically set if a valid attachment token is passed via POST /archive or PUT /archive/{documentId}.</value>
        [DataMember(Name = "attachment_url", EmitDefaultValue = true)]
        public string AttachmentUrl { get; private set; }

        /// <summary>
        /// Returns false as AttachmentUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAttachmentUrl()
        {
            return false;
        }
        /// <summary>
        /// Archive document category.
        /// </summary>
        /// <value>Archive document category.</value>
        [DataMember(Name = "category", EmitDefaultValue = true)]
        public string Category
        {
            get { return _Category; }
            set
            {
                _Category = value;
                _flagCategory = true;
            }
        }
        private string _Category;
        private bool _flagCategory;

        /// <summary>
        /// Returns false as Category should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCategory()
        {
            return _flagCategory;
        }
        /// <summary>
        /// [Write Only]  [Required] Attachment token returned by POST /archive/attachment. Used to attach the file already uploaded.
        /// </summary>
        /// <value>[Write Only]  [Required] Attachment token returned by POST /archive/attachment. Used to attach the file already uploaded.</value>
        [DataMember(Name = "attachment_token", EmitDefaultValue = true)]
        public string AttachmentToken
        {
            get { return _AttachmentToken; }
            set
            {
                _AttachmentToken = value;
                _flagAttachmentToken = true;
            }
        }
        private string _AttachmentToken;
        private bool _flagAttachmentToken;

        /// <summary>
        /// Returns false as AttachmentToken should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAttachmentToken()
        {
            return _flagAttachmentToken;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArchiveDocument {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AttachmentUrl: ").Append(AttachmentUrl).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(input as ArchiveDocument);
        }

        /// <summary>
        /// Returns true if ArchiveDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of ArchiveDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchiveDocument input)
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
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) &&
                (
                    this.AttachmentUrl == input.AttachmentUrl ||
                    (this.AttachmentUrl != null &&
                    this.AttachmentUrl.Equals(input.AttachmentUrl))
                ) &&
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) &&
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.AttachmentUrl != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentUrl.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.AttachmentToken != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentToken.GetHashCode();
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
