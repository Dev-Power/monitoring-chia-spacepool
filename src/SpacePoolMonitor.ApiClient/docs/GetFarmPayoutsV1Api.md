# SpacePoolMonitor.ApiClient.Api.GetFarmPayoutsV1Api

All URIs are relative to *https://developer.pool.space*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1FarmsLauncherIdOrAliasPayoutsGet**](GetFarmPayoutsV1Api.md#apiv1farmslauncheridoraliaspayoutsget) | **GET** /api/v1/farms/{launcherIdOrAlias}/payouts | Get recent payout information for a farmer by launcher or alias


<a name="apiv1farmslauncheridoraliaspayoutsget"></a>
# **ApiV1FarmsLauncherIdOrAliasPayoutsGet**
> PayoutV1ModelPagedCollectionResponseV1Model ApiV1FarmsLauncherIdOrAliasPayoutsGet (string launcherIdOrAlias, string developerKey, string userAgent, string continuationToken = null)

Get recent payout information for a farmer by launcher or alias

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpacePoolMonitor.ApiClient.Api;
using SpacePoolMonitor.ApiClient.Client;
using SpacePoolMonitor.ApiClient.Model;

namespace Example
{
    public class ApiV1FarmsLauncherIdOrAliasPayoutsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://developer.pool.space";
            var apiInstance = new GetFarmPayoutsV1Api(config);
            var launcherIdOrAlias = launcherIdOrAlias_example;  // string | Launcher id or alias
            var developerKey = developerKey_example;  // string | 
            var userAgent = userAgent_example;  // string | 
            var continuationToken = continuationToken_example;  // string | Continuation token for resuming paging of the previous request (optional) 

            try
            {
                // Get recent payout information for a farmer by launcher or alias
                PayoutV1ModelPagedCollectionResponseV1Model result = apiInstance.ApiV1FarmsLauncherIdOrAliasPayoutsGet(launcherIdOrAlias, developerKey, userAgent, continuationToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GetFarmPayoutsV1Api.ApiV1FarmsLauncherIdOrAliasPayoutsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **launcherIdOrAlias** | **string**| Launcher id or alias | 
 **developerKey** | **string**|  | 
 **userAgent** | **string**|  | 
 **continuationToken** | **string**| Continuation token for resuming paging of the previous request | [optional] 

### Return type

[**PayoutV1ModelPagedCollectionResponseV1Model**](PayoutV1ModelPagedCollectionResponseV1Model.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

