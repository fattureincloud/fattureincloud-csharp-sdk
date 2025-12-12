# It.FattureInCloud.Sdk.Api.CompaniesApi

All URIs are relative to *https://api-v2.fattureincloud.it*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCompanyInfo**](CompaniesApi.md#getcompanyinfo) | **GET** /c/{company_id}/company/info | Get Company Info |
| [**GetCompanyPlanUsage**](CompaniesApi.md#getcompanyplanusage) | **GET** /c/{company_id}/company/plan_usage | Get Company Plan Usage |

<a id="getcompanyinfo"></a>
# **GetCompanyInfo**
> GetCompanyInfoResponse GetCompanyInfo (int companyId)

Get Company Info

Gets the company detailed info.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetCompanyInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CompaniesApi(config);
            var companyId = 12345;  // int | The ID of the company.

            try
            {
                // Get Company Info
                GetCompanyInfoResponse result = apiInstance.GetCompanyInfo(companyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompaniesApi.GetCompanyInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCompanyInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Company Info
    ApiResponse<GetCompanyInfoResponse> response = apiInstance.GetCompanyInfoWithHttpInfo(companyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CompaniesApi.GetCompanyInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |

### Return type

[**GetCompanyInfoResponse**](GetCompanyInfoResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Company info. |  * RateLimit-HourlyRemaining -  <br>  * RateLimit-HourlyLimit -  <br>  * RateLimit-MonthlyRemaining -  <br>  * RateLimit-MonthlyLimit -  <br>  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden - Rate limit exceeded |  * Retry-After -  <br>  |
| **429** | Too Many Requests |  * Retry-After -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcompanyplanusage"></a>
# **GetCompanyPlanUsage**
> GetCompanyPlanUsageResponse GetCompanyPlanUsage (int companyId, string category)

Get Company Plan Usage

Gets the company limits usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetCompanyPlanUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CompaniesApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var category = "clients";  // string | Category

            try
            {
                // Get Company Plan Usage
                GetCompanyPlanUsageResponse result = apiInstance.GetCompanyPlanUsage(companyId, category);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompaniesApi.GetCompanyPlanUsage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCompanyPlanUsageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Company Plan Usage
    ApiResponse<GetCompanyPlanUsageResponse> response = apiInstance.GetCompanyPlanUsageWithHttpInfo(companyId, category);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CompaniesApi.GetCompanyPlanUsageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **category** | **string** | Category |  |

### Return type

[**GetCompanyPlanUsageResponse**](GetCompanyPlanUsageResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Example response |  * RateLimit-HourlyRemaining -  <br>  * RateLimit-HourlyLimit -  <br>  * RateLimit-MonthlyRemaining -  <br>  * RateLimit-MonthlyLimit -  <br>  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden - Rate limit exceeded |  * Retry-After -  <br>  |
| **429** | Too Many Requests |  * Retry-After -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

