# It.FattureInCloud.Sdk.Api.IssuedDocumentsApi

All URIs are relative to *https://api-v2.fattureincloud.it*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateIssuedDocument**](IssuedDocumentsApi.md#createissueddocument) | **POST** /c/{company_id}/issued_documents | Create Issued Document |
| [**DeleteIssuedDocument**](IssuedDocumentsApi.md#deleteissueddocument) | **DELETE** /c/{company_id}/issued_documents/{document_id} | Delete Issued Document |
| [**DeleteIssuedDocumentAttachment**](IssuedDocumentsApi.md#deleteissueddocumentattachment) | **DELETE** /c/{company_id}/issued_documents/{document_id}/attachment | Delete Issued Document Attachment |
| [**GetEmailData**](IssuedDocumentsApi.md#getemaildata) | **GET** /c/{company_id}/issued_documents/{document_id}/email | Get Email Data |
| [**GetExistingIssuedDocumentTotals**](IssuedDocumentsApi.md#getexistingissueddocumenttotals) | **POST** /c/{company_id}/issued_documents/{document_id}/totals | Get Existing Issued Document Totals |
| [**GetIssuedDocument**](IssuedDocumentsApi.md#getissueddocument) | **GET** /c/{company_id}/issued_documents/{document_id} | Get Issued Document |
| [**GetIssuedDocumentPreCreateInfo**](IssuedDocumentsApi.md#getissueddocumentprecreateinfo) | **GET** /c/{company_id}/issued_documents/info | Get Issued Document Pre-create info |
| [**GetNewIssuedDocumentTotals**](IssuedDocumentsApi.md#getnewissueddocumenttotals) | **POST** /c/{company_id}/issued_documents/totals | Get New Issued Document Totals |
| [**JoinIssuedDocuments**](IssuedDocumentsApi.md#joinissueddocuments) | **GET** /c/{company_id}/issued_documents/join | Join issued documents |
| [**ListIssuedDocuments**](IssuedDocumentsApi.md#listissueddocuments) | **GET** /c/{company_id}/issued_documents | List Issued Documents |
| [**ModifyIssuedDocument**](IssuedDocumentsApi.md#modifyissueddocument) | **PUT** /c/{company_id}/issued_documents/{document_id} | Modify Issued Document |
| [**ScheduleEmail**](IssuedDocumentsApi.md#scheduleemail) | **POST** /c/{company_id}/issued_documents/{document_id}/email | Schedule Email |
| [**TransformIssuedDocument**](IssuedDocumentsApi.md#transformissueddocument) | **GET** /c/{company_id}/issued_documents/transform | Transform issued document |
| [**UploadIssuedDocumentAttachment**](IssuedDocumentsApi.md#uploadissueddocumentattachment) | **POST** /c/{company_id}/issued_documents/attachment | Upload Issued Document Attachment |

<a name="createissueddocument"></a>
# **CreateIssuedDocument**
> CreateIssuedDocumentResponse CreateIssuedDocument (int companyId, CreateIssuedDocumentRequest createIssuedDocumentRequest = null)

Create Issued Document

Creates a new document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class CreateIssuedDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var createIssuedDocumentRequest = new CreateIssuedDocumentRequest(); // CreateIssuedDocumentRequest | The Issued Document (optional) 

            try
            {
                // Create Issued Document
                CreateIssuedDocumentResponse result = apiInstance.CreateIssuedDocument(companyId, createIssuedDocumentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedDocumentsApi.CreateIssuedDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateIssuedDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Issued Document
    ApiResponse<CreateIssuedDocumentResponse> response = apiInstance.CreateIssuedDocumentWithHttpInfo(companyId, createIssuedDocumentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedDocumentsApi.CreateIssuedDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **createIssuedDocumentRequest** | [**CreateIssuedDocumentRequest**](CreateIssuedDocumentRequest.md) | The Issued Document | [optional]  |

### Return type

[**CreateIssuedDocumentResponse**](CreateIssuedDocumentResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Document created. |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteissueddocument"></a>
# **DeleteIssuedDocument**
> void DeleteIssuedDocument (int companyId, int documentId)

Delete Issued Document

Deletes the specified document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class DeleteIssuedDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.

            try
            {
                // Delete Issued Document
                apiInstance.DeleteIssuedDocument(companyId, documentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedDocumentsApi.DeleteIssuedDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteIssuedDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Issued Document
    apiInstance.DeleteIssuedDocumentWithHttpInfo(companyId, documentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedDocumentsApi.DeleteIssuedDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **documentId** | **int** | The ID of the document. |  |

### Return type

void (empty response body)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Document removed |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteissueddocumentattachment"></a>
# **DeleteIssuedDocumentAttachment**
> void DeleteIssuedDocumentAttachment (int companyId, int documentId)

Delete Issued Document Attachment

Removes the attachment of the specified document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class DeleteIssuedDocumentAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.

            try
            {
                // Delete Issued Document Attachment
                apiInstance.DeleteIssuedDocumentAttachment(companyId, documentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedDocumentsApi.DeleteIssuedDocumentAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteIssuedDocumentAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Issued Document Attachment
    apiInstance.DeleteIssuedDocumentAttachmentWithHttpInfo(companyId, documentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedDocumentsApi.DeleteIssuedDocumentAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **documentId** | **int** | The ID of the document. |  |

### Return type

void (empty response body)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File removed. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaildata"></a>
# **GetEmailData**
> GetEmailDataResponse GetEmailData (int companyId, int documentId)

Get Email Data

Gets the pre-compiled email details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetEmailDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.

            try
            {
                // Get Email Data
                GetEmailDataResponse result = apiInstance.GetEmailData(companyId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedDocumentsApi.GetEmailData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmailDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Email Data
    ApiResponse<GetEmailDataResponse> response = apiInstance.GetEmailDataWithHttpInfo(companyId, documentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedDocumentsApi.GetEmailDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **documentId** | **int** | The ID of the document. |  |

### Return type

[**GetEmailDataResponse**](GetEmailDataResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | EmailData |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexistingissueddocumenttotals"></a>
# **GetExistingIssuedDocumentTotals**
> GetExistingIssuedDocumentTotalsResponse GetExistingIssuedDocumentTotals (int companyId, int documentId, GetExistingIssuedDocumentTotalsRequest getExistingIssuedDocumentTotalsRequest = null)

Get Existing Issued Document Totals

Returns the totals for a specified document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetExistingIssuedDocumentTotalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.
            var getExistingIssuedDocumentTotalsRequest = new GetExistingIssuedDocumentTotalsRequest(); // GetExistingIssuedDocumentTotalsRequest |  (optional) 

            try
            {
                // Get Existing Issued Document Totals
                GetExistingIssuedDocumentTotalsResponse result = apiInstance.GetExistingIssuedDocumentTotals(companyId, documentId, getExistingIssuedDocumentTotalsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedDocumentsApi.GetExistingIssuedDocumentTotals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExistingIssuedDocumentTotalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Existing Issued Document Totals
    ApiResponse<GetExistingIssuedDocumentTotalsResponse> response = apiInstance.GetExistingIssuedDocumentTotalsWithHttpInfo(companyId, documentId, getExistingIssuedDocumentTotalsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedDocumentsApi.GetExistingIssuedDocumentTotalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **documentId** | **int** | The ID of the document. |  |
| **getExistingIssuedDocumentTotalsRequest** | [**GetExistingIssuedDocumentTotalsRequest**](GetExistingIssuedDocumentTotalsRequest.md) |  | [optional]  |

### Return type

[**GetExistingIssuedDocumentTotalsResponse**](GetExistingIssuedDocumentTotalsResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Totals. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getissueddocument"></a>
# **GetIssuedDocument**
> GetIssuedDocumentResponse GetIssuedDocument (int companyId, int documentId, string fields = null, string fieldset = null)

Get Issued Document

Gets the specified document. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetIssuedDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.
            var fields = "fields_example";  // string | List of comma-separated fields. (optional) 
            var fieldset = "basic";  // string | Name of the fieldset. (optional) 

            try
            {
                // Get Issued Document
                GetIssuedDocumentResponse result = apiInstance.GetIssuedDocument(companyId, documentId, fields, fieldset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedDocumentsApi.GetIssuedDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIssuedDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Issued Document
    ApiResponse<GetIssuedDocumentResponse> response = apiInstance.GetIssuedDocumentWithHttpInfo(companyId, documentId, fields, fieldset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedDocumentsApi.GetIssuedDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **documentId** | **int** | The ID of the document. |  |
| **fields** | **string** | List of comma-separated fields. | [optional]  |
| **fieldset** | **string** | Name of the fieldset. | [optional]  |

### Return type

[**GetIssuedDocumentResponse**](GetIssuedDocumentResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Document Details. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getissueddocumentprecreateinfo"></a>
# **GetIssuedDocumentPreCreateInfo**
> GetIssuedDocumentPreCreateInfoResponse GetIssuedDocumentPreCreateInfo (int companyId, string type)

Get Issued Document Pre-create info

Retrieves the information useful while creating a new document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetIssuedDocumentPreCreateInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var type = "invoice";  // string | The type of the issued document.

            try
            {
                // Get Issued Document Pre-create info
                GetIssuedDocumentPreCreateInfoResponse result = apiInstance.GetIssuedDocumentPreCreateInfo(companyId, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedDocumentsApi.GetIssuedDocumentPreCreateInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIssuedDocumentPreCreateInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Issued Document Pre-create info
    ApiResponse<GetIssuedDocumentPreCreateInfoResponse> response = apiInstance.GetIssuedDocumentPreCreateInfoWithHttpInfo(companyId, type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedDocumentsApi.GetIssuedDocumentPreCreateInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **type** | **string** | The type of the issued document. |  |

### Return type

[**GetIssuedDocumentPreCreateInfoResponse**](GetIssuedDocumentPreCreateInfoResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pre-create info. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnewissueddocumenttotals"></a>
# **GetNewIssuedDocumentTotals**
> GetNewIssuedDocumentTotalsResponse GetNewIssuedDocumentTotals (int companyId, GetNewIssuedDocumentTotalsRequest getNewIssuedDocumentTotalsRequest = null)

Get New Issued Document Totals

Returns the totals for a new document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetNewIssuedDocumentTotalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var getNewIssuedDocumentTotalsRequest = new GetNewIssuedDocumentTotalsRequest(); // GetNewIssuedDocumentTotalsRequest |  (optional) 

            try
            {
                // Get New Issued Document Totals
                GetNewIssuedDocumentTotalsResponse result = apiInstance.GetNewIssuedDocumentTotals(companyId, getNewIssuedDocumentTotalsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedDocumentsApi.GetNewIssuedDocumentTotals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNewIssuedDocumentTotalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get New Issued Document Totals
    ApiResponse<GetNewIssuedDocumentTotalsResponse> response = apiInstance.GetNewIssuedDocumentTotalsWithHttpInfo(companyId, getNewIssuedDocumentTotalsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedDocumentsApi.GetNewIssuedDocumentTotalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **getNewIssuedDocumentTotalsRequest** | [**GetNewIssuedDocumentTotalsRequest**](GetNewIssuedDocumentTotalsRequest.md) |  | [optional]  |

### Return type

[**GetNewIssuedDocumentTotalsResponse**](GetNewIssuedDocumentTotalsResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Totals. |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="joinissueddocuments"></a>
# **JoinIssuedDocuments**
> JoinIssuedDocumentsResponse JoinIssuedDocuments (int companyId, string ids, int? group = null, int? eInvoice = null)

Join issued documents

Joins issued documents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class JoinIssuedDocumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var ids = 1,2,3,4;  // string | Ids of the documents.
            var group = 0;  // int? | Group items. (optional) 
            var eInvoice = 0;  // int? | New document e_invoice. (optional) 

            try
            {
                // Join issued documents
                JoinIssuedDocumentsResponse result = apiInstance.JoinIssuedDocuments(companyId, ids, group, eInvoice);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedDocumentsApi.JoinIssuedDocuments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JoinIssuedDocumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Join issued documents
    ApiResponse<JoinIssuedDocumentsResponse> response = apiInstance.JoinIssuedDocumentsWithHttpInfo(companyId, ids, group, eInvoice);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedDocumentsApi.JoinIssuedDocumentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **ids** | **string** | Ids of the documents. |  |
| **group** | **int?** | Group items. | [optional]  |
| **eInvoice** | **int?** | New document e_invoice. | [optional]  |

### Return type

[**JoinIssuedDocumentsResponse**](JoinIssuedDocumentsResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Example response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listissueddocuments"></a>
# **ListIssuedDocuments**
> ListIssuedDocumentsResponse ListIssuedDocuments (int companyId, string type, string fields = null, string fieldset = null, string sort = null, int? page = null, int? perPage = null, string q = null)

List Issued Documents

Lists the issued documents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListIssuedDocumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var type = "invoice";  // string | The type of the issued document.
            var fields = "fields_example";  // string | List of comma-separated fields. (optional) 
            var fieldset = "basic";  // string | Name of the fieldset. (optional) 
            var sort = "sort_example";  // string | List of comma-separated fields for result sorting (minus for desc sorting). (optional) 
            var page = 1;  // int? | The page to retrieve. (optional)  (default to 1)
            var perPage = 5;  // int? | The size of the page. (optional)  (default to 5)
            var q = "q_example";  // string | Query for filtering the results. (optional) 

            try
            {
                // List Issued Documents
                ListIssuedDocumentsResponse result = apiInstance.ListIssuedDocuments(companyId, type, fields, fieldset, sort, page, perPage, q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedDocumentsApi.ListIssuedDocuments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListIssuedDocumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Issued Documents
    ApiResponse<ListIssuedDocumentsResponse> response = apiInstance.ListIssuedDocumentsWithHttpInfo(companyId, type, fields, fieldset, sort, page, perPage, q);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedDocumentsApi.ListIssuedDocumentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **type** | **string** | The type of the issued document. |  |
| **fields** | **string** | List of comma-separated fields. | [optional]  |
| **fieldset** | **string** | Name of the fieldset. | [optional]  |
| **sort** | **string** | List of comma-separated fields for result sorting (minus for desc sorting). | [optional]  |
| **page** | **int?** | The page to retrieve. | [optional] [default to 1] |
| **perPage** | **int?** | The size of the page. | [optional] [default to 5] |
| **q** | **string** | Query for filtering the results. | [optional]  |

### Return type

[**ListIssuedDocumentsResponse**](ListIssuedDocumentsResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Results list. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modifyissueddocument"></a>
# **ModifyIssuedDocument**
> ModifyIssuedDocumentResponse ModifyIssuedDocument (int companyId, int documentId, ModifyIssuedDocumentRequest modifyIssuedDocumentRequest = null)

Modify Issued Document

Modifies the specified document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ModifyIssuedDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.
            var modifyIssuedDocumentRequest = new ModifyIssuedDocumentRequest(); // ModifyIssuedDocumentRequest | The modified document (optional) 

            try
            {
                // Modify Issued Document
                ModifyIssuedDocumentResponse result = apiInstance.ModifyIssuedDocument(companyId, documentId, modifyIssuedDocumentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedDocumentsApi.ModifyIssuedDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModifyIssuedDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Modify Issued Document
    ApiResponse<ModifyIssuedDocumentResponse> response = apiInstance.ModifyIssuedDocumentWithHttpInfo(companyId, documentId, modifyIssuedDocumentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedDocumentsApi.ModifyIssuedDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **documentId** | **int** | The ID of the document. |  |
| **modifyIssuedDocumentRequest** | [**ModifyIssuedDocumentRequest**](ModifyIssuedDocumentRequest.md) | The modified document | [optional]  |

### Return type

[**ModifyIssuedDocumentResponse**](ModifyIssuedDocumentResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Document edited |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scheduleemail"></a>
# **ScheduleEmail**
> void ScheduleEmail (int companyId, int documentId, ScheduleEmailRequest scheduleEmailRequest = null)

Schedule Email

Schedules the sending of a document by email.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ScheduleEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.
            var scheduleEmailRequest = new ScheduleEmailRequest(); // ScheduleEmailRequest | Email Schedule (optional) 

            try
            {
                // Schedule Email
                apiInstance.ScheduleEmail(companyId, documentId, scheduleEmailRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedDocumentsApi.ScheduleEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScheduleEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Schedule Email
    apiInstance.ScheduleEmailWithHttpInfo(companyId, documentId, scheduleEmailRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedDocumentsApi.ScheduleEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **documentId** | **int** | The ID of the document. |  |
| **scheduleEmailRequest** | [**ScheduleEmailRequest**](ScheduleEmailRequest.md) | Email Schedule | [optional]  |

### Return type

void (empty response body)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transformissueddocument"></a>
# **TransformIssuedDocument**
> TransformIssuedDocumentResponse TransformIssuedDocument (int companyId, string originalDocumentId, string newType, int? eInvoice = null, int? transformKeepCopy = null)

Transform issued document

Transforms the document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class TransformIssuedDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var originalDocumentId = "originalDocumentId_example";  // string | Original document id.
            var newType = "newType_example";  // string | New document type.
            var eInvoice = 0;  // int? | New document e_invoice. (optional) 
            var transformKeepCopy = 0;  // int? | Keep the old document. (optional) 

            try
            {
                // Transform issued document
                TransformIssuedDocumentResponse result = apiInstance.TransformIssuedDocument(companyId, originalDocumentId, newType, eInvoice, transformKeepCopy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedDocumentsApi.TransformIssuedDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TransformIssuedDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Transform issued document
    ApiResponse<TransformIssuedDocumentResponse> response = apiInstance.TransformIssuedDocumentWithHttpInfo(companyId, originalDocumentId, newType, eInvoice, transformKeepCopy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedDocumentsApi.TransformIssuedDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **originalDocumentId** | **string** | Original document id. |  |
| **newType** | **string** | New document type. |  |
| **eInvoice** | **int?** | New document e_invoice. | [optional]  |
| **transformKeepCopy** | **int?** | Keep the old document. | [optional]  |

### Return type

[**TransformIssuedDocumentResponse**](TransformIssuedDocumentResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Example response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadissueddocumentattachment"></a>
# **UploadIssuedDocumentAttachment**
> UploadIssuedDocumentAttachmentResponse UploadIssuedDocumentAttachment (int companyId, string filename = null, System.IO.Stream attachment = null)

Upload Issued Document Attachment

Uploads an attachment destined to an issued document. The actual association between the document and the attachment must be implemented separately, using the returned token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class UploadIssuedDocumentAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var filename = "filename_example";  // string | Name of the file. (optional) 
            var attachment = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Valid format: .png, .jpg, .gif, .pdf, .zip, .xls, .xlsx, .doc, .docx (optional) 

            try
            {
                // Upload Issued Document Attachment
                UploadIssuedDocumentAttachmentResponse result = apiInstance.UploadIssuedDocumentAttachment(companyId, filename, attachment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedDocumentsApi.UploadIssuedDocumentAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadIssuedDocumentAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload Issued Document Attachment
    ApiResponse<UploadIssuedDocumentAttachmentResponse> response = apiInstance.UploadIssuedDocumentAttachmentWithHttpInfo(companyId, filename, attachment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedDocumentsApi.UploadIssuedDocumentAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **filename** | **string** | Name of the file. | [optional]  |
| **attachment** | **System.IO.Stream****System.IO.Stream** | Valid format: .png, .jpg, .gif, .pdf, .zip, .xls, .xlsx, .doc, .docx | [optional]  |

### Return type

[**UploadIssuedDocumentAttachmentResponse**](UploadIssuedDocumentAttachmentResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Attachment Token. |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

