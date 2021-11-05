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
    ///  Class for testing CashbookEntry
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CashbookEntryTests : IDisposable
    {
        private CashbookEntryInOut instance;

        public CashbookEntryTests()
        {
            var body = "{ 'id': 12345, 'date': '2021-08-24', 'description': 'Fattura n. 201/2021', 'entity_name': 'Rossi S.r.l.', 'kind': 'issued_document', 'type': 'in', 'amount_in': 100, 'amount_out': 0, 'document': { 'id': 12345, 'type': 'issued_document', 'path': '/doc1.pdf' }, 'payment_account_in': { 'id': 333 }, 'payment_account_out': { 'id': 333 } }";
            instance = JsonConvert.DeserializeObject<CashbookEntryInOut>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CashbookEntry
        /// </summary>
        [Fact]
        public void CashbookEntryInstanceTest()
        {
            Assert.IsType<CashbookEntryInOut>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            Assert.IsType<string>(instance.Id);
        }
        /// <summary>
        /// Test the property 'Date'
        /// </summary>
        [Fact]
        public void DateTest()
        {
            Assert.IsType<DateTimeOffset>(instance.Date);
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            Assert.IsType<string>(instance.Description);
        }
        /// <summary>
        /// Test the property 'Kind'
        /// </summary>
        [Fact]
        public void KindTest()
        {
            Assert.IsType<CashbookEntryInOut.KindEnum>(instance.Kind);
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            Assert.IsType<CashbookEntryInOut.TypeEnum>(instance.Type);
        }
        /// <summary>
        /// Test the property 'EntityName'
        /// </summary>
        [Fact]
        public void EntityNameTest()
        {
            Assert.IsType<string>(instance.EntityName);
        }
        /// <summary>
        /// Test the property 'Document'
        /// </summary>
        [Fact]
        public void DocumentTest()
        {
            Assert.IsType<CashbookEntryDataDocument>(instance.Document);
        }
        /// <summary>
        /// Test the property 'AmountIn'
        /// </summary>
        [Fact]
        public void AmountInTest()
        {
            Assert.IsType<decimal>(instance.AmountIn);
        }
        /// <summary>
        /// Test the property 'PaymentAccountIn'
        /// </summary>
        [Fact]
        public void PaymentAccountInTest()
        {
            Assert.IsType<PaymentAccount>(instance.PaymentAccountIn);
        }
        /// <summary>
        /// Test the property 'AmountOut'
        /// </summary>
        [Fact]
        public void AmountOutTest()
        {
            Assert.IsType<decimal>(instance.AmountOut);
        }
        /// <summary>
        /// Test the property 'PaymentAccountOut'
        /// </summary>
        [Fact]
        public void PaymentAccountOutTest()
        {
            Assert.IsType<PaymentAccount>(instance.PaymentAccountOut);
        }

    }

}
