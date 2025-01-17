﻿namespace Incoding.Endpoint
{
    #region << Using >>

    using System;
    using System.Collections.Generic;
    using Incoding.CQRS;
    using Incoding.Extensions;

    #endregion

    public class IosResponseCodeGenerateQuery : QueryBase<string>
    {
        #region Properties

        public FileOfIos File { get; set; }

        public Type Type { get; set; }

        #endregion

        protected override string ExecuteResult()
        {
            bool isArray = Dispatcher.Query(new HasQueryResponseAsArrayQuery(Type));
            bool isQuery = !Dispatcher.Query(new IsCommandTypeQuery(Type));
            var session = new Dictionary<string, object>
                          {
                                  { "Name", Dispatcher.Query(new GetNameFromTypeQuery(Type))[GetNameFromTypeQuery.ModeOf.Response] }, 
                                  { "Properties", new List<GetPropertiesQuery.Response>() }, 
                                  { "IsQuery", isQuery }, 
                                  { "IsArray", isArray }
                          };

            if (isQuery)
            {
                session.Set("Properties", Dispatcher.Query(new GetPropertiesQuery
                                                           {
                                                                   Type = Type.BaseType.GenericTypeArguments[0], 
                                                                   Language = Language.ObjectiveC
                                                           }));
            }

            switch (File)
            {
                case FileOfIos.H:
                    var tmplH = new Ios_Response_h();
                    tmplH.Session = session;
                    tmplH.Initialize();
                    return tmplH.TransformText();
                case FileOfIos.M:
                    if (isQuery)
                    {
                        if (isArray)
                        {
                            var tmplMAsQueryIsArray = new Ios_Response_Query_As_Array_m();
                            tmplMAsQueryIsArray.Session = session;
                            tmplMAsQueryIsArray.Initialize();
                            return tmplMAsQueryIsArray.TransformText();
                        }
                        else
                        {
                            var tmplMAsQuery = new Ios_Response_Query_m();
                            tmplMAsQuery.Session = session;
                            tmplMAsQuery.Initialize();
                            return tmplMAsQuery.TransformText();
                        }
                    }
                    else
                    {
                        var tmplM = new Ios_Response_m();
                        tmplM.Session = session;
                        tmplM.Initialize();
                        return tmplM.TransformText();
                    }

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}