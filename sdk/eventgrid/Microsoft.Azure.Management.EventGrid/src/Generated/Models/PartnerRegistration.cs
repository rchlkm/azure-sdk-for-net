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
    /// Information about a partner registration.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PartnerRegistration : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the PartnerRegistration class.
        /// </summary>
        public PartnerRegistration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PartnerRegistration class.
        /// </summary>
        /// <param name="location">Location of the resource.</param>
        /// <param name="id">Fully qualified identifier of the
        /// resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of the resource.</param>
        /// <param name="tags">Tags of the resource.</param>
        /// <param name="provisioningState">Provisioning state of the partner
        /// registration. Possible values include: 'Creating', 'Updating',
        /// 'Deleting', 'Succeeded', 'Canceled', 'Failed'</param>
        /// <param name="partnerRegistrationImmutableId">The immutableId of the
        /// corresponding partner registration.</param>
        /// <param name="partnerName">Official name of the partner name. For
        /// example: "Contoso".</param>
        /// <param name="partnerResourceTypeName">Name of the partner resource
        /// type.</param>
        /// <param name="partnerResourceTypeDisplayName">Display name of the
        /// partner resource type.</param>
        /// <param name="partnerResourceTypeDescription">Short description of
        /// the partner resource type. The length of this description should
        /// not exceed 256 characters.</param>
        /// <param name="longDescription">Long description for the custom
        /// scenarios and integration to be displayed in the portal if needed.
        /// Length of this description should not exceed 2048
        /// characters.</param>
        /// <param name="partnerCustomerServiceNumber">The customer service
        /// number of the publisher. The expected phone format should start
        /// with a '+' sign
        /// followed by the country code. The remaining digits are then
        /// followed. Only digits and spaces are allowed and its
        /// length cannot exceed 16 digits including country code. Examples of
        /// valid phone numbers are: +1 515 123 4567 and
        /// +966 7 5115 2471. Examples of invalid phone numbers are: +1 (515)
        /// 123-4567, 1 515 123 4567 and +966 121 5115 24 7 551 1234 43</param>
        /// <param name="partnerCustomerServiceExtension">The extension of the
        /// customer service number of the publisher. Only digits are allowed
        /// and number of digits should not exceed 10.</param>
        /// <param name="customerServiceUri">The extension of the customer
        /// service URI of the publisher.</param>
        /// <param name="setupUri">URI of the partner website that can be used
        /// by Azure customers to setup Event Grid
        /// integration on an event source.</param>
        /// <param name="logoUri">URI of the logo.</param>
        /// <param name="visibilityState">Visibility state of the partner
        /// registration. Possible values include: 'Hidden', 'PublicPreview',
        /// 'GenerallyAvailable'</param>
        /// <param name="authorizedAzureSubscriptionIds">List of Azure
        /// subscription Ids that are authorized to create a partner namespace
        /// associated with this partner registration. This is an optional
        /// property. Creating
        /// partner namespaces is always permitted under the same Azure
        /// subscription as the one used
        /// for creating the partner registration.</param>
        /// <param name="systemData">The system metadata relating to Partner
        /// Registration resource.</param>
        public PartnerRegistration(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), System.Guid? partnerRegistrationImmutableId = default(System.Guid?), string partnerName = default(string), string partnerResourceTypeName = default(string), string partnerResourceTypeDisplayName = default(string), string partnerResourceTypeDescription = default(string), string longDescription = default(string), string partnerCustomerServiceNumber = default(string), string partnerCustomerServiceExtension = default(string), string customerServiceUri = default(string), string setupUri = default(string), string logoUri = default(string), string visibilityState = default(string), IList<string> authorizedAzureSubscriptionIds = default(IList<string>), SystemData systemData = default(SystemData))
            : base(location, id, name, type, tags)
        {
            ProvisioningState = provisioningState;
            PartnerRegistrationImmutableId = partnerRegistrationImmutableId;
            PartnerName = partnerName;
            PartnerResourceTypeName = partnerResourceTypeName;
            PartnerResourceTypeDisplayName = partnerResourceTypeDisplayName;
            PartnerResourceTypeDescription = partnerResourceTypeDescription;
            LongDescription = longDescription;
            PartnerCustomerServiceNumber = partnerCustomerServiceNumber;
            PartnerCustomerServiceExtension = partnerCustomerServiceExtension;
            CustomerServiceUri = customerServiceUri;
            SetupUri = setupUri;
            LogoUri = logoUri;
            VisibilityState = visibilityState;
            AuthorizedAzureSubscriptionIds = authorizedAzureSubscriptionIds;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets provisioning state of the partner registration. Possible
        /// values include: 'Creating', 'Updating', 'Deleting', 'Succeeded',
        /// 'Canceled', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the immutableId of the corresponding partner
        /// registration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerRegistrationImmutableId")]
        public System.Guid? PartnerRegistrationImmutableId { get; set; }

        /// <summary>
        /// Gets or sets official name of the partner name. For example:
        /// "Contoso".
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerName")]
        public string PartnerName { get; set; }

        /// <summary>
        /// Gets or sets name of the partner resource type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerResourceTypeName")]
        public string PartnerResourceTypeName { get; set; }

        /// <summary>
        /// Gets or sets display name of the partner resource type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerResourceTypeDisplayName")]
        public string PartnerResourceTypeDisplayName { get; set; }

        /// <summary>
        /// Gets or sets short description of the partner resource type. The
        /// length of this description should not exceed 256 characters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerResourceTypeDescription")]
        public string PartnerResourceTypeDescription { get; set; }

        /// <summary>
        /// Gets or sets long description for the custom scenarios and
        /// integration to be displayed in the portal if needed.
        /// Length of this description should not exceed 2048 characters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.longDescription")]
        public string LongDescription { get; set; }

        /// <summary>
        /// Gets or sets the customer service number of the publisher. The
        /// expected phone format should start with a '+' sign
        /// followed by the country code. The remaining digits are then
        /// followed. Only digits and spaces are allowed and its
        /// length cannot exceed 16 digits including country code. Examples of
        /// valid phone numbers are: +1 515 123 4567 and
        /// +966 7 5115 2471. Examples of invalid phone numbers are: +1 (515)
        /// 123-4567, 1 515 123 4567 and +966 121 5115 24 7 551 1234 43
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerCustomerServiceNumber")]
        public string PartnerCustomerServiceNumber { get; set; }

        /// <summary>
        /// Gets or sets the extension of the customer service number of the
        /// publisher. Only digits are allowed and number of digits should not
        /// exceed 10.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerCustomerServiceExtension")]
        public string PartnerCustomerServiceExtension { get; set; }

        /// <summary>
        /// Gets or sets the extension of the customer service URI of the
        /// publisher.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customerServiceUri")]
        public string CustomerServiceUri { get; set; }

        /// <summary>
        /// Gets or sets URI of the partner website that can be used by Azure
        /// customers to setup Event Grid
        /// integration on an event source.
        /// </summary>
        [JsonProperty(PropertyName = "properties.setupUri")]
        public string SetupUri { get; set; }

        /// <summary>
        /// Gets or sets URI of the logo.
        /// </summary>
        [JsonProperty(PropertyName = "properties.logoUri")]
        public string LogoUri { get; set; }

        /// <summary>
        /// Gets or sets visibility state of the partner registration. Possible
        /// values include: 'Hidden', 'PublicPreview', 'GenerallyAvailable'
        /// </summary>
        [JsonProperty(PropertyName = "properties.visibilityState")]
        public string VisibilityState { get; set; }

        /// <summary>
        /// Gets or sets list of Azure subscription Ids that are authorized to
        /// create a partner namespace
        /// associated with this partner registration. This is an optional
        /// property. Creating
        /// partner namespaces is always permitted under the same Azure
        /// subscription as the one used
        /// for creating the partner registration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authorizedAzureSubscriptionIds")]
        public IList<string> AuthorizedAzureSubscriptionIds { get; set; }

        /// <summary>
        /// Gets the system metadata relating to Partner Registration resource.
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
