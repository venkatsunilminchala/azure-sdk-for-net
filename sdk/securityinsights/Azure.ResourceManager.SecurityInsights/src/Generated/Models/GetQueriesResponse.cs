// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Retrieve queries for entity result operation response. </summary>
    internal partial class GetQueriesResponse
    {
        /// <summary> Initializes a new instance of GetQueriesResponse. </summary>
        internal GetQueriesResponse()
        {
            Value = new ChangeTrackingList<EntityQueryItem>();
        }

        /// <summary> Initializes a new instance of GetQueriesResponse. </summary>
        /// <param name="value">
        /// The query result values.
        /// Please note <see cref="EntityQueryItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="InsightQueryItem"/>.
        /// </param>
        internal GetQueriesResponse(IReadOnlyList<EntityQueryItem> value)
        {
            Value = value;
        }

        /// <summary>
        /// The query result values.
        /// Please note <see cref="EntityQueryItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="InsightQueryItem"/>.
        /// </summary>
        public IReadOnlyList<EntityQueryItem> Value { get; }
    }
}
