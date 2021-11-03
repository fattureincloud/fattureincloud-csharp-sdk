# It.FattureInCloud.Sdk.Api.SettingsApi

All URIs are relative to *https://api-v2.fattureincloud.it*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePaymentAccount**](SettingsApi.md#createpaymentaccount) | **POST** /c/{companyId}/settings/payment_accounts | Create Payment Account
[**CreatePaymentMethod**](SettingsApi.md#createpaymentmethod) | **POST** /c/{companyId}/settings/payment_methods | Create Payment Method
[**DeletePaymentAccount**](SettingsApi.md#deletepaymentaccount) | **DELETE** /c/{companyId}/settings/payment_accounts/{paymentAccountId} | Delete Payment Account
[**DeletePaymentMethod**](SettingsApi.md#deletepaymentmethod) | **DELETE** /c/{companyId}/settings/payment_method/{paymentMethodId} | Delete Payment Method
[**GetPaymentAccount**](SettingsApi.md#getpaymentaccount) | **GET** /c/{companyId}/settings/payment_accounts/{paymentAccountId} | Get Payment Account
[**GetPaymentMethod**](SettingsApi.md#getpaymentmethod) | **GET** /c/{companyId}/settings/payment_method/{paymentMethodId} | Get Payment Method
[**ModifyPaymentAccount**](SettingsApi.md#modifypaymentaccount) | **PUT** /c/{companyId}/settings/payment_accounts/{paymentAccountId} | Modify Payment Account
[**ModifyPaymentMethod**](SettingsApi.md#modifypaymentmethod) | **PUT** /c/{companyId}/settings/payment_method/{paymentMethodId} | Modify Payment Method


<a name="createpaymentaccount"></a>
# **CreatePaymentAccount**
> CreatePaymentAccountResponse CreatePaymentAccount (int companyId, CreatePaymentAccountRequest createPaymentAccountRequest = null)

Create Payment Account

Creates a new payment account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class CreatePaymentAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SettingsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var createPaymentAccountRequest = new CreatePaymentAccountRequest(); // CreatePaymentAccountRequest |  (optional) 

            try
            {
                // Create Payment Account
                CreatePaymentAccountResponse result = apiInstance.CreatePaymentAccount(companyId, createPaymentAccountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.CreatePaymentAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **int**| The ID of the company. | 
 **createPaymentAccountRequest** | [**CreatePaymentAccountRequest**](CreatePaymentAccountRequest.md)|  | [optional] 

### Return type

[**CreatePaymentAccountResponse**](CreatePaymentAccountResponse.md)

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

<a name="createpaymentmethod"></a>
# **CreatePaymentMethod**
> CreatePaymentMethodResponse CreatePaymentMethod (int companyId, CreatePaymentMethodRequest createPaymentMethodRequest = null)

Create Payment Method

Creates a new payment method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class CreatePaymentMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SettingsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var createPaymentMethodRequest = new CreatePaymentMethodRequest(); // CreatePaymentMethodRequest |  (optional) 

            try
            {
                // Create Payment Method
                CreatePaymentMethodResponse result = apiInstance.CreatePaymentMethod(companyId, createPaymentMethodRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.CreatePaymentMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **int**| The ID of the company. | 
 **createPaymentMethodRequest** | [**CreatePaymentMethodRequest**](CreatePaymentMethodRequest.md)|  | [optional] 

### Return type

[**CreatePaymentMethodResponse**](CreatePaymentMethodResponse.md)

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

<a name="deletepaymentaccount"></a>
# **DeletePaymentAccount**
> void DeletePaymentAccount (int companyId, string paymentAccountId)

Delete Payment Account

Deletes the specified payment account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class DeletePaymentAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SettingsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var paymentAccountId = 1;  // string | The Referred Payment Account Id.

            try
            {
                // Delete Payment Account
                apiInstance.DeletePaymentAccount(companyId, paymentAccountId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.DeletePaymentAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **int**| The ID of the company. | 
 **paymentAccountId** | **string**| The Referred Payment Account Id. | 

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

<a name="deletepaymentmethod"></a>
# **DeletePaymentMethod**
> void DeletePaymentMethod (int companyId, int paymentMethodId)

Delete Payment Method

Deletes the specified payment method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class DeletePaymentMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SettingsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var paymentMethodId = 1;  // int | The Referred Payment Method Id.

            try
            {
                // Delete Payment Method
                apiInstance.DeletePaymentMethod(companyId, paymentMethodId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.DeletePaymentMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **int**| The ID of the company. | 
 **paymentMethodId** | **int**| The Referred Payment Method Id. | 

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

<a name="getpaymentaccount"></a>
# **GetPaymentAccount**
> GetPaymentAccountResponse GetPaymentAccount (int companyId, string paymentAccountId, string fields = null, string fieldset = null, Object body = null)

Get Payment Account

Gets the specified payment account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetPaymentAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SettingsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var paymentAccountId = 1;  // string | The Referred Payment Account Id.
            var fields = fields_example;  // string | List of comma-separated fields. (optional) 
            var fieldset = fieldset_example;  // string | Name of the fieldset. (optional) 
            var body = ;  // Object |  (optional) 

            try
            {
                // Get Payment Account
                GetPaymentAccountResponse result = apiInstance.GetPaymentAccount(companyId, paymentAccountId, fields, fieldset, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetPaymentAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **int**| The ID of the company. | 
 **paymentAccountId** | **string**| The Referred Payment Account Id. | 
 **fields** | **string**| List of comma-separated fields. | [optional] 
 **fieldset** | **string**| Name of the fieldset. | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

[**GetPaymentAccountResponse**](GetPaymentAccountResponse.md)

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

<a name="getpaymentmethod"></a>
# **GetPaymentMethod**
> GetPaymentMethodResponse GetPaymentMethod (int companyId, int paymentMethodId, string fields = null, string fieldset = null)

Get Payment Method

Gets the specified payment method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetPaymentMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SettingsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var paymentMethodId = 1;  // int | The Referred Payment Method Id.
            var fields = fields_example;  // string | List of comma-separated fields. (optional) 
            var fieldset = fieldset_example;  // string | Name of the fieldset. (optional) 

            try
            {
                // Get Payment Method
                GetPaymentMethodResponse result = apiInstance.GetPaymentMethod(companyId, paymentMethodId, fields, fieldset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetPaymentMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **int**| The ID of the company. | 
 **paymentMethodId** | **int**| The Referred Payment Method Id. | 
 **fields** | **string**| List of comma-separated fields. | [optional] 
 **fieldset** | **string**| Name of the fieldset. | [optional] 

### Return type

[**GetPaymentMethodResponse**](GetPaymentMethodResponse.md)

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

<a name="modifypaymentaccount"></a>
# **ModifyPaymentAccount**
> ModifyPaymentAccountResponse ModifyPaymentAccount (int companyId, string paymentAccountId, ModifyPaymentAccountRequest modifyPaymentAccountRequest = null)

Modify Payment Account

Modifies the specified payment account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ModifyPaymentAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SettingsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var paymentAccountId = 1;  // string | The Referred Payment Account Id.
            var modifyPaymentAccountRequest = new ModifyPaymentAccountRequest(); // ModifyPaymentAccountRequest |  (optional) 

            try
            {
                // Modify Payment Account
                ModifyPaymentAccountResponse result = apiInstance.ModifyPaymentAccount(companyId, paymentAccountId, modifyPaymentAccountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.ModifyPaymentAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **int**| The ID of the company. | 
 **paymentAccountId** | **string**| The Referred Payment Account Id. | 
 **modifyPaymentAccountRequest** | [**ModifyPaymentAccountRequest**](ModifyPaymentAccountRequest.md)|  | [optional] 

### Return type

[**ModifyPaymentAccountResponse**](ModifyPaymentAccountResponse.md)

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

<a name="modifypaymentmethod"></a>
# **ModifyPaymentMethod**
> ModifyPaymentMethodResponse ModifyPaymentMethod (int companyId, int paymentMethodId, ModifyPaymentMethodRequest modifyPaymentMethodRequest = null)

Modify Payment Method

Modifies the specified payment method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ModifyPaymentMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SettingsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var paymentMethodId = 1;  // int | The Referred Payment Method Id.
            var modifyPaymentMethodRequest = new ModifyPaymentMethodRequest(); // ModifyPaymentMethodRequest |  (optional) 

            try
            {
                // Modify Payment Method
                ModifyPaymentMethodResponse result = apiInstance.ModifyPaymentMethod(companyId, paymentMethodId, modifyPaymentMethodRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.ModifyPaymentMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **int**| The ID of the company. | 
 **paymentMethodId** | **int**| The Referred Payment Method Id. | 
 **modifyPaymentMethodRequest** | [**ModifyPaymentMethodRequest**](ModifyPaymentMethodRequest.md)|  | [optional] 

### Return type

[**ModifyPaymentMethodResponse**](ModifyPaymentMethodResponse.md)

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

