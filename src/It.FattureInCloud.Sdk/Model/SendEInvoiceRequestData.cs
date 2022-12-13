/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.23
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
    /// SendEInvoiceRequestData
    /// </summary>
    [DataContract(Name = "SendEInvoiceRequest_data")]
    public partial class SendEInvoiceRequestData : IEquatable<SendEInvoiceRequestData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendEInvoiceRequestData" /> class.
        /// </summary>
        /// <param name="cassaType">Value of TipoCassa used (optional, override the company default value)..</param>
        /// <param name="withholdingTaxCausal">Value of CausalePagamento used (optional, override the company default value)..</param>
        public SendEInvoiceRequestData(string cassaType = default(string), string withholdingTaxCausal = default(string))
        {
            this._CassaType = cassaType;
            if (this.CassaType != null)
            {
                this._flagCassaType = true;
            }
            this._WithholdingTaxCausal = withholdingTaxCausal;
            if (this.WithholdingTaxCausal != null)
            {
                this._flagWithholdingTaxCausal = true;
            }
        }

        /// <summary>
        /// Value of TipoCassa used (optional, override the company default value).
        /// </summary>
        /// <value>Value of TipoCassa used (optional, override the company default value).</value>
        [DataMember(Name = "cassa_type", EmitDefaultValue = true)]
        public string CassaType
        {
            get { return _CassaType; }
            set
            {
                _CassaType = value;
                _flagCassaType = true;
            }
        }
        private string _CassaType;
        private bool _flagCassaType;

        /// <summary>
        /// Returns false as CassaType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCassaType()
        {
            return _flagCassaType;
        }
        /// <summary>
        /// Value of CausalePagamento used (optional, override the company default value).
        /// </summary>
        /// <value>Value of CausalePagamento used (optional, override the company default value).</value>
        [DataMember(Name = "withholding_tax_causal", EmitDefaultValue = true)]
        public string WithholdingTaxCausal
        {
            get { return _WithholdingTaxCausal; }
            set
            {
                _WithholdingTaxCausal = value;
                _flagWithholdingTaxCausal = true;
            }
        }
        private string _WithholdingTaxCausal;
        private bool _flagWithholdingTaxCausal;

        /// <summary>
        /// Returns false as WithholdingTaxCausal should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWithholdingTaxCausal()
        {
            return _flagWithholdingTaxCausal;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SendEInvoiceRequestData {\n");
            sb.Append("  CassaType: ").Append(CassaType).Append("\n");
            sb.Append("  WithholdingTaxCausal: ").Append(WithholdingTaxCausal).Append("\n");
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
            return this.Equals(input as SendEInvoiceRequestData);
        }

        /// <summary>
        /// Returns true if SendEInvoiceRequestData instances are equal
        /// </summary>
        /// <param name="input">Instance of SendEInvoiceRequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendEInvoiceRequestData input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.CassaType == input.CassaType ||
                    (this.CassaType != null &&
                    this.CassaType.Equals(input.CassaType))
                ) &&
                (
                    this.WithholdingTaxCausal == input.WithholdingTaxCausal ||
                    (this.WithholdingTaxCausal != null &&
                    this.WithholdingTaxCausal.Equals(input.WithholdingTaxCausal))
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
                if (this.CassaType != null)
                {
                    hashCode = (hashCode * 59) + this.CassaType.GetHashCode();
                }
                if (this.WithholdingTaxCausal != null)
                {
                    hashCode = (hashCode * 59) + this.WithholdingTaxCausal.GetHashCode();
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
