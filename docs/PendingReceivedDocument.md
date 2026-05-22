# It.FattureInCloud.Sdk.Model.PendingReceivedDocument

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Pending received document id | [optional] 
**Date** | **DateTime?** | Pending received document date | [optional] 
**Subject** | **string** | Pending received document subject | [optional] 
**Filename** | **string** | Pending received document filename | [optional] 
**Type** | **PendingReceivedDocumentType** |  | [optional] 
**AttachmentUrl** | **string** | [Temporary] [Read Only] Pending received document url of the attached file | [optional] [readonly] 
**AmountGross** | **decimal?** | [Read Only] Pending received document total gross amount | [optional] [readonly] 
**Currency** | [**Currency**](Currency.md) |  | [optional] 
**DocumentType** | **ReceivedDocumentType** |  | [optional] 
**SupplierName** | **string** | Pending received document supplier name | [optional] 
**CostCenter** | **string** | Pending received document cost center | [optional] 
**Category** | **string** | Pending received document category | [optional] 
**OtherAttachments** | [**List&lt;Attachment&gt;**](Attachment.md) | Pending received document other attachments | [optional] 
**EmssionDate** | **DateTime?** | Pending received document emission date | [optional] 
**PaymentsList** | [**List&lt;PendingReceivedDocumentPaymentsListItem&gt;**](PendingReceivedDocumentPaymentsListItem.md) |  | [optional] 
**AmountNet** | **decimal?** | Pending received document total net amount | [optional] 
**AmountVat** | **decimal?** | Pending received document total vat amount | [optional] 
**ImportError** | **string** | Pending received document import error | [optional] 
**ExtractedData** | [**PendingReceivedDocumentExtractedData**](PendingReceivedDocumentExtractedData.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

