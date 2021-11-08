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
    ///  Class for testing ReceivedDocumentInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ReceivedDocumentInfoTests : IDisposable
    {
        private ReceivedDocumentInfo instance;

        public ReceivedDocumentInfoTests()
        {
            var body = "{'default_values':{'detailed':false},'items_default_values':{'vat':21},'countries_list':['Italia','Afghanistan','Albania'],'currencies_list':[{'id':'AED','symbol':'AED','html_symbol':'AED','exchange_rate':'4.09500'},{'id':'ALL','symbol':'ALL','html_symbol':'ALL','exchange_rate':'121.50000'}],'categories_list':['Auto','Telefono e internet'],'payment_accounts_list':[{'id':111,'name':'Indesa - carta conto'}],'vat_types_list':[{'id':1334,'value':0,'description':'Non imp. art. 17 c. 6 DPR 633/72 e s.m.i.','is_disabled':false},{'id':1333,'value':0,'description':'Non sogg. art. 74 c. 7 e 8 DPR 633/72','is_disabled':false}]}";
            instance = JsonConvert.DeserializeObject<ReceivedDocumentInfo>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReceivedDocumentInfo
        /// </summary>
        [Fact]
        public void ReceivedDocumentInfoInstanceTest()
        {
            Assert.IsType<ReceivedDocumentInfo>(instance);
        }


        /// <summary>
        /// Test the property 'DefaultValues'
        /// </summary>
        [Fact]
        public void DefaultValuesTest()
        {
            Assert.IsType<ReceivedDocumentInfoDefaultValues>(instance.DefaultValues);
        }
        /// <summary>
        /// Test the property 'ItemsDefaultValues'
        /// </summary>
        [Fact]
        public void ItemsDefaultValuesTest()
        {
            Assert.IsType<ReceivedDocumentInfoItemsDefaultValues>(instance.ItemsDefaultValues);
        }
        /// <summary>
        /// Test the property 'CountriesList'
        /// </summary>
        [Fact]
        public void CountriesListTest()
        {
            Assert.IsType<List<string>>(instance.CountriesList);
        }
        /// <summary>
        /// Test the property 'CurrenciesList'
        /// </summary>
        [Fact]
        public void CurrenciesListTest()
        {
            Assert.IsType<List<Currency>>(instance.CurrenciesList);
        }
        /// <summary>
        /// Test the property 'CategoriesList'
        /// </summary>
        [Fact]
        public void CategoriesListTest()
        {
            Assert.IsType<List<string>>(instance.CategoriesList);
        }
        /// <summary>
        /// Test the property 'PaymentAccountsList'
        /// </summary>
        [Fact]
        public void PaymentAccountsListTest()
        {
            Assert.IsType<List<PaymentAccount>>(instance.PaymentAccountsList);
        }
        /// <summary>
        /// Test the property 'VatTypesList'
        /// </summary>
        [Fact]
        public void VatTypesListTest()
        {
            Assert.IsType<List<VatType>>(instance.VatTypesList);
        }

    }

}
