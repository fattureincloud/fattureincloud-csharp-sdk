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
    ///     Class for testing EmailDataDefaultSenderEmail
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class EmailDataDefaultSenderEmailTests : IDisposable
    {
        private readonly EmailDataDefaultSenderEmail instance;

        public EmailDataDefaultSenderEmailTests()
        {
            var body = "{ 'id': 0, 'email': 'no-reply@fattureincloud.it' }";
            instance = JsonConvert.DeserializeObject<EmailDataDefaultSenderEmail>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of EmailDataDefaultSenderEmail
        /// </summary>
        [Fact]
        public void EmailDataDefaultSenderEmailInstanceTest()
        {
            Assert.IsType<EmailDataDefaultSenderEmail>(instance);
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
        ///     Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            Assert.IsType<string>(instance.Email);
        }
    }
}