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
using System.Collections.Generic;
using It.FattureInCloud.Sdk.Model;

namespace It.FattureInCloud.Sdk.Test.Model
{
    /// <summary>
    ///     Class for testing ListSuppliersResponse
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class ListSuppliersResponseTests : IDisposable
    {
        private readonly ListSuppliersResponse instance;

        public ListSuppliersResponseTests()
        {
            var body =
                "{ 'current_page': 2, 'first_page_url': 'page=1', 'from': 1, 'last_page': 3, 'last_page_url': 'page=3', 'next_page_url': 'page=3', 'path': '/archive', 'per_page': 50, 'prev_page_url': 'page=1', 'to': 3, 'total': 155, 'data': [ { 'id': 12345, 'code': 'AE86', 'name': 'Mario Rossi S.R.L.', 'type': 'company', 'first_name': 'Mario', 'last_name': 'Rossi', 'contact_person': '', 'vat_number': '111222333', 'tax_code': '111122233', 'address_street': 'Corso Magellano, 46', 'address_postal_code': '20146', 'address_city': 'Milano', 'address_province': 'MI', 'address_extra': '', 'country': 'Italia', 'email': 'mario.rossi@example.com', 'certified_email': 'mario.rossi@pec.example.com', 'phone': '1234567890', 'fax': '123456789', 'notes': '', 'created_at': '2021-15-08', 'updated_at': '2021-15-08' }, { 'id': 12346, 'code': 'GT86', 'name': 'Maria Grossi S.R.L.', 'type': 'company', 'first_name': '', 'last_name': '', 'contact_person': '', 'vat_number': '200020102020', 'tax_code': '200020102020', 'address_street': 'Vicolo stretto, 32', 'address_postal_code': '20146', 'address_city': 'Milano', 'address_province': 'MI', 'address_extra': '', 'country': 'Italia', 'email': 'maria.grossi@example.com', 'certified_email': 'maria.grossi@pec.example.com', 'phone': '0987654321', 'fax': '098765432', 'notes': '', 'created_at': '2021-15-09', 'updated_at': '2021-15-09' } ] }";
            instance = JsonConvert.DeserializeObject<ListSuppliersResponse>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of ListSuppliersResponse
        /// </summary>
        [Fact]
        public void ListSuppliersResponseInstanceTest()
        {
            Assert.IsType<ListSuppliersResponse>(instance);
        }


        /// <summary>
        ///     Test the property 'CurrentPage'
        /// </summary>
        [Fact]
        public void CurrentPageTest()
        {
            Assert.IsType<int>(instance.CurrentPage);
        }

        /// <summary>
        ///     Test the property 'FirstPageUrl'
        /// </summary>
        [Fact]
        public void FirstPageUrlTest()
        {
            Assert.IsType<string>(instance.FirstPageUrl);
        }

        /// <summary>
        ///     Test the property 'From'
        /// </summary>
        [Fact]
        public void FromTest()
        {
            Assert.IsType<int>(instance.From);
        }

        /// <summary>
        ///     Test the property 'LastPage'
        /// </summary>
        [Fact]
        public void LastPageTest()
        {
            Assert.IsType<int>(instance.LastPage);
        }

        /// <summary>
        ///     Test the property 'LastPageUrl'
        /// </summary>
        [Fact]
        public void LastPageUrlTest()
        {
            Assert.IsType<string>(instance.LastPageUrl);
        }

        /// <summary>
        ///     Test the property 'NextPageUrl'
        /// </summary>
        [Fact]
        public void NextPageUrlTest()
        {
            Assert.IsType<string>(instance.NextPageUrl);
        }

        /// <summary>
        ///     Test the property 'Path'
        /// </summary>
        [Fact]
        public void PathTest()
        {
            Assert.IsType<string>(instance.Path);
        }

        /// <summary>
        ///     Test the property 'PerPage'
        /// </summary>
        [Fact]
        public void PerPageTest()
        {
            Assert.IsType<int>(instance.PerPage);
        }

        /// <summary>
        ///     Test the property 'PrevPageUrl'
        /// </summary>
        [Fact]
        public void PrevPageUrlTest()
        {
            Assert.IsType<string>(instance.PrevPageUrl);
        }

        /// <summary>
        ///     Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            Assert.IsType<int>(instance.To);
        }

        /// <summary>
        ///     Test the property 'Total'
        /// </summary>
        [Fact]
        public void TotalTest()
        {
            Assert.IsType<int>(instance.Total);
        }

        /// <summary>
        ///     Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<List<Supplier>>(instance.Data);
        }
    }
}