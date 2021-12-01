/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.6
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
    /// CashbookEntryOutData
    /// </summary>
    [DataContract(Name = "CashbookEntryOutData")]
    public partial class CashbookEntryOutData : IEquatable<CashbookEntryOutData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CashbookEntryOutData" /> class.
        /// </summary>
        /// <param name="amountOut">Total amount out..</param>
        /// <param name="paymentAccountOut">paymentAccountOut.</param>
        public CashbookEntryOutData(decimal amountOut = default(decimal), PaymentAccount paymentAccountOut = default(PaymentAccount))
        {
            this.AmountOut = amountOut;
            this.PaymentAccountOut = paymentAccountOut;
        }

        /// <summary>
        /// Total amount out.
        /// </summary>
        /// <value>Total amount out.</value>
        [DataMember(Name = "amount_out", EmitDefaultValue = false)]
        public decimal AmountOut { get; set; }

        /// <summary>
        /// Gets or Sets PaymentAccountOut
        /// </summary>
        [DataMember(Name = "payment_account_out", EmitDefaultValue = true)]
        public PaymentAccount PaymentAccountOut { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CashbookEntryOutData {\n");
            sb.Append("  AmountOut: ").Append(AmountOut).Append("\n");
            sb.Append("  PaymentAccountOut: ").Append(PaymentAccountOut).Append("\n");
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
            return this.Equals(input as CashbookEntryOutData);
        }

        /// <summary>
        /// Returns true if CashbookEntryOutData instances are equal
        /// </summary>
        /// <param name="input">Instance of CashbookEntryOutData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashbookEntryOutData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AmountOut == input.AmountOut ||
                    this.AmountOut.Equals(input.AmountOut)
                ) && 
                (
                    this.PaymentAccountOut == input.PaymentAccountOut ||
                    (this.PaymentAccountOut != null &&
                    this.PaymentAccountOut.Equals(input.PaymentAccountOut))
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
                hashCode = hashCode * 59 + this.AmountOut.GetHashCode();
                if (this.PaymentAccountOut != null)
                    hashCode = hashCode * 59 + this.PaymentAccountOut.GetHashCode();
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
