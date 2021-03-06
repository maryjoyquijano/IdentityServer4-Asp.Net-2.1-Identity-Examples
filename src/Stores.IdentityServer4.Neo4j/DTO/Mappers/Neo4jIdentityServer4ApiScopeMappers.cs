﻿using AutoMapper;

namespace StoresIdentityServer4.Neo4j.DTO.Mappers
{
    public static class Neo4jIdentityServer4ApiScopeMappers
    {
        static Neo4jIdentityServer4ApiScopeMappers()
        {
            Mapper = new MapperConfiguration(
                    cfg => cfg.AddProfile<
                        Neo4JIdentityServer4ApiScopeMapperProfile
                    >())
                .CreateMapper();
        }

        internal static IMapper Mapper { get; }

        /// <summary>
        /// Maps an entity to a model.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public static IdentityServer4.Models.Scope ToModel(this Neo4jIdentityServer4ApiScope entity)
        {
            return Mapper.Map<IdentityServer4.Models.Scope>(entity);
        }

        /// <summary>
        /// Maps a model to an entity.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public static Neo4jIdentityServer4ApiScope ToNeo4jEntity(
            this IdentityServer4.Models.Scope model)
        {
            return Mapper.Map<Neo4jIdentityServer4ApiScope>(model);
        }
        /// <summary>
        /// Maps a model to an entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public static Neo4jIdentityServer4ApiScope ToNeo4jEntity(
            this StoresIdentityServer4.Neo4j.Entities.ApiScope entity)
        {
            return Mapper.Map<Neo4jIdentityServer4ApiScope>(entity);
        }
    }
}