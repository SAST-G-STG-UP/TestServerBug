﻿namespace net.openstack.Providers.Rackspace.Objects.LoadBalancers
{
    using System;
    using System.Collections.Concurrent;
    using net.openstack.Core;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents a node service event category.
    /// </summary>
    /// <remarks>
    /// This class functions as a strongly-typed enumeration of known categories,
    /// with added support for unknown categories returned by a server extension.
    /// </remarks>
    /// <seealso cref="NodeServiceEvent.Category"/>
    /// <seealso href="http://docs.rackspace.com/loadbalancers/api/v1.0/clb-devguide/content/Node-Events-d1e264.html">View Node Service Events (Rackspace Cloud Load Balancers Developer Guide - API v1.0)</seealso>
    /// <threadsafety static="true" instance="false"/>
    /// <preliminary/>
    [JsonConverter(typeof(NodeServiceEventCategory.Converter))]
    public sealed class NodeServiceEventCategory : ExtensibleEnum<NodeServiceEventCategory>
    {
        private static readonly ConcurrentDictionary<string, NodeServiceEventCategory> _types =
            new ConcurrentDictionary<string, NodeServiceEventCategory>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeServiceEventCategory"/> class with the specified name.
        /// </summary>
        /// <inheritdoc/>
        private NodeServiceEventCategory(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Gets the <see cref="NodeServiceEventCategory"/> instance with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>The unique <see cref="NodeServiceEventCategory"/> instance with the specified name.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="name"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentException">If <paramref name="name"/> is empty.</exception>
        public static NodeServiceEventCategory FromName(string name)
        {
            if (name == null)
                throw new ArgumentNullException("name");
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("name cannot be empty");

            return _types.GetOrAdd(name, i => new NodeServiceEventCategory(i));
        }

        /// <summary>
        /// Provides support for serializing and deserializing <see cref="NodeServiceEventCategory"/>
        /// objects to JSON string values.
        /// </summary>
        /// <threadsafety static="true" instance="false"/>
        /// <preliminary/>
        private sealed class Converter : ConverterBase
        {
            /// <inheritdoc/>
            protected override NodeServiceEventCategory FromName(string name)
            {
                return NodeServiceEventCategory.FromName(name);
            }
        }
    }
}
