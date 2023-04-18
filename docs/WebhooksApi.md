# It.FattureInCloud.Sdk.Api.WebhooksApi

All URIs are relative to *https://api-v2.fattureincloud.it*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateWebhooksSubscription**](WebhooksApi.md#createwebhookssubscription) | **POST** /c/{company_id}/subscriptions | Create a Webhook Subscription |
| [**DeleteWebhooksSubscription**](WebhooksApi.md#deletewebhookssubscription) | **DELETE** /c/{company_id}/subscriptions/{subscription_id} | Delete Webhooks Subscription |
| [**GetWebhooksSubscription**](WebhooksApi.md#getwebhookssubscription) | **GET** /c/{company_id}/subscriptions/{subscription_id} | Get Webhooks Subscription |
| [**ListWebhooksSubscriptions**](WebhooksApi.md#listwebhookssubscriptions) | **GET** /c/{company_id}/subscriptions | List Webhooks Subscriptions |
| [**ModifyWebhooksSubscription**](WebhooksApi.md#modifywebhookssubscription) | **PUT** /c/{company_id}/subscriptions/{subscription_id} | Modify Webhooks Subscription |

<a name="createwebhookssubscription"></a>
# **CreateWebhooksSubscription**
> CreateWebhooksSubscriptionResponse CreateWebhooksSubscription (int companyId, CreateWebhooksSubscriptionRequest createWebhooksSubscriptionRequest = null)

Create a Webhook Subscription

Register some webhooks Subscriptions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class CreateWebhooksSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var createWebhooksSubscriptionRequest = new CreateWebhooksSubscriptionRequest(); // CreateWebhooksSubscriptionRequest |  (optional) 

            try
            {
                // Create a Webhook Subscription
                CreateWebhooksSubscriptionResponse result = apiInstance.CreateWebhooksSubscription(companyId, createWebhooksSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.CreateWebhooksSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWebhooksSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Webhook Subscription
    ApiResponse<CreateWebhooksSubscriptionResponse> response = apiInstance.CreateWebhooksSubscriptionWithHttpInfo(companyId, createWebhooksSubscriptionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.CreateWebhooksSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **createWebhooksSubscriptionRequest** | [**CreateWebhooksSubscriptionRequest**](CreateWebhooksSubscriptionRequest.md) |  | [optional]  |

### Return type

[**CreateWebhooksSubscriptionResponse**](CreateWebhooksSubscriptionResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Example response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewebhookssubscription"></a>
# **DeleteWebhooksSubscription**
> void DeleteWebhooksSubscription (int companyId, string subscriptionId)

Delete Webhooks Subscription

Delete a webhooks subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class DeleteWebhooksSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var subscriptionId = SUB123;  // string | The ID of the subscription.

            try
            {
                // Delete Webhooks Subscription
                apiInstance.DeleteWebhooksSubscription(companyId, subscriptionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.DeleteWebhooksSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWebhooksSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Webhooks Subscription
    apiInstance.DeleteWebhooksSubscriptionWithHttpInfo(companyId, subscriptionId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.DeleteWebhooksSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **subscriptionId** | **string** | The ID of the subscription. |  |

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

<a name="getwebhookssubscription"></a>
# **GetWebhooksSubscription**
> GetWebhooksSubscriptionResponse GetWebhooksSubscription (int companyId, string subscriptionId)

Get Webhooks Subscription

Get a webhooks subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetWebhooksSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var subscriptionId = SUB123;  // string | The ID of the subscription.

            try
            {
                // Get Webhooks Subscription
                GetWebhooksSubscriptionResponse result = apiInstance.GetWebhooksSubscription(companyId, subscriptionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhooksSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebhooksSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Webhooks Subscription
    ApiResponse<GetWebhooksSubscriptionResponse> response = apiInstance.GetWebhooksSubscriptionWithHttpInfo(companyId, subscriptionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.GetWebhooksSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **subscriptionId** | **string** | The ID of the subscription. |  |

### Return type

[**GetWebhooksSubscriptionResponse**](GetWebhooksSubscriptionResponse.md)

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

<a name="listwebhookssubscriptions"></a>
# **ListWebhooksSubscriptions**
> ListWebhooksSubscriptionsResponse ListWebhooksSubscriptions (int companyId)

List Webhooks Subscriptions

List active webhooks subscriptions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ListWebhooksSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi(config);
            var companyId = 12345;  // int | The ID of the company.

            try
            {
                // List Webhooks Subscriptions
                ListWebhooksSubscriptionsResponse result = apiInstance.ListWebhooksSubscriptions(companyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.ListWebhooksSubscriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListWebhooksSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Webhooks Subscriptions
    ApiResponse<ListWebhooksSubscriptionsResponse> response = apiInstance.ListWebhooksSubscriptionsWithHttpInfo(companyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.ListWebhooksSubscriptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |

### Return type

[**ListWebhooksSubscriptionsResponse**](ListWebhooksSubscriptionsResponse.md)

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

<a name="modifywebhookssubscription"></a>
# **ModifyWebhooksSubscription**
> ModifyWebhooksSubscriptionResponse ModifyWebhooksSubscription (int companyId, string subscriptionId, ModifyWebhooksSubscriptionRequest modifyWebhooksSubscriptionRequest = null)

Modify Webhooks Subscription

Edit a webhooks subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ModifyWebhooksSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var subscriptionId = SUB123;  // string | The ID of the subscription.
            var modifyWebhooksSubscriptionRequest = new ModifyWebhooksSubscriptionRequest(); // ModifyWebhooksSubscriptionRequest |  (optional) 

            try
            {
                // Modify Webhooks Subscription
                ModifyWebhooksSubscriptionResponse result = apiInstance.ModifyWebhooksSubscription(companyId, subscriptionId, modifyWebhooksSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.ModifyWebhooksSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModifyWebhooksSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Modify Webhooks Subscription
    ApiResponse<ModifyWebhooksSubscriptionResponse> response = apiInstance.ModifyWebhooksSubscriptionWithHttpInfo(companyId, subscriptionId, modifyWebhooksSubscriptionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.ModifyWebhooksSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **subscriptionId** | **string** | The ID of the subscription. |  |
| **modifyWebhooksSubscriptionRequest** | [**ModifyWebhooksSubscriptionRequest**](ModifyWebhooksSubscriptionRequest.md) |  | [optional]  |

### Return type

[**ModifyWebhooksSubscriptionResponse**](ModifyWebhooksSubscriptionResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Example response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

