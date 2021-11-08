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
    ///  Class for testing IssuedDocumentItemsList
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IssuedDocumentItemsListTests : IDisposable
    {
        private IssuedDocumentItemsList instance;

        public IssuedDocumentItemsListTests()
        {
            var body = "{ 'product_id': 12345, 'code': 'cod3', 'name': 'prod 1', 'description': 'product number uan', 'qty': 44, 'measure': 'very big', 'net_price': 10, 'gross_price': 12.2, 'not_taxable': false, 'apply_withholding_taxes': true, 'discount': 0, 'discount_highlight': true, 'in_ddt': false, 'stock': 89, 'vat': { 'id': 21 }, 'ei_raw': { 'prop': true } }";
            instance = JsonConvert.DeserializeObject<IssuedDocumentItemsList>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IssuedDocumentItemsList
        /// </summary>
        [Fact]
        public void IssuedDocumentItemsListInstanceTest()
        {
            Assert.IsType<IssuedDocumentItemsList>(instance);
        }


        /// <summary>
        /// Test the property 'ProductId'
        /// </summary>
        [Fact]
        public void ProductIdTest()
        {
            Assert.IsType<int>(instance.ProductId);
        }
        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Fact]
        public void CodeTest()
        {
            Assert.IsType<string>(instance.Code);
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            Assert.IsType<string>(instance.Name);
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
        /// Test the property 'Qty'
        /// </summary>
        [Fact]
        public void QtyTest()
        {
            Assert.IsType<decimal>(instance.Qty);
        }
        /// <summary>
        /// Test the property 'Measure'
        /// </summary>
        [Fact]
        public void MeasureTest()
        {
            Assert.IsType<string>(instance.Measure);
        }
        /// <summary>
        /// Test the property 'NetPrice'
        /// </summary>
        [Fact]
        public void NetPriceTest()
        {
            Assert.IsType<decimal>(instance.NetPrice);
        }
        /// <summary>
        /// Test the property 'GrossPrice'
        /// </summary>
        [Fact]
        public void GrossPriceTest()
        {
            Assert.IsType<decimal>(instance.GrossPrice);
        }
        /// <summary>
        /// Test the property 'Vat'
        /// </summary>
        [Fact]
        public void VatTest()
        {
            Assert.IsType<VatType>(instance.Vat);
        }
        /// <summary>
        /// Test the property 'NotTaxable'
        /// </summary>
        [Fact]
        public void NotTaxableTest()
        {
            Assert.IsType<bool>(instance.NotTaxable);
        }
        /// <summary>
        /// Test the property 'ApplyWithholdingTaxes'
        /// </summary>
        [Fact]
        public void ApplyWithholdingTaxesTest()
        {
            Assert.IsType<bool>(instance.ApplyWithholdingTaxes);
        }
        /// <summary>
        /// Test the property 'Discount'
        /// </summary>
        [Fact]
        public void DiscountTest()
        {
            Assert.IsType<decimal>(instance.Discount);
        }
        /// <summary>
        /// Test the property 'DiscountHighlight'
        /// </summary>
        [Fact]
        public void DiscountHighlightTest()
        {
            Assert.IsType<bool>(instance.DiscountHighlight);
        }
        /// <summary>
        /// Test the property 'InDdt'
        /// </summary>
        [Fact]
        public void InDdtTest()
        {
            Assert.IsType<bool>(instance.InDdt);
        }
        /// <summary>
        /// Test the property 'Stock'
        /// </summary>
        [Fact]
        public void StockTest()
        {
            Assert.IsType<bool>(instance.Stock);
        }
        /// <summary>
        /// Test the property 'EiRaw'
        /// </summary>
        [Fact]
        public void EiRawTest()
        {
            Assert.IsType<Newtonsoft.Json.Linq.JObject>(instance.EiRaw);
        }

    }

}
