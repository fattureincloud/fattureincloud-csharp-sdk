/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.10
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
    /// Cashbook kind.
    /// </summary>
    /// <value>Cashbook kind.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CashbookEntryKind
    {
        /// <summary>
        /// Enum Cashbook for value: cashbook
        /// </summary>
        [EnumMember(Value = "cashbook")]
        Cashbook = 1,

        /// <summary>
        /// Enum IssuedDocument for value: issued_document
        /// </summary>
        [EnumMember(Value = "issued_document")]
        IssuedDocument = 2,

        /// <summary>
        /// Enum ReceivedDocument for value: received_document
        /// </summary>
        [EnumMember(Value = "received_document")]
        ReceivedDocument = 3,

        /// <summary>
        /// Enum Tax for value: tax
        /// </summary>
        [EnumMember(Value = "tax")]
        Tax = 4,

        /// <summary>
        /// Enum Receipt for value: receipt
        /// </summary>
        [EnumMember(Value = "receipt")]
        Receipt = 5

    }

}
