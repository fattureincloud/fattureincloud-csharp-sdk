/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.3
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using It.FattureInCloud.Sdk.Model;

namespace It.FattureInCloud.Sdk.Test.Model
{
    /// <summary>
    ///     Class for testing ListPaymentAccountsResponse
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class ListPaymentAccountsResponseTests : IDisposable
    {
        private readonly ListPaymentAccountsResponse instance;

        public ListPaymentAccountsResponseTests()
        {
            var body =
                "{ 'data': [ { 'id': 21, 'name': 'Indesa - Carta conto', 'type': 'standard', 'iban': null, 'sia': null, 'virtual': false }, { 'id': 109, 'name': 'Indesa', 'type': 'bank', 'iban': 'IT17A1234563200000003498936', 'sia': 'IN234', 'virtual': false } ] }";
            instance = JsonConvert.DeserializeObject<ListPaymentAccountsResponse>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of ListPaymentAccountsResponse
        /// </summary>
        [Fact]
        public void ListPaymentAccountsResponseInstanceTest()
        {
            Assert.IsType<ListPaymentAccountsResponse>(instance);
        }


        /// <summary>
        ///     Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<List<PaymentAccount>>(instance.Data);
        }
    }
}