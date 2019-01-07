/* 
 * MovieGrep API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using apiProxy.proxyGeneratedCode.Client;

namespace apiProxy.proxyGeneratedCode.API
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="apiProxy.proxyGeneratedCode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText"></param>
        /// <param name="version"></param>
        /// <param name="titleId"> (optional)</param>
        /// <returns></returns>
        void Search (string searchText, string version, string titleId = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="apiProxy.proxyGeneratedCode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText"></param>
        /// <param name="version"></param>
        /// <param name="titleId"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SearchWithHttpInfo (string searchText, string version, string titleId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="apiProxy.proxyGeneratedCode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText"></param>
        /// <param name="version"></param>
        /// <param name="titleId"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SearchAsync (string searchText, string version, string titleId = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="apiProxy.proxyGeneratedCode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText"></param>
        /// <param name="version"></param>
        /// <param name="titleId"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SearchAsyncWithHttpInfo (string searchText, string version, string titleId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SearchApi : ISearchApi
    {
        private apiProxy.proxyGeneratedCode.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchApi(String basePath)
        {
            this.Configuration = new apiProxy.proxyGeneratedCode.Client.Configuration { BasePath = basePath };

            ExceptionFactory = apiProxy.proxyGeneratedCode.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SearchApi(apiProxy.proxyGeneratedCode.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = apiProxy.proxyGeneratedCode.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = apiProxy.proxyGeneratedCode.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public apiProxy.proxyGeneratedCode.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public apiProxy.proxyGeneratedCode.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="apiProxy.proxyGeneratedCode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText"></param>
        /// <param name="version"></param>
        /// <param name="titleId"> (optional)</param>
        /// <returns></returns>
        public void Search (string searchText, string version, string titleId = null)
        {
             SearchWithHttpInfo(searchText, version, titleId);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="apiProxy.proxyGeneratedCode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText"></param>
        /// <param name="version"></param>
        /// <param name="titleId"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SearchWithHttpInfo (string searchText, string version, string titleId = null)
        {
            // verify the required parameter 'searchText' is set
            if (searchText == null)
                throw new ApiException(400, "Missing required parameter 'searchText' when calling SearchApi->Search");
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling SearchApi->Search");

            var localVarPath = "/api/v{version}/Search/{searchText}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchText != null) localVarPathParams.Add("searchText", this.Configuration.ApiClient.ParameterToString(searchText)); // path parameter
            if (version != null) localVarPathParams.Add("version", this.Configuration.ApiClient.ParameterToString(version)); // path parameter
            if (titleId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "titleId", titleId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="apiProxy.proxyGeneratedCode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText"></param>
        /// <param name="version"></param>
        /// <param name="titleId"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SearchAsync (string searchText, string version, string titleId = null)
        {
             await SearchAsyncWithHttpInfo(searchText, version, titleId);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="apiProxy.proxyGeneratedCode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText"></param>
        /// <param name="version"></param>
        /// <param name="titleId"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SearchAsyncWithHttpInfo (string searchText, string version, string titleId = null)
        {
            // verify the required parameter 'searchText' is set
            if (searchText == null)
                throw new ApiException(400, "Missing required parameter 'searchText' when calling SearchApi->Search");
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling SearchApi->Search");

            var localVarPath = "/api/v{version}/Search/{searchText}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchText != null) localVarPathParams.Add("searchText", this.Configuration.ApiClient.ParameterToString(searchText)); // path parameter
            if (version != null) localVarPathParams.Add("version", this.Configuration.ApiClient.ParameterToString(version)); // path parameter
            if (titleId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "titleId", titleId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
