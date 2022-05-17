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
using It.FattureInCloud.Sdk.Model;

namespace It.FattureInCloud.Sdk.Test.Model
{
    /// <summary>
    ///     Class for testing GetNewReceivedDocumentTotalsRequest
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class GetNewReceivedDocumentTotalsRequestTests : IDisposable
    {
        private readonly GetNewReceivedDocumentTotalsRequest instance;

        public GetNewReceivedDocumentTotalsRequestTests()
        {
            var body =
                "{ 'data': { 'id': 12345, 'type': 'expense', 'description': 'Soggiorno di lavoro', 'category': 'cat', 'amortization': 1, 'rc_center': 'rcc', 'invoice_number': 'inv12345', 'is_marked': false, 'is_detailed': false, 'e_invoice': false, 'entity': { 'id': 111, 'name': 'Hotel Rubino Palace' }, 'date': '2021-08-15', 'next_due_date': '2021-08-15', 'currency': { 'id': 'EUR', 'exchange_rate': '1.00000', 'symbol': '€' }, 'amount_net': 592, 'amount_vat': 0, 'amount_gross': 592, 'amount_withholding_tax': 0, 'amount_other_withholding_tax': 0, 'tax_deductibility': 50, 'vat_deductibility': 100, 'attachment_url': 'spesa_ger5i783t45hu6ti.pdf', 'attachment_preview_url': '/preview.pdf', 'payments_list': [ { 'amount': 592, 'due_date': '2021-08-15', 'paid_date': '2021-08-15', 'id': 777, 'payment_terms': { 'days': 0, 'type': 'standard' }, 'status': 'paid' } ] } }";
            instance = JsonConvert.DeserializeObject<GetNewReceivedDocumentTotalsRequest>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of GetNewReceivedDocumentTotalsRequest
        /// </summary>
        [Fact]
        public void GetNewReceivedDocumentTotalsRequestInstanceTest()
        {
            Assert.IsType<GetNewReceivedDocumentTotalsRequest>(instance);
        }


        /// <summary>
        ///     Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<ReceivedDocument>(instance.Data);
        }
    }
}