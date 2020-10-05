// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class NetezzaPartitionSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PartitionColumnName))
            {
                writer.WritePropertyName("partitionColumnName");
                writer.WriteObjectValue(PartitionColumnName);
            }
            if (Optional.IsDefined(PartitionUpperBound))
            {
                writer.WritePropertyName("partitionUpperBound");
                writer.WriteObjectValue(PartitionUpperBound);
            }
            if (Optional.IsDefined(PartitionLowerBound))
            {
                writer.WritePropertyName("partitionLowerBound");
                writer.WriteObjectValue(PartitionLowerBound);
            }
            writer.WriteEndObject();
        }

        internal static NetezzaPartitionSettings DeserializeNetezzaPartitionSettings(JsonElement element)
        {
            Optional<object> partitionColumnName = default;
            Optional<object> partitionUpperBound = default;
            Optional<object> partitionLowerBound = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionColumnName"))
                {
                    partitionColumnName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionUpperBound"))
                {
                    partitionUpperBound = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionLowerBound"))
                {
                    partitionLowerBound = property.Value.GetObject();
                    continue;
                }
            }
            return new NetezzaPartitionSettings(partitionColumnName.Value, partitionUpperBound.Value, partitionLowerBound.Value);
        }
    }
}
