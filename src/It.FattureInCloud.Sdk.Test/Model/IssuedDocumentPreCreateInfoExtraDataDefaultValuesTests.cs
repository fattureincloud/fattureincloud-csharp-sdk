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
    ///     Class for testing IssuedDocumentPreCreateInfoExtraDataDefaultValues
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class IssuedDocumentPreCreateInfoExtraDataDefaultValuesTests : IDisposable
    {
        private readonly IssuedDocumentPreCreateInfoExtraDataDefaultValues instance;

        public IssuedDocumentPreCreateInfoExtraDataDefaultValuesTests()
        {
            var body =
                "{ 'ts_communication': false, 'ts_tipo_spesa': 'SR', 'ts_flag_tipo_spesa': 0, 'ts_pagamento_tracciato': false }";
            instance = JsonConvert.DeserializeObject<IssuedDocumentPreCreateInfoExtraDataDefaultValues>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of IssuedDocumentPreCreateInfoExtraDataDefaultValues
        /// </summary>
        [Fact]
        public void IssuedDocumentPreCreateInfoExtraDataDefaultValuesInstanceTest()
        {
            Assert.IsType<IssuedDocumentPreCreateInfoExtraDataDefaultValues>(instance);
        }


        /// <summary>
        ///     Test the property 'TsCommunication'
        /// </summary>
        [Fact]
        public void TsCommunicationTest()
        {
            Assert.IsType<bool>(instance.TsCommunication);
        }

        /// <summary>
        ///     Test the property 'TsTipoSpesa'
        /// </summary>
        [Fact]
        public void TsTipoSpesaTest()
        {
            Assert.IsType<string>(instance.TsTipoSpesa);
        }

        /// <summary>
        ///     Test the property 'TsFlagTipoSpesa'
        /// </summary>
        [Fact]
        public void TsFlagTipoSpesaTest()
        {
            Assert.IsType<int>(instance.TsFlagTipoSpesa);
        }

        /// <summary>
        ///     Test the property 'TsPagamentoTracciato'
        /// </summary>
        [Fact]
        public void TsPagamentoTracciatoTest()
        {
            Assert.IsType<bool>(instance.TsPagamentoTracciato);
        }
    }
}