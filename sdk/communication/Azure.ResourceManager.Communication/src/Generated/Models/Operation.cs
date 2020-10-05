// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> REST API operation supported by CommunicationService resource provider. </summary>
    public partial class Operation
    {
        /// <summary> Initializes a new instance of Operation. </summary>
        internal Operation()
        {
        }

        /// <summary> Initializes a new instance of Operation. </summary>
        /// <param name="name"> Name of the operation with format: {provider}/{resource}/{operation}. </param>
        /// <param name="display"> The object that describes the operation. </param>
        /// <param name="origin"> Optional. The intended executor of the operation; governs the display of the operation in the RBAC UX and the audit logs UX. </param>
        /// <param name="properties"> Extra properties for the operation. </param>
        internal Operation(string name, OperationDisplay display, string origin, OperationProperties properties)
        {
            Name = name;
            Display = display;
            Origin = origin;
            Properties = properties;
        }

        /// <summary> Name of the operation with format: {provider}/{resource}/{operation}. </summary>
        public string Name { get; }
        /// <summary> The object that describes the operation. </summary>
        public OperationDisplay Display { get; }
        /// <summary> Optional. The intended executor of the operation; governs the display of the operation in the RBAC UX and the audit logs UX. </summary>
        public string Origin { get; }
        /// <summary> Extra properties for the operation. </summary>
        public OperationProperties Properties { get; }
    }
}
