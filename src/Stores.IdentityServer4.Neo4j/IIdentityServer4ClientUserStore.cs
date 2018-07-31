﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Identity;
using Stores.IdentityServer4.Neo4j.Entities;

namespace Stores.IdentityServer4.Neo4j
{
    public interface IIdentityServer4ClientUserStore<
        TUser, 
        TClient,
        TSecret,
        TGrantType,
        TClaim,
        TCorsOrigin,
        TScope,
        TIdPRestriction,
        TProperty,
        TPostLogoutRedirectUri,
        TRedirectUri> :
        IIdentityServer4ClientStore<
            TClient,
            TSecret,
            TGrantType,
            TClaim,
            TCorsOrigin,
            TScope,
            TIdPRestriction,
            TProperty,
            TPostLogoutRedirectUri,
            TRedirectUri>,
        IDisposable
        where TUser : class
        where TClient : ClientRoot
        where TSecret : Secret
        where TGrantType : ClientGrantType
        where TClaim : ClientClaim
        where TCorsOrigin : ClientCorsOrigin
        where TScope : ClientScope
        where TIdPRestriction : ClientIDPRestriction
        where TProperty : ClientProperty
        where TPostLogoutRedirectUri : ClientPostLogoutRedirectUri
        where TRedirectUri : ClientRedirectUri

    {
        Task CreateConstraintsAsync(CancellationToken cancellationToken = default(CancellationToken));

        Task<IdentityResult> AddClientToUserAsync(TUser user, TClient client,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<IList<TClient>> GetClientsAsync(TUser user,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}