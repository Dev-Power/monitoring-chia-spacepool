# SpacePoolMonitor.ApiClient.Api.GetPoolInfoV1Api

All URIs are relative to *https://developer.pool.space*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1PoolGet**](GetPoolInfoV1Api.md#apiv1poolget) | **GET** /api/v1/pool | Get latest statistics about the pool


<a name="apiv1poolget"></a>
# **ApiV1PoolGet**
> PoolInfoV1Response ApiV1PoolGet (string developerKey, string userAgent)

Get latest statistics about the pool

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SpacePoolMonitor.ApiClient.Api;
using SpacePoolMonitor.ApiClient.Client;
using SpacePoolMonitor.ApiClient.Model;

namespace Example
{
    public class ApiV1PoolGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://developer.pool.space";
            var apiInstance = new GetPoolInfoV1Api(config);
            var developerKey = developerKey_example;  // string | 
            var userAgent = userAgent_example;  // string | 

            try
            {
                // Get latest statistics about the pool
                PoolInfoV1Response result = apiInstance.ApiV1PoolGet(developerKey, userAgent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GetPoolInfoV1Api.ApiV1PoolGet: " + e.Message );
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

[**PoolInfoV1Response**](PoolInfoV1Response.md)

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

