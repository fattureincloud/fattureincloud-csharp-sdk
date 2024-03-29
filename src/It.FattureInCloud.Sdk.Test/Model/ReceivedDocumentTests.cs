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
    ///  Class for testing ReceivedDocument
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ReceivedDocumentTests : IDisposable
    {
        private ReceivedDocument instance;

        public ReceivedDocumentTests()
        {
            var body = "{ 'id': 12345, 'type': 'expense', 'description': 'Soggiorno di lavoro', 'category': 'cat', 'amortization': 1, 'rc_center': 'rcc', 'invoice_number': 'inv12345', 'is_marked': false, 'is_detailed': false, 'e_invoice': false, 'date': '2021-08-15', 'next_due_date': '2021-08-15', 'amount_net': 592, 'amount_vat': 0, 'amount_gross': 592, 'amount_withholding_tax': 0, 'amount_other_withholding_tax': 0, 'tax_deductibility': 50, 'vat_deductibility': 100, 'attachment_url': 'spesa_ger5i783t45hu6ti.pdf', 'attachment_preview_url': '/preview.pdf', 'entity': { 'id': 111, 'name': 'Hotel Rubino Palace' }, 'currency': { 'id': 'EUR', 'exchange_rate': '1.00000', 'symbol': '€' }, 'payments_list': [ { 'amount': 592, 'due_date': '2021-08-15', 'paid_date': '2021-08-15', 'id': 777, 'payment_terms': { 'days': 0, 'type': 'standard' }, 'status': 'paid', 'payment_account': { 'id': 222, 'name': 'Contanti', 'virtual': false } } ], 'items_list': [ { 'id': 12345, 'product_id': 54321, 'code': 'pdr01', 'measure': 'very big', 'name': 'prod uan', 'net_price': 100, 'category': 'other', 'qty': 1, 'stock': 99, 'vat': { 'id': 1020, 'value': 0, 'description': 'PA Non imp art. 2', 'is_disabled': false } }], 'attachment_token': 'sjfbisfb43t5y454y65uhete' }";
            instance = JsonConvert.DeserializeObject<ReceivedDocument>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReceivedDocument
        /// </summary>
        [Fact]
        public void ReceivedDocumentInstanceTest()
        {
            Assert.IsType<ReceivedDocument>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            Assert.IsType<int>(instance.Id);
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            Assert.IsType<ReceivedDocumentType>(instance.Type);
        }
        /// <summary>
        /// Test the property 'Entity'
        /// </summary>
        [Fact]
        public void EntityTest()
        {
            Assert.IsType<Entity>(instance.Entity);
        }
        /// <summary>
        /// Test the property 'Date'
        /// </summary>
        [Fact]
        public void DateTest()
        {
            Assert.IsType<DateTime>(instance.Date);
        }
        /// <summary>
        /// Test the property 'Category'
        /// </summary>
        [Fact]
        public void CategoryTest()
        {
            Assert.IsType<string>(instance.Category);
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            Assert.IsType<string>(instance.Description);
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
        /// Test the property 'AmountVat'
        /// </summary>
        [Fact]
        public void AmountVatTest()
        {
            Assert.IsType<decimal>(instance.AmountVat);
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
        /// Test the property 'AmountOtherWithholdingTax'
        /// </summary>
        [Fact]
        public void AmountOtherWithholdingTaxTest()
        {
            Assert.IsType<decimal>(instance.AmountOtherWithholdingTax);
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
        /// Test the property 'Amortization'
        /// </summary>
        [Fact]
        public void AmortizationTest()
        {
            Assert.IsType<decimal>(instance.Amortization);
        }
        /// <summary>
        /// Test the property 'RcCenter'
        /// </summary>
        [Fact]
        public void RcCenterTest()
        {
            Assert.IsType<string>(instance.RcCenter);
        }
        /// <summary>
        /// Test the property 'InvoiceNumber'
        /// </summary>
        [Fact]
        public void InvoiceNumberTest()
        {
            Assert.IsType<string>(instance.InvoiceNumber);
        }
        /// <summary>
        /// Test the property 'IsMarked'
        /// </summary>
        [Fact]
        public void IsMarkedTest()
        {
            Assert.IsType<bool>(instance.IsMarked);
        }
        /// <summary>
        /// Test the property 'IsDetailed'
        /// </summary>
        [Fact]
        public void IsDetailedTest()
        {
            Assert.IsType<bool>(instance.IsDetailed);
        }
        /// <summary>
        /// Test the property 'EInvoice'
        /// </summary>
        [Fact]
        public void EInvoiceTest()
        {
            Assert.IsType<bool>(instance.EInvoice);
        }
        /// <summary>
        /// Test the property 'NextDueDate'
        /// </summary>
        [Fact]
        public void NextDueDateTest()
        {
            Assert.IsType<DateTime>(instance.NextDueDate);
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Fact]
        public void CurrencyTest()
        {
            Assert.IsType<Currency>(instance.Currency);
        }
        /// <summary>
        /// Test the property 'TaxDeductibility'
        /// </summary>
        [Fact]
        public void TaxDeductibilityTest()
        {
            Assert.IsType<decimal>(instance.TaxDeductibility);
        }
        /// <summary>
        /// Test the property 'VatDeductibility'
        /// </summary>
        [Fact]
        public void VatDeductibilityTest()
        {
            Assert.IsType<decimal>(instance.VatDeductibility);
        }
        /// <summary>
        /// Test the property 'ItemsList'
        /// </summary>
        [Fact]
        public void ItemsListTest()
        {
            Assert.IsType<string>(instance.RcCenter);
        }
        /// <summary>
        /// Test the property 'PaymentsList'
        /// </summary>
        [Fact]
        public void PaymentsListTest()
        {
            Assert.IsType<string>(instance.RcCenter);
        }
        /// <summary>
        /// Test the property 'AttachmentUrl'
        /// </summary>
        [Fact]
        public void AttachmentUrlTest()
        {
            Assert.IsType<string>(instance.AttachmentUrl);
        }
        /// <summary>
        /// Test the property 'AttachmentPreviewUrl'
        /// </summary>
        [Fact]
        public void AttachmentPreviewUrlTest()
        {
            Assert.IsType<string>(instance.AttachmentPreviewUrl);
        }
        /// <summary>
        /// Test the property 'AttachmentToken'
        /// </summary>
        [Fact]
        public void AttachmentTokenTest()
        {
            Assert.IsType<string>(instance.AttachmentToken);
        }

    }

}
