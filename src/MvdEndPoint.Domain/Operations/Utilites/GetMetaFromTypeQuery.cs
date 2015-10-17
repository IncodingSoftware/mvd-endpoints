﻿namespace MvdEndPoint.Domain
{
    #region << Using >>

    using System;
    using System.ServiceModel;
    using Incoding.CQRS;
    using Incoding.Extensions;

    #endregion

    public class GetMetaFromTypeQuery : QueryBase<GetMetaFromTypeQuery.Response>
    {
        #region Properties

        public Type Type { get; set; }

        #endregion

        #region Nested classes

        public class Response
        {
            #region Properties

            public string Package { get; set; }

            public string Namespace { get; set; }

            public string Name { get; set; }

            #endregion
        }

        #endregion

        protected override Response ExecuteResult()
        {
            var serviceContract = Type.FirstOrDefaultAttribute<ServiceContractAttribute>();
            var @namespace = serviceContract.Namespace;
            if (string.IsNullOrWhiteSpace(@namespace))
            {
                string defNamespace = Type.Module.Name.Replace(".dll", "");
                @namespace = defNamespace;
            }
            return new Response
                   {
                           Package = "{0}.{1}".F(@namespace, Type.Name),
                           Name = Type.Name,
                           Namespace = @namespace
                   };
        }
    }
}