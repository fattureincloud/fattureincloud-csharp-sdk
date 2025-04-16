# It.FattureInCloud.Sdk.Api.PriceListsApi

All URIs are relative to *https://api-v2.fattureincloud.it*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetPriceListItems**](PriceListsApi.md#getpricelistitems) | **GET** /c/{company_id}/price_lists/{price_list_id}/items | Get PriceList Items List |
| [**GetPriceLists**](PriceListsApi.md#getpricelists) | **GET** /c/{company_id}/price_lists | Get PriceLists |

<a id="getpricelistitems"></a>
# **GetPriceListItems**
> GetPriceListItemsResponse GetPriceListItems (int companyId, string priceListId)

Get PriceList Items List

Retrieves all the Items of a PriceList

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetPriceListItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PriceListsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var priceListId = "priceListId_example";  // string | The ID of the price

            try
            {
                // Get PriceList Items List
                GetPriceListItemsResponse result = apiInstance.GetPriceListItems(companyId, priceListId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListsApi.GetPriceListItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPriceListItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get PriceList Items List
    ApiResponse<GetPriceListItemsResponse> response = apiInstance.GetPriceListItemsWithHttpInfo(companyId, priceListId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListsApi.GetPriceListItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **priceListId** | **string** | The ID of the price |  |

### Return type

[**GetPriceListItemsResponse**](GetPriceListItemsResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Example response |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getpricelists"></a>
# **GetPriceLists**
> ListPriceListsResponse GetPriceLists (int companyId)

Get PriceLists

Retrieves all price lists of the company

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetPriceListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PriceListsApi(config);
            var companyId = 12345;  // int | The ID of the company.

            try
            {
                // Get PriceLists
                ListPriceListsResponse result = apiInstance.GetPriceLists(companyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListsApi.GetPriceLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPriceListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get PriceLists
    ApiResponse<ListPriceListsResponse> response = apiInstance.GetPriceListsWithHttpInfo(companyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListsApi.GetPriceListsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |

### Return type

[**ListPriceListsResponse**](ListPriceListsResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Example response |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

