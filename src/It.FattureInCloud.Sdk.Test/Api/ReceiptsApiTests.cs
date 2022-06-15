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
    ///  Class for testing ReceiptsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReceiptsApiTests : IDisposable
    {
        Mock<IReceiptsApi> instance = new Mock<IReceiptsApi>();
        string createReceiptResponseBody;
        string getReceiptResponseBody;
        string getReceiptPreCreateInfoResponseBody;
        string getReceiptsMonthlyTotalsResponseBody;
        string listReceiptsResponseBody;
        string modifyReceiptResponseBody;

        public ReceiptsApiTests()
        {
            createReceiptResponseBody = "{ 'data': { 'type': 'sales_receipt', 'id': 12346, 'date': '2021-08-19', 'number': 6.0, 'numeration': 'REC006', 'amount_net': 8.2, 'amount_vat': 1.8, 'amount_gross': 10.0, 'use_gross_prices': true, 'description': 'cassa 1', 'rc_center': '', 'created_at': '2021-08-19 17:57:56', 'updated_at': '2021-08-19 17:57:56', 'payment_account': { 'id': 555, 'name': 'contanti', 'virtual': false }, 'items_list': [ { 'id': 888, 'amount_net': 8.2, 'amount_gross': 10.0, 'category': 'altro', 'vat': { 'value': 22.0, 'description': 'iva', 'e_invoice': false, 'is_disabled': false } } ] }}";
            var createReceiptResponse = JsonConvert.DeserializeObject<CreateReceiptResponse>(createReceiptResponseBody);
            instance
                .Setup(p => p.CreateReceipt(Moq.It.IsAny<int>(), Moq.It.IsAny<CreateReceiptRequest>(), 0))
                .Returns(createReceiptResponse);

            getReceiptResponseBody = "{ 'data': { 'type': 'sales_receipt', 'id': 12346, 'date': '2021-08-19', 'number': 6.0, 'numeration': 'REC006', 'amount_net': 8.2, 'amount_vat': 1.8, 'amount_gross': 10.0, 'use_gross_prices': true, 'description': 'cassa 1', 'rc_center': '', 'created_at': '2021-08-19 17:57:56', 'updated_at': '2021-08-19 17:57:56', 'payment_account': { 'id': 555, 'name': 'contanti', 'virtual': false }, 'items_list': [ { 'id': 888, 'amount_net': 8.2, 'amount_gross': 10.0, 'category': 'altro', 'vat': { 'value': 22.0, 'description': 'iva', 'e_invoice': false, 'is_disabled': false } } ] }}";
            var getReceiptResponse = JsonConvert.DeserializeObject<GetReceiptResponse>(getReceiptResponseBody);
            instance
                .Setup(p => p.GetReceipt(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), 0))
                .Returns(getReceiptResponse);

            getReceiptPreCreateInfoResponseBody = "{ 'data': { 'numerations': { '2016': { 'sales_receipt': { 'REC003': 12, 'REC002': 5, 'REC001': 2 }, 'till_receipt': { 'REC002': 6, 'REC001': 2 } }, '2017': { 'sales_receipt': { 'REC003': 14, 'REC002': 7, 'REC001': 1 }, 'till_receipt': { 'REC003': 1, 'REC001': 3 } }, '2018': { 'sales_receipt': { 'REC001': 3 } }, '2019': { 'sales_receipt': { 'REC002': 105, 'REC001': 22 }, 'till_receipt': { 'REC003': 21, 'REC002': 24, 'REC001': 25 } }, '2020': { 'sales_receipt': { 'REC001': 3 } }, '2021': { 'sales_receipt': { 'REC005': 3, 'REC004': 2, 'REC003': 2, 'REC001': 7 } } }, 'numerations_list': [ 'REC001', 'REC002', 'REC003', 'REC005', 'REC006' ], 'rc_centers_list': [ 'Sede generale', 'Negozio Bergamo', 'Negozio Milano' ], 'payment_accounts_list': [ { 'id': 111, 'name': 'Indesa - carta conto', 'virtual': false }, { 'id': 222, 'name': 'Contanti', 'virtual': false }, { 'id': 333, 'name': 'Bonifico Bancario', 'virtual': false } ], 'categories_list': [ 'altro', 'arredamento' ], 'vat_types_list': [ { 'id': 1334, 'description': 'Non imp. art. 17 c. 6 DPR 633/72 e s.m.i.', 'e_invoice': false, 'is_disabled': false }, { 'id': 1333, 'description': 'Non sogg. art. 74 c. 7 e 8 DPR 633/72', 'e_invoice': false, 'is_disabled': false }, { 'id': 1332, 'description': 'Non imp. art. 17 c. 6 lett. A TER DPR 633/72', 'e_invoice': false, 'is_disabled': false }, { 'id': 1331, 'value': 22.0, 'description': 'Pippus', 'e_invoice': false, 'is_disabled': false }, { 'id': 1330, 'description': 'Natura 4', 'e_invoice': false, 'is_disabled': false }, { 'id': 1020, 'description': 'PA Non imp art. 2', 'e_invoice': false, 'is_disabled': false }, { 'id': 1018, 'description': 'Aliq. 22% reverse charge', 'e_invoice': false, 'is_disabled': false }, { 'id': 1015, 'value': 22.0, 'description': 'Speciale prova', 'e_invoice': false, 'is_disabled': false }, { 'id': 1014, 'description': 'Ai sensi dellarticolo 123', 'e_invoice': false, 'is_disabled': false }, { 'id': 1013, 'description': 'Non imponibile art. 8 lett. A DPR 633/72', 'e_invoice': false, 'is_disabled': false }, { 'id': 1010, 'description': 'NON IMPONIBILE IVA EX ART. 8 COMMA 1 LETT.A', 'e_invoice': false, 'is_disabled': false }, { 'id': 1009, 'value': 20.0, 'description': 'Aliquota 20%', 'e_invoice': false, 'is_disabled': false }, { 'id': 1008, 'description': 'Non imp. art. 41 D.L. 427/93', 'e_invoice': false, 'is_disabled': false }, { 'id': 1007, 'description': 'Non imp. art. 71 DPR 633/72', 'e_invoice': false, 'is_disabled': false }, { 'id': 1006, 'description': 'Escl. art. 15 DPR 633/72', 'e_invoice': false, 'is_disabled': false }, { 'id': 1004, 'description': 'Non imp. art. 1 L. 244/2007', 'e_invoice': false, 'is_disabled': false }, { 'id': 1003, 'description': 'Non imp. art. 8 DPR 633/72', 'e_invoice': false, 'is_disabled': false }, { 'id': 1002, 'description': 'Omaggi art. 2 c. 2 n. 4 DPR 633/72', 'e_invoice': false, 'is_disabled': false }, { 'id': 1000, 'description': 'art.26 COMMA 3 DPR 633/72', 'e_invoice': false, 'is_disabled': false } ] }}";
            var getReceiptPreCreateInfoResponse = JsonConvert.DeserializeObject<GetReceiptPreCreateInfoResponse>(getReceiptPreCreateInfoResponseBody);
            instance
                .Setup(p => p.GetReceiptPreCreateInfo(Moq.It.IsAny<int>(), 0))
                .Returns(getReceiptPreCreateInfoResponse);

            getReceiptsMonthlyTotalsResponseBody = "{ 'data': [ { 'net': 15000.0, 'gross': 18000.0, 'count': 10.0 }, { 'net': 18000.0, 'gross': 22000.0, 'count': 20.0 }, { 'net': 20000.0, 'gross': 24400.0, 'count': 30.0 }, { 'net': 19000.0, 'gross': 22000.0, 'count': 20.0 }, { 'net': 17000.0, 'gross': 20000.0, 'count': 10.0 }, { 'net': 18000.0, 'gross': 24000.0, 'count': 21.0 }, { 'net': 22000.0, 'gross': 25000.0, 'count': 30.0 }, { 'net': 17000.0, 'gross': 21000.0, 'count': 21.0 }, { 'count': 10.0 }, { 'count': 20.0 }, { 'count': 30.0 }, { 'count': 21.0 } ]}";
            var getReceiptsMonthlyTotalsResponse = JsonConvert.DeserializeObject<GetReceiptsMonthlyTotalsResponse>(getReceiptsMonthlyTotalsResponseBody);
            instance
                .Setup(p => p.GetReceiptsMonthlyTotals(Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), 0))
                .Returns(getReceiptsMonthlyTotalsResponse);

            listReceiptsResponseBody = "{ 'current_page': 1, 'first_page_url': 'page=1', 'from': 1, 'last_page': 4, 'last_page_url': 'page=4', 'next_page_url': 'page=2', 'path': 'receipts', 'per_page': 50, 'to': 50, 'total': 65, 'data': [ { 'type': 'sales_receipt', 'id': 12345, 'date': '2021-08-20', 'number': 5.0, 'numeration': 'REC005', 'amount_net': 16.39, 'amount_vat': 3.61, 'amount_gross': 20.0, 'use_gross_prices': true, 'description': 'cassa 1', 'rc_center': '', 'created_at': '2021-08-20 13:56:56', 'updated_at': '2021-08-20 13:56:56', 'payment_account': { 'id': 222, 'name': 'carta di credito', 'virtual': false }, 'items_list': [ { 'id': 666, 'amount_net': 10.0, 'amount_gross': 12.2, 'category': 'altro', 'vat': { 'value': 22.0, 'description': 'iva', 'e_invoice': false, 'is_disabled': false } }, { 'id': 777, 'amount_net': 100.0, 'amount_gross': 104.0, 'category': 'altro', 'vat': { 'value': 22.0, 'description': 'iva', 'e_invoice': false, 'is_disabled': false } } ] }, { 'type': 'sales_receipt', 'id': 12346, 'date': '2021-08-19', 'number': 6.0, 'numeration': 'REC006', 'amount_net': 8.2, 'amount_vat': 1.8, 'amount_gross': 10.0, 'use_gross_prices': true, 'description': 'cassa 1', 'rc_center': '', 'created_at': '2021-08-19 17:57:56', 'updated_at': '2021-08-19 17:57:56', 'payment_account': { 'id': 555, 'name': 'contanti', 'virtual': false }, 'items_list': [ { 'id': 888, 'amount_net': 8.2, 'amount_gross': 10.0, 'category': 'altro', 'vat': { 'value': 22.0, 'description': 'iva', 'e_invoice': false, 'is_disabled': false } } ] } ]}";
            var listReceiptsResponse = JsonConvert.DeserializeObject<ListReceiptsResponse>(listReceiptsResponseBody);
            instance
                .Setup(p => p.ListReceipts(Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), 0))
                .Returns(listReceiptsResponse);

            modifyReceiptResponseBody = "{ 'data': { 'type': 'sales_receipt', 'id': 12346, 'date': '2021-08-19', 'number': 6.0, 'numeration': 'REC006', 'amount_net': 8.2, 'amount_vat': 1.8, 'amount_gross': 10.0, 'use_gross_prices': true, 'description': 'cassa 1', 'rc_center': '', 'created_at': '2021-08-19 17:57:56', 'updated_at': '2021-08-19 17:57:56', 'payment_account': { 'id': 555, 'name': 'contanti', 'virtual': false }, 'items_list': [ { 'id': 888, 'amount_net': 8.2, 'amount_gross': 10.0, 'category': 'altro', 'vat': { 'value': 22.0, 'description': 'iva', 'e_invoice': false, 'is_disabled': false } } ] }}";
            var modifyReceiptResponse = JsonConvert.DeserializeObject<ModifyReceiptResponse>(modifyReceiptResponseBody);
            instance
                .Setup(p => p.ModifyReceipt(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<ModifyReceiptRequest>(), 0))
                .Returns(modifyReceiptResponse);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReceiptsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<Mock<IReceiptsApi>>(instance);
        }

        /// <summary>
        /// Test CreateReceipt
        /// </summary>
        [Fact]
        public void CreateReceiptTest()
        {
            int companyId = 2;
            CreateReceiptRequest createReceiptRequest = new CreateReceiptRequest();

            var response = instance.Object.CreateReceipt(companyId, createReceiptRequest);
            JObject obj = JObject.Parse(createReceiptResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test DeleteReceipt
        /// </summary>
        [Fact]
        public void DeleteReceiptTest()
        {
            Assert.True(true);
        }

        /// <summary>
        /// Test GetReceipt
        /// </summary>
        [Fact]
        public void GetReceiptTest()
        {
            int companyId = 2;
            int documentId = 12345;
            string fields = "";
            string fieldset = "";

            var response = instance.Object.GetReceipt(companyId, documentId, fields, fieldset);
            JObject obj = JObject.Parse(getReceiptResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test GetReceiptPreCreateInfo
        /// </summary>
        [Fact]
        public void GetReceiptPreCreateInfoTest()
        {
            int companyId = 2;

            var response = instance.Object.GetReceiptPreCreateInfo(companyId);
            JObject obj = JObject.Parse(getReceiptPreCreateInfoResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test GetReceiptsMonthlyTotals
        /// </summary>
        [Fact]
        public void GetReceiptsMonthlyTotalsTest()
        {
            int companyId = 2;
            string type = "";
            string year = "";

            var response = instance.Object.GetReceiptsMonthlyTotals(companyId, type, year);
            JObject obj = JObject.Parse(getReceiptsMonthlyTotalsResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListReceipts
        /// </summary>
        [Fact]
        public void ListReceiptsTest()
        {
            int companyId = 2;
            string fields = "";
            string fieldset = "";
            int? page = 50;
            int? perPage = 5;
            string sort = "";

            var response = instance.Object.ListReceipts(companyId, fields, fieldset, page, perPage, sort);
            JObject obj = JObject.Parse(listReceiptsResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ModifyReceipt
        /// </summary>
        [Fact]
        public void ModifyReceiptTest()
        {
            int companyId = 2;
            int documentId = 12345;
            ModifyReceiptRequest modifyReceiptRequest = new ModifyReceiptRequest();

            var response = instance.Object.ModifyReceipt(companyId, documentId, modifyReceiptRequest);
            JObject obj = JObject.Parse(modifyReceiptResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }
    }
}
