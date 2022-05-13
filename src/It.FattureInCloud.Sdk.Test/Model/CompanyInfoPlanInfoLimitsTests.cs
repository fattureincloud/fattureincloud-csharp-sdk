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
    ///     Class for testing CompanyInfoPlanInfoLimits
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class CompanyInfoPlanInfoLimitsTests : IDisposable
    {
        private readonly CompanyInfoPlanInfoLimits instance;

        public CompanyInfoPlanInfoLimitsTests()
        {
            var body = "{ 'clients': 5000, 'suppliers': 5000, 'products': 5000, 'documents': 3000 }";
            instance = JsonConvert.DeserializeObject<CompanyInfoPlanInfoLimits>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of CompanyInfoPlanInfoLimits
        /// </summary>
        [Fact]
        public void CompanyInfoPlanInfoLimitsInstanceTest()
        {
            Assert.IsType<CompanyInfoPlanInfoLimits>(instance);
        }


        /// <summary>
        ///     Test the property 'Clients'
        /// </summary>
        [Fact]
        public void ClientsTest()
        {
            Assert.IsType<int>(instance.Clients);
        }

        /// <summary>
        ///     Test the property 'Suppliers'
        /// </summary>
        [Fact]
        public void SuppliersTest()
        {
            Assert.IsType<int>(instance.Suppliers);
        }

        /// <summary>
        ///     Test the property 'Products'
        /// </summary>
        [Fact]
        public void ProductsTest()
        {
            Assert.IsType<int>(instance.Products);
        }

        /// <summary>
        ///     Test the property 'Documents'
        /// </summary>
        [Fact]
        public void DocumentsTest()
        {
            Assert.IsType<int>(instance.Documents);
        }
    }
}