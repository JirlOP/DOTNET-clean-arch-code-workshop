// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace UCR.ECCI.IS.EvaluacionTecnica.Infrastructure.ApiClient.Client.AddContenidoCarrera {
    /// <summary>
    /// Builds and executes requests for operations under \add-contenido-carrera
    /// </summary>
    public class AddContenidoCarreraRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="AddContenidoCarreraRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AddContenidoCarreraRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/add-contenido-carrera?acronimo={acronimo}&codigo={codigo}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="AddContenidoCarreraRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AddContenidoCarreraRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/add-contenido-carrera?acronimo={acronimo}&codigo={codigo}", rawUrl)
        {
        }
        /// <returns>A <see cref="bool"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<bool?> PutAsync(Action<RequestConfiguration<AddContenidoCarreraRequestBuilderPutQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<bool?> PutAsync(Action<RequestConfiguration<AddContenidoCarreraRequestBuilderPutQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPutRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<bool?>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<AddContenidoCarreraRequestBuilderPutQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<AddContenidoCarreraRequestBuilderPutQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="AddContenidoCarreraRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AddContenidoCarreraRequestBuilder WithUrl(string rawUrl)
        {
            return new AddContenidoCarreraRequestBuilder(rawUrl, RequestAdapter);
        }
        #pragma warning disable CS1591
        public class AddContenidoCarreraRequestBuilderPutQueryParameters 
        #pragma warning restore CS1591
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("acronimo")]
            public string? Acronimo { get; set; }
#nullable restore
#else
            [QueryParameter("acronimo")]
            public string Acronimo { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("codigo")]
            public string? Codigo { get; set; }
#nullable restore
#else
            [QueryParameter("codigo")]
            public string Codigo { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class AddContenidoCarreraRequestBuilderPutRequestConfiguration : RequestConfiguration<AddContenidoCarreraRequestBuilderPutQueryParameters> 
        {
        }
    }
}
