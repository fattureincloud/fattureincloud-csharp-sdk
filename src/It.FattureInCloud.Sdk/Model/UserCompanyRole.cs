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
    /// Role of the user in this company.
    /// </summary>
    /// <value>Role of the user in this company.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserCompanyRole
    {
        /// <summary>
        /// Enum Master for value: master
        /// </summary>
        [EnumMember(Value = "master")]
        Master = 1,

        /// <summary>
        /// Enum Subaccount for value: subaccount
        /// </summary>
        [EnumMember(Value = "subaccount")]
        Subaccount = 2,

        /// <summary>
        /// Enum Employee for value: employee
        /// </summary>
        [EnumMember(Value = "employee")]
        Employee = 3

    }

}
