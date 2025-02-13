// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the ExpressRouteConnection data model. </summary>
    public partial class ExpressRouteConnectionData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of ExpressRouteConnectionData. </summary>
        public ExpressRouteConnectionData()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteConnectionData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="provisioningState"> The provisioning state of the express route connection resource. </param>
        /// <param name="expressRouteCircuitPeering"> The ExpressRoute circuit peering. </param>
        /// <param name="authorizationKey"> Authorization key to establish the connection. </param>
        /// <param name="routingWeight"> The routing weight associated to the connection. </param>
        /// <param name="enableInternetSecurity"> Enable internet security. </param>
        /// <param name="expressRouteGatewayBypass"> Enable FastPath to vWan Firewall hub. </param>
        /// <param name="routingConfiguration"> The Routing Configuration indicating the associated and propagated route tables on this connection. </param>
        internal ExpressRouteConnectionData(ResourceIdentifier id, string name, ResourceType? resourceType, NetworkProvisioningState? provisioningState, WritableSubResource expressRouteCircuitPeering, string authorizationKey, int? routingWeight, bool? enableInternetSecurity, bool? expressRouteGatewayBypass, RoutingConfiguration routingConfiguration) : base(id, name, resourceType)
        {
            ProvisioningState = provisioningState;
            ExpressRouteCircuitPeering = expressRouteCircuitPeering;
            AuthorizationKey = authorizationKey;
            RoutingWeight = routingWeight;
            EnableInternetSecurity = enableInternetSecurity;
            ExpressRouteGatewayBypass = expressRouteGatewayBypass;
            RoutingConfiguration = routingConfiguration;
        }

        /// <summary> The provisioning state of the express route connection resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The ExpressRoute circuit peering. </summary>
        internal WritableSubResource ExpressRouteCircuitPeering { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ExpressRouteCircuitPeeringId
        {
            get => ExpressRouteCircuitPeering is null ? default : ExpressRouteCircuitPeering.Id;
            set
            {
                if (ExpressRouteCircuitPeering is null)
                    ExpressRouteCircuitPeering = new WritableSubResource();
                ExpressRouteCircuitPeering.Id = value;
            }
        }

        /// <summary> Authorization key to establish the connection. </summary>
        public string AuthorizationKey { get; set; }
        /// <summary> The routing weight associated to the connection. </summary>
        public int? RoutingWeight { get; set; }
        /// <summary> Enable internet security. </summary>
        public bool? EnableInternetSecurity { get; set; }
        /// <summary> Enable FastPath to vWan Firewall hub. </summary>
        public bool? ExpressRouteGatewayBypass { get; set; }
        /// <summary> The Routing Configuration indicating the associated and propagated route tables on this connection. </summary>
        public RoutingConfiguration RoutingConfiguration { get; set; }
    }
}
