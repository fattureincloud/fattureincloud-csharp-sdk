/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.8
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
    ///  Class for testing AttachmentData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AttachmentDataTests : IDisposable
    {
        private AttachmentData instance;

        public AttachmentDataTests()
        {
            var body = "{ 'attachment_token': 'YmMyNWYxYzIwMTU3N2Y4ZGE3ZjZiMzg5OWY0ODNkZDQveXl5LmRvYw' }";
            instance = JsonConvert.DeserializeObject<AttachmentData>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AttachmentData
        /// </summary>
        [Fact]
        public void AttachmentDataInstanceTest()
        {
            Assert.IsType<AttachmentData>(instance);
        }


        /// <summary>
        /// Test the property 'AttachmentToken'
        /// </summary>
        [Fact]
        public void AttachmentTokenTest()
        {
            Assert.IsType<string>(instance.AttachmentToken);
        }

    }

}
