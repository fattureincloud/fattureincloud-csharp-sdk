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
    ///  Class for testing EmailSchedule
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EmailScheduleTests : IDisposable
    {
        private EmailSchedule instance;

        public EmailScheduleTests()
        {
            var body = "{ 'sender_email': 'mariorossi@fattureincloud.it', 'sender_id': 5, 'recipient_email': 'mary.red@example.com', 'subject': 'Nostra pro forma nr. 1', 'body': 'Gentile Mario Rossi,<br>per vedere la nostra pro forma di o per scaricarne una copia in versione PDF prema sul bottone sottostante.<br><br>{{allegati}}<br><br>Cordiali saluti,<br><b>Mario Rossi</b>', 'attach_pdf': true, 'include': { 'document': false, 'delivery_note': false, 'attachment': false, 'accompanying_invoice': false }, 'send_copy': false }";
            instance = JsonConvert.DeserializeObject<EmailSchedule>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EmailSchedule
        /// </summary>
        [Fact]
        public void EmailScheduleInstanceTest()
        {
            Assert.IsType<EmailSchedule>(instance);
        }


        /// <summary>
        /// Test the property 'SenderId'
        /// </summary>
        [Fact]
        public void SenderIdTest()
        {
            Assert.IsType<decimal>(instance.SenderId);
        }
        /// <summary>
        /// Test the property 'SenderEmail'
        /// </summary>
        [Fact]
        public void SenderEmailTest()
        {
            Assert.IsType<string>(instance.SenderEmail);
        }
        /// <summary>
        /// Test the property 'RecipientEmail'
        /// </summary>
        [Fact]
        public void RecipientEmailTest()
        {
            Assert.IsType<string>(instance.RecipientEmail);
        }
        /// <summary>
        /// Test the property 'Subject'
        /// </summary>
        [Fact]
        public void SubjectTest()
        {
            Assert.IsType<string>(instance.Subject);
        }
        /// <summary>
        /// Test the property 'Body'
        /// </summary>
        [Fact]
        public void BodyTest()
        {
            Assert.IsType<string>(instance.Body);
        }
        /// <summary>
        /// Test the property 'Include'
        /// </summary>
        [Fact]
        public void IncludeTest()
        {
            Assert.IsType<EmailScheduleInclude>(instance.Include);
        }
        /// <summary>
        /// Test the property 'AttachPdf'
        /// </summary>
        [Fact]
        public void AttachPdfTest()
        {
            Assert.IsType<bool>(instance.AttachPdf);
        }
        /// <summary>
        /// Test the property 'SendCopy'
        /// </summary>
        [Fact]
        public void SendCopyTest()
        {
            Assert.IsType<bool>(instance.SendCopy);
        }

    }

}
