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
    ///  Class for testing ClientsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ClientsApiTests : IDisposable
    {
        Mock<IClientsApi> instance = new Mock<IClientsApi>();
        string createClientResponseBody;
        string getClientResponseBody;
        string listClientsResponseBody;
        string modifyClientResponseBody;

        public ClientsApiTests()
        {
            createClientResponseBody = "{ 'data': { 'type': 'person', 'default_payment_terms_type': 'standard', 'id': 16451, 'code': 'AE86', 'name': 'Avv. Maria Rossi', 'first_name': 'Maria', 'last_name': 'Rossi', 'contact_person': '', 'vat_number': 'IT12345640962', 'tax_code': 'BLTGNI5ABCDA794E', 'address_street': 'Via Roma, 1', 'address_postal_code': '20900', 'address_city': 'Milano', 'address_province': 'MI', 'address_extra': '', 'country': 'Italia', 'email': 'maria.rossi@example.com', 'certified_email': 'maria.rossi@pec.example.com', 'phone': '1234567890', 'fax': '', 'notes': '', 'default_vat': { 'id': 54321, 'value': 45.0, 'description': '', 'e_invoice': false, 'is_disabled': false }, 'default_payment_terms': 1, 'default_payment_method': { 'id': 386092, 'name': 'Credit card', 'is_default': false }, 'bank_name': 'Indesa', 'bank_iban': 'IT40P123456781000000123456', 'bank_swift_code': 'AK86PCT', 'shipping_address': 'Corso Magellano 4', 'e_invoice': true, 'ei_code': '111111', 'discount_highlight': false, 'created_at': '2021-04-29 08:53:07', 'updated_at': '2021-04-29 08:53:07' }}";
            var createClientResponse = JsonConvert.DeserializeObject<CreateClientResponse>(createClientResponseBody);
            instance
                .Setup(p => p.CreateClient(Moq.It.IsAny<int>(), Moq.It.IsAny<CreateClientRequest>()))
                .Returns(createClientResponse);

            getClientResponseBody = "{ 'data': { 'type': 'person', 'default_payment_terms_type': 'standard', 'id': 16451, 'code': 'AE86', 'name': 'Avv. Maria Rossi', 'first_name': 'Maria', 'last_name': 'Rossi', 'contact_person': '', 'vat_number': 'IT12345640962', 'tax_code': 'BLTGNI5ABCDA794E', 'address_street': 'Via Roma, 1', 'address_postal_code': '20900', 'address_city': 'Milano', 'address_province': 'MI', 'address_extra': '', 'country': 'Italia', 'email': 'maria.rossi@example.com', 'certified_email': 'maria.rossi@pec.example.com', 'phone': '1234567890', 'fax': '', 'notes': '', 'default_vat': { 'id': 54321, 'value': 45.0, 'description': '', 'e_invoice': false, 'is_disabled': false }, 'default_payment_terms': 1, 'default_payment_method': { 'id': 386092, 'name': 'Credit card', 'is_default': false }, 'bank_name': 'Indesa', 'bank_iban': 'IT40P123456781000000123456', 'bank_swift_code': 'AK86PCT', 'shipping_address': 'Corso Magellano 4', 'e_invoice': true, 'ei_code': '111111', 'discount_highlight': false, 'created_at': '2021-04-29 08:53:07', 'updated_at': '2021-04-29 08:53:07' }}";
            var getClientResponse = JsonConvert.DeserializeObject<GetClientResponse>(getClientResponseBody);
            instance
                .Setup(p => p.GetClient(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>()))
                .Returns(getClientResponse);

            listClientsResponseBody = "{ 'current_page': 1, 'first_page_url': 'page=1', 'from': 1, 'last_page': 2, 'last_page_url': 'page=2', 'next_page_url': 'page=2', 'path': 'entities/clients', 'per_page': 5, 'to': 50, 'total': 8, 'data': [ { 'type': 'person', 'default_payment_terms_type': 'standard', 'id': 16451, 'code': 'AE86', 'name': 'Avv. Maria Rossi', 'first_name': 'Maria', 'last_name': 'Rossi', 'contact_person': '', 'vat_number': 'IT12345640962', 'tax_code': 'BLTGNI5ABCDA794E', 'address_street': 'Via Roma, 1', 'address_postal_code': '20900', 'address_city': 'Milano', 'address_province': 'MI', 'address_extra': '', 'country': 'Italia', 'email': 'maria.rossi@example.com', 'certified_email': 'maria.rossi@pec.example.com', 'phone': '1234567890', 'fax': '', 'notes': '', 'default_vat': { 'id': 54321, 'value': 45.0, 'description': '', 'e_invoice': false, 'is_disabled': false }, 'default_payment_terms': 1, 'default_payment_method': { 'id': 386092, 'name': 'Credit card', 'is_default': false }, 'bank_name': 'Indesa', 'bank_iban': 'IT40P123456781000000123456', 'bank_swift_code': 'AK86PCT', 'shipping_address': 'Corso Magellano 4', 'e_invoice': true, 'ei_code': '111111', 'discount_highlight': false, 'created_at': '2021-04-29 08:53:07', 'updated_at': '2021-04-29 08:53:07' }, { 'type': 'person', 'default_payment_terms_type': 'standard', 'id': 25330696, 'code': 'PD00', 'name': 'Mario Rossi', 'first_name': 'Mario', 'last_name': 'Rossi', 'contact_person': '', 'vat_number': 'IT1234567890', 'tax_code': 'ABCDEF12G34H567I', 'address_street': 'Via largo augusto 123', 'address_postal_code': '21012', 'address_city': 'Bergamo', 'address_province': 'BG', 'address_extra': '', 'country': 'Italia', 'email': 'info@mariorossi.it', 'certified_email': 'info@pec.mariorossi.it', 'phone': '012345678', 'fax': '012345678', 'notes': '', 'default_vat': { 'id': 66, 'value': 22.0, 'description': '', 'e_invoice': false, 'is_disabled': false }, 'bank_name': 'Monte dei Pascoli', 'bank_iban': 'IT00P123456781000000123456', 'bank_swift_code': 'APL86PCT', 'shipping_address': 'Via Miilano 4', 'e_invoice': false, 'ei_code': '7654321', 'discount_highlight': false, 'created_at': '2021-04-29 08:53:07' } ]}";
            var listClientsResponse = JsonConvert.DeserializeObject<ListClientsResponse>(listClientsResponseBody);
            instance
                .Setup(p => p.ListClients(Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>()))
                .Returns(listClientsResponse);

            modifyClientResponseBody = "{ 'data': { 'type': 'person', 'default_payment_terms_type': 'standard', 'id': 16451, 'code': 'AE86', 'name': 'Avv. Maria Rossi', 'first_name': 'Maria', 'last_name': 'Rossi', 'contact_person': '', 'vat_number': 'IT12345640962', 'tax_code': 'BLTGNI5ABCDA794E', 'address_street': 'Via Roma, 1', 'address_postal_code': '20900', 'address_city': 'Milano', 'address_province': 'MI', 'address_extra': '', 'country': 'Italia', 'email': 'maria.rossi@example.com', 'certified_email': 'maria.rossi@pec.example.com', 'phone': '1234567890', 'fax': '', 'notes': '', 'default_vat': { 'id': 54321, 'value': 45.0, 'description': '', 'e_invoice': false, 'is_disabled': false }, 'default_payment_terms': 1, 'default_payment_method': { 'id': 386092, 'name': 'Credit card', 'is_default': false }, 'bank_name': 'Indesa', 'bank_iban': 'IT40P123456781000000123456', 'bank_swift_code': 'AK86PCT', 'shipping_address': 'Corso Magellano 4', 'e_invoice': true, 'ei_code': '111111', 'discount_highlight': false, 'created_at': '2021-04-29 08:53:07', 'updated_at': '2021-04-29 08:53:07' }}";
            var modifyClientResponse = JsonConvert.DeserializeObject<ModifyClientResponse>(modifyClientResponseBody);
            instance
                .Setup(p => p.ModifyClient(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<ModifyClientRequest>()))
                .Returns(modifyClientResponse);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ClientsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<Mock<IClientsApi>>(instance);
        }

        /// <summary>
        /// Test CreateClient
        /// </summary>
        [Fact]
        public void CreateClientTest()
        {
            int companyId = 2;
            CreateClientRequest createClientRequest = new CreateClientRequest();

            var response = instance.Object.CreateClient(companyId, createClientRequest);
            JObject obj = JObject.Parse(createClientResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test DeleteClient
        /// </summary>
        [Fact]
        public void DeleteClientTest()
        {
            Assert.True(true);
        }

        /// <summary>
        /// Test GetClient
        /// </summary>
        [Fact]
        public void GetClientTest()
        {
            int companyId = 2;
            int clientId = 12345;
            string fields = "";
            string fieldset = "";

            var response = instance.Object.GetClient(companyId, clientId, fields, fieldset);
            JObject obj = JObject.Parse(getClientResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListClients
        /// </summary>
        [Fact]
        public void ListClientsTest()
        {
            int companyId = 2;
            string fields = "";
            string fieldset = "";
            string sort = "";
            int? page = 2;
            int? perPage = 5;

            var response = instance.Object.ListClients(companyId, fields, fieldset, sort, page, perPage);
            JObject obj = JObject.Parse(listClientsResponseBody);
            
            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ModifyClient
        /// </summary>
        [Fact]
        public void ModifyClientTest()
        {
            int companyId = 2;
            int clientId = 12345;
            ModifyClientRequest modifyClientRequest = new ModifyClientRequest();

            var response = instance.Object.ModifyClient(companyId, clientId, modifyClientRequest);
            JObject obj = JObject.Parse(modifyClientResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }
    }
}
