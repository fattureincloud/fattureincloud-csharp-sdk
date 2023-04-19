/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.27
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
using Moq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using It.FattureInCloud.Sdk.Model;

namespace It.FattureInCloud.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing WebhooksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WebhooksApiTests : IDisposable
    {
        Mock<IWebhooksApi> instance = new Mock<IWebhooksApi>();
        string createWebhooksSubscriptionResponseBody;
        string getWebhooksSubscriptionResponseBody;
        string listWebhooksSubscriptionsResponseBody;
        string modifyWebhooksSubscriptionsResponseBody;

        public WebhooksApiTests()
        {
            createWebhooksSubscriptionResponseBody = "{'data':{'id':'SUB123','sink':'https://endpoint.test','verified':true,'types':['it.fattureincloud.cashbook.create']},'warnings':['error']}";
            var createWebhooksSubscriptionResponse = JsonConvert.DeserializeObject<CreateWebhooksSubscriptionResponse>(createWebhooksSubscriptionResponseBody);
            instance
                .Setup(p => p.CreateWebhooksSubscription(Moq.It.IsAny<int>(), Moq.It.IsAny<CreateWebhooksSubscriptionRequest>(), 0))
                .Returns(createWebhooksSubscriptionResponse);

            getWebhooksSubscriptionResponseBody = "{'data':{'id':'SUB123','sink':'https://endpoint.test','verified':true,'types':['it.fattureincloud.cashbook.create']}}";
            var getWebhooksSubscriptionResponse = JsonConvert.DeserializeObject<GetWebhooksSubscriptionResponse>(createWebhooksSubscriptionResponseBody);
            instance
                .Setup(p => p.GetWebhooksSubscription(Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), 0))
                .Returns(getWebhooksSubscriptionResponse);

            listWebhooksSubscriptionsResponseBody = "{'data':[{'id':'SUB123','sink':'https://endpoint.test','verified':true,'types':['it.fattureincloud.cashbook.create']},{'id':'SUB1234','sink':'https://endpoint.test','verified':true,'types':['it.fattureincloud.cashbook.delete']}]}";
            var listWebhooksSubscriptionsResponse = JsonConvert.DeserializeObject<ListWebhooksSubscriptionsResponse>(listWebhooksSubscriptionsResponseBody);
            instance
                .Setup(p => p.ListWebhooksSubscriptions(Moq.It.IsAny<int>(), 0))
                .Returns(listWebhooksSubscriptionsResponse);

            modifyWebhooksSubscriptionsResponseBody = "{'data':{'id':'SUB123','sink':'https://endpoint.test','verified':true,'types':['it.fattureincloud.cashbook.create']},'warnings':['error']}";
            var modifyWebhooksSubscriptionsResponse = JsonConvert.DeserializeObject<ModifyWebhooksSubscriptionResponse>(modifyWebhooksSubscriptionsResponseBody);
            instance
                .Setup(p => p.ModifyWebhooksSubscription(Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<ModifyWebhooksSubscriptionRequest>(), 0))
                .Returns(modifyWebhooksSubscriptionsResponse);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebhooksApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<Mock<IWebhooksApi>>(instance);
        }

        /// <summary>
        /// Test CreateWebhooksSubscription
        /// </summary>
        [Fact]
        public void CreateWebhooksSubscriptionTest()
        {
            int companyId = 12345;
            CreateWebhooksSubscriptionRequest createWebhooksSubscriptionRequest = new CreateWebhooksSubscriptionRequest();

            var response = instance.Object.CreateWebhooksSubscription(companyId, createWebhooksSubscriptionRequest);
            JObject obj = JObject.Parse(createWebhooksSubscriptionResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test DeleteWebhooksSubscription
        /// </summary>
        [Fact]
        public void DeleteWebhooksSubscriptionTest()
        {
            Assert.True(true);
        }

        /// <summary>
        /// Test GetWebhooksSubscription
        /// </summary>
        [Fact]
        public void GetWebhooksSubscriptionTest()
        {
            int companyId = 12345;
            string subscriptionId = "SUB12345";
            var response = instance.Object.GetWebhooksSubscription(companyId, subscriptionId);
            JObject obj = JObject.Parse(getWebhooksSubscriptionResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListWebhooksSubscriptions
        /// </summary>
        [Fact]
        public void ListWebhooksSubscriptionsTest()
        {
            int companyId = 12345;
            var response = instance.Object.ListWebhooksSubscriptions(companyId);
            JObject obj = JObject.Parse(listWebhooksSubscriptionsResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ModifyWebhooksSubscription
        /// </summary>
        [Fact]
        public void ModifyWebhooksSubscriptionTest()
        {
            int companyId = 12345;
            string subscriptionId = "SUB123";
            var response = instance.Object.ModifyWebhooksSubscription(companyId, subscriptionId, new ModifyWebhooksSubscriptionRequest());
            JObject obj = JObject.Parse(modifyWebhooksSubscriptionsResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }
    }
}
