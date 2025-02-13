// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// EventGrid Topic
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Topic : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Topic class.
        /// </summary>
        public Topic()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Topic class.
        /// </summary>
        /// <param name="location">Location of the resource.</param>
        /// <param name="id">Fully qualified identifier of the
        /// resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of the resource.</param>
        /// <param name="tags">Tags of the resource.</param>
        /// <param name="provisioningState">Provisioning state of the topic.
        /// Possible values include: 'Creating', 'Updating', 'Deleting',
        /// 'Succeeded', 'Canceled', 'Failed'</param>
        /// <param name="endpoint">Endpoint for the topic.</param>
        /// <param name="inputSchema">This determines the format that Event
        /// Grid should expect for incoming events published to the topic.
        /// Possible values include: 'EventGridSchema', 'CustomEventSchema',
        /// 'CloudEventSchemaV1_0'</param>
        /// <param name="inputSchemaMapping">This enables publishing using
        /// custom event schemas. An InputSchemaMapping can be specified to map
        /// various properties of a source schema to various required
        /// properties of the EventGridEvent schema.</param>
        /// <param name="metricResourceId">Metric resource id for the
        /// topic.</param>
        /// <param name="publicNetworkAccess">This determines if traffic is
        /// allowed over public network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring &lt;seealso
        /// cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.TopicProperties.InboundIpRules"
        /// /&gt;. Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="inboundIpRules">This can be used to restrict traffic
        /// from specific IPs instead of all IPs. Note: These are considered
        /// only if PublicNetworkAccess is enabled.</param>
        /// <param name="disableLocalAuth">This boolean is used to enable or
        /// disable local auth. Default value is false. When the property is
        /// set to true, only AAD token will be used to authenticate if user is
        /// allowed to publish to the topic.</param>
        /// <param name="dataResidencyBoundary">Data Residency Boundary of the
        /// resource. Possible values include: 'WithinGeopair',
        /// 'WithinRegion'</param>
        /// <param name="sku">The Sku pricing tier for the topic.</param>
        /// <param name="identity">Identity information for the
        /// resource.</param>
        /// <param name="kind">Kind of the resource. Possible values include:
        /// 'Azure', 'AzureArc'</param>
        /// <param name="extendedLocation">Extended location of the
        /// resource.</param>
        /// <param name="systemData">The system metadata relating to Topic
        /// resource.</param>
        public Topic(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<PrivateEndpointConnection> privateEndpointConnections = default(IList<PrivateEndpointConnection>), string provisioningState = default(string), string endpoint = default(string), string inputSchema = default(string), InputSchemaMapping inputSchemaMapping = default(InputSchemaMapping), string metricResourceId = default(string), string publicNetworkAccess = default(string), IList<InboundIpRule> inboundIpRules = default(IList<InboundIpRule>), bool? disableLocalAuth = default(bool?), string dataResidencyBoundary = default(string), ResourceSku sku = default(ResourceSku), IdentityInfo identity = default(IdentityInfo), string kind = default(string), ExtendedLocation extendedLocation = default(ExtendedLocation), SystemData systemData = default(SystemData))
            : base(location, id, name, type, tags)
        {
            PrivateEndpointConnections = privateEndpointConnections;
            ProvisioningState = provisioningState;
            Endpoint = endpoint;
            InputSchema = inputSchema;
            InputSchemaMapping = inputSchemaMapping;
            MetricResourceId = metricResourceId;
            PublicNetworkAccess = publicNetworkAccess;
            InboundIpRules = inboundIpRules;
            DisableLocalAuth = disableLocalAuth;
            DataResidencyBoundary = dataResidencyBoundary;
            Sku = sku;
            Identity = identity;
            Kind = kind;
            ExtendedLocation = extendedLocation;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public IList<PrivateEndpointConnection> PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets provisioning state of the topic. Possible values include:
        /// 'Creating', 'Updating', 'Deleting', 'Succeeded', 'Canceled',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets endpoint for the topic.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpoint")]
        public string Endpoint { get; private set; }

        /// <summary>
        /// Gets or sets this determines the format that Event Grid should
        /// expect for incoming events published to the topic. Possible values
        /// include: 'EventGridSchema', 'CustomEventSchema',
        /// 'CloudEventSchemaV1_0'
        /// </summary>
        [JsonProperty(PropertyName = "properties.inputSchema")]
        public string InputSchema { get; set; }

        /// <summary>
        /// Gets or sets this enables publishing using custom event schemas. An
        /// InputSchemaMapping can be specified to map various properties of a
        /// source schema to various required properties of the EventGridEvent
        /// schema.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inputSchemaMapping")]
        public InputSchemaMapping InputSchemaMapping { get; set; }

        /// <summary>
        /// Gets metric resource id for the topic.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metricResourceId")]
        public string MetricResourceId { get; private set; }

        /// <summary>
        /// Gets or sets this determines if traffic is allowed over public
        /// network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring
        /// &amp;lt;seealso
        /// cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.TopicProperties.InboundIpRules"
        /// /&amp;gt;. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets this can be used to restrict traffic from specific IPs
        /// instead of all IPs. Note: These are considered only if
        /// PublicNetworkAccess is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inboundIpRules")]
        public IList<InboundIpRule> InboundIpRules { get; set; }

        /// <summary>
        /// Gets or sets this boolean is used to enable or disable local auth.
        /// Default value is false. When the property is set to true, only AAD
        /// token will be used to authenticate if user is allowed to publish to
        /// the topic.
        /// </summary>
        [JsonProperty(PropertyName = "properties.disableLocalAuth")]
        public bool? DisableLocalAuth { get; set; }

        /// <summary>
        /// Gets or sets data Residency Boundary of the resource. Possible
        /// values include: 'WithinGeopair', 'WithinRegion'
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataResidencyBoundary")]
        public string DataResidencyBoundary { get; set; }

        /// <summary>
        /// Gets or sets the Sku pricing tier for the topic.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public ResourceSku Sku { get; set; }

        /// <summary>
        /// Gets or sets identity information for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public IdentityInfo Identity { get; set; }

        /// <summary>
        /// Gets or sets kind of the resource. Possible values include:
        /// 'Azure', 'AzureArc'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets extended location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "extendedLocation")]
        public ExtendedLocation ExtendedLocation { get; set; }

        /// <summary>
        /// Gets the system metadata relating to Topic resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
