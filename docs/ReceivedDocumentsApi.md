# It.FattureInCloud.Sdk.Api.ReceivedDocumentsApi

All URIs are relative to *https://api-v2.fattureincloud.it*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateReceivedDocument**](ReceivedDocumentsApi.md#createreceiveddocument) | **POST** /c/{company_id}/received_documents | Create Received Document |
| [**DeleteBinReceivedDocument**](ReceivedDocumentsApi.md#deletebinreceiveddocument) | **DELETE** /c/{company_id}/bin/received_documents/{document_id} | Delete Bin Received Document |
| [**DeleteReceivedDocument**](ReceivedDocumentsApi.md#deletereceiveddocument) | **DELETE** /c/{company_id}/received_documents/{document_id} | Delete Received Document |
| [**DeleteReceivedDocumentAttachment**](ReceivedDocumentsApi.md#deletereceiveddocumentattachment) | **DELETE** /c/{company_id}/received_documents/{document_id}/attachment | Delete Received Document Attachment |
| [**GetBinReceivedDocument**](ReceivedDocumentsApi.md#getbinreceiveddocument) | **GET** /c/{company_id}/bin/received_documents/{document_id} | Get Bin Received Documents List |
| [**GetExistingReceivedDocumentTotals**](ReceivedDocumentsApi.md#getexistingreceiveddocumenttotals) | **POST** /c/{company_id}/received_documents/{document_id}/totals | Get Existing Received Document Totals |
| [**GetNewReceivedDocumentTotals**](ReceivedDocumentsApi.md#getnewreceiveddocumenttotals) | **POST** /c/{company_id}/received_documents/totals | Get New Received Document Totals |
| [**GetReceivedDocument**](ReceivedDocumentsApi.md#getreceiveddocument) | **GET** /c/{company_id}/received_documents/{document_id} | Get Received Document |
| [**GetReceivedDocumentPreCreateInfo**](ReceivedDocumentsApi.md#getreceiveddocumentprecreateinfo) | **GET** /c/{company_id}/received_documents/info | Get Received Document Pre-Create Info |
| [**ListBinReceivedDocuments**](ReceivedDocumentsApi.md#listbinreceiveddocuments) | **GET** /c/{company_id}/bin/received_documents | Get Bin Received Documents List |
| [**ListReceivedDocuments**](ReceivedDocumentsApi.md#listreceiveddocuments) | **GET** /c/{company_id}/received_documents | List Received Documents |
| [**ModifyReceivedDocument**](ReceivedDocumentsApi.md#modifyreceiveddocument) | **PUT** /c/{company_id}/received_documents/{document_id} | Modify Received Document |
| [**RecoverBinReceivedDocument**](ReceivedDocumentsApi.md#recoverbinreceiveddocument) | **POST** /c/{company_id}/bin/received_documents/{document_id}/recover | Recover Received Document From The Bin |
| [**UploadReceivedDocumentAttachment**](ReceivedDocumentsApi.md#uploadreceiveddocumentattachment) | **POST** /c/{company_id}/received_documents/attachment | Upload Received Document Attachment |

<a id="createreceiveddocument"></a>
# **CreateReceivedDocument**
> CreateReceivedDocumentResponse CreateReceivedDocument (int companyId, CreateReceivedDocumentRequest createReceivedDocumentRequest = null)

Create Received Document

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
    public class CreateReceivedDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceivedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var createReceivedDocumentRequest = new CreateReceivedDocumentRequest(); // CreateReceivedDocumentRequest | Document to create (optional) 

            try
            {
                // Create Received Document
                CreateReceivedDocumentResponse result = apiInstance.CreateReceivedDocument(companyId, createReceivedDocumentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceivedDocumentsApi.CreateReceivedDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateReceivedDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Received Document
    ApiResponse<CreateReceivedDocumentResponse> response = apiInstance.CreateReceivedDocumentWithHttpInfo(companyId, createReceivedDocumentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceivedDocumentsApi.CreateReceivedDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **createReceivedDocumentRequest** | [**CreateReceivedDocumentRequest**](CreateReceivedDocumentRequest.md) | Document to create | [optional]  |

### Return type

[**CreateReceivedDocumentResponse**](CreateReceivedDocumentResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Document created. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletebinreceiveddocument"></a>
# **DeleteBinReceivedDocument**
> void DeleteBinReceivedDocument (int companyId, int documentId)

Delete Bin Received Document

Delete Bin Received Document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class DeleteBinReceivedDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceivedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.

            try
            {
                // Delete Bin Received Document
                apiInstance.DeleteBinReceivedDocument(companyId, documentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceivedDocumentsApi.DeleteBinReceivedDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBinReceivedDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Bin Received Document
    apiInstance.DeleteBinReceivedDocumentWithHttpInfo(companyId, documentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceivedDocumentsApi.DeleteBinReceivedDocumentWithHttpInfo: " + e.Message);
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
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletereceiveddocument"></a>
# **DeleteReceivedDocument**
> void DeleteReceivedDocument (int companyId, int documentId)

Delete Received Document

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
    public class DeleteReceivedDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceivedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.

            try
            {
                // Delete Received Document
                apiInstance.DeleteReceivedDocument(companyId, documentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceivedDocumentsApi.DeleteReceivedDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReceivedDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Received Document
    apiInstance.DeleteReceivedDocumentWithHttpInfo(companyId, documentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceivedDocumentsApi.DeleteReceivedDocumentWithHttpInfo: " + e.Message);
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
| **200** | Document removed. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletereceiveddocumentattachment"></a>
# **DeleteReceivedDocumentAttachment**
> void DeleteReceivedDocumentAttachment (int companyId, int documentId)

Delete Received Document Attachment

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
    public class DeleteReceivedDocumentAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceivedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.

            try
            {
                // Delete Received Document Attachment
                apiInstance.DeleteReceivedDocumentAttachment(companyId, documentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceivedDocumentsApi.DeleteReceivedDocumentAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReceivedDocumentAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Received Document Attachment
    apiInstance.DeleteReceivedDocumentAttachmentWithHttpInfo(companyId, documentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceivedDocumentsApi.DeleteReceivedDocumentAttachmentWithHttpInfo: " + e.Message);
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
| **200** | File removed |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbinreceiveddocument"></a>
# **GetBinReceivedDocument**
> GetBinIssuedDocumentResponse GetBinReceivedDocument (int companyId, int documentId)

Get Bin Received Documents List

Get bin issued documents detail

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetBinReceivedDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceivedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.

            try
            {
                // Get Bin Received Documents List
                GetBinIssuedDocumentResponse result = apiInstance.GetBinReceivedDocument(companyId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceivedDocumentsApi.GetBinReceivedDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBinReceivedDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Bin Received Documents List
    ApiResponse<GetBinIssuedDocumentResponse> response = apiInstance.GetBinReceivedDocumentWithHttpInfo(companyId, documentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceivedDocumentsApi.GetBinReceivedDocumentWithHttpInfo: " + e.Message);
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

[**GetBinIssuedDocumentResponse**](GetBinIssuedDocumentResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bin issued document details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getexistingreceiveddocumenttotals"></a>
# **GetExistingReceivedDocumentTotals**
> GetExistingReceivedDocumentTotalsResponse GetExistingReceivedDocumentTotals (int companyId, int documentId, GetExistingReceivedDocumentTotalsRequest getExistingReceivedDocumentTotalsRequest = null)

Get Existing Received Document Totals

Returns the totals for the specified document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetExistingReceivedDocumentTotalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceivedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.
            var getExistingReceivedDocumentTotalsRequest = new GetExistingReceivedDocumentTotalsRequest(); // GetExistingReceivedDocumentTotalsRequest | Received document. (optional) 

            try
            {
                // Get Existing Received Document Totals
                GetExistingReceivedDocumentTotalsResponse result = apiInstance.GetExistingReceivedDocumentTotals(companyId, documentId, getExistingReceivedDocumentTotalsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceivedDocumentsApi.GetExistingReceivedDocumentTotals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExistingReceivedDocumentTotalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Existing Received Document Totals
    ApiResponse<GetExistingReceivedDocumentTotalsResponse> response = apiInstance.GetExistingReceivedDocumentTotalsWithHttpInfo(companyId, documentId, getExistingReceivedDocumentTotalsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceivedDocumentsApi.GetExistingReceivedDocumentTotalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **documentId** | **int** | The ID of the document. |  |
| **getExistingReceivedDocumentTotalsRequest** | [**GetExistingReceivedDocumentTotalsRequest**](GetExistingReceivedDocumentTotalsRequest.md) | Received document. | [optional]  |

### Return type

[**GetExistingReceivedDocumentTotalsResponse**](GetExistingReceivedDocumentTotalsResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Document Totals. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getnewreceiveddocumenttotals"></a>
# **GetNewReceivedDocumentTotals**
> GetNewReceivedDocumentTotalsResponse GetNewReceivedDocumentTotals (int companyId, GetNewReceivedDocumentTotalsRequest getNewReceivedDocumentTotalsRequest = null)

Get New Received Document Totals

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
    public class GetNewReceivedDocumentTotalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceivedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var getNewReceivedDocumentTotalsRequest = new GetNewReceivedDocumentTotalsRequest(); // GetNewReceivedDocumentTotalsRequest | Received document. (optional) 

            try
            {
                // Get New Received Document Totals
                GetNewReceivedDocumentTotalsResponse result = apiInstance.GetNewReceivedDocumentTotals(companyId, getNewReceivedDocumentTotalsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceivedDocumentsApi.GetNewReceivedDocumentTotals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNewReceivedDocumentTotalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get New Received Document Totals
    ApiResponse<GetNewReceivedDocumentTotalsResponse> response = apiInstance.GetNewReceivedDocumentTotalsWithHttpInfo(companyId, getNewReceivedDocumentTotalsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceivedDocumentsApi.GetNewReceivedDocumentTotalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **getNewReceivedDocumentTotalsRequest** | [**GetNewReceivedDocumentTotalsRequest**](GetNewReceivedDocumentTotalsRequest.md) | Received document. | [optional]  |

### Return type

[**GetNewReceivedDocumentTotalsResponse**](GetNewReceivedDocumentTotalsResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Document Totals. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreceiveddocument"></a>
# **GetReceivedDocument**
> GetReceivedDocumentResponse GetReceivedDocument (int companyId, int documentId, string fields = null, string fieldset = null)

Get Received Document

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
    public class GetReceivedDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceivedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.
            var fields = "fields_example";  // string | List of comma-separated fields. (optional) 
            var fieldset = "basic";  // string | Name of the fieldset. (optional) 

            try
            {
                // Get Received Document
                GetReceivedDocumentResponse result = apiInstance.GetReceivedDocument(companyId, documentId, fields, fieldset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceivedDocumentsApi.GetReceivedDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReceivedDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Received Document
    ApiResponse<GetReceivedDocumentResponse> response = apiInstance.GetReceivedDocumentWithHttpInfo(companyId, documentId, fields, fieldset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceivedDocumentsApi.GetReceivedDocumentWithHttpInfo: " + e.Message);
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

[**GetReceivedDocumentResponse**](GetReceivedDocumentResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Document details. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreceiveddocumentprecreateinfo"></a>
# **GetReceivedDocumentPreCreateInfo**
> GetReceivedDocumentPreCreateInfoResponse GetReceivedDocumentPreCreateInfo (int companyId, string type)

Get Received Document Pre-Create Info

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
    public class GetReceivedDocumentPreCreateInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceivedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var type = "expense";  // string | The type of the received document.

            try
            {
                // Get Received Document Pre-Create Info
                GetReceivedDocumentPreCreateInfoResponse result = apiInstance.GetReceivedDocumentPreCreateInfo(companyId, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceivedDocumentsApi.GetReceivedDocumentPreCreateInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReceivedDocumentPreCreateInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Received Document Pre-Create Info
    ApiResponse<GetReceivedDocumentPreCreateInfoResponse> response = apiInstance.GetReceivedDocumentPreCreateInfoWithHttpInfo(companyId, type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceivedDocumentsApi.GetReceivedDocumentPreCreateInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **type** | **string** | The type of the received document. |  |

### Return type

[**GetReceivedDocumentPreCreateInfoResponse**](GetReceivedDocumentPreCreateInfoResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pre-create info |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listbinreceiveddocuments"></a>
# **ListBinReceivedDocuments**
> ListBinReceivedDocuments ListBinReceivedDocuments (int companyId)

Get Bin Received Documents List

Get bin Received documents list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListBinReceivedDocumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceivedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.

            try
            {
                // Get Bin Received Documents List
                ListBinReceivedDocuments result = apiInstance.ListBinReceivedDocuments(companyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceivedDocumentsApi.ListBinReceivedDocuments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListBinReceivedDocumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Bin Received Documents List
    ApiResponse<ListBinReceivedDocuments> response = apiInstance.ListBinReceivedDocumentsWithHttpInfo(companyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceivedDocumentsApi.ListBinReceivedDocumentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |

### Return type

[**ListBinReceivedDocuments**](ListBinReceivedDocuments.md)

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

<a id="listreceiveddocuments"></a>
# **ListReceivedDocuments**
> ListReceivedDocumentsResponse ListReceivedDocuments (int companyId, string type, string fields = null, string fieldset = null, string sort = null, int? page = null, int? perPage = null, string q = null)

List Received Documents

Lists the received documents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListReceivedDocumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceivedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var type = "expense";  // string | The type of the received document.
            var fields = "fields_example";  // string | List of comma-separated fields. (optional) 
            var fieldset = "basic";  // string | Name of the fieldset. (optional) 
            var sort = "sort_example";  // string | List of comma-separated fields for result sorting (minus for desc sorting). (optional) 
            var page = 1;  // int? | The page to retrieve. (optional)  (default to 1)
            var perPage = 5;  // int? | The size of the page. (optional)  (default to 5)
            var q = "q_example";  // string | Query for filtering the results. (optional) 

            try
            {
                // List Received Documents
                ListReceivedDocumentsResponse result = apiInstance.ListReceivedDocuments(companyId, type, fields, fieldset, sort, page, perPage, q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceivedDocumentsApi.ListReceivedDocuments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListReceivedDocumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Received Documents
    ApiResponse<ListReceivedDocumentsResponse> response = apiInstance.ListReceivedDocumentsWithHttpInfo(companyId, type, fields, fieldset, sort, page, perPage, q);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceivedDocumentsApi.ListReceivedDocumentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **type** | **string** | The type of the received document. |  |
| **fields** | **string** | List of comma-separated fields. | [optional]  |
| **fieldset** | **string** | Name of the fieldset. | [optional]  |
| **sort** | **string** | List of comma-separated fields for result sorting (minus for desc sorting). | [optional]  |
| **page** | **int?** | The page to retrieve. | [optional] [default to 1] |
| **perPage** | **int?** | The size of the page. | [optional] [default to 5] |
| **q** | **string** | Query for filtering the results. | [optional]  |

### Return type

[**ListReceivedDocumentsResponse**](ListReceivedDocumentsResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="modifyreceiveddocument"></a>
# **ModifyReceivedDocument**
> ModifyReceivedDocumentResponse ModifyReceivedDocument (int companyId, int documentId, ModifyReceivedDocumentRequest modifyReceivedDocumentRequest = null)

Modify Received Document

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
    public class ModifyReceivedDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceivedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.
            var modifyReceivedDocumentRequest = new ModifyReceivedDocumentRequest(); // ModifyReceivedDocumentRequest | Modified document. (optional) 

            try
            {
                // Modify Received Document
                ModifyReceivedDocumentResponse result = apiInstance.ModifyReceivedDocument(companyId, documentId, modifyReceivedDocumentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceivedDocumentsApi.ModifyReceivedDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModifyReceivedDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Modify Received Document
    ApiResponse<ModifyReceivedDocumentResponse> response = apiInstance.ModifyReceivedDocumentWithHttpInfo(companyId, documentId, modifyReceivedDocumentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceivedDocumentsApi.ModifyReceivedDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **documentId** | **int** | The ID of the document. |  |
| **modifyReceivedDocumentRequest** | [**ModifyReceivedDocumentRequest**](ModifyReceivedDocumentRequest.md) | Modified document. | [optional]  |

### Return type

[**ModifyReceivedDocumentResponse**](ModifyReceivedDocumentResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Modified document. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="recoverbinreceiveddocument"></a>
# **RecoverBinReceivedDocument**
> void RecoverBinReceivedDocument (int companyId, int documentId)

Recover Received Document From The Bin

Recover Received Document From The Bin

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class RecoverBinReceivedDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceivedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.

            try
            {
                // Recover Received Document From The Bin
                apiInstance.RecoverBinReceivedDocument(companyId, documentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceivedDocumentsApi.RecoverBinReceivedDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecoverBinReceivedDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Recover Received Document From The Bin
    apiInstance.RecoverBinReceivedDocumentWithHttpInfo(companyId, documentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceivedDocumentsApi.RecoverBinReceivedDocumentWithHttpInfo: " + e.Message);
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
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadreceiveddocumentattachment"></a>
# **UploadReceivedDocumentAttachment**
> UploadReceivedDocumentAttachmentResponse UploadReceivedDocumentAttachment (int companyId, string filename = null, System.IO.Stream attachment = null)

Upload Received Document Attachment

Uploads an attachment destined to a received document. The actual association between the document and the attachment must be implemented separately, using the returned token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class UploadReceivedDocumentAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceivedDocumentsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var filename = "filename_example";  // string | Attachment file name (optional) 
            var attachment = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Attachment file [.png, .jpg, .gif, .pdf, .zip, .xls, .xlsx, .doc, .docx] (optional) 

            try
            {
                // Upload Received Document Attachment
                UploadReceivedDocumentAttachmentResponse result = apiInstance.UploadReceivedDocumentAttachment(companyId, filename, attachment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReceivedDocumentsApi.UploadReceivedDocumentAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadReceivedDocumentAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload Received Document Attachment
    ApiResponse<UploadReceivedDocumentAttachmentResponse> response = apiInstance.UploadReceivedDocumentAttachmentWithHttpInfo(companyId, filename, attachment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReceivedDocumentsApi.UploadReceivedDocumentAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **filename** | **string** | Attachment file name | [optional]  |
| **attachment** | **System.IO.Stream****System.IO.Stream** | Attachment file [.png, .jpg, .gif, .pdf, .zip, .xls, .xlsx, .doc, .docx] | [optional]  |

### Return type

[**UploadReceivedDocumentAttachmentResponse**](UploadReceivedDocumentAttachmentResponse.md)

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

