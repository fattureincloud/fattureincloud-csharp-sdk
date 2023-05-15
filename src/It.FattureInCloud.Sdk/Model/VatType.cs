/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.28
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
        /// <param name="value">[Read Only] Percentual value..</param>
        /// <param name="description">Short description..</param>
        /// <param name="notes">Long description and notes shown in documents..</param>
        /// <param name="eInvoice">Usable for e-invoices..</param>
        /// <param name="eiType">E-invoice type (natura)..</param>
        /// <param name="eiDescription">E-invoice description..</param>
        /// <param name="isDisabled">Determine if the vat type is disabled..</param>
        public VatType(int? id = default(int?), decimal? value = default(decimal?), string description = default(string), string notes = default(string), bool? eInvoice = default(bool?), string eiType = default(string), string eiDescription = default(string), bool? isDisabled = default(bool?))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._Value = value;
            if (this.Value != null)
            {
                this._flagValue = true;
            }
            this._Description = description;
            if (this.Description != null)
            {
                this._flagDescription = true;
            }
            this._Notes = notes;
            if (this.Notes != null)
            {
                this._flagNotes = true;
            }
            this._EInvoice = eInvoice;
            if (this.EInvoice != null)
            {
                this._flagEInvoice = true;
            }
            this._EiType = eiType;
            if (this.EiType != null)
            {
                this._flagEiType = true;
            }
            this._EiDescription = eiDescription;
            if (this.EiDescription != null)
            {
                this._flagEiDescription = true;
            }
            this._IsDisabled = isDisabled;
            if (this.IsDisabled != null)
            {
                this._flagIsDisabled = true;
            }
        }

        /// <summary>
        /// Unique identifier
        /// </summary>
        /// <value>Unique identifier</value>
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
        /// [Read Only] Percentual value.
        /// </summary>
        /// <value>[Read Only] Percentual value.</value>
        /// <example>22</example>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public decimal? Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
                _flagValue = true;
            }
        }
        private decimal? _Value;
        private bool _flagValue;

        /// <summary>
        /// Returns false as Value should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValue()
        {
            return _flagValue;
        }
        /// <summary>
        /// Short description.
        /// </summary>
        /// <value>Short description.</value>
        /// <example>&quot;Non imponibile art. 123&quot;</example>
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
        /// Long description and notes shown in documents.
        /// </summary>
        /// <value>Long description and notes shown in documents.</value>
        /// <example>&quot;IVA non imponibile ai sensi dell&#39;articolo 123, comma 2&quot;</example>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes
        {
            get { return _Notes; }
            set
            {
                _Notes = value;
                _flagNotes = true;
            }
        }
        private string _Notes;
        private bool _flagNotes;

        /// <summary>
        /// Returns false as Notes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNotes()
        {
            return _flagNotes;
        }
        /// <summary>
        /// Usable for e-invoices.
        /// </summary>
        /// <value>Usable for e-invoices.</value>
        [DataMember(Name = "e_invoice", EmitDefaultValue = true)]
        public bool? EInvoice
        {
            get { return _EInvoice; }
            set
            {
                _EInvoice = value;
                _flagEInvoice = true;
            }
        }
        private bool? _EInvoice;
        private bool _flagEInvoice;

        /// <summary>
        /// Returns false as EInvoice should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEInvoice()
        {
            return _flagEInvoice;
        }
        /// <summary>
        /// E-invoice type (natura).
        /// </summary>
        /// <value>E-invoice type (natura).</value>
        /// <example>&quot;2&quot;</example>
        [DataMember(Name = "ei_type", EmitDefaultValue = true)]
        public string EiType
        {
            get { return _EiType; }
            set
            {
                _EiType = value;
                _flagEiType = true;
            }
        }
        private string _EiType;
        private bool _flagEiType;

        /// <summary>
        /// Returns false as EiType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEiType()
        {
            return _flagEiType;
        }
        /// <summary>
        /// E-invoice description.
        /// </summary>
        /// <value>E-invoice description.</value>
        [DataMember(Name = "ei_description", EmitDefaultValue = true)]
        public string EiDescription
        {
            get { return _EiDescription; }
            set
            {
                _EiDescription = value;
                _flagEiDescription = true;
            }
        }
        private string _EiDescription;
        private bool _flagEiDescription;

        /// <summary>
        /// Returns false as EiDescription should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEiDescription()
        {
            return _flagEiDescription;
        }
        /// <summary>
        /// [Read Only] Determine if this vat type is editable.
        /// </summary>
        /// <value>[Read Only] Determine if this vat type is editable.</value>
        [DataMember(Name = "editable", EmitDefaultValue = true)]
        public bool? Editable { get; private set; }

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
        public bool? IsDisabled
        {
            get { return _IsDisabled; }
            set
            {
                _IsDisabled = value;
                _flagIsDisabled = true;
            }
        }
        private bool? _IsDisabled;
        private bool _flagIsDisabled;

        /// <summary>
        /// Returns false as IsDisabled should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsDisabled()
        {
            return _flagIsDisabled;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                    (this.EInvoice != null &&
                    this.EInvoice.Equals(input.EInvoice))
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
                    (this.Editable != null &&
                    this.Editable.Equals(input.Editable))
                ) &&
                (
                    this.IsDisabled == input.IsDisabled ||
                    (this.IsDisabled != null &&
                    this.IsDisabled.Equals(input.IsDisabled))
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
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.EInvoice != null)
                {
                    hashCode = (hashCode * 59) + this.EInvoice.GetHashCode();
                }
                if (this.EiType != null)
                {
                    hashCode = (hashCode * 59) + this.EiType.GetHashCode();
                }
                if (this.EiDescription != null)
                {
                    hashCode = (hashCode * 59) + this.EiDescription.GetHashCode();
                }
                if (this.Editable != null)
                {
                    hashCode = (hashCode * 59) + this.Editable.GetHashCode();
                }
                if (this.IsDisabled != null)
                {
                    hashCode = (hashCode * 59) + this.IsDisabled.GetHashCode();
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
