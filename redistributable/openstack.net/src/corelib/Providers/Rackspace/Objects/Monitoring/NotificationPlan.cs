﻿namespace net.openstack.Providers.Rackspace.Objects.Monitoring
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// This class models the JSON representation of a notification plan resource
    /// in the <see cref="IMonitoringService"/>.
    /// </summary>
    /// <seealso href="http://docs.rackspace.com/cm/api/v1.0/cm-devguide/content/service-notification-plans.html">Notification Plans (Rackspace Cloud Monitoring Developer Guide - API v1.0)</seealso>
    /// <threadsafety static="true" instance="false"/>
    /// <preliminary/>
    [JsonObject(MemberSerialization.OptIn)]
    public class NotificationPlan : NotificationPlanConfiguration
    {
#pragma warning disable 649 // Field 'fieldName' is never assigned to, and will always have its default value {value}
        /// <summary>
        /// This is the backing field for the <see cref="Id"/> property.
        /// </summary>
        [JsonProperty("id")]
        private NotificationPlanId _id;

        /// <summary>
        /// This is the backing field for the <see cref="Created"/> property.
        /// </summary>
        [JsonProperty("created_at")]
        private long? _createdAt;

        /// <summary>
        /// This is the backing field for the <see cref="LastModified"/> property.
        /// </summary>
        [JsonProperty("updated_at")]
        private long? _updatedAt;
#pragma warning restore 649

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationPlan"/> class
        /// during JSON deserialization.
        /// </summary>
        [JsonConstructor]
        protected NotificationPlan()
        {
        }

        /// <summary>
        /// Gets the unique identifier for the notification plan resource.
        /// </summary>
        public NotificationPlanId Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Gets a timestamp indicating when the notification plan resource was created.
        /// </summary>
        public DateTimeOffset? Created
        {
            get
            {
                return DateTimeOffsetExtensions.ToDateTimeOffset(_createdAt);
            }
        }

        /// <summary>
        /// Gets a timestamp indicating when the notification plan resource was last modified.
        /// </summary>
        public DateTimeOffset? LastModified
        {
            get
            {
                return DateTimeOffsetExtensions.ToDateTimeOffset(_updatedAt);
            }
        }
    }
}
