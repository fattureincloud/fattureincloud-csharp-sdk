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
    ///  Class for testing CompaniesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CompaniesApiTests : IDisposable
    {
        Mock<ICompaniesApi> instance = new Mock<ICompaniesApi>();
        string getCompanyInfoResponseBody;

        public CompaniesApiTests()
        {
            getCompanyInfoResponseBody = "{ 'data': { 'type': 'accountant', 'id': 12345, 'name': 'Studio Commercialista', 'email': 'mario.rossi@examplea.com', 'access_info': { 'role': 'master', 'through_accountant': false }, 'is_accountant': false }}";
            var getCompanyInfoResponse = JsonConvert.DeserializeObject<GetCompanyInfoResponse>(getCompanyInfoResponseBody);
            instance
                .Setup(p => p.GetCompanyInfo(Moq.It.IsAny<int>(), 0))
                .Returns(getCompanyInfoResponse);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CompaniesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<Mock<ICompaniesApi>>(instance);
        }

        /// <summary>
        /// Test GetCompanyInfo
        /// </summary>
        [Fact]
        public void GetCompanyInfoTest()
        {
            int companyId = 2;

            var response = instance.Object.GetCompanyInfo(companyId);
            JObject obj = JObject.Parse(getCompanyInfoResponseBody);
            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }
    }
}
