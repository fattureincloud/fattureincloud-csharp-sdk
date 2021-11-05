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
    ///  Class for testing ModifyReceivedDocumentResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ModifyReceivedDocumentResponseTests : IDisposable
    {
        private ModifyReceivedDocumentResponse instance;

        public ModifyReceivedDocumentResponseTests()
        {
            var body = "{ 'data': { 'type': 'expense', 'description': 'Soggiorno di lavoro', 'amortization': 1, 'rc_center': '', 'invoice_number': '', 'is_marked': false, 'is_detailed': false, 'e_invoice': false, 'entity': { 'id': 111, 'name': 'Hotel Rubino Palace' }, 'date': '2021-08-15', 'next_due_date': '2021-08-15', 'currency': { 'id': 'EUR', 'exchange_rate': '1.00000', 'symbol': '€' }, 'amount_net': 592, 'amount_vat': 0, 'amount_gross': 592, 'amount_withholding_tax': 0, 'amount_other_withholding_tax': 0, 'tax_deductibility': 50, 'vat_deductibility': 100, 'payments_list': [ { 'amount': 592, 'due_date': '2021-08-15', 'paid_date': '2021-08-15', 'id': 777, 'payment_terms': { 'days': 0, 'type': 'standard' }, 'status': 'paid', 'payment_account': { 'id': 222, 'name': 'Contanti', 'virtual': false } } ] } }";
            instance = JsonConvert.DeserializeObject<ModifyReceivedDocumentResponse>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ModifyReceivedDocumentResponse
        /// </summary>
        [Fact]
        public void ModifyReceivedDocumentResponseInstanceTest()
        {
            Assert.IsType<ModifyReceivedDocumentResponse>(instance);
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<ReceivedDocument>(instance.Data);
        }

    }

}
