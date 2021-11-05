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
    ///  Class for testing CreateF24Response
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateF24ResponseTests : IDisposable
    {
        private CreateF24Response instance;

        public CreateF24ResponseTests()
        {
            var body = "{ 'data': { 'amount': 840.36, 'description': 'PAGAMENTO IVA 2021', 'due_date': '2021-12-31', 'status': 'paid', 'payment_account': { 'id': 111 }, 'attachment_token': 'b19c01da9b1688fb73d0d9e8ad' } }";
            instance = JsonConvert.DeserializeObject<CreateF24Response>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateF24Response
        /// </summary>
        [Fact]
        public void CreateF24ResponseInstanceTest()
        {
            Assert.IsType<CreateF24Response>(instance);
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<F24>(instance.Data);
        }

    }

}
