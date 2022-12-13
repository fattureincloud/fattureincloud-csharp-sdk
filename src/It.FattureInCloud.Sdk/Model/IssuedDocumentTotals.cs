/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.24
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
    /// IssuedDocumentTotals
    /// </summary>
    [DataContract(Name = "IssuedDocumentTotals")]
    public partial class IssuedDocumentTotals : IEquatable<IssuedDocumentTotals>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedDocumentTotals" /> class.
        /// </summary>
        /// <param name="amountNet">Total net amount..</param>
        /// <param name="amountRivalsa">Rivalsa amount..</param>
        /// <param name="amountNetWithRivalsa">Net amount with rivalsa..</param>
        /// <param name="amountCassa">Cassa amount..</param>
        /// <param name="taxableAmount">Taxable amount..</param>
        /// <param name="notTaxableAmount">Not taxable amount..</param>
        /// <param name="amountVat">Total vat amount..</param>
        /// <param name="amountGross">Total grosas amount..</param>
        /// <param name="taxableAmountWithholdingTax">Taxable withholding tax amount..</param>
        /// <param name="amountWithholdingTax">Withholding tax amount..</param>
        /// <param name="taxableAmountOtherWithholdingTax">Other withholding tax taxable amount..</param>
        /// <param name="amountOtherWithholdingTax">Other withholding tax amount..</param>
        /// <param name="stampDuty">Stamp duty value [0 if not present]..</param>
        /// <param name="amountDue">Total amount due..</param>
        /// <param name="isEnasarcoMaximalExceeded">isEnasarcoMaximalExceeded.</param>
        /// <param name="paymentsSum">Payments sum..</param>
        /// <param name="vatList">vatList.</param>
        public IssuedDocumentTotals(decimal? amountNet = default(decimal?), decimal? amountRivalsa = default(decimal?), decimal? amountNetWithRivalsa = default(decimal?), decimal? amountCassa = default(decimal?), decimal? taxableAmount = default(decimal?), decimal? notTaxableAmount = default(decimal?), decimal? amountVat = default(decimal?), decimal? amountGross = default(decimal?), decimal? taxableAmountWithholdingTax = default(decimal?), decimal? amountWithholdingTax = default(decimal?), decimal? taxableAmountOtherWithholdingTax = default(decimal?), decimal? amountOtherWithholdingTax = default(decimal?), decimal? stampDuty = default(decimal?), decimal? amountDue = default(decimal?), bool? isEnasarcoMaximalExceeded = default(bool?), decimal? paymentsSum = default(decimal?), Dictionary<string, VatItem> vatList = default(Dictionary<string, VatItem>))
        {
            this._AmountNet = amountNet;
            if (this.AmountNet != null)
            {
                this._flagAmountNet = true;
            }
            this._AmountRivalsa = amountRivalsa;
            if (this.AmountRivalsa != null)
            {
                this._flagAmountRivalsa = true;
            }
            this._AmountNetWithRivalsa = amountNetWithRivalsa;
            if (this.AmountNetWithRivalsa != null)
            {
                this._flagAmountNetWithRivalsa = true;
            }
            this._AmountCassa = amountCassa;
            if (this.AmountCassa != null)
            {
                this._flagAmountCassa = true;
            }
            this._TaxableAmount = taxableAmount;
            if (this.TaxableAmount != null)
            {
                this._flagTaxableAmount = true;
            }
            this._NotTaxableAmount = notTaxableAmount;
            if (this.NotTaxableAmount != null)
            {
                this._flagNotTaxableAmount = true;
            }
            this._AmountVat = amountVat;
            if (this.AmountVat != null)
            {
                this._flagAmountVat = true;
            }
            this._AmountGross = amountGross;
            if (this.AmountGross != null)
            {
                this._flagAmountGross = true;
            }
            this._TaxableAmountWithholdingTax = taxableAmountWithholdingTax;
            if (this.TaxableAmountWithholdingTax != null)
            {
                this._flagTaxableAmountWithholdingTax = true;
            }
            this._AmountWithholdingTax = amountWithholdingTax;
            if (this.AmountWithholdingTax != null)
            {
                this._flagAmountWithholdingTax = true;
            }
            this._TaxableAmountOtherWithholdingTax = taxableAmountOtherWithholdingTax;
            if (this.TaxableAmountOtherWithholdingTax != null)
            {
                this._flagTaxableAmountOtherWithholdingTax = true;
            }
            this._AmountOtherWithholdingTax = amountOtherWithholdingTax;
            if (this.AmountOtherWithholdingTax != null)
            {
                this._flagAmountOtherWithholdingTax = true;
            }
            this._StampDuty = stampDuty;
            if (this.StampDuty != null)
            {
                this._flagStampDuty = true;
            }
            this._AmountDue = amountDue;
            if (this.AmountDue != null)
            {
                this._flagAmountDue = true;
            }
            this._IsEnasarcoMaximalExceeded = isEnasarcoMaximalExceeded;
            if (this.IsEnasarcoMaximalExceeded != null)
            {
                this._flagIsEnasarcoMaximalExceeded = true;
            }
            this._PaymentsSum = paymentsSum;
            if (this.PaymentsSum != null)
            {
                this._flagPaymentsSum = true;
            }
            this._VatList = vatList;
            if (this.VatList != null)
            {
                this._flagVatList = true;
            }
        }

        /// <summary>
        /// Total net amount.
        /// </summary>
        /// <value>Total net amount.</value>
        [DataMember(Name = "amount_net", EmitDefaultValue = true)]
        public decimal? AmountNet
        {
            get { return _AmountNet; }
            set
            {
                _AmountNet = value;
                _flagAmountNet = true;
            }
        }
        private decimal? _AmountNet;
        private bool _flagAmountNet;

        /// <summary>
        /// Returns false as AmountNet should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountNet()
        {
            return _flagAmountNet;
        }
        /// <summary>
        /// Rivalsa amount.
        /// </summary>
        /// <value>Rivalsa amount.</value>
        [DataMember(Name = "amount_rivalsa", EmitDefaultValue = true)]
        public decimal? AmountRivalsa
        {
            get { return _AmountRivalsa; }
            set
            {
                _AmountRivalsa = value;
                _flagAmountRivalsa = true;
            }
        }
        private decimal? _AmountRivalsa;
        private bool _flagAmountRivalsa;

        /// <summary>
        /// Returns false as AmountRivalsa should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountRivalsa()
        {
            return _flagAmountRivalsa;
        }
        /// <summary>
        /// Net amount with rivalsa.
        /// </summary>
        /// <value>Net amount with rivalsa.</value>
        [DataMember(Name = "amount_net_with_rivalsa", EmitDefaultValue = true)]
        public decimal? AmountNetWithRivalsa
        {
            get { return _AmountNetWithRivalsa; }
            set
            {
                _AmountNetWithRivalsa = value;
                _flagAmountNetWithRivalsa = true;
            }
        }
        private decimal? _AmountNetWithRivalsa;
        private bool _flagAmountNetWithRivalsa;

        /// <summary>
        /// Returns false as AmountNetWithRivalsa should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountNetWithRivalsa()
        {
            return _flagAmountNetWithRivalsa;
        }
        /// <summary>
        /// Cassa amount.
        /// </summary>
        /// <value>Cassa amount.</value>
        [DataMember(Name = "amount_cassa", EmitDefaultValue = true)]
        public decimal? AmountCassa
        {
            get { return _AmountCassa; }
            set
            {
                _AmountCassa = value;
                _flagAmountCassa = true;
            }
        }
        private decimal? _AmountCassa;
        private bool _flagAmountCassa;

        /// <summary>
        /// Returns false as AmountCassa should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountCassa()
        {
            return _flagAmountCassa;
        }
        /// <summary>
        /// Taxable amount.
        /// </summary>
        /// <value>Taxable amount.</value>
        [DataMember(Name = "taxable_amount", EmitDefaultValue = true)]
        public decimal? TaxableAmount
        {
            get { return _TaxableAmount; }
            set
            {
                _TaxableAmount = value;
                _flagTaxableAmount = true;
            }
        }
        private decimal? _TaxableAmount;
        private bool _flagTaxableAmount;

        /// <summary>
        /// Returns false as TaxableAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTaxableAmount()
        {
            return _flagTaxableAmount;
        }
        /// <summary>
        /// Not taxable amount.
        /// </summary>
        /// <value>Not taxable amount.</value>
        [DataMember(Name = "not_taxable_amount", EmitDefaultValue = true)]
        public decimal? NotTaxableAmount
        {
            get { return _NotTaxableAmount; }
            set
            {
                _NotTaxableAmount = value;
                _flagNotTaxableAmount = true;
            }
        }
        private decimal? _NotTaxableAmount;
        private bool _flagNotTaxableAmount;

        /// <summary>
        /// Returns false as NotTaxableAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNotTaxableAmount()
        {
            return _flagNotTaxableAmount;
        }
        /// <summary>
        /// Total vat amount.
        /// </summary>
        /// <value>Total vat amount.</value>
        [DataMember(Name = "amount_vat", EmitDefaultValue = true)]
        public decimal? AmountVat
        {
            get { return _AmountVat; }
            set
            {
                _AmountVat = value;
                _flagAmountVat = true;
            }
        }
        private decimal? _AmountVat;
        private bool _flagAmountVat;

        /// <summary>
        /// Returns false as AmountVat should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountVat()
        {
            return _flagAmountVat;
        }
        /// <summary>
        /// Total grosas amount.
        /// </summary>
        /// <value>Total grosas amount.</value>
        [DataMember(Name = "amount_gross", EmitDefaultValue = true)]
        public decimal? AmountGross
        {
            get { return _AmountGross; }
            set
            {
                _AmountGross = value;
                _flagAmountGross = true;
            }
        }
        private decimal? _AmountGross;
        private bool _flagAmountGross;

        /// <summary>
        /// Returns false as AmountGross should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountGross()
        {
            return _flagAmountGross;
        }
        /// <summary>
        /// Taxable withholding tax amount.
        /// </summary>
        /// <value>Taxable withholding tax amount.</value>
        [DataMember(Name = "taxable_amount_withholding_tax", EmitDefaultValue = true)]
        public decimal? TaxableAmountWithholdingTax
        {
            get { return _TaxableAmountWithholdingTax; }
            set
            {
                _TaxableAmountWithholdingTax = value;
                _flagTaxableAmountWithholdingTax = true;
            }
        }
        private decimal? _TaxableAmountWithholdingTax;
        private bool _flagTaxableAmountWithholdingTax;

        /// <summary>
        /// Returns false as TaxableAmountWithholdingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTaxableAmountWithholdingTax()
        {
            return _flagTaxableAmountWithholdingTax;
        }
        /// <summary>
        /// Withholding tax amount.
        /// </summary>
        /// <value>Withholding tax amount.</value>
        [DataMember(Name = "amount_withholding_tax", EmitDefaultValue = true)]
        public decimal? AmountWithholdingTax
        {
            get { return _AmountWithholdingTax; }
            set
            {
                _AmountWithholdingTax = value;
                _flagAmountWithholdingTax = true;
            }
        }
        private decimal? _AmountWithholdingTax;
        private bool _flagAmountWithholdingTax;

        /// <summary>
        /// Returns false as AmountWithholdingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountWithholdingTax()
        {
            return _flagAmountWithholdingTax;
        }
        /// <summary>
        /// Other withholding tax taxable amount.
        /// </summary>
        /// <value>Other withholding tax taxable amount.</value>
        [DataMember(Name = "taxable_amount_other_withholding_tax", EmitDefaultValue = true)]
        public decimal? TaxableAmountOtherWithholdingTax
        {
            get { return _TaxableAmountOtherWithholdingTax; }
            set
            {
                _TaxableAmountOtherWithholdingTax = value;
                _flagTaxableAmountOtherWithholdingTax = true;
            }
        }
        private decimal? _TaxableAmountOtherWithholdingTax;
        private bool _flagTaxableAmountOtherWithholdingTax;

        /// <summary>
        /// Returns false as TaxableAmountOtherWithholdingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTaxableAmountOtherWithholdingTax()
        {
            return _flagTaxableAmountOtherWithholdingTax;
        }
        /// <summary>
        /// Other withholding tax amount.
        /// </summary>
        /// <value>Other withholding tax amount.</value>
        [DataMember(Name = "amount_other_withholding_tax", EmitDefaultValue = true)]
        public decimal? AmountOtherWithholdingTax
        {
            get { return _AmountOtherWithholdingTax; }
            set
            {
                _AmountOtherWithholdingTax = value;
                _flagAmountOtherWithholdingTax = true;
            }
        }
        private decimal? _AmountOtherWithholdingTax;
        private bool _flagAmountOtherWithholdingTax;

        /// <summary>
        /// Returns false as AmountOtherWithholdingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountOtherWithholdingTax()
        {
            return _flagAmountOtherWithholdingTax;
        }
        /// <summary>
        /// Stamp duty value [0 if not present].
        /// </summary>
        /// <value>Stamp duty value [0 if not present].</value>
        [DataMember(Name = "stamp_duty", EmitDefaultValue = true)]
        public decimal? StampDuty
        {
            get { return _StampDuty; }
            set
            {
                _StampDuty = value;
                _flagStampDuty = true;
            }
        }
        private decimal? _StampDuty;
        private bool _flagStampDuty;

        /// <summary>
        /// Returns false as StampDuty should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStampDuty()
        {
            return _flagStampDuty;
        }
        /// <summary>
        /// Total amount due.
        /// </summary>
        /// <value>Total amount due.</value>
        [DataMember(Name = "amount_due", EmitDefaultValue = true)]
        public decimal? AmountDue
        {
            get { return _AmountDue; }
            set
            {
                _AmountDue = value;
                _flagAmountDue = true;
            }
        }
        private decimal? _AmountDue;
        private bool _flagAmountDue;

        /// <summary>
        /// Returns false as AmountDue should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountDue()
        {
            return _flagAmountDue;
        }
        /// <summary>
        /// Gets or Sets IsEnasarcoMaximalExceeded
        /// </summary>
        [DataMember(Name = "is_enasarco_maximal_exceeded", EmitDefaultValue = true)]
        public bool? IsEnasarcoMaximalExceeded
        {
            get { return _IsEnasarcoMaximalExceeded; }
            set
            {
                _IsEnasarcoMaximalExceeded = value;
                _flagIsEnasarcoMaximalExceeded = true;
            }
        }
        private bool? _IsEnasarcoMaximalExceeded;
        private bool _flagIsEnasarcoMaximalExceeded;

        /// <summary>
        /// Returns false as IsEnasarcoMaximalExceeded should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsEnasarcoMaximalExceeded()
        {
            return _flagIsEnasarcoMaximalExceeded;
        }
        /// <summary>
        /// Payments sum.
        /// </summary>
        /// <value>Payments sum.</value>
        [DataMember(Name = "payments_sum", EmitDefaultValue = true)]
        public decimal? PaymentsSum
        {
            get { return _PaymentsSum; }
            set
            {
                _PaymentsSum = value;
                _flagPaymentsSum = true;
            }
        }
        private decimal? _PaymentsSum;
        private bool _flagPaymentsSum;

        /// <summary>
        /// Returns false as PaymentsSum should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentsSum()
        {
            return _flagPaymentsSum;
        }
        /// <summary>
        /// Gets or Sets VatList
        /// </summary>
        [DataMember(Name = "vat_list", EmitDefaultValue = false)]
        public Dictionary<string, VatItem> VatList
        {
            get { return _VatList; }
            set
            {
                _VatList = value;
                _flagVatList = true;
            }
        }
        private Dictionary<string, VatItem> _VatList;
        private bool _flagVatList;

        /// <summary>
        /// Returns false as VatList should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVatList()
        {
            return _flagVatList;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssuedDocumentTotals {\n");
            sb.Append("  AmountNet: ").Append(AmountNet).Append("\n");
            sb.Append("  AmountRivalsa: ").Append(AmountRivalsa).Append("\n");
            sb.Append("  AmountNetWithRivalsa: ").Append(AmountNetWithRivalsa).Append("\n");
            sb.Append("  AmountCassa: ").Append(AmountCassa).Append("\n");
            sb.Append("  TaxableAmount: ").Append(TaxableAmount).Append("\n");
            sb.Append("  NotTaxableAmount: ").Append(NotTaxableAmount).Append("\n");
            sb.Append("  AmountVat: ").Append(AmountVat).Append("\n");
            sb.Append("  AmountGross: ").Append(AmountGross).Append("\n");
            sb.Append("  TaxableAmountWithholdingTax: ").Append(TaxableAmountWithholdingTax).Append("\n");
            sb.Append("  AmountWithholdingTax: ").Append(AmountWithholdingTax).Append("\n");
            sb.Append("  TaxableAmountOtherWithholdingTax: ").Append(TaxableAmountOtherWithholdingTax).Append("\n");
            sb.Append("  AmountOtherWithholdingTax: ").Append(AmountOtherWithholdingTax).Append("\n");
            sb.Append("  StampDuty: ").Append(StampDuty).Append("\n");
            sb.Append("  AmountDue: ").Append(AmountDue).Append("\n");
            sb.Append("  IsEnasarcoMaximalExceeded: ").Append(IsEnasarcoMaximalExceeded).Append("\n");
            sb.Append("  PaymentsSum: ").Append(PaymentsSum).Append("\n");
            sb.Append("  VatList: ").Append(VatList).Append("\n");
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
            return this.Equals(input as IssuedDocumentTotals);
        }

        /// <summary>
        /// Returns true if IssuedDocumentTotals instances are equal
        /// </summary>
        /// <param name="input">Instance of IssuedDocumentTotals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuedDocumentTotals input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AmountNet == input.AmountNet ||
                    (this.AmountNet != null &&
                    this.AmountNet.Equals(input.AmountNet))
                ) &&
                (
                    this.AmountRivalsa == input.AmountRivalsa ||
                    (this.AmountRivalsa != null &&
                    this.AmountRivalsa.Equals(input.AmountRivalsa))
                ) &&
                (
                    this.AmountNetWithRivalsa == input.AmountNetWithRivalsa ||
                    (this.AmountNetWithRivalsa != null &&
                    this.AmountNetWithRivalsa.Equals(input.AmountNetWithRivalsa))
                ) &&
                (
                    this.AmountCassa == input.AmountCassa ||
                    (this.AmountCassa != null &&
                    this.AmountCassa.Equals(input.AmountCassa))
                ) &&
                (
                    this.TaxableAmount == input.TaxableAmount ||
                    (this.TaxableAmount != null &&
                    this.TaxableAmount.Equals(input.TaxableAmount))
                ) &&
                (
                    this.NotTaxableAmount == input.NotTaxableAmount ||
                    (this.NotTaxableAmount != null &&
                    this.NotTaxableAmount.Equals(input.NotTaxableAmount))
                ) &&
                (
                    this.AmountVat == input.AmountVat ||
                    (this.AmountVat != null &&
                    this.AmountVat.Equals(input.AmountVat))
                ) &&
                (
                    this.AmountGross == input.AmountGross ||
                    (this.AmountGross != null &&
                    this.AmountGross.Equals(input.AmountGross))
                ) &&
                (
                    this.TaxableAmountWithholdingTax == input.TaxableAmountWithholdingTax ||
                    (this.TaxableAmountWithholdingTax != null &&
                    this.TaxableAmountWithholdingTax.Equals(input.TaxableAmountWithholdingTax))
                ) &&
                (
                    this.AmountWithholdingTax == input.AmountWithholdingTax ||
                    (this.AmountWithholdingTax != null &&
                    this.AmountWithholdingTax.Equals(input.AmountWithholdingTax))
                ) &&
                (
                    this.TaxableAmountOtherWithholdingTax == input.TaxableAmountOtherWithholdingTax ||
                    (this.TaxableAmountOtherWithholdingTax != null &&
                    this.TaxableAmountOtherWithholdingTax.Equals(input.TaxableAmountOtherWithholdingTax))
                ) &&
                (
                    this.AmountOtherWithholdingTax == input.AmountOtherWithholdingTax ||
                    (this.AmountOtherWithholdingTax != null &&
                    this.AmountOtherWithholdingTax.Equals(input.AmountOtherWithholdingTax))
                ) &&
                (
                    this.StampDuty == input.StampDuty ||
                    (this.StampDuty != null &&
                    this.StampDuty.Equals(input.StampDuty))
                ) &&
                (
                    this.AmountDue == input.AmountDue ||
                    (this.AmountDue != null &&
                    this.AmountDue.Equals(input.AmountDue))
                ) &&
                (
                    this.IsEnasarcoMaximalExceeded == input.IsEnasarcoMaximalExceeded ||
                    (this.IsEnasarcoMaximalExceeded != null &&
                    this.IsEnasarcoMaximalExceeded.Equals(input.IsEnasarcoMaximalExceeded))
                ) &&
                (
                    this.PaymentsSum == input.PaymentsSum ||
                    (this.PaymentsSum != null &&
                    this.PaymentsSum.Equals(input.PaymentsSum))
                ) &&
                (
                    this.VatList == input.VatList ||
                    this.VatList != null &&
                    input.VatList != null &&
                    this.VatList.SequenceEqual(input.VatList)
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
                if (this.AmountNet != null)
                {
                    hashCode = (hashCode * 59) + this.AmountNet.GetHashCode();
                }
                if (this.AmountRivalsa != null)
                {
                    hashCode = (hashCode * 59) + this.AmountRivalsa.GetHashCode();
                }
                if (this.AmountNetWithRivalsa != null)
                {
                    hashCode = (hashCode * 59) + this.AmountNetWithRivalsa.GetHashCode();
                }
                if (this.AmountCassa != null)
                {
                    hashCode = (hashCode * 59) + this.AmountCassa.GetHashCode();
                }
                if (this.TaxableAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TaxableAmount.GetHashCode();
                }
                if (this.NotTaxableAmount != null)
                {
                    hashCode = (hashCode * 59) + this.NotTaxableAmount.GetHashCode();
                }
                if (this.AmountVat != null)
                {
                    hashCode = (hashCode * 59) + this.AmountVat.GetHashCode();
                }
                if (this.AmountGross != null)
                {
                    hashCode = (hashCode * 59) + this.AmountGross.GetHashCode();
                }
                if (this.TaxableAmountWithholdingTax != null)
                {
                    hashCode = (hashCode * 59) + this.TaxableAmountWithholdingTax.GetHashCode();
                }
                if (this.AmountWithholdingTax != null)
                {
                    hashCode = (hashCode * 59) + this.AmountWithholdingTax.GetHashCode();
                }
                if (this.TaxableAmountOtherWithholdingTax != null)
                {
                    hashCode = (hashCode * 59) + this.TaxableAmountOtherWithholdingTax.GetHashCode();
                }
                if (this.AmountOtherWithholdingTax != null)
                {
                    hashCode = (hashCode * 59) + this.AmountOtherWithholdingTax.GetHashCode();
                }
                if (this.StampDuty != null)
                {
                    hashCode = (hashCode * 59) + this.StampDuty.GetHashCode();
                }
                if (this.AmountDue != null)
                {
                    hashCode = (hashCode * 59) + this.AmountDue.GetHashCode();
                }
                if (this.IsEnasarcoMaximalExceeded != null)
                {
                    hashCode = (hashCode * 59) + this.IsEnasarcoMaximalExceeded.GetHashCode();
                }
                if (this.PaymentsSum != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentsSum.GetHashCode();
                }
                if (this.VatList != null)
                {
                    hashCode = (hashCode * 59) + this.VatList.GetHashCode();
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
