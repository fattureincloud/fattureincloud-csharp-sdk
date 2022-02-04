/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.10
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
    /// ReceiptPreCreateInfo
    /// </summary>
    [DataContract(Name = "ReceiptPreCreateInfo")]
    public partial class ReceiptPreCreateInfo : IEquatable<ReceiptPreCreateInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptPreCreateInfo" /> class.
        /// </summary>
        /// <param name="numerations">Next number by year, receipt type and numeration name..</param>
        /// <param name="numerationsList">List of series used in the past..</param>
        /// <param name="rcCentersList">List of revenue centers used in the past..</param>
        /// <param name="paymentAccountsList">User payment accounts list..</param>
        /// <param name="categoriesList">List of categories used in the past..</param>
        /// <param name="vatTypesList">List of user vat types with the default 22%, 10%, 4% and 0% vats..</param>
        public ReceiptPreCreateInfo(Object numerations = default(Object), List<string> numerationsList = default(List<string>), List<string> rcCentersList = default(List<string>), List<PaymentAccount> paymentAccountsList = default(List<PaymentAccount>), List<string> categoriesList = default(List<string>), List<VatType> vatTypesList = default(List<VatType>))
        {
            this.Numerations = numerations;
            this.NumerationsList = numerationsList;
            this.RcCentersList = rcCentersList;
            this.PaymentAccountsList = paymentAccountsList;
            this.CategoriesList = categoriesList;
            this.VatTypesList = vatTypesList;
        }

        /// <summary>
        /// Next number by year, receipt type and numeration name.
        /// </summary>
        /// <value>Next number by year, receipt type and numeration name.</value>
        [DataMember(Name = "numerations", EmitDefaultValue = false)]
        public Object Numerations { get; set; }

        /// <summary>
        /// List of series used in the past.
        /// </summary>
        /// <value>List of series used in the past.</value>
        [DataMember(Name = "numerations_list", EmitDefaultValue = false)]
        public List<string> NumerationsList { get; set; }

        /// <summary>
        /// List of revenue centers used in the past.
        /// </summary>
        /// <value>List of revenue centers used in the past.</value>
        [DataMember(Name = "rc_centers_list", EmitDefaultValue = false)]
        public List<string> RcCentersList { get; set; }

        /// <summary>
        /// User payment accounts list.
        /// </summary>
        /// <value>User payment accounts list.</value>
        [DataMember(Name = "payment_accounts_list", EmitDefaultValue = false)]
        public List<PaymentAccount> PaymentAccountsList { get; set; }

        /// <summary>
        /// List of categories used in the past.
        /// </summary>
        /// <value>List of categories used in the past.</value>
        [DataMember(Name = "categories_list", EmitDefaultValue = false)]
        public List<string> CategoriesList { get; set; }

        /// <summary>
        /// List of user vat types with the default 22%, 10%, 4% and 0% vats.
        /// </summary>
        /// <value>List of user vat types with the default 22%, 10%, 4% and 0% vats.</value>
        [DataMember(Name = "vat_types_list", EmitDefaultValue = false)]
        public List<VatType> VatTypesList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReceiptPreCreateInfo {\n");
            sb.Append("  Numerations: ").Append(Numerations).Append("\n");
            sb.Append("  NumerationsList: ").Append(NumerationsList).Append("\n");
            sb.Append("  RcCentersList: ").Append(RcCentersList).Append("\n");
            sb.Append("  PaymentAccountsList: ").Append(PaymentAccountsList).Append("\n");
            sb.Append("  CategoriesList: ").Append(CategoriesList).Append("\n");
            sb.Append("  VatTypesList: ").Append(VatTypesList).Append("\n");
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
            return this.Equals(input as ReceiptPreCreateInfo);
        }

        /// <summary>
        /// Returns true if ReceiptPreCreateInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ReceiptPreCreateInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceiptPreCreateInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Numerations == input.Numerations ||
                    (this.Numerations != null &&
                    this.Numerations.Equals(input.Numerations))
                ) && 
                (
                    this.NumerationsList == input.NumerationsList ||
                    this.NumerationsList != null &&
                    input.NumerationsList != null &&
                    this.NumerationsList.SequenceEqual(input.NumerationsList)
                ) && 
                (
                    this.RcCentersList == input.RcCentersList ||
                    this.RcCentersList != null &&
                    input.RcCentersList != null &&
                    this.RcCentersList.SequenceEqual(input.RcCentersList)
                ) && 
                (
                    this.PaymentAccountsList == input.PaymentAccountsList ||
                    this.PaymentAccountsList != null &&
                    input.PaymentAccountsList != null &&
                    this.PaymentAccountsList.SequenceEqual(input.PaymentAccountsList)
                ) && 
                (
                    this.CategoriesList == input.CategoriesList ||
                    this.CategoriesList != null &&
                    input.CategoriesList != null &&
                    this.CategoriesList.SequenceEqual(input.CategoriesList)
                ) && 
                (
                    this.VatTypesList == input.VatTypesList ||
                    this.VatTypesList != null &&
                    input.VatTypesList != null &&
                    this.VatTypesList.SequenceEqual(input.VatTypesList)
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
                if (this.Numerations != null)
                {
                    hashCode = (hashCode * 59) + this.Numerations.GetHashCode();
                }
                if (this.NumerationsList != null)
                {
                    hashCode = (hashCode * 59) + this.NumerationsList.GetHashCode();
                }
                if (this.RcCentersList != null)
                {
                    hashCode = (hashCode * 59) + this.RcCentersList.GetHashCode();
                }
                if (this.PaymentAccountsList != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentAccountsList.GetHashCode();
                }
                if (this.CategoriesList != null)
                {
                    hashCode = (hashCode * 59) + this.CategoriesList.GetHashCode();
                }
                if (this.VatTypesList != null)
                {
                    hashCode = (hashCode * 59) + this.VatTypesList.GetHashCode();
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
