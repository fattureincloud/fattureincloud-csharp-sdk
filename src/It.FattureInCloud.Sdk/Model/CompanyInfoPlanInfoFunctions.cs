/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.1.3
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
    /// Access to functions for this company.
    /// </summary>
    [DataContract(Name = "CompanyInfo_plan_info_functions")]
    public partial class CompanyInfoPlanInfoFunctions : IEquatable<CompanyInfoPlanInfoFunctions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyInfoPlanInfoFunctions" /> class.
        /// </summary>
        /// <param name="archive">archive.</param>
        /// <param name="cerved">cerved.</param>
        /// <param name="documentAttachments">documentAttachments.</param>
        /// <param name="eInvoice">eInvoice.</param>
        /// <param name="genius">genius.</param>
        /// <param name="mailTracking">mailTracking.</param>
        /// <param name="paymentNotifications">paymentNotifications.</param>
        /// <param name="paypal">paypal.</param>
        /// <param name="receipts">receipts.</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="smtp">smtp.</param>
        /// <param name="sofort">sofort.</param>
        /// <param name="stock">stock.</param>
        /// <param name="subaccounts">subaccounts.</param>
        /// <param name="tesseraSanitaria">tesseraSanitaria.</param>
        /// <param name="tsDigital">tsDigital.</param>
        /// <param name="tsInvoiceTrading">tsInvoiceTrading.</param>
        /// <param name="tsPay">tsPay.</param>
        public CompanyInfoPlanInfoFunctions(bool? archive = default(bool?), bool? cerved = default(bool?), bool? documentAttachments = default(bool?), bool? eInvoice = default(bool?), bool? genius = default(bool?), bool? mailTracking = default(bool?), bool? paymentNotifications = default(bool?), bool? paypal = default(bool?), bool? receipts = default(bool?), bool? recurring = default(bool?), bool? smtp = default(bool?), bool? sofort = default(bool?), bool? stock = default(bool?), bool? subaccounts = default(bool?), bool? tesseraSanitaria = default(bool?), bool? tsDigital = default(bool?), bool? tsInvoiceTrading = default(bool?), bool? tsPay = default(bool?))
        {
            this._Archive = archive;
            if (this.Archive != null)
            {
                this._flagArchive = true;
            }
            this._Cerved = cerved;
            if (this.Cerved != null)
            {
                this._flagCerved = true;
            }
            this._DocumentAttachments = documentAttachments;
            if (this.DocumentAttachments != null)
            {
                this._flagDocumentAttachments = true;
            }
            this._EInvoice = eInvoice;
            if (this.EInvoice != null)
            {
                this._flagEInvoice = true;
            }
            this._Genius = genius;
            if (this.Genius != null)
            {
                this._flagGenius = true;
            }
            this._MailTracking = mailTracking;
            if (this.MailTracking != null)
            {
                this._flagMailTracking = true;
            }
            this._PaymentNotifications = paymentNotifications;
            if (this.PaymentNotifications != null)
            {
                this._flagPaymentNotifications = true;
            }
            this._Paypal = paypal;
            if (this.Paypal != null)
            {
                this._flagPaypal = true;
            }
            this._Receipts = receipts;
            if (this.Receipts != null)
            {
                this._flagReceipts = true;
            }
            this._Recurring = recurring;
            if (this.Recurring != null)
            {
                this._flagRecurring = true;
            }
            this._Smtp = smtp;
            if (this.Smtp != null)
            {
                this._flagSmtp = true;
            }
            this._Sofort = sofort;
            if (this.Sofort != null)
            {
                this._flagSofort = true;
            }
            this._Stock = stock;
            if (this.Stock != null)
            {
                this._flagStock = true;
            }
            this._Subaccounts = subaccounts;
            if (this.Subaccounts != null)
            {
                this._flagSubaccounts = true;
            }
            this._TesseraSanitaria = tesseraSanitaria;
            if (this.TesseraSanitaria != null)
            {
                this._flagTesseraSanitaria = true;
            }
            this._TsDigital = tsDigital;
            if (this.TsDigital != null)
            {
                this._flagTsDigital = true;
            }
            this._TsInvoiceTrading = tsInvoiceTrading;
            if (this.TsInvoiceTrading != null)
            {
                this._flagTsInvoiceTrading = true;
            }
            this._TsPay = tsPay;
            if (this.TsPay != null)
            {
                this._flagTsPay = true;
            }
        }

        /// <summary>
        /// Gets or Sets Archive
        /// </summary>
        [DataMember(Name = "archive", EmitDefaultValue = true)]
        public bool? Archive
        {
            get { return _Archive; }
            set
            {
                _Archive = value;
                _flagArchive = true;
            }
        }
        private bool? _Archive;
        private bool _flagArchive;

        /// <summary>
        /// Returns false as Archive should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeArchive()
        {
            return _flagArchive;
        }
        /// <summary>
        /// Gets or Sets Cerved
        /// </summary>
        [DataMember(Name = "cerved", EmitDefaultValue = true)]
        public bool? Cerved
        {
            get { return _Cerved; }
            set
            {
                _Cerved = value;
                _flagCerved = true;
            }
        }
        private bool? _Cerved;
        private bool _flagCerved;

        /// <summary>
        /// Returns false as Cerved should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCerved()
        {
            return _flagCerved;
        }
        /// <summary>
        /// Gets or Sets DocumentAttachments
        /// </summary>
        [DataMember(Name = "document_attachments", EmitDefaultValue = true)]
        public bool? DocumentAttachments
        {
            get { return _DocumentAttachments; }
            set
            {
                _DocumentAttachments = value;
                _flagDocumentAttachments = true;
            }
        }
        private bool? _DocumentAttachments;
        private bool _flagDocumentAttachments;

        /// <summary>
        /// Returns false as DocumentAttachments should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDocumentAttachments()
        {
            return _flagDocumentAttachments;
        }
        /// <summary>
        /// Gets or Sets EInvoice
        /// </summary>
        [DataMember(Name = "e_invoice", EmitDefaultValue = true)]
        public bool? EInvoice
        {
            get { return _EInvoice; }
            set
            {
                _EInvoice = value;
                _flagEInvoice = true;
            }
        }
        private bool? _EInvoice;
        private bool _flagEInvoice;

        /// <summary>
        /// Returns false as EInvoice should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEInvoice()
        {
            return _flagEInvoice;
        }
        /// <summary>
        /// Gets or Sets Genius
        /// </summary>
        [DataMember(Name = "genius", EmitDefaultValue = true)]
        public bool? Genius
        {
            get { return _Genius; }
            set
            {
                _Genius = value;
                _flagGenius = true;
            }
        }
        private bool? _Genius;
        private bool _flagGenius;

        /// <summary>
        /// Returns false as Genius should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGenius()
        {
            return _flagGenius;
        }
        /// <summary>
        /// Gets or Sets MailTracking
        /// </summary>
        [DataMember(Name = "mail_tracking", EmitDefaultValue = true)]
        public bool? MailTracking
        {
            get { return _MailTracking; }
            set
            {
                _MailTracking = value;
                _flagMailTracking = true;
            }
        }
        private bool? _MailTracking;
        private bool _flagMailTracking;

        /// <summary>
        /// Returns false as MailTracking should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMailTracking()
        {
            return _flagMailTracking;
        }
        /// <summary>
        /// Gets or Sets PaymentNotifications
        /// </summary>
        [DataMember(Name = "payment_notifications", EmitDefaultValue = true)]
        public bool? PaymentNotifications
        {
            get { return _PaymentNotifications; }
            set
            {
                _PaymentNotifications = value;
                _flagPaymentNotifications = true;
            }
        }
        private bool? _PaymentNotifications;
        private bool _flagPaymentNotifications;

        /// <summary>
        /// Returns false as PaymentNotifications should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentNotifications()
        {
            return _flagPaymentNotifications;
        }
        /// <summary>
        /// Gets or Sets Paypal
        /// </summary>
        [DataMember(Name = "paypal", EmitDefaultValue = true)]
        public bool? Paypal
        {
            get { return _Paypal; }
            set
            {
                _Paypal = value;
                _flagPaypal = true;
            }
        }
        private bool? _Paypal;
        private bool _flagPaypal;

        /// <summary>
        /// Returns false as Paypal should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaypal()
        {
            return _flagPaypal;
        }
        /// <summary>
        /// Gets or Sets Receipts
        /// </summary>
        [DataMember(Name = "receipts", EmitDefaultValue = true)]
        public bool? Receipts
        {
            get { return _Receipts; }
            set
            {
                _Receipts = value;
                _flagReceipts = true;
            }
        }
        private bool? _Receipts;
        private bool _flagReceipts;

        /// <summary>
        /// Returns false as Receipts should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeReceipts()
        {
            return _flagReceipts;
        }
        /// <summary>
        /// Gets or Sets Recurring
        /// </summary>
        [DataMember(Name = "recurring", EmitDefaultValue = true)]
        public bool? Recurring
        {
            get { return _Recurring; }
            set
            {
                _Recurring = value;
                _flagRecurring = true;
            }
        }
        private bool? _Recurring;
        private bool _flagRecurring;

        /// <summary>
        /// Returns false as Recurring should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRecurring()
        {
            return _flagRecurring;
        }
        /// <summary>
        /// Gets or Sets Smtp
        /// </summary>
        [DataMember(Name = "smtp", EmitDefaultValue = true)]
        public bool? Smtp
        {
            get { return _Smtp; }
            set
            {
                _Smtp = value;
                _flagSmtp = true;
            }
        }
        private bool? _Smtp;
        private bool _flagSmtp;

        /// <summary>
        /// Returns false as Smtp should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSmtp()
        {
            return _flagSmtp;
        }
        /// <summary>
        /// Gets or Sets Sofort
        /// </summary>
        [DataMember(Name = "sofort", EmitDefaultValue = true)]
        public bool? Sofort
        {
            get { return _Sofort; }
            set
            {
                _Sofort = value;
                _flagSofort = true;
            }
        }
        private bool? _Sofort;
        private bool _flagSofort;

        /// <summary>
        /// Returns false as Sofort should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSofort()
        {
            return _flagSofort;
        }
        /// <summary>
        /// Gets or Sets Stock
        /// </summary>
        [DataMember(Name = "stock", EmitDefaultValue = true)]
        public bool? Stock
        {
            get { return _Stock; }
            set
            {
                _Stock = value;
                _flagStock = true;
            }
        }
        private bool? _Stock;
        private bool _flagStock;

        /// <summary>
        /// Returns false as Stock should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStock()
        {
            return _flagStock;
        }
        /// <summary>
        /// Gets or Sets Subaccounts
        /// </summary>
        [DataMember(Name = "subaccounts", EmitDefaultValue = true)]
        public bool? Subaccounts
        {
            get { return _Subaccounts; }
            set
            {
                _Subaccounts = value;
                _flagSubaccounts = true;
            }
        }
        private bool? _Subaccounts;
        private bool _flagSubaccounts;

        /// <summary>
        /// Returns false as Subaccounts should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSubaccounts()
        {
            return _flagSubaccounts;
        }
        /// <summary>
        /// Gets or Sets TesseraSanitaria
        /// </summary>
        [DataMember(Name = "tessera_sanitaria", EmitDefaultValue = true)]
        public bool? TesseraSanitaria
        {
            get { return _TesseraSanitaria; }
            set
            {
                _TesseraSanitaria = value;
                _flagTesseraSanitaria = true;
            }
        }
        private bool? _TesseraSanitaria;
        private bool _flagTesseraSanitaria;

        /// <summary>
        /// Returns false as TesseraSanitaria should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTesseraSanitaria()
        {
            return _flagTesseraSanitaria;
        }
        /// <summary>
        /// Gets or Sets TsDigital
        /// </summary>
        [DataMember(Name = "ts_digital", EmitDefaultValue = true)]
        public bool? TsDigital
        {
            get { return _TsDigital; }
            set
            {
                _TsDigital = value;
                _flagTsDigital = true;
            }
        }
        private bool? _TsDigital;
        private bool _flagTsDigital;

        /// <summary>
        /// Returns false as TsDigital should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTsDigital()
        {
            return _flagTsDigital;
        }
        /// <summary>
        /// Gets or Sets TsInvoiceTrading
        /// </summary>
        [DataMember(Name = "ts_invoice_trading", EmitDefaultValue = true)]
        public bool? TsInvoiceTrading
        {
            get { return _TsInvoiceTrading; }
            set
            {
                _TsInvoiceTrading = value;
                _flagTsInvoiceTrading = true;
            }
        }
        private bool? _TsInvoiceTrading;
        private bool _flagTsInvoiceTrading;

        /// <summary>
        /// Returns false as TsInvoiceTrading should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTsInvoiceTrading()
        {
            return _flagTsInvoiceTrading;
        }
        /// <summary>
        /// Gets or Sets TsPay
        /// </summary>
        [DataMember(Name = "ts_pay", EmitDefaultValue = true)]
        public bool? TsPay
        {
            get { return _TsPay; }
            set
            {
                _TsPay = value;
                _flagTsPay = true;
            }
        }
        private bool? _TsPay;
        private bool _flagTsPay;

        /// <summary>
        /// Returns false as TsPay should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTsPay()
        {
            return _flagTsPay;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyInfoPlanInfoFunctions {\n");
            sb.Append("  Archive: ").Append(Archive).Append("\n");
            sb.Append("  Cerved: ").Append(Cerved).Append("\n");
            sb.Append("  DocumentAttachments: ").Append(DocumentAttachments).Append("\n");
            sb.Append("  EInvoice: ").Append(EInvoice).Append("\n");
            sb.Append("  Genius: ").Append(Genius).Append("\n");
            sb.Append("  MailTracking: ").Append(MailTracking).Append("\n");
            sb.Append("  PaymentNotifications: ").Append(PaymentNotifications).Append("\n");
            sb.Append("  Paypal: ").Append(Paypal).Append("\n");
            sb.Append("  Receipts: ").Append(Receipts).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  Smtp: ").Append(Smtp).Append("\n");
            sb.Append("  Sofort: ").Append(Sofort).Append("\n");
            sb.Append("  Stock: ").Append(Stock).Append("\n");
            sb.Append("  Subaccounts: ").Append(Subaccounts).Append("\n");
            sb.Append("  TesseraSanitaria: ").Append(TesseraSanitaria).Append("\n");
            sb.Append("  TsDigital: ").Append(TsDigital).Append("\n");
            sb.Append("  TsInvoiceTrading: ").Append(TsInvoiceTrading).Append("\n");
            sb.Append("  TsPay: ").Append(TsPay).Append("\n");
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
            return this.Equals(input as CompanyInfoPlanInfoFunctions);
        }

        /// <summary>
        /// Returns true if CompanyInfoPlanInfoFunctions instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyInfoPlanInfoFunctions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyInfoPlanInfoFunctions input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Archive == input.Archive ||
                    (this.Archive != null &&
                    this.Archive.Equals(input.Archive))
                ) &&
                (
                    this.Cerved == input.Cerved ||
                    (this.Cerved != null &&
                    this.Cerved.Equals(input.Cerved))
                ) &&
                (
                    this.DocumentAttachments == input.DocumentAttachments ||
                    (this.DocumentAttachments != null &&
                    this.DocumentAttachments.Equals(input.DocumentAttachments))
                ) &&
                (
                    this.EInvoice == input.EInvoice ||
                    (this.EInvoice != null &&
                    this.EInvoice.Equals(input.EInvoice))
                ) &&
                (
                    this.Genius == input.Genius ||
                    (this.Genius != null &&
                    this.Genius.Equals(input.Genius))
                ) &&
                (
                    this.MailTracking == input.MailTracking ||
                    (this.MailTracking != null &&
                    this.MailTracking.Equals(input.MailTracking))
                ) &&
                (
                    this.PaymentNotifications == input.PaymentNotifications ||
                    (this.PaymentNotifications != null &&
                    this.PaymentNotifications.Equals(input.PaymentNotifications))
                ) &&
                (
                    this.Paypal == input.Paypal ||
                    (this.Paypal != null &&
                    this.Paypal.Equals(input.Paypal))
                ) &&
                (
                    this.Receipts == input.Receipts ||
                    (this.Receipts != null &&
                    this.Receipts.Equals(input.Receipts))
                ) &&
                (
                    this.Recurring == input.Recurring ||
                    (this.Recurring != null &&
                    this.Recurring.Equals(input.Recurring))
                ) &&
                (
                    this.Smtp == input.Smtp ||
                    (this.Smtp != null &&
                    this.Smtp.Equals(input.Smtp))
                ) &&
                (
                    this.Sofort == input.Sofort ||
                    (this.Sofort != null &&
                    this.Sofort.Equals(input.Sofort))
                ) &&
                (
                    this.Stock == input.Stock ||
                    (this.Stock != null &&
                    this.Stock.Equals(input.Stock))
                ) &&
                (
                    this.Subaccounts == input.Subaccounts ||
                    (this.Subaccounts != null &&
                    this.Subaccounts.Equals(input.Subaccounts))
                ) &&
                (
                    this.TesseraSanitaria == input.TesseraSanitaria ||
                    (this.TesseraSanitaria != null &&
                    this.TesseraSanitaria.Equals(input.TesseraSanitaria))
                ) &&
                (
                    this.TsDigital == input.TsDigital ||
                    (this.TsDigital != null &&
                    this.TsDigital.Equals(input.TsDigital))
                ) &&
                (
                    this.TsInvoiceTrading == input.TsInvoiceTrading ||
                    (this.TsInvoiceTrading != null &&
                    this.TsInvoiceTrading.Equals(input.TsInvoiceTrading))
                ) &&
                (
                    this.TsPay == input.TsPay ||
                    (this.TsPay != null &&
                    this.TsPay.Equals(input.TsPay))
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
                if (this.Archive != null)
                {
                    hashCode = (hashCode * 59) + this.Archive.GetHashCode();
                }
                if (this.Cerved != null)
                {
                    hashCode = (hashCode * 59) + this.Cerved.GetHashCode();
                }
                if (this.DocumentAttachments != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentAttachments.GetHashCode();
                }
                if (this.EInvoice != null)
                {
                    hashCode = (hashCode * 59) + this.EInvoice.GetHashCode();
                }
                if (this.Genius != null)
                {
                    hashCode = (hashCode * 59) + this.Genius.GetHashCode();
                }
                if (this.MailTracking != null)
                {
                    hashCode = (hashCode * 59) + this.MailTracking.GetHashCode();
                }
                if (this.PaymentNotifications != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentNotifications.GetHashCode();
                }
                if (this.Paypal != null)
                {
                    hashCode = (hashCode * 59) + this.Paypal.GetHashCode();
                }
                if (this.Receipts != null)
                {
                    hashCode = (hashCode * 59) + this.Receipts.GetHashCode();
                }
                if (this.Recurring != null)
                {
                    hashCode = (hashCode * 59) + this.Recurring.GetHashCode();
                }
                if (this.Smtp != null)
                {
                    hashCode = (hashCode * 59) + this.Smtp.GetHashCode();
                }
                if (this.Sofort != null)
                {
                    hashCode = (hashCode * 59) + this.Sofort.GetHashCode();
                }
                if (this.Stock != null)
                {
                    hashCode = (hashCode * 59) + this.Stock.GetHashCode();
                }
                if (this.Subaccounts != null)
                {
                    hashCode = (hashCode * 59) + this.Subaccounts.GetHashCode();
                }
                if (this.TesseraSanitaria != null)
                {
                    hashCode = (hashCode * 59) + this.TesseraSanitaria.GetHashCode();
                }
                if (this.TsDigital != null)
                {
                    hashCode = (hashCode * 59) + this.TsDigital.GetHashCode();
                }
                if (this.TsInvoiceTrading != null)
                {
                    hashCode = (hashCode * 59) + this.TsInvoiceTrading.GetHashCode();
                }
                if (this.TsPay != null)
                {
                    hashCode = (hashCode * 59) + this.TsPay.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
