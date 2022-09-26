# FattureInCloud C# SDK

[![NuGet](https://img.shields.io/nuget/v/It.FattureInCloud.Sdk?color=g)](https://www.nuget.org/packages/It.FattureInCloud.Sdk) ![unit tests](https://github.com/fattureincloud/fattureincloud-csharp-sdk/actions/workflows/validate.yaml/badge.svg)

Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy. 

The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 2.0.20
- SDK version: 2.0.15
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen


For more information, please visit [https://www.fattureincloud.it](https://www.fattureincloud.it)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation

To install the bindings via [Nuget](https://www.nuget.org), run the following command:
```shell
dotnet add package It.FattureInCloud.Sdk
```

Then add the following namespaces to your project:
```csharp
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchiveApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var createArchiveDocumentRequest = new CreateArchiveDocumentRequest(); // CreateArchiveDocumentRequest | The Archive Document. (optional) 

            try
            {
                // Create Archive Document
                CreateArchiveDocumentResponse result = apiInstance.CreateArchiveDocument(companyId, createArchiveDocumentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArchiveApi.CreateArchiveDocument: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api-v2.fattureincloud.it*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ArchiveApi* | [**CreateArchiveDocument**](docs/ArchiveApi.md#createarchivedocument) | **POST** /c/{company_id}/archive | Create Archive Document
*ArchiveApi* | [**DeleteArchiveDocument**](docs/ArchiveApi.md#deletearchivedocument) | **DELETE** /c/{company_id}/archive/{document_id} | Delete Archive Document
*ArchiveApi* | [**GetArchiveDocument**](docs/ArchiveApi.md#getarchivedocument) | **GET** /c/{company_id}/archive/{document_id} | Get Archive Document
*ArchiveApi* | [**ListArchiveDocuments**](docs/ArchiveApi.md#listarchivedocuments) | **GET** /c/{company_id}/archive | List Archive Documents
*ArchiveApi* | [**ModifyArchiveDocument**](docs/ArchiveApi.md#modifyarchivedocument) | **PUT** /c/{company_id}/archive/{document_id} | Modify Archive Document
*ArchiveApi* | [**UploadArchiveDocumentAttachment**](docs/ArchiveApi.md#uploadarchivedocumentattachment) | **POST** /c/{company_id}/archive/attachment | Upload Archive Document Attachment
*CashbookApi* | [**CreateCashbookEntry**](docs/CashbookApi.md#createcashbookentry) | **POST** /c/{company_id}/cashbook | Create Cashbook Entry
*CashbookApi* | [**DeleteCashbookEntry**](docs/CashbookApi.md#deletecashbookentry) | **DELETE** /c/{company_id}/cashbook/{document_id} | Delete Cashbook Entry
*CashbookApi* | [**GetCashbookEntry**](docs/CashbookApi.md#getcashbookentry) | **GET** /c/{company_id}/cashbook/{document_id} | Get Cashbook Entry
*CashbookApi* | [**ListCashbookEntries**](docs/CashbookApi.md#listcashbookentries) | **GET** /c/{company_id}/cashbook | List Cashbook Entries
*CashbookApi* | [**ModifyCashbookEntry**](docs/CashbookApi.md#modifycashbookentry) | **PUT** /c/{company_id}/cashbook/{document_id} | Modify Cashbook Entry
*ClientsApi* | [**CreateClient**](docs/ClientsApi.md#createclient) | **POST** /c/{company_id}/entities/clients | Create Client
*ClientsApi* | [**DeleteClient**](docs/ClientsApi.md#deleteclient) | **DELETE** /c/{company_id}/entities/clients/{client_id} | Delete Client
*ClientsApi* | [**GetClient**](docs/ClientsApi.md#getclient) | **GET** /c/{company_id}/entities/clients/{client_id} | Get Client
*ClientsApi* | [**ListClients**](docs/ClientsApi.md#listclients) | **GET** /c/{company_id}/entities/clients | List Clients
*ClientsApi* | [**ModifyClient**](docs/ClientsApi.md#modifyclient) | **PUT** /c/{company_id}/entities/clients/{client_id} | Modify Client
*CompaniesApi* | [**GetCompanyInfo**](docs/CompaniesApi.md#getcompanyinfo) | **GET** /c/{company_id}/company/info | Get Company Info
*InfoApi* | [**ListArchiveCategories**](docs/InfoApi.md#listarchivecategories) | **GET** /c/{company_id}/info/archive_categories | List Archive Categories
*InfoApi* | [**ListCities**](docs/InfoApi.md#listcities) | **GET** /info/cities | List Cities
*InfoApi* | [**ListCostCenters**](docs/InfoApi.md#listcostcenters) | **GET** /c/{company_id}/info/cost_centers | List Cost Centers
*InfoApi* | [**ListCountries**](docs/InfoApi.md#listcountries) | **GET** /info/countries | List Countries
*InfoApi* | [**ListCurrencies**](docs/InfoApi.md#listcurrencies) | **GET** /info/currencies | List Currencies
*InfoApi* | [**ListDeliveryNotesDefaultCausals**](docs/InfoApi.md#listdeliverynotesdefaultcausals) | **GET** /info/dn_causals | List Delivery Notes Default Causals
*InfoApi* | [**ListDetailedCountries**](docs/InfoApi.md#listdetailedcountries) | **GET** /info/detailed_countries | List Detailed Countries
*InfoApi* | [**ListLanguages**](docs/InfoApi.md#listlanguages) | **GET** /info/languages | List Languages
*InfoApi* | [**ListPaymentAccounts**](docs/InfoApi.md#listpaymentaccounts) | **GET** /c/{company_id}/info/payment_accounts | List Payment Accounts
*InfoApi* | [**ListPaymentMethods**](docs/InfoApi.md#listpaymentmethods) | **GET** /c/{company_id}/info/payment_methods | List Payment Methods
*InfoApi* | [**ListProductCategories**](docs/InfoApi.md#listproductcategories) | **GET** /c/{company_id}/info/product_categories | List Product Categories
*InfoApi* | [**ListReceivedDocumentCategories**](docs/InfoApi.md#listreceiveddocumentcategories) | **GET** /c/{company_id}/info/received_document_categories | List Received Document Categories
*InfoApi* | [**ListRevenueCenters**](docs/InfoApi.md#listrevenuecenters) | **GET** /c/{company_id}/info/revenue_centers | List Revenue Centers
*InfoApi* | [**ListTemplates**](docs/InfoApi.md#listtemplates) | **GET** /info/templates | List Templates
*InfoApi* | [**ListUnitsOfMeasure**](docs/InfoApi.md#listunitsofmeasure) | **GET** /info/measures | List Units of Measure
*InfoApi* | [**ListVatTypes**](docs/InfoApi.md#listvattypes) | **GET** /c/{company_id}/info/vat_types | List Vat Types
*IssuedDocumentsApi* | [**CreateIssuedDocument**](docs/IssuedDocumentsApi.md#createissueddocument) | **POST** /c/{company_id}/issued_documents | Create Issued Document
*IssuedDocumentsApi* | [**DeleteIssuedDocument**](docs/IssuedDocumentsApi.md#deleteissueddocument) | **DELETE** /c/{company_id}/issued_documents/{document_id} | Delete Issued Document
*IssuedDocumentsApi* | [**DeleteIssuedDocumentAttachment**](docs/IssuedDocumentsApi.md#deleteissueddocumentattachment) | **DELETE** /c/{company_id}/issued_documents/{document_id}/attachment | Delete Issued Document Attachment
*IssuedDocumentsApi* | [**GetEmailData**](docs/IssuedDocumentsApi.md#getemaildata) | **GET** /c/{company_id}/issued_documents/{document_id}/email | Get Email Data
*IssuedDocumentsApi* | [**GetExistingIssuedDocumentTotals**](docs/IssuedDocumentsApi.md#getexistingissueddocumenttotals) | **POST** /c/{company_id}/issued_documents/{document_id}/totals | Get Existing Issued Document Totals
*IssuedDocumentsApi* | [**GetIssuedDocument**](docs/IssuedDocumentsApi.md#getissueddocument) | **GET** /c/{company_id}/issued_documents/{document_id} | Get Issued Document
*IssuedDocumentsApi* | [**GetIssuedDocumentPreCreateInfo**](docs/IssuedDocumentsApi.md#getissueddocumentprecreateinfo) | **GET** /c/{company_id}/issued_documents/info | Get Issued Document Pre-create info
*IssuedDocumentsApi* | [**GetNewIssuedDocumentTotals**](docs/IssuedDocumentsApi.md#getnewissueddocumenttotals) | **POST** /c/{company_id}/issued_documents/totals | Get New Issued Document Totals
*IssuedDocumentsApi* | [**ListIssuedDocuments**](docs/IssuedDocumentsApi.md#listissueddocuments) | **GET** /c/{company_id}/issued_documents | List Issued Documents
*IssuedDocumentsApi* | [**ModifyIssuedDocument**](docs/IssuedDocumentsApi.md#modifyissueddocument) | **PUT** /c/{company_id}/issued_documents/{document_id} | Modify Issued Document
*IssuedDocumentsApi* | [**ScheduleEmail**](docs/IssuedDocumentsApi.md#scheduleemail) | **POST** /c/{company_id}/issued_documents/{document_id}/email | Schedule Email
*IssuedDocumentsApi* | [**UploadIssuedDocumentAttachment**](docs/IssuedDocumentsApi.md#uploadissueddocumentattachment) | **POST** /c/{company_id}/issued_documents/attachment | Upload Issued Document Attachment
*IssuedEInvoicesApi* | [**GetEInvoiceRejectionReason**](docs/IssuedEInvoicesApi.md#geteinvoicerejectionreason) | **GET** /c/{company_id}/issued_documents/{document_id}/e_invoice/error_reason | Get e-invoice rejection reason
*IssuedEInvoicesApi* | [**GetEInvoiceXml**](docs/IssuedEInvoicesApi.md#geteinvoicexml) | **GET** /c/{company_id}/issued_documents/{document_id}/e_invoice/xml | Get e-invoice XML
*IssuedEInvoicesApi* | [**SendEInvoice**](docs/IssuedEInvoicesApi.md#sendeinvoice) | **POST** /c/{company_id}/issued_documents/{document_id}/e_invoice/send | Send the e-invoice
*IssuedEInvoicesApi* | [**VerifyEInvoiceXml**](docs/IssuedEInvoicesApi.md#verifyeinvoicexml) | **GET** /c/{company_id}/issued_documents/{document_id}/e_invoice/xml_verify | Verify e-invoice XML
*ProductsApi* | [**CreateProduct**](docs/ProductsApi.md#createproduct) | **POST** /c/{company_id}/products | Create Product
*ProductsApi* | [**DeleteProduct**](docs/ProductsApi.md#deleteproduct) | **DELETE** /c/{company_id}/products/{product_id} | Delete Product
*ProductsApi* | [**GetProduct**](docs/ProductsApi.md#getproduct) | **GET** /c/{company_id}/products/{product_id} | Get Product
*ProductsApi* | [**ListProducts**](docs/ProductsApi.md#listproducts) | **GET** /c/{company_id}/products | List Products
*ProductsApi* | [**ModifyProduct**](docs/ProductsApi.md#modifyproduct) | **PUT** /c/{company_id}/products/{product_id} | Modify Product
*ReceiptsApi* | [**CreateReceipt**](docs/ReceiptsApi.md#createreceipt) | **POST** /c/{company_id}/receipts | Create Receipt
*ReceiptsApi* | [**DeleteReceipt**](docs/ReceiptsApi.md#deletereceipt) | **DELETE** /c/{company_id}/receipts/{document_id} | Delete Receipt
*ReceiptsApi* | [**GetReceipt**](docs/ReceiptsApi.md#getreceipt) | **GET** /c/{company_id}/receipts/{document_id} | Get Receipt
*ReceiptsApi* | [**GetReceiptPreCreateInfo**](docs/ReceiptsApi.md#getreceiptprecreateinfo) | **GET** /c/{company_id}/receipts/info | Get Receipt Pre-Create Info
*ReceiptsApi* | [**GetReceiptsMonthlyTotals**](docs/ReceiptsApi.md#getreceiptsmonthlytotals) | **GET** /c/{company_id}/receipts/monthly_totals | Get Receipts Monthly Totals
*ReceiptsApi* | [**ListReceipts**](docs/ReceiptsApi.md#listreceipts) | **GET** /c/{company_id}/receipts | List Receipts
*ReceiptsApi* | [**ModifyReceipt**](docs/ReceiptsApi.md#modifyreceipt) | **PUT** /c/{company_id}/receipts/{document_id} | Modify Receipt
*ReceivedDocumentsApi* | [**CreateReceivedDocument**](docs/ReceivedDocumentsApi.md#createreceiveddocument) | **POST** /c/{company_id}/received_documents | Create Received Document
*ReceivedDocumentsApi* | [**DeleteReceivedDocument**](docs/ReceivedDocumentsApi.md#deletereceiveddocument) | **DELETE** /c/{company_id}/received_documents/{document_id} | Delete Received Document
*ReceivedDocumentsApi* | [**DeleteReceivedDocumentAttachment**](docs/ReceivedDocumentsApi.md#deletereceiveddocumentattachment) | **DELETE** /c/{company_id}/received_documents/{document_id}/attachment | Delete Received Document Attachment
*ReceivedDocumentsApi* | [**GetExistingReceivedDocumentTotals**](docs/ReceivedDocumentsApi.md#getexistingreceiveddocumenttotals) | **POST** /c/{company_id}/received_documents/{document_id}/totals | Get Existing Received Document Totals
*ReceivedDocumentsApi* | [**GetNewReceivedDocumentTotals**](docs/ReceivedDocumentsApi.md#getnewreceiveddocumenttotals) | **POST** /c/{company_id}/received_documents/totals | Get New Received Document Totals
*ReceivedDocumentsApi* | [**GetReceivedDocument**](docs/ReceivedDocumentsApi.md#getreceiveddocument) | **GET** /c/{company_id}/received_documents/{document_id} | Get Received Document
*ReceivedDocumentsApi* | [**GetReceivedDocumentPreCreateInfo**](docs/ReceivedDocumentsApi.md#getreceiveddocumentprecreateinfo) | **GET** /c/{company_id}/received_documents/info | Get Received Document Pre-Create Info
*ReceivedDocumentsApi* | [**ListReceivedDocuments**](docs/ReceivedDocumentsApi.md#listreceiveddocuments) | **GET** /c/{company_id}/received_documents | List Received Documents
*ReceivedDocumentsApi* | [**ModifyReceivedDocument**](docs/ReceivedDocumentsApi.md#modifyreceiveddocument) | **PUT** /c/{company_id}/received_documents/{document_id} | Modify Received Document
*ReceivedDocumentsApi* | [**UploadReceivedDocumentAttachment**](docs/ReceivedDocumentsApi.md#uploadreceiveddocumentattachment) | **POST** /c/{company_id}/received_documents/attachment | Upload Received Document Attachment
*SettingsApi* | [**CreatePaymentAccount**](docs/SettingsApi.md#createpaymentaccount) | **POST** /c/{company_id}/settings/payment_accounts | Create Payment Account
*SettingsApi* | [**CreatePaymentMethod**](docs/SettingsApi.md#createpaymentmethod) | **POST** /c/{company_id}/settings/payment_methods | Create Payment Method
*SettingsApi* | [**CreateVatType**](docs/SettingsApi.md#createvattype) | **POST** /c/{company_id}/settings/vat_types | Create Vat Type
*SettingsApi* | [**DeletePaymentAccount**](docs/SettingsApi.md#deletepaymentaccount) | **DELETE** /c/{company_id}/settings/payment_accounts/{payment_account_id} | Delete Payment Account
*SettingsApi* | [**DeletePaymentMethod**](docs/SettingsApi.md#deletepaymentmethod) | **DELETE** /c/{company_id}/settings/payment_methods/{payment_method_id} | Delete Payment Method
*SettingsApi* | [**DeleteVatType**](docs/SettingsApi.md#deletevattype) | **DELETE** /c/{company_id}/settings/vat_types/{vat_type_id} | Delete Vat Type
*SettingsApi* | [**GetPaymentAccount**](docs/SettingsApi.md#getpaymentaccount) | **GET** /c/{company_id}/settings/payment_accounts/{payment_account_id} | Get Payment Account
*SettingsApi* | [**GetPaymentMethod**](docs/SettingsApi.md#getpaymentmethod) | **GET** /c/{company_id}/settings/payment_methods/{payment_method_id} | Get Payment Method
*SettingsApi* | [**GetVatType**](docs/SettingsApi.md#getvattype) | **GET** /c/{company_id}/settings/vat_types/{vat_type_id} | Get Vat Type
*SettingsApi* | [**ModifyPaymentAccount**](docs/SettingsApi.md#modifypaymentaccount) | **PUT** /c/{company_id}/settings/payment_accounts/{payment_account_id} | Modify Payment Account
*SettingsApi* | [**ModifyPaymentMethod**](docs/SettingsApi.md#modifypaymentmethod) | **PUT** /c/{company_id}/settings/payment_methods/{payment_method_id} | Modify Payment Method
*SettingsApi* | [**ModifyVatType**](docs/SettingsApi.md#modifyvattype) | **PUT** /c/{company_id}/settings/vat_types/{vat_type_id} | Modify Vat Type
*SuppliersApi* | [**CreateSupplier**](docs/SuppliersApi.md#createsupplier) | **POST** /c/{company_id}/entities/suppliers | Create Supplier
*SuppliersApi* | [**DeleteSupplier**](docs/SuppliersApi.md#deletesupplier) | **DELETE** /c/{company_id}/entities/suppliers/{supplier_id} | Delete Supplier
*SuppliersApi* | [**GetSupplier**](docs/SuppliersApi.md#getsupplier) | **GET** /c/{company_id}/entities/suppliers/{supplier_id} | Get Supplier
*SuppliersApi* | [**ListSuppliers**](docs/SuppliersApi.md#listsuppliers) | **GET** /c/{company_id}/entities/suppliers | List Suppliers
*SuppliersApi* | [**ModifySupplier**](docs/SuppliersApi.md#modifysupplier) | **PUT** /c/{company_id}/entities/suppliers/{supplier_id} | Modify Supplier
*TaxesApi* | [**CreateF24**](docs/TaxesApi.md#createf24) | **POST** /c/{company_id}/taxes | Create F24
*TaxesApi* | [**DeleteF24**](docs/TaxesApi.md#deletef24) | **DELETE** /c/{company_id}/taxes/{document_id} | Delete F24
*TaxesApi* | [**DeleteF24Attachment**](docs/TaxesApi.md#deletef24attachment) | **DELETE** /c/{company_id}/taxes/{document_id}/attachment | Delete F24 Attachment
*TaxesApi* | [**GetF24**](docs/TaxesApi.md#getf24) | **GET** /c/{company_id}/taxes/{document_id} | Get F24
*TaxesApi* | [**ListF24**](docs/TaxesApi.md#listf24) | **GET** /c/{company_id}/taxes | List F24
*TaxesApi* | [**ModifyF24**](docs/TaxesApi.md#modifyf24) | **PUT** /c/{company_id}/taxes/{document_id} | Modify F24
*TaxesApi* | [**UploadF24Attachment**](docs/TaxesApi.md#uploadf24attachment) | **POST** /c/{company_id}/taxes/attachment | Upload F24 Attachment
*UserApi* | [**GetUserInfo**](docs/UserApi.md#getuserinfo) | **GET** /user/info | Get User Info
*UserApi* | [**ListUserCompanies**](docs/UserApi.md#listusercompanies) | **GET** /user/companies | List User Companies


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ArchiveDocument](docs/ArchiveDocument.md)
 - [Model.AttachmentData](docs/AttachmentData.md)
 - [Model.CashbookEntry](docs/CashbookEntry.md)
 - [Model.CashbookEntryDocument](docs/CashbookEntryDocument.md)
 - [Model.CashbookEntryKind](docs/CashbookEntryKind.md)
 - [Model.CashbookEntryType](docs/CashbookEntryType.md)
 - [Model.City](docs/City.md)
 - [Model.ClientType](docs/ClientType.md)
 - [Model.Company](docs/Company.md)
 - [Model.CompanyInfo](docs/CompanyInfo.md)
 - [Model.CompanyInfoAccessInfo](docs/CompanyInfoAccessInfo.md)
 - [Model.CompanyInfoPlanInfo](docs/CompanyInfoPlanInfo.md)
 - [Model.CompanyInfoPlanInfoFunctions](docs/CompanyInfoPlanInfoFunctions.md)
 - [Model.CompanyInfoPlanInfoFunctionsStatus](docs/CompanyInfoPlanInfoFunctionsStatus.md)
 - [Model.CompanyInfoPlanInfoLimits](docs/CompanyInfoPlanInfoLimits.md)
 - [Model.CompanyType](docs/CompanyType.md)
 - [Model.ControlledCompany](docs/ControlledCompany.md)
 - [Model.CreateArchiveDocumentRequest](docs/CreateArchiveDocumentRequest.md)
 - [Model.CreateArchiveDocumentResponse](docs/CreateArchiveDocumentResponse.md)
 - [Model.CreateCashbookEntryRequest](docs/CreateCashbookEntryRequest.md)
 - [Model.CreateCashbookEntryResponse](docs/CreateCashbookEntryResponse.md)
 - [Model.CreateClientRequest](docs/CreateClientRequest.md)
 - [Model.CreateClientResponse](docs/CreateClientResponse.md)
 - [Model.CreateF24Request](docs/CreateF24Request.md)
 - [Model.CreateF24Response](docs/CreateF24Response.md)
 - [Model.CreateIssuedDocumentRequest](docs/CreateIssuedDocumentRequest.md)
 - [Model.CreateIssuedDocumentResponse](docs/CreateIssuedDocumentResponse.md)
 - [Model.CreatePaymentAccountRequest](docs/CreatePaymentAccountRequest.md)
 - [Model.CreatePaymentAccountResponse](docs/CreatePaymentAccountResponse.md)
 - [Model.CreatePaymentMethodRequest](docs/CreatePaymentMethodRequest.md)
 - [Model.CreatePaymentMethodResponse](docs/CreatePaymentMethodResponse.md)
 - [Model.CreateProductRequest](docs/CreateProductRequest.md)
 - [Model.CreateProductResponse](docs/CreateProductResponse.md)
 - [Model.CreateReceiptRequest](docs/CreateReceiptRequest.md)
 - [Model.CreateReceiptResponse](docs/CreateReceiptResponse.md)
 - [Model.CreateReceivedDocumentRequest](docs/CreateReceivedDocumentRequest.md)
 - [Model.CreateReceivedDocumentResponse](docs/CreateReceivedDocumentResponse.md)
 - [Model.CreateSupplierRequest](docs/CreateSupplierRequest.md)
 - [Model.CreateSupplierResponse](docs/CreateSupplierResponse.md)
 - [Model.CreateVatTypeRequest](docs/CreateVatTypeRequest.md)
 - [Model.CreateVatTypeResponse](docs/CreateVatTypeResponse.md)
 - [Model.Currency](docs/Currency.md)
 - [Model.DetailedCountry](docs/DetailedCountry.md)
 - [Model.DocumentTemplate](docs/DocumentTemplate.md)
 - [Model.EInvoiceRejectionReason](docs/EInvoiceRejectionReason.md)
 - [Model.EmailData](docs/EmailData.md)
 - [Model.EmailDataDefaultSenderEmail](docs/EmailDataDefaultSenderEmail.md)
 - [Model.EmailSchedule](docs/EmailSchedule.md)
 - [Model.EmailScheduleInclude](docs/EmailScheduleInclude.md)
 - [Model.Entity](docs/Entity.md)
 - [Model.EntityType](docs/EntityType.md)
 - [Model.F24](docs/F24.md)
 - [Model.F24Status](docs/F24Status.md)
 - [Model.FunctionStatus](docs/FunctionStatus.md)
 - [Model.GetArchiveDocumentResponse](docs/GetArchiveDocumentResponse.md)
 - [Model.GetCashbookEntryResponse](docs/GetCashbookEntryResponse.md)
 - [Model.GetClientResponse](docs/GetClientResponse.md)
 - [Model.GetCompanyInfoResponse](docs/GetCompanyInfoResponse.md)
 - [Model.GetEInvoiceRejectionReasonResponse](docs/GetEInvoiceRejectionReasonResponse.md)
 - [Model.GetEmailDataResponse](docs/GetEmailDataResponse.md)
 - [Model.GetExistingIssuedDocumentTotalsRequest](docs/GetExistingIssuedDocumentTotalsRequest.md)
 - [Model.GetExistingIssuedDocumentTotalsResponse](docs/GetExistingIssuedDocumentTotalsResponse.md)
 - [Model.GetExistingReceivedDocumentTotalsRequest](docs/GetExistingReceivedDocumentTotalsRequest.md)
 - [Model.GetExistingReceivedDocumentTotalsResponse](docs/GetExistingReceivedDocumentTotalsResponse.md)
 - [Model.GetF24Response](docs/GetF24Response.md)
 - [Model.GetIssuedDocumentPreCreateInfoResponse](docs/GetIssuedDocumentPreCreateInfoResponse.md)
 - [Model.GetIssuedDocumentResponse](docs/GetIssuedDocumentResponse.md)
 - [Model.GetNewIssuedDocumentTotalsRequest](docs/GetNewIssuedDocumentTotalsRequest.md)
 - [Model.GetNewIssuedDocumentTotalsResponse](docs/GetNewIssuedDocumentTotalsResponse.md)
 - [Model.GetNewReceivedDocumentTotalsRequest](docs/GetNewReceivedDocumentTotalsRequest.md)
 - [Model.GetNewReceivedDocumentTotalsResponse](docs/GetNewReceivedDocumentTotalsResponse.md)
 - [Model.GetPaymentAccountResponse](docs/GetPaymentAccountResponse.md)
 - [Model.GetPaymentMethodResponse](docs/GetPaymentMethodResponse.md)
 - [Model.GetProductResponse](docs/GetProductResponse.md)
 - [Model.GetReceiptPreCreateInfoResponse](docs/GetReceiptPreCreateInfoResponse.md)
 - [Model.GetReceiptResponse](docs/GetReceiptResponse.md)
 - [Model.GetReceiptsMonthlyTotalsResponse](docs/GetReceiptsMonthlyTotalsResponse.md)
 - [Model.GetReceivedDocumentPreCreateInfoResponse](docs/GetReceivedDocumentPreCreateInfoResponse.md)
 - [Model.GetReceivedDocumentResponse](docs/GetReceivedDocumentResponse.md)
 - [Model.GetSupplierResponse](docs/GetSupplierResponse.md)
 - [Model.GetUserInfoResponse](docs/GetUserInfoResponse.md)
 - [Model.GetUserInfoResponseEmailConfirmationState](docs/GetUserInfoResponseEmailConfirmationState.md)
 - [Model.GetUserInfoResponseInfo](docs/GetUserInfoResponseInfo.md)
 - [Model.GetVatTypeResponse](docs/GetVatTypeResponse.md)
 - [Model.IssuedDocument](docs/IssuedDocument.md)
 - [Model.IssuedDocumentEiData](docs/IssuedDocumentEiData.md)
 - [Model.IssuedDocumentExtraData](docs/IssuedDocumentExtraData.md)
 - [Model.IssuedDocumentItemsListItem](docs/IssuedDocumentItemsListItem.md)
 - [Model.IssuedDocumentOptions](docs/IssuedDocumentOptions.md)
 - [Model.IssuedDocumentPaymentsListItem](docs/IssuedDocumentPaymentsListItem.md)
 - [Model.IssuedDocumentPaymentsListItemPaymentTerms](docs/IssuedDocumentPaymentsListItemPaymentTerms.md)
 - [Model.IssuedDocumentPreCreateInfo](docs/IssuedDocumentPreCreateInfo.md)
 - [Model.IssuedDocumentPreCreateInfoDefaultValues](docs/IssuedDocumentPreCreateInfoDefaultValues.md)
 - [Model.IssuedDocumentPreCreateInfoExtraDataDefaultValues](docs/IssuedDocumentPreCreateInfoExtraDataDefaultValues.md)
 - [Model.IssuedDocumentPreCreateInfoItemsDefaultValues](docs/IssuedDocumentPreCreateInfoItemsDefaultValues.md)
 - [Model.IssuedDocumentStatus](docs/IssuedDocumentStatus.md)
 - [Model.IssuedDocumentTotals](docs/IssuedDocumentTotals.md)
 - [Model.IssuedDocumentType](docs/IssuedDocumentType.md)
 - [Model.Language](docs/Language.md)
 - [Model.ListArchiveCategoriesResponse](docs/ListArchiveCategoriesResponse.md)
 - [Model.ListArchiveDocumentsResponse](docs/ListArchiveDocumentsResponse.md)
 - [Model.ListArchiveDocumentsResponsePage](docs/ListArchiveDocumentsResponsePage.md)
 - [Model.ListCashbookEntriesResponse](docs/ListCashbookEntriesResponse.md)
 - [Model.ListCitiesResponse](docs/ListCitiesResponse.md)
 - [Model.ListClientsResponse](docs/ListClientsResponse.md)
 - [Model.ListClientsResponsePage](docs/ListClientsResponsePage.md)
 - [Model.ListCostCentersResponse](docs/ListCostCentersResponse.md)
 - [Model.ListCountriesResponse](docs/ListCountriesResponse.md)
 - [Model.ListCurrenciesResponse](docs/ListCurrenciesResponse.md)
 - [Model.ListDeliveryNotesDefaultCausalsResponse](docs/ListDeliveryNotesDefaultCausalsResponse.md)
 - [Model.ListDetailedCountriesResponse](docs/ListDetailedCountriesResponse.md)
 - [Model.ListF24Response](docs/ListF24Response.md)
 - [Model.ListF24ResponseAggregatedData](docs/ListF24ResponseAggregatedData.md)
 - [Model.ListF24ResponseAggregation](docs/ListF24ResponseAggregation.md)
 - [Model.ListF24ResponsePage](docs/ListF24ResponsePage.md)
 - [Model.ListIssuedDocumentsResponse](docs/ListIssuedDocumentsResponse.md)
 - [Model.ListIssuedDocumentsResponsePage](docs/ListIssuedDocumentsResponsePage.md)
 - [Model.ListLanguagesResponse](docs/ListLanguagesResponse.md)
 - [Model.ListPaymentAccountsResponse](docs/ListPaymentAccountsResponse.md)
 - [Model.ListPaymentMethodsResponse](docs/ListPaymentMethodsResponse.md)
 - [Model.ListProductCategoriesResponse](docs/ListProductCategoriesResponse.md)
 - [Model.ListProductsResponse](docs/ListProductsResponse.md)
 - [Model.ListProductsResponsePage](docs/ListProductsResponsePage.md)
 - [Model.ListReceiptsResponse](docs/ListReceiptsResponse.md)
 - [Model.ListReceiptsResponsePage](docs/ListReceiptsResponsePage.md)
 - [Model.ListReceivedDocumentCategoriesResponse](docs/ListReceivedDocumentCategoriesResponse.md)
 - [Model.ListReceivedDocumentsResponse](docs/ListReceivedDocumentsResponse.md)
 - [Model.ListReceivedDocumentsResponsePage](docs/ListReceivedDocumentsResponsePage.md)
 - [Model.ListRevenueCentersResponse](docs/ListRevenueCentersResponse.md)
 - [Model.ListSuppliersResponse](docs/ListSuppliersResponse.md)
 - [Model.ListSuppliersResponsePage](docs/ListSuppliersResponsePage.md)
 - [Model.ListTemplatesResponse](docs/ListTemplatesResponse.md)
 - [Model.ListUnitsOfMeasureResponse](docs/ListUnitsOfMeasureResponse.md)
 - [Model.ListUserCompaniesResponse](docs/ListUserCompaniesResponse.md)
 - [Model.ListUserCompaniesResponseData](docs/ListUserCompaniesResponseData.md)
 - [Model.ListVatTypesResponse](docs/ListVatTypesResponse.md)
 - [Model.ModelClient](docs/ModelClient.md)
 - [Model.ModifyArchiveDocumentRequest](docs/ModifyArchiveDocumentRequest.md)
 - [Model.ModifyArchiveDocumentResponse](docs/ModifyArchiveDocumentResponse.md)
 - [Model.ModifyCashbookEntryRequest](docs/ModifyCashbookEntryRequest.md)
 - [Model.ModifyCashbookEntryResponse](docs/ModifyCashbookEntryResponse.md)
 - [Model.ModifyClientRequest](docs/ModifyClientRequest.md)
 - [Model.ModifyClientResponse](docs/ModifyClientResponse.md)
 - [Model.ModifyF24Request](docs/ModifyF24Request.md)
 - [Model.ModifyF24Response](docs/ModifyF24Response.md)
 - [Model.ModifyIssuedDocumentRequest](docs/ModifyIssuedDocumentRequest.md)
 - [Model.ModifyIssuedDocumentResponse](docs/ModifyIssuedDocumentResponse.md)
 - [Model.ModifyPaymentAccountRequest](docs/ModifyPaymentAccountRequest.md)
 - [Model.ModifyPaymentAccountResponse](docs/ModifyPaymentAccountResponse.md)
 - [Model.ModifyPaymentMethodRequest](docs/ModifyPaymentMethodRequest.md)
 - [Model.ModifyPaymentMethodResponse](docs/ModifyPaymentMethodResponse.md)
 - [Model.ModifyProductRequest](docs/ModifyProductRequest.md)
 - [Model.ModifyProductResponse](docs/ModifyProductResponse.md)
 - [Model.ModifyReceiptRequest](docs/ModifyReceiptRequest.md)
 - [Model.ModifyReceiptResponse](docs/ModifyReceiptResponse.md)
 - [Model.ModifyReceivedDocumentRequest](docs/ModifyReceivedDocumentRequest.md)
 - [Model.ModifyReceivedDocumentResponse](docs/ModifyReceivedDocumentResponse.md)
 - [Model.ModifySupplierRequest](docs/ModifySupplierRequest.md)
 - [Model.ModifySupplierResponse](docs/ModifySupplierResponse.md)
 - [Model.ModifyVatTypeRequest](docs/ModifyVatTypeRequest.md)
 - [Model.ModifyVatTypeResponse](docs/ModifyVatTypeResponse.md)
 - [Model.MonthlyTotal](docs/MonthlyTotal.md)
 - [Model.OriginalDocumentType](docs/OriginalDocumentType.md)
 - [Model.Pagination](docs/Pagination.md)
 - [Model.PaymentAccount](docs/PaymentAccount.md)
 - [Model.PaymentAccountType](docs/PaymentAccountType.md)
 - [Model.PaymentMethod](docs/PaymentMethod.md)
 - [Model.PaymentMethodDetails](docs/PaymentMethodDetails.md)
 - [Model.PaymentMethodType](docs/PaymentMethodType.md)
 - [Model.PaymentTermsType](docs/PaymentTermsType.md)
 - [Model.PermissionLevel](docs/PermissionLevel.md)
 - [Model.Permissions](docs/Permissions.md)
 - [Model.PermissionsFicIssuedDocumentsDetailed](docs/PermissionsFicIssuedDocumentsDetailed.md)
 - [Model.Product](docs/Product.md)
 - [Model.Receipt](docs/Receipt.md)
 - [Model.ReceiptItemsListItem](docs/ReceiptItemsListItem.md)
 - [Model.ReceiptPreCreateInfo](docs/ReceiptPreCreateInfo.md)
 - [Model.ReceiptType](docs/ReceiptType.md)
 - [Model.ReceivedDocument](docs/ReceivedDocument.md)
 - [Model.ReceivedDocumentEntity](docs/ReceivedDocumentEntity.md)
 - [Model.ReceivedDocumentInfo](docs/ReceivedDocumentInfo.md)
 - [Model.ReceivedDocumentInfoDefaultValues](docs/ReceivedDocumentInfoDefaultValues.md)
 - [Model.ReceivedDocumentInfoItemsDefaultValues](docs/ReceivedDocumentInfoItemsDefaultValues.md)
 - [Model.ReceivedDocumentItemsListItem](docs/ReceivedDocumentItemsListItem.md)
 - [Model.ReceivedDocumentPaymentsListItem](docs/ReceivedDocumentPaymentsListItem.md)
 - [Model.ReceivedDocumentPaymentsListItemPaymentTerms](docs/ReceivedDocumentPaymentsListItemPaymentTerms.md)
 - [Model.ReceivedDocumentTotals](docs/ReceivedDocumentTotals.md)
 - [Model.ReceivedDocumentType](docs/ReceivedDocumentType.md)
 - [Model.ScheduleEmailRequest](docs/ScheduleEmailRequest.md)
 - [Model.SendEInvoiceRequest](docs/SendEInvoiceRequest.md)
 - [Model.SendEInvoiceRequestData](docs/SendEInvoiceRequestData.md)
 - [Model.SendEInvoiceResponse](docs/SendEInvoiceResponse.md)
 - [Model.SendEInvoiceResponseData](docs/SendEInvoiceResponseData.md)
 - [Model.SenderEmail](docs/SenderEmail.md)
 - [Model.ShowTotalsMode](docs/ShowTotalsMode.md)
 - [Model.Supplier](docs/Supplier.md)
 - [Model.SupplierType](docs/SupplierType.md)
 - [Model.UploadArchiveAttachmentResponse](docs/UploadArchiveAttachmentResponse.md)
 - [Model.UploadF24AttachmentResponse](docs/UploadF24AttachmentResponse.md)
 - [Model.UploadIssuedDocumentAttachmentResponse](docs/UploadIssuedDocumentAttachmentResponse.md)
 - [Model.UploadReceivedDocumentAttachmentResponse](docs/UploadReceivedDocumentAttachmentResponse.md)
 - [Model.User](docs/User.md)
 - [Model.UserCompanyRole](docs/UserCompanyRole.md)
 - [Model.VatItem](docs/VatItem.md)
 - [Model.VatKind](docs/VatKind.md)
 - [Model.VatType](docs/VatType.md)
 - [Model.VerifyEInvoiceXmlErrorResponse](docs/VerifyEInvoiceXmlErrorResponse.md)
 - [Model.VerifyEInvoiceXmlErrorResponseError](docs/VerifyEInvoiceXmlErrorResponseError.md)
 - [Model.VerifyEInvoiceXmlErrorResponseExtra](docs/VerifyEInvoiceXmlErrorResponseExtra.md)
 - [Model.VerifyEInvoiceXmlResponse](docs/VerifyEInvoiceXmlResponse.md)
 - [Model.VerifyEInvoiceXmlResponseData](docs/VerifyEInvoiceXmlResponseData.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="OAuth2AuthenticationCodeFlow"></a>
### OAuth2AuthenticationCodeFlow

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: https://api-v2.fattureincloud.it/oauth/authorize
- **Scopes**: 
    - **entity.clients:r**: Read permission to the Clients registry
    - **entity.clients:a**: Write permission to the Clients registry
    - **entity.suppliers:r**: Read permission to the Suppliers registry
    - **entity.suppliers:a**: Write permission to the Suppliers registry
    - **products:r**: Read permission to the Products
    - **products:a**: Write permission to the Products
    - **issued_documents.invoices:r**: Read permission to the issued Invoices
    - **issued_documents.credit_notes:r**: Read permission to the issued Credit Notes
    - **issued_documents.receipts:r**: Read permission to the issued Receipts
    - **issued_documents.orders:r**: Read permission to the issued Orders
    - **issued_documents.quotes:r**: Read permission to the issued Quotes
    - **issued_documents.proformas:r**: Read permission to the issued Proformas
    - **issued_documents.delivery_notes:r**: Read permission to the issued Delivery Notes
    - **issued_documents.work_reports:r**: Read permission to the issued Work Reports
    - **issued_documents.supplier_orders:r**: Read permission to the issued Supplier Orders
    - **issued_documents.self_invoices:r**: Read permission to the issued Self Invoices
    - **issued_documents.invoices:a**: Write permission to the issued Invoices
    - **issued_documents.credit_notes:a**: Write permission to the issued Credit Notes
    - **issued_documents.receipts:a**: Write permission to the issued issued Receipts
    - **issued_documents.orders:a**: Write permission to the issued Orders
    - **issued_documents.quotes:a**: Write permission to the issued Quotes
    - **issued_documents.proformas:a**: Write permission to the issued Proformas
    - **issued_documents.delivery_notes:a**: Write permission to the issued Delivery Notes
    - **issued_documents.work_reports:a**: Write permission to the issued Work Reports
    - **issued_documents.supplier_orders:a**: Write permission to the issued Supplier Orders
    - **issued_documents.self_invoices:a**: Write permission to the issued Self Invoices
    - **received_documents:r**: Read permission to the Received Documents
    - **received_documents:a**: Write permission to the Received Documents
    - **stock:r**: Read permission to the Stock movements
    - **stock:a**: Write permission to the Stock movements
    - **receipts:r**: Read permission to the Receipts
    - **receipts:a**: Write permission to the Receipts
    - **taxes:r**: Read permission to the Taxes
    - **taxes:a**: Write permission to the Taxes
    - **archive:r**: Read permission to the Archive Documents
    - **archive:a**: Read permission to the Archive Documents
    - **cashbook:r**: Read permission to the Cashbook
    - **cashbook:a**: Write permission to the Cashbook
    - **settings:r**: Read permission to the Settings
    - **settings:a**: Write permission to the Settings
    - **situation:r**: Read permission to the company Situation

