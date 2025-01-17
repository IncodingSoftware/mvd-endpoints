﻿namespace CloudIn.Domain.Endpoint
{
    #region << Using >>

    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Linq.Expressions;
    using Incoding;
    using Incoding.Data;
    using Incoding.Endpoint;
    using Incoding.Quality;
    using JetBrains.Annotations;
    using MongoDB.Bson.Serialization.Attributes;

    #endregion


    public class Message : IncEntityBase
    {
        private IList<Property> properties = new List<Property>();

        [IgnoreCompare("Auto")]
        public new virtual string Id { get; protected set; }

        public virtual string Name { get; set; }

        public virtual string Type { get; set; }

        public virtual string Description { get; set; }

        [BsonIgnore]
        public virtual IList<Property> Properties { get { return this.properties; } set { this.properties = value; } }

        public virtual Group GroupKey { get; set; }

        public virtual int? Jira { get; set; }

        public virtual string Result { get; set; }

        [UsedImplicitly, Obsolete(ObsoleteMessage.ClassNotForDirectUsage, true), ExcludeFromCodeCoverage]
        public class Map : NHibernateEntityMap<Message>
        {
            protected Map()
            {
                Table("Endpoint_Message_Tbl");
                IdGenerateByGuid(r => r.Id);
                MapEscaping(r => r.Name).Length(int.MaxValue);
                MapEscaping(r => r.Jira);
                MapEscaping(r => r.Description).Length(int.MaxValue);
                MapEscaping(r => r.Result);
                MapEscaping(r => r.Type);
                DefaultHasMany(r => r.Properties);
                DefaultReference(r => r.GroupKey);
            }
        }

        public class Property : IncEntityBase
        {
            public enum TypeOf
            {
                Response,

                Request
            }

            private string values = string.Empty;

            [UsedImplicitly, Obsolete(ObsoleteMessage.SerializeConstructor, true), ExcludeFromCodeCoverage]
            public Property()
            {
                Childrens = new List<Property>();
            }

            public Property(SyncEndpointCommand.GetEndpointsQuery.Response.Property property, TypeOf type)
            {
                Name = property.Name;
                PropertyType = property.Type.FullName;
                GenericType = property.Type.IsGenericType
                                      ? property.Type.GenericTypeArguments[0].FullName
                                      : string.Empty;
                Type = type;
                Values = property.Values;
                Childrens = property.Childrens.Select(s => new Property(s, type)).ToList();
            }

            [IgnoreCompare("Auto")]
            public new virtual string Id { get; protected set; }

            public virtual string Name { get; set; }

            public virtual Message Message { get; set; }

            public virtual string Default { get; set; }

            public virtual string Description { get; set; }

            public virtual string PropertyType { get; set; }

            public virtual string GenericType { get; set; }

            public virtual string GroupKey { get; set; }

            public virtual bool IsRequired { get; set; }

            public virtual TypeOf Type { get; set; }

            public virtual Property Parent { get; set; }

            public virtual IList<Property> Childrens { get; set; }

            public virtual List<string> Values
            {
                get { return CollectionAsString.Parse(values).ToList(); }
                set
                {
                    this.values = string.Empty;
                    CollectionAsString.Join(ref this.values, value);
                }
            }

            [UsedImplicitly, Obsolete(ObsoleteMessage.ClassNotForDirectUsage, true), ExcludeFromCodeCoverage]
            public class Map : NHibernateEntityMap<Property>
            {
                protected Map()
                {
                    Table("Endpoint_Property_Tbl");
                    IdGenerateByGuid(r => r.Id);
                    DefaultReference(r => r.Message);
                    DefaultReference(r => r.Parent).Cascade.SaveUpdate();
                    HasMany(r => r.Childrens).Cascade.AllDeleteOrphan();
                    MapEscaping(r => r.Name).CustomType("StringClob").CustomSqlType("nvarchar(max)");
                    MapEscaping(r => r.values).CustomType("StringClob").CustomSqlType("nvarchar(max)");
                    MapEscaping(r => r.Type);
                    MapEscaping(r => r.Default);
                    MapEscaping(r => r.Description).CustomType("StringClob").CustomSqlType("nvarchar(max)");
                    MapEscaping(r => r.PropertyType);
                    MapEscaping(r => r.GenericType);
                    MapEscaping(r => r.GroupKey);
                    MapEscaping(r => r.IsRequired);
                }
            }

            public class Where
            {
                public class ByMessage : Specification<Property>
                {
                    private readonly string id;

                    public ByMessage(string id)
                    {
                        this.id = id;
                    }

                    public override Expression<Func<Property, bool>> IsSatisfiedBy()
                    {
                        return property => property.Message.Id == id;
                    }
                }

                public class ByType : Specification<Property>
                {
                    private readonly TypeOf request;

                    public ByType(TypeOf request)
                    {
                        this.request = request;
                    }

                    public override Expression<Func<Property, bool>> IsSatisfiedBy()
                    {
                        return property => property.Type == this.request;
                    }
                }
            }
        }

        public class Group : IncEntityBase
        {
            [IgnoreCompare("Auto")]
            public new virtual string Id { get; protected set; }

            public virtual string Name { get; set; }

            public virtual string Description { get; set; }

            [UsedImplicitly, Obsolete(ObsoleteMessage.ClassNotForDirectUsage, true), ExcludeFromCodeCoverage]
            public class Map : NHibernateEntityMap<Group>
            {
                public Map()
                {
                    Table("Endpoint_Group_Tbl");
                    IdGenerateByGuid(r => r.Id);
                    MapEscaping(r => r.Name);
                    MapEscaping(r => r.Description).CustomType("StringClob").CustomSqlType("nvarchar(max)");
                }
            }

            public abstract class Where
            {
                public class ByName : Specification<Group>
                {
                    private readonly string name;

                    public ByName(string name)
                    {
                        this.name = name;
                    }

                    public override Expression<Func<Group, bool>> IsSatisfiedBy()
                    {
                        return group => group.Name == name;
                    }
                }
            }
        }

        public abstract class Where
        {
            public class ByFullName : Specification<Message>
            {
                private readonly string fullName;

                public ByFullName(string fullName)
                {
                    this.fullName = fullName;
                }

                public override Expression<Func<Message, bool>> IsSatisfiedBy()
                {
                    return endpoint => endpoint.Type == this.fullName;
                }
            }
        }

        public abstract class Order
        {
            public class Default : OrderSpecification<Message>
            {
                public override Action<AdHocOrderSpecification<Message>> SortedBy()
                {
                    return specification => specification.OrderBy(r => r.GroupKey.Name)
                                                         .OrderBy(r => r.Name);
                }
            }
        }
    }
}