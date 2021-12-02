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
    ///  Class for testing CompanyInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CompanyInfoTests : IDisposable
    {
        private CompanyInfo instance;

        public CompanyInfoTests()
        {
            var body = "{ 'id': 12345, 'name': 'Studio Commercialista', 'email': 'mario.rossi@example.com', 'type': 'accountant', 'fic': true, 'fic_plan_name': 'premium_plus', 'fic_signup_date': '2013-11-01', 'fic_license_expire': '2030-12-31', 'use_fic': true, 'fic_need_setup': false, 'fic_license_type': 'coupon_b', 'dic': true, 'dic_plan_name': 'trial', 'dic_signup_date': '2018-03-26', 'dic_license_expire': '2022-12-31', 'use_dic': true, 'dic_license_type': '', 'registration_service': 'fic', 'can_use_coupon': false, 'is_accountant': true, 'accountant_id': 12345, 'fic_payment_subject': 'client', 'dic_payment_subject': 'client', 'dic_plan': 'trial', 'dic_need_setup': false, 'access_info': { 'role': 'master', 'through_accountant': false, 'permissions': { 'fic_situation': 'read', 'fic_clients': 'write', 'fic_suppliers': 'write', 'fic_products': 'write', 'fic_issued_documents': 'detailed', 'fic_issued_documents_detailed': { 'quotes': 'write', 'proformas': 'write', 'invoices': 'write', 'receipts': 'write', 'delivery_notes': 'write', 'credit_notes': 'write', 'orders': 'write', 'work_reports': 'write', 'supplier_orders': 'write', 'self_invoices': 'write' }, 'fic_received_documents': 'write', 'fic_receipts': 'write', 'fic_calendar': 'write', 'fic_archive': 'write', 'fic_taxes': 'write', 'fic_stock': 'write', 'fic_cashbook': 'write', 'fic_settings': 'write', 'fic_emails': 'read', 'dic_employees': 'none', 'dic_timesheet': 'none', 'dic_settings': 'none', 'fic_invoice_trading': 'none', 'fic_export': 'write', 'fic_import_clients_suppliers': 'write', 'fic_import_products': 'write', 'fic_import_issued_documents': 'none', 'fic_import_bankstatements': 'none', 'fic_recurring': 'write', 'fic_riba': 'write' } }, 'plan_info': { 'limits': { 'clients': 5000, 'suppliers': 5000, 'products': 5000, 'documents': 3000 }, 'functions': { 'document_attachments': true, 'archive': true, 'payment_notifications': true, 'paypal': true, 'receipts': true, 'e_invoice': true, 'genius': true, 'stock': true, 'smtp': true, 'mail_tracking': true, 'subaccounts': true, 'tessera_sanitaria': true, 'recurring': true, 'sofort': false, 'cerved': true, 'ts_digital': true, 'ts_pay': true, 'ts_invoice_trading': true }, 'functions_status': { 'ts_digital': { 'active': true }, 'ts_pay': { 'active': true } } } }";
            instance = JsonConvert.DeserializeObject<CompanyInfo>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CompanyInfo
        /// </summary>
        [Fact]
        public void CompanyInfoInstanceTest()
        {
            Assert.IsType<CompanyInfo>(instance);
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
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            Assert.IsType<string>(instance.Name);
        }
        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            Assert.IsType<string>(instance.Email);
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            Assert.IsType<CompanyType>(instance.Type);
        }
        /// <summary>
        /// Test the property 'AccountantId'
        /// </summary>
        [Fact]
        public void AccountantIdTest()
        {
            Assert.IsType<int>(instance.AccountantId);
        }
        /// <summary>
        /// Test the property 'IsAccountant'
        /// </summary>
        [Fact]
        public void IsAccountantTest()
        {
            Assert.IsType<bool>(instance.IsAccountant);
        }

    }

}
