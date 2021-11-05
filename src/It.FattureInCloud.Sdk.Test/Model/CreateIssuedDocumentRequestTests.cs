/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.  For more information, please visit https://www.fattureincloud.it.
 *
 * The version of the OpenAPI document: 2.0.1
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
    ///  Class for testing CreateIssuedDocumentRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateIssuedDocumentRequestTests : IDisposable
    {
        private CreateIssuedDocumentRequest instance;

        public CreateIssuedDocumentRequestTests()
        {
            var body = "{ 'data': { 'type': 'receipt', 'numeration': 'rec123', 'subject': '', 'visible_subject': '', 'amount_net': 68.18, 'amount_vat': 6.82, 'amount_gross': 75, 'amount_due_discount': 0, 'entity': { 'id': 54321, 'name': 'Mary Red S.r.L.', 'vat_number': 'IT05432181211', 'tax_code': 'IT05432181211', 'address_street': 'Corso impero, 66', 'address_postal_code': '20900', 'address_city': 'Milano', 'address_province': 'MI', 'address_extra': '', 'country': 'Italia', 'certified_email': 'mary@pec.red.com', 'ei_code': 'ABCXCR1' }, 'date': '2021-08-20', 'number': 1, 'next_due_date': '2021-12-31', 'attachment_token': 'ypbqqe4u8w8bdabcd5fd5b1a', 'items_list': [ { 'product_id': 333, 'code': 'SG3', 'name': 'Soggiorno', 'measure': '', 'net_price': 68.18182, 'category': '', 'id': 277875565, 'gross_price': 75, 'apply_withholding_taxes': true, 'discount': 0, 'discount_highlight': false, 'in_dn': false, 'qty': 1, 'vat': { 'id': 3, 'value': 10, 'description': '' }, 'stock': true, 'description': '', 'not_taxable': false } ], 'payments_list': [ { 'amount': 75, 'due_date': '2020-08-23', 'paid_date': '2021-10-01', 'id': 444, 'payment_terms': { 'days': 0, 'type': 'standard' }, 'status': 'not_paid', 'payment_account': null } ] }, 'options': { 'entity_create': true } }";
            instance = JsonConvert.DeserializeObject<CreateIssuedDocumentRequest>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateIssuedDocumentRequest
        /// </summary>
        [Fact]
        public void CreateIssuedDocumentRequestInstanceTest()
        {
            Assert.IsType<CreateIssuedDocumentRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<IssuedDocument>(instance.Data);
        }
        /// <summary>
        /// Test the property 'Options'
        /// </summary>
        [Fact]
        public void OptionsTest()
        {
            Assert.IsType<EntityOptions>(instance.Options);
        }

    }

}
