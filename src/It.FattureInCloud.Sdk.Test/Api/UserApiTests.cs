/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.  For more information, please visit https://www.fattureincloud.it.
 *
 * The version of the OpenAPI document: 2.0.1
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;
using Moq;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using It.FattureInCloud.Sdk.Model;

namespace It.FattureInCloud.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserApiTests : IDisposable
    {
        Mock<IUserApi> instance = new Mock<IUserApi>();
        string getUserInfoResponseBody;
        string listUserCompaniesResponseBody;

        public UserApiTests()
        {
            getUserInfoResponseBody = "{'data':{'id':2,'name':'Matteo Milesi2','first_name':'Matteo','last_name':'Milesi2','email':'matteo@example.com','picture':null,'hash':'5add29e1046432a1bf2ed7b612043029'},'info':{'need_password_change':false,'need_marketing_consents_confirmation':false,'need_terms_of_service_confirmation':false},'email_confirmation_state':{'need_confirmation':false}}";
            var getUserInfoResponse = JsonConvert.DeserializeObject<GetUserInfoResponse>(getUserInfoResponseBody);
            instance
                .Setup(p => p.GetUserInfo())
                .Returns(getUserInfoResponse);

            listUserCompaniesResponseBody = "{ 'data': { 'companies': [ { 'type': 'accountant', 'id': 12345, 'name': 'Studio Commercialista', 'access_token': '4ff5f0fe5abcd1d7157fa13ca72ab62b6183db0667a576a0e19164801c18c4f7362a848fa32dbb8c3a3f94c34f3df95', 'controlled_companies': [ { 'type': 'company', 'id': 12246, 'name': 'Studio Commercialista', 'access_token': '4ff5f0fe5abcdf1d7157fa13ca72ab62b6183db0667a576a0e19164801c18c4f7362a848fa32dbb8c3a3f94c34f3df95', 'permissions': { 'fic_situation': 'write', 'fic_clients': 'write', 'fic_suppliers': 'write', 'fic_products': 'write', 'fic_issued_documents': 'write', 'fic_received_documents': 'write', 'fic_receipts': 'write', 'fic_calendar': 'write', 'fic_archive': 'write', 'fic_taxes': 'write', 'fic_stock': 'write', 'fic_cashbook': 'write', 'fic_settings': 'write', 'fic_emails': 'write', 'dic_employees': 'write', 'dic_settings': 'write', 'dic_timesheet': 'write' }, 'controlled_companies': [], 'connection_id': 94566.0, 'dic': true, 'fic': true, 'fic_license_expire': '2021-12-31', 'fic_plan': 'premium_plus', 'tax_code': 'ABCSFN94T17A794K' }, { 'type': 'company', 'id': 12347, 'name': 'Mario Rossi SRL', 'access_token': '86690c98be13592e78b763c52fab2ba0c22faa118708ca5273da2b4dcdc7ad1234517107266d463fd9ae424a78c16cde', 'permissions': { 'fic_situation': 'write', 'fic_clients': 'write', 'fic_suppliers': 'write', 'fic_products': 'write', 'fic_issued_documents': 'write', 'fic_received_documents': 'write', 'fic_receipts': 'write', 'fic_calendar': 'write', 'fic_archive': 'write', 'fic_taxes': 'write', 'fic_stock': 'write', 'fic_cashbook': 'write', 'fic_settings': 'write', 'fic_emails': 'write', 'dic_employees': 'none', 'dic_settings': 'none', 'dic_timesheet': 'none' }, 'controlled_companies': [], 'connection_id': 94566.0, 'dic': false, 'fic': true, 'fic_license_expire': '2021-12-31', 'fic_plan': 'trial', 'tax_code': '57398280214' } ], 'connection_id': 94566.0, 'dic': false, 'fic': false, 'tax_code': 'ABCSFN94T17A794K' } ] } }";
            var listUserCompaniesResponse = JsonConvert.DeserializeObject<ListUserCompaniesResponse>(listUserCompaniesResponseBody);
            instance
                .Setup(p => p.ListUserCompanies())
                .Returns(listUserCompaniesResponse);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<Mock<IUserApi>>(instance);
        }

        /// <summary>
        /// Test GetUserInfo
        /// </summary>
        [Fact]
        public void GetUserInfoTest()
        {
            var response = instance.Object.GetUserInfo();
            JObject obj = JObject.Parse(getUserInfoResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListUserCompanies
        /// </summary>
        [Fact]
        public void ListUserCompaniesTest()
        {
            var response = instance.Object.ListUserCompanies();
            JObject obj = JObject.Parse(listUserCompaniesResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));

        }
    }
}
