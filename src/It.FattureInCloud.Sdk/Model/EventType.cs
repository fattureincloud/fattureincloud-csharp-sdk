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
    /// Webhooks event type
    /// </summary>
    /// <value>Webhooks event type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventType
    {
        /// <summary>
        /// Enum IssuedDocumentsInvoicesCreate for value: it.fattureincloud.webhooks.issued_documents.invoices.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.invoices.create")]
        IssuedDocumentsInvoicesCreate = 1,

        /// <summary>
        /// Enum IssuedDocumentsInvoicesUpdate for value: it.fattureincloud.webhooks.issued_documents.invoices.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.invoices.update")]
        IssuedDocumentsInvoicesUpdate = 2,

        /// <summary>
        /// Enum IssuedDocumentsInvoicesDelete for value: it.fattureincloud.webhooks.issued_documents.invoices.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.invoices.delete")]
        IssuedDocumentsInvoicesDelete = 3,

        /// <summary>
        /// Enum IssuedDocumentsQuotesCreate for value: it.fattureincloud.webhooks.issued_documents.quotes.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.quotes.create")]
        IssuedDocumentsQuotesCreate = 4,

        /// <summary>
        /// Enum IssuedDocumentsQuotesUpdate for value: it.fattureincloud.webhooks.issued_documents.quotes.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.quotes.update")]
        IssuedDocumentsQuotesUpdate = 5,

        /// <summary>
        /// Enum IssuedDocumentsQuotesDelete for value: it.fattureincloud.webhooks.issued_documents.quotes.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.quotes.delete")]
        IssuedDocumentsQuotesDelete = 6,

        /// <summary>
        /// Enum IssuedDocumentsProformasCreate for value: it.fattureincloud.webhooks.issued_documents.proformas.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.proformas.create")]
        IssuedDocumentsProformasCreate = 7,

        /// <summary>
        /// Enum IssuedDocumentsProformasUpdate for value: it.fattureincloud.webhooks.issued_documents.proformas.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.proformas.update")]
        IssuedDocumentsProformasUpdate = 8,

        /// <summary>
        /// Enum IssuedDocumentsProformasDelete for value: it.fattureincloud.webhooks.issued_documents.proformas.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.proformas.delete")]
        IssuedDocumentsProformasDelete = 9,

        /// <summary>
        /// Enum IssuedDocumentsReceiptsCreate for value: it.fattureincloud.webhooks.issued_documents.receipts.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.receipts.create")]
        IssuedDocumentsReceiptsCreate = 10,

        /// <summary>
        /// Enum IssuedDocumentsReceiptsUpdate for value: it.fattureincloud.webhooks.issued_documents.receipts.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.receipts.update")]
        IssuedDocumentsReceiptsUpdate = 11,

        /// <summary>
        /// Enum IssuedDocumentsReceiptsDelete for value: it.fattureincloud.webhooks.issued_documents.receipts.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.receipts.delete")]
        IssuedDocumentsReceiptsDelete = 12,

        /// <summary>
        /// Enum IssuedDocumentsDeliveryNotesCreate for value: it.fattureincloud.webhooks.issued_documents.delivery_notes.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.delivery_notes.create")]
        IssuedDocumentsDeliveryNotesCreate = 13,

        /// <summary>
        /// Enum IssuedDocumentsDeliveryNotesUpdate for value: it.fattureincloud.webhooks.issued_documents.delivery_notes.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.delivery_notes.update")]
        IssuedDocumentsDeliveryNotesUpdate = 14,

        /// <summary>
        /// Enum IssuedDocumentsDeliveryNotesDelete for value: it.fattureincloud.webhooks.issued_documents.delivery_notes.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.delivery_notes.delete")]
        IssuedDocumentsDeliveryNotesDelete = 15,

        /// <summary>
        /// Enum IssuedDocumentsCreditNotesCreate for value: it.fattureincloud.webhooks.issued_documents.credit_notes.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.credit_notes.create")]
        IssuedDocumentsCreditNotesCreate = 16,

        /// <summary>
        /// Enum IssuedDocumentsCreditNotesUpdate for value: it.fattureincloud.webhooks.issued_documents.credit_notes.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.credit_notes.update")]
        IssuedDocumentsCreditNotesUpdate = 17,

        /// <summary>
        /// Enum IssuedDocumentsCreditNotesDelete for value: it.fattureincloud.webhooks.issued_documents.credit_notes.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.credit_notes.delete")]
        IssuedDocumentsCreditNotesDelete = 18,

        /// <summary>
        /// Enum IssuedDocumentsOrdersCreate for value: it.fattureincloud.webhooks.issued_documents.orders.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.orders.create")]
        IssuedDocumentsOrdersCreate = 19,

        /// <summary>
        /// Enum IssuedDocumentsOrdersUpdate for value: it.fattureincloud.webhooks.issued_documents.orders.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.orders.update")]
        IssuedDocumentsOrdersUpdate = 20,

        /// <summary>
        /// Enum IssuedDocumentsOrdersDelete for value: it.fattureincloud.webhooks.issued_documents.orders.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.orders.delete")]
        IssuedDocumentsOrdersDelete = 21,

        /// <summary>
        /// Enum IssuedDocumentsWorkReportsCreate for value: it.fattureincloud.webhooks.issued_documents.work_reports.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.work_reports.create")]
        IssuedDocumentsWorkReportsCreate = 22,

        /// <summary>
        /// Enum IssuedDocumentsWorkReportsUpdate for value: it.fattureincloud.webhooks.issued_documents.work_reports.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.work_reports.update")]
        IssuedDocumentsWorkReportsUpdate = 23,

        /// <summary>
        /// Enum IssuedDocumentsWorkReportsDelete for value: it.fattureincloud.webhooks.issued_documents.work_reports.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.work_reports.delete")]
        IssuedDocumentsWorkReportsDelete = 24,

        /// <summary>
        /// Enum IssuedDocumentsSupplierOrdersCreate for value: it.fattureincloud.webhooks.issued_documents.supplier_orders.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.supplier_orders.create")]
        IssuedDocumentsSupplierOrdersCreate = 25,

        /// <summary>
        /// Enum IssuedDocumentsSupplierOrdersUpdate for value: it.fattureincloud.webhooks.issued_documents.supplier_orders.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.supplier_orders.update")]
        IssuedDocumentsSupplierOrdersUpdate = 26,

        /// <summary>
        /// Enum IssuedDocumentsSupplierOrdersDelete for value: it.fattureincloud.webhooks.issued_documents.supplier_orders.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.supplier_orders.delete")]
        IssuedDocumentsSupplierOrdersDelete = 27,

        /// <summary>
        /// Enum IssuedDocumentsSelfInvoicesCreate for value: it.fattureincloud.webhooks.issued_documents.self_invoices.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.self_invoices.create")]
        IssuedDocumentsSelfInvoicesCreate = 28,

        /// <summary>
        /// Enum IssuedDocumentsSelfInvoicesUpdate for value: it.fattureincloud.webhooks.issued_documents.self_invoices.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.self_invoices.update")]
        IssuedDocumentsSelfInvoicesUpdate = 29,

        /// <summary>
        /// Enum IssuedDocumentsSelfInvoicesDelete for value: it.fattureincloud.webhooks.issued_documents.self_invoices.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.self_invoices.delete")]
        IssuedDocumentsSelfInvoicesDelete = 30,

        /// <summary>
        /// Enum IssuedDocumentsAllCreate for value: it.fattureincloud.webhooks.issued_documents.all.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.all.create")]
        IssuedDocumentsAllCreate = 31,

        /// <summary>
        /// Enum IssuedDocumentsAllUpdate for value: it.fattureincloud.webhooks.issued_documents.all.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.all.update")]
        IssuedDocumentsAllUpdate = 32,

        /// <summary>
        /// Enum IssuedDocumentsAllDelete for value: it.fattureincloud.webhooks.issued_documents.all.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.all.delete")]
        IssuedDocumentsAllDelete = 33,

        /// <summary>
        /// Enum ReceivedDocumentsCreate for value: it.fattureincloud.webhooks.received_documents.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.received_documents.create")]
        ReceivedDocumentsCreate = 34,

        /// <summary>
        /// Enum ReceivedDocumentsUpdate for value: it.fattureincloud.webhooks.received_documents.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.received_documents.update")]
        ReceivedDocumentsUpdate = 35,

        /// <summary>
        /// Enum ReceivedDocumentsDelete for value: it.fattureincloud.webhooks.received_documents.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.received_documents.delete")]
        ReceivedDocumentsDelete = 36,

        /// <summary>
        /// Enum ReceiptsCreate for value: it.fattureincloud.webhooks.receipts.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.receipts.create")]
        ReceiptsCreate = 37,

        /// <summary>
        /// Enum ReceiptsUpdate for value: it.fattureincloud.webhooks.receipts.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.receipts.update")]
        ReceiptsUpdate = 38,

        /// <summary>
        /// Enum ReceiptsDelete for value: it.fattureincloud.webhooks.receipts.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.receipts.delete")]
        ReceiptsDelete = 39,

        /// <summary>
        /// Enum TaxesCreate for value: it.fattureincloud.webhooks.taxes.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.taxes.create")]
        TaxesCreate = 40,

        /// <summary>
        /// Enum TaxesUpdate for value: it.fattureincloud.webhooks.taxes.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.taxes.update")]
        TaxesUpdate = 41,

        /// <summary>
        /// Enum TaxesDelete for value: it.fattureincloud.webhooks.taxes.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.taxes.delete")]
        TaxesDelete = 42,

        /// <summary>
        /// Enum ArchiveDocumentsCreate for value: it.fattureincloud.webhooks.archive_documents.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.archive_documents.create")]
        ArchiveDocumentsCreate = 43,

        /// <summary>
        /// Enum ArchiveDocumentsUpdate for value: it.fattureincloud.webhooks.archive_documents.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.archive_documents.update")]
        ArchiveDocumentsUpdate = 44,

        /// <summary>
        /// Enum ArchiveDocumentsDelete for value: it.fattureincloud.webhooks.archive_documents.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.archive_documents.delete")]
        ArchiveDocumentsDelete = 45,

        /// <summary>
        /// Enum CashbookCreate for value: it.fattureincloud.webhooks.cashbook.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.cashbook.create")]
        CashbookCreate = 46,

        /// <summary>
        /// Enum CashbookUpdate for value: it.fattureincloud.webhooks.cashbook.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.cashbook.update")]
        CashbookUpdate = 47,

        /// <summary>
        /// Enum CashbookDelete for value: it.fattureincloud.webhooks.cashbook.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.cashbook.delete")]
        CashbookDelete = 48,

        /// <summary>
        /// Enum ProductsCreate for value: it.fattureincloud.webhooks.products.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.products.create")]
        ProductsCreate = 49,

        /// <summary>
        /// Enum ProductsUpdate for value: it.fattureincloud.webhooks.products.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.products.update")]
        ProductsUpdate = 50,

        /// <summary>
        /// Enum ProductsDelete for value: it.fattureincloud.webhooks.products.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.products.delete")]
        ProductsDelete = 51,

        /// <summary>
        /// Enum ProductsStockUpdate for value: it.fattureincloud.webhooks.products.stock_update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.products.stock_update")]
        ProductsStockUpdate = 52,

        /// <summary>
        /// Enum EntitiesClientsCreate for value: it.fattureincloud.webhooks.entities.clients.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.entities.clients.create")]
        EntitiesClientsCreate = 53,

        /// <summary>
        /// Enum EntitiesClientsUpdate for value: it.fattureincloud.webhooks.entities.clients.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.entities.clients.update")]
        EntitiesClientsUpdate = 54,

        /// <summary>
        /// Enum EntitiesClientsDelete for value: it.fattureincloud.webhooks.entities.clients.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.entities.clients.delete")]
        EntitiesClientsDelete = 55,

        /// <summary>
        /// Enum EntitiesSuppliersCreate for value: it.fattureincloud.webhooks.entities.suppliers.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.entities.suppliers.create")]
        EntitiesSuppliersCreate = 56,

        /// <summary>
        /// Enum EntitiesSuppliersUpdate for value: it.fattureincloud.webhooks.entities.suppliers.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.entities.suppliers.update")]
        EntitiesSuppliersUpdate = 57,

        /// <summary>
        /// Enum EntitiesSuppliersDelete for value: it.fattureincloud.webhooks.entities.suppliers.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.entities.suppliers.delete")]
        EntitiesSuppliersDelete = 58,

        /// <summary>
        /// Enum EntitiesAllCreate for value: it.fattureincloud.webhooks.entities.all.create
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.entities.all.create")]
        EntitiesAllCreate = 59,

        /// <summary>
        /// Enum EntitiesAllUpdate for value: it.fattureincloud.webhooks.entities.all.update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.entities.all.update")]
        EntitiesAllUpdate = 60,

        /// <summary>
        /// Enum EntitiesAllDelete for value: it.fattureincloud.webhooks.entities.all.delete
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.entities.all.delete")]
        EntitiesAllDelete = 61,

        /// <summary>
        /// Enum IssuedDocumentsEInvoicesStatusUpdate for value: it.fattureincloud.webhooks.issued_documents.e_invoices.status_update
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.issued_documents.e_invoices.status_update")]
        IssuedDocumentsEInvoicesStatusUpdate = 62,

        /// <summary>
        /// Enum ReceivedDocumentsEInvoicesReceive for value: it.fattureincloud.webhooks.received_documents.e_invoices.receive
        /// </summary>
        [EnumMember(Value = "it.fattureincloud.webhooks.received_documents.e_invoices.receive")]
        ReceivedDocumentsEInvoicesReceive = 63
    }

}
