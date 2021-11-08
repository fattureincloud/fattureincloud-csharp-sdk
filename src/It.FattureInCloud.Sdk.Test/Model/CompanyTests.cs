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
    ///  Class for testing Company
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CompanyTests : IDisposable
    {
        private Company instance;

        public CompanyTests()
        {
            var body = "{ 'id': 12345, 'name': 'Studio Commercialista', 'tax_code': 'ABCSFN94T17A794K', 'type': 'accountant', 'access_token': '4ff5f0fe5abcd1d7157fa13ca72ab62b6183db0667a576a0e19164801c18c4f7362a848fa32dbb8c3a3f94c34f3df95', 'connection_id': 94566, 'fic': true, 'dic': true, 'fic_plan': 'premium_plus', 'fic_license_expire': '2021-12-31', 'access_token': 'ergaegwergq53wh65je5j', 'permissions': { 'fic_situation': 'write', 'fic_clients': 'write', 'fic_suppliers': 'write', 'fic_products': 'write', 'fic_issued_documents': 'write', 'fic_received_documents': 'write', 'fic_receipts': 'write', 'fic_calendar': 'write', 'fic_archive': 'write', 'fic_taxes': 'write', 'fic_stock': 'write', 'fic_cashbook': 'write', 'fic_settings': 'write', 'fic_emails': 'write', 'dic_employees': 'none', 'dic_timesheet': 'none', 'dic_settings': 'none' }, 'controlled_companies': [ { 'id': 12246, 'name': 'Studio Commercialista', 'tax_code': 'ABCSFN94T17A794K', 'type': 'company', 'access_token': '4ff5f0fe5abcdf1d7157fa13ca72ab62b6183db0667a576a0e19164801c18c4f7362a848fa32dbb8c3a3f94c34f3df95', 'connection_id': 94566, 'controlled_companies': [], 'fic': true, 'dic': true, 'fic_plan': 'premium_plus', 'fic_license_expire': '2021-12-31', 'permissions': { 'fic_situation': 'write', 'fic_clients': 'write', 'fic_suppliers': 'write', 'fic_products': 'write', 'fic_issued_documents': 'write', 'fic_received_documents': 'write', 'fic_receipts': 'write', 'fic_calendar': 'write', 'fic_archive': 'write', 'fic_taxes': 'write', 'fic_stock': 'write', 'fic_cashbook': 'write', 'fic_settings': 'write', 'fic_emails': 'write', 'dic_employees': 'write', 'dic_timesheet': 'write', 'dic_settings': 'write' } }, { 'id': 12347, 'name': 'Mario Rossi SRL', 'tax_code': '57398280214', 'type': 'company', 'access_token': '86690c98be13592e78b763c52fab2ba0c22faa118708ca5273da2b4dcdc7ad1234517107266d463fd9ae424a78c16cde', 'connection_id': 94566, 'controlled_companies': [], 'fic': true, 'dic': false, 'fic_plan': 'trial', 'fic_license_expire': '2021-12-31', 'permissions': { 'fic_situation': 'write', 'fic_clients': 'write', 'fic_suppliers': 'write', 'fic_products': 'write', 'fic_issued_documents': 'write', 'fic_received_documents': 'write', 'fic_receipts': 'write', 'fic_calendar': 'write', 'fic_archive': 'write', 'fic_taxes': 'write', 'fic_stock': 'write', 'fic_cashbook': 'write', 'fic_settings': 'write', 'fic_emails': 'write', 'dic_employees': 'none', 'dic_timesheet': 'none', 'dic_settings': 'none' } } ] }";
            instance = JsonConvert.DeserializeObject<Company>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Company
        /// </summary>
        [Fact]
        public void CompanyInstanceTest()
        {
            Assert.IsType<Company>(instance);
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
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            Assert.IsType<Company.TypeEnum>(instance.Type);
        }
        /// <summary>
        /// Test the property 'AccessToken'
        /// </summary>
        [Fact]
        public void AccessTokenTest()
        {
            Assert.IsType<string>(instance.AccessToken);
        }
        /// <summary>
        /// Test the property 'Permissions'
        /// </summary>
        [Fact]
        public void PermissionsTest()
        {
            Assert.IsType<Permissions>(instance.Permissions);
        }
        /// <summary>
        /// Test the property 'ControlledCompanies'
        /// </summary>
        [Fact]
        public void ControlledCompaniesTest()
        {
            Assert.IsType<List<Company>>(instance.ControlledCompanies);
        }
        /// <summary>
        /// Test the property 'ConnectionId'
        /// </summary>
        [Fact]
        public void ConnectionIdTest()
        {
            Assert.IsType<decimal>(instance.ConnectionId);
        }
        /// <summary>
        /// Test the property 'Dic'
        /// </summary>
        [Fact]
        public void DicTest()
        {
            Assert.IsType<bool>(instance.Dic);
        }
        /// <summary>
        /// Test the property 'Fic'
        /// </summary>
        [Fact]
        public void FicTest()
        {
            Assert.IsType<bool>(instance.Fic);
        }
        /// <summary>
        /// Test the property 'FicLicenseExpire'
        /// </summary>
        [Fact]
        public void FicLicenseExpireTest()
        {
            Assert.IsType<DateTimeOffset>(instance.FicLicenseExpire);
        }
        /// <summary>
        /// Test the property 'FicPlan'
        /// </summary>
        [Fact]
        public void FicPlanTest()
        {
            Assert.IsType<string>(instance.FicPlan);
        }
        /// <summary>
        /// Test the property 'TaxCode'
        /// </summary>
        [Fact]
        public void TaxCodeTest()
        {
            Assert.IsType<string>(instance.TaxCode);
        }

    }

}
