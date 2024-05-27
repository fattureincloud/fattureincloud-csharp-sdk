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
    ///  Class for testing ListIssuedDocumentsResponsePage
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ListIssuedDocumentsResponsePageTests : IDisposable
    {
        private ListIssuedDocumentsResponsePage instance;

        public ListIssuedDocumentsResponsePageTests()
        {
            var body = "{ 'data': [ { 'id': 12345, 'type': 'invoice', 'year': 2021, 'numeration': 'rec123', 'subject': '', 'visible_subject': '', 'rc_center': '', 'stamp_duty': 0, 'use_gross_prices': false, 'e_invoice': false, 'delivery_note': false, 'accompanying_invoice': false, 'amount_net': 68.18, 'amount_vat': 6.82, 'amount_gross': 75, 'amount_due_discount': 0, 'amount_rivalsa': 0, 'amount_cassa': 0, 'amount_withholding_tax': 0, 'amount_other_withholding_tax': 0, 'h_margins': 15, 'v_margins': 16, 'show_payment_method': false, 'show_payments': true, 'show_totals': 'all', 'show_notification_button': false, 'is_marked': false, 'entity': { 'id': 54321, 'name': 'Mary Red S.r.L.', 'vat_number': 'IT05432181211', 'tax_code': 'IT05432181211', 'address_street': 'Corso impero, 66', 'address_postal_code': '20900', 'address_city': 'Milano', 'address_province': 'MI', 'address_extra': '', 'country': 'Italia', 'certified_email': 'mary@pec.red.com', 'ei_code': 'ABCXCR1' }, 'date': '2021-08-20', 'number': 1, 'currency': { 'id': 'EUR', 'exchange_rate': '1.00000', 'symbol': '€' }, 'language': { 'code': 'it', 'name': 'Italiano' }, 'notes': '', 'rivalsa': 0, 'cassa': 0, 'withholding_tax': 0, 'withholding_tax_taxable': 100, 'other_withholding_tax': 0, 'payment_method': { 'id': 4, 'name': 'Credit card' }, 'use_split_payment': false, 'items_list': [ { 'product_id': 5432, 'code': 'SG3', 'name': 'Soggiorno', 'measure': '', 'net_price': 68.18182, 'category': '', 'id': 277876033, 'gross_price': 75, 'apply_withholding_taxes': true, 'discount': 0, 'discount_highlight': false, 'in_dn': false, 'qty': 1, 'vat': { 'id': 3, 'value': 10, 'description': '' }, 'stock': false, 'description': '', 'not_taxable': false } ], 'payments_list': [ { 'amount': 75, 'due_date': '2020-08-23', 'paid_date': '2021-10-10', 'id': 69078013, 'payment_terms': { 'days': 0, 'type': 'standard' }, 'status': 'not_paid', 'payment_account': null } ], 'attachment_url': 'kdijrnf893hnwkfk45f50f.pdf', 'next_due_date': '2020-08-23', 'template': { 'id': 2821, 'name': 'Light Smoke' }, 'url': 'y12h45rn9yf2mse0p43t7ec90vr.pdf', 'show_tspay_button': false } ] }";
            instance = JsonConvert.DeserializeObject<ListIssuedDocumentsResponsePage>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ListIssuedDocumentsResponsePage
        /// </summary>
        [Fact]
        public void ListIssuedDocumentsResponsePageInstanceTest()
        {
            Assert.IsType<ListIssuedDocumentsResponsePage>(instance);
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<List<IssuedDocument>>(instance.Data);
        }

    }

}
