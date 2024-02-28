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
    /// Received document items default values
    /// </summary>
    [DataContract(Name = "ReceivedDocumentInfo_items_default_values")]
    public partial class ReceivedDocumentInfoItemsDefaultValues : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivedDocumentInfoItemsDefaultValues" /> class.
        /// </summary>
        /// <param name="vat">Vat default value.</param>
        public ReceivedDocumentInfoItemsDefaultValues(decimal? vat = default(decimal?))
        {
            this._Vat = vat;
            if (this.Vat != null)
            {
                this._flagVat = true;
            }
        }

        /// <summary>
        /// Vat default value
        /// </summary>
        /// <value>Vat default value</value>
        [DataMember(Name = "vat", EmitDefaultValue = true)]
        public decimal? Vat
        {
            get { return _Vat; }
            set
            {
                _Vat = value;
                _flagVat = true;
            }
        }
        private decimal? _Vat;
        private bool _flagVat;

        /// <summary>
        /// Returns false as Vat should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVat()
        {
            return _flagVat;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReceivedDocumentInfoItemsDefaultValues {\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
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
