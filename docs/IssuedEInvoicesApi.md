# It.FattureInCloud.Sdk.Api.IssuedEInvoicesApi

All URIs are relative to *https://api-v2.fattureincloud.it*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetEInvoiceRejectionReason**](IssuedEInvoicesApi.md#geteinvoicerejectionreason) | **GET** /c/{company_id}/issued_documents/{document_id}/e_invoice/error_reason | Get E-Invoice Rejection Reason |
| [**GetEInvoiceXml**](IssuedEInvoicesApi.md#geteinvoicexml) | **GET** /c/{company_id}/issued_documents/{document_id}/e_invoice/xml | Get E-Invoice XML |
| [**SendEInvoice**](IssuedEInvoicesApi.md#sendeinvoice) | **POST** /c/{company_id}/issued_documents/{document_id}/e_invoice/send | Send E-Invoice |
| [**VerifyEInvoiceXml**](IssuedEInvoicesApi.md#verifyeinvoicexml) | **GET** /c/{company_id}/issued_documents/{document_id}/e_invoice/xml_verify | Verify E-Invoice XML |

<a id="geteinvoicerejectionreason"></a>
# **GetEInvoiceRejectionReason**
> GetEInvoiceRejectionReasonResponse GetEInvoiceRejectionReason (int companyId, int documentId)

Get E-Invoice Rejection Reason

Get e-invoice rejection reason

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetEInvoiceRejectionReasonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedEInvoicesApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.

            try
            {
                // Get E-Invoice Rejection Reason
                GetEInvoiceRejectionReasonResponse result = apiInstance.GetEInvoiceRejectionReason(companyId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedEInvoicesApi.GetEInvoiceRejectionReason: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEInvoiceRejectionReasonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get E-Invoice Rejection Reason
    ApiResponse<GetEInvoiceRejectionReasonResponse> response = apiInstance.GetEInvoiceRejectionReasonWithHttpInfo(companyId, documentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedEInvoicesApi.GetEInvoiceRejectionReasonWithHttpInfo: " + e.Message);
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

[**GetEInvoiceRejectionReasonResponse**](GetEInvoiceRejectionReasonResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Example response |  * RateLimit-HourlyRemaining -  <br>  * RateLimit-HourlyLimit -  <br>  * RateLimit-MonthlyRemaining -  <br>  * RateLimit-MonthlyLimit -  <br>  |
| **403** | Forbidden - Rate limit exceeded |  * Retry-After -  <br>  |
| **429** | Too Many Requests |  * Retry-After -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="geteinvoicexml"></a>
# **GetEInvoiceXml**
> string GetEInvoiceXml (int companyId, int documentId, bool? includeAttachment = null)

Get E-Invoice XML

Downloads the e-invoice in XML format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class GetEInvoiceXmlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedEInvoicesApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.
            var includeAttachment = true;  // bool? | Include the attachment to the XML e-invoice. (optional) 

            try
            {
                // Get E-Invoice XML
                string result = apiInstance.GetEInvoiceXml(companyId, documentId, includeAttachment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedEInvoicesApi.GetEInvoiceXml: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEInvoiceXmlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get E-Invoice XML
    ApiResponse<string> response = apiInstance.GetEInvoiceXmlWithHttpInfo(companyId, documentId, includeAttachment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedEInvoicesApi.GetEInvoiceXmlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **documentId** | **int** | The ID of the document. |  |
| **includeAttachment** | **bool?** | Include the attachment to the XML e-invoice. | [optional]  |

### Return type

**string**

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * RateLimit-HourlyRemaining -  <br>  * RateLimit-HourlyLimit -  <br>  * RateLimit-MonthlyRemaining -  <br>  * RateLimit-MonthlyLimit -  <br>  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden - Rate limit exceeded |  * Retry-After -  <br>  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  * Retry-After -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sendeinvoice"></a>
# **SendEInvoice**
> SendEInvoiceResponse SendEInvoice (int companyId, int documentId, SendEInvoiceRequest sendEInvoiceRequest = null)

Send E-Invoice

Sends the e-invoice to SDI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class SendEInvoiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedEInvoicesApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.
            var sendEInvoiceRequest = new SendEInvoiceRequest(); // SendEInvoiceRequest |  (optional) 

            try
            {
                // Send E-Invoice
                SendEInvoiceResponse result = apiInstance.SendEInvoice(companyId, documentId, sendEInvoiceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedEInvoicesApi.SendEInvoice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendEInvoiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send E-Invoice
    ApiResponse<SendEInvoiceResponse> response = apiInstance.SendEInvoiceWithHttpInfo(companyId, documentId, sendEInvoiceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedEInvoicesApi.SendEInvoiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **int** | The ID of the company. |  |
| **documentId** | **int** | The ID of the document. |  |
| **sendEInvoiceRequest** | [**SendEInvoiceRequest**](SendEInvoiceRequest.md) |  | [optional]  |

### Return type

[**SendEInvoiceResponse**](SendEInvoiceResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: application/json
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

<a id="verifyeinvoicexml"></a>
# **VerifyEInvoiceXml**
> VerifyEInvoiceXmlResponse VerifyEInvoiceXml (int companyId, int documentId)

Verify E-Invoice XML

Verifies the e-invoice XML format. Checks if all of the mandatory fields are filled and compliant to the right format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using It.FattureInCloud.Sdk.Api;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Model;

namespace Example
{
    public class VerifyEInvoiceXmlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-v2.fattureincloud.it";
            // Configure OAuth2 access token for authorization: OAuth2AuthenticationCodeFlow
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssuedEInvoicesApi(config);
            var companyId = 12345;  // int | The ID of the company.
            var documentId = 56;  // int | The ID of the document.

            try
            {
                // Verify E-Invoice XML
                VerifyEInvoiceXmlResponse result = apiInstance.VerifyEInvoiceXml(companyId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedEInvoicesApi.VerifyEInvoiceXml: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VerifyEInvoiceXmlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Verify E-Invoice XML
    ApiResponse<VerifyEInvoiceXmlResponse> response = apiInstance.VerifyEInvoiceXmlWithHttpInfo(companyId, documentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuedEInvoicesApi.VerifyEInvoiceXmlWithHttpInfo: " + e.Message);
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

[**VerifyEInvoiceXmlResponse**](VerifyEInvoiceXmlResponse.md)

### Authorization

[OAuth2AuthenticationCodeFlow](../README.md#OAuth2AuthenticationCodeFlow)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Example response |  * RateLimit-HourlyRemaining -  <br>  * RateLimit-HourlyLimit -  <br>  * RateLimit-MonthlyRemaining -  <br>  * RateLimit-MonthlyLimit -  <br>  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden - Rate limit exceeded |  * Retry-After -  <br>  |
| **404** | Not Found |  -  |
| **422** | Example response |  * RateLimit-HourlyRemaining -  <br>  * RateLimit-HourlyLimit -  <br>  * RateLimit-MonthlyRemaining -  <br>  * RateLimit-MonthlyLimit -  <br>  |
| **429** | Too Many Requests |  * Retry-After -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

