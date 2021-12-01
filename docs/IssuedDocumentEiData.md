# It.FattureInCloud.Sdk.Model.IssuedDocumentEiData
E-invoice data. [Only if e_invoice=true]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VatKind** | **VatKind** |  | [optional] 
**OriginalDocumentType** | **OriginalDocumentType** |  | [optional] 
**OdNumber** | **string** | Original document number. | [optional] 
**OdDate** | **DateTime?** | Original document date. | [optional] 
**Cig** | **string** | CIG. | [optional] 
**Cup** | **string** | CUP. | [optional] 
**PaymentMethod** | **string** | Payment method (see https://www.fatturapa.gov.it/export/documenti/fatturapa/v1.2.1/Rappresentazione-tabellare-fattura-ordinaria.pdf for the accepted values of ModalitaPagamento). | [optional] 
**BankName** | **string** | Bank name. | [optional] 
**BankIban** | **string** | IBAN. | [optional] 
**BankBeneficiary** | **string** | Bank beneficiary. | [optional] 
**InvoiceNumber** | **string** | Invoice number. | [optional] 
**InvoiceDate** | **DateTime?** | Invoice date. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

