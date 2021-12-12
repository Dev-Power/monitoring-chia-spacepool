# SpacePoolMonitor.ApiClient.Model.PayoutV1Model

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LauncherId** | **string** | Launcher id that the payout was made to | [optional] 
**CoinId** | **string** | Coin id related to the payout transaction | [optional] 
**ConfirmationBlockNumber** | **long** | Block number that the payout was confirmed under | [optional] 
**FeeInXCH** | **double** | Block-chain transaction fee for the payout, in XCH | [optional] 
**PayoutBalanceInXCH** | **double** | Amount that was paid out in this payout transaction, in XCH | [optional] 
**PayoutDateTimeUtc** | **string** | Date and time the payout was created | [optional] 
**RecipientPuzzleHash** | **string** | Puzzle hash of the recipient of the payout | [optional] 
**Status** | **PayoutStatusV1** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

