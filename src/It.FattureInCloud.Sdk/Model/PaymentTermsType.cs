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
    /// Payment terms type
    /// </summary>
    /// <value>Payment terms type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentTermsType
    {
        /// <summary>
        /// Enum Standard for value: standard
        /// </summary>
        [EnumMember(Value = "standard")]
        Standard = 1,

        /// <summary>
        /// Enum EndOfMonth for value: end_of_month
        /// </summary>
        [EnumMember(Value = "end_of_month")]
        EndOfMonth = 2
    }

}
