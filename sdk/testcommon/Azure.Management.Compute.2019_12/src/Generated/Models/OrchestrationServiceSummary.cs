// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Compute.Models
{
    /// <summary> Summary for an orchestration service of a virtual machine scale set. </summary>
    public partial class OrchestrationServiceSummary
    {
        /// <summary> Initializes a new instance of OrchestrationServiceSummary. </summary>
        internal OrchestrationServiceSummary()
        {
        }

        /// <summary> Initializes a new instance of OrchestrationServiceSummary. </summary>
        /// <param name="serviceName"> The name of the service. </param>
        /// <param name="serviceState"> The current state of the service. </param>
        internal OrchestrationServiceSummary(OrchestrationServiceNames? serviceName, OrchestrationServiceState? serviceState)
        {
            ServiceName = serviceName;
            ServiceState = serviceState;
        }

        /// <summary> The name of the service. </summary>
        public OrchestrationServiceNames? ServiceName { get; }
        /// <summary> The current state of the service. </summary>
        public OrchestrationServiceState? ServiceState { get; }
    }
}
