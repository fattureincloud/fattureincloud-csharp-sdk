/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
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
    ///  Class for testing ScheduleEmailRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ScheduleEmailRequestTests : IDisposable
    {
        private ScheduleEmailRequest instance;

        public ScheduleEmailRequestTests()
        {
            var body = "{ 'data': { 'sender_email': 'mariorossi@fattureincloud.it', 'recipient_email': 'mary.red@example.com', 'subject': 'Nostra pro forma nr. 1', 'body': 'Gentile Mario Rossi,<br>per vedere la nostra pro forma di o per scaricarne una copia in versione PDF prema sul bottone sottostante.<br><br>{{allegati}}<br><br>Cordiali saluti,<br><b>Mario Rossi</b>', 'include': { 'document': false, 'delivery_note': false, 'attachment': false, 'accompanying_invoice': false }, 'attach_pdf': true, 'send_copy': false } }";
            instance = JsonConvert.DeserializeObject<ScheduleEmailRequest>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ScheduleEmailRequest
        /// </summary>
        [Fact]
        public void ScheduleEmailRequestInstanceTest()
        {
            Assert.IsType<ScheduleEmailRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<EmailSchedule>(instance.Data);
        }

    }

}
