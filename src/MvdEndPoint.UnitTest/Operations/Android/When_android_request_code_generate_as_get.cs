﻿namespace MvdEndPoint.UnitTest
{
    #region << Using >>

    using System;
    using System.Collections.Generic;
    using System.IO;
    using Incoding.CQRS;
    using Incoding.MSpecContrib;
    using Machine.Specifications;
    using MvdEndPoint.Domain;

    #endregion

    [Subject(typeof(AndroidRequestCodeGenerateQuery))]
    public class When_android_request_code_generate_as_get
    {
        #region Fake classes

        class GetCustomerQuery : QueryBase<string>
        {
            protected override string ExecuteResult()
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Establish value

        static MockMessage<AndroidRequestCodeGenerateQuery, string> mockQuery;

        static string expected;

        #endregion

        Establish establish = () =>
                              {
                                  var query = Pleasure.Generator.Invent<AndroidRequestCodeGenerateQuery>(dsl => dsl.Tuning(r => r.Type, typeof(GetCustomerQuery)));
                                  expected = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, typeof(When_android_request_code_generate_as_get).Name));

                                  var meta = Pleasure.Generator.Invent<GetMetaFromTypeQuery.Response>(dsl => dsl.Tuning(r => r.Name, "GetCustomerQuery")
                                                                                                                .Tuning(r => r.Package, "com.qabenchmarking.android.models.GetCustomerQuery")
                                                                                                                .Tuning(r => r.Namespace, "com.qabenchmarking.android.models"));
                                  mockQuery = MockQuery<AndroidRequestCodeGenerateQuery, string>
                                          .When(query)
                                          .StubQuery(Pleasure.Generator.Invent<GetMetaFromTypeQuery>(dsl => dsl.Tuning(r => r.Type, typeof(GetCustomerQuery))), 
                                                     meta)
                                          .StubQuery<GetNameFromTypeQuery, Dictionary<GetNameFromTypeQuery.ModeOf, string>>(dsl => dsl.Tuning(r => r.Type, query.Type), new Dictionary<GetNameFromTypeQuery.ModeOf, string>()
                                                                                                                                                                        {
                                                                                                                                                                           { GetNameFromTypeQuery.ModeOf.Request, "GetCustomerRequest" } 
                                                                                                                                                                        })
                                          .StubQuery(Pleasure.Generator.Invent<GetPropertiesFromTypeQuery>(dsl => dsl.Tuning(r => r.Device, DeviceOfType.Android)
                                                                                                                     .Tuning(r => r.IsCommand, meta.IsCommand)
                                                                                                                     .Tuning(r => r.Type, typeof(GetCustomerQuery))), new List<GetPropertiesFromTypeQuery.Response>
                                                                                                                                                                      {
                                                                                                                                                                              Pleasure.Generator.Invent<GetPropertiesFromTypeQuery.Response>(dsl => dsl.Tuning(r => r.Name, "Message")
                                                                                                                                                                                                                                                       .Tuning(r => r.Attributes, GetPropertiesFromTypeQuery.Response.OfAttributes.IsCanNull)
                                                                                                                                                                                                                                                       .Tuning(r => r.Type, "TheSameString")), 
                                                                                                                                                                              Pleasure.Generator.Invent<GetPropertiesFromTypeQuery.Response>(dsl => dsl.Tuning(r => r.Name, "Title")
                                                                                                                                                                                                                                                       .Empty(r => r.Attributes)
                                                                                                                                                                                                                                                       .Tuning(r => r.Type, "Number")), 
                                                                                                                                                                              Pleasure.Generator.Invent<GetPropertiesFromTypeQuery.Response>(dsl => dsl.Tuning(r => r.Name, "Ids")
                                                                                                                                                                                                                                                       .Tuning(r => r.Attributes, GetPropertiesFromTypeQuery.Response.OfAttributes.IsArray)
                                                                                                                                                                                                                                                       .Tuning(r => r.Type, "String"))
                                                                                                                                                                      });
                              };

        Because of = () => mockQuery.Execute();

        It should_be_result = () => mockQuery.ShouldBeIsResult(s => s.ShouldEqual(expected));
    }
}