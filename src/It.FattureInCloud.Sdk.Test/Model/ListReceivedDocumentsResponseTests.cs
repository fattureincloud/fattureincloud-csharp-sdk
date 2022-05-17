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
    ///     Class for testing ListReceivedDocumentsResponse
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class ListReceivedDocumentsResponseTests : IDisposable
    {
        private readonly ListReceivedDocumentsResponse instance;

        public ListReceivedDocumentsResponseTests()
        {
            var body =
                "{ 'current_page': 2, 'first_page_url': 'page=1', 'from': 1, 'last_page': 3, 'last_page_url': 'page=3', 'next_page_url': 'page=3', 'path': '/archive', 'per_page': 50, 'prev_page_url': 'page=1', 'to': 3, 'total': 155, 'data': [ { 'id': 12345, 'type': 'expense', 'description': 'Soggiorno di lavoro', 'amortization': 1, 'rc_center': '', 'invoice_number': '', 'is_marked': false, 'is_detailed': false, 'e_invoice': false, 'created_at': '2021-08-15 14:02:02', 'updated_at': '2021-08-15 14:02:02', 'entity': { 'id': 111, 'name': 'Hotel Rubino Palace' }, 'date': '2021-08-15', 'next_due_date': '2021-08-15', 'currency': { 'id': 'EUR', 'exchange_rate': '1.00000', 'symbol': '€' }, 'amount_net': 592, 'amount_vat': 0, 'amount_gross': 592, 'amount_withholding_tax': 0, 'amount_other_withholding_tax': 0, 'tax_deductibility': 50, 'vat_deductibility': 100, 'items_list': null, 'payments_list': [ { 'amount': 592, 'due_date': '2021-08-15', 'paid_date': '2021-08-15', 'id': 777, 'payment_terms': { 'days': 0, 'type': 'standard' }, 'status': 'paid', 'payment_account': { 'id': 222, 'name': 'Contanti', 'virtual': false } } ], 'attachment_url': 'spesa_ger5i783t45hu6ti.pdf', 'attachment_preview_url': null, 'extra_data': null }, { 'id': 12346, 'type': 'expense', 'description': 'Assicurazione RCA', 'iamortization': 1, 'rc_center': '', 'invoice_number': '', 'is_marked': false, 'is_detailed': false, 'e_invoice': false, 'created_at': '2021-08-09 14:02:02', 'updated_at': '2021-08-09 14:02:02', 'entity': { 'id': 89, 'name': 'Indesa Assicurazioni S.P.A.' }, 'date': '2021-08-08', 'next_due_date': '2021-08-08', 'currency': { 'id': 'EUR', 'exchange_rate': '1.00000', 'symbol': '€' }, 'amount_net': 645.69, 'amount_vat': 0, 'amount_gross': 645.69, 'amount_withholding_tax': 0, 'amount_other_withholding_tax': 0, 'tax_deductibility': 50, 'vat_deductibility': 100, 'items_list': null, 'payments_list': [ { 'amount': 645.69, 'due_date': '2021-08-08', 'paid_date': '2021-08-08', 'id': 999, 'payment_terms': { 'days': 0, 'type': 'standard' }, 'status': 'paid', 'payment_account': { 'id': 333, 'name': 'Carta conto', 'virtual': false } } ], 'attachment_url': 'spesa_gjsd567e5hu6ti.pdf', 'attachment_preview_url': null, 'extra_data': null } ] }";
            instance = JsonConvert.DeserializeObject<ListReceivedDocumentsResponse>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of ListReceivedDocumentsResponse
        /// </summary>
        [Fact]
        public void ListReceivedDocumentsResponseInstanceTest()
        {
            Assert.IsType<ListReceivedDocumentsResponse>(instance);
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
            Assert.IsType<List<ReceivedDocument>>(instance.Data);
        }
    }
}