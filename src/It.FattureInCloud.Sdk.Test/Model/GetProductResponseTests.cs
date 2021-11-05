/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.  For more information, please visit https://www.fattureincloud.it.
 *
 * The version of the OpenAPI document: 2.0.1
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
    ///  Class for testing GetProductResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetProductResponseTests : IDisposable
    {
        private GetProductResponse instance;

        public GetProductResponseTests()
        {
            var body = "{ 'data': { 'id': 12345, 'name': 'Tavolo di marmo', 'code': 'TAVOLO003', 'net_price': 240, 'gross_price': 280, 'use_gross_price': false, 'net_cost': 0, 'measure': '', 'description': 'Tavolo in marmo pregiato', 'category': 'arredamento', 'in_stock': true, 'created_at': '2021-08-09 08:57:14', 'updated_at': '2021-08-09 08:57:14', 'default_vat': { 'id': 3, 'value': 22, 'description': 'Non imponibile art. 123', 'notes': 'IVA non imponibile ai sensi dell articolo 123, comma 2', 'is_disabled': false }, 'stock_initial': 123, 'stock_current': 123 } }";
            instance = JsonConvert.DeserializeObject<GetProductResponse>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetProductResponse
        /// </summary>
        [Fact]
        public void GetProductResponseInstanceTest()
        {
            Assert.IsType<GetProductResponse>(instance);
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<Product>(instance.Data);
        }

    }

}
