// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading;

using Microsoft.Graph;

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    /// <summary>
    /// The type ItemDeltaRequest.
    /// </summary>
    public partial class ItemDeltaRequest : BaseRequest, IItemDeltaRequest
    {
        /// <summary>
        /// Constructs a new ItemDeltaRequest.
        /// </summary>
        public ItemDeltaRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
            this.Method = "GET";
        }

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        public System.Threading.Tasks.Task<IItemDeltaCollectionPage> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name=""cancellationToken"">The <see cref=""CancellationToken""/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IItemDeltaCollectionPage> GetAsync(
            CancellationToken cancellationToken)
        {
            var response = await this.SendAsync<ItemDeltaCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
            if (response != null && response.Value != null && response.Value.CurrentPage != null)
            {
                if (response.AdditionalData != null)
                {
                    response.Value.AdditionalData = response.AdditionalData;

                    object nextPageLink;
                    response.AdditionalData.TryGetValue("@odata.nextLink", out nextPageLink);

                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        response.Value.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

               response.Value.Token = response.Token;

               response.Value.DeltaLink = response.DeltaLink;

                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IItemDeltaRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IItemDeltaRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IItemDeltaRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IItemDeltaRequest Filter(string value)
        {
            this.QueryOptions.Add(new QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IItemDeltaRequest Skip(int value)
        {
            this.QueryOptions.Add(new QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IItemDeltaRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    }
}
