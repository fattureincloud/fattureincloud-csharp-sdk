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
    /// Issued document default values
    /// </summary>
    [DataContract(Name = "IssuedDocumentPreCreateInfo_default_values")]
    public partial class IssuedDocumentPreCreateInfoDefaultValues : IValidatableObject
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
        public IssuedDocumentPreCreateInfoDefaultValues(DocumentTemplate defaultTemplate = default(DocumentTemplate), DocumentTemplate dnTemplate = default(DocumentTemplate), DocumentTemplate aiTemplate = default(DocumentTemplate), string notes = default(string), decimal? rivalsa = default(decimal?), decimal? cassa = default(decimal?), decimal? withholdingTax = default(decimal?), decimal? withholdingTaxTaxable = default(decimal?), decimal? otherWithholdingTax = default(decimal?), bool? useGrossPrices = default(bool?), PaymentMethod paymentMethod = default(PaymentMethod))
        {
            this._DefaultTemplate = defaultTemplate;
            if (this.DefaultTemplate != null)
            {
                this._flagDefaultTemplate = true;
            }
            this._DnTemplate = dnTemplate;
            if (this.DnTemplate != null)
            {
                this._flagDnTemplate = true;
            }
            this._AiTemplate = aiTemplate;
            if (this.AiTemplate != null)
            {
                this._flagAiTemplate = true;
            }
            this._Notes = notes;
            if (this.Notes != null)
            {
                this._flagNotes = true;
            }
            this._Rivalsa = rivalsa;
            if (this.Rivalsa != null)
            {
                this._flagRivalsa = true;
            }
            this._Cassa = cassa;
            if (this.Cassa != null)
            {
                this._flagCassa = true;
            }
            this._WithholdingTax = withholdingTax;
            if (this.WithholdingTax != null)
            {
                this._flagWithholdingTax = true;
            }
            this._WithholdingTaxTaxable = withholdingTaxTaxable;
            if (this.WithholdingTaxTaxable != null)
            {
                this._flagWithholdingTaxTaxable = true;
            }
            this._OtherWithholdingTax = otherWithholdingTax;
            if (this.OtherWithholdingTax != null)
            {
                this._flagOtherWithholdingTax = true;
            }
            this._UseGrossPrices = useGrossPrices;
            if (this.UseGrossPrices != null)
            {
                this._flagUseGrossPrices = true;
            }
            this._PaymentMethod = paymentMethod;
            if (this.PaymentMethod != null)
            {
                this._flagPaymentMethod = true;
            }
        }

        /// <summary>
        /// Gets or Sets DefaultTemplate
        /// </summary>
        [DataMember(Name = "default_template", EmitDefaultValue = false)]
        public DocumentTemplate DefaultTemplate
        {
            get { return _DefaultTemplate; }
            set
            {
                _DefaultTemplate = value;
                _flagDefaultTemplate = true;
            }
        }
        private DocumentTemplate _DefaultTemplate;
        private bool _flagDefaultTemplate;

        /// <summary>
        /// Returns false as DefaultTemplate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDefaultTemplate()
        {
            return _flagDefaultTemplate;
        }
        /// <summary>
        /// Gets or Sets DnTemplate
        /// </summary>
        [DataMember(Name = "dn_template", EmitDefaultValue = false)]
        public DocumentTemplate DnTemplate
        {
            get { return _DnTemplate; }
            set
            {
                _DnTemplate = value;
                _flagDnTemplate = true;
            }
        }
        private DocumentTemplate _DnTemplate;
        private bool _flagDnTemplate;

        /// <summary>
        /// Returns false as DnTemplate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDnTemplate()
        {
            return _flagDnTemplate;
        }
        /// <summary>
        /// Gets or Sets AiTemplate
        /// </summary>
        [DataMember(Name = "ai_template", EmitDefaultValue = false)]
        public DocumentTemplate AiTemplate
        {
            get { return _AiTemplate; }
            set
            {
                _AiTemplate = value;
                _flagAiTemplate = true;
            }
        }
        private DocumentTemplate _AiTemplate;
        private bool _flagAiTemplate;

        /// <summary>
        /// Returns false as AiTemplate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAiTemplate()
        {
            return _flagAiTemplate;
        }
        /// <summary>
        /// Default notes.
        /// </summary>
        /// <value>Default notes.</value>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes
        {
            get { return _Notes; }
            set
            {
                _Notes = value;
                _flagNotes = true;
            }
        }
        private string _Notes;
        private bool _flagNotes;

        /// <summary>
        /// Returns false as Notes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNotes()
        {
            return _flagNotes;
        }
        /// <summary>
        /// Default rivalsa percentage.
        /// </summary>
        /// <value>Default rivalsa percentage.</value>
        [DataMember(Name = "rivalsa", EmitDefaultValue = true)]
        public decimal? Rivalsa
        {
            get { return _Rivalsa; }
            set
            {
                _Rivalsa = value;
                _flagRivalsa = true;
            }
        }
        private decimal? _Rivalsa;
        private bool _flagRivalsa;

        /// <summary>
        /// Returns false as Rivalsa should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRivalsa()
        {
            return _flagRivalsa;
        }
        /// <summary>
        /// Default cassa percentage.
        /// </summary>
        /// <value>Default cassa percentage.</value>
        [DataMember(Name = "cassa", EmitDefaultValue = true)]
        public decimal? Cassa
        {
            get { return _Cassa; }
            set
            {
                _Cassa = value;
                _flagCassa = true;
            }
        }
        private decimal? _Cassa;
        private bool _flagCassa;

        /// <summary>
        /// Returns false as Cassa should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCassa()
        {
            return _flagCassa;
        }
        /// <summary>
        /// Default withholding tax percentage.
        /// </summary>
        /// <value>Default withholding tax percentage.</value>
        [DataMember(Name = "withholding_tax", EmitDefaultValue = true)]
        public decimal? WithholdingTax
        {
            get { return _WithholdingTax; }
            set
            {
                _WithholdingTax = value;
                _flagWithholdingTax = true;
            }
        }
        private decimal? _WithholdingTax;
        private bool _flagWithholdingTax;

        /// <summary>
        /// Returns false as WithholdingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWithholdingTax()
        {
            return _flagWithholdingTax;
        }
        /// <summary>
        /// Default withholding tax taxable percentage.
        /// </summary>
        /// <value>Default withholding tax taxable percentage.</value>
        [DataMember(Name = "withholding_tax_taxable", EmitDefaultValue = true)]
        public decimal? WithholdingTaxTaxable
        {
            get { return _WithholdingTaxTaxable; }
            set
            {
                _WithholdingTaxTaxable = value;
                _flagWithholdingTaxTaxable = true;
            }
        }
        private decimal? _WithholdingTaxTaxable;
        private bool _flagWithholdingTaxTaxable;

        /// <summary>
        /// Returns false as WithholdingTaxTaxable should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWithholdingTaxTaxable()
        {
            return _flagWithholdingTaxTaxable;
        }
        /// <summary>
        /// Default other withholding tax percentage.
        /// </summary>
        /// <value>Default other withholding tax percentage.</value>
        [DataMember(Name = "other_withholding_tax", EmitDefaultValue = true)]
        public decimal? OtherWithholdingTax
        {
            get { return _OtherWithholdingTax; }
            set
            {
                _OtherWithholdingTax = value;
                _flagOtherWithholdingTax = true;
            }
        }
        private decimal? _OtherWithholdingTax;
        private bool _flagOtherWithholdingTax;

        /// <summary>
        /// Returns false as OtherWithholdingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOtherWithholdingTax()
        {
            return _flagOtherWithholdingTax;
        }
        /// <summary>
        /// Use gross price by default.
        /// </summary>
        /// <value>Use gross price by default.</value>
        [DataMember(Name = "use_gross_prices", EmitDefaultValue = true)]
        public bool? UseGrossPrices
        {
            get { return _UseGrossPrices; }
            set
            {
                _UseGrossPrices = value;
                _flagUseGrossPrices = true;
            }
        }
        private bool? _UseGrossPrices;
        private bool _flagUseGrossPrices;

        /// <summary>
        /// Returns false as UseGrossPrices should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUseGrossPrices()
        {
            return _flagUseGrossPrices;
        }
        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "payment_method", EmitDefaultValue = false)]
        public PaymentMethod PaymentMethod
        {
            get { return _PaymentMethod; }
            set
            {
                _PaymentMethod = value;
                _flagPaymentMethod = true;
            }
        }
        private PaymentMethod _PaymentMethod;
        private bool _flagPaymentMethod;

        /// <summary>
        /// Returns false as PaymentMethod should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentMethod()
        {
            return _flagPaymentMethod;
        }
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
