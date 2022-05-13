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
    ///     Class for testing ListClientsResponse
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the model.
    /// </remarks>
    public class ListClientsResponseTests : IDisposable
    {
        private readonly ListClientsResponse instance;

        public ListClientsResponseTests()
        {
            var body =
                "{ 'current_page': 2, 'first_page_url': 'page=1', 'from': 1, 'last_page': 3, 'last_page_url': 'page=3', 'next_page_url': 'page=3', 'path': '/archive', 'per_page': 50, 'prev_page_url': 'page=1', 'to': 3, 'total': 155, 'data': [ { 'id': 16451, 'code': 'AE86', 'name': 'Avv. Maria Rossi', 'type': 'person', 'first_name': 'Maria', 'last_name': 'Rossi', 'contact_person': '', 'vat_number': 'IT12345640962', 'tax_code': 'BLTGNI5ABCDA794E', 'address_street': 'Via Roma, 1', 'address_postal_code': '20900', 'address_city': 'Milano', 'address_province': 'MI', 'address_extra': '', 'country': 'Italia', 'email': 'maria.rossi@example.com', 'certified_email': 'maria.rossi@pec.example.com', 'phone': '1234567890', 'fax': '', 'notes': '', 'created_at': '2021-04-29 08:53:07', 'updated_at': '2021-04-29 08:53:07', 'default_payment_terms': 1, 'default_payment_terms_type': 'standard', 'bank_name': 'Indesa', 'bank_iban': 'IT40P123456781000000123456', 'bank_swift_code': 'AK86PCT', 'shipping_address': 'Corso Magellano 4', 'e_invoice': true, 'ei_code': '111111', 'default_vat': { 'id': 54321, 'value': 45, 'description': '', 'is_disabled': false }, 'default_payment_method': { 'id': 386092, 'name': 'Credit card' } }, { 'id': 25330696, 'code': 'PD00', 'name': 'Mario Rossi', 'type': 'person', 'first_name': 'Mario', 'last_name': 'Rossi', 'contact_person': '', 'vat_number': 'IT1234567890', 'tax_code': 'ABCDEF12G34H567I', 'address_street': 'Via largo augusto 123', 'address_postal_code': '21012', 'address_city': 'Bergamo', 'address_province': 'BG', 'address_extra': '', 'country': 'Italia', 'email': 'info@mariorossi.it', 'certified_email': 'info@pec.mariorossi.it', 'phone': '012345678', 'fax': '012345678', 'notes': '', 'created_at': '2021-04-29 08:53:07', 'default_payment_terms': 0, 'default_payment_terms_type': 'standard', 'bank_name': 'Monte dei Pascoli', 'bank_iban': 'IT00P123456781000000123456', 'bank_swift_code': 'APL86PCT', 'shipping_address': 'Via Miilano 4', 'e_invoice': false, 'ei_code': '7654321', 'default_vat': { 'id': 66, 'value': 22, 'description': '', 'is_disabled': false }, 'default_payment_method': null } ] }";
            instance = JsonConvert.DeserializeObject<ListClientsResponse>(body);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        ///     Test an instance of ListClientsResponse
        /// </summary>
        [Fact]
        public void ListClientsResponseInstanceTest()
        {
            Assert.IsType<ListClientsResponse>(instance);
        }


        /// <summary>
        ///     Test the property 'CurrentPage'
        /// </summary>
        [Fact]
        public void CurrentPageTest()
        {
            Assert.IsType<int>(instance.CurrentPage);
        }

        /// <summary>
        ///     Test the property 'FirstPageUrl'
        /// </summary>
        [Fact]
        public void FirstPageUrlTest()
        {
            Assert.IsType<string>(instance.FirstPageUrl);
        }

        /// <summary>
        ///     Test the property 'From'
        /// </summary>
        [Fact]
        public void FromTest()
        {
            Assert.IsType<int>(instance.From);
        }

        /// <summary>
        ///     Test the property 'LastPage'
        /// </summary>
        [Fact]
        public void LastPageTest()
        {
            Assert.IsType<int>(instance.LastPage);
        }

        /// <summary>
        ///     Test the property 'LastPageUrl'
        /// </summary>
        [Fact]
        public void LastPageUrlTest()
        {
            Assert.IsType<string>(instance.LastPageUrl);
        }

        /// <summary>
        ///     Test the property 'NextPageUrl'
        /// </summary>
        [Fact]
        public void NextPageUrlTest()
        {
            Assert.IsType<string>(instance.NextPageUrl);
        }

        /// <summary>
        ///     Test the property 'Path'
        /// </summary>
        [Fact]
        public void PathTest()
        {
            Assert.IsType<string>(instance.Path);
        }

        /// <summary>
        ///     Test the property 'PerPage'
        /// </summary>
        [Fact]
        public void PerPageTest()
        {
            Assert.IsType<int>(instance.PerPage);
        }

        /// <summary>
        ///     Test the property 'PrevPageUrl'
        /// </summary>
        [Fact]
        public void PrevPageUrlTest()
        {
            Assert.IsType<string>(instance.PrevPageUrl);
        }

        /// <summary>
        ///     Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            Assert.IsType<int>(instance.To);
        }

        /// <summary>
        ///     Test the property 'Total'
        /// </summary>
        [Fact]
        public void TotalTest()
        {
            Assert.IsType<int>(instance.Total);
        }

        /// <summary>
        ///     Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            Assert.IsType<List<ModelClient>>(instance.Data);
        }
    }
}