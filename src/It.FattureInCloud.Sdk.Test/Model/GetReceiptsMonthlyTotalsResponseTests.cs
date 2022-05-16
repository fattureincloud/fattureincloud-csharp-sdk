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
    ///     Class for testing GetReceiptsMonthlyTotalsResponse
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class GetReceiptsMonthlyTotalsResponseTests : IDisposable
    {
        private readonly GetReceiptsMonthlyTotalsResponse instance;

        public GetReceiptsMonthlyTotalsResponseTests()
        {
            var body =
                "{'data':[{'net':15000,'gross':18000,'count':10},{'net':18000,'gross':22000,'count':20},{'net':20000,'gross':24400,'count':30},{'net':19000,'gross':22000,'count':20},{'net':17000,'gross':20000,'count':10},{'net':18000,'gross':24000,'count':21},{'net':22000,'gross':25000,'count':30},{'net':17000,'gross':21000,'count':21},{'net':0,'gross':0,'count':10},{'net':0,'gross':0,'count':20},{'net':0,'gross':0,'count':30},{'net':0,'gross':0,'count':21}]}";
            instance = JsonConvert.DeserializeObject<GetReceiptsMonthlyTotalsResponse>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of GetReceiptsMonthlyTotalsResponse
        /// </summary>
        [Fact]
        public void GetReceiptsMonthlyTotalsResponseInstanceTest()
        {
            Assert.IsType<GetReceiptsMonthlyTotalsResponse>(instance);
        }


        /// <summary>
        ///     Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<List<MonthlyTotal>>(instance.Data);
        }
    }
}