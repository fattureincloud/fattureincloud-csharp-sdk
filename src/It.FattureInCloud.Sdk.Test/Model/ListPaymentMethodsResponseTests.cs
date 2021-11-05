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
    ///  Class for testing ListPaymentMethodsResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ListPaymentMethodsResponseTests : IDisposable
    {
        private ListPaymentMethodsResponse instance;

        public ListPaymentMethodsResponseTests()
        {
            var body = "{ 'data': [ { 'id': 12345, 'name': 'Carta di credito', 'is_default': false, 'default_payment_account': null }, { 'id': 12346, 'name': 'Bonifico bancario', 'is_default': true, 'default_payment_account': null } ] }";
            instance = JsonConvert.DeserializeObject<ListPaymentMethodsResponse>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ListPaymentMethodsResponse
        /// </summary>
        [Fact]
        public void ListPaymentMethodsResponseInstanceTest()
        {
            Assert.IsType<ListPaymentMethodsResponse>(instance);
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<List<PaymentMethod>>(instance.Data);
        }

    }

}
