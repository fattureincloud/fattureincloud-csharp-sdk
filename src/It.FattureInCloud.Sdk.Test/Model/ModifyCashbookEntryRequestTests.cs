/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
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
    ///  Class for testing ModifyCashbookEntryRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ModifyCashbookEntryRequestTests : IDisposable
    {
        private ModifyCashbookEntryRequest instance;

        public ModifyCashbookEntryRequestTests()
        {
            var body = "{ 'data': { 'date': '2021-08-24', 'amount_in': 122, 'payment_account_in': { 'id': 333 }, 'description': 'Fattura n. 201/2021', 'entity_name': 'Rossi S.r.l.' } }";
            instance = JsonConvert.DeserializeObject<ModifyCashbookEntryRequest>(body);

        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ModifyCashbookEntryRequest
        /// </summary>
        [Fact]
        public void ModifyCashbookEntryRequestInstanceTest()
        {
            Assert.IsType<ModifyCashbookEntryRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<CashbookEntry>(instance.Data);
        }

    }

}
