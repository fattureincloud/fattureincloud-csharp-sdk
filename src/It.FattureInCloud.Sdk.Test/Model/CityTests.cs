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
    ///  Class for testing City
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CityTests : IDisposable
    {
        private City instance;

        public CityTests()
        {
            var body = "{ 'postal_code': '89867', 'city': 'Zungri', 'province': 'VV' }";
            instance = JsonConvert.DeserializeObject<City>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of City
        /// </summary>
        [Fact]
        public void CityInstanceTest()
        {
            Assert.IsType<City>(instance);
        }


        /// <summary>
        /// Test the property 'PostalCode'
        /// </summary>
        [Fact]
        public void PostalCodeTest()
        {
            Assert.IsType<string>(instance.PostalCode);
        }
        /// <summary>
        /// Test the property '_City'
        /// </summary>
        [Fact]
        public void _CityTest()
        {
            Assert.IsType<string>(instance._City);
        }
        /// <summary>
        /// Test the property 'Province'
        /// </summary>
        [Fact]
        public void ProvinceTest()
        {
            Assert.IsType<string>(instance.Province);
        }

    }

}
