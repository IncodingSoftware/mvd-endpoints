﻿namespace MvdEndPoint.UnitTest
{
    #region << Using >>

    using System.Collections.Generic;
    using Incoding.CQRS;
    using Incoding.MSpecContrib;
    using Machine.Specifications;
    using MvdEndPoint.Domain;

    #endregion

    [Subject(typeof(GetUrlByTypeQuery))]
    public class When_get_url_by_type_as_query
    {
        #region Fake 

        class FakeQuery : QueryBase<string>
        {
            protected override string ExecuteResult()
            {
                return null;
            }
        }

        #endregion

        #region Establish value

        static MockMessage<GetUrlByTypeQuery, string> mockQuery;

        static string expected;

        #endregion

        Establish establish = () =>
                                  {
                                      var query = Pleasure.Generator.Invent<GetUrlByTypeQuery>(dsl => dsl.Tuning(r => r.Type, typeof(FakeQuery))
                                                                                                         .Tuning(r => r.BaseUrl, "http://localhost:48801"));
                                      expected = "http://localhost:48801/Dispatcher/Query?incType=FakeQuery&Param=%s&Param2=%s";

                                      mockQuery = MockQuery<GetUrlByTypeQuery, string>
                                              .When(query)
                                              .StubQuery(Pleasure.Generator.Invent<GetPropertiesByTypeQuery>(dsl => dsl.Tuning(r => r.Type, query.Type)),
                                                         new Dictionary<string, string>
                                                             {
                                                                     { "Param", Pleasure.Generator.String() },
                                                                     { "Param2", Pleasure.Generator.String() }
                                                             });
                                  };

        Because of = () => mockQuery.Original.Execute();

        It should_be_result = () => mockQuery.ShouldBeIsResult(expected);
    }
}