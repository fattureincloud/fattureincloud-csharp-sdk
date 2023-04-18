# It.FattureInCloud.Sdk.Model.EmailSchedule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SenderId** | **int?** | Sender id. Required if &#x60;sender_email&#x60; is not specified | [optional] 
**SenderEmail** | **string** | Sender email. Required if &#x60;sender_id&#x60; is not specified | [optional] 
**RecipientEmail** | **string** | One or more comma separated recipient emails | [optional] 
**Subject** | **string** | Email subject | [optional] 
**Body** | **string** | Email body [HTML Escaped] [max size 50KiB] | [optional] 
**Include** | [**EmailScheduleInclude**](EmailScheduleInclude.md) |  | [optional] 
**AttachPdf** | **bool?** | If set to true, documents will be sent as PDF attachments too | [optional] 
**SendCopy** | **bool?** | If set to true, a copy of the email will be sent to the &#x60;cc_email&#x60; specified by &#x60;Get email data&#x60; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

