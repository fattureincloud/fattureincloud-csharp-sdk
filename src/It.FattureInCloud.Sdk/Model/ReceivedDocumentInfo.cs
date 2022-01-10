/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.8
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
    /// ReceivedDocumentInfo
    /// </summary>
    [DataContract(Name = "ReceivedDocumentInfo")]
    public partial class ReceivedDocumentInfo : IEquatable<ReceivedDocumentInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivedDocumentInfo" /> class.
        /// </summary>
        /// <param name="defaultValues">defaultValues.</param>
        /// <param name="itemsDefaultValues">itemsDefaultValues.</param>
        /// <param name="countriesList">countriesList.</param>
        /// <param name="currenciesList">currenciesList.</param>
        /// <param name="categoriesList">categoriesList.</param>
        /// <param name="paymentAccountsList">paymentAccountsList.</param>
        /// <param name="vatTypesList">vatTypesList.</param>
        public ReceivedDocumentInfo(ReceivedDocumentInfoDefaultValues defaultValues = default(ReceivedDocumentInfoDefaultValues), ReceivedDocumentInfoItemsDefaultValues itemsDefaultValues = default(ReceivedDocumentInfoItemsDefaultValues), List<string> countriesList = default(List<string>), List<Currency> currenciesList = default(List<Currency>), List<string> categoriesList = default(List<string>), List<PaymentAccount> paymentAccountsList = default(List<PaymentAccount>), List<VatType> vatTypesList = default(List<VatType>))
        {
            this.DefaultValues = defaultValues;
            this.ItemsDefaultValues = itemsDefaultValues;
            this.CountriesList = countriesList;
            this.CurrenciesList = currenciesList;
            this.CategoriesList = categoriesList;
            this.PaymentAccountsList = paymentAccountsList;
            this.VatTypesList = vatTypesList;
        }

        /// <summary>
        /// Gets or Sets DefaultValues
        /// </summary>
        [DataMember(Name = "default_values", EmitDefaultValue = false)]
        public ReceivedDocumentInfoDefaultValues DefaultValues { get; set; }

        /// <summary>
        /// Gets or Sets ItemsDefaultValues
        /// </summary>
        [DataMember(Name = "items_default_values", EmitDefaultValue = false)]
        public ReceivedDocumentInfoItemsDefaultValues ItemsDefaultValues { get; set; }

        /// <summary>
        /// Gets or Sets CountriesList
        /// </summary>
        [DataMember(Name = "countries_list", EmitDefaultValue = false)]
        public List<string> CountriesList { get; set; }

        /// <summary>
        /// Gets or Sets CurrenciesList
        /// </summary>
        [DataMember(Name = "currencies_list", EmitDefaultValue = false)]
        public List<Currency> CurrenciesList { get; set; }

        /// <summary>
        /// Gets or Sets CategoriesList
        /// </summary>
        [DataMember(Name = "categories_list", EmitDefaultValue = false)]
        public List<string> CategoriesList { get; set; }

        /// <summary>
        /// Gets or Sets PaymentAccountsList
        /// </summary>
        [DataMember(Name = "payment_accounts_list", EmitDefaultValue = false)]
        public List<PaymentAccount> PaymentAccountsList { get; set; }

        /// <summary>
        /// Gets or Sets VatTypesList
        /// </summary>
        [DataMember(Name = "vat_types_list", EmitDefaultValue = false)]
        public List<VatType> VatTypesList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReceivedDocumentInfo {\n");
            sb.Append("  DefaultValues: ").Append(DefaultValues).Append("\n");
            sb.Append("  ItemsDefaultValues: ").Append(ItemsDefaultValues).Append("\n");
            sb.Append("  CountriesList: ").Append(CountriesList).Append("\n");
            sb.Append("  CurrenciesList: ").Append(CurrenciesList).Append("\n");
            sb.Append("  CategoriesList: ").Append(CategoriesList).Append("\n");
            sb.Append("  PaymentAccountsList: ").Append(PaymentAccountsList).Append("\n");
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
            return this.Equals(input as ReceivedDocumentInfo);
        }

        /// <summary>
        /// Returns true if ReceivedDocumentInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ReceivedDocumentInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceivedDocumentInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DefaultValues == input.DefaultValues ||
                    (this.DefaultValues != null &&
                    this.DefaultValues.Equals(input.DefaultValues))
                ) && 
                (
                    this.ItemsDefaultValues == input.ItemsDefaultValues ||
                    (this.ItemsDefaultValues != null &&
                    this.ItemsDefaultValues.Equals(input.ItemsDefaultValues))
                ) && 
                (
                    this.CountriesList == input.CountriesList ||
                    this.CountriesList != null &&
                    input.CountriesList != null &&
                    this.CountriesList.SequenceEqual(input.CountriesList)
                ) && 
                (
                    this.CurrenciesList == input.CurrenciesList ||
                    this.CurrenciesList != null &&
                    input.CurrenciesList != null &&
                    this.CurrenciesList.SequenceEqual(input.CurrenciesList)
                ) && 
                (
                    this.CategoriesList == input.CategoriesList ||
                    this.CategoriesList != null &&
                    input.CategoriesList != null &&
                    this.CategoriesList.SequenceEqual(input.CategoriesList)
                ) && 
                (
                    this.PaymentAccountsList == input.PaymentAccountsList ||
                    this.PaymentAccountsList != null &&
                    input.PaymentAccountsList != null &&
                    this.PaymentAccountsList.SequenceEqual(input.PaymentAccountsList)
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
                if (this.DefaultValues != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultValues.GetHashCode();
                }
                if (this.ItemsDefaultValues != null)
                {
                    hashCode = (hashCode * 59) + this.ItemsDefaultValues.GetHashCode();
                }
                if (this.CountriesList != null)
                {
                    hashCode = (hashCode * 59) + this.CountriesList.GetHashCode();
                }
                if (this.CurrenciesList != null)
                {
                    hashCode = (hashCode * 59) + this.CurrenciesList.GetHashCode();
                }
                if (this.CategoriesList != null)
                {
                    hashCode = (hashCode * 59) + this.CategoriesList.GetHashCode();
                }
                if (this.PaymentAccountsList != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentAccountsList.GetHashCode();
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
