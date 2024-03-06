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
    /// IssuedDocumentPreCreateInfo
    /// </summary>
    [DataContract(Name = "IssuedDocumentPreCreateInfo")]
    public partial class IssuedDocumentPreCreateInfo : IEquatable<IssuedDocumentPreCreateInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedDocumentPreCreateInfo" /> class.
        /// </summary>
        /// <param name="numerations">numerations.</param>
        /// <param name="dnNumerations">dnNumerations.</param>
        /// <param name="defaultValues">defaultValues.</param>
        /// <param name="extraDataDefaultValues">extraDataDefaultValues.</param>
        /// <param name="itemsDefaultValues">itemsDefaultValues.</param>
        /// <param name="countriesList">Countries list.</param>
        /// <param name="currenciesList">Currencies list.</param>
        /// <param name="templatesList">Document templates list.</param>
        /// <param name="dnTemplatesList">Delivery note templates list.</param>
        /// <param name="aiTemplatesList">Accompanying invoice templates list.</param>
        /// <param name="paymentMethodsList">Payment methods list.</param>
        /// <param name="paymentAccountsList">Payment accounts list.</param>
        /// <param name="vatTypesList">Vat types list.</param>
        /// <param name="languagesList">Languages list.</param>
        public IssuedDocumentPreCreateInfo(Dictionary<string, Dictionary<string, int>> numerations = default(Dictionary<string, Dictionary<string, int>>), Dictionary<string, Dictionary<string, int>> dnNumerations = default(Dictionary<string, Dictionary<string, int>>), IssuedDocumentPreCreateInfoDefaultValues defaultValues = default(IssuedDocumentPreCreateInfoDefaultValues), IssuedDocumentPreCreateInfoExtraDataDefaultValues extraDataDefaultValues = default(IssuedDocumentPreCreateInfoExtraDataDefaultValues), IssuedDocumentPreCreateInfoItemsDefaultValues itemsDefaultValues = default(IssuedDocumentPreCreateInfoItemsDefaultValues), List<string> countriesList = default(List<string>), List<Currency> currenciesList = default(List<Currency>), List<DocumentTemplate> templatesList = default(List<DocumentTemplate>), List<DocumentTemplate> dnTemplatesList = default(List<DocumentTemplate>), List<DocumentTemplate> aiTemplatesList = default(List<DocumentTemplate>), List<PaymentMethod> paymentMethodsList = default(List<PaymentMethod>), List<PaymentAccount> paymentAccountsList = default(List<PaymentAccount>), List<VatType> vatTypesList = default(List<VatType>), List<Language> languagesList = default(List<Language>))
        {
            this._Numerations = numerations;
            if (this.Numerations != null)
            {
                this._flagNumerations = true;
            }
            this._DnNumerations = dnNumerations;
            if (this.DnNumerations != null)
            {
                this._flagDnNumerations = true;
            }
            this._DefaultValues = defaultValues;
            if (this.DefaultValues != null)
            {
                this._flagDefaultValues = true;
            }
            this._ExtraDataDefaultValues = extraDataDefaultValues;
            if (this.ExtraDataDefaultValues != null)
            {
                this._flagExtraDataDefaultValues = true;
            }
            this._ItemsDefaultValues = itemsDefaultValues;
            if (this.ItemsDefaultValues != null)
            {
                this._flagItemsDefaultValues = true;
            }
            this._CountriesList = countriesList;
            if (this.CountriesList != null)
            {
                this._flagCountriesList = true;
            }
            this._CurrenciesList = currenciesList;
            if (this.CurrenciesList != null)
            {
                this._flagCurrenciesList = true;
            }
            this._TemplatesList = templatesList;
            if (this.TemplatesList != null)
            {
                this._flagTemplatesList = true;
            }
            this._DnTemplatesList = dnTemplatesList;
            if (this.DnTemplatesList != null)
            {
                this._flagDnTemplatesList = true;
            }
            this._AiTemplatesList = aiTemplatesList;
            if (this.AiTemplatesList != null)
            {
                this._flagAiTemplatesList = true;
            }
            this._PaymentMethodsList = paymentMethodsList;
            if (this.PaymentMethodsList != null)
            {
                this._flagPaymentMethodsList = true;
            }
            this._PaymentAccountsList = paymentAccountsList;
            if (this.PaymentAccountsList != null)
            {
                this._flagPaymentAccountsList = true;
            }
            this._VatTypesList = vatTypesList;
            if (this.VatTypesList != null)
            {
                this._flagVatTypesList = true;
            }
            this._LanguagesList = languagesList;
            if (this.LanguagesList != null)
            {
                this._flagLanguagesList = true;
            }
        }

        /// <summary>
        /// Gets or Sets Numerations
        /// </summary>
        [DataMember(Name = "numerations", EmitDefaultValue = false)]
        public Dictionary<string, Dictionary<string, int>> Numerations
        {
            get { return _Numerations; }
            set
            {
                _Numerations = value;
                _flagNumerations = true;
            }
        }
        private Dictionary<string, Dictionary<string, int>> _Numerations;
        private bool _flagNumerations;

        /// <summary>
        /// Returns false as Numerations should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNumerations()
        {
            return _flagNumerations;
        }
        /// <summary>
        /// Gets or Sets DnNumerations
        /// </summary>
        [DataMember(Name = "dn_numerations", EmitDefaultValue = false)]
        public Dictionary<string, Dictionary<string, int>> DnNumerations
        {
            get { return _DnNumerations; }
            set
            {
                _DnNumerations = value;
                _flagDnNumerations = true;
            }
        }
        private Dictionary<string, Dictionary<string, int>> _DnNumerations;
        private bool _flagDnNumerations;

        /// <summary>
        /// Returns false as DnNumerations should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDnNumerations()
        {
            return _flagDnNumerations;
        }
        /// <summary>
        /// Gets or Sets DefaultValues
        /// </summary>
        [DataMember(Name = "default_values", EmitDefaultValue = true)]
        public IssuedDocumentPreCreateInfoDefaultValues DefaultValues
        {
            get { return _DefaultValues; }
            set
            {
                _DefaultValues = value;
                _flagDefaultValues = true;
            }
        }
        private IssuedDocumentPreCreateInfoDefaultValues _DefaultValues;
        private bool _flagDefaultValues;

        /// <summary>
        /// Returns false as DefaultValues should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDefaultValues()
        {
            return _flagDefaultValues;
        }
        /// <summary>
        /// Gets or Sets ExtraDataDefaultValues
        /// </summary>
        [DataMember(Name = "extra_data_default_values", EmitDefaultValue = true)]
        public IssuedDocumentPreCreateInfoExtraDataDefaultValues ExtraDataDefaultValues
        {
            get { return _ExtraDataDefaultValues; }
            set
            {
                _ExtraDataDefaultValues = value;
                _flagExtraDataDefaultValues = true;
            }
        }
        private IssuedDocumentPreCreateInfoExtraDataDefaultValues _ExtraDataDefaultValues;
        private bool _flagExtraDataDefaultValues;

        /// <summary>
        /// Returns false as ExtraDataDefaultValues should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExtraDataDefaultValues()
        {
            return _flagExtraDataDefaultValues;
        }
        /// <summary>
        /// Gets or Sets ItemsDefaultValues
        /// </summary>
        [DataMember(Name = "items_default_values", EmitDefaultValue = true)]
        public IssuedDocumentPreCreateInfoItemsDefaultValues ItemsDefaultValues
        {
            get { return _ItemsDefaultValues; }
            set
            {
                _ItemsDefaultValues = value;
                _flagItemsDefaultValues = true;
            }
        }
        private IssuedDocumentPreCreateInfoItemsDefaultValues _ItemsDefaultValues;
        private bool _flagItemsDefaultValues;

        /// <summary>
        /// Returns false as ItemsDefaultValues should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeItemsDefaultValues()
        {
            return _flagItemsDefaultValues;
        }
        /// <summary>
        /// Countries list
        /// </summary>
        /// <value>Countries list</value>
        [DataMember(Name = "countries_list", EmitDefaultValue = true)]
        public List<string> CountriesList
        {
            get { return _CountriesList; }
            set
            {
                _CountriesList = value;
                _flagCountriesList = true;
            }
        }
        private List<string> _CountriesList;
        private bool _flagCountriesList;

        /// <summary>
        /// Returns false as CountriesList should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCountriesList()
        {
            return _flagCountriesList;
        }
        /// <summary>
        /// Currencies list
        /// </summary>
        /// <value>Currencies list</value>
        [DataMember(Name = "currencies_list", EmitDefaultValue = true)]
        public List<Currency> CurrenciesList
        {
            get { return _CurrenciesList; }
            set
            {
                _CurrenciesList = value;
                _flagCurrenciesList = true;
            }
        }
        private List<Currency> _CurrenciesList;
        private bool _flagCurrenciesList;

        /// <summary>
        /// Returns false as CurrenciesList should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrenciesList()
        {
            return _flagCurrenciesList;
        }
        /// <summary>
        /// Document templates list
        /// </summary>
        /// <value>Document templates list</value>
        [DataMember(Name = "templates_list", EmitDefaultValue = true)]
        public List<DocumentTemplate> TemplatesList
        {
            get { return _TemplatesList; }
            set
            {
                _TemplatesList = value;
                _flagTemplatesList = true;
            }
        }
        private List<DocumentTemplate> _TemplatesList;
        private bool _flagTemplatesList;

        /// <summary>
        /// Returns false as TemplatesList should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTemplatesList()
        {
            return _flagTemplatesList;
        }
        /// <summary>
        /// Delivery note templates list
        /// </summary>
        /// <value>Delivery note templates list</value>
        [DataMember(Name = "dn_templates_list", EmitDefaultValue = true)]
        public List<DocumentTemplate> DnTemplatesList
        {
            get { return _DnTemplatesList; }
            set
            {
                _DnTemplatesList = value;
                _flagDnTemplatesList = true;
            }
        }
        private List<DocumentTemplate> _DnTemplatesList;
        private bool _flagDnTemplatesList;

        /// <summary>
        /// Returns false as DnTemplatesList should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDnTemplatesList()
        {
            return _flagDnTemplatesList;
        }
        /// <summary>
        /// Accompanying invoice templates list
        /// </summary>
        /// <value>Accompanying invoice templates list</value>
        [DataMember(Name = "ai_templates_list", EmitDefaultValue = true)]
        public List<DocumentTemplate> AiTemplatesList
        {
            get { return _AiTemplatesList; }
            set
            {
                _AiTemplatesList = value;
                _flagAiTemplatesList = true;
            }
        }
        private List<DocumentTemplate> _AiTemplatesList;
        private bool _flagAiTemplatesList;

        /// <summary>
        /// Returns false as AiTemplatesList should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAiTemplatesList()
        {
            return _flagAiTemplatesList;
        }
        /// <summary>
        /// Payment methods list
        /// </summary>
        /// <value>Payment methods list</value>
        [DataMember(Name = "payment_methods_list", EmitDefaultValue = true)]
        public List<PaymentMethod> PaymentMethodsList
        {
            get { return _PaymentMethodsList; }
            set
            {
                _PaymentMethodsList = value;
                _flagPaymentMethodsList = true;
            }
        }
        private List<PaymentMethod> _PaymentMethodsList;
        private bool _flagPaymentMethodsList;

        /// <summary>
        /// Returns false as PaymentMethodsList should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentMethodsList()
        {
            return _flagPaymentMethodsList;
        }
        /// <summary>
        /// Payment accounts list
        /// </summary>
        /// <value>Payment accounts list</value>
        [DataMember(Name = "payment_accounts_list", EmitDefaultValue = true)]
        public List<PaymentAccount> PaymentAccountsList
        {
            get { return _PaymentAccountsList; }
            set
            {
                _PaymentAccountsList = value;
                _flagPaymentAccountsList = true;
            }
        }
        private List<PaymentAccount> _PaymentAccountsList;
        private bool _flagPaymentAccountsList;

        /// <summary>
        /// Returns false as PaymentAccountsList should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentAccountsList()
        {
            return _flagPaymentAccountsList;
        }
        /// <summary>
        /// Vat types list
        /// </summary>
        /// <value>Vat types list</value>
        [DataMember(Name = "vat_types_list", EmitDefaultValue = true)]
        public List<VatType> VatTypesList
        {
            get { return _VatTypesList; }
            set
            {
                _VatTypesList = value;
                _flagVatTypesList = true;
            }
        }
        private List<VatType> _VatTypesList;
        private bool _flagVatTypesList;

        /// <summary>
        /// Returns false as VatTypesList should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVatTypesList()
        {
            return _flagVatTypesList;
        }
        /// <summary>
        /// Languages list
        /// </summary>
        /// <value>Languages list</value>
        [DataMember(Name = "languages_list", EmitDefaultValue = true)]
        public List<Language> LanguagesList
        {
            get { return _LanguagesList; }
            set
            {
                _LanguagesList = value;
                _flagLanguagesList = true;
            }
        }
        private List<Language> _LanguagesList;
        private bool _flagLanguagesList;

        /// <summary>
        /// Returns false as LanguagesList should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLanguagesList()
        {
            return _flagLanguagesList;
        }
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
            sb.Append("  LanguagesList: ").Append(LanguagesList).Append("\n");
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
                    this.Numerations != null &&
                    input.Numerations != null &&
                    this.Numerations.SequenceEqual(input.Numerations)
                ) &&
                (
                    this.DnNumerations == input.DnNumerations ||
                    this.DnNumerations != null &&
                    input.DnNumerations != null &&
                    this.DnNumerations.SequenceEqual(input.DnNumerations)
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
                ) &&
                (
                    this.LanguagesList == input.LanguagesList ||
                    this.LanguagesList != null &&
                    input.LanguagesList != null &&
                    this.LanguagesList.SequenceEqual(input.LanguagesList)
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
                if (this.LanguagesList != null)
                {
                    hashCode = (hashCode * 59) + this.LanguagesList.GetHashCode();
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
