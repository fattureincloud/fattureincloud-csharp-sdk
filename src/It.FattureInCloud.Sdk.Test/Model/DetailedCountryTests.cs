/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.14
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using It.FattureInCloud.Sdk.Model;

namespace It.FattureInCloud.Sdk.Test.Model
{
    /// <summary>
    ///     Class for testing DetailedCountry
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class DetailedCountryTests : IDisposable
    {
        private readonly DetailedCountry instance;

        public DetailedCountryTests()
        {
            var body = "{ 'name': 'Italia', 'settings_name': 'Italia', 'iso': 'IT', 'fiscal_iso': 'IT', 'uic': '086' }";
            instance = JsonConvert.DeserializeObject<DetailedCountry>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of DetailedCountry
        /// </summary>
        [Fact]
        public void DetailedCountryInstanceTest()
        {
            Assert.IsType<DetailedCountry>(instance);
        }


        /// <summary>
        ///     Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            Assert.IsType<string>(instance.Name);
        }

        /// <summary>
        ///     Test the property 'SettingsName'
        /// </summary>
        [Fact]
        public void SettingsNameTest()
        {
            Assert.IsType<string>(instance.SettingsName);
        }

        /// <summary>
        ///     Test the property 'Iso'
        /// </summary>
        [Fact]
        public void IsoTest()
        {
            Assert.IsType<string>(instance.Iso);
        }

        /// <summary>
        ///     Test the property 'FiscalIso'
        /// </summary>
        [Fact]
        public void FiscalIsoTest()
        {
            Assert.IsType<string>(instance.FiscalIso);
        }

        /// <summary>
        ///     Test the property 'Uic'
        /// </summary>
        [Fact]
        public void UicTest()
        {
            Assert.IsType<string>(instance.Uic);
        }
    }
}