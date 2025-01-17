namespace MvdEndPoint.UnitTest
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Incoding.CQRS;
    using Incoding.Endpoint;
    using Incoding.MSpecContrib;
    using Machine.Specifications;

    [Subject(typeof(WPGenerateHttpMessageQuery))]
    public class When_wp_generate_command_with_property_changed
    {
        Establish establish = () =>
                              {
                                  var type = typeof(FakeCommand);
                                  var query = Pleasure.Generator.Invent<WPGenerateCommandQuery>(dsl => dsl.Tuning(r => r.Type, type));

                                  expected = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sample_Code_Generate", typeof(When_wp_generate_command_with_property_changed).Name));

                                  var meta = Pleasure.Generator.Invent<GetMetaFromTypeQuery.Response>(dsl => dsl.Tuning(r => r.Name, type.Name)
                                                                                                                .Tuning(s => s.IsNotifyPropertyChanged, true)
                                                                                                                .Tuning(r => r.Namespace, type.Namespace));
                                  var properties = Pleasure.ToList(Pleasure.Generator.Invent<GetPropertiesQuery.Response>(dsl => dsl.Tuning(r => r.Name, "Login")
                                                                                                                                    .Tuning(r => r.Attributes, GetPropertiesQuery.Response.OfAttributes.IsClass | GetPropertiesQuery.Response.OfAttributes.IsCanNull)
                                                                                                                                    .Tuning(r => r.Type, typeof(string).Name)),
                                                                   Pleasure.Generator.Invent<GetPropertiesQuery.Response>(dsl => dsl.Tuning(r => r.Name, "Count")
                                                                                                                                    .Tuning(r => r.Type, typeof(int).Name)
                                                                                                                                    .Tuning(r => r.Attributes, GetPropertiesQuery.Response.OfAttributes.IsCanNull)),
                                                                   Pleasure.Generator.Invent<GetPropertiesQuery.Response>(dsl => dsl.Tuning(r => r.Name, "Values")
                                                                                                                                    .Tuning(r => r.Attributes, GetPropertiesQuery.Response.OfAttributes.IsArray)
                                                                                                                                    .Tuning(r => r.Type, typeof(double).Name)));
                                  mockQuery = MockQuery<WPGenerateCommandQuery, string>
                                          .When(query)
                                          .StubQuery<GetMetaFromTypeQuery, GetMetaFromTypeQuery.Response>(dsl => dsl.Tuning(r => r.Type, type), meta)
                                          .StubQuery<GetPropertiesQuery, List<GetPropertiesQuery.Response>>(dsl => dsl.Tuning(r => r.Type, type)
                                                                                                                      .Tuning(r => r.IsCommand, meta.IsCommand)
                                                                                                                      .Tuning(r => r.Language, Language.Csharp),
                                                                                                            properties);
                              };

        Because of = () => mockQuery.Execute();

        It should_be_result = () => mockQuery.ShouldBeIsResult(s => s.ShouldEqual(expected));

        #region Fake classes

        class FakeCommand : CommandBase
        {
            protected override void Execute()
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Establish value

        static MockMessage<WPGenerateCommandQuery, string> mockQuery;

        static string expected;

        #endregion
    }
}