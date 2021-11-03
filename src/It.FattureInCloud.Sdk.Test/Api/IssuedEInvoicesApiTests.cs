/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol. For more information, please visit https://www.fattureincloud.it.
 *
 * The version of the OpenAPI document: 2.0.2
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

using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Api;
// uncomment below to import models
//using It.FattureInCloud.Sdk.Model;

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
        private IssuedEInvoicesApi instance;

        public IssuedEInvoicesApiTests()
        {
            instance = new IssuedEInvoicesApi();
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
            // TODO uncomment below to test 'IsType' IssuedEInvoicesApi
            //Assert.IsType<IssuedEInvoicesApi>(instance);
        }

        /// <summary>
        /// Test SendEInvoice
        /// </summary>
        [Fact]
        public void SendEInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //int documentId = null;
            //SendEInvoiceRequest sendEInvoiceRequest = null;
            //var response = instance.SendEInvoice(companyId, documentId, sendEInvoiceRequest);
            //Assert.IsType<SendEInvoiceResponse>(response);
        }

        /// <summary>
        /// Test VerifyEInvoiceXml
        /// </summary>
        [Fact]
        public void VerifyEInvoiceXmlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int companyId = null;
            //int documentId = null;
            //var response = instance.VerifyEInvoiceXml(companyId, documentId);
            //Assert.IsType<VerifyEInvoiceXmlResponse>(response);
        }
    }
}
