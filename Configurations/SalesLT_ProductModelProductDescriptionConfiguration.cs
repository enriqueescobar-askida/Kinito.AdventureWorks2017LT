// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Configurations
{
    using Entities;
    using Interfaces;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    // ProductModelProductDescription
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class SalesLT_ProductModelProductDescriptionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SalesLT_ProductModelProductDescription>
    {
        public SalesLT_ProductModelProductDescriptionConfiguration()
            : this("SalesLT")
        {
        }

        public SalesLT_ProductModelProductDescriptionConfiguration(string schema)
        {
            Property(x => x.Culture).IsFixedLength();

        }
    }

}
// </auto-generated>
