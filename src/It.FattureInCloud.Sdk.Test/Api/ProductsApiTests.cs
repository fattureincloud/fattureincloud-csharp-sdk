/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.  For more information, please visit https://www.fattureincloud.it.
 *
 * The version of the OpenAPI document: 2.0.1
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;
using Moq;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using It.FattureInCloud.Sdk.Model; 

namespace It.FattureInCloud.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing ProductsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProductsApiTests : IDisposable
    {
        Mock<IProductsApi> instance = new Mock<IProductsApi>();
        string createProductResponseBody;
        string getProductResponseBody;
        string listProductsResponseBody;
        string modifyProductResponseBody;

        public ProductsApiTests()
        {
            createProductResponseBody = "{'data':{'id':12345,'name':'Tavolo di marmo','code':'TAVOLO003','net_price':240.0,'gross_price':280.0,'use_gross_price':false,'default_vat':{'id':3,'value':22.0,'description':'Non imponibile art. 123','notes':'IVA non imponibile ai sensi dell articolo 123, comma 2','e_invoice':false,'is_disabled':false},'net_cost':0.0,'measure':'','description':'Tavolo in marmo pregiato','category':'arredamento','notes':null,'in_stock':true,'created_at':null,'updated_at':null}}";
            var createProductResponse = JsonConvert.DeserializeObject<CreateProductResponse>(createProductResponseBody);
            instance
                .Setup(p => p.CreateProduct(Moq.It.IsAny<int>(), Moq.It.IsAny<CreateProductRequest>()))
                .Returns(createProductResponse);

            getProductResponseBody = "{'data':{'id':12345,'name':'Tavolo di marmo','code':'TAVOLO003','net_price':240.0,'gross_price':280.0,'use_gross_price':false,'default_vat':{'id':3,'value':22.0,'description':'Non imponibile art. 123','notes':'IVA non imponibile ai sensi dell articolo 123, comma 2','e_invoice':false,'is_disabled':false},'net_cost':0.0,'measure':'','description':'Tavolo in marmo pregiato','category':'arredamento','notes':null,'in_stock':true,'created_at':null,'updated_at':null}}";
            var getProductResponse = JsonConvert.DeserializeObject<GetProductResponse>(getProductResponseBody);
            instance
                .Setup(p => p.GetProduct(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>()))
                .Returns(getProductResponse);

            listProductsResponseBody = "{ 'current_page': 1, 'first_page_url': 'page=1', 'from': 1, 'last_page': 1, 'last_page_url': 'page=1', 'next_page_url': 'page=2', 'path': 'products', 'per_page': 50, 'prev_page_url': null, 'to': 55, 'total': 55, 'data': [ { 'id': 12345, 'name': 'Tavolo di marmo', 'code': 'TAVOLO003', 'net_price': 240.0, 'gross_price': 280.0, 'use_gross_price': false, 'default_vat': { 'id': 3, 'value': 22.0, 'description': 'Non imponibile art. 123', 'notes': 'IVA non imponibile ai sensi dell articolo 123, comma 2', 'e_invoice': false, 'is_disabled': false }, 'net_cost': 0.0, 'measure': '', 'description': 'Tavolo in marmo pregiato', 'category': 'arredamento', 'notes': null, 'in_stock': true, 'created_at': null, 'updated_at': null }, { 'id': 12346, 'name': 'Tavolo di legno', 'code': 'TAVOLO001', 'net_price': 120.0, 'gross_price': 160.0, 'use_gross_price': false, 'default_vat': { 'id': 3, 'value': 22.0, 'description': 'Non imponibile art. 123', 'notes': 'IVA non imponibile ai sensi dell articolo 123, comma 2', 'e_invoice': false, 'is_disabled': false }, 'net_cost': 0.0, 'measure': '', 'description': 'Tavolo in legno pregiato', 'category': 'arredamento', 'notes': null, 'in_stock': true, 'created_at': null, 'updated_at': null } ]}";
            var listProductsResponse = JsonConvert.DeserializeObject<ListProductsResponse>(listProductsResponseBody);
            instance
                .Setup(p => p.ListProducts(Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>()))
                .Returns(listProductsResponse);

            modifyProductResponseBody = "{'data':{'id':12345,'name':'Tavolo di marmo','code':'TAVOLO003','net_price':240.0,'gross_price':280.0,'use_gross_price':false,'default_vat':{'id':3,'value':22.0,'description':'Non imponibile art. 123','notes':'IVA non imponibile ai sensi dell articolo 123, comma 2','e_invoice':false,'is_disabled':false},'net_cost':0.0,'measure':'','description':'Tavolo in marmo pregiato','category':'arredamento','notes':null,'in_stock':true,'created_at':null,'updated_at':null}}";
            var modifyProductResponse = JsonConvert.DeserializeObject<ModifyProductResponse>(modifyProductResponseBody);
            instance
                .Setup(p => p.ModifyProduct(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<ModifyProductRequest>()))
                .Returns(modifyProductResponse);

        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProductsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<Mock<IProductsApi>>(instance);
        }

        /// <summary>
        /// Test CreateProduct
        /// </summary>
        [Fact]
        public void CreateProductTest()
        {
            int companyId = 2;
            CreateProductRequest createProductRequest = new CreateProductRequest();

            var response = instance.Object.CreateProduct(companyId, createProductRequest);
            JObject obj = JObject.Parse(createProductResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test DeleteProduct
        /// </summary>
        [Fact]
        public void DeleteProductTest()
        {
            Assert.True(true);
        }

        /// <summary>
        /// Test GetProduct
        /// </summary>
        [Fact]
        public void GetProductTest()
        {
            int companyId = 2;
            int productId = 12345;
            string fields = "";
            string fieldset = "";

            var response = instance.Object.GetProduct(companyId, productId, fields, fieldset);
            JObject obj = JObject.Parse(getProductResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListProducts
        /// </summary>
        [Fact]
        public void ListProductsTest()
        {
            int companyId = 2;
            string fields = "";
            string fieldset = "";
            string sort = "";
            int? page = 60;
            int? perPage = 5;

            var response = instance.Object.ListProducts(companyId, fields, fieldset, sort, page, perPage);
            JObject obj = JObject.Parse(listProductsResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ModifyProduct
        /// </summary>
        [Fact]
        public void ModifyProductTest()
        {
            int companyId = 2;
            int productId = 12345;
            ModifyProductRequest modifyProductRequest = new ModifyProductRequest();

            var response = instance.Object.ModifyProduct(companyId, productId, modifyProductRequest);
            JObject obj = JObject.Parse(getProductResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }
    }
}
