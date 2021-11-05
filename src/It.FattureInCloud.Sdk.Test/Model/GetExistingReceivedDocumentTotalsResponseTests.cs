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
    ///  Class for testing GetExistingReceivedDocumentTotalsResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetExistingReceivedDocumentTotalsResponseTests : IDisposable
    {
        private GetExistingReceivedDocumentTotalsResponse instance;

        public GetExistingReceivedDocumentTotalsResponseTests()
        {
            var body = "{ 'data': { 'amount_net': 592, 'amount_vat': 20, 'amount_gross': 612, 'amount_withholding_tax': 0, 'amount_other_withholding_tax': 0, 'amount_due': 612, 'payments_sum': 592 } }";
            instance = JsonConvert.DeserializeObject<GetExistingReceivedDocumentTotalsResponse>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetExistingReceivedDocumentTotalsResponse
        /// </summary>
        [Fact]
        public void GetExistingReceivedDocumentTotalsResponseInstanceTest()
        {
            Assert.IsType<GetExistingReceivedDocumentTotalsResponse>(instance);
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<ReceivedDocumentTotals>(instance.Data);
        }

    }

}
