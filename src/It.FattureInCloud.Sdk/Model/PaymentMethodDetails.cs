/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.13
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
    /// PaymentMethodDetails
    /// </summary>
    [DataContract(Name = "PaymentMethod_details")]
    public partial class PaymentMethodDetails : IEquatable<PaymentMethodDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodDetails" /> class.
        /// </summary>
        /// <param name="title">Details title..</param>
        /// <param name="description">Details description..</param>
        public PaymentMethodDetails(string title = default(string), string description = default(string))
        {
            this._Title = title;
            this._Description = description;
        }

        /// <summary>
        /// Details title.
        /// </summary>
        /// <value>Details title.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title
        {
            get{ return _Title;}
            set
            {
                _Title = value;
                _flagTitle = true;
            }
        }
        private string _Title;
        private bool _flagTitle;

        /// <summary>
        /// Returns false as Title should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTitle()
        {
            return _flagTitle;
        }
        /// <summary>
        /// Details description.
        /// </summary>
        /// <value>Details description.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description
        {
            get{ return _Description;}
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodDetails {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as PaymentMethodDetails);
        }

        /// <summary>
        /// Returns true if PaymentMethodDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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
