﻿namespace Incoding.Endpoint
{
    #region << Using >>

    using System;
    using System.Collections.Generic;
    using Incoding.CQRS;
    using Incoding.Endpoint.Operations.Code_Generate.WP;

    #endregion

    public class WPGenerateCommandQuery : QueryBase<string>
    {
        #region Properties

        public Type Type { get; set; }

        #endregion

        protected override string ExecuteResult()
        {
            var engine = new WP_Command();
            var meta = Dispatcher.Query(new GetMetaFromTypeQuery() { Type = Type });
            engine.Session = new Dictionary<string, object>()
                             {
                                     { "Name", meta.Name },
                                     { "Properties", Dispatcher.Query(new GetPropertiesQuery() { Type = Type, Language = Language.Csharp, IsCommand = meta.IsCommand }) },
                                     { "Namespace", meta.Namespace },
                                     { "IsNotifyPropertyChanged", meta.IsNotifyPropertyChanged },
                             };
            engine.Initialize();
            return engine.TransformText();
        }
    }
}