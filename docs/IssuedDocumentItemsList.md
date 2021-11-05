# It.FattureInCloud.Sdk.Model.IssuedDocumentItemsList

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductId** | **int?** | Unique identifier of the product. | [optional] 
**Code** | **string** | Product code. | [optional] 
**Name** | **string** | Product name. | [optional] 
**Description** | **string** | Product description. | [optional] 
**Qty** | **decimal** | Items quantity, | [optional] 
**Measure** | **string** | Item measure. | [optional] 
**NetPrice** | **decimal** | Net price. | [optional] 
**GrossPrice** | **decimal?** | Gross price. | [optional] 
**Vat** | [**VatType**](VatType.md) |  | [optional] 
**NotTaxable** | **bool** |  | [optional] [default to false]
**ApplyWithholdingTaxes** | **bool** | Apply withholding taxes, rivalsa and cassa. | [optional] [default to true]
**Discount** | **decimal** | Discount percentual value. | [optional] 
**DiscountHighlight** | **bool** |  | [optional] [default to false]
**InDdt** | **bool** |  | [optional] [default to true]
**Stock** | **bool?** |  | [optional] 
**EiRaw** | **Object** | Advanced raw attributes for e-invoices. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

