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
    ///     Class for testing ArchiveDocument
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class ArchiveDocumentTests : IDisposable
    {
        private readonly ArchiveDocument instance = new();

        public ArchiveDocumentTests()
        {
            instance.Id = 12345;
            instance.Date = new DateTime(2021, 8, 21);
            instance.Category = "Altri documenti";
            instance.Description = "spesa 2";
            instance.AttachmentToken = "jwfbaiuwbfoiewfoa8weohafw7gefa9we";
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of ArchiveDocument
        /// </summary>
        [Fact]
        public void ArchiveDocumentInstanceTest()
        {
            Assert.IsType<ArchiveDocument>(instance);
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
        ///     Test the property 'Date'
        /// </summary>
        [Fact]
        public void DateTest()
        {
            Assert.IsType<DateTime>(instance.Date);
        }

        /// <summary>
        ///     Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            Assert.IsType<string>(instance.Description);
        }

        /// <summary>
        ///     Test the property 'AttachmentUrl'
        /// </summary>
        [Fact]
        public void AttachmentUrlTest()
        {
        }

        /// <summary>
        ///     Test the property 'Category'
        /// </summary>
        [Fact]
        public void CategoryTest()
        {
            Assert.IsType<string>(instance.Category);
        }

        /// <summary>
        ///     Test the property 'AttachmentToken'
        /// </summary>
        [Fact]
        public void AttachmentTokenTest()
        {
            Assert.IsType<string>(instance.AttachmentToken);
        }
    }
}