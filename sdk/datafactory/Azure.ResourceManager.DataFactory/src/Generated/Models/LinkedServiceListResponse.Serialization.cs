// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class LinkedServiceListResponse
    {
        internal static LinkedServiceListResponse DeserializeLinkedServiceListResponse(JsonElement element)
        {
            IReadOnlyList<FactoryLinkedServiceData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<FactoryLinkedServiceData> array = new List<FactoryLinkedServiceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FactoryLinkedServiceData.DeserializeFactoryLinkedServiceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new LinkedServiceListResponse(value, nextLink.Value);
        }
    }
}
