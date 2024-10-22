/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.1.2
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
    /// Issued document type
    /// </summary>
    /// <value>Issued document type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IssuedDocumentType
    {
        /// <summary>
        /// Enum Invoice for value: invoice
        /// </summary>
        [EnumMember(Value = "invoice")]
        Invoice = 1,

        /// <summary>
        /// Enum Quote for value: quote
        /// </summary>
        [EnumMember(Value = "quote")]
        Quote = 2,

        /// <summary>
        /// Enum Proforma for value: proforma
        /// </summary>
        [EnumMember(Value = "proforma")]
        Proforma = 3,

        /// <summary>
        /// Enum Receipt for value: receipt
        /// </summary>
        [EnumMember(Value = "receipt")]
        Receipt = 4,

        /// <summary>
        /// Enum DeliveryNote for value: delivery_note
        /// </summary>
        [EnumMember(Value = "delivery_note")]
        DeliveryNote = 5,

        /// <summary>
        /// Enum CreditNote for value: credit_note
        /// </summary>
        [EnumMember(Value = "credit_note")]
        CreditNote = 6,

        /// <summary>
        /// Enum Order for value: order
        /// </summary>
        [EnumMember(Value = "order")]
        Order = 7,

        /// <summary>
        /// Enum WorkReport for value: work_report
        /// </summary>
        [EnumMember(Value = "work_report")]
        WorkReport = 8,

        /// <summary>
        /// Enum SupplierOrder for value: supplier_order
        /// </summary>
        [EnumMember(Value = "supplier_order")]
        SupplierOrder = 9,

        /// <summary>
        /// Enum SelfOwnInvoice for value: self_own_invoice
        /// </summary>
        [EnumMember(Value = "self_own_invoice")]
        SelfOwnInvoice = 10,

        /// <summary>
        /// Enum SelfSupplierInvoice for value: self_supplier_invoice
        /// </summary>
        [EnumMember(Value = "self_supplier_invoice")]
        SelfSupplierInvoice = 11
    }

}
