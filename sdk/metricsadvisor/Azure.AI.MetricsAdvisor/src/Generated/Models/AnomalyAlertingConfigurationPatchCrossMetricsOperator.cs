// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> cross metrics operator. </summary>
    internal readonly partial struct AnomalyAlertingConfigurationPatchCrossMetricsOperator : IEquatable<AnomalyAlertingConfigurationPatchCrossMetricsOperator>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AnomalyAlertingConfigurationPatchCrossMetricsOperator"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AnomalyAlertingConfigurationPatchCrossMetricsOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ANDValue = "AND";
        private const string ORValue = "OR";
        private const string XORValue = "XOR";

        /// <summary> AND. </summary>
        public static AnomalyAlertingConfigurationPatchCrossMetricsOperator AND { get; } = new AnomalyAlertingConfigurationPatchCrossMetricsOperator(ANDValue);
        /// <summary> OR. </summary>
        public static AnomalyAlertingConfigurationPatchCrossMetricsOperator OR { get; } = new AnomalyAlertingConfigurationPatchCrossMetricsOperator(ORValue);
        /// <summary> XOR. </summary>
        public static AnomalyAlertingConfigurationPatchCrossMetricsOperator XOR { get; } = new AnomalyAlertingConfigurationPatchCrossMetricsOperator(XORValue);
        /// <summary> Determines if two <see cref="AnomalyAlertingConfigurationPatchCrossMetricsOperator"/> values are the same. </summary>
        public static bool operator ==(AnomalyAlertingConfigurationPatchCrossMetricsOperator left, AnomalyAlertingConfigurationPatchCrossMetricsOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AnomalyAlertingConfigurationPatchCrossMetricsOperator"/> values are not the same. </summary>
        public static bool operator !=(AnomalyAlertingConfigurationPatchCrossMetricsOperator left, AnomalyAlertingConfigurationPatchCrossMetricsOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AnomalyAlertingConfigurationPatchCrossMetricsOperator"/>. </summary>
        public static implicit operator AnomalyAlertingConfigurationPatchCrossMetricsOperator(string value) => new AnomalyAlertingConfigurationPatchCrossMetricsOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AnomalyAlertingConfigurationPatchCrossMetricsOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AnomalyAlertingConfigurationPatchCrossMetricsOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
