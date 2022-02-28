/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.10
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
    ///  Class for testing ReceivedDocumentPaymentsListItem
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ReceivedDocumentPaymentsListItemTests : IDisposable
    {
        private ReceivedDocumentPaymentsListItem instance;

        public ReceivedDocumentPaymentsListItemTests()
        {
            var body = "{'amount':592,'due_date':'2021-08-15','paid_date':'2021-08-15','id':777,'payment_terms':{'days':0,'type':'standard'},'status':'paid','payment_account':{'id':222,'name':'Contanti','virtual':false}}";
            instance = JsonConvert.DeserializeObject<ReceivedDocumentPaymentsListItem>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReceivedDocumentPaymentsList
        /// </summary>
        [Fact]
        public void ReceivedDocumentPaymentsListInstanceTest()
        {
            Assert.IsType<ReceivedDocumentPaymentsListItem>(instance);
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
        /// Test the property 'Amount'
        /// </summary>
        [Fact]
        public void AmountTest()
        {
            Assert.IsType<decimal>(instance.Amount);
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
        /// Test the property 'PaidDate'
        /// </summary>
        [Fact]
        public void PaidDateTest()
        {
            Assert.IsType<DateTime>(instance.PaidDate);
        }
        /// <summary>
        /// Test the property 'PaymentTerms'
        /// </summary>
        [Fact]
        public void PaymentTermsTest()
        {
            Assert.IsType<ReceivedDocumentPaymentsListItemPaymentTerms>(instance.PaymentTerms);
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            Assert.IsType<string>(instance.Status);
        }
        /// <summary>
        /// Test the property 'PaymentAccount'
        /// </summary>
        [Fact]
        public void PaymentAccountTest()
        {
            Assert.IsType<PaymentAccount>(instance.PaymentAccount);
        }

    }

}