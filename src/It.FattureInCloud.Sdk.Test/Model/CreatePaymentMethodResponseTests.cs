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
    ///     Class for testing CreatePaymentMethodResponse
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class CreatePaymentMethodResponseTests : IDisposable
    {
        private readonly CreatePaymentMethodResponse instance;

        public CreatePaymentMethodResponseTests()
        {
            var body =
                "{ 'data': { 'id': 386683, 'name': 'Bonifico bancario', 'is_default': true, 'type': 'standard', 'details': [ { 'title': 'Banca', 'description': 'Sao Paulo' } ], 'default_payment_account': { 'id': 12345, 'name': 'conto banca SP' } } }";
            instance = JsonConvert.DeserializeObject<CreatePaymentMethodResponse>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of CreatePaymentMethodResponse
        /// </summary>
        [Fact]
        public void CreatePaymentMethodResponseInstanceTest()
        {
            Assert.IsType<CreatePaymentMethodResponse>(instance);
        }


        /// <summary>
        ///     Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<PaymentMethod>(instance.Data);
        }
    }
}