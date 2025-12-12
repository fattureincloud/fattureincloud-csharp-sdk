# It.FattureInCloud.Sdk.Api.ArchiveApi

All URIs are relative to *https://api-v2.fattureincloud.it*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateArchiveDocument**](ArchiveApi.md#createarchivedocument) | **POST** /c/{company_id}/archive | Create Archive Document |
| [**DeleteArchiveDocument**](ArchiveApi.md#deletearchivedocument) | **DELETE** /c/{company_id}/archive/{document_id} | Delete Archive Document |
| [**GetArchiveDocument**](ArchiveApi.md#getarchivedocument) | **GET** /c/{company_id}/archive/{document_id} | Get Archive Document |
| [**ListArchiveDocuments**](ArchiveApi.md#listarchivedocuments) | **GET** /c/{company_id}/archive | List Archive Documents |
| [**ModifyArchiveDocument**](ArchiveApi.md#modifyarchivedocument) | **PUT** /c/{company_id}/archive/{document_id} | Modify Archive Document |
| [**UploadArchiveDocumentAttachment**](ArchiveApi.md#uploadarchivedocumentattachment) | **POST** /c/{company_id}/archive/attachment | Upload Archive Document Attachment |

<a id="createarchivedocument"></a>
# **CreateArchiveDocument**
> CreateArchiveDocumentResponse CreateArchiveDocument (int companyId, CreateArchiveDocumentRequest createArchiveDocumentRequest = null)

Create Archive Document

Creates a new archive document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class CreateArchiveDocumentExample
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
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArchiveApi.CreateArchiveDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateArchiveDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Archive Document
    ApiResponse<CreateArchiveDocumentResponse> response = apiInstance.CreateArchiveDocumentWithHttpInfo(companyId, createArchiveDocumentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArchiveApi.CreateArchiveDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **createArchiveDocumentRequest** | [**CreateArchiveDocumentRequest**](CreateArchiveDocumentRequest.md) | The Archive Document. | [optional]  |

### Return type

[**CreateArchiveDocumentResponse**](CreateArchiveDocumentResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Archive Document. |  * RateLimit-HourlyRemaining -  <br>  * RateLimit-HourlyLimit -  <br>  * RateLimit-MonthlyRemaining -  <br>  * RateLimit-MonthlyLimit -  <br>  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden - Rate limit exceeded |  * Retry-After -  <br>  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  * Retry-After -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletearchivedocument"></a>
# **DeleteArchiveDocument**
> void DeleteArchiveDocument (int companyId, int documentId)

Delete Archive Document

Deletes the specified archive document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class DeleteArchiveDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchiveApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.

            try
            {
                // Delete Archive Document
                apiInstance.DeleteArchiveDocument(companyId, documentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArchiveApi.DeleteArchiveDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteArchiveDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Archive Document
    apiInstance.DeleteArchiveDocumentWithHttpInfo(companyId, documentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArchiveApi.DeleteArchiveDocumentWithHttpInfo: " + e.Message);
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
| **200** | Document removed. |  * RateLimit-HourlyRemaining -  <br>  * RateLimit-HourlyLimit -  <br>  * RateLimit-MonthlyRemaining -  <br>  * RateLimit-MonthlyLimit -  <br>  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden - Rate limit exceeded |  * Retry-After -  <br>  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  * Retry-After -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getarchivedocument"></a>
# **GetArchiveDocument**
> GetArchiveDocumentResponse GetArchiveDocument (int companyId, int documentId, string fields = null, string fieldset = null)

Get Archive Document

Gets the specified archive document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetArchiveDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchiveApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.
            var fields = "fields_example";  // string | List of comma-separated fields. (optional) 
            var fieldset = "basic";  // string | Name of the fieldset. (optional) 

            try
            {
                // Get Archive Document
                GetArchiveDocumentResponse result = apiInstance.GetArchiveDocument(companyId, documentId, fields, fieldset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArchiveApi.GetArchiveDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetArchiveDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Archive Document
    ApiResponse<GetArchiveDocumentResponse> response = apiInstance.GetArchiveDocumentWithHttpInfo(companyId, documentId, fields, fieldset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArchiveApi.GetArchiveDocumentWithHttpInfo: " + e.Message);
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

[**GetArchiveDocumentResponse**](GetArchiveDocumentResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Archive Document Details |  * RateLimit-HourlyRemaining -  <br>  * RateLimit-HourlyLimit -  <br>  * RateLimit-MonthlyRemaining -  <br>  * RateLimit-MonthlyLimit -  <br>  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden - Rate limit exceeded |  * Retry-After -  <br>  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  * Retry-After -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listarchivedocuments"></a>
# **ListArchiveDocuments**
> ListArchiveDocumentsResponse ListArchiveDocuments (int companyId, string fields = null, string fieldset = null, string sort = null, int? page = null, int? perPage = null, string q = null)

List Archive Documents

Lists the archive documents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListArchiveDocumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchiveApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var fields = "fields_example";  // string | List of comma-separated fields. (optional) 
            var fieldset = "basic";  // string | Name of the fieldset. (optional) 
            var sort = "sort_example";  // string | List of comma-separated fields for result sorting (minus for desc sorting). (optional) 
            var page = 1;  // int? | The page to retrieve. (optional)  (default to 1)
            var perPage = 5;  // int? | The size of the page. (optional)  (default to 5)
            var q = "q_example";  // string | Query for filtering the results. (optional) 

            try
            {
                // List Archive Documents
                ListArchiveDocumentsResponse result = apiInstance.ListArchiveDocuments(companyId, fields, fieldset, sort, page, perPage, q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArchiveApi.ListArchiveDocuments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListArchiveDocumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Archive Documents
    ApiResponse<ListArchiveDocumentsResponse> response = apiInstance.ListArchiveDocumentsWithHttpInfo(companyId, fields, fieldset, sort, page, perPage, q);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArchiveApi.ListArchiveDocumentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **fields** | **string** | List of comma-separated fields. | [optional]  |
| **fieldset** | **string** | Name of the fieldset. | [optional]  |
| **sort** | **string** | List of comma-separated fields for result sorting (minus for desc sorting). | [optional]  |
| **page** | **int?** | The page to retrieve. | [optional] [default to 1] |
| **perPage** | **int?** | The size of the page. | [optional] [default to 5] |
| **q** | **string** | Query for filtering the results. | [optional]  |

### Return type

[**ListArchiveDocumentsResponse**](ListArchiveDocumentsResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Results list. |  * RateLimit-HourlyRemaining -  <br>  * RateLimit-HourlyLimit -  <br>  * RateLimit-MonthlyRemaining -  <br>  * RateLimit-MonthlyLimit -  <br>  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden - Rate limit exceeded |  * Retry-After -  <br>  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  * Retry-After -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="modifyarchivedocument"></a>
# **ModifyArchiveDocument**
> ModifyArchiveDocumentResponse ModifyArchiveDocument (int companyId, int documentId, ModifyArchiveDocumentRequest modifyArchiveDocumentRequest = null)

Modify Archive Document

Modifies the specified archive document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ModifyArchiveDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchiveApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.
            var modifyArchiveDocumentRequest = new ModifyArchiveDocumentRequest(); // ModifyArchiveDocumentRequest | Modified Archive Document (optional) 

            try
            {
                // Modify Archive Document
                ModifyArchiveDocumentResponse result = apiInstance.ModifyArchiveDocument(companyId, documentId, modifyArchiveDocumentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArchiveApi.ModifyArchiveDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModifyArchiveDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Modify Archive Document
    ApiResponse<ModifyArchiveDocumentResponse> response = apiInstance.ModifyArchiveDocumentWithHttpInfo(companyId, documentId, modifyArchiveDocumentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArchiveApi.ModifyArchiveDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **documentId** | **int** | The ID of the document. |  |
| **modifyArchiveDocumentRequest** | [**ModifyArchiveDocumentRequest**](ModifyArchiveDocumentRequest.md) | Modified Archive Document | [optional]  |

### Return type

[**ModifyArchiveDocumentResponse**](ModifyArchiveDocumentResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The modified Archived Document |  * RateLimit-HourlyRemaining -  <br>  * RateLimit-HourlyLimit -  <br>  * RateLimit-MonthlyRemaining -  <br>  * RateLimit-MonthlyLimit -  <br>  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden - Rate limit exceeded |  * Retry-After -  <br>  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  * Retry-After -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadarchivedocumentattachment"></a>
# **UploadArchiveDocumentAttachment**
> UploadArchiveAttachmentResponse UploadArchiveDocumentAttachment (int companyId, string filename = null, System.IO.Stream attachment = null)

Upload Archive Document Attachment

Uploads an attachment destined to an archive document. The actual association between the document and the attachment must be implemented separately, using the returned token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class UploadArchiveDocumentAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ArchiveApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var filename = "filename_example";  // string | Attachment file name (optional) 
            var attachment = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Attachment file [.png, .jpg, .gif, .pdf, .zip, .xls, .xlsx, .doc, .docx] (optional) 

            try
            {
                // Upload Archive Document Attachment
                UploadArchiveAttachmentResponse result = apiInstance.UploadArchiveDocumentAttachment(companyId, filename, attachment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArchiveApi.UploadArchiveDocumentAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadArchiveDocumentAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload Archive Document Attachment
    ApiResponse<UploadArchiveAttachmentResponse> response = apiInstance.UploadArchiveDocumentAttachmentWithHttpInfo(companyId, filename, attachment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArchiveApi.UploadArchiveDocumentAttachmentWithHttpInfo: " + e.Message);
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

[**UploadArchiveAttachmentResponse**](UploadArchiveAttachmentResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Example response |  * RateLimit-HourlyRemaining -  <br>  * RateLimit-HourlyLimit -  <br>  * RateLimit-MonthlyRemaining -  <br>  * RateLimit-MonthlyLimit -  <br>  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden - Rate limit exceeded |  * Retry-After -  <br>  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  * Retry-After -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

