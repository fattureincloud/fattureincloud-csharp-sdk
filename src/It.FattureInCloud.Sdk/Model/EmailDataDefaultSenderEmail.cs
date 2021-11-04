/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol. For more information, please visit https://www.fattureincloud.it.
 *
 * The version of the OpenAPI document: 2.0.2
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
    /// Default sender email. (Other emails can be found in &#x60;sender_emails_list&#x60;)
    /// </summary>
    [DataContract(Name = "EmailData_default_sender_email")]
    public partial class EmailDataDefaultSenderEmail : IEquatable<EmailDataDefaultSenderEmail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailDataDefaultSenderEmail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailDataDefaultSenderEmail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailDataDefaultSenderEmail" /> class.
        /// </summary>
        /// <param name="id">Id (required).</param>
        /// <param name="email">Email address (required).</param>
        public EmailDataDefaultSenderEmail(decimal id = default(decimal), string email = default(string))
        {
            this.Id = id;
            // to ensure "email" is required (not null)
            if (email == null) {
                throw new ArgumentNullException("email is a required property for EmailDataDefaultSenderEmail and cannot be null");
            }
            this.Email = email;
        }

        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public decimal Id { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        /// <value>Email address</value>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailDataDefaultSenderEmail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as EmailDataDefaultSenderEmail);
        }

        /// <summary>
        /// Returns true if EmailDataDefaultSenderEmail instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailDataDefaultSenderEmail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailDataDefaultSenderEmail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
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
