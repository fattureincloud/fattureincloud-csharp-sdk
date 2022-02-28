/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.13
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
    /// Permissions
    /// </summary>
    [DataContract(Name = "Permissions")]
    public partial class Permissions : IEquatable<Permissions>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets FicSituation
        /// </summary>

        [DataMember(Name = "fic_situation", EmitDefaultValue = false)]
        public PermissionLevel? FicSituation
        {
            get{ return _FicSituation;}
            set
            {
                _FicSituation = value;
                _flagFicSituation = true;
            }
        }
        private PermissionLevel? _FicSituation;
        private bool _flagFicSituation;

        /// <summary>
        /// Returns false as FicSituation should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicSituation()
        {
            return _flagFicSituation;
        }

        /// <summary>
        /// Gets or Sets FicClients
        /// </summary>

        [DataMember(Name = "fic_clients", EmitDefaultValue = false)]
        public PermissionLevel? FicClients
        {
            get{ return _FicClients;}
            set
            {
                _FicClients = value;
                _flagFicClients = true;
            }
        }
        private PermissionLevel? _FicClients;
        private bool _flagFicClients;

        /// <summary>
        /// Returns false as FicClients should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicClients()
        {
            return _flagFicClients;
        }

        /// <summary>
        /// Gets or Sets FicSuppliers
        /// </summary>

        [DataMember(Name = "fic_suppliers", EmitDefaultValue = false)]
        public PermissionLevel? FicSuppliers
        {
            get{ return _FicSuppliers;}
            set
            {
                _FicSuppliers = value;
                _flagFicSuppliers = true;
            }
        }
        private PermissionLevel? _FicSuppliers;
        private bool _flagFicSuppliers;

        /// <summary>
        /// Returns false as FicSuppliers should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicSuppliers()
        {
            return _flagFicSuppliers;
        }

        /// <summary>
        /// Gets or Sets FicProducts
        /// </summary>

        [DataMember(Name = "fic_products", EmitDefaultValue = false)]
        public PermissionLevel? FicProducts
        {
            get{ return _FicProducts;}
            set
            {
                _FicProducts = value;
                _flagFicProducts = true;
            }
        }
        private PermissionLevel? _FicProducts;
        private bool _flagFicProducts;

        /// <summary>
        /// Returns false as FicProducts should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicProducts()
        {
            return _flagFicProducts;
        }

        /// <summary>
        /// Gets or Sets FicIssuedDocuments
        /// </summary>

        [DataMember(Name = "fic_issued_documents", EmitDefaultValue = false)]
        public PermissionLevel? FicIssuedDocuments
        {
            get{ return _FicIssuedDocuments;}
            set
            {
                _FicIssuedDocuments = value;
                _flagFicIssuedDocuments = true;
            }
        }
        private PermissionLevel? _FicIssuedDocuments;
        private bool _flagFicIssuedDocuments;

        /// <summary>
        /// Returns false as FicIssuedDocuments should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicIssuedDocuments()
        {
            return _flagFicIssuedDocuments;
        }

        /// <summary>
        /// Gets or Sets FicReceivedDocuments
        /// </summary>

        [DataMember(Name = "fic_received_documents", EmitDefaultValue = false)]
        public PermissionLevel? FicReceivedDocuments
        {
            get{ return _FicReceivedDocuments;}
            set
            {
                _FicReceivedDocuments = value;
                _flagFicReceivedDocuments = true;
            }
        }
        private PermissionLevel? _FicReceivedDocuments;
        private bool _flagFicReceivedDocuments;

        /// <summary>
        /// Returns false as FicReceivedDocuments should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicReceivedDocuments()
        {
            return _flagFicReceivedDocuments;
        }

        /// <summary>
        /// Gets or Sets FicReceipts
        /// </summary>

        [DataMember(Name = "fic_receipts", EmitDefaultValue = false)]
        public PermissionLevel? FicReceipts
        {
            get{ return _FicReceipts;}
            set
            {
                _FicReceipts = value;
                _flagFicReceipts = true;
            }
        }
        private PermissionLevel? _FicReceipts;
        private bool _flagFicReceipts;

        /// <summary>
        /// Returns false as FicReceipts should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicReceipts()
        {
            return _flagFicReceipts;
        }

        /// <summary>
        /// Gets or Sets FicCalendar
        /// </summary>

        [DataMember(Name = "fic_calendar", EmitDefaultValue = false)]
        public PermissionLevel? FicCalendar
        {
            get{ return _FicCalendar;}
            set
            {
                _FicCalendar = value;
                _flagFicCalendar = true;
            }
        }
        private PermissionLevel? _FicCalendar;
        private bool _flagFicCalendar;

        /// <summary>
        /// Returns false as FicCalendar should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicCalendar()
        {
            return _flagFicCalendar;
        }

        /// <summary>
        /// Gets or Sets FicArchive
        /// </summary>

        [DataMember(Name = "fic_archive", EmitDefaultValue = false)]
        public PermissionLevel? FicArchive
        {
            get{ return _FicArchive;}
            set
            {
                _FicArchive = value;
                _flagFicArchive = true;
            }
        }
        private PermissionLevel? _FicArchive;
        private bool _flagFicArchive;

        /// <summary>
        /// Returns false as FicArchive should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicArchive()
        {
            return _flagFicArchive;
        }

        /// <summary>
        /// Gets or Sets FicTaxes
        /// </summary>

        [DataMember(Name = "fic_taxes", EmitDefaultValue = false)]
        public PermissionLevel? FicTaxes
        {
            get{ return _FicTaxes;}
            set
            {
                _FicTaxes = value;
                _flagFicTaxes = true;
            }
        }
        private PermissionLevel? _FicTaxes;
        private bool _flagFicTaxes;

        /// <summary>
        /// Returns false as FicTaxes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicTaxes()
        {
            return _flagFicTaxes;
        }

        /// <summary>
        /// Gets or Sets FicStock
        /// </summary>

        [DataMember(Name = "fic_stock", EmitDefaultValue = false)]
        public PermissionLevel? FicStock
        {
            get{ return _FicStock;}
            set
            {
                _FicStock = value;
                _flagFicStock = true;
            }
        }
        private PermissionLevel? _FicStock;
        private bool _flagFicStock;

        /// <summary>
        /// Returns false as FicStock should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicStock()
        {
            return _flagFicStock;
        }

        /// <summary>
        /// Gets or Sets FicCashbook
        /// </summary>

        [DataMember(Name = "fic_cashbook", EmitDefaultValue = false)]
        public PermissionLevel? FicCashbook
        {
            get{ return _FicCashbook;}
            set
            {
                _FicCashbook = value;
                _flagFicCashbook = true;
            }
        }
        private PermissionLevel? _FicCashbook;
        private bool _flagFicCashbook;

        /// <summary>
        /// Returns false as FicCashbook should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicCashbook()
        {
            return _flagFicCashbook;
        }

        /// <summary>
        /// Gets or Sets FicSettings
        /// </summary>

        [DataMember(Name = "fic_settings", EmitDefaultValue = false)]
        public PermissionLevel? FicSettings
        {
            get{ return _FicSettings;}
            set
            {
                _FicSettings = value;
                _flagFicSettings = true;
            }
        }
        private PermissionLevel? _FicSettings;
        private bool _flagFicSettings;

        /// <summary>
        /// Returns false as FicSettings should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicSettings()
        {
            return _flagFicSettings;
        }

        /// <summary>
        /// Gets or Sets FicEmails
        /// </summary>

        [DataMember(Name = "fic_emails", EmitDefaultValue = false)]
        public PermissionLevel? FicEmails
        {
            get{ return _FicEmails;}
            set
            {
                _FicEmails = value;
                _flagFicEmails = true;
            }
        }
        private PermissionLevel? _FicEmails;
        private bool _flagFicEmails;

        /// <summary>
        /// Returns false as FicEmails should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicEmails()
        {
            return _flagFicEmails;
        }

        /// <summary>
        /// Gets or Sets FicExport
        /// </summary>

        [DataMember(Name = "fic_export", EmitDefaultValue = false)]
        public PermissionLevel? FicExport
        {
            get{ return _FicExport;}
            set
            {
                _FicExport = value;
                _flagFicExport = true;
            }
        }
        private PermissionLevel? _FicExport;
        private bool _flagFicExport;

        /// <summary>
        /// Returns false as FicExport should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicExport()
        {
            return _flagFicExport;
        }

        /// <summary>
        /// Gets or Sets FicImportBankstatements
        /// </summary>

        [DataMember(Name = "fic_import_bankstatements", EmitDefaultValue = false)]
        public PermissionLevel? FicImportBankstatements
        {
            get{ return _FicImportBankstatements;}
            set
            {
                _FicImportBankstatements = value;
                _flagFicImportBankstatements = true;
            }
        }
        private PermissionLevel? _FicImportBankstatements;
        private bool _flagFicImportBankstatements;

        /// <summary>
        /// Returns false as FicImportBankstatements should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicImportBankstatements()
        {
            return _flagFicImportBankstatements;
        }

        /// <summary>
        /// Gets or Sets FicImportClientsSuppliers
        /// </summary>

        [DataMember(Name = "fic_import_clients_suppliers", EmitDefaultValue = false)]
        public PermissionLevel? FicImportClientsSuppliers
        {
            get{ return _FicImportClientsSuppliers;}
            set
            {
                _FicImportClientsSuppliers = value;
                _flagFicImportClientsSuppliers = true;
            }
        }
        private PermissionLevel? _FicImportClientsSuppliers;
        private bool _flagFicImportClientsSuppliers;

        /// <summary>
        /// Returns false as FicImportClientsSuppliers should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicImportClientsSuppliers()
        {
            return _flagFicImportClientsSuppliers;
        }

        /// <summary>
        /// Gets or Sets FicImportIssuedDocuments
        /// </summary>

        [DataMember(Name = "fic_import_issued_documents", EmitDefaultValue = false)]
        public PermissionLevel? FicImportIssuedDocuments
        {
            get{ return _FicImportIssuedDocuments;}
            set
            {
                _FicImportIssuedDocuments = value;
                _flagFicImportIssuedDocuments = true;
            }
        }
        private PermissionLevel? _FicImportIssuedDocuments;
        private bool _flagFicImportIssuedDocuments;

        /// <summary>
        /// Returns false as FicImportIssuedDocuments should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicImportIssuedDocuments()
        {
            return _flagFicImportIssuedDocuments;
        }

        /// <summary>
        /// Gets or Sets FicImportProducts
        /// </summary>

        [DataMember(Name = "fic_import_products", EmitDefaultValue = false)]
        public PermissionLevel? FicImportProducts
        {
            get{ return _FicImportProducts;}
            set
            {
                _FicImportProducts = value;
                _flagFicImportProducts = true;
            }
        }
        private PermissionLevel? _FicImportProducts;
        private bool _flagFicImportProducts;

        /// <summary>
        /// Returns false as FicImportProducts should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicImportProducts()
        {
            return _flagFicImportProducts;
        }

        /// <summary>
        /// Gets or Sets FicRecurring
        /// </summary>

        [DataMember(Name = "fic_recurring", EmitDefaultValue = false)]
        public PermissionLevel? FicRecurring
        {
            get{ return _FicRecurring;}
            set
            {
                _FicRecurring = value;
                _flagFicRecurring = true;
            }
        }
        private PermissionLevel? _FicRecurring;
        private bool _flagFicRecurring;

        /// <summary>
        /// Returns false as FicRecurring should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicRecurring()
        {
            return _flagFicRecurring;
        }

        /// <summary>
        /// Gets or Sets FicRiba
        /// </summary>

        [DataMember(Name = "fic_riba", EmitDefaultValue = false)]
        public PermissionLevel? FicRiba
        {
            get{ return _FicRiba;}
            set
            {
                _FicRiba = value;
                _flagFicRiba = true;
            }
        }
        private PermissionLevel? _FicRiba;
        private bool _flagFicRiba;

        /// <summary>
        /// Returns false as FicRiba should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicRiba()
        {
            return _flagFicRiba;
        }

        /// <summary>
        /// Gets or Sets DicEmployees
        /// </summary>

        [DataMember(Name = "dic_employees", EmitDefaultValue = false)]
        public PermissionLevel? DicEmployees
        {
            get{ return _DicEmployees;}
            set
            {
                _DicEmployees = value;
                _flagDicEmployees = true;
            }
        }
        private PermissionLevel? _DicEmployees;
        private bool _flagDicEmployees;

        /// <summary>
        /// Returns false as DicEmployees should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDicEmployees()
        {
            return _flagDicEmployees;
        }

        /// <summary>
        /// Gets or Sets DicSettings
        /// </summary>

        [DataMember(Name = "dic_settings", EmitDefaultValue = false)]
        public PermissionLevel? DicSettings
        {
            get{ return _DicSettings;}
            set
            {
                _DicSettings = value;
                _flagDicSettings = true;
            }
        }
        private PermissionLevel? _DicSettings;
        private bool _flagDicSettings;

        /// <summary>
        /// Returns false as DicSettings should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDicSettings()
        {
            return _flagDicSettings;
        }

        /// <summary>
        /// Gets or Sets DicTimesheet
        /// </summary>

        [DataMember(Name = "dic_timesheet", EmitDefaultValue = false)]
        public PermissionLevel? DicTimesheet
        {
            get{ return _DicTimesheet;}
            set
            {
                _DicTimesheet = value;
                _flagDicTimesheet = true;
            }
        }
        private PermissionLevel? _DicTimesheet;
        private bool _flagDicTimesheet;

        /// <summary>
        /// Returns false as DicTimesheet should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDicTimesheet()
        {
            return _flagDicTimesheet;
        }
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
            this._FicSituation = ficSituation;
            if (this.FicSituation != null) this._flagFicSituation = true;
            this._FicClients = ficClients;
            if (this.FicClients != null) this._flagFicClients = true;
            this._FicSuppliers = ficSuppliers;
            if (this.FicSuppliers != null) this._flagFicSuppliers = true;
            this._FicProducts = ficProducts;
            if (this.FicProducts != null) this._flagFicProducts = true;
            this._FicIssuedDocuments = ficIssuedDocuments;
            if (this.FicIssuedDocuments != null) this._flagFicIssuedDocuments = true;
            this._FicReceivedDocuments = ficReceivedDocuments;
            if (this.FicReceivedDocuments != null) this._flagFicReceivedDocuments = true;
            this._FicReceipts = ficReceipts;
            if (this.FicReceipts != null) this._flagFicReceipts = true;
            this._FicCalendar = ficCalendar;
            if (this.FicCalendar != null) this._flagFicCalendar = true;
            this._FicArchive = ficArchive;
            if (this.FicArchive != null) this._flagFicArchive = true;
            this._FicTaxes = ficTaxes;
            if (this.FicTaxes != null) this._flagFicTaxes = true;
            this._FicStock = ficStock;
            if (this.FicStock != null) this._flagFicStock = true;
            this._FicCashbook = ficCashbook;
            if (this.FicCashbook != null) this._flagFicCashbook = true;
            this._FicSettings = ficSettings;
            if (this.FicSettings != null) this._flagFicSettings = true;
            this._FicEmails = ficEmails;
            if (this.FicEmails != null) this._flagFicEmails = true;
            this._FicExport = ficExport;
            if (this.FicExport != null) this._flagFicExport = true;
            this._FicImportBankstatements = ficImportBankstatements;
            if (this.FicImportBankstatements != null) this._flagFicImportBankstatements = true;
            this._FicImportClientsSuppliers = ficImportClientsSuppliers;
            if (this.FicImportClientsSuppliers != null) this._flagFicImportClientsSuppliers = true;
            this._FicImportIssuedDocuments = ficImportIssuedDocuments;
            if (this.FicImportIssuedDocuments != null) this._flagFicImportIssuedDocuments = true;
            this._FicImportProducts = ficImportProducts;
            if (this.FicImportProducts != null) this._flagFicImportProducts = true;
            this._FicRecurring = ficRecurring;
            if (this.FicRecurring != null) this._flagFicRecurring = true;
            this._FicRiba = ficRiba;
            if (this.FicRiba != null) this._flagFicRiba = true;
            this._DicEmployees = dicEmployees;
            if (this.DicEmployees != null) this._flagDicEmployees = true;
            this._DicSettings = dicSettings;
            if (this.DicSettings != null) this._flagDicSettings = true;
            this._DicTimesheet = dicTimesheet;
            if (this.DicTimesheet != null) this._flagDicTimesheet = true;
            this._FicIssuedDocumentsDetailed = ficIssuedDocumentsDetailed;
            if (this.FicIssuedDocumentsDetailed != null) this._flagFicIssuedDocumentsDetailed = true;
        }

        /// <summary>
        /// Gets or Sets FicIssuedDocumentsDetailed
        /// </summary>
        [DataMember(Name = "fic_issued_documents_detailed", EmitDefaultValue = true)]
        public PermissionsFicIssuedDocumentsDetailed FicIssuedDocumentsDetailed
        {
            get{ return _FicIssuedDocumentsDetailed;}
            set
            {
                _FicIssuedDocumentsDetailed = value;
                _flagFicIssuedDocumentsDetailed = true;
            }
        }
        private PermissionsFicIssuedDocumentsDetailed _FicIssuedDocumentsDetailed;
        private bool _flagFicIssuedDocumentsDetailed;

        /// <summary>
        /// Returns false as FicIssuedDocumentsDetailed should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFicIssuedDocumentsDetailed()
        {
            return _flagFicIssuedDocumentsDetailed;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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
            {
                return false;
            }
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
                hashCode = (hashCode * 59) + this.FicSituation.GetHashCode();
                hashCode = (hashCode * 59) + this.FicClients.GetHashCode();
                hashCode = (hashCode * 59) + this.FicSuppliers.GetHashCode();
                hashCode = (hashCode * 59) + this.FicProducts.GetHashCode();
                hashCode = (hashCode * 59) + this.FicIssuedDocuments.GetHashCode();
                hashCode = (hashCode * 59) + this.FicReceivedDocuments.GetHashCode();
                hashCode = (hashCode * 59) + this.FicReceipts.GetHashCode();
                hashCode = (hashCode * 59) + this.FicCalendar.GetHashCode();
                hashCode = (hashCode * 59) + this.FicArchive.GetHashCode();
                hashCode = (hashCode * 59) + this.FicTaxes.GetHashCode();
                hashCode = (hashCode * 59) + this.FicStock.GetHashCode();
                hashCode = (hashCode * 59) + this.FicCashbook.GetHashCode();
                hashCode = (hashCode * 59) + this.FicSettings.GetHashCode();
                hashCode = (hashCode * 59) + this.FicEmails.GetHashCode();
                hashCode = (hashCode * 59) + this.FicExport.GetHashCode();
                hashCode = (hashCode * 59) + this.FicImportBankstatements.GetHashCode();
                hashCode = (hashCode * 59) + this.FicImportClientsSuppliers.GetHashCode();
                hashCode = (hashCode * 59) + this.FicImportIssuedDocuments.GetHashCode();
                hashCode = (hashCode * 59) + this.FicImportProducts.GetHashCode();
                hashCode = (hashCode * 59) + this.FicRecurring.GetHashCode();
                hashCode = (hashCode * 59) + this.FicRiba.GetHashCode();
                hashCode = (hashCode * 59) + this.DicEmployees.GetHashCode();
                hashCode = (hashCode * 59) + this.DicSettings.GetHashCode();
                hashCode = (hashCode * 59) + this.DicTimesheet.GetHashCode();
                if (this.FicIssuedDocumentsDetailed != null)
                {
                    hashCode = (hashCode * 59) + this.FicIssuedDocumentsDetailed.GetHashCode();
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
