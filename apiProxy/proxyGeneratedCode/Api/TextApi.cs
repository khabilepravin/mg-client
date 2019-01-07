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
    public interface ITextApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="apiProxy.proxyGeneratedCode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version"></param>
        /// <param name="textIds"> (optional)</param>
        /// <returns></returns>
        void GroupText (string version, List<string> textIds = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="apiProxy.proxyGeneratedCode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version"></param>
        /// <param name="textIds"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GroupTextWithHttpInfo (string version, List<string> textIds = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="apiProxy.proxyGeneratedCode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version"></param>
        /// <param name="textIds"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GroupTextAsync (string version, List<string> textIds = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="apiProxy.proxyGeneratedCode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version"></param>
        /// <param name="textIds"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GroupTextAsyncWithHttpInfo (string version, List<string> textIds = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TextApi : ITextApi
    {
        private apiProxy.proxyGeneratedCode.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TextApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TextApi(String basePath)
        {
            this.Configuration = new apiProxy.proxyGeneratedCode.Client.Configuration { BasePath = basePath };

            ExceptionFactory = apiProxy.proxyGeneratedCode.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TextApi(apiProxy.proxyGeneratedCode.Client.Configuration configuration = null)
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
        /// <param name="version"></param>
        /// <param name="textIds"> (optional)</param>
        /// <returns></returns>
        public void GroupText (string version, List<string> textIds = null)
        {
             GroupTextWithHttpInfo(version, textIds);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="apiProxy.proxyGeneratedCode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version"></param>
        /// <param name="textIds"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GroupTextWithHttpInfo (string version, List<string> textIds = null)
        {
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling TextApi->GroupText");

            var localVarPath = "/api/v{version}/Text/grouptext";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (version != null) localVarPathParams.Add("version", this.Configuration.ApiClient.ParameterToString(version)); // path parameter
            if (textIds != null && textIds.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(textIds); // http body (model) parameter
            }
            else
            {
                localVarPostBody = textIds; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GroupText", localVarResponse);
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
        /// <param name="version"></param>
        /// <param name="textIds"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GroupTextAsync (string version, List<string> textIds = null)
        {
             await GroupTextAsyncWithHttpInfo(version, textIds);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="apiProxy.proxyGeneratedCode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version"></param>
        /// <param name="textIds"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GroupTextAsyncWithHttpInfo (string version, List<string> textIds = null)
        {
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling TextApi->GroupText");

            var localVarPath = "/api/v{version}/Text/grouptext";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (version != null) localVarPathParams.Add("version", this.Configuration.ApiClient.ParameterToString(version)); // path parameter
            if (textIds != null && textIds.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(textIds); // http body (model) parameter
            }
            else
            {
                localVarPostBody = textIds; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GroupText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
