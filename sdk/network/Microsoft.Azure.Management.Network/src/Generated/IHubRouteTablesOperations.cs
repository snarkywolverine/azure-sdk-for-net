// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// HubRouteTablesOperations operations.
    /// </summary>
    public partial interface IHubRouteTablesOperations
    {
        /// <summary>
        /// Creates a RouteTable resource if it doesn't exist else updates the
        /// existing RouteTable.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VirtualHub.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the RouteTable.
        /// </param>
        /// <param name='routeTableParameters'>
        /// Parameters supplied to create or update RouteTable.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<HubRouteTable>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string routeTableName, HubRouteTable routeTableParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves the details of a RouteTable.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VirtualHub.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the RouteTable.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<HubRouteTable>> GetWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string routeTableName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a RouteTable.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the RouteTable.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the RouteTable.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string routeTableName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves the details of all RouteTables.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VirtualHub.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<HubRouteTable>>> ListWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a RouteTable resource if it doesn't exist else updates the
        /// existing RouteTable.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VirtualHub.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the RouteTable.
        /// </param>
        /// <param name='routeTableParameters'>
        /// Parameters supplied to create or update RouteTable.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<HubRouteTable>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string routeTableName, HubRouteTable routeTableParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a RouteTable.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the RouteTable.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the RouteTable.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string routeTableName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves the details of all RouteTables.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<HubRouteTable>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
