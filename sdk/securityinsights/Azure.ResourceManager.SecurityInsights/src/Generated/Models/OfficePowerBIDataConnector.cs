// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents Office Microsoft PowerBI data connector. </summary>
    public partial class OfficePowerBIDataConnector : DataConnectorData
    {
        /// <summary> Initializes a new instance of OfficePowerBIDataConnector. </summary>
        public OfficePowerBIDataConnector()
        {
            Kind = DataConnectorKind.OfficePowerBI;
        }

        /// <summary> Initializes a new instance of OfficePowerBIDataConnector. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The data connector kind. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="tenantId"> The tenant id to connect to, and get the data from. </param>
        /// <param name="logs"> Logs data type. </param>
        internal OfficePowerBIDataConnector(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataConnectorKind kind, ETag? etag, Guid? tenantId, OfficePowerBIConnectorDataTypesLogs logs) : base(id, name, resourceType, systemData, kind, etag)
        {
            TenantId = tenantId;
            Logs = logs;
            Kind = kind;
        }

        /// <summary> The tenant id to connect to, and get the data from. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Logs data type. </summary>
        internal OfficePowerBIConnectorDataTypesLogs Logs { get; set; }
        /// <summary> Describe whether this data type connection is enabled or not. </summary>
        public DataTypeState? LogsState
        {
            get => Logs is null ? default(DataTypeState?) : Logs.State;
            set
            {
                Logs = value.HasValue ? new OfficePowerBIConnectorDataTypesLogs(value.Value) : null;
            }
        }
    }
}
