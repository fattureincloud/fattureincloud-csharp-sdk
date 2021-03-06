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
    ///  Class for testing TaxesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TaxesApiTests : IDisposable
    {
        Mock<ITaxesApi> instance = new Mock<ITaxesApi>();
        string createF24ResponseBody;
        string getF24ResponseBody;
        string listF24ResponseBody;
        string modifyF24ResponseBody;
        string uploadF24AttachmentResponseBody;

        public TaxesApiTests()
        {
            createF24ResponseBody = "{ 'data': { 'status': 'paid', 'due_date': '2021-12-31', 'payment_account': { 'id': 111, 'virtual': false }, 'amount': 840.36, 'attachment_token': 'b19c01da9b1688fb73d0d9e8ad', 'description': 'PAGAMENTO IVA 2021' }}";
            var createF24Response = JsonConvert.DeserializeObject<CreateF24Response>(createF24ResponseBody);
            instance
                .Setup(p => p.CreateF24(Moq.It.IsAny<int>(), Moq.It.IsAny<CreateF24Request>(), 0))
                .Returns(createF24Response);

            getF24ResponseBody = "{ 'data': { 'status': 'paid', 'due_date': '2021-12-31', 'payment_account': { 'id': 111, 'virtual': false }, 'amount': 840.36, 'attachment_token': 'b19c01da9b1688fb73d0d9e8ad', 'description': 'PAGAMENTO IVA 2021' }}";
            var getF24Response = JsonConvert.DeserializeObject<GetF24Response>(getF24ResponseBody);
            instance
                .Setup(p => p.GetF24(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), 0))
                .Returns(getF24Response);

            listF24ResponseBody = "{ 'current_page': 1, 'first_page_url': 'page=1', 'from': 1, 'last_page': 1, 'last_page_url': 'page=1', 'path': 'taxes', 'per_page': 50, 'to': 2, 'total': 2, 'data': [ { 'status': 'paid', 'id': 12345, 'due_date': '2021-12-31', 'payment_account': { 'id': 111, 'name': 'Indesa - carta conto', 'virtual': false }, 'amount': 840.36, 'description': 'PAGAMENTO IVA 2021' }, { 'status': 'paid', 'id': 12346, 'due_date': '2020-12-31', 'payment_account': { 'id': 111, 'name': 'Indesa - carta conto', 'virtual': false }, 'amount': 810.62, 'description': 'PAGAMENTO IVA 2020' } ], 'aggregated_data': { 'amount': 6438.96 }}";
            var listF24sResponse = JsonConvert.DeserializeObject<ListF24Response>(listF24ResponseBody);
            instance
                .Setup(p => p.ListF24(Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), 0))
                .Returns(listF24sResponse);

            modifyF24ResponseBody = "{ 'data': { 'status': 'paid', 'due_date': '2021-12-31', 'payment_account': { 'id': 111, 'virtual': false }, 'amount': 840.36, 'attachment_token': 'b19c01da9b1688fb73d0d9e8ad', 'description': 'PAGAMENTO IVA 2021' }}";
            var modifyF24Response = JsonConvert.DeserializeObject<ModifyF24Response>(modifyF24ResponseBody);
            instance
                .Setup(p => p.ModifyF24(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<ModifyF24Request>(), 0))
                .Returns(modifyF24Response);

            uploadF24AttachmentResponseBody = "{'data':{'attachment_token':'YmMyNWYxYzIwMTU3N2Y4ZGE3ZjZiMzg5OWY0ODNkZDQveXl5LmRvYw'}}";
            var uploadF24AttachmentResponse = JsonConvert.DeserializeObject<UploadF24AttachmentResponse>(uploadF24AttachmentResponseBody);
            instance
                .Setup(p => p.UploadF24Attachment(Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<Stream>(), 0))
                .Returns(uploadF24AttachmentResponse);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TaxesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<Mock<ITaxesApi>>(instance);
        }

        /// <summary>
        /// Test CreateF24
        /// </summary>
        [Fact]
        public void CreateF24Test()
        {
            int companyId = 2;
            CreateF24Request createF24Request = new CreateF24Request();

            var response = instance.Object.CreateF24(companyId, createF24Request);
            JObject obj = JObject.Parse(createF24ResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test DeleteF24
        /// </summary>
        [Fact]
        public void DeleteF24Test()
        {
            Assert.True(true);
        }

        /// <summary>
        /// Test DeleteF24Attachment
        /// </summary>
        [Fact]
        public void DeleteF24AttachmentTest()
        {
            Assert.True(true);
        }

        /// <summary>
        /// Test GetF24
        /// </summary>
        [Fact]
        public void GetF24Test()
        {
            int companyId = 2;
            int documentId = 12345;
            string fields = "";
            string fieldset = "";

            var response = instance.Object.GetF24(companyId, documentId, fields, fieldset);
            JObject obj = JObject.Parse(getF24ResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListF24
        /// </summary>
        [Fact]
        public void ListF24Test()
        {
            int companyId = 2;
            string fields = "";
            string fieldset = "";
            string sort = "";
            int? page = 20;
            int? perPage = 5;

            var response = instance.Object.ListF24(companyId, fields, fieldset, sort, page, perPage);
            JObject obj = JObject.Parse(listF24ResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ModifyF24
        /// </summary>
        [Fact]
        public void ModifyF24Test()
        {
            int companyId = 2;
            int documentId = 12345;
            ModifyF24Request modifyF24Request = new ModifyF24Request();

            var response = instance.Object.ModifyF24(companyId, documentId, modifyF24Request);
            JObject obj = JObject.Parse(modifyF24ResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test UploadF24Attachment
        /// </summary>
        [Fact]
        public void UploadF24AttachmentTest()
        {
            int companyId = 2;
            string filename = "";
            Stream attachment = new MemoryStream();

            var response = instance.Object.UploadF24Attachment(companyId, filename, attachment);
            JObject obj = JObject.Parse(uploadF24AttachmentResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }
    }
}
