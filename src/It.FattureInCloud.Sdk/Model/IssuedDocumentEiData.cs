/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.6
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
        public VatKind? VatKind { get; set; }

        /// <summary>
        /// Gets or Sets OriginalDocumentType
        /// </summary>
        [DataMember(Name = "original_document_type", EmitDefaultValue = true)]
        public OriginalDocumentType? OriginalDocumentType { get; set; }
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
            this.VatKind = vatKind;
            this.OriginalDocumentType = originalDocumentType;
            this.OdNumber = odNumber;
            this.OdDate = odDate;
            this.Cig = cig;
            this.Cup = cup;
            this.PaymentMethod = paymentMethod;
            this.BankName = bankName;
            this.BankIban = bankIban;
            this.BankBeneficiary = bankBeneficiary;
            this.InvoiceNumber = invoiceNumber;
            this.InvoiceDate = invoiceDate;
        }

        /// <summary>
        /// Original document number.
        /// </summary>
        /// <value>Original document number.</value>
        [DataMember(Name = "od_number", EmitDefaultValue = true)]
        public string OdNumber { get; set; }

        /// <summary>
        /// Original document date.
        /// </summary>
        /// <value>Original document date.</value>
        [DataMember(Name = "od_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? OdDate { get; set; }

        /// <summary>
        /// CIG.
        /// </summary>
        /// <value>CIG.</value>
        [DataMember(Name = "cig", EmitDefaultValue = true)]
        public string Cig { get; set; }

        /// <summary>
        /// CUP.
        /// </summary>
        /// <value>CUP.</value>
        [DataMember(Name = "cup", EmitDefaultValue = true)]
        public string Cup { get; set; }

        /// <summary>
        /// Payment method (see https://www.fatturapa.gov.it/export/documenti/fatturapa/v1.2.1/Rappresentazione-tabellare-fattura-ordinaria.pdf for the accepted values of ModalitaPagamento).
        /// </summary>
        /// <value>Payment method (see https://www.fatturapa.gov.it/export/documenti/fatturapa/v1.2.1/Rappresentazione-tabellare-fattura-ordinaria.pdf for the accepted values of ModalitaPagamento).</value>
        [DataMember(Name = "payment_method", EmitDefaultValue = true)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Bank name.
        /// </summary>
        /// <value>Bank name.</value>
        [DataMember(Name = "bank_name", EmitDefaultValue = true)]
        public string BankName { get; set; }

        /// <summary>
        /// IBAN.
        /// </summary>
        /// <value>IBAN.</value>
        [DataMember(Name = "bank_iban", EmitDefaultValue = true)]
        public string BankIban { get; set; }

        /// <summary>
        /// Bank beneficiary.
        /// </summary>
        /// <value>Bank beneficiary.</value>
        [DataMember(Name = "bank_beneficiary", EmitDefaultValue = true)]
        public string BankBeneficiary { get; set; }

        /// <summary>
        /// Invoice number.
        /// </summary>
        /// <value>Invoice number.</value>
        [DataMember(Name = "invoice_number", EmitDefaultValue = true)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Invoice date.
        /// </summary>
        /// <value>Invoice date.</value>
        [DataMember(Name = "invoice_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
                return false;

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
                hashCode = hashCode * 59 + this.VatKind.GetHashCode();
                hashCode = hashCode * 59 + this.OriginalDocumentType.GetHashCode();
                if (this.OdNumber != null)
                    hashCode = hashCode * 59 + this.OdNumber.GetHashCode();
                if (this.OdDate != null)
                    hashCode = hashCode * 59 + this.OdDate.GetHashCode();
                if (this.Cig != null)
                    hashCode = hashCode * 59 + this.Cig.GetHashCode();
                if (this.Cup != null)
                    hashCode = hashCode * 59 + this.Cup.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                if (this.BankIban != null)
                    hashCode = hashCode * 59 + this.BankIban.GetHashCode();
                if (this.BankBeneficiary != null)
                    hashCode = hashCode * 59 + this.BankBeneficiary.GetHashCode();
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                if (this.InvoiceDate != null)
                    hashCode = hashCode * 59 + this.InvoiceDate.GetHashCode();
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
