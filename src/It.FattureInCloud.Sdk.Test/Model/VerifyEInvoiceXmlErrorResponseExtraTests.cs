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
    ///  Class for testing VerifyEInvoiceXmlErrorResponseExtra
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class VerifyEInvoiceXmlErrorResponseExtraTests : IDisposable
    {
        private VerifyEInvoiceXmlErrorResponseExtra instance;

        public VerifyEInvoiceXmlErrorResponseExtraTests()
        {
            var body = "{ 'errors': [ 'errore brutto', 'errore brutto2' ] }";
            instance = JsonConvert.DeserializeObject<VerifyEInvoiceXmlErrorResponseExtra>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VerifyEInvoiceXmlErrorResponseExtra
        /// </summary>
        [Fact]
        public void VerifyEInvoiceXmlErrorResponseExtraInstanceTest()
        {
            Assert.IsType<VerifyEInvoiceXmlErrorResponseExtra>(instance);
        }


        /// <summary>
        /// Test the property 'Errors'
        /// </summary>
        [Fact]
        public void ErrorsTest()
        {
            Assert.IsType<List<string>>(instance.Errors);
        }

    }

}
