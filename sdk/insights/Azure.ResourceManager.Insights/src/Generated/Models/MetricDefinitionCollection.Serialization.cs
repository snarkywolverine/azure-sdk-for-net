// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class MetricDefinitionCollection
    {
        internal static MetricDefinitionCollection DeserializeMetricDefinitionCollection(JsonElement element)
        {
            IReadOnlyList<MetricDefinition> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<MetricDefinition> array = new List<MetricDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricDefinition.DeserializeMetricDefinition(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MetricDefinitionCollection(value);
        }
    }
}
