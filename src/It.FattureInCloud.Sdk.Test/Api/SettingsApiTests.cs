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
    ///  Class for testing SettingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SettingsApiTests : IDisposable
    {
        Mock<ISettingsApi> instance = new Mock<ISettingsApi>();
        string createPaymentAccountResponseBody;
        string getPaymentAccountResponseBody;
        string modifyPaymentAccountResponseBody;
        string createPaymentMethodResponseBody;
        string getPaymentMethodResponseBody;
        string modifyPaymentMethodResponseBody;

        public SettingsApiTests()
        {
            createPaymentAccountResponseBody = "{ 'data': { 'type': 'standard', 'name': 'Conto Banca Intesa', 'iban': 'string', 'sia': 'string', 'cuc': 'string', 'virtual': true } }";
            var createPaymentAccountResponse = JsonConvert.DeserializeObject<CreatePaymentAccountResponse>(createPaymentAccountResponseBody);
            instance
                .Setup(p => p.CreatePaymentAccount(Moq.It.IsAny<int>(), Moq.It.IsAny<CreatePaymentAccountRequest>()))
                .Returns(createPaymentAccountResponse);

            getPaymentAccountResponseBody = "{ 'data': { 'type': 'standard', 'name': 'Conto Banca Intesa', 'iban': 'string', 'sia': 'string', 'cuc': 'string', 'virtual': true } }";
            var getPaymentAccountResponse = JsonConvert.DeserializeObject<GetPaymentAccountResponse>(getPaymentAccountResponseBody);
            instance
                .Setup(p => p.GetPaymentAccount(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>()))
                .Returns(getPaymentAccountResponse);

            modifyPaymentAccountResponseBody = "{ 'data': { 'type': 'standard', 'name': 'Conto Banca Intesa', 'iban': 'string', 'sia': 'string', 'cuc': 'string', 'virtual': true } }";
            var modifyPaymentAccountResponse = JsonConvert.DeserializeObject<ModifyPaymentAccountResponse>(modifyPaymentAccountResponseBody);
            instance
                .Setup(p => p.ModifyPaymentAccount(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<ModifyPaymentAccountRequest>()))
                .Returns(modifyPaymentAccountResponse);

            createPaymentMethodResponseBody = "{ 'data': { 'type': 'standard', 'id': 386683, 'name': 'Bonifico bancario', 'is_default': true, 'default_payment_account': { 'id': 12345, 'name': 'conto banca SP', 'virtual': false }, 'details': [ { 'title': 'Banca', 'description': 'Sao Paulo' } ] } }";
            var createPaymentMethodResponse = JsonConvert.DeserializeObject<CreatePaymentMethodResponse>(createPaymentMethodResponseBody);
            instance
                .Setup(p => p.CreatePaymentMethod(Moq.It.IsAny<int>(), Moq.It.IsAny<CreatePaymentMethodRequest>()))
                .Returns(createPaymentMethodResponse);

            getPaymentMethodResponseBody = "{ 'data': { 'type': 'standard', 'id': 386683, 'name': 'Bonifico bancario', 'is_default': true, 'default_payment_account': { 'id': 12345, 'name': 'conto banca SP', 'virtual': false }, 'details': [ { 'title': 'Banca', 'description': 'Sao Paulo' } ] } }";
            var getPaymentMethodResponse = JsonConvert.DeserializeObject<GetPaymentMethodResponse>(getPaymentMethodResponseBody);
            instance
                .Setup(p => p.GetPaymentMethod(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>()))
                .Returns(getPaymentMethodResponse);

            modifyPaymentMethodResponseBody = "{ 'data': { 'type': 'standard', 'id': 386683, 'name': 'Bonifico bancario', 'is_default': true, 'default_payment_account': { 'id': 12345, 'name': 'conto banca SP', 'virtual': false }, 'details': [ { 'title': 'Banca', 'description': 'Sao Paulo' } ] } }";
            var modifyPaymentMethodResponse = JsonConvert.DeserializeObject<ModifyPaymentMethodResponse>(modifyPaymentMethodResponseBody);
            instance
                .Setup(p => p.ModifyPaymentMethod(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<ModifyPaymentMethodRequest>()))
                .Returns(modifyPaymentMethodResponse);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<Mock<ISettingsApi>>(instance);
        }

        /// <summary>
        /// Test CreatePaymentAccount
        /// </summary>
        [Fact]
        public void CreatePaymentAccountTest()
        {
            int companyId = 2;
            CreatePaymentAccountRequest createPaymentAccountRequest = new CreatePaymentAccountRequest();

            var response = instance.Object.CreatePaymentAccount(companyId, createPaymentAccountRequest);
            JObject obj = JObject.Parse(createPaymentAccountResponseBody);
 
            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test CreatePaymentMethod
        /// </summary>
        [Fact]
        public void CreatePaymentMethodTest()
        {
            int companyId = 2;
            CreatePaymentMethodRequest createPaymentMethodRequest = new CreatePaymentMethodRequest();

            var response = instance.Object.CreatePaymentMethod(companyId, createPaymentMethodRequest);
            JObject obj = JObject.Parse(createPaymentMethodResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test DeletePaymentAccount
        /// </summary>
        [Fact]
        public void DeletePaymentAccountTest()
        {
            Assert.True(true);
        }

        /// <summary>
        /// Test DeletePaymentMethod
        /// </summary>
        [Fact]
        public void DeletePaymentMethodTest()
        {
            Assert.True(true);
        }

        /// <summary>
        /// Test GetPaymentAccount
        /// </summary>
        [Fact]
        public void GetPaymentAccountTest()
        {
            int companyId = 2;
            int paymentAccountId = 12345;
            string fields = "";
            string fieldset = "";

            var response = instance.Object.GetPaymentAccount(companyId, paymentAccountId, fields, fieldset);
            JObject obj = JObject.Parse(getPaymentAccountResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test GetPaymentMethod
        /// </summary>
        [Fact]
        public void GetPaymentMethodTest()
        {
            int companyId = 2;
            int paymentMethodId = 12345;
            string fields = "";
            string fieldset = "";

            var response = instance.Object.GetPaymentMethod(companyId, paymentMethodId, fields, fieldset);
            JObject obj = JObject.Parse(getPaymentMethodResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ModifyPaymentAccount
        /// </summary>
        [Fact]
        public void ModifyPaymentAccountTest()
        {
            int companyId = 2;
            int paymentAccountId = 12345;
            ModifyPaymentAccountRequest modifyPaymentAccountRequest = new ModifyPaymentAccountRequest();

            var response = instance.Object.ModifyPaymentAccount(companyId, paymentAccountId, modifyPaymentAccountRequest);
            JObject obj = JObject.Parse(modifyPaymentAccountResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ModifyPaymentMethod
        /// </summary>
        [Fact]
        public void ModifyPaymentMethodTest()
        {
            int companyId = 2;
            int paymentMethodId = 12345;
            ModifyPaymentMethodRequest modifyPaymentMethodRequest = new ModifyPaymentMethodRequest();

            var response = instance.Object.ModifyPaymentMethod(companyId, paymentMethodId, modifyPaymentMethodRequest);
            JObject obj = JObject.Parse(modifyPaymentMethodResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }
    }
}
