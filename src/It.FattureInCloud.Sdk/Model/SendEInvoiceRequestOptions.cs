/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.25
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
    /// SendEInvoiceRequestOptions
    /// </summary>
    [DataContract(Name = "SendEInvoiceRequest_options")]
    public partial class SendEInvoiceRequestOptions : IEquatable<SendEInvoiceRequestOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendEInvoiceRequestOptions" /> class.
        /// </summary>
        /// <param name="dryRun">If set to true the e-invoice will not be sent to the SDI..</param>
        public SendEInvoiceRequestOptions(bool? dryRun = default(bool?))
        {
            this._DryRun = dryRun;
            if (this.DryRun != null)
            {
                this._flagDryRun = true;
            }
        }

        /// <summary>
        /// If set to true the e-invoice will not be sent to the SDI.
        /// </summary>
        /// <value>If set to true the e-invoice will not be sent to the SDI.</value>
        [DataMember(Name = "dry_run", EmitDefaultValue = true)]
        public bool? DryRun
        {
            get { return _DryRun; }
            set
            {
                _DryRun = value;
                _flagDryRun = true;
            }
        }
        private bool? _DryRun;
        private bool _flagDryRun;

        /// <summary>
        /// Returns false as DryRun should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDryRun()
        {
            return _flagDryRun;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SendEInvoiceRequestOptions {\n");
            sb.Append("  DryRun: ").Append(DryRun).Append("\n");
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
            return this.Equals(input as SendEInvoiceRequestOptions);
        }

        /// <summary>
        /// Returns true if SendEInvoiceRequestOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of SendEInvoiceRequestOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendEInvoiceRequestOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.DryRun == input.DryRun ||
                    (this.DryRun != null &&
                    this.DryRun.Equals(input.DryRun))
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
                if (this.DryRun != null)
                {
                    hashCode = (hashCode * 59) + this.DryRun.GetHashCode();
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