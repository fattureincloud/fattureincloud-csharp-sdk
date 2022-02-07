/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.11
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
    /// IssuedDocumentPreCreateInfo
    /// </summary>
    [DataContract(Name = "IssuedDocumentPreCreateInfo")]
    public partial class IssuedDocumentPreCreateInfo : IEquatable<IssuedDocumentPreCreateInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedDocumentPreCreateInfo" /> class.
        /// </summary>
        /// <param name="numerations">Next numbers by year and numeration name (for the given document type)..</param>
        /// <param name="dnNumerations">Next numbers by year and numeration name (for delivery_notes)..</param>
        /// <param name="defaultValues">defaultValues.</param>
        /// <param name="extraDataDefaultValues">extraDataDefaultValues.</param>
        /// <param name="itemsDefaultValues">itemsDefaultValues.</param>
        /// <param name="countriesList">Countries list..</param>
        /// <param name="currenciesList">Currencies list..</param>
        /// <param name="templatesList">Document templates list..</param>
        /// <param name="dnTemplatesList">Delivery note templates list..</param>
        /// <param name="aiTemplatesList">Accompanying invoice templates list..</param>
        /// <param name="paymentMethodsList">Payment methods list..</param>
        /// <param name="paymentAccountsList">Payment accounts list..</param>
        /// <param name="vatTypesList">Vat types list..</param>
        public IssuedDocumentPreCreateInfo(Object numerations = default(Object), Object dnNumerations = default(Object), IssuedDocumentPreCreateInfoDefaultValues defaultValues = default(IssuedDocumentPreCreateInfoDefaultValues), IssuedDocumentPreCreateInfoExtraDataDefaultValues extraDataDefaultValues = default(IssuedDocumentPreCreateInfoExtraDataDefaultValues), IssuedDocumentPreCreateInfoItemsDefaultValues itemsDefaultValues = default(IssuedDocumentPreCreateInfoItemsDefaultValues), List<string> countriesList = default(List<string>), List<Currency> currenciesList = default(List<Currency>), List<DocumentTemplate> templatesList = default(List<DocumentTemplate>), List<DocumentTemplate> dnTemplatesList = default(List<DocumentTemplate>), List<DocumentTemplate> aiTemplatesList = default(List<DocumentTemplate>), List<PaymentMethod> paymentMethodsList = default(List<PaymentMethod>), List<PaymentAccount> paymentAccountsList = default(List<PaymentAccount>), List<VatType> vatTypesList = default(List<VatType>))
        {
            this.Numerations = numerations;
            this.DnNumerations = dnNumerations;
            this.DefaultValues = defaultValues;
            this.ExtraDataDefaultValues = extraDataDefaultValues;
            this.ItemsDefaultValues = itemsDefaultValues;
            this.CountriesList = countriesList;
            this.CurrenciesList = currenciesList;
            this.TemplatesList = templatesList;
            this.DnTemplatesList = dnTemplatesList;
            this.AiTemplatesList = aiTemplatesList;
            this.PaymentMethodsList = paymentMethodsList;
            this.PaymentAccountsList = paymentAccountsList;
            this.VatTypesList = vatTypesList;
        }

        /// <summary>
        /// Next numbers by year and numeration name (for the given document type).
        /// </summary>
        /// <value>Next numbers by year and numeration name (for the given document type).</value>
        [DataMember(Name = "numerations", EmitDefaultValue = false)]
        public Object Numerations { get; set; }

        /// <summary>
        /// Next numbers by year and numeration name (for delivery_notes).
        /// </summary>
        /// <value>Next numbers by year and numeration name (for delivery_notes).</value>
        [DataMember(Name = "dn_numerations", EmitDefaultValue = false)]
        public Object DnNumerations { get; set; }

        /// <summary>
        /// Gets or Sets DefaultValues
        /// </summary>
        [DataMember(Name = "default_values", EmitDefaultValue = false)]
        public IssuedDocumentPreCreateInfoDefaultValues DefaultValues { get; set; }

        /// <summary>
        /// Gets or Sets ExtraDataDefaultValues
        /// </summary>
        [DataMember(Name = "extra_data_default_values", EmitDefaultValue = false)]
        public IssuedDocumentPreCreateInfoExtraDataDefaultValues ExtraDataDefaultValues { get; set; }

        /// <summary>
        /// Gets or Sets ItemsDefaultValues
        /// </summary>
        [DataMember(Name = "items_default_values", EmitDefaultValue = false)]
        public IssuedDocumentPreCreateInfoItemsDefaultValues ItemsDefaultValues { get; set; }

        /// <summary>
        /// Countries list.
        /// </summary>
        /// <value>Countries list.</value>
        [DataMember(Name = "countries_list", EmitDefaultValue = false)]
        public List<string> CountriesList { get; set; }

        /// <summary>
        /// Currencies list.
        /// </summary>
        /// <value>Currencies list.</value>
        [DataMember(Name = "currencies_list", EmitDefaultValue = false)]
        public List<Currency> CurrenciesList { get; set; }

        /// <summary>
        /// Document templates list.
        /// </summary>
        /// <value>Document templates list.</value>
        [DataMember(Name = "templates_list", EmitDefaultValue = false)]
        public List<DocumentTemplate> TemplatesList { get; set; }

        /// <summary>
        /// Delivery note templates list.
        /// </summary>
        /// <value>Delivery note templates list.</value>
        [DataMember(Name = "dn_templates_list", EmitDefaultValue = false)]
        public List<DocumentTemplate> DnTemplatesList { get; set; }

        /// <summary>
        /// Accompanying invoice templates list.
        /// </summary>
        /// <value>Accompanying invoice templates list.</value>
        [DataMember(Name = "ai_templates_list", EmitDefaultValue = false)]
        public List<DocumentTemplate> AiTemplatesList { get; set; }

        /// <summary>
        /// Payment methods list.
        /// </summary>
        /// <value>Payment methods list.</value>
        [DataMember(Name = "payment_methods_list", EmitDefaultValue = false)]
        public List<PaymentMethod> PaymentMethodsList { get; set; }

        /// <summary>
        /// Payment accounts list.
        /// </summary>
        /// <value>Payment accounts list.</value>
        [DataMember(Name = "payment_accounts_list", EmitDefaultValue = false)]
        public List<PaymentAccount> PaymentAccountsList { get; set; }

        /// <summary>
        /// Vat types list.
        /// </summary>
        /// <value>Vat types list.</value>
        [DataMember(Name = "vat_types_list", EmitDefaultValue = false)]
        public List<VatType> VatTypesList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssuedDocumentPreCreateInfo {\n");
            sb.Append("  Numerations: ").Append(Numerations).Append("\n");
            sb.Append("  DnNumerations: ").Append(DnNumerations).Append("\n");
            sb.Append("  DefaultValues: ").Append(DefaultValues).Append("\n");
            sb.Append("  ExtraDataDefaultValues: ").Append(ExtraDataDefaultValues).Append("\n");
            sb.Append("  ItemsDefaultValues: ").Append(ItemsDefaultValues).Append("\n");
            sb.Append("  CountriesList: ").Append(CountriesList).Append("\n");
            sb.Append("  CurrenciesList: ").Append(CurrenciesList).Append("\n");
            sb.Append("  TemplatesList: ").Append(TemplatesList).Append("\n");
            sb.Append("  DnTemplatesList: ").Append(DnTemplatesList).Append("\n");
            sb.Append("  AiTemplatesList: ").Append(AiTemplatesList).Append("\n");
            sb.Append("  PaymentMethodsList: ").Append(PaymentMethodsList).Append("\n");
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
            return this.Equals(input as IssuedDocumentPreCreateInfo);
        }

        /// <summary>
        /// Returns true if IssuedDocumentPreCreateInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of IssuedDocumentPreCreateInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuedDocumentPreCreateInfo input)
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
                    this.DnNumerations == input.DnNumerations ||
                    (this.DnNumerations != null &&
                    this.DnNumerations.Equals(input.DnNumerations))
                ) && 
                (
                    this.DefaultValues == input.DefaultValues ||
                    (this.DefaultValues != null &&
                    this.DefaultValues.Equals(input.DefaultValues))
                ) && 
                (
                    this.ExtraDataDefaultValues == input.ExtraDataDefaultValues ||
                    (this.ExtraDataDefaultValues != null &&
                    this.ExtraDataDefaultValues.Equals(input.ExtraDataDefaultValues))
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
                    this.TemplatesList == input.TemplatesList ||
                    this.TemplatesList != null &&
                    input.TemplatesList != null &&
                    this.TemplatesList.SequenceEqual(input.TemplatesList)
                ) && 
                (
                    this.DnTemplatesList == input.DnTemplatesList ||
                    this.DnTemplatesList != null &&
                    input.DnTemplatesList != null &&
                    this.DnTemplatesList.SequenceEqual(input.DnTemplatesList)
                ) && 
                (
                    this.AiTemplatesList == input.AiTemplatesList ||
                    this.AiTemplatesList != null &&
                    input.AiTemplatesList != null &&
                    this.AiTemplatesList.SequenceEqual(input.AiTemplatesList)
                ) && 
                (
                    this.PaymentMethodsList == input.PaymentMethodsList ||
                    this.PaymentMethodsList != null &&
                    input.PaymentMethodsList != null &&
                    this.PaymentMethodsList.SequenceEqual(input.PaymentMethodsList)
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
                if (this.Numerations != null)
                {
                    hashCode = (hashCode * 59) + this.Numerations.GetHashCode();
                }
                if (this.DnNumerations != null)
                {
                    hashCode = (hashCode * 59) + this.DnNumerations.GetHashCode();
                }
                if (this.DefaultValues != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultValues.GetHashCode();
                }
                if (this.ExtraDataDefaultValues != null)
                {
                    hashCode = (hashCode * 59) + this.ExtraDataDefaultValues.GetHashCode();
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
                if (this.TemplatesList != null)
                {
                    hashCode = (hashCode * 59) + this.TemplatesList.GetHashCode();
                }
                if (this.DnTemplatesList != null)
                {
                    hashCode = (hashCode * 59) + this.DnTemplatesList.GetHashCode();
                }
                if (this.AiTemplatesList != null)
                {
                    hashCode = (hashCode * 59) + this.AiTemplatesList.GetHashCode();
                }
                if (this.PaymentMethodsList != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethodsList.GetHashCode();
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
