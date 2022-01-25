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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;
using Moq;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using It.FattureInCloud.Sdk.Model;

namespace It.FattureInCloud.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing IssuedEInvoicesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IssuedEInvoicesApiTests : IDisposable
    {
        Mock<IIssuedEInvoicesApi> instance = new Mock<IIssuedEInvoicesApi>();
        string sendEInvoiceResponseBody;
        string verifyEInvoiceXmlResponseBody;
        string getEInvoiceXmlResponseBody;

        public IssuedEInvoicesApiTests()
        {
            sendEInvoiceResponseBody = "{'data':{'name':'CARICATO','date':'2021-08-23 10:38:03'}}";
            var sendEInvoiceResponse = JsonConvert.DeserializeObject<SendEInvoiceResponse>(sendEInvoiceResponseBody);
            instance
                .Setup(p => p.SendEInvoice(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<SendEInvoiceRequest>()))
                .Returns(sendEInvoiceResponse);

            verifyEInvoiceXmlResponseBody = "{'data':{'success':true}}";
            var verifyEInvoiceXmlResponse = JsonConvert.DeserializeObject<VerifyEInvoiceXmlResponse>(verifyEInvoiceXmlResponseBody);
            instance
                .Setup(p => p.VerifyEInvoiceXml(Moq.It.IsAny<int>(), Moq.It.IsAny<int>()))
                .Returns(verifyEInvoiceXmlResponse);

            getEInvoiceXmlResponseBody = "<xmlFattura>fields</xmlFattura>";
            var getEInvoiceXmlResponse = getEInvoiceXmlResponseBody;
            instance
                .Setup(p => p.GetEInvoiceXml(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), true))
                .Returns(getEInvoiceXmlResponse);

        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IssuedEInvoicesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<Mock<IIssuedEInvoicesApi>>(instance);
        }

        /// <summary>
        /// Test SendEInvoice
        /// </summary>
        [Fact]
        public void SendEInvoiceTest()
        {
            int companyId = 2;
            int documentId = 1234;
            SendEInvoiceRequest sendEInvoiceRequest = new SendEInvoiceRequest();

            var response = instance.Object.SendEInvoice(companyId, documentId, sendEInvoiceRequest);
            JObject obj = JObject.Parse(sendEInvoiceResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test VerifyEInvoiceXml
        /// </summary>
        [Fact]
        public void VerifyEInvoiceXmlTest()
        {
            int companyId = 2;
            int documentId = 12345;

            var response = instance.Object.VerifyEInvoiceXml(companyId, documentId);
            JObject obj = JObject.Parse(verifyEInvoiceXmlResponseBody);

            var jobj = JObject.FromObject(response);
            Assert.True(JToken.DeepEquals(obj, jobj));
        }

        /// <summary>
        /// Test GetEInvoiceXml
        /// </summary>
        [Fact]
        public void GetEInvoiceXmlTest()
        {
            int companyId = 2;
            int documentId = 12345;

            var response = instance.Object.GetEInvoiceXml(companyId, documentId, true);

            Assert.True(response == getEInvoiceXmlResponseBody);
        }
    }
}
