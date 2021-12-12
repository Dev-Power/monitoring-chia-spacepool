# SpacePoolMonitor.ApiClient.Api.GetFarmRewardsV1Api

All URIs are relative to *https://developer.pool.space*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1FarmsLauncherIdOrAliasRewardsGet**](GetFarmRewardsV1Api.md#apiv1farmslauncheridoraliasrewardsget) | **GET** /api/v1/farms/{launcherIdOrAlias}/rewards | Get recent reward information for a farmer by launcher or alias


<a name="apiv1farmslauncheridoraliasrewardsget"></a>
# **ApiV1FarmsLauncherIdOrAliasRewardsGet**
> RewardV1ModelCollectionResponseV1Model ApiV1FarmsLauncherIdOrAliasRewardsGet (string launcherIdOrAlias, string developerKey, string userAgent)

Get recent reward information for a farmer by launcher or alias

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpacePoolMonitor.ApiClient.Api;
using SpacePoolMonitor.ApiClient.Client;
using SpacePoolMonitor.ApiClient.Model;

namespace Example
{
    public class ApiV1FarmsLauncherIdOrAliasRewardsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://developer.pool.space";
            var apiInstance = new GetFarmRewardsV1Api(config);
            var launcherIdOrAlias = launcherIdOrAlias_example;  // string | Launcher id or alias
            var developerKey = developerKey_example;  // string | 
            var userAgent = userAgent_example;  // string | 

            try
            {
                // Get recent reward information for a farmer by launcher or alias
                RewardV1ModelCollectionResponseV1Model result = apiInstance.ApiV1FarmsLauncherIdOrAliasRewardsGet(launcherIdOrAlias, developerKey, userAgent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GetFarmRewardsV1Api.ApiV1FarmsLauncherIdOrAliasRewardsGet: " + e.Message );
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

### Return type

[**RewardV1ModelCollectionResponseV1Model**](RewardV1ModelCollectionResponseV1Model.md)

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

