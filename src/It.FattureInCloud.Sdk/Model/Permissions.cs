/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.3
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
    /// Set of permissions.
    /// </summary>
    [DataContract(Name = "Permissions")]
    public partial class Permissions : IEquatable<Permissions>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets FicSituation
        /// </summary>
        [DataMember(Name = "fic_situation", EmitDefaultValue = false)]
        public PermissionLevel? FicSituation { get; set; }

        /// <summary>
        /// Gets or Sets FicClients
        /// </summary>
        [DataMember(Name = "fic_clients", EmitDefaultValue = false)]
        public PermissionLevel? FicClients { get; set; }

        /// <summary>
        /// Gets or Sets FicSuppliers
        /// </summary>
        [DataMember(Name = "fic_suppliers", EmitDefaultValue = false)]
        public PermissionLevel? FicSuppliers { get; set; }

        /// <summary>
        /// Gets or Sets FicProducts
        /// </summary>
        [DataMember(Name = "fic_products", EmitDefaultValue = false)]
        public PermissionLevel? FicProducts { get; set; }

        /// <summary>
        /// Gets or Sets FicIssuedDocuments
        /// </summary>
        [DataMember(Name = "fic_issued_documents", EmitDefaultValue = false)]
        public PermissionLevel? FicIssuedDocuments { get; set; }

        /// <summary>
        /// Gets or Sets FicReceivedDocuments
        /// </summary>
        [DataMember(Name = "fic_received_documents", EmitDefaultValue = false)]
        public PermissionLevel? FicReceivedDocuments { get; set; }

        /// <summary>
        /// Gets or Sets FicReceipts
        /// </summary>
        [DataMember(Name = "fic_receipts", EmitDefaultValue = false)]
        public PermissionLevel? FicReceipts { get; set; }

        /// <summary>
        /// Gets or Sets FicCalendar
        /// </summary>
        [DataMember(Name = "fic_calendar", EmitDefaultValue = false)]
        public PermissionLevel? FicCalendar { get; set; }

        /// <summary>
        /// Gets or Sets FicArchive
        /// </summary>
        [DataMember(Name = "fic_archive", EmitDefaultValue = false)]
        public PermissionLevel? FicArchive { get; set; }

        /// <summary>
        /// Gets or Sets FicTaxes
        /// </summary>
        [DataMember(Name = "fic_taxes", EmitDefaultValue = false)]
        public PermissionLevel? FicTaxes { get; set; }

        /// <summary>
        /// Gets or Sets FicStock
        /// </summary>
        [DataMember(Name = "fic_stock", EmitDefaultValue = false)]
        public PermissionLevel? FicStock { get; set; }

        /// <summary>
        /// Gets or Sets FicCashbook
        /// </summary>
        [DataMember(Name = "fic_cashbook", EmitDefaultValue = false)]
        public PermissionLevel? FicCashbook { get; set; }

        /// <summary>
        /// Gets or Sets FicSettings
        /// </summary>
        [DataMember(Name = "fic_settings", EmitDefaultValue = false)]
        public PermissionLevel? FicSettings { get; set; }

        /// <summary>
        /// Gets or Sets FicEmails
        /// </summary>
        [DataMember(Name = "fic_emails", EmitDefaultValue = false)]
        public PermissionLevel? FicEmails { get; set; }

        /// <summary>
        /// Gets or Sets FicExport
        /// </summary>
        [DataMember(Name = "fic_export", EmitDefaultValue = false)]
        public PermissionLevel? FicExport { get; set; }

        /// <summary>
        /// Gets or Sets FicImportBankstatements
        /// </summary>
        [DataMember(Name = "fic_import_bankstatements", EmitDefaultValue = false)]
        public PermissionLevel? FicImportBankstatements { get; set; }

        /// <summary>
        /// Gets or Sets FicImportClientsSuppliers
        /// </summary>
        [DataMember(Name = "fic_import_clients_suppliers", EmitDefaultValue = false)]
        public PermissionLevel? FicImportClientsSuppliers { get; set; }

        /// <summary>
        /// Gets or Sets FicImportIssuedDocuments
        /// </summary>
        [DataMember(Name = "fic_import_issued_documents", EmitDefaultValue = false)]
        public PermissionLevel? FicImportIssuedDocuments { get; set; }

        /// <summary>
        /// Gets or Sets FicImportProducts
        /// </summary>
        [DataMember(Name = "fic_import_products", EmitDefaultValue = false)]
        public PermissionLevel? FicImportProducts { get; set; }

        /// <summary>
        /// Gets or Sets FicRecurring
        /// </summary>
        [DataMember(Name = "fic_recurring", EmitDefaultValue = false)]
        public PermissionLevel? FicRecurring { get; set; }

        /// <summary>
        /// Gets or Sets FicRiba
        /// </summary>
        [DataMember(Name = "fic_riba", EmitDefaultValue = false)]
        public PermissionLevel? FicRiba { get; set; }

        /// <summary>
        /// Gets or Sets DicEmployees
        /// </summary>
        [DataMember(Name = "dic_employees", EmitDefaultValue = false)]
        public PermissionLevel? DicEmployees { get; set; }

        /// <summary>
        /// Gets or Sets DicSettings
        /// </summary>
        [DataMember(Name = "dic_settings", EmitDefaultValue = false)]
        public PermissionLevel? DicSettings { get; set; }

        /// <summary>
        /// Gets or Sets DicTimesheet
        /// </summary>
        [DataMember(Name = "dic_timesheet", EmitDefaultValue = false)]
        public PermissionLevel? DicTimesheet { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Permissions" /> class.
        /// </summary>
        /// <param name="ficSituation">ficSituation.</param>
        /// <param name="ficClients">ficClients.</param>
        /// <param name="ficSuppliers">ficSuppliers.</param>
        /// <param name="ficProducts">ficProducts.</param>
        /// <param name="ficIssuedDocuments">ficIssuedDocuments.</param>
        /// <param name="ficReceivedDocuments">ficReceivedDocuments.</param>
        /// <param name="ficReceipts">ficReceipts.</param>
        /// <param name="ficCalendar">ficCalendar.</param>
        /// <param name="ficArchive">ficArchive.</param>
        /// <param name="ficTaxes">ficTaxes.</param>
        /// <param name="ficStock">ficStock.</param>
        /// <param name="ficCashbook">ficCashbook.</param>
        /// <param name="ficSettings">ficSettings.</param>
        /// <param name="ficEmails">ficEmails.</param>
        /// <param name="ficExport">ficExport.</param>
        /// <param name="ficImportBankstatements">ficImportBankstatements.</param>
        /// <param name="ficImportClientsSuppliers">ficImportClientsSuppliers.</param>
        /// <param name="ficImportIssuedDocuments">ficImportIssuedDocuments.</param>
        /// <param name="ficImportProducts">ficImportProducts.</param>
        /// <param name="ficRecurring">ficRecurring.</param>
        /// <param name="ficRiba">ficRiba.</param>
        /// <param name="dicEmployees">dicEmployees.</param>
        /// <param name="dicSettings">dicSettings.</param>
        /// <param name="dicTimesheet">dicTimesheet.</param>
        /// <param name="ficIssuedDocumentsDetailed">ficIssuedDocumentsDetailed.</param>
        public Permissions(PermissionLevel? ficSituation = default(PermissionLevel?), PermissionLevel? ficClients = default(PermissionLevel?), PermissionLevel? ficSuppliers = default(PermissionLevel?), PermissionLevel? ficProducts = default(PermissionLevel?), PermissionLevel? ficIssuedDocuments = default(PermissionLevel?), PermissionLevel? ficReceivedDocuments = default(PermissionLevel?), PermissionLevel? ficReceipts = default(PermissionLevel?), PermissionLevel? ficCalendar = default(PermissionLevel?), PermissionLevel? ficArchive = default(PermissionLevel?), PermissionLevel? ficTaxes = default(PermissionLevel?), PermissionLevel? ficStock = default(PermissionLevel?), PermissionLevel? ficCashbook = default(PermissionLevel?), PermissionLevel? ficSettings = default(PermissionLevel?), PermissionLevel? ficEmails = default(PermissionLevel?), PermissionLevel? ficExport = default(PermissionLevel?), PermissionLevel? ficImportBankstatements = default(PermissionLevel?), PermissionLevel? ficImportClientsSuppliers = default(PermissionLevel?), PermissionLevel? ficImportIssuedDocuments = default(PermissionLevel?), PermissionLevel? ficImportProducts = default(PermissionLevel?), PermissionLevel? ficRecurring = default(PermissionLevel?), PermissionLevel? ficRiba = default(PermissionLevel?), PermissionLevel? dicEmployees = default(PermissionLevel?), PermissionLevel? dicSettings = default(PermissionLevel?), PermissionLevel? dicTimesheet = default(PermissionLevel?), PermissionsFicIssuedDocumentsDetailed ficIssuedDocumentsDetailed = default(PermissionsFicIssuedDocumentsDetailed))
        {
            this.FicSituation = ficSituation;
            this.FicClients = ficClients;
            this.FicSuppliers = ficSuppliers;
            this.FicProducts = ficProducts;
            this.FicIssuedDocuments = ficIssuedDocuments;
            this.FicReceivedDocuments = ficReceivedDocuments;
            this.FicReceipts = ficReceipts;
            this.FicCalendar = ficCalendar;
            this.FicArchive = ficArchive;
            this.FicTaxes = ficTaxes;
            this.FicStock = ficStock;
            this.FicCashbook = ficCashbook;
            this.FicSettings = ficSettings;
            this.FicEmails = ficEmails;
            this.FicExport = ficExport;
            this.FicImportBankstatements = ficImportBankstatements;
            this.FicImportClientsSuppliers = ficImportClientsSuppliers;
            this.FicImportIssuedDocuments = ficImportIssuedDocuments;
            this.FicImportProducts = ficImportProducts;
            this.FicRecurring = ficRecurring;
            this.FicRiba = ficRiba;
            this.DicEmployees = dicEmployees;
            this.DicSettings = dicSettings;
            this.DicTimesheet = dicTimesheet;
            this.FicIssuedDocumentsDetailed = ficIssuedDocumentsDetailed;
        }

        /// <summary>
        /// Gets or Sets FicIssuedDocumentsDetailed
        /// </summary>
        [DataMember(Name = "fic_issued_documents_detailed", EmitDefaultValue = false)]
        public PermissionsFicIssuedDocumentsDetailed FicIssuedDocumentsDetailed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Permissions {\n");
            sb.Append("  FicSituation: ").Append(FicSituation).Append("\n");
            sb.Append("  FicClients: ").Append(FicClients).Append("\n");
            sb.Append("  FicSuppliers: ").Append(FicSuppliers).Append("\n");
            sb.Append("  FicProducts: ").Append(FicProducts).Append("\n");
            sb.Append("  FicIssuedDocuments: ").Append(FicIssuedDocuments).Append("\n");
            sb.Append("  FicReceivedDocuments: ").Append(FicReceivedDocuments).Append("\n");
            sb.Append("  FicReceipts: ").Append(FicReceipts).Append("\n");
            sb.Append("  FicCalendar: ").Append(FicCalendar).Append("\n");
            sb.Append("  FicArchive: ").Append(FicArchive).Append("\n");
            sb.Append("  FicTaxes: ").Append(FicTaxes).Append("\n");
            sb.Append("  FicStock: ").Append(FicStock).Append("\n");
            sb.Append("  FicCashbook: ").Append(FicCashbook).Append("\n");
            sb.Append("  FicSettings: ").Append(FicSettings).Append("\n");
            sb.Append("  FicEmails: ").Append(FicEmails).Append("\n");
            sb.Append("  FicExport: ").Append(FicExport).Append("\n");
            sb.Append("  FicImportBankstatements: ").Append(FicImportBankstatements).Append("\n");
            sb.Append("  FicImportClientsSuppliers: ").Append(FicImportClientsSuppliers).Append("\n");
            sb.Append("  FicImportIssuedDocuments: ").Append(FicImportIssuedDocuments).Append("\n");
            sb.Append("  FicImportProducts: ").Append(FicImportProducts).Append("\n");
            sb.Append("  FicRecurring: ").Append(FicRecurring).Append("\n");
            sb.Append("  FicRiba: ").Append(FicRiba).Append("\n");
            sb.Append("  DicEmployees: ").Append(DicEmployees).Append("\n");
            sb.Append("  DicSettings: ").Append(DicSettings).Append("\n");
            sb.Append("  DicTimesheet: ").Append(DicTimesheet).Append("\n");
            sb.Append("  FicIssuedDocumentsDetailed: ").Append(FicIssuedDocumentsDetailed).Append("\n");
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
            return this.Equals(input as Permissions);
        }

        /// <summary>
        /// Returns true if Permissions instances are equal
        /// </summary>
        /// <param name="input">Instance of Permissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Permissions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FicSituation == input.FicSituation ||
                    this.FicSituation.Equals(input.FicSituation)
                ) && 
                (
                    this.FicClients == input.FicClients ||
                    this.FicClients.Equals(input.FicClients)
                ) && 
                (
                    this.FicSuppliers == input.FicSuppliers ||
                    this.FicSuppliers.Equals(input.FicSuppliers)
                ) && 
                (
                    this.FicProducts == input.FicProducts ||
                    this.FicProducts.Equals(input.FicProducts)
                ) && 
                (
                    this.FicIssuedDocuments == input.FicIssuedDocuments ||
                    this.FicIssuedDocuments.Equals(input.FicIssuedDocuments)
                ) && 
                (
                    this.FicReceivedDocuments == input.FicReceivedDocuments ||
                    this.FicReceivedDocuments.Equals(input.FicReceivedDocuments)
                ) && 
                (
                    this.FicReceipts == input.FicReceipts ||
                    this.FicReceipts.Equals(input.FicReceipts)
                ) && 
                (
                    this.FicCalendar == input.FicCalendar ||
                    this.FicCalendar.Equals(input.FicCalendar)
                ) && 
                (
                    this.FicArchive == input.FicArchive ||
                    this.FicArchive.Equals(input.FicArchive)
                ) && 
                (
                    this.FicTaxes == input.FicTaxes ||
                    this.FicTaxes.Equals(input.FicTaxes)
                ) && 
                (
                    this.FicStock == input.FicStock ||
                    this.FicStock.Equals(input.FicStock)
                ) && 
                (
                    this.FicCashbook == input.FicCashbook ||
                    this.FicCashbook.Equals(input.FicCashbook)
                ) && 
                (
                    this.FicSettings == input.FicSettings ||
                    this.FicSettings.Equals(input.FicSettings)
                ) && 
                (
                    this.FicEmails == input.FicEmails ||
                    this.FicEmails.Equals(input.FicEmails)
                ) && 
                (
                    this.FicExport == input.FicExport ||
                    this.FicExport.Equals(input.FicExport)
                ) && 
                (
                    this.FicImportBankstatements == input.FicImportBankstatements ||
                    this.FicImportBankstatements.Equals(input.FicImportBankstatements)
                ) && 
                (
                    this.FicImportClientsSuppliers == input.FicImportClientsSuppliers ||
                    this.FicImportClientsSuppliers.Equals(input.FicImportClientsSuppliers)
                ) && 
                (
                    this.FicImportIssuedDocuments == input.FicImportIssuedDocuments ||
                    this.FicImportIssuedDocuments.Equals(input.FicImportIssuedDocuments)
                ) && 
                (
                    this.FicImportProducts == input.FicImportProducts ||
                    this.FicImportProducts.Equals(input.FicImportProducts)
                ) && 
                (
                    this.FicRecurring == input.FicRecurring ||
                    this.FicRecurring.Equals(input.FicRecurring)
                ) && 
                (
                    this.FicRiba == input.FicRiba ||
                    this.FicRiba.Equals(input.FicRiba)
                ) && 
                (
                    this.DicEmployees == input.DicEmployees ||
                    this.DicEmployees.Equals(input.DicEmployees)
                ) && 
                (
                    this.DicSettings == input.DicSettings ||
                    this.DicSettings.Equals(input.DicSettings)
                ) && 
                (
                    this.DicTimesheet == input.DicTimesheet ||
                    this.DicTimesheet.Equals(input.DicTimesheet)
                ) && 
                (
                    this.FicIssuedDocumentsDetailed == input.FicIssuedDocumentsDetailed ||
                    (this.FicIssuedDocumentsDetailed != null &&
                    this.FicIssuedDocumentsDetailed.Equals(input.FicIssuedDocumentsDetailed))
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
                hashCode = hashCode * 59 + this.FicSituation.GetHashCode();
                hashCode = hashCode * 59 + this.FicClients.GetHashCode();
                hashCode = hashCode * 59 + this.FicSuppliers.GetHashCode();
                hashCode = hashCode * 59 + this.FicProducts.GetHashCode();
                hashCode = hashCode * 59 + this.FicIssuedDocuments.GetHashCode();
                hashCode = hashCode * 59 + this.FicReceivedDocuments.GetHashCode();
                hashCode = hashCode * 59 + this.FicReceipts.GetHashCode();
                hashCode = hashCode * 59 + this.FicCalendar.GetHashCode();
                hashCode = hashCode * 59 + this.FicArchive.GetHashCode();
                hashCode = hashCode * 59 + this.FicTaxes.GetHashCode();
                hashCode = hashCode * 59 + this.FicStock.GetHashCode();
                hashCode = hashCode * 59 + this.FicCashbook.GetHashCode();
                hashCode = hashCode * 59 + this.FicSettings.GetHashCode();
                hashCode = hashCode * 59 + this.FicEmails.GetHashCode();
                hashCode = hashCode * 59 + this.FicExport.GetHashCode();
                hashCode = hashCode * 59 + this.FicImportBankstatements.GetHashCode();
                hashCode = hashCode * 59 + this.FicImportClientsSuppliers.GetHashCode();
                hashCode = hashCode * 59 + this.FicImportIssuedDocuments.GetHashCode();
                hashCode = hashCode * 59 + this.FicImportProducts.GetHashCode();
                hashCode = hashCode * 59 + this.FicRecurring.GetHashCode();
                hashCode = hashCode * 59 + this.FicRiba.GetHashCode();
                hashCode = hashCode * 59 + this.DicEmployees.GetHashCode();
                hashCode = hashCode * 59 + this.DicSettings.GetHashCode();
                hashCode = hashCode * 59 + this.DicTimesheet.GetHashCode();
                if (this.FicIssuedDocumentsDetailed != null)
                    hashCode = hashCode * 59 + this.FicIssuedDocumentsDetailed.GetHashCode();
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