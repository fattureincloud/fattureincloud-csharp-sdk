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
using It.FattureInCloud.Sdk.Model;

namespace It.FattureInCloud.Sdk.Test.Model
{
    /// <summary>
    ///     Class for testing GetArchiveDocumentResponse
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class GetArchiveDocumentResponseTests : IDisposable
    {
        private readonly GetArchiveDocumentResponse instance;

        public GetArchiveDocumentResponseTests()
        {
            var body =
                "{ 'data': { 'id': 12345, 'date': '2021-08-20', 'category': 'Altri documenti', 'description': 'spesa 2', 'attachment_url': 'spesa2.pdf' } }";
            instance = JsonConvert.DeserializeObject<GetArchiveDocumentResponse>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of GetArchiveDocumentResponse
        /// </summary>
        [Fact]
        public void GetArchiveDocumentResponseInstanceTest()
        {
            Assert.IsType<GetArchiveDocumentResponse>(instance);
        }


        /// <summary>
        ///     Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<ArchiveDocument>(instance.Data);
        }
    }
}