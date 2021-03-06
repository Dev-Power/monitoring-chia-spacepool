/*
 * Space Pool Developer API
 *
 * Space Pool public developer REST APIs
 *
 * The version of the OpenAPI document: v1
 * Contact: info@pool.space
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using SpacePoolMonitor.ApiClient.Client;
using SpacePoolMonitor.ApiClient.Api;
// uncomment below to import models
//using SpacePoolMonitor.ApiClient.Model;

namespace SpacePoolMonitor.ApiClient.Test.Api
{
    /// <summary>
    ///  Class for testing GetFarmPayoutsV1Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GetFarmPayoutsV1ApiTests : IDisposable
    {
        private GetFarmPayoutsV1Api instance;

        public GetFarmPayoutsV1ApiTests()
        {
            instance = new GetFarmPayoutsV1Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetFarmPayoutsV1Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GetFarmPayoutsV1Api
            //Assert.IsType<GetFarmPayoutsV1Api>(instance);
        }

        /// <summary>
        /// Test ApiV1FarmsLauncherIdOrAliasPayoutsGet
        /// </summary>
        [Fact]
        public void ApiV1FarmsLauncherIdOrAliasPayoutsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string launcherIdOrAlias = null;
            //string developerKey = null;
            //string userAgent = null;
            //string continuationToken = null;
            //var response = instance.ApiV1FarmsLauncherIdOrAliasPayoutsGet(launcherIdOrAlias, developerKey, userAgent, continuationToken);
            //Assert.IsType<PayoutV1ModelPagedCollectionResponseV1Model>(response);
        }
    }
}
