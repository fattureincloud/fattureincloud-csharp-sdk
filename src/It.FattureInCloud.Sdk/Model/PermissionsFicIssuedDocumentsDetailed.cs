/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.31
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
    /// PermissionsFicIssuedDocumentsDetailed
    /// </summary>
    [DataContract(Name = "Permissions_fic_issued_documents_detailed")]
    public partial class PermissionsFicIssuedDocumentsDetailed : IEquatable<PermissionsFicIssuedDocumentsDetailed>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Quotes
        /// </summary>

        [DataMember(Name = "quotes", EmitDefaultValue = false)]
        public PermissionLevel? Quotes
        {
            get { return _Quotes; }
            set
            {
                _Quotes = value;
                _flagQuotes = true;
            }
        }
        private PermissionLevel? _Quotes;
        private bool _flagQuotes;

        /// <summary>
        /// Returns false as Quotes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeQuotes()
        {
            return _flagQuotes;
        }

        /// <summary>
        /// Gets or Sets Proformas
        /// </summary>

        [DataMember(Name = "proformas", EmitDefaultValue = false)]
        public PermissionLevel? Proformas
        {
            get { return _Proformas; }
            set
            {
                _Proformas = value;
                _flagProformas = true;
            }
        }
        private PermissionLevel? _Proformas;
        private bool _flagProformas;

        /// <summary>
        /// Returns false as Proformas should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProformas()
        {
            return _flagProformas;
        }

        /// <summary>
        /// Gets or Sets Invoices
        /// </summary>

        [DataMember(Name = "invoices", EmitDefaultValue = false)]
        public PermissionLevel? Invoices
        {
            get { return _Invoices; }
            set
            {
                _Invoices = value;
                _flagInvoices = true;
            }
        }
        private PermissionLevel? _Invoices;
        private bool _flagInvoices;

        /// <summary>
        /// Returns false as Invoices should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInvoices()
        {
            return _flagInvoices;
        }

        /// <summary>
        /// Gets or Sets Receipts
        /// </summary>

        [DataMember(Name = "receipts", EmitDefaultValue = false)]
        public PermissionLevel? Receipts
        {
            get { return _Receipts; }
            set
            {
                _Receipts = value;
                _flagReceipts = true;
            }
        }
        private PermissionLevel? _Receipts;
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
        /// Gets or Sets DeliveryNotes
        /// </summary>

        [DataMember(Name = "delivery_notes", EmitDefaultValue = false)]
        public PermissionLevel? DeliveryNotes
        {
            get { return _DeliveryNotes; }
            set
            {
                _DeliveryNotes = value;
                _flagDeliveryNotes = true;
            }
        }
        private PermissionLevel? _DeliveryNotes;
        private bool _flagDeliveryNotes;

        /// <summary>
        /// Returns false as DeliveryNotes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeliveryNotes()
        {
            return _flagDeliveryNotes;
        }

        /// <summary>
        /// Gets or Sets CreditNotes
        /// </summary>

        [DataMember(Name = "credit_notes", EmitDefaultValue = false)]
        public PermissionLevel? CreditNotes
        {
            get { return _CreditNotes; }
            set
            {
                _CreditNotes = value;
                _flagCreditNotes = true;
            }
        }
        private PermissionLevel? _CreditNotes;
        private bool _flagCreditNotes;

        /// <summary>
        /// Returns false as CreditNotes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreditNotes()
        {
            return _flagCreditNotes;
        }

        /// <summary>
        /// Gets or Sets Orders
        /// </summary>

        [DataMember(Name = "orders", EmitDefaultValue = false)]
        public PermissionLevel? Orders
        {
            get { return _Orders; }
            set
            {
                _Orders = value;
                _flagOrders = true;
            }
        }
        private PermissionLevel? _Orders;
        private bool _flagOrders;

        /// <summary>
        /// Returns false as Orders should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOrders()
        {
            return _flagOrders;
        }

        /// <summary>
        /// Gets or Sets WorkReports
        /// </summary>

        [DataMember(Name = "work_reports", EmitDefaultValue = false)]
        public PermissionLevel? WorkReports
        {
            get { return _WorkReports; }
            set
            {
                _WorkReports = value;
                _flagWorkReports = true;
            }
        }
        private PermissionLevel? _WorkReports;
        private bool _flagWorkReports;

        /// <summary>
        /// Returns false as WorkReports should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWorkReports()
        {
            return _flagWorkReports;
        }

        /// <summary>
        /// Gets or Sets SupplierOrders
        /// </summary>

        [DataMember(Name = "supplier_orders", EmitDefaultValue = false)]
        public PermissionLevel? SupplierOrders
        {
            get { return _SupplierOrders; }
            set
            {
                _SupplierOrders = value;
                _flagSupplierOrders = true;
            }
        }
        private PermissionLevel? _SupplierOrders;
        private bool _flagSupplierOrders;

        /// <summary>
        /// Returns false as SupplierOrders should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSupplierOrders()
        {
            return _flagSupplierOrders;
        }

        /// <summary>
        /// Gets or Sets SelfInvoices
        /// </summary>

        [DataMember(Name = "self_invoices", EmitDefaultValue = false)]
        public PermissionLevel? SelfInvoices
        {
            get { return _SelfInvoices; }
            set
            {
                _SelfInvoices = value;
                _flagSelfInvoices = true;
            }
        }
        private PermissionLevel? _SelfInvoices;
        private bool _flagSelfInvoices;

        /// <summary>
        /// Returns false as SelfInvoices should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSelfInvoices()
        {
            return _flagSelfInvoices;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionsFicIssuedDocumentsDetailed" /> class.
        /// </summary>
        /// <param name="quotes">quotes.</param>
        /// <param name="proformas">proformas.</param>
        /// <param name="invoices">invoices.</param>
        /// <param name="receipts">receipts.</param>
        /// <param name="deliveryNotes">deliveryNotes.</param>
        /// <param name="creditNotes">creditNotes.</param>
        /// <param name="orders">orders.</param>
        /// <param name="workReports">workReports.</param>
        /// <param name="supplierOrders">supplierOrders.</param>
        /// <param name="selfInvoices">selfInvoices.</param>
        public PermissionsFicIssuedDocumentsDetailed(PermissionLevel? quotes = default(PermissionLevel?), PermissionLevel? proformas = default(PermissionLevel?), PermissionLevel? invoices = default(PermissionLevel?), PermissionLevel? receipts = default(PermissionLevel?), PermissionLevel? deliveryNotes = default(PermissionLevel?), PermissionLevel? creditNotes = default(PermissionLevel?), PermissionLevel? orders = default(PermissionLevel?), PermissionLevel? workReports = default(PermissionLevel?), PermissionLevel? supplierOrders = default(PermissionLevel?), PermissionLevel? selfInvoices = default(PermissionLevel?))
        {
            this._Quotes = quotes;
            if (this.Quotes != null)
            {
                this._flagQuotes = true;
            }
            this._Proformas = proformas;
            if (this.Proformas != null)
            {
                this._flagProformas = true;
            }
            this._Invoices = invoices;
            if (this.Invoices != null)
            {
                this._flagInvoices = true;
            }
            this._Receipts = receipts;
            if (this.Receipts != null)
            {
                this._flagReceipts = true;
            }
            this._DeliveryNotes = deliveryNotes;
            if (this.DeliveryNotes != null)
            {
                this._flagDeliveryNotes = true;
            }
            this._CreditNotes = creditNotes;
            if (this.CreditNotes != null)
            {
                this._flagCreditNotes = true;
            }
            this._Orders = orders;
            if (this.Orders != null)
            {
                this._flagOrders = true;
            }
            this._WorkReports = workReports;
            if (this.WorkReports != null)
            {
                this._flagWorkReports = true;
            }
            this._SupplierOrders = supplierOrders;
            if (this.SupplierOrders != null)
            {
                this._flagSupplierOrders = true;
            }
            this._SelfInvoices = selfInvoices;
            if (this.SelfInvoices != null)
            {
                this._flagSelfInvoices = true;
            }
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PermissionsFicIssuedDocumentsDetailed {\n");
            sb.Append("  Quotes: ").Append(Quotes).Append("\n");
            sb.Append("  Proformas: ").Append(Proformas).Append("\n");
            sb.Append("  Invoices: ").Append(Invoices).Append("\n");
            sb.Append("  Receipts: ").Append(Receipts).Append("\n");
            sb.Append("  DeliveryNotes: ").Append(DeliveryNotes).Append("\n");
            sb.Append("  CreditNotes: ").Append(CreditNotes).Append("\n");
            sb.Append("  Orders: ").Append(Orders).Append("\n");
            sb.Append("  WorkReports: ").Append(WorkReports).Append("\n");
            sb.Append("  SupplierOrders: ").Append(SupplierOrders).Append("\n");
            sb.Append("  SelfInvoices: ").Append(SelfInvoices).Append("\n");
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
            return this.Equals(input as PermissionsFicIssuedDocumentsDetailed);
        }

        /// <summary>
        /// Returns true if PermissionsFicIssuedDocumentsDetailed instances are equal
        /// </summary>
        /// <param name="input">Instance of PermissionsFicIssuedDocumentsDetailed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionsFicIssuedDocumentsDetailed input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Quotes == input.Quotes ||
                    this.Quotes.Equals(input.Quotes)
                ) &&
                (
                    this.Proformas == input.Proformas ||
                    this.Proformas.Equals(input.Proformas)
                ) &&
                (
                    this.Invoices == input.Invoices ||
                    this.Invoices.Equals(input.Invoices)
                ) &&
                (
                    this.Receipts == input.Receipts ||
                    this.Receipts.Equals(input.Receipts)
                ) &&
                (
                    this.DeliveryNotes == input.DeliveryNotes ||
                    this.DeliveryNotes.Equals(input.DeliveryNotes)
                ) &&
                (
                    this.CreditNotes == input.CreditNotes ||
                    this.CreditNotes.Equals(input.CreditNotes)
                ) &&
                (
                    this.Orders == input.Orders ||
                    this.Orders.Equals(input.Orders)
                ) &&
                (
                    this.WorkReports == input.WorkReports ||
                    this.WorkReports.Equals(input.WorkReports)
                ) &&
                (
                    this.SupplierOrders == input.SupplierOrders ||
                    this.SupplierOrders.Equals(input.SupplierOrders)
                ) &&
                (
                    this.SelfInvoices == input.SelfInvoices ||
                    this.SelfInvoices.Equals(input.SelfInvoices)
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
                hashCode = (hashCode * 59) + this.Quotes.GetHashCode();
                hashCode = (hashCode * 59) + this.Proformas.GetHashCode();
                hashCode = (hashCode * 59) + this.Invoices.GetHashCode();
                hashCode = (hashCode * 59) + this.Receipts.GetHashCode();
                hashCode = (hashCode * 59) + this.DeliveryNotes.GetHashCode();
                hashCode = (hashCode * 59) + this.CreditNotes.GetHashCode();
                hashCode = (hashCode * 59) + this.Orders.GetHashCode();
                hashCode = (hashCode * 59) + this.WorkReports.GetHashCode();
                hashCode = (hashCode * 59) + this.SupplierOrders.GetHashCode();
                hashCode = (hashCode * 59) + this.SelfInvoices.GetHashCode();
                return hashCode;
            }
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
