# SpacePoolMonitor.ApiClient.Model.FarmV1Model

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LauncherId** | **string** | Launcher id of the farm | [optional] 
**UnpaidBalanceInXCH** | **double?** | Unpaid balance of the farm account, in XCH | [optional] 
**TotalPaidInXCH** | **double?** | Total lifetime paid balance to the farm account, in XCH | [optional] 
**BlocksFound** | **int?** | Number of blocks found by the farm | [optional] 
**EstimatedPlotSizeTiB** | **double?** | Estimated size of the farm, in TiB | [optional] 
**EstimatedPlots** | **int?** | Estimated number of plots in the farm | [optional] 
**TenureDateTimeUtc** | **string** | Tenure date (most recent join date) for the farm, used for fee discount reward program | [optional] 
**PendingPoints** | **double?** | Pending points for the farm in the current PPLNS window | [optional] 
**AccountDisplayName** | **string** | Display name (or alias) of the farm, if set | [optional] 
**Rank** | **int?** | Rank # of the farm out of total active farms in the pool | [optional] 
**Difficulty** | **long?** | The current difficulty the farm is using to find partial proofs with the pool | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

