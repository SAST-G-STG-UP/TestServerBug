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


namespace ASC.ReversyProxy;

/// <summary>
/// Extends the IReverseProxyBuilder to support the InMemoryConfigProvider
/// </summary>
public static class InMemoryConfigProviderExtensions
{
    public static IReverseProxyBuilder LoadFromMemory(this IReverseProxyBuilder builder)
    {
        var provider = new InMemoryConfigProvider();

        builder.Services.AddSingleton<IProxyConfigProvider>(provider);
        builder.Services.AddSingleton<IUpdateConfig>(provider);

        return builder;
    }
}

/// <summary>
/// Provides an implementation of IProxyConfigProvider to support config being generated by code. 
/// </summary>
public class InMemoryConfigProvider : IProxyConfigProvider, IUpdateConfig
{
    // Marked as volatile so that updates are atomic
    private volatile InMemoryConfig _config;

    public InMemoryConfigProvider()
    {
        _config = new InMemoryConfig(new List<RouteConfig>(), new List<ClusterConfig>());
    }

    /// <summary>
    /// Implementation of the IProxyConfigProvider.GetConfig method to supply the current snapshot of configuration
    /// </summary>
    /// <returns>An immutable snapshot of the current configuration state</returns>
    public IProxyConfig GetConfig() => _config;

    /// <summary>
    /// Swaps the config state with a new snapshot of the configuration, then signals the change
    /// </summary>
    public void Update(IReadOnlyList<RouteConfig> routes, IReadOnlyList<ClusterConfig> clusters)
    {
        var oldConfig = _config;
        _config = new InMemoryConfig(routes, clusters);
        oldConfig.SignalChange();
    }

    /// <summary>
    /// Implementation of IProxyConfig which is a snapshot of the current config state. The data for this class should be immutable.
    /// </summary>
    private class InMemoryConfig : IProxyConfig
    {
        // Used to implement the change token for the state
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();

        public InMemoryConfig(IReadOnlyList<RouteConfig> routes, IReadOnlyList<ClusterConfig> clusters)
        {
            Routes = routes;
            Clusters = clusters;
            ChangeToken = new CancellationChangeToken(_cts.Token);
        }

        /// <summary>
        /// A snapshot of the list of routes for the proxy
        /// </summary>
        public IReadOnlyList<RouteConfig> Routes { get; }

        /// <summary>
        /// A snapshot of the list of Clusters which are collections of interchangable destination endpoints
        /// </summary>
        public IReadOnlyList<ClusterConfig> Clusters { get; }

        /// <summary>
        /// Fired to indicate the the proxy state has changed, and that this snapshot is now stale
        /// </summary>
        public IChangeToken ChangeToken { get; }

        internal void SignalChange()
        {
            _cts.Cancel();
        }
    }
}
