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
    /// CreateReceiptRequest
    /// </summary>
    [DataContract(Name = "CreateReceiptRequest")]
    public partial class CreateReceiptRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReceiptRequest" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="autocompleteNumber">If true, the number is autocompleted progressively..</param>
        public CreateReceiptRequest(Receipt data = default(Receipt), bool? autocompleteNumber = default(bool?))
        {
            this._Data = data;
            if (this.Data != null)
            {
                this._flagData = true;
            }
            this._AutocompleteNumber = autocompleteNumber;
            if (this.AutocompleteNumber != null)
            {
                this._flagAutocompleteNumber = true;
            }
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Receipt Data
        {
            get { return _Data; }
            set
            {
                _Data = value;
                _flagData = true;
            }
        }
        private Receipt _Data;
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
        /// If true, the number is autocompleted progressively.
        /// </summary>
        /// <value>If true, the number is autocompleted progressively.</value>
        [DataMember(Name = "autocomplete_number", EmitDefaultValue = true)]
        public bool? AutocompleteNumber
        {
            get { return _AutocompleteNumber; }
            set
            {
                _AutocompleteNumber = value;
                _flagAutocompleteNumber = true;
            }
        }
        private bool? _AutocompleteNumber;
        private bool _flagAutocompleteNumber;

        /// <summary>
        /// Returns false as AutocompleteNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAutocompleteNumber()
        {
            return _flagAutocompleteNumber;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateReceiptRequest {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  AutocompleteNumber: ").Append(AutocompleteNumber).Append("\n");
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
