/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.16
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using It.FattureInCloud.Sdk.Client;

namespace It.FattureInCloud.Sdk.Model
{
    /// <summary>
    ///     E-invoice data. [Only if e_invoice&#x3D;true]
    /// </summary>
    [DataContract(Name = "IssuedDocument_ei_data")]
    public class IssuedDocumentEiData : IEquatable<IssuedDocumentEiData>, IValidatableObject
    {
        private string _BankBeneficiary;
        private string _BankIban;
        private string _BankName;
        private string _Cig;
        private string _Cup;
        private bool _flagBankBeneficiary;
        private bool _flagBankIban;
        private bool _flagBankName;
        private bool _flagCig;
        private bool _flagCup;
        private bool _flagInvoiceDate;
        private bool _flagInvoiceNumber;
        private bool _flagOdDate;
        private bool _flagOdNumber;
        private bool _flagOriginalDocumentType;
        private bool _flagPaymentMethod;
        private bool _flagVatKind;
        private DateTime? _InvoiceDate;
        private string _InvoiceNumber;
        private DateTime? _OdDate;
        private string _OdNumber;
        private OriginalDocumentType? _OriginalDocumentType;
        private string _PaymentMethod;
        private VatKind? _VatKind;

        /// <summary>
        ///     Initializes a new instance of the <see cref="IssuedDocumentEiData" /> class.
        /// </summary>
        /// <param name="vatKind">vatKind.</param>
        /// <param name="originalDocumentType">originalDocumentType.</param>
        /// <param name="odNumber">Original document number..</param>
        /// <param name="odDate">Original document date..</param>
        /// <param name="cig">CIG..</param>
        /// <param name="cup">CUP..</param>
        /// <param name="paymentMethod">
        ///     Payment method (see
        ///     https://www.fatturapa.gov.it/export/documenti/fatturapa/v1.2.1/Rappresentazione-tabellare-fattura-ordinaria.pdf for
        ///     the accepted values of ModalitaPagamento)..
        /// </param>
        /// <param name="bankName">Bank name..</param>
        /// <param name="bankIban">IBAN..</param>
        /// <param name="bankBeneficiary">Bank beneficiary..</param>
        /// <param name="invoiceNumber">Invoice number..</param>
        /// <param name="invoiceDate">Invoice date..</param>
        public IssuedDocumentEiData(VatKind? vatKind = default(VatKind?),
            OriginalDocumentType? originalDocumentType = default(OriginalDocumentType?),
            string odNumber = default(string), DateTime? odDate = default(DateTime?), string cig = default(string),
            string cup = default(string), string paymentMethod = default(string), string bankName = default(string),
            string bankIban = default(string), string bankBeneficiary = default(string),
            string invoiceNumber = default(string), DateTime? invoiceDate = default(DateTime?))
        {
            _VatKind = vatKind;
            if (VatKind != null) _flagVatKind = true;
            _OriginalDocumentType = originalDocumentType;
            if (OriginalDocumentType != null) _flagOriginalDocumentType = true;
            _OdNumber = odNumber;
            if (OdNumber != null) _flagOdNumber = true;
            _OdDate = odDate;
            if (OdDate != null) _flagOdDate = true;
            _Cig = cig;
            if (Cig != null) _flagCig = true;
            _Cup = cup;
            if (Cup != null) _flagCup = true;
            _PaymentMethod = paymentMethod;
            if (PaymentMethod != null) _flagPaymentMethod = true;
            _BankName = bankName;
            if (BankName != null) _flagBankName = true;
            _BankIban = bankIban;
            if (BankIban != null) _flagBankIban = true;
            _BankBeneficiary = bankBeneficiary;
            if (BankBeneficiary != null) _flagBankBeneficiary = true;
            _InvoiceNumber = invoiceNumber;
            if (InvoiceNumber != null) _flagInvoiceNumber = true;
            _InvoiceDate = invoiceDate;
            if (InvoiceDate != null) _flagInvoiceDate = true;
        }

        /// <summary>
        ///     Gets or Sets VatKind
        /// </summary>

        [DataMember(Name = "vat_kind", EmitDefaultValue = true)]
        public VatKind? VatKind
        {
            get => _VatKind;
            set
            {
                _VatKind = value;
                _flagVatKind = true;
            }
        }

        /// <summary>
        ///     Gets or Sets OriginalDocumentType
        /// </summary>

        [DataMember(Name = "original_document_type", EmitDefaultValue = true)]
        public OriginalDocumentType? OriginalDocumentType
        {
            get => _OriginalDocumentType;
            set
            {
                _OriginalDocumentType = value;
                _flagOriginalDocumentType = true;
            }
        }

        /// <summary>
        ///     Original document number.
        /// </summary>
        /// <value>Original document number.</value>
        [DataMember(Name = "od_number", EmitDefaultValue = true)]
        public string OdNumber
        {
            get => _OdNumber;
            set
            {
                _OdNumber = value;
                _flagOdNumber = true;
            }
        }

        /// <summary>
        ///     Original document date.
        /// </summary>
        /// <value>Original document date.</value>
        [JsonConverter(typeof(OpenAPIDateConverter))]
        [DataMember(Name = "od_date", EmitDefaultValue = true)]
        public DateTime? OdDate
        {
            get => _OdDate;
            set
            {
                _OdDate = value;
                _flagOdDate = true;
            }
        }

        /// <summary>
        ///     CIG.
        /// </summary>
        /// <value>CIG.</value>
        [DataMember(Name = "cig", EmitDefaultValue = true)]
        public string Cig
        {
            get => _Cig;
            set
            {
                _Cig = value;
                _flagCig = true;
            }
        }

        /// <summary>
        ///     CUP.
        /// </summary>
        /// <value>CUP.</value>
        [DataMember(Name = "cup", EmitDefaultValue = true)]
        public string Cup
        {
            get => _Cup;
            set
            {
                _Cup = value;
                _flagCup = true;
            }
        }

        /// <summary>
        ///     Payment method (see
        ///     https://www.fatturapa.gov.it/export/documenti/fatturapa/v1.2.1/Rappresentazione-tabellare-fattura-ordinaria.pdf for
        ///     the accepted values of ModalitaPagamento).
        /// </summary>
        /// <value>
        ///     Payment method (see
        ///     https://www.fatturapa.gov.it/export/documenti/fatturapa/v1.2.1/Rappresentazione-tabellare-fattura-ordinaria.pdf for
        ///     the accepted values of ModalitaPagamento).
        /// </value>
        [DataMember(Name = "payment_method", EmitDefaultValue = true)]
        public string PaymentMethod
        {
            get => _PaymentMethod;
            set
            {
                _PaymentMethod = value;
                _flagPaymentMethod = true;
            }
        }

        /// <summary>
        ///     Bank name.
        /// </summary>
        /// <value>Bank name.</value>
        [DataMember(Name = "bank_name", EmitDefaultValue = true)]
        public string BankName
        {
            get => _BankName;
            set
            {
                _BankName = value;
                _flagBankName = true;
            }
        }

        /// <summary>
        ///     IBAN.
        /// </summary>
        /// <value>IBAN.</value>
        [DataMember(Name = "bank_iban", EmitDefaultValue = true)]
        public string BankIban
        {
            get => _BankIban;
            set
            {
                _BankIban = value;
                _flagBankIban = true;
            }
        }

        /// <summary>
        ///     Bank beneficiary.
        /// </summary>
        /// <value>Bank beneficiary.</value>
        [DataMember(Name = "bank_beneficiary", EmitDefaultValue = true)]
        public string BankBeneficiary
        {
            get => _BankBeneficiary;
            set
            {
                _BankBeneficiary = value;
                _flagBankBeneficiary = true;
            }
        }

        /// <summary>
        ///     Invoice number.
        /// </summary>
        /// <value>Invoice number.</value>
        [DataMember(Name = "invoice_number", EmitDefaultValue = true)]
        public string InvoiceNumber
        {
            get => _InvoiceNumber;
            set
            {
                _InvoiceNumber = value;
                _flagInvoiceNumber = true;
            }
        }

        /// <summary>
        ///     Invoice date.
        /// </summary>
        /// <value>Invoice date.</value>
        [JsonConverter(typeof(OpenAPIDateConverter))]
        [DataMember(Name = "invoice_date", EmitDefaultValue = true)]
        public DateTime? InvoiceDate
        {
            get => _InvoiceDate;
            set
            {
                _InvoiceDate = value;
                _flagInvoiceDate = true;
            }
        }

        /// <summary>
        ///     Returns false as VatKind should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVatKind()
        {
            return _flagVatKind;
        }

        /// <summary>
        ///     Returns false as OriginalDocumentType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOriginalDocumentType()
        {
            return _flagOriginalDocumentType;
        }

        /// <summary>
        ///     Returns false as OdNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOdNumber()
        {
            return _flagOdNumber;
        }

        /// <summary>
        ///     Returns false as OdDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOdDate()
        {
            return _flagOdDate;
        }

        /// <summary>
        ///     Returns false as Cig should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCig()
        {
            return _flagCig;
        }

        /// <summary>
        ///     Returns false as Cup should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCup()
        {
            return _flagCup;
        }

        /// <summary>
        ///     Returns false as PaymentMethod should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentMethod()
        {
            return _flagPaymentMethod;
        }

        /// <summary>
        ///     Returns false as BankName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBankName()
        {
            return _flagBankName;
        }

        /// <summary>
        ///     Returns false as BankIban should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBankIban()
        {
            return _flagBankIban;
        }

        /// <summary>
        ///     Returns false as BankBeneficiary should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBankBeneficiary()
        {
            return _flagBankBeneficiary;
        }

        /// <summary>
        ///     Returns false as InvoiceNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInvoiceNumber()
        {
            return _flagInvoiceNumber;
        }

        /// <summary>
        ///     Returns false as InvoiceDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInvoiceDate()
        {
            return _flagInvoiceDate;
        }

        /// <summary>
        ///     Returns the string presentation of the object
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
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as IssuedDocumentEiData);
        }

        /// <summary>
        ///     Returns true if IssuedDocumentEiData instances are equal
        /// </summary>
        /// <param name="input">Instance of IssuedDocumentEiData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuedDocumentEiData input)
        {
            if (input == null) return false;
            return
                (
                    VatKind == input.VatKind ||
                    VatKind.Equals(input.VatKind)
                ) &&
                (
                    OriginalDocumentType == input.OriginalDocumentType ||
                    OriginalDocumentType.Equals(input.OriginalDocumentType)
                ) &&
                (
                    OdNumber == input.OdNumber ||
                    (OdNumber != null &&
                     OdNumber.Equals(input.OdNumber))
                ) &&
                (
                    OdDate == input.OdDate ||
                    (OdDate != null &&
                     OdDate.Equals(input.OdDate))
                ) &&
                (
                    Cig == input.Cig ||
                    (Cig != null &&
                     Cig.Equals(input.Cig))
                ) &&
                (
                    Cup == input.Cup ||
                    (Cup != null &&
                     Cup.Equals(input.Cup))
                ) &&
                (
                    PaymentMethod == input.PaymentMethod ||
                    (PaymentMethod != null &&
                     PaymentMethod.Equals(input.PaymentMethod))
                ) &&
                (
                    BankName == input.BankName ||
                    (BankName != null &&
                     BankName.Equals(input.BankName))
                ) &&
                (
                    BankIban == input.BankIban ||
                    (BankIban != null &&
                     BankIban.Equals(input.BankIban))
                ) &&
                (
                    BankBeneficiary == input.BankBeneficiary ||
                    (BankBeneficiary != null &&
                     BankBeneficiary.Equals(input.BankBeneficiary))
                ) &&
                (
                    InvoiceNumber == input.InvoiceNumber ||
                    (InvoiceNumber != null &&
                     InvoiceNumber.Equals(input.InvoiceNumber))
                ) &&
                (
                    InvoiceDate == input.InvoiceDate ||
                    (InvoiceDate != null &&
                     InvoiceDate.Equals(input.InvoiceDate))
                );
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + VatKind.GetHashCode();
                hashCode = hashCode * 59 + OriginalDocumentType.GetHashCode();
                if (OdNumber != null) hashCode = hashCode * 59 + OdNumber.GetHashCode();
                if (OdDate != null) hashCode = hashCode * 59 + OdDate.GetHashCode();
                if (Cig != null) hashCode = hashCode * 59 + Cig.GetHashCode();
                if (Cup != null) hashCode = hashCode * 59 + Cup.GetHashCode();
                if (PaymentMethod != null) hashCode = hashCode * 59 + PaymentMethod.GetHashCode();
                if (BankName != null) hashCode = hashCode * 59 + BankName.GetHashCode();
                if (BankIban != null) hashCode = hashCode * 59 + BankIban.GetHashCode();
                if (BankBeneficiary != null) hashCode = hashCode * 59 + BankBeneficiary.GetHashCode();
                if (InvoiceNumber != null) hashCode = hashCode * 59 + InvoiceNumber.GetHashCode();
                if (InvoiceDate != null) hashCode = hashCode * 59 + InvoiceDate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}