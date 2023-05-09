# It.FattureInCloud.Sdk.Model.Email

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Email unique identifier. | [optional] 
**Status** | **EmailStatus** |  | [optional] 
**SentDate** | **DateTimeOffset?** | Email sent date. | [optional] 
**ErrorsCount** | **int?** | Errors count. | [optional] 
**ErrorLog** | **string** | Error log. | [optional] 
**FromEmail** | **string** | Sender email. | [optional] 
**FromName** | **string** | Sender name. | [optional] 
**ToEmail** | **string** | Recipient email. | [optional] 
**ToName** | **string** | Receipient email. | [optional] 
**Subject** | **string** | Email subject. | [optional] 
**Content** | **string** | Email content. | [optional] 
**CopyTo** | **string** |  | [optional] 
**RecipientStatus** | **EmailRecipientStatus** |  | [optional] 
**RecipientDate** | **DateTimeOffset?** |  | [optional] 
**Kind** | **string** | Email kind. | [optional] 
**Attachments** | [**List&lt;EmailAttachment&gt;**](EmailAttachment.md) | Email attachments. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

