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
    ///     Class for testing GetExistingIssuedDocumentTotalsResponse
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class GetExistingIssuedDocumentTotalsResponseTests : IDisposable
    {
        private readonly GetExistingIssuedDocumentTotalsResponse instance;

        public GetExistingIssuedDocumentTotalsResponseTests()
        {
            var body =
                "{ 'data': { 'amount_net': 68.18, 'amount_rivalsa': 13.64, 'amount_net_with_rivalsa': 81.82000000000001, 'taxable_amount': 81.82, 'vat_list': { '10': { 'amount_net': 81.82, 'amount_vat': 8.18 } }, 'amount_vat': 8.18, 'amount_gross': 90, 'amount_due': 90, 'payments_sum': 75 } }";
            instance = JsonConvert.DeserializeObject<GetExistingIssuedDocumentTotalsResponse>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of GetExistingIssuedDocumentTotalsResponse
        /// </summary>
        [Fact]
        public void GetExistingIssuedDocumentTotalsResponseInstanceTest()
        {
            Assert.IsType<GetExistingIssuedDocumentTotalsResponse>(instance);
        }


        /// <summary>
        ///     Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<IssuedDocumentTotals>(instance.Data);
        }
    }
}