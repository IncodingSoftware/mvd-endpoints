﻿namespace MvdEndPoint.UnitTest
{
    using Incoding.Endpoint;
    using Incoding.MSpecContrib;
    using Machine.Specifications;

    [Subject(typeof(ConvertCSharpTypeToTargetQuery))]
    public class When_conver_cs_sharp_type_to_target_wp
    {
        Establish establish = () =>
                              {
                                  ConvertCSharpTypeToTargetQuery query = Pleasure.Generator.Invent<ConvertCSharpTypeToTargetQuery>(dsl => dsl.Tuning(r => r.Language, Language.Csharp)
                                                                                                                                             .Tuning(r => r.Type, typeof(string)));
                                  expected = Pleasure.Generator.String();

                                  mockQuery = MockQuery<ConvertCSharpTypeToTargetQuery, string>
                                          .When(query)
                                          .StubQuery<ConvertCSharpTypeToTargetQuery.ToWPQuery, string>(dsl => dsl.Tuning(r => r.Type, query.Type), expected);
                              };

        Because of = () => mockQuery.Original.Execute();

        It should_be_result = () => mockQuery.ShouldBeIsResult(expected);

        #region Establish value

        static MockMessage<ConvertCSharpTypeToTargetQuery, string> mockQuery;

        static string expected;

        #endregion
    }
}