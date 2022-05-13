/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.3
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using It.FattureInCloud.Sdk.Model;

namespace It.FattureInCloud.Sdk.Test.Model
{
    /// <summary>
    ///     Class for testing ReceivedDocumentEntity
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class ReceivedDocumentEntityTests : IDisposable
    {
        private readonly ReceivedDocumentEntity instance;

        public ReceivedDocumentEntityTests()
        {
            var body = "{'id':111,'name':'Hotel Rubino Palace'}";
            instance = JsonConvert.DeserializeObject<ReceivedDocumentEntity>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of ReceivedDocumentEntity
        /// </summary>
        [Fact]
        public void ReceivedDocumentEntityInstanceTest()
        {
            Assert.IsType<ReceivedDocumentEntity>(instance);
        }


        /// <summary>
        ///     Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            Assert.IsType<int>(instance.Id);
        }

        /// <summary>
        ///     Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            Assert.IsType<string>(instance.Name);
        }
    }
}