# It.FattureInCloud.Sdk.Model.ReceivedDocument

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique identifier of the document. | [optional] 
**Type** | **ReceivedDocumentType** |  | [optional] 
**Entity** | [**ReceivedDocumentEntity**](ReceivedDocumentEntity.md) |  | [optional] 
**Date** | **DateTime?** | Date of the document [If not specified, today date is used]. | [optional] 
**Category** | **string** | Document category. | [optional] 
**Description** | **string** | Document description. | [optional] 
**AmountNet** | **decimal?** | Total net amount. | [optional] 
**AmountVat** | **decimal?** | Total vat amount. | [optional] 
**AmountWithholdingTax** | **decimal?** | Withholding tax amount. | [optional] 
**AmountOtherWithholdingTax** | **decimal?** | Other withholding tax amount. | [optional] 
**AmountGross** | **decimal?** | [Read Only] Total gross amount. | [optional] [readonly] 
**Amortization** | **decimal?** | Amortization value | [optional] 
**RcCenter** | **string** | Revenue center. | [optional] 
**InvoiceNumber** | **string** | Invoice number | [optional] 
**IsMarked** | **bool?** |  | [optional] 
**IsDetailed** | **bool?** |  | [optional] 
**EInvoice** | **bool?** | [Read Only] Indicates if this is an e-invoice. | [optional] 
**NextDueDate** | **DateTime?** | [Read Only] Next due date. | [optional] [readonly] 
**Currency** | [**Currency**](Currency.md) |  | [optional] 
**TaxDeductibility** | **decimal?** | Tax deducibility percentage. | [optional] 
**VatDeductibility** | **decimal?** | Vat deducibility percentage. | [optional] 
**ItemsList** | [**List&lt;ReceivedDocumentItemsListItem&gt;**](ReceivedDocumentItemsListItem.md) |  | [optional] 
**PaymentsList** | [**List&lt;ReceivedDocumentPaymentsListItem&gt;**](ReceivedDocumentPaymentsListItem.md) |  | [optional] 
**AttachmentUrl** | **string** | [Temporary] [Read Only]  Public url of the attached file. Authomatically set if a valid attachment token is passed via POST /received_documents or PUT /received_documents/{documentId}. | [optional] [readonly] 
**AttachmentPreviewUrl** | **string** | [Temporary] [Read Only]  Attachment preview url. | [optional] [readonly] 
**AttachmentToken** | **string** | Uploaded attachement token. | [optional] 
**CreatedAt** | **string** |  | [optional] 
**UpdatedAt** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

