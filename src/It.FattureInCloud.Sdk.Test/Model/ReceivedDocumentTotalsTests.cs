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
    ///     Class for testing ReceivedDocumentTotals
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class ReceivedDocumentTotalsTests : IDisposable
    {
        private readonly ReceivedDocumentTotals instance;

        public ReceivedDocumentTotalsTests()
        {
            var body =
                "{ 'amount_net': 592, 'amount_vat': 20, 'amount_gross': 612, 'amount_withholding_tax': 0, 'amount_other_withholding_tax': 0, 'amount_due': 612, 'payments_sum': 592 }";
            instance = JsonConvert.DeserializeObject<ReceivedDocumentTotals>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of ReceivedDocumentTotals
        /// </summary>
        [Fact]
        public void ReceivedDocumentTotalsInstanceTest()
        {
            Assert.IsType<ReceivedDocumentTotals>(instance);
        }


        /// <summary>
        ///     Test the property 'AmountNet'
        /// </summary>
        [Fact]
        public void AmountNetTest()
        {
            Assert.IsType<decimal>(instance.AmountNet);
        }

        /// <summary>
        ///     Test the property 'AmountVat'
        /// </summary>
        [Fact]
        public void AmountVatTest()
        {
            Assert.IsType<decimal>(instance.AmountVat);
        }

        /// <summary>
        ///     Test the property 'AmountGross'
        /// </summary>
        [Fact]
        public void AmountGrossTest()
        {
            Assert.IsType<decimal>(instance.AmountGross);
        }

        /// <summary>
        ///     Test the property 'AmountWithholdingTax'
        /// </summary>
        [Fact]
        public void AmountWithholdingTaxTest()
        {
            Assert.IsType<decimal>(instance.AmountWithholdingTax);
        }

        /// <summary>
        ///     Test the property 'AmountOtherWithholdingTax'
        /// </summary>
        [Fact]
        public void AmountOtherWithholdingTaxTest()
        {
            Assert.IsType<decimal>(instance.AmountOtherWithholdingTax);
        }

        /// <summary>
        ///     Test the property 'AmountDue'
        /// </summary>
        [Fact]
        public void AmountDueTest()
        {
            Assert.IsType<decimal>(instance.AmountDue);
        }

        /// <summary>
        ///     Test the property 'PaymentsSum'
        /// </summary>
        [Fact]
        public void PaymentsSumTest()
        {
            Assert.IsType<decimal>(instance.PaymentsSum);
        }
    }
}