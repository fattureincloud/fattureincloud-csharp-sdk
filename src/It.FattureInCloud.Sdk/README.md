# Created with Openapi Generator

<a id="cli"></a>
## Run the following powershell command to generate the library

```ps1
$properties = @(
    'apiName=Api',
    'targetFramework=netstandard2.0',
    'validatable=true',
    'nullableReferenceTypes=',
    'hideGenerationTimestamp=true',
    'packageVersion=2.1.2',
    'packageAuthors=Fatture in Cloud API Team',
    'packageCompany=Fatture in Cloud',
    'packageCopyright=No Copyright',
    'packageDescription=A library generated from a OpenAPI doc',
    'licenseId=MIT',
    'packageName=It.FattureInCloud.Sdk',
    'packageTags=',
    'packageTitle=Fatture in Cloud C# SDK'
) -join ","

$global = @(
    'apiDocs=true',
    'modelDocs=true',
    'apiTests=true',
    'modelTests=true'
) -join ","

java -jar "<path>/openapi-generator/modules/openapi-generator-cli/target/openapi-generator-cli.jar" generate `
    -g csharp-netcore `
    -i <your-swagger-file>.yaml `
    -o <your-output-folder> `
    --library generichost `
    --additional-properties $properties `
    --global-property $global `
    --git-host "github.com" `
    --git-repo-id "fattureincloud-csharp-sdk" `
    --git-user-id "fattureincloud" `
    --release-note "bumping version to 2.1.2"
    # -t templates
```

<a id="usage"></a>
## Using the library in your project

```cs
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace YourProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var api = host.Services.GetRequiredService<IArchiveApi>();
            CreateArchiveDocumentApiResponse apiResponse = await api.CreateArchiveDocumentAsync("todo");
            CreateArchiveDocumentResponse model = apiResponse.Ok();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
          .ConfigureApi((context, options) =>
          {
              // the type of token here depends on the api security specifications
              ApiKeyToken token = new("<your token>", ClientUtils.ApiKeyHeader.Authorization);
              options.AddTokens(token);

              // optionally choose the method the tokens will be provided with, default is RateLimitProvider
              options.UseProvider<RateLimitProvider<ApiKeyToken>, ApiKeyToken>();

              options.ConfigureJsonOptions((jsonOptions) =>
              {
                  // your custom converters if any
              });

              options.AddApiHttpClients(builder: builder => builder
                .AddRetryPolicy(2)
                .AddTimeoutPolicy(TimeSpan.FromSeconds(5))
                .AddCircuitBreakerPolicy(10, TimeSpan.FromSeconds(30))
                // add whatever middleware you prefer
              );
          });
    }
}
```
<a id="questions"></a>
## Questions

- What about HttpRequest failures and retries?
  If supportsRetry is enabled, you can configure Polly in the ConfigureClients method.
- How are tokens used?
  Tokens are provided by a TokenProvider class. The default is RateLimitProvider which will perform client side rate limiting.
  Other providers can be used with the UseProvider method.
- Does an HttpRequest throw an error when the server response is not Ok?
  It depends how you made the request. If the return type is ApiResponse<T> no error will be thrown, though the Content property will be null. 
  StatusCode and ReasonPhrase will contain information about the error.
  If the return type is T, then it will throw. If the return type is TOrDefault, it will return null.
- How do I validate requests and process responses?
  Use the provided On and After methods in the Api class from the namespace It.FattureInCloud.Sdk.Rest.DefaultApi.
  Or provide your own class by using the generic ConfigureApi method.

<a id="dependencies"></a>
## Dependencies

- [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting/) - 5.0.0 or later
- [Microsoft.Extensions.Http](https://www.nuget.org/packages/Microsoft.Extensions.Http/) - 5.0.0 or later
- [Microsoft.Extensions.Http.Polly](https://www.nuget.org/packages/Microsoft.Extensions.Http.Polly/) - 5.0.1 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.7.0 or later

<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="OAuth2AuthenticationCodeFlow"></a>
### OAuth2AuthenticationCodeFlow

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: https://api-v2.fattureincloud.it/oauth/authorize
- **Scopes**:   
- entity.clients:r: Read permission to the Clients registry  
- entity.clients:a: Write permission to the Clients registry  
- entity.suppliers:r: Read permission to the Suppliers registry  
- entity.suppliers:a: Write permission to the Suppliers registry  
- products:r: Read permission to the Products  
- products:a: Write permission to the Products  
- issued_documents.invoices:r: Read permission to the issued Invoices  
- issued_documents.credit_notes:r: Read permission to the issued Credit Notes  
- issued_documents.receipts:r: Read permission to the issued Receipts  
- issued_documents.orders:r: Read permission to the issued Orders  
- issued_documents.quotes:r: Read permission to the issued Quotes  
- issued_documents.proformas:r: Read permission to the issued Proformas  
- issued_documents.delivery_notes:r: Read permission to the issued Delivery Notes  
- issued_documents.work_reports:r: Read permission to the issued Work Reports  
- issued_documents.supplier_orders:r: Read permission to the issued Supplier Orders  
- issued_documents.self_invoices:r: Read permission to the issued Self Invoices  
- issued_documents.invoices:a: Write permission to the issued Invoices  
- issued_documents.credit_notes:a: Write permission to the issued Credit Notes  
- issued_documents.receipts:a: Write permission to the issued issued Receipts  
- issued_documents.orders:a: Write permission to the issued Orders  
- issued_documents.quotes:a: Write permission to the issued Quotes  
- issued_documents.proformas:a: Write permission to the issued Proformas  
- issued_documents.delivery_notes:a: Write permission to the issued Delivery Notes  
- issued_documents.work_reports:a: Write permission to the issued Work Reports  
- issued_documents.supplier_orders:a: Write permission to the issued Supplier Orders  
- issued_documents.self_invoices:a: Write permission to the issued Self Invoices  
- received_documents:r: Read permission to the Received Documents  
- received_documents:a: Write permission to the Received Documents  
- stock:r: Read permission to the Stock movements  
- stock:a: Write permission to the Stock movements  
- receipts:r: Read permission to the Receipts  
- receipts:a: Write permission to the Receipts  
- calendar:r: Read permission to the Calendar  
- calendar:a: Write permission to the Calendar  
- taxes:r: Read permission to the Taxes  
- taxes:a: Write permission to the Taxes  
- archive:r: Read permission to the Archive Documents  
- archive:a: Read permission to the Archive Documents  
- emails:r: Read permission to the Emails  
- cashbook:r: Read permission to the Cashbook  
- cashbook:a: Write permission to the Cashbook  
- settings:r: Read permission to the Settings  
- settings:a: Write permission to the Settings  
- situation:r: Read permission to the company Situation


## Build
- SDK version: 2.1.2
- Generator version: 7.12.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

## Api Information
- appName: Fatture in Cloud API v2 - API Reference
- appVersion: 2.1.7
- appDescription: Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 500.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.

## [OpenApi Global properties](https://openapi-generator.tech/docs/globals)
- generateAliasAsModel: 
- supportingFiles: 
- models: omitted for brevity
- apis: omitted for brevity
- apiDocs: true
- modelDocs: true
- apiTests: true
- modelTests: true

## [OpenApi Generator Parameters](https://openapi-generator.tech/docs/generators/csharp-netcore)
- allowUnicodeIdentifiers: 
- apiName: Api
- caseInsensitiveResponseHeaders: 
- conditionalSerialization: true
- disallowAdditionalPropertiesIfNotPresent: 
- gitHost: github.com
- gitRepoId: fattureincloud-csharp-sdk
- gitUserId: fattureincloud
- hideGenerationTimestamp: true
- interfacePrefix: I
- library: generichost
- licenseId: MIT
- modelPropertyNaming: 
- netCoreProjectFile: false
- nonPublicApi: false
- nullableReferenceTypes: 
- optionalAssemblyInfo: 
- optionalEmitDefaultValues: false
- optionalMethodArgument: true
- optionalProjectFile: 
- packageAuthors: Fatture in Cloud API Team
- packageCompany: Fatture in Cloud
- packageCopyright: No Copyright
- packageDescription: A library generated from a OpenAPI doc
- packageGuid: {7230FBC0-4578-40BA-A7EE-E412B86CBB91}
- packageName: It.FattureInCloud.Sdk
- packageTags: 
- packageTitle: Fatture in Cloud C# SDK
- packageVersion: 2.1.2
- releaseNote: bumping version to 2.1.2
- returnICollection: false
- sortParamsByRequiredFlag: 
- sourceFolder: src
- targetFramework: netstandard2.0
- useCollection: false
- useDateTimeOffset: true
- useOneOfDiscriminatorLookup: false
- validatable: true
For more information, please visit [https://www.fattureincloud.it](https://www.fattureincloud.it)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project.
