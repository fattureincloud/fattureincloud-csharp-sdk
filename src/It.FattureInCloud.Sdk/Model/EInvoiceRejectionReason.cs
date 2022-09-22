/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.20
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
    /// EInvoiceRejectionReason
    /// </summary>
    [DataContract(Name = "EInvoiceRejectionReason")]
    public partial class EInvoiceRejectionReason : IEquatable<EInvoiceRejectionReason>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EInvoiceRejectionReason" /> class.
        /// </summary>
        /// <param name="reason">Rejection reason..</param>
        /// <param name="eiStatus">E-invoice status..</param>
        /// <param name="solution">Error solution..</param>
        /// <param name="code">Error code..</param>
        /// <param name="date">Rejection date..</param>
        public EInvoiceRejectionReason(string reason = default(string), string eiStatus = default(string), string solution = default(string), string code = default(string), DateTimeOffset? date = default(DateTimeOffset?))
        {
            this._Reason = reason;
            if (this.Reason != null)
            {
                this._flagReason = true;
            }
            this._EiStatus = eiStatus;
            if (this.EiStatus != null)
            {
                this._flagEiStatus = true;
            }
            this._Solution = solution;
            if (this.Solution != null)
            {
                this._flagSolution = true;
            }
            this._Code = code;
            if (this.Code != null)
            {
                this._flagCode = true;
            }
            this._Date = date;
            if (this.Date != null)
            {
                this._flagDate = true;
            }
        }

        /// <summary>
        /// Rejection reason.
        /// </summary>
        /// <value>Rejection reason.</value>
        [DataMember(Name = "reason", EmitDefaultValue = true)]
        public string Reason
        {
            get { return _Reason; }
            set
            {
                _Reason = value;
                _flagReason = true;
            }
        }
        private string _Reason;
        private bool _flagReason;

        /// <summary>
        /// Returns false as Reason should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeReason()
        {
            return _flagReason;
        }
        /// <summary>
        /// E-invoice status.
        /// </summary>
        /// <value>E-invoice status.</value>
        [DataMember(Name = "ei_status", EmitDefaultValue = true)]
        public string EiStatus
        {
            get { return _EiStatus; }
            set
            {
                _EiStatus = value;
                _flagEiStatus = true;
            }
        }
        private string _EiStatus;
        private bool _flagEiStatus;

        /// <summary>
        /// Returns false as EiStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEiStatus()
        {
            return _flagEiStatus;
        }
        /// <summary>
        /// Error solution.
        /// </summary>
        /// <value>Error solution.</value>
        [DataMember(Name = "solution", EmitDefaultValue = true)]
        public string Solution
        {
            get { return _Solution; }
            set
            {
                _Solution = value;
                _flagSolution = true;
            }
        }
        private string _Solution;
        private bool _flagSolution;

        /// <summary>
        /// Returns false as Solution should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSolution()
        {
            return _flagSolution;
        }
        /// <summary>
        /// Error code.
        /// </summary>
        /// <value>Error code.</value>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code
        {
            get { return _Code; }
            set
            {
                _Code = value;
                _flagCode = true;
            }
        }
        private string _Code;
        private bool _flagCode;

        /// <summary>
        /// Returns false as Code should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCode()
        {
            return _flagCode;
        }
        /// <summary>
        /// Rejection date.
        /// </summary>
        /// <value>Rejection date.</value>
        [DataMember(Name = "date", EmitDefaultValue = true)]
        public DateTimeOffset? Date
        {
            get { return _Date; }
            set
            {
                _Date = value;
                _flagDate = true;
            }
        }
        private DateTimeOffset? _Date;
        private bool _flagDate;

        /// <summary>
        /// Returns false as Date should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDate()
        {
            return _flagDate;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EInvoiceRejectionReason {\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  EiStatus: ").Append(EiStatus).Append("\n");
            sb.Append("  Solution: ").Append(Solution).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(input as EInvoiceRejectionReason);
        }

        /// <summary>
        /// Returns true if EInvoiceRejectionReason instances are equal
        /// </summary>
        /// <param name="input">Instance of EInvoiceRejectionReason to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EInvoiceRejectionReason input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) &&
                (
                    this.EiStatus == input.EiStatus ||
                    (this.EiStatus != null &&
                    this.EiStatus.Equals(input.EiStatus))
                ) &&
                (
                    this.Solution == input.Solution ||
                    (this.Solution != null &&
                    this.Solution.Equals(input.Solution))
                ) &&
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) &&
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                if (this.Reason != null)
                {
                    hashCode = (hashCode * 59) + this.Reason.GetHashCode();
                }
                if (this.EiStatus != null)
                {
                    hashCode = (hashCode * 59) + this.EiStatus.GetHashCode();
                }
                if (this.Solution != null)
                {
                    hashCode = (hashCode * 59) + this.Solution.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
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
