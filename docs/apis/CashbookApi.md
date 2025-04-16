# It.FattureInCloud.Sdk.Api.CashbookApi

All URIs are relative to *https://api-v2.fattureincloud.it*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCashbookEntry**](CashbookApi.md#createcashbookentry) | **POST** /c/{company_id}/cashbook | Create Cashbook Entry |
| [**DeleteCashbookEntry**](CashbookApi.md#deletecashbookentry) | **DELETE** /c/{company_id}/cashbook/{document_id} | Delete Cashbook Entry |
| [**GetCashbookEntry**](CashbookApi.md#getcashbookentry) | **GET** /c/{company_id}/cashbook/{document_id} | Get Cashbook Entry |
| [**ListCashbookEntries**](CashbookApi.md#listcashbookentries) | **GET** /c/{company_id}/cashbook | List Cashbook Entries |
| [**ModifyCashbookEntry**](CashbookApi.md#modifycashbookentry) | **PUT** /c/{company_id}/cashbook/{document_id} | Modify Cashbook Entry |

<a id="createcashbookentry"></a>
# **CreateCashbookEntry**
> CreateCashbookEntryResponse CreateCashbookEntry (int companyId, CreateCashbookEntryRequest createCashbookEntryRequest = null)

Create Cashbook Entry

Creates a new cashbook entry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class CreateCashbookEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CashbookApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var createCashbookEntryRequest = new CreateCashbookEntryRequest(); // CreateCashbookEntryRequest | Cashbook entry.  (optional) 

            try
            {
                // Create Cashbook Entry
                CreateCashbookEntryResponse result = apiInstance.CreateCashbookEntry(companyId, createCashbookEntryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CashbookApi.CreateCashbookEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCashbookEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Cashbook Entry
    ApiResponse<CreateCashbookEntryResponse> response = apiInstance.CreateCashbookEntryWithHttpInfo(companyId, createCashbookEntryRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CashbookApi.CreateCashbookEntryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **createCashbookEntryRequest** | [**CreateCashbookEntryRequest**](CreateCashbookEntryRequest.md) | Cashbook entry.  | [optional]  |

### Return type

[**CreateCashbookEntryResponse**](CreateCashbookEntryResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The created Cashbook Entry. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletecashbookentry"></a>
# **DeleteCashbookEntry**
> void DeleteCashbookEntry (int companyId, string documentId)

Delete Cashbook Entry

Deletes the specified cashbook entry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class DeleteCashbookEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CashbookApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = "documentId_example";  // string | The ID of the document.

            try
            {
                // Delete Cashbook Entry
                apiInstance.DeleteCashbookEntry(companyId, documentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CashbookApi.DeleteCashbookEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCashbookEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Cashbook Entry
    apiInstance.DeleteCashbookEntryWithHttpInfo(companyId, documentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CashbookApi.DeleteCashbookEntryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **documentId** | **string** | The ID of the document. |  |

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcashbookentry"></a>
# **GetCashbookEntry**
> GetCashbookEntryResponse GetCashbookEntry (int companyId, string documentId, string fields = null, string fieldset = null)

Get Cashbook Entry

Gets the specified cashbook entry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetCashbookEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CashbookApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = "documentId_example";  // string | The ID of the document.
            var fields = "fields_example";  // string | List of comma-separated fields. (optional) 
            var fieldset = "basic";  // string | Name of the fieldset. (optional) 

            try
            {
                // Get Cashbook Entry
                GetCashbookEntryResponse result = apiInstance.GetCashbookEntry(companyId, documentId, fields, fieldset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CashbookApi.GetCashbookEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCashbookEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Cashbook Entry
    ApiResponse<GetCashbookEntryResponse> response = apiInstance.GetCashbookEntryWithHttpInfo(companyId, documentId, fields, fieldset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CashbookApi.GetCashbookEntryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **documentId** | **string** | The ID of the document. |  |
| **fields** | **string** | List of comma-separated fields. | [optional]  |
| **fieldset** | **string** | Name of the fieldset. | [optional]  |

### Return type

[**GetCashbookEntryResponse**](GetCashbookEntryResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Cashbook Entry. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listcashbookentries"></a>
# **ListCashbookEntries**
> ListCashbookEntriesResponse ListCashbookEntries (int companyId, string dateFrom, string dateTo, int year = null, string type = null, int paymentAccountId = null)

List Cashbook Entries

Lists the cashbook entries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListCashbookEntriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CashbookApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var dateFrom = "dateFrom_example";  // string | Start date.
            var dateTo = "dateTo_example";  // string | End date.
            var year = 56;  // int | Filter cashbook by year. (optional) 
            var type = "all";  // string | Filter cashbook by type. (optional) 
            var paymentAccountId = 56;  // int | Filter by payment account. (optional) 

            try
            {
                // List Cashbook Entries
                ListCashbookEntriesResponse result = apiInstance.ListCashbookEntries(companyId, dateFrom, dateTo, year, type, paymentAccountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CashbookApi.ListCashbookEntries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCashbookEntriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Cashbook Entries
    ApiResponse<ListCashbookEntriesResponse> response = apiInstance.ListCashbookEntriesWithHttpInfo(companyId, dateFrom, dateTo, year, type, paymentAccountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CashbookApi.ListCashbookEntriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **dateFrom** | **string** | Start date. |  |
| **dateTo** | **string** | End date. |  |
| **year** | **int** | Filter cashbook by year. | [optional]  |
| **type** | **string** | Filter cashbook by type. | [optional]  |
| **paymentAccountId** | **int** | Filter by payment account. | [optional]  |

### Return type

[**ListCashbookEntriesResponse**](ListCashbookEntriesResponse.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="modifycashbookentry"></a>
# **ModifyCashbookEntry**
> ModifyCashbookEntryResponse ModifyCashbookEntry (int companyId, string documentId, ModifyCashbookEntryRequest modifyCashbookEntryRequest = null)

Modify Cashbook Entry

Modifies the specified cashbook entry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ModifyCashbookEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CashbookApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = "documentId_example";  // string | The ID of the document.
            var modifyCashbookEntryRequest = new ModifyCashbookEntryRequest(); // ModifyCashbookEntryRequest | Cashbook Entry (optional) 

            try
            {
                // Modify Cashbook Entry
                ModifyCashbookEntryResponse result = apiInstance.ModifyCashbookEntry(companyId, documentId, modifyCashbookEntryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CashbookApi.ModifyCashbookEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModifyCashbookEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Modify Cashbook Entry
    ApiResponse<ModifyCashbookEntryResponse> response = apiInstance.ModifyCashbookEntryWithHttpInfo(companyId, documentId, modifyCashbookEntryRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CashbookApi.ModifyCashbookEntryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **documentId** | **string** | The ID of the document. |  |
| **modifyCashbookEntryRequest** | [**ModifyCashbookEntryRequest**](ModifyCashbookEntryRequest.md) | Cashbook Entry | [optional]  |

### Return type

[**ModifyCashbookEntryResponse**](ModifyCashbookEntryResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The modified Cashbook Entry |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

