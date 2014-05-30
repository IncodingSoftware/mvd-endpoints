﻿namespace MvdEndPoint.Domain
{
    #region << Using >>

    using System;
    using System.Collections.Generic;
    using Incoding.CQRS;
    using MvdEndPoint.Domain.Operations.Code_Generate;

    #endregion

    public class ResponseCodeGenerateQuery : QueryBase<string>
    {
        #region Properties

        public Type Type { get; set; }

        #endregion

        protected override string ExecuteResult()
        {
            var dto = new Android_Dto();
            dto.Session = new Dictionary<string, object>
                              {
                                      {
                                              "Name", Dispatcher.Query(new GetNameFromTypeQuery
                                                                           {
                                                                                   Type = Type,
                                                                                   Mode = GetNameFromTypeQuery.ModeOf.Response
                                                                           })
                                      },
                                      {
                                              "Properties", Dispatcher.Query(new GetPropertiesByTypeQuery
                                                                                 {
                                                                                         Type = Type.BaseType.GenericTypeArguments[0]
                                                                                 })
                                      }
                              };
            dto.Initialize();
            return dto.TransformText();
        }
    }
}