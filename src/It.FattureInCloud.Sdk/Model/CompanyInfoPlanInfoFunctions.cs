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
            this.Archive = archive;
            this.Cerved = cerved;
            this.DocumentAttachments = documentAttachments;
            this.EInvoice = eInvoice;
            this.Genius = genius;
            this.MailTracking = mailTracking;
            this.PaymentNotifications = paymentNotifications;
            this.Paypal = paypal;
            this.Receipts = receipts;
            this.Recurring = recurring;
            this.Smtp = smtp;
            this.Sofort = sofort;
            this.Stock = stock;
            this.Subaccounts = subaccounts;
            this.TesseraSanitaria = tesseraSanitaria;
            this.TsDigital = tsDigital;
            this.TsInvoiceTrading = tsInvoiceTrading;
            this.TsPay = tsPay;
        }

        /// <summary>
        /// Gets or Sets Archive
        /// </summary>
        [DataMember(Name = "archive", EmitDefaultValue = true)]
        public bool? Archive { get; set; }

        /// <summary>
        /// Gets or Sets Cerved
        /// </summary>
        [DataMember(Name = "cerved", EmitDefaultValue = true)]
        public bool? Cerved { get; set; }

        /// <summary>
        /// Gets or Sets DocumentAttachments
        /// </summary>
        [DataMember(Name = "document_attachments", EmitDefaultValue = true)]
        public bool? DocumentAttachments { get; set; }

        /// <summary>
        /// Gets or Sets EInvoice
        /// </summary>
        [DataMember(Name = "e_invoice", EmitDefaultValue = true)]
        public bool? EInvoice { get; set; }

        /// <summary>
        /// Gets or Sets Genius
        /// </summary>
        [DataMember(Name = "genius", EmitDefaultValue = true)]
        public bool? Genius { get; set; }

        /// <summary>
        /// Gets or Sets MailTracking
        /// </summary>
        [DataMember(Name = "mail_tracking", EmitDefaultValue = true)]
        public bool? MailTracking { get; set; }

        /// <summary>
        /// Gets or Sets PaymentNotifications
        /// </summary>
        [DataMember(Name = "payment_notifications", EmitDefaultValue = true)]
        public bool? PaymentNotifications { get; set; }

        /// <summary>
        /// Gets or Sets Paypal
        /// </summary>
        [DataMember(Name = "paypal", EmitDefaultValue = true)]
        public bool? Paypal { get; set; }

        /// <summary>
        /// Gets or Sets Receipts
        /// </summary>
        [DataMember(Name = "receipts", EmitDefaultValue = true)]
        public bool? Receipts { get; set; }

        /// <summary>
        /// Gets or Sets Recurring
        /// </summary>
        [DataMember(Name = "recurring", EmitDefaultValue = true)]
        public bool? Recurring { get; set; }

        /// <summary>
        /// Gets or Sets Smtp
        /// </summary>
        [DataMember(Name = "smtp", EmitDefaultValue = true)]
        public bool? Smtp { get; set; }

        /// <summary>
        /// Gets or Sets Sofort
        /// </summary>
        [DataMember(Name = "sofort", EmitDefaultValue = true)]
        public bool? Sofort { get; set; }

        /// <summary>
        /// Gets or Sets Stock
        /// </summary>
        [DataMember(Name = "stock", EmitDefaultValue = true)]
        public bool? Stock { get; set; }

        /// <summary>
        /// Gets or Sets Subaccounts
        /// </summary>
        [DataMember(Name = "subaccounts", EmitDefaultValue = true)]
        public bool? Subaccounts { get; set; }

        /// <summary>
        /// Gets or Sets TesseraSanitaria
        /// </summary>
        [DataMember(Name = "tessera_sanitaria", EmitDefaultValue = true)]
        public bool? TesseraSanitaria { get; set; }

        /// <summary>
        /// Gets or Sets TsDigital
        /// </summary>
        [DataMember(Name = "ts_digital", EmitDefaultValue = true)]
        public bool? TsDigital { get; set; }

        /// <summary>
        /// Gets or Sets TsInvoiceTrading
        /// </summary>
        [DataMember(Name = "ts_invoice_trading", EmitDefaultValue = true)]
        public bool? TsInvoiceTrading { get; set; }

        /// <summary>
        /// Gets or Sets TsPay
        /// </summary>
        [DataMember(Name = "ts_pay", EmitDefaultValue = true)]
        public bool? TsPay { get; set; }

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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
