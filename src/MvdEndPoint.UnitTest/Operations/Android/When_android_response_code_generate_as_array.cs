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

    [Subject(typeof(AndroidResponseCodeGenerateQuery))]
    public class When_android_response_code_generate_as_array
    {
        Establish establish = () =>
                              {
                                  var query = Pleasure.Generator.Invent<AndroidResponseCodeGenerateQuery>(dsl => dsl.Tuning(r => r.Type, typeof(GetCustomersQuery)));
                                  expected = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, typeof(When_android_response_code_generate_as_array).Name));

                                  mockQuery = MockQuery<AndroidResponseCodeGenerateQuery, string>
                                          .When(query)
                                          .StubQuery(Pleasure.Generator.Invent<GetMetaFromTypeQuery>(dsl => dsl.Tuning(r => r.Type, typeof(GetCustomersQuery))),
                                                     Pleasure.Generator.Invent<GetMetaFromTypeQuery.Response>(dsl => dsl.Tuning(r => r.Name, "GetCustomersQuery")
                                                                                                                        .Tuning(r => r.Package, "com.qabenchmarking.android.models.GetCustomersQuery")
                                                                                                                        .Tuning(r => r.Namespace, "com.qabenchmarking.android.models")))
                                          .StubQuery(Pleasure.Generator.Invent<GetNameFromTypeQuery>(dsl => dsl.Tuning(r => r.Mode, GetNameFromTypeQuery.ModeOf.Response)
                                                                                                               .Tuning(r => r.Type, query.Type)), "GetCustomersResponse")
                                          .StubQuery(Pleasure.Generator.Invent<GetPropertiesByTypeQuery>(dsl => dsl.Tuning(r => r.Device, DeviceOfType.Android)
                                                                                                                   .Tuning(r => r.IsCommand, false)
                                                                                                                   .Tuning(r => r.Type, typeof(List<GetCustomersQuery.Response>))), new List<GetPropertiesByTypeQuery.Response>
                                                                                                                                                                                    {
                                                                                                                                                                                            new GetPropertiesByTypeQuery.Response { Name = "Title", Type = ConvertCSharpTypeToJavaQuery.String },
                                                                                                                                                                                            new GetPropertiesByTypeQuery.Response { Name = "Number", Type = ConvertCSharpTypeToJavaQuery.Int },
                                                                                                                                                                                            new GetPropertiesByTypeQuery.Response { Name = "Type", Type = "MyEnum", IsEnum = true },
                                                                                                                                                                                            new GetPropertiesByTypeQuery.Response { Name = "CreateDt", Type = "java.util.Date", IsDateTime = true },
                                                                                                                                                                                            new GetPropertiesByTypeQuery.Response { Name = "Ids", Type = "String", IsArray = true }
                                                                                                                                                                                    });
                              };

        Because of = () => mockQuery.Original.Execute();

        It should_be_result = () => mockQuery.ShouldBeIsResult(s => s.ShouldEqual(expected));

        #region Fake classes

        class GetCustomersQuery : QueryBase<List<GetCustomersQuery.Response>>
        {
            protected override List<Response> ExecuteResult()
            {
                throw new NotImplementedException();
            }

            #region Nested classes

            public class Response { }

            #endregion
        }

        #endregion

        #region Establish value

        static MockMessage<AndroidResponseCodeGenerateQuery, string> mockQuery;

        static string expected;

        #endregion
    }
}