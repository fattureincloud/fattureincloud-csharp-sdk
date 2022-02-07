# It.FattureInCloud.Sdk.Model.EmailData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecipientEmail** | **string** | Recipient&#39;s email | [optional] 
**DefaultSenderEmail** | [**EmailDataDefaultSenderEmail**](EmailDataDefaultSenderEmail.md) |  | [optional] 
**SenderEmailsList** | [**List&lt;SenderEmail&gt;**](SenderEmail.md) | List of all emails from which the document can be sent | [optional] 
**CcEmail** | **string** | By default is the logged company email. This is the email address to which a copy will be sent. | [optional] 
**Subject** | **string** | Email subject | [optional] 
**Body** | **string** | Email body | [optional] 
**DocumentExists** | **bool** | If the document is not a delivery note, this flag will be set to true | [optional] 
**DeliveryNoteExists** | **bool** | If the document is a delivery note, this flag will be set to true | [optional] 
**AttachmentExists** | **bool** | If the document has one or more attachments, this flag will be set to true | [optional] 
**AccompanyingInvoiceExists** | **bool** | If an accompanying invoice exists, this flag will be set to true | [optional] 
**DefaultAttachPdf** | **bool** | If a pdf is attached, this flag will be set to true | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

