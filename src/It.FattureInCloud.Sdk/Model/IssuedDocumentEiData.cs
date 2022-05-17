/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.16
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
    /// E-invoice data. [Only if e_invoice&#x3D;true]
    /// </summary>
    [DataContract(Name = "IssuedDocument_ei_data")]
    public partial class IssuedDocumentEiData : IEquatable<IssuedDocumentEiData>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets VatKind
        /// </summary>

        [DataMember(Name = "vat_kind", EmitDefaultValue = true)]
        public VatKind? VatKind
        {
            get { return _VatKind; }
            set
            {
                _VatKind = value;
                _flagVatKind = true;
            }
        }
        private VatKind? _VatKind;
        private bool _flagVatKind;

        /// <summary>
        /// Returns false as VatKind should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVatKind()
        {
            return _flagVatKind;
        }

        /// <summary>
        /// Gets or Sets OriginalDocumentType
        /// </summary>

        [DataMember(Name = "original_document_type", EmitDefaultValue = true)]
        public OriginalDocumentType? OriginalDocumentType
        {
            get { return _OriginalDocumentType; }
            set
            {
                _OriginalDocumentType = value;
                _flagOriginalDocumentType = true;
            }
        }
        private OriginalDocumentType? _OriginalDocumentType;
        private bool _flagOriginalDocumentType;

        /// <summary>
        /// Returns false as OriginalDocumentType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOriginalDocumentType()
        {
            return _flagOriginalDocumentType;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedDocumentEiData" /> class.
        /// </summary>
        /// <param name="vatKind">vatKind.</param>
        /// <param name="originalDocumentType">originalDocumentType.</param>
        /// <param name="odNumber">Original document number..</param>
        /// <param name="odDate">Original document date..</param>
        /// <param name="cig">CIG..</param>
        /// <param name="cup">CUP..</param>
        /// <param name="paymentMethod">Payment method (see https://www.fatturapa.gov.it/export/documenti/fatturapa/v1.2.1/Rappresentazione-tabellare-fattura-ordinaria.pdf for the accepted values of ModalitaPagamento)..</param>
        /// <param name="bankName">Bank name..</param>
        /// <param name="bankIban">IBAN..</param>
        /// <param name="bankBeneficiary">Bank beneficiary..</param>
        /// <param name="invoiceNumber">Invoice number..</param>
        /// <param name="invoiceDate">Invoice date..</param>
        public IssuedDocumentEiData(VatKind? vatKind = default(VatKind?), OriginalDocumentType? originalDocumentType = default(OriginalDocumentType?), string odNumber = default(string), DateTime? odDate = default(DateTime?), string cig = default(string), string cup = default(string), string paymentMethod = default(string), string bankName = default(string), string bankIban = default(string), string bankBeneficiary = default(string), string invoiceNumber = default(string), DateTime? invoiceDate = default(DateTime?))
        {
            this._VatKind = vatKind;
            if (this.VatKind != null) this._flagVatKind = true;
            this._OriginalDocumentType = originalDocumentType;
            if (this.OriginalDocumentType != null) this._flagOriginalDocumentType = true;
            this._OdNumber = odNumber;
            if (this.OdNumber != null) this._flagOdNumber = true;
            this._OdDate = odDate;
            if (this.OdDate != null) this._flagOdDate = true;
            this._Cig = cig;
            if (this.Cig != null) this._flagCig = true;
            this._Cup = cup;
            if (this.Cup != null) this._flagCup = true;
            this._PaymentMethod = paymentMethod;
            if (this.PaymentMethod != null) this._flagPaymentMethod = true;
            this._BankName = bankName;
            if (this.BankName != null) this._flagBankName = true;
            this._BankIban = bankIban;
            if (this.BankIban != null) this._flagBankIban = true;
            this._BankBeneficiary = bankBeneficiary;
            if (this.BankBeneficiary != null) this._flagBankBeneficiary = true;
            this._InvoiceNumber = invoiceNumber;
            if (this.InvoiceNumber != null) this._flagInvoiceNumber = true;
            this._InvoiceDate = invoiceDate;
            if (this.InvoiceDate != null) this._flagInvoiceDate = true;
        }

        /// <summary>
        /// Original document number.
        /// </summary>
        /// <value>Original document number.</value>
        [DataMember(Name = "od_number", EmitDefaultValue = true)]
        public string OdNumber
        {
            get { return _OdNumber; }
            set
            {
                _OdNumber = value;
                _flagOdNumber = true;
            }
        }
        private string _OdNumber;
        private bool _flagOdNumber;

        /// <summary>
        /// Returns false as OdNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOdNumber()
        {
            return _flagOdNumber;
        }
        /// <summary>
        /// Original document date.
        /// </summary>
        /// <value>Original document date.</value>
        [JsonConverter(typeof(OpenAPIDateConverter))]
        [DataMember(Name = "od_date", EmitDefaultValue = true)]
        public DateTime? OdDate
        {
            get { return _OdDate; }
            set
            {
                _OdDate = value;
                _flagOdDate = true;
            }
        }
        private DateTime? _OdDate;
        private bool _flagOdDate;

        /// <summary>
        /// Returns false as OdDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOdDate()
        {
            return _flagOdDate;
        }
        /// <summary>
        /// CIG.
        /// </summary>
        /// <value>CIG.</value>
        [DataMember(Name = "cig", EmitDefaultValue = true)]
        public string Cig
        {
            get { return _Cig; }
            set
            {
                _Cig = value;
                _flagCig = true;
            }
        }
        private string _Cig;
        private bool _flagCig;

        /// <summary>
        /// Returns false as Cig should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCig()
        {
            return _flagCig;
        }
        /// <summary>
        /// CUP.
        /// </summary>
        /// <value>CUP.</value>
        [DataMember(Name = "cup", EmitDefaultValue = true)]
        public string Cup
        {
            get { return _Cup; }
            set
            {
                _Cup = value;
                _flagCup = true;
            }
        }
        private string _Cup;
        private bool _flagCup;

        /// <summary>
        /// Returns false as Cup should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCup()
        {
            return _flagCup;
        }
        /// <summary>
        /// Payment method (see https://www.fatturapa.gov.it/export/documenti/fatturapa/v1.2.1/Rappresentazione-tabellare-fattura-ordinaria.pdf for the accepted values of ModalitaPagamento).
        /// </summary>
        /// <value>Payment method (see https://www.fatturapa.gov.it/export/documenti/fatturapa/v1.2.1/Rappresentazione-tabellare-fattura-ordinaria.pdf for the accepted values of ModalitaPagamento).</value>
        [DataMember(Name = "payment_method", EmitDefaultValue = true)]
        public string PaymentMethod
        {
            get { return _PaymentMethod; }
            set
            {
                _PaymentMethod = value;
                _flagPaymentMethod = true;
            }
        }
        private string _PaymentMethod;
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
        /// Bank name.
        /// </summary>
        /// <value>Bank name.</value>
        [DataMember(Name = "bank_name", EmitDefaultValue = true)]
        public string BankName
        {
            get { return _BankName; }
            set
            {
                _BankName = value;
                _flagBankName = true;
            }
        }
        private string _BankName;
        private bool _flagBankName;

        /// <summary>
        /// Returns false as BankName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBankName()
        {
            return _flagBankName;
        }
        /// <summary>
        /// IBAN.
        /// </summary>
        /// <value>IBAN.</value>
        [DataMember(Name = "bank_iban", EmitDefaultValue = true)]
        public string BankIban
        {
            get { return _BankIban; }
            set
            {
                _BankIban = value;
                _flagBankIban = true;
            }
        }
        private string _BankIban;
        private bool _flagBankIban;

        /// <summary>
        /// Returns false as BankIban should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBankIban()
        {
            return _flagBankIban;
        }
        /// <summary>
        /// Bank beneficiary.
        /// </summary>
        /// <value>Bank beneficiary.</value>
        [DataMember(Name = "bank_beneficiary", EmitDefaultValue = true)]
        public string BankBeneficiary
        {
            get { return _BankBeneficiary; }
            set
            {
                _BankBeneficiary = value;
                _flagBankBeneficiary = true;
            }
        }
        private string _BankBeneficiary;
        private bool _flagBankBeneficiary;

        /// <summary>
        /// Returns false as BankBeneficiary should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBankBeneficiary()
        {
            return _flagBankBeneficiary;
        }
        /// <summary>
        /// Invoice number.
        /// </summary>
        /// <value>Invoice number.</value>
        [DataMember(Name = "invoice_number", EmitDefaultValue = true)]
        public string InvoiceNumber
        {
            get { return _InvoiceNumber; }
            set
            {
                _InvoiceNumber = value;
                _flagInvoiceNumber = true;
            }
        }
        private string _InvoiceNumber;
        private bool _flagInvoiceNumber;

        /// <summary>
        /// Returns false as InvoiceNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInvoiceNumber()
        {
            return _flagInvoiceNumber;
        }
        /// <summary>
        /// Invoice date.
        /// </summary>
        /// <value>Invoice date.</value>
        [JsonConverter(typeof(OpenAPIDateConverter))]
        [DataMember(Name = "invoice_date", EmitDefaultValue = true)]
        public DateTime? InvoiceDate
        {
            get { return _InvoiceDate; }
            set
            {
                _InvoiceDate = value;
                _flagInvoiceDate = true;
            }
        }
        private DateTime? _InvoiceDate;
        private bool _flagInvoiceDate;

        /// <summary>
        /// Returns false as InvoiceDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInvoiceDate()
        {
            return _flagInvoiceDate;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssuedDocumentEiData {\n");
            sb.Append("  VatKind: ").Append(VatKind).Append("\n");
            sb.Append("  OriginalDocumentType: ").Append(OriginalDocumentType).Append("\n");
            sb.Append("  OdNumber: ").Append(OdNumber).Append("\n");
            sb.Append("  OdDate: ").Append(OdDate).Append("\n");
            sb.Append("  Cig: ").Append(Cig).Append("\n");
            sb.Append("  Cup: ").Append(Cup).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  BankIban: ").Append(BankIban).Append("\n");
            sb.Append("  BankBeneficiary: ").Append(BankBeneficiary).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
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
            return this.Equals(input as IssuedDocumentEiData);
        }

        /// <summary>
        /// Returns true if IssuedDocumentEiData instances are equal
        /// </summary>
        /// <param name="input">Instance of IssuedDocumentEiData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuedDocumentEiData input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.VatKind == input.VatKind ||
                    this.VatKind.Equals(input.VatKind)
                ) &&
                (
                    this.OriginalDocumentType == input.OriginalDocumentType ||
                    this.OriginalDocumentType.Equals(input.OriginalDocumentType)
                ) &&
                (
                    this.OdNumber == input.OdNumber ||
                    (this.OdNumber != null &&
                    this.OdNumber.Equals(input.OdNumber))
                ) &&
                (
                    this.OdDate == input.OdDate ||
                    (this.OdDate != null &&
                    this.OdDate.Equals(input.OdDate))
                ) &&
                (
                    this.Cig == input.Cig ||
                    (this.Cig != null &&
                    this.Cig.Equals(input.Cig))
                ) &&
                (
                    this.Cup == input.Cup ||
                    (this.Cup != null &&
                    this.Cup.Equals(input.Cup))
                ) &&
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) &&
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) &&
                (
                    this.BankIban == input.BankIban ||
                    (this.BankIban != null &&
                    this.BankIban.Equals(input.BankIban))
                ) &&
                (
                    this.BankBeneficiary == input.BankBeneficiary ||
                    (this.BankBeneficiary != null &&
                    this.BankBeneficiary.Equals(input.BankBeneficiary))
                ) &&
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) &&
                (
                    this.InvoiceDate == input.InvoiceDate ||
                    (this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(input.InvoiceDate))
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
                hashCode = (hashCode * 59) + this.VatKind.GetHashCode();
                hashCode = (hashCode * 59) + this.OriginalDocumentType.GetHashCode();
                if (this.OdNumber != null)
                {
                    hashCode = (hashCode * 59) + this.OdNumber.GetHashCode();
                }
                if (this.OdDate != null)
                {
                    hashCode = (hashCode * 59) + this.OdDate.GetHashCode();
                }
                if (this.Cig != null)
                {
                    hashCode = (hashCode * 59) + this.Cig.GetHashCode();
                }
                if (this.Cup != null)
                {
                    hashCode = (hashCode * 59) + this.Cup.GetHashCode();
                }
                if (this.PaymentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethod.GetHashCode();
                }
                if (this.BankName != null)
                {
                    hashCode = (hashCode * 59) + this.BankName.GetHashCode();
                }
                if (this.BankIban != null)
                {
                    hashCode = (hashCode * 59) + this.BankIban.GetHashCode();
                }
                if (this.BankBeneficiary != null)
                {
                    hashCode = (hashCode * 59) + this.BankBeneficiary.GetHashCode();
                }
                if (this.InvoiceNumber != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNumber.GetHashCode();
                }
                if (this.InvoiceDate != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceDate.GetHashCode();
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
