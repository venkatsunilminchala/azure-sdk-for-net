// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class BatchAuthenticationModeExtensions
    {
        public static string ToSerialString(this BatchAuthenticationMode value) => value switch
        {
            BatchAuthenticationMode.SharedKey => "SharedKey",
            BatchAuthenticationMode.Aad => "AAD",
            BatchAuthenticationMode.TaskAuthenticationToken => "TaskAuthenticationToken",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchAuthenticationMode value.")
        };

        public static BatchAuthenticationMode ToBatchAuthenticationMode(this string value)
        {
            if (string.Equals(value, "SharedKey", StringComparison.InvariantCultureIgnoreCase)) return BatchAuthenticationMode.SharedKey;
            if (string.Equals(value, "AAD", StringComparison.InvariantCultureIgnoreCase)) return BatchAuthenticationMode.Aad;
            if (string.Equals(value, "TaskAuthenticationToken", StringComparison.InvariantCultureIgnoreCase)) return BatchAuthenticationMode.TaskAuthenticationToken;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchAuthenticationMode value.");
        }
    }
}
