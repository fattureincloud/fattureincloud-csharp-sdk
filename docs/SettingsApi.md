# It.FattureInCloud.Sdk.Api.SettingsApi

All URIs are relative to *https://api-v2.fattureincloud.it*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePaymentAccount**](SettingsApi.md#createpaymentaccount) | **POST** /c/{company_id}/settings/payment_accounts | Create Payment Account |
| [**CreatePaymentMethod**](SettingsApi.md#createpaymentmethod) | **POST** /c/{company_id}/settings/payment_methods | Create Payment Method |
| [**CreateVatType**](SettingsApi.md#createvattype) | **POST** /c/{company_id}/settings/vat_types | Create Vat Type |
| [**DeletePaymentAccount**](SettingsApi.md#deletepaymentaccount) | **DELETE** /c/{company_id}/settings/payment_accounts/{payment_account_id} | Delete Payment Account |
| [**DeletePaymentMethod**](SettingsApi.md#deletepaymentmethod) | **DELETE** /c/{company_id}/settings/payment_methods/{payment_method_id} | Delete Payment Method |
| [**DeleteVatType**](SettingsApi.md#deletevattype) | **DELETE** /c/{company_id}/settings/vat_types/{vat_type_id} | Delete Vat Type |
| [**GetPaymentAccount**](SettingsApi.md#getpaymentaccount) | **GET** /c/{company_id}/settings/payment_accounts/{payment_account_id} | Get Payment Account |
| [**GetPaymentMethod**](SettingsApi.md#getpaymentmethod) | **GET** /c/{company_id}/settings/payment_methods/{payment_method_id} | Get Payment Method |
| [**GetVatType**](SettingsApi.md#getvattype) | **GET** /c/{company_id}/settings/vat_types/{vat_type_id} | Get Vat Type |
| [**ModifyPaymentAccount**](SettingsApi.md#modifypaymentaccount) | **PUT** /c/{company_id}/settings/payment_accounts/{payment_account_id} | Modify Payment Account |
| [**ModifyPaymentMethod**](SettingsApi.md#modifypaymentmethod) | **PUT** /c/{company_id}/settings/payment_methods/{payment_method_id} | Modify Payment Method |
| [**ModifyVatType**](SettingsApi.md#modifyvattype) | **PUT** /c/{company_id}/settings/vat_types/{vat_type_id} | Modify Vat Type |

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
                Debug.Print("Exception when calling SettingsApi.CreatePaymentAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePaymentAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Payment Account
    ApiResponse<CreatePaymentAccountResponse> response = apiInstance.CreatePaymentAccountWithHttpInfo(companyId, createPaymentAccountRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.CreatePaymentAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **createPaymentAccountRequest** | [**CreatePaymentAccountRequest**](CreatePaymentAccountRequest.md) |  | [optional]  |

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
                Debug.Print("Exception when calling SettingsApi.CreatePaymentMethod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePaymentMethodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Payment Method
    ApiResponse<CreatePaymentMethodResponse> response = apiInstance.CreatePaymentMethodWithHttpInfo(companyId, createPaymentMethodRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.CreatePaymentMethodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **createPaymentMethodRequest** | [**CreatePaymentMethodRequest**](CreatePaymentMethodRequest.md) |  | [optional]  |

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

<a name="createvattype"></a>
# **CreateVatType**
> CreateVatTypeResponse CreateVatType (int companyId, CreateVatTypeRequest createVatTypeRequest = null)

Create Vat Type

Creates a vat type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class CreateVatTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SettingsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var createVatTypeRequest = new CreateVatTypeRequest(); // CreateVatTypeRequest |  (optional) 

            try
            {
                // Create Vat Type
                CreateVatTypeResponse result = apiInstance.CreateVatType(companyId, createVatTypeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.CreateVatType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateVatTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Vat Type
    ApiResponse<CreateVatTypeResponse> response = apiInstance.CreateVatTypeWithHttpInfo(companyId, createVatTypeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.CreateVatTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **createVatTypeRequest** | [**CreateVatTypeRequest**](CreateVatTypeRequest.md) |  | [optional]  |

### Return type

[**CreateVatTypeResponse**](CreateVatTypeResponse.md)

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
> void DeletePaymentAccount (int companyId, int paymentAccountId)

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
            var paymentAccountId = 56;  // int | The Referred Payment Account Id.

            try
            {
                // Delete Payment Account
                apiInstance.DeletePaymentAccount(companyId, paymentAccountId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.DeletePaymentAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePaymentAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Payment Account
    apiInstance.DeletePaymentAccountWithHttpInfo(companyId, paymentAccountId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.DeletePaymentAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **paymentAccountId** | **int** | The Referred Payment Account Id. |  |

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
            var paymentMethodId = 56;  // int | The Referred Payment Method Id.

            try
            {
                // Delete Payment Method
                apiInstance.DeletePaymentMethod(companyId, paymentMethodId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.DeletePaymentMethod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePaymentMethodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Payment Method
    apiInstance.DeletePaymentMethodWithHttpInfo(companyId, paymentMethodId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.DeletePaymentMethodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **paymentMethodId** | **int** | The Referred Payment Method Id. |  |

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

<a name="deletevattype"></a>
# **DeleteVatType**
> void DeleteVatType (int companyId, int vatTypeId)

Delete Vat Type

Deletes the specified vat type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class DeleteVatTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SettingsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var vatTypeId = 56;  // int | The Referred Vat Type Id.

            try
            {
                // Delete Vat Type
                apiInstance.DeleteVatType(companyId, vatTypeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.DeleteVatType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteVatTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Vat Type
    apiInstance.DeleteVatTypeWithHttpInfo(companyId, vatTypeId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.DeleteVatTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **vatTypeId** | **int** | The Referred Vat Type Id. |  |

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
> GetPaymentAccountResponse GetPaymentAccount (int companyId, int paymentAccountId, string fields = null, string fieldset = null)

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
            var paymentAccountId = 56;  // int | The Referred Payment Account Id.
            var fields = "fields_example";  // string | List of comma-separated fields. (optional) 
            var fieldset = "basic";  // string | Name of the fieldset. (optional) 

            try
            {
                // Get Payment Account
                GetPaymentAccountResponse result = apiInstance.GetPaymentAccount(companyId, paymentAccountId, fields, fieldset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetPaymentAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPaymentAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Payment Account
    ApiResponse<GetPaymentAccountResponse> response = apiInstance.GetPaymentAccountWithHttpInfo(companyId, paymentAccountId, fields, fieldset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetPaymentAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **paymentAccountId** | **int** | The Referred Payment Account Id. |  |
| **fields** | **string** | List of comma-separated fields. | [optional]  |
| **fieldset** | **string** | Name of the fieldset. | [optional]  |

### Return type

[**GetPaymentAccountResponse**](GetPaymentAccountResponse.md)

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
            var paymentMethodId = 56;  // int | The Referred Payment Method Id.
            var fields = "fields_example";  // string | List of comma-separated fields. (optional) 
            var fieldset = "basic";  // string | Name of the fieldset. (optional) 

            try
            {
                // Get Payment Method
                GetPaymentMethodResponse result = apiInstance.GetPaymentMethod(companyId, paymentMethodId, fields, fieldset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetPaymentMethod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPaymentMethodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Payment Method
    ApiResponse<GetPaymentMethodResponse> response = apiInstance.GetPaymentMethodWithHttpInfo(companyId, paymentMethodId, fields, fieldset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetPaymentMethodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **paymentMethodId** | **int** | The Referred Payment Method Id. |  |
| **fields** | **string** | List of comma-separated fields. | [optional]  |
| **fieldset** | **string** | Name of the fieldset. | [optional]  |

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

<a name="getvattype"></a>
# **GetVatType**
> GetVatTypeResponse GetVatType (int companyId, int vatTypeId)

Get Vat Type

Gets the specified vat type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetVatTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SettingsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var vatTypeId = 56;  // int | The Referred Vat Type Id.

            try
            {
                // Get Vat Type
                GetVatTypeResponse result = apiInstance.GetVatType(companyId, vatTypeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetVatType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVatTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Vat Type
    ApiResponse<GetVatTypeResponse> response = apiInstance.GetVatTypeWithHttpInfo(companyId, vatTypeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetVatTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **vatTypeId** | **int** | The Referred Vat Type Id. |  |

### Return type

[**GetVatTypeResponse**](GetVatTypeResponse.md)

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
> ModifyPaymentAccountResponse ModifyPaymentAccount (int companyId, int paymentAccountId, ModifyPaymentAccountRequest modifyPaymentAccountRequest = null)

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
            var paymentAccountId = 56;  // int | The Referred Payment Account Id.
            var modifyPaymentAccountRequest = new ModifyPaymentAccountRequest(); // ModifyPaymentAccountRequest |  (optional) 

            try
            {
                // Modify Payment Account
                ModifyPaymentAccountResponse result = apiInstance.ModifyPaymentAccount(companyId, paymentAccountId, modifyPaymentAccountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.ModifyPaymentAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModifyPaymentAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Modify Payment Account
    ApiResponse<ModifyPaymentAccountResponse> response = apiInstance.ModifyPaymentAccountWithHttpInfo(companyId, paymentAccountId, modifyPaymentAccountRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.ModifyPaymentAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **paymentAccountId** | **int** | The Referred Payment Account Id. |  |
| **modifyPaymentAccountRequest** | [**ModifyPaymentAccountRequest**](ModifyPaymentAccountRequest.md) |  | [optional]  |

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
            var paymentMethodId = 56;  // int | The Referred Payment Method Id.
            var modifyPaymentMethodRequest = new ModifyPaymentMethodRequest(); // ModifyPaymentMethodRequest |  (optional) 

            try
            {
                // Modify Payment Method
                ModifyPaymentMethodResponse result = apiInstance.ModifyPaymentMethod(companyId, paymentMethodId, modifyPaymentMethodRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.ModifyPaymentMethod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModifyPaymentMethodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Modify Payment Method
    ApiResponse<ModifyPaymentMethodResponse> response = apiInstance.ModifyPaymentMethodWithHttpInfo(companyId, paymentMethodId, modifyPaymentMethodRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.ModifyPaymentMethodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **paymentMethodId** | **int** | The Referred Payment Method Id. |  |
| **modifyPaymentMethodRequest** | [**ModifyPaymentMethodRequest**](ModifyPaymentMethodRequest.md) |  | [optional]  |

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

<a name="modifyvattype"></a>
# **ModifyVatType**
> ModifyVatTypeResponse ModifyVatType (int companyId, int vatTypeId, ModifyVatTypeRequest modifyVatTypeRequest = null)

Modify Vat Type

Modifies the specified vat type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class ModifyVatTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SettingsApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var vatTypeId = 56;  // int | The Referred Vat Type Id.
            var modifyVatTypeRequest = new ModifyVatTypeRequest(); // ModifyVatTypeRequest |  (optional) 

            try
            {
                // Modify Vat Type
                ModifyVatTypeResponse result = apiInstance.ModifyVatType(companyId, vatTypeId, modifyVatTypeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.ModifyVatType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModifyVatTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Modify Vat Type
    ApiResponse<ModifyVatTypeResponse> response = apiInstance.ModifyVatTypeWithHttpInfo(companyId, vatTypeId, modifyVatTypeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.ModifyVatTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **vatTypeId** | **int** | The Referred Vat Type Id. |  |
| **modifyVatTypeRequest** | [**ModifyVatTypeRequest**](ModifyVatTypeRequest.md) |  | [optional]  |

### Return type

[**ModifyVatTypeResponse**](ModifyVatTypeResponse.md)

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

