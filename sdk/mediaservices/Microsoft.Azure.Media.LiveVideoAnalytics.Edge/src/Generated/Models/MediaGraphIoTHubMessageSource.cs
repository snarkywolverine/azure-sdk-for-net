// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Media.LiveVideoAnalytics.Edge.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Enables a graph to receive messages via routes declared in the IoT Edge
    /// deployment manifest.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.MediaGraphIoTHubMessageSource")]
    public partial class MediaGraphIoTHubMessageSource : MediaGraphSource
    {
        /// <summary>
        /// Initializes a new instance of the MediaGraphIoTHubMessageSource
        /// class.
        /// </summary>
        public MediaGraphIoTHubMessageSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaGraphIoTHubMessageSource
        /// class.
        /// </summary>
        /// <param name="name">The name to be used for this source
        /// node.</param>
        /// <param name="hubInputName">Name of the input path where messages
        /// can be routed to (via routes declared in the IoT Edge deployment
        /// manifest).</param>
        public MediaGraphIoTHubMessageSource(string name, string hubInputName = default(string))
            : base(name)
        {
            HubInputName = hubInputName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the input path where messages can be routed to
        /// (via routes declared in the IoT Edge deployment manifest).
        /// </summary>
        [JsonProperty(PropertyName = "hubInputName")]
        public string HubInputName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
