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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using SpacePoolMonitor.ApiClient.Client;
using SpacePoolMonitor.ApiClient.Model;

namespace SpacePoolMonitor.ApiClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGetFarmPayoutsV1ApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get recent payout information for a farmer by launcher or alias
        /// </summary>
        /// <exception cref="SpacePoolMonitor.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="launcherIdOrAlias">Launcher id or alias</param>
        /// <param name="developerKey"></param>
        /// <param name="userAgent"></param>
        /// <param name="continuationToken">Continuation token for resuming paging of the previous request (optional)</param>
        /// <returns>PayoutV1ModelPagedCollectionResponseV1Model</returns>
        PayoutV1ModelPagedCollectionResponseV1Model ApiV1FarmsLauncherIdOrAliasPayoutsGet(string launcherIdOrAlias, string developerKey, string userAgent, string continuationToken = default(string));

        /// <summary>
        /// Get recent payout information for a farmer by launcher or alias
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SpacePoolMonitor.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="launcherIdOrAlias">Launcher id or alias</param>
        /// <param name="developerKey"></param>
        /// <param name="userAgent"></param>
        /// <param name="continuationToken">Continuation token for resuming paging of the previous request (optional)</param>
        /// <returns>ApiResponse of PayoutV1ModelPagedCollectionResponseV1Model</returns>
        ApiResponse<PayoutV1ModelPagedCollectionResponseV1Model> ApiV1FarmsLauncherIdOrAliasPayoutsGetWithHttpInfo(string launcherIdOrAlias, string developerKey, string userAgent, string continuationToken = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGetFarmPayoutsV1ApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get recent payout information for a farmer by launcher or alias
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SpacePoolMonitor.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="launcherIdOrAlias">Launcher id or alias</param>
        /// <param name="developerKey"></param>
        /// <param name="userAgent"></param>
        /// <param name="continuationToken">Continuation token for resuming paging of the previous request (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PayoutV1ModelPagedCollectionResponseV1Model</returns>
        System.Threading.Tasks.Task<PayoutV1ModelPagedCollectionResponseV1Model> ApiV1FarmsLauncherIdOrAliasPayoutsGetAsync(string launcherIdOrAlias, string developerKey, string userAgent, string continuationToken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get recent payout information for a farmer by launcher or alias
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SpacePoolMonitor.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="launcherIdOrAlias">Launcher id or alias</param>
        /// <param name="developerKey"></param>
        /// <param name="userAgent"></param>
        /// <param name="continuationToken">Continuation token for resuming paging of the previous request (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PayoutV1ModelPagedCollectionResponseV1Model)</returns>
        System.Threading.Tasks.Task<ApiResponse<PayoutV1ModelPagedCollectionResponseV1Model>> ApiV1FarmsLauncherIdOrAliasPayoutsGetWithHttpInfoAsync(string launcherIdOrAlias, string developerKey, string userAgent, string continuationToken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGetFarmPayoutsV1Api : IGetFarmPayoutsV1ApiSync, IGetFarmPayoutsV1ApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GetFarmPayoutsV1Api : IGetFarmPayoutsV1Api
    {
        private SpacePoolMonitor.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFarmPayoutsV1Api"/> class.
        /// </summary>
        /// <returns></returns>
        public GetFarmPayoutsV1Api() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFarmPayoutsV1Api"/> class.
        /// </summary>
        /// <returns></returns>
        public GetFarmPayoutsV1Api(string basePath)
        {
            this.Configuration = SpacePoolMonitor.ApiClient.Client.Configuration.MergeConfigurations(
                SpacePoolMonitor.ApiClient.Client.GlobalConfiguration.Instance,
                new SpacePoolMonitor.ApiClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new SpacePoolMonitor.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new SpacePoolMonitor.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = SpacePoolMonitor.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFarmPayoutsV1Api"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GetFarmPayoutsV1Api(SpacePoolMonitor.ApiClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = SpacePoolMonitor.ApiClient.Client.Configuration.MergeConfigurations(
                SpacePoolMonitor.ApiClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new SpacePoolMonitor.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new SpacePoolMonitor.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = SpacePoolMonitor.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFarmPayoutsV1Api"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public GetFarmPayoutsV1Api(SpacePoolMonitor.ApiClient.Client.ISynchronousClient client, SpacePoolMonitor.ApiClient.Client.IAsynchronousClient asyncClient, SpacePoolMonitor.ApiClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = SpacePoolMonitor.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public SpacePoolMonitor.ApiClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public SpacePoolMonitor.ApiClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public SpacePoolMonitor.ApiClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public SpacePoolMonitor.ApiClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get recent payout information for a farmer by launcher or alias 
        /// </summary>
        /// <exception cref="SpacePoolMonitor.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="launcherIdOrAlias">Launcher id or alias</param>
        /// <param name="developerKey"></param>
        /// <param name="userAgent"></param>
        /// <param name="continuationToken">Continuation token for resuming paging of the previous request (optional)</param>
        /// <returns>PayoutV1ModelPagedCollectionResponseV1Model</returns>
        public PayoutV1ModelPagedCollectionResponseV1Model ApiV1FarmsLauncherIdOrAliasPayoutsGet(string launcherIdOrAlias, string developerKey, string userAgent, string continuationToken = default(string))
        {
            SpacePoolMonitor.ApiClient.Client.ApiResponse<PayoutV1ModelPagedCollectionResponseV1Model> localVarResponse = ApiV1FarmsLauncherIdOrAliasPayoutsGetWithHttpInfo(launcherIdOrAlias, developerKey, userAgent, continuationToken);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get recent payout information for a farmer by launcher or alias 
        /// </summary>
        /// <exception cref="SpacePoolMonitor.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="launcherIdOrAlias">Launcher id or alias</param>
        /// <param name="developerKey"></param>
        /// <param name="userAgent"></param>
        /// <param name="continuationToken">Continuation token for resuming paging of the previous request (optional)</param>
        /// <returns>ApiResponse of PayoutV1ModelPagedCollectionResponseV1Model</returns>
        public SpacePoolMonitor.ApiClient.Client.ApiResponse<PayoutV1ModelPagedCollectionResponseV1Model> ApiV1FarmsLauncherIdOrAliasPayoutsGetWithHttpInfo(string launcherIdOrAlias, string developerKey, string userAgent, string continuationToken = default(string))
        {
            // verify the required parameter 'launcherIdOrAlias' is set
            if (launcherIdOrAlias == null)
            {
                throw new SpacePoolMonitor.ApiClient.Client.ApiException(400, "Missing required parameter 'launcherIdOrAlias' when calling GetFarmPayoutsV1Api->ApiV1FarmsLauncherIdOrAliasPayoutsGet");
            }

            // verify the required parameter 'developerKey' is set
            if (developerKey == null)
            {
                throw new SpacePoolMonitor.ApiClient.Client.ApiException(400, "Missing required parameter 'developerKey' when calling GetFarmPayoutsV1Api->ApiV1FarmsLauncherIdOrAliasPayoutsGet");
            }

            // verify the required parameter 'userAgent' is set
            if (userAgent == null)
            {
                throw new SpacePoolMonitor.ApiClient.Client.ApiException(400, "Missing required parameter 'userAgent' when calling GetFarmPayoutsV1Api->ApiV1FarmsLauncherIdOrAliasPayoutsGet");
            }

            SpacePoolMonitor.ApiClient.Client.RequestOptions localVarRequestOptions = new SpacePoolMonitor.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = SpacePoolMonitor.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = SpacePoolMonitor.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("launcherIdOrAlias", SpacePoolMonitor.ApiClient.Client.ClientUtils.ParameterToString(launcherIdOrAlias)); // path parameter
            if (continuationToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(SpacePoolMonitor.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "continuationToken", continuationToken));
            }
            localVarRequestOptions.HeaderParameters.Add("Developer-Key", SpacePoolMonitor.ApiClient.Client.ClientUtils.ParameterToString(developerKey)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("User-Agent", SpacePoolMonitor.ApiClient.Client.ClientUtils.ParameterToString(userAgent)); // header parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<PayoutV1ModelPagedCollectionResponseV1Model>("/api/v1/farms/{launcherIdOrAlias}/payouts", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1FarmsLauncherIdOrAliasPayoutsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get recent payout information for a farmer by launcher or alias 
        /// </summary>
        /// <exception cref="SpacePoolMonitor.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="launcherIdOrAlias">Launcher id or alias</param>
        /// <param name="developerKey"></param>
        /// <param name="userAgent"></param>
        /// <param name="continuationToken">Continuation token for resuming paging of the previous request (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PayoutV1ModelPagedCollectionResponseV1Model</returns>
        public async System.Threading.Tasks.Task<PayoutV1ModelPagedCollectionResponseV1Model> ApiV1FarmsLauncherIdOrAliasPayoutsGetAsync(string launcherIdOrAlias, string developerKey, string userAgent, string continuationToken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            SpacePoolMonitor.ApiClient.Client.ApiResponse<PayoutV1ModelPagedCollectionResponseV1Model> localVarResponse = await ApiV1FarmsLauncherIdOrAliasPayoutsGetWithHttpInfoAsync(launcherIdOrAlias, developerKey, userAgent, continuationToken, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get recent payout information for a farmer by launcher or alias 
        /// </summary>
        /// <exception cref="SpacePoolMonitor.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="launcherIdOrAlias">Launcher id or alias</param>
        /// <param name="developerKey"></param>
        /// <param name="userAgent"></param>
        /// <param name="continuationToken">Continuation token for resuming paging of the previous request (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PayoutV1ModelPagedCollectionResponseV1Model)</returns>
        public async System.Threading.Tasks.Task<SpacePoolMonitor.ApiClient.Client.ApiResponse<PayoutV1ModelPagedCollectionResponseV1Model>> ApiV1FarmsLauncherIdOrAliasPayoutsGetWithHttpInfoAsync(string launcherIdOrAlias, string developerKey, string userAgent, string continuationToken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'launcherIdOrAlias' is set
            if (launcherIdOrAlias == null)
            {
                throw new SpacePoolMonitor.ApiClient.Client.ApiException(400, "Missing required parameter 'launcherIdOrAlias' when calling GetFarmPayoutsV1Api->ApiV1FarmsLauncherIdOrAliasPayoutsGet");
            }

            // verify the required parameter 'developerKey' is set
            if (developerKey == null)
            {
                throw new SpacePoolMonitor.ApiClient.Client.ApiException(400, "Missing required parameter 'developerKey' when calling GetFarmPayoutsV1Api->ApiV1FarmsLauncherIdOrAliasPayoutsGet");
            }

            // verify the required parameter 'userAgent' is set
            if (userAgent == null)
            {
                throw new SpacePoolMonitor.ApiClient.Client.ApiException(400, "Missing required parameter 'userAgent' when calling GetFarmPayoutsV1Api->ApiV1FarmsLauncherIdOrAliasPayoutsGet");
            }


            SpacePoolMonitor.ApiClient.Client.RequestOptions localVarRequestOptions = new SpacePoolMonitor.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = SpacePoolMonitor.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = SpacePoolMonitor.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("launcherIdOrAlias", SpacePoolMonitor.ApiClient.Client.ClientUtils.ParameterToString(launcherIdOrAlias)); // path parameter
            if (continuationToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(SpacePoolMonitor.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "continuationToken", continuationToken));
            }
            localVarRequestOptions.HeaderParameters.Add("Developer-Key", SpacePoolMonitor.ApiClient.Client.ClientUtils.ParameterToString(developerKey)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("User-Agent", SpacePoolMonitor.ApiClient.Client.ClientUtils.ParameterToString(userAgent)); // header parameter


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<PayoutV1ModelPagedCollectionResponseV1Model>("/api/v1/farms/{launcherIdOrAlias}/payouts", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1FarmsLauncherIdOrAliasPayoutsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
