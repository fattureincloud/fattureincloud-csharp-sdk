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
    ///  Class for testing ArchiveApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ArchiveApiTests : IDisposable
    {
        Mock<IArchiveApi>instance = new Mock<IArchiveApi>();
        string createArchiveDocumentResponseBody;
        string getArchiveDocumentResponseBody;
        string listArchiveDocumentsResponseBody;
        string modifyArchiveDocumentResponseBody;
        string uploadArchiveDocumentAttachmentResponseBody;

        public ArchiveApiTests()
        {
            createArchiveDocumentResponseBody = "{'data':{'id':12345,'date':'2021-08-20','category':'Altri documenti','description':'spesa 2'}}";
            var createArchiveDocumentResponse = JsonConvert.DeserializeObject<CreateArchiveDocumentResponse>(createArchiveDocumentResponseBody);
            instance
                .Setup(p => p.CreateArchiveDocument(Moq.It.IsAny<int>(), Moq.It.IsAny<CreateArchiveDocumentRequest>()))
                .Returns(createArchiveDocumentResponse);

            getArchiveDocumentResponseBody = "{'data':{'id':12345,'date':'2021-08-20','category':'Altri documenti','description':'spesa 2',}}";
            var getArchiveDocumentResponse = JsonConvert.DeserializeObject<GetArchiveDocumentResponse>(getArchiveDocumentResponseBody);
            instance
                .Setup(p => p.GetArchiveDocument(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>()))
                .Returns(getArchiveDocumentResponse);

            listArchiveDocumentsResponseBody = "{'current_page':1,'data':[{'id':12345,'date':'2021-08-20','category':'Altri documenti','description':'spesa 2'},{'id':12346,'date':'2021-08-19','category':'Altri documenti','description':'spesa 1'}],'first_page_url':'page=1','from':1,'last_page':1,'last_page_url':'page=1','next_page_url':null,'path':'/archive','per_page':50,'prev_page_url':null,'to':2,'total':2}";
            var listArchiveDocumentsResponse = JsonConvert.DeserializeObject<ListArchiveDocumentsResponse>(listArchiveDocumentsResponseBody);
            instance
                .Setup(p => p.ListArchiveDocuments(Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>()))
                .Returns(listArchiveDocumentsResponse);

            modifyArchiveDocumentResponseBody = "{'data':{'id':12345,'date':'2021-08-20','category':'Altri documenti','description':'spesa 2'}}";
            var modifyArchiveDocumentResponse = JsonConvert.DeserializeObject<ModifyArchiveDocumentResponse>(modifyArchiveDocumentResponseBody);
            instance
                .Setup(p => p.ModifyArchiveDocument(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<ModifyArchiveDocumentRequest>()))
                .Returns(modifyArchiveDocumentResponse);

            uploadArchiveDocumentAttachmentResponseBody = "{'data':{'attachment_token':'YmMyNWYxYzIwMTU3N2Y4ZGE3ZjZiMzg5OWY0ODNkZDQveXl5LmRvYw'}}";
            var uploadArchiveDocumentAttachmentResponse = JsonConvert.DeserializeObject<UploadArchiveAttachmentResponse>(uploadArchiveDocumentAttachmentResponseBody);
            instance
                .Setup(p => p.UploadArchiveDocumentAttachment(Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<Stream>()))
                .Returns(uploadArchiveDocumentAttachmentResponse);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ArchiveApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<Mock<IArchiveApi>>(instance);
        }

        /// <summary>
        /// Test CreateArchiveDocument
        /// </summary>
        [Fact]
        public void CreateArchiveDocumentTest()
        {
            int companyId = 12345;
            CreateArchiveDocumentRequest createArchiveDocumentRequest = new CreateArchiveDocumentRequest();

            var response = instance.Object.CreateArchiveDocument(companyId, createArchiveDocumentRequest);
            JObject obj = JObject.Parse(createArchiveDocumentResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test DeleteArchiveDocument
        /// </summary>
        [Fact]
        public void DeleteArchiveDocumentTest()
        {
            Assert.True(true);
        }

        /// <summary>
        /// Test GetArchiveDocument
        /// </summary>
        [Fact]
        public void GetArchiveDocumentTest()
        {
            int companyId = 2;
            int documentId = 12345;
            string fields = "";
            string fieldset = "";

            var response = instance.Object.GetArchiveDocument(companyId, documentId, fields, fieldset);
            JObject obj = JObject.Parse(getArchiveDocumentResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListArchiveDocuments
        /// </summary>
        [Fact]
        public void ListArchiveDocumentsTest()
        {
            int companyId = 2;
            string fields = "";
            string fieldset = "";
            string sort = "";
            int? page = 2;
            int? perPage = 5;

            var response = instance.Object.ListArchiveDocuments(companyId, fields, fieldset, sort, page, perPage);
            JObject obj = JObject.Parse(listArchiveDocumentsResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ModifyArchiveDocument
        /// </summary>
        [Fact]
        public void ModifyArchiveDocumentTest()
        {
            int companyId = 2;
            int documentId = 12345;
            ModifyArchiveDocumentRequest modifyArchiveDocumentRequest = new ModifyArchiveDocumentRequest();

            var response = instance.Object.ModifyArchiveDocument(companyId, documentId, modifyArchiveDocumentRequest);
            JObject obj = JObject.Parse(modifyArchiveDocumentResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test UploadArchiveDocumentAttachment
        /// </summary>
        [Fact]
        public void UploadArchiveDocumentAttachmentTest()
        {
            int companyId = 2;
            string filename = "";
            Stream attachment = new MemoryStream();

            var response = instance.Object.UploadArchiveDocumentAttachment(companyId, filename, attachment);
            JObject obj = JObject.Parse(uploadArchiveDocumentAttachmentResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }
    }
}
