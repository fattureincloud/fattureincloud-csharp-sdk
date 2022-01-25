/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.9
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
        public PermissionLevel? Quotes { get; set; }

        /// <summary>
        /// Gets or Sets Proformas
        /// </summary>
        [DataMember(Name = "proformas", EmitDefaultValue = false)]
        public PermissionLevel? Proformas { get; set; }

        /// <summary>
        /// Gets or Sets Invoices
        /// </summary>
        [DataMember(Name = "invoices", EmitDefaultValue = false)]
        public PermissionLevel? Invoices { get; set; }

        /// <summary>
        /// Gets or Sets Receipts
        /// </summary>
        [DataMember(Name = "receipts", EmitDefaultValue = false)]
        public PermissionLevel? Receipts { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryNotes
        /// </summary>
        [DataMember(Name = "delivery_notes", EmitDefaultValue = false)]
        public PermissionLevel? DeliveryNotes { get; set; }

        /// <summary>
        /// Gets or Sets CreditNotes
        /// </summary>
        [DataMember(Name = "credit_notes", EmitDefaultValue = false)]
        public PermissionLevel? CreditNotes { get; set; }

        /// <summary>
        /// Gets or Sets Orders
        /// </summary>
        [DataMember(Name = "orders", EmitDefaultValue = false)]
        public PermissionLevel? Orders { get; set; }

        /// <summary>
        /// Gets or Sets WorkReports
        /// </summary>
        [DataMember(Name = "work_reports", EmitDefaultValue = false)]
        public PermissionLevel? WorkReports { get; set; }

        /// <summary>
        /// Gets or Sets SupplierOrders
        /// </summary>
        [DataMember(Name = "supplier_orders", EmitDefaultValue = false)]
        public PermissionLevel? SupplierOrders { get; set; }

        /// <summary>
        /// Gets or Sets SelfInvoices
        /// </summary>
        [DataMember(Name = "self_invoices", EmitDefaultValue = false)]
        public PermissionLevel? SelfInvoices { get; set; }
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
            this.Quotes = quotes;
            this.Proformas = proformas;
            this.Invoices = invoices;
            this.Receipts = receipts;
            this.DeliveryNotes = deliveryNotes;
            this.CreditNotes = creditNotes;
            this.Orders = orders;
            this.WorkReports = workReports;
            this.SupplierOrders = supplierOrders;
            this.SelfInvoices = selfInvoices;
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
