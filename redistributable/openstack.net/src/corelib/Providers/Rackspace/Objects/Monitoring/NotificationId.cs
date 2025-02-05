﻿namespace net.openstack.Providers.Rackspace.Objects.Monitoring
{
    using System;
    using net.openstack.Core;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents the unique identifier of a notification in the <see cref="IMonitoringService"/>.
    /// </summary>
    /// <seealso cref="Notification.Id"/>
    /// <threadsafety static="true" instance="false"/>
    /// <preliminary/>
    [JsonConverter(typeof(NotificationId.Converter))]
    public sealed class NotificationId : ResourceIdentifier<NotificationId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationId"/> class
        /// with the specified identifier value.
        /// </summary>
        /// <param name="id">The notification identifier value.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="id"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentException">If <paramref name="id"/> is empty.</exception>
        public NotificationId(string id)
            : base(id)
        {
        }

        /// <summary>
        /// Provides support for serializing and deserializing <see cref="NotificationId"/>
        /// objects to JSON string values.
        /// </summary>
        /// <threadsafety static="true" instance="false"/>
        private sealed class Converter : ConverterBase
        {
            /// <inheritdoc/>
            protected override NotificationId FromValue(string id)
            {
                return new NotificationId(id);
            }
        }
    }
}
