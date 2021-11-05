/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.  For more information, please visit https://www.fattureincloud.it.
 *
 * The version of the OpenAPI document: 2.0.3
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
    ///  Class for testing InfoApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InfoApiTests : IDisposable
    {
        Mock<IInfoApi> instance = new Mock<IInfoApi>();
        string listArchiveCategoriesResponseBody;
        string listCitiesResponseBody;
        string listCostCentersResponseBody;
        string listCountriesResponseBody;
        string listCurrenciesResponseBody;
        string listDeliveryNotesDefaultCausalsResponseBody;
        string listLanguagesResponseBody;
        string listPaymentAccountsResponseBody;
        string listPaymentMethodsResponseBody;
        string listProductCategoriesResponseBody;
        string listReceivedDocumentCategoriesResponseBody;
        string listRevenueCentersResponseBody;
        string listTemplatesResponseBody;
        string listUnitsOfMeasureResponseBody;
        string listVatTypesResponseBody;

        public InfoApiTests()
        {
            listArchiveCategoriesResponseBody = "{'data':['Altri documenti','Conferme dordine','Contratti','Dichiarazioni dei redditi','Documenti per detrazioni','Estratti conto bancari','Estratti conto carte di credito']}";
            var listArchiveCategoriesResponse = JsonConvert.DeserializeObject<ListArchiveCategoriesResponse>(listArchiveCategoriesResponseBody);
            instance
                .Setup(p => p.ListArchiveCategories(Moq.It.IsAny<int>()))
                .Returns(listArchiveCategoriesResponse);

            listCitiesResponseBody = "{'data':[{'postal_code':'89867','city':'Zungri','province':'VV'},{'postal_code':'83020','city':'Aiello del Sabato','province':'AV'},{'postal_code':'83011','city':'Altavilla Irpina','province':'AV'}]}";
            var listCitiesResponse = JsonConvert.DeserializeObject<ListCitiesResponse>(listCitiesResponseBody);
            instance
                .Setup(p => p.ListCities(Moq.It.IsAny<string>(), Moq.It.IsAny<string>()))
                .Returns(listCitiesResponse);

            listCostCentersResponseBody = "{'data':['Negozio Bergamo','Negozio Milano']}";
            var listCostCentersResponse = JsonConvert.DeserializeObject<ListCostCentersResponse>(listCostCentersResponseBody);
            instance
                .Setup(p => p.ListCostCenters(Moq.It.IsAny<int>()))
                .Returns(listCostCentersResponse);

            listCountriesResponseBody = "{'data':['Italia','Afghanistan','Albania','Algeria','Andorra','Angola','Anguilla','...']}";
            var listCountriesResponse = JsonConvert.DeserializeObject<ListCountriesResponse>(listCountriesResponseBody);
            instance
                .Setup(p => p.ListCountries())
                .Returns(listCountriesResponse);

            listCurrenciesResponseBody = "{'data':[{'id':'AED','symbol':'AED','html_symbol':'AED','exchange_rate':'4.09500'},{'id':'EUR','symbol':'\u20ac','html_symbol':'€','exchange_rate':'1.00000'}]}";
            var listCurrenciesResponse = JsonConvert.DeserializeObject<ListCurrenciesResponse>(listCurrenciesResponseBody);
            instance
                .Setup(p => p.ListCurrencies())
                .Returns(listCurrenciesResponse);

            listDeliveryNotesDefaultCausalsResponseBody = "{'data':['Altri documenti','Conferme dordine','Contratti','Dichiarazioni dei redditi','Documenti per detrazioni','Estratti conto bancari','Estratti conto carte di credito']}";
            var listDeliveryNotesDefaultCausalsResponse = JsonConvert.DeserializeObject<ListDeliveryNotesDefaultCausalsResponse>(listDeliveryNotesDefaultCausalsResponseBody);
            instance
                .Setup(p => p.ListDeliveryNotesDefaultCausals())
                .Returns(listDeliveryNotesDefaultCausalsResponse);

            listLanguagesResponseBody = "{'data':[{'code':'it','name':'Italiano'},{'code':'en','name':'Inglese'}]}";
            var listLanguagesResponse = JsonConvert.DeserializeObject<ListLanguagesResponse>(listLanguagesResponseBody);
            instance
                .Setup(p => p.ListLanguages())
                .Returns(listLanguagesResponse);

            listPaymentAccountsResponseBody = "{'data':[{'id':21,'name':'Indesa - Carta conto','type':'standard','iban':null,'sia':null,'virtual':false},{'id':109,'name':'Indesa','type':'bank','iban':'IT17A1234563200000003498936','sia':'IN234','virtual':false}]}";
            var listPaymentAccountsResponse = JsonConvert.DeserializeObject<ListPaymentAccountsResponse>(listPaymentAccountsResponseBody);
            instance
                .Setup(p => p.ListPaymentAccounts(Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>()))
                .Returns(listPaymentAccountsResponse);

            listPaymentMethodsResponseBody = "{'data':[{'id':12345,'name':'Carta di credito','is_default':false,'default_payment_account':null,'details':null,'bank_iban':null,'bank_name':null,'bank_beneficiary':null},{'id':12346,'name':'Bonifico bancario','is_default':true,'default_payment_account':null,'details':null,'bank_iban':null,'bank_name':null,'bank_beneficiary':null}]}";
            var listPaymentMethodsResponse = JsonConvert.DeserializeObject<ListPaymentMethodsResponse>(listPaymentMethodsResponseBody);
            instance
                .Setup(p => p.ListPaymentMethods(Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>()))
                .Returns(listPaymentMethodsResponse);

            listProductCategoriesResponseBody = "{'data':['Alimentari','Arredamento']}";
            var listProductCategoriesResponse = JsonConvert.DeserializeObject<ListProductCategoriesResponse>(listProductCategoriesResponseBody);
            instance
                .Setup(p => p.ListProductCategories(Moq.It.IsAny<int>(), Moq.It.IsAny<string>()))
                .Returns(listProductCategoriesResponse);

            listReceivedDocumentCategoriesResponseBody = "{'data':['Telefono e internet','Assicurazioni e quote','Auto ed altri veicoli','Computer e accessori','Server e hosting']}";
            var listReceivedDocumentCategoriesResponse = JsonConvert.DeserializeObject<ListReceivedDocumentCategoriesResponse>(listReceivedDocumentCategoriesResponseBody);
            instance
                .Setup(p => p.ListReceivedDocumentCategories(Moq.It.IsAny<int>()))
                .Returns(listReceivedDocumentCategoriesResponse);

            listRevenueCentersResponseBody = "{'data':['Negozio Bergamo','Negozio Milano']}";
            var listRevenueCentersResponse = JsonConvert.DeserializeObject<ListRevenueCentersResponse>(listRevenueCentersResponseBody);
            instance
                .Setup(p => p.ListRevenueCenters(Moq.It.IsAny<int>()))
                .Returns(listRevenueCentersResponse);

            listTemplatesResponseBody = "{'data':[{'id':10,'name':'New Standard S1'},{'id':106,'name':'Minimalist'}]}";
            var listTemplatesResponse = JsonConvert.DeserializeObject<ListTemplatesResponse>(listTemplatesResponseBody);
            instance
                .Setup(p => p.ListTemplates(Moq.It.IsAny<string>(), Moq.It.IsAny<bool>()))
                .Returns(listTemplatesResponse);

            listUnitsOfMeasureResponseBody = "{'data':['pezzi','kg','litri','ore','giorni','km','mesi']}";
            var listUnitsOfMeasureResponse = JsonConvert.DeserializeObject<ListUnitsOfMeasureResponse>(listUnitsOfMeasureResponseBody);
            instance
                .Setup(p => p.ListUnitsOfMeasure())
                .Returns(listUnitsOfMeasureResponse);

            listVatTypesResponseBody = "{'data':[{'value':22.0,'description':'Non imponibile art. 123','notes':'IVA non imponibile ai sensi dell articolo 123, comma 2','e_invoice':true,'ei_type':'2','ei_description':'string','is_disabled':false},{'id':1010,'description':'NON IMPONIBILE IVA EX ART. 8 COMMA 1 LETT.A','notes':'','e_invoice':false,'ei_type':'0','is_disabled':false}]}";
            var listVatTypesResponse = JsonConvert.DeserializeObject<ListVatTypesResponse>(listVatTypesResponseBody);
            instance
                .Setup(p => p.ListVatTypes(Moq.It.IsAny<int>(), Moq.It.IsAny<string>()))
                .Returns(listVatTypesResponse);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InfoApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<Mock<IInfoApi>>(instance);
        }

        /// <summary>
        /// Test ListArchiveCategories
        /// </summary>
        [Fact]
        public void ListArchiveCategoriesTest()
        {
            int companyId = 2;

            var response = instance.Object.ListArchiveCategories(companyId);
            JObject obj = JObject.Parse(listArchiveCategoriesResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListCities
        /// </summary>
        [Fact]
        public void ListCitiesTest()
        {
            string postalCode = "";
            string city = "";

            var response = instance.Object.ListCities(postalCode, city);
            JObject obj = JObject.Parse(listCitiesResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListCostCenters
        /// </summary>
        [Fact]
        public void ListCostCentersTest()
        {
            int companyId = 2;
            var response = instance.Object.ListCostCenters(companyId);
            JObject obj = JObject.Parse(listCostCentersResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListCountries
        /// </summary>
        [Fact]
        public void ListCountriesTest()
        {
            var response = instance.Object.ListCountries();
            JObject obj = JObject.Parse(listCountriesResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListCurrencies
        /// </summary>
        [Fact]
        public void ListCurrenciesTest()
        {
            var response = instance.Object.ListCurrencies();
            JObject obj = JObject.Parse(listCurrenciesResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListDeliveryNotesDefaultCausals
        /// </summary>
        [Fact]
        public void ListDeliveryNotesDefaultCausalsTest()
        {
            var response = instance.Object.ListDeliveryNotesDefaultCausals();
            JObject obj = JObject.Parse(listDeliveryNotesDefaultCausalsResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListLanguages
        /// </summary>
        [Fact]
        public void ListLanguagesTest()
        {
            var response = instance.Object.ListLanguages();
            JObject obj = JObject.Parse(listLanguagesResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListPaymentAccounts
        /// </summary>
        [Fact]
        public void ListPaymentAccountsTest()
        {
            int companyId = 2;
            string fields = "";
            string fieldset = "";
            string sort = "";

            var response = instance.Object.ListPaymentAccounts(companyId, fields, fieldset, sort);
            JObject obj = JObject.Parse(listPaymentAccountsResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListPaymentMethods
        /// </summary>
        [Fact]
        public void ListPaymentMethodsTest()
        {
            int companyId = 2;
            string fields = "";
            string fieldset = "";
            string sort = "";

            var response = instance.Object.ListPaymentMethods(companyId, fields, fieldset, sort);
            JObject obj = JObject.Parse(listPaymentMethodsResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListProductCategories
        /// </summary>
        [Fact]
        public void ListProductCategoriesTest()
        {
            int companyId = 2;
            string context = "";

            var response = instance.Object.ListProductCategories(companyId, context);
            JObject obj = JObject.Parse(listProductCategoriesResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListReceivedDocumentCategories
        /// </summary>
        [Fact]
        public void ListReceivedDocumentCategoriesTest()
        {
            int companyId = 2;

            var response = instance.Object.ListReceivedDocumentCategories(companyId);
            JObject obj = JObject.Parse(listReceivedDocumentCategoriesResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListRevenueCenters
        /// </summary>
        [Fact]
        public void ListRevenueCentersTest()
        {
            int companyId = 2;

            var response = instance.Object.ListRevenueCenters(companyId);
            JObject obj = JObject.Parse(listRevenueCentersResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListTemplates
        /// </summary>
        [Fact]
        public void ListTemplatesTest()
        {
            string type = "";
            bool? byType = true;

            var response = instance.Object.ListTemplates(type, byType);
            JObject obj = JObject.Parse(listTemplatesResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListUnitsOfMeasure
        /// </summary>
        [Fact]
        public void ListUnitsOfMeasureTest()
        {
            var response = instance.Object.ListUnitsOfMeasure();
            JObject obj = JObject.Parse(listUnitsOfMeasureResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListVatTypes
        /// </summary>
        [Fact]
        public void ListVatTypesTest()
        {
            int companyId = 2;
            string fieldset = "";

            var response = instance.Object.ListVatTypes(companyId, fieldset);
            JObject obj = JObject.Parse(listVatTypesResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }
    }
}
