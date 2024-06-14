// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.MSGraph.Version1_0.Identity.DirectoryManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// servicePlanInfo
    /// </summary>
    public partial class MicrosoftgraphservicePlanInfo
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphservicePlanInfo
        /// class.
        /// </summary>
        public MicrosoftgraphservicePlanInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphservicePlanInfo
        /// class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="appliesTo">The object the service plan can be assigned
        /// to. The possible values are:User - service plan can be assigned to
        /// individual users.Company - service plan can be assigned to the
        /// entire tenant.</param>
        /// <param name="provisioningStatus">The provisioning status of the
        /// service plan. The possible values are:Success - Service is fully
        /// provisioned.Disabled - Service has been disabled.ErrorStatus - The
        /// service plan has not been provisioned and is in an error
        /// state.PendingInput - Service is not yet provisioned; awaiting
        /// service confirmation.PendingActivation - Service is provisioned but
        /// requires explicit activation by administrator (for example,
        /// Intune_O365 service plan)PendingProvisioning - Microsoft has added
        /// a new service to the product SKU and it has not been activated in
        /// the tenant, yet.</param>
        /// <param name="servicePlanId">The unique identifier of the service
        /// plan.</param>
        /// <param name="servicePlanName">The name of the service plan.</param>
        public MicrosoftgraphservicePlanInfo(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string appliesTo = default(string), string provisioningStatus = default(string), System.Guid? servicePlanId = default(System.Guid?), string servicePlanName = default(string))
        {
            AdditionalProperties = additionalProperties;
            AppliesTo = appliesTo;
            ProvisioningStatus = provisioningStatus;
            ServicePlanId = servicePlanId;
            ServicePlanName = servicePlanName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets the object the service plan can be assigned to. The
        /// possible values are:User - service plan can be assigned to
        /// individual users.Company - service plan can be assigned to the
        /// entire tenant.
        /// </summary>
        [JsonProperty(PropertyName = "appliesTo")]
        public string AppliesTo { get; set; }

        /// <summary>
        /// Gets or sets the provisioning status of the service plan. The
        /// possible values are:Success - Service is fully provisioned.Disabled
        /// - Service has been disabled.ErrorStatus - The service plan has not
        /// been provisioned and is in an error state.PendingInput - Service is
        /// not yet provisioned; awaiting service
        /// confirmation.PendingActivation - Service is provisioned but
        /// requires explicit activation by administrator (for example,
        /// Intune_O365 service plan)PendingProvisioning - Microsoft has added
        /// a new service to the product SKU and it has not been activated in
        /// the tenant, yet.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningStatus")]
        public string ProvisioningStatus { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the service plan.
        /// </summary>
        [JsonProperty(PropertyName = "servicePlanId")]
        public System.Guid? ServicePlanId { get; set; }

        /// <summary>
        /// Gets or sets the name of the service plan.
        /// </summary>
        [JsonProperty(PropertyName = "servicePlanName")]
        public string ServicePlanName { get; set; }
    }
}