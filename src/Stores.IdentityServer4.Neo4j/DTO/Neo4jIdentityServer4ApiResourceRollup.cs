﻿using Neo4jExtras;
using StoresIdentityServer4.Neo4j.Entities;

namespace StoresIdentityServer4.Neo4j
{
    /// <summary>
    /// Represents an IdentityServer4 ApiResourceRollup
    /// </summary>
    [Neo4jLabel(Neo4jConstants.Labels.ApiResourceRollup)]
    public class Neo4jIdentityServer4ApiResourceRollup : ApiResourceRollup
    {
    }
}