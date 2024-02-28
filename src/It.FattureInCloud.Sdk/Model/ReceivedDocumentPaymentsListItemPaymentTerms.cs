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
    /// ReceivedDocumentPaymentsListItemPaymentTerms
    /// </summary>
    [DataContract(Name = "ReceivedDocumentPaymentsListItem_payment_terms")]
    public partial class ReceivedDocumentPaymentsListItemPaymentTerms : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>

        [DataMember(Name = "type", EmitDefaultValue = false)]
        public PaymentTermsType? Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                _flagType = true;
            }
        }
        private PaymentTermsType? _Type;
        private bool _flagType;

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return _flagType;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivedDocumentPaymentsListItemPaymentTerms" /> class.
        /// </summary>
        /// <param name="days">Received document payment number of days by which the payment must be made.</param>
        /// <param name="type">type.</param>
        public ReceivedDocumentPaymentsListItemPaymentTerms(int? days = default(int?), PaymentTermsType? type = default(PaymentTermsType?))
        {
            this._Days = days;
            if (this.Days != null)
            {
                this._flagDays = true;
            }
            this._Type = type;
            if (this.Type != null)
            {
                this._flagType = true;
            }
        }

        /// <summary>
        /// Received document payment number of days by which the payment must be made
        /// </summary>
        /// <value>Received document payment number of days by which the payment must be made</value>
        [DataMember(Name = "days", EmitDefaultValue = true)]
        public int? Days
        {
            get { return _Days; }
            set
            {
                _Days = value;
                _flagDays = true;
            }
        }
        private int? _Days;
        private bool _flagDays;

        /// <summary>
        /// Returns false as Days should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDays()
        {
            return _flagDays;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReceivedDocumentPaymentsListItemPaymentTerms {\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
