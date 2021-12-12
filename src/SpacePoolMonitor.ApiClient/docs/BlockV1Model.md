# SpacePoolMonitor.ApiClient.Model.BlockV1Model

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LuckPercent** | **double?** | Percent of how lucky this block reward was compared to expectation from size of the pool, normalized to 1. Less than 1 means the pool was lucky. More than 1 signifies the pool was unlucky. | [optional] 
**BlockNumber** | **long** | Block number that the reward was confirmed on | [optional] 
**RewardInXCH** | **double** | Amount of the block reward, in XCH | [optional] 
**CreationDateTimeUtc** | **string** | Date and time that the block was confirmed on the blockchain | [optional] 
**WinnerLauncherId** | **string** | Launcher id of the winner of the block reward | [optional] 
**Status** | **BlockConfirmationStatusV1** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

