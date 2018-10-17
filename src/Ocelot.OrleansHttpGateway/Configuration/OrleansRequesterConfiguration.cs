using Ocelot.Configuration;
using Ocelot.Middleware;
using Ocelot.OrleansHttpGateway.Model;
using Ocelot.Responses;
using Orleans;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.OrleansHttpGateway.Configuration
{
    public class OrleansRequesterConfiguration
    {
        public OrleansRequesterConfiguration()
        {
            MapRouteToGraininterface = (route) => route.GrainName;
        }
        public Func<DownstreamContext, Response<string>> RequestContextInjection { get; set; }

        public Func<GrainRouteValues, string> MapRouteToGraininterface { get; set; }

        public Action<ServiceProviderConfiguration, IClientBuilder> ServiceDiscoveryConfig { get; set; }
    }
}
