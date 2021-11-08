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
    ///  Class for testing CreateReceiptRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateReceiptRequestTests : IDisposable
    {
        private CreateReceiptRequest instance;

        public CreateReceiptRequestTests()
        {
            var body = "{ 'data': { 'date': '2021-08-19', 'number': 6, 'numeration': 'REC006', 'amount_net': 8.2, 'amount_vat': 1.8, 'amount_gross': 10, 'use_gross_prices': true, 'type': 'sales_receipt', 'description': 'cassa 1', 'rc_center': '', 'payment_account': { 'id': 555, 'name': 'contanti' }, 'items_list': [ { 'id': 888, 'amount_net': 8.2, 'amount_vat': 1.8, 'amount_gross': 10, 'category': 'altro', 'vat': { 'id': 0, 'value': 22, 'description': 'iva' } } ] }, 'autocomplete_number': true }";
            instance = JsonConvert.DeserializeObject<CreateReceiptRequest>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateReceiptRequest
        /// </summary>
        [Fact]
        public void CreateReceiptRequestInstanceTest()
        {
            Assert.IsType<CreateReceiptRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<Receipt>(instance.Data);
        }
        /// <summary>
        /// Test the property 'AutocompleteNumber'
        /// </summary>
        [Fact]
        public void AutocompleteNumberTest()
        {
            Assert.IsType<bool>(instance.AutocompleteNumber);
        }

    }

}
