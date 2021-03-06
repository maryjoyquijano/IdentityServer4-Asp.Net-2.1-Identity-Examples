﻿using AutoMapper;

namespace StoresIdentityServer4.Neo4j.DTO.Mappers
{
    public static class Neo4JIdentityServer4ClientIdpRestrictionMappers
    {
        static Neo4JIdentityServer4ClientIdpRestrictionMappers()
        {
            Mapper = new MapperConfiguration(
                    cfg => cfg.AddProfile<
                        Neo4JIdentityServer4ClientIdpRestrictionMapperProfile
                    >())
                .CreateMapper();
        }

        internal static IMapper Mapper { get; }

        /// <summary>
        /// Maps an entity to a model.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public static string ToModel(
            this Neo4JIdentityServer4ClientIdpRestriction entity)
        {
            return Mapper.Map<string>(entity);
        }

        /// <summary>
        /// Maps a model to an entity.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public static Neo4JIdentityServer4ClientIdpRestriction ToNeo4JClientIdpRestrictionEntity(
            this string model)
        {
            return Mapper.Map<Neo4JIdentityServer4ClientIdpRestriction>(model);
        }
         
    }
}