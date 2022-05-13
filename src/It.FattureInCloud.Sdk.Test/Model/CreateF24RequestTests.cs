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
    ///     Class for testing CreateF24Request
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class CreateF24RequestTests : IDisposable
    {
        private readonly CreateF24Request instance;

        public CreateF24RequestTests()
        {
            var body =
                "{ 'data': { 'amount': 840.36, 'description': 'PAGAMENTO IVA 2021', 'due_date': '2021-12-31', 'status': 'paid', 'payment_account': { 'id': 111 }, 'attachment_token': 'b19c01da9b1688fb73d0d9e8ad' } }";
            instance = JsonConvert.DeserializeObject<CreateF24Request>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of CreateF24Request
        /// </summary>
        [Fact]
        public void CreateF24RequestInstanceTest()
        {
            Assert.IsType<CreateF24Request>(instance);
        }


        /// <summary>
        ///     Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<F24>(instance.Data);
        }
    }
}