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


using Newtonsoft.Json;

namespace ASC.HealthCheck.Models
{
    public class Port
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public string StatusDescription { get; set; }
        [JsonIgnore]
        public PortStatus PortStatus { get; set; }
        [JsonIgnore]
        public string Status { get; set; }
        [JsonIgnore]
        public bool AllowClosedForIncomingRequests { get; set; }
        [JsonIgnore]
        public bool AllowClosedForOutgoingRequests { get; set; }

        public Port()
        {
            AllowClosedForIncomingRequests = true;
            AllowClosedForOutgoingRequests = false;
        }
    }
}