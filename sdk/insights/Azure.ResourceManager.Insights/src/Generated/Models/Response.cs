// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> The response to a metrics query. </summary>
    public partial class Response
    {
        /// <summary> Initializes a new instance of Response. </summary>
        /// <param name="timespan"> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by &apos;/&apos;.  This may be adjusted in the future and returned back from what was originally requested. </param>
        /// <param name="value"> the value of the collection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="timespan"/> or <paramref name="value"/> is null. </exception>
        internal Response(string timespan, IEnumerable<Metric> value)
        {
            if (timespan == null)
            {
                throw new ArgumentNullException(nameof(timespan));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Timespan = timespan;
            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of Response. </summary>
        /// <param name="cost"> The integer value representing the cost of the query, for data case. </param>
        /// <param name="timespan"> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by &apos;/&apos;.  This may be adjusted in the future and returned back from what was originally requested. </param>
        /// <param name="interval"> The interval (window size) for which the metric data was returned in.  This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </param>
        /// <param name="namespace"> The namespace of the metrics been queried. </param>
        /// <param name="resourceregion"> The region of the resource been queried for metrics. </param>
        /// <param name="value"> the value of the collection. </param>
        internal Response(int? cost, string timespan, TimeSpan? interval, string @namespace, string resourceregion, IReadOnlyList<Metric> value)
        {
            Cost = cost;
            Timespan = timespan;
            Interval = interval;
            Namespace = @namespace;
            Resourceregion = resourceregion;
            Value = value;
        }

        /// <summary> The integer value representing the cost of the query, for data case. </summary>
        public int? Cost { get; }
        /// <summary> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by &apos;/&apos;.  This may be adjusted in the future and returned back from what was originally requested. </summary>
        public string Timespan { get; }
        /// <summary> The interval (window size) for which the metric data was returned in.  This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </summary>
        public TimeSpan? Interval { get; }
        /// <summary> The namespace of the metrics been queried. </summary>
        public string Namespace { get; }
        /// <summary> The region of the resource been queried for metrics. </summary>
        public string Resourceregion { get; }
        /// <summary> the value of the collection. </summary>
        public IReadOnlyList<Metric> Value { get; }
    }
}
