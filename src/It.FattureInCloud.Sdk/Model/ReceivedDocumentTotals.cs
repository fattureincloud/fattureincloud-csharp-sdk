/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.27
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
    /// ReceivedDocumentTotals
    /// </summary>
    [DataContract(Name = "ReceivedDocumentTotals")]
    public partial class ReceivedDocumentTotals : IEquatable<ReceivedDocumentTotals>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivedDocumentTotals" /> class.
        /// </summary>
        /// <param name="amountNet">Total net amount..</param>
        /// <param name="amountVat">Total vat amount..</param>
        /// <param name="amountGross">Total gross amount..</param>
        /// <param name="amountWithholdingTax">Total withholding tax amount..</param>
        /// <param name="amountOtherWithholdingTax">Total other withholding tax amount..</param>
        /// <param name="amountDue">Total amount due..</param>
        /// <param name="paymentsSum">Payments sum..</param>
        public ReceivedDocumentTotals(decimal? amountNet = default(decimal?), decimal? amountVat = default(decimal?), decimal? amountGross = default(decimal?), decimal? amountWithholdingTax = default(decimal?), decimal? amountOtherWithholdingTax = default(decimal?), decimal? amountDue = default(decimal?), decimal? paymentsSum = default(decimal?))
        {
            this._AmountNet = amountNet;
            if (this.AmountNet != null)
            {
                this._flagAmountNet = true;
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
            this._AmountWithholdingTax = amountWithholdingTax;
            if (this.AmountWithholdingTax != null)
            {
                this._flagAmountWithholdingTax = true;
            }
            this._AmountOtherWithholdingTax = amountOtherWithholdingTax;
            if (this.AmountOtherWithholdingTax != null)
            {
                this._flagAmountOtherWithholdingTax = true;
            }
            this._AmountDue = amountDue;
            if (this.AmountDue != null)
            {
                this._flagAmountDue = true;
            }
            this._PaymentsSum = paymentsSum;
            if (this.PaymentsSum != null)
            {
                this._flagPaymentsSum = true;
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
        /// Total gross amount.
        /// </summary>
        /// <value>Total gross amount.</value>
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
        /// Total withholding tax amount.
        /// </summary>
        /// <value>Total withholding tax amount.</value>
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
        /// Total other withholding tax amount.
        /// </summary>
        /// <value>Total other withholding tax amount.</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReceivedDocumentTotals {\n");
            sb.Append("  AmountNet: ").Append(AmountNet).Append("\n");
            sb.Append("  AmountVat: ").Append(AmountVat).Append("\n");
            sb.Append("  AmountGross: ").Append(AmountGross).Append("\n");
            sb.Append("  AmountWithholdingTax: ").Append(AmountWithholdingTax).Append("\n");
            sb.Append("  AmountOtherWithholdingTax: ").Append(AmountOtherWithholdingTax).Append("\n");
            sb.Append("  AmountDue: ").Append(AmountDue).Append("\n");
            sb.Append("  PaymentsSum: ").Append(PaymentsSum).Append("\n");
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
            return this.Equals(input as ReceivedDocumentTotals);
        }

        /// <summary>
        /// Returns true if ReceivedDocumentTotals instances are equal
        /// </summary>
        /// <param name="input">Instance of ReceivedDocumentTotals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceivedDocumentTotals input)
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
                    this.AmountWithholdingTax == input.AmountWithholdingTax ||
                    (this.AmountWithholdingTax != null &&
                    this.AmountWithholdingTax.Equals(input.AmountWithholdingTax))
                ) &&
                (
                    this.AmountOtherWithholdingTax == input.AmountOtherWithholdingTax ||
                    (this.AmountOtherWithholdingTax != null &&
                    this.AmountOtherWithholdingTax.Equals(input.AmountOtherWithholdingTax))
                ) &&
                (
                    this.AmountDue == input.AmountDue ||
                    (this.AmountDue != null &&
                    this.AmountDue.Equals(input.AmountDue))
                ) &&
                (
                    this.PaymentsSum == input.PaymentsSum ||
                    (this.PaymentsSum != null &&
                    this.PaymentsSum.Equals(input.PaymentsSum))
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
                if (this.AmountVat != null)
                {
                    hashCode = (hashCode * 59) + this.AmountVat.GetHashCode();
                }
                if (this.AmountGross != null)
                {
                    hashCode = (hashCode * 59) + this.AmountGross.GetHashCode();
                }
                if (this.AmountWithholdingTax != null)
                {
                    hashCode = (hashCode * 59) + this.AmountWithholdingTax.GetHashCode();
                }
                if (this.AmountOtherWithholdingTax != null)
                {
                    hashCode = (hashCode * 59) + this.AmountOtherWithholdingTax.GetHashCode();
                }
                if (this.AmountDue != null)
                {
                    hashCode = (hashCode * 59) + this.AmountDue.GetHashCode();
                }
                if (this.PaymentsSum != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentsSum.GetHashCode();
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
