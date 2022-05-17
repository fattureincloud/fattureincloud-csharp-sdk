/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.3
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using It.FattureInCloud.Sdk.Model;

namespace It.FattureInCloud.Sdk.Test.Model
{
    /// <summary>
    ///     Class for testing SendEInvoiceRequestData
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class SendEInvoiceRequestDataTests : IDisposable
    {
        private readonly SendEInvoiceRequestData instance;

        public SendEInvoiceRequestDataTests()
        {
            var body = "{'cassa_type':'ct','withholding_tax_causal':'causale'}";
            instance = JsonConvert.DeserializeObject<SendEInvoiceRequestData>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of SendEInvoiceRequestData
        /// </summary>
        [Fact]
        public void SendEInvoiceRequestDataInstanceTest()
        {
            Assert.IsType<SendEInvoiceRequestData>(instance);
        }


        /// <summary>
        ///     Test the property 'CassaType'
        /// </summary>
        [Fact]
        public void CassaTypeTest()
        {
            Assert.IsType<string>(instance.CassaType);
        }

        /// <summary>
        ///     Test the property 'WithholdingTaxCausal'
        /// </summary>
        [Fact]
        public void WithholdingTaxCausalTest()
        {
            Assert.IsType<string>(instance.WithholdingTaxCausal);
        }
    }
}