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
    /// Default values for the document.
    /// </summary>
    [DataContract(Name = "IssuedDocumentPreCreateInfo_default_values")]
    public partial class IssuedDocumentPreCreateInfoDefaultValues : IEquatable<IssuedDocumentPreCreateInfoDefaultValues>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedDocumentPreCreateInfoDefaultValues" /> class.
        /// </summary>
        /// <param name="defaultTemplate">defaultTemplate.</param>
        /// <param name="dnTemplate">dnTemplate.</param>
        /// <param name="aiTemplate">aiTemplate.</param>
        /// <param name="notes">Default notes..</param>
        /// <param name="rivalsa">Default rivalsa percentage..</param>
        /// <param name="cassa">Default cassa percentage..</param>
        /// <param name="withholdingTax">Default withholding tax percentage..</param>
        /// <param name="withholdingTaxTaxable">Default withholding tax taxable percentage..</param>
        /// <param name="otherWithholdingTax">Default other withholding tax percentage..</param>
        /// <param name="useGrossPrices">Use gross price by default..</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        public IssuedDocumentPreCreateInfoDefaultValues(DocumentTemplate defaultTemplate = default(DocumentTemplate), DocumentTemplate dnTemplate = default(DocumentTemplate), DocumentTemplate aiTemplate = default(DocumentTemplate), string notes = default(string), decimal rivalsa = default(decimal), decimal cassa = default(decimal), decimal withholdingTax = default(decimal), decimal withholdingTaxTaxable = default(decimal), decimal otherWithholdingTax = default(decimal), bool useGrossPrices = default(bool), PaymentMethod paymentMethod = default(PaymentMethod))
        {
            this.DefaultTemplate = defaultTemplate;
            this.DnTemplate = dnTemplate;
            this.AiTemplate = aiTemplate;
            this.Notes = notes;
            this.Rivalsa = rivalsa;
            this.Cassa = cassa;
            this.WithholdingTax = withholdingTax;
            this.WithholdingTaxTaxable = withholdingTaxTaxable;
            this.OtherWithholdingTax = otherWithholdingTax;
            this.UseGrossPrices = useGrossPrices;
            this.PaymentMethod = paymentMethod;
        }

        /// <summary>
        /// Gets or Sets DefaultTemplate
        /// </summary>
        [DataMember(Name = "default_template", EmitDefaultValue = false)]
        public DocumentTemplate DefaultTemplate { get; set; }

        /// <summary>
        /// Gets or Sets DnTemplate
        /// </summary>
        [DataMember(Name = "dn_template", EmitDefaultValue = false)]
        public DocumentTemplate DnTemplate { get; set; }

        /// <summary>
        /// Gets or Sets AiTemplate
        /// </summary>
        [DataMember(Name = "ai_template", EmitDefaultValue = false)]
        public DocumentTemplate AiTemplate { get; set; }

        /// <summary>
        /// Default notes.
        /// </summary>
        /// <value>Default notes.</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Default rivalsa percentage.
        /// </summary>
        /// <value>Default rivalsa percentage.</value>
        [DataMember(Name = "rivalsa", EmitDefaultValue = false)]
        public decimal Rivalsa { get; set; }

        /// <summary>
        /// Default cassa percentage.
        /// </summary>
        /// <value>Default cassa percentage.</value>
        [DataMember(Name = "cassa", EmitDefaultValue = false)]
        public decimal Cassa { get; set; }

        /// <summary>
        /// Default withholding tax percentage.
        /// </summary>
        /// <value>Default withholding tax percentage.</value>
        [DataMember(Name = "withholding_tax", EmitDefaultValue = false)]
        public decimal WithholdingTax { get; set; }

        /// <summary>
        /// Default withholding tax taxable percentage.
        /// </summary>
        /// <value>Default withholding tax taxable percentage.</value>
        [DataMember(Name = "withholding_tax_taxable", EmitDefaultValue = false)]
        public decimal WithholdingTaxTaxable { get; set; }

        /// <summary>
        /// Default other withholding tax percentage.
        /// </summary>
        /// <value>Default other withholding tax percentage.</value>
        [DataMember(Name = "other_withholding_tax", EmitDefaultValue = false)]
        public decimal OtherWithholdingTax { get; set; }

        /// <summary>
        /// Use gross price by default.
        /// </summary>
        /// <value>Use gross price by default.</value>
        [DataMember(Name = "use_gross_prices", EmitDefaultValue = true)]
        public bool UseGrossPrices { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "payment_method", EmitDefaultValue = false)]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssuedDocumentPreCreateInfoDefaultValues {\n");
            sb.Append("  DefaultTemplate: ").Append(DefaultTemplate).Append("\n");
            sb.Append("  DnTemplate: ").Append(DnTemplate).Append("\n");
            sb.Append("  AiTemplate: ").Append(AiTemplate).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Rivalsa: ").Append(Rivalsa).Append("\n");
            sb.Append("  Cassa: ").Append(Cassa).Append("\n");
            sb.Append("  WithholdingTax: ").Append(WithholdingTax).Append("\n");
            sb.Append("  WithholdingTaxTaxable: ").Append(WithholdingTaxTaxable).Append("\n");
            sb.Append("  OtherWithholdingTax: ").Append(OtherWithholdingTax).Append("\n");
            sb.Append("  UseGrossPrices: ").Append(UseGrossPrices).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
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
            return this.Equals(input as IssuedDocumentPreCreateInfoDefaultValues);
        }

        /// <summary>
        /// Returns true if IssuedDocumentPreCreateInfoDefaultValues instances are equal
        /// </summary>
        /// <param name="input">Instance of IssuedDocumentPreCreateInfoDefaultValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuedDocumentPreCreateInfoDefaultValues input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DefaultTemplate == input.DefaultTemplate ||
                    (this.DefaultTemplate != null &&
                    this.DefaultTemplate.Equals(input.DefaultTemplate))
                ) && 
                (
                    this.DnTemplate == input.DnTemplate ||
                    (this.DnTemplate != null &&
                    this.DnTemplate.Equals(input.DnTemplate))
                ) && 
                (
                    this.AiTemplate == input.AiTemplate ||
                    (this.AiTemplate != null &&
                    this.AiTemplate.Equals(input.AiTemplate))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.Rivalsa == input.Rivalsa ||
                    this.Rivalsa.Equals(input.Rivalsa)
                ) && 
                (
                    this.Cassa == input.Cassa ||
                    this.Cassa.Equals(input.Cassa)
                ) && 
                (
                    this.WithholdingTax == input.WithholdingTax ||
                    this.WithholdingTax.Equals(input.WithholdingTax)
                ) && 
                (
                    this.WithholdingTaxTaxable == input.WithholdingTaxTaxable ||
                    this.WithholdingTaxTaxable.Equals(input.WithholdingTaxTaxable)
                ) && 
                (
                    this.OtherWithholdingTax == input.OtherWithholdingTax ||
                    this.OtherWithholdingTax.Equals(input.OtherWithholdingTax)
                ) && 
                (
                    this.UseGrossPrices == input.UseGrossPrices ||
                    this.UseGrossPrices.Equals(input.UseGrossPrices)
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
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
                if (this.DefaultTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultTemplate.GetHashCode();
                }
                if (this.DnTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.DnTemplate.GetHashCode();
                }
                if (this.AiTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.AiTemplate.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rivalsa.GetHashCode();
                hashCode = (hashCode * 59) + this.Cassa.GetHashCode();
                hashCode = (hashCode * 59) + this.WithholdingTax.GetHashCode();
                hashCode = (hashCode * 59) + this.WithholdingTaxTaxable.GetHashCode();
                hashCode = (hashCode * 59) + this.OtherWithholdingTax.GetHashCode();
                hashCode = (hashCode * 59) + this.UseGrossPrices.GetHashCode();
                if (this.PaymentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethod.GetHashCode();
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
