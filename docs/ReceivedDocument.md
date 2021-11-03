# It.FattureInCloud.Sdk.Model.ReceivedDocument

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier of the document. | [optional] 
**Type** | **ReceivedDocumentType** |  | [optional] 
**Entity** | [**ReceivedDocumentEntity**](ReceivedDocumentEntity.md) |  | [optional] 
**Date** | **DateTimeOffset** | Date of the document [If not specified, today date is used]. | [optional] 
**Category** | **string** | Document category. | [optional] 
**Description** | **string** | Document description. | [optional] 
**AmountNet** | **decimal** | Total net amount. | [optional] 
**AmountVat** | **decimal** | Total vat amount. | [optional] 
**AmountWithholdingTax** | **decimal** | Withholding tax amount. | [optional] 
**AmountOtherWithholdingTax** | **decimal** | Other withholding tax amount. | [optional] 
**AmountGross** | **decimal** | [Read Only] Total gross amount. | [optional] [readonly] 
**Amortization** | **decimal** | Amortization value | [optional] 
**RcCenter** | **string** | Revenue center. | [optional] 
**InvoiceNumber** | **string** | Invoice number | [optional] 
**IsMarked** | **bool** |  | [optional] 
**IsDetailed** | **bool** |  | [optional] 
**EInvoice** | **bool** | [Read Only] Indicates if this is an e-invoice. | [optional] 
**NextDueDate** | **DateTime?** | [Read Only] Next due date. | [optional] [readonly] 
**Currency** | [**Currency**](Currency.md) |  | [optional] 
**TaxDeductibility** | **decimal** | Tax deducibility percentage. | [optional] 
**VatDeductibility** | **decimal** | Vat deducibility percentage. | [optional] 
**ItemsList** | [**List&lt;ReceivedDocumentItemsList&gt;**](ReceivedDocumentItemsList.md) |  | [optional] 
**PaymentsList** | [**List&lt;ReceivedDocumentPaymentsList&gt;**](ReceivedDocumentPaymentsList.md) |  | [optional] 
**AttachmentUrl** | **string** | [Read Only] Attachment url. | [optional] [readonly] 
**AttachmentPreviewUrl** | **string** | [Read Only] Attachment preview url. | [optional] [readonly] 
**AttachmentToken** | **string** | Uploaded attachement token. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

