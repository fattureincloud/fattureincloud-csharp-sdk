# It.FattureInCloud.Sdk.Api.IssuedEInvoicesApi

All URIs are relative to *https://api-v2.fattureincloud.it*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEInvoiceRejectionReason**](IssuedEInvoicesApi.md#geteinvoicerejectionreason) | **GET** /c/{company_id}/issued_documents/{document_id}/e_invoice/error_reason | Get EInvoice rejection reason
[**GetEInvoiceXml**](IssuedEInvoicesApi.md#geteinvoicexml) | **GET** /c/{company_id}/issued_documents/{document_id}/e_invoice/xml | Get e-invoice XML
[**SendEInvoice**](IssuedEInvoicesApi.md#sendeinvoice) | **POST** /c/{company_id}/issued_documents/{document_id}/e_invoice/send | Send the e-invoice
[**VerifyEInvoiceXml**](IssuedEInvoicesApi.md#verifyeinvoicexml) | **GET** /c/{company_id}/issued_documents/{document_id}/e_invoice/xml_verify | Verify e-invoice xml


<a name="geteinvoicerejectionreason"></a>
# **GetEInvoiceRejectionReason**
> GetEInvoiceRejectionReasonResponse GetEInvoiceRejectionReason (int companyId, int documentId)

Get EInvoice rejection reason

Get EInvoice rejection reason

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
                // Get EInvoice rejection reason
                GetEInvoiceRejectionReasonResponse result = apiInstance.GetEInvoiceRejectionReason(companyId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedEInvoicesApi.GetEInvoiceRejectionReason: " + e.Message );
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
 **documentId** | **int**| The ID of the document. | 

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
| **200** | Example response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteinvoicexml"></a>
# **GetEInvoiceXml**
> string GetEInvoiceXml (int companyId, int documentId, bool? includeAttachment = null)

Get e-invoice XML

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
                // Get e-invoice XML
                string result = apiInstance.GetEInvoiceXml(companyId, documentId, includeAttachment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedEInvoicesApi.GetEInvoiceXml: " + e.Message );
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
 **documentId** | **int**| The ID of the document. | 
 **includeAttachment** | **bool?**| Include the attachment to the XML e-invoice. | [optional] 

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
| **200** |  |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendeinvoice"></a>
# **SendEInvoice**
> SendEInvoiceResponse SendEInvoice (int companyId, int documentId, SendEInvoiceRequest sendEInvoiceRequest = null)

Send the e-invoice

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
                // Send the e-invoice
                SendEInvoiceResponse result = apiInstance.SendEInvoice(companyId, documentId, sendEInvoiceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedEInvoicesApi.SendEInvoice: " + e.Message );
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
 **documentId** | **int**| The ID of the document. | 
 **sendEInvoiceRequest** | [**SendEInvoiceRequest**](SendEInvoiceRequest.md)|  | [optional] 

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
| **200** | Example response |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifyeinvoicexml"></a>
# **VerifyEInvoiceXml**
> VerifyEInvoiceXmlResponse VerifyEInvoiceXml (int companyId, int documentId)

Verify e-invoice xml

Verifies the e-invoice xml format. Checks if all of the mandatory fields are filled and compliant to the right format.

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
                // Verify e-invoice xml
                VerifyEInvoiceXmlResponse result = apiInstance.VerifyEInvoiceXml(companyId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuedEInvoicesApi.VerifyEInvoiceXml: " + e.Message );
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
 **documentId** | **int**| The ID of the document. | 

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
| **200** | Example response |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **422** | Example response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

