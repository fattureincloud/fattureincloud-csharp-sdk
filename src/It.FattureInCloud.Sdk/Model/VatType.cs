/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.7
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
    /// VatType
    /// </summary>
    [DataContract(Name = "VatType")]
    public partial class VatType : IEquatable<VatType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VatType" /> class.
        /// </summary>
        /// <param name="id">Unique identifier.</param>
        /// <param name="value">Percentual value..</param>
        /// <param name="description">Short description..</param>
        /// <param name="notes">Long description and notes shown in documents..</param>
        /// <param name="eInvoice">Usable for e-invoices..</param>
        /// <param name="eiType">E-invoice type (natura)..</param>
        /// <param name="eiDescription">E-invoice description..</param>
        /// <param name="isDisabled">Determine if the vat type is disabled..</param>
        public VatType(int id = default(int), decimal value = default(decimal), string description = default(string), string notes = default(string), bool eInvoice = default(bool), string eiType = default(string), string eiDescription = default(string), bool isDisabled = default(bool))
        {
            this.Id = id;
            this.Value = value;
            this.Description = description;
            this.Notes = notes;
            this.EInvoice = eInvoice;
            this.EiType = eiType;
            this.EiDescription = eiDescription;
            this.IsDisabled = isDisabled;
        }

        /// <summary>
        /// Unique identifier
        /// </summary>
        /// <value>Unique identifier</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Percentual value.
        /// </summary>
        /// <value>Percentual value.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public decimal Value { get; set; }

        /// <summary>
        /// Short description.
        /// </summary>
        /// <value>Short description.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Long description and notes shown in documents.
        /// </summary>
        /// <value>Long description and notes shown in documents.</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Usable for e-invoices.
        /// </summary>
        /// <value>Usable for e-invoices.</value>
        [DataMember(Name = "e_invoice", EmitDefaultValue = true)]
        public bool EInvoice { get; set; }

        /// <summary>
        /// E-invoice type (natura).
        /// </summary>
        /// <value>E-invoice type (natura).</value>
        [DataMember(Name = "ei_type", EmitDefaultValue = false)]
        public string EiType { get; set; }

        /// <summary>
        /// E-invoice description.
        /// </summary>
        /// <value>E-invoice description.</value>
        [DataMember(Name = "ei_description", EmitDefaultValue = false)]
        public string EiDescription { get; set; }

        /// <summary>
        /// [Read Only] Determine if this vat type is editable.
        /// </summary>
        /// <value>[Read Only] Determine if this vat type is editable.</value>
        [DataMember(Name = "editable", EmitDefaultValue = true)]
        public bool Editable { get; private set; }

        /// <summary>
        /// Returns false as Editable should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEditable()
        {
            return false;
        }
        /// <summary>
        /// Determine if the vat type is disabled.
        /// </summary>
        /// <value>Determine if the vat type is disabled.</value>
        [DataMember(Name = "is_disabled", EmitDefaultValue = true)]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VatType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  EInvoice: ").Append(EInvoice).Append("\n");
            sb.Append("  EiType: ").Append(EiType).Append("\n");
            sb.Append("  EiDescription: ").Append(EiDescription).Append("\n");
            sb.Append("  Editable: ").Append(Editable).Append("\n");
            sb.Append("  IsDisabled: ").Append(IsDisabled).Append("\n");
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
            return this.Equals(input as VatType);
        }

        /// <summary>
        /// Returns true if VatType instances are equal
        /// </summary>
        /// <param name="input">Instance of VatType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VatType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.EInvoice == input.EInvoice ||
                    this.EInvoice.Equals(input.EInvoice)
                ) && 
                (
                    this.EiType == input.EiType ||
                    (this.EiType != null &&
                    this.EiType.Equals(input.EiType))
                ) && 
                (
                    this.EiDescription == input.EiDescription ||
                    (this.EiDescription != null &&
                    this.EiDescription.Equals(input.EiDescription))
                ) && 
                (
                    this.Editable == input.Editable ||
                    this.Editable.Equals(input.Editable)
                ) && 
                (
                    this.IsDisabled == input.IsDisabled ||
                    this.IsDisabled.Equals(input.IsDisabled)
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
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                hashCode = hashCode * 59 + this.EInvoice.GetHashCode();
                if (this.EiType != null)
                    hashCode = hashCode * 59 + this.EiType.GetHashCode();
                if (this.EiDescription != null)
                    hashCode = hashCode * 59 + this.EiDescription.GetHashCode();
                hashCode = hashCode * 59 + this.Editable.GetHashCode();
                hashCode = hashCode * 59 + this.IsDisabled.GetHashCode();
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
            // Value (decimal) maximum
            if(this.Value > (decimal)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, must be a value less than or equal to 100.", new [] { "Value" });
            }

            // Value (decimal) minimum
            if(this.Value < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, must be a value greater than or equal to 0.", new [] { "Value" });
            }

            yield break;
        }
    }

}
