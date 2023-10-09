/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.30
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
    /// CompanyInfoPlanInfoFunctionsStatus
    /// </summary>
    [DataContract(Name = "CompanyInfo_plan_info_functions_status")]
    public partial class CompanyInfoPlanInfoFunctionsStatus : IEquatable<CompanyInfoPlanInfoFunctionsStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyInfoPlanInfoFunctionsStatus" /> class.
        /// </summary>
        /// <param name="tsDigital">tsDigital.</param>
        /// <param name="tsPay">tsPay.</param>
        public CompanyInfoPlanInfoFunctionsStatus(FunctionStatus tsDigital = default(FunctionStatus), FunctionStatus tsPay = default(FunctionStatus))
        {
            this._TsDigital = tsDigital;
            if (this.TsDigital != null)
            {
                this._flagTsDigital = true;
            }
            this._TsPay = tsPay;
            if (this.TsPay != null)
            {
                this._flagTsPay = true;
            }
        }

        /// <summary>
        /// Gets or Sets TsDigital
        /// </summary>
        [DataMember(Name = "ts_digital", EmitDefaultValue = false)]
        public FunctionStatus TsDigital
        {
            get { return _TsDigital; }
            set
            {
                _TsDigital = value;
                _flagTsDigital = true;
            }
        }
        private FunctionStatus _TsDigital;
        private bool _flagTsDigital;

        /// <summary>
        /// Returns false as TsDigital should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTsDigital()
        {
            return _flagTsDigital;
        }
        /// <summary>
        /// Gets or Sets TsPay
        /// </summary>
        [DataMember(Name = "ts_pay", EmitDefaultValue = false)]
        public FunctionStatus TsPay
        {
            get { return _TsPay; }
            set
            {
                _TsPay = value;
                _flagTsPay = true;
            }
        }
        private FunctionStatus _TsPay;
        private bool _flagTsPay;

        /// <summary>
        /// Returns false as TsPay should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTsPay()
        {
            return _flagTsPay;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyInfoPlanInfoFunctionsStatus {\n");
            sb.Append("  TsDigital: ").Append(TsDigital).Append("\n");
            sb.Append("  TsPay: ").Append(TsPay).Append("\n");
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
            return this.Equals(input as CompanyInfoPlanInfoFunctionsStatus);
        }

        /// <summary>
        /// Returns true if CompanyInfoPlanInfoFunctionsStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyInfoPlanInfoFunctionsStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyInfoPlanInfoFunctionsStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.TsDigital == input.TsDigital ||
                    (this.TsDigital != null &&
                    this.TsDigital.Equals(input.TsDigital))
                ) &&
                (
                    this.TsPay == input.TsPay ||
                    (this.TsPay != null &&
                    this.TsPay.Equals(input.TsPay))
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
                if (this.TsDigital != null)
                {
                    hashCode = (hashCode * 59) + this.TsDigital.GetHashCode();
                }
                if (this.TsPay != null)
                {
                    hashCode = (hashCode * 59) + this.TsPay.GetHashCode();
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
