/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.17
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
    /// ReceivedDocument
    /// </summary>
    [DataContract(Name = "ReceivedDocument")]
    public partial class ReceivedDocument : IEquatable<ReceivedDocument>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>

        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ReceivedDocumentType? Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                _flagType = true;
            }
        }
        private ReceivedDocumentType? _Type;
        private bool _flagType;

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return _flagType;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivedDocument" /> class.
        /// </summary>
        /// <param name="id">Unique identifier of the document..</param>
        /// <param name="type">type.</param>
        /// <param name="entity">entity.</param>
        /// <param name="date">Date of the document [If not specified, today date is used]..</param>
        /// <param name="category">Document category..</param>
        /// <param name="description">Document description..</param>
        /// <param name="amountNet">Total net amount..</param>
        /// <param name="amountVat">Total vat amount..</param>
        /// <param name="amountWithholdingTax">Withholding tax amount..</param>
        /// <param name="amountOtherWithholdingTax">Other withholding tax amount..</param>
        /// <param name="amortization">Amortization value.</param>
        /// <param name="rcCenter">Revenue center..</param>
        /// <param name="invoiceNumber">Invoice number.</param>
        /// <param name="isMarked">isMarked.</param>
        /// <param name="isDetailed">isDetailed.</param>
        /// <param name="eInvoice">[Read Only] Indicates if this is an e-invoice..</param>
        /// <param name="currency">currency.</param>
        /// <param name="taxDeductibility">Tax deducibility percentage..</param>
        /// <param name="vatDeductibility">Vat deducibility percentage..</param>
        /// <param name="itemsList">itemsList.</param>
        /// <param name="paymentsList">paymentsList.</param>
        /// <param name="attachmentToken">Uploaded attachement token..</param>
        public ReceivedDocument(int? id = default(int?), ReceivedDocumentType? type = default(ReceivedDocumentType?), ReceivedDocumentEntity entity = default(ReceivedDocumentEntity), DateTime? date = default(DateTime?), string category = default(string), string description = default(string), decimal? amountNet = default(decimal?), decimal? amountVat = default(decimal?), decimal? amountWithholdingTax = default(decimal?), decimal? amountOtherWithholdingTax = default(decimal?), decimal? amortization = default(decimal?), string rcCenter = default(string), string invoiceNumber = default(string), bool? isMarked = default(bool?), bool? isDetailed = default(bool?), bool? eInvoice = default(bool?), Currency currency = default(Currency), decimal? taxDeductibility = default(decimal?), decimal? vatDeductibility = default(decimal?), List<ReceivedDocumentItemsListItem> itemsList = default(List<ReceivedDocumentItemsListItem>), List<ReceivedDocumentPaymentsListItem> paymentsList = default(List<ReceivedDocumentPaymentsListItem>), string attachmentToken = default(string))
        {
            this._Id = id;
            if (this.Id != null) this._flagId = true;
            this._Type = type;
            if (this.Type != null) this._flagType = true;
            this._Entity = entity;
            if (this.Entity != null) this._flagEntity = true;
            this._Date = date;
            if (this.Date != null) this._flagDate = true;
            this._Category = category;
            if (this.Category != null) this._flagCategory = true;
            this._Description = description;
            if (this.Description != null) this._flagDescription = true;
            this._AmountNet = amountNet;
            if (this.AmountNet != null) this._flagAmountNet = true;
            this._AmountVat = amountVat;
            if (this.AmountVat != null) this._flagAmountVat = true;
            this._AmountWithholdingTax = amountWithholdingTax;
            if (this.AmountWithholdingTax != null) this._flagAmountWithholdingTax = true;
            this._AmountOtherWithholdingTax = amountOtherWithholdingTax;
            if (this.AmountOtherWithholdingTax != null) this._flagAmountOtherWithholdingTax = true;
            this._Amortization = amortization;
            if (this.Amortization != null) this._flagAmortization = true;
            this._RcCenter = rcCenter;
            if (this.RcCenter != null) this._flagRcCenter = true;
            this._InvoiceNumber = invoiceNumber;
            if (this.InvoiceNumber != null) this._flagInvoiceNumber = true;
            this._IsMarked = isMarked;
            if (this.IsMarked != null) this._flagIsMarked = true;
            this._IsDetailed = isDetailed;
            if (this.IsDetailed != null) this._flagIsDetailed = true;
            this._EInvoice = eInvoice;
            if (this.EInvoice != null) this._flagEInvoice = true;
            this._Currency = currency;
            if (this.Currency != null) this._flagCurrency = true;
            this._TaxDeductibility = taxDeductibility;
            if (this.TaxDeductibility != null) this._flagTaxDeductibility = true;
            this._VatDeductibility = vatDeductibility;
            if (this.VatDeductibility != null) this._flagVatDeductibility = true;
            this._ItemsList = itemsList;
            if (this.ItemsList != null) this._flagItemsList = true;
            this._PaymentsList = paymentsList;
            if (this.PaymentsList != null) this._flagPaymentsList = true;
            this._AttachmentToken = attachmentToken;
            if (this.AttachmentToken != null) this._flagAttachmentToken = true;
        }

        /// <summary>
        /// Unique identifier of the document.
        /// </summary>
        /// <value>Unique identifier of the document.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
                _flagId = true;
            }
        }
        private int? _Id;
        private bool _flagId;

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return _flagId;
        }
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name = "entity", EmitDefaultValue = true)]
        public ReceivedDocumentEntity Entity
        {
            get { return _Entity; }
            set
            {
                _Entity = value;
                _flagEntity = true;
            }
        }
        private ReceivedDocumentEntity _Entity;
        private bool _flagEntity;

        /// <summary>
        /// Returns false as Entity should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEntity()
        {
            return _flagEntity;
        }
        /// <summary>
        /// Date of the document [If not specified, today date is used].
        /// </summary>
        /// <value>Date of the document [If not specified, today date is used].</value>
        [JsonConverter(typeof(OpenAPIDateConverter))]
        [DataMember(Name = "date", EmitDefaultValue = true)]
        public DateTime? Date
        {
            get { return _Date; }
            set
            {
                _Date = value;
                _flagDate = true;
            }
        }
        private DateTime? _Date;
        private bool _flagDate;

        /// <summary>
        /// Returns false as Date should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDate()
        {
            return _flagDate;
        }
        /// <summary>
        /// Document category.
        /// </summary>
        /// <value>Document category.</value>
        [DataMember(Name = "category", EmitDefaultValue = true)]
        public string Category
        {
            get { return _Category; }
            set
            {
                _Category = value;
                _flagCategory = true;
            }
        }
        private string _Category;
        private bool _flagCategory;

        /// <summary>
        /// Returns false as Category should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCategory()
        {
            return _flagCategory;
        }
        /// <summary>
        /// Document description.
        /// </summary>
        /// <value>Document description.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                _flagDescription = true;
            }
        }
        private string _Description;
        private bool _flagDescription;

        /// <summary>
        /// Returns false as Description should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDescription()
        {
            return _flagDescription;
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
        /// [Read Only] Total gross amount.
        /// </summary>
        /// <value>[Read Only] Total gross amount.</value>
        [DataMember(Name = "amount_gross", EmitDefaultValue = true)]
        public decimal? AmountGross { get; private set; }

        /// <summary>
        /// Returns false as AmountGross should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountGross()
        {
            return false;
        }
        /// <summary>
        /// Amortization value
        /// </summary>
        /// <value>Amortization value</value>
        [DataMember(Name = "amortization", EmitDefaultValue = true)]
        public decimal? Amortization
        {
            get { return _Amortization; }
            set
            {
                _Amortization = value;
                _flagAmortization = true;
            }
        }
        private decimal? _Amortization;
        private bool _flagAmortization;

        /// <summary>
        /// Returns false as Amortization should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmortization()
        {
            return _flagAmortization;
        }
        /// <summary>
        /// Revenue center.
        /// </summary>
        /// <value>Revenue center.</value>
        [DataMember(Name = "rc_center", EmitDefaultValue = true)]
        public string RcCenter
        {
            get { return _RcCenter; }
            set
            {
                _RcCenter = value;
                _flagRcCenter = true;
            }
        }
        private string _RcCenter;
        private bool _flagRcCenter;

        /// <summary>
        /// Returns false as RcCenter should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRcCenter()
        {
            return _flagRcCenter;
        }
        /// <summary>
        /// Invoice number
        /// </summary>
        /// <value>Invoice number</value>
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
        /// Gets or Sets IsMarked
        /// </summary>
        [DataMember(Name = "is_marked", EmitDefaultValue = true)]
        public bool? IsMarked
        {
            get { return _IsMarked; }
            set
            {
                _IsMarked = value;
                _flagIsMarked = true;
            }
        }
        private bool? _IsMarked;
        private bool _flagIsMarked;

        /// <summary>
        /// Returns false as IsMarked should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsMarked()
        {
            return _flagIsMarked;
        }
        /// <summary>
        /// Gets or Sets IsDetailed
        /// </summary>
        [DataMember(Name = "is_detailed", EmitDefaultValue = true)]
        public bool? IsDetailed
        {
            get { return _IsDetailed; }
            set
            {
                _IsDetailed = value;
                _flagIsDetailed = true;
            }
        }
        private bool? _IsDetailed;
        private bool _flagIsDetailed;

        /// <summary>
        /// Returns false as IsDetailed should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsDetailed()
        {
            return _flagIsDetailed;
        }
        /// <summary>
        /// [Read Only] Indicates if this is an e-invoice.
        /// </summary>
        /// <value>[Read Only] Indicates if this is an e-invoice.</value>
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
        /// [Read Only] Next due date.
        /// </summary>
        /// <value>[Read Only] Next due date.</value>
        [DataMember(Name = "next_due_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? NextDueDate { get; private set; }

        /// <summary>
        /// Returns false as NextDueDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNextDueDate()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public Currency Currency
        {
            get { return _Currency; }
            set
            {
                _Currency = value;
                _flagCurrency = true;
            }
        }
        private Currency _Currency;
        private bool _flagCurrency;

        /// <summary>
        /// Returns false as Currency should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrency()
        {
            return _flagCurrency;
        }
        /// <summary>
        /// Tax deducibility percentage.
        /// </summary>
        /// <value>Tax deducibility percentage.</value>
        [DataMember(Name = "tax_deductibility", EmitDefaultValue = true)]
        public decimal? TaxDeductibility
        {
            get { return _TaxDeductibility; }
            set
            {
                _TaxDeductibility = value;
                _flagTaxDeductibility = true;
            }
        }
        private decimal? _TaxDeductibility;
        private bool _flagTaxDeductibility;

        /// <summary>
        /// Returns false as TaxDeductibility should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTaxDeductibility()
        {
            return _flagTaxDeductibility;
        }
        /// <summary>
        /// Vat deducibility percentage.
        /// </summary>
        /// <value>Vat deducibility percentage.</value>
        [DataMember(Name = "vat_deductibility", EmitDefaultValue = true)]
        public decimal? VatDeductibility
        {
            get { return _VatDeductibility; }
            set
            {
                _VatDeductibility = value;
                _flagVatDeductibility = true;
            }
        }
        private decimal? _VatDeductibility;
        private bool _flagVatDeductibility;

        /// <summary>
        /// Returns false as VatDeductibility should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVatDeductibility()
        {
            return _flagVatDeductibility;
        }
        /// <summary>
        /// Gets or Sets ItemsList
        /// </summary>
        [DataMember(Name = "items_list", EmitDefaultValue = true)]
        public List<ReceivedDocumentItemsListItem> ItemsList
        {
            get { return _ItemsList; }
            set
            {
                _ItemsList = value;
                _flagItemsList = true;
            }
        }
        private List<ReceivedDocumentItemsListItem> _ItemsList;
        private bool _flagItemsList;

        /// <summary>
        /// Returns false as ItemsList should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeItemsList()
        {
            return _flagItemsList;
        }
        /// <summary>
        /// Gets or Sets PaymentsList
        /// </summary>
        [DataMember(Name = "payments_list", EmitDefaultValue = true)]
        public List<ReceivedDocumentPaymentsListItem> PaymentsList
        {
            get { return _PaymentsList; }
            set
            {
                _PaymentsList = value;
                _flagPaymentsList = true;
            }
        }
        private List<ReceivedDocumentPaymentsListItem> _PaymentsList;
        private bool _flagPaymentsList;

        /// <summary>
        /// Returns false as PaymentsList should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentsList()
        {
            return _flagPaymentsList;
        }
        /// <summary>
        /// [Read Only] Attachment url.
        /// </summary>
        /// <value>[Read Only] Attachment url.</value>
        [DataMember(Name = "attachment_url", EmitDefaultValue = true)]
        public string AttachmentUrl { get; private set; }

        /// <summary>
        /// Returns false as AttachmentUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAttachmentUrl()
        {
            return false;
        }
        /// <summary>
        /// [Read Only] Attachment preview url.
        /// </summary>
        /// <value>[Read Only] Attachment preview url.</value>
        [DataMember(Name = "attachment_preview_url", EmitDefaultValue = true)]
        public string AttachmentPreviewUrl { get; private set; }

        /// <summary>
        /// Returns false as AttachmentPreviewUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAttachmentPreviewUrl()
        {
            return false;
        }
        /// <summary>
        /// Uploaded attachement token.
        /// </summary>
        /// <value>Uploaded attachement token.</value>
        [DataMember(Name = "attachment_token", EmitDefaultValue = true)]
        public string AttachmentToken
        {
            get { return _AttachmentToken; }
            set
            {
                _AttachmentToken = value;
                _flagAttachmentToken = true;
            }
        }
        private string _AttachmentToken;
        private bool _flagAttachmentToken;

        /// <summary>
        /// Returns false as AttachmentToken should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAttachmentToken()
        {
            return _flagAttachmentToken;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReceivedDocument {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AmountNet: ").Append(AmountNet).Append("\n");
            sb.Append("  AmountVat: ").Append(AmountVat).Append("\n");
            sb.Append("  AmountWithholdingTax: ").Append(AmountWithholdingTax).Append("\n");
            sb.Append("  AmountOtherWithholdingTax: ").Append(AmountOtherWithholdingTax).Append("\n");
            sb.Append("  AmountGross: ").Append(AmountGross).Append("\n");
            sb.Append("  Amortization: ").Append(Amortization).Append("\n");
            sb.Append("  RcCenter: ").Append(RcCenter).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  IsMarked: ").Append(IsMarked).Append("\n");
            sb.Append("  IsDetailed: ").Append(IsDetailed).Append("\n");
            sb.Append("  EInvoice: ").Append(EInvoice).Append("\n");
            sb.Append("  NextDueDate: ").Append(NextDueDate).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  TaxDeductibility: ").Append(TaxDeductibility).Append("\n");
            sb.Append("  VatDeductibility: ").Append(VatDeductibility).Append("\n");
            sb.Append("  ItemsList: ").Append(ItemsList).Append("\n");
            sb.Append("  PaymentsList: ").Append(PaymentsList).Append("\n");
            sb.Append("  AttachmentUrl: ").Append(AttachmentUrl).Append("\n");
            sb.Append("  AttachmentPreviewUrl: ").Append(AttachmentPreviewUrl).Append("\n");
            sb.Append("  AttachmentToken: ").Append(AttachmentToken).Append("\n");
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
            return this.Equals(input as ReceivedDocument);
        }

        /// <summary>
        /// Returns true if ReceivedDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of ReceivedDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceivedDocument input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) &&
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) &&
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) &&
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) &&
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) &&
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
                    this.AmountGross == input.AmountGross ||
                    (this.AmountGross != null &&
                    this.AmountGross.Equals(input.AmountGross))
                ) &&
                (
                    this.Amortization == input.Amortization ||
                    (this.Amortization != null &&
                    this.Amortization.Equals(input.Amortization))
                ) &&
                (
                    this.RcCenter == input.RcCenter ||
                    (this.RcCenter != null &&
                    this.RcCenter.Equals(input.RcCenter))
                ) &&
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) &&
                (
                    this.IsMarked == input.IsMarked ||
                    (this.IsMarked != null &&
                    this.IsMarked.Equals(input.IsMarked))
                ) &&
                (
                    this.IsDetailed == input.IsDetailed ||
                    (this.IsDetailed != null &&
                    this.IsDetailed.Equals(input.IsDetailed))
                ) &&
                (
                    this.EInvoice == input.EInvoice ||
                    (this.EInvoice != null &&
                    this.EInvoice.Equals(input.EInvoice))
                ) &&
                (
                    this.NextDueDate == input.NextDueDate ||
                    (this.NextDueDate != null &&
                    this.NextDueDate.Equals(input.NextDueDate))
                ) &&
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) &&
                (
                    this.TaxDeductibility == input.TaxDeductibility ||
                    (this.TaxDeductibility != null &&
                    this.TaxDeductibility.Equals(input.TaxDeductibility))
                ) &&
                (
                    this.VatDeductibility == input.VatDeductibility ||
                    (this.VatDeductibility != null &&
                    this.VatDeductibility.Equals(input.VatDeductibility))
                ) &&
                (
                    this.ItemsList == input.ItemsList ||
                    this.ItemsList != null &&
                    input.ItemsList != null &&
                    this.ItemsList.SequenceEqual(input.ItemsList)
                ) &&
                (
                    this.PaymentsList == input.PaymentsList ||
                    this.PaymentsList != null &&
                    input.PaymentsList != null &&
                    this.PaymentsList.SequenceEqual(input.PaymentsList)
                ) &&
                (
                    this.AttachmentUrl == input.AttachmentUrl ||
                    (this.AttachmentUrl != null &&
                    this.AttachmentUrl.Equals(input.AttachmentUrl))
                ) &&
                (
                    this.AttachmentPreviewUrl == input.AttachmentPreviewUrl ||
                    (this.AttachmentPreviewUrl != null &&
                    this.AttachmentPreviewUrl.Equals(input.AttachmentPreviewUrl))
                ) &&
                (
                    this.AttachmentToken == input.AttachmentToken ||
                    (this.AttachmentToken != null &&
                    this.AttachmentToken.Equals(input.AttachmentToken))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Entity != null)
                {
                    hashCode = (hashCode * 59) + this.Entity.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.AmountNet != null)
                {
                    hashCode = (hashCode * 59) + this.AmountNet.GetHashCode();
                }
                if (this.AmountVat != null)
                {
                    hashCode = (hashCode * 59) + this.AmountVat.GetHashCode();
                }
                if (this.AmountWithholdingTax != null)
                {
                    hashCode = (hashCode * 59) + this.AmountWithholdingTax.GetHashCode();
                }
                if (this.AmountOtherWithholdingTax != null)
                {
                    hashCode = (hashCode * 59) + this.AmountOtherWithholdingTax.GetHashCode();
                }
                if (this.AmountGross != null)
                {
                    hashCode = (hashCode * 59) + this.AmountGross.GetHashCode();
                }
                if (this.Amortization != null)
                {
                    hashCode = (hashCode * 59) + this.Amortization.GetHashCode();
                }
                if (this.RcCenter != null)
                {
                    hashCode = (hashCode * 59) + this.RcCenter.GetHashCode();
                }
                if (this.InvoiceNumber != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNumber.GetHashCode();
                }
                if (this.IsMarked != null)
                {
                    hashCode = (hashCode * 59) + this.IsMarked.GetHashCode();
                }
                if (this.IsDetailed != null)
                {
                    hashCode = (hashCode * 59) + this.IsDetailed.GetHashCode();
                }
                if (this.EInvoice != null)
                {
                    hashCode = (hashCode * 59) + this.EInvoice.GetHashCode();
                }
                if (this.NextDueDate != null)
                {
                    hashCode = (hashCode * 59) + this.NextDueDate.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.TaxDeductibility != null)
                {
                    hashCode = (hashCode * 59) + this.TaxDeductibility.GetHashCode();
                }
                if (this.VatDeductibility != null)
                {
                    hashCode = (hashCode * 59) + this.VatDeductibility.GetHashCode();
                }
                if (this.ItemsList != null)
                {
                    hashCode = (hashCode * 59) + this.ItemsList.GetHashCode();
                }
                if (this.PaymentsList != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentsList.GetHashCode();
                }
                if (this.AttachmentUrl != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentUrl.GetHashCode();
                }
                if (this.AttachmentPreviewUrl != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentPreviewUrl.GetHashCode();
                }
                if (this.AttachmentToken != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentToken.GetHashCode();
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
