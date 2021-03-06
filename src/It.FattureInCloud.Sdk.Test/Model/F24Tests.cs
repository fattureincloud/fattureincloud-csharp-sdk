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
    ///  Class for testing F24
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class F24Tests : IDisposable
    {
        private F24 instance;

        public F24Tests()
        {
            var body = "{ 'id': 12345, 'amount': 840.36, 'description': 'PAGAMENTO IVA 2021', 'due_date': '2021-12-31', 'status': 'paid', 'attachment_url': 'b19c01da9b1688fb73d0d9e8adae89a8.pdf', 'payment_account': { 'id': 111, 'name': 'Indesa - carta conto' }, 'attachment_token': 'Adfqregwthwrt6whrtghsrgbsdthyeruerur6u6676e5879' }";
            instance = JsonConvert.DeserializeObject<F24>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of F24
        /// </summary>
        [Fact]
        public void F24InstanceTest()
        {
            Assert.IsType<F24>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            Assert.IsType<int>(instance.Id);
        }
        /// <summary>
        /// Test the property 'DueDate'
        /// </summary>
        [Fact]
        public void DueDateTest()
        {
            Assert.IsType<DateTime>(instance.DueDate);
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            Assert.IsType<F24Status>(instance.Status);
        }
        /// <summary>
        /// Test the property 'PaymentAccount'
        /// </summary>
        [Fact]
        public void PaymentAccountTest()
        {
            Assert.IsType<PaymentAccount>(instance.PaymentAccount);
        }
        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Fact]
        public void AmountTest()
        {
            Assert.IsType<decimal>(instance.Amount);
        }
        /// <summary>
        /// Test the property 'AttachmentUrl'
        /// </summary>
        [Fact]
        public void AttachmentUrlTest()
        {
            Assert.IsType<string>(instance.AttachmentUrl);
        }
        /// <summary>
        /// Test the property 'AttachmentToken'
        /// </summary>
        [Fact]
        public void AttachmentTokenTest()
        {
            Assert.IsType<string>(instance.AttachmentToken);
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            Assert.IsType<string>(instance.Description);
        }

    }

}
