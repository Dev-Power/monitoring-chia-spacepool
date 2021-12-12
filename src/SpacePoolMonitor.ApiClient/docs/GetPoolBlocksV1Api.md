# SpacePoolMonitor.ApiClient.Api.GetPoolBlocksV1Api

All URIs are relative to *https://developer.pool.space*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1PoolBlocksGet**](GetPoolBlocksV1Api.md#apiv1poolblocksget) | **GET** /api/v1/pool/blocks | Get blocks recently farmed by the pool


<a name="apiv1poolblocksget"></a>
# **ApiV1PoolBlocksGet**
> BlockV1Model ApiV1PoolBlocksGet (string developerKey, string userAgent)

Get blocks recently farmed by the pool

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpacePoolMonitor.ApiClient.Api;
using SpacePoolMonitor.ApiClient.Client;
using SpacePoolMonitor.ApiClient.Model;

namespace Example
{
    public class ApiV1PoolBlocksGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://developer.pool.space";
            var apiInstance = new GetPoolBlocksV1Api(config);
            var developerKey = developerKey_example;  // string | 
            var userAgent = userAgent_example;  // string | 

            try
            {
                // Get blocks recently farmed by the pool
                BlockV1Model result = apiInstance.ApiV1PoolBlocksGet(developerKey, userAgent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GetPoolBlocksV1Api.ApiV1PoolBlocksGet: " + e.Message );
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
 **developerKey** | **string**|  | 
 **userAgent** | **string**|  | 

### Return type

[**BlockV1Model**](BlockV1Model.md)

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

