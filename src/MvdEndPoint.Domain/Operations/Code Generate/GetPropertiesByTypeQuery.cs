﻿namespace MvdEndPoint.Domain
{
    #region << Using >>

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Incoding.CQRS;
    using Incoding.Extensions;

    #endregion

    public class GetPropertiesByTypeQuery : QueryBase<Dictionary<string, string>>
    {
        #region Properties

        public Type Type { get; set; }

        #endregion

        protected override Dictionary<string, string> ExecuteResult()
        {            
            return (Type.IsImplement<IEnumerable>() ? Type.GenericTypeArguments[0] : Type)
                    .GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)
                    .Where(r => r.CanWrite)
                    .Select(r => new KeyValuePair<string, string>(r.Name, Dispatcher.Query(new ConvertCSharpTypeToJavaQuery
                                                                                               {
                                                                                                       Type = r.PropertyType
                                                                                               })))
                    .ToDictionary(r => r.Key, r => r.Value);
        }
    }
}