# It.FattureInCloud.Sdk.Model.Product

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique identifier. | [optional] 
**Name** | **string** | Product name. | [optional] 
**Code** | **string** | Product code. | [optional] 
**NetPrice** | **decimal?** | Net sale price (used if use_gross_price is false, otherwise it&#39;s competed automatically). | [optional] 
**GrossPrice** | **decimal?** | Gross sale price (used if use_gross_price is false, otherwise it&#39;s competed automatically). | [optional] 
**UseGrossPrice** | **bool?** | Determine which price to use for calculations. | [optional] 
**DefaultVat** | [**VatType**](VatType.md) |  | [optional] 
**NetCost** | **decimal?** | Net cost of the product (used for received documents). | [optional] 
**Measure** | **string** | Unit of measure. | [optional] 
**Description** | **string** | Product description. | [optional] 
**Category** | **string** | Product category. | [optional] 
**Notes** | **string** | Extra notes. | [optional] 
**InStock** | **bool?** | Determine if the product is in stock. | [optional] 
**StockInitial** | **decimal?** | Product initial stock. | [optional] 
**StockCurrent** | **decimal?** | [Read Only] Product current stock. | [optional] [readonly] 
**AverageCost** | **decimal?** | Product average cost. | [optional] 
**AveragePrice** | **decimal?** | Product average price. | [optional] 
**CreatedAt** | **string** |  | [optional] 
**UpdatedAt** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

