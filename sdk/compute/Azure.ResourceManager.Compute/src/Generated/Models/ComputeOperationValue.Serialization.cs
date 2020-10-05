// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ComputeOperationValue
    {
        internal static ComputeOperationValue DeserializeComputeOperationValue(JsonElement element)
        {
            Optional<string> origin = default;
            Optional<string> name = default;
            Optional<string> operation = default;
            Optional<string> resource = default;
            Optional<string> description = default;
            Optional<string> provider = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("origin"))
                {
                    origin = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("display"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("operation"))
                        {
                            operation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resource"))
                        {
                            resource = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provider"))
                        {
                            provider = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ComputeOperationValue(origin.Value, name.Value, operation.Value, resource.Value, description.Value, provider.Value);
        }
    }
}
