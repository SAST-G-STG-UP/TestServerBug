﻿/*
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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ASC.Common.Web
{
    public static class HttpClientFactory
    {
        private static ConcurrentDictionary<string, HttpClient> clientsStorage = new ConcurrentDictionary<string, HttpClient>();
        private const string DEFAULT_NAME = "default";
        public static HttpClient CreateClient()
        {
            return CreateClient(DEFAULT_NAME);
        }

        public static HttpClient CreateClient(string name, HttpClientHandler httpHandler = null)
        {
            if(!clientsStorage.TryGetValue(name, out var httpClient))
            {
                if(httpHandler != null)
                {
                    httpClient = new HttpClient(httpHandler);
                }
                else
                {
                    httpClient = new HttpClient();
                }

                clientsStorage.TryAdd(name, httpClient);
            }

            return httpClient;
        }
    }
}
