/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.  For more information, please visit https://www.fattureincloud.it.
 *
 * The version of the OpenAPI document: 2.0.3
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Model;
using It.FattureInCloud.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace It.FattureInCloud.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing ListVatTypesResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ListVatTypesResponseTests : IDisposable
    {
        private ListVatTypesResponse instance;

        public ListVatTypesResponseTests()
        {
            var body = "{ 'data': [ { 'id': 0, 'value': 22, 'description': 'Non imponibile art. 123', 'notes': 'IVA non imponibile ai sensi dell articolo 123, comma 2', 'e_invoice': false, 'ei_type': 2, 'ei_description': 'string', 'editable': true }, { 'id': 1010, 'value': 0, 'description': 'NON IMPONIBILE IVA EX ART. 8 COMMA 1 LETT.A', 'notes': '', 'e_invoice': false, 'ei_type': 0, 'ei_description': null, 'is_disabled': false, 'editable': true } ] }";
            instance = JsonConvert.DeserializeObject<ListVatTypesResponse>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ListVatTypesResponse
        /// </summary>
        [Fact]
        public void ListVatTypesResponseInstanceTest()
        {
            Assert.IsType<ListVatTypesResponse>(instance);
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<List<VatType>>(instance.Data);
        }

    }

}
