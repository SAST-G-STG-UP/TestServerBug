/*
 *
 * (c) Copyright Ascensio System Limited 2010-2023
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/


using System;
using System.Collections.Generic;

namespace ASC.AuditTrail
{
    public class BaseEvent
    {
        public int Id { get; set; }

        public int TenantId { get; set; }

        public Guid UserId { get; set; }

        public bool Mobile { get; set; }

        public IList<string> Description { get; set; }

        [Event("IpCol")]
        public string IP { get; set; }

        [Event("BrowserCol")]
        public string Browser { get; set; }

        [Event("PlatformCol")]
        public string Platform { get; set; }

        [Event("DateCol")]
        public DateTime Date { get; set; }

        [Event("UserCol")]
        public string UserName { get; set; }

        [Event("PageCol")]
        public string Page { get; set; }

        [Event("ActionCol")]
        public string ActionText { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class EventAttribute : Attribute
    {
        public string Resource { get; private set; }

        public int Order { get; private set; }

        public EventAttribute(string resource, int order = 0)
        {
            Resource = resource;
            Order = order;
        }
    }
}
