/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.9
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
    ///  Class for testing ControlledCompany
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ControlledCompanyTests : IDisposable
    {
        private ControlledCompany instance;

        public ControlledCompanyTests()
        {
            var body = "{ 'id': 12345, 'name': 'Studio Commercialista', 'tax_code': 'ABCSFN94T17A794K', 'type': 'accountant', 'access_token': '4ff5f0fe5abcd1d7157fa13ca72ab62b6183db0667a576a0e19164801c18c4f7362a848fa32dbb8c3a3f94c34f3df95', 'connection_id': 94566, 'access_token': 'ergaegwergq53wh65je5j' }";
            instance = JsonConvert.DeserializeObject<ControlledCompany>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ControlledCompany
        /// </summary>
        [Fact]
        public void ControlledCompanyInstanceTest()
        {
            Assert.IsType<ControlledCompany>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            Assert.IsType<int>(instance.Id);
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            Assert.IsType<string>(instance.Name);
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            Assert.IsType<CompanyType>(instance.Type);
        }
        /// <summary>
        /// Test the property 'AccessToken'
        /// </summary>
        [Fact]
        public void AccessTokenTest()
        {
            Assert.IsType<string>(instance.AccessToken);
        }
        /// <summary>
        /// Test the property 'ConnectionId'
        /// </summary>
        [Fact]
        public void ConnectionIdTest()
        {
            Assert.IsType<decimal>(instance.ConnectionId);
        }
        /// <summary>
        /// Test the property 'TaxCode'
        /// </summary>
        [Fact]
        public void TaxCodeTest()
        {
            Assert.IsType<string>(instance.TaxCode);
        }

    }

}
