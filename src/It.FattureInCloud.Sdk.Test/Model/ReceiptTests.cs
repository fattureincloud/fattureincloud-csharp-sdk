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
    ///  Class for testing Receipt
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ReceiptTests : IDisposable
    {
        private Receipt instance;

        public ReceiptTests()
        {
            var body = "{'id':12345,'date':'2021-08-20','number':5,'numeration':'REC005','amount_net':16.39,'amount_vat':3.61,'amount_gross':20,'use_gross_prices':true,'type':'sales_receipt','description':'cassa 1','rc_center':'','created_at':'2021-08-20 13:56:56','updated_at':'2021-08-20 13:56:56','payment_account':{'id':222,'name':'carta di credito'},'items_list':[{'id':666,'amount_net':10,'amount_vat':2.2,'amount_gross':12.2,'category':'altro','vat':{'id':0,'value':22,'description':'iva'}}]}";
            instance = JsonConvert.DeserializeObject<Receipt>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Receipt
        /// </summary>
        [Fact]
        public void ReceiptInstanceTest()
        {
            Assert.IsType<Receipt>(instance);
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
        /// Test the property 'Date'
        /// </summary>
        [Fact]
        public void DateTest()
        {
            Assert.IsType<DateTime>(instance.Date);
        }
        /// <summary>
        /// Test the property 'Number'
        /// </summary>
        [Fact]
        public void NumberTest()
        {
            Assert.IsType<decimal>(instance.Number);
        }
        /// <summary>
        /// Test the property 'Numeration'
        /// </summary>
        [Fact]
        public void NumerationTest()
        {
            Assert.IsType<string>(instance.Numeration);
        }
        /// <summary>
        /// Test the property 'AmountNet'
        /// </summary>
        [Fact]
        public void AmountNetTest()
        {
            Assert.IsType<decimal>(instance.AmountNet);
        }
        /// <summary>
        /// Test the property 'AmountVat'
        /// </summary>
        [Fact]
        public void AmountVatTest()
        {
            Assert.IsType<Receipt>(instance);
        }
        /// <summary>
        /// Test the property 'AmountGross'
        /// </summary>
        [Fact]
        public void AmountGrossTest()
        {
            Assert.IsType<Receipt>(instance);
        }
        /// <summary>
        /// Test the property 'UseGrossPrices'
        /// </summary>
        [Fact]
        public void UseGrossPricesTest()
        {
            Assert.IsType<decimal>(instance.AmountVat);
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            Assert.IsType<ReceiptType>(instance.Type);
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            Assert.IsType<string>(instance.Description);
        }
        /// <summary>
        /// Test the property 'RcCenter'
        /// </summary>
        [Fact]
        public void RcCenterTest()
        {
            Assert.IsType<string>(instance.RcCenter);
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            Assert.IsType<string>(instance.CreatedAt);
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Fact]
        public void UpdatedAtTest()
        {
            Assert.IsType<string>(instance.CreatedAt);
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
        /// Test the property 'ItemsList'
        /// </summary>
        [Fact]
        public void ItemsListTest()
        {
            Assert.IsType<List<ReceiptItemsListItem>>(instance.ItemsList);
        }

    }

}
