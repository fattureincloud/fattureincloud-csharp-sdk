/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.3
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
    /// CompanyInfoPlanInfo
    /// </summary>
    [DataContract(Name = "CompanyInfo_plan_info")]
    public partial class CompanyInfoPlanInfo : IEquatable<CompanyInfoPlanInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyInfoPlanInfo" /> class.
        /// </summary>
        /// <param name="limits">limits.</param>
        /// <param name="functions">functions.</param>
        /// <param name="functionsStatus">functionsStatus.</param>
        public CompanyInfoPlanInfo(CompanyInfoPlanInfoLimits limits = default(CompanyInfoPlanInfoLimits), CompanyInfoPlanInfoFunctions functions = default(CompanyInfoPlanInfoFunctions), CompanyInfoPlanInfoFunctionsStatus functionsStatus = default(CompanyInfoPlanInfoFunctionsStatus))
        {
            this.Limits = limits;
            this.Functions = functions;
            this.FunctionsStatus = functionsStatus;
        }

        /// <summary>
        /// Gets or Sets Limits
        /// </summary>
        [DataMember(Name = "limits", EmitDefaultValue = false)]
        public CompanyInfoPlanInfoLimits Limits { get; set; }

        /// <summary>
        /// Gets or Sets Functions
        /// </summary>
        [DataMember(Name = "functions", EmitDefaultValue = false)]
        public CompanyInfoPlanInfoFunctions Functions { get; set; }

        /// <summary>
        /// Gets or Sets FunctionsStatus
        /// </summary>
        [DataMember(Name = "functions_status", EmitDefaultValue = false)]
        public CompanyInfoPlanInfoFunctionsStatus FunctionsStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyInfoPlanInfo {\n");
            sb.Append("  Limits: ").Append(Limits).Append("\n");
            sb.Append("  Functions: ").Append(Functions).Append("\n");
            sb.Append("  FunctionsStatus: ").Append(FunctionsStatus).Append("\n");
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
            return this.Equals(input as CompanyInfoPlanInfo);
        }

        /// <summary>
        /// Returns true if CompanyInfoPlanInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyInfoPlanInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyInfoPlanInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limits == input.Limits ||
                    (this.Limits != null &&
                    this.Limits.Equals(input.Limits))
                ) && 
                (
                    this.Functions == input.Functions ||
                    (this.Functions != null &&
                    this.Functions.Equals(input.Functions))
                ) && 
                (
                    this.FunctionsStatus == input.FunctionsStatus ||
                    (this.FunctionsStatus != null &&
                    this.FunctionsStatus.Equals(input.FunctionsStatus))
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
                if (this.Limits != null)
                    hashCode = hashCode * 59 + this.Limits.GetHashCode();
                if (this.Functions != null)
                    hashCode = hashCode * 59 + this.Functions.GetHashCode();
                if (this.FunctionsStatus != null)
                    hashCode = hashCode * 59 + this.FunctionsStatus.GetHashCode();
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