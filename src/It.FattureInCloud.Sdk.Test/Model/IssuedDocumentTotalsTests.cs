/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.3
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Model;
using It.FattureInCloud.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace It.FattureInCloud.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing IssuedDocumentTotals
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IssuedDocumentTotalsTests : IDisposable
    {
        private IssuedDocumentTotals instance;

        public IssuedDocumentTotalsTests()
        {
            var body = "{ 'amount_net': 68.18, 'taxable_amount': 68.18, 'amount_vat': 6.82, 'amount_gross': 75, 'amount_due': 75, 'payments_sum': 75, 'amount_rivalsa': 10, 'amount_net_with_rivalsa': 10, 'amount_cassa': 10, 'not_taxable_amount': 10, 'taxable_amount_withholding_tax': 10, 'amount_withholding_tax': 10, 'taxable_amount_other_withholding_tax': 10, 'amount_other_withholding_tax': 10, 'stamp_duty': 10, 'is_enasarco_maximal_exceeded': false, 'payments_sum': 2, 'vat_list': { 'vat_item': { 'amount_net': 68.18, 'amount_vat': 6.82 } } }";
            instance = JsonConvert.DeserializeObject<IssuedDocumentTotals>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IssuedDocumentTotals
        /// </summary>
        [Fact]
        public void IssuedDocumentTotalsInstanceTest()
        {
            Assert.IsType<IssuedDocumentTotals>(instance);
        }


        /// <summary>
        /// Test the property 'AmountNet'
        /// </summary>
        [Fact]
        public void AmountNetTest()
        {
            Assert.IsType<decimal>(instance.AmountNet);
        }
        /// <summary>
        /// Test the property 'AmountRivalsa'
        /// </summary>
        [Fact]
        public void AmountRivalsaTest()
        {
            Assert.IsType<decimal>(instance.AmountRivalsa);
        }
        /// <summary>
        /// Test the property 'AmountNetWithRivalsa'
        /// </summary>
        [Fact]
        public void AmountNetWithRivalsaTest()
        {
            Assert.IsType<decimal>(instance.AmountNetWithRivalsa);
        }
        /// <summary>
        /// Test the property 'AmountCassa'
        /// </summary>
        [Fact]
        public void AmountCassaTest()
        {
            Assert.IsType<decimal>(instance.AmountCassa);
        }
        /// <summary>
        /// Test the property 'TaxableAmount'
        /// </summary>
        [Fact]
        public void TaxableAmountTest()
        {
            Assert.IsType<decimal>(instance.TaxableAmount);
        }
        /// <summary>
        /// Test the property 'NotTaxableAmount'
        /// </summary>
        [Fact]
        public void NotTaxableAmountTest()
        {
            Assert.IsType<decimal>(instance.NotTaxableAmount);
        }
        /// <summary>
        /// Test the property 'AmountVat'
        /// </summary>
        [Fact]
        public void AmountVatTest()
        {
            Assert.IsType<decimal>(instance.AmountVat);
        }
        /// <summary>
        /// Test the property 'AmountGross'
        /// </summary>
        [Fact]
        public void AmountGrossTest()
        {
            Assert.IsType<decimal>(instance.AmountGross);
        }
        /// <summary>
        /// Test the property 'TaxableAmountWithholdingTax'
        /// </summary>
        [Fact]
        public void TaxableAmountWithholdingTaxTest()
        {
            Assert.IsType<decimal>(instance.TaxableAmountWithholdingTax);
        }
        /// <summary>
        /// Test the property 'AmountWithholdingTax'
        /// </summary>
        [Fact]
        public void AmountWithholdingTaxTest()
        {
            Assert.IsType<decimal>(instance.AmountWithholdingTax);
        }
        /// <summary>
        /// Test the property 'TaxableAmountOtherWithholdingTax'
        /// </summary>
        [Fact]
        public void TaxableAmountOtherWithholdingTaxTest()
        {
            Assert.IsType<decimal>(instance.TaxableAmountOtherWithholdingTax);
        }
        /// <summary>
        /// Test the property 'AmountOtherWithholdingTax'
        /// </summary>
        [Fact]
        public void AmountOtherWithholdingTaxTest()
        {
            Assert.IsType<decimal>(instance.AmountOtherWithholdingTax);
        }
        /// <summary>
        /// Test the property 'StampDuty'
        /// </summary>
        [Fact]
        public void StampDutyTest()
        {
            Assert.IsType<decimal>(instance.StampDuty);
        }
        /// <summary>
        /// Test the property 'AmountDue'
        /// </summary>
        [Fact]
        public void AmountDueTest()
        {
            Assert.IsType<decimal>(instance.AmountDue);
        }
        /// <summary>
        /// Test the property 'IsEnasarcoMaximalExceeded'
        /// </summary>
        [Fact]
        public void IsEnasarcoMaximalExceededTest()
        {
            Assert.IsType<bool>(instance.IsEnasarcoMaximalExceeded);
        }
        /// <summary>
        /// Test the property 'PaymentsSum'
        /// </summary>
        [Fact]
        public void PaymentsSumTest()
        {
            Assert.IsType<decimal>(instance.PaymentsSum);
        }
        /// <summary>
        /// Test the property 'VatList'
        /// </summary>
        [Fact]
        public void VatListTest()
        {
            Assert.IsType<IssuedDocumentTotalsVatList>(instance.VatList);
        }

    }

}
