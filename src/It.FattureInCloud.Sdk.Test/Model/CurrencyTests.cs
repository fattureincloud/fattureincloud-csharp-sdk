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
    ///     Class for testing Currency
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class CurrencyTests : IDisposable
    {
        private readonly Currency instance;

        public CurrencyTests()
        {
            var body = "{ 'id': 'EUR', 'symbol': '€', 'html_symbol': '€', 'exchange_rate': '1.00000' }";
            instance = JsonConvert.DeserializeObject<Currency>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of Currency
        /// </summary>
        [Fact]
        public void CurrencyInstanceTest()
        {
            Assert.IsType<Currency>(instance);
        }


        /// <summary>
        ///     Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            Assert.IsType<string>(instance.Id);
        }

        /// <summary>
        ///     Test the property 'Symbol'
        /// </summary>
        [Fact]
        public void SymbolTest()
        {
            Assert.IsType<string>(instance.Symbol);
        }

        /// <summary>
        ///     Test the property 'ExchangeRate'
        /// </summary>
        [Fact]
        public void ExchangeRateTest()
        {
            Assert.IsType<string>(instance.ExchangeRate);
        }

        /// <summary>
        ///     Test the property 'HtmlSymbol'
        /// </summary>
        [Fact]
        public void HtmlSymbolTest()
        {
            Assert.IsType<string>(instance.HtmlSymbol);
        }
    }
}